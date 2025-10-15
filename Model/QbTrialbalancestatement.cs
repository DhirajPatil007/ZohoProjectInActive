using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class QbTrialbalancestatement
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string TransactionType { get; set; }
        public string No { get; set; }
        public string Adj { get; set; }
        public string Name { get; set; }
        public string MemoDescription { get; set; }
        public string Account { get; set; }
        public string Split { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string Currency { get; set; }
        public decimal? ForeignDebit { get; set; }
        public decimal? ForeignCredit { get; set; }
        public decimal? ForeignAmount { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Location { get; set; }
        public decimal? RevaluedExchangeRate { get; set; }
        public decimal? RevaluedAmount { get; set; }
        public decimal? UnrealisedGainLoss { get; set; }
        public string ProductService { get; set; }
        public string TaxName { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? ForeignTaxAmount { get; set; }
        public string Branch { get; set; }
        public string FileName { get; set; }
        public string Year { get; set; }
    }
}
