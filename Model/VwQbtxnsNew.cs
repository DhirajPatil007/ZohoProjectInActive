using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwQbtxnsNew
    {
        public string UniqueId { get; set; }
        public string Txndate { get; set; }
        public string TransactionType { get; set; }
        public string EntityNumber { get; set; }
        public decimal? NetAmount { get; set; }
        public string ParentAccount { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string TbName { get; set; }
        public string ScheduleHead { get; set; }
        public string TbGroup { get; set; }
        public string QbBranch { get; set; }
        public string AccountCode { get; set; }
    }
}
