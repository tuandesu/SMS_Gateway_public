using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects.Models
{
    public class AccountDataModel
    {
        public string TransID { get; set; }
        public string CpCode { get; set; }
        public string Data { get; set; }
        public string signature { get; set; }
        public string Password { get; set; }
        public long reqtime { get; set; }
    }
}
