using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCurrencies
    {
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyNameFormatted { get; set; }
        public string CurrencySymbol { get; set; }
        public string PricePrecision { get; set; }
        public string CurrencyFormat { get; set; }
        public string IsBaseCurrency { get; set; }
        public string ExchangeRate { get; set; }
    }
}
