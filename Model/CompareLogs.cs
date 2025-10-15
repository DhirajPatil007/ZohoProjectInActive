using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class CompareLogs
    {
        public string VendorName { get; set; }
        public string TxnDate { get; set; }
        public string TransactionType { get; set; }
        public string ReferenceNumber { get; set; }
        public double? NetAmt { get; set; }
        public double? FcyNetAmt { get; set; }
        public string MismatchType { get; set; }
        public string TxnId { get; set; }
        public string QuickbooksDate { get; set; }
        public string ZohoDate { get; set; }
        public double? QuickbooksNetAmount { get; set; }
        public double? ZohoNetAmount { get; set; }
        public double? QuickbooksFcyNetAmount { get; set; }
        public double? ZohoFcyNetAmount { get; set; }
        public string QuickbooksSource { get; set; }
        public string ZohoSource { get; set; }
        public DateTime? DateCompared { get; set; }
    }
}
