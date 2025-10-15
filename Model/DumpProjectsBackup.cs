using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpProjectsBackup
    {
        public string ProjectName { get; set; }
        public string ZohoCustomerName { get; set; }
        public string BillingType { get; set; }
        public string BudgetType { get; set; }
        public int BudgetAmount { get; set; }
        public int ProjectBudgetHours { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ProjectCost { get; set; }
        public string ProjectBranch { get; set; }
        public string InvoiceNumber { get; set; }
        public string Jobnumber { get; set; }
        public string InvoiceDate { get; set; }
        public string Branch { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string UniqueCustomerId { get; set; }
    }
}
