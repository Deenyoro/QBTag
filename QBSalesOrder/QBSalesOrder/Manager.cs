using System;
using Logs;
using QBHelpers;

namespace QBSalesOrder;

public class Manager
{
	public static bool ConnectToQB()
	{
		bool IsConnect = false;
		try
		{
			QBCommunication.CreateInstance(9);
			QBCommunication.InitManager("ABANAKI");
			QBRegistration regis = new QBRegistration("ABANAKI", null, "{1275AA71-769C-4988-B045-F4C542BE85AA}", null, null, null);
			IsConnect = QBCommunication.QBSessionManager != null;
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		return IsConnect;
	}

	public static void Disconnect()
	{
		try
		{
			QBCommunication.QBSessionManager.CloseConnection();
			QBCommunication.ReleaseManager();
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}
}
