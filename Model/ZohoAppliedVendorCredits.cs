using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoAppliedVendorCredits
    {
        public string TxnDate { get; set; }
        public string VendorCreditNumber { get; set; }
        public string BillNumber { get; set; }
        public double? AppliedCreditAmount { get; set; }
    }
}
