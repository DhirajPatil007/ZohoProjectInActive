using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpPaymentReceivedLinesOnAccount
    {
        public string UniqueId { get; set; }
        public string PaymentNumberPrefix { get; set; }
        public long? PaymentNumberSuffix { get; set; }
        public string Date { get; set; }
        public string Branch { get; set; }
        public string DescriptionOfSupply { get; set; }
        public string PaymentType { get; set; }
        public string Mode { get; set; }
        public string Description { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public string DepositToAccountId { get; set; }
        public string DepositTo { get; set; }
        public string BankCharges { get; set; }
        public string ReferenceNumber { get; set; }
        public string CustomerName { get; set; }
        public string GstTreatment { get; set; }
        public string Gstin { get; set; }
        public string TaxAccount { get; set; }
        public string WithholdingTaxAmount { get; set; }
    }
}
