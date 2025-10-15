using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ApSummaryBills
    {
        public int BillsId { get; set; }
        public int? VendorId { get; set; }
        public string VendorName { get; set; }
        public string BillNumber { get; set; }
        public DateTime? BillDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? TotalBcy { get; set; }
        public decimal? BalanceBcy { get; set; }
        public decimal? BalanceFcy { get; set; }
        public int? AgePastDueDate { get; set; }
        public string PaymentTerm { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillAmountFcy { get; set; }
        public decimal? BalanceAmount { get; set; }
        public decimal? BalanceAmountFcy { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountFcy { get; set; }
        public int ImportId { get; set; }
    }
}
