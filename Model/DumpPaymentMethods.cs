using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpPaymentMethods
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string CreateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string UniqueId { get; set; }
        public string ZohoPaymentMethod { get; set; }
        public string QbCompany { get; set; }
        public string QbShortCompany { get; set; }
    }
}
