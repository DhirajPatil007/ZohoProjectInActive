using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoDuplicateJvs
    {
        public string ZohoJv { get; set; }
        public int? DupCount { get; set; }
        public string UniqueId { get; set; }
        public string TxnType { get; set; }
    }
}
