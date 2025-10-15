using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class XlsTrialBalance2023
    {
        public string MigrationDate { get; set; }
        public string AccountName { get; set; }
        public string DebitCredit { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Branch { get; set; }
        public int? SrNo { get; set; }
        public string QbaccountName { get; set; }
        public string ParentAccount { get; set; }
        public string BranchShort { get; set; }
        public string AccountCode { get; set; }
        public string QbId { get; set; }
    }
}
