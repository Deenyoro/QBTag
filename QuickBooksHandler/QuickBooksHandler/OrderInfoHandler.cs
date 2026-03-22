using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class OrderInfoHandler
{
	[DebuggerNonUserCode]
	public OrderInfoHandler()
	{
	}

	public bool CheckOrderNumber(string conStr, string OrderNumber)
	{
		return new ORDERINFODAL().CheckOrder(conStr, OrderNumber);
	}

	public bool CheckOrders(string conStr)
	{
		return new ORDERINFODAL().CheckOrders(conStr);
	}

	public List<OrderInfo> GetOrders(string conStr)
	{
		return new ORDERINFODAL().SelectOrders(conStr);
	}

	public void AddOrderInfo(OrderInfo OrderInfo, string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.Insert(OrderInfo, conStr);
	}

	public void AddMotorOrderInfo(OrderInfo OrderInfo, string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.InsertMotors(OrderInfo, conStr);
	}

	public void AddBeltOrderInfo(OrderInfo OrderInfo, string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.InsertBelts(OrderInfo, conStr);
	}

	public void UpdateOrderInfo(OrderInfo OrderInfo, string conStr, string NewOrderNumber)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.Update(OrderInfo, conStr, NewOrderNumber);
	}

	public void DeleteOrderInfo(string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.Delete(conStr);
	}

	public void DeleteOrderInfo(string conStr, string OrderNumber)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.DeleteOrder(conStr, OrderNumber);
	}

	public void DeleteMotorOrderInfo(string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.DeleteMotors(conStr);
	}

	public void DeleteBeltOrderInfo(string conStr)
	{
		ORDERINFODAL O = new ORDERINFODAL();
		O.DeleteBelts(conStr);
	}
}
