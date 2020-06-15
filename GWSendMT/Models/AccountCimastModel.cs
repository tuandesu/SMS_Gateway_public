using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWSendMT.Models
{
    public class AccountCimastModel
    {
        public int? STT { get; set; }
        public string SERVICENAME { get; set; }
        public string USER_NAME { get; set; }
        public string TX_DATE { get; set; }
        public Nullable<long> DEBIT_AMT { get; set; }
        public Nullable<long> VOL { get; set; }
        public Nullable<long> IN_AMT { get; set; }
        public Nullable<long> OUT_AMT { get; set; }
        public Nullable<long> IN_VOL { get; set; }
        public Nullable<long> OUT_VOL { get; set; }
        public long CI_ID { get; set; }
        public long ACCOUNT_ID { get; set; }
        public int? PAYMENT_TYPE { get; set; }
        public Nullable<short> ENABLE_SMS_CSKH { get; set; }
        public Nullable<short> ENABLE_SMS_QC { get; set; }
        public string CREATE_USER { get; set; }
    }
}
