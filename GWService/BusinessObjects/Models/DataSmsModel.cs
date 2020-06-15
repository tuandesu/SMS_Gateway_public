namespace BusinessObjects.Models
{
    public class DataSmsModel
    {
        public long ID { get; set; }
        public long ACCOUNT_ID { get; set; }
        public string PHONE { get; set; }
        public string TELCO { get; set; }
        public long? DATA_VOL { get; set; }
        public long? DATA_AMT { get; set; }
        public string SENDER_NAME { get; set; }
        public string PARTNER_NAME { get; set; }
        public string TYPE { get; set; }
        public string SMS_CONTENT { get; set; }
        public int? SMS_COUNT { get; set; }
        public string INSERT_TIME { get; set; }
        public string TIME_SCHEDULE { get; set; }
        public string TIME_SEND { get; set; }
        public string TIME_RECEIVE { get; set; }
        public string CODE_RECEIVE { get; set; }
        public string PROGRAM_NAME { get; set; }
        public int? TOTAL_PHONE { get; set; }
        public int? STT { get; set; }
        public int? TOTAL { get; set; }
        public long? DATA_CAMPAIGN_ID { get; set; }
        public string RECEIVE_RESULT { get; set; }
        public string DLVR_STATUS { get; set; }
        public short? IS_SEND_SMS { get; set; }
        public long? PACKAGE_ID { get; set; }
        public long? SENDER_ID { get; set; }
        public int? QUOTA { get; set; }
        public short? APPROVED { get; set; }
        public string PACKAGE_NAME { get; set; }
    }
}
