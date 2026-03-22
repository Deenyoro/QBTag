using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class BELTDAL
{
	[DebuggerNonUserCode]
	public BELTDAL()
	{
	}

	public List<Belt> SelectBelts(string ReferenceNumber, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where  SalesOrderLineItemRefFullName LIKE '%BELT%' AND RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchBelts(cmd);
	}

	private List<Belt> fetchBelts(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<Belt> BeltList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				BeltList = new List<Belt>();
				while (dr.Read())
				{
					Belt Belt = new Belt();
					Belt.OrderNumberValue = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					string[] ItemName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])).Split(':');
					Belt.BeltValue = ItemName[1].ToString();
					BeltList.Add(Belt);
				}
				BeltList.TrimExcess();
			}
			return BeltList;
		}
	}
}
