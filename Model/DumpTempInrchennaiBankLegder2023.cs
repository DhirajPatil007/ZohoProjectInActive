using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpTempInrchennaiBankLegder2023
    {
        public long? LineId { get; set; }
        public string UniqueId { get; set; }
        public string TxnDate { get; set; }
        public string BankAccountName { get; set; }
        public string DocNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? TotalAmtFcy { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string ContactName { get; set; }
        public string ZohoDisplayName { get; set; }
        public string BranchQb { get; set; }
    }
}
