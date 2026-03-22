using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;

namespace QuickBooksDAL;

public class DALUTIL
{
	[DebuggerNonUserCode]
	public DALUTIL()
	{
	}

	internal static OdbcConnection getQuickBooksConnection(string conStr)
	{
		return new OdbcConnection(conStr);
	}

	internal static OleDbConnection getAccessConnection(string conStr)
	{
		return new OleDbConnection(conStr);
	}

	internal static string gettest(string str)
	{
		str += " from Dal Util";
		return str;
	}
}
