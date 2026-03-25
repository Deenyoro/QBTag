using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace QBtag.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		// Resolve log4net assembly mismatch: Crystal Reports expects SAP-signed
		// log4net (PublicKeyToken=692fbea5521e1304) but we ship the Apache-signed
		// build (PublicKeyToken=1b44e1d426115821). Redirect at runtime.
		AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
		{
			var name = new System.Reflection.AssemblyName(e.Name);
			if (string.Equals(name.Name, "log4net", StringComparison.OrdinalIgnoreCase))
			{
				string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.dll");
				if (System.IO.File.Exists(path))
					return System.Reflection.Assembly.LoadFrom(path);
			}
			return null;
		};

		if (QBtag.CLI.HasArgs(Args))
		{
			int exitCode = QBtag.CLI.Run(Args);
			Environment.Exit(exitCode);
			return;
		}
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(Args);
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		__ENCAddToList(this);
		IsSingleInstance = false;
		EnableVisualStyles = true;
		SaveMySettingsOnExit = false;
		ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		MainForm = MyProject.Forms.FrmMain;
	}
}
