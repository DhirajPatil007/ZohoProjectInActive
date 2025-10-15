using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class JvInvoiceBranchfix202223
    {
        public string PaymentUniqueId { get; set; }
        public string TxnType { get; set; }
        public string Txnid { get; set; }
        public string JournalNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Amount { get; set; }
        public decimal? AmountAppliedToInvoice { get; set; }
        public double? BalanceFcy { get; set; }
        public double? InvoiceBalance { get; set; }
        public string InvoiceBranch { get; set; }
        public string Jvbranch { get; set; }
        public string CustomerName { get; set; }
    }
}
