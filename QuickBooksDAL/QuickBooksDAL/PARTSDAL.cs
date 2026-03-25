using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class PARTSDAL
{
	[DebuggerNonUserCode]
	public PARTSDAL()
	{
	}

	public List<Parts> SelectPartTypes(string ReferenceNumber, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchPartTypes(cmd);
	}

	public List<Parts> SelectParts(string AccessConstr)
	{
		OleDbCommand cmd = new OleDbCommand("Select * from Parts", DALUTIL.getAccessConnection(AccessConstr));
		return fetchParts(cmd);
	}

	public Parts SelectPart(string AccessConstr, string PartType)
	{
		OleDbCommand cmd = new OleDbCommand("Select * from Parts where PartType LIKE'%" + PartType + "%'", DALUTIL.getAccessConnection(AccessConstr));
		return fetchParts(cmd)?[0];
	}

	public string SelectWhereNow(string AccessConstr)
	{
		OleDbCommand cmd = new OleDbCommand("Select * from Parts", DALUTIL.getAccessConnection(AccessConstr));
		return WhereNow(cmd);
	}

	public string SelectWhereNowSingleLineItem(string AccessConstr)
	{
		OleDbCommand cmd = new OleDbCommand("Select * from Parts", DALUTIL.getAccessConnection(AccessConstr));
		return WhereNowSingleLineItem(cmd);
	}

	private List<Parts> fetchPartTypes(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<Parts> PartsList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				PartsList = new List<Parts>();
				while (dr.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"])))
					{
						Parts Parts = new Parts();
						Parts.OrderNumberValue = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
						{
							Parts.OrderNumberValue = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"])) + "-" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupSeqNo"])) + "-" + Conversions.ToString(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])));
						}
						Parts.PartType = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
						PartsList.Add(Parts);
					}
				}
				PartsList.TrimExcess();
			}
			return PartsList;
		}
	}

	private List<Parts> fetchParts(OleDbCommand cmd)
	{
		OleDbConnection con = cmd.Connection;
		List<Parts> PartsList = null;
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				PartsList = new List<Parts>();
				while (dr.Read())
				{
					Parts Parts = new Parts();
					Parts.PartType = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["PartType"]));
					PartsList.Add(Parts);
				}
				PartsList.TrimExcess();
			}
			return PartsList;
		}
	}

	private string WhereNowSingleLineItem(OleDbCommand cmd)
	{
		OleDbConnection con = cmd.Connection;
		string wherestr = "";
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while (dr.Read())
				{
					wherestr = wherestr + " or SalesOrderLineItemRefFullName like '%" + dr[0].ToString() + "%'";
				}
			}
			else
			{
				wherestr = " and (SalesOrderLineItemRefFullName like '%" + dr[0].ToString() + "%'";
			}
			return wherestr;
		}
	}

	private string WhereNow(OleDbCommand cmd)
	{
		OleDbConnection con = cmd.Connection;
		string wherestr = "";
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while (dr.Read())
				{
					wherestr = wherestr + " or SalesOrderLineGroupItemGroupRefFullName like '" + dr[0].ToString() + "%'";
				}
			}
			else
			{
				wherestr = " and (SalesOrderLineGroupItemGroupRefFullName like '" + dr[0].ToString() + "%'";
			}
			return wherestr;
		}
	}

	public void Insert(Parts Parts, string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdInsertPart = new OleDbCommand("Insert into Parts (Parttype) Values(?)", con);
		cmdInsertPart.Parameters.AddWithValue("@Parttype", Parts.PartType);
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			cmdInsertPart.ExecuteNonQuery();
		}
	}

	public void Delete(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmdDeletePart = new OleDbCommand("Delete From Parts", con);
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			cmdDeletePart.ExecuteNonQuery();
		}
	}
}
