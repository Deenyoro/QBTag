using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class BeltHandler
{
	[DebuggerNonUserCode]
	public BeltHandler()
	{
	}

	public List<Belt> GetBelts(string ReferenceNumber, string conStr)
	{
		return new BELTDAL().SelectBelts(ReferenceNumber, conStr);
	}
}
