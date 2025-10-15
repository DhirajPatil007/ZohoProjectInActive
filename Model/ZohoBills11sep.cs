using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoBills11sep
    {
        public string BillId { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string Status { get; set; }
        public string BillNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string Date { get; set; }
        public string DueDate { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public double? ExchangeRate { get; set; }
        public double? FcyTotal { get; set; }
        public double? BcyTotal { get; set; }
        public double? FcyBalance { get; set; }
        public double? BcyBalance { get; set; }
        public string ProjectNames { get; set; }
        public string GstNo { get; set; }
        public string QuickbooksId { get; set; }
        public string QbCompany { get; set; }
    }
}
