using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class PaymentTermMapping
    {
        public int Id { get; set; }
        public string PaymentTermLabel { get; set; }
        public int? DueDays { get; set; }
        public string Qbid { get; set; }
        public string ZohoId { get; set; }
        public string ZohoLabel { get; set; }
        public string QbCompany { get; set; }
    }
}
