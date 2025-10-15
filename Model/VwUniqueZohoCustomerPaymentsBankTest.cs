using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwUniqueZohoCustomerPaymentsBankTest
    {
        public string Uniqueid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaidThrough { get; set; }
        public string QbAmount { get; set; }
        public double? ZohoAmount { get; set; }
        public string ZohoBank { get; set; }
        public string CustomerPaymentId { get; set; }
        public double? AmountAppliedToInvoice { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public decimal JvCredit { get; set; }
        public decimal JvDebit { get; set; }
        public decimal Purchase { get; set; }
        public string Mode { get; set; }
        public string CustomerId { get; set; }
        public string Status { get; set; }
    }
}
