using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ArkashReportUsdInrView
    {
        public int ImportId { get; set; }
        public DateTime? UploadedDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public int? FileWeek { get; set; }
        public string Arbranch { get; set; }
        public string Arsalesperson { get; set; }
        public string CustomerName { get; set; }
        public string PaymentTermsContacts { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Currency { get; set; }
        public decimal? CurrentUsd { get; set; }
        public decimal? CurrentInr { get; set; }
        public decimal? _015Usd { get; set; }
        public decimal? _015Inr { get; set; }
        public decimal? _1630Usd { get; set; }
        public decimal? _1630Inr { get; set; }
        public decimal? _3160Usd { get; set; }
        public decimal? _3160Inr { get; set; }
        public decimal? _6190Usd { get; set; }
        public decimal? _6190Inr { get; set; }
        public decimal? Days91120Usd { get; set; }
        public decimal? Days91120Inr { get; set; }
        public decimal? _120Usd { get; set; }
        public decimal? _120Inr { get; set; }
        public decimal? TotalBalanceUsd { get; set; }
        public decimal? TotalBalanceInr { get; set; }
        public decimal? UnusedCreditsUsd { get; set; }
        public decimal? UnusedCreditsInr { get; set; }
        public decimal? TotalOutstandingUsd { get; set; }
        public decimal? TotalOutstandingInr { get; set; }
    }
}
