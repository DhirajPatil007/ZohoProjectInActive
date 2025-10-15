using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoTempInrFlc
    {
        public string Date { get; set; }
        public string AccountName { get; set; }
        public string TransactionDetails { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string EntityNumber { get; set; }
        public string Debit { get; set; }
        public double? NetAmount { get; set; }
        public string FcyDebit { get; set; }
        public double? FcyNetAmount { get; set; }
        public string ContactId { get; set; }
        public string ContactName { get; set; }
        public string AccountId { get; set; }
        public string CurrencyCode { get; set; }
        public string AccountGroup { get; set; }
        public string AccountType { get; set; }
        public string BranchName { get; set; }
        public string ManualAccount { get; set; }
        public string ZohoAccount { get; set; }
        public string QbAccount { get; set; }
        public string OldStatus { get; set; }
        public string LineStatus { get; set; }
        public int LineId { get; set; }
    }
}
