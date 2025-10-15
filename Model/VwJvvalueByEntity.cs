using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwJvvalueByEntity
    {
        public string UniqueJvid { get; set; }
        public string Jvdate { get; set; }
        public string UniqueEntityId { get; set; }
        public string Jvlineentityrefname { get; set; }
        public string JvlineEntityType { get; set; }
        public string DocNumber { get; set; }
        public decimal? JvAmount { get; set; }
    }
}
