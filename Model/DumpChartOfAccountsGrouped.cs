using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpChartOfAccountsGrouped
    {
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public string AccountType { get; set; }
        public string ParentAccount { get; set; }
        public string Currency { get; set; }
        public double? QbId { get; set; }
        public string QbAccountName { get; set; }
        public double? AccLevel { get; set; }
        public string Qbcompany { get; set; }
        public string IsActive { get; set; }
        public string ZohoAcountType { get; set; }
        public string TbGroup { get; set; }
        public string ScheduleHead { get; set; }
        public string TbName { get; set; }
        public string Qbbranch { get; set; }
    }
}
