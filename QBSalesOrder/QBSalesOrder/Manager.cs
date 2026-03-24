using System;
using System.Runtime.InteropServices;
using Logs;
using QBHelpers;

namespace QBSalesOrder;

public class Manager
{
	/// <summary>
	/// The last connection error, if any. Null when connection succeeds.
	/// </summary>
	public static Exception LastConnectionError { get; private set; }

	public static bool ConnectToQB()
	{
		LastConnectionError = null;
		bool IsConnect = false;
		try
		{
			QBCommunication.CreateInstance(9);
			QBCommunication.InitManager("ABANAKI");
			QBRegistration regis = new QBRegistration("ABANAKI", null, "{1275AA71-769C-4988-B045-F4C542BE85AA}", null, null, null);
			IsConnect = QBCommunication.QBSessionManager != null;
			if (!IsConnect)
			{
				LastConnectionError = QBCommunication.LastError;
			}
		}
		catch (Exception ex)
		{
			LastConnectionError = ex;
			Log.Add(ex);
		}
		if (!IsConnect)
		{
			string diagnosis = DiagnoseConnectionError(LastConnectionError);
			Log.Add("QuickBooks connection failed. " + diagnosis);
		}
		return IsConnect;
	}

	/// <summary>
	/// Translates a connection exception into a human-readable diagnosis with fix instructions.
	/// </summary>
	public static string DiagnoseConnectionError(Exception ex)
	{
		if (ex == null)
			return "Connection returned null with no exception. QuickBooks may not be running.";

		// COM class not registered — QBFC12 SDK is not installed
		if (ex is COMException comEx)
		{
			unchecked
			{
				switch ((uint)comEx.ErrorCode)
				{
					case 0x80040154: // REGDB_E_CLASSNOTREG
						return "QBFC12 SDK is NOT installed on this computer (COM class not registered).\n\n"
							+ "QBTag requires the QuickBooks SDK (QBFC12), not QODBC.\n"
							+ "Download it from: https://developer.intuit.com/app/developer/qbdesktop/docs/get-started/download-and-install-the-sdk\n\n"
							+ "After installing, restart your computer and try again.";

					case 0x80040150: // REGDB_E_READREGDB — registry read error
						return "Cannot read COM registration for QBFC12 SDK (registry error).\n"
							+ "Try running QBTag as Administrator, or reinstall the QuickBooks SDK.";

					case 0x80040111: // CLASS_E_CLASSNOTAVAILABLE
						return "QBFC12 SDK COM class is not available.\n"
							+ "The SDK may be partially installed. Reinstall the QuickBooks Desktop SDK (QBFC12).";

					case 0x80080005: // CO_E_SERVER_EXEC_FAILURE
						return "QuickBooks COM server failed to start.\n"
							+ "Make sure QuickBooks Desktop is installed and not corrupted. Try 'Run as Administrator'.";

					case 0x8007007E: // ERROR_MOD_NOT_FOUND
						return "QBFC12 SDK is installed but a required DLL is missing (QBXMLRP2).\n\n"
							+ "This usually means QuickBooks Desktop is not installed on this computer.\n"
							+ "The SDK alone is not enough — QuickBooks Desktop must be installed and running.";

					case 0x80010108: // RPC_E_DISCONNECTED
						return "Lost connection to QuickBooks (RPC disconnected).\n"
							+ "QuickBooks may have closed or crashed. Restart QuickBooks and try again.";

					case 0x8004041D: // QB-specific: application denied access
						return "QuickBooks denied access to QBTag.\n"
							+ "Open QuickBooks > Edit > Preferences > Integrated Applications and make sure 'ABANAKI' is allowed.";

					default:
						return "COM error 0x" + ((uint)comEx.ErrorCode).ToString("X8") + ": " + comEx.Message + "\n"
							+ "This may indicate a QuickBooks SDK installation issue.";
				}
			}
		}

		// Generic exception — include the full message
		string msg = ex.Message;
		if (msg.Contains("8007007E") || msg.Contains("module could not be found"))
		{
			return "QBFC12 SDK is installed but a required DLL is missing (QBXMLRP2).\n\n"
				+ "This usually means QuickBooks Desktop is not installed on this computer.\n"
				+ "The SDK alone is not enough — QuickBooks Desktop must be installed and running.";
		}

		if (msg.Contains("80040154") || msg.Contains("REGDB_E_CLASSNOTREG") || msg.Contains("Class not registered"))
		{
			return "QBFC12 SDK is NOT installed on this computer.\n\n"
				+ "QBTag requires the QuickBooks SDK (QBFC12), not QODBC.\n"
				+ "Download it from: https://developer.intuit.com/app/developer/qbdesktop/docs/get-started/download-and-install-the-sdk\n\n"
				+ "After installing, restart your computer and try again.";
		}

		return "Error: " + msg + "\n\nCheck the log files for more details (QBTag --logs).";
	}

	public static void Disconnect()
	{
		try
		{
			if (QBCommunication.Instance == null || QBCommunication.QBSessionManager == null)
				return;
			QBCommunication.QBSessionManager.CloseConnection();
			QBCommunication.ReleaseManager();
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}
}
