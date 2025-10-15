using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoInvoices11sep
    {
        public string InvoiceId { get; set; }
        public string Status { get; set; }
        public string TxnDate { get; set; }
        public string DueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string CustomerName { get; set; }
        public double? BcyTotal { get; set; }
        public double? BcyBalance { get; set; }
        public double? FcyTotal { get; set; }
        public double? FcyBalance { get; set; }
        public string SalespersonId { get; set; }
        public double? TaxAmount { get; set; }
        public double? FcyTaxAmount { get; set; }
        public double? AmountWithoutTax { get; set; }
        public double? PaidAmountFcy { get; set; }
        public double? CreditAmount { get; set; }
        public double? CreditAmountFcy { get; set; }
        public double? FcyAmountWithoutTax { get; set; }
        public string ProjectNames { get; set; }
        public double? FcyAmountPaid { get; set; }
        public string CurrencyCode { get; set; }
        public string FcyWriteoffAmount { get; set; }
        public string CurrencyId { get; set; }
        public string CustomerId { get; set; }
        public string PricePrecision { get; set; }
        public string IsEmailed { get; set; }
        public string RemindersSent { get; set; }
        public double? ExchangeRate { get; set; }
        public string GstNo { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string BranchName { get; set; }
    }
}
