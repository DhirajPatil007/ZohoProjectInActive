using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BillsPlanB
    {
        public string VendorName { get; set; }
        public string BillNumber { get; set; }
        public string TransactionType { get; set; }
        public string BillDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? OpenBalance { get; set; }
        public decimal? ForeignAmount { get; set; }
        public decimal? ForeignOpenBalance { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public string JobNumber { get; set; }
        public string Branch { get; set; }
    }
}
