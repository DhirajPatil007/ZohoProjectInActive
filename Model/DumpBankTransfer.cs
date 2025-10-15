using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpBankTransfer
    {
        public DateTime? TxnDate { get; set; }
        public DateTime? OldDate { get; set; }
        public string Qbdate { get; set; }
        public string Name { get; set; }
        public string FromAccountId { get; set; }
        public string FromAccountName { get; set; }
        public string ToAccountId { get; set; }
        public string ToAccountName { get; set; }
        public string CustomerId { get; set; }
        public string PaymentMode { get; set; }
        public double? ExchangeRate { get; set; }
        public string PaymentNumber { get; set; }
        public string TransactionType { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Amount { get; set; }
        public double? Balance { get; set; }
        public double? ForeignCredit { get; set; }
        public double? ForeignDebit { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
        public string MemoDescription { get; set; }
        public string SyncStatus { get; set; }
        public int Id { get; set; }
        public string RefernceNumber { get; set; }
    }
}
