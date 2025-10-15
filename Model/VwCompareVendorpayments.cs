using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwCompareVendorpayments
    {
        public string Date { get; set; }
        public string VendorName { get; set; }
        public decimal? Zoho { get; set; }
        public decimal? Qb { get; set; }
        public decimal? Diff { get; set; }
    }
}
