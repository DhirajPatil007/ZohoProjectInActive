using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ApSummaryVendors
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Branches { get; set; }
        public decimal? UnusedCredit { get; set; }
        public decimal? UnusedCreditFcy { get; set; }
        public string PaymentTerms { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? ImportId { get; set; }
    }
}
