using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class SortItems
    {
        public string UniqueId { get; set; }
        public string OldName { get; set; }
        public string FullyQualifiedName { get; set; }
        public string Type { get; set; }
        public string Branch { get; set; }
        public long? RecordRank { get; set; }
        public string NewDisplayName { get; set; }
    }
}
