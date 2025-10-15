using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class QbOpenInvoices
    {
        public string QbCompany { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public string TransactionType { get; set; }
        public string TxnDate { get; set; }
        public double? Amount { get; set; }
        public double? OpenBalance { get; set; }
        public double? ForeignAmount { get; set; }
        public double? BalanceFcy { get; set; }
        public string CurrencyCode { get; set; }
    }
}
