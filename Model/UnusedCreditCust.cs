using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class UnusedCreditCust
    {
        public DateTime? Date { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal? AmountFcy { get; set; }
        public decimal? AmountBcy { get; set; }
        public decimal? UnusedAmountFcy { get; set; }
        public decimal? UnusedAmountBcy { get; set; }
        public string Branch { get; set; }
        public string UniqueId { get; set; }
        public string Arsalesperson { get; set; }
        public string Arbranch { get; set; }
        public string PaymentNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymentMode { get; set; }
        public string Notes { get; set; }
        public decimal? RefundAmountBcy { get; set; }
        public decimal? RefundAmountFcy { get; set; }
        public int? ImportId { get; set; }
        public int Id { get; set; }
        public DateTime? UploadedDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public string Transaction { get; set; }
    }
}
