using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class GaneshJvLot
    {
        public DateTime? Invoicedate { get; set; }
        public string JournalNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Amount { get; set; }
        public double? BalanceFcy { get; set; }
        public double? FixedAmount { get; set; }
        public double? Difference { get; set; }
        public string PaymentId { get; set; }
        public double? PaymentAmount { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public string PaymentTxnType { get; set; }
        public double? Invoice { get; set; }
        public double? JournalEntry { get; set; }
        public double? CreditMemo { get; set; }
    }
}
