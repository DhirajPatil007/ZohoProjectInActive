using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class FixVendorData
    {
        public string TxnDate { get; set; }
        public string TxnType { get; set; }
        public double? Qbamount { get; set; }
        public double? QbRunningBalance { get; set; }
        public double? ZohoAmount { get; set; }
        public double? ZohoRunningBalance { get; set; }
        public double? Difference { get; set; }
        public string VendorName { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
