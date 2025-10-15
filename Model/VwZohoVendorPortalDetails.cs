using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwZohoVendorPortalDetails
    {
        public string Date { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string EntityNumber { get; set; }
        public decimal? FcyCredit { get; set; }
        public decimal? FcyDebit { get; set; }
        public decimal? FcyNetAmount { get; set; }
        public double? Excess { get; set; }
        public string ContactId { get; set; }
        public string Description { get; set; }
        public string DebitAcc { get; set; }
        public string CreditAcc { get; set; }
    }
}
