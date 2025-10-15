using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCustomerPayments
    {
        public string PaymentNumber { get; set; }
        public string CustomerPaymentId { get; set; }
        public string Mode { get; set; }
        public string CustomerId { get; set; }
        public string Description { get; set; }
        public double? ExchangeRate { get; set; }
        public double? Amount { get; set; }
        public double? UnusedAmount { get; set; }
        public double? BankCharges { get; set; }
        public string ReferenceNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string BranchId { get; set; }
        public string PaymentNumberPrefix { get; set; }
        public string PaymentNumberSuffix { get; set; }
        public string CustomerName { get; set; }
        public string PlaceOfSupply { get; set; }
        public string PlaceOfSupplyWithStateCode { get; set; }
        public string GstTreatment { get; set; }
        public string GstIdentificationNumberGstin { get; set; }
        public string DescriptionOfSupply { get; set; }
        public string TaxName { get; set; }
        public string TaxPercentage { get; set; }
        public string TaxType { get; set; }
        public string PaymentType { get; set; }
        public string BranchName { get; set; }
        public string Date { get; set; }
        public string CreatedTime { get; set; }
        public string PaymentType1 { get; set; }
        public string DepositTo { get; set; }
        public string DepositToAccountCode { get; set; }
        public string TaxAccount { get; set; }
        public string InvoicePaymentId { get; set; }
        public double? AmountAppliedToInvoice { get; set; }
        public double? WithholdingTaxAmount { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
