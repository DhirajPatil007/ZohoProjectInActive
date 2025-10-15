using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CompareZohoVendordataNew
    {
        public int? VendorId { get; set; }
        public string VendorName { get; set; }
        public string TxnDate { get; set; }
        public string TxnType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RunningBalance { get; set; }
    }
}
