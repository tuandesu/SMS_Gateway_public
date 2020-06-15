using System;

namespace GWSendMT.Models
{
    public class AccountModel
    {
        public long ACCOUNT_ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string PASSWORD_API { get; set; }
        public string FULL_NAME { get; set; }
        public string PHONE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string AVATAR { get; set; }
        public string SKYPE { get; set; }
        public string EMAIL { get; set; }
        public string LOGIN_IP { get; set; }
        public Nullable<short> UNLIMIT_QUOTA { get; set; }
        public Nullable<short> PAYMENT_TYPE { get; set; }
        public Nullable<long> CREDIT_LINE_IN_MONTH_CSKH { get; set; }
        public Nullable<long> CREDIT_LINE_IN_DAY_CSKH { get; set; }
        public Nullable<long> QUOTA_CSKH { get; set; }
        public Nullable<long> QUOTA_REMAIN_CSKH { get; set; }
        public Nullable<long> CREDIT_LINE_IN_MONTH_QC { get; set; }
        public Nullable<long> CREDIT_LINE_IN_DAY_QC { get; set; }
        public Nullable<long> QUOTA_QC { get; set; }
        public Nullable<long> QUOTA_REMAIN_QC { get; set; }
        public Nullable<short> DLVR { get; set; }
        public string DLVR_URL { get; set; }
        public string EMAIL_REPORT { get; set; }
        public string PARENT_ID { get; set; }
        public string FACEBOOK_ID { get; set; }
        public string GOOGLE_ID { get; set; }
        public Nullable<short> IS_ADMIN { get; set; }
        public Nullable<short> IS_ACTIVE { get; set; }
        public string BANK_ACCOUNT { get; set; }
        public string BANK_ACCOUNT_NAME { get; set; }
        public string BANK_NAME { get; set; }
        public Nullable<long> ROLE_ACCESS { get; set; }
        public string RSA_PUBLIC_KEY { get; set; }
        public string SECRET_KEY { get; set; }
        public Nullable<short> ENABLE_SMS_CSKH { get; set; }
        public Nullable<short> ENABLE_SMS_QC { get; set; }
        public Nullable<short> ENABLE_OTT { get; set; }
        public Nullable<short> ENABLE_SHORT_NUMBER { get; set; }
        public Nullable<short> ENABLE_OTP { get; set; }
        public string CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string EDIT_DATE { get; set; }
        public string EDIT_USER { get; set; }
        public Nullable<short> IS_DEL { get; set; }
        public int? STT { get; set; }
        public int? TOTAL { get; set; }
        public string PARENT_NAME { get; set; }
        public string ROLE_NAME { get; set; }
        public string TOTAL_QUOTA { get; set; }
        public Nullable<short> IS_SEND_SMS_LOOP { get; set; }
        public long? VOL_CSKH { get; set; }
        public long? VOL_QC { get; set; }
        public long? VOL_8x88 { get; set; }
    }
}
