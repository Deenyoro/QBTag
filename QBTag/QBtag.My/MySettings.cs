using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace QBtag.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
public sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += AutoSaveSettings;
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("QuickBooks Data")]
	[DebuggerNonUserCode]
	public string QuickBooksDBDataSource
	{
		get
		{
			return Conversions.ToString(this["QuickBooksDBDataSource"]);
		}
		set
		{
			this["QuickBooksDBDataSource"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\PC\\Desktop\\Abanaki Tag Program-with DB edit\\Macola\\usman.mdb")]
	public string AccessDatabaseConnectionString
	{
		get
		{
			return Conversions.ToString(this["AccessDatabaseConnectionString"]);
		}
		set
		{
			this["AccessDatabaseConnectionString"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("C:\\Users\\PC\\Desktop\\Abanaki Tag Program-with DB edit\\Macola\\usman.mdb")]
	public string AccessDBDataSource
	{
		get
		{
			return Conversions.ToString(this["AccessDBDataSource"]);
		}
		set
		{
			this["AccessDBDataSource"] = value;
		}
	}

	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\PC\\Desktop\\Abanaki Tag Program-with DB edit\\Macola\\usman.mdb")]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[ApplicationScopedSetting]
	public string usmanConnectionString => Conversions.ToString(this["usmanConnectionString"]);

	[UserScopedSetting]
	[DefaultSettingValue("Usman")]
	[DebuggerNonUserCode]
	public string QuickBooksUserID
	{
		get
		{
			return Conversions.ToString(this["QuickBooksUserID"]);
		}
		set
		{
			this["QuickBooksUserID"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Usman")]
	[UserScopedSetting]
	public string QuickBooksPassword
	{
		get
		{
			return Conversions.ToString(this["QuickBooksPassword"]);
		}
		set
		{
			this["QuickBooksPassword"] = value;
		}
	}

	[DefaultSettingValue("dsn=QuickBooks Data;uid=Admin;pwd=19Abanaki80;")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string QuickBooksDBConnectionString
	{
		get
		{
			return Conversions.ToString(this["QuickBooksDBConnectionString"]);
		}
		set
		{
			this["QuickBooksDBConnectionString"] = value;
		}
	}

	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\PC\\Desktop\\Abanaki Tag Program-with DB edit\\Macola\\usman.mdb\\usman.mdb")]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string TomConnectionstring1 => Conversions.ToString(this["TomConnectionstring1"]);

	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\usman.mdb")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string JtagsUsmanConnection => Conversions.ToString(this["JtagsUsmanConnection"]);

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
