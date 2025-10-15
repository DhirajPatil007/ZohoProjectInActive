using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCustomerPayments1822
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
        public string AccountName { get; set; }
        public string CustomerName { get; set; }
        public string CreatedBy { get; set; }
        public string LastFourDigits { get; set; }
        public string Type { get; set; }
        public string GatewayTransactionId { get; set; }
        public double? RefundedAmount { get; set; }
        public double? BcyRefundedAmount { get; set; }
        public string IsAdvancePayment { get; set; }
        public string HasAttachment { get; set; }
        public string Documents { get; set; }
        public string UniqueId { get; set; }
        public string JvUniqueid { get; set; }
        public string TaxAccountId { get; set; }
        public string TaxAccountName { get; set; }
        public double? TaxAmountWithheld { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentMethod { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string BranchName { get; set; }
    }
}
