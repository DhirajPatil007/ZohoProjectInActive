using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoAPIProjectInactiveContext : DbContext
    {
        public ZohoAPIProjectInactiveContext()
        {
        }

        public ZohoAPIProjectInactiveContext(DbContextOptions<ZohoAPIProjectInactiveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApSummaryBills> ApSummaryBills { get; set; }
        public virtual DbSet<ApSummaryVendors> ApSummaryVendors { get; set; }
        public virtual DbSet<ApSummayReportFilesList> ApSummayReportFilesList { get; set; }
        public virtual DbSet<ApagingDetails> ApagingDetails { get; set; }
        public virtual DbSet<AragingDetails> AragingDetails { get; set; }
        public virtual DbSet<AragingDetails2> AragingDetails2 { get; set; }
        public virtual DbSet<AragingDetailsCustomerWise> AragingDetailsCustomerWise { get; set; }
        public virtual DbSet<ArkashReportInrView> ArkashReportInrView { get; set; }
        public virtual DbSet<ArkashReportUsdInrView> ArkashReportUsdInrView { get; set; }
        public virtual DbSet<ArkashReportView> ArkashReportView { get; set; }
        public virtual DbSet<AugBillPaymentsImportCheck> AugBillPaymentsImportCheck { get; set; }
        public virtual DbSet<BackupDumpBankLegder> BackupDumpBankLegder { get; set; }
        public virtual DbSet<BackupDumpBankTransfer> BackupDumpBankTransfer { get; set; }
        public virtual DbSet<BackupZohoBankLedger> BackupZohoBankLedger { get; set; }
        public virtual DbSet<BillAllocationResult> BillAllocationResult { get; set; }
        public virtual DbSet<BillAllocationResultAugust> BillAllocationResultAugust { get; set; }
        public virtual DbSet<BillGstapplicable> BillGstapplicable { get; set; }
        public virtual DbSet<BillJvpaymentTest> BillJvpaymentTest { get; set; }
        public virtual DbSet<BillPaymentTest> BillPaymentTest { get; set; }
        public virtual DbSet<BilllineitemsView> BilllineitemsView { get; set; }
        public virtual DbSet<BillsAllocationResult> BillsAllocationResult { get; set; }
        public virtual DbSet<BillsPlanB> BillsPlanB { get; set; }
        public virtual DbSet<BordoKutuCategory> BordoKutuCategory { get; set; }
        public virtual DbSet<BranchList> BranchList { get; set; }
        public virtual DbSet<CompareLogs> CompareLogs { get; set; }
        public virtual DbSet<CompareQbCustomerdata> CompareQbCustomerdata { get; set; }
        public virtual DbSet<CompareQbVendordata> CompareQbVendordata { get; set; }
        public virtual DbSet<CompareQbVendordataNew> CompareQbVendordataNew { get; set; }
        public virtual DbSet<CompareZohoCustomerdata> CompareZohoCustomerdata { get; set; }
        public virtual DbSet<CompareZohoVendordata> CompareZohoVendordata { get; set; }
        public virtual DbSet<CompareZohoVendordataNew> CompareZohoVendordataNew { get; set; }
        public virtual DbSet<CreditNotesLineItemsView> CreditNotesLineItemsView { get; set; }
        public virtual DbSet<CsvApplyMultijvSingleInvoice> CsvApplyMultijvSingleInvoice { get; set; }
        public virtual DbSet<CsvApplySingleJvMultiInvoices> CsvApplySingleJvMultiInvoices { get; set; }
        public virtual DbSet<CsvBillPaymentImportJuly> CsvBillPaymentImportJuly { get; set; }
        public virtual DbSet<CsvBillPaymentsApril18> CsvBillPaymentsApril18 { get; set; }
        public virtual DbSet<CsvJvBills20230708> CsvJvBills20230708 { get; set; }
        public virtual DbSet<CsvJvBills20230717> CsvJvBills20230717 { get; set; }
        public virtual DbSet<CsvJvBills20230719> CsvJvBills20230719 { get; set; }
        public virtual DbSet<CsvJvFinal> CsvJvFinal { get; set; }
        public virtual DbSet<CsvJvInvoices20230611> CsvJvInvoices20230611 { get; set; }
        public virtual DbSet<CsvJvInvoices20230611Fixed> CsvJvInvoices20230611Fixed { get; set; }
        public virtual DbSet<CsvVendorOpeningBalance> CsvVendorOpeningBalance { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DumpAccountsPayable> DumpAccountsPayable { get; set; }
        public virtual DbSet<DumpAccountsPayable2023> DumpAccountsPayable2023 { get; set; }
        public virtual DbSet<DumpAccountsPayableBackup> DumpAccountsPayableBackup { get; set; }
        public virtual DbSet<DumpAccountsReceivable> DumpAccountsReceivable { get; set; }
        public virtual DbSet<DumpAccountsReceivable2023> DumpAccountsReceivable2023 { get; set; }
        public virtual DbSet<DumpAccountsReceivableBackup> DumpAccountsReceivableBackup { get; set; }
        public virtual DbSet<DumpBankLedger14mar> DumpBankLedger14mar { get; set; }
        public virtual DbSet<DumpBankLegder> DumpBankLegder { get; set; }
        public virtual DbSet<DumpBankLegder20240330> DumpBankLegder20240330 { get; set; }
        public virtual DbSet<DumpBankTransfer> DumpBankTransfer { get; set; }
        public virtual DbSet<DumpBillLineItems> DumpBillLineItems { get; set; }
        public virtual DbSet<DumpBillPaymentLines1aug> DumpBillPaymentLines1aug { get; set; }
        public virtual DbSet<DumpBillPaymentLines28apr> DumpBillPaymentLines28apr { get; set; }
        public virtual DbSet<DumpBillPaymentLinesOct23> DumpBillPaymentLinesOct23 { get; set; }
        public virtual DbSet<DumpBillPaymentTxnType> DumpBillPaymentTxnType { get; set; }
        public virtual DbSet<DumpBillPayments> DumpBillPayments { get; set; }
        public virtual DbSet<DumpBillTest> DumpBillTest { get; set; }
        public virtual DbSet<DumpBills202223b> DumpBills202223b { get; set; }
        public virtual DbSet<DumpBills202223c> DumpBills202223c { get; set; }
        public virtual DbSet<DumpBills202324a> DumpBills202324a { get; set; }
        public virtual DbSet<DumpBills25apr> DumpBills25apr { get; set; }
        public virtual DbSet<DumpBills28apr> DumpBills28apr { get; set; }
        public virtual DbSet<DumpBillsExcel> DumpBillsExcel { get; set; }
        public virtual DbSet<DumpBillsPlanb> DumpBillsPlanb { get; set; }
        public virtual DbSet<DumpChartOfAccounts> DumpChartOfAccounts { get; set; }
        public virtual DbSet<DumpChartOfAccounts1> DumpChartOfAccounts1 { get; set; }
        public virtual DbSet<DumpChartOfAccounts28apr> DumpChartOfAccounts28apr { get; set; }
        public virtual DbSet<DumpChartOfAccountsFinal> DumpChartOfAccountsFinal { get; set; }
        public virtual DbSet<DumpChartOfAccountsGrouped> DumpChartOfAccountsGrouped { get; set; }
        public virtual DbSet<DumpChartOfAccountsImport> DumpChartOfAccountsImport { get; set; }
        public virtual DbSet<DumpChartOfAccountsOldGrouped> DumpChartOfAccountsOldGrouped { get; set; }
        public virtual DbSet<DumpChartOfAccountsSort> DumpChartOfAccountsSort { get; set; }
        public virtual DbSet<DumpCreditNotes28apr> DumpCreditNotes28apr { get; set; }
        public virtual DbSet<DumpCreditNotesLineItems> DumpCreditNotesLineItems { get; set; }
        public virtual DbSet<DumpCustomers> DumpCustomers { get; set; }
        public virtual DbSet<DumpCustomers25apr> DumpCustomers25apr { get; set; }
        public virtual DbSet<DumpCustomers28apr> DumpCustomers28apr { get; set; }
        public virtual DbSet<DumpCustomersBackup> DumpCustomersBackup { get; set; }
        public virtual DbSet<DumpDepositLinesTest> DumpDepositLinesTest { get; set; }
        public virtual DbSet<DumpDeposits> DumpDeposits { get; set; }
        public virtual DbSet<DumpHdfc2223> DumpHdfc2223 { get; set; }
        public virtual DbSet<DumpHdfcLedgerApr22> DumpHdfcLedgerApr22 { get; set; }
        public virtual DbSet<DumpHdfcLegder2223> DumpHdfcLegder2223 { get; set; }
        public virtual DbSet<DumpHdfcLegder2223Backup> DumpHdfcLegder2223Backup { get; set; }
        public virtual DbSet<DumpImportPurchase20jul> DumpImportPurchase20jul { get; set; }
        public virtual DbSet<DumpInvoiceLineItems> DumpInvoiceLineItems { get; set; }
        public virtual DbSet<DumpInvoiceTest> DumpInvoiceTest { get; set; }
        public virtual DbSet<DumpInvoices> DumpInvoices { get; set; }
        public virtual DbSet<DumpInvoices25apr> DumpInvoices25apr { get; set; }
        public virtual DbSet<DumpInvoices28apr> DumpInvoices28apr { get; set; }
        public virtual DbSet<DumpItems> DumpItems { get; set; }
        public virtual DbSet<DumpItems25apr> DumpItems25apr { get; set; }
        public virtual DbSet<DumpItems28apr> DumpItems28apr { get; set; }
        public virtual DbSet<DumpItemsBackup> DumpItemsBackup { get; set; }
        public virtual DbSet<DumpItemsFinal> DumpItemsFinal { get; set; }
        public virtual DbSet<DumpJournalEntry> DumpJournalEntry { get; set; }
        public virtual DbSet<DumpJournalLines> DumpJournalLines { get; set; }
        public virtual DbSet<DumpJournalList> DumpJournalList { get; set; }
        public virtual DbSet<DumpPaymentMethods> DumpPaymentMethods { get; set; }
        public virtual DbSet<DumpPaymentReceivedLines> DumpPaymentReceivedLines { get; set; }
        public virtual DbSet<DumpPaymentReceivedLinesOnAccount> DumpPaymentReceivedLinesOnAccount { get; set; }
        public virtual DbSet<DumpPaymentReceivedLinesOpeningBalance> DumpPaymentReceivedLinesOpeningBalance { get; set; }
        public virtual DbSet<DumpPaymentTxnType> DumpPaymentTxnType { get; set; }
        public virtual DbSet<DumpPaymentsReceived> DumpPaymentsReceived { get; set; }
        public virtual DbSet<DumpProjects> DumpProjects { get; set; }
        public virtual DbSet<DumpProjectsBackup> DumpProjectsBackup { get; set; }
        public virtual DbSet<DumpProjectsBackup25apr> DumpProjectsBackup25apr { get; set; }
        public virtual DbSet<DumpProjectsBackup28apr> DumpProjectsBackup28apr { get; set; }
        public virtual DbSet<DumpPurchaseLines> DumpPurchaseLines { get; set; }
        public virtual DbSet<DumpPurchases> DumpPurchases { get; set; }
        public virtual DbSet<DumpSalesPersons> DumpSalesPersons { get; set; }
        public virtual DbSet<DumpTbJournals> DumpTbJournals { get; set; }
        public virtual DbSet<DumpTempInrchennaiBankLegder2023> DumpTempInrchennaiBankLegder2023 { get; set; }
        public virtual DbSet<DumpTempInrflmBankLegder2023> DumpTempInrflmBankLegder2023 { get; set; }
        public virtual DbSet<DumpTrialBalance> DumpTrialBalance { get; set; }
        public virtual DbSet<DumpTrialBalance2023> DumpTrialBalance2023 { get; set; }
        public virtual DbSet<DumpTrialBalanceBackup> DumpTrialBalanceBackup { get; set; }
        public virtual DbSet<DumpVendorCreditLineItems> DumpVendorCreditLineItems { get; set; }
        public virtual DbSet<DumpVendorCredits28apr> DumpVendorCredits28apr { get; set; }
        public virtual DbSet<DumpVendorMapping> DumpVendorMapping { get; set; }
        public virtual DbSet<DumpVendors> DumpVendors { get; set; }
        public virtual DbSet<DumpVendors22> DumpVendors22 { get; set; }
        public virtual DbSet<DumpVendors25apr> DumpVendors25apr { get; set; }
        public virtual DbSet<DumpVendors28apr> DumpVendors28apr { get; set; }
        public virtual DbSet<DumpVendorsBackup> DumpVendorsBackup { get; set; }
        public virtual DbSet<DumpVendorsNew25apr> DumpVendorsNew25apr { get; set; }
        public virtual DbSet<DumpVendorsNew28apr> DumpVendorsNew28apr { get; set; }
        public virtual DbSet<DumpZohoJv2223> DumpZohoJv2223 { get; set; }
        public virtual DbSet<FileList> FileList { get; set; }
        public virtual DbSet<FixVendorData> FixVendorData { get; set; }
        public virtual DbSet<Fretlog202308> Fretlog202308 { get; set; }
        public virtual DbSet<GaneshJvLot> GaneshJvLot { get; set; }
        public virtual DbSet<GaneshJvLot2> GaneshJvLot2 { get; set; }
        public virtual DbSet<GstTypeMaster> GstTypeMaster { get; set; }
        public virtual DbSet<GststateCodes> GststateCodes { get; set; }
        public virtual DbSet<Invoice202223C> Invoice202223C { get; set; }
        public virtual DbSet<Invoice202324A> Invoice202324A { get; set; }
        public virtual DbSet<InvoiceAgingView> InvoiceAgingView { get; set; }
        public virtual DbSet<InvoiceBillApril> InvoiceBillApril { get; set; }
        public virtual DbSet<InvoiceLineItemsView> InvoiceLineItemsView { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<InvoicesPlanB> InvoicesPlanB { get; set; }
        public virtual DbSet<InvoicesPlanBXls> InvoicesPlanBXls { get; set; }
        public virtual DbSet<JournalLineItemView> JournalLineItemView { get; set; }
        public virtual DbSet<JvBillCredited> JvBillCredited { get; set; }
        public virtual DbSet<JvConvertedToPayment> JvConvertedToPayment { get; set; }
        public virtual DbSet<JvInvoiceBranchfix202223> JvInvoiceBranchfix202223 { get; set; }
        public virtual DbSet<JvInvoiceCredit201820> JvInvoiceCredit201820 { get; set; }
        public virtual DbSet<JvInvoiceCredit202022> JvInvoiceCredit202022 { get; set; }
        public virtual DbSet<JvInvoiceCredit202223> JvInvoiceCredit202223 { get; set; }
        public virtual DbSet<JvInvoicesCredited> JvInvoicesCredited { get; set; }
        public virtual DbSet<LedgerTempInrMumbaiFlc2223> LedgerTempInrMumbaiFlc2223 { get; set; }
        public virtual DbSet<MergedCustomerData> MergedCustomerData { get; set; }
        public virtual DbSet<MergedCustomerData202308244pm> MergedCustomerData202308244pm { get; set; }
        public virtual DbSet<MergedCustomerData20230825> MergedCustomerData20230825 { get; set; }
        public virtual DbSet<MergedCustomerDataBackup> MergedCustomerDataBackup { get; set; }
        public virtual DbSet<MergedVendorData> MergedVendorData { get; set; }
        public virtual DbSet<MergedVendorDataNew> MergedVendorDataNew { get; set; }
        public virtual DbSet<MessageList> MessageList { get; set; }
        public virtual DbSet<Old2DumpBankLegder> Old2DumpBankLegder { get; set; }
        public virtual DbSet<Old2ZohoBankLedger> Old2ZohoBankLedger { get; set; }
        public virtual DbSet<OldDumpBankLegder> OldDumpBankLegder { get; set; }
        public virtual DbSet<OldZohoBankLedger> OldZohoBankLedger { get; set; }
        public virtual DbSet<OpenAllocations> OpenAllocations { get; set; }
        public virtual DbSet<OpenAllocationsAugust> OpenAllocationsAugust { get; set; }
        public virtual DbSet<OpenBillpayments> OpenBillpayments { get; set; }
        public virtual DbSet<OpenBillpaymentsAugust> OpenBillpaymentsAugust { get; set; }
        public virtual DbSet<OpenJournalpayments> OpenJournalpayments { get; set; }
        public virtual DbSet<PaymentTermMapping> PaymentTermMapping { get; set; }
        public virtual DbSet<QbCustomJv> QbCustomJv { get; set; }
        public virtual DbSet<QbCustomJv2> QbCustomJv2 { get; set; }
        public virtual DbSet<QbHdfc2223> QbHdfc2223 { get; set; }
        public virtual DbSet<QbHdfc2223Backup> QbHdfc2223Backup { get; set; }
        public virtual DbSet<QbHdfc2223Staging> QbHdfc2223Staging { get; set; }
        public virtual DbSet<QbItemHsn> QbItemHsn { get; set; }
        public virtual DbSet<QbOpenInvoices> QbOpenInvoices { get; set; }
        public virtual DbSet<QbTrialbalancestatement> QbTrialbalancestatement { get; set; }
        public virtual DbSet<QbzohoTaxMappings> QbzohoTaxMappings { get; set; }
        public virtual DbSet<QbzohoTaxMappingsView> QbzohoTaxMappingsView { get; set; }
        public virtual DbSet<ReportFilesList> ReportFilesList { get; set; }
        public virtual DbSet<ReportFilesListNew> ReportFilesListNew { get; set; }
        public virtual DbSet<SortBillPaymentLines28apr> SortBillPaymentLines28apr { get; set; }
        public virtual DbSet<SortBills> SortBills { get; set; }
        public virtual DbSet<SortBills25apr> SortBills25apr { get; set; }
        public virtual DbSet<SortBills28apr> SortBills28apr { get; set; }
        public virtual DbSet<SortBills5may> SortBills5may { get; set; }
        public virtual DbSet<SortCustomers> SortCustomers { get; set; }
        public virtual DbSet<SortCustomers25apr> SortCustomers25apr { get; set; }
        public virtual DbSet<SortCustomers28apr> SortCustomers28apr { get; set; }
        public virtual DbSet<SortItems> SortItems { get; set; }
        public virtual DbSet<SortParentCustomers> SortParentCustomers { get; set; }
        public virtual DbSet<SortParentCustomers25apr> SortParentCustomers25apr { get; set; }
        public virtual DbSet<SortParentCustomers28apr> SortParentCustomers28apr { get; set; }
        public virtual DbSet<SortPaymentReceivedLines28apr> SortPaymentReceivedLines28apr { get; set; }
        public virtual DbSet<SortProjects> SortProjects { get; set; }
        public virtual DbSet<SortProjects25apr> SortProjects25apr { get; set; }
        public virtual DbSet<SortProjects28apr> SortProjects28apr { get; set; }
        public virtual DbSet<SortProjectsBackup25apr> SortProjectsBackup25apr { get; set; }
        public virtual DbSet<SortProjectsBackup28apr> SortProjectsBackup28apr { get; set; }
        public virtual DbSet<SortVendors> SortVendors { get; set; }
        public virtual DbSet<TdsReceivableRange> TdsReceivableRange { get; set; }
        public virtual DbSet<UnusedCreditCust> UnusedCreditCust { get; set; }
        public virtual DbSet<VendorCreditLineItemsView> VendorCreditLineItemsView { get; set; }
        public virtual DbSet<VwBillAmountAllocated> VwBillAmountAllocated { get; set; }
        public virtual DbSet<VwBillPaymentLinesCompare> VwBillPaymentLinesCompare { get; set; }
        public virtual DbSet<VwCompareCustomerpayments> VwCompareCustomerpayments { get; set; }
        public virtual DbSet<VwCompareCustomerpayments2> VwCompareCustomerpayments2 { get; set; }
        public virtual DbSet<VwCompareVendorpayments> VwCompareVendorpayments { get; set; }
        public virtual DbSet<VwDumpCustomers28apr> VwDumpCustomers28apr { get; set; }
        public virtual DbSet<VwDumpZohoVendors> VwDumpZohoVendors { get; set; }
        public virtual DbSet<VwJournalAccountTypes> VwJournalAccountTypes { get; set; }
        public virtual DbSet<VwJvvalueByEntity> VwJvvalueByEntity { get; set; }
        public virtual DbSet<VwOpenPaymentList> VwOpenPaymentList { get; set; }
        public virtual DbSet<VwPaymentDeposits> VwPaymentDeposits { get; set; }
        public virtual DbSet<VwPaymentTransactionCount> VwPaymentTransactionCount { get; set; }
        public virtual DbSet<VwQbtxns> VwQbtxns { get; set; }
        public virtual DbSet<VwQbtxnsNew> VwQbtxnsNew { get; set; }
        public virtual DbSet<VwQbtxnsNewCompare> VwQbtxnsNewCompare { get; set; }
        public virtual DbSet<VwUniqueCustomerStatement> VwUniqueCustomerStatement { get; set; }
        public virtual DbSet<VwUniqueVenderStatement> VwUniqueVenderStatement { get; set; }
        public virtual DbSet<VwUniqueZohoCustomerPaymentsBank> VwUniqueZohoCustomerPaymentsBank { get; set; }
        public virtual DbSet<VwUniqueZohoCustomerPaymentsBankTest> VwUniqueZohoCustomerPaymentsBankTest { get; set; }
        public virtual DbSet<VwVendorOpeningBalances> VwVendorOpeningBalances { get; set; }
        public virtual DbSet<VwZohoOpenInvoicesMismatch> VwZohoOpenInvoicesMismatch { get; set; }
        public virtual DbSet<VwZohoOpenInvoicesMismatch13jun> VwZohoOpenInvoicesMismatch13jun { get; set; }
        public virtual DbSet<VwZohoOpenInvoicesMismatch20jun> VwZohoOpenInvoicesMismatch20jun { get; set; }
        public virtual DbSet<VwZohoOpenInvoicesMismatch24jun> VwZohoOpenInvoicesMismatch24jun { get; set; }
        public virtual DbSet<VwZohoOpenInvoicesMismatchFinal> VwZohoOpenInvoicesMismatchFinal { get; set; }
        public virtual DbSet<VwZohoVendorPortalDetails> VwZohoVendorPortalDetails { get; set; }
        public virtual DbSet<VwZohovendorstatement> VwZohovendorstatement { get; set; }
        public virtual DbSet<XlpxlHdfc2223> XlpxlHdfc2223 { get; set; }
        public virtual DbSet<XlsAccountsPayable> XlsAccountsPayable { get; set; }
        public virtual DbSet<XlsAccountsReceivable> XlsAccountsReceivable { get; set; }
        public virtual DbSet<XlsAccountsReceivable2023> XlsAccountsReceivable2023 { get; set; }
        public virtual DbSet<XlsAppliedCreditNotes20230611> XlsAppliedCreditNotes20230611 { get; set; }
        public virtual DbSet<XlsInvoicePayments> XlsInvoicePayments { get; set; }
        public virtual DbSet<XlsInvoicePayments2> XlsInvoicePayments2 { get; set; }
        public virtual DbSet<XlsTrialBalance> XlsTrialBalance { get; set; }
        public virtual DbSet<XlsTrialBalance2023> XlsTrialBalance2023 { get; set; }
        public virtual DbSet<ZohoAp18oct> ZohoAp18oct { get; set; }
        public virtual DbSet<ZohoAp21sep> ZohoAp21sep { get; set; }
        public virtual DbSet<ZohoApSummary> ZohoApSummary { get; set; }
        public virtual DbSet<ZohoAppliedVendorCredits> ZohoAppliedVendorCredits { get; set; }
        public virtual DbSet<ZohoApplyCn118jun> ZohoApplyCn118jun { get; set; }
        public virtual DbSet<ZohoAr16Sep> ZohoAr16Sep { get; set; }
        public virtual DbSet<ZohoArAgingJvCn> ZohoArAgingJvCn { get; set; }
        public virtual DbSet<ZohoArBalance22aug> ZohoArBalance22aug { get; set; }
        public virtual DbSet<ZohoBank2223> ZohoBank2223 { get; set; }
        public virtual DbSet<ZohoBank2223Backup> ZohoBank2223Backup { get; set; }
        public virtual DbSet<ZohoBankLedger> ZohoBankLedger { get; set; }
        public virtual DbSet<ZohoBankLedger20240330> ZohoBankLedger20240330 { get; set; }
        public virtual DbSet<ZohoBankRefund22032024> ZohoBankRefund22032024 { get; set; }
        public virtual DbSet<ZohoBankRefund23032024> ZohoBankRefund23032024 { get; set; }
        public virtual DbSet<ZohoBankRefund23032024Success> ZohoBankRefund23032024Success { get; set; }
        public virtual DbSet<ZohoBankRefundError> ZohoBankRefundError { get; set; }
        public virtual DbSet<ZohoBankRefundErrorEx230324> ZohoBankRefundErrorEx230324 { get; set; }
        public virtual DbSet<ZohoBankRefundEx230324> ZohoBankRefundEx230324 { get; set; }
        public virtual DbSet<ZohoBankRefundEx230324Hdfc3> ZohoBankRefundEx230324Hdfc3 { get; set; }
        public virtual DbSet<ZohoBankReturn22032024> ZohoBankReturn22032024 { get; set; }
        public virtual DbSet<ZohoBankReturnEx230324> ZohoBankReturnEx230324 { get; set; }
        public virtual DbSet<ZohoBankReturnExv01042024> ZohoBankReturnExv01042024 { get; set; }
        public virtual DbSet<ZohoBankTempFlc> ZohoBankTempFlc { get; set; }
        public virtual DbSet<ZohoBillpayments> ZohoBillpayments { get; set; }
        public virtual DbSet<ZohoBills11sep> ZohoBills11sep { get; set; }
        public virtual DbSet<ZohoBills2223> ZohoBills2223 { get; set; }
        public virtual DbSet<ZohoChargeItems> ZohoChargeItems { get; set; }
        public virtual DbSet<ZohoChargeitemsMin> ZohoChargeitemsMin { get; set; }
        public virtual DbSet<ZohoChartOfAccounts> ZohoChartOfAccounts { get; set; }
        public virtual DbSet<ZohoCoa> ZohoCoa { get; set; }
        public virtual DbSet<ZohoCurrencies> ZohoCurrencies { get; set; }
        public virtual DbSet<ZohoCustomerPayments> ZohoCustomerPayments { get; set; }
        public virtual DbSet<ZohoCustomerPayments1> ZohoCustomerPayments1 { get; set; }
        public virtual DbSet<ZohoCustomerPayments1822> ZohoCustomerPayments1822 { get; set; }
        public virtual DbSet<ZohoCustomerPaymentsBank> ZohoCustomerPaymentsBank { get; set; }
        public virtual DbSet<ZohoCustomerPaymentsBankBackup> ZohoCustomerPaymentsBankBackup { get; set; }
        public virtual DbSet<ZohoCustomerPaymentsBankUpdate240403> ZohoCustomerPaymentsBankUpdate240403 { get; set; }
        public virtual DbSet<ZohoCustomerRefunds> ZohoCustomerRefunds { get; set; }
        public virtual DbSet<ZohoCustomers> ZohoCustomers { get; set; }
        public virtual DbSet<ZohoCustomerstatement> ZohoCustomerstatement { get; set; }
        public virtual DbSet<ZohoCustomerstatementNew> ZohoCustomerstatementNew { get; set; }
        public virtual DbSet<ZohoCustomerstatementOld> ZohoCustomerstatementOld { get; set; }
        public virtual DbSet<ZohoDuplicateJvs> ZohoDuplicateJvs { get; set; }
        public virtual DbSet<ZohoExc260324> ZohoExc260324 { get; set; }
        public virtual DbSet<ZohoHdfc17dec> ZohoHdfc17dec { get; set; }
        public virtual DbSet<ZohoHdfc20dec> ZohoHdfc20dec { get; set; }
        public virtual DbSet<ZohoHdfc2223> ZohoHdfc2223 { get; set; }
        public virtual DbSet<ZohoHdfc2223Backup> ZohoHdfc2223Backup { get; set; }
        public virtual DbSet<ZohoHdfcDec10> ZohoHdfcDec10 { get; set; }
        public virtual DbSet<ZohoHdfcRefund1> ZohoHdfcRefund1 { get; set; }
        public virtual DbSet<ZohoHdfcRefund2> ZohoHdfcRefund2 { get; set; }
        public virtual DbSet<ZohoHdfcRefund3> ZohoHdfcRefund3 { get; set; }
        public virtual DbSet<ZohoHdfcRefund3Backup22032024> ZohoHdfcRefund3Backup22032024 { get; set; }
        public virtual DbSet<ZohoHdfcReturn2223> ZohoHdfcReturn2223 { get; set; }
        public virtual DbSet<ZohoHdfcReturn2223Backup> ZohoHdfcReturn2223Backup { get; set; }
        public virtual DbSet<ZohoInvoices11sep> ZohoInvoices11sep { get; set; }
        public virtual DbSet<ZohoInvoices20230430> ZohoInvoices20230430 { get; set; }
        public virtual DbSet<ZohoJournals3oct> ZohoJournals3oct { get; set; }
        public virtual DbSet<ZohoJv> ZohoJv { get; set; }
        public virtual DbSet<ZohoJv11sep> ZohoJv11sep { get; set; }
        public virtual DbSet<ZohoJv2223> ZohoJv2223 { get; set; }
        public virtual DbSet<ZohoJv22232jan> ZohoJv22232jan { get; set; }
        public virtual DbSet<ZohoJvAll> ZohoJvAll { get; set; }
        public virtual DbSet<ZohoJvFinal> ZohoJvFinal { get; set; }
        public virtual DbSet<ZohoMissingBills31jul> ZohoMissingBills31jul { get; set; }
        public virtual DbSet<ZohoMissmatched31jul> ZohoMissmatched31jul { get; set; }
        public virtual DbSet<ZohoOdBills10jul> ZohoOdBills10jul { get; set; }
        public virtual DbSet<ZohoOdBills1aug> ZohoOdBills1aug { get; set; }
        public virtual DbSet<ZohoOdBills1jul> ZohoOdBills1jul { get; set; }
        public virtual DbSet<ZohoOdBills20jul> ZohoOdBills20jul { get; set; }
        public virtual DbSet<ZohoOdBills5jul> ZohoOdBills5jul { get; set; }
        public virtual DbSet<ZohoOdInvoices20jun> ZohoOdInvoices20jun { get; set; }
        public virtual DbSet<ZohoOdInvoices24jun> ZohoOdInvoices24jun { get; set; }
        public virtual DbSet<ZohoOverdueInvoices> ZohoOverdueInvoices { get; set; }
        public virtual DbSet<ZohoOverdueInvoices13jun> ZohoOverdueInvoices13jun { get; set; }
        public virtual DbSet<ZohoOverdueInvoices18jun> ZohoOverdueInvoices18jun { get; set; }
        public virtual DbSet<ZohoOverdueInvoices20jun> ZohoOverdueInvoices20jun { get; set; }
        public virtual DbSet<ZohoPaymentsreceived4nov> ZohoPaymentsreceived4nov { get; set; }
        public virtual DbSet<ZohoPm4nov> ZohoPm4nov { get; set; }
        public virtual DbSet<ZohoPr4nov> ZohoPr4nov { get; set; }
        public virtual DbSet<ZohoProjects> ZohoProjects { get; set; }
        public virtual DbSet<ZohoProjectsImport> ZohoProjectsImport { get; set; }
        public virtual DbSet<ZohoTaxMaster> ZohoTaxMaster { get; set; }
        public virtual DbSet<ZohoTempInrFlc> ZohoTempInrFlc { get; set; }
        public virtual DbSet<ZohoTempJv> ZohoTempJv { get; set; }
        public virtual DbSet<ZohoTempJv13jun> ZohoTempJv13jun { get; set; }
        public virtual DbSet<ZohoTempJv20jun> ZohoTempJv20jun { get; set; }
        public virtual DbSet<ZohoTempJv24jun> ZohoTempJv24jun { get; set; }
        public virtual DbSet<ZohoTempMumFlc2223> ZohoTempMumFlc2223 { get; set; }
        public virtual DbSet<ZohoTokens> ZohoTokens { get; set; }
        public virtual DbSet<ZohoTxntest> ZohoTxntest { get; set; }
        public virtual DbSet<ZohoUndepositedFlm> ZohoUndepositedFlm { get; set; }
        public virtual DbSet<ZohoVendorBalance7aug> ZohoVendorBalance7aug { get; set; }
        public virtual DbSet<ZohoVendorList> ZohoVendorList { get; set; }
        public virtual DbSet<ZohoVendorPayments> ZohoVendorPayments { get; set; }
        public virtual DbSet<ZohoVendorRefund2223> ZohoVendorRefund2223 { get; set; }
        public virtual DbSet<ZohoVendorRefunds> ZohoVendorRefunds { get; set; }
        public virtual DbSet<ZohoVendors> ZohoVendors { get; set; }
        public virtual DbSet<ZohoVendorstatement> ZohoVendorstatement { get; set; }
        public virtual DbSet<Zohotxn20240913Backup> Zohotxn20240913Backup { get; set; }
        public virtual DbSet<Zohotxns> Zohotxns { get; set; }
        public virtual DbSet<Zohotxns20240919> Zohotxns20240919 { get; set; }
        public virtual DbSet<Zohotxns20240920> Zohotxns20240920 { get; set; }
        public virtual DbSet<Zohotxns20240921> Zohotxns20240921 { get; set; }
        public virtual DbSet<Zohotxns20240927> Zohotxns20240927 { get; set; }
        public virtual DbSet<Zohotxns22jul> Zohotxns22jul { get; set; }
        public virtual DbSet<ZohotxnsHdfc> ZohotxnsHdfc { get; set; }
        public virtual DbSet<ZohotxnsHdfcusd> ZohotxnsHdfcusd { get; set; }
        public virtual DbSet<ZohotxnsOld> ZohotxnsOld { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=108.181.191.121;Database=FretrackZoho;User Id=zohoapi;Password=zoho@api@2024db;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApSummaryBills>(entity =>
            {
                entity.HasKey(e => e.BillsId)
                    .HasName("PK__ap_summa__CE7F6864358FCA8F");

                entity.ToTable("ap_summary_Bills");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountFcy)
                    .HasColumnName("AmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmountFcy)
                    .HasColumnName("BalanceAmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceBcy)
                    .HasColumnName("BalanceBCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy)
                    .HasColumnName("BalanceFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmountFcy)
                    .HasColumnName("BillAmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBcy)
                    .HasColumnName("TotalBCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApSummaryVendors>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__ap_summa__FC8618F3AA5132D5");

                entity.ToTable("ap_summary_Vendors");

                entity.Property(e => e.Branches)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnusedCredit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCreditFcy)
                    .HasColumnName("UnusedCreditFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApSummayReportFilesList>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK__ap_summa__869767EAC0C30CEF");

                entity.ToTable("ap_summay_ReportFilesList");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate).HasColumnType("date");
            });

            modelBuilder.Entity<ApagingDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("APAgingDetails");

                entity.Property(e => e.Current).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.UnusedCredit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<AragingDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ARAgingDetails");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Current).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(255);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.SalesPerson).HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Transaction).HasMaxLength(20);

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<AragingDetails2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ARAgingDetails2");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<AragingDetailsCustomerWise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ARAgingDetailsCustomerWise");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Current).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(255);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.SalesPerson).HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<ArkashReportInrView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArkashReportInrView");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Days106120)
                    .HasColumnName("days_106-120")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days3160)
                    .HasColumnName("days_31-60")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days6190)
                    .HasColumnName("days_61-90")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days91120)
                    .HasColumnName("days_91-120")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ArkashReportUsdInrView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArkashReportUsdInrView");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentInr)
                    .HasColumnName("Current_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentUsd)
                    .HasColumnName("Current_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Days91120Inr)
                    .HasColumnName("days_91-120_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days91120Usd)
                    .HasColumnName("days_91-120_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.TotalBalanceInr)
                    .HasColumnName("TotalBalance_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBalanceUsd)
                    .HasColumnName("TotalBalance_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOutstandingInr)
                    .HasColumnName("TotalOutstanding_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOutstandingUsd)
                    .HasColumnName("TotalOutstanding_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCreditsInr)
                    .HasColumnName("UnusedCredits_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCreditsUsd)
                    .HasColumnName("UnusedCredits_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._015Inr)
                    .HasColumnName("0_15+_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._015Usd)
                    .HasColumnName("0_15+_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._120Inr)
                    .HasColumnName("120+_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._120Usd)
                    .HasColumnName("120+_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._1630Inr)
                    .HasColumnName("16_30+_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._1630Usd)
                    .HasColumnName("16_30+_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._3160Inr)
                    .HasColumnName("31_60+_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._3160Usd)
                    .HasColumnName("31_60+_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._6190Inr)
                    .HasColumnName("61_90+_INR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._6190Usd)
                    .HasColumnName("61_90+_USD")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ArkashReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArkashReportView");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Days106120)
                    .HasColumnName("days_106-120")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days3160)
                    .HasColumnName("days_31-60")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days6190)
                    .HasColumnName("days_61-90")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Days91120)
                    .HasColumnName("days_91-120")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._105)
                    .HasColumnName("105+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._120)
                    .HasColumnName("120+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AugBillPaymentsImportCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aug_BillPayments_ImportCheck");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("bill date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvAmount)
                    .HasColumnName("JV_AMOUNT")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupDumpBankLegder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_dump_Bank_Legder");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupDumpBankTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_dump_BankTransfer");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.FromAccountId)
                    .HasColumnName("FromAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.FromAccountName).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MemoDescription).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OldDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(255);

                entity.Property(e => e.PaymentNumber).HasMaxLength(255);

                entity.Property(e => e.Qbdate)
                    .HasColumnName("QBDate")
                    .HasMaxLength(255);

                entity.Property(e => e.RefernceNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.SyncStatus).HasMaxLength(255);

                entity.Property(e => e.ToAccountId)
                    .HasColumnName("ToAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.ToAccountName).HasMaxLength(255);

                entity.Property(e => e.TransactionType).HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BackupZohoBankLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_zoho_bank_ledger");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BillAllocationResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bill_AllocationResult");

                entity.Property(e => e.AmountAllocated).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountBalance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillTxnId)
                    .HasColumnName("BillTxnID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillAllocationResultAugust>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bill_AllocationResult_August");

                entity.Property(e => e.AmountAllocated).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountBalance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillTxnId)
                    .HasColumnName("BillTxnID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillGstapplicable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillGSTApplicable");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationOfSupply)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttax)
                    .IsRequired()
                    .HasColumnName("GSTTAX")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply).HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillJvpaymentTest>(entity =>
            {
                entity.ToTable("BillJVPaymentTest");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvCredit)
                    .HasColumnName("JV CREDIT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvDebit)
                    .HasColumnName("JV DEBIT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("PAID THROUGH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Purchase)
                    .HasColumnName("PURCHASE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCredits)
                    .HasColumnName("VENDOR CREDITS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("ZOHO_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("ZOHO_BANK")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoPaymentId)
                    .HasColumnName("Zoho_paymentId")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillPaymentTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JvCredit)
                    .HasColumnName("JV CREDIT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvDebit)
                    .HasColumnName("JV DEBIT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidThroghAccountId)
                    .HasColumnName("Paid Throgh Account Id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("PAID THROUGH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Purchase)
                    .HasColumnName("PURCHASE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCredits)
                    .HasColumnName("VENDOR CREDITS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("ZOHO_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("ZOHO_BANK")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoPaymentId)
                    .HasColumnName("Zoho_paymentId")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilllineitemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("billlineitemsView");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillsAllocationResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bills_AllocationResult");

                entity.Property(e => e.AmountAllocated).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountBalance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillsPlanB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bills_PlanB");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ForeignAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ForeignOpenBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.JobNumber).HasMaxLength(255);

                entity.Property(e => e.OpenBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TransactionType).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<BordoKutuCategory>(entity =>
            {
                entity.ToTable("BordoKutu_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateModfied)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2024-02-02 14:30:00')");

                entity.Property(e => e.DrawerOrder).HasColumnName("drawerOrder");

                entity.Property(e => e.HomescreenOrder).HasColumnName("homescreenOrder");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("('TRUE')");

                entity.Property(e => e.IsdiplayedonDrawer).HasColumnName("isdiplayedonDrawer");

                entity.Property(e => e.IsdiplayedonHomeScreen).HasColumnName("isdiplayedonHomeScreen");

                entity.Property(e => e.IsdiplayedonShopScreen).HasColumnName("isdiplayedonShopScreen");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ShopscreenOrder).HasColumnName("shopscreenOrder");

                entity.Property(e => e.Slug)
                    .HasColumnName("slug")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasColumnName("sortOrder");
            });

            modelBuilder.Entity<BranchList>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.Property(e => e.BranchId).ValueGeneratedNever();

                entity.Property(e => e.BranchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateCodeAlpha)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareLogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_logs");

                entity.Property(e => e.DateCompared)
                    .HasColumnName("date_compared")
                    .HasColumnType("datetime");

                entity.Property(e => e.FcyNetAmt).HasColumnName("fcy_net_amt");

                entity.Property(e => e.MismatchType)
                    .HasColumnName("mismatch_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.QuickbooksDate)
                    .HasColumnName("quickbooks_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksFcyNetAmount).HasColumnName("quickbooks_fcy_net_amount");

                entity.Property(e => e.QuickbooksNetAmount).HasColumnName("quickbooks_net_amount");

                entity.Property(e => e.QuickbooksSource)
                    .HasColumnName("quickbooks_source")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasColumnName("txn_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("txn_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDate)
                    .HasColumnName("zoho_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoFcyNetAmount).HasColumnName("zoho_fcy_net_amount");

                entity.Property(e => e.ZohoNetAmount).HasColumnName("zoho_net_amount");

                entity.Property(e => e.ZohoSource)
                    .HasColumnName("zoho_source")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareQbCustomerdata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_qb_customerdata");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareQbVendordata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_qb_vendordata");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareQbVendordataNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_qb_vendordata_new");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareZohoCustomerdata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_zoho_customerdata");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareZohoVendordata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_zoho_vendordata");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompareZohoVendordataNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compare_zoho_vendordata_new");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditNotesLineItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CreditNotesLineItemsView");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvApplyMultijvSingleInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSV_Apply_MULTIJV_SingleInvoice");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.JournalUniqueId)
                    .HasColumnName("JournalUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.JvAmount)
                    .HasColumnName("JV_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvApplySingleJvMultiInvoices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSV_Apply_SingleJV_MultiInvoices");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.JournalUniqueId)
                    .HasColumnName("JournalUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.JvAmount)
                    .HasColumnName("JV_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvBillPaymentImportJuly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_BillPaymentImport_July");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAllocated).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillDiff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FixedAllocatedAmount)
                    .HasColumnName("Fixed_Allocated_Amount")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewVendorName)
                    .HasColumnName("New Vendor Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvBillPaymentsApril18>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_BillPayments_April18");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountTotal).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvBills20230708>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_Bills_20230708");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvBills20230717>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_Bills_20230717");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvBills20230719>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_Bills_20230719");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_FINAL");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("Tax Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxExemptionCode)
                    .IsRequired()
                    .HasColumnName("Tax Exemption Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvInvoices20230611>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_Invoices_20230611");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvJvInvoices20230611Fixed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_JV_Invoices_20230611_FIXED");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(618)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsvVendorOpeningBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csv_Vendor_OpeningBalance");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountApplied).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64D8E421498E");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Flbranch)
                    .HasColumnName("FLBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.UnusedCredits)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnusedCreditsFcy)
                    .HasColumnName("UnusedCreditsFCY")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DumpAccountsPayable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsPayable");

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("zoho_display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpAccountsPayable2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsPayable_2023");

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<DumpAccountsPayableBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsPayable_backup");

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<DumpAccountsReceivable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsReceivable");

                entity.Property(e => e.AcountName).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.Parent1).HasMaxLength(255);

                entity.Property(e => e.Parent2).HasMaxLength(255);

                entity.Property(e => e.QbcustomerName)
                    .HasColumnName("QBCustomerName")
                    .HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);
            });

            modelBuilder.Entity<DumpAccountsReceivable2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsReceivable_2023");

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Parent1)
                    .HasColumnName("PARENT1")
                    .HasMaxLength(255);

                entity.Property(e => e.Parent2)
                    .HasColumnName("PARENT2")
                    .HasMaxLength(255);

                entity.Property(e => e.QbcustomerName)
                    .HasColumnName("QBCustomerName")
                    .HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);
            });

            modelBuilder.Entity<DumpAccountsReceivableBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_AccountsReceivable_backup");

                entity.Property(e => e.AcountName).HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.Parent1).HasMaxLength(255);

                entity.Property(e => e.Parent2).HasMaxLength(255);

                entity.Property(e => e.QbcustomerName)
                    .HasColumnName("QBCustomerName")
                    .HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);
            });

            modelBuilder.Entity<DumpBankLedger14mar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bank_Ledger_14Mar");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBankLegder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bank_Legder");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBankLegder20240330>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bank_Legder_20240330");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBankTransfer>(entity =>
            {
                entity.ToTable("dump_BankTransfer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.FromAccountId)
                    .HasColumnName("FromAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.FromAccountName).HasMaxLength(255);

                entity.Property(e => e.MemoDescription).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OldDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(255);

                entity.Property(e => e.PaymentNumber).HasMaxLength(255);

                entity.Property(e => e.Qbdate)
                    .HasColumnName("QBDate")
                    .HasMaxLength(255);

                entity.Property(e => e.RefernceNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.SyncStatus).HasMaxLength(255);

                entity.Property(e => e.ToAccountId)
                    .HasColumnName("ToAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.ToAccountName).HasMaxLength(255);

                entity.Property(e => e.TransactionType).HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DumpBillLineItems>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__dump_Bil__2EAE64C99B09AA50");

                entity.ToTable("dump_BillLineItems");

                entity.HasIndex(e => new { e.UniqueId, e.Amount, e.AccountRefValue, e.DetailType })
                    .HasName("idx_bli_2");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountRefName)
                    .HasColumnName("AccountRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRefValue)
                    .HasColumnName("AccountRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillableStatus)
                    .HasColumnName("Billable_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRefName)
                    .HasColumnName("ClassRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRefValue)
                    .HasColumnName("ClassRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<DumpBillPaymentLines1aug>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_BillPaymentLines_1AUG");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBillPaymentLines28apr>(entity =>
            {
                entity.HasKey(e => e.PayLineId);

                entity.ToTable("dump_BillPaymentLines_28APR");

                entity.Property(e => e.PayLineId).HasColumnName("PayLineID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSolved).HasColumnName("isSolved");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolvedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnusedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTransactionId)
                    .HasColumnName("ZohoTransactionID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBillPaymentLinesOct23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_BillPaymentLines_OCT23");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBillPaymentTxnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_BillPaymentTxnType");

                entity.Property(e => e.PaymentTxnType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBillPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_BillPayments");

                entity.HasIndex(e => new { e.BankAccountId, e.DocNumber, e.ExchangeRate, e.UniqueId, e.TotalAmt, e.TxnDate })
                    .HasName("idx_bpay_002");

                entity.Property(e => e.BankAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("zoho_display_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpBillTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_BillTest");

                entity.Property(e => e.ApaccountRefId)
                    .HasColumnName("APAccountRefId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApaccountRefName)
                    .HasColumnName("APAccountRefName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddressId)
                    .HasColumnName("VendorAddressID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBills202223b>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_202223B");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .IsRequired()
                    .HasColumnName("Bill Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatonOfSupply)
                    .HasColumnName("Destinaton of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstCheck)
                    .IsRequired()
                    .HasColumnName("GST_CHECK")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("importFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillable)
                    .IsRequired()
                    .HasColumnName("Is Billable")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsReverseCharge)
                    .IsRequired()
                    .HasColumnName("Is Reverse Charge")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEligibility)
                    .IsRequired()
                    .HasColumnName("ITC_Eligibility")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("Reverse Charge Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("Reverse Charge Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("Reverse Charge Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleTax)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DumpBills202223c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_202223C");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .IsRequired()
                    .HasColumnName("Bill Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatonOfSupply)
                    .HasColumnName("Destinaton of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstCheck)
                    .IsRequired()
                    .HasColumnName("GST_CHECK")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("importFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillable)
                    .IsRequired()
                    .HasColumnName("Is Billable")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsReverseCharge)
                    .IsRequired()
                    .HasColumnName("Is Reverse Charge")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEligibility)
                    .IsRequired()
                    .HasColumnName("ITC_Eligibility")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("Reverse Charge Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("Reverse Charge Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("Reverse Charge Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleTax)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DumpBills202324a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_202324A");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .IsRequired()
                    .HasColumnName("Bill Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatonOfSupply)
                    .HasColumnName("Destinaton of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstCheck)
                    .IsRequired()
                    .HasColumnName("GST_CHECK")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("importFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillable)
                    .IsRequired()
                    .HasColumnName("Is Billable")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsReverseCharge)
                    .IsRequired()
                    .HasColumnName("Is Reverse Charge")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEligibility)
                    .IsRequired()
                    .HasColumnName("ITC_Eligibility")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("Reverse Charge Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("Reverse Charge Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("Reverse Charge Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleTax)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DumpBills25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_25APR");

                entity.Property(e => e.ApaccountRefId)
                    .HasColumnName("APAccountRefId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApaccountRefName)
                    .HasColumnName("APAccountRefName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddressId)
                    .HasColumnName("VendorAddressID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBills28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_28APR");

                entity.HasIndex(e => new { e.NewDocNumber2, e.TxnDate })
                    .HasName("idx_zoho_newdocnumber2");

                entity.HasIndex(e => new { e.DocNumber, e.ExchangeRate, e.UniqueId, e.TxnDate })
                    .HasName("noncls_IDX_BILLS2");

                entity.HasIndex(e => new { e.ExchangeRate, e.VendorId, e.TotalAmt, e.UniqueId, e.NewDocNumber2, e.TxnDate })
                    .HasName("noncls_idx_Bills_IX1");

                entity.Property(e => e.ApaccountRefId)
                    .HasColumnName("APAccountRefId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApaccountRefName)
                    .HasColumnName("APAccountRefName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddressId)
                    .HasColumnName("VendorAddressID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpBillsExcel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_Excel");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .IsRequired()
                    .HasColumnName("Bill Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatonOfSupply)
                    .HasColumnName("Destinaton of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstCheck)
                    .IsRequired()
                    .HasColumnName("GST_CHECK")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("importFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillable)
                    .IsRequired()
                    .HasColumnName("Is Billable")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsReverseCharge)
                    .IsRequired()
                    .HasColumnName("Is Reverse Charge")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEligibility)
                    .IsRequired()
                    .HasColumnName("ITC_Eligibility")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("Reverse Charge Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("Reverse Charge Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("Reverse Charge Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleTax)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DumpBillsPlanb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Bills_PLANB");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .IsRequired()
                    .HasColumnName("Bill Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatonOfSupply)
                    .HasColumnName("Destinaton of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstCheck)
                    .IsRequired()
                    .HasColumnName("GST_CHECK")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("importFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBillable)
                    .IsRequired()
                    .HasColumnName("Is Billable")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsReverseCharge)
                    .IsRequired()
                    .HasColumnName("Is Reverse Charge")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEligibility)
                    .IsRequired()
                    .HasColumnName("ITC_Eligibility")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("Reverse Charge Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("Reverse Charge Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("Reverse Charge Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleTax)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DumpChartOfAccounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("Account #")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DebitOrCredit)
                    .IsRequired()
                    .HasColumnName("Debit or Credit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningBalance)
                    .IsRequired()
                    .HasColumnName("Opening Balance")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentAccount).HasColumnName("Parent Account");

                entity.Property(e => e.ParentAccountId)
                    .HasColumnName("ParentAccountID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpChartOfAccounts1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dumpChartOfAccounts");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("Account #")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DebitOrCredit)
                    .IsRequired()
                    .HasColumnName("Debit or Credit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningBalance)
                    .IsRequired()
                    .HasColumnName("Opening Balance")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentAccount).HasColumnName("Parent Account");

                entity.Property(e => e.ParentAccountId)
                    .HasColumnName("ParentAccountID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpChartOfAccounts28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_28APR");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("Account #")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DebitOrCredit)
                    .IsRequired()
                    .HasColumnName("Debit or Credit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningBalance)
                    .IsRequired()
                    .HasColumnName("Opening Balance")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentAccount).HasColumnName("Parent Account");

                entity.Property(e => e.ParentAccountId)
                    .HasColumnName("ParentAccountID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpChartOfAccountsFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_Final");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(553)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAcountType)
                    .HasColumnName("zoho_acount_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpChartOfAccountsGrouped>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_Grouped");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(255);

                entity.Property(e => e.QbAccountName).HasMaxLength(255);

                entity.Property(e => e.Qbbranch)
                    .HasColumnName("QBBranch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(255);

                entity.Property(e => e.ScheduleHead)
                    .HasColumnName("schedule_head")
                    .HasMaxLength(255);

                entity.Property(e => e.TbGroup)
                    .HasColumnName("tb_group")
                    .HasMaxLength(255);

                entity.Property(e => e.TbName)
                    .HasColumnName("tb_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAcountType)
                    .HasColumnName("zoho_acount_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpChartOfAccountsImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_IMPORT");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(553)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpChartOfAccountsOldGrouped>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_OldGrouped");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(255);

                entity.Property(e => e.QbAccountName).HasMaxLength(255);

                entity.Property(e => e.QbBranch)
                    .HasColumnName("qb_branch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(255);

                entity.Property(e => e.ScheduleHead)
                    .HasColumnName("schedule_head")
                    .HasMaxLength(255);

                entity.Property(e => e.TbGroup)
                    .HasColumnName("tb_group")
                    .HasMaxLength(255);

                entity.Property(e => e.TbName)
                    .HasColumnName("tb_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAcountType)
                    .HasColumnName("zoho_acount_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpChartOfAccountsSort>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_ChartOfAccounts_SORT");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(553)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpCreditNotes28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_CreditNotes_28APR");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.RemainingCredit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShipFromAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddressId)
                    .HasColumnName("ShipFromAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpCreditNotesLineItems>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__dump_Cre__2EAE64C9B2F5FBBF");

                entity.ToTable("dump_CreditNotesLineItems");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAccountRefName)
                    .HasColumnName("ItemAccountRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAccountRefValue)
                    .HasColumnName("ItemAccountRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRefName)
                    .HasColumnName("ItemRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRefValue)
                    .HasColumnName("ItemRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeRefValue)
                    .HasColumnName("TaxCodeRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<DumpCustomers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Customers");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpCustomers25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Customers_25APR");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpCustomers28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Customers_28APR");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpCustomersBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Customers_backup");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpDepositLinesTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_DepositLines_Test");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnLineId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAccountName)
                    .HasColumnName("ZohoAccountNAme")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpDeposits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Deposits");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpHdfc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_hdfc2223");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.ForeignAmount).HasColumnName("Foreign Amount");

                entity.Property(e => e.ForeignCredit).HasColumnName("Foreign_Credit");

                entity.Property(e => e.ForeignDebit).HasColumnName("Foreign_Debit");

                entity.Property(e => e.Fy)
                    .HasColumnName("FY")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.MemoDescription)
                    .HasColumnName("Memo_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.No).HasMaxLength(255);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.TxnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DumpHdfcLedgerApr22>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("dump_HDFC_Ledger_APR22");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("ASSIGNED TO")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAccountName).HasMaxLength(255);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName).HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.DocNumber).HasMaxLength(255);

                entity.Property(e => e.JvType)
                    .HasColumnName("jv type")
                    .HasMaxLength(255);

                entity.Property(e => e.LineStatus).HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmtFcy).HasColumnName("TotalAmtFCY");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasMaxLength(255);

                entity.Property(e => e.UniqueId).HasMaxLength(255);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy).HasColumnName("zoho_fcy");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpHdfcLegder2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_HDFC_Legder_2223");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpHdfcLegder2223Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_HDFC_Legder_2223_backup");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpImportPurchase20jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Import_Purchase_20JUL");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.LineAmount)
                    .HasColumnName("lineAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpInvoiceLineItems>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__dump_Inv__2EAE64C909C1F345");

                entity.ToTable("dump_InvoiceLineItems");

                entity.HasIndex(e => new { e.UniqueId, e.Amount, e.ItemAccountRefValue, e.DetailType })
                    .HasName("idx_ili_3");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAccountRefName)
                    .HasColumnName("ItemAccountRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAccountRefValue)
                    .HasColumnName("ItemAccountRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRefName)
                    .HasColumnName("ItemRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRefValue)
                    .HasColumnName("ItemRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeRefValue)
                    .HasColumnName("TaxCodeRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<DumpInvoiceTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_InvoiceTest");

                entity.Property(e => e.AllowIpnpayment).HasColumnName("AllowIPNPayment");

                entity.Property(e => e.AllowOnlineAchpayment).HasColumnName("AllowOnlineACHPayment");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.ShipFromAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddressId)
                    .HasColumnName("ShipFromAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DumpInvoices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Invoices");

                entity.Property(e => e.BulkColumn).IsUnicode(false);
            });

            modelBuilder.Entity<DumpInvoices25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Invoices_25APR");

                entity.Property(e => e.AllowIpnpayment).HasColumnName("AllowIPNPayment");

                entity.Property(e => e.AllowOnlineAchpayment).HasColumnName("AllowOnlineACHPayment");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.ShipFromAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddressId)
                    .HasColumnName("ShipFromAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DumpInvoices28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Invoices_28APR");

                entity.HasIndex(e => new { e.DocNumber, e.ExchangeRate, e.Uniqueid, e.TxnDate })
                    .HasName("noncls_idx_invoices2");

                entity.Property(e => e.AllowIpnpayment).HasColumnName("AllowIPNPayment");

                entity.Property(e => e.AllowOnlineAchpayment).HasColumnName("AllowOnlineACHPayment");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.ShipFromAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddressId)
                    .HasColumnName("ShipFromAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Items");

                entity.Property(e => e.AbatementRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxcodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoDescription)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpItems25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Items_25APR");

                entity.Property(e => e.AbatementRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxcodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoDescription)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpItems28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Items_28APR");

                entity.Property(e => e.AbatementRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxcodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoDescription)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpItemsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Items_Backup");

                entity.Property(e => e.AbatementRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountZohoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseTaxcodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChargeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTaxCodeId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoDescription)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpItemsFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Items_Final");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ExpAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseAccountId)
                    .HasColumnName("expenseAccountID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncAccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeAccountId)
                    .HasColumnName("incomeAccountID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseAccount)
                    .HasColumnName("Purchase Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDescription)
                    .HasColumnName("Purchase Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("Qb Company")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("Quickbooks ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpJournalEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_JournalEntry");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpJournalLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_JournalLines");

                entity.HasIndex(e => e.DocNumber)
                    .HasName("idx_zohotxn_doc1");

                entity.HasIndex(e => new { e.Uniqueid, e.DocNumber, e.ExchangeRate, e.Amount, e.JvlinePostingType, e.JvlineAccountRefId, e.TxnDate })
                    .HasName("idx_jv_3");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineAccountRefId)
                    .HasColumnName("JVLineAccountRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineDepartmentRefId)
                    .HasColumnName("JVLineDepartmentRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineDepartmentRefName)
                    .HasColumnName("JVLineDepartmentRefName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityRefId)
                    .HasColumnName("JVLineEntityRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityRefName)
                    .HasColumnName("JVLineEntityRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityType)
                    .HasColumnName("JVLineEntityType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineTaxAmount)
                    .HasColumnName("JVLineTaxAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvlineTaxApplicableOn)
                    .HasColumnName("JVLineTaxApplicableOn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineTaxCodeRefId)
                    .HasColumnName("JVLineTaxCodeRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpJournalList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_JournalList");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineAccountRefId)
                    .HasColumnName("JVLineAccountRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineDepartmentRefId)
                    .HasColumnName("JVLineDepartmentRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineDepartmentRefName)
                    .HasColumnName("JVLineDepartmentRefName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityRefId)
                    .HasColumnName("JVLineEntityRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityRefName)
                    .HasColumnName("JVLineEntityRefName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityType)
                    .HasColumnName("JVLineEntityType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineTaxAmount)
                    .HasColumnName("JVLineTaxAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvlineTaxApplicableOn)
                    .HasColumnName("JVLineTaxApplicableOn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineTaxCodeRefId)
                    .HasColumnName("JVLineTaxCodeRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentMethods>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentMethods");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbShortCompany)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoPaymentMethod)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentReceivedLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentReceivedLines");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("Invoice Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentReceivedLinesOnAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentReceivedLines_OnAccount");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentReceivedLinesOpeningBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentReceivedLines_OpeningBalance");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentTxnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentTxnType");

                entity.Property(e => e.JournalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTxnType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPaymentsReceived>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PaymentsReceived");

                entity.HasIndex(e => new { e.PaymentRefNum, e.ExchangeRate, e.UniqueId, e.DepositToAccountId, e.TotalAmt, e.TxnDate })
                    .HasName("idx_ztxn123");

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentRefNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnappliedAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpProjects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Projects");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueCustomerId)
                    .HasColumnName("UniqueCustomerID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpProjectsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Projects_backup");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Jobnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost)
                    .HasColumnName("Project Cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueCustomerId)
                    .HasColumnName("UniqueCustomerID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpProjectsBackup25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Projects_backup25apr");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueCustomerId)
                    .HasColumnName("UniqueCustomerID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpProjectsBackup28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Projects_backup28apr");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueCustomerId)
                    .HasColumnName("UniqueCustomerID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpPurchaseLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_PurchaseLines");

                entity.HasIndex(e => new { e.DocNumber, e.ExchangeRate, e.UniqueId, e.LineAmount, e.LineAccountId, e.TxnDate })
                    .HasName("idx_pli_1");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EntityRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineAccountId)
                    .HasColumnName("LineAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.LineAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineDetailType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineTaxCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("zoho_display_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpPurchases>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Purchases");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EntityRefId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpSalesPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_SalesPersons");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpTbJournals>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TB_JOURNALS");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchqb)
                    .HasColumnName("BRANCHQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FullAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId)
                    .HasColumnName("importID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalQbid)
                    .HasColumnName("JournalQBId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(621)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("Tax Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxExemptionCode)
                    .IsRequired()
                    .HasColumnName("Tax Exemption Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpTempInrchennaiBankLegder2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TempINRChennai_Bank_Legder_2023");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpTempInrflmBankLegder2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TempINRFLM_Bank_Legder_2023");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpTrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TrialBalance");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchShort).HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.Parent1).HasMaxLength(255);

                entity.Property(e => e.QbFullyQualifiedName).HasMaxLength(255);

                entity.Property(e => e.QbaccountName)
                    .HasColumnName("QBAccountName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpTrialBalance2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TrialBalance_2023");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchShort).HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.Parent1).HasMaxLength(255);

                entity.Property(e => e.QbFullyFualifiedName).HasMaxLength(255);

                entity.Property(e => e.QbaccountName)
                    .HasColumnName("QBAccountName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpTrialBalanceBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_TrialBalance_backup");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchShort).HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.Parent1).HasMaxLength(255);

                entity.Property(e => e.QbFullyQualifiedName).HasMaxLength(255);

                entity.Property(e => e.QbaccountName)
                    .HasColumnName("QBAccountName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DumpVendorCreditLineItems>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__dump_Ven__2EAE64C9727D9EE6");

                entity.ToTable("dump_VendorCreditLineItems");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountRefName)
                    .HasColumnName("AccountRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRefValue)
                    .HasColumnName("AccountRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillableStatus)
                    .HasColumnName("Billable_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRefName)
                    .HasColumnName("ClassRef_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRefValue)
                    .HasColumnName("ClassRef_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendorCredits28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_VendorCredits_28APR");

                entity.Property(e => e.ApaccountRefId)
                    .HasColumnName("APAccountRefId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApaccountRefName)
                    .HasColumnName("APAccountRefName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlobalTaxCalculation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateNote).HasMaxLength(500);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddressId)
                    .HasColumnName("VendorAddressID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCountry)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendorMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_VendorMapping");

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompId).HasColumnName("CompID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FretrackId).HasColumnName("FretrackID");

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GstregistrationType)
                    .HasColumnName("GSTRegistrationType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PrintOnCheckName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcity)
                    .HasColumnName("QBCity")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcountry)
                    .HasColumnName("QBCountry")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Qbid)
                    .HasColumnName("QBID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qbname)
                    .HasColumnName("QBName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Qbpincode)
                    .HasColumnName("QBPINcode")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Qbstate)
                    .HasColumnName("QBState")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbstreetAddress)
                    .HasColumnName("QBStreetAddress")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdentifier)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VendorFullName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendors22>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors22");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendors25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors_25APR");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendors28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors_28APR");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendorsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors_backup");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendorsNew25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors_New_25Apr");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpVendorsNew28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_Vendors_New_28Apr");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(4, 4)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFile)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PanNumber)
                    .HasColumnName("PAN Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasMaxLength(4005)
                    .IsUnicode(false);

                entity.Property(e => e.QbChennai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QbMumbai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbdisplayName)
                    .HasColumnName("QBDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCode)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DumpZohoJv2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dump_zoho_jv_2223");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FileList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.FilePrefix).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.JsonFileName).HasMaxLength(255);

                entity.Property(e => e.JsonFilePath).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<FixVendorData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fix_VendorData");

                entity.Property(e => e.Qbamount).HasColumnName("QBAmount");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TxnDate).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<Fretlog202308>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fretlog_202308");

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.EarlyEntry)
                    .HasColumnName("Early Entry")
                    .HasMaxLength(255);

                entity.Property(e => e.EarlyExit)
                    .HasColumnName("Early Exit")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email ID")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee Id")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("Employee Name")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstIn)
                    .HasColumnName("First In")
                    .HasMaxLength(255);

                entity.Property(e => e.LastOut)
                    .HasColumnName("Last Out")
                    .HasMaxLength(255);

                entity.Property(e => e.LateEntry)
                    .HasColumnName("Late Entry")
                    .HasMaxLength(255);

                entity.Property(e => e.LateExit)
                    .HasColumnName("Late Exit")
                    .HasMaxLength(255);

                entity.Property(e => e.NetHours)
                    .HasColumnName("Net hours")
                    .HasMaxLength(255);

                entity.Property(e => e.ShiftName)
                    .HasColumnName("Shift Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalHours)
                    .HasColumnName("Total Hours")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GaneshJvLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GANESH_JV_LOT");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Difference).HasColumnName("difference");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoicedate).HasColumnType("date");

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTxnType).HasMaxLength(255);

                entity.Property(e => e.TxnId).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<GaneshJvLot2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GANESH_JV_LOT2");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Difference).HasColumnName("difference");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoicedate).HasColumnType("date");

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTxnType).HasMaxLength(255);

                entity.Property(e => e.TxnId).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<GstTypeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GssttypeDescription)
                    .HasColumnName("GSSTTypeDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GstregType)
                    .IsRequired()
                    .HasColumnName("GSTRegType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GsttypeId).HasColumnName("GSTTypeID");

                entity.Property(e => e.QbGsttype)
                    .HasColumnName("QbGSTType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoGsttype)
                    .HasColumnName("ZohoGSTType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GststateCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GSTStateCodes");

                entity.Property(e => e.AlphaCode).HasMaxLength(255);

                entity.Property(e => e.StateCode2).HasMaxLength(255);

                entity.Property(e => e.StateName).HasMaxLength(255);
            });

            modelBuilder.Entity<Invoice202223C>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice2022_23_C");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasColumnName("Billing City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasColumnName("Billing Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasColumnName("Billing State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName1)
                    .HasColumnName("CustomerName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasColumnName("Invoice Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus1)
                    .IsRequired()
                    .HasColumnName("InvoiceStatus")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDesc).HasColumnName("Item Desc");

                entity.Property(e => e.ItemDiscountAmount)
                    .HasColumnName("Item Discount Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("Item Price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemTax)
                    .HasColumnName("Item Tax")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxPercent)
                    .HasColumnName("Item Tax Percent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemTaxType)
                    .HasColumnName("Item Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms).HasColumnName("Payment Terms");

                entity.Property(e => e.PaymentTermsLabel)
                    .HasColumnName("Payment Terms Label")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply).HasMaxLength(255);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.QbCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPerson)
                    .HasColumnName("Sales Person")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("Shipping Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Invoice202324A>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice2023_24_A");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasColumnName("Billing City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasColumnName("Billing Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasColumnName("Billing State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName1)
                    .HasColumnName("CustomerName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasColumnName("Invoice Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus1)
                    .IsRequired()
                    .HasColumnName("InvoiceStatus")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDesc).HasColumnName("Item Desc");

                entity.Property(e => e.ItemDiscountAmount)
                    .HasColumnName("Item Discount Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("Item Price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemTax)
                    .HasColumnName("Item Tax")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxPercent)
                    .HasColumnName("Item Tax Percent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemTaxType)
                    .HasColumnName("Item Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms).HasColumnName("Payment Terms");

                entity.Property(e => e.PaymentTermsLabel)
                    .HasColumnName("Payment Terms Label")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply).HasMaxLength(255);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.QbCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPerson)
                    .HasColumnName("Sales Person")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("Shipping Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvoiceAgingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceAgingView");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(255);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Days7690)
                    .HasColumnName("days_76-90")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsContacts).HasMaxLength(255);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOutstanding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedCredits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e._15)
                    .HasColumnName("15+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._30)
                    .HasColumnName("30+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._45)
                    .HasColumnName("45+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._60)
                    .HasColumnName("60+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._75)
                    .HasColumnName("75+")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e._90)
                    .HasColumnName("90+")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvoiceBillApril>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerVendor)
                    .HasColumnName("Customer_Vendor")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber).HasMaxLength(255);

                entity.Property(e => e.JobNumber).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<InvoiceLineItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceLineItemsView");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK__Invoices__D796AAB5DB47A52F");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountPaidFcy)
                    .HasColumnName("AmountPaidFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy)
                    .HasColumnName("BalanceFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditsApplied).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditsAppliedFcy)
                    .HasColumnName("CreditsAppliedFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentAmountFcy)
                    .HasColumnName("PaymentAmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentTerms).HasMaxLength(255);

                entity.Property(e => e.Project).HasMaxLength(255);

                entity.Property(e => e.SalesPerson).HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFcy)
                    .HasColumnName("TotalFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transaction).HasMaxLength(20);

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.UsdexRate)
                    .HasColumnName("USDExRate")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvoicesPlanB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoices_PlanB");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.ForeignAmount).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.ForeignOpenBalance).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.OpenBalance).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<InvoicesPlanBXls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoices_PlanB_xls");

                entity.Property(e => e.Account)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId)
                    .HasColumnName("BillingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasColumnName("Billing City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountry)
                    .HasColumnName("Billing Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasColumnName("Billing State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName1)
                    .HasColumnName("CustomerName")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasColumnName("Invoice Status")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus1)
                    .IsRequired()
                    .HasColumnName("InvoiceStatus")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsInclusiveTax)
                    .IsRequired()
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDesc).HasColumnName("Item Desc");

                entity.Property(e => e.ItemDiscountAmount)
                    .HasColumnName("Item Discount Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("Item Price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemTax)
                    .HasColumnName("Item Tax")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxPercent)
                    .HasColumnName("Item Tax Percent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemTaxType)
                    .HasColumnName("Item Tax Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("Item Type")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.PartialPayments)
                    .IsRequired()
                    .HasColumnName("Partial Payments")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms).HasColumnName("Payment Terms");

                entity.Property(e => e.PaymentTermsLabel)
                    .HasColumnName("Payment Terms Label")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfSupply).HasMaxLength(255);

                entity.Property(e => e.PrintStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.QbCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPerson)
                    .HasColumnName("Sales Person")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress3)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress4)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress5)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping City")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("Shipping Country")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping State")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sparse).HasColumnName("sparse");

                entity.Property(e => e.SupplyType)
                    .IsRequired()
                    .HasColumnName("Supply Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionLocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnTaxDetailTotalTax).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<JournalLineItemView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("JournalLineItemView");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PercentageOfTotal).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTaxGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvBillCredited>(entity =>
            {
                entity.ToTable("jv_BillCredited");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("bill_number")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreditedAmount)
                    .HasColumnName("credited_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBillId)
                    .HasColumnName("journal_bill_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JournalId)
                    .HasColumnName("journalID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvConvertedToPayment>(entity =>
            {
                entity.ToTable("jv_ConvertedToPayment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewpaymentId)
                    .HasColumnName("newpaymentId")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OldjournalId)
                    .HasColumnName("oldjournalId")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvInvoiceBranchfix202223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JV_INVOICE_BRANCHFIX_202223");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.InvoiceBranch).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.Jvbranch)
                    .HasColumnName("JVBranch")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentUniqueId)
                    .HasColumnName("PaymentUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("txnid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvInvoiceCredit201820>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JV_INVOICE_CREDIT_201820");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.InvoiceBranch).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.Jvbranch)
                    .HasColumnName("JVBranch")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentUniqueId)
                    .HasColumnName("PaymentUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("txnid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvInvoiceCredit202022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JV_INVOICE_CREDIT_202022");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.InvoiceBranch).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.Jvbranch)
                    .HasColumnName("JVBranch")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentUniqueId)
                    .HasColumnName("PaymentUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("txnid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvInvoiceCredit202223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JV_INVOICE_CREDIT_202223");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.InvoiceBranch).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal Number")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.Jvbranch)
                    .HasColumnName("JVBranch")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentUniqueId)
                    .HasColumnName("PaymentUniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("txnid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JvInvoicesCredited>(entity =>
            {
                entity.ToTable("jv_InvoicesCredited");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreditedAmount)
                    .HasColumnName("credited_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JournalId)
                    .HasColumnName("journalID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JournalInvoiceId)
                    .HasColumnName("journal_invoice_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedgerTempInrMumbaiFlc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ledger_TempINR_Mumbai_FLC_2223");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MergedCustomerData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_CustomerData");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MergedCustomerData202308244pm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_CustomerData_20230824_4pm");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MergedCustomerData20230825>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_CustomerData_20230825");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MergedCustomerDataBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_CustomerData_backup");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MergedVendorData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_VendorData");

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MergedVendorDataNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("merged_VendorData_new");

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MessageList>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__MessageL__C87C037C7A926383");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageContent).IsRequired();

                entity.Property(e => e.MessageCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.MessageStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Old2DumpBankLegder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("old2_dump_Bank_Legder");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueLineId)
                    .HasColumnName("UniqueLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Old2ZohoBankLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("old2_zoho_bank_ledger");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OldDumpBankLegder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("old_dump_Bank_Legder");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldZohoBankLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("old_zoho_bank_ledger");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OpenAllocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("open_allocations");

                entity.Property(e => e.BillBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpenAllocationsAugust>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("open_allocations_august");

                entity.Property(e => e.BillBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpenBillpayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("open_billpayments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpenBillpaymentsAugust>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("open_billpayments_august");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpenJournalpayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("open_journalpayments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasColumnName("UniqueVendorID")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentTermMapping>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentTermLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Qbid)
                    .HasColumnName("QBID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoId)
                    .HasColumnName("ZohoID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbCustomJv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_custom_JV");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.JvnumberOrCreditnote)
                    .HasColumnName("JVNUMBER_OR_CREDITNOTE")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTxnType).HasMaxLength(255);

                entity.Property(e => e.TxnId).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<QbCustomJv2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_custom_jv2");

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to Invoice");

                entity.Property(e => e.CrDr).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.JvnumberOrCreditnote)
                    .HasColumnName("JVNUMBER_OR_CREDITNOTE")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTxnType).HasMaxLength(255);

                entity.Property(e => e.TxnId).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<QbHdfc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_hdfc_2223");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbHdfc2223Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_hdfc_2223_backup");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbHdfc2223Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_hdfc_2223_staging");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmtFcy)
                    .HasColumnName("TotalAmtFCY")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy)
                    .HasColumnName("zoho_fcy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbItemHsn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QbItemHSN");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCode")
                    .HasMaxLength(255);

                entity.Property(e => e.IncomeAccount).HasMaxLength(255);

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.SalesDescription).HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbOpenInvoices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qb_open_invoices");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BalanceFcy).HasColumnName("balance_fcy");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ForeignAmount).HasColumnName("foreign_amount");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(255);

                entity.Property(e => e.OpenBalance).HasColumnName("open_balance");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(50);

                entity.Property(e => e.TxnDate)
                    .HasColumnName("txn_date")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QbTrialbalancestatement>(entity =>
            {
                entity.ToTable("qb_trialbalancestatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adj)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ForeignAmount)
                    .HasColumnName("Foreign Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ForeignCredit)
                    .HasColumnName("Foreign_Credit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ForeignDebit)
                    .HasColumnName("Foreign_Debit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ForeignTaxAmount)
                    .HasColumnName("Foreign Tax Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemoDescription)
                    .HasColumnName("Memo_Description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductService)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RevaluedAmount)
                    .HasColumnName("Revalued Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevaluedExchangeRate)
                    .HasColumnName("Revalued exchange Rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Split)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("Tax Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxableAmount)
                    .HasColumnName("Taxable Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnrealisedGainLoss)
                    .HasColumnName("Unrealised GainLoss")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Year)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbzohoTaxMappings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBZohoTaxMappings");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompId).HasColumnName("CompID");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.FretrackOfficeId).HasColumnName("FretrackOfficeID");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTypeGst)
                    .HasColumnName("invoiceTypeGST")
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Percentage).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.QbcompanyId)
                    .HasColumnName("QBCompanyID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeDescription)
                    .HasColumnName("QBTaxCodeDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeName)
                    .HasColumnName("QBTaxCodeName")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateName)
                    .HasColumnName("QBTaxRateName")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.TaxMappingId)
                    .HasColumnName("TaxMappingID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ZohoTaxGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbzohoTaxMappingsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QBZohoTaxMappingsView");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeName)
                    .HasColumnName("QBTaxCodeName")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateName)
                    .HasColumnName("QBTaxRateName")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.UniqueQbtaxCodeId)
                    .HasColumnName("UniqueQBTaxCodeID")
                    .HasMaxLength(256);

                entity.Property(e => e.ZohoTaxGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportFilesList>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReportFilesListNew>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK__ReportFi__869767EAA81F805F");

                entity.ToTable("ReportFilesList_new");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate).HasColumnType("date");
            });

            modelBuilder.Entity<SortBillPaymentLines28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_BillPaymentLines_28APR");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentTxnType)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortBills>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Bills");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(113)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortBills25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Bills_25Apr");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(113)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortBills28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Bills_28Apr");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(113)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortBills5may>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Bills_5May");

                entity.Property(e => e.BranchDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber2)
                    .HasMaxLength(113)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortCustomers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Customers");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NewDisplayName)
                    .HasMaxLength(508)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortCustomers25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Customers_25APR");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NewDisplayName)
                    .HasMaxLength(508)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortCustomers28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Customers_28APR");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NewDisplayName)
                    .HasMaxLength(508)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Items");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewDisplayName)
                    .HasMaxLength(208)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortParentCustomers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_ParentCustomers");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Hierarchy).IsUnicode(false);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortParentCustomers25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_ParentCustomers_25APR");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Hierarchy).IsUnicode(false);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortParentCustomers28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_ParentCustomers_28APR");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Hierarchy).IsUnicode(false);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortPaymentReceivedLines28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_PaymentReceivedLines_28APR");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("Invoice Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortProjects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Projects");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewProjectName)
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortProjects25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Projects_25APR");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewProjectName)
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortProjects28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Projects_28APR");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewProjectName)
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortProjectsBackup25apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Projects_backup25apr");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewProjectName)
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortProjectsBackup28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Projects_backup28apr");

                entity.Property(e => e.BillingType)
                    .IsRequired()
                    .HasColumnName("Billing Type")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetType)
                    .IsRequired()
                    .HasColumnName("Budget Type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewProjectName)
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBranch)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectBudgetHours).HasColumnName("Project Budget Hours");

                entity.Property(e => e.ProjectCost).HasColumnName("Project Cost");

                entity.Property(e => e.UniqueCustomerId)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoCustomerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SortVendors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sort_Vendors");

                entity.Property(e => e.Branch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NewDisplayName)
                    .HasMaxLength(508)
                    .IsUnicode(false);

                entity.Property(e => e.OldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TdsReceivableRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TDS_Receivable_Range");

                entity.Property(e => e.AccLevel).HasColumnName("acc_level");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(553)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qbcompany)
                    .HasColumnName("qbcompany")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnusedCreditCust>(entity =>
            {
                entity.ToTable("unusedCreditCust");

                entity.Property(e => e.AmountBcy)
                    .HasColumnName("AmountBCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountFcy)
                    .HasColumnName("AmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("ARBranch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Arsalesperson)
                    .HasColumnName("ARSalesperson")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmountBcy)
                    .HasColumnName("RefundAmountBCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundAmountFcy)
                    .HasColumnName("RefundAmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transaction).HasMaxLength(20);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnusedAmountBcy)
                    .HasColumnName("UnusedAmountBCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnusedAmountFcy)
                    .HasColumnName("UnusedAmountFCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VendorCreditLineItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VendorCreditLineItemsView");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbtaxRateId)
                    .HasColumnName("QBTaxRateID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBillAmountAllocated>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_billAmountAllocated");

                entity.Property(e => e.Amountallocated)
                    .HasColumnName("AMOUNTALLOCATED")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Billnumber)
                    .HasColumnName("BILLNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Billtxnid)
                    .HasColumnName("BILLTXNID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorid)
                    .HasColumnName("uniqueVendorid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBillPaymentLinesCompare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BillPaymentLines_Compare");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bank)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.BillAmount)
                    .HasColumnName("Bill Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAcc).HasColumnName("Credit_Acc");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAcc).HasColumnName("Debit_Acc");

                entity.Property(e => e.IsSolved).HasColumnName("isSolved");

                entity.Property(e => e.PayLineId).HasColumnName("PayLineID");

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolvedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueVendorId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoTransactionId)
                    .HasColumnName("ZohoTransactionID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwCompareCustomerpayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_compare_customerpayments");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Qb).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Zoho).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VwCompareCustomerpayments2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_compare_customerpayments_2");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Jv)
                    .HasColumnName("JV")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Qb).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Zoho).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VwCompareVendorpayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_compare_vendorpayments");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Qb).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Zoho).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VwDumpCustomers28apr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_dump_Customers_28APR");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDumpZohoVendors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_dump_ZohoVendors");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJournalAccountTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JournalAccountTypes");

                entity.Property(e => e.CreditAcc).HasColumnName("Credit_Acc");

                entity.Property(e => e.DebitAcc).HasColumnName("Debit_Acc");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwJvvalueByEntity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JVValueByEntity");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JvAmount)
                    .HasColumnName("JV_AMOUNT")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Jvdate)
                    .HasColumnName("JVDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JvlineEntityType)
                    .HasColumnName("JVLineEntityType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jvlineentityrefname)
                    .HasColumnName("JVLINEENTITYREFNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueEntityId)
                    .HasColumnName("UniqueEntityID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueJvid)
                    .HasColumnName("UniqueJVID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOpenPaymentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OpenPaymentList");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JvCnNo)
                    .HasColumnName("jv_cn_no")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("txnid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Txntype)
                    .HasColumnName("txntype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPaymentDeposits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PaymentDeposits");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueTxnId)
                    .HasColumnName("UniqueTxnID")
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPaymentTransactionCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Payment_TransactionCount");

                entity.Property(e => e.Creditmemo).HasColumnName("CREDITMEMO");

                entity.Property(e => e.Invoice).HasColumnName("INVOICE");

                entity.Property(e => e.Journalentry).HasColumnName("JOURNALENTRY");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwQbtxns>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_qbtxns");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("parent_account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("txndate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwQbtxnsNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_qbtxns_new");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("parent_account")
                    .HasMaxLength(255);

                entity.Property(e => e.QbBranch)
                    .HasColumnName("qbBranch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleHead)
                    .HasColumnName("schedule_head")
                    .HasMaxLength(255);

                entity.Property(e => e.TbGroup)
                    .HasColumnName("tb_group")
                    .HasMaxLength(255);

                entity.Property(e => e.TbName)
                    .HasColumnName("tb_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("txndate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwQbtxnsNewCompare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_qbtxns_newCompare");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasColumnName("Contact_Type")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("parent_account")
                    .HasMaxLength(255);

                entity.Property(e => e.QbBranch)
                    .HasColumnName("qbBranch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleHead)
                    .HasColumnName("schedule_head")
                    .HasMaxLength(255);

                entity.Property(e => e.TbGroup)
                    .HasColumnName("tb_group")
                    .HasMaxLength(255);

                entity.Property(e => e.TbName)
                    .HasColumnName("tb_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("txndate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUniqueCustomerStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_uniqueCustomerStatement");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUniqueVenderStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_uniqueVenderStatement");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUniqueZohoCustomerPaymentsBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Unique_Zoho_CustomerPayments_Bank");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.NewBankName)
                    .HasColumnName("New  Bank  Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<VwUniqueZohoCustomerPaymentsBankTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Unique_Zoho_CustomerPayments_Bank_Test");

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to INVOICE");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.JvCredit)
                    .HasColumnName("JV CREDIT")
                    .HasColumnType("numeric(1, 1)");

                entity.Property(e => e.JvDebit)
                    .HasColumnName("JV DEBIT")
                    .HasColumnType("numeric(1, 1)");

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("PAID THROUGH")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Purchase)
                    .HasColumnName("PURCHASE")
                    .HasColumnType("numeric(1, 1)");

                entity.Property(e => e.QbAmount)
                    .IsRequired()
                    .HasColumnName("QB Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TxnId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .IsRequired()
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount).HasColumnName("ZOHO_AMOUNT");

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("ZOHO_BANK")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwVendorOpeningBalances>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VendorOpeningBalances");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate).HasMaxLength(255);

                entity.Property(e => e.ShortBranch).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoOpenInvoicesMismatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZohoOpenInvoices_mismatch");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.QbBalance)
                    .HasColumnName("QB_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbCustomer)
                    .HasColumnName("QB_CUSTOMER")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbTotal)
                    .HasColumnName("QB_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoOpenInvoicesMismatch13jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZohoOpenInvoices_mismatch_13jun");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.QbBalance)
                    .HasColumnName("QB_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbCustomer)
                    .HasColumnName("QB_CUSTOMER")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbTotal)
                    .HasColumnName("QB_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoOpenInvoicesMismatch20jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZohoOpenInvoices_mismatch_20jun");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.QbBalance)
                    .HasColumnName("QB_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbCustomer)
                    .HasColumnName("QB_CUSTOMER")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbTotal)
                    .HasColumnName("QB_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoOpenInvoicesMismatch24jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZohoOpenInvoices_mismatch_24jun");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.QbBalance)
                    .HasColumnName("QB_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbCustomer)
                    .HasColumnName("QB_CUSTOMER")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbTotal)
                    .HasColumnName("QB_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoOpenInvoicesMismatchFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZohoOpenInvoices_mismatch_final");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.QbBalance)
                    .HasColumnName("QB_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbCustomer)
                    .HasColumnName("QB_CUSTOMER")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.QbTotal)
                    .HasColumnName("QB_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwZohoVendorPortalDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Zoho_VendorPortalDetails");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CreditAcc).HasColumnName("Credit_Acc");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DebitAcc).HasColumnName("Debit_Acc");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("FCY Credit")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("FCY Debit")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.FcyNetAmount)
                    .HasColumnName("FCY Net Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwZohovendorstatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_zohovendorstatement");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RunningBalance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Transactions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.Vendorname)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlpxlHdfc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xlpxl_hdfc_2223");

                entity.Property(e => e.AamodRemarks).HasMaxLength(255);

                entity.Property(e => e.Assign)
                    .HasColumnName("ASSIGN")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAccountName).HasMaxLength(255);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DocNumber).HasMaxLength(255);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus).HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.TotalAmtFcy).HasColumnName("TotalAmtFCY");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasMaxLength(255);

                entity.Property(e => e.UniqueId).HasMaxLength(255);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("zoho_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoFcy).HasColumnName("zoho_fcy");

                entity.Property(e => e.ZohoStatus)
                    .HasColumnName("zoho_status")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoTxncount).HasColumnName("zoho_txncount");

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<XlsAccountsPayable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_AccountsPayable");

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<XlsAccountsReceivable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_AccountsReceivable");

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.QbcustomerName)
                    .HasColumnName("QBCustomerName")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlsAccountsReceivable2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_AccountsReceivable_2023");

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DebitCredit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.FullyQualifiedName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.QbcustomerName)
                    .HasColumnName("QBCustomerName")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlsAppliedCreditNotes20230611>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_Applied_Credit_Notes_20230611");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditNoteNumber)
                    .HasColumnName("Credit Note Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlsInvoicePayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_InvoicePayments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("Invoice Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlsInvoicePayments2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_InvoicePayments2");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice)
                    .HasColumnName("Amount Applied to Invoice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountAppliedToInvoice1).HasColumnName("AmountAppliedToInvoice");

                entity.Property(e => e.AppliedTotal).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BankCharges)
                    .IsRequired()
                    .HasColumnName("Bank Charges")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.DepositToAccountId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("Invoice Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNumberSuffix).HasColumnName("Payment Number Suffix");

                entity.Property(e => e.PaymentTxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .IsRequired()
                    .HasColumnName("Tax Account")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdingTaxAmount)
                    .IsRequired()
                    .HasColumnName("Withholding Tax Amount")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XlsTrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_TrialBalance");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchShort).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbaccountName)
                    .HasColumnName("QBAccountName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<XlsTrialBalance2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xls_TrialBalance_2023");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.BranchShort).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.DebitCredit).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MigrationDate)
                    .HasColumnName("Migration Date")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent_Account")
                    .HasMaxLength(506)
                    .IsUnicode(false);

                entity.Property(e => e.QbId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbaccountName)
                    .HasColumnName("QBAccountName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoAp18oct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ap_18oct");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.Days130).HasColumnName("days_1_30");

                entity.Property(e => e.Days3160).HasColumnName("days_31_60");

                entity.Property(e => e.DaysAbove60).HasColumnName("days_above_60");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedCredits).HasColumnName("unused_credits");

                entity.Property(e => e.UnusedCreditsBcy).HasColumnName("unused_credits_bcy");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAp).HasColumnName("zoho_ap");

                entity.Property(e => e.ZohoApFcy).HasColumnName("zoho_ap_fcy");
            });

            modelBuilder.Entity<ZohoAp21sep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ap_21sep");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.Days115).HasColumnName("days_1_15");

                entity.Property(e => e.Days1630).HasColumnName("days_16_30");

                entity.Property(e => e.Days3145).HasColumnName("days_31_45");

                entity.Property(e => e.DaysAbove45).HasColumnName("days_above_45");

                entity.Property(e => e.GstNo)
                    .HasColumnName("gst_no")
                    .HasMaxLength(255);

                entity.Property(e => e.OutstandingAmount).HasColumnName("outstanding_amount");

                entity.Property(e => e.OutstandingAmountBcy).HasColumnName("outstanding_amount_bcy");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedCredits).HasColumnName("unused_credits");

                entity.Property(e => e.UnusedCreditsBcy).HasColumnName("unused_credits_bcy");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAp).HasColumnName("zoho_ap");

                entity.Property(e => e.ZohoApFcy).HasColumnName("zoho_ap_fcy");
            });

            modelBuilder.Entity<ZohoApSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_AP_Summary");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("Assigned to")
                    .HasMaxLength(255);

                entity.Property(e => e.BilledAmount).HasColumnName("billed_amount");

                entity.Property(e => e.ClosingFcy).HasColumnName("closing_fcy");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.Difference).HasColumnName("difference");

                entity.Property(e => e.Imported).HasMaxLength(255);

                entity.Property(e => e.QbClosing).HasColumnName("qb_closing");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbId)
                    .HasColumnName("qb_id")
                    .HasMaxLength(255);

                entity.Property(e => e.QbVendorName)
                    .HasColumnName("qb_vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.Zoho11aug).HasColumnName("ZOHO_11AUG");

                entity.Property(e => e.ZohoClosing).HasColumnName("zoho_closing");

                entity.Property(e => e.ZohoVendorName)
                    .HasColumnName("zoho_vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoAppliedVendorCredits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_AppliedVendorCredits");

                entity.Property(e => e.AppliedCreditAmount).HasColumnName("applied_credit_amount");

                entity.Property(e => e.BillNumber)
                    .HasColumnName("bill_number")
                    .HasMaxLength(255);

                entity.Property(e => e.TxnDate)
                    .HasColumnName("txn_date")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorCreditNumber)
                    .HasColumnName("vendor_credit_number")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoApplyCn118jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Apply_CN1_18jun");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.JvnumberOrCreditnote)
                    .HasColumnName("JVNUMBER_OR_CREDITNOTE")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTxnType).HasMaxLength(255);

                entity.Property(e => e.TxnId).HasMaxLength(255);

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoAr16Sep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ar_16_sep");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.CustUniqueId)
                    .HasColumnName("cust_unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Days115).HasColumnName("days_1-15");

                entity.Property(e => e.Days1630).HasColumnName("days_16-30");

                entity.Property(e => e.Days3145).HasColumnName("days_31-45");

                entity.Property(e => e.DaysAbove45).HasColumnName("days_above-45");

                entity.Property(e => e.FcyTotal).HasColumnName("fcy_total");

                entity.Property(e => e.OutstandingReceivableAmount).HasColumnName("outstanding_receivable_amount");

                entity.Property(e => e.OutstandingReceivableAmountBcy).HasColumnName("outstanding_receivable_amount_bcy");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UnusedCreditsReceivableAmount).HasColumnName("unused_credits_receivable_amount");

                entity.Property(e => e.UnusedCreditsReceivableAmountBcy).HasColumnName("unused_credits_receivable_amount_bcy");
            });

            modelBuilder.Entity<ZohoArAgingJvCn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ar_aging_jv_cn");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyTotal).HasColumnName("fcy_total");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UnusedCredits).HasColumnName("unused_credits");

                entity.Property(e => e.UnusedCreditsFcy).HasColumnName("unused_credits_fcy");
            });

            modelBuilder.Entity<ZohoArBalance22aug>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ar_balance_22aug");

                entity.Property(e => e.AmountReceived).HasColumnName("amount_received");

                entity.Property(e => e.ClosingBalance).HasColumnName("closing_balance");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyClosingBalance).HasColumnName("fcy_closing_balance");

                entity.Property(e => e.InvoicedAmount).HasColumnName("invoiced_amount");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbId)
                    .HasColumnName("qb_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBank2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_2223");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZohoBank2223Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_2223_backup");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZohoBankLedger>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__zoho_ban__2EAE64C9190170BD");

                entity.ToTable("zoho_bank_ledger");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankLedger20240330>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_ledger_20240330");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefund22032024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_22032024");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefund23032024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_23032024");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefund23032024Success>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_23032024_success");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefundError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_error");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefundErrorEx230324>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_errorEX230324");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefundEx230324>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_EX230324");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankRefundEx230324Hdfc3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_refund_EX230324_hdfc3");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankReturn22032024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_return_22032024");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankReturnEx230324>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_return_EX230324");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankReturnExv01042024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_return_EXV01042024");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBankTempFlc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bank_temp_flc");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBillpayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_billpayments");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillAmount).HasColumnName("bill_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionNotes).HasColumnName("description_notes");

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBills11sep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bills_11sep");

                entity.Property(e => e.BcyBalance).HasColumnName("bcy_balance");

                entity.Property(e => e.BcyTotal).HasColumnName("bcy_total");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(255);

                entity.Property(e => e.BillNumber)
                    .HasColumnName("bill_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.FcyBalance).HasColumnName("fcy_balance");

                entity.Property(e => e.FcyTotal).HasColumnName("fcy_total");

                entity.Property(e => e.GstNo)
                    .HasColumnName("gst_no")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectNames)
                    .HasColumnName("project_names")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoBills2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_bills_2223");

                entity.Property(e => e.BalanceAmountFcy).HasColumnName("BalanceAmountFCY");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.ZohoBillId)
                    .HasColumnName("zoho_bill_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoVendorId)
                    .HasColumnName("zoho_vendor_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoChargeItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ChargeItems");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Brand).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DimensionUnit)
                    .HasColumnName("Dimension Unit")
                    .HasMaxLength(255);

                entity.Property(e => e.Ean)
                    .HasColumnName("EAN")
                    .HasMaxLength(255);

                entity.Property(e => e.ExemptionReason)
                    .HasColumnName("Exemption Reason")
                    .HasMaxLength(255);

                entity.Property(e => e.HsnSac)
                    .HasColumnName("HSN/SAC")
                    .HasMaxLength(255);

                entity.Property(e => e.InterStateTaxName)
                    .HasColumnName("Inter State Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.InterStateTaxRate)
                    .HasColumnName("Inter State Tax Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.InterStateTaxType)
                    .HasColumnName("Inter State Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.IntraStateTaxName)
                    .HasColumnName("Intra State Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.IntraStateTaxRate)
                    .HasColumnName("Intra State Tax Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.IntraStateTaxType)
                    .HasColumnName("Intra State Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryAccount)
                    .HasColumnName("Inventory Account")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryAccountCode)
                    .HasColumnName("Inventory Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.IsReturnableItem)
                    .HasColumnName("Is Returnable Item")
                    .HasMaxLength(255);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemId)
                    .HasColumnName("Item ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemType)
                    .HasColumnName("Item Type")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSyncTime)
                    .HasColumnName("Last Sync Time")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Mpn)
                    .HasColumnName("MPN")
                    .HasMaxLength(255);

                entity.Property(e => e.OpeningStock)
                    .HasColumnName("Opening Stock")
                    .HasMaxLength(255);

                entity.Property(e => e.OpeningStockValue)
                    .HasColumnName("Opening Stock Value")
                    .HasMaxLength(255);

                entity.Property(e => e.PackageHeight).HasColumnName("Package Height");

                entity.Property(e => e.PackageLength).HasColumnName("Package Length");

                entity.Property(e => e.PackageWeight).HasColumnName("Package Weight");

                entity.Property(e => e.PackageWidth).HasColumnName("Package Width");

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseAccount)
                    .HasColumnName("Purchase Account")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseAccountCode)
                    .HasColumnName("Purchase Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseDescription)
                    .HasColumnName("Purchase Description")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseRate)
                    .HasColumnName("Purchase Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.Rate).HasMaxLength(255);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("Reference ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReorderPoint)
                    .HasColumnName("Reorder Point")
                    .HasMaxLength(255);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.StockOnHand)
                    .HasColumnName("Stock On Hand")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxabilityType)
                    .HasColumnName("Taxability Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Taxable).HasMaxLength(255);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(255);

                entity.Property(e => e.UsageUnit)
                    .HasColumnName("Usage unit")
                    .HasMaxLength(255);

                entity.Property(e => e.Vendor).HasMaxLength(255);

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("Weight Unit")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoChargeitemsMin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Chargeitems_min");

                entity.Property(e => e.ItemId)
                    .HasColumnName("Item ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoChartOfAccounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_ChartOfAccounts");

                entity.Property(e => e.Account)
                    .HasColumnName("Account # ")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountCode1)
                    .HasColumnName("Account Code1")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account ID")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsMileage).HasMaxLength(255);

                entity.Property(e => e.MileageRate)
                    .HasColumnName("Mileage Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.MileageUnit)
                    .HasColumnName("Mileage Unit")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent Account")
                    .HasMaxLength(255);

                entity.Property(e => e.QbAccountId)
                    .HasColumnName("QbAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbShortBranch).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoCoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_coa");

                entity.Property(e => e.Account)
                    .HasColumnName("Account # ")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account ID")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsMileage).HasMaxLength(255);

                entity.Property(e => e.MileageRate)
                    .HasColumnName("Mileage Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.MileageUnit)
                    .HasColumnName("Mileage Unit")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentAccount)
                    .HasColumnName("Parent Account")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoCurrencies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Currencies");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFormat)
                    .HasColumnName("currency_format")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasColumnName("currency_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyNameFormatted)
                    .HasColumnName("currency_name_formatted")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnName("currency_symbol")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasMaxLength(255);

                entity.Property(e => e.IsBaseCurrency)
                    .HasColumnName("is_base_currency")
                    .HasMaxLength(255);

                entity.Property(e => e.PricePrecision)
                    .HasColumnName("price_precision")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoCustomerPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_customer_payments");

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to Invoice");

                entity.Property(e => e.BankCharges).HasColumnName("Bank Charges");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(255);

                entity.Property(e => e.DepositToAccountCode)
                    .HasColumnName("Deposit To Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoicePaymentId)
                    .HasColumnName("InvoicePayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberSuffix)
                    .HasColumnName("Payment Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType1)
                    .HasColumnName("Payment Type1")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupply)
                    .HasColumnName("Place of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasColumnName("Place of Supply(With State Code)")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccount)
                    .HasColumnName("Tax Account")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("Unused Amount");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnName("Withholding Tax Amount");
            });

            modelBuilder.Entity<ZohoCustomerPayments1>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Zoho_CustomerPayments");

                entity.ToTable("zoho_CustomerPayments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to Invoice");

                entity.Property(e => e.BankCharges).HasColumnName("Bank Charges");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(250);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(255);

                entity.Property(e => e.DepositToAccountCode)
                    .HasColumnName("Deposit To Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoicePaymentId)
                    .HasColumnName("InvoicePayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberSuffix)
                    .HasColumnName("Payment Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType1)
                    .HasColumnName("Payment Type1")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupply)
                    .HasColumnName("Place of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasColumnName("Place of Supply(With State Code)")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccount)
                    .HasColumnName("Tax Account")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("Unused Amount");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnName("Withholding Tax Amount");
            });

            modelBuilder.Entity<ZohoCustomerPayments1822>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_customer_payments_1822");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Documents)
                    .HasColumnName("documents")
                    .HasMaxLength(255);

                entity.Property(e => e.GatewayTransactionId)
                    .HasColumnName("gateway_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.HasAttachment)
                    .HasColumnName("has_attachment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(255);

                entity.Property(e => e.IsAdvancePayment)
                    .HasColumnName("is_advance_payment")
                    .HasMaxLength(255);

                entity.Property(e => e.JvUniqueid)
                    .HasColumnName("jv_uniqueid")
                    .HasMaxLength(255);

                entity.Property(e => e.LastFourDigits)
                    .HasColumnName("last_four_digits")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.TaxAccountId)
                    .HasColumnName("tax_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccountName)
                    .HasColumnName("tax_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmountWithheld).HasColumnName("tax_amount_withheld");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");
            });

            modelBuilder.Entity<ZohoCustomerPaymentsBank>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Zoho_CustomerPayments_Bank");

                entity.ToTable("zoho_CustomerPayments_bank");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to Invoice");

                entity.Property(e => e.BankCharges).HasColumnName("Bank Charges");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(255);

                entity.Property(e => e.DepositToAccountCode)
                    .HasColumnName("Deposit To Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoicePaymentId)
                    .HasColumnName("InvoicePayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.NewBankName)
                    .HasColumnName("New  Bank  Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberSuffix)
                    .HasColumnName("Payment Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType1)
                    .HasColumnName("Payment Type1")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupply)
                    .HasColumnName("Place of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasColumnName("Place of Supply(With State Code)")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAccount)
                    .HasColumnName("Tax Account")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("Unused Amount");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnName("Withholding Tax Amount");
            });

            modelBuilder.Entity<ZohoCustomerPaymentsBankBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zoho_CustomerPayments_Bank_backup");

                entity.Property(e => e.AmountAppliedToInvoice).HasColumnName("Amount Applied to Invoice");

                entity.Property(e => e.BankCharges).HasColumnName("Bank Charges");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("CustomerPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepositTo)
                    .HasColumnName("Deposit To")
                    .HasMaxLength(255);

                entity.Property(e => e.DepositToAccountCode)
                    .HasColumnName("Deposit To Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice Number")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoicePaymentId)
                    .HasColumnName("InvoicePayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.NewBankName)
                    .HasColumnName("New  Bank  Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberSuffix)
                    .HasColumnName("Payment Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType1)
                    .HasColumnName("Payment Type1")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupply)
                    .HasColumnName("Place of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfSupplyWithStateCode)
                    .HasColumnName("Place of Supply(With State Code)")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAccount)
                    .HasColumnName("Tax Account")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("Unused Amount");

                entity.Property(e => e.WithholdingTaxAmount).HasColumnName("Withholding Tax Amount");
            });

            modelBuilder.Entity<ZohoCustomerPaymentsBankUpdate240403>(entity =>
            {
                entity.ToTable("zoho_CustomerPaymentsBankUpdate240403");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.BranchQb)
                    .HasColumnName("BranchQB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBank)
                    .HasColumnName("new_bank")
                    .HasMaxLength(255);

                entity.Property(e => e.NewBankId)
                    .HasColumnName("new_bank_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionType)
                    .HasColumnName("Transaction_Type")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoBank)
                    .HasColumnName("zoho_bank")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoDisplayName)
                    .HasColumnName("Zoho_Display_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoTxnid)
                    .HasColumnName("zoho_txnid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoCustomerRefunds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_customer_refunds");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityType)
                    .HasColumnName("entity_type")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyAmount).HasColumnName("fcy_amount");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundFromAccountId)
                    .HasColumnName("refund_from_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundFromAccountName)
                    .HasColumnName("refund_from_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundMode)
                    .HasColumnName("refund_mode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoCustomers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Customers");

                entity.Property(e => e.BankAccountPayment)
                    .HasColumnName("Bank Account Payment")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingAddress)
                    .HasColumnName("Billing Address")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingAttention)
                    .HasColumnName("Billing Attention")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCity)
                    .HasColumnName("Billing City")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCode)
                    .HasColumnName("Billing Code")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCountry)
                    .HasColumnName("Billing Country")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingFax)
                    .HasColumnName("Billing Fax")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingPhone)
                    .HasColumnName("Billing Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingState)
                    .HasColumnName("Billing State")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingStreet2)
                    .HasColumnName("Billing Street2")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentCompany)
                    .HasColumnName("CF#Parent Company")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentGroup1)
                    .HasColumnName("CF#Parent Group 1")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentGroup2)
                    .HasColumnName("CF#Parent Group 2")
                    .HasMaxLength(255);

                entity.Property(e => e.CfQbChennai)
                    .HasColumnName("CF#QbChennai")
                    .HasMaxLength(255);

                entity.Property(e => e.CfQbMumbai)
                    .HasColumnName("CF#QbMumbai")
                    .HasMaxLength(255);

                entity.Property(e => e.CfSalesPerson)
                    .HasColumnName("CF#Sales Person")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactAddressId)
                    .HasColumnName("Contact Address ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactType)
                    .HasColumnName("Contact Type")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("Credit Limit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerSubType)
                    .HasColumnName("Customer Sub Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Designation).HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.ExemptionReason)
                    .HasColumnName("Exemption Reason")
                    .HasMaxLength(255);

                entity.Property(e => e.Facebook).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(255);

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("Last Modified Time")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSyncTime)
                    .HasColumnName("Last Sync Time")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.MobilePhone).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OpeningBalance)
                    .HasColumnName("Opening Balance")
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerName)
                    .HasColumnName("Owner Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("Payment Terms")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTermsLabel)
                    .HasColumnName("Payment Terms Label")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PlaceOfContact)
                    .HasColumnName("Place Of Contact")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceOfContactWithStateCode)
                    .HasColumnName("Place of Contact(With State Code)")
                    .HasMaxLength(255);

                entity.Property(e => e.PriceList)
                    .HasColumnName("Price List")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryContactId)
                    .HasColumnName("Primary Contact ID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.ShippingAddress)
                    .HasColumnName("Shipping Address")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingAttention)
                    .HasColumnName("Shipping Attention")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping City")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCode)
                    .HasColumnName("Shipping Code")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("Shipping Country")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingFax)
                    .HasColumnName("Shipping Fax")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingPhone)
                    .HasColumnName("Shipping Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping State")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingStreet2)
                    .HasColumnName("Shipping Street2")
                    .HasMaxLength(255);

                entity.Property(e => e.SkypeIdentity)
                    .HasColumnName("Skype Identity")
                    .HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.Taxable).HasMaxLength(255);

                entity.Property(e => e.Twitter).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoCustomerstatement>(entity =>
            {
                entity.ToTable("zoho_customerstatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Payments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transactions)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoCustomerstatementNew>(entity =>
            {
                entity.ToTable("zoho_customerstatementNew");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Payments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transactions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoCustomerstatementOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_customerstatement_old");

                entity.Property(e => e.Customername)
                    .HasColumnName("CUSTOMERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnType).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoDuplicateJvs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_duplicate_JVS");

                entity.Property(e => e.DupCount).HasColumnName("dup_count");

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoJv)
                    .HasColumnName("zoho_JV")
                    .HasMaxLength(54)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoExc260324>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_exc260324");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyTotalExcludingTdsDeduction).HasColumnName("bcy_total_excluding_tds_deduction");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Documents)
                    .HasColumnName("documents")
                    .HasMaxLength(255);

                entity.Property(e => e.HasAttachment)
                    .HasColumnName("has_attachment")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(255);

                entity.Property(e => e.IsAdvancePayment)
                    .HasColumnName("is_advance_payment")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCustomerid)
                    .HasColumnName("qb_customerid")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.TaxAccountId)
                    .HasColumnName("tax_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccountName)
                    .HasColumnName("tax_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmountWithheld).HasColumnName("tax_amount_withheld");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueJvid)
                    .HasColumnName("unique_jvid")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");
            });

            modelBuilder.Entity<ZohoHdfc17dec>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("zoho_hdfc_17dec");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfc20dec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_20dec");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_2223");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfc2223Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_2223_backup");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompareStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.QbDate).HasColumnType("datetime");

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcDec10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_dec10");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcRefund1>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("zoho_hdfc_refund_1");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcRefund2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_refund_2");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcRefund3>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__zoho_hdf__2EAE64C91A932B4A");

                entity.ToTable("zoho_hdfc_refund_3");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Diff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcRefund3Backup22032024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_refund_3_backup22032024");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountAppliedToBill)
                    .HasColumnName("Amount Applied to Bill")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.Jvamount)
                    .HasColumnName("JVAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jvdesc)
                    .HasColumnName("JVDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvexRate)
                    .HasColumnName("JVExRate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JvlineAccountRefName)
                    .HasColumnName("JVLineAccountRefName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JvlinePostingType)
                    .HasColumnName("JVLinePostingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uniqueid1)
                    .HasColumnName("uniqueid")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcReturn2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_return_2223");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoHdfcReturn2223Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_hdfc_return_2223_backup");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoInvoices11sep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_invoices_11sep");

                entity.Property(e => e.AmountWithoutTax).HasColumnName("amount_without_tax");

                entity.Property(e => e.BcyBalance).HasColumnName("bcy_balance");

                entity.Property(e => e.BcyTotal).HasColumnName("bcy_total");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreditAmount).HasColumnName("credit_amount");

                entity.Property(e => e.CreditAmountFcy).HasColumnName("credit_amount_fcy");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.FcyAmountPaid).HasColumnName("fcy_amount_paid");

                entity.Property(e => e.FcyAmountWithoutTax).HasColumnName("fcy_amount_without_tax");

                entity.Property(e => e.FcyBalance).HasColumnName("fcy_balance");

                entity.Property(e => e.FcyTaxAmount).HasColumnName("fcy_tax_amount");

                entity.Property(e => e.FcyTotal).HasColumnName("fcy_total");

                entity.Property(e => e.FcyWriteoffAmount)
                    .HasColumnName("fcy_writeoff_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.GstNo)
                    .HasColumnName("gst_no")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(255);

                entity.Property(e => e.IsEmailed)
                    .HasColumnName("is_emailed")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidAmountFcy).HasColumnName("paid_amount_fcy");

                entity.Property(e => e.PricePrecision)
                    .HasColumnName("price_precision")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectNames)
                    .HasColumnName("project_names")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RemindersSent)
                    .HasColumnName("reminders_sent")
                    .HasMaxLength(255);

                entity.Property(e => e.SalespersonId)
                    .HasColumnName("salesperson_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");

                entity.Property(e => e.TxnDate)
                    .HasColumnName("txn_date")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoInvoices20230430>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_invoices_20230430");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.AmountWithoutTaxFcy).HasColumnName("AmountWithoutTaxFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.CreditsAppliedFcy).HasColumnName("CreditsAppliedFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Igst).HasColumnName("IGST");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentAmountFcy).HasColumnName("PaymentAmountFCY");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.TotalAmountFcy).HasColumnName("TotalAmountFCY");
            });

            modelBuilder.Entity<ZohoJournals3oct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_journals_3oct");

                entity.HasIndex(e => new { e.TransactionId, e.TransactionType, e.NetAmount })
                    .HasName("idx_zoho_journals_1");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv");

                entity.Property(e => e.Account).HasMaxLength(255);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.IsInclusiveTax)
                    .HasColumnName("Is Inclusive Tax")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemOrder).HasColumnName("Item Order");

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(255);

                entity.Property(e => e.JournalNumber).HasMaxLength(255);

                entity.Property(e => e.JournalNumberPrefix)
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.JournalNumberSuffix)
                    .HasColumnName("Journal Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.JournalType)
                    .HasColumnName("Journal Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAmount).HasColumnName("Tax Amount");

                entity.Property(e => e.TaxBasis)
                    .HasColumnName("Tax Basis")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxType)
                    .HasColumnName("Tax Type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJv11sep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv_11sep");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJv2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv_2223");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJv22232jan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv_2223_2jan");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJvAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv_all");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(1000);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoJvFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_jv_final");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoMissingBills31jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_MissingBills_31Jul");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<ZohoMissmatched31jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Missmatched_31Jul");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NewDocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewDocNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbAmount)
                    .HasColumnName("QB_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.QbRunningBalance)
                    .HasColumnName("QB_RunningBalance")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZohoAmount)
                    .HasColumnName("Zoho_Amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZohoRunningBalance)
                    .HasColumnName("ZOHO_RunningBalance")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<ZohoOdBills10jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_bills_10jul");

                entity.Property(e => e.BalanceAmountFcy).HasColumnName("BalanceAmountFCY");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.DueDate).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoOdBills1aug>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_bills_1aug");

                entity.Property(e => e.BalanceAmountFcy).HasColumnName("BalanceAmountFCY");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.Gsttreatment)
                    .HasColumnName("GSTTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.ZohoBillId)
                    .HasColumnName("zoho_bill_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoVendorId)
                    .HasColumnName("zoho_vendor_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoOdBills1jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_bills_1jul");

                entity.Property(e => e.AmountWithoutTaxFcy).HasColumnName("AmountWithoutTaxFCY");

                entity.Property(e => e.BalanceAmountFcy).HasColumnName("BalanceAmountFCY");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoOdBills20jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_bills_20jul");

                entity.Property(e => e.BcyBalance).HasColumnName("bcy_balance");

                entity.Property(e => e.BcyTotal).HasColumnName("bcy_total");

                entity.Property(e => e.BillNumber)
                    .HasColumnName("bill_number")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.FcyBalance).HasColumnName("fcy_balance");

                entity.Property(e => e.FcyTotal).HasColumnName("fcy_total");

                entity.Property(e => e.GstNo)
                    .HasColumnName("gst_no")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("quickbooks_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoOdBills5jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_bills_5jul");

                entity.Property(e => e.BalanceAmountFcy).HasColumnName("BalanceAmountFCY");

                entity.Property(e => e.BillAmountFcy).HasColumnName("BillAmountFCY");

                entity.Property(e => e.BillDate).HasMaxLength(255);

                entity.Property(e => e.BillNumber).HasMaxLength(255);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.DueDate).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.VendorName1).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoOdInvoices20jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_invoices_20jun");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.AmountwithoutTaxFcy).HasColumnName("AmountwithoutTaxFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditsAppliedFcy).HasColumnName("CreditsAppliedFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentAmountFcy).HasColumnName("PaymentAmountFCY");

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAmountFcy).HasColumnName("TaxAmountFCY");

                entity.Property(e => e.TotalFcy).HasColumnName("TotalFCY");

                entity.Property(e => e.WriteOffAmountFcy).HasColumnName("WriteOffAmountFCY");
            });

            modelBuilder.Entity<ZohoOdInvoices24jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_od_invoices24jun");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.AmountWithoutTaxFcy).HasColumnName("AmountWithoutTaxFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditsAppliedFcy).HasColumnName("CreditsAppliedFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentAmountFcy).HasColumnName("PaymentAmountFCY");

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAmountFcy).HasColumnName("TaxAmountFCY");

                entity.Property(e => e.TotalFcy).HasColumnName("TotalFCY");

                entity.Property(e => e.WriteOffFcy).HasColumnName("WriteOffFCY");
            });

            modelBuilder.Entity<ZohoOverdueInvoices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_overdue_invoices");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.AmountWithoutTaxFcy).HasColumnName("AmountWithoutTaxFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditsAppliedFcy).HasColumnName("CreditsAppliedFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(255);

                entity.Property(e => e.InvoiceTotalFcy).HasColumnName("InvoiceTotalFCY");

                entity.Property(e => e.PaymentAmountFcy).HasColumnName("PaymentAmountFCY");

                entity.Property(e => e.QbCompany).HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("QuickbooksID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmountFcy).HasColumnName("TaxAmountFCY");

                entity.Property(e => e.WriteOffAmountFcy).HasColumnName("WriteOffAmountFCY");
            });

            modelBuilder.Entity<ZohoOverdueInvoices13jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_overdue_invoices_13jun");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("Amount Paid FCY");

                entity.Property(e => e.AmountWithoutTax).HasColumnName("Amount Without Tax");

                entity.Property(e => e.AmountWithoutTaxFcy).HasColumnName("Amount without Tax FCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditsApplied).HasColumnName("Credits Applied");

                entity.Property(e => e.CreditsAppliedFcy).HasColumnName("Credits Applied FCY");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentAmountFcy).HasColumnName("Payment Amount FCY");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("Qb Company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("Quickbooks ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TaxAmount).HasColumnName("Tax Amount");

                entity.Property(e => e.TaxAmountFcy).HasColumnName("Tax Amount FCY");

                entity.Property(e => e.TotalFcy).HasColumnName("Total FCY");

                entity.Property(e => e.WriteOffAmountFcy).HasColumnName("Write Off Amount FCY");
            });

            modelBuilder.Entity<ZohoOverdueInvoices18jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_overdue_invoices_18jun");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CreditsFcy).HasColumnName("CreditsFCY");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentFcy).HasColumnName("PaymentFCY");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("Qb Company")
                    .HasMaxLength(255);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("Quickbooks ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TotalFcy).HasColumnName("TotalFCY");
            });

            modelBuilder.Entity<ZohoOverdueInvoices20jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_overdue_invoices_20jun");

                entity.Property(e => e.AmountPaidFcy).HasColumnName("AmountPaidFCY");

                entity.Property(e => e.BalanceFcy).HasColumnName("BalanceFCY");

                entity.Property(e => e.CreditsFcy).HasColumnName("CreditsFCY");

                entity.Property(e => e.InvoiceDate).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.PaymentFcy).HasColumnName("PaymentFCY");

                entity.Property(e => e.TotalFcy).HasColumnName("TotalFCY");
            });

            modelBuilder.Entity<ZohoPaymentsreceived4nov>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_paymentsreceived_4nov");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.F100).HasMaxLength(255);

                entity.Property(e => e.F101).HasMaxLength(255);

                entity.Property(e => e.F102).HasMaxLength(255);

                entity.Property(e => e.F103).HasMaxLength(255);

                entity.Property(e => e.F104).HasMaxLength(255);

                entity.Property(e => e.F105).HasMaxLength(255);

                entity.Property(e => e.F106).HasMaxLength(255);

                entity.Property(e => e.F107).HasMaxLength(255);

                entity.Property(e => e.F108).HasMaxLength(255);

                entity.Property(e => e.F109).HasMaxLength(255);

                entity.Property(e => e.F110).HasMaxLength(255);

                entity.Property(e => e.F111).HasMaxLength(255);

                entity.Property(e => e.F112).HasMaxLength(255);

                entity.Property(e => e.F113).HasMaxLength(255);

                entity.Property(e => e.F114).HasMaxLength(255);

                entity.Property(e => e.F115).HasMaxLength(255);

                entity.Property(e => e.F116).HasMaxLength(255);

                entity.Property(e => e.F117).HasMaxLength(255);

                entity.Property(e => e.F118).HasMaxLength(255);

                entity.Property(e => e.F119).HasMaxLength(255);

                entity.Property(e => e.F120).HasMaxLength(255);

                entity.Property(e => e.F121).HasMaxLength(255);

                entity.Property(e => e.F122).HasMaxLength(255);

                entity.Property(e => e.F123).HasMaxLength(255);

                entity.Property(e => e.F124).HasMaxLength(255);

                entity.Property(e => e.F125).HasMaxLength(255);

                entity.Property(e => e.F126).HasMaxLength(255);

                entity.Property(e => e.F127).HasMaxLength(255);

                entity.Property(e => e.F128).HasMaxLength(255);

                entity.Property(e => e.F129).HasMaxLength(255);

                entity.Property(e => e.F130).HasMaxLength(255);

                entity.Property(e => e.F131).HasMaxLength(255);

                entity.Property(e => e.F132).HasMaxLength(255);

                entity.Property(e => e.F133).HasMaxLength(255);

                entity.Property(e => e.F134).HasMaxLength(255);

                entity.Property(e => e.F135).HasMaxLength(255);

                entity.Property(e => e.F136).HasMaxLength(255);

                entity.Property(e => e.F137).HasMaxLength(255);

                entity.Property(e => e.F138).HasMaxLength(255);

                entity.Property(e => e.F139).HasMaxLength(255);

                entity.Property(e => e.F140).HasMaxLength(255);

                entity.Property(e => e.F141).HasMaxLength(255);

                entity.Property(e => e.F142).HasMaxLength(255);

                entity.Property(e => e.F143).HasMaxLength(255);

                entity.Property(e => e.F144).HasMaxLength(255);

                entity.Property(e => e.F145).HasMaxLength(255);

                entity.Property(e => e.F146).HasMaxLength(255);

                entity.Property(e => e.F147).HasMaxLength(255);

                entity.Property(e => e.F148).HasMaxLength(255);

                entity.Property(e => e.F149).HasMaxLength(255);

                entity.Property(e => e.F150).HasMaxLength(255);

                entity.Property(e => e.F151).HasMaxLength(255);

                entity.Property(e => e.F152).HasMaxLength(255);

                entity.Property(e => e.F153).HasMaxLength(255);

                entity.Property(e => e.F154).HasMaxLength(255);

                entity.Property(e => e.F155).HasMaxLength(255);

                entity.Property(e => e.F156).HasMaxLength(255);

                entity.Property(e => e.F157).HasMaxLength(255);

                entity.Property(e => e.F158).HasMaxLength(255);

                entity.Property(e => e.F159).HasMaxLength(255);

                entity.Property(e => e.F160).HasMaxLength(255);

                entity.Property(e => e.F161).HasMaxLength(255);

                entity.Property(e => e.F162).HasMaxLength(255);

                entity.Property(e => e.F163).HasMaxLength(255);

                entity.Property(e => e.F164).HasMaxLength(255);

                entity.Property(e => e.F165).HasMaxLength(255);

                entity.Property(e => e.F166).HasMaxLength(255);

                entity.Property(e => e.F167).HasMaxLength(255);

                entity.Property(e => e.F168).HasMaxLength(255);

                entity.Property(e => e.F169).HasMaxLength(255);

                entity.Property(e => e.F170).HasMaxLength(255);

                entity.Property(e => e.F171).HasMaxLength(255);

                entity.Property(e => e.F172).HasMaxLength(255);

                entity.Property(e => e.F173).HasMaxLength(255);

                entity.Property(e => e.F174).HasMaxLength(255);

                entity.Property(e => e.F175).HasMaxLength(255);

                entity.Property(e => e.F176).HasMaxLength(255);

                entity.Property(e => e.F177).HasMaxLength(255);

                entity.Property(e => e.F178).HasMaxLength(255);

                entity.Property(e => e.F179).HasMaxLength(255);

                entity.Property(e => e.F180).HasMaxLength(255);

                entity.Property(e => e.F181).HasMaxLength(255);

                entity.Property(e => e.F182).HasMaxLength(255);

                entity.Property(e => e.F183).HasMaxLength(255);

                entity.Property(e => e.F184).HasMaxLength(255);

                entity.Property(e => e.F185).HasMaxLength(255);

                entity.Property(e => e.F186).HasMaxLength(255);

                entity.Property(e => e.F187).HasMaxLength(255);

                entity.Property(e => e.F188).HasMaxLength(255);

                entity.Property(e => e.F189).HasMaxLength(255);

                entity.Property(e => e.F190).HasMaxLength(255);

                entity.Property(e => e.F191).HasMaxLength(255);

                entity.Property(e => e.F192).HasMaxLength(255);

                entity.Property(e => e.F193).HasMaxLength(255);

                entity.Property(e => e.F194).HasMaxLength(255);

                entity.Property(e => e.F195).HasMaxLength(255);

                entity.Property(e => e.F196).HasMaxLength(255);

                entity.Property(e => e.F197).HasMaxLength(255);

                entity.Property(e => e.F198).HasMaxLength(255);

                entity.Property(e => e.F199).HasMaxLength(255);

                entity.Property(e => e.F200).HasMaxLength(255);

                entity.Property(e => e.F201).HasMaxLength(255);

                entity.Property(e => e.F202).HasMaxLength(255);

                entity.Property(e => e.F203).HasMaxLength(255);

                entity.Property(e => e.F204).HasMaxLength(255);

                entity.Property(e => e.F205).HasMaxLength(255);

                entity.Property(e => e.F206).HasMaxLength(255);

                entity.Property(e => e.F207).HasMaxLength(255);

                entity.Property(e => e.F208).HasMaxLength(255);

                entity.Property(e => e.F209).HasMaxLength(255);

                entity.Property(e => e.F210).HasMaxLength(255);

                entity.Property(e => e.F211).HasMaxLength(255);

                entity.Property(e => e.F212).HasMaxLength(255);

                entity.Property(e => e.F213).HasMaxLength(255);

                entity.Property(e => e.F214).HasMaxLength(255);

                entity.Property(e => e.F215).HasMaxLength(255);

                entity.Property(e => e.F216).HasMaxLength(255);

                entity.Property(e => e.F217).HasMaxLength(255);

                entity.Property(e => e.F218).HasMaxLength(255);

                entity.Property(e => e.F219).HasMaxLength(255);

                entity.Property(e => e.F220).HasMaxLength(255);

                entity.Property(e => e.F221).HasMaxLength(255);

                entity.Property(e => e.F222).HasMaxLength(255);

                entity.Property(e => e.F223).HasMaxLength(255);

                entity.Property(e => e.F224).HasMaxLength(255);

                entity.Property(e => e.F225).HasMaxLength(255);

                entity.Property(e => e.F226).HasMaxLength(255);

                entity.Property(e => e.F227).HasMaxLength(255);

                entity.Property(e => e.F228).HasMaxLength(255);

                entity.Property(e => e.F229).HasMaxLength(255);

                entity.Property(e => e.F230).HasMaxLength(255);

                entity.Property(e => e.F231).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.F52).HasMaxLength(255);

                entity.Property(e => e.F53).HasMaxLength(255);

                entity.Property(e => e.F54).HasMaxLength(255);

                entity.Property(e => e.F55).HasMaxLength(255);

                entity.Property(e => e.F56).HasMaxLength(255);

                entity.Property(e => e.F57).HasMaxLength(255);

                entity.Property(e => e.F58).HasMaxLength(255);

                entity.Property(e => e.F59).HasMaxLength(255);

                entity.Property(e => e.F60).HasMaxLength(255);

                entity.Property(e => e.F61).HasMaxLength(255);

                entity.Property(e => e.F62).HasMaxLength(255);

                entity.Property(e => e.F63).HasMaxLength(255);

                entity.Property(e => e.F64).HasMaxLength(255);

                entity.Property(e => e.F65).HasMaxLength(255);

                entity.Property(e => e.F66).HasMaxLength(255);

                entity.Property(e => e.F67).HasMaxLength(255);

                entity.Property(e => e.F68).HasMaxLength(255);

                entity.Property(e => e.F69).HasMaxLength(255);

                entity.Property(e => e.F70).HasMaxLength(255);

                entity.Property(e => e.F71).HasMaxLength(255);

                entity.Property(e => e.F72).HasMaxLength(255);

                entity.Property(e => e.F73).HasMaxLength(255);

                entity.Property(e => e.F74).HasMaxLength(255);

                entity.Property(e => e.F75).HasMaxLength(255);

                entity.Property(e => e.F76).HasMaxLength(255);

                entity.Property(e => e.F77).HasMaxLength(255);

                entity.Property(e => e.F78).HasMaxLength(255);

                entity.Property(e => e.F79).HasMaxLength(255);

                entity.Property(e => e.F80).HasMaxLength(255);

                entity.Property(e => e.F81).HasMaxLength(255);

                entity.Property(e => e.F82).HasMaxLength(255);

                entity.Property(e => e.F83).HasMaxLength(255);

                entity.Property(e => e.F84).HasMaxLength(255);

                entity.Property(e => e.F85).HasMaxLength(255);

                entity.Property(e => e.F86).HasMaxLength(255);

                entity.Property(e => e.F87).HasMaxLength(255);

                entity.Property(e => e.F88).HasMaxLength(255);

                entity.Property(e => e.F89).HasMaxLength(255);

                entity.Property(e => e.F90).HasMaxLength(255);

                entity.Property(e => e.F91).HasMaxLength(255);

                entity.Property(e => e.F92).HasMaxLength(255);

                entity.Property(e => e.F93).HasMaxLength(255);

                entity.Property(e => e.F94).HasMaxLength(255);

                entity.Property(e => e.F95).HasMaxLength(255);

                entity.Property(e => e.F96).HasMaxLength(255);

                entity.Property(e => e.F97).HasMaxLength(255);

                entity.Property(e => e.F98).HasMaxLength(255);

                entity.Property(e => e.F99).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(500);

                entity.Property(e => e.IsAdvancePayment)
                    .HasColumnName("is_advance_payment")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PrType)
                    .HasColumnName("pr_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("product_description")
                    .HasMaxLength(500);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCustid)
                    .HasColumnName("qb_custid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbJvid)
                    .HasColumnName("qb_jvid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.TaxAccountId)
                    .HasColumnName("tax_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccountName)
                    .HasColumnName("tax_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmountWithheld).HasColumnName("tax_amount_withheld");

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.ZohoAmount).HasColumnName("zoho_amount");

                entity.Property(e => e.ZohoDate)
                    .HasColumnName("zoho_date")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoDescription)
                    .HasColumnName("zoho_description")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ZohoPm4nov>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_pm_4nov");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BillNumbers)
                    .HasColumnName("bill_numbers")
                    .HasMaxLength(1000);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("check_status")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.IsPaidViaPrintCheck)
                    .HasColumnName("is_paid_via_print_check")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountId)
                    .HasColumnName("paid_through_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountName)
                    .HasColumnName("paid_through_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCustid)
                    .HasColumnName("qb_custid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbJvid)
                    .HasColumnName("qb_jvid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAmount).HasColumnName("zoho_amount");

                entity.Property(e => e.ZohoDate)
                    .HasColumnName("zoho_date")
                    .HasMaxLength(50);

                entity.Property(e => e.ZohoDescription)
                    .HasColumnName("zoho_description")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoPr4nov>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_pr_4nov");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.BcyRefundedAmount).HasColumnName("bcy_refunded_amount");

                entity.Property(e => e.BcyUnusedAmount).HasColumnName("bcy_unused_amount");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoice_number")
                    .HasMaxLength(500);

                entity.Property(e => e.IsAdvancePayment)
                    .HasColumnName("is_advance_payment")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("payment_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PrType)
                    .HasColumnName("pr_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("product_description")
                    .HasMaxLength(500);

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCustid)
                    .HasColumnName("qb_custid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbJvid)
                    .HasColumnName("qb_jvid")
                    .HasMaxLength(255);

                entity.Property(e => e.QbUniqueid)
                    .HasColumnName("qb_uniqueid")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");

                entity.Property(e => e.TaxAccountId)
                    .HasColumnName("tax_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAccountName)
                    .HasColumnName("tax_account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxAmountWithheld).HasColumnName("tax_amount_withheld");

                entity.Property(e => e.UnusedAmount).HasColumnName("unused_amount");

                entity.Property(e => e.ZohoAmount).HasColumnName("zoho_amount");

                entity.Property(e => e.ZohoDate)
                    .HasColumnName("zoho_date")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoDescription)
                    .HasColumnName("zoho_description")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ZohoProjects>(entity =>
            {
                entity.HasKey(e => e.ProjectId1);

                entity.ToTable("zoho_projects");

                entity.Property(e => e.ProjectId1).HasColumnName("ProjectID");

                entity.Property(e => e.BillingType)
                    .HasColumnName("billing_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BudgetHours).HasColumnName("budget_hours");

                entity.Property(e => e.BudgetHoursInTime)
                    .HasColumnName("budget_hours_in_time")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyRate).HasColumnName("fcy_rate");

                entity.Property(e => e.IsLoggedhoursExceeded)
                    .HasColumnName("is_loggedhours_exceeded")
                    .HasMaxLength(255);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoProjectsImport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BillingType)
                    .HasColumnName("Billing Type")
                    .HasMaxLength(255);

                entity.Property(e => e.BudgetAmount)
                    .HasColumnName("Budget Amount")
                    .HasMaxLength(255);

                entity.Property(e => e.BudgetType)
                    .HasColumnName("Budget Type")
                    .HasMaxLength(255);

                entity.Property(e => e.CostBudget)
                    .HasColumnName("Cost Budget")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ProjectBranch).HasMaxLength(255);

                entity.Property(e => e.ProjectBudgetHours)
                    .HasColumnName("Project Budget Hours")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectCost)
                    .HasColumnName("Project Cost")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.ProjectStatus)
                    .HasColumnName("Project Status")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoTaxMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Compid).HasColumnName("compid");

                entity.Property(e => e.ItemTaxType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbCompany)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.QbTaxcodename).HasMaxLength(255);

                entity.Property(e => e.QbtaxCodeId)
                    .HasColumnName("QBTaxCodeID")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxId)
                    .HasColumnName("tax_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasColumnName("tax_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("tax_percentage")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxSpecificType)
                    .HasColumnName("tax_specific_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasColumnName("tax_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<ZohoTempInrFlc>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__zoho_Tem__2EAE64C982F6307D");

                entity.ToTable("zoho_TempINR_FLC");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ManualAccount).HasMaxLength(255);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OldStatus).HasMaxLength(255);

                entity.Property(e => e.QbAccount).HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ZohoAccount).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoTempJv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_TempJV");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.JournalDate)
                    .IsRequired()
                    .HasColumnName("Journal Date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasColumnName("Reference Number")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoTempJv13jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_TempJV_13jun");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.JournalDate)
                    .IsRequired()
                    .HasColumnName("Journal Date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasColumnName("Reference Number")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoTempJv20jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_TempJV_20jun");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.JournalDate)
                    .IsRequired()
                    .HasColumnName("Journal Date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasColumnName("Reference Number")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoTempJv24jun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_TempJV_24jun");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.JournalDate)
                    .HasColumnName("Journal Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberPrefix)
                    .IsRequired()
                    .HasColumnName("Journal Number Prefix")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JournalNumberSuffix).HasColumnName("Journal Number Suffix");

                entity.Property(e => e.JournalType)
                    .IsRequired()
                    .HasColumnName("Journal Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasColumnName("Reference Number")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoTempMumFlc2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_temp_mum_flc_2223");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoTokens>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApiDomain)
                    .HasColumnName("api_domain")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate)
                    .HasColumnName("expired_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.TokenType)
                    .HasColumnName("token_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZohoTxntest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_txntest");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoUndepositedFlm>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("zoho_undeposited_flm");

                entity.Property(e => e.LineId).ValueGeneratedNever();

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineStatus).HasMaxLength(255);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendorBalance7aug>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_vendor_balance_7aug");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.BilledAmount).HasColumnName("billed_amount");

                entity.Property(e => e.ClosingBalance).HasColumnName("closing_balance");

                entity.Property(e => e.FcyClosingBalance).HasColumnName("fcy_closing_balance");

                entity.Property(e => e.QbCompany)
                    .HasColumnName("qb_company")
                    .HasMaxLength(255);

                entity.Property(e => e.QbId)
                    .HasColumnName("qb_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendorList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zoho_VendorList");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendorPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_vendor_payments");

                entity.Property(e => e.BankReferenceNumber)
                    .HasColumnName("Bank Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.BillAmount).HasColumnName("Bill Amount");

                entity.Property(e => e.BillNumber)
                    .HasColumnName("Bill Number")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DebitACNo)
                    .HasColumnName("Debit A/c no")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionOfSupply)
                    .HasColumnName("Description of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.DestinationOfSupply)
                    .HasColumnName("Destination of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange Rate");

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Mode).HasMaxLength(255);

                entity.Property(e => e.NewBank)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewBankId)
                    .HasColumnName("NewBankID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaidThrough)
                    .HasColumnName("Paid Through")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidThroughAccountCode)
                    .HasColumnName("Paid Through Account Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumber)
                    .HasColumnName("Payment Number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberPrefix)
                    .HasColumnName("Payment Number Prefix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentNumberSuffix)
                    .HasColumnName("Payment Number Suffix")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment Type")
                    .HasMaxLength(255);

                entity.Property(e => e.PipaymentId)
                    .HasColumnName("PIPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference Number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReverseChargeTaxAmount)
                    .HasColumnName("Reverse Charge Tax Amount")
                    .HasMaxLength(255);

                entity.Property(e => e.ReverseChargeTaxName)
                    .HasColumnName("ReverseCharge Tax Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReverseChargeTaxPercentage)
                    .HasColumnName("ReverseCharge Tax Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.ReverseChargeTaxType)
                    .HasColumnName("ReverseCharge Tax Type")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAccount)
                    .HasColumnName("Tax Account")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsAccountName)
                    .HasColumnName("TDS Account Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsName)
                    .HasColumnName("TDS Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsPercentage)
                    .HasColumnName("TDS Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsSection)
                    .HasColumnName("TDS Section")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsSectionCode)
                    .HasColumnName("TDS Section Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Tdsamount).HasColumnName("TDSAmount");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UnusedAmount).HasColumnName("Unused Amount");

                entity.Property(e => e.VendorBankAccountNumber)
                    .HasColumnName("Vendor Bank Account Number")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorBankCode)
                    .HasColumnName("Vendor Bank Code")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorBankName)
                    .HasColumnName("Vendor Bank Name")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor Name")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorPaymentId)
                    .HasColumnName("VendorPayment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WithholdingTaxAmount).HasColumnName("Withholding Tax Amount");
            });

            modelBuilder.Entity<ZohoVendorRefund2223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_vendor_refund_2223");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityType)
                    .HasColumnName("entity_type")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyAmount).HasColumnName("fcy_amount");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundMode)
                    .HasColumnName("refund_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendorRefunds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_vendor_refunds");

                entity.Property(e => e.BcyAmount).HasColumnName("bcy_amount");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityType)
                    .HasColumnName("entity_type")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyAmount).HasColumnName("fcy_amount");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundId)
                    .HasColumnName("refund_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RefundMode)
                    .HasColumnName("refund_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendor_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zoho_Vendors");

                entity.Property(e => e.BeneficiaryName)
                    .HasColumnName("Beneficiary Name")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingAddress)
                    .HasColumnName("Billing Address")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingAttention)
                    .HasColumnName("Billing Attention")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCity)
                    .HasColumnName("Billing City")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCode)
                    .HasColumnName("Billing Code")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingCountry)
                    .HasColumnName("Billing Country")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingFax)
                    .HasColumnName("Billing Fax")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingPhone)
                    .HasColumnName("Billing Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingState)
                    .HasColumnName("Billing State")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingStreet2)
                    .HasColumnName("Billing Street2")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("Branch Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentCompany)
                    .HasColumnName("CF#Parent Company")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentGroup1)
                    .HasColumnName("CF#Parent Group 1")
                    .HasMaxLength(255);

                entity.Property(e => e.CfParentGroup2)
                    .HasColumnName("CF#Parent Group 2")
                    .HasMaxLength(255);

                entity.Property(e => e.CfQbChennai)
                    .HasColumnName("CF#QbChennai")
                    .HasMaxLength(255);

                entity.Property(e => e.CfQbMumbai)
                    .HasColumnName("CF#QbMumbai")
                    .HasMaxLength(255);

                entity.Property(e => e.CfSalesPerson)
                    .HasColumnName("CF#Sales Person")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactAddressId)
                    .HasColumnName("Contact Address ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("Created Time")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Designation).HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("Exchange Rate")
                    .HasMaxLength(255);

                entity.Property(e => e.Facebook).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(255);

                entity.Property(e => e.GstIdentificationNumberGstin)
                    .HasColumnName("GST Identification Number (GSTIN)")
                    .HasMaxLength(255);

                entity.Property(e => e.GstTreatment)
                    .HasColumnName("GST Treatment")
                    .HasMaxLength(255);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("Last Modified Time")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSyncTime)
                    .HasColumnName("Last Sync Time")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.MobilePhone).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OpeningBalance)
                    .HasColumnName("Opening Balance")
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerName)
                    .HasColumnName("Owner Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("Payment Terms")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTermsLabel)
                    .HasColumnName("Payment Terms Label")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PriceList)
                    .HasColumnName("Price List")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryContactId)
                    .HasColumnName("Primary Contact ID")
                    .HasMaxLength(255);

                entity.Property(e => e.QbCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuickbooksId)
                    .HasColumnName("Quickbooks ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation).HasMaxLength(255);

                entity.Property(e => e.ShippingAddress)
                    .HasColumnName("Shipping Address")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingAttention)
                    .HasColumnName("Shipping Attention")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("Shipping City")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCode)
                    .HasColumnName("Shipping Code")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("Shipping Country")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingFax)
                    .HasColumnName("Shipping Fax")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingPhone)
                    .HasColumnName("Shipping Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingState)
                    .HasColumnName("Shipping State")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingStreet2)
                    .HasColumnName("Shipping Street2")
                    .HasMaxLength(255);

                entity.Property(e => e.SkypeIdentity)
                    .HasColumnName("Skype Identity")
                    .HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.SourceOfSupply)
                    .HasColumnName("Source of Supply")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TdsName)
                    .HasColumnName("TDS Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsPercentage)
                    .HasColumnName("TDS Percentage")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsSection)
                    .HasColumnName("TDS Section")
                    .HasMaxLength(255);

                entity.Property(e => e.TdsSectionCode)
                    .HasColumnName("TDS Section Code")
                    .HasMaxLength(255);

                entity.Property(e => e.Twitter).HasMaxLength(255);

                entity.Property(e => e.VendorBankAccountNumber)
                    .HasColumnName("Vendor Bank Account Number")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorBankCode)
                    .HasColumnName("Vendor Bank Code")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorBankName)
                    .HasColumnName("Vendor Bank Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<ZohoVendorstatement>(entity =>
            {
                entity.ToTable("zoho_vendorstatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Payments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transactions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zohotxn20240913Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxn_20240913_backup");

                entity.HasIndex(e => new { e.NetAmount, e.AccountName, e.Date })
                    .HasName("idx_zohotxns_004");

                entity.HasIndex(e => new { e.NetAmount, e.AccountName, e.Date, e.TransactionType })
                    .HasName("idx_zohotxns_05");

                entity.HasIndex(e => new { e.AccountName, e.NetAmount, e.AccountType, e.AccountCode, e.Date, e.TransactionType })
                    .HasName("idx_ztxns_2323");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns");

                entity.HasIndex(e => new { e.NetAmount, e.AccountName, e.Date })
                    .HasName("idx_zohotxns_004");

                entity.HasIndex(e => new { e.NetAmount, e.AccountName, e.Date, e.TransactionType })
                    .HasName("idx_zohotxns_05");

                entity.HasIndex(e => new { e.AccountName, e.NetAmount, e.AccountType, e.AccountCode, e.Date, e.TransactionType })
                    .HasName("idx_ztxns_2323");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns20240919>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_20240919");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns20240920>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_20240920");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns20240921>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_20240921");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns20240927>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_20240927");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zohotxns22jul>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__zohotxns__2EAE64C930610A59");

                entity.ToTable("zohotxns_22jul");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit)
                    .HasColumnName("fcy_credit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.LineId2).HasColumnName("LineID2");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohotxnsHdfc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_hdfc");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohotxnsHdfcusd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zohotxns_hdfcusd");

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RunningBalance).HasColumnName("running_balance");

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZohotxnsOld>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK__zohotxns__2EAE64C962578667");

                entity.ToTable("zohotxns_old");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityNumber)
                    .HasColumnName("entity_number")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");

                entity.Property(e => e.FcyDebit)
                    .HasColumnName("fcy_debit")
                    .HasMaxLength(255);

                entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.OffsetAccountId)
                    .HasColumnName("offset_account_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OffsetAccountType)
                    .HasColumnName("offset_account_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectIds)
                    .HasColumnName("project_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("reference_transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionDetails)
                    .HasColumnName("transaction_details")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
