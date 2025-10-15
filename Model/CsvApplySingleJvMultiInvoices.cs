using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CsvApplySingleJvMultiInvoices
    {
        public string Date { get; set; }
        public string PaymentId { get; set; }
        public string TxnId { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? JvAmount { get; set; }
        public string InvoiceNumber { get; set; }
        public string JournalNumber { get; set; }
        public decimal? Amount { get; set; }
        public double? BalanceFcy { get; set; }
        public string JournalUniqueId { get; set; }
    }
}
