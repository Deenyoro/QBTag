using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;

namespace QBtag;

[StandardModule]
internal sealed class ModConnection
{
	public static string ConnString1 = "";

	public static string ConnString2 = "";

	public static string ServerName = "";

	public static string UserName = "";

	public static string Password = "";

	public static string DatabaseName = "";

	public static object GetQuickBooksDBConnectionString()
	{
		string conStr = "dsn=QuickBooks Data;uid=Admin;pwd=Abanaki;";
		string DataSource = MySettingsProperty.Settings.QuickBooksDBDataSource;
		string UserName = MySettingsProperty.Settings.QuickBooksUserID;
		string Password = MySettingsProperty.Settings.QuickBooksPassword;
		return "dsn=" + DataSource + ";uid=" + UserName + ";pwd=" + Password + ";";
	}

	public static object GetAccessDBConnectionString()
	{
		string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\MacolaDatabase.mdb";
		string DataSource = MySettingsProperty.Settings.AccessDBDataSource;
		return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataSource;
	}
}
