using BusinessObjects.Models;
using BusinessObjects.Supports;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Services
{
    public class Vmg2Service
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">http://api.brandsms.vn:8018/api/SMSBrandname</param>
        /// <param name="auth"></param>
        /// <param name="tranId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<int> SendSMS_CSKHAsync(string url, string auth, string to, string telco, int type, string from, string message, string scheduled, string requestId, int useUnicode)
        {
            string result = String.Empty;

            try
            {
                IDictionary<string, string> smsCSKH = new Dictionary<string, string>() {
                    { "to", to },
                    //{ "telco", telco },
                    { "type", type.ToString()},
                    { "from", from},
                    { "message", message },
                    { "scheduled", scheduled },
                    { "requestId", requestId },
                    { "useUnicode", useUnicode.ToString() }
                };

                HttpResponseMessage response = await CallAPIAsync(url, auth, JsonConvert.SerializeObject(smsCSKH));

                if (response != null)
                {
                    result = await response.Content.ReadAsStringAsync();
                    logger.Info(AppConst.A("SendSMS_CSKHAsync", result));

                    Dictionary<string, dynamic> dict = CommonUtil.ConvertJsonToObject(result);
                    if (dict != null && dict["errorCode"] == "000")
                    {
                        return AppConst.SYS_ERR_OK;
                    }
                    else if (dict != null)
                    {
                        return Convert.ToInt32(dict["errorCode"]);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("SendSMS_CSKHAsync", url, auth, to, telco, type, from, message, scheduled, requestId, useUnicode, ex));
            }

            return AppConst.SYS_ERR_UNKNOW;
        }

        public async Task<IDictionary<string, object>> SendSMS_QCAsync(string url, string auth, string sender, string msg, string[] listPhone, string time_send, string smsId, short unicode, short type)
        {
            IDictionary<string, object> resultData = new Dictionary<string, object>();
            resultData.Add(AppConst.ERR_CODE, AppConst.SYS_MSG_EXCEPTION);
            resultData.Add(AppConst.ERR_CODE_PARTNER, String.Empty);
            resultData.Add(AppConst.RECEIVE_RESULT, AppConst.SYS_MSG_EXCEPTION);

            try
            {
                IDictionary<string, object> smsQC = new Dictionary<string, object>() {
                    { "to", listPhone },
                    { "from", sender },
                    { "message", msg },
                    { "scheduled", time_send },
                    { "requestId", smsId },
                    { "useUnicode", unicode },
                    { "type", type }
                };

                HttpResponseMessage response = await CallAPIAsync(url, auth, JsonConvert.SerializeObject(smsQC));

                if (response != null)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    logger.Info(AppConst.A("SendSMS_QCAsync", url, auth, sender, msg, message));

                    if (!String.IsNullOrEmpty(message))
                    {
                        Dictionary<string, dynamic> dict = CommonUtil.ConvertJsonToObject(message);
                        if (dict != null && dict["errorCode"] == "000")
                        {
                            resultData[AppConst.ERR_CODE] = AppConst.SYS_ERR_OK;
                            resultData[AppConst.ERR_CODE_PARTNER] = dict["errorCode"];
                            resultData[AppConst.RECEIVE_RESULT] = dict["referentId"];
                        }
                        else if (dict != null)
                        {
                            resultData[AppConst.ERR_CODE] = AppConst.SYS_ERR_UNKNOW;
                            resultData[AppConst.ERR_CODE_PARTNER] = dict["errorCode"];
                            resultData[AppConst.RECEIVE_RESULT] = dict["referentId"];
                        }
                        //SouthReceiveQCModel southReceiveQC = JsonConvert.DeserializeObject<SouthReceiveQCModel>(message);

                        //if (southReceiveQC.Status.Equals("1"))
                        //{
                        //    resultData[AppConst.ERR_CODE] = AppConst.SYS_ERR_OK;
                        //    resultData[AppConst.ERR_CODE_PARTNER] = southReceiveQC.Status;
                        //    resultData[AppConst.RECEIVE_RESULT] = southReceiveQC.CampaignId;
                        //}
                        //else if (southReceiveQC.Status.Equals("0"))
                        //{
                        //    resultData[AppConst.ERR_CODE] = AppConst.SYS_ERR_UNKNOW;
                        //    resultData[AppConst.ERR_CODE_PARTNER] = southReceiveQC.Code;
                        //    resultData[AppConst.RECEIVE_RESULT] = message;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("SendSMS_CSKHAsync", url, auth, sender, msg, time_send, smsId, unicode, type, ex));
                resultData[AppConst.ERR_CODE] = AppConst.SYS_MSG_EXCEPTION;
                resultData[AppConst.ERR_CODE_PARTNER] = String.Empty;
                resultData[AppConst.RECEIVE_RESULT] = AppConst.SYS_MSG_EXCEPTION;
            }

            return resultData;
        }

        private async Task<HttpResponseMessage> CallAPIAsync(string url, string auth, string content)
        {
            try
            {
                using (HttpClient http = new HttpClient())
                {
                    HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
                    httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpRequest.Content = new StringContent(content, Encoding.UTF8, "application/json");
                    httpRequest.Headers.Add("token", auth);
                    return await http.SendAsync(httpRequest);
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("CallAPIAsync", url, auth, content, ex));
                return null;
            }
        }
    }
}
