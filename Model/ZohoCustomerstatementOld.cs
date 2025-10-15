using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCustomerstatementOld
    {
        public string Customername { get; set; }
        public DateTime? TxnDate { get; set; }
        public string TxnType { get; set; }
        public string Details { get; set; }
        public double? Amount { get; set; }
        public double? Payments { get; set; }
        public double? Balance { get; set; }
    }
}
