using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects.Models
{
    public class CheckResponseModel : RegisterResponseModel
    {
        public List<ListTransModel> lstTrans { get; set; }
    }
}
