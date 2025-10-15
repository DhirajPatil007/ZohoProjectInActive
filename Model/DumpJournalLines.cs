using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpJournalLines
    {
        public string Uniqueid { get; set; }
        public string TxnDate { get; set; }
        public string DocNumber { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? HomeTotalAmt { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PrivateNote { get; set; }
        public string JournalQbid { get; set; }
        public string BranchQb { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string DetailType { get; set; }
        public string JvlinePostingType { get; set; }
        public string JvlineEntityType { get; set; }
        public string JvlineEntityRefId { get; set; }
        public string JvlineEntityRefName { get; set; }
        public string JvlineAccountRefId { get; set; }
        public string JvlineAccountRefName { get; set; }
        public string JvlineDepartmentRefId { get; set; }
        public string JvlineDepartmentRefName { get; set; }
        public string JvlineTaxCodeRefId { get; set; }
        public string JvlineTaxApplicableOn { get; set; }
        public decimal? JvlineTaxAmount { get; set; }
        public string ZohoDisplayName { get; set; }
    }
}
