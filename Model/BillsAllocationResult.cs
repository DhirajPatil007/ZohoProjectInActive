using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BillsAllocationResult
    {
        public string UniqueId { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public string BillNumber { get; set; }
        public decimal? AmountAllocated { get; set; }
        public decimal? AmountBalance { get; set; }
    }
}
