using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoOverdueInvoices20jun
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public double? TotalFcy { get; set; }
        public double? BalanceFcy { get; set; }
        public double? CreditsFcy { get; set; }
        public double? PaymentFcy { get; set; }
        public double? AmountPaidFcy { get; set; }
    }
}
