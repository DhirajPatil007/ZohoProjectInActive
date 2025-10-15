using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class JvInvoicesCredited
    {
        public int Id { get; set; }
        public string JournalInvoiceId { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public string Date { get; set; }
        public decimal? CreditedAmount { get; set; }
        public string JournalId { get; set; }
    }
}
