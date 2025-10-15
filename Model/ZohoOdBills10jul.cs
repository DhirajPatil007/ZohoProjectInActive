using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoOdBills10jul
    {
        public string BillDate { get; set; }
        public string DueDate { get; set; }
        public string BillNumber { get; set; }
        public string VendorName { get; set; }
        public double? BillAmount { get; set; }
        public double? BalanceAmount { get; set; }
        public double? BillAmountFcy { get; set; }
        public double? BalanceAmountFcy { get; set; }
        public string Gstin { get; set; }
        public string Gsttreatment { get; set; }
        public string Branch { get; set; }
        public string QbCompany { get; set; }
        public string QuickbooksId { get; set; }
    }
}
