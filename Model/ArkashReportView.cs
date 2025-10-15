using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ArkashReportView
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
        public decimal? Current { get; set; }
        public decimal? _15 { get; set; }
        public decimal? _30 { get; set; }
        public decimal? _45 { get; set; }
        public decimal? _60 { get; set; }
        public decimal? Days3160 { get; set; }
        public decimal? _75 { get; set; }
        public decimal? _90 { get; set; }
        public decimal? Days6190 { get; set; }
        public decimal? _105 { get; set; }
        public decimal? Days106120 { get; set; }
        public decimal? Days91120 { get; set; }
        public decimal? _120 { get; set; }
        public decimal? TotalBalance { get; set; }
        public decimal? UnusedCredits { get; set; }
        public decimal? TotalOutstanding { get; set; }
    }
}
