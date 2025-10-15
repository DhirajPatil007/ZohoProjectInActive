using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpChartOfAccounts
    {
        public string QbId { get; set; }
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public string AccountType { get; set; }
        public string ParentAccountId { get; set; }
        public int? ParentAccount { get; set; }
        public string Account { get; set; }
        public string Currency { get; set; }
        public string OpeningBalance { get; set; }
        public string DebitOrCredit { get; set; }
        public string QbCompany { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
