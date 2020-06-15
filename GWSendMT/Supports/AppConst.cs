using System.IO;
using System.Reflection;

namespace GWSendMT.Supports
{
    public class AppConst
    {
        public const int SYS_ERR_OK = 0;
        public const int SYS_ERR_UNKNOW = -1;
        public const int SYS_ERR_EXCEPTION = -2;

        public const string SYS_MSG_OK = "Success";
        public const string SYS_MSG_UNKNOW = "Lỗi chưa được định nghĩa";
        public const string SYS_MSG_EXCEPTION = "Lỗi hệ thống";

        /// <summary>
        /// Const Upload, Export, Import... file
        /// </summary>
        public static string PATH_CURRENT_DIRECTORY = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        /// </summary>
        public const string ERR_CODE = "err_code";
        public const string ERR_MESSAGE = "err_message";
        public const string DATA = "data";

        /// <summary>
        /// Template return store
        /// </summary>
        public const string P_ERR_CODE = "p_err_code";
        public const string P_ERR_MESSAGE = "p_err_message";
        public const string P_REFCURSOR = "p_refcursor";

        public const string DATE_FORMAT_TEMPLATE_1 = "yyyyMMdd";
        public const string DATE_FORMAT_TEMPLATE_2 = "dd/MM/yyyy";
        public const string DATE_FORMAT_TEMPLATE_3 = "yyyyMMddHHmm";
        public const string DATE_FORMAT_TEMPLATE_4 = "yyyyMMddHHmmss";
        public const string DATETIME_FORMAT_TEMPLATE_1 = "dd-MM-yyyy HH:mm:ss";
        public const string DATETIME_FORMAT_TEMPLATE_2 = "dd/MM/yyyy HH:mm:ss";
        public const string DATETIME_FORMAT_TEMPLATE_3 = "dd-MM-yyyy HH:mm";

        /// <summary>
        /// Template input store
        /// </summary>
        public const int REFCURSOR = 121;
        public const int VARCHAR2 = 126;
        public const int NUMBER = 111;
        public const int INPUT = 1;
        public const int OUTPUT = 2;
        public const int LONG = 113;
        public const int DECIMAL = 107;

        /// <summary>
        /// Telco
        /// </summary>
        public const string GPC = "GPC";
        public const string VNM = "VNM";
        public const string VMS = "VMS";
        public const string GTEL = "GTEL";
        public const string SFONE = "SFONE";
        public const string VIETTEL = "VIETTEL";
        public const string DDMOBILE = "DDMBLE";

        /// <summary>
        /// VIA
        /// </summary>
        public const string VIA_SMS_CLIENT = "SMS_CLIENT";
        public const string VIA_SMS_BRIRTDAY = "SMS_BRIRTDAY";
        public const string VIA_SMS_API = "SMS_API";

        /// <summary>
        /// VIA
        /// </summary>
        public const string SMS_TYPE_CSKH = "CSKH";
        public const string SMS_TYPE_QC= "QC";

        public const double TIME_CHECK_LOOP = 5;
    }
}
