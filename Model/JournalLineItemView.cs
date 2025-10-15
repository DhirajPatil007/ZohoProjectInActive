using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class JournalLineItemView
    {
        public string UniqueId { get; set; }
        public string DocNumber { get; set; }
        public string Id { get; set; }
        public decimal? Amount { get; set; }
        public string Name { get; set; }
        public string QbtaxCodeId { get; set; }
        public string QbtaxRateId { get; set; }
        public decimal? TaxPercent { get; set; }
        public string ZohoTaxGroup { get; set; }
        public decimal? PercentageOfTotal { get; set; }
        public string InvoiceType { get; set; }
    }
}
