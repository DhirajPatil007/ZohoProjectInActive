using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Arbranch { get; set; }
        public string Arsalesperson { get; set; }
        public decimal? UnusedCredits { get; set; }
        public decimal? UnusedCreditsFcy { get; set; }
        public string PaymentTermsContacts { get; set; }
        public string Flbranch { get; set; }
        public string Branch { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? ImportId { get; set; }
        public DateTime? UploadedDate { get; set; }
    }
}
