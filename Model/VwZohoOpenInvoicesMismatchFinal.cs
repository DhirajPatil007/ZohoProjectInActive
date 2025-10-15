using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwZohoOpenInvoicesMismatchFinal
    {
        public string Customername { get; set; }
        public string CurrencyCode { get; set; }
        public string QbCustomer { get; set; }
        public string InvoiceNumber { get; set; }
        public string TxnDate { get; set; }
        public string Docnumber { get; set; }
        public double? TotalAmountFcy { get; set; }
        public double? BalanceFcy { get; set; }
        public decimal? QbTotal { get; set; }
        public decimal? QbBalance { get; set; }
        public string Branch { get; set; }
    }
}
