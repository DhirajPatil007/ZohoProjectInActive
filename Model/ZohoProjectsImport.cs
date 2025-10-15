using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoProjectsImport
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string BillingType { get; set; }
        public string ProjectCost { get; set; }
        public string CustomerName { get; set; }
        public string CurrencyCode { get; set; }
        public string BudgetType { get; set; }
        public string BudgetAmount { get; set; }
        public string CostBudget { get; set; }
        public string ProjectBudgetHours { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectBranch { get; set; }
    }
}
