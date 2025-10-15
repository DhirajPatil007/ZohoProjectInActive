using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class SortProjects
    {
        public string NewProjectName { get; set; }
        public string OldName { get; set; }
        public string ZohoCustomerName { get; set; }
        public string BillingType { get; set; }
        public string BudgetType { get; set; }
        public int BudgetAmount { get; set; }
        public int ProjectBudgetHours { get; set; }
        public string CurrencyCode { get; set; }
        public int ProjectCost { get; set; }
        public string ProjectBranch { get; set; }
        public string UniqueCustomerId { get; set; }
        public string Branch { get; set; }
        public long? RecordRank { get; set; }
    }
}
