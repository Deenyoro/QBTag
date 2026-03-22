using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class SalesLineHandler
{
	[DebuggerNonUserCode]
	public SalesLineHandler()
	{
	}

	public List<SalesLine> GetSalesLineOrders(string OrderNumber, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrders(OrderNumber, conStr);
	}

	public List<SalesLine> GetSalesLineOrders(string OrderNumber, string SalesLineType, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrders(OrderNumber, SalesLineType);
	}

	public List<SalesLine> GetSalesLineOrders(string FromOrderNumber, string ToOrderNumber, string SalesLineType, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrders(FromOrderNumber, ToOrderNumber, SalesLineType);
	}

	public SalesLine GetSalesLineOrder(string OrderNumber, string SalesLineType, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrder(OrderNumber, SalesLineType, conStr);
	}

	public SalesLine GetSalesLineOrderBelt(string OrderNumber, string SalesLineType, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrderBelt(OrderNumber, SalesLineType, conStr);
	}

	public SalesLine GetSalesLineOrderMotor(string OrderNumber, string SalesLineType, string conStr)
	{
		return new SALESLINEDAL().SelectSalesLineOrderMotor(OrderNumber, SalesLineType, conStr);
	}
}
