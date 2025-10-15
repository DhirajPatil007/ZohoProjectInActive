using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwBillAmountAllocated
    {
        public string Billtxnid { get; set; }
        public string Billnumber { get; set; }
        public decimal? Amountallocated { get; set; }
        public string UniqueVendorid { get; set; }
    }
}
