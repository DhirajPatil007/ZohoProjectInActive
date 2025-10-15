using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoVendorRefunds
    {
        public string RefundId { get; set; }
        public string EntityId { get; set; }
        public string Date { get; set; }
        public string RefundMode { get; set; }
        public string ReferenceNumber { get; set; }
        public string EntityNumber { get; set; }
        public string VendorName { get; set; }
        public string EntityType { get; set; }
        public string Description { get; set; }
        public double? BcyAmount { get; set; }
        public double? FcyAmount { get; set; }
        public string VendorId { get; set; }
        public string CurrencyCode { get; set; }
    }
}
