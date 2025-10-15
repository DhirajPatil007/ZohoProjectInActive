using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoAp21sep
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public double? Current { get; set; }
        public double? Days115 { get; set; }
        public double? Days1630 { get; set; }
        public double? Days3145 { get; set; }
        public double? DaysAbove45 { get; set; }
        public double? ZohoAp { get; set; }
        public double? ZohoApFcy { get; set; }
        public string GstNo { get; set; }
        public double? OutstandingAmount { get; set; }
        public double? OutstandingAmountBcy { get; set; }
        public double? UnusedCredits { get; set; }
        public double? UnusedCreditsBcy { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
    }
}
