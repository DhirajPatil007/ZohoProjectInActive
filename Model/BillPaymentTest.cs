using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BillPaymentTest
    {
        public int Id { get; set; }
        public string Uniqueid { get; set; }
        public string Date { get; set; }
        public string PaidThrough { get; set; }
        public decimal? QbAmount { get; set; }
        public decimal? ZohoAmount { get; set; }
        public string ZohoBank { get; set; }
        public string ZohoPaymentId { get; set; }
        public string Invoice { get; set; }
        public decimal? AmountAppliedToInvoice { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public decimal? JvCredit { get; set; }
        public decimal? JvDebit { get; set; }
        public decimal? Purchase { get; set; }
        public decimal? VendorCredits { get; set; }
        public decimal? Total { get; set; }
        public string PaidThroghAccountId { get; set; }
        public string Status { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
