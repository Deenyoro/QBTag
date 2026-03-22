using System;
using System.IO;

namespace Logs;

public class ErrorLoggerSender
{
	private static string errorServiceURL = "";

	private static string password = "";

	public static string ErrorReportingServiceURL
	{
		get
		{
			return errorServiceURL;
		}
		set
		{
			errorServiceURL = value;
		}
	}

	public static string WebServicePassword
	{
		get
		{
			return password;
		}
		set
		{
			password = value;
		}
	}

	public static bool Send(string errorLoggerFileName)
	{
		try
		{
			StreamReader streamReader = new StreamReader(errorLoggerFileName);
			streamReader.ReadToEnd();
			streamReader.Close();
			return true;
		}
		catch (Exception ex)
		{
			Log.Add(ex);
			return false;
		}
	}
}
