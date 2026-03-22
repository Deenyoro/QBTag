using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class MOTORDAL
{
	[DebuggerNonUserCode]
	public MOTORDAL()
	{
	}

	public List<Motor> SelectMotors(string ReferenceNumber, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where  SalesOrderLineItemRefFullName LIKE '%MOTOR%' AND RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchMotors(cmd);
	}

	private List<Motor> fetchMotors(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<Motor> MotorList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				MotorList = new List<Motor>();
				while (dr.Read())
				{
					Motor Motor = new Motor();
					Motor.OrderNumberValue = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					string[] ItemName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])).Split(':');
					Motor.MotorValue = ItemName[1].ToString();
					MotorList.Add(Motor);
				}
				MotorList.TrimExcess();
			}
			return MotorList;
		}
	}
}
