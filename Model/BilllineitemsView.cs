using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BilllineitemsView
    {
        public string UniqueId { get; set; }
        public string TxnDate { get; set; }
        public string TransactionType { get; set; }
        public int LineId { get; set; }
        public string EntityNumber { get; set; }
        public string Id { get; set; }
        public int? LineNum { get; set; }
        public decimal? Amount { get; set; }
        public string Name { get; set; }
        public string QbtaxCodeId { get; set; }
        public string QbtaxRateId { get; set; }
        public decimal? TaxPercent { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal? NetAmount { get; set; }
    }
}
