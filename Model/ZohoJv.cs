using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoJv
    {
        public string JournalNumber { get; set; }
        public string JournalNumberPrefix { get; set; }
        public string JournalNumberSuffix { get; set; }
        public string JournalDate { get; set; }
        public string TaxBasis { get; set; }
        public string Status { get; set; }
        public string JournalType { get; set; }
        public string ReferenceNumber { get; set; }
        public string Notes { get; set; }
        public string IsInclusiveTax { get; set; }
        public double? ExchangeRate { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public double? ItemOrder { get; set; }
        public string TaxName { get; set; }
        public string TaxPercentage { get; set; }
        public double? TaxAmount { get; set; }
        public string TaxType { get; set; }
        public string ProjectName { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string Account { get; set; }
        public string AccountCode { get; set; }
        public string ContactName { get; set; }
        public string Currency { get; set; }
        public double? Total { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
