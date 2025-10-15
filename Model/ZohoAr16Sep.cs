using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoAr16Sep
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public double? Current { get; set; }
        public double? Days115 { get; set; }
        public double? Days1630 { get; set; }
        public double? Days3145 { get; set; }
        public double? DaysAbove45 { get; set; }
        public double? Total { get; set; }
        public double? FcyTotal { get; set; }
        public double? OutstandingReceivableAmount { get; set; }
        public double? OutstandingReceivableAmountBcy { get; set; }
        public double? UnusedCreditsReceivableAmount { get; set; }
        public double? UnusedCreditsReceivableAmountBcy { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string CustUniqueId { get; set; }
    }
}
