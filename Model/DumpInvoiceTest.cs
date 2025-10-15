using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpInvoiceTest
    {
        public string TxnDate { get; set; }
        public string DocNumber { get; set; }
        public string Id { get; set; }
        public bool? AllowIpnpayment { get; set; }
        public bool? AllowOnlinePayment { get; set; }
        public bool? AllowOnlineCreditCardPayment { get; set; }
        public bool? AllowOnlineAchpayment { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public int? SyncToken { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PrivateNote { get; set; }
        public string LinkedTxn { get; set; }
        public string LineItems { get; set; }
        public string TxnTaxDetail { get; set; }
        public decimal? TxnTaxDetailTotalTax { get; set; }
        public string TransactionLocationType { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string BillingAddressId { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingAddress4 { get; set; }
        public string BillingAddress5 { get; set; }
        public bool? FreeFormAddress { get; set; }
        public string ShippingAddressId { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingAddress3 { get; set; }
        public string ShippingAddress4 { get; set; }
        public string ShippingAddress5 { get; set; }
        public string ShipFromAddressId { get; set; }
        public string ShipFromAddress1 { get; set; }
        public string ShipFromAddress2 { get; set; }
        public string ClassId { get; set; }
        public string JobNumber { get; set; }
        public string PaymentTermRef { get; set; }
        public string Gstin { get; set; }
        public string DueDate { get; set; }
        public string GlobalTaxCalculation { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? HomeTotalAmt { get; set; }
        public string PrintStatus { get; set; }
        public string EmailStatus { get; set; }
        public decimal? Balance { get; set; }
        public decimal? HomeBalance { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string InvoiceStatus { get; set; }
        public string Branch { get; set; }
    }
}
