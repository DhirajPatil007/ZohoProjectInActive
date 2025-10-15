using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoArAgingJvCn
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CurrencyCode { get; set; }
        public double? Total { get; set; }
        public double? FcyTotal { get; set; }
        public double? UnusedCreditsFcy { get; set; }
        public double? UnusedCredits { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
    }
}
