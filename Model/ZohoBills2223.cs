using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoBills2223
    {
        public string ZohoBillId { get; set; }
        public string ZohoVendorId { get; set; }
        public string VendorName { get; set; }
        public string ReferenceNumber { get; set; }
        public string BillNumber { get; set; }
        public string BillDate { get; set; }
        public string CurrencyCode { get; set; }
        public double? ExchangeRate { get; set; }
        public double? BillAmountFcy { get; set; }
        public double? BillAmount { get; set; }
        public double? BalanceAmountFcy { get; set; }
        public double? BalanceAmount { get; set; }
        public string Gstin { get; set; }
        public string Gsttreatment { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string Branch { get; set; }
    }
}
