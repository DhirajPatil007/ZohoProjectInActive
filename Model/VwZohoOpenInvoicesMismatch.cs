using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwZohoOpenInvoicesMismatch
    {
        public string Customername { get; set; }
        public string QbCustomer { get; set; }
        public string InvoiceNumber { get; set; }
        public string TxnDate { get; set; }
        public string Docnumber { get; set; }
        public double? TotalAmountFcy { get; set; }
        public double? BalanceFcy { get; set; }
        public decimal? QbTotal { get; set; }
        public decimal? QbBalance { get; set; }
    }
}
