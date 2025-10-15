using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwVendorOpeningBalances
    {
        public int? SrNo { get; set; }
        public string MigrationDate { get; set; }
        public string ShortBranch { get; set; }
        public string VendorName { get; set; }
        public string ZohoDisplayName { get; set; }
        public decimal? Amount { get; set; }
    }
}
