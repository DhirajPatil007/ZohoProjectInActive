using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class MergedVendorData
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string TxnDate { get; set; }
        public string TxnType { get; set; }
        public decimal? QbAmount { get; set; }
        public decimal? QbRunningBalance { get; set; }
        public decimal? ZohoAmount { get; set; }
        public decimal? ZohoRunningBalance { get; set; }
        public decimal? LineDifference { get; set; }
    }
}
