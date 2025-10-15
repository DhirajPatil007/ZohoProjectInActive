using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoChargeItems
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Sku { get; set; }
        public string Upc { get; set; }
        public string Mpn { get; set; }
        public string Ean { get; set; }
        public string Isbn { get; set; }
        public string IsReturnableItem { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string HsnSac { get; set; }
        public string Description { get; set; }
        public string Rate { get; set; }
        public string Account { get; set; }
        public string AccountCode { get; set; }
        public double? PackageWeight { get; set; }
        public double? PackageLength { get; set; }
        public double? PackageWidth { get; set; }
        public double? PackageHeight { get; set; }
        public string DimensionUnit { get; set; }
        public string WeightUnit { get; set; }
        public string Taxable { get; set; }
        public string ExemptionReason { get; set; }
        public string TaxabilityType { get; set; }
        public string ProductType { get; set; }
        public string IntraStateTaxName { get; set; }
        public string IntraStateTaxRate { get; set; }
        public string IntraStateTaxType { get; set; }
        public string InterStateTaxName { get; set; }
        public string InterStateTaxRate { get; set; }
        public string InterStateTaxType { get; set; }
        public string Source { get; set; }
        public string ReferenceId { get; set; }
        public string LastSyncTime { get; set; }
        public string Status { get; set; }
        public string UsageUnit { get; set; }
        public string PurchaseRate { get; set; }
        public string PurchaseAccount { get; set; }
        public string PurchaseAccountCode { get; set; }
        public string PurchaseDescription { get; set; }
        public string InventoryAccount { get; set; }
        public string InventoryAccountCode { get; set; }
        public string ReorderPoint { get; set; }
        public string Vendor { get; set; }
        public string OpeningStock { get; set; }
        public string OpeningStockValue { get; set; }
        public string StockOnHand { get; set; }
        public string ItemType { get; set; }
        public string Location { get; set; }
        public string QbCompany { get; set; }
        public string QuickbooksId { get; set; }
    }
}
