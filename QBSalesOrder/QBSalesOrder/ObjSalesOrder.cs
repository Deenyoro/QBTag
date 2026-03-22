using System;
using Logs;
using QBFC12Lib;
using QBHelpers;

namespace QBSalesOrder;

public class ObjSalesOrder
{
	public static ISalesOrderRetList GetSalesOrders(string refNo)
	{
		ISalesOrderRetList saleList = null;
		try
		{
			IMsgSetRequest reqSet = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			reqSet.Attributes.OnError = ENRqOnError.roeContinue;
			ISalesOrderQuery query = reqSet.AppendSalesOrderQueryRq();
			query.ORTxnNoAccountQuery.RefNumberList.Add(refNo);
			query.IncludeLineItems.SetValue(val: true);
			query.IncludeLinkedTxns.SetValue(val: true);
			query.OwnerIDList.Add("0");
			IMsgSetResponse response = QBCommunication.QBSessionManager.DoRequests(reqSet);
			saleList = (ISalesOrderRetList)response.ResponseList.GetAt(0).Detail;
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		return saleList;
	}

	public static ISalesOrderRetList GetSalesOrders(string fromRefNo, string toRefNo)
	{
		ISalesOrderRetList saleList = null;
		try
		{
			IMsgSetRequest reqSet = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			reqSet.Attributes.OnError = ENRqOnError.roeContinue;
			ISalesOrderQuery query = reqSet.AppendSalesOrderQueryRq();
			query.ORTxnNoAccountQuery.TxnFilterNoAccount.ORRefNumberFilter.RefNumberRangeFilter.FromRefNumber.SetValue(fromRefNo);
			query.ORTxnNoAccountQuery.TxnFilterNoAccount.ORRefNumberFilter.RefNumberRangeFilter.ToRefNumber.SetValue(toRefNo);
			query.IncludeLineItems.SetValue(val: true);
			query.IncludeLinkedTxns.SetValue(val: true);
			query.OwnerIDList.Add("0");
			IMsgSetResponse response = QBCommunication.QBSessionManager.DoRequests(reqSet);
			saleList = (ISalesOrderRetList)response.ResponseList.GetAt(0).Detail;
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		return saleList;
	}

	public static ISalesOrderRetList GetSalesOrders(DateTime fromDate, DateTime toDate)
	{
		ISalesOrderRetList saleList = null;
		try
		{
			IMsgSetRequest reqSet = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			reqSet.Attributes.OnError = ENRqOnError.roeContinue;
			ISalesOrderQuery query = reqSet.AppendSalesOrderQueryRq();
			query.ORTxnNoAccountQuery.TxnFilterNoAccount.ORDateRangeFilter.TxnDateRangeFilter.ORTxnDateRangeFilter.TxnDateFilter.FromTxnDate.SetValue(fromDate);
			query.ORTxnNoAccountQuery.TxnFilterNoAccount.ORDateRangeFilter.TxnDateRangeFilter.ORTxnDateRangeFilter.TxnDateFilter.ToTxnDate.SetValue(toDate);
			query.IncludeLineItems.SetValue(val: true);
			query.IncludeLinkedTxns.SetValue(val: true);
			query.OwnerIDList.Add("0");
			IMsgSetResponse response = QBCommunication.QBSessionManager.DoRequests(reqSet);
			saleList = (ISalesOrderRetList)response.ResponseList.GetAt(0).Detail;
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		return saleList;
	}
}
