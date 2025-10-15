using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoAp18oct
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public double? Current { get; set; }
        public double? Days130 { get; set; }
        public double? Days3160 { get; set; }
        public double? DaysAbove60 { get; set; }
        public double? ZohoAp { get; set; }
        public double? ZohoApFcy { get; set; }
        public double? UnusedCredits { get; set; }
        public double? UnusedCreditsBcy { get; set; }
        public string QbCompany { get; set; }
        public string QuickbooksId { get; set; }
    }
}
