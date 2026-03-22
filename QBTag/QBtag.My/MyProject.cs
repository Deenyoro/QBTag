using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace QBtag.My;

[GeneratedCode("MyTemplate", "10.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public FormOrdShowU m_FormOrdShowU;

		public FrmAddNewQrCodes m_FrmAddNewQrCodes;

		public FrmConfig m_FrmConfig;

		public FrmCRViewer m_FrmCRViewer;

		public FrmMain m_FrmMain;

		public FrmOrderInfo m_FrmOrderInfo;

		public FrmProducts m_FrmProducts;

		public FrmTestODBC m_FrmTestODBC;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public FormOrdShowU FormOrdShowU
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormOrdShowU = Create__Instance__(m_FormOrdShowU);
				return m_FormOrdShowU;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormOrdShowU)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormOrdShowU);
				}
			}
		}

		public FrmAddNewQrCodes FrmAddNewQrCodes
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmAddNewQrCodes = Create__Instance__(m_FrmAddNewQrCodes);
				return m_FrmAddNewQrCodes;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmAddNewQrCodes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmAddNewQrCodes);
				}
			}
		}

		public FrmConfig FrmConfig
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConfig = Create__Instance__(m_FrmConfig);
				return m_FrmConfig;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConfig);
				}
			}
		}

		public FrmCRViewer FrmCRViewer
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmCRViewer = Create__Instance__(m_FrmCRViewer);
				return m_FrmCRViewer;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmCRViewer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmCRViewer);
				}
			}
		}

		public FrmMain FrmMain
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMain = Create__Instance__(m_FrmMain);
				return m_FrmMain;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMain);
				}
			}
		}

		public FrmOrderInfo FrmOrderInfo
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmOrderInfo = Create__Instance__(m_FrmOrderInfo);
				return m_FrmOrderInfo;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmOrderInfo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmOrderInfo);
				}
			}
		}

		public FrmProducts FrmProducts
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmProducts = Create__Instance__(m_FrmProducts);
				return m_FrmProducts;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmProducts)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmProducts);
				}
			}
		}

		public FrmTestODBC FrmTestODBC
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmTestODBC = Create__Instance__(m_FrmTestODBC);
				return m_FrmTestODBC;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmTestODBC)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmTestODBC);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (Instance.IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string BetterMessage = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(BetterMessage, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
