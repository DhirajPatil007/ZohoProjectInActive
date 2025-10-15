using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpBillPayments
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string PayType { get; set; }
        public string BankAccountId { get; set; }
        public string BankAccountName { get; set; }
        public decimal? TotalAmt { get; set; }
        public string DocNumber { get; set; }
        public string TxnDate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PrivateNote { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string LineItems { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public string Id { get; set; }
        public int? SyncToken { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string BranchQb { get; set; }
        public string UniqueId { get; set; }
        public string ZohoDisplayName { get; set; }
    }
}
