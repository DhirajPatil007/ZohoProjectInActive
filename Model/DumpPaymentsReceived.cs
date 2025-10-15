using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpPaymentsReceived
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string DepositToAccountId { get; set; }
        public string PaymentMethodId { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? UnappliedAmt { get; set; }
        public bool? ProcessPayment { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public string Id { get; set; }
        public int? SyncToken { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string TxnDate { get; set; }
        public string PrivateNote { get; set; }
        public string PaymentRefNum { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string LineItems { get; set; }
        public string BranchQb { get; set; }
        public string UniqueId { get; set; }
        public string ZohoDisplayName { get; set; }
    }
}
