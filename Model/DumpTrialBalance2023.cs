using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpTrialBalance2023
    {
        public int? SrNo { get; set; }
        public string MigrationDate { get; set; }
        public string QbaccountName { get; set; }
        public string DebitCredit { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Branch { get; set; }
        public string BranchShort { get; set; }
        public string Parent1 { get; set; }
        public string QbFullyFualifiedName { get; set; }
    }
}
