using System;
using System.IO;

namespace Logs;

public class FileSplitter
{
	public const string extension = ".log";

	public const string logName = "ErrorLog";

	public static int logCount = 1;

	public static int fileSize = 1049072;

	public static int MaxLogSize
	{
		get
		{
			return fileSize;
		}
		set
		{
			fileSize = value;
		}
	}

	public static string GetLogFileName()
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(LogDirName());
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			FileInfo[] files = directoryInfo.GetFiles("*.log");
			if (files.Length == 0)
			{
				return LogDirName() + "\\ErrorLog" + logCount + ".log";
			}
			for (int i = 0; i < files.Length; i++)
			{
				string fullName = files[i].FullName;
				int num = 0;
				try
				{
					num = int.Parse(fullName.ToLower().Replace(LogDirName().ToLower() + "\\ErrorLog", "").Replace(".log", ""));
				}
				catch
				{
				}
				if (num >= logCount)
				{
					logCount = num;
				}
			}
			FileInfo fileInfo = new FileInfo(LogDirName() + "\\ErrorLog" + logCount + ".log");
			if (fileInfo.Length >= fileSize)
			{
				logCount++;
			}
			return LogDirName() + "\\ErrorLog" + logCount + ".log";
		}
		catch (Exception)
		{
		}
		return LogDirName() + "\\ErrorLog" + logCount + ".log";
	}

	protected static string LogDirName()
	{
		string dir = AppDomain.CurrentDomain.BaseDirectory + "Log";
		try
		{
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}
		}
		catch
		{
		}
		return dir;
	}

	internal static FileInfo[] GetErrorLoggersList()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(LogDirName());
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
		}
		return directoryInfo.GetFiles("*.log");
	}
}
