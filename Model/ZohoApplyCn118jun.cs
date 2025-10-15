using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoApplyCn118jun
    {
        public string PaymentId { get; set; }
        public double? PaymentAmount { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public string JvnumberOrCreditnote { get; set; }
        public string InvoiceNumber { get; set; }
        public double? AmountAppliedToInvoice { get; set; }
        public string PaymentTxnType { get; set; }
        public double? Invoice { get; set; }
        public double? JournalEntry { get; set; }
        public double? CreditMemo { get; set; }
    }
}
