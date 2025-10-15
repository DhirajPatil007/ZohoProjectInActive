using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoTaxMaster
    {
        public string QbtaxCodeId { get; set; }
        public string QbTaxcodename { get; set; }
        public decimal? TotalPercentage { get; set; }
        public int? Compid { get; set; }
        public string QbCompany { get; set; }
        public string TaxId { get; set; }
        public string TaxName { get; set; }
        public decimal? TaxPercentage { get; set; }
        public string TaxSpecificType { get; set; }
        public string TaxType { get; set; }
        public string ItemTaxType { get; set; }
    }
}
