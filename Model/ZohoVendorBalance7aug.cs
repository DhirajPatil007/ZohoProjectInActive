using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoVendorBalance7aug
    {
        public string VendorName { get; set; }
        public string VendorId { get; set; }
        public double? BilledAmount { get; set; }
        public double? AmountPaid { get; set; }
        public double? ClosingBalance { get; set; }
        public double? FcyClosingBalance { get; set; }
        public string QbId { get; set; }
        public string QbCompany { get; set; }
    }
}
