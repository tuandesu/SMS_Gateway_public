using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects.Models
{
    public class BalanceGPCModel
    {
        public int? error_code { get; set; }
        public string message { get; set; }
        public string user_name { get; set; }
        public int? count_order_active { get; set; }
        public List<BalanceDetailGPCModel> detail { get; set; }
    }
}
