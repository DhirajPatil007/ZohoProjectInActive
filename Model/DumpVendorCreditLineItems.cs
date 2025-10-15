using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpVendorCreditLineItems
    {
        public string UniqueId { get; set; }
        public string Docnumber { get; set; }
        public string Branch { get; set; }
        public string Id { get; set; }
        public int? LineNum { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string DetailType { get; set; }
        public string ClassRefValue { get; set; }
        public string ClassRefName { get; set; }
        public string AccountRefValue { get; set; }
        public string AccountRefName { get; set; }
        public string BillableStatus { get; set; }
        public string TaxCodeRef { get; set; }
        public int LineId { get; set; }
    }
}
