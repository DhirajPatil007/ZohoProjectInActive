using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class AugBillPaymentsImportCheck
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string UniqueId { get; set; }
        public string Date { get; set; }
        public decimal? Amount { get; set; }
        public string TxnType { get; set; }
        public string BillNumber { get; set; }
        public decimal? AmountAppliedToBill { get; set; }
        public decimal? JvAmount { get; set; }
        public string BillDate { get; set; }
        public decimal? BillAmount { get; set; }
    }
}
