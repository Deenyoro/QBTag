#define TRACE
using System;
using System.Diagnostics;
using System.Reflection;
using QBFC12Lib;

namespace Logs;

public class LogQB : Log
{
	private const string ctQBErrorHeader = "QUICK BOOKS RESPONSE ERROR";

	private static object caller = null;

	private static string methodName = "ErrorHandler";

	private static string error = "";

	public static string SetErrorHandlerName
	{
		set
		{
			methodName = value;
		}
	}

	public static object Caller
	{
		set
		{
			caller = value;
		}
	}

	protected static bool ParseStatusMessage(IResponse resp)
	{
		if (resp.StatusMessage.ToLower().IndexOf("exceeded") > -1 && resp.StatusSeverity.ToUpper() != "OK")
		{
			try
			{
				error = resp.StatusMessage.Replace("QuickBooks error message: ", "\n").Replace("&quot", "\"");
			}
			catch
			{
			}
			RaiseErrorEvent();
			return true;
		}
		return false;
	}

	protected static void RaiseErrorEvent()
	{
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: true);
		try
		{
			MethodInfo methodInfo = null;
			object[] array = new object[1];
			for (int i = 0; i < stackTrace.FrameCount; i++)
			{
				StackFrame frame = stackTrace.GetFrame(i);
				array[0] = error;
				try
				{
					methodInfo = frame.GetMethod().DeclaringType.GetMethod(methodName);
				}
				catch
				{
				}
				if (methodInfo != null)
				{
					i = stackTrace.FrameCount;
					break;
				}
			}
			if (methodInfo != null && caller != null)
			{
				methodInfo.Invoke(caller, array);
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.Message);
		}
	}

	public static void Add(string info, IMsgSetRequest req, IMsgSetResponse resp, bool showMessage)
	{
		bool showMessage2 = false;
		try
		{
			if (resp == null || resp.ResponseList == null || req.RequestList == null)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < resp.ResponseList.Count; i++)
			{
				IResponse at = resp.ResponseList.GetAt(i);
				string text = "";
				string text2 = "";
				if (flag)
				{
					text = "Response log:\n{0}, Severity:\n{1}";
					text2 = string.Format(text, at.StatusMessage, at.StatusSeverity);
				}
				else
				{
					text = "Request log:\n{0} Response log:\n{1}, Severity:\n{2}";
					text2 = string.Format(text, req.ToXMLString(), at.StatusMessage, at.StatusSeverity);
				}
				if (at.StatusCode != 0)
				{
					if (!flag && showMessage)
					{
						showMessage2 = false;
					}
					else if (flag && showMessage)
					{
						showMessage2 = true;
					}
					flag = true;
					if (info == null || info == "")
					{
						Log.Add(text2, "QUICK BOOKS RESPONSE ERROR", showMessage2);
					}
					else
					{
						Log.Add(info + ":" + text2, "QUICK BOOKS RESPONSE ERROR", showMessage2);
					}
				}
				if (ParseStatusMessage(at))
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public static void Add(string info, IMsgSetRequest req, IMsgSetResponse resp)
	{
		Add(info, req, resp, showMessage: false);
	}
}
