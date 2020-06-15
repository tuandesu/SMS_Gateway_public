using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects.Models
{
    public class BalanceModel
    {
        public string tranID { get; set; }
        public string RETURN { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public double balance { get; set; }
        public string validDate { get; set; }
    }
}
