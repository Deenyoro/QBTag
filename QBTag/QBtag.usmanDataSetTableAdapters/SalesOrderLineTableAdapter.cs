using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QBtag.My;

namespace QBtag.usmanDataSetTableAdapters;

[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
public class SalesOrderLineTableAdapter : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("_adapter")]
	private OleDbDataAdapter __adapter;

	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private OleDbDataAdapter _adapter
	{
		[DebuggerNonUserCode]
		get
		{
			return __adapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__adapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.DeleteCommand != null) ? true : false)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.InsertCommand != null) ? true : false)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.UpdateCommand != null) ? true : false)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public SalesOrderLineTableAdapter()
	{
		__ENCAddToList(this);
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		_adapter = new OleDbDataAdapter();
		DataTableMapping tableMapping = new DataTableMapping();
		tableMapping.SourceTable = "Table";
		tableMapping.DataSetTable = "SalesOrderLine";
		tableMapping.ColumnMappings.Add("TxnID", "TxnID");
		tableMapping.ColumnMappings.Add("TimeCreated", "TimeCreated");
		tableMapping.ColumnMappings.Add("TimeModified", "TimeModified");
		tableMapping.ColumnMappings.Add("EditSequence", "EditSequence");
		tableMapping.ColumnMappings.Add("TxnNumber", "TxnNumber");
		tableMapping.ColumnMappings.Add("CustomerRefListID", "CustomerRefListID");
		tableMapping.ColumnMappings.Add("CustomerRefFullName", "CustomerRefFullName");
		tableMapping.ColumnMappings.Add("ClassRefListID", "ClassRefListID");
		tableMapping.ColumnMappings.Add("ClassRefFullName", "ClassRefFullName");
		tableMapping.ColumnMappings.Add("TemplateRefListID", "TemplateRefListID");
		tableMapping.ColumnMappings.Add("TemplateRefFullName", "TemplateRefFullName");
		tableMapping.ColumnMappings.Add("TxnDate", "TxnDate");
		tableMapping.ColumnMappings.Add("TxnDateMacro", "TxnDateMacro");
		tableMapping.ColumnMappings.Add("RefNumber", "RefNumber");
		tableMapping.ColumnMappings.Add("BillAddressAddr1", "BillAddressAddr1");
		tableMapping.ColumnMappings.Add("BillAddressAddr2", "BillAddressAddr2");
		tableMapping.ColumnMappings.Add("BillAddressAddr3", "BillAddressAddr3");
		tableMapping.ColumnMappings.Add("BillAddressAddr4", "BillAddressAddr4");
		tableMapping.ColumnMappings.Add("BillAddressAddr5", "BillAddressAddr5");
		tableMapping.ColumnMappings.Add("BillAddressCity", "BillAddressCity");
		tableMapping.ColumnMappings.Add("BillAddressState", "BillAddressState");
		tableMapping.ColumnMappings.Add("BillAddressProvince", "BillAddressProvince");
		tableMapping.ColumnMappings.Add("BillAddressCounty", "BillAddressCounty");
		tableMapping.ColumnMappings.Add("BillAddressPostalCode", "BillAddressPostalCode");
		tableMapping.ColumnMappings.Add("BillAddressCountry", "BillAddressCountry");
		tableMapping.ColumnMappings.Add("BillAddressNote", "BillAddressNote");
		tableMapping.ColumnMappings.Add("BillAddressBlockAddr1", "BillAddressBlockAddr1");
		tableMapping.ColumnMappings.Add("BillAddressBlockAddr2", "BillAddressBlockAddr2");
		tableMapping.ColumnMappings.Add("BillAddressBlockAddr3", "BillAddressBlockAddr3");
		tableMapping.ColumnMappings.Add("BillAddressBlockAddr4", "BillAddressBlockAddr4");
		tableMapping.ColumnMappings.Add("BillAddressBlockAddr5", "BillAddressBlockAddr5");
		tableMapping.ColumnMappings.Add("ShipAddressAddr1", "ShipAddressAddr1");
		tableMapping.ColumnMappings.Add("ShipAddressAddr2", "ShipAddressAddr2");
		tableMapping.ColumnMappings.Add("ShipAddressAddr3", "ShipAddressAddr3");
		tableMapping.ColumnMappings.Add("ShipAddressAddr4", "ShipAddressAddr4");
		tableMapping.ColumnMappings.Add("ShipAddressAddr5", "ShipAddressAddr5");
		tableMapping.ColumnMappings.Add("ShipAddressCity", "ShipAddressCity");
		tableMapping.ColumnMappings.Add("ShipAddressState", "ShipAddressState");
		tableMapping.ColumnMappings.Add("ShipAddressProvince", "ShipAddressProvince");
		tableMapping.ColumnMappings.Add("ShipAddressCounty", "ShipAddressCounty");
		tableMapping.ColumnMappings.Add("ShipAddressPostalCode", "ShipAddressPostalCode");
		tableMapping.ColumnMappings.Add("ShipAddressCountry", "ShipAddressCountry");
		tableMapping.ColumnMappings.Add("ShipAddressNote", "ShipAddressNote");
		tableMapping.ColumnMappings.Add("ShipAddressBlockAddr1", "ShipAddressBlockAddr1");
		tableMapping.ColumnMappings.Add("ShipAddressBlockAddr2", "ShipAddressBlockAddr2");
		tableMapping.ColumnMappings.Add("ShipAddressBlockAddr3", "ShipAddressBlockAddr3");
		tableMapping.ColumnMappings.Add("ShipAddressBlockAddr4", "ShipAddressBlockAddr4");
		tableMapping.ColumnMappings.Add("ShipAddressBlockAddr5", "ShipAddressBlockAddr5");
		tableMapping.ColumnMappings.Add("PONumber", "PONumber");
		tableMapping.ColumnMappings.Add("TermsRefListID", "TermsRefListID");
		tableMapping.ColumnMappings.Add("TermsRefFullName", "TermsRefFullName");
		tableMapping.ColumnMappings.Add("DueDate", "DueDate");
		tableMapping.ColumnMappings.Add("SalesRepRefListID", "SalesRepRefListID");
		tableMapping.ColumnMappings.Add("SalesRepRefFullName", "SalesRepRefFullName");
		tableMapping.ColumnMappings.Add("FOB", "FOB");
		tableMapping.ColumnMappings.Add("ShipDate", "ShipDate");
		tableMapping.ColumnMappings.Add("ShipMethodRefListID", "ShipMethodRefListID");
		tableMapping.ColumnMappings.Add("ShipMethodRefFullName", "ShipMethodRefFullName");
		tableMapping.ColumnMappings.Add("Subtotal", "Subtotal");
		tableMapping.ColumnMappings.Add("ItemSalesTaxRefListID", "ItemSalesTaxRefListID");
		tableMapping.ColumnMappings.Add("ItemSalesTaxRefFullName", "ItemSalesTaxRefFullName");
		tableMapping.ColumnMappings.Add("SalesTaxPercentage", "SalesTaxPercentage");
		tableMapping.ColumnMappings.Add("SalesTaxTotal", "SalesTaxTotal");
		tableMapping.ColumnMappings.Add("TotalAmount", "TotalAmount");
		tableMapping.ColumnMappings.Add("IsManuallyClosed", "IsManuallyClosed");
		tableMapping.ColumnMappings.Add("IsFullyInvoiced", "IsFullyInvoiced");
		tableMapping.ColumnMappings.Add("Memo", "Memo");
		tableMapping.ColumnMappings.Add("CustomerMsgRefListID", "CustomerMsgRefListID");
		tableMapping.ColumnMappings.Add("CustomerMsgRefFullName", "CustomerMsgRefFullName");
		tableMapping.ColumnMappings.Add("IsToBePrinted", "IsToBePrinted");
		tableMapping.ColumnMappings.Add("IsToBeEmailed", "IsToBeEmailed");
		tableMapping.ColumnMappings.Add("IsTaxIncluded", "IsTaxIncluded");
		tableMapping.ColumnMappings.Add("CustomerSalesTaxCodeRefListID", "CustomerSalesTaxCodeRefListID");
		tableMapping.ColumnMappings.Add("CustomerSalesTaxCodeRefFullName", "CustomerSalesTaxCodeRefFullName");
		tableMapping.ColumnMappings.Add("CustomerTaxCodeRefListID", "CustomerTaxCodeRefListID");
		tableMapping.ColumnMappings.Add("CustomFieldOther", "CustomFieldOther");
		tableMapping.ColumnMappings.Add("SalesOrderLineSeqNo", "SalesOrderLineSeqNo");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupTxnLineID", "SalesOrderLineGroupTxnLineID");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupItemGroupRefListID", "SalesOrderLineGroupItemGroupRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupItemGroupRefFullName", "SalesOrderLineGroupItemGroupRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupDesc", "SalesOrderLineGroupDesc");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupQuantity", "SalesOrderLineGroupQuantity");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupUnitOfMeasure", "SalesOrderLineGroupUnitOfMeasure");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupOverrideUOMSetRefListID", "SalesOrderLineGroupOverrideUOMSetRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupOverrideUOMSetRefFullName", "SalesOrderLineGroupOverrideUOMSetRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupIsPrintItemsInGroup", "SalesOrderLineGroupIsPrintItemsInGroup");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupTotalAmount", "SalesOrderLineGroupTotalAmount");
		tableMapping.ColumnMappings.Add("SalesOrderLineGroupSeqNo", "SalesOrderLineGroupSeqNo");
		tableMapping.ColumnMappings.Add("SalesOrderLineTxnLineID", "SalesOrderLineTxnLineID");
		tableMapping.ColumnMappings.Add("SalesOrderLineItemRefListID", "SalesOrderLineItemRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineItemRefFullName", "SalesOrderLineItemRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineDesc", "SalesOrderLineDesc");
		tableMapping.ColumnMappings.Add("SalesOrderLineQuantity", "SalesOrderLineQuantity");
		tableMapping.ColumnMappings.Add("SalesOrderLineUnitOfMeasure", "SalesOrderLineUnitOfMeasure");
		tableMapping.ColumnMappings.Add("SalesOrderLineOverrideUOMSetRefListID", "SalesOrderLineOverrideUOMSetRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineOverrideUOMSetRefFullName", "SalesOrderLineOverrideUOMSetRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineRate", "SalesOrderLineRate");
		tableMapping.ColumnMappings.Add("SalesOrderLineRatePercent", "SalesOrderLineRatePercent");
		tableMapping.ColumnMappings.Add("SalesOrderLinePriceLevelRefListID", "SalesOrderLinePriceLevelRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLinePriceLevelRefFullName", "SalesOrderLinePriceLevelRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineClassRefListID", "SalesOrderLineClassRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineClassRefFullName", "SalesOrderLineClassRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineAmount", "SalesOrderLineAmount");
		tableMapping.ColumnMappings.Add("SalesOrderInventorySiteRefListID", "SalesOrderInventorySiteRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderInventorySiteRefFullName", "SalesOrderInventorySiteRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineSerialNumber", "SalesOrderLineSerialNumber");
		tableMapping.ColumnMappings.Add("SalesOrderLineLotNumber", "SalesOrderLineLotNumber");
		tableMapping.ColumnMappings.Add("SalesOrderLineTaxAmount", "SalesOrderLineTaxAmount");
		tableMapping.ColumnMappings.Add("SalesOrderLineSalesTaxCodeRefListID", "SalesOrderLineSalesTaxCodeRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineSalesTaxCodeRefFullName", "SalesOrderLineSalesTaxCodeRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineTaxCodeRefListID", "SalesOrderLineTaxCodeRefListID");
		tableMapping.ColumnMappings.Add("SalesOrderLineTaxCodeRefFullName", "SalesOrderLineTaxCodeRefFullName");
		tableMapping.ColumnMappings.Add("SalesOrderLineInvoiced", "SalesOrderLineInvoiced");
		tableMapping.ColumnMappings.Add("SalesOrderLineIsManuallyClosed", "SalesOrderLineIsManuallyClosed");
		tableMapping.ColumnMappings.Add("CustomFieldSalesOrderLineOther1", "CustomFieldSalesOrderLineOther1");
		tableMapping.ColumnMappings.Add("CustomFieldSalesOrderLineOther2", "CustomFieldSalesOrderLineOther2");
		tableMapping.ColumnMappings.Add("Tax1Total", "Tax1Total");
		tableMapping.ColumnMappings.Add("Tax2Total", "Tax2Total");
		tableMapping.ColumnMappings.Add("ExchangeRate", "ExchangeRate");
		tableMapping.ColumnMappings.Add("AmountIncludesVAT", "AmountIncludesVAT");
		tableMapping.ColumnMappings.Add("FQSaveToCache", "FQSaveToCache");
		tableMapping.ColumnMappings.Add("FQPrimaryKey", "FQPrimaryKey");
		tableMapping.ColumnMappings.Add("FQTxnLinkKey", "FQTxnLinkKey");
		tableMapping.ColumnMappings.Add("CustomFieldSalesOrderLineCycleCount", "CustomFieldSalesOrderLineCycleCount");
		tableMapping.ColumnMappings.Add("CustomFieldSalesOrderLineGroupCycleCount", "CustomFieldSalesOrderLineGroupCycleCount");
		tableMapping.ColumnMappings.Add("CustomFieldSalesOrderLineGroupLineCycleCount", "CustomFieldSalesOrderLineGroupLineCycleCount");
		tableMapping.ColumnMappings.Add("CustomFieldCollect", "CustomFieldCollect");
		tableMapping.ColumnMappings.Add("CustomFieldPPDCOL", "CustomFieldPPDCOL");
		tableMapping.ColumnMappings.Add("CustomFieldRep", "CustomFieldRep");
		tableMapping.ColumnMappings.Add("CustomFieldShipDate", "CustomFieldShipDate");
		tableMapping.ColumnMappings.Add("CustomFieldShipVia", "CustomFieldShipVia");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `SalesOrderLine` WHERE (((? = 1 AND `TxnID` IS NULL) OR (`TxnID` = ?)) AND ((? = 1 AND `TimeCreated` IS NULL) OR (`TimeCreated` = ?)) AND ((? = 1 AND `TimeModified` IS NULL) OR (`TimeModified` = ?)) AND ((? = 1 AND `EditSequence` IS NULL) OR (`EditSequence` = ?)) AND ((? = 1 AND `TxnNumber` IS NULL) OR (`TxnNumber` = ?)) AND ((? = 1 AND `CustomerRefListID` IS NULL) OR (`CustomerRefListID` = ?)) AND ((? = 1 AND `CustomerRefFullName` IS NULL) OR (`CustomerRefFullName` = ?)) AND ((? = 1 AND `ClassRefListID` IS NULL) OR (`ClassRefListID` = ?)) AND ((? = 1 AND `ClassRefFullName` IS NULL) OR (`ClassRefFullName` = ?)) AND ((? = 1 AND `TemplateRefListID` IS NULL) OR (`TemplateRefListID` = ?)) AND ((? = 1 AND `TemplateRefFullName` IS NULL) OR (`TemplateRefFullName` = ?)) AND ((? = 1 AND `TxnDate` IS NULL) OR (`TxnDate` = ?)) AND ((? = 1 AND `TxnDateMacro` IS NULL) OR (`TxnDateMacro` = ?)) AND ((? = 1 AND `RefNumber` IS NULL) OR (`RefNumber` = ?)) AND ((? = 1 AND `BillAddressAddr1` IS NULL) OR (`BillAddressAddr1` = ?)) AND ((? = 1 AND `BillAddressAddr2` IS NULL) OR (`BillAddressAddr2` = ?)) AND ((? = 1 AND `BillAddressAddr3` IS NULL) OR (`BillAddressAddr3` = ?)) AND ((? = 1 AND `BillAddressAddr4` IS NULL) OR (`BillAddressAddr4` = ?)) AND ((? = 1 AND `BillAddressAddr5` IS NULL) OR (`BillAddressAddr5` = ?)) AND ((? = 1 AND `BillAddressCity` IS NULL) OR (`BillAddressCity` = ?)) AND ((? = 1 AND `BillAddressState` IS NULL) OR (`BillAddressState` = ?)) AND ((? = 1 AND `BillAddressProvince` IS NULL) OR (`BillAddressProvince` = ?)) AND ((? = 1 AND `BillAddressCounty` IS NULL) OR (`BillAddressCounty` = ?)) AND ((? = 1 AND `BillAddressPostalCode` IS NULL) OR (`BillAddressPostalCode` = ?)) AND ((? = 1 AND `BillAddressCountry` IS NULL) OR (`BillAddressCountry` = ?)) AND ((? = 1 AND `BillAddressNote` IS NULL) OR (`BillAddressNote` = ?)) AND ((? = 1 AND `BillAddressBlockAddr1` IS NULL) OR (`BillAddressBlockAddr1` = ?)) AND ((? = 1 AND `BillAddressBlockAddr2` IS NULL) OR (`BillAddressBlockAddr2` = ?)) AND ((? = 1 AND `BillAddressBlockAddr3` IS NULL) OR (`BillAddressBlockAddr3` = ?)) AND ((? = 1 AND `BillAddressBlockAddr4` IS NULL) OR (`BillAddressBlockAddr4` = ?)) AND ((? = 1 AND `BillAddressBlockAddr5` IS NULL) OR (`BillAddressBlockAddr5` = ?)) AND ((? = 1 AND `ShipAddressAddr1` IS NULL) OR (`ShipAddressAddr1` = ?)) AND ((? = 1 AND `ShipAddressAddr2` IS NULL) OR (`ShipAddressAddr2` = ?)) AND ((? = 1 AND `ShipAddressAddr3` IS NULL) OR (`ShipAddressAddr3` = ?)) AND ((? = 1 AND `ShipAddressAddr4` IS NULL) OR (`ShipAddressAddr4` = ?)) AND ((? = 1 AND `ShipAddressAddr5` IS NULL) OR (`ShipAddressAddr5` = ?)) AND ((? = 1 AND `ShipAddressCity` IS NULL) OR (`ShipAddressCity` = ?)) AND ((? = 1 AND `ShipAddressState` IS NULL) OR (`ShipAddressState` = ?)) AND ((? = 1 AND `ShipAddressProvince` IS NULL) OR (`ShipAddressProvince` = ?)) AND ((? = 1 AND `ShipAddressCounty` IS NULL) OR (`ShipAddressCounty` = ?)) AND ((? = 1 AND `ShipAddressPostalCode` IS NULL) OR (`ShipAddressPostalCode` = ?)) AND ((? = 1 AND `ShipAddressCountry` IS NULL) OR (`ShipAddressCountry` = ?)) AND ((? = 1 AND `ShipAddressNote` IS NULL) OR (`ShipAddressNote` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr1` IS NULL) OR (`ShipAddressBlockAddr1` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr2` IS NULL) OR (`ShipAddressBlockAddr2` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr3` IS NULL) OR (`ShipAddressBlockAddr3` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr4` IS NULL) OR (`ShipAddressBlockAddr4` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr5` IS NULL) OR (`ShipAddressBlockAddr5` = ?)) AND ((? = 1 AND `PONumber` IS NULL) OR (`PONumber` = ?)) AND ((? = 1 AND `TermsRefListID` IS NULL) OR (`TermsRefListID` = ?)) AND ((? = 1 AND `TermsRefFullName` IS NULL) OR (`TermsRefFullName` = ?)) AND ((? = 1 AND `DueDate` IS NULL) OR (`DueDate` = ?)) AND ((? = 1 AND `SalesRepRefListID` IS NULL) OR (`SalesRepRefListID` = ?)) AND ((? = 1 AND `SalesRepRefFullName` IS NULL) OR (`SalesRepRefFullName` = ?)) AND ((? = 1 AND `FOB` IS NULL) OR (`FOB` = ?)) AND ((? = 1 AND `ShipDate` IS NULL) OR (`ShipDate` = ?)) AND ((? = 1 AND `ShipMethodRefListID` IS NULL) OR (`ShipMethodRefListID` = ?)) AND ((? = 1 AND `ShipMethodRefFullName` IS NULL) OR (`ShipMethodRefFullName` = ?)) AND ((? = 1 AND `Subtotal` IS NULL) OR (`Subtotal` = ?)) AND ((? = 1 AND `ItemSalesTaxRefListID` IS NULL) OR (`ItemSalesTaxRefListID` = ?)) AND ((? = 1 AND `ItemSalesTaxRefFullName` IS NULL) OR (`ItemSalesTaxRefFullName` = ?)) AND ((? = 1 AND `SalesTaxPercentage` IS NULL) OR (`SalesTaxPercentage` = ?)) AND ((? = 1 AND `SalesTaxTotal` IS NULL) OR (`SalesTaxTotal` = ?)) AND ((? = 1 AND `TotalAmount` IS NULL) OR (`TotalAmount` = ?)) AND ((? = 1 AND `IsManuallyClosed` IS NULL) OR (`IsManuallyClosed` = ?)) AND ((? = 1 AND `IsFullyInvoiced` IS NULL) OR (`IsFullyInvoiced` = ?)) AND ((? = 1 AND `CustomerMsgRefListID` IS NULL) OR (`CustomerMsgRefListID` = ?)) AND ((? = 1 AND `CustomerMsgRefFullName` IS NULL) OR (`CustomerMsgRefFullName` = ?)) AND ((? = 1 AND `IsToBePrinted` IS NULL) OR (`IsToBePrinted` = ?)) AND ((? = 1 AND `IsToBeEmailed` IS NULL) OR (`IsToBeEmailed` = ?)) AND ((? = 1 AND `IsTaxIncluded` IS NULL) OR (`IsTaxIncluded` = ?)) AND ((? = 1 AND `CustomerSalesTaxCodeRefListID` IS NULL) OR (`CustomerSalesTaxCodeRefListID` = ?)) AND ((? = 1 AND `CustomerSalesTaxCodeRefFullName` IS NULL) OR (`CustomerSalesTaxCodeRefFullName` = ?)) AND ((? = 1 AND `CustomerTaxCodeRefListID` IS NULL) OR (`CustomerTaxCodeRefListID` = ?)) AND ((? = 1 AND `CustomFieldOther` IS NULL) OR (`CustomFieldOther` = ?)) AND ((? = 1 AND `SalesOrderLineSeqNo` IS NULL) OR (`SalesOrderLineSeqNo` = ?)) AND ((? = 1 AND `SalesOrderLineGroupTxnLineID` IS NULL) OR (`SalesOrderLineGroupTxnLineID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupItemGroupRefListID` IS NULL) OR (`SalesOrderLineGroupItemGroupRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupItemGroupRefFullName` IS NULL) OR (`SalesOrderLineGroupItemGroupRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineGroupQuantity` IS NULL) OR (`SalesOrderLineGroupQuantity` = ?)) AND ((? = 1 AND `SalesOrderLineGroupUnitOfMeasure` IS NULL) OR (`SalesOrderLineGroupUnitOfMeasure` = ?)) AND ((? = 1 AND `SalesOrderLineGroupOverrideUOMSetRefListID` IS NULL) OR (`SalesOrderLineGroupOverrideUOMSetRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupOverrideUOMSetRefFullName` IS NULL) OR (`SalesOrderLineGroupOverrideUOMSetRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineGroupIsPrintItemsInGroup` IS NULL) OR (`SalesOrderLineGroupIsPrintItemsInGroup` = ?)) AND ((? = 1 AND `SalesOrderLineGroupTotalAmount` IS NULL) OR (`SalesOrderLineGroupTotalAmount` = ?)) AND ((? = 1 AND `SalesOrderLineGroupSeqNo` IS NULL) OR (`SalesOrderLineGroupSeqNo` = ?)) AND ((? = 1 AND `SalesOrderLineTxnLineID` IS NULL) OR (`SalesOrderLineTxnLineID` = ?)) AND ((? = 1 AND `SalesOrderLineItemRefListID` IS NULL) OR (`SalesOrderLineItemRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineItemRefFullName` IS NULL) OR (`SalesOrderLineItemRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineQuantity` IS NULL) OR (`SalesOrderLineQuantity` = ?)) AND ((? = 1 AND `SalesOrderLineUnitOfMeasure` IS NULL) OR (`SalesOrderLineUnitOfMeasure` = ?)) AND ((? = 1 AND `SalesOrderLineOverrideUOMSetRefListID` IS NULL) OR (`SalesOrderLineOverrideUOMSetRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineOverrideUOMSetRefFullName` IS NULL) OR (`SalesOrderLineOverrideUOMSetRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineRate` IS NULL) OR (`SalesOrderLineRate` = ?)) AND ((? = 1 AND `SalesOrderLineRatePercent` IS NULL) OR (`SalesOrderLineRatePercent` = ?)) AND ((? = 1 AND `SalesOrderLinePriceLevelRefListID` IS NULL) OR (`SalesOrderLinePriceLevelRefListID` = ?)) AND ((? = 1 AND `SalesOrderLinePriceLevelRefFullName` IS NULL) OR (`SalesOrderLinePriceLevelRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineClassRefListID` IS NULL) OR (`SalesOrderLineClassRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineClassRefFullName` IS NULL) OR (`SalesOrderLineClassRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineAmount` IS NULL) OR (`SalesOrderLineAmount` = ?)) AND ((? = 1 AND `SalesOrderInventorySiteRefListID` IS NULL) OR (`SalesOrderInventorySiteRefListID` = ?)) AND ((? = 1 AND `SalesOrderInventorySiteRefFullName` IS NULL) OR (`SalesOrderInventorySiteRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineLotNumber` IS NULL) OR (`SalesOrderLineLotNumber` = ?)) AND ((? = 1 AND `SalesOrderLineTaxAmount` IS NULL) OR (`SalesOrderLineTaxAmount` = ?)) AND ((? = 1 AND `SalesOrderLineSalesTaxCodeRefListID` IS NULL) OR (`SalesOrderLineSalesTaxCodeRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineSalesTaxCodeRefFullName` IS NULL) OR (`SalesOrderLineSalesTaxCodeRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineTaxCodeRefListID` IS NULL) OR (`SalesOrderLineTaxCodeRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineTaxCodeRefFullName` IS NULL) OR (`SalesOrderLineTaxCodeRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineInvoiced` IS NULL) OR (`SalesOrderLineInvoiced` = ?)) AND ((? = 1 AND `SalesOrderLineIsManuallyClosed` IS NULL) OR (`SalesOrderLineIsManuallyClosed` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineOther1` IS NULL) OR (`CustomFieldSalesOrderLineOther1` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineOther2` IS NULL) OR (`CustomFieldSalesOrderLineOther2` = ?)) AND ((? = 1 AND `Tax1Total` IS NULL) OR (`Tax1Total` = ?)) AND ((? = 1 AND `Tax2Total` IS NULL) OR (`Tax2Total` = ?)) AND ((? = 1 AND `ExchangeRate` IS NULL) OR (`ExchangeRate` = ?)) AND ((? = 1 AND `AmountIncludesVAT` IS NULL) OR (`AmountIncludesVAT` = ?)) AND ((? = 1 AND `FQSaveToCache` IS NULL) OR (`FQSaveToCache` = ?)) AND (`FQPrimaryKey` = ?) AND ((? = 1 AND `FQTxnLinkKey` IS NULL) OR (`FQTxnLinkKey` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineCycleCount` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineGroupCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineGroupCycleCount` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineGroupLineCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineGroupLineCycleCount` = ?)) AND ((? = 1 AND `CustomFieldCollect` IS NULL) OR (`CustomFieldCollect` = ?)) AND ((? = 1 AND `CustomFieldPPDCOL` IS NULL) OR (`CustomFieldPPDCOL` = ?)) AND ((? = 1 AND `CustomFieldRep` IS NULL) OR (`CustomFieldRep` = ?)) AND ((? = 1 AND `CustomFieldShipDate` IS NULL) OR (`CustomFieldShipDate` = ?)) AND ((? = 1 AND `CustomFieldShipVia` IS NULL) OR (`CustomFieldShipVia` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TxnID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TxnID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TimeCreated", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TimeCreated", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TimeModified", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TimeModified", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_EditSequence", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_EditSequence", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ClassRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ClassRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TemplateRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TemplateRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TemplateRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TemplateRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TxnDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TxnDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TxnDateMacro", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TxnDateMacro", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_RefNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_RefNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressState", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressProvince", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCounty", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressPostalCode", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCountry", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressNote", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressState", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressProvince", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCounty", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressPostalCode", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCountry", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressNote", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PONumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PONumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TermsRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TermsRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TermsRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TermsRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DueDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DueDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesRepRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesRepRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesRepRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesRepRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_FOB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_FOB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipMethodRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipMethodRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ShipMethodRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ShipMethodRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Subtotal", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Subtotal", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Subtotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Subtotal", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ItemSalesTaxRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ItemSalesTaxRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ItemSalesTaxRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ItemSalesTaxRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesTaxPercentage", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesTaxPercentage", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesTaxPercentage", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesTaxPercentage", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesTaxTotal", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesTaxTotal", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesTaxTotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesTaxTotal", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TotalAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TotalAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "TotalAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IsManuallyClosed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IsFullyInvoiced", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IsFullyInvoiced", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerMsgRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerMsgRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerMsgRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerMsgRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IsToBePrinted", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IsToBePrinted", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IsToBeEmailed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IsToBeEmailed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IsTaxIncluded", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IsTaxIncluded", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerSalesTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerSalesTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomerTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldOther", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldOther", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupTxnLineID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupItemGroupRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupItemGroupRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupItemGroupRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupItemGroupRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupQuantity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupQuantity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineGroupQuantity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupUnitOfMeasure", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupTotalAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTotalAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupTotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineGroupTotalAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTxnLineID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineItemRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineItemRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineItemRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineItemRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineQuantity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineQuantity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineQuantity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineUnitOfMeasure", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineOverrideUOMSetRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineOverrideUOMSetRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineRate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineRate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineRate", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineRate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineRatePercent", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineRatePercent", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineRatePercent", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 5, "SalesOrderLineRatePercent", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLinePriceLevelRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLinePriceLevelRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLinePriceLevelRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLinePriceLevelRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineClassRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineClassRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderInventorySiteRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderInventorySiteRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderInventorySiteRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderInventorySiteRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineLotNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineLotNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineTaxAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSalesTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSalesTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineInvoiced", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineInvoiced", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineInvoiced", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineInvoiced", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineIsManuallyClosed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineIsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineOther1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineOther1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineOther2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineOther2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Tax1Total", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Tax1Total", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Tax1Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax1Total", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Tax2Total", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Tax2Total", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Tax2Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax2Total", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ExchangeRate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ExchangeRate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ExchangeRate", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 6, "ExchangeRate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_AmountIncludesVAT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_AmountIncludesVAT", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_FQSaveToCache", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_FQSaveToCache", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_FQPrimaryKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQPrimaryKey", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_FQTxnLinkKey", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_FQTxnLinkKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineGroupCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineGroupCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldCollect", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldCollect", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldPPDCOL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldPPDCOL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldRep", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldRep", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldShipDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldShipDate", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldShipVia", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldShipVia", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `SalesOrderLine` (`TxnID`, `TimeCreated`, `TimeModified`, `EditSequence`, `TxnNumber`, `CustomerRefListID`, `CustomerRefFullName`, `ClassRefListID`, `ClassRefFullName`, `TemplateRefListID`, `TemplateRefFullName`, `TxnDate`, `TxnDateMacro`, `RefNumber`, `BillAddressAddr1`, `BillAddressAddr2`, `BillAddressAddr3`, `BillAddressAddr4`, `BillAddressAddr5`, `BillAddressCity`, `BillAddressState`, `BillAddressProvince`, `BillAddressCounty`, `BillAddressPostalCode`, `BillAddressCountry`, `BillAddressNote`, `BillAddressBlockAddr1`, `BillAddressBlockAddr2`, `BillAddressBlockAddr3`, `BillAddressBlockAddr4`, `BillAddressBlockAddr5`, `ShipAddressAddr1`, `ShipAddressAddr2`, `ShipAddressAddr3`, `ShipAddressAddr4`, `ShipAddressAddr5`, `ShipAddressCity`, `ShipAddressState`, `ShipAddressProvince`, `ShipAddressCounty`, `ShipAddressPostalCode`, `ShipAddressCountry`, `ShipAddressNote`, `ShipAddressBlockAddr1`, `ShipAddressBlockAddr2`, `ShipAddressBlockAddr3`, `ShipAddressBlockAddr4`, `ShipAddressBlockAddr5`, `PONumber`, `TermsRefListID`, `TermsRefFullName`, `DueDate`, `SalesRepRefListID`, `SalesRepRefFullName`, `FOB`, `ShipDate`, `ShipMethodRefListID`, `ShipMethodRefFullName`, `Subtotal`, `ItemSalesTaxRefListID`, `ItemSalesTaxRefFullName`, `SalesTaxPercentage`, `SalesTaxTotal`, `TotalAmount`, `IsManuallyClosed`, `IsFullyInvoiced`, `Memo`, `CustomerMsgRefListID`, `CustomerMsgRefFullName`, `IsToBePrinted`, `IsToBeEmailed`, `IsTaxIncluded`, `CustomerSalesTaxCodeRefListID`, `CustomerSalesTaxCodeRefFullName`, `CustomerTaxCodeRefListID`, `CustomFieldOther`, `SalesOrderLineSeqNo`, `SalesOrderLineGroupTxnLineID`, `SalesOrderLineGroupItemGroupRefListID`, `SalesOrderLineGroupItemGroupRefFullName`, `SalesOrderLineGroupDesc`, `SalesOrderLineGroupQuantity`, `SalesOrderLineGroupUnitOfMeasure`, `SalesOrderLineGroupOverrideUOMSetRefListID`, `SalesOrderLineGroupOverrideUOMSetRefFullName`, `SalesOrderLineGroupIsPrintItemsInGroup`, `SalesOrderLineGroupTotalAmount`, `SalesOrderLineGroupSeqNo`, `SalesOrderLineTxnLineID`, `SalesOrderLineItemRefListID`, `SalesOrderLineItemRefFullName`, `SalesOrderLineDesc`, `SalesOrderLineQuantity`, `SalesOrderLineUnitOfMeasure`, `SalesOrderLineOverrideUOMSetRefListID`, `SalesOrderLineOverrideUOMSetRefFullName`, `SalesOrderLineRate`, `SalesOrderLineRatePercent`, `SalesOrderLinePriceLevelRefListID`, `SalesOrderLinePriceLevelRefFullName`, `SalesOrderLineClassRefListID`, `SalesOrderLineClassRefFullName`, `SalesOrderLineAmount`, `SalesOrderInventorySiteRefListID`, `SalesOrderInventorySiteRefFullName`, `SalesOrderLineSerialNumber`, `SalesOrderLineLotNumber`, `SalesOrderLineTaxAmount`, `SalesOrderLineSalesTaxCodeRefListID`, `SalesOrderLineSalesTaxCodeRefFullName`, `SalesOrderLineTaxCodeRefListID`, `SalesOrderLineTaxCodeRefFullName`, `SalesOrderLineInvoiced`, `SalesOrderLineIsManuallyClosed`, `CustomFieldSalesOrderLineOther1`, `CustomFieldSalesOrderLineOther2`, `Tax1Total`, `Tax2Total`, `ExchangeRate`, `AmountIncludesVAT`, `FQSaveToCache`, `FQPrimaryKey`, `FQTxnLinkKey`, `CustomFieldSalesOrderLineCycleCount`, `CustomFieldSalesOrderLineGroupCycleCount`, `CustomFieldSalesOrderLineGroupLineCycleCount`, `CustomFieldCollect`, `CustomFieldPPDCOL`, `CustomFieldRep`, `CustomFieldShipDate`, `CustomFieldShipVia`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TxnID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TimeCreated", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TimeModified", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("EditSequence", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TemplateRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TemplateRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TxnDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TxnDateMacro", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("RefNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PONumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TermsRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TermsRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DueDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesRepRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesRepRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("FOB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipMethodRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ShipMethodRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Subtotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Subtotal", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ItemSalesTaxRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ItemSalesTaxRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesTaxPercentage", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesTaxPercentage", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesTaxTotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesTaxTotal", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "TotalAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IsFullyInvoiced", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Memo", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "Memo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerMsgRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerMsgRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IsToBePrinted", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IsToBeEmailed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IsTaxIncluded", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomerTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldOther", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupItemGroupRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupItemGroupRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupDesc", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupDesc", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineGroupQuantity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupTotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineGroupTotalAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineItemRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineItemRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineDesc", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineDesc", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineQuantity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineRate", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineRate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineRatePercent", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 5, "SalesOrderLineRatePercent", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLinePriceLevelRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLinePriceLevelRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderInventorySiteRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderInventorySiteRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSerialNumber", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSerialNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineLotNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineTaxAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineInvoiced", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineInvoiced", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SalesOrderLineIsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineOther1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineOther2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Tax1Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax1Total", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Tax2Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax2Total", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ExchangeRate", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 6, "ExchangeRate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("AmountIncludesVAT", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("FQSaveToCache", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("FQPrimaryKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQPrimaryKey", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("FQTxnLinkKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineGroupCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldCollect", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldPPDCOL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldRep", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldShipDate", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CustomFieldShipVia", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `SalesOrderLine` SET `TxnID` = ?, `TimeCreated` = ?, `TimeModified` = ?, `EditSequence` = ?, `TxnNumber` = ?, `CustomerRefListID` = ?, `CustomerRefFullName` = ?, `ClassRefListID` = ?, `ClassRefFullName` = ?, `TemplateRefListID` = ?, `TemplateRefFullName` = ?, `TxnDate` = ?, `TxnDateMacro` = ?, `RefNumber` = ?, `BillAddressAddr1` = ?, `BillAddressAddr2` = ?, `BillAddressAddr3` = ?, `BillAddressAddr4` = ?, `BillAddressAddr5` = ?, `BillAddressCity` = ?, `BillAddressState` = ?, `BillAddressProvince` = ?, `BillAddressCounty` = ?, `BillAddressPostalCode` = ?, `BillAddressCountry` = ?, `BillAddressNote` = ?, `BillAddressBlockAddr1` = ?, `BillAddressBlockAddr2` = ?, `BillAddressBlockAddr3` = ?, `BillAddressBlockAddr4` = ?, `BillAddressBlockAddr5` = ?, `ShipAddressAddr1` = ?, `ShipAddressAddr2` = ?, `ShipAddressAddr3` = ?, `ShipAddressAddr4` = ?, `ShipAddressAddr5` = ?, `ShipAddressCity` = ?, `ShipAddressState` = ?, `ShipAddressProvince` = ?, `ShipAddressCounty` = ?, `ShipAddressPostalCode` = ?, `ShipAddressCountry` = ?, `ShipAddressNote` = ?, `ShipAddressBlockAddr1` = ?, `ShipAddressBlockAddr2` = ?, `ShipAddressBlockAddr3` = ?, `ShipAddressBlockAddr4` = ?, `ShipAddressBlockAddr5` = ?, `PONumber` = ?, `TermsRefListID` = ?, `TermsRefFullName` = ?, `DueDate` = ?, `SalesRepRefListID` = ?, `SalesRepRefFullName` = ?, `FOB` = ?, `ShipDate` = ?, `ShipMethodRefListID` = ?, `ShipMethodRefFullName` = ?, `Subtotal` = ?, `ItemSalesTaxRefListID` = ?, `ItemSalesTaxRefFullName` = ?, `SalesTaxPercentage` = ?, `SalesTaxTotal` = ?, `TotalAmount` = ?, `IsManuallyClosed` = ?, `IsFullyInvoiced` = ?, `Memo` = ?, `CustomerMsgRefListID` = ?, `CustomerMsgRefFullName` = ?, `IsToBePrinted` = ?, `IsToBeEmailed` = ?, `IsTaxIncluded` = ?, `CustomerSalesTaxCodeRefListID` = ?, `CustomerSalesTaxCodeRefFullName` = ?, `CustomerTaxCodeRefListID` = ?, `CustomFieldOther` = ?, `SalesOrderLineSeqNo` = ?, `SalesOrderLineGroupTxnLineID` = ?, `SalesOrderLineGroupItemGroupRefListID` = ?, `SalesOrderLineGroupItemGroupRefFullName` = ?, `SalesOrderLineGroupDesc` = ?, `SalesOrderLineGroupQuantity` = ?, `SalesOrderLineGroupUnitOfMeasure` = ?, `SalesOrderLineGroupOverrideUOMSetRefListID` = ?, `SalesOrderLineGroupOverrideUOMSetRefFullName` = ?, `SalesOrderLineGroupIsPrintItemsInGroup` = ?, `SalesOrderLineGroupTotalAmount` = ?, `SalesOrderLineGroupSeqNo` = ?, `SalesOrderLineTxnLineID` = ?, `SalesOrderLineItemRefListID` = ?, `SalesOrderLineItemRefFullName` = ?, `SalesOrderLineDesc` = ?, `SalesOrderLineQuantity` = ?, `SalesOrderLineUnitOfMeasure` = ?, `SalesOrderLineOverrideUOMSetRefListID` = ?, `SalesOrderLineOverrideUOMSetRefFullName` = ?, `SalesOrderLineRate` = ?, `SalesOrderLineRatePercent` = ?, `SalesOrderLinePriceLevelRefListID` = ?, `SalesOrderLinePriceLevelRefFullName` = ?, `SalesOrderLineClassRefListID` = ?, `SalesOrderLineClassRefFullName` = ?, `SalesOrderLineAmount` = ?, `SalesOrderInventorySiteRefListID` = ?, `SalesOrderInventorySiteRefFullName` = ?, `SalesOrderLineSerialNumber` = ?, `SalesOrderLineLotNumber` = ?, `SalesOrderLineTaxAmount` = ?, `SalesOrderLineSalesTaxCodeRefListID` = ?, `SalesOrderLineSalesTaxCodeRefFullName` = ?, `SalesOrderLineTaxCodeRefListID` = ?, `SalesOrderLineTaxCodeRefFullName` = ?, `SalesOrderLineInvoiced` = ?, `SalesOrderLineIsManuallyClosed` = ?, `CustomFieldSalesOrderLineOther1` = ?, `CustomFieldSalesOrderLineOther2` = ?, `Tax1Total` = ?, `Tax2Total` = ?, `ExchangeRate` = ?, `AmountIncludesVAT` = ?, `FQSaveToCache` = ?, `FQPrimaryKey` = ?, `FQTxnLinkKey` = ?, `CustomFieldSalesOrderLineCycleCount` = ?, `CustomFieldSalesOrderLineGroupCycleCount` = ?, `CustomFieldSalesOrderLineGroupLineCycleCount` = ?, `CustomFieldCollect` = ?, `CustomFieldPPDCOL` = ?, `CustomFieldRep` = ?, `CustomFieldShipDate` = ?, `CustomFieldShipVia` = ? WHERE (((? = 1 AND `TxnID` IS NULL) OR (`TxnID` = ?)) AND ((? = 1 AND `TimeCreated` IS NULL) OR (`TimeCreated` = ?)) AND ((? = 1 AND `TimeModified` IS NULL) OR (`TimeModified` = ?)) AND ((? = 1 AND `EditSequence` IS NULL) OR (`EditSequence` = ?)) AND ((? = 1 AND `TxnNumber` IS NULL) OR (`TxnNumber` = ?)) AND ((? = 1 AND `CustomerRefListID` IS NULL) OR (`CustomerRefListID` = ?)) AND ((? = 1 AND `CustomerRefFullName` IS NULL) OR (`CustomerRefFullName` = ?)) AND ((? = 1 AND `ClassRefListID` IS NULL) OR (`ClassRefListID` = ?)) AND ((? = 1 AND `ClassRefFullName` IS NULL) OR (`ClassRefFullName` = ?)) AND ((? = 1 AND `TemplateRefListID` IS NULL) OR (`TemplateRefListID` = ?)) AND ((? = 1 AND `TemplateRefFullName` IS NULL) OR (`TemplateRefFullName` = ?)) AND ((? = 1 AND `TxnDate` IS NULL) OR (`TxnDate` = ?)) AND ((? = 1 AND `TxnDateMacro` IS NULL) OR (`TxnDateMacro` = ?)) AND ((? = 1 AND `RefNumber` IS NULL) OR (`RefNumber` = ?)) AND ((? = 1 AND `BillAddressAddr1` IS NULL) OR (`BillAddressAddr1` = ?)) AND ((? = 1 AND `BillAddressAddr2` IS NULL) OR (`BillAddressAddr2` = ?)) AND ((? = 1 AND `BillAddressAddr3` IS NULL) OR (`BillAddressAddr3` = ?)) AND ((? = 1 AND `BillAddressAddr4` IS NULL) OR (`BillAddressAddr4` = ?)) AND ((? = 1 AND `BillAddressAddr5` IS NULL) OR (`BillAddressAddr5` = ?)) AND ((? = 1 AND `BillAddressCity` IS NULL) OR (`BillAddressCity` = ?)) AND ((? = 1 AND `BillAddressState` IS NULL) OR (`BillAddressState` = ?)) AND ((? = 1 AND `BillAddressProvince` IS NULL) OR (`BillAddressProvince` = ?)) AND ((? = 1 AND `BillAddressCounty` IS NULL) OR (`BillAddressCounty` = ?)) AND ((? = 1 AND `BillAddressPostalCode` IS NULL) OR (`BillAddressPostalCode` = ?)) AND ((? = 1 AND `BillAddressCountry` IS NULL) OR (`BillAddressCountry` = ?)) AND ((? = 1 AND `BillAddressNote` IS NULL) OR (`BillAddressNote` = ?)) AND ((? = 1 AND `BillAddressBlockAddr1` IS NULL) OR (`BillAddressBlockAddr1` = ?)) AND ((? = 1 AND `BillAddressBlockAddr2` IS NULL) OR (`BillAddressBlockAddr2` = ?)) AND ((? = 1 AND `BillAddressBlockAddr3` IS NULL) OR (`BillAddressBlockAddr3` = ?)) AND ((? = 1 AND `BillAddressBlockAddr4` IS NULL) OR (`BillAddressBlockAddr4` = ?)) AND ((? = 1 AND `BillAddressBlockAddr5` IS NULL) OR (`BillAddressBlockAddr5` = ?)) AND ((? = 1 AND `ShipAddressAddr1` IS NULL) OR (`ShipAddressAddr1` = ?)) AND ((? = 1 AND `ShipAddressAddr2` IS NULL) OR (`ShipAddressAddr2` = ?)) AND ((? = 1 AND `ShipAddressAddr3` IS NULL) OR (`ShipAddressAddr3` = ?)) AND ((? = 1 AND `ShipAddressAddr4` IS NULL) OR (`ShipAddressAddr4` = ?)) AND ((? = 1 AND `ShipAddressAddr5` IS NULL) OR (`ShipAddressAddr5` = ?)) AND ((? = 1 AND `ShipAddressCity` IS NULL) OR (`ShipAddressCity` = ?)) AND ((? = 1 AND `ShipAddressState` IS NULL) OR (`ShipAddressState` = ?)) AND ((? = 1 AND `ShipAddressProvince` IS NULL) OR (`ShipAddressProvince` = ?)) AND ((? = 1 AND `ShipAddressCounty` IS NULL) OR (`ShipAddressCounty` = ?)) AND ((? = 1 AND `ShipAddressPostalCode` IS NULL) OR (`ShipAddressPostalCode` = ?)) AND ((? = 1 AND `ShipAddressCountry` IS NULL) OR (`ShipAddressCountry` = ?)) AND ((? = 1 AND `ShipAddressNote` IS NULL) OR (`ShipAddressNote` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr1` IS NULL) OR (`ShipAddressBlockAddr1` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr2` IS NULL) OR (`ShipAddressBlockAddr2` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr3` IS NULL) OR (`ShipAddressBlockAddr3` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr4` IS NULL) OR (`ShipAddressBlockAddr4` = ?)) AND ((? = 1 AND `ShipAddressBlockAddr5` IS NULL) OR (`ShipAddressBlockAddr5` = ?)) AND ((? = 1 AND `PONumber` IS NULL) OR (`PONumber` = ?)) AND ((? = 1 AND `TermsRefListID` IS NULL) OR (`TermsRefListID` = ?)) AND ((? = 1 AND `TermsRefFullName` IS NULL) OR (`TermsRefFullName` = ?)) AND ((? = 1 AND `DueDate` IS NULL) OR (`DueDate` = ?)) AND ((? = 1 AND `SalesRepRefListID` IS NULL) OR (`SalesRepRefListID` = ?)) AND ((? = 1 AND `SalesRepRefFullName` IS NULL) OR (`SalesRepRefFullName` = ?)) AND ((? = 1 AND `FOB` IS NULL) OR (`FOB` = ?)) AND ((? = 1 AND `ShipDate` IS NULL) OR (`ShipDate` = ?)) AND ((? = 1 AND `ShipMethodRefListID` IS NULL) OR (`ShipMethodRefListID` = ?)) AND ((? = 1 AND `ShipMethodRefFullName` IS NULL) OR (`ShipMethodRefFullName` = ?)) AND ((? = 1 AND `Subtotal` IS NULL) OR (`Subtotal` = ?)) AND ((? = 1 AND `ItemSalesTaxRefListID` IS NULL) OR (`ItemSalesTaxRefListID` = ?)) AND ((? = 1 AND `ItemSalesTaxRefFullName` IS NULL) OR (`ItemSalesTaxRefFullName` = ?)) AND ((? = 1 AND `SalesTaxPercentage` IS NULL) OR (`SalesTaxPercentage` = ?)) AND ((? = 1 AND `SalesTaxTotal` IS NULL) OR (`SalesTaxTotal` = ?)) AND ((? = 1 AND `TotalAmount` IS NULL) OR (`TotalAmount` = ?)) AND ((? = 1 AND `IsManuallyClosed` IS NULL) OR (`IsManuallyClosed` = ?)) AND ((? = 1 AND `IsFullyInvoiced` IS NULL) OR (`IsFullyInvoiced` = ?)) AND ((? = 1 AND `CustomerMsgRefListID` IS NULL) OR (`CustomerMsgRefListID` = ?)) AND ((? = 1 AND `CustomerMsgRefFullName` IS NULL) OR (`CustomerMsgRefFullName` = ?)) AND ((? = 1 AND `IsToBePrinted` IS NULL) OR (`IsToBePrinted` = ?)) AND ((? = 1 AND `IsToBeEmailed` IS NULL) OR (`IsToBeEmailed` = ?)) AND ((? = 1 AND `IsTaxIncluded` IS NULL) OR (`IsTaxIncluded` = ?)) AND ((? = 1 AND `CustomerSalesTaxCodeRefListID` IS NULL) OR (`CustomerSalesTaxCodeRefListID` = ?)) AND ((? = 1 AND `CustomerSalesTaxCodeRefFullName` IS NULL) OR (`CustomerSalesTaxCodeRefFullName` = ?)) AND ((? = 1 AND `CustomerTaxCodeRefListID` IS NULL) OR (`CustomerTaxCodeRefListID` = ?)) AND ((? = 1 AND `CustomFieldOther` IS NULL) OR (`CustomFieldOther` = ?)) AND ((? = 1 AND `SalesOrderLineSeqNo` IS NULL) OR (`SalesOrderLineSeqNo` = ?)) AND ((? = 1 AND `SalesOrderLineGroupTxnLineID` IS NULL) OR (`SalesOrderLineGroupTxnLineID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupItemGroupRefListID` IS NULL) OR (`SalesOrderLineGroupItemGroupRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupItemGroupRefFullName` IS NULL) OR (`SalesOrderLineGroupItemGroupRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineGroupQuantity` IS NULL) OR (`SalesOrderLineGroupQuantity` = ?)) AND ((? = 1 AND `SalesOrderLineGroupUnitOfMeasure` IS NULL) OR (`SalesOrderLineGroupUnitOfMeasure` = ?)) AND ((? = 1 AND `SalesOrderLineGroupOverrideUOMSetRefListID` IS NULL) OR (`SalesOrderLineGroupOverrideUOMSetRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineGroupOverrideUOMSetRefFullName` IS NULL) OR (`SalesOrderLineGroupOverrideUOMSetRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineGroupIsPrintItemsInGroup` IS NULL) OR (`SalesOrderLineGroupIsPrintItemsInGroup` = ?)) AND ((? = 1 AND `SalesOrderLineGroupTotalAmount` IS NULL) OR (`SalesOrderLineGroupTotalAmount` = ?)) AND ((? = 1 AND `SalesOrderLineGroupSeqNo` IS NULL) OR (`SalesOrderLineGroupSeqNo` = ?)) AND ((? = 1 AND `SalesOrderLineTxnLineID` IS NULL) OR (`SalesOrderLineTxnLineID` = ?)) AND ((? = 1 AND `SalesOrderLineItemRefListID` IS NULL) OR (`SalesOrderLineItemRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineItemRefFullName` IS NULL) OR (`SalesOrderLineItemRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineQuantity` IS NULL) OR (`SalesOrderLineQuantity` = ?)) AND ((? = 1 AND `SalesOrderLineUnitOfMeasure` IS NULL) OR (`SalesOrderLineUnitOfMeasure` = ?)) AND ((? = 1 AND `SalesOrderLineOverrideUOMSetRefListID` IS NULL) OR (`SalesOrderLineOverrideUOMSetRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineOverrideUOMSetRefFullName` IS NULL) OR (`SalesOrderLineOverrideUOMSetRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineRate` IS NULL) OR (`SalesOrderLineRate` = ?)) AND ((? = 1 AND `SalesOrderLineRatePercent` IS NULL) OR (`SalesOrderLineRatePercent` = ?)) AND ((? = 1 AND `SalesOrderLinePriceLevelRefListID` IS NULL) OR (`SalesOrderLinePriceLevelRefListID` = ?)) AND ((? = 1 AND `SalesOrderLinePriceLevelRefFullName` IS NULL) OR (`SalesOrderLinePriceLevelRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineClassRefListID` IS NULL) OR (`SalesOrderLineClassRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineClassRefFullName` IS NULL) OR (`SalesOrderLineClassRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineAmount` IS NULL) OR (`SalesOrderLineAmount` = ?)) AND ((? = 1 AND `SalesOrderInventorySiteRefListID` IS NULL) OR (`SalesOrderInventorySiteRefListID` = ?)) AND ((? = 1 AND `SalesOrderInventorySiteRefFullName` IS NULL) OR (`SalesOrderInventorySiteRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineLotNumber` IS NULL) OR (`SalesOrderLineLotNumber` = ?)) AND ((? = 1 AND `SalesOrderLineTaxAmount` IS NULL) OR (`SalesOrderLineTaxAmount` = ?)) AND ((? = 1 AND `SalesOrderLineSalesTaxCodeRefListID` IS NULL) OR (`SalesOrderLineSalesTaxCodeRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineSalesTaxCodeRefFullName` IS NULL) OR (`SalesOrderLineSalesTaxCodeRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineTaxCodeRefListID` IS NULL) OR (`SalesOrderLineTaxCodeRefListID` = ?)) AND ((? = 1 AND `SalesOrderLineTaxCodeRefFullName` IS NULL) OR (`SalesOrderLineTaxCodeRefFullName` = ?)) AND ((? = 1 AND `SalesOrderLineInvoiced` IS NULL) OR (`SalesOrderLineInvoiced` = ?)) AND ((? = 1 AND `SalesOrderLineIsManuallyClosed` IS NULL) OR (`SalesOrderLineIsManuallyClosed` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineOther1` IS NULL) OR (`CustomFieldSalesOrderLineOther1` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineOther2` IS NULL) OR (`CustomFieldSalesOrderLineOther2` = ?)) AND ((? = 1 AND `Tax1Total` IS NULL) OR (`Tax1Total` = ?)) AND ((? = 1 AND `Tax2Total` IS NULL) OR (`Tax2Total` = ?)) AND ((? = 1 AND `ExchangeRate` IS NULL) OR (`ExchangeRate` = ?)) AND ((? = 1 AND `AmountIncludesVAT` IS NULL) OR (`AmountIncludesVAT` = ?)) AND ((? = 1 AND `FQSaveToCache` IS NULL) OR (`FQSaveToCache` = ?)) AND (`FQPrimaryKey` = ?) AND ((? = 1 AND `FQTxnLinkKey` IS NULL) OR (`FQTxnLinkKey` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineCycleCount` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineGroupCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineGroupCycleCount` = ?)) AND ((? = 1 AND `CustomFieldSalesOrderLineGroupLineCycleCount` IS NULL) OR (`CustomFieldSalesOrderLineGroupLineCycleCount` = ?)) AND ((? = 1 AND `CustomFieldCollect` IS NULL) OR (`CustomFieldCollect` = ?)) AND ((? = 1 AND `CustomFieldPPDCOL` IS NULL) OR (`CustomFieldPPDCOL` = ?)) AND ((? = 1 AND `CustomFieldRep` IS NULL) OR (`CustomFieldRep` = ?)) AND ((? = 1 AND `CustomFieldShipDate` IS NULL) OR (`CustomFieldShipDate` = ?)) AND ((? = 1 AND `CustomFieldShipVia` IS NULL) OR (`CustomFieldShipVia` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TxnID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TimeCreated", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TimeModified", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("EditSequence", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TemplateRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TemplateRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TxnDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TxnDateMacro", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RefNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BillAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PONumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TermsRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TermsRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DueDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesRepRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesRepRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FOB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipMethodRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ShipMethodRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Subtotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Subtotal", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ItemSalesTaxRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ItemSalesTaxRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesTaxPercentage", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesTaxPercentage", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesTaxTotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesTaxTotal", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "TotalAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsFullyInvoiced", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Memo", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "Memo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerMsgRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerMsgRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsToBePrinted", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsToBeEmailed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsTaxIncluded", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomerTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldOther", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupItemGroupRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupItemGroupRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupDesc", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupDesc", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineGroupQuantity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupTotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineGroupTotalAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineItemRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineItemRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineDesc", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineDesc", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineQuantity", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineRate", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineRate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineRatePercent", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 5, "SalesOrderLineRatePercent", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLinePriceLevelRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLinePriceLevelRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderInventorySiteRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderInventorySiteRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSerialNumber", OleDbType.LongVarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSerialNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineLotNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineTaxAmount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineInvoiced", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineInvoiced", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SalesOrderLineIsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineOther1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineOther2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Tax1Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax1Total", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Tax2Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax2Total", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ExchangeRate", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 6, "ExchangeRate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("AmountIncludesVAT", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FQSaveToCache", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FQPrimaryKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQPrimaryKey", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FQTxnLinkKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineGroupCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldCollect", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldPPDCOL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldRep", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldShipDate", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CustomFieldShipVia", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TxnID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TxnID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TimeCreated", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TimeCreated", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeCreated", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TimeModified", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TimeModified", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TimeModified", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_EditSequence", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_EditSequence", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EditSequence", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TxnNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ClassRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ClassRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TemplateRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TemplateRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TemplateRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TemplateRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TemplateRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TxnDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TxnDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "TxnDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TxnDateMacro", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TxnDateMacro", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TxnDateMacro", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_RefNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_RefNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RefNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressState", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressState", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressProvince", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCounty", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressPostalCode", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressCountry", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressNote", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressNote", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_BillAddressBlockAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_BillAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "BillAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCity", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressState", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressState", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressState", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressProvince", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressProvince", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressProvince", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCounty", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCounty", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCounty", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressPostalCode", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressPostalCode", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressPostalCode", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressCountry", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressCountry", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressCountry", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressNote", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressNote", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressNote", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr3", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr3", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr3", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr4", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr4", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr4", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipAddressBlockAddr5", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipAddressBlockAddr5", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipAddressBlockAddr5", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PONumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PONumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PONumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TermsRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TermsRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TermsRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TermsRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TermsRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DueDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DueDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DueDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesRepRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesRepRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesRepRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesRepRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesRepRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_FOB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_FOB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FOB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipDate", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "ShipDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipMethodRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipMethodRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ShipMethodRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ShipMethodRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ShipMethodRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Subtotal", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Subtotal", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Subtotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Subtotal", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ItemSalesTaxRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ItemSalesTaxRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ItemSalesTaxRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ItemSalesTaxRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ItemSalesTaxRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesTaxPercentage", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesTaxPercentage", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesTaxPercentage", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesTaxPercentage", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesTaxTotal", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesTaxTotal", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesTaxTotal", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesTaxTotal", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TotalAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TotalAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "TotalAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IsManuallyClosed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IsFullyInvoiced", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IsFullyInvoiced", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsFullyInvoiced", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerMsgRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerMsgRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerMsgRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerMsgRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerMsgRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IsToBePrinted", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IsToBePrinted", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBePrinted", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IsToBeEmailed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IsToBeEmailed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsToBeEmailed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IsTaxIncluded", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IsTaxIncluded", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "IsTaxIncluded", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerSalesTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerSalesTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomerTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomerTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomerTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldOther", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldOther", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldOther", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSeqNo", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupTxnLineID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupItemGroupRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupItemGroupRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupItemGroupRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupItemGroupRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupItemGroupRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupQuantity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupQuantity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineGroupQuantity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupUnitOfMeasure", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupIsPrintItemsInGroup", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupIsPrintItemsInGroup", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupTotalAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupTotalAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupTotalAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineGroupTotalAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineGroupSeqNo", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineGroupSeqNo", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTxnLineID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTxnLineID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTxnLineID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineItemRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineItemRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineItemRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineItemRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineItemRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineQuantity", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineQuantity", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineQuantity", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineQuantity", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineUnitOfMeasure", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineUnitOfMeasure", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineUnitOfMeasure", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineOverrideUOMSetRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineOverrideUOMSetRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineOverrideUOMSetRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineOverrideUOMSetRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineOverrideUOMSetRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineRate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineRate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineRate", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineRate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineRatePercent", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineRatePercent", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineRatePercent", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 5, "SalesOrderLineRatePercent", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLinePriceLevelRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLinePriceLevelRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLinePriceLevelRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLinePriceLevelRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLinePriceLevelRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineClassRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineClassRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineClassRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineClassRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineClassRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderInventorySiteRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderInventorySiteRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderInventorySiteRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderInventorySiteRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderInventorySiteRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineLotNumber", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineLotNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineLotNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxAmount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxAmount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxAmount", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "SalesOrderLineTaxAmount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSalesTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSalesTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineSalesTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineSalesTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineSalesTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxCodeRefListID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxCodeRefListID", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefListID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineTaxCodeRefFullName", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineTaxCodeRefFullName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineTaxCodeRefFullName", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineInvoiced", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineInvoiced", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineInvoiced", OleDbType.Numeric, 0, ParameterDirection.Input, 16, 5, "SalesOrderLineInvoiced", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SalesOrderLineIsManuallyClosed", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SalesOrderLineIsManuallyClosed", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "SalesOrderLineIsManuallyClosed", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineOther1", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineOther1", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther1", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineOther2", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineOther2", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineOther2", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Tax1Total", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Tax1Total", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Tax1Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax1Total", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Tax2Total", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Tax2Total", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Tax2Total", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 2, "Tax2Total", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ExchangeRate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ExchangeRate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ExchangeRate", OleDbType.Numeric, 0, ParameterDirection.Input, 13, 6, "ExchangeRate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_AmountIncludesVAT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_AmountIncludesVAT", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "AmountIncludesVAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_FQSaveToCache", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_FQSaveToCache", OleDbType.Boolean, 0, ParameterDirection.Input, 0, 0, "FQSaveToCache", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_FQPrimaryKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQPrimaryKey", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_FQTxnLinkKey", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_FQTxnLinkKey", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FQTxnLinkKey", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineGroupCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineGroupCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldSalesOrderLineGroupLineCycleCount", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldSalesOrderLineGroupLineCycleCount", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldCollect", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldCollect", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldCollect", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldPPDCOL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldPPDCOL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldPPDCOL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldRep", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldRep", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldRep", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldShipDate", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldShipDate", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipDate", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CustomFieldShipVia", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CustomFieldShipVia", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CustomFieldShipVia", DataRowVersion.Original, sourceColumnNullMapping: false, null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitConnection()
	{
		_connection = new OleDbConnection();
		_connection.ConnectionString = MySettings.Default.TomConnectionstring1;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		_commandCollection = new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT TxnID, TimeCreated, TimeModified, EditSequence, TxnNumber, CustomerRefListID, CustomerRefFullName, ClassRefListID, ClassRefFullName, TemplateRefListID, TemplateRefFullName, TxnDate, TxnDateMacro, RefNumber, BillAddressAddr1, BillAddressAddr2, BillAddressAddr3, BillAddressAddr4, BillAddressAddr5, BillAddressCity, BillAddressState, BillAddressProvince, BillAddressCounty, BillAddressPostalCode, BillAddressCountry, BillAddressNote, BillAddressBlockAddr1, BillAddressBlockAddr2, BillAddressBlockAddr3, BillAddressBlockAddr4, BillAddressBlockAddr5, ShipAddressAddr1, ShipAddressAddr2, ShipAddressAddr3, ShipAddressAddr4, ShipAddressAddr5, ShipAddressCity, ShipAddressState, ShipAddressProvince, ShipAddressCounty, ShipAddressPostalCode, ShipAddressCountry, ShipAddressNote, ShipAddressBlockAddr1, ShipAddressBlockAddr2, ShipAddressBlockAddr3, ShipAddressBlockAddr4, ShipAddressBlockAddr5, PONumber, TermsRefListID, TermsRefFullName, DueDate, SalesRepRefListID, SalesRepRefFullName, FOB, ShipDate, ShipMethodRefListID, ShipMethodRefFullName, Subtotal, ItemSalesTaxRefListID, ItemSalesTaxRefFullName, SalesTaxPercentage, SalesTaxTotal, TotalAmount, IsManuallyClosed, IsFullyInvoiced, [Memo], CustomerMsgRefListID, CustomerMsgRefFullName, IsToBePrinted, IsToBeEmailed, IsTaxIncluded, CustomerSalesTaxCodeRefListID, CustomerSalesTaxCodeRefFullName, CustomerTaxCodeRefListID, CustomFieldOther, SalesOrderLineSeqNo, SalesOrderLineGroupTxnLineID, SalesOrderLineGroupItemGroupRefListID, SalesOrderLineGroupItemGroupRefFullName, SalesOrderLineGroupDesc, SalesOrderLineGroupQuantity, SalesOrderLineGroupUnitOfMeasure, SalesOrderLineGroupOverrideUOMSetRefListID, SalesOrderLineGroupOverrideUOMSetRefFullName, SalesOrderLineGroupIsPrintItemsInGroup, SalesOrderLineGroupTotalAmount, SalesOrderLineGroupSeqNo, SalesOrderLineTxnLineID, SalesOrderLineItemRefListID, SalesOrderLineItemRefFullName, SalesOrderLineDesc, SalesOrderLineQuantity, SalesOrderLineUnitOfMeasure, SalesOrderLineOverrideUOMSetRefListID, SalesOrderLineOverrideUOMSetRefFullName, SalesOrderLineRate, SalesOrderLineRatePercent, SalesOrderLinePriceLevelRefListID, SalesOrderLinePriceLevelRefFullName, SalesOrderLineClassRefListID, SalesOrderLineClassRefFullName, SalesOrderLineAmount, SalesOrderInventorySiteRefListID, SalesOrderInventorySiteRefFullName, SalesOrderLineSerialNumber, SalesOrderLineLotNumber, SalesOrderLineTaxAmount, SalesOrderLineSalesTaxCodeRefListID, SalesOrderLineSalesTaxCodeRefFullName, SalesOrderLineTaxCodeRefListID, SalesOrderLineTaxCodeRefFullName, SalesOrderLineInvoiced, SalesOrderLineIsManuallyClosed, CustomFieldSalesOrderLineOther1, CustomFieldSalesOrderLineOther2, Tax1Total, Tax2Total, ExchangeRate, AmountIncludesVAT, FQSaveToCache, FQPrimaryKey, FQTxnLinkKey, CustomFieldSalesOrderLineCycleCount, CustomFieldSalesOrderLineGroupCycleCount, CustomFieldSalesOrderLineGroupLineCycleCount, CustomFieldCollect, CustomFieldPPDCOL, CustomFieldRep, CustomFieldShipDate, CustomFieldShipVia FROM SalesOrderLine";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(usmanDataSet.SalesOrderLineDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual usmanDataSet.SalesOrderLineDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		usmanDataSet.SalesOrderLineDataTable dataTable = new usmanDataSet.SalesOrderLineDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(usmanDataSet.SalesOrderLineDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(usmanDataSet dataSet)
	{
		return Adapter.Update(dataSet, "SalesOrderLine");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow dataRow)
	{
		return Adapter.Update(new DataRow[1] { dataRow });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return Adapter.Update(dataRows);
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Delete(string Original_TxnID, DateTime? Original_TimeCreated, DateTime? Original_TimeModified, string Original_EditSequence, int? Original_TxnNumber, string Original_CustomerRefListID, string Original_CustomerRefFullName, string Original_ClassRefListID, string Original_ClassRefFullName, string Original_TemplateRefListID, string Original_TemplateRefFullName, DateTime? Original_TxnDate, string Original_TxnDateMacro, string Original_RefNumber, string Original_BillAddressAddr1, string Original_BillAddressAddr2, string Original_BillAddressAddr3, string Original_BillAddressAddr4, string Original_BillAddressAddr5, string Original_BillAddressCity, string Original_BillAddressState, string Original_BillAddressProvince, string Original_BillAddressCounty, string Original_BillAddressPostalCode, string Original_BillAddressCountry, string Original_BillAddressNote, string Original_BillAddressBlockAddr1, string Original_BillAddressBlockAddr2, string Original_BillAddressBlockAddr3, string Original_BillAddressBlockAddr4, string Original_BillAddressBlockAddr5, string Original_ShipAddressAddr1, string Original_ShipAddressAddr2, string Original_ShipAddressAddr3, string Original_ShipAddressAddr4, string Original_ShipAddressAddr5, string Original_ShipAddressCity, string Original_ShipAddressState, string Original_ShipAddressProvince, string Original_ShipAddressCounty, string Original_ShipAddressPostalCode, string Original_ShipAddressCountry, string Original_ShipAddressNote, string Original_ShipAddressBlockAddr1, string Original_ShipAddressBlockAddr2, string Original_ShipAddressBlockAddr3, string Original_ShipAddressBlockAddr4, string Original_ShipAddressBlockAddr5, string Original_PONumber, string Original_TermsRefListID, string Original_TermsRefFullName, DateTime? Original_DueDate, string Original_SalesRepRefListID, string Original_SalesRepRefFullName, string Original_FOB, DateTime? Original_ShipDate, string Original_ShipMethodRefListID, string Original_ShipMethodRefFullName, decimal? Original_Subtotal, string Original_ItemSalesTaxRefListID, string Original_ItemSalesTaxRefFullName, decimal? Original_SalesTaxPercentage, decimal? Original_SalesTaxTotal, decimal? Original_TotalAmount, bool Original_IsManuallyClosed, bool Original_IsFullyInvoiced, string Original_CustomerMsgRefListID, string Original_CustomerMsgRefFullName, bool Original_IsToBePrinted, bool Original_IsToBeEmailed, bool Original_IsTaxIncluded, string Original_CustomerSalesTaxCodeRefListID, string Original_CustomerSalesTaxCodeRefFullName, string Original_CustomerTaxCodeRefListID, string Original_CustomFieldOther, int? Original_SalesOrderLineSeqNo, string Original_SalesOrderLineGroupTxnLineID, string Original_SalesOrderLineGroupItemGroupRefListID, string Original_SalesOrderLineGroupItemGroupRefFullName, decimal? Original_SalesOrderLineGroupQuantity, string Original_SalesOrderLineGroupUnitOfMeasure, string Original_SalesOrderLineGroupOverrideUOMSetRefListID, string Original_SalesOrderLineGroupOverrideUOMSetRefFullName, bool Original_SalesOrderLineGroupIsPrintItemsInGroup, decimal? Original_SalesOrderLineGroupTotalAmount, int? Original_SalesOrderLineGroupSeqNo, string Original_SalesOrderLineTxnLineID, string Original_SalesOrderLineItemRefListID, string Original_SalesOrderLineItemRefFullName, decimal? Original_SalesOrderLineQuantity, string Original_SalesOrderLineUnitOfMeasure, string Original_SalesOrderLineOverrideUOMSetRefListID, string Original_SalesOrderLineOverrideUOMSetRefFullName, decimal? Original_SalesOrderLineRate, decimal? Original_SalesOrderLineRatePercent, string Original_SalesOrderLinePriceLevelRefListID, string Original_SalesOrderLinePriceLevelRefFullName, string Original_SalesOrderLineClassRefListID, string Original_SalesOrderLineClassRefFullName, decimal? Original_SalesOrderLineAmount, string Original_SalesOrderInventorySiteRefListID, string Original_SalesOrderInventorySiteRefFullName, string Original_SalesOrderLineLotNumber, decimal? Original_SalesOrderLineTaxAmount, string Original_SalesOrderLineSalesTaxCodeRefListID, string Original_SalesOrderLineSalesTaxCodeRefFullName, string Original_SalesOrderLineTaxCodeRefListID, string Original_SalesOrderLineTaxCodeRefFullName, decimal? Original_SalesOrderLineInvoiced, bool Original_SalesOrderLineIsManuallyClosed, string Original_CustomFieldSalesOrderLineOther1, string Original_CustomFieldSalesOrderLineOther2, decimal? Original_Tax1Total, decimal? Original_Tax2Total, decimal? Original_ExchangeRate, bool Original_AmountIncludesVAT, bool Original_FQSaveToCache, string Original_FQPrimaryKey, string Original_FQTxnLinkKey, string Original_CustomFieldSalesOrderLineCycleCount, string Original_CustomFieldSalesOrderLineGroupCycleCount, string Original_CustomFieldSalesOrderLineGroupLineCycleCount, string Original_CustomFieldCollect, string Original_CustomFieldPPDCOL, string Original_CustomFieldRep, string Original_CustomFieldShipDate, string Original_CustomFieldShipVia)
	{
		if (Original_TxnID == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = 1;
			Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = 0;
			Adapter.DeleteCommand.Parameters[1].Value = Original_TxnID;
		}
		if (Original_TimeCreated.HasValue)
		{
			Adapter.DeleteCommand.Parameters[2].Value = 0;
			Adapter.DeleteCommand.Parameters[3].Value = Original_TimeCreated.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[2].Value = 1;
			Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
		}
		if (Original_TimeModified.HasValue)
		{
			Adapter.DeleteCommand.Parameters[4].Value = 0;
			Adapter.DeleteCommand.Parameters[5].Value = Original_TimeModified.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[4].Value = 1;
			Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Original_EditSequence == null)
		{
			throw new ArgumentNullException("Original_EditSequence");
		}
		Adapter.DeleteCommand.Parameters[6].Value = 0;
		Adapter.DeleteCommand.Parameters[7].Value = Original_EditSequence;
		if (Original_TxnNumber.HasValue)
		{
			Adapter.DeleteCommand.Parameters[8].Value = 0;
			Adapter.DeleteCommand.Parameters[9].Value = Original_TxnNumber.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[8].Value = 1;
			Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
		}
		if (Original_CustomerRefListID == null)
		{
			throw new ArgumentNullException("Original_CustomerRefListID");
		}
		Adapter.DeleteCommand.Parameters[10].Value = 0;
		Adapter.DeleteCommand.Parameters[11].Value = Original_CustomerRefListID;
		if (Original_CustomerRefFullName == null)
		{
			throw new ArgumentNullException("Original_CustomerRefFullName");
		}
		Adapter.DeleteCommand.Parameters[12].Value = 0;
		Adapter.DeleteCommand.Parameters[13].Value = Original_CustomerRefFullName;
		if (Original_ClassRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[14].Value = 1;
			Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[14].Value = 0;
			Adapter.DeleteCommand.Parameters[15].Value = Original_ClassRefListID;
		}
		if (Original_ClassRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[16].Value = 1;
			Adapter.DeleteCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[16].Value = 0;
			Adapter.DeleteCommand.Parameters[17].Value = Original_ClassRefFullName;
		}
		if (Original_TemplateRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[18].Value = 1;
			Adapter.DeleteCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[18].Value = 0;
			Adapter.DeleteCommand.Parameters[19].Value = Original_TemplateRefListID;
		}
		if (Original_TemplateRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[20].Value = 1;
			Adapter.DeleteCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[20].Value = 0;
			Adapter.DeleteCommand.Parameters[21].Value = Original_TemplateRefFullName;
		}
		if (Original_TxnDate.HasValue)
		{
			Adapter.DeleteCommand.Parameters[22].Value = 0;
			Adapter.DeleteCommand.Parameters[23].Value = Original_TxnDate.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[22].Value = 1;
			Adapter.DeleteCommand.Parameters[23].Value = DBNull.Value;
		}
		if (Original_TxnDateMacro == null)
		{
			Adapter.DeleteCommand.Parameters[24].Value = 1;
			Adapter.DeleteCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[24].Value = 0;
			Adapter.DeleteCommand.Parameters[25].Value = Original_TxnDateMacro;
		}
		if (Original_RefNumber == null)
		{
			Adapter.DeleteCommand.Parameters[26].Value = 1;
			Adapter.DeleteCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[26].Value = 0;
			Adapter.DeleteCommand.Parameters[27].Value = Original_RefNumber;
		}
		if (Original_BillAddressAddr1 == null)
		{
			Adapter.DeleteCommand.Parameters[28].Value = 1;
			Adapter.DeleteCommand.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[28].Value = 0;
			Adapter.DeleteCommand.Parameters[29].Value = Original_BillAddressAddr1;
		}
		if (Original_BillAddressAddr2 == null)
		{
			Adapter.DeleteCommand.Parameters[30].Value = 1;
			Adapter.DeleteCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[30].Value = 0;
			Adapter.DeleteCommand.Parameters[31].Value = Original_BillAddressAddr2;
		}
		if (Original_BillAddressAddr3 == null)
		{
			Adapter.DeleteCommand.Parameters[32].Value = 1;
			Adapter.DeleteCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[32].Value = 0;
			Adapter.DeleteCommand.Parameters[33].Value = Original_BillAddressAddr3;
		}
		if (Original_BillAddressAddr4 == null)
		{
			Adapter.DeleteCommand.Parameters[34].Value = 1;
			Adapter.DeleteCommand.Parameters[35].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[34].Value = 0;
			Adapter.DeleteCommand.Parameters[35].Value = Original_BillAddressAddr4;
		}
		if (Original_BillAddressAddr5 == null)
		{
			Adapter.DeleteCommand.Parameters[36].Value = 1;
			Adapter.DeleteCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[36].Value = 0;
			Adapter.DeleteCommand.Parameters[37].Value = Original_BillAddressAddr5;
		}
		if (Original_BillAddressCity == null)
		{
			Adapter.DeleteCommand.Parameters[38].Value = 1;
			Adapter.DeleteCommand.Parameters[39].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[38].Value = 0;
			Adapter.DeleteCommand.Parameters[39].Value = Original_BillAddressCity;
		}
		if (Original_BillAddressState == null)
		{
			Adapter.DeleteCommand.Parameters[40].Value = 1;
			Adapter.DeleteCommand.Parameters[41].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[40].Value = 0;
			Adapter.DeleteCommand.Parameters[41].Value = Original_BillAddressState;
		}
		if (Original_BillAddressProvince == null)
		{
			Adapter.DeleteCommand.Parameters[42].Value = 1;
			Adapter.DeleteCommand.Parameters[43].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[42].Value = 0;
			Adapter.DeleteCommand.Parameters[43].Value = Original_BillAddressProvince;
		}
		if (Original_BillAddressCounty == null)
		{
			Adapter.DeleteCommand.Parameters[44].Value = 1;
			Adapter.DeleteCommand.Parameters[45].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[44].Value = 0;
			Adapter.DeleteCommand.Parameters[45].Value = Original_BillAddressCounty;
		}
		if (Original_BillAddressPostalCode == null)
		{
			Adapter.DeleteCommand.Parameters[46].Value = 1;
			Adapter.DeleteCommand.Parameters[47].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[46].Value = 0;
			Adapter.DeleteCommand.Parameters[47].Value = Original_BillAddressPostalCode;
		}
		if (Original_BillAddressCountry == null)
		{
			Adapter.DeleteCommand.Parameters[48].Value = 1;
			Adapter.DeleteCommand.Parameters[49].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[48].Value = 0;
			Adapter.DeleteCommand.Parameters[49].Value = Original_BillAddressCountry;
		}
		if (Original_BillAddressNote == null)
		{
			Adapter.DeleteCommand.Parameters[50].Value = 1;
			Adapter.DeleteCommand.Parameters[51].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[50].Value = 0;
			Adapter.DeleteCommand.Parameters[51].Value = Original_BillAddressNote;
		}
		if (Original_BillAddressBlockAddr1 == null)
		{
			Adapter.DeleteCommand.Parameters[52].Value = 1;
			Adapter.DeleteCommand.Parameters[53].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[52].Value = 0;
			Adapter.DeleteCommand.Parameters[53].Value = Original_BillAddressBlockAddr1;
		}
		if (Original_BillAddressBlockAddr2 == null)
		{
			Adapter.DeleteCommand.Parameters[54].Value = 1;
			Adapter.DeleteCommand.Parameters[55].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[54].Value = 0;
			Adapter.DeleteCommand.Parameters[55].Value = Original_BillAddressBlockAddr2;
		}
		if (Original_BillAddressBlockAddr3 == null)
		{
			Adapter.DeleteCommand.Parameters[56].Value = 1;
			Adapter.DeleteCommand.Parameters[57].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[56].Value = 0;
			Adapter.DeleteCommand.Parameters[57].Value = Original_BillAddressBlockAddr3;
		}
		if (Original_BillAddressBlockAddr4 == null)
		{
			Adapter.DeleteCommand.Parameters[58].Value = 1;
			Adapter.DeleteCommand.Parameters[59].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[58].Value = 0;
			Adapter.DeleteCommand.Parameters[59].Value = Original_BillAddressBlockAddr4;
		}
		if (Original_BillAddressBlockAddr5 == null)
		{
			Adapter.DeleteCommand.Parameters[60].Value = 1;
			Adapter.DeleteCommand.Parameters[61].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[60].Value = 0;
			Adapter.DeleteCommand.Parameters[61].Value = Original_BillAddressBlockAddr5;
		}
		if (Original_ShipAddressAddr1 == null)
		{
			Adapter.DeleteCommand.Parameters[62].Value = 1;
			Adapter.DeleteCommand.Parameters[63].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[62].Value = 0;
			Adapter.DeleteCommand.Parameters[63].Value = Original_ShipAddressAddr1;
		}
		if (Original_ShipAddressAddr2 == null)
		{
			Adapter.DeleteCommand.Parameters[64].Value = 1;
			Adapter.DeleteCommand.Parameters[65].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[64].Value = 0;
			Adapter.DeleteCommand.Parameters[65].Value = Original_ShipAddressAddr2;
		}
		if (Original_ShipAddressAddr3 == null)
		{
			Adapter.DeleteCommand.Parameters[66].Value = 1;
			Adapter.DeleteCommand.Parameters[67].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[66].Value = 0;
			Adapter.DeleteCommand.Parameters[67].Value = Original_ShipAddressAddr3;
		}
		if (Original_ShipAddressAddr4 == null)
		{
			Adapter.DeleteCommand.Parameters[68].Value = 1;
			Adapter.DeleteCommand.Parameters[69].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[68].Value = 0;
			Adapter.DeleteCommand.Parameters[69].Value = Original_ShipAddressAddr4;
		}
		if (Original_ShipAddressAddr5 == null)
		{
			Adapter.DeleteCommand.Parameters[70].Value = 1;
			Adapter.DeleteCommand.Parameters[71].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[70].Value = 0;
			Adapter.DeleteCommand.Parameters[71].Value = Original_ShipAddressAddr5;
		}
		if (Original_ShipAddressCity == null)
		{
			Adapter.DeleteCommand.Parameters[72].Value = 1;
			Adapter.DeleteCommand.Parameters[73].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[72].Value = 0;
			Adapter.DeleteCommand.Parameters[73].Value = Original_ShipAddressCity;
		}
		if (Original_ShipAddressState == null)
		{
			Adapter.DeleteCommand.Parameters[74].Value = 1;
			Adapter.DeleteCommand.Parameters[75].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[74].Value = 0;
			Adapter.DeleteCommand.Parameters[75].Value = Original_ShipAddressState;
		}
		if (Original_ShipAddressProvince == null)
		{
			Adapter.DeleteCommand.Parameters[76].Value = 1;
			Adapter.DeleteCommand.Parameters[77].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[76].Value = 0;
			Adapter.DeleteCommand.Parameters[77].Value = Original_ShipAddressProvince;
		}
		if (Original_ShipAddressCounty == null)
		{
			Adapter.DeleteCommand.Parameters[78].Value = 1;
			Adapter.DeleteCommand.Parameters[79].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[78].Value = 0;
			Adapter.DeleteCommand.Parameters[79].Value = Original_ShipAddressCounty;
		}
		if (Original_ShipAddressPostalCode == null)
		{
			Adapter.DeleteCommand.Parameters[80].Value = 1;
			Adapter.DeleteCommand.Parameters[81].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[80].Value = 0;
			Adapter.DeleteCommand.Parameters[81].Value = Original_ShipAddressPostalCode;
		}
		if (Original_ShipAddressCountry == null)
		{
			Adapter.DeleteCommand.Parameters[82].Value = 1;
			Adapter.DeleteCommand.Parameters[83].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[82].Value = 0;
			Adapter.DeleteCommand.Parameters[83].Value = Original_ShipAddressCountry;
		}
		if (Original_ShipAddressNote == null)
		{
			Adapter.DeleteCommand.Parameters[84].Value = 1;
			Adapter.DeleteCommand.Parameters[85].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[84].Value = 0;
			Adapter.DeleteCommand.Parameters[85].Value = Original_ShipAddressNote;
		}
		if (Original_ShipAddressBlockAddr1 == null)
		{
			Adapter.DeleteCommand.Parameters[86].Value = 1;
			Adapter.DeleteCommand.Parameters[87].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[86].Value = 0;
			Adapter.DeleteCommand.Parameters[87].Value = Original_ShipAddressBlockAddr1;
		}
		if (Original_ShipAddressBlockAddr2 == null)
		{
			Adapter.DeleteCommand.Parameters[88].Value = 1;
			Adapter.DeleteCommand.Parameters[89].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[88].Value = 0;
			Adapter.DeleteCommand.Parameters[89].Value = Original_ShipAddressBlockAddr2;
		}
		if (Original_ShipAddressBlockAddr3 == null)
		{
			Adapter.DeleteCommand.Parameters[90].Value = 1;
			Adapter.DeleteCommand.Parameters[91].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[90].Value = 0;
			Adapter.DeleteCommand.Parameters[91].Value = Original_ShipAddressBlockAddr3;
		}
		if (Original_ShipAddressBlockAddr4 == null)
		{
			Adapter.DeleteCommand.Parameters[92].Value = 1;
			Adapter.DeleteCommand.Parameters[93].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[92].Value = 0;
			Adapter.DeleteCommand.Parameters[93].Value = Original_ShipAddressBlockAddr4;
		}
		if (Original_ShipAddressBlockAddr5 == null)
		{
			Adapter.DeleteCommand.Parameters[94].Value = 1;
			Adapter.DeleteCommand.Parameters[95].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[94].Value = 0;
			Adapter.DeleteCommand.Parameters[95].Value = Original_ShipAddressBlockAddr5;
		}
		if (Original_PONumber == null)
		{
			Adapter.DeleteCommand.Parameters[96].Value = 1;
			Adapter.DeleteCommand.Parameters[97].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[96].Value = 0;
			Adapter.DeleteCommand.Parameters[97].Value = Original_PONumber;
		}
		if (Original_TermsRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[98].Value = 1;
			Adapter.DeleteCommand.Parameters[99].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[98].Value = 0;
			Adapter.DeleteCommand.Parameters[99].Value = Original_TermsRefListID;
		}
		if (Original_TermsRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[100].Value = 1;
			Adapter.DeleteCommand.Parameters[101].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[100].Value = 0;
			Adapter.DeleteCommand.Parameters[101].Value = Original_TermsRefFullName;
		}
		if (Original_DueDate.HasValue)
		{
			Adapter.DeleteCommand.Parameters[102].Value = 0;
			Adapter.DeleteCommand.Parameters[103].Value = Original_DueDate.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[102].Value = 1;
			Adapter.DeleteCommand.Parameters[103].Value = DBNull.Value;
		}
		if (Original_SalesRepRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[104].Value = 1;
			Adapter.DeleteCommand.Parameters[105].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[104].Value = 0;
			Adapter.DeleteCommand.Parameters[105].Value = Original_SalesRepRefListID;
		}
		if (Original_SalesRepRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[106].Value = 1;
			Adapter.DeleteCommand.Parameters[107].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[106].Value = 0;
			Adapter.DeleteCommand.Parameters[107].Value = Original_SalesRepRefFullName;
		}
		if (Original_FOB == null)
		{
			Adapter.DeleteCommand.Parameters[108].Value = 1;
			Adapter.DeleteCommand.Parameters[109].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[108].Value = 0;
			Adapter.DeleteCommand.Parameters[109].Value = Original_FOB;
		}
		if (Original_ShipDate.HasValue)
		{
			Adapter.DeleteCommand.Parameters[110].Value = 0;
			Adapter.DeleteCommand.Parameters[111].Value = Original_ShipDate.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[110].Value = 1;
			Adapter.DeleteCommand.Parameters[111].Value = DBNull.Value;
		}
		if (Original_ShipMethodRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[112].Value = 1;
			Adapter.DeleteCommand.Parameters[113].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[112].Value = 0;
			Adapter.DeleteCommand.Parameters[113].Value = Original_ShipMethodRefListID;
		}
		if (Original_ShipMethodRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[114].Value = 1;
			Adapter.DeleteCommand.Parameters[115].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[114].Value = 0;
			Adapter.DeleteCommand.Parameters[115].Value = Original_ShipMethodRefFullName;
		}
		if (Original_Subtotal.HasValue)
		{
			Adapter.DeleteCommand.Parameters[116].Value = 0;
			Adapter.DeleteCommand.Parameters[117].Value = Original_Subtotal.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[116].Value = 1;
			Adapter.DeleteCommand.Parameters[117].Value = DBNull.Value;
		}
		if (Original_ItemSalesTaxRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[118].Value = 1;
			Adapter.DeleteCommand.Parameters[119].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[118].Value = 0;
			Adapter.DeleteCommand.Parameters[119].Value = Original_ItemSalesTaxRefListID;
		}
		if (Original_ItemSalesTaxRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[120].Value = 1;
			Adapter.DeleteCommand.Parameters[121].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[120].Value = 0;
			Adapter.DeleteCommand.Parameters[121].Value = Original_ItemSalesTaxRefFullName;
		}
		if (Original_SalesTaxPercentage.HasValue)
		{
			Adapter.DeleteCommand.Parameters[122].Value = 0;
			Adapter.DeleteCommand.Parameters[123].Value = Original_SalesTaxPercentage.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[122].Value = 1;
			Adapter.DeleteCommand.Parameters[123].Value = DBNull.Value;
		}
		if (Original_SalesTaxTotal.HasValue)
		{
			Adapter.DeleteCommand.Parameters[124].Value = 0;
			Adapter.DeleteCommand.Parameters[125].Value = Original_SalesTaxTotal.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[124].Value = 1;
			Adapter.DeleteCommand.Parameters[125].Value = DBNull.Value;
		}
		if (Original_TotalAmount.HasValue)
		{
			Adapter.DeleteCommand.Parameters[126].Value = 0;
			Adapter.DeleteCommand.Parameters[127].Value = Original_TotalAmount.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[126].Value = 1;
			Adapter.DeleteCommand.Parameters[127].Value = DBNull.Value;
		}
		Adapter.DeleteCommand.Parameters[128].Value = 0;
		Adapter.DeleteCommand.Parameters[129].Value = Original_IsManuallyClosed;
		Adapter.DeleteCommand.Parameters[130].Value = 0;
		Adapter.DeleteCommand.Parameters[131].Value = Original_IsFullyInvoiced;
		if (Original_CustomerMsgRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[132].Value = 1;
			Adapter.DeleteCommand.Parameters[133].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[132].Value = 0;
			Adapter.DeleteCommand.Parameters[133].Value = Original_CustomerMsgRefListID;
		}
		if (Original_CustomerMsgRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[134].Value = 1;
			Adapter.DeleteCommand.Parameters[135].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[134].Value = 0;
			Adapter.DeleteCommand.Parameters[135].Value = Original_CustomerMsgRefFullName;
		}
		Adapter.DeleteCommand.Parameters[136].Value = 0;
		Adapter.DeleteCommand.Parameters[137].Value = Original_IsToBePrinted;
		Adapter.DeleteCommand.Parameters[138].Value = 0;
		Adapter.DeleteCommand.Parameters[139].Value = Original_IsToBeEmailed;
		Adapter.DeleteCommand.Parameters[140].Value = 0;
		Adapter.DeleteCommand.Parameters[141].Value = Original_IsTaxIncluded;
		if (Original_CustomerSalesTaxCodeRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[142].Value = 1;
			Adapter.DeleteCommand.Parameters[143].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[142].Value = 0;
			Adapter.DeleteCommand.Parameters[143].Value = Original_CustomerSalesTaxCodeRefListID;
		}
		if (Original_CustomerSalesTaxCodeRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[144].Value = 1;
			Adapter.DeleteCommand.Parameters[145].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[144].Value = 0;
			Adapter.DeleteCommand.Parameters[145].Value = Original_CustomerSalesTaxCodeRefFullName;
		}
		if (Original_CustomerTaxCodeRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[146].Value = 1;
			Adapter.DeleteCommand.Parameters[147].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[146].Value = 0;
			Adapter.DeleteCommand.Parameters[147].Value = Original_CustomerTaxCodeRefListID;
		}
		if (Original_CustomFieldOther == null)
		{
			Adapter.DeleteCommand.Parameters[148].Value = 1;
			Adapter.DeleteCommand.Parameters[149].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[148].Value = 0;
			Adapter.DeleteCommand.Parameters[149].Value = Original_CustomFieldOther;
		}
		if (Original_SalesOrderLineSeqNo.HasValue)
		{
			Adapter.DeleteCommand.Parameters[150].Value = 0;
			Adapter.DeleteCommand.Parameters[151].Value = Original_SalesOrderLineSeqNo.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[150].Value = 1;
			Adapter.DeleteCommand.Parameters[151].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupTxnLineID == null)
		{
			Adapter.DeleteCommand.Parameters[152].Value = 1;
			Adapter.DeleteCommand.Parameters[153].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[152].Value = 0;
			Adapter.DeleteCommand.Parameters[153].Value = Original_SalesOrderLineGroupTxnLineID;
		}
		if (Original_SalesOrderLineGroupItemGroupRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[154].Value = 1;
			Adapter.DeleteCommand.Parameters[155].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[154].Value = 0;
			Adapter.DeleteCommand.Parameters[155].Value = Original_SalesOrderLineGroupItemGroupRefListID;
		}
		if (Original_SalesOrderLineGroupItemGroupRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[156].Value = 1;
			Adapter.DeleteCommand.Parameters[157].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[156].Value = 0;
			Adapter.DeleteCommand.Parameters[157].Value = Original_SalesOrderLineGroupItemGroupRefFullName;
		}
		if (Original_SalesOrderLineGroupQuantity.HasValue)
		{
			Adapter.DeleteCommand.Parameters[158].Value = 0;
			Adapter.DeleteCommand.Parameters[159].Value = Original_SalesOrderLineGroupQuantity.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[158].Value = 1;
			Adapter.DeleteCommand.Parameters[159].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupUnitOfMeasure == null)
		{
			Adapter.DeleteCommand.Parameters[160].Value = 1;
			Adapter.DeleteCommand.Parameters[161].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[160].Value = 0;
			Adapter.DeleteCommand.Parameters[161].Value = Original_SalesOrderLineGroupUnitOfMeasure;
		}
		if (Original_SalesOrderLineGroupOverrideUOMSetRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[162].Value = 1;
			Adapter.DeleteCommand.Parameters[163].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[162].Value = 0;
			Adapter.DeleteCommand.Parameters[163].Value = Original_SalesOrderLineGroupOverrideUOMSetRefListID;
		}
		if (Original_SalesOrderLineGroupOverrideUOMSetRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[164].Value = 1;
			Adapter.DeleteCommand.Parameters[165].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[164].Value = 0;
			Adapter.DeleteCommand.Parameters[165].Value = Original_SalesOrderLineGroupOverrideUOMSetRefFullName;
		}
		Adapter.DeleteCommand.Parameters[166].Value = 0;
		Adapter.DeleteCommand.Parameters[167].Value = Original_SalesOrderLineGroupIsPrintItemsInGroup;
		if (Original_SalesOrderLineGroupTotalAmount.HasValue)
		{
			Adapter.DeleteCommand.Parameters[168].Value = 0;
			Adapter.DeleteCommand.Parameters[169].Value = Original_SalesOrderLineGroupTotalAmount.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[168].Value = 1;
			Adapter.DeleteCommand.Parameters[169].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupSeqNo.HasValue)
		{
			Adapter.DeleteCommand.Parameters[170].Value = 0;
			Adapter.DeleteCommand.Parameters[171].Value = Original_SalesOrderLineGroupSeqNo.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[170].Value = 1;
			Adapter.DeleteCommand.Parameters[171].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineTxnLineID == null)
		{
			Adapter.DeleteCommand.Parameters[172].Value = 1;
			Adapter.DeleteCommand.Parameters[173].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[172].Value = 0;
			Adapter.DeleteCommand.Parameters[173].Value = Original_SalesOrderLineTxnLineID;
		}
		if (Original_SalesOrderLineItemRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[174].Value = 1;
			Adapter.DeleteCommand.Parameters[175].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[174].Value = 0;
			Adapter.DeleteCommand.Parameters[175].Value = Original_SalesOrderLineItemRefListID;
		}
		if (Original_SalesOrderLineItemRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[176].Value = 1;
			Adapter.DeleteCommand.Parameters[177].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[176].Value = 0;
			Adapter.DeleteCommand.Parameters[177].Value = Original_SalesOrderLineItemRefFullName;
		}
		if (Original_SalesOrderLineQuantity.HasValue)
		{
			Adapter.DeleteCommand.Parameters[178].Value = 0;
			Adapter.DeleteCommand.Parameters[179].Value = Original_SalesOrderLineQuantity.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[178].Value = 1;
			Adapter.DeleteCommand.Parameters[179].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineUnitOfMeasure == null)
		{
			Adapter.DeleteCommand.Parameters[180].Value = 1;
			Adapter.DeleteCommand.Parameters[181].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[180].Value = 0;
			Adapter.DeleteCommand.Parameters[181].Value = Original_SalesOrderLineUnitOfMeasure;
		}
		if (Original_SalesOrderLineOverrideUOMSetRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[182].Value = 1;
			Adapter.DeleteCommand.Parameters[183].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[182].Value = 0;
			Adapter.DeleteCommand.Parameters[183].Value = Original_SalesOrderLineOverrideUOMSetRefListID;
		}
		if (Original_SalesOrderLineOverrideUOMSetRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[184].Value = 1;
			Adapter.DeleteCommand.Parameters[185].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[184].Value = 0;
			Adapter.DeleteCommand.Parameters[185].Value = Original_SalesOrderLineOverrideUOMSetRefFullName;
		}
		if (Original_SalesOrderLineRate.HasValue)
		{
			Adapter.DeleteCommand.Parameters[186].Value = 0;
			Adapter.DeleteCommand.Parameters[187].Value = Original_SalesOrderLineRate.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[186].Value = 1;
			Adapter.DeleteCommand.Parameters[187].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineRatePercent.HasValue)
		{
			Adapter.DeleteCommand.Parameters[188].Value = 0;
			Adapter.DeleteCommand.Parameters[189].Value = Original_SalesOrderLineRatePercent.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[188].Value = 1;
			Adapter.DeleteCommand.Parameters[189].Value = DBNull.Value;
		}
		if (Original_SalesOrderLinePriceLevelRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[190].Value = 1;
			Adapter.DeleteCommand.Parameters[191].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[190].Value = 0;
			Adapter.DeleteCommand.Parameters[191].Value = Original_SalesOrderLinePriceLevelRefListID;
		}
		if (Original_SalesOrderLinePriceLevelRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[192].Value = 1;
			Adapter.DeleteCommand.Parameters[193].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[192].Value = 0;
			Adapter.DeleteCommand.Parameters[193].Value = Original_SalesOrderLinePriceLevelRefFullName;
		}
		if (Original_SalesOrderLineClassRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[194].Value = 1;
			Adapter.DeleteCommand.Parameters[195].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[194].Value = 0;
			Adapter.DeleteCommand.Parameters[195].Value = Original_SalesOrderLineClassRefListID;
		}
		if (Original_SalesOrderLineClassRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[196].Value = 1;
			Adapter.DeleteCommand.Parameters[197].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[196].Value = 0;
			Adapter.DeleteCommand.Parameters[197].Value = Original_SalesOrderLineClassRefFullName;
		}
		if (Original_SalesOrderLineAmount.HasValue)
		{
			Adapter.DeleteCommand.Parameters[198].Value = 0;
			Adapter.DeleteCommand.Parameters[199].Value = Original_SalesOrderLineAmount.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[198].Value = 1;
			Adapter.DeleteCommand.Parameters[199].Value = DBNull.Value;
		}
		if (Original_SalesOrderInventorySiteRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[200].Value = 1;
			Adapter.DeleteCommand.Parameters[201].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[200].Value = 0;
			Adapter.DeleteCommand.Parameters[201].Value = Original_SalesOrderInventorySiteRefListID;
		}
		if (Original_SalesOrderInventorySiteRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[202].Value = 1;
			Adapter.DeleteCommand.Parameters[203].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[202].Value = 0;
			Adapter.DeleteCommand.Parameters[203].Value = Original_SalesOrderInventorySiteRefFullName;
		}
		if (Original_SalesOrderLineLotNumber == null)
		{
			Adapter.DeleteCommand.Parameters[204].Value = 1;
			Adapter.DeleteCommand.Parameters[205].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[204].Value = 0;
			Adapter.DeleteCommand.Parameters[205].Value = Original_SalesOrderLineLotNumber;
		}
		if (Original_SalesOrderLineTaxAmount.HasValue)
		{
			Adapter.DeleteCommand.Parameters[206].Value = 0;
			Adapter.DeleteCommand.Parameters[207].Value = Original_SalesOrderLineTaxAmount.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[206].Value = 1;
			Adapter.DeleteCommand.Parameters[207].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineSalesTaxCodeRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[208].Value = 1;
			Adapter.DeleteCommand.Parameters[209].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[208].Value = 0;
			Adapter.DeleteCommand.Parameters[209].Value = Original_SalesOrderLineSalesTaxCodeRefListID;
		}
		if (Original_SalesOrderLineSalesTaxCodeRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[210].Value = 1;
			Adapter.DeleteCommand.Parameters[211].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[210].Value = 0;
			Adapter.DeleteCommand.Parameters[211].Value = Original_SalesOrderLineSalesTaxCodeRefFullName;
		}
		if (Original_SalesOrderLineTaxCodeRefListID == null)
		{
			Adapter.DeleteCommand.Parameters[212].Value = 1;
			Adapter.DeleteCommand.Parameters[213].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[212].Value = 0;
			Adapter.DeleteCommand.Parameters[213].Value = Original_SalesOrderLineTaxCodeRefListID;
		}
		if (Original_SalesOrderLineTaxCodeRefFullName == null)
		{
			Adapter.DeleteCommand.Parameters[214].Value = 1;
			Adapter.DeleteCommand.Parameters[215].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[214].Value = 0;
			Adapter.DeleteCommand.Parameters[215].Value = Original_SalesOrderLineTaxCodeRefFullName;
		}
		if (Original_SalesOrderLineInvoiced.HasValue)
		{
			Adapter.DeleteCommand.Parameters[216].Value = 0;
			Adapter.DeleteCommand.Parameters[217].Value = Original_SalesOrderLineInvoiced.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[216].Value = 1;
			Adapter.DeleteCommand.Parameters[217].Value = DBNull.Value;
		}
		Adapter.DeleteCommand.Parameters[218].Value = 0;
		Adapter.DeleteCommand.Parameters[219].Value = Original_SalesOrderLineIsManuallyClosed;
		if (Original_CustomFieldSalesOrderLineOther1 == null)
		{
			Adapter.DeleteCommand.Parameters[220].Value = 1;
			Adapter.DeleteCommand.Parameters[221].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[220].Value = 0;
			Adapter.DeleteCommand.Parameters[221].Value = Original_CustomFieldSalesOrderLineOther1;
		}
		if (Original_CustomFieldSalesOrderLineOther2 == null)
		{
			Adapter.DeleteCommand.Parameters[222].Value = 1;
			Adapter.DeleteCommand.Parameters[223].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[222].Value = 0;
			Adapter.DeleteCommand.Parameters[223].Value = Original_CustomFieldSalesOrderLineOther2;
		}
		if (Original_Tax1Total.HasValue)
		{
			Adapter.DeleteCommand.Parameters[224].Value = 0;
			Adapter.DeleteCommand.Parameters[225].Value = Original_Tax1Total.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[224].Value = 1;
			Adapter.DeleteCommand.Parameters[225].Value = DBNull.Value;
		}
		if (Original_Tax2Total.HasValue)
		{
			Adapter.DeleteCommand.Parameters[226].Value = 0;
			Adapter.DeleteCommand.Parameters[227].Value = Original_Tax2Total.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[226].Value = 1;
			Adapter.DeleteCommand.Parameters[227].Value = DBNull.Value;
		}
		if (Original_ExchangeRate.HasValue)
		{
			Adapter.DeleteCommand.Parameters[228].Value = 0;
			Adapter.DeleteCommand.Parameters[229].Value = Original_ExchangeRate.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[228].Value = 1;
			Adapter.DeleteCommand.Parameters[229].Value = DBNull.Value;
		}
		Adapter.DeleteCommand.Parameters[230].Value = 0;
		Adapter.DeleteCommand.Parameters[231].Value = Original_AmountIncludesVAT;
		Adapter.DeleteCommand.Parameters[232].Value = 0;
		Adapter.DeleteCommand.Parameters[233].Value = Original_FQSaveToCache;
		if (Original_FQPrimaryKey == null)
		{
			throw new ArgumentNullException("Original_FQPrimaryKey");
		}
		Adapter.DeleteCommand.Parameters[234].Value = Original_FQPrimaryKey;
		if (Original_FQTxnLinkKey == null)
		{
			Adapter.DeleteCommand.Parameters[235].Value = 1;
			Adapter.DeleteCommand.Parameters[236].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[235].Value = 0;
			Adapter.DeleteCommand.Parameters[236].Value = Original_FQTxnLinkKey;
		}
		if (Original_CustomFieldSalesOrderLineCycleCount == null)
		{
			Adapter.DeleteCommand.Parameters[237].Value = 1;
			Adapter.DeleteCommand.Parameters[238].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[237].Value = 0;
			Adapter.DeleteCommand.Parameters[238].Value = Original_CustomFieldSalesOrderLineCycleCount;
		}
		if (Original_CustomFieldSalesOrderLineGroupCycleCount == null)
		{
			Adapter.DeleteCommand.Parameters[239].Value = 1;
			Adapter.DeleteCommand.Parameters[240].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[239].Value = 0;
			Adapter.DeleteCommand.Parameters[240].Value = Original_CustomFieldSalesOrderLineGroupCycleCount;
		}
		if (Original_CustomFieldSalesOrderLineGroupLineCycleCount == null)
		{
			Adapter.DeleteCommand.Parameters[241].Value = 1;
			Adapter.DeleteCommand.Parameters[242].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[241].Value = 0;
			Adapter.DeleteCommand.Parameters[242].Value = Original_CustomFieldSalesOrderLineGroupLineCycleCount;
		}
		if (Original_CustomFieldCollect == null)
		{
			Adapter.DeleteCommand.Parameters[243].Value = 1;
			Adapter.DeleteCommand.Parameters[244].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[243].Value = 0;
			Adapter.DeleteCommand.Parameters[244].Value = Original_CustomFieldCollect;
		}
		if (Original_CustomFieldPPDCOL == null)
		{
			Adapter.DeleteCommand.Parameters[245].Value = 1;
			Adapter.DeleteCommand.Parameters[246].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[245].Value = 0;
			Adapter.DeleteCommand.Parameters[246].Value = Original_CustomFieldPPDCOL;
		}
		if (Original_CustomFieldRep == null)
		{
			Adapter.DeleteCommand.Parameters[247].Value = 1;
			Adapter.DeleteCommand.Parameters[248].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[247].Value = 0;
			Adapter.DeleteCommand.Parameters[248].Value = Original_CustomFieldRep;
		}
		if (Original_CustomFieldShipDate == null)
		{
			Adapter.DeleteCommand.Parameters[249].Value = 1;
			Adapter.DeleteCommand.Parameters[250].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[249].Value = 0;
			Adapter.DeleteCommand.Parameters[250].Value = Original_CustomFieldShipDate;
		}
		if (Original_CustomFieldShipVia == null)
		{
			Adapter.DeleteCommand.Parameters[251].Value = 1;
			Adapter.DeleteCommand.Parameters[252].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[251].Value = 0;
			Adapter.DeleteCommand.Parameters[252].Value = Original_CustomFieldShipVia;
		}
		ConnectionState previousConnectionState = Adapter.DeleteCommand.Connection.State;
		if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			return Adapter.DeleteCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.DeleteCommand.Connection.Close();
			}
		}
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Insert(string TxnID, DateTime? TimeCreated, DateTime? TimeModified, string EditSequence, int? TxnNumber, string CustomerRefListID, string CustomerRefFullName, string ClassRefListID, string ClassRefFullName, string TemplateRefListID, string TemplateRefFullName, DateTime? TxnDate, string TxnDateMacro, string RefNumber, string BillAddressAddr1, string BillAddressAddr2, string BillAddressAddr3, string BillAddressAddr4, string BillAddressAddr5, string BillAddressCity, string BillAddressState, string BillAddressProvince, string BillAddressCounty, string BillAddressPostalCode, string BillAddressCountry, string BillAddressNote, string BillAddressBlockAddr1, string BillAddressBlockAddr2, string BillAddressBlockAddr3, string BillAddressBlockAddr4, string BillAddressBlockAddr5, string ShipAddressAddr1, string ShipAddressAddr2, string ShipAddressAddr3, string ShipAddressAddr4, string ShipAddressAddr5, string ShipAddressCity, string ShipAddressState, string ShipAddressProvince, string ShipAddressCounty, string ShipAddressPostalCode, string ShipAddressCountry, string ShipAddressNote, string ShipAddressBlockAddr1, string ShipAddressBlockAddr2, string ShipAddressBlockAddr3, string ShipAddressBlockAddr4, string ShipAddressBlockAddr5, string PONumber, string TermsRefListID, string TermsRefFullName, DateTime? DueDate, string SalesRepRefListID, string SalesRepRefFullName, string FOB, DateTime? ShipDate, string ShipMethodRefListID, string ShipMethodRefFullName, decimal? Subtotal, string ItemSalesTaxRefListID, string ItemSalesTaxRefFullName, decimal? SalesTaxPercentage, decimal? SalesTaxTotal, decimal? TotalAmount, bool IsManuallyClosed, bool IsFullyInvoiced, string Memo, string CustomerMsgRefListID, string CustomerMsgRefFullName, bool IsToBePrinted, bool IsToBeEmailed, bool IsTaxIncluded, string CustomerSalesTaxCodeRefListID, string CustomerSalesTaxCodeRefFullName, string CustomerTaxCodeRefListID, string CustomFieldOther, int? SalesOrderLineSeqNo, string SalesOrderLineGroupTxnLineID, string SalesOrderLineGroupItemGroupRefListID, string SalesOrderLineGroupItemGroupRefFullName, string SalesOrderLineGroupDesc, decimal? SalesOrderLineGroupQuantity, string SalesOrderLineGroupUnitOfMeasure, string SalesOrderLineGroupOverrideUOMSetRefListID, string SalesOrderLineGroupOverrideUOMSetRefFullName, bool SalesOrderLineGroupIsPrintItemsInGroup, decimal? SalesOrderLineGroupTotalAmount, int? SalesOrderLineGroupSeqNo, string SalesOrderLineTxnLineID, string SalesOrderLineItemRefListID, string SalesOrderLineItemRefFullName, string SalesOrderLineDesc, decimal? SalesOrderLineQuantity, string SalesOrderLineUnitOfMeasure, string SalesOrderLineOverrideUOMSetRefListID, string SalesOrderLineOverrideUOMSetRefFullName, decimal? SalesOrderLineRate, decimal? SalesOrderLineRatePercent, string SalesOrderLinePriceLevelRefListID, string SalesOrderLinePriceLevelRefFullName, string SalesOrderLineClassRefListID, string SalesOrderLineClassRefFullName, decimal? SalesOrderLineAmount, string SalesOrderInventorySiteRefListID, string SalesOrderInventorySiteRefFullName, string SalesOrderLineSerialNumber, string SalesOrderLineLotNumber, decimal? SalesOrderLineTaxAmount, string SalesOrderLineSalesTaxCodeRefListID, string SalesOrderLineSalesTaxCodeRefFullName, string SalesOrderLineTaxCodeRefListID, string SalesOrderLineTaxCodeRefFullName, decimal? SalesOrderLineInvoiced, bool SalesOrderLineIsManuallyClosed, string CustomFieldSalesOrderLineOther1, string CustomFieldSalesOrderLineOther2, decimal? Tax1Total, decimal? Tax2Total, decimal? ExchangeRate, bool AmountIncludesVAT, bool FQSaveToCache, string FQPrimaryKey, string FQTxnLinkKey, string CustomFieldSalesOrderLineCycleCount, string CustomFieldSalesOrderLineGroupCycleCount, string CustomFieldSalesOrderLineGroupLineCycleCount, string CustomFieldCollect, string CustomFieldPPDCOL, string CustomFieldRep, string CustomFieldShipDate, string CustomFieldShipVia)
	{
		if (TxnID == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = TxnID;
		}
		if (TimeCreated.HasValue)
		{
			Adapter.InsertCommand.Parameters[1].Value = TimeCreated.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		if (TimeModified.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = TimeModified.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		if (EditSequence == null)
		{
			throw new ArgumentNullException("EditSequence");
		}
		Adapter.InsertCommand.Parameters[3].Value = EditSequence;
		if (TxnNumber.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = TxnNumber.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (CustomerRefListID == null)
		{
			throw new ArgumentNullException("CustomerRefListID");
		}
		Adapter.InsertCommand.Parameters[5].Value = CustomerRefListID;
		if (CustomerRefFullName == null)
		{
			throw new ArgumentNullException("CustomerRefFullName");
		}
		Adapter.InsertCommand.Parameters[6].Value = CustomerRefFullName;
		if (ClassRefListID == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = ClassRefListID;
		}
		if (ClassRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = ClassRefFullName;
		}
		if (TemplateRefListID == null)
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = TemplateRefListID;
		}
		if (TemplateRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = TemplateRefFullName;
		}
		if (TxnDate.HasValue)
		{
			Adapter.InsertCommand.Parameters[11].Value = TxnDate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		if (TxnDateMacro == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = TxnDateMacro;
		}
		if (RefNumber == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = RefNumber;
		}
		if (BillAddressAddr1 == null)
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = BillAddressAddr1;
		}
		if (BillAddressAddr2 == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = BillAddressAddr2;
		}
		if (BillAddressAddr3 == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = BillAddressAddr3;
		}
		if (BillAddressAddr4 == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = BillAddressAddr4;
		}
		if (BillAddressAddr5 == null)
		{
			Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[18].Value = BillAddressAddr5;
		}
		if (BillAddressCity == null)
		{
			Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[19].Value = BillAddressCity;
		}
		if (BillAddressState == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = BillAddressState;
		}
		if (BillAddressProvince == null)
		{
			Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[21].Value = BillAddressProvince;
		}
		if (BillAddressCounty == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = BillAddressCounty;
		}
		if (BillAddressPostalCode == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = BillAddressPostalCode;
		}
		if (BillAddressCountry == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = BillAddressCountry;
		}
		if (BillAddressNote == null)
		{
			Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[25].Value = BillAddressNote;
		}
		if (BillAddressBlockAddr1 == null)
		{
			Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[26].Value = BillAddressBlockAddr1;
		}
		if (BillAddressBlockAddr2 == null)
		{
			Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[27].Value = BillAddressBlockAddr2;
		}
		if (BillAddressBlockAddr3 == null)
		{
			Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[28].Value = BillAddressBlockAddr3;
		}
		if (BillAddressBlockAddr4 == null)
		{
			Adapter.InsertCommand.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[29].Value = BillAddressBlockAddr4;
		}
		if (BillAddressBlockAddr5 == null)
		{
			Adapter.InsertCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[30].Value = BillAddressBlockAddr5;
		}
		if (ShipAddressAddr1 == null)
		{
			Adapter.InsertCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[31].Value = ShipAddressAddr1;
		}
		if (ShipAddressAddr2 == null)
		{
			Adapter.InsertCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[32].Value = ShipAddressAddr2;
		}
		if (ShipAddressAddr3 == null)
		{
			Adapter.InsertCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[33].Value = ShipAddressAddr3;
		}
		if (ShipAddressAddr4 == null)
		{
			Adapter.InsertCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[34].Value = ShipAddressAddr4;
		}
		if (ShipAddressAddr5 == null)
		{
			Adapter.InsertCommand.Parameters[35].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[35].Value = ShipAddressAddr5;
		}
		if (ShipAddressCity == null)
		{
			Adapter.InsertCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[36].Value = ShipAddressCity;
		}
		if (ShipAddressState == null)
		{
			Adapter.InsertCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[37].Value = ShipAddressState;
		}
		if (ShipAddressProvince == null)
		{
			Adapter.InsertCommand.Parameters[38].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[38].Value = ShipAddressProvince;
		}
		if (ShipAddressCounty == null)
		{
			Adapter.InsertCommand.Parameters[39].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[39].Value = ShipAddressCounty;
		}
		if (ShipAddressPostalCode == null)
		{
			Adapter.InsertCommand.Parameters[40].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[40].Value = ShipAddressPostalCode;
		}
		if (ShipAddressCountry == null)
		{
			Adapter.InsertCommand.Parameters[41].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[41].Value = ShipAddressCountry;
		}
		if (ShipAddressNote == null)
		{
			Adapter.InsertCommand.Parameters[42].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[42].Value = ShipAddressNote;
		}
		if (ShipAddressBlockAddr1 == null)
		{
			Adapter.InsertCommand.Parameters[43].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[43].Value = ShipAddressBlockAddr1;
		}
		if (ShipAddressBlockAddr2 == null)
		{
			Adapter.InsertCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[44].Value = ShipAddressBlockAddr2;
		}
		if (ShipAddressBlockAddr3 == null)
		{
			Adapter.InsertCommand.Parameters[45].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[45].Value = ShipAddressBlockAddr3;
		}
		if (ShipAddressBlockAddr4 == null)
		{
			Adapter.InsertCommand.Parameters[46].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[46].Value = ShipAddressBlockAddr4;
		}
		if (ShipAddressBlockAddr5 == null)
		{
			Adapter.InsertCommand.Parameters[47].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[47].Value = ShipAddressBlockAddr5;
		}
		if (PONumber == null)
		{
			Adapter.InsertCommand.Parameters[48].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[48].Value = PONumber;
		}
		if (TermsRefListID == null)
		{
			Adapter.InsertCommand.Parameters[49].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[49].Value = TermsRefListID;
		}
		if (TermsRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[50].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[50].Value = TermsRefFullName;
		}
		if (DueDate.HasValue)
		{
			Adapter.InsertCommand.Parameters[51].Value = DueDate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[51].Value = DBNull.Value;
		}
		if (SalesRepRefListID == null)
		{
			Adapter.InsertCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[52].Value = SalesRepRefListID;
		}
		if (SalesRepRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[53].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[53].Value = SalesRepRefFullName;
		}
		if (FOB == null)
		{
			Adapter.InsertCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[54].Value = FOB;
		}
		if (ShipDate.HasValue)
		{
			Adapter.InsertCommand.Parameters[55].Value = ShipDate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[55].Value = DBNull.Value;
		}
		if (ShipMethodRefListID == null)
		{
			Adapter.InsertCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[56].Value = ShipMethodRefListID;
		}
		if (ShipMethodRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[57].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[57].Value = ShipMethodRefFullName;
		}
		if (Subtotal.HasValue)
		{
			Adapter.InsertCommand.Parameters[58].Value = Subtotal.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[58].Value = DBNull.Value;
		}
		if (ItemSalesTaxRefListID == null)
		{
			Adapter.InsertCommand.Parameters[59].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[59].Value = ItemSalesTaxRefListID;
		}
		if (ItemSalesTaxRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[60].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[60].Value = ItemSalesTaxRefFullName;
		}
		if (SalesTaxPercentage.HasValue)
		{
			Adapter.InsertCommand.Parameters[61].Value = SalesTaxPercentage.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[61].Value = DBNull.Value;
		}
		if (SalesTaxTotal.HasValue)
		{
			Adapter.InsertCommand.Parameters[62].Value = SalesTaxTotal.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[62].Value = DBNull.Value;
		}
		if (TotalAmount.HasValue)
		{
			Adapter.InsertCommand.Parameters[63].Value = TotalAmount.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[63].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[64].Value = IsManuallyClosed;
		Adapter.InsertCommand.Parameters[65].Value = IsFullyInvoiced;
		if (Memo == null)
		{
			Adapter.InsertCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[66].Value = Memo;
		}
		if (CustomerMsgRefListID == null)
		{
			Adapter.InsertCommand.Parameters[67].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[67].Value = CustomerMsgRefListID;
		}
		if (CustomerMsgRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[68].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[68].Value = CustomerMsgRefFullName;
		}
		Adapter.InsertCommand.Parameters[69].Value = IsToBePrinted;
		Adapter.InsertCommand.Parameters[70].Value = IsToBeEmailed;
		Adapter.InsertCommand.Parameters[71].Value = IsTaxIncluded;
		if (CustomerSalesTaxCodeRefListID == null)
		{
			Adapter.InsertCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[72].Value = CustomerSalesTaxCodeRefListID;
		}
		if (CustomerSalesTaxCodeRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[73].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[73].Value = CustomerSalesTaxCodeRefFullName;
		}
		if (CustomerTaxCodeRefListID == null)
		{
			Adapter.InsertCommand.Parameters[74].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[74].Value = CustomerTaxCodeRefListID;
		}
		if (CustomFieldOther == null)
		{
			Adapter.InsertCommand.Parameters[75].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[75].Value = CustomFieldOther;
		}
		if (SalesOrderLineSeqNo.HasValue)
		{
			Adapter.InsertCommand.Parameters[76].Value = SalesOrderLineSeqNo.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[76].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupTxnLineID == null)
		{
			Adapter.InsertCommand.Parameters[77].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[77].Value = SalesOrderLineGroupTxnLineID;
		}
		if (SalesOrderLineGroupItemGroupRefListID == null)
		{
			Adapter.InsertCommand.Parameters[78].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[78].Value = SalesOrderLineGroupItemGroupRefListID;
		}
		if (SalesOrderLineGroupItemGroupRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[79].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[79].Value = SalesOrderLineGroupItemGroupRefFullName;
		}
		if (SalesOrderLineGroupDesc == null)
		{
			Adapter.InsertCommand.Parameters[80].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[80].Value = SalesOrderLineGroupDesc;
		}
		if (SalesOrderLineGroupQuantity.HasValue)
		{
			Adapter.InsertCommand.Parameters[81].Value = SalesOrderLineGroupQuantity.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[81].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupUnitOfMeasure == null)
		{
			Adapter.InsertCommand.Parameters[82].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[82].Value = SalesOrderLineGroupUnitOfMeasure;
		}
		if (SalesOrderLineGroupOverrideUOMSetRefListID == null)
		{
			Adapter.InsertCommand.Parameters[83].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[83].Value = SalesOrderLineGroupOverrideUOMSetRefListID;
		}
		if (SalesOrderLineGroupOverrideUOMSetRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[84].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[84].Value = SalesOrderLineGroupOverrideUOMSetRefFullName;
		}
		Adapter.InsertCommand.Parameters[85].Value = SalesOrderLineGroupIsPrintItemsInGroup;
		if (SalesOrderLineGroupTotalAmount.HasValue)
		{
			Adapter.InsertCommand.Parameters[86].Value = SalesOrderLineGroupTotalAmount.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[86].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupSeqNo.HasValue)
		{
			Adapter.InsertCommand.Parameters[87].Value = SalesOrderLineGroupSeqNo.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[87].Value = DBNull.Value;
		}
		if (SalesOrderLineTxnLineID == null)
		{
			Adapter.InsertCommand.Parameters[88].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[88].Value = SalesOrderLineTxnLineID;
		}
		if (SalesOrderLineItemRefListID == null)
		{
			Adapter.InsertCommand.Parameters[89].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[89].Value = SalesOrderLineItemRefListID;
		}
		if (SalesOrderLineItemRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[90].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[90].Value = SalesOrderLineItemRefFullName;
		}
		if (SalesOrderLineDesc == null)
		{
			Adapter.InsertCommand.Parameters[91].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[91].Value = SalesOrderLineDesc;
		}
		if (SalesOrderLineQuantity.HasValue)
		{
			Adapter.InsertCommand.Parameters[92].Value = SalesOrderLineQuantity.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[92].Value = DBNull.Value;
		}
		if (SalesOrderLineUnitOfMeasure == null)
		{
			Adapter.InsertCommand.Parameters[93].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[93].Value = SalesOrderLineUnitOfMeasure;
		}
		if (SalesOrderLineOverrideUOMSetRefListID == null)
		{
			Adapter.InsertCommand.Parameters[94].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[94].Value = SalesOrderLineOverrideUOMSetRefListID;
		}
		if (SalesOrderLineOverrideUOMSetRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[95].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[95].Value = SalesOrderLineOverrideUOMSetRefFullName;
		}
		if (SalesOrderLineRate.HasValue)
		{
			Adapter.InsertCommand.Parameters[96].Value = SalesOrderLineRate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[96].Value = DBNull.Value;
		}
		if (SalesOrderLineRatePercent.HasValue)
		{
			Adapter.InsertCommand.Parameters[97].Value = SalesOrderLineRatePercent.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[97].Value = DBNull.Value;
		}
		if (SalesOrderLinePriceLevelRefListID == null)
		{
			Adapter.InsertCommand.Parameters[98].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[98].Value = SalesOrderLinePriceLevelRefListID;
		}
		if (SalesOrderLinePriceLevelRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[99].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[99].Value = SalesOrderLinePriceLevelRefFullName;
		}
		if (SalesOrderLineClassRefListID == null)
		{
			Adapter.InsertCommand.Parameters[100].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[100].Value = SalesOrderLineClassRefListID;
		}
		if (SalesOrderLineClassRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[101].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[101].Value = SalesOrderLineClassRefFullName;
		}
		if (SalesOrderLineAmount.HasValue)
		{
			Adapter.InsertCommand.Parameters[102].Value = SalesOrderLineAmount.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[102].Value = DBNull.Value;
		}
		if (SalesOrderInventorySiteRefListID == null)
		{
			Adapter.InsertCommand.Parameters[103].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[103].Value = SalesOrderInventorySiteRefListID;
		}
		if (SalesOrderInventorySiteRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[104].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[104].Value = SalesOrderInventorySiteRefFullName;
		}
		if (SalesOrderLineSerialNumber == null)
		{
			Adapter.InsertCommand.Parameters[105].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[105].Value = SalesOrderLineSerialNumber;
		}
		if (SalesOrderLineLotNumber == null)
		{
			Adapter.InsertCommand.Parameters[106].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[106].Value = SalesOrderLineLotNumber;
		}
		if (SalesOrderLineTaxAmount.HasValue)
		{
			Adapter.InsertCommand.Parameters[107].Value = SalesOrderLineTaxAmount.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[107].Value = DBNull.Value;
		}
		if (SalesOrderLineSalesTaxCodeRefListID == null)
		{
			Adapter.InsertCommand.Parameters[108].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[108].Value = SalesOrderLineSalesTaxCodeRefListID;
		}
		if (SalesOrderLineSalesTaxCodeRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[109].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[109].Value = SalesOrderLineSalesTaxCodeRefFullName;
		}
		if (SalesOrderLineTaxCodeRefListID == null)
		{
			Adapter.InsertCommand.Parameters[110].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[110].Value = SalesOrderLineTaxCodeRefListID;
		}
		if (SalesOrderLineTaxCodeRefFullName == null)
		{
			Adapter.InsertCommand.Parameters[111].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[111].Value = SalesOrderLineTaxCodeRefFullName;
		}
		if (SalesOrderLineInvoiced.HasValue)
		{
			Adapter.InsertCommand.Parameters[112].Value = SalesOrderLineInvoiced.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[112].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[113].Value = SalesOrderLineIsManuallyClosed;
		if (CustomFieldSalesOrderLineOther1 == null)
		{
			Adapter.InsertCommand.Parameters[114].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[114].Value = CustomFieldSalesOrderLineOther1;
		}
		if (CustomFieldSalesOrderLineOther2 == null)
		{
			Adapter.InsertCommand.Parameters[115].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[115].Value = CustomFieldSalesOrderLineOther2;
		}
		if (Tax1Total.HasValue)
		{
			Adapter.InsertCommand.Parameters[116].Value = Tax1Total.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[116].Value = DBNull.Value;
		}
		if (Tax2Total.HasValue)
		{
			Adapter.InsertCommand.Parameters[117].Value = Tax2Total.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[117].Value = DBNull.Value;
		}
		if (ExchangeRate.HasValue)
		{
			Adapter.InsertCommand.Parameters[118].Value = ExchangeRate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[118].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[119].Value = AmountIncludesVAT;
		Adapter.InsertCommand.Parameters[120].Value = FQSaveToCache;
		if (FQPrimaryKey == null)
		{
			throw new ArgumentNullException("FQPrimaryKey");
		}
		Adapter.InsertCommand.Parameters[121].Value = FQPrimaryKey;
		if (FQTxnLinkKey == null)
		{
			Adapter.InsertCommand.Parameters[122].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[122].Value = FQTxnLinkKey;
		}
		if (CustomFieldSalesOrderLineCycleCount == null)
		{
			Adapter.InsertCommand.Parameters[123].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[123].Value = CustomFieldSalesOrderLineCycleCount;
		}
		if (CustomFieldSalesOrderLineGroupCycleCount == null)
		{
			Adapter.InsertCommand.Parameters[124].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[124].Value = CustomFieldSalesOrderLineGroupCycleCount;
		}
		if (CustomFieldSalesOrderLineGroupLineCycleCount == null)
		{
			Adapter.InsertCommand.Parameters[125].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[125].Value = CustomFieldSalesOrderLineGroupLineCycleCount;
		}
		if (CustomFieldCollect == null)
		{
			Adapter.InsertCommand.Parameters[126].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[126].Value = CustomFieldCollect;
		}
		if (CustomFieldPPDCOL == null)
		{
			Adapter.InsertCommand.Parameters[127].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[127].Value = CustomFieldPPDCOL;
		}
		if (CustomFieldRep == null)
		{
			Adapter.InsertCommand.Parameters[128].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[128].Value = CustomFieldRep;
		}
		if (CustomFieldShipDate == null)
		{
			Adapter.InsertCommand.Parameters[129].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[129].Value = CustomFieldShipDate;
		}
		if (CustomFieldShipVia == null)
		{
			Adapter.InsertCommand.Parameters[130].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[130].Value = CustomFieldShipVia;
		}
		ConnectionState previousConnectionState = Adapter.InsertCommand.Connection.State;
		if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			return Adapter.InsertCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.InsertCommand.Connection.Close();
			}
		}
	}

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string TxnID, DateTime? TimeCreated, DateTime? TimeModified, string EditSequence, int? TxnNumber, string CustomerRefListID, string CustomerRefFullName, string ClassRefListID, string ClassRefFullName, string TemplateRefListID, string TemplateRefFullName, DateTime? TxnDate, string TxnDateMacro, string RefNumber, string BillAddressAddr1, string BillAddressAddr2, string BillAddressAddr3, string BillAddressAddr4, string BillAddressAddr5, string BillAddressCity, string BillAddressState, string BillAddressProvince, string BillAddressCounty, string BillAddressPostalCode, string BillAddressCountry, string BillAddressNote, string BillAddressBlockAddr1, string BillAddressBlockAddr2, string BillAddressBlockAddr3, string BillAddressBlockAddr4, string BillAddressBlockAddr5, string ShipAddressAddr1, string ShipAddressAddr2, string ShipAddressAddr3, string ShipAddressAddr4, string ShipAddressAddr5, string ShipAddressCity, string ShipAddressState, string ShipAddressProvince, string ShipAddressCounty, string ShipAddressPostalCode, string ShipAddressCountry, string ShipAddressNote, string ShipAddressBlockAddr1, string ShipAddressBlockAddr2, string ShipAddressBlockAddr3, string ShipAddressBlockAddr4, string ShipAddressBlockAddr5, string PONumber, string TermsRefListID, string TermsRefFullName, DateTime? DueDate, string SalesRepRefListID, string SalesRepRefFullName, string FOB, DateTime? ShipDate, string ShipMethodRefListID, string ShipMethodRefFullName, decimal? Subtotal, string ItemSalesTaxRefListID, string ItemSalesTaxRefFullName, decimal? SalesTaxPercentage, decimal? SalesTaxTotal, decimal? TotalAmount, bool IsManuallyClosed, bool IsFullyInvoiced, string Memo, string CustomerMsgRefListID, string CustomerMsgRefFullName, bool IsToBePrinted, bool IsToBeEmailed, bool IsTaxIncluded, string CustomerSalesTaxCodeRefListID, string CustomerSalesTaxCodeRefFullName, string CustomerTaxCodeRefListID, string CustomFieldOther, int? SalesOrderLineSeqNo, string SalesOrderLineGroupTxnLineID, string SalesOrderLineGroupItemGroupRefListID, string SalesOrderLineGroupItemGroupRefFullName, string SalesOrderLineGroupDesc, decimal? SalesOrderLineGroupQuantity, string SalesOrderLineGroupUnitOfMeasure, string SalesOrderLineGroupOverrideUOMSetRefListID, string SalesOrderLineGroupOverrideUOMSetRefFullName, bool SalesOrderLineGroupIsPrintItemsInGroup, decimal? SalesOrderLineGroupTotalAmount, int? SalesOrderLineGroupSeqNo, string SalesOrderLineTxnLineID, string SalesOrderLineItemRefListID, string SalesOrderLineItemRefFullName, string SalesOrderLineDesc, decimal? SalesOrderLineQuantity, string SalesOrderLineUnitOfMeasure, string SalesOrderLineOverrideUOMSetRefListID, string SalesOrderLineOverrideUOMSetRefFullName, decimal? SalesOrderLineRate, decimal? SalesOrderLineRatePercent, string SalesOrderLinePriceLevelRefListID, string SalesOrderLinePriceLevelRefFullName, string SalesOrderLineClassRefListID, string SalesOrderLineClassRefFullName, decimal? SalesOrderLineAmount, string SalesOrderInventorySiteRefListID, string SalesOrderInventorySiteRefFullName, string SalesOrderLineSerialNumber, string SalesOrderLineLotNumber, decimal? SalesOrderLineTaxAmount, string SalesOrderLineSalesTaxCodeRefListID, string SalesOrderLineSalesTaxCodeRefFullName, string SalesOrderLineTaxCodeRefListID, string SalesOrderLineTaxCodeRefFullName, decimal? SalesOrderLineInvoiced, bool SalesOrderLineIsManuallyClosed, string CustomFieldSalesOrderLineOther1, string CustomFieldSalesOrderLineOther2, decimal? Tax1Total, decimal? Tax2Total, decimal? ExchangeRate, bool AmountIncludesVAT, bool FQSaveToCache, string FQPrimaryKey, string FQTxnLinkKey, string CustomFieldSalesOrderLineCycleCount, string CustomFieldSalesOrderLineGroupCycleCount, string CustomFieldSalesOrderLineGroupLineCycleCount, string CustomFieldCollect, string CustomFieldPPDCOL, string CustomFieldRep, string CustomFieldShipDate, string CustomFieldShipVia, string Original_TxnID, DateTime? Original_TimeCreated, DateTime? Original_TimeModified, string Original_EditSequence, int? Original_TxnNumber, string Original_CustomerRefListID, string Original_CustomerRefFullName, string Original_ClassRefListID, string Original_ClassRefFullName, string Original_TemplateRefListID, string Original_TemplateRefFullName, DateTime? Original_TxnDate, string Original_TxnDateMacro, string Original_RefNumber, string Original_BillAddressAddr1, string Original_BillAddressAddr2, string Original_BillAddressAddr3, string Original_BillAddressAddr4, string Original_BillAddressAddr5, string Original_BillAddressCity, string Original_BillAddressState, string Original_BillAddressProvince, string Original_BillAddressCounty, string Original_BillAddressPostalCode, string Original_BillAddressCountry, string Original_BillAddressNote, string Original_BillAddressBlockAddr1, string Original_BillAddressBlockAddr2, string Original_BillAddressBlockAddr3, string Original_BillAddressBlockAddr4, string Original_BillAddressBlockAddr5, string Original_ShipAddressAddr1, string Original_ShipAddressAddr2, string Original_ShipAddressAddr3, string Original_ShipAddressAddr4, string Original_ShipAddressAddr5, string Original_ShipAddressCity, string Original_ShipAddressState, string Original_ShipAddressProvince, string Original_ShipAddressCounty, string Original_ShipAddressPostalCode, string Original_ShipAddressCountry, string Original_ShipAddressNote, string Original_ShipAddressBlockAddr1, string Original_ShipAddressBlockAddr2, string Original_ShipAddressBlockAddr3, string Original_ShipAddressBlockAddr4, string Original_ShipAddressBlockAddr5, string Original_PONumber, string Original_TermsRefListID, string Original_TermsRefFullName, DateTime? Original_DueDate, string Original_SalesRepRefListID, string Original_SalesRepRefFullName, string Original_FOB, DateTime? Original_ShipDate, string Original_ShipMethodRefListID, string Original_ShipMethodRefFullName, decimal? Original_Subtotal, string Original_ItemSalesTaxRefListID, string Original_ItemSalesTaxRefFullName, decimal? Original_SalesTaxPercentage, decimal? Original_SalesTaxTotal, decimal? Original_TotalAmount, bool Original_IsManuallyClosed, bool Original_IsFullyInvoiced, string Original_CustomerMsgRefListID, string Original_CustomerMsgRefFullName, bool Original_IsToBePrinted, bool Original_IsToBeEmailed, bool Original_IsTaxIncluded, string Original_CustomerSalesTaxCodeRefListID, string Original_CustomerSalesTaxCodeRefFullName, string Original_CustomerTaxCodeRefListID, string Original_CustomFieldOther, int? Original_SalesOrderLineSeqNo, string Original_SalesOrderLineGroupTxnLineID, string Original_SalesOrderLineGroupItemGroupRefListID, string Original_SalesOrderLineGroupItemGroupRefFullName, decimal? Original_SalesOrderLineGroupQuantity, string Original_SalesOrderLineGroupUnitOfMeasure, string Original_SalesOrderLineGroupOverrideUOMSetRefListID, string Original_SalesOrderLineGroupOverrideUOMSetRefFullName, bool Original_SalesOrderLineGroupIsPrintItemsInGroup, decimal? Original_SalesOrderLineGroupTotalAmount, int? Original_SalesOrderLineGroupSeqNo, string Original_SalesOrderLineTxnLineID, string Original_SalesOrderLineItemRefListID, string Original_SalesOrderLineItemRefFullName, decimal? Original_SalesOrderLineQuantity, string Original_SalesOrderLineUnitOfMeasure, string Original_SalesOrderLineOverrideUOMSetRefListID, string Original_SalesOrderLineOverrideUOMSetRefFullName, decimal? Original_SalesOrderLineRate, decimal? Original_SalesOrderLineRatePercent, string Original_SalesOrderLinePriceLevelRefListID, string Original_SalesOrderLinePriceLevelRefFullName, string Original_SalesOrderLineClassRefListID, string Original_SalesOrderLineClassRefFullName, decimal? Original_SalesOrderLineAmount, string Original_SalesOrderInventorySiteRefListID, string Original_SalesOrderInventorySiteRefFullName, string Original_SalesOrderLineLotNumber, decimal? Original_SalesOrderLineTaxAmount, string Original_SalesOrderLineSalesTaxCodeRefListID, string Original_SalesOrderLineSalesTaxCodeRefFullName, string Original_SalesOrderLineTaxCodeRefListID, string Original_SalesOrderLineTaxCodeRefFullName, decimal? Original_SalesOrderLineInvoiced, bool Original_SalesOrderLineIsManuallyClosed, string Original_CustomFieldSalesOrderLineOther1, string Original_CustomFieldSalesOrderLineOther2, decimal? Original_Tax1Total, decimal? Original_Tax2Total, decimal? Original_ExchangeRate, bool Original_AmountIncludesVAT, bool Original_FQSaveToCache, string Original_FQPrimaryKey, string Original_FQTxnLinkKey, string Original_CustomFieldSalesOrderLineCycleCount, string Original_CustomFieldSalesOrderLineGroupCycleCount, string Original_CustomFieldSalesOrderLineGroupLineCycleCount, string Original_CustomFieldCollect, string Original_CustomFieldPPDCOL, string Original_CustomFieldRep, string Original_CustomFieldShipDate, string Original_CustomFieldShipVia)
	{
		if (TxnID == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = TxnID;
		}
		if (TimeCreated.HasValue)
		{
			Adapter.UpdateCommand.Parameters[1].Value = TimeCreated.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		if (TimeModified.HasValue)
		{
			Adapter.UpdateCommand.Parameters[2].Value = TimeModified.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		if (EditSequence == null)
		{
			throw new ArgumentNullException("EditSequence");
		}
		Adapter.UpdateCommand.Parameters[3].Value = EditSequence;
		if (TxnNumber.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = TxnNumber.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (CustomerRefListID == null)
		{
			throw new ArgumentNullException("CustomerRefListID");
		}
		Adapter.UpdateCommand.Parameters[5].Value = CustomerRefListID;
		if (CustomerRefFullName == null)
		{
			throw new ArgumentNullException("CustomerRefFullName");
		}
		Adapter.UpdateCommand.Parameters[6].Value = CustomerRefFullName;
		if (ClassRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = ClassRefListID;
		}
		if (ClassRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = ClassRefFullName;
		}
		if (TemplateRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = TemplateRefListID;
		}
		if (TemplateRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = TemplateRefFullName;
		}
		if (TxnDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[11].Value = TxnDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		if (TxnDateMacro == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = TxnDateMacro;
		}
		if (RefNumber == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = RefNumber;
		}
		if (BillAddressAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = BillAddressAddr1;
		}
		if (BillAddressAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = BillAddressAddr2;
		}
		if (BillAddressAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = BillAddressAddr3;
		}
		if (BillAddressAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = BillAddressAddr4;
		}
		if (BillAddressAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = BillAddressAddr5;
		}
		if (BillAddressCity == null)
		{
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = BillAddressCity;
		}
		if (BillAddressState == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = BillAddressState;
		}
		if (BillAddressProvince == null)
		{
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = BillAddressProvince;
		}
		if (BillAddressCounty == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = BillAddressCounty;
		}
		if (BillAddressPostalCode == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = BillAddressPostalCode;
		}
		if (BillAddressCountry == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = BillAddressCountry;
		}
		if (BillAddressNote == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = BillAddressNote;
		}
		if (BillAddressBlockAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = BillAddressBlockAddr1;
		}
		if (BillAddressBlockAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = BillAddressBlockAddr2;
		}
		if (BillAddressBlockAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[28].Value = BillAddressBlockAddr3;
		}
		if (BillAddressBlockAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = BillAddressBlockAddr4;
		}
		if (BillAddressBlockAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[30].Value = BillAddressBlockAddr5;
		}
		if (ShipAddressAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = ShipAddressAddr1;
		}
		if (ShipAddressAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[32].Value = ShipAddressAddr2;
		}
		if (ShipAddressAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = ShipAddressAddr3;
		}
		if (ShipAddressAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[34].Value = ShipAddressAddr4;
		}
		if (ShipAddressAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[35].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[35].Value = ShipAddressAddr5;
		}
		if (ShipAddressCity == null)
		{
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[36].Value = ShipAddressCity;
		}
		if (ShipAddressState == null)
		{
			Adapter.UpdateCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[37].Value = ShipAddressState;
		}
		if (ShipAddressProvince == null)
		{
			Adapter.UpdateCommand.Parameters[38].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[38].Value = ShipAddressProvince;
		}
		if (ShipAddressCounty == null)
		{
			Adapter.UpdateCommand.Parameters[39].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = ShipAddressCounty;
		}
		if (ShipAddressPostalCode == null)
		{
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[40].Value = ShipAddressPostalCode;
		}
		if (ShipAddressCountry == null)
		{
			Adapter.UpdateCommand.Parameters[41].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = ShipAddressCountry;
		}
		if (ShipAddressNote == null)
		{
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[42].Value = ShipAddressNote;
		}
		if (ShipAddressBlockAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[43].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = ShipAddressBlockAddr1;
		}
		if (ShipAddressBlockAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[44].Value = ShipAddressBlockAddr2;
		}
		if (ShipAddressBlockAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[45].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = ShipAddressBlockAddr3;
		}
		if (ShipAddressBlockAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[46].Value = ShipAddressBlockAddr4;
		}
		if (ShipAddressBlockAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[47].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[47].Value = ShipAddressBlockAddr5;
		}
		if (PONumber == null)
		{
			Adapter.UpdateCommand.Parameters[48].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[48].Value = PONumber;
		}
		if (TermsRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[49].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[49].Value = TermsRefListID;
		}
		if (TermsRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[50].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[50].Value = TermsRefFullName;
		}
		if (DueDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[51].Value = DueDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[51].Value = DBNull.Value;
		}
		if (SalesRepRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[52].Value = SalesRepRefListID;
		}
		if (SalesRepRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[53].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[53].Value = SalesRepRefFullName;
		}
		if (FOB == null)
		{
			Adapter.UpdateCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[54].Value = FOB;
		}
		if (ShipDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[55].Value = ShipDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[55].Value = DBNull.Value;
		}
		if (ShipMethodRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[56].Value = ShipMethodRefListID;
		}
		if (ShipMethodRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[57].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[57].Value = ShipMethodRefFullName;
		}
		if (Subtotal.HasValue)
		{
			Adapter.UpdateCommand.Parameters[58].Value = Subtotal.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[58].Value = DBNull.Value;
		}
		if (ItemSalesTaxRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[59].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[59].Value = ItemSalesTaxRefListID;
		}
		if (ItemSalesTaxRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[60].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[60].Value = ItemSalesTaxRefFullName;
		}
		if (SalesTaxPercentage.HasValue)
		{
			Adapter.UpdateCommand.Parameters[61].Value = SalesTaxPercentage.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[61].Value = DBNull.Value;
		}
		if (SalesTaxTotal.HasValue)
		{
			Adapter.UpdateCommand.Parameters[62].Value = SalesTaxTotal.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[62].Value = DBNull.Value;
		}
		if (TotalAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[63].Value = TotalAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[63].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[64].Value = IsManuallyClosed;
		Adapter.UpdateCommand.Parameters[65].Value = IsFullyInvoiced;
		if (Memo == null)
		{
			Adapter.UpdateCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[66].Value = Memo;
		}
		if (CustomerMsgRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[67].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[67].Value = CustomerMsgRefListID;
		}
		if (CustomerMsgRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[68].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[68].Value = CustomerMsgRefFullName;
		}
		Adapter.UpdateCommand.Parameters[69].Value = IsToBePrinted;
		Adapter.UpdateCommand.Parameters[70].Value = IsToBeEmailed;
		Adapter.UpdateCommand.Parameters[71].Value = IsTaxIncluded;
		if (CustomerSalesTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[72].Value = CustomerSalesTaxCodeRefListID;
		}
		if (CustomerSalesTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[73].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[73].Value = CustomerSalesTaxCodeRefFullName;
		}
		if (CustomerTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[74].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[74].Value = CustomerTaxCodeRefListID;
		}
		if (CustomFieldOther == null)
		{
			Adapter.UpdateCommand.Parameters[75].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[75].Value = CustomFieldOther;
		}
		if (SalesOrderLineSeqNo.HasValue)
		{
			Adapter.UpdateCommand.Parameters[76].Value = SalesOrderLineSeqNo.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[76].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupTxnLineID == null)
		{
			Adapter.UpdateCommand.Parameters[77].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[77].Value = SalesOrderLineGroupTxnLineID;
		}
		if (SalesOrderLineGroupItemGroupRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[78].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[78].Value = SalesOrderLineGroupItemGroupRefListID;
		}
		if (SalesOrderLineGroupItemGroupRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[79].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[79].Value = SalesOrderLineGroupItemGroupRefFullName;
		}
		if (SalesOrderLineGroupDesc == null)
		{
			Adapter.UpdateCommand.Parameters[80].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[80].Value = SalesOrderLineGroupDesc;
		}
		if (SalesOrderLineGroupQuantity.HasValue)
		{
			Adapter.UpdateCommand.Parameters[81].Value = SalesOrderLineGroupQuantity.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[81].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupUnitOfMeasure == null)
		{
			Adapter.UpdateCommand.Parameters[82].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[82].Value = SalesOrderLineGroupUnitOfMeasure;
		}
		if (SalesOrderLineGroupOverrideUOMSetRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[83].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[83].Value = SalesOrderLineGroupOverrideUOMSetRefListID;
		}
		if (SalesOrderLineGroupOverrideUOMSetRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[84].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[84].Value = SalesOrderLineGroupOverrideUOMSetRefFullName;
		}
		Adapter.UpdateCommand.Parameters[85].Value = SalesOrderLineGroupIsPrintItemsInGroup;
		if (SalesOrderLineGroupTotalAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[86].Value = SalesOrderLineGroupTotalAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[86].Value = DBNull.Value;
		}
		if (SalesOrderLineGroupSeqNo.HasValue)
		{
			Adapter.UpdateCommand.Parameters[87].Value = SalesOrderLineGroupSeqNo.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[87].Value = DBNull.Value;
		}
		if (SalesOrderLineTxnLineID == null)
		{
			Adapter.UpdateCommand.Parameters[88].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[88].Value = SalesOrderLineTxnLineID;
		}
		if (SalesOrderLineItemRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[89].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[89].Value = SalesOrderLineItemRefListID;
		}
		if (SalesOrderLineItemRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[90].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[90].Value = SalesOrderLineItemRefFullName;
		}
		if (SalesOrderLineDesc == null)
		{
			Adapter.UpdateCommand.Parameters[91].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[91].Value = SalesOrderLineDesc;
		}
		if (SalesOrderLineQuantity.HasValue)
		{
			Adapter.UpdateCommand.Parameters[92].Value = SalesOrderLineQuantity.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[92].Value = DBNull.Value;
		}
		if (SalesOrderLineUnitOfMeasure == null)
		{
			Adapter.UpdateCommand.Parameters[93].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[93].Value = SalesOrderLineUnitOfMeasure;
		}
		if (SalesOrderLineOverrideUOMSetRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[94].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[94].Value = SalesOrderLineOverrideUOMSetRefListID;
		}
		if (SalesOrderLineOverrideUOMSetRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[95].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[95].Value = SalesOrderLineOverrideUOMSetRefFullName;
		}
		if (SalesOrderLineRate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[96].Value = SalesOrderLineRate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[96].Value = DBNull.Value;
		}
		if (SalesOrderLineRatePercent.HasValue)
		{
			Adapter.UpdateCommand.Parameters[97].Value = SalesOrderLineRatePercent.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[97].Value = DBNull.Value;
		}
		if (SalesOrderLinePriceLevelRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[98].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[98].Value = SalesOrderLinePriceLevelRefListID;
		}
		if (SalesOrderLinePriceLevelRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[99].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[99].Value = SalesOrderLinePriceLevelRefFullName;
		}
		if (SalesOrderLineClassRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[100].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[100].Value = SalesOrderLineClassRefListID;
		}
		if (SalesOrderLineClassRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[101].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[101].Value = SalesOrderLineClassRefFullName;
		}
		if (SalesOrderLineAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[102].Value = SalesOrderLineAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[102].Value = DBNull.Value;
		}
		if (SalesOrderInventorySiteRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[103].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[103].Value = SalesOrderInventorySiteRefListID;
		}
		if (SalesOrderInventorySiteRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[104].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[104].Value = SalesOrderInventorySiteRefFullName;
		}
		if (SalesOrderLineSerialNumber == null)
		{
			Adapter.UpdateCommand.Parameters[105].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[105].Value = SalesOrderLineSerialNumber;
		}
		if (SalesOrderLineLotNumber == null)
		{
			Adapter.UpdateCommand.Parameters[106].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[106].Value = SalesOrderLineLotNumber;
		}
		if (SalesOrderLineTaxAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[107].Value = SalesOrderLineTaxAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[107].Value = DBNull.Value;
		}
		if (SalesOrderLineSalesTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[108].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[108].Value = SalesOrderLineSalesTaxCodeRefListID;
		}
		if (SalesOrderLineSalesTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[109].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[109].Value = SalesOrderLineSalesTaxCodeRefFullName;
		}
		if (SalesOrderLineTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[110].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[110].Value = SalesOrderLineTaxCodeRefListID;
		}
		if (SalesOrderLineTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[111].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[111].Value = SalesOrderLineTaxCodeRefFullName;
		}
		if (SalesOrderLineInvoiced.HasValue)
		{
			Adapter.UpdateCommand.Parameters[112].Value = SalesOrderLineInvoiced.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[112].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[113].Value = SalesOrderLineIsManuallyClosed;
		if (CustomFieldSalesOrderLineOther1 == null)
		{
			Adapter.UpdateCommand.Parameters[114].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[114].Value = CustomFieldSalesOrderLineOther1;
		}
		if (CustomFieldSalesOrderLineOther2 == null)
		{
			Adapter.UpdateCommand.Parameters[115].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[115].Value = CustomFieldSalesOrderLineOther2;
		}
		if (Tax1Total.HasValue)
		{
			Adapter.UpdateCommand.Parameters[116].Value = Tax1Total.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[116].Value = DBNull.Value;
		}
		if (Tax2Total.HasValue)
		{
			Adapter.UpdateCommand.Parameters[117].Value = Tax2Total.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[117].Value = DBNull.Value;
		}
		if (ExchangeRate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[118].Value = ExchangeRate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[118].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[119].Value = AmountIncludesVAT;
		Adapter.UpdateCommand.Parameters[120].Value = FQSaveToCache;
		if (FQPrimaryKey == null)
		{
			throw new ArgumentNullException("FQPrimaryKey");
		}
		Adapter.UpdateCommand.Parameters[121].Value = FQPrimaryKey;
		if (FQTxnLinkKey == null)
		{
			Adapter.UpdateCommand.Parameters[122].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[122].Value = FQTxnLinkKey;
		}
		if (CustomFieldSalesOrderLineCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[123].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[123].Value = CustomFieldSalesOrderLineCycleCount;
		}
		if (CustomFieldSalesOrderLineGroupCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[124].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[124].Value = CustomFieldSalesOrderLineGroupCycleCount;
		}
		if (CustomFieldSalesOrderLineGroupLineCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[125].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[125].Value = CustomFieldSalesOrderLineGroupLineCycleCount;
		}
		if (CustomFieldCollect == null)
		{
			Adapter.UpdateCommand.Parameters[126].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[126].Value = CustomFieldCollect;
		}
		if (CustomFieldPPDCOL == null)
		{
			Adapter.UpdateCommand.Parameters[127].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[127].Value = CustomFieldPPDCOL;
		}
		if (CustomFieldRep == null)
		{
			Adapter.UpdateCommand.Parameters[128].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[128].Value = CustomFieldRep;
		}
		if (CustomFieldShipDate == null)
		{
			Adapter.UpdateCommand.Parameters[129].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[129].Value = CustomFieldShipDate;
		}
		if (CustomFieldShipVia == null)
		{
			Adapter.UpdateCommand.Parameters[130].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[130].Value = CustomFieldShipVia;
		}
		if (Original_TxnID == null)
		{
			Adapter.UpdateCommand.Parameters[131].Value = 1;
			Adapter.UpdateCommand.Parameters[132].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[131].Value = 0;
			Adapter.UpdateCommand.Parameters[132].Value = Original_TxnID;
		}
		if (Original_TimeCreated.HasValue)
		{
			Adapter.UpdateCommand.Parameters[133].Value = 0;
			Adapter.UpdateCommand.Parameters[134].Value = Original_TimeCreated.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[133].Value = 1;
			Adapter.UpdateCommand.Parameters[134].Value = DBNull.Value;
		}
		if (Original_TimeModified.HasValue)
		{
			Adapter.UpdateCommand.Parameters[135].Value = 0;
			Adapter.UpdateCommand.Parameters[136].Value = Original_TimeModified.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[135].Value = 1;
			Adapter.UpdateCommand.Parameters[136].Value = DBNull.Value;
		}
		if (Original_EditSequence == null)
		{
			throw new ArgumentNullException("Original_EditSequence");
		}
		Adapter.UpdateCommand.Parameters[137].Value = 0;
		Adapter.UpdateCommand.Parameters[138].Value = Original_EditSequence;
		if (Original_TxnNumber.HasValue)
		{
			Adapter.UpdateCommand.Parameters[139].Value = 0;
			Adapter.UpdateCommand.Parameters[140].Value = Original_TxnNumber.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[139].Value = 1;
			Adapter.UpdateCommand.Parameters[140].Value = DBNull.Value;
		}
		if (Original_CustomerRefListID == null)
		{
			throw new ArgumentNullException("Original_CustomerRefListID");
		}
		Adapter.UpdateCommand.Parameters[141].Value = 0;
		Adapter.UpdateCommand.Parameters[142].Value = Original_CustomerRefListID;
		if (Original_CustomerRefFullName == null)
		{
			throw new ArgumentNullException("Original_CustomerRefFullName");
		}
		Adapter.UpdateCommand.Parameters[143].Value = 0;
		Adapter.UpdateCommand.Parameters[144].Value = Original_CustomerRefFullName;
		if (Original_ClassRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[145].Value = 1;
			Adapter.UpdateCommand.Parameters[146].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[145].Value = 0;
			Adapter.UpdateCommand.Parameters[146].Value = Original_ClassRefListID;
		}
		if (Original_ClassRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[147].Value = 1;
			Adapter.UpdateCommand.Parameters[148].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[147].Value = 0;
			Adapter.UpdateCommand.Parameters[148].Value = Original_ClassRefFullName;
		}
		if (Original_TemplateRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[149].Value = 1;
			Adapter.UpdateCommand.Parameters[150].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[149].Value = 0;
			Adapter.UpdateCommand.Parameters[150].Value = Original_TemplateRefListID;
		}
		if (Original_TemplateRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[151].Value = 1;
			Adapter.UpdateCommand.Parameters[152].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[151].Value = 0;
			Adapter.UpdateCommand.Parameters[152].Value = Original_TemplateRefFullName;
		}
		if (Original_TxnDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[153].Value = 0;
			Adapter.UpdateCommand.Parameters[154].Value = Original_TxnDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[153].Value = 1;
			Adapter.UpdateCommand.Parameters[154].Value = DBNull.Value;
		}
		if (Original_TxnDateMacro == null)
		{
			Adapter.UpdateCommand.Parameters[155].Value = 1;
			Adapter.UpdateCommand.Parameters[156].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[155].Value = 0;
			Adapter.UpdateCommand.Parameters[156].Value = Original_TxnDateMacro;
		}
		if (Original_RefNumber == null)
		{
			Adapter.UpdateCommand.Parameters[157].Value = 1;
			Adapter.UpdateCommand.Parameters[158].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[157].Value = 0;
			Adapter.UpdateCommand.Parameters[158].Value = Original_RefNumber;
		}
		if (Original_BillAddressAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[159].Value = 1;
			Adapter.UpdateCommand.Parameters[160].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[159].Value = 0;
			Adapter.UpdateCommand.Parameters[160].Value = Original_BillAddressAddr1;
		}
		if (Original_BillAddressAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[161].Value = 1;
			Adapter.UpdateCommand.Parameters[162].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[161].Value = 0;
			Adapter.UpdateCommand.Parameters[162].Value = Original_BillAddressAddr2;
		}
		if (Original_BillAddressAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[163].Value = 1;
			Adapter.UpdateCommand.Parameters[164].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[163].Value = 0;
			Adapter.UpdateCommand.Parameters[164].Value = Original_BillAddressAddr3;
		}
		if (Original_BillAddressAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[165].Value = 1;
			Adapter.UpdateCommand.Parameters[166].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[165].Value = 0;
			Adapter.UpdateCommand.Parameters[166].Value = Original_BillAddressAddr4;
		}
		if (Original_BillAddressAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[167].Value = 1;
			Adapter.UpdateCommand.Parameters[168].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[167].Value = 0;
			Adapter.UpdateCommand.Parameters[168].Value = Original_BillAddressAddr5;
		}
		if (Original_BillAddressCity == null)
		{
			Adapter.UpdateCommand.Parameters[169].Value = 1;
			Adapter.UpdateCommand.Parameters[170].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[169].Value = 0;
			Adapter.UpdateCommand.Parameters[170].Value = Original_BillAddressCity;
		}
		if (Original_BillAddressState == null)
		{
			Adapter.UpdateCommand.Parameters[171].Value = 1;
			Adapter.UpdateCommand.Parameters[172].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[171].Value = 0;
			Adapter.UpdateCommand.Parameters[172].Value = Original_BillAddressState;
		}
		if (Original_BillAddressProvince == null)
		{
			Adapter.UpdateCommand.Parameters[173].Value = 1;
			Adapter.UpdateCommand.Parameters[174].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[173].Value = 0;
			Adapter.UpdateCommand.Parameters[174].Value = Original_BillAddressProvince;
		}
		if (Original_BillAddressCounty == null)
		{
			Adapter.UpdateCommand.Parameters[175].Value = 1;
			Adapter.UpdateCommand.Parameters[176].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[175].Value = 0;
			Adapter.UpdateCommand.Parameters[176].Value = Original_BillAddressCounty;
		}
		if (Original_BillAddressPostalCode == null)
		{
			Adapter.UpdateCommand.Parameters[177].Value = 1;
			Adapter.UpdateCommand.Parameters[178].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[177].Value = 0;
			Adapter.UpdateCommand.Parameters[178].Value = Original_BillAddressPostalCode;
		}
		if (Original_BillAddressCountry == null)
		{
			Adapter.UpdateCommand.Parameters[179].Value = 1;
			Adapter.UpdateCommand.Parameters[180].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[179].Value = 0;
			Adapter.UpdateCommand.Parameters[180].Value = Original_BillAddressCountry;
		}
		if (Original_BillAddressNote == null)
		{
			Adapter.UpdateCommand.Parameters[181].Value = 1;
			Adapter.UpdateCommand.Parameters[182].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[181].Value = 0;
			Adapter.UpdateCommand.Parameters[182].Value = Original_BillAddressNote;
		}
		if (Original_BillAddressBlockAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[183].Value = 1;
			Adapter.UpdateCommand.Parameters[184].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[183].Value = 0;
			Adapter.UpdateCommand.Parameters[184].Value = Original_BillAddressBlockAddr1;
		}
		if (Original_BillAddressBlockAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[185].Value = 1;
			Adapter.UpdateCommand.Parameters[186].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[185].Value = 0;
			Adapter.UpdateCommand.Parameters[186].Value = Original_BillAddressBlockAddr2;
		}
		if (Original_BillAddressBlockAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[187].Value = 1;
			Adapter.UpdateCommand.Parameters[188].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[187].Value = 0;
			Adapter.UpdateCommand.Parameters[188].Value = Original_BillAddressBlockAddr3;
		}
		if (Original_BillAddressBlockAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[189].Value = 1;
			Adapter.UpdateCommand.Parameters[190].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[189].Value = 0;
			Adapter.UpdateCommand.Parameters[190].Value = Original_BillAddressBlockAddr4;
		}
		if (Original_BillAddressBlockAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[191].Value = 1;
			Adapter.UpdateCommand.Parameters[192].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[191].Value = 0;
			Adapter.UpdateCommand.Parameters[192].Value = Original_BillAddressBlockAddr5;
		}
		if (Original_ShipAddressAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[193].Value = 1;
			Adapter.UpdateCommand.Parameters[194].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[193].Value = 0;
			Adapter.UpdateCommand.Parameters[194].Value = Original_ShipAddressAddr1;
		}
		if (Original_ShipAddressAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[195].Value = 1;
			Adapter.UpdateCommand.Parameters[196].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[195].Value = 0;
			Adapter.UpdateCommand.Parameters[196].Value = Original_ShipAddressAddr2;
		}
		if (Original_ShipAddressAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[197].Value = 1;
			Adapter.UpdateCommand.Parameters[198].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[197].Value = 0;
			Adapter.UpdateCommand.Parameters[198].Value = Original_ShipAddressAddr3;
		}
		if (Original_ShipAddressAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[199].Value = 1;
			Adapter.UpdateCommand.Parameters[200].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[199].Value = 0;
			Adapter.UpdateCommand.Parameters[200].Value = Original_ShipAddressAddr4;
		}
		if (Original_ShipAddressAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[201].Value = 1;
			Adapter.UpdateCommand.Parameters[202].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[201].Value = 0;
			Adapter.UpdateCommand.Parameters[202].Value = Original_ShipAddressAddr5;
		}
		if (Original_ShipAddressCity == null)
		{
			Adapter.UpdateCommand.Parameters[203].Value = 1;
			Adapter.UpdateCommand.Parameters[204].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[203].Value = 0;
			Adapter.UpdateCommand.Parameters[204].Value = Original_ShipAddressCity;
		}
		if (Original_ShipAddressState == null)
		{
			Adapter.UpdateCommand.Parameters[205].Value = 1;
			Adapter.UpdateCommand.Parameters[206].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[205].Value = 0;
			Adapter.UpdateCommand.Parameters[206].Value = Original_ShipAddressState;
		}
		if (Original_ShipAddressProvince == null)
		{
			Adapter.UpdateCommand.Parameters[207].Value = 1;
			Adapter.UpdateCommand.Parameters[208].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[207].Value = 0;
			Adapter.UpdateCommand.Parameters[208].Value = Original_ShipAddressProvince;
		}
		if (Original_ShipAddressCounty == null)
		{
			Adapter.UpdateCommand.Parameters[209].Value = 1;
			Adapter.UpdateCommand.Parameters[210].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[209].Value = 0;
			Adapter.UpdateCommand.Parameters[210].Value = Original_ShipAddressCounty;
		}
		if (Original_ShipAddressPostalCode == null)
		{
			Adapter.UpdateCommand.Parameters[211].Value = 1;
			Adapter.UpdateCommand.Parameters[212].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[211].Value = 0;
			Adapter.UpdateCommand.Parameters[212].Value = Original_ShipAddressPostalCode;
		}
		if (Original_ShipAddressCountry == null)
		{
			Adapter.UpdateCommand.Parameters[213].Value = 1;
			Adapter.UpdateCommand.Parameters[214].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[213].Value = 0;
			Adapter.UpdateCommand.Parameters[214].Value = Original_ShipAddressCountry;
		}
		if (Original_ShipAddressNote == null)
		{
			Adapter.UpdateCommand.Parameters[215].Value = 1;
			Adapter.UpdateCommand.Parameters[216].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[215].Value = 0;
			Adapter.UpdateCommand.Parameters[216].Value = Original_ShipAddressNote;
		}
		if (Original_ShipAddressBlockAddr1 == null)
		{
			Adapter.UpdateCommand.Parameters[217].Value = 1;
			Adapter.UpdateCommand.Parameters[218].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[217].Value = 0;
			Adapter.UpdateCommand.Parameters[218].Value = Original_ShipAddressBlockAddr1;
		}
		if (Original_ShipAddressBlockAddr2 == null)
		{
			Adapter.UpdateCommand.Parameters[219].Value = 1;
			Adapter.UpdateCommand.Parameters[220].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[219].Value = 0;
			Adapter.UpdateCommand.Parameters[220].Value = Original_ShipAddressBlockAddr2;
		}
		if (Original_ShipAddressBlockAddr3 == null)
		{
			Adapter.UpdateCommand.Parameters[221].Value = 1;
			Adapter.UpdateCommand.Parameters[222].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[221].Value = 0;
			Adapter.UpdateCommand.Parameters[222].Value = Original_ShipAddressBlockAddr3;
		}
		if (Original_ShipAddressBlockAddr4 == null)
		{
			Adapter.UpdateCommand.Parameters[223].Value = 1;
			Adapter.UpdateCommand.Parameters[224].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[223].Value = 0;
			Adapter.UpdateCommand.Parameters[224].Value = Original_ShipAddressBlockAddr4;
		}
		if (Original_ShipAddressBlockAddr5 == null)
		{
			Adapter.UpdateCommand.Parameters[225].Value = 1;
			Adapter.UpdateCommand.Parameters[226].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[225].Value = 0;
			Adapter.UpdateCommand.Parameters[226].Value = Original_ShipAddressBlockAddr5;
		}
		if (Original_PONumber == null)
		{
			Adapter.UpdateCommand.Parameters[227].Value = 1;
			Adapter.UpdateCommand.Parameters[228].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[227].Value = 0;
			Adapter.UpdateCommand.Parameters[228].Value = Original_PONumber;
		}
		if (Original_TermsRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[229].Value = 1;
			Adapter.UpdateCommand.Parameters[230].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[229].Value = 0;
			Adapter.UpdateCommand.Parameters[230].Value = Original_TermsRefListID;
		}
		if (Original_TermsRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[231].Value = 1;
			Adapter.UpdateCommand.Parameters[232].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[231].Value = 0;
			Adapter.UpdateCommand.Parameters[232].Value = Original_TermsRefFullName;
		}
		if (Original_DueDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[233].Value = 0;
			Adapter.UpdateCommand.Parameters[234].Value = Original_DueDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[233].Value = 1;
			Adapter.UpdateCommand.Parameters[234].Value = DBNull.Value;
		}
		if (Original_SalesRepRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[235].Value = 1;
			Adapter.UpdateCommand.Parameters[236].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[235].Value = 0;
			Adapter.UpdateCommand.Parameters[236].Value = Original_SalesRepRefListID;
		}
		if (Original_SalesRepRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[237].Value = 1;
			Adapter.UpdateCommand.Parameters[238].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[237].Value = 0;
			Adapter.UpdateCommand.Parameters[238].Value = Original_SalesRepRefFullName;
		}
		if (Original_FOB == null)
		{
			Adapter.UpdateCommand.Parameters[239].Value = 1;
			Adapter.UpdateCommand.Parameters[240].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[239].Value = 0;
			Adapter.UpdateCommand.Parameters[240].Value = Original_FOB;
		}
		if (Original_ShipDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[241].Value = 0;
			Adapter.UpdateCommand.Parameters[242].Value = Original_ShipDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[241].Value = 1;
			Adapter.UpdateCommand.Parameters[242].Value = DBNull.Value;
		}
		if (Original_ShipMethodRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[243].Value = 1;
			Adapter.UpdateCommand.Parameters[244].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[243].Value = 0;
			Adapter.UpdateCommand.Parameters[244].Value = Original_ShipMethodRefListID;
		}
		if (Original_ShipMethodRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[245].Value = 1;
			Adapter.UpdateCommand.Parameters[246].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[245].Value = 0;
			Adapter.UpdateCommand.Parameters[246].Value = Original_ShipMethodRefFullName;
		}
		if (Original_Subtotal.HasValue)
		{
			Adapter.UpdateCommand.Parameters[247].Value = 0;
			Adapter.UpdateCommand.Parameters[248].Value = Original_Subtotal.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[247].Value = 1;
			Adapter.UpdateCommand.Parameters[248].Value = DBNull.Value;
		}
		if (Original_ItemSalesTaxRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[249].Value = 1;
			Adapter.UpdateCommand.Parameters[250].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[249].Value = 0;
			Adapter.UpdateCommand.Parameters[250].Value = Original_ItemSalesTaxRefListID;
		}
		if (Original_ItemSalesTaxRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[251].Value = 1;
			Adapter.UpdateCommand.Parameters[252].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[251].Value = 0;
			Adapter.UpdateCommand.Parameters[252].Value = Original_ItemSalesTaxRefFullName;
		}
		if (Original_SalesTaxPercentage.HasValue)
		{
			Adapter.UpdateCommand.Parameters[253].Value = 0;
			Adapter.UpdateCommand.Parameters[254].Value = Original_SalesTaxPercentage.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[253].Value = 1;
			Adapter.UpdateCommand.Parameters[254].Value = DBNull.Value;
		}
		if (Original_SalesTaxTotal.HasValue)
		{
			Adapter.UpdateCommand.Parameters[255].Value = 0;
			Adapter.UpdateCommand.Parameters[256].Value = Original_SalesTaxTotal.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[255].Value = 1;
			Adapter.UpdateCommand.Parameters[256].Value = DBNull.Value;
		}
		if (Original_TotalAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[257].Value = 0;
			Adapter.UpdateCommand.Parameters[258].Value = Original_TotalAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[257].Value = 1;
			Adapter.UpdateCommand.Parameters[258].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[259].Value = 0;
		Adapter.UpdateCommand.Parameters[260].Value = Original_IsManuallyClosed;
		Adapter.UpdateCommand.Parameters[261].Value = 0;
		Adapter.UpdateCommand.Parameters[262].Value = Original_IsFullyInvoiced;
		if (Original_CustomerMsgRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[263].Value = 1;
			Adapter.UpdateCommand.Parameters[264].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[263].Value = 0;
			Adapter.UpdateCommand.Parameters[264].Value = Original_CustomerMsgRefListID;
		}
		if (Original_CustomerMsgRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[265].Value = 1;
			Adapter.UpdateCommand.Parameters[266].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[265].Value = 0;
			Adapter.UpdateCommand.Parameters[266].Value = Original_CustomerMsgRefFullName;
		}
		Adapter.UpdateCommand.Parameters[267].Value = 0;
		Adapter.UpdateCommand.Parameters[268].Value = Original_IsToBePrinted;
		Adapter.UpdateCommand.Parameters[269].Value = 0;
		Adapter.UpdateCommand.Parameters[270].Value = Original_IsToBeEmailed;
		Adapter.UpdateCommand.Parameters[271].Value = 0;
		Adapter.UpdateCommand.Parameters[272].Value = Original_IsTaxIncluded;
		if (Original_CustomerSalesTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[273].Value = 1;
			Adapter.UpdateCommand.Parameters[274].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[273].Value = 0;
			Adapter.UpdateCommand.Parameters[274].Value = Original_CustomerSalesTaxCodeRefListID;
		}
		if (Original_CustomerSalesTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[275].Value = 1;
			Adapter.UpdateCommand.Parameters[276].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[275].Value = 0;
			Adapter.UpdateCommand.Parameters[276].Value = Original_CustomerSalesTaxCodeRefFullName;
		}
		if (Original_CustomerTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[277].Value = 1;
			Adapter.UpdateCommand.Parameters[278].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[277].Value = 0;
			Adapter.UpdateCommand.Parameters[278].Value = Original_CustomerTaxCodeRefListID;
		}
		if (Original_CustomFieldOther == null)
		{
			Adapter.UpdateCommand.Parameters[279].Value = 1;
			Adapter.UpdateCommand.Parameters[280].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[279].Value = 0;
			Adapter.UpdateCommand.Parameters[280].Value = Original_CustomFieldOther;
		}
		if (Original_SalesOrderLineSeqNo.HasValue)
		{
			Adapter.UpdateCommand.Parameters[281].Value = 0;
			Adapter.UpdateCommand.Parameters[282].Value = Original_SalesOrderLineSeqNo.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[281].Value = 1;
			Adapter.UpdateCommand.Parameters[282].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupTxnLineID == null)
		{
			Adapter.UpdateCommand.Parameters[283].Value = 1;
			Adapter.UpdateCommand.Parameters[284].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[283].Value = 0;
			Adapter.UpdateCommand.Parameters[284].Value = Original_SalesOrderLineGroupTxnLineID;
		}
		if (Original_SalesOrderLineGroupItemGroupRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[285].Value = 1;
			Adapter.UpdateCommand.Parameters[286].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[285].Value = 0;
			Adapter.UpdateCommand.Parameters[286].Value = Original_SalesOrderLineGroupItemGroupRefListID;
		}
		if (Original_SalesOrderLineGroupItemGroupRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[287].Value = 1;
			Adapter.UpdateCommand.Parameters[288].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[287].Value = 0;
			Adapter.UpdateCommand.Parameters[288].Value = Original_SalesOrderLineGroupItemGroupRefFullName;
		}
		if (Original_SalesOrderLineGroupQuantity.HasValue)
		{
			Adapter.UpdateCommand.Parameters[289].Value = 0;
			Adapter.UpdateCommand.Parameters[290].Value = Original_SalesOrderLineGroupQuantity.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[289].Value = 1;
			Adapter.UpdateCommand.Parameters[290].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupUnitOfMeasure == null)
		{
			Adapter.UpdateCommand.Parameters[291].Value = 1;
			Adapter.UpdateCommand.Parameters[292].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[291].Value = 0;
			Adapter.UpdateCommand.Parameters[292].Value = Original_SalesOrderLineGroupUnitOfMeasure;
		}
		if (Original_SalesOrderLineGroupOverrideUOMSetRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[293].Value = 1;
			Adapter.UpdateCommand.Parameters[294].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[293].Value = 0;
			Adapter.UpdateCommand.Parameters[294].Value = Original_SalesOrderLineGroupOverrideUOMSetRefListID;
		}
		if (Original_SalesOrderLineGroupOverrideUOMSetRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[295].Value = 1;
			Adapter.UpdateCommand.Parameters[296].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[295].Value = 0;
			Adapter.UpdateCommand.Parameters[296].Value = Original_SalesOrderLineGroupOverrideUOMSetRefFullName;
		}
		Adapter.UpdateCommand.Parameters[297].Value = 0;
		Adapter.UpdateCommand.Parameters[298].Value = Original_SalesOrderLineGroupIsPrintItemsInGroup;
		if (Original_SalesOrderLineGroupTotalAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[299].Value = 0;
			Adapter.UpdateCommand.Parameters[300].Value = Original_SalesOrderLineGroupTotalAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[299].Value = 1;
			Adapter.UpdateCommand.Parameters[300].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineGroupSeqNo.HasValue)
		{
			Adapter.UpdateCommand.Parameters[301].Value = 0;
			Adapter.UpdateCommand.Parameters[302].Value = Original_SalesOrderLineGroupSeqNo.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[301].Value = 1;
			Adapter.UpdateCommand.Parameters[302].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineTxnLineID == null)
		{
			Adapter.UpdateCommand.Parameters[303].Value = 1;
			Adapter.UpdateCommand.Parameters[304].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[303].Value = 0;
			Adapter.UpdateCommand.Parameters[304].Value = Original_SalesOrderLineTxnLineID;
		}
		if (Original_SalesOrderLineItemRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[305].Value = 1;
			Adapter.UpdateCommand.Parameters[306].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[305].Value = 0;
			Adapter.UpdateCommand.Parameters[306].Value = Original_SalesOrderLineItemRefListID;
		}
		if (Original_SalesOrderLineItemRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[307].Value = 1;
			Adapter.UpdateCommand.Parameters[308].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[307].Value = 0;
			Adapter.UpdateCommand.Parameters[308].Value = Original_SalesOrderLineItemRefFullName;
		}
		if (Original_SalesOrderLineQuantity.HasValue)
		{
			Adapter.UpdateCommand.Parameters[309].Value = 0;
			Adapter.UpdateCommand.Parameters[310].Value = Original_SalesOrderLineQuantity.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[309].Value = 1;
			Adapter.UpdateCommand.Parameters[310].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineUnitOfMeasure == null)
		{
			Adapter.UpdateCommand.Parameters[311].Value = 1;
			Adapter.UpdateCommand.Parameters[312].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[311].Value = 0;
			Adapter.UpdateCommand.Parameters[312].Value = Original_SalesOrderLineUnitOfMeasure;
		}
		if (Original_SalesOrderLineOverrideUOMSetRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[313].Value = 1;
			Adapter.UpdateCommand.Parameters[314].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[313].Value = 0;
			Adapter.UpdateCommand.Parameters[314].Value = Original_SalesOrderLineOverrideUOMSetRefListID;
		}
		if (Original_SalesOrderLineOverrideUOMSetRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[315].Value = 1;
			Adapter.UpdateCommand.Parameters[316].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[315].Value = 0;
			Adapter.UpdateCommand.Parameters[316].Value = Original_SalesOrderLineOverrideUOMSetRefFullName;
		}
		if (Original_SalesOrderLineRate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[317].Value = 0;
			Adapter.UpdateCommand.Parameters[318].Value = Original_SalesOrderLineRate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[317].Value = 1;
			Adapter.UpdateCommand.Parameters[318].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineRatePercent.HasValue)
		{
			Adapter.UpdateCommand.Parameters[319].Value = 0;
			Adapter.UpdateCommand.Parameters[320].Value = Original_SalesOrderLineRatePercent.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[319].Value = 1;
			Adapter.UpdateCommand.Parameters[320].Value = DBNull.Value;
		}
		if (Original_SalesOrderLinePriceLevelRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[321].Value = 1;
			Adapter.UpdateCommand.Parameters[322].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[321].Value = 0;
			Adapter.UpdateCommand.Parameters[322].Value = Original_SalesOrderLinePriceLevelRefListID;
		}
		if (Original_SalesOrderLinePriceLevelRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[323].Value = 1;
			Adapter.UpdateCommand.Parameters[324].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[323].Value = 0;
			Adapter.UpdateCommand.Parameters[324].Value = Original_SalesOrderLinePriceLevelRefFullName;
		}
		if (Original_SalesOrderLineClassRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[325].Value = 1;
			Adapter.UpdateCommand.Parameters[326].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[325].Value = 0;
			Adapter.UpdateCommand.Parameters[326].Value = Original_SalesOrderLineClassRefListID;
		}
		if (Original_SalesOrderLineClassRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[327].Value = 1;
			Adapter.UpdateCommand.Parameters[328].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[327].Value = 0;
			Adapter.UpdateCommand.Parameters[328].Value = Original_SalesOrderLineClassRefFullName;
		}
		if (Original_SalesOrderLineAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[329].Value = 0;
			Adapter.UpdateCommand.Parameters[330].Value = Original_SalesOrderLineAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[329].Value = 1;
			Adapter.UpdateCommand.Parameters[330].Value = DBNull.Value;
		}
		if (Original_SalesOrderInventorySiteRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[331].Value = 1;
			Adapter.UpdateCommand.Parameters[332].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[331].Value = 0;
			Adapter.UpdateCommand.Parameters[332].Value = Original_SalesOrderInventorySiteRefListID;
		}
		if (Original_SalesOrderInventorySiteRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[333].Value = 1;
			Adapter.UpdateCommand.Parameters[334].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[333].Value = 0;
			Adapter.UpdateCommand.Parameters[334].Value = Original_SalesOrderInventorySiteRefFullName;
		}
		if (Original_SalesOrderLineLotNumber == null)
		{
			Adapter.UpdateCommand.Parameters[335].Value = 1;
			Adapter.UpdateCommand.Parameters[336].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[335].Value = 0;
			Adapter.UpdateCommand.Parameters[336].Value = Original_SalesOrderLineLotNumber;
		}
		if (Original_SalesOrderLineTaxAmount.HasValue)
		{
			Adapter.UpdateCommand.Parameters[337].Value = 0;
			Adapter.UpdateCommand.Parameters[338].Value = Original_SalesOrderLineTaxAmount.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[337].Value = 1;
			Adapter.UpdateCommand.Parameters[338].Value = DBNull.Value;
		}
		if (Original_SalesOrderLineSalesTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[339].Value = 1;
			Adapter.UpdateCommand.Parameters[340].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[339].Value = 0;
			Adapter.UpdateCommand.Parameters[340].Value = Original_SalesOrderLineSalesTaxCodeRefListID;
		}
		if (Original_SalesOrderLineSalesTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[341].Value = 1;
			Adapter.UpdateCommand.Parameters[342].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[341].Value = 0;
			Adapter.UpdateCommand.Parameters[342].Value = Original_SalesOrderLineSalesTaxCodeRefFullName;
		}
		if (Original_SalesOrderLineTaxCodeRefListID == null)
		{
			Adapter.UpdateCommand.Parameters[343].Value = 1;
			Adapter.UpdateCommand.Parameters[344].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[343].Value = 0;
			Adapter.UpdateCommand.Parameters[344].Value = Original_SalesOrderLineTaxCodeRefListID;
		}
		if (Original_SalesOrderLineTaxCodeRefFullName == null)
		{
			Adapter.UpdateCommand.Parameters[345].Value = 1;
			Adapter.UpdateCommand.Parameters[346].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[345].Value = 0;
			Adapter.UpdateCommand.Parameters[346].Value = Original_SalesOrderLineTaxCodeRefFullName;
		}
		if (Original_SalesOrderLineInvoiced.HasValue)
		{
			Adapter.UpdateCommand.Parameters[347].Value = 0;
			Adapter.UpdateCommand.Parameters[348].Value = Original_SalesOrderLineInvoiced.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[347].Value = 1;
			Adapter.UpdateCommand.Parameters[348].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[349].Value = 0;
		Adapter.UpdateCommand.Parameters[350].Value = Original_SalesOrderLineIsManuallyClosed;
		if (Original_CustomFieldSalesOrderLineOther1 == null)
		{
			Adapter.UpdateCommand.Parameters[351].Value = 1;
			Adapter.UpdateCommand.Parameters[352].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[351].Value = 0;
			Adapter.UpdateCommand.Parameters[352].Value = Original_CustomFieldSalesOrderLineOther1;
		}
		if (Original_CustomFieldSalesOrderLineOther2 == null)
		{
			Adapter.UpdateCommand.Parameters[353].Value = 1;
			Adapter.UpdateCommand.Parameters[354].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[353].Value = 0;
			Adapter.UpdateCommand.Parameters[354].Value = Original_CustomFieldSalesOrderLineOther2;
		}
		if (Original_Tax1Total.HasValue)
		{
			Adapter.UpdateCommand.Parameters[355].Value = 0;
			Adapter.UpdateCommand.Parameters[356].Value = Original_Tax1Total.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[355].Value = 1;
			Adapter.UpdateCommand.Parameters[356].Value = DBNull.Value;
		}
		if (Original_Tax2Total.HasValue)
		{
			Adapter.UpdateCommand.Parameters[357].Value = 0;
			Adapter.UpdateCommand.Parameters[358].Value = Original_Tax2Total.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[357].Value = 1;
			Adapter.UpdateCommand.Parameters[358].Value = DBNull.Value;
		}
		if (Original_ExchangeRate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[359].Value = 0;
			Adapter.UpdateCommand.Parameters[360].Value = Original_ExchangeRate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[359].Value = 1;
			Adapter.UpdateCommand.Parameters[360].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[361].Value = 0;
		Adapter.UpdateCommand.Parameters[362].Value = Original_AmountIncludesVAT;
		Adapter.UpdateCommand.Parameters[363].Value = 0;
		Adapter.UpdateCommand.Parameters[364].Value = Original_FQSaveToCache;
		if (Original_FQPrimaryKey == null)
		{
			throw new ArgumentNullException("Original_FQPrimaryKey");
		}
		Adapter.UpdateCommand.Parameters[365].Value = Original_FQPrimaryKey;
		if (Original_FQTxnLinkKey == null)
		{
			Adapter.UpdateCommand.Parameters[366].Value = 1;
			Adapter.UpdateCommand.Parameters[367].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[366].Value = 0;
			Adapter.UpdateCommand.Parameters[367].Value = Original_FQTxnLinkKey;
		}
		if (Original_CustomFieldSalesOrderLineCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[368].Value = 1;
			Adapter.UpdateCommand.Parameters[369].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[368].Value = 0;
			Adapter.UpdateCommand.Parameters[369].Value = Original_CustomFieldSalesOrderLineCycleCount;
		}
		if (Original_CustomFieldSalesOrderLineGroupCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[370].Value = 1;
			Adapter.UpdateCommand.Parameters[371].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[370].Value = 0;
			Adapter.UpdateCommand.Parameters[371].Value = Original_CustomFieldSalesOrderLineGroupCycleCount;
		}
		if (Original_CustomFieldSalesOrderLineGroupLineCycleCount == null)
		{
			Adapter.UpdateCommand.Parameters[372].Value = 1;
			Adapter.UpdateCommand.Parameters[373].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[372].Value = 0;
			Adapter.UpdateCommand.Parameters[373].Value = Original_CustomFieldSalesOrderLineGroupLineCycleCount;
		}
		if (Original_CustomFieldCollect == null)
		{
			Adapter.UpdateCommand.Parameters[374].Value = 1;
			Adapter.UpdateCommand.Parameters[375].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[374].Value = 0;
			Adapter.UpdateCommand.Parameters[375].Value = Original_CustomFieldCollect;
		}
		if (Original_CustomFieldPPDCOL == null)
		{
			Adapter.UpdateCommand.Parameters[376].Value = 1;
			Adapter.UpdateCommand.Parameters[377].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[376].Value = 0;
			Adapter.UpdateCommand.Parameters[377].Value = Original_CustomFieldPPDCOL;
		}
		if (Original_CustomFieldRep == null)
		{
			Adapter.UpdateCommand.Parameters[378].Value = 1;
			Adapter.UpdateCommand.Parameters[379].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[378].Value = 0;
			Adapter.UpdateCommand.Parameters[379].Value = Original_CustomFieldRep;
		}
		if (Original_CustomFieldShipDate == null)
		{
			Adapter.UpdateCommand.Parameters[380].Value = 1;
			Adapter.UpdateCommand.Parameters[381].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[380].Value = 0;
			Adapter.UpdateCommand.Parameters[381].Value = Original_CustomFieldShipDate;
		}
		if (Original_CustomFieldShipVia == null)
		{
			Adapter.UpdateCommand.Parameters[382].Value = 1;
			Adapter.UpdateCommand.Parameters[383].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[382].Value = 0;
			Adapter.UpdateCommand.Parameters[383].Value = Original_CustomFieldShipVia;
		}
		ConnectionState previousConnectionState = Adapter.UpdateCommand.Connection.State;
		if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			return Adapter.UpdateCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.UpdateCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string TxnID, DateTime? TimeCreated, DateTime? TimeModified, string EditSequence, int? TxnNumber, string CustomerRefListID, string CustomerRefFullName, string ClassRefListID, string ClassRefFullName, string TemplateRefListID, string TemplateRefFullName, DateTime? TxnDate, string TxnDateMacro, string RefNumber, string BillAddressAddr1, string BillAddressAddr2, string BillAddressAddr3, string BillAddressAddr4, string BillAddressAddr5, string BillAddressCity, string BillAddressState, string BillAddressProvince, string BillAddressCounty, string BillAddressPostalCode, string BillAddressCountry, string BillAddressNote, string BillAddressBlockAddr1, string BillAddressBlockAddr2, string BillAddressBlockAddr3, string BillAddressBlockAddr4, string BillAddressBlockAddr5, string ShipAddressAddr1, string ShipAddressAddr2, string ShipAddressAddr3, string ShipAddressAddr4, string ShipAddressAddr5, string ShipAddressCity, string ShipAddressState, string ShipAddressProvince, string ShipAddressCounty, string ShipAddressPostalCode, string ShipAddressCountry, string ShipAddressNote, string ShipAddressBlockAddr1, string ShipAddressBlockAddr2, string ShipAddressBlockAddr3, string ShipAddressBlockAddr4, string ShipAddressBlockAddr5, string PONumber, string TermsRefListID, string TermsRefFullName, DateTime? DueDate, string SalesRepRefListID, string SalesRepRefFullName, string FOB, DateTime? ShipDate, string ShipMethodRefListID, string ShipMethodRefFullName, decimal? Subtotal, string ItemSalesTaxRefListID, string ItemSalesTaxRefFullName, decimal? SalesTaxPercentage, decimal? SalesTaxTotal, decimal? TotalAmount, bool IsManuallyClosed, bool IsFullyInvoiced, string Memo, string CustomerMsgRefListID, string CustomerMsgRefFullName, bool IsToBePrinted, bool IsToBeEmailed, bool IsTaxIncluded, string CustomerSalesTaxCodeRefListID, string CustomerSalesTaxCodeRefFullName, string CustomerTaxCodeRefListID, string CustomFieldOther, int? SalesOrderLineSeqNo, string SalesOrderLineGroupTxnLineID, string SalesOrderLineGroupItemGroupRefListID, string SalesOrderLineGroupItemGroupRefFullName, string SalesOrderLineGroupDesc, decimal? SalesOrderLineGroupQuantity, string SalesOrderLineGroupUnitOfMeasure, string SalesOrderLineGroupOverrideUOMSetRefListID, string SalesOrderLineGroupOverrideUOMSetRefFullName, bool SalesOrderLineGroupIsPrintItemsInGroup, decimal? SalesOrderLineGroupTotalAmount, int? SalesOrderLineGroupSeqNo, string SalesOrderLineTxnLineID, string SalesOrderLineItemRefListID, string SalesOrderLineItemRefFullName, string SalesOrderLineDesc, decimal? SalesOrderLineQuantity, string SalesOrderLineUnitOfMeasure, string SalesOrderLineOverrideUOMSetRefListID, string SalesOrderLineOverrideUOMSetRefFullName, decimal? SalesOrderLineRate, decimal? SalesOrderLineRatePercent, string SalesOrderLinePriceLevelRefListID, string SalesOrderLinePriceLevelRefFullName, string SalesOrderLineClassRefListID, string SalesOrderLineClassRefFullName, decimal? SalesOrderLineAmount, string SalesOrderInventorySiteRefListID, string SalesOrderInventorySiteRefFullName, string SalesOrderLineSerialNumber, string SalesOrderLineLotNumber, decimal? SalesOrderLineTaxAmount, string SalesOrderLineSalesTaxCodeRefListID, string SalesOrderLineSalesTaxCodeRefFullName, string SalesOrderLineTaxCodeRefListID, string SalesOrderLineTaxCodeRefFullName, decimal? SalesOrderLineInvoiced, bool SalesOrderLineIsManuallyClosed, string CustomFieldSalesOrderLineOther1, string CustomFieldSalesOrderLineOther2, decimal? Tax1Total, decimal? Tax2Total, decimal? ExchangeRate, bool AmountIncludesVAT, bool FQSaveToCache, string FQTxnLinkKey, string CustomFieldSalesOrderLineCycleCount, string CustomFieldSalesOrderLineGroupCycleCount, string CustomFieldSalesOrderLineGroupLineCycleCount, string CustomFieldCollect, string CustomFieldPPDCOL, string CustomFieldRep, string CustomFieldShipDate, string CustomFieldShipVia, string Original_TxnID, DateTime? Original_TimeCreated, DateTime? Original_TimeModified, string Original_EditSequence, int? Original_TxnNumber, string Original_CustomerRefListID, string Original_CustomerRefFullName, string Original_ClassRefListID, string Original_ClassRefFullName, string Original_TemplateRefListID, string Original_TemplateRefFullName, DateTime? Original_TxnDate, string Original_TxnDateMacro, string Original_RefNumber, string Original_BillAddressAddr1, string Original_BillAddressAddr2, string Original_BillAddressAddr3, string Original_BillAddressAddr4, string Original_BillAddressAddr5, string Original_BillAddressCity, string Original_BillAddressState, string Original_BillAddressProvince, string Original_BillAddressCounty, string Original_BillAddressPostalCode, string Original_BillAddressCountry, string Original_BillAddressNote, string Original_BillAddressBlockAddr1, string Original_BillAddressBlockAddr2, string Original_BillAddressBlockAddr3, string Original_BillAddressBlockAddr4, string Original_BillAddressBlockAddr5, string Original_ShipAddressAddr1, string Original_ShipAddressAddr2, string Original_ShipAddressAddr3, string Original_ShipAddressAddr4, string Original_ShipAddressAddr5, string Original_ShipAddressCity, string Original_ShipAddressState, string Original_ShipAddressProvince, string Original_ShipAddressCounty, string Original_ShipAddressPostalCode, string Original_ShipAddressCountry, string Original_ShipAddressNote, string Original_ShipAddressBlockAddr1, string Original_ShipAddressBlockAddr2, string Original_ShipAddressBlockAddr3, string Original_ShipAddressBlockAddr4, string Original_ShipAddressBlockAddr5, string Original_PONumber, string Original_TermsRefListID, string Original_TermsRefFullName, DateTime? Original_DueDate, string Original_SalesRepRefListID, string Original_SalesRepRefFullName, string Original_FOB, DateTime? Original_ShipDate, string Original_ShipMethodRefListID, string Original_ShipMethodRefFullName, decimal? Original_Subtotal, string Original_ItemSalesTaxRefListID, string Original_ItemSalesTaxRefFullName, decimal? Original_SalesTaxPercentage, decimal? Original_SalesTaxTotal, decimal? Original_TotalAmount, bool Original_IsManuallyClosed, bool Original_IsFullyInvoiced, string Original_CustomerMsgRefListID, string Original_CustomerMsgRefFullName, bool Original_IsToBePrinted, bool Original_IsToBeEmailed, bool Original_IsTaxIncluded, string Original_CustomerSalesTaxCodeRefListID, string Original_CustomerSalesTaxCodeRefFullName, string Original_CustomerTaxCodeRefListID, string Original_CustomFieldOther, int? Original_SalesOrderLineSeqNo, string Original_SalesOrderLineGroupTxnLineID, string Original_SalesOrderLineGroupItemGroupRefListID, string Original_SalesOrderLineGroupItemGroupRefFullName, decimal? Original_SalesOrderLineGroupQuantity, string Original_SalesOrderLineGroupUnitOfMeasure, string Original_SalesOrderLineGroupOverrideUOMSetRefListID, string Original_SalesOrderLineGroupOverrideUOMSetRefFullName, bool Original_SalesOrderLineGroupIsPrintItemsInGroup, decimal? Original_SalesOrderLineGroupTotalAmount, int? Original_SalesOrderLineGroupSeqNo, string Original_SalesOrderLineTxnLineID, string Original_SalesOrderLineItemRefListID, string Original_SalesOrderLineItemRefFullName, decimal? Original_SalesOrderLineQuantity, string Original_SalesOrderLineUnitOfMeasure, string Original_SalesOrderLineOverrideUOMSetRefListID, string Original_SalesOrderLineOverrideUOMSetRefFullName, decimal? Original_SalesOrderLineRate, decimal? Original_SalesOrderLineRatePercent, string Original_SalesOrderLinePriceLevelRefListID, string Original_SalesOrderLinePriceLevelRefFullName, string Original_SalesOrderLineClassRefListID, string Original_SalesOrderLineClassRefFullName, decimal? Original_SalesOrderLineAmount, string Original_SalesOrderInventorySiteRefListID, string Original_SalesOrderInventorySiteRefFullName, string Original_SalesOrderLineLotNumber, decimal? Original_SalesOrderLineTaxAmount, string Original_SalesOrderLineSalesTaxCodeRefListID, string Original_SalesOrderLineSalesTaxCodeRefFullName, string Original_SalesOrderLineTaxCodeRefListID, string Original_SalesOrderLineTaxCodeRefFullName, decimal? Original_SalesOrderLineInvoiced, bool Original_SalesOrderLineIsManuallyClosed, string Original_CustomFieldSalesOrderLineOther1, string Original_CustomFieldSalesOrderLineOther2, decimal? Original_Tax1Total, decimal? Original_Tax2Total, decimal? Original_ExchangeRate, bool Original_AmountIncludesVAT, bool Original_FQSaveToCache, string Original_FQPrimaryKey, string Original_FQTxnLinkKey, string Original_CustomFieldSalesOrderLineCycleCount, string Original_CustomFieldSalesOrderLineGroupCycleCount, string Original_CustomFieldSalesOrderLineGroupLineCycleCount, string Original_CustomFieldCollect, string Original_CustomFieldPPDCOL, string Original_CustomFieldRep, string Original_CustomFieldShipDate, string Original_CustomFieldShipVia)
	{
		return Update(TxnID, TimeCreated, TimeModified, EditSequence, TxnNumber, CustomerRefListID, CustomerRefFullName, ClassRefListID, ClassRefFullName, TemplateRefListID, TemplateRefFullName, TxnDate, TxnDateMacro, RefNumber, BillAddressAddr1, BillAddressAddr2, BillAddressAddr3, BillAddressAddr4, BillAddressAddr5, BillAddressCity, BillAddressState, BillAddressProvince, BillAddressCounty, BillAddressPostalCode, BillAddressCountry, BillAddressNote, BillAddressBlockAddr1, BillAddressBlockAddr2, BillAddressBlockAddr3, BillAddressBlockAddr4, BillAddressBlockAddr5, ShipAddressAddr1, ShipAddressAddr2, ShipAddressAddr3, ShipAddressAddr4, ShipAddressAddr5, ShipAddressCity, ShipAddressState, ShipAddressProvince, ShipAddressCounty, ShipAddressPostalCode, ShipAddressCountry, ShipAddressNote, ShipAddressBlockAddr1, ShipAddressBlockAddr2, ShipAddressBlockAddr3, ShipAddressBlockAddr4, ShipAddressBlockAddr5, PONumber, TermsRefListID, TermsRefFullName, DueDate, SalesRepRefListID, SalesRepRefFullName, FOB, ShipDate, ShipMethodRefListID, ShipMethodRefFullName, Subtotal, ItemSalesTaxRefListID, ItemSalesTaxRefFullName, SalesTaxPercentage, SalesTaxTotal, TotalAmount, IsManuallyClosed, IsFullyInvoiced, Memo, CustomerMsgRefListID, CustomerMsgRefFullName, IsToBePrinted, IsToBeEmailed, IsTaxIncluded, CustomerSalesTaxCodeRefListID, CustomerSalesTaxCodeRefFullName, CustomerTaxCodeRefListID, CustomFieldOther, SalesOrderLineSeqNo, SalesOrderLineGroupTxnLineID, SalesOrderLineGroupItemGroupRefListID, SalesOrderLineGroupItemGroupRefFullName, SalesOrderLineGroupDesc, SalesOrderLineGroupQuantity, SalesOrderLineGroupUnitOfMeasure, SalesOrderLineGroupOverrideUOMSetRefListID, SalesOrderLineGroupOverrideUOMSetRefFullName, SalesOrderLineGroupIsPrintItemsInGroup, SalesOrderLineGroupTotalAmount, SalesOrderLineGroupSeqNo, SalesOrderLineTxnLineID, SalesOrderLineItemRefListID, SalesOrderLineItemRefFullName, SalesOrderLineDesc, SalesOrderLineQuantity, SalesOrderLineUnitOfMeasure, SalesOrderLineOverrideUOMSetRefListID, SalesOrderLineOverrideUOMSetRefFullName, SalesOrderLineRate, SalesOrderLineRatePercent, SalesOrderLinePriceLevelRefListID, SalesOrderLinePriceLevelRefFullName, SalesOrderLineClassRefListID, SalesOrderLineClassRefFullName, SalesOrderLineAmount, SalesOrderInventorySiteRefListID, SalesOrderInventorySiteRefFullName, SalesOrderLineSerialNumber, SalesOrderLineLotNumber, SalesOrderLineTaxAmount, SalesOrderLineSalesTaxCodeRefListID, SalesOrderLineSalesTaxCodeRefFullName, SalesOrderLineTaxCodeRefListID, SalesOrderLineTaxCodeRefFullName, SalesOrderLineInvoiced, SalesOrderLineIsManuallyClosed, CustomFieldSalesOrderLineOther1, CustomFieldSalesOrderLineOther2, Tax1Total, Tax2Total, ExchangeRate, AmountIncludesVAT, FQSaveToCache, Original_FQPrimaryKey, FQTxnLinkKey, CustomFieldSalesOrderLineCycleCount, CustomFieldSalesOrderLineGroupCycleCount, CustomFieldSalesOrderLineGroupLineCycleCount, CustomFieldCollect, CustomFieldPPDCOL, CustomFieldRep, CustomFieldShipDate, CustomFieldShipVia, Original_TxnID, Original_TimeCreated, Original_TimeModified, Original_EditSequence, Original_TxnNumber, Original_CustomerRefListID, Original_CustomerRefFullName, Original_ClassRefListID, Original_ClassRefFullName, Original_TemplateRefListID, Original_TemplateRefFullName, Original_TxnDate, Original_TxnDateMacro, Original_RefNumber, Original_BillAddressAddr1, Original_BillAddressAddr2, Original_BillAddressAddr3, Original_BillAddressAddr4, Original_BillAddressAddr5, Original_BillAddressCity, Original_BillAddressState, Original_BillAddressProvince, Original_BillAddressCounty, Original_BillAddressPostalCode, Original_BillAddressCountry, Original_BillAddressNote, Original_BillAddressBlockAddr1, Original_BillAddressBlockAddr2, Original_BillAddressBlockAddr3, Original_BillAddressBlockAddr4, Original_BillAddressBlockAddr5, Original_ShipAddressAddr1, Original_ShipAddressAddr2, Original_ShipAddressAddr3, Original_ShipAddressAddr4, Original_ShipAddressAddr5, Original_ShipAddressCity, Original_ShipAddressState, Original_ShipAddressProvince, Original_ShipAddressCounty, Original_ShipAddressPostalCode, Original_ShipAddressCountry, Original_ShipAddressNote, Original_ShipAddressBlockAddr1, Original_ShipAddressBlockAddr2, Original_ShipAddressBlockAddr3, Original_ShipAddressBlockAddr4, Original_ShipAddressBlockAddr5, Original_PONumber, Original_TermsRefListID, Original_TermsRefFullName, Original_DueDate, Original_SalesRepRefListID, Original_SalesRepRefFullName, Original_FOB, Original_ShipDate, Original_ShipMethodRefListID, Original_ShipMethodRefFullName, Original_Subtotal, Original_ItemSalesTaxRefListID, Original_ItemSalesTaxRefFullName, Original_SalesTaxPercentage, Original_SalesTaxTotal, Original_TotalAmount, Original_IsManuallyClosed, Original_IsFullyInvoiced, Original_CustomerMsgRefListID, Original_CustomerMsgRefFullName, Original_IsToBePrinted, Original_IsToBeEmailed, Original_IsTaxIncluded, Original_CustomerSalesTaxCodeRefListID, Original_CustomerSalesTaxCodeRefFullName, Original_CustomerTaxCodeRefListID, Original_CustomFieldOther, Original_SalesOrderLineSeqNo, Original_SalesOrderLineGroupTxnLineID, Original_SalesOrderLineGroupItemGroupRefListID, Original_SalesOrderLineGroupItemGroupRefFullName, Original_SalesOrderLineGroupQuantity, Original_SalesOrderLineGroupUnitOfMeasure, Original_SalesOrderLineGroupOverrideUOMSetRefListID, Original_SalesOrderLineGroupOverrideUOMSetRefFullName, Original_SalesOrderLineGroupIsPrintItemsInGroup, Original_SalesOrderLineGroupTotalAmount, Original_SalesOrderLineGroupSeqNo, Original_SalesOrderLineTxnLineID, Original_SalesOrderLineItemRefListID, Original_SalesOrderLineItemRefFullName, Original_SalesOrderLineQuantity, Original_SalesOrderLineUnitOfMeasure, Original_SalesOrderLineOverrideUOMSetRefListID, Original_SalesOrderLineOverrideUOMSetRefFullName, Original_SalesOrderLineRate, Original_SalesOrderLineRatePercent, Original_SalesOrderLinePriceLevelRefListID, Original_SalesOrderLinePriceLevelRefFullName, Original_SalesOrderLineClassRefListID, Original_SalesOrderLineClassRefFullName, Original_SalesOrderLineAmount, Original_SalesOrderInventorySiteRefListID, Original_SalesOrderInventorySiteRefFullName, Original_SalesOrderLineLotNumber, Original_SalesOrderLineTaxAmount, Original_SalesOrderLineSalesTaxCodeRefListID, Original_SalesOrderLineSalesTaxCodeRefFullName, Original_SalesOrderLineTaxCodeRefListID, Original_SalesOrderLineTaxCodeRefFullName, Original_SalesOrderLineInvoiced, Original_SalesOrderLineIsManuallyClosed, Original_CustomFieldSalesOrderLineOther1, Original_CustomFieldSalesOrderLineOther2, Original_Tax1Total, Original_Tax2Total, Original_ExchangeRate, Original_AmountIncludesVAT, Original_FQSaveToCache, Original_FQPrimaryKey, Original_FQTxnLinkKey, Original_CustomFieldSalesOrderLineCycleCount, Original_CustomFieldSalesOrderLineGroupCycleCount, Original_CustomFieldSalesOrderLineGroupLineCycleCount, Original_CustomFieldCollect, Original_CustomFieldPPDCOL, Original_CustomFieldRep, Original_CustomFieldShipDate, Original_CustomFieldShipVia);
	}
}
