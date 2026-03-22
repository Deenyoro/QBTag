using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class OrderNumberHandler
{
	[DebuggerNonUserCode]
	public OrderNumberHandler()
	{
	}

	public List<OrderNumber> GetOrderNumbers(string RerenceNumber, string conStr)
	{
		return new ORDERNUMBERDAL().SelectOrderNumbers(RerenceNumber, conStr);
	}
}
