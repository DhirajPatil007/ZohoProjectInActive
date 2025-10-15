using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class AragingDetailsCustomerWise
    {
        public string Arbranch { get; set; }
        public string Arsalesperson { get; set; }
        public string SalesPerson { get; set; }
        public DateTime? ExportDate { get; set; }
        public string CustomerName { get; set; }
        public string PaymentTermsContacts { get; set; }
        public string InvoiceStatus { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Balance { get; set; }
        public string Notes { get; set; }
        public decimal? Current { get; set; }
        public decimal? _15 { get; set; }
        public decimal? _30 { get; set; }
        public decimal? _45 { get; set; }
        public decimal? _60 { get; set; }
        public decimal? _75 { get; set; }
        public decimal? _90 { get; set; }
        public decimal? _105 { get; set; }
        public decimal? _120 { get; set; }
        public decimal? TotalBalance { get; set; }
        public decimal? UnusedCredits { get; set; }
        public decimal? TotalOutstanding { get; set; }
    }
}
