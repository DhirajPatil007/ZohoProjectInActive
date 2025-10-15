using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoHdfcRefund2
    {
        public string Date { get; set; }
        public double? Amount { get; set; }
        public string UniqueId { get; set; }
        public string PaymentId { get; set; }
        public string VendorName { get; set; }
        public string Uniqueid1 { get; set; }
        public string TxnId { get; set; }
        public string TxnType { get; set; }
        public decimal? AmountAppliedToBill { get; set; }
        public string TxnDate { get; set; }
        public string DocNumber { get; set; }
        public string JvlineAccountRefName { get; set; }
        public string JvlinePostingType { get; set; }
        public decimal? Jvamount { get; set; }
        public double? Diff { get; set; }
    }
}
