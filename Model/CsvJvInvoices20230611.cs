using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CsvJvInvoices20230611
    {
        public string JournalNumberPrefix { get; set; }
        public long? JournalNumberSuffix { get; set; }
        public string JournalDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string JournalType { get; set; }
        public string Currency { get; set; }
        public string Branch { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string AccountType { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
        public string ProjectName { get; set; }
        public string ContactName { get; set; }
        public string UniqueId { get; set; }
        public string JournalQbid { get; set; }
        public string Branchqb { get; set; }
    }
}
