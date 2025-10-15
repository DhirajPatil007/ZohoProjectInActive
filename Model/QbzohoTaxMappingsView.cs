using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class QbzohoTaxMappingsView
    {
        public string QbtaxCodeId { get; set; }
        public string QbtaxCodeName { get; set; }
        public decimal? TotalPercentage { get; set; }
        public string QbtaxRateId { get; set; }
        public string QbtaxRateName { get; set; }
        public int? SortOrder { get; set; }
        public decimal? TaxPercent { get; set; }
        public string InvoiceType { get; set; }
        public string ZohoTaxGroup { get; set; }
        public string Name { get; set; }
        public string UniqueQbtaxCodeId { get; set; }
    }
}
