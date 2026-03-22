using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class ORDERINFODAL
{
	[DebuggerNonUserCode]
	public ORDERINFODAL()
	{
	}

	public bool CheckOrder(string conStr, string OrderNumber)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Select * from orderinfo where OrderNumber=?", con);
		cmd.Parameters.AddWithValue("@OrderNumber", OrderNumber);
		con.Open();
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				return true;
			}
			return false;
		}
	}

	public bool CheckOrders(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Select * from orderinfo", con);
		con.Open();
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				return true;
			}
			return false;
		}
	}

	public List<OrderInfo> SelectOrders(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Select * from orderinfo Order by OrderNumber", con);
		return fetchOrders(cmd);
	}

	private List<OrderInfo> fetchOrders(OleDbCommand cmd)
	{
		OleDbConnection con = cmd.Connection;
		List<OrderInfo> OrdersList = null;
		con.Open();
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				OrdersList = new List<OrderInfo>();
				while (dr.Read())
				{
					OrderInfo order = new OrderInfo();
					order.OrderNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["OrderNumber"]));
					order.Motor = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["Motor"]));
					order.Belt = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["Belt"]));
					order.PartType = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["PartType"]));
					OrdersList.Add(order);
				}
				OrdersList.TrimExcess();
			}
			return OrdersList;
		}
	}

	public void Insert(OrderInfo OrderInfo, string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdInsertOrderInfo = new OleDbCommand("Insert into OrderInfo (OrderNumber,Motor,Belt,PartType,CopiedNo) Values(?,?,?,?,?)", con);
		cmdInsertOrderInfo.Parameters.AddWithValue("@OrderNumber", OrderInfo.OrderNumber);
		if (OrderInfo.Motor == null)
		{
			OrderInfo.Motor = "";
		}
		if (OrderInfo.Belt == null)
		{
			OrderInfo.Belt = "";
		}
		cmdInsertOrderInfo.Parameters.AddWithValue("@Motor", OrderInfo.Motor);
		cmdInsertOrderInfo.Parameters.AddWithValue("@Belt ", OrderInfo.Belt);
		cmdInsertOrderInfo.Parameters.AddWithValue("@PartType", OrderInfo.PartType);
		cmdInsertOrderInfo.Parameters.AddWithValue("@CopiedNo", OrderInfo.CopiedNo);
		con.Open();
		using (con)
		{
			if (Operators.CompareString(OrderInfo.CopiedNo, "", TextCompare: false) == 0)
			{
				if (!CheckOrder(conStr, OrderInfo.OrderNumber))
				{
					cmdInsertOrderInfo.ExecuteNonQuery();
					return;
				}
				DeleteOrder(conStr, OrderInfo.OrderNumber);
				cmdInsertOrderInfo.ExecuteNonQuery();
			}
			else
			{
				cmdInsertOrderInfo.ExecuteNonQuery();
			}
		}
	}

	public void Update(OrderInfo OrderInfo, string conStr, string NewOrder)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdUpdatetOrderInfo = new OleDbCommand("Update OrderInfo Set OrderNumber=@OrderNo,Motor=@Motor,Belt=@Belt,PartType=@PartType where OrderNumber=@OrderNumber", con);
		cmdUpdatetOrderInfo.Parameters.AddWithValue("@OrderNo", OrderInfo.OrderNumber);
		cmdUpdatetOrderInfo.Parameters.AddWithValue("@Motor", OrderInfo.Motor);
		cmdUpdatetOrderInfo.Parameters.AddWithValue("@Belt ", OrderInfo.Belt);
		cmdUpdatetOrderInfo.Parameters.AddWithValue("@PartType", OrderInfo.PartType);
		cmdUpdatetOrderInfo.Parameters.AddWithValue("@OrderNumber", NewOrder);
		con.Open();
		using (con)
		{
			cmdUpdatetOrderInfo.ExecuteNonQuery();
		}
	}

	public void DeleteOrder(string conStr, string OrderNumber)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Delete from orderinfo where OrderNumber=?", con);
		cmd.Parameters.AddWithValue("@OrderNumber", OrderNumber);
		con.Open();
		using (con)
		{
			cmd.ExecuteNonQuery();
		}
	}

	public void Delete(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Delete from orderinfo", con);
		con.Open();
		using (con)
		{
			cmd.ExecuteNonQuery();
		}
	}

	public void DeleteMotors(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Delete from MotorOrderInfo", con);
		con.Open();
		using (con)
		{
			cmd.ExecuteNonQuery();
		}
	}

	public void DeleteBelts(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("Delete from BeltOrderInfo", con);
		con.Open();
		using (con)
		{
			cmd.ExecuteNonQuery();
		}
	}

	public void InsertMotors(OrderInfo OrderInfo, string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdInsertOrderInfo = new OleDbCommand("Insert into MotorOrderInfo (OrderNumber,Motor,Belt,PartType) Values(?,?,?,?)", con);
		cmdInsertOrderInfo.Parameters.AddWithValue("@OrderNumber", OrderInfo.OrderNumber);
		cmdInsertOrderInfo.Parameters.AddWithValue("@Motor", OrderInfo.Motor);
		cmdInsertOrderInfo.Parameters.AddWithValue("@Belt ", OrderInfo.Belt);
		cmdInsertOrderInfo.Parameters.AddWithValue("@PartType", OrderInfo.PartType);
		con.Open();
		using (con)
		{
			cmdInsertOrderInfo.ExecuteNonQuery();
		}
	}

	public void InsertBelts(OrderInfo OrderInfo, string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdInsertOrderInfo = new OleDbCommand("Insert into BeltOrderInfo (OrderNumber,Motor,Belt,PartType) Values(?,?,?,?)", con);
		cmdInsertOrderInfo.Parameters.AddWithValue("@OrderNumber", OrderInfo.OrderNumber);
		cmdInsertOrderInfo.Parameters.AddWithValue("@Motor", OrderInfo.Motor);
		cmdInsertOrderInfo.Parameters.AddWithValue("@Belt ", OrderInfo.Belt);
		cmdInsertOrderInfo.Parameters.AddWithValue("@PartType", OrderInfo.PartType);
		con.Open();
		using (con)
		{
			cmdInsertOrderInfo.ExecuteNonQuery();
		}
	}
}
