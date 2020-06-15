using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects.Models
{
    public class UserLoginModel
    {
        public string ACCOUNT_ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_ADMIN { get; set; }
        public string LOGIN_IP { get; set; }
        public string TIME_OUT { get; set; }
        public string PROVIDER { get; set; }
        public string FULL_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string AVATAR { get; set; }
        public string TOKEN { get; set; }
    }
}
