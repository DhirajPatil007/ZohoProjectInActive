using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class XlsAccountsReceivable
    {
        public string MigrationDate { get; set; }
        public string ContactName { get; set; }
        public string AccountName { get; set; }
        public string DebitCredit { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Branch { get; set; }
        public string QbcustomerName { get; set; }
        public string UniqueId { get; set; }
        public string FullyQualifiedName { get; set; }
    }
}
