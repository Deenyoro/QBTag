using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class PartsHandler
{
	[DebuggerNonUserCode]
	public PartsHandler()
	{
	}

	public List<Parts> GetParts(string ReferenceNumber, string conStr, string AccessconStr)
	{
		return new PARTSDAL().SelectPartTypes(ReferenceNumber, conStr);
	}

	public List<Parts> GetParts(string conStr)
	{
		return new PARTSDAL().SelectParts(conStr);
	}

	public string GetWhereNow(string conStr)
	{
		return new PARTSDAL().SelectWhereNow(conStr);
	}

	public void AddPart(Parts Part, string conStr)
	{
		PARTSDAL PD = new PARTSDAL();
		PD.Insert(Part, conStr);
	}

	public void DeletePart(string conStr)
	{
		PARTSDAL PD = new PARTSDAL();
		PD.Delete(conStr);
	}
}
