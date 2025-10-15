using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class OpenAllocationsAugust
    {
        public string Uniqueid { get; set; }
        public string UniqueTxnId { get; set; }
        public string BillDate { get; set; }
        public string BillNumber { get; set; }
        public decimal? BillBalance { get; set; }
        public string UniqueVendorId { get; set; }
    }
}
