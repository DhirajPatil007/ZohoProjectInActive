using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class JvBillCredited
    {
        public int Id { get; set; }
        public string JournalBillId { get; set; }
        public string BillId { get; set; }
        public string BillNumber { get; set; }
        public string Date { get; set; }
        public decimal? CreditedAmount { get; set; }
        public string JournalId { get; set; }
    }
}
