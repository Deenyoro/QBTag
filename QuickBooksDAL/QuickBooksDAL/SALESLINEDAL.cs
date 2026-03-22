using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class SALESLINEDAL : PARTSDAL
{
	[DebuggerNonUserCode]
	public SALESLINEDAL()
	{
	}

	public List<SalesLine> SelectSalesLineOrders(string ReferenceNumber, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TimeCreated from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesOrderLine(cmd);
	}

	public List<SalesLine> SelectSalesLineOrders(string ReferenceNumber, string SalesLineType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated from SalesLine where SalesLineQuantity>0 AND RefNumber='" + ReferenceNumber.ToString() + "' AND SalesLineType='" + SalesLineType.ToString() + "' GROUP BY RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesLineOrders(cmd, conStr);
	}

	public List<SalesLine> SelectSalesLineOrders(string FromReferenceNumber, string ToReferenceNumber, string SalesLineType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated from SalesLine where SalesLineQuantity>0 AND RefNumber BETWEEN ? AND ? AND SalesLineType='" + SalesLineType.ToString() + "' GROUP BY RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated", DALUTIL.getQuickBooksConnection(conStr));
		cmd.Parameters.AddWithValue("@reference1", FromReferenceNumber);
		cmd.Parameters.AddWithValue("@reference2", ToReferenceNumber);
		return fetchSalesLineOrders(cmd, conStr);
	}

	public SalesLine SelectSalesLineOrder(string ReferenceNumber, string SalesLineType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated from SalesLine where RefNumber='" + ReferenceNumber.ToString() + "' AND SalesLineType='" + SalesLineType.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesLineOrder(cmd)?[0];
	}

	public SalesLine SelectSalesLineOrderBelt(string ReferenceNumber, string SalesLineType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated from SalesLine where SalesLineItemRefFullName LIKE '%BELT%' AND RefNumber='" + ReferenceNumber.ToString() + "' AND SalesLineType='" + SalesLineType.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesLineOrder(cmd)?[0];
	}

	public SalesLine SelectSalesLineOrderMotor(string ReferenceNumber, string SalesLineType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesLineSeqNo,SalesLineType,SalesLineGroupItemGroupRefFullName,SalesLineGroupQuantity,SalesLineItemRefFullName,SalesLineQuantity,TimeCreated from SalesLine where SalesLineItemRefFullName LIKE '%MOTOR%' AND RefNumber='" + ReferenceNumber.ToString() + "' AND SalesLineType='" + SalesLineType.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesLineOrder(cmd)?[0];
	}

	private List<SalesLine> fetchSalesOrderLine(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesLine> SalesLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesLineList = new List<SalesLine>();
				while (dr.Read())
				{
					SalesLine SalesLine = new SalesLine();
					SalesLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])))
					{
						SalesLine.SalesLineSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])));
					}
					else
					{
						SalesLine.SalesLineSeqNo = 0;
					}
					SalesLine.SerialNumber = SalesLine.RefNumber + "-" + Conversions.ToString(SalesLine.SalesLineSeqNo);
					SalesLine.OrderNumber = SalesLine.SerialNumber;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])))
					{
						SalesLine.SalesLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"]));
						string[] ItemName = SalesLine.SalesLineItemRefFullName.Split(':');
						if (Operators.CompareString(ItemName[0].ToString(), "MOTOR", TextCompare: false) == 0)
						{
							SalesLine.Motor = ItemName[1].ToString();
						}
						else
						{
							SalesLine.Motor = "";
						}
						if (ItemName[0].ToString().StartsWith("BELT"))
						{
							SalesLine.Belt = ItemName[1].ToString();
						}
						else
						{
							SalesLine.Belt = "";
						}
					}
					else
					{
						SalesLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
					{
						SalesLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"]));
					}
					else
					{
						SalesLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TimeCreated"])))
					{
						SalesLine.TimeCreated = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TimeCreated"]));
					}
					else
					{
						SalesLine.TimeCreated = DateTime.MinValue;
					}
					SalesLineList.Add(SalesLine);
				}
				SalesLineList.TrimExcess();
			}
			return SalesLineList;
		}
	}

	private List<SalesLine> fetchSalesLineOrders(OdbcCommand cmd, string conStr)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesLine> SalesLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesLineList = new List<SalesLine>();
				while (dr.Read())
				{
					SalesLine SalesLine = new SalesLine();
					SalesLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineSeqNo"])))
					{
						SalesLine.SalesLineSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineSeqNo"])));
					}
					else
					{
						SalesLine.SalesLineSeqNo = 0;
					}
					SalesLine.SerialNumber = SalesLine.RefNumber + "-" + Conversions.ToString(SalesLine.SalesLineSeqNo);
					SalesLine.OrderNumber = SalesLine.SerialNumber;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineType"])))
					{
						SalesLine.SalesLineType = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineType"]));
					}
					else
					{
						SalesLine.SalesLineType = null;
					}
					if (SelectSalesLineOrder(SalesLine.RefNumber, "GroupHeader", conStr).SalesLineGroupItemGroupRefFullName != null)
					{
						SalesLine.PartType = SelectSalesLineOrder(SalesLine.RefNumber, "GroupHeader", conStr).SalesLineGroupItemGroupRefFullName;
					}
					else
					{
						SalesLine.PartType = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineItemRefFullName"])))
					{
						SalesLine.SalesLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineItemRefFullName"]));
						string[] ItemName = SalesLine.SalesLineItemRefFullName.Split(':');
						if (Operators.CompareString(ItemName[0].ToString(), "MOTOR", TextCompare: false) == 0)
						{
							SalesLine.Motor = ItemName[1].ToString();
						}
						else
						{
							SalesLine.Motor = "";
						}
						if (ItemName[0].ToString().StartsWith("BELT"))
						{
							SalesLine.Belt = ItemName[1].ToString();
						}
						else
						{
							SalesLine.Belt = "";
						}
					}
					else
					{
						SalesLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineQuantity"])))
					{
						SalesLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesLineQuantity"]));
					}
					else
					{
						SalesLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TimeCreated"])))
					{
						SalesLine.TimeCreated = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TimeCreated"]));
					}
					else
					{
						SalesLine.TimeCreated = DateTime.MinValue;
					}
					SalesLineList.Add(SalesLine);
				}
				SalesLineList.TrimExcess();
			}
			return SalesLineList;
		}
	}

	private List<SalesLine> fetchSalesLineOrder(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesLine> SalesLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesLineList = new List<SalesLine>();
				while (dr.Read())
				{
					SalesLine SalesLine = new SalesLine();
					SalesLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineSeqNo"])))
					{
						SalesLine.SalesLineSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineSeqNo"])));
					}
					else
					{
						SalesLine.SalesLineSeqNo = 0;
					}
					SalesLine.SerialNumber = SalesLine.RefNumber + "-" + Conversions.ToString(SalesLine.SalesLineSeqNo);
					SalesLine.OrderNumber = SalesLine.SerialNumber;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineType"])))
					{
						SalesLine.SalesLineType = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineType"]));
					}
					else
					{
						SalesLine.SalesLineType = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineGroupItemGroupRefFullName"])))
					{
						SalesLine.SalesLineGroupItemGroupRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineGroupItemGroupRefFullName"]));
					}
					else
					{
						SalesLine.SalesLineGroupItemGroupRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineItemRefFullName"])))
					{
						SalesLine.SalesLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesLineItemRefFullName"]));
						string[] ItemName = SalesLine.SalesLineItemRefFullName.Split(':');
						if (Operators.CompareString(ItemName[0].ToString(), "MOTOR", TextCompare: false) == 0)
						{
							SalesLine.Motor = ItemName[1].ToString();
						}
						if (ItemName[0].ToString().StartsWith("BELT"))
						{
							SalesLine.Belt = ItemName[1].ToString();
						}
					}
					else
					{
						SalesLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesLineQuantity"])))
					{
						SalesLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesLineQuantity"]));
					}
					else
					{
						SalesLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TimeCreated"])))
					{
						SalesLine.TimeCreated = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TimeCreated"]));
					}
					else
					{
						SalesLine.TimeCreated = DateTime.MinValue;
					}
					SalesLineList.Add(SalesLine);
				}
				SalesLineList.TrimExcess();
			}
			return SalesLineList;
		}
	}
}
