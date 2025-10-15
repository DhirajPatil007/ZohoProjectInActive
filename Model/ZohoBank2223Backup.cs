using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoBank2223Backup
    {
        public string Date { get; set; }
        public string AccountName { get; set; }
        public string TransactionDetails { get; set; }
        public string TransactionId { get; set; }
        public string ReferenceTransactionId { get; set; }
        public string OffsetAccountId { get; set; }
        public string OffsetAccountType { get; set; }
        public string TransactionType { get; set; }
        public string ReferenceNumber { get; set; }
        public string EntityNumber { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? NetAmount { get; set; }
        public double? FcyDebit { get; set; }
        public double? FcyCredit { get; set; }
        public double? FcyNetAmount { get; set; }
        public string ContactId { get; set; }
        public string ContactName { get; set; }
        public string AccountId { get; set; }
        public string ProjectIds { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public string AccountGroup { get; set; }
        public string AccountType { get; set; }
        public string BranchName { get; set; }
        public string LineStatus { get; set; }
        public string QbUniqueid { get; set; }
        public int LineId { get; set; }
    }
}
