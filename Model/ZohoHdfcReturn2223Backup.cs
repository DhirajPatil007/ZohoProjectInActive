using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoHdfcReturn2223Backup
    {
        public string PaymentId { get; set; }
        public string PaymentNumber { get; set; }
        public string BillNumbers { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string PaymentMode { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string ReferenceNumber { get; set; }
        public double? Amount { get; set; }
        public double? BcyAmount { get; set; }
        public double? UnusedAmount { get; set; }
        public double? BcyUnusedAmount { get; set; }
        public string PaidThroughAccountId { get; set; }
        public string IsPaidViaPrintCheck { get; set; }
        public string PaidThroughAccountName { get; set; }
        public string CheckId { get; set; }
        public string CheckNumber { get; set; }
        public string CheckStatus { get; set; }
        public string UniqueId { get; set; }
        public string CurrencyCode { get; set; }
        public double? ExchangeRate { get; set; }
        public string BranchName { get; set; }
        public int? UniqueCount { get; set; }
    }
}
