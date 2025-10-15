using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class InvoiceBillApril
    {
        public string DocNumber { get; set; }
        public string JobNumber { get; set; }
        public DateTime? TxnDate { get; set; }
        public string CustomerVendor { get; set; }
        public string Location { get; set; }
        public string TxnType { get; set; }
    }
}
