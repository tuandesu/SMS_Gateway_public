using GWSendMT.DataAccess;
using GWSendMT.Models;
using GWSendMT.Supports;
using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GWSendMT.Controllers
{

    [ApiController]
    public class SendSMSController : ControllerBase
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "API SMS BrandName Conek - v3.0" };
        }

        [HttpPost]
        [Route("[controller]")]
        public async Task<IActionResult> SendSMSAsync([FromBody] SmsModel sms)
        {
            try
            {
                logger.Info(Utils.A("SendSMS", JsonConvert.SerializeObject(sms)));

                #region Check validate input
                if (String.IsNullOrEmpty(sms.brandname) || String.IsNullOrEmpty(sms.phone) || String.IsNullOrEmpty(sms.message) || String.IsNullOrEmpty(sms.username) || String.IsNullOrEmpty(sms.password))
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "2",
                        message = "Input invalid"
                    }));
                }
                #endregion

                #region Check username & password
                AccountModel account = JsonConvert.DeserializeObject<AccountModel>(RedisHelper.Get(String.Format("ACCOUNTS:{0}", sms.username)));
                if (!account.PASSWORD.Equals(sms.password))
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "3",
                        message = "Username or password invalid"
                    }));
                }
                #endregion

                #region Check account active
                if (account.IS_ACTIVE != 1)
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "4",
                        message = "Account not active"
                    }));
                }
                #endregion

                #region Check mobile number
                sms.phone = Utils.AddPhone84(sms.phone);
                sms.telco = Utils.GetTelco(sms.phone);
                if (String.IsNullOrEmpty(sms.telco))
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "5",
                        message = "Mobile number invalid"
                    }));
                }
                #endregion

                #region Check brandname by account
                object[] kvAccountSender = new object[] { account.ACCOUNT_ID, sms.brandname, AppConst.SMS_TYPE_CSKH };
                IDictionary<string, object> resultAccountSender = (new DapperHelper()).GetAccountSender(AppConfig.API_GET_ACCOUNT_SENDER, kvAccountSender);
                string json = JsonConvert.SerializeObject(resultAccountSender[AppConst.DATA], Formatting.Indented);
                IList<SenderModel> lstSender = JsonConvert.DeserializeObject<IList<SenderModel>>(json);
                if (lstSender.Count == 0)
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "8",
                        message = "Brand name is not active by account"
                    }));
                }
                #endregion

                #region Check exists mapping 
                object[] kvMapping = new object[] { account.ACCOUNT_ID, lstSender[0].sender_id, sms.telco, AppConst.SMS_TYPE_CSKH };
                IDictionary<string, object> resultMapping = (new DapperHelper()).GetMappingByTelco(AppConfig.API_GET_PARTNER_SENDER_BY_TELCO, kvMapping);
                string jsonMap = JsonConvert.SerializeObject(resultMapping[AppConst.DATA], Formatting.Indented);
                IList<SenderModel> lstMapp = JsonConvert.DeserializeObject<IList<SenderModel>>(jsonMap);
                if (lstMapp.Count == 0)
                {
                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                    {
                        phone = sms.phone,
                        code = "9",
                        message = "Telco " + sms.telco + " is not active"
                    }));
                }
                #endregion

                sms.message = Utils.RemoveVietnameseSigns(sms.message);
                sms.sms_count = Utils.GetCountSms(sms.message);
                DateTime currentDate = DateTime.Now;
                sms.sendtime = currentDate.ToString(AppConst.DATE_FORMAT_TEMPLATE_4);
                ReturnModel result = new ReturnModel();

                //check quota
                object[] keyValues = new object[] { account.ACCOUNT_ID, AppConst.SMS_TYPE_CSKH };
                IDictionary<string, object> result1 = (new DapperHelper()).GetQuotaByAccount(AppConfig.API_GET_QUOTA_REMAIN, keyValues);
                json = JsonConvert.SerializeObject(result1[AppConst.DATA], Formatting.Indented);
                IList<AccountCimastModel> quota = JsonConvert.DeserializeObject<IList<AccountCimastModel>>(json);
                bool checkPayment = false;
                if (quota[0].PAYMENT_TYPE == 1 && quota.Count > 0)
                {
                    AccountCimastModel quotaAccount = quota[0];
                    var quota_remain = quotaAccount.VOL != null ? quotaAccount.VOL : 0;
                    if (quota_remain == 0 || sms.sms_count > quota_remain)
                    {
                        checkPayment = true;
                        return Ok(JsonConvert.SerializeObject(new ReturnModel()
                        {
                            phone = sms.phone,
                            code = "7",
                            message = "The account is not enough quota."
                        }));
                    }

                    // trừ quỹ tin
                    await (new DapperHelper()).UpdateQuota(AppConfig.API_UPDATE_QUOTA, account.ACCOUNT_ID, AppConst.SMS_TYPE_CSKH, sms.sms_count);
                }
                if (!checkPayment || quota[0].PAYMENT_TYPE == 2)
                {
                    string sendTime = RedisHelper.Get(string.Format("PARTNER_CHECK_LOOP:{0},{1},{2},{3},{4}", account.ACCOUNT_ID, lstSender[0].sender_id, sms.phone, sms.message, sms.telco));
                    if ((!string.IsNullOrEmpty(sendTime) && currentDate.AddMinutes(-Convert.ToDouble(AppConst.TIME_CHECK_LOOP)) > Convert.ToDateTime(sendTime)) || string.IsNullOrEmpty(sendTime))
                    {
                        // Insert sms
                        object[] values = new object[] { account.ACCOUNT_ID, Convert.ToInt64(lstSender[0].sender_id), AppConst.SMS_TYPE_CSKH, sms.message, sms.sms_count, sms.phone, sms.telco, sms.sendtime, String.Empty, String.Empty, 0, sms.id, AppConst.VIA_SMS_API };
                        result = await (new DapperHelper()).InsertSmsAsync(AppConfig.API_POST_SMS, values);
                        if (result.code != "0")
                        {
                            //cộng trả lại
                            int count = 0 - sms.sms_count;
                            result = await (new DapperHelper()).UpdateQuota(AppConfig.API_UPDATE_QUOTA, account.ACCOUNT_ID, AppConst.SMS_TYPE_CSKH, count);
                            if (result.code != "0")
                            {
                                return Ok(JsonConvert.SerializeObject(new ReturnModel()
                                {
                                    phone = sms.phone,
                                    code = "1",
                                    message = "System exception."
                                }));
                            }
                        }

                        RedisHelper.Set(string.Format("PARTNER_CHECK_LOOP:{0},{1},{2},{3},{4}", account.ACCOUNT_ID, lstSender[0].sender_id, sms.phone, sms.message, sms.telco), currentDate.ToString());
                    }
                    else
                    {
                        if (account.IS_SEND_SMS_LOOP == 1)
                        {
                            // Insert sms
                            object[] values = new object[] { account.ACCOUNT_ID, lstSender[0].sender_id, AppConst.SMS_TYPE_CSKH, sms.message, String.Empty, sms.sms_count, sms.phone, sms.telco, currentDate.AddMinutes(Convert.ToDouble(AppConst.TIME_CHECK_LOOP)).ToString(AppConst.DATE_FORMAT_TEMPLATE_4), String.Empty, String.Empty, 0, sms.id, AppConst.VIA_SMS_API };
                            result = await (new DapperHelper()).InsertSmsAsync(AppConfig.API_POST_SMS, values);
                            if (result.code != "0")
                            {
                                //cộng trả lại
                                int count = 0 - sms.sms_count;
                                result = await (new DapperHelper()).UpdateQuota(AppConfig.API_UPDATE_QUOTA, account.ACCOUNT_ID, AppConst.SMS_TYPE_CSKH, count);
                                if (result.code != "0")
                                {
                                    return Ok(JsonConvert.SerializeObject(new ReturnModel()
                                    {
                                        phone = sms.phone,
                                        code = "1",
                                        message = "System exception."
                                    }));
                                }
                            }

                            RedisHelper.Set(string.Format("PARTNER_CHECK_LOOP:{0},{1},{2},{3},{4}", account.ACCOUNT_ID, lstSender[0].sender_id, sms.phone, sms.message, sms.telco), currentDate.ToString());
                        }
                        else
                        {
                            return Ok(JsonConvert.SerializeObject(new ReturnModel()
                            {
                                phone = sms.phone,
                                code = "6",
                                message = "Phone send sms is loop"
                            }));
                        }
                    }
                }

                return Ok(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                logger.Error(Utils.A("SendSMS", JsonConvert.SerializeObject(sms), ex));
                return Ok(JsonConvert.SerializeObject(new ReturnModel()
                {
                    phone = sms.phone,
                    code = "1",
                    message = "System exception"
                }));
            }
        }

    }
}
