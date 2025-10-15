using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoVendorPayments
    {
        public string PaymentNumber { get; set; }
        public string PaymentNumberPrefix { get; set; }
        public string PaymentNumberSuffix { get; set; }
        public string VendorPaymentId { get; set; }
        public string Mode { get; set; }
        public string Description { get; set; }
        public double? ExchangeRate { get; set; }
        public double? Amount { get; set; }
        public double? UnusedAmount { get; set; }
        public double? Tdsamount { get; set; }
        public string ReferenceNumber { get; set; }
        public string BranchId { get; set; }
        public string Date { get; set; }
        public string PaymentType { get; set; }
        public string BranchName { get; set; }
        public string VendorName { get; set; }
        public string DebitACNo { get; set; }
        public string VendorBankAccountNumber { get; set; }
        public string VendorBankName { get; set; }
        public string VendorBankCode { get; set; }
        public string SourceOfSupply { get; set; }
        public string DestinationOfSupply { get; set; }
        public string GstTreatment { get; set; }
        public string GstIdentificationNumberGstin { get; set; }
        public string EmailId { get; set; }
        public string DescriptionOfSupply { get; set; }
        public string PaidThrough { get; set; }
        public string PaidThroughAccountCode { get; set; }
        public string TaxAccount { get; set; }
        public string ReverseChargeTaxPercentage { get; set; }
        public string ReverseChargeTaxType { get; set; }
        public string ReverseChargeTaxAmount { get; set; }
        public string ReverseChargeTaxName { get; set; }
        public string TdsName { get; set; }
        public string TdsPercentage { get; set; }
        public string TdsSectionCode { get; set; }
        public string TdsSection { get; set; }
        public string TdsAccountName { get; set; }
        public string BankReferenceNumber { get; set; }
        public string PipaymentId { get; set; }
        public double? BillAmount { get; set; }
        public string BillNumber { get; set; }
        public double? WithholdingTaxAmount { get; set; }
        public string NewBank { get; set; }
        public string NewBankId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Status { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
