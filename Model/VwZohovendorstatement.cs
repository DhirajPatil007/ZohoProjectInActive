using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwZohovendorstatement
    {
        public int? VendorId { get; set; }
        public string Vendorname { get; set; }
        public string Date { get; set; }
        public string Transactions { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RunningBalance { get; set; }
    }
}
