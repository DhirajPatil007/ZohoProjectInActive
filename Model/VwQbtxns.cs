using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwQbtxns
    {
        public string UniqueId { get; set; }
        public string Txndate { get; set; }
        public string TransactionType { get; set; }
        public string EntityNumber { get; set; }
        public decimal? NetAmount { get; set; }
        public string ParentAccount { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
    }
}
