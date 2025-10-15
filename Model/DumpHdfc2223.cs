using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpHdfc2223
    {
        public DateTime? TxnDate { get; set; }
        public string TransactionType { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string MemoDescription { get; set; }
        public string Account { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Amount { get; set; }
        public double? Balance { get; set; }
        public string Currency { get; set; }
        public double? ForeignDebit { get; set; }
        public double? ForeignCredit { get; set; }
        public double? ForeignAmount { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
        public string ExchangeRate { get; set; }
        public string Branch { get; set; }
        public string Fy { get; set; }
    }
}
