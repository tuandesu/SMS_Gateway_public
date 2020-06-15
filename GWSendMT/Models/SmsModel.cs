using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWSendMT.Models
{
    public class SmsModel
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string password_api { get; set; }
        public string brandname { get; set; }
        public string phone { get; set; }
        public string telco { get; set; }
        public string message { get; set; }
        public int sms_count { get; set; }
        public string sendtime { get; set; }
        public string unicode { get; set; }
    }
}
