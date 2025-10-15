using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpAccountsReceivableBackup
    {
        public int? Id { get; set; }
        public string MigrationDate { get; set; }
        public string AcountName { get; set; }
        public string QbcustomerName { get; set; }
        public string DebitCredit { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public string Parent1 { get; set; }
        public string Parent2 { get; set; }
        public string Branch { get; set; }
        public string ShortBranch { get; set; }
    }
}
