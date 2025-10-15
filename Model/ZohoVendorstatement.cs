using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoVendorstatement
    {
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public string VendorName { get; set; }
        public string Date { get; set; }
        public string Transactions { get; set; }
        public string Details { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Payments { get; set; }
        public decimal? Balance { get; set; }
    }
}
