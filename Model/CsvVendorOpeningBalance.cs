using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CsvVendorOpeningBalance
    {
        public string PaymentNumberPrefix { get; set; }
        public long? PaymentNumberSuffix { get; set; }
        public string UniqueId { get; set; }
        public string PaymentNumber { get; set; }
        public string Department { get; set; }
        public string DepartmentId { get; set; }
        public string Date { get; set; }
        public string VendorName { get; set; }
        public string Mode { get; set; }
        public string Description { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public string PaidThrough { get; set; }
        public string TaxAccount { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymentType { get; set; }
        public string GstTreatment { get; set; }
        public string Gstin { get; set; }
        public string BranchQb { get; set; }
        public decimal? AmountApplied { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
