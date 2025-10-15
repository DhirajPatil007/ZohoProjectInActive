using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoCustomerstatement
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Date { get; set; }
        public string Transactions { get; set; }
        public string Details { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Payments { get; set; }
        public decimal? Balance { get; set; }
    }
}
