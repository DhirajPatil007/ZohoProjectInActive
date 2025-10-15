using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoProjects
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string BillingType { get; set; }
        public double? FcyRate { get; set; }
        public double? BudgetHours { get; set; }
        public string BudgetHoursInTime { get; set; }
        public string IsLoggedhoursExceeded { get; set; }
        public int ProjectId1 { get; set; }
        public string LineStatus { get; set; }
    }
}
