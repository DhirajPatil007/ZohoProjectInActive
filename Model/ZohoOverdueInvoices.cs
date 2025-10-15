using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoOverdueInvoices
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceStatus { get; set; }
        public string CustomerName { get; set; }
        public double? AmountWithoutTax { get; set; }
        public double? TaxAmount { get; set; }
        public double? InvoiceAmount { get; set; }
        public string Branch { get; set; }
        public double? AmountWithoutTaxFcy { get; set; }
        public double? TaxAmountFcy { get; set; }
        public double? InvoiceTotalFcy { get; set; }
        public double? BalanceFcy { get; set; }
        public double? CreditsAppliedFcy { get; set; }
        public double? PaymentAmountFcy { get; set; }
        public double? AmountPaidFcy { get; set; }
        public double? WriteOffAmountFcy { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string Gstin { get; set; }
        public double? CreditsApplied { get; set; }
    }
}
