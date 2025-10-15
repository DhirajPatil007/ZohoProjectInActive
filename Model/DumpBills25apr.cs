using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpBills25apr
    {
        public string DueDate { get; set; }
        public string VendorAddressId { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorAddress3 { get; set; }
        public string VendorAddress4 { get; set; }
        public string VendorAddress5 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorCountry { get; set; }
        public string VendorZip { get; set; }
        public decimal? Balance { get; set; }
        public decimal? HomeBalance { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public string Id { get; set; }
        public int? SyncToken { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string DocNumber { get; set; }
        public string TxnDate { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PrivateNote { get; set; }
        public string LinkedTxn { get; set; }
        public string LineItems { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string ApaccountRefId { get; set; }
        public string ApaccountRefName { get; set; }
        public string GlobalTaxCalculation { get; set; }
        public decimal? TotalAmt { get; set; }
        public string InvoiceStatus { get; set; }
        public string BranchDept { get; set; }
        public int? RecordRank { get; set; }
        public string UniqueId { get; set; }
        public string NewDocNumber { get; set; }
    }
}
