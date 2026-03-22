using System;
using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class SalesOrderLineHandler
{
	[DebuggerNonUserCode]
	public SalesOrderLineHandler()
	{
	}

	public List<SalesOrderLine> GetSingleSalesOrderLine(string OrderNumber, string conStr, string AccessconStr)
	{
		return new SALESORDERLINEDAL().SelectSingleLineItem(OrderNumber, conStr, AccessconStr);
	}

	public List<SalesOrderLine> GetSalesOrderLineGroupItems(string OrderNumber, string conStr, string AccessconStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLineGroupItems(OrderNumber, conStr, AccessconStr);
	}

	public List<SalesOrderLine> GetSalesOrderLineOrders(string OrderNumber, string conStr, string AccessconStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLine(OrderNumber, conStr, AccessconStr);
	}

	public List<SalesOrderLine> GetSalesOrderLineOrders(string FromOrderNumber, string ToOrderNumber, string conStr, string AccessconStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLine(FromOrderNumber, ToOrderNumber, conStr, AccessconStr);
	}

	public List<SalesOrderLine> GetSalesOrderLineOrders(DateTime FromDate, DateTime ToDate, string conStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLine(FromDate, ToDate, conStr);
	}

	public SalesOrderLine GetSalesOrderLineOrderBelt(string OrderNumber, string PartType, string conStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLineBelt(OrderNumber, PartType, conStr);
	}

	public SalesOrderLine GetSalesLineOrderLineMotor(string OrderNumber, string PartType, string conStr)
	{
		return new SALESORDERLINEDAL().SelectSalesOrderLineMotor(OrderNumber, PartType, conStr);
	}

	public string GetTest(string str)
	{
		return new SALESORDERLINEDAL().SelectTest(str);
	}
}
