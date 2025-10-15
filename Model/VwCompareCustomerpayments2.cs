using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwCompareCustomerpayments2
    {
        public string Date { get; set; }
        public string CustomerName { get; set; }
        public decimal? Zoho { get; set; }
        public decimal? Qb { get; set; }
        public decimal? Jv { get; set; }
        public decimal? Diff { get; set; }
    }
}
