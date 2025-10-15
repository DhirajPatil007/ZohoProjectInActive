using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpChartOfAccountsSort
    {
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public string AccountType { get; set; }
        public string ParentAccount { get; set; }
        public string Currency { get; set; }
        public string QbId { get; set; }
        public string QbAccountName { get; set; }
        public int? AccLevel { get; set; }
        public string Qbcompany { get; set; }
        public bool? IsActive { get; set; }
    }
}
