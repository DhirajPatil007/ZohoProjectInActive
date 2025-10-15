using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpCreditNotesLineItems
    {
        public string UniqueId { get; set; }
        public string Docnumber { get; set; }
        public string Branch { get; set; }
        public string Id { get; set; }
        public int? LineNum { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string DetailType { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string ItemRefValue { get; set; }
        public string ItemRefName { get; set; }
        public decimal? UnitPrice { get; set; }
        public double? Qty { get; set; }
        public string ItemAccountRefValue { get; set; }
        public string ItemAccountRefName { get; set; }
        public string TaxCodeRefValue { get; set; }
        public int LineId { get; set; }
    }
}
