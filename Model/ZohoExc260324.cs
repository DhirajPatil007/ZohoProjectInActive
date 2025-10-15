using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoExc260324
    {
        public string PaymentId { get; set; }
        public string PaymentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string Date { get; set; }
        public string PaymentMode { get; set; }
        public double? Amount { get; set; }
        public double? BcyAmount { get; set; }
        public double? UnusedAmount { get; set; }
        public double? BcyUnusedAmount { get; set; }
        public double? BcyTotalExcludingTdsDeduction { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string ReferenceNumber { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CreatedBy { get; set; }
        public string Type { get; set; }
        public double? RefundedAmount { get; set; }
        public double? BcyRefundedAmount { get; set; }
        public string IsAdvancePayment { get; set; }
        public string HasAttachment { get; set; }
        public string Documents { get; set; }
        public string UniqueId { get; set; }
        public string UniqueJvid { get; set; }
        public string TaxAccountId { get; set; }
        public string TaxAccountName { get; set; }
        public double? TaxAmountWithheld { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentMethod { get; set; }
        public string QbCustomerid { get; set; }
        public string QbCompany { get; set; }
        public string BranchName { get; set; }
    }
}
