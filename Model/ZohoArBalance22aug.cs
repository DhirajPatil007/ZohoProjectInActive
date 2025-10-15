using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoArBalance22aug
    {
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public double? InvoicedAmount { get; set; }
        public double? AmountReceived { get; set; }
        public double? ClosingBalance { get; set; }
        public double? FcyClosingBalance { get; set; }
        public string QbId { get; set; }
        public string QbCompany { get; set; }
    }
}
