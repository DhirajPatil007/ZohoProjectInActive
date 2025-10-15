using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoInvoices20230430
    {
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public double? AmountWithoutTaxFcy { get; set; }
        public double? Cgst { get; set; }
        public double? Sgst { get; set; }
        public double? Igst { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountFcy { get; set; }
        public double? BalanceAmount { get; set; }
        public double? BalanceFcy { get; set; }
        public double? PaymentAmount { get; set; }
        public double? PaymentAmountFcy { get; set; }
        public double? CreditsApplied { get; set; }
        public double? CreditsAppliedFcy { get; set; }
        public double? AmountPaid { get; set; }
        public double? AmountPaidFcy { get; set; }
        public string Branch { get; set; }
    }
}
