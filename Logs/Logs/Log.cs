#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Logs;

public class Log
{
	private const string separator = "<---------------------------------{0}------------------------------->";

	protected const string ctMessageHeader = "MESSAGE";

	protected const string ctErrorHeader = "ERROR";

	protected static string appName = "";

	protected static string extraMessageLine = "";

	public static bool logAssemblyVersion = false;

	public static int MaxLogSize
	{
		get
		{
			return FileSplitter.MaxLogSize;
		}
		set
		{
			FileSplitter.MaxLogSize = value;
		}
	}

	public static string ApplicationName
	{
		get
		{
			return appName;
		}
		set
		{
			appName = value;
		}
	}

	public static string ExtraLineMessage
	{
		get
		{
			return extraMessageLine;
		}
		set
		{
			extraMessageLine = value;
		}
	}

	public static bool LogAssemblyVersion
	{
		get
		{
			return logAssemblyVersion;
		}
		set
		{
			logAssemblyVersion = value;
		}
	}

	protected static void Add(string message, string header, bool showMessage)
	{
		StreamWriter streamWriter = null;
		new Process();
		try
		{
			string logFileName = FileSplitter.GetLogFileName();
			streamWriter = ((!File.Exists(logFileName)) ? new StreamWriter(logFileName) : new StreamWriter(logFileName, append: true, Encoding.UTF8, 512));
			string value = $"<---------------------------------{header}------------------------------->";
			streamWriter.WriteLine(value);
			if (LogAssemblyVersion)
			{
				Type type = null;
				type = GetCallingType();
				if (type != null)
				{
					try
					{
						Assembly assembly = Assembly.GetAssembly(type);
						streamWriter.WriteLine(appName + " : " + assembly.GetName().Name + " version " + assembly.GetName().Version.ToString());
					}
					catch
					{
					}
				}
			}
			if (extraMessageLine != null && extraMessageLine.Trim() != "")
			{
				streamWriter.WriteLine(extraMessageLine);
			}
			streamWriter.WriteLine(DateTime.Now.ToString());
			streamWriter.WriteLine(message);
			streamWriter.WriteLine(value);
			streamWriter.WriteLine("\n");
			Trace.WriteLine(header + ":\n" + message);
			streamWriter.Close();
			streamWriter = null;
		}
		catch
		{
			// Silently swallow logging failures — never block the user
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	protected static string GetCallingInformation()
	{
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: true);
		string text = "";
		try
		{
			StackFrame frame = stackTrace.GetFrame(2);
			string name = frame.GetMethod().DeclaringType.Name;
			text = frame.GetMethod().Name;
			return name + " " + text;
		}
		catch
		{
			return "";
		}
	}

	protected static Type GetCallingType()
	{
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: true);
		try
		{
			for (int i = 0; i < stackTrace.FrameCount; i++)
			{
				StackFrame frame = stackTrace.GetFrame(i);
				if (!frame.GetMethod().DeclaringType.Module.Assembly.Equals(Assembly.GetExecutingAssembly()))
				{
					return frame.GetMethod().DeclaringType;
				}
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static void Add(string message, bool showMessage)
	{
		Add(message, "MESSAGE", showMessage);
	}

	public static void Add(Exception ex, bool showMessage)
	{
		Add(ex.Message, "ERROR", showMessage);
		Add(ex.StackTrace);
	}

	public static void Add(Exception ex, string message, bool showMessage)
	{
		Add(ex, showMessage: false);
		Add(message, showMessage);
	}

	public static void Add(string message)
	{
		Add(message, showMessage: false);
	}

	public static void Add(Exception ex)
	{
		Add(ex, showMessage: false);
	}

	public static void Add(Exception ex, string message)
	{
		Add(ex, message, showMessage: false);
	}
}
