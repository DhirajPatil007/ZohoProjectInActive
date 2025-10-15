using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwOpenPaymentList
    {
        public string CustomerName { get; set; }
        public string UniqueId { get; set; }
        public decimal? Amount { get; set; }
        public string Txnid { get; set; }
        public string Txntype { get; set; }
        public string JvCnNo { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? AmountAppliedToInvoice { get; set; }
        public string PayDate { get; set; }
        public string Branch { get; set; }
    }
}
