using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class Invoices
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TotalFcy { get; set; }
        public decimal? BalanceFcy { get; set; }
        public string Notes { get; set; }
        public int? InvoiceAge { get; set; }
        public int? AgePastDueDate { get; set; }
        public string SalesPerson { get; set; }
        public string PaymentTerms { get; set; }
        public decimal? PaymentAmountFcy { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? CreditsApplied { get; set; }
        public decimal? CreditsAppliedFcy { get; set; }
        public decimal? UsdexRate { get; set; }
        public string Project { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? AmountPaidFcy { get; set; }
        public string InvoiceStatus { get; set; }
        public int ImportId { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string Transaction { get; set; }
    }
}
