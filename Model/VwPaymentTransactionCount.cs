using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwPaymentTransactionCount
    {
        public string Uniqueid { get; set; }
        public int? Invoice { get; set; }
        public int? Journalentry { get; set; }
        public int? Creditmemo { get; set; }
    }
}
