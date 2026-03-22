using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class ORDERNUMBERDAL
{
	[DebuggerNonUserCode]
	public ORDERNUMBERDAL()
	{
	}

	public List<OrderNumber> SelectOrderNumbers(string ReferenceNumber, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchOrderNumbers(cmd);
	}

	private List<OrderNumber> fetchOrderNumbers(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<OrderNumber> OrderNumberList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				OrderNumberList = new List<OrderNumber>();
				while (dr.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
					{
						OrderNumber OrderNumber = new OrderNumber();
						OrderNumber.OrderNumberValue = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"])) + "-" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupSeqNo"])) + "-" + Conversions.ToString(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])));
						OrderNumberList.Add(OrderNumber);
					}
				}
				OrderNumberList.TrimExcess();
			}
			return OrderNumberList;
		}
	}
}
