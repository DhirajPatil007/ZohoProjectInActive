using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpDepositLinesTest
    {
        public string UniqueId { get; set; }
        public string DepositToAccountId { get; set; }
        public string DepositToAccountName { get; set; }
        public string ZohoAccountName { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? HomeTotalAmt { get; set; }
        public string DocNumber { get; set; }
        public string TxnDate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public string UniqueTxnId { get; set; }
        public string TxnType { get; set; }
        public string TxnLineId { get; set; }
        public string PrivateNote { get; set; }
        public string DepartmentId { get; set; }
        public string BranchQb { get; set; }
        public string ZohoDisplayName { get; set; }
    }
}
