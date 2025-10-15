using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CompareZohoCustomerdata
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string TxnDate { get; set; }
        public string TxnType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RunningBalance { get; set; }
    }
}
