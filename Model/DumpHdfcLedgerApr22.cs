using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpHdfcLedgerApr22
    {
        public int LineId { get; set; }
        public string UniqueId { get; set; }
        public string TxnDate { get; set; }
        public string BankAccountName { get; set; }
        public string DocNumber { get; set; }
        public string TransactionType { get; set; }
        public double? TotalAmt { get; set; }
        public double? TotalAmtFcy { get; set; }
        public string Currency { get; set; }
        public double? ExRate { get; set; }
        public string ContactName { get; set; }
        public string ZohoDisplayName { get; set; }
        public string BranchQb { get; set; }
        public string LineStatus { get; set; }
        public string JvType { get; set; }
        public string ZohoTxnid { get; set; }
        public string ZohoBank { get; set; }
        public string ZohoAmount { get; set; }
        public double? ZohoFcy { get; set; }
        public string ZohoStatus { get; set; }
        public double? ZohoTxncount { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? QbDate { get; set; }
    }
}
