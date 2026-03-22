using System;
using System.Threading;
using Logs;
using QBFC12Lib;

namespace QBHelpers;

public class QBCommunication
{
	protected static short qbXmlMajorVersion;

	protected static short qbXmlMinorVersion;

	protected static QBCommunication instance;

	protected QBSessionManagerClass qbSessionManager;

	public static short QBXmlMajorVersion
	{
		get
		{
			return qbXmlMajorVersion;
		}
		set
		{
			qbXmlMajorVersion = value;
		}
	}

	public static short QBXmlMinorVersion
	{
		get
		{
			return qbXmlMinorVersion;
		}
		set
		{
			qbXmlMinorVersion = value;
		}
	}

	public static QBCommunication Instance => instance;

	public static QBSessionManagerClass QBSessionManager
	{
		get
		{
			return Instance.qbSessionManager;
		}
		set
		{
			Instance.qbSessionManager = value;
		}
	}

	public QBCommunication()
	{
		qbSessionManager = null;
		QBXmlMajorVersion = 0;
		QBXmlMinorVersion = 0;
	}

	public QBCommunication(short qbXmlMajorVersion)
	{
		qbSessionManager = null;
		QBXmlMajorVersion = qbXmlMajorVersion;
		QBXmlMinorVersion = 0;
	}

	public QBCommunication(short qbXmlMajorVersion, short qbXmlMinorVersion)
	{
		qbSessionManager = null;
		QBXmlMajorVersion = qbXmlMajorVersion;
		QBXmlMinorVersion = qbXmlMinorVersion;
	}

	public static void CreateInstance()
	{
		instance = new QBCommunication();
	}

	public static void CreateInstance(short qbXmlMajorVersion)
	{
		instance = new QBCommunication(qbXmlMajorVersion);
	}

	public static void CreateInstance(short qbXmlMajorVersion, short qbXmlMinorVersion)
	{
		instance = new QBCommunication(qbXmlMajorVersion, qbXmlMinorVersion);
	}

	public static bool IsCreated()
	{
		if (instance == null)
		{
			return false;
		}
		return true;
	}

	public static bool InitManager(string appName)
	{
		if (!IsCreated())
		{
			return false;
		}
		try
		{
			Instance.qbSessionManager = new QBSessionManagerClass();
			Instance.qbSessionManager.OpenConnection("", appName);
			Instance.qbSessionManager.BeginSession("", ENOpenMode.omDontCare);
		}
		catch
		{
			Thread.Sleep(500);
			try
			{
				Instance.qbSessionManager = new QBSessionManagerClass();
				Instance.qbSessionManager.OpenConnection("", appName);
				Instance.qbSessionManager.BeginSession("", ENOpenMode.omDontCare);
			}
			catch (Exception ex)
			{
				Log.Add(ex);
				Instance.qbSessionManager = null;
				return false;
			}
			return true;
		}
		return true;
	}

	public static bool InitManager(string appName, string qbFile)
	{
		if (!IsCreated())
		{
			return false;
		}
		try
		{
			Instance.qbSessionManager = new QBSessionManagerClass();
			Instance.qbSessionManager.OpenConnection("", appName);
			Instance.qbSessionManager.BeginSession(qbFile, ENOpenMode.omDontCare);
		}
		catch (Exception ex)
		{
			Log.Add(ex);
			Instance.qbSessionManager = null;
			return false;
		}
		return true;
	}

	public static bool InitManager(string appName, ENOpenMode openMode)
	{
		if (!IsCreated())
		{
			return false;
		}
		try
		{
			Instance.qbSessionManager = new QBSessionManagerClass();
			Instance.qbSessionManager.OpenConnection("", appName);
			Instance.qbSessionManager.BeginSession("", openMode);
		}
		catch (Exception ex)
		{
			Log.Add(ex);
			Instance.qbSessionManager = null;
			return false;
		}
		return true;
	}

	public static bool InitManager(string appName, string qbFile, ENOpenMode openMode)
	{
		if (!IsCreated())
		{
			return false;
		}
		try
		{
			Instance.qbSessionManager = new QBSessionManagerClass();
			Instance.qbSessionManager.OpenConnection("", appName);
			Instance.qbSessionManager.BeginSession(qbFile, openMode);
		}
		catch (Exception ex)
		{
			Log.Add(ex);
			Instance.qbSessionManager = null;
			return false;
		}
		return true;
	}

	public static bool InitManager(string appID, string appName, string qbFile, ENOpenMode openMode, ENConnectionType connectionType)
	{
		if (!IsCreated())
		{
			return false;
		}
		try
		{
			Instance.qbSessionManager = new QBSessionManagerClass();
			Instance.qbSessionManager.OpenConnection2(appID, appName, connectionType);
			Instance.qbSessionManager.BeginSession(qbFile, openMode);
		}
		catch (Exception ex)
		{
			Log.Add(ex);
			Instance.qbSessionManager = null;
			return false;
		}
		return true;
	}

	public static void InitRegistrationManager(string appName)
	{
		bool flag = false;
		int num = 0;
		while (!flag && num < 5)
		{
			try
			{
				Instance.qbSessionManager = new QBSessionManagerClass();
				Instance.qbSessionManager.OpenConnection("", appName);
				flag = true;
			}
			catch (Exception ex)
			{
				Log.Add(ex);
				Instance.qbSessionManager = null;
				num++;
			}
		}
	}

	public static void ReleaseManager()
	{
		if (!IsCreated())
		{
			return;
		}
		try
		{
			if (Instance.qbSessionManager == null)
			{
				return;
			}
			try
			{
				Instance.qbSessionManager.EndSession();
				Instance.qbSessionManager.CloseConnection();
			}
			catch (Exception ex)
			{
				Log.Add(ex);
			}
			finally
			{
				Instance.qbSessionManager.CloseConnection();
			}
		}
		catch
		{
		}
	}

	public static void ReleaseRegistrationManager()
	{
		try
		{
			if (Instance.qbSessionManager == null)
			{
				return;
			}
			try
			{
				Instance.qbSessionManager.CloseConnection();
			}
			catch (Exception ex)
			{
				Log.Add(ex);
			}
			finally
			{
				Instance.qbSessionManager = null;
			}
		}
		catch
		{
		}
	}
}
