using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[TypeLibType(4160)]
[Guid("8BC2F067-F8C6-4857-91C4-05A1A3D79954")]
public interface IMsgSetRequest
{
	[DispId(1)]
	IAttributesRqSet Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	void ClearRequests();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string ToXMLString();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	bool Verify([MarshalAs(UnmanagedType.BStr)] out string errorMsg);

	[DispId(5)]
	IRequestList RequestList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomSummaryReportQuery AppendCustomSummaryReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillMod AppendBillModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillAdd AppendBillAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IReceivePaymentMod AppendReceivePaymentModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IReceivePaymentAdd AppendReceivePaymentAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryAssemblyMod AppendItemInventoryAssemblyModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryAssemblyAdd AppendItemInventoryAssemblyAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IReceivePaymentQuery AppendReceivePaymentQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IToDoQuery AppendToDoQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtMod AppendDataExtModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtAdd AppendDataExtAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IAgingReportQuery AppendAgingReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVehicleMileageAdd AppendVehicleMileageAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IOtherNameQuery AppendOtherNameQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerMsgAdd AppendCustomerMsgAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerTypeAdd AppendCustomerTypeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPayrollDetailReportQuery AppendPayrollDetailReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	void AppendSalesTaxReturnQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICheckQuery AppendCheckQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillingRateAdd AppendBillingRateAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerMsgQuery AppendCustomerMsgQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesReceiptQuery AppendSalesReceiptQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorQuery AppendVendorQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomDetailReportQuery AppendCustomDetailReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillPaymentCreditCardQuery AppendBillPaymentCreditCardQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(32)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICurrencyQuery AppendCurrencyQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemOtherChargeMod AppendItemOtherChargeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemOtherChargeAdd AppendItemOtherChargeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemServiceQuery AppendItemServiceQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IWorkersCompCodeQuery AppendWorkersCompCodeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesOrderMod AppendSalesOrderModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(38)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesOrderAdd AppendSalesOrderAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(39)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemAssembliesCanBuildQuery AppendItemAssembliesCanBuildQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(40)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorTypeQuery AppendVendorTypeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(41)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBuildAssemblyQuery AppendBuildAssemblyQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(42)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillPaymentCheckQuery AppendBillPaymentCheckQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(43)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IReceivePaymentToDepositQuery AppendReceivePaymentToDepositQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(44)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPayrollItemNonWageQuery AppendPayrollItemNonWageQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(45)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITimeTrackingMod AppendTimeTrackingModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(46)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITimeTrackingAdd AppendTimeTrackingAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(47)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IStandardTermsQuery AppendStandardTermsQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(48)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemDiscountQuery AppendItemDiscountQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(49)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorTypeAdd AppendVendorTypeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(50)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditMemoQuery AppendCreditMemoQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(51)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillPaymentCreditCardAdd AppendBillPaymentCreditCardAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(52)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorCreditQuery AppendVendorCreditQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(53)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemReceiptQuery AppendItemReceiptQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(54)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSubtotalQuery AppendItemSubtotalQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(55)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventoryAdjustmentMod AppendInventoryAdjustmentModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(56)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventoryAdjustmentAdd AppendInventoryAdjustmentAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(57)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBudgetSummaryReportQuery AppendBudgetSummaryReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(58)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEntityQuery AppendEntityQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(59)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPurchaseOrderQuery AppendPurchaseOrderQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(60)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorCreditMod AppendVendorCreditModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(61)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorCreditAdd AppendVendorCreditAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(62)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPreferencesQuery AppendPreferencesQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(63)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryAssemblyQuery AppendItemInventoryAssemblyQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(64)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IGeneralSummaryReportQuery AppendGeneralSummaryReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(65)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInvoiceMod AppendInvoiceModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(66)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInvoiceAdd AppendInvoiceAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(67)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillQuery AppendBillQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(68)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxCodeMod AppendSalesTaxCodeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(69)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxCodeAdd AppendSalesTaxCodeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(70)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemServiceMod AppendItemServiceModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(71)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemServiceAdd AppendItemServiceAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(72)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesOrderQuery AppendSalesOrderQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(73)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesRepQuery AppendSalesRepQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(74)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IListDeletedQuery AppendListDeletedQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(75)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IUnitOfMeasureSetQuery AppendUnitOfMeasureSetQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(76)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IToDoMod AppendToDoModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(77)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IAccountQuery AppendAccountQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(78)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJournalEntryMod AppendJournalEntryModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(79)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJournalEntryAdd AppendJournalEntryAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(80)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPayrollSummaryReportQuery AppendPayrollSummaryReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(81)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IARRefundCreditCardQuery AppendARRefundCreditCardQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(82)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IForm1099CategoryAccountMappingQuery AppendForm1099CategoryAccountMappingQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(83)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVehicleMod AppendVehicleModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(84)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVehicleAdd AppendVehicleAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(85)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInvoiceQuery AppendInvoiceQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(86)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventorySiteMod AppendInventorySiteModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(87)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventorySiteAdd AppendInventorySiteAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(88)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IOtherNameMod AppendOtherNameModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(89)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IOtherNameAdd AppendOtherNameAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(90)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITxnDisplayMod AppendTxnDisplayModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(91)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITxnDisplayAdd AppendTxnDisplayAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(92)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IGeneralDetailReportQuery AppendGeneralDetailReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(93)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBarCodeQuery AppendBarCodeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(94)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IToDoAdd AppendToDoAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(95)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtDel AppendDataExtDelRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(96)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesRepMod AppendSalesRepModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(97)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesRepAdd AppendSalesRepAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(98)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemPaymentQuery AppendItemPaymentQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(99)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPaymentMethodAdd AppendPaymentMethodAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(100)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICompanyQuery AppendCompanyQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICurrencyMod AppendCurrencyModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(102)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICurrencyAdd AppendCurrencyAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(103)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtDefMod AppendDataExtDefModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(104)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtDefAdd AppendDataExtDefAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(105)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemReceiptMod AppendItemReceiptModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(106)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemReceiptAdd AppendItemReceiptAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(107)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IListDel AppendListDelRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(108)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEmployeeMod AppendEmployeeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(109)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEmployeeAdd AppendEmployeeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(110)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IChargeQuery AppendChargeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(111)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITemplateQuery AppendTemplateQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(112)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPriceLevelQuery AppendPriceLevelQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(113)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesReceiptMod AppendSalesReceiptModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(114)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITxnDeletedQuery AppendTxnDeletedQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(115)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJobTypeAdd AppendJobTypeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(116)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxGroupMod AppendItemSalesTaxGroupModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(117)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxGroupAdd AppendItemSalesTaxGroupAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(118)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDateDrivenTermsQuery AppendDateDrivenTermsQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(119)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxReturnLineQuery AppendSalesTaxReturnLineQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(120)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardCreditMod AppendCreditCardCreditModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(121)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardCreditAdd AppendCreditCardCreditAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(122)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemGroupMod AppendItemGroupModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(123)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemGroupAdd AppendItemGroupAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(124)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxQuery AppendItemSalesTaxQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(125)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerQuery AppendCustomerQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(126)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataEventRecoveryInfoQuery AppendDataEventRecoveryInfoQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(127)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVehicleQuery AppendVehicleQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(128)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSubtotalMod AppendItemSubtotalModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(129)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSubtotalAdd AppendItemSubtotalAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(130)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDepositQuery AppendDepositQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(131)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesReceiptAdd AppendSalesReceiptAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(132)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IAccountMod AppendAccountModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(133)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IAccountAdd AppendAccountAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(134)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardChargeMod AppendCreditCardChargeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(135)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardChargeAdd AppendCreditCardChargeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(136)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemFixedAssetQuery AppendItemFixedAssetQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(137)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransactionQuery AppendTransactionQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(138)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPayrollItemWageQuery AppendPayrollItemWageQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(139)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxGroupQuery AppendItemSalesTaxGroupQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(140)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IClassMod AppendClassModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(141)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IClassAdd AppendClassAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(142)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IChargeMod AppendChargeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(143)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IChargeAdd AppendChargeAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(144)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IListDisplayMod AppendListDisplayModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(145)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IListDisplayAdd AppendListDisplayAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(146)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEstimateMod AppendEstimateModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(147)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEstimateAdd AppendEstimateAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(148)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemFixedAssetMod AppendItemFixedAssetModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(149)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemFixedAssetAdd AppendItemFixedAssetAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(150)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITermsQuery AppendTermsQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(151)]
	void AppendPayrollLastPeriodQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(152)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillPaymentCheckMod AppendBillPaymentCheckModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(153)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillPaymentCheckAdd AppendBillPaymentCheckAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(154)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IClassQuery AppendClassQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(155)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPayrollItemWageAdd AppendPayrollItemWageAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(156)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISpecialItemAdd AppendSpecialItemAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(157)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVehicleMileageQuery AppendVehicleMileageQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(158)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventoryAdjustmentQuery AppendInventoryAdjustmentQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(159)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxCodeQuery AppendSalesTaxCodeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(160)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDepositMod AppendDepositModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(161)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDepositAdd AppendDepositAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(162)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJournalEntryQuery AppendJournalEntryQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(163)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPaymentMethodQuery AppendPaymentMethodQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(164)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITxnDel AppendTxnDelRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(165)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferQuery AppendTransferQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(166)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxMod AppendItemSalesTaxModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(167)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSalesTaxAdd AppendItemSalesTaxAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(168)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemOtherChargeQuery AppendItemOtherChargeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(169)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBuildAssemblyMod AppendBuildAssemblyModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(170)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBuildAssemblyAdd AppendBuildAssemblyAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(171)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemGroupQuery AppendItemGroupQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(172)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITimeTrackingQuery AppendTimeTrackingQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(173)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtDefDel AppendDataExtDefDelRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(174)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillToPayQuery AppendBillToPayQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(175)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferInventoryMod AppendTransferInventoryModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(176)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferInventoryAdd AppendTransferInventoryAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(177)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataEventRecoveryInfoDel AppendDataEventRecoveryInfoDelRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(178)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IStandardTermsAdd AppendStandardTermsAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(179)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITxnVoid AppendTxnVoidRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(180)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditMemoMod AppendCreditMemoModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(181)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditMemoAdd AppendCreditMemoAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(182)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxPaymentCheckMod AppendSalesTaxPaymentCheckModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(183)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxPaymentCheckAdd AppendSalesTaxPaymentCheckAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(184)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IListMerge AppendListMergeRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(185)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerMod AppendCustomerModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(186)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerAdd AppendCustomerAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(187)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICheckMod AppendCheckModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(188)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICheckAdd AppendCheckAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(189)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxPaymentCheckQuery AppendSalesTaxPaymentCheckQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(190)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICustomerTypeQuery AppendCustomerTypeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(191)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IShipMethodQuery AppendShipMethodQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(192)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardChargeQuery AppendCreditCardChargeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(193)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITimeReportQuery AppendTimeReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(194)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemNonInventoryMod AppendItemNonInventoryModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(195)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemNonInventoryAdd AppendItemNonInventoryAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(196)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDateDrivenTermsAdd AppendDateDrivenTermsAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(197)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IInventorySiteQuery AppendInventorySiteQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(198)]
	void AppendAccountTaxLineInfoQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(199)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IUnitOfMeasureSetAdd AppendUnitOfMeasureSetAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(200)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICreditCardCreditQuery AppendCreditCardCreditQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEstimateQuery AppendEstimateQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(202)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IARRefundCreditCardAdd AppendARRefundCreditCardAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(203)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IShipMethodAdd AppendShipMethodAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(204)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemQuery AppendItemQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(205)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEmployeeQuery AppendEmployeeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(206)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISpecialAccountAdd AppendSpecialAccountAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(207)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IClearedStatusMod AppendClearedStatusModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(208)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemPaymentMod AppendItemPaymentModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(209)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemPaymentAdd AppendItemPaymentAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(210)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryQuery AppendItemInventoryQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(211)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJobTypeQuery AppendJobTypeQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(212)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IJobReportQuery AppendJobReportQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(213)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHostQuery AppendHostQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(214)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemNonInventoryQuery AppendItemNonInventoryQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(215)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPurchaseOrderMod AppendPurchaseOrderModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(216)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPurchaseOrderAdd AppendPurchaseOrderAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(217)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IBillingRateQuery AppendBillingRateQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(218)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IForm1099CategoryAccountMappingMod AppendForm1099CategoryAccountMappingModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(219)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemSitesQuery AppendItemSitesQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(220)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISalesTaxPayableQuery AppendSalesTaxPayableQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(221)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferMod AppendTransferModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(222)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferAdd AppendTransferAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(223)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICompanyActivityQuery AppendCompanyActivityQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(224)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITransferInventoryQuery AppendTransferInventoryQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(225)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemDiscountMod AppendItemDiscountModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(226)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemDiscountAdd AppendItemDiscountAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(227)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryMod AppendItemInventoryModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(228)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IItemInventoryAdd AppendItemInventoryAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(229)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorMod AppendVendorModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(230)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IVendorAdd AppendVendorAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(231)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPriceLevelMod AppendPriceLevelModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(232)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IPriceLevelAdd AppendPriceLevelAddRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(233)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IDataExtDefQuery AppendDataExtDefQueryRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(234)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IWorkersCompCodeMod AppendWorkersCompCodeModRq();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(235)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IWorkersCompCodeAdd AppendWorkersCompCodeAddRq();
}
