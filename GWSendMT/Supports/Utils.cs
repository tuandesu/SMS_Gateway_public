using GWSendMT.DataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GWSendMT.Supports
{
    public class Utils
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string A(string logString, params object[] logParams)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(logString).Append(".:");

            foreach (object s in logParams)
            {
                sb.Append(" [").Append(s).Append("]");
            }

            return sb.ToString();
        }

        public static IDictionary<string, string> ServiceReturn(string err_code, string err_message)
        {
            return new Dictionary<string, string>()
            {
                { AppConst.ERR_CODE, err_code },
                { AppConst.ERR_MESSAGE, err_message }
            };
        }

        public static string GetPhoneNew(string phone)
        {
            string phoneNew = String.Empty;
            string b = String.Empty;

            if ((phone.Length != 12 && phone.StartsWith("841")))
            {
                return phoneNew;
            }

            if (phone.Length == 12)
            {
                b = phone.Substring(0, 5);
            }

            switch (b)
            {
                case "84120":
                    phoneNew = "8470" + phone.Substring(5);
                    break;
                case "84121":
                    phoneNew = "8479" + phone.Substring(5);
                    break;
                case "84122":
                    phoneNew = "8477" + phone.Substring(5);
                    break;
                case "84126":
                    phoneNew = "8476" + phone.Substring(5);
                    break;
                case "84128":
                    phoneNew = "8478" + phone.Substring(5);
                    break;
                case "84123":
                    phoneNew = "8483" + phone.Substring(5);
                    break;
                case "84124":
                    phoneNew = "8484" + phone.Substring(5);
                    break;
                case "84125":
                    phoneNew = "8485" + phone.Substring(5);
                    break;
                case "84127":
                    phoneNew = "8481" + phone.Substring(5);
                    break;
                case "84129":
                    phoneNew = "8482" + phone.Substring(5);
                    break;
                case "84162":
                    phoneNew = "8432" + phone.Substring(5);
                    break;
                case "84163":
                    phoneNew = "8433" + phone.Substring(5);
                    break;
                case "84164":
                    phoneNew = "8434" + phone.Substring(5);
                    break;
                case "84165":
                    phoneNew = "8435" + phone.Substring(5);
                    break;
                case "84166":
                    phoneNew = "8436" + phone.Substring(5);
                    break;
                case "84167":
                    phoneNew = "8437" + phone.Substring(5);
                    break;
                case "84168":
                    phoneNew = "8438" + phone.Substring(5);
                    break;
                case "84169":
                    phoneNew = "8439" + phone.Substring(5);
                    break;
                case "84188":
                    phoneNew = "8458" + phone.Substring(5);
                    break;
                case "84186":
                    phoneNew = "8456" + phone.Substring(5);
                    break;
                case "84199":
                    phoneNew = "8459" + phone.Substring(5);
                    break;
                default:
                    phoneNew = phone;
                    break;
            }

            return phoneNew;
        }

        public static string GetTelco(string phone)
        {
            try
            {
                if (!string.IsNullOrEmpty(phone))
                {
                    if (!String.IsNullOrEmpty(phone))
                    {
                        string telco = RedisHelper.Get(String.Format("PHONE_CHANGE_TELCO:{0}", phone));
                        if (!String.IsNullOrEmpty(telco))
                        {
                            return telco;
                        }
                    }

                    string a = String.Empty;
                    string b = String.Empty;

                    if (phone.Length > 5)
                    {
                        if (phone.IndexOf("84") == 0)
                        {
                            a = "0" + phone.Substring(2, 2);
                            b = "0" + phone.Substring(2, 3);
                        }
                        else
                        {
                            a = phone.Substring(0, 3);
                            b = phone.Substring(0, 4);
                        }
                    }
                    if (phone.IndexOf("84") == 0)
                    {
                        if (phone.Length == 11) phone = "0" + phone.Substring(0, 9);
                        if (phone.Length == 12) phone = "0" + phone.Substring(0, 10);
                    }

                    List<string> lst_viettel = new List<string> { "086", "096", "097", "098", "032", "033", "034", "035", "036", "037", "038", "039" };
                    List<string> lst_mobi = new List<string> { "089", "090", "093", "070", "079", "077", "076", "078" };
                    List<string> lst_vina = new List<string> { "088", "091", "094", "083", "084", "085", "081", "082" };
                    List<string> lst_vnMobile = new List<string> { "092", "052", "056", "058" };
                    List<string> lst_gMobile = new List<string> { "099", "059" };

                    if (phone.Length != 10)
                        return String.Empty;
                    if (lst_viettel.Contains(a) || lst_viettel.Contains(b))
                        return AppConst.VIETTEL;
                    if (lst_mobi.Contains(a) || lst_mobi.Contains(b))
                        return AppConst.VMS;
                    if (lst_vina.Contains(a) || lst_vina.Contains(b))
                        return AppConst.GPC;
                    if (lst_vnMobile.Contains(a) || lst_vnMobile.Contains(b))
                        return AppConst.VNM;
                    if (lst_gMobile.Contains(a) || lst_gMobile.Contains(b))
                        return AppConst.GTEL;

                    return String.Empty;
                }
                else
                {
                    logger.Error(A("GetTelco", "Số điện thoại rỗng"));
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error(A("GetTelco", ex));
                return String.Empty;
            }
        }

        public static string AddPhone84(string phone)
        {
            try
            {
                #region check 10 số đầu 0
                if (phone.IndexOf("84") != 0 && phone.Length == 10)
                    return "84" + phone.Substring(1, phone.Length - 1);
                #endregion
                #region check 11 số đầu 0
                else if (phone.Length == 11 && phone.IndexOf("0") == 0)
                {
                    #region check mạng Viettel
                    if (phone.IndexOf("0162") == 0 || phone.IndexOf("0163") == 0 || phone.IndexOf("0164") == 0 ||
                        phone.IndexOf("0165") == 0 || phone.IndexOf("0166") == 0 || phone.IndexOf("0167") == 0 ||
                        phone.IndexOf("0168") == 0 || phone.IndexOf("0169") == 0)
                        return "843" + phone.Substring(3, phone.Length - 3);
                    #endregion
                    #region check mạng Mobifone
                    else if (phone.IndexOf("0120") == 0) return "8470" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0121") == 0) return "8479" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0122") == 0) return "8477" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0126") == 0) return "8476" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0128") == 0) return "8478" + phone.Substring(4, phone.Length - 4);
                    #endregion
                    #region check mạng Vinaphone
                    else if (phone.IndexOf("0123") == 0) return "8483" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0124") == 0) return "8484" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0125") == 0) return "8485" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0127") == 0) return "8481" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0129") == 0) return "8482" + phone.Substring(4, phone.Length - 4);
                    #endregion
                    #region check mạng Vietnammobile
                    else if (phone.IndexOf("0186") == 0) return "8456" + phone.Substring(4, phone.Length - 4);
                    else if (phone.IndexOf("0188") == 0) return "8458" + phone.Substring(4, phone.Length - 4);
                    #endregion
                    #region check mạng GMobile
                    else if (phone.IndexOf("0199") == 0) return "8459" + phone.Substring(4, phone.Length - 4);
                    #endregion
                    else return phone;
                }
                #endregion
                #region check 11 số đầu 84
                else if (phone.Length == 12 && phone.IndexOf("84") == 0)
                {
                    #region check mạng Viettel
                    if (phone.IndexOf("84162") == 0 || phone.IndexOf("84163") == 0 || phone.IndexOf("84164") == 0 ||
                        phone.IndexOf("84165") == 0 || phone.IndexOf("84166") == 0 || phone.IndexOf("84167") == 0 ||
                        phone.IndexOf("84168") == 0 || phone.IndexOf("84169") == 0)
                        return "843" + phone.Substring(4, phone.Length - 4);
                    #endregion
                    #region check mạng Mobifone
                    else if (phone.IndexOf("84120") == 0) return "8470" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84121") == 0) return "8479" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84122") == 0) return "8477" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84126") == 0) return "8476" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84128") == 0) return "8478" + phone.Substring(5, phone.Length - 5);
                    #endregion
                    #region check mạng Vinaphone
                    else if (phone.IndexOf("84123") == 0) return "8483" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84124") == 0) return "8484" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84125") == 0) return "8485" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84127") == 0) return "8481" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84129") == 0) return "8482" + phone.Substring(5, phone.Length - 5);
                    #endregion
                    #region check mạng Vietnammobile
                    else if (phone.IndexOf("84186") == 0) return "8456" + phone.Substring(5, phone.Length - 5);
                    else if (phone.IndexOf("84188") == 0) return "8458" + phone.Substring(5, phone.Length - 5);
                    #endregion
                    #region check mạng GMobile
                    else if (phone.IndexOf("84199") == 0) return "8459" + phone.Substring(5, phone.Length - 5);
                    #endregion
                    else return phone;
                }
                #endregion
                else if (phone.Length == 9)
                    return "84" + phone;
                return phone;
            }
            catch (Exception ex)
            {
                logger.Error("AddPhone84", ex);
                return phone;
            }
        }

        public static int GetCountSms(string text)
        {
            if (String.IsNullOrEmpty(text)) return 0;
            if (text.Length < 161) return 1;
            else if (text.Length > 160 && text.Length < 307) return 2;
            else if (text.Length > 306 && text.Length < 460) return 3;
            else if (text.Length > 459 && text.Length < 613) return 4;
            else return 0;
        }

        public static string RemoveVietnameseSigns(string text)
        {
            string[] VietnameseSigns = new string[] {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ"
            };

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    text = text.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }

            text = Regex.Replace(text.Replace("“", "\"").Replace("”", "\""), "[@#$%^*]", "", RegexOptions.Compiled);
            if (String.IsNullOrWhiteSpace(text)) return text;
            return new string(text.Normalize(NormalizationForm.FormD).Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray()).Normalize(NormalizationForm.FormC);
        }

        public static string FormatDatetimeToString(string input, string templateIn, string templateOut = AppConst.DATE_FORMAT_TEMPLATE_2)
        {
            try
            {
                if (!String.IsNullOrEmpty(input))
                {
                    if (!String.IsNullOrEmpty(templateIn))
                    {
                        DateTime dateTime = DateTime.ParseExact(input, templateIn, CultureInfo.InvariantCulture, DateTimeStyles.None);
                        return dateTime.ToString(templateOut);
                    }
                    else
                    {
                        DateTime dateTime;
                        DateTime.TryParse(input, out dateTime);
                        return dateTime.ToString(templateOut);
                    }
                }
                else return String.Empty;
            }
            catch (Exception ex)
            {
                logger.Error(A("ConvertToDateTime", input, templateIn, templateOut, ex));
                return String.Empty;
            }
        }
    }
}
