using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BillAllocationResultAugust
    {
        public string UniqueId { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public string BillTxnId { get; set; }
        public string BillNumber { get; set; }
        public decimal? AmountAllocated { get; set; }
        public decimal? AmountBalance { get; set; }
        public string UniqueVendorId { get; set; }
    }
}
