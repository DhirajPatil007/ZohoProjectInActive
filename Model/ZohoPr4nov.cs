using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoPr4nov
    {
        public string PaymentId { get; set; }
        public string PaymentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string ZohoDate { get; set; }
        public string PaymentMode { get; set; }
        public double? ZohoAmount { get; set; }
        public double? BcyAmount { get; set; }
        public double? UnusedAmount { get; set; }
        public double? BcyUnusedAmount { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string ZohoDescription { get; set; }
        public string ProductDescription { get; set; }
        public string ReferenceNumber { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CreatedBy { get; set; }
        public string PrType { get; set; }
        public double? RefundedAmount { get; set; }
        public double? BcyRefundedAmount { get; set; }
        public string IsAdvancePayment { get; set; }
        public string QbUniqueid { get; set; }
        public string QbJvid { get; set; }
        public string TaxAccountId { get; set; }
        public string TaxAccountName { get; set; }
        public double? TaxAmountWithheld { get; set; }
        public string CurrencyCode { get; set; }
        public string QbCustid { get; set; }
        public string QbCompany { get; set; }
        public string BranchName { get; set; }
    }
}
