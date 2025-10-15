using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class BillGstapplicable
    {
        public string UniqueId { get; set; }
        public string BillDate { get; set; }
        public string BillNumber { get; set; }
        public string Gsttax { get; set; }
        public string BranchDept { get; set; }
        public string Gsttreatment { get; set; }
        public string SourceOfSupply { get; set; }
        public string DestinationOfSupply { get; set; }
    }
}
