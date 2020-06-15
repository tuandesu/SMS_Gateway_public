using BusinessObjects.Supports;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Services
{
    public class SendSMS
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public async Task<int> SendSMS_CSKHAsync(string url, long id, string user, string pass, string brandName, string phone, string content)
        {
            string result = String.Empty;

            try
            {
                IDictionary<string, string> smsCSKH = new Dictionary<string, string>() {
                    { "id", id.ToString() },
                    { "username", user },
                    { "password", pass },
                    { "brandname", brandName },
                    { "phone", phone },
                    { "message", content }
            };

                HttpResponseMessage response = await CallAPIAsync(url, JsonConvert.SerializeObject(smsCSKH));

                if (response != null)
                {
                    result = await response.Content.ReadAsStringAsync();
                    logger.Info(AppConst.A("SendSMS_CSKHAsync: ", url, id, user, pass, brandName, phone, content, result));

                    Dictionary<string, dynamic> dict = CommonUtil.ConvertJsonToObject(result);
                    if (dict != null && dict["code"] == 0)
                    {
                        return AppConst.SYS_ERR_OK;
                    }
                    else 
                    {
                        return AppConst.SYS_ERR_UNKNOW;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("SendSMS_CSKHAsync - error: ", url, id, user, pass, brandName, phone, content, result, ex));
            }

            return AppConst.SYS_ERR_UNKNOW;
        }

        private async Task<HttpResponseMessage> CallAPIAsync(string url, string content)
        {
            try
            {
                using (HttpClient http = new HttpClient())
                {
                    HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
                    httpRequest.Content = new StringContent(content, Encoding.UTF8, "application/json");
                    return await http.SendAsync(httpRequest);
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("CallAPIAsync", url, content, ex));
                return null;
            }
        }
    }
}
