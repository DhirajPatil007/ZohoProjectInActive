using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class VwUniqueZohoCustomerPaymentsBank
    {
        public string CustomerPaymentId { get; set; }
        public string Mode { get; set; }
        public string CustomerId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Status { get; set; }
        public string NewBankName { get; set; }
        public string DepositTo { get; set; }
    }
}
