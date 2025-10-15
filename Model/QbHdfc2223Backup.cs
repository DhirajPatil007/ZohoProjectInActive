using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class QbHdfc2223Backup
    {
        public long? LineId { get; set; }
        public string UniqueId { get; set; }
        public string TxnDate { get; set; }
        public string BankAccountName { get; set; }
        public string DocNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? TotalAmtFcy { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string ContactName { get; set; }
        public string ZohoDisplayName { get; set; }
        public string BranchQb { get; set; }
        public string LineStatus { get; set; }
        public string ZohoTxnid { get; set; }
        public string ZohoBank { get; set; }
        public decimal? ZohoAmount { get; set; }
        public decimal? ZohoFcy { get; set; }
        public string ZohoStatus { get; set; }
        public int? ZohoTxncount { get; set; }
        public string CompareStatus { get; set; }
        public DateTime? QbDate { get; set; }
    }
}
