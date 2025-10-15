using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoApSummary
    {
        public string QbVendorName { get; set; }
        public string QbCompany { get; set; }
        public string QbId { get; set; }
        public string ZohoVendorName { get; set; }
        public double? BilledAmount { get; set; }
        public double? AmountPaid { get; set; }
        public double? ZohoClosing { get; set; }
        public double? QbClosing { get; set; }
        public double? Difference { get; set; }
        public double? ClosingFcy { get; set; }
        public double? VendorId { get; set; }
        public string AssignedTo { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string Imported { get; set; }
        public string Comments { get; set; }
        public double? Zoho11aug { get; set; }
    }
}
