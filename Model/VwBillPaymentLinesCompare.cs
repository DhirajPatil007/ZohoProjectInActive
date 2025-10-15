using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwBillPaymentLinesCompare
    {
        public string Date { get; set; }
        public string UniqueId { get; set; }
        public string UniqueVendorId { get; set; }
        public string BillNumber { get; set; }
        public string TxnType { get; set; }
        public string TxnId { get; set; }
        public string PaymentNumber { get; set; }
        public decimal? Amount { get; set; }
        public string Bank { get; set; }
        public string BillDate { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? AppliedAmount { get; set; }
        public double? ZohoAmount { get; set; }
        public string ZohoTransactionId { get; set; }
        public double? UnusedAmount { get; set; }
        public string ZohoDisplayName { get; set; }
        public string CreditAcc { get; set; }
        public string DebitAcc { get; set; }
        public int PayLineId { get; set; }
        public bool IsSolved { get; set; }
        public DateTime? SolvedDateTime { get; set; }
    }
}
