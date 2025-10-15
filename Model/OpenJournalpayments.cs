using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class OpenJournalpayments
    {
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
        public string BillDate { get; set; }
        public string BillNumber { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? AmountAppliedToBill { get; set; }
        public string PaymentType { get; set; }
        public string GstTreatment { get; set; }
        public string Gstin { get; set; }
        public string TxnId { get; set; }
        public string TxnType { get; set; }
        public decimal? BalanceAmount { get; set; }
        public string BranchQb { get; set; }
        public string UniqueTxnId { get; set; }
        public string UniqueVendorId { get; set; }
    }
}
