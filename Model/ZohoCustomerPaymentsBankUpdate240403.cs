using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCustomerPaymentsBankUpdate240403
    {
        public string UniqueId { get; set; }
        public int Lineid { get; set; }
        public string TransactionType { get; set; }
        public string TxnDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public string ZohoDisplayName { get; set; }
        public string BranchQb { get; set; }
        public string DocNumber { get; set; }
        public string ZohoTxnid { get; set; }
        public string BankAccountName { get; set; }
        public string ZohoBank { get; set; }
        public string NewBank { get; set; }
        public string NewBankId { get; set; }
        public int Id { get; set; }
        public string LineStatus { get; set; }
    }
}
