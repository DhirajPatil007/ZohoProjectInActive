using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoOverdueInvoices18jun
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public double? Total { get; set; }
        public string Branch { get; set; }
        public double? TotalFcy { get; set; }
        public double? BalanceFcy { get; set; }
        public double? CreditsFcy { get; set; }
        public double? PaymentFcy { get; set; }
        public double? AmountPaidFcy { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
        public string Gstin { get; set; }
    }
}
