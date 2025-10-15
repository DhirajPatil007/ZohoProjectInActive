using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ApagingDetails
    {
        public string VendorName { get; set; }
        public string PaymentTerms { get; set; }
        public decimal? Current { get; set; }
        public decimal? _15 { get; set; }
        public decimal? _30 { get; set; }
        public decimal? _45 { get; set; }
        public decimal? _60 { get; set; }
        public decimal? _75 { get; set; }
        public decimal? _90 { get; set; }
        public decimal? _105 { get; set; }
        public decimal? _120 { get; set; }
        public decimal? TotalBalance { get; set; }
        public decimal? UnusedCredit { get; set; }
        public decimal? TotalOutstanding { get; set; }
    }
}
