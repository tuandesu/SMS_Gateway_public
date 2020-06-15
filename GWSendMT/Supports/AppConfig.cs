using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace GWSendMT.Supports
{
    public class AppConfig
    {
        public static IConfigurationRoot _Configuration;

        public static string GetKeySetting(string key)
        {
            if (_Configuration == null)
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
                _Configuration = builder.Build();
            }
            return _Configuration[key];
        }

        public readonly static string ORACLE_CONNECTION =
            String.Format("Connection Timeout=60;User Id={0};Password={1};Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={2})(PORT={3})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={4})))",
                GetKeySetting("ConnectionOracle:Id"),
                GetKeySetting("ConnectionOracle:Password"),
                GetKeySetting("ConnectionOracle:Host"),
                GetKeySetting("ConnectionOracle:Port"),
                GetKeySetting("ConnectionOracle:ServiceName")
            );

        /// <summary>
        /// Redis config
        /// </summary>
        public readonly static string REDIS_HOST = GetKeySetting("ConnectionRedis:Host");
        public readonly static int REDIS_PORT = Convert.ToInt32(GetKeySetting("ConnectionRedis:Port"));
        public readonly static string REDIS_PASS = GetKeySetting("ConnectionRedis:Password");

        /// <summary>
        /// Worker config
        /// </summary>
        public readonly static int WORKER_TIMEOUT = String.IsNullOrEmpty(GetKeySetting("Worker:Timeout")) ? 5000 : Convert.ToInt32(GetKeySetting("Worker:Timeout"));
        public readonly static int WORKER_MAX_CONCURRENCY = String.IsNullOrEmpty(GetKeySetting("Worker:MaxConcurrency")) ? 1 : Convert.ToInt32(GetKeySetting("Worker:MaxConcurrency"));

        public readonly static string API_CHECK_LOGIN_API = GetKeySetting("API:auth:login_api");

        /// <summary>
        /// SMS
        /// </summary>
        public readonly static string API_POST_SMS = GetKeySetting("API:sms:post_sms");

        /// <summary>
        /// Account cimast
        /// </summary>
        public readonly static string API_GET_QUOTA_REMAIN = GetKeySetting("API:account_cimast:get_quota_remain");
        public readonly static string API_UPDATE_QUOTA = GetKeySetting("API:account_cimast:update_quota");

        /// <summary>
        /// PARTNER_SENDER
        /// </summary>
        public readonly static string API_GET_ACCOUNT_SENDER = GetKeySetting("API:parter_sender:get_account_sender");
        public readonly static string API_GET_PARTNER_SENDER_BY_TELCO = GetKeySetting("API:parter_sender:get_partner_by_sender_telco");

        public readonly static string ENCRYPTION_PUBLIC_KEY_VIETTEL = GetKeySetting("Encryption:PublicKeys:Viettel");
    }
}
