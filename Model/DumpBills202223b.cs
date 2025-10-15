using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class DumpBills202223b
    {
        public string BillNumber { get; set; }
        public string BillDate { get; set; }
        public string BranchDept { get; set; }
        public string DueDate { get; set; }
        public string BillStatus { get; set; }
        public string GstTreatment { get; set; }
        public string Gstin { get; set; }
        public string OfficeStateCode { get; set; }
        public string SourceOfSupply { get; set; }
        public string DestinatonOfSupply { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string VendorNotes { get; set; }
        public string IsBillable { get; set; }
        public string ProjectName { get; set; }
        public string VendorName { get; set; }
        public string CustomerName { get; set; }
        public string IsInclusiveTax { get; set; }
        public string ItemType { get; set; }
        public string SupplyType { get; set; }
        public string LineNum { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal? Rate { get; set; }
        public string TaxName { get; set; }
        public decimal? TaxPercentage { get; set; }
        public string TaxType { get; set; }
        public string ReverseChargeTaxName { get; set; }
        public decimal? ReverseChargeTaxPercentage { get; set; }
        public string ReverseChargeTaxType { get; set; }
        public string PartialPayments { get; set; }
        public string IsReverseCharge { get; set; }
        public string ItcEligibility { get; set; }
        public string Id { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string GstCheck { get; set; }
        public string UniqueId { get; set; }
        public string SingleTax { get; set; }
        public string ImportFileName { get; set; }
        public long? RowNo { get; set; }
    }
}
