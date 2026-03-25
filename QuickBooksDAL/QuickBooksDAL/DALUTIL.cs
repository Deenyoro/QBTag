using System;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;
using Logs;

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

	/// <summary>
	/// Opens an Access DB connection with logging. Use this instead of raw con.Open()
	/// to get clear error messages when the DB can't be accessed (network drives, permissions, etc.)
	/// </summary>
	internal static void OpenAccessConnection(OleDbConnection con)
	{
		try
		{
			con.Open();
		}
		catch (Exception ex)
		{
			string path = "";
			try { path = con.DataSource; } catch { }
			Log.Add(ex, "Failed to open Access database: " + path);
			throw;
		}
	}

	internal static string gettest(string str)
	{
		str += " from Dal Util";
		return str;
	}
}
