using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class InvoicesPlanB
    {
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public string TransactionType { get; set; }
        public string InvoiceDate { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? OpenBalance { get; set; }
        public decimal? ForeignAmount { get; set; }
        public decimal? ForeignOpenBalance { get; set; }
        public string Currency { get; set; }
        public string Branch { get; set; }
    }
}
