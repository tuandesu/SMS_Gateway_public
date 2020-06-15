using BusinessObjects.Models;
using BusinessObjects.Supports;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessObjects.Services
{
    public class ServiceHelper
    {
        private static readonly string BASE_URL = "http://api.sponsorx.viettel.vn:8888/datasponsor/";
        private static readonly string BASE_URL_GPC = "http://mydata.com.vn/";
        private static readonly string ADDON_METHOD = "reg_addon";
        private static readonly string DATA_METHOD = "add_data";
        private static readonly string PLUS_DATA = "plus_data";
        private static readonly string GET_BALANCE = "get_balance";
        private static readonly string CHECK_BALANCE_METHOD = "wallet/balance";
        private static readonly string CHECK_DATA_METHOD = "add_data/check";
        private static readonly string CHECK_ADDON_METHOD = "reg_addon/check";
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string CheckBalance(AccountDataModel account)
        {
            var parameter = GetInputDataCheckParams(account);

            var input = SecurityUtils.EncryptInputWithAES(parameter);
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            account.Data = HttpUtility.UrlEncode(data);
            account.signature = HttpUtility.UrlEncode(signature);
            logger.Error("input: " + input + "data: " + data + "signature: " + signature);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataCheckParams(account);

                HttpResponseMessage responseMessage = httpClient.GetAsync(CHECK_BALANCE_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsStringAsync().Result;
                }
            }

            return null;
        }

        public CheckResponseModel CheckRegDataToString(AccountDataModel model)
        {
            var parameter = GetInputDataCheckParams(model);

            var input = SecurityUtils.EncryptInputWithAES(parameter);
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            model.Data = HttpUtility.UrlEncode(data);
            model.signature = HttpUtility.UrlEncode(signature);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataCheckParams(model);

                HttpResponseMessage responseMessage = httpClient.GetAsync(CHECK_DATA_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    string result = responseMessage.Content.ReadAsStringAsync().Result;
                    CheckResponseModel checkResponse = JsonConvert.DeserializeObject<CheckResponseModel>(result);
                    return checkResponse;
                }
            }

            return null;
        }

        public string CheckRegAddOnToString(AccountDataModel model)
        {
            var parameter = GetInputDataCheckParams(model);

            var input = SecurityUtils.EncryptInputWithAES(parameter);
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            model.Data = HttpUtility.UrlEncode(data);
            model.signature = HttpUtility.UrlEncode(signature);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataCheckParams(model);

                HttpResponseMessage responseMessage = httpClient.GetAsync(CHECK_ADDON_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsStringAsync().Result;
                }
            }

            return null;
        }

        public RegisterResponseModel RegisterData(DataRegisterModel dataRegister)
        {
            var parameter = GetInputDataRegParam(dataRegister);

            var input = SecurityUtils.EncryptInputWithAES(parameter);
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            dataRegister.Data = HttpUtility.UrlEncode(data);
            dataRegister.signature = HttpUtility.UrlEncode(signature);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataRegParam(dataRegister);

                HttpResponseMessage responseMessage = httpClient.GetAsync(DATA_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    RegisterResponseModel response = JsonConvert.DeserializeObject<RegisterResponseModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    return response;
                }
            }

            return null;
        }

        public string RegDataToString(DataRegisterModel model)
        {
            model.TransID = Guid.NewGuid().ToString();
            var input = SecurityUtils.EncryptInputWithAES(GetInputDataRegParam(model));
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            model.Data = HttpUtility.UrlEncode(data);
            model.signature = HttpUtility.UrlEncode(signature);
            var ReqParams = DATA_METHOD + GetOutputDataRegParam(model);
            //Console.WriteLine("url: {0}", BASE_URL + ReqParams);
            //HttpResponseMessage responseMessage = httpClient.GetAsync(ReqParams).Result;
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var response = responseMessage.Content.ReadAsStringAsync().Result;
            //    //Console.WriteLine("response: {0}", response);
            //    return response;
            //}
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataRegParam(model);

                HttpResponseMessage responseMessage = httpClient.GetAsync(DATA_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    var response = responseMessage.Content.ReadAsStringAsync().Result;
                    return response;
                }
            }
            return null;
        }

        public string RegAddOnToString(DataRegisterModel model)
        {
            model.TransID = Guid.NewGuid().ToString();
            var input = SecurityUtils.EncryptInputWithAES(GetInputDataRegParam(model));
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            model.Data = HttpUtility.UrlEncode(data);
            model.signature = HttpUtility.UrlEncode(signature);
            var ReqParams = ADDON_METHOD + GetOutputDataRegParam(model);
            //Console.WriteLine("url: {0}", BASE_URL + ReqParams);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataRegParam(model);

                HttpResponseMessage responseMessage = httpClient.GetAsync(ADDON_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    var response = responseMessage.Content.ReadAsStringAsync().Result;
                    return response;
                }
            }
            return null;
        }

        public RegisterResponseModel RegisterAddOn(DataRegisterModel dataRegister)
        {
            var parameter = GetInputDataRegParam(dataRegister);

            var input = SecurityUtils.EncryptInputWithAES(parameter);
            var data = SecurityUtils.EncryptInputWithPublicDS(input);
            var signature = SecurityUtils.SignatureWithPrivateCP(data);
            dataRegister.Data = HttpUtility.UrlEncode(data);
            dataRegister.signature = HttpUtility.UrlEncode(signature);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var outputParams = GetOutputDataRegParam(dataRegister);

                HttpResponseMessage responseMessage = httpClient.GetAsync(ADDON_METHOD + outputParams).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    RegisterResponseModel response = JsonConvert.DeserializeObject<RegisterResponseModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    return response;
                }
            }
            return null;
        }

        public string GetInputDataRegParam(DataRegisterModel model)
        {
            var output = "password=" + model.Password
                + "&msisdn=" + model.Msisdn
                + "&tranid=" + model.TransID
                + "&reqtime=" + ((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)
                + "&cpCode=" + model.CpCode
                + "&dataPack=" + model.DataPack;
            return output;
        }

        public string GetOutputDataRegParam(DataRegisterModel model)
        {
            var output = "?msisdn=" + model.Msisdn
                + "&tranID=" + model.TransID
                + "&cpCode=" + model.CpCode
                + "&subCpCode=" + model.SubCpCode
                + "&dataPack=" + model.DataPack
                + "&data=" + model.Data
                + "&signature=" + model.signature;
            return output;
        }

        public string GetInputDataCheckParams(AccountDataModel model)
        {
            var output = "password=" + model.Password
                + "&tranid=" + model.TransID
                + "&reqtime=" + ((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)
                + "&cpCode=" + model.CpCode;
            return output;
        }

        public string GetOutputDataCheckParams(AccountDataModel model)
        {
            var output = "?tranID=" + model.TransID
                + "&cpCode=" + model.CpCode
                + "&data=" + model.Data
                + "&signature=" + model.signature;
            return output;
        }

        public string GetInputDataRegParamGPC(DataRegisterGPCModel model)
        {
            var output = PLUS_DATA + "#"
                + model.user_name + "#"
                + model.tranId + "#"
                + model.msisdn + "#"
                + model.service_code + "#"
                + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "#"
                + model.orderId;
            return output;
        }

        public string GetOutputDataRegParamGPC(DataRegisterGPCModel model)
        {
            var output = "&msisdn=" + model.msisdn
                + "&user_name=" + model.user_name
                + "&trandId=" + model.tranId
                + "&requestTime=" + DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds
                + "&service_code=" + model.service_code
                + "&authKey=" + model.authKey;
            return output;
        }



        public UserLoginModel LoginVNPT(string path, string userName, string password)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL_GPC);
                IDictionary<string, string> param = new Dictionary<string, string>() {
                    { "user_name", userName },
                    { "password", CreateMd5(password) }
                };

                HttpRequestMessage resquestMessage = new HttpRequestMessage(HttpMethod.Post, path);
                resquestMessage.Content = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = httpClient.PostAsync(path, resquestMessage.Content).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    UserLoginModel user = JsonConvert.DeserializeObject<UserLoginModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    return user;
                }
            }

            return null;
        }

        public ResponsedGPCModel RegisterData(DataRegisterGPCModel dataRegister, string token)
        {
            var parameter = GetInputDataRegParamGPC(dataRegister);
            var data = SecurityUtils.Encryption_VNPT(parameter);
            dataRegister.authKey = data;

            IDictionary<string, string> param = new Dictionary<string, string>() {
                { "msisdn", dataRegister.msisdn },
                { "user_name", dataRegister.user_name },
                { "transId", dataRegister.tranId },
                { "requestTime", dataRegister.requestTime },
                { "service_code", dataRegister.service_code },
                { "authKey", dataRegister.authKey },
                { "orderId", dataRegister.orderId }
            };
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL_GPC);
                //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                HttpRequestMessage resquestMessage = new HttpRequestMessage(HttpMethod.Post, "api/rest/user/" + PLUS_DATA);
                resquestMessage.Content = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = httpClient.PostAsync("api/rest/user/" + PLUS_DATA, resquestMessage.Content).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    ResponsedGPCModel response = JsonConvert.DeserializeObject<ResponsedGPCModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    return response;
                }
            }

            return null;
        }

        public string CreateMd5(string input)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }

        public BalanceGPCModel CheckBalanceGPC(string user_name, string token)
        {
            IDictionary<string, string> param = new Dictionary<string, string>() {
                    { "user_name", user_name }
                };
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL_GPC);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                HttpRequestMessage resquestMessage = new HttpRequestMessage(HttpMethod.Post, "api/rest/user/" + GET_BALANCE);
                resquestMessage.Content = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = httpClient.PostAsync("api/rest/user/" + GET_BALANCE, resquestMessage.Content).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    BalanceGPCModel user = JsonConvert.DeserializeObject<BalanceGPCModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    return user;
                }
                else if (responseMessage.ReasonPhrase == "Unauthorized")
                {
                    BalanceGPCModel user = new BalanceGPCModel();
                    user.error_code = -1;
                    return user;
                }
            }

            return null;
        }
    }
}
