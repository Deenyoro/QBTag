using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Logs;
using QBSalesOrder;
using QBtag.MacolaReportsTableAdapters;
using QBtag.My;
using QuickBooksHandler;
using QuickBooksModel;

namespace QBtag;

[DesignerGenerated]
public class FrmMain : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("MainMenu")]
	private MenuStrip _MainMenu;

	[AccessedThroughProperty("MenuItemTool")]
	private ToolStripMenuItem _MenuItemTool;

	[AccessedThroughProperty("chkUk")]
	private CheckBox _chkUk;

	[AccessedThroughProperty("rbOrderNumber")]
	private RadioButton _rbOrderNumber;

	[AccessedThroughProperty("rbOrderNumbers")]
	private RadioButton _rbOrderNumbers;

	[AccessedThroughProperty("rbUseDates")]
	private RadioButton _rbUseDates;

	[AccessedThroughProperty("chkDelete")]
	private CheckBox _chkDelete;

	[AccessedThroughProperty("chkHist")]
	private CheckBox _chkHist;

	[AccessedThroughProperty("chkPrint")]
	private CheckBox _chkPrint;

	[AccessedThroughProperty("chkPreviewLabels")]
	private CheckBox _chkPreviewLabels;

	[AccessedThroughProperty("btnExport")]
	private Button _btnExport;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("btnReprint")]
	private Button _btnReprint;

	[AccessedThroughProperty("ProgressProcessing")]
	private ProgressBar _ProgressProcessing;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("dtFrom")]
	private DateTimePicker _dtFrom;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	[AccessedThroughProperty("dtTo")]
	private DateTimePicker _dtTo;

	[AccessedThroughProperty("lblAnd")]
	private Label _lblAnd;

	[AccessedThroughProperty("txtOrderStart")]
	private TextBox _txtOrderStart;

	[AccessedThroughProperty("txtOrderEnd")]
	private TextBox _txtOrderEnd;

	[AccessedThroughProperty("txtOrder")]
	private TextBox _txtOrder;

	[AccessedThroughProperty("MenuItemConfigureDatabases")]
	private ToolStripMenuItem _MenuItemConfigureDatabases;

	[AccessedThroughProperty("lblProg")]
	private Label _lblProg;

	[AccessedThroughProperty("btnPopulateQrCodes")]
	private Button _btnPopulateQrCodes;

	[AccessedThroughProperty("lblReportName")]
	private Label _lblReportName;

	[AccessedThroughProperty("cmbReportName")]
	private ComboBox _cmbReportName;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("MenuItemConfigureQRCodes")]
	private ToolStripMenuItem _MenuItemConfigureQRCodes;

	private ToolStripMenuItem _MenuItemManageReports;

	[AccessedThroughProperty("chkUseAero")]
	private CheckBox _chkUseAero;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ViewOrderWithQRCodeTableAdapter1")]
	private ViewOrderWithQRCodeTableAdapter _ViewOrderWithQRCodeTableAdapter1;

	[AccessedThroughProperty("btnLoadProduct")]
	private Button _btnLoadProduct;

	private DataSet DbDataset;

	private DataSet Ds;

	private DataSet DsNow;

	private DataSet DsHistory;

	private DataSet DsRs;

	private DataSet checkrs;

	private DataSet RsOrdLin;

	private bool SearchOption;

	private string[] ConnStr1;

	private long OrderNo;

	private bool Multiple;

	private string Motor;

	private string Order;

	private string Belt;

	private string Serial;

	private string MyType;

	private string NewSerial;

	private bool History;

	private int MyLength;

	private string BuildNo;

	private int i;

	private long myCounter;

	private Hashtable hashProduct;

	public string ConnectionString;

	public string ConnectionString2;

	public object conStr;

	public string WhereNow;

	public string PdfPath;

	public string ExcelPath;

	public OleDbCommand DbCommand;

	public OleDbCommand DbCommand2;

	public OleDbCommand DbCommand3;

	public OleDbCommand DbCommand4;

	public OleDbCommand DbCommand5;

	public OleDbConnection DbConnection;

	public OleDbConnection DbConnection2;

	public OleDbDataAdapter DbDataAdapter;

	public OleDbDataAdapter DbDataAdapter2;

	public OleDbDataAdapter DbDataAdapter3;

	public OleDbDataAdapter DbDataAdapter4;

	public OleDbDataAdapter DbDataAdapter5;

	public DataTable DbDataTable;

	private byte[] m_barrImg;

	private long m_lImageFileLength;

	internal virtual MenuStrip MainMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _MainMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MainMenu = value;
		}
	}

	internal virtual ToolStripMenuItem MenuItemTool
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuItemTool;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuItemTool = value;
		}
	}

	internal virtual CheckBox chkUk
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUk = value;
		}
	}

	internal virtual RadioButton rbOrderNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbOrderNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = rbOrderNumber_CheckedChanged;
			if (_rbOrderNumber != null)
			{
				_rbOrderNumber.CheckedChanged -= value2;
			}
			_rbOrderNumber = value;
			if (_rbOrderNumber != null)
			{
				_rbOrderNumber.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton rbOrderNumbers
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbOrderNumbers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = rbOrderNumbers_CheckedChanged;
			if (_rbOrderNumbers != null)
			{
				_rbOrderNumbers.CheckedChanged -= value2;
			}
			_rbOrderNumbers = value;
			if (_rbOrderNumbers != null)
			{
				_rbOrderNumbers.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton rbUseDates
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbUseDates;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = rbUseDates_CheckedChanged;
			if (_rbUseDates != null)
			{
				_rbUseDates.CheckedChanged -= value2;
			}
			_rbUseDates = value;
			if (_rbUseDates != null)
			{
				_rbUseDates.CheckedChanged += value2;
			}
		}
	}

	internal virtual CheckBox chkDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkDelete = value;
		}
	}

	internal virtual CheckBox chkHist
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkHist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkHist = value;
		}
	}

	internal virtual CheckBox chkPrint
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkPrint = value;
		}
	}

	internal virtual CheckBox chkPreviewLabels
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkPreviewLabels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkPreviewLabels = value;
		}
	}

	internal virtual Button btnExport
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnExport_Click;
			if (_btnExport != null)
			{
				_btnExport.Click -= value2;
			}
			_btnExport = value;
			if (_btnExport != null)
			{
				_btnExport.Click += value2;
			}
		}
	}

	internal virtual Button btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnClose_Click;
			if (_btnClose != null)
			{
				_btnClose.Click -= value2;
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				_btnClose.Click += value2;
			}
		}
	}

	internal virtual Button btnReprint
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnReprint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnReprint_Click;
			if (_btnReprint != null)
			{
				_btnReprint.Click -= value2;
			}
			_btnReprint = value;
			if (_btnReprint != null)
			{
				_btnReprint.Click += value2;
			}
		}
	}

	internal virtual ProgressBar ProgressProcessing
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressProcessing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressProcessing = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual DateTimePicker dtFrom
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtFrom = value;
		}
	}

	internal virtual Label lblTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTo = value;
		}
	}

	internal virtual DateTimePicker dtTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtTo = value;
		}
	}

	internal virtual Label lblAnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAnd = value;
		}
	}

	internal virtual TextBox txtOrderStart
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrderStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrderStart = value;
		}
	}

	internal virtual TextBox txtOrderEnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrderEnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrderEnd = value;
		}
	}

	internal virtual TextBox txtOrder
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrder = value;
		}
	}

	internal virtual ToolStripMenuItem MenuItemConfigureDatabases
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuItemConfigureDatabases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = MenuItemConfigureDatabases_Click;
			if (_MenuItemConfigureDatabases != null)
			{
				_MenuItemConfigureDatabases.Click -= value2;
			}
			_MenuItemConfigureDatabases = value;
			if (_MenuItemConfigureDatabases != null)
			{
				_MenuItemConfigureDatabases.Click += value2;
			}
		}
	}

	internal virtual Label lblProg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProg = value;
		}
	}

	internal virtual Button btnPopulateQrCodes
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPopulateQrCodes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnPopulateQrCodes_Click;
			if (_btnPopulateQrCodes != null)
			{
				_btnPopulateQrCodes.Click -= value2;
			}
			_btnPopulateQrCodes = value;
			if (_btnPopulateQrCodes != null)
			{
				_btnPopulateQrCodes.Click += value2;
			}
		}
	}

	internal virtual Label lblReportName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblReportName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblReportName = value;
		}
	}

	internal virtual ComboBox cmbReportName
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbReportName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbReportName = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= value2;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem MenuItemConfigureQRCodes
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuItemConfigureQRCodes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = MenuItemConfigureQRCodes_Click;
			if (_MenuItemConfigureQRCodes != null)
			{
				_MenuItemConfigureQRCodes.Click -= value2;
			}
			_MenuItemConfigureQRCodes = value;
			if (_MenuItemConfigureQRCodes != null)
			{
				_MenuItemConfigureQRCodes.Click += value2;
			}
		}
	}

	internal virtual CheckBox chkUseAero
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUseAero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = chkUseAero_CheckedChanged;
			if (_chkUseAero != null)
			{
				_chkUseAero.CheckedChanged -= value2;
			}
			_chkUseAero = value;
			if (_chkUseAero != null)
			{
				_chkUseAero.CheckedChanged += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button2_Click;
			if (_Button2 != null)
			{
				_Button2.Click -= value2;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				_Button2.Click += value2;
			}
		}
	}

	internal virtual ViewOrderWithQRCodeTableAdapter ViewOrderWithQRCodeTableAdapter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewOrderWithQRCodeTableAdapter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ViewOrderWithQRCodeTableAdapter1 = value;
		}
	}

	internal virtual Button btnLoadProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLoadProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnLoadProduct_Click;
			if (_btnLoadProduct != null)
			{
				_btnLoadProduct.Click -= value2;
			}
			_btnLoadProduct = value;
			if (_btnLoadProduct != null)
			{
				_btnLoadProduct.Click += value2;
			}
		}
	}

	public FrmMain()
	{
		base.Load += FrmMain_Load;
		base.FormClosing += FrmMain_FormClosing;
		__ENCAddToList(this);
		ConnectionString = "";
		ConnectionString2 = "";
		conStr = MySettingsProperty.Settings.QuickBooksDBConnectionString;
		m_lImageFileLength = 0L;
		InitializeComponent();
	}

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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.MainMenu = new System.Windows.Forms.MenuStrip();
		this.MenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuItemConfigureDatabases = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuItemConfigureQRCodes = new System.Windows.Forms.ToolStripMenuItem();
		this.chkUk = new System.Windows.Forms.CheckBox();
		this.rbOrderNumber = new System.Windows.Forms.RadioButton();
		this.rbOrderNumbers = new System.Windows.Forms.RadioButton();
		this.rbUseDates = new System.Windows.Forms.RadioButton();
		this.chkDelete = new System.Windows.Forms.CheckBox();
		this.chkHist = new System.Windows.Forms.CheckBox();
		this.chkPrint = new System.Windows.Forms.CheckBox();
		this.chkPreviewLabels = new System.Windows.Forms.CheckBox();
		this.btnExport = new System.Windows.Forms.Button();
		this.btnClose = new System.Windows.Forms.Button();
		this.btnReprint = new System.Windows.Forms.Button();
		this.ProgressProcessing = new System.Windows.Forms.ProgressBar();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.dtFrom = new System.Windows.Forms.DateTimePicker();
		this.lblTo = new System.Windows.Forms.Label();
		this.dtTo = new System.Windows.Forms.DateTimePicker();
		this.lblAnd = new System.Windows.Forms.Label();
		this.txtOrderStart = new System.Windows.Forms.TextBox();
		this.txtOrderEnd = new System.Windows.Forms.TextBox();
		this.txtOrder = new System.Windows.Forms.TextBox();
		this.lblProg = new System.Windows.Forms.Label();
		this.btnPopulateQrCodes = new System.Windows.Forms.Button();
		this.lblReportName = new System.Windows.Forms.Label();
		this.cmbReportName = new System.Windows.Forms.ComboBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.chkUseAero = new System.Windows.Forms.CheckBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.ViewOrderWithQRCodeTableAdapter1 = new QBtag.MacolaReportsTableAdapters.ViewOrderWithQRCodeTableAdapter();
		this.btnLoadProduct = new System.Windows.Forms.Button();
		this.MainMenu.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.SuspendLayout();
		this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.MenuItemTool });
		System.Windows.Forms.MenuStrip mainMenu = this.MainMenu;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		mainMenu.Location = location;
		this.MainMenu.Name = "MainMenu";
		System.Windows.Forms.MenuStrip mainMenu2 = this.MainMenu;
		System.Drawing.Size size = new System.Drawing.Size(312, 24);
		mainMenu2.Size = size;
		this.MainMenu.TabIndex = 0;
		this.MainMenu.Text = "MenuStrip1";
		this._MenuItemManageReports = new System.Windows.Forms.ToolStripMenuItem();
		this._MenuItemManageReports.Name = "MenuItemManageReports";
		this._MenuItemManageReports.Size = new System.Drawing.Size(200, 22);
		this._MenuItemManageReports.Text = "Manage Reports";
		this._MenuItemManageReports.Click += MenuItemManageReports_Click;
		this.MenuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.MenuItemConfigureDatabases, this.MenuItemConfigureQRCodes, this._MenuItemManageReports });
		this.MenuItemTool.Name = "MenuItemTool";
		System.Windows.Forms.ToolStripMenuItem menuItemTool = this.MenuItemTool;
		size = new System.Drawing.Size(48, 20);
		menuItemTool.Size = size;
		this.MenuItemTool.Text = "Tools";
		this.MenuItemConfigureDatabases.Name = "MenuItemConfigureDatabases";
		System.Windows.Forms.ToolStripMenuItem menuItemConfigureDatabases = this.MenuItemConfigureDatabases;
		size = new System.Drawing.Size(183, 22);
		menuItemConfigureDatabases.Size = size;
		this.MenuItemConfigureDatabases.Text = "Configure Databases";
		this.MenuItemConfigureQRCodes.Name = "MenuItemConfigureQRCodes";
		System.Windows.Forms.ToolStripMenuItem menuItemConfigureQRCodes = this.MenuItemConfigureQRCodes;
		size = new System.Drawing.Size(183, 22);
		menuItemConfigureQRCodes.Size = size;
		this.MenuItemConfigureQRCodes.Text = "Configure QR Codes";
		this.chkUk.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox = this.chkUk;
		location = new System.Drawing.Point(187, 26);
		checkBox.Location = location;
		this.chkUk.Name = "chkUk";
		System.Windows.Forms.CheckBox checkBox2 = this.chkUk;
		size = new System.Drawing.Size(92, 17);
		checkBox2.Size = size;
		this.chkUk.TabIndex = 1;
		this.chkUk.Text = "Use UK Label";
		this.chkUk.UseVisualStyleBackColor = true;
		this.rbOrderNumber.AutoSize = true;
		System.Windows.Forms.RadioButton radioButton = this.rbOrderNumber;
		location = new System.Drawing.Point(25, 52);
		radioButton.Location = location;
		this.rbOrderNumber.Name = "rbOrderNumber";
		System.Windows.Forms.RadioButton radioButton2 = this.rbOrderNumber;
		size = new System.Drawing.Size(61, 17);
		radioButton2.Size = size;
		this.rbOrderNumber.TabIndex = 2;
		this.rbOrderNumber.TabStop = true;
		this.rbOrderNumber.Text = "Order #";
		this.rbOrderNumber.UseVisualStyleBackColor = true;
		this.rbOrderNumbers.AutoSize = true;
		System.Windows.Forms.RadioButton radioButton3 = this.rbOrderNumbers;
		location = new System.Drawing.Point(25, 75);
		radioButton3.Location = location;
		this.rbOrderNumbers.Name = "rbOrderNumbers";
		System.Windows.Forms.RadioButton radioButton4 = this.rbOrderNumbers;
		size = new System.Drawing.Size(110, 17);
		radioButton4.Size = size;
		this.rbOrderNumbers.TabIndex = 3;
		this.rbOrderNumbers.TabStop = true;
		this.rbOrderNumbers.Text = "Order #s between";
		this.rbOrderNumbers.UseVisualStyleBackColor = true;
		this.rbUseDates.AutoSize = true;
		System.Windows.Forms.RadioButton radioButton5 = this.rbUseDates;
		location = new System.Drawing.Point(25, 98);
		radioButton5.Location = location;
		this.rbUseDates.Name = "rbUseDates";
		System.Windows.Forms.RadioButton radioButton6 = this.rbUseDates;
		size = new System.Drawing.Size(96, 17);
		radioButton6.Size = size;
		this.rbUseDates.TabIndex = 4;
		this.rbUseDates.TabStop = true;
		this.rbUseDates.Text = "Use dates from";
		this.rbUseDates.UseVisualStyleBackColor = true;
		this.chkDelete.AutoSize = true;
		this.chkDelete.Checked = true;
		this.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked;
		System.Windows.Forms.CheckBox checkBox3 = this.chkDelete;
		location = new System.Drawing.Point(25, 157);
		checkBox3.Location = location;
		this.chkDelete.Name = "chkDelete";
		System.Windows.Forms.CheckBox checkBox4 = this.chkDelete;
		size = new System.Drawing.Size(130, 17);
		checkBox4.Size = size;
		this.chkDelete.TabIndex = 5;
		this.chkDelete.Text = "Delete old export data";
		this.chkDelete.UseVisualStyleBackColor = true;
		this.chkHist.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox5 = this.chkHist;
		location = new System.Drawing.Point(25, 180);
		checkBox5.Location = location;
		this.chkHist.Name = "chkHist";
		System.Windows.Forms.CheckBox checkBox6 = this.chkHist;
		size = new System.Drawing.Size(95, 17);
		checkBox6.Size = size;
		this.chkHist.TabIndex = 6;
		this.chkHist.Text = "Search History";
		this.chkHist.UseVisualStyleBackColor = true;
		this.chkPrint.AutoSize = true;
		this.chkPrint.Checked = true;
		this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
		System.Windows.Forms.CheckBox checkBox7 = this.chkPrint;
		location = new System.Drawing.Point(25, 203);
		checkBox7.Location = location;
		this.chkPrint.Name = "chkPrint";
		System.Windows.Forms.CheckBox checkBox8 = this.chkPrint;
		size = new System.Drawing.Size(81, 17);
		checkBox8.Size = size;
		this.chkPrint.TabIndex = 7;
		this.chkPrint.Text = "Print Labels";
		this.chkPrint.UseVisualStyleBackColor = true;
		this.chkPreviewLabels.AutoSize = true;
		this.chkPreviewLabels.Checked = true;
		this.chkPreviewLabels.CheckState = System.Windows.Forms.CheckState.Checked;
		System.Windows.Forms.CheckBox checkBox9 = this.chkPreviewLabels;
		location = new System.Drawing.Point(150, 203);
		checkBox9.Location = location;
		this.chkPreviewLabels.Name = "chkPreviewLabels";
		System.Windows.Forms.CheckBox checkBox10 = this.chkPreviewLabels;
		size = new System.Drawing.Size(98, 17);
		checkBox10.Size = size;
		this.chkPreviewLabels.TabIndex = 8;
		this.chkPreviewLabels.Text = "Preview Labels";
		this.chkPreviewLabels.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button = this.btnExport;
		location = new System.Drawing.Point(25, 252);
		button.Location = location;
		this.btnExport.Name = "btnExport";
		System.Windows.Forms.Button button2 = this.btnExport;
		size = new System.Drawing.Size(75, 23);
		button2.Size = size;
		this.btnExport.TabIndex = 9;
		this.btnExport.Text = "Export";
		this.btnExport.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button3 = this.btnClose;
		location = new System.Drawing.Point(106, 252);
		button3.Location = location;
		this.btnClose.Name = "btnClose";
		System.Windows.Forms.Button button4 = this.btnClose;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnClose.TabIndex = 10;
		this.btnClose.Text = "Close";
		this.btnClose.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button5 = this.btnReprint;
		location = new System.Drawing.Point(187, 252);
		button5.Location = location;
		this.btnReprint.Name = "btnReprint";
		System.Windows.Forms.Button button6 = this.btnReprint;
		size = new System.Drawing.Size(75, 23);
		button6.Size = size;
		this.btnReprint.TabIndex = 11;
		this.btnReprint.Text = "Reprint";
		this.btnReprint.UseVisualStyleBackColor = true;
		System.Windows.Forms.ProgressBar progressProcessing = this.ProgressProcessing;
		location = new System.Drawing.Point(17, 295);
		progressProcessing.Location = location;
		this.ProgressProcessing.Name = "ProgressProcessing";
		System.Windows.Forms.ProgressBar progressProcessing2 = this.ProgressProcessing;
		size = new System.Drawing.Size(285, 23);
		progressProcessing2.Size = size;
		this.ProgressProcessing.TabIndex = 12;
		System.Windows.Forms.PictureBox pictureBox = this.PictureBox1;
		location = new System.Drawing.Point(0, 245);
		pictureBox.Location = location;
		this.PictureBox1.Name = "PictureBox1";
		System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox1;
		size = new System.Drawing.Size(25, 30);
		pictureBox2.Size = size;
		this.PictureBox1.TabIndex = 13;
		this.PictureBox1.TabStop = false;
		this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dateTimePicker = this.dtFrom;
		location = new System.Drawing.Point(118, 98);
		dateTimePicker.Location = location;
		this.dtFrom.Name = "dtFrom";
		System.Windows.Forms.DateTimePicker dateTimePicker2 = this.dtFrom;
		size = new System.Drawing.Size(82, 20);
		dateTimePicker2.Size = size;
		this.dtFrom.TabIndex = 14;
		this.lblTo.AutoSize = true;
		System.Windows.Forms.Label label = this.lblTo;
		location = new System.Drawing.Point(206, 105);
		label.Location = location;
		this.lblTo.Name = "lblTo";
		System.Windows.Forms.Label label2 = this.lblTo;
		size = new System.Drawing.Size(16, 13);
		label2.Size = size;
		this.lblTo.TabIndex = 15;
		this.lblTo.Text = "to";
		this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dateTimePicker3 = this.dtTo;
		location = new System.Drawing.Point(228, 101);
		dateTimePicker3.Location = location;
		this.dtTo.Name = "dtTo";
		System.Windows.Forms.DateTimePicker dateTimePicker4 = this.dtTo;
		size = new System.Drawing.Size(82, 20);
		dateTimePicker4.Size = size;
		this.dtTo.TabIndex = 16;
		this.lblAnd.AutoSize = true;
		System.Windows.Forms.Label label3 = this.lblAnd;
		location = new System.Drawing.Point(206, 75);
		label3.Location = location;
		this.lblAnd.Name = "lblAnd";
		System.Windows.Forms.Label label4 = this.lblAnd;
		size = new System.Drawing.Size(25, 13);
		label4.Size = size;
		this.lblAnd.TabIndex = 17;
		this.lblAnd.Text = "and";
		System.Windows.Forms.TextBox textBox = this.txtOrderStart;
		location = new System.Drawing.Point(133, 72);
		textBox.Location = location;
		this.txtOrderStart.Name = "txtOrderStart";
		System.Windows.Forms.TextBox textBox2 = this.txtOrderStart;
		size = new System.Drawing.Size(74, 20);
		textBox2.Size = size;
		this.txtOrderStart.TabIndex = 18;
		System.Windows.Forms.TextBox textBox3 = this.txtOrderEnd;
		location = new System.Drawing.Point(228, 72);
		textBox3.Location = location;
		this.txtOrderEnd.Name = "txtOrderEnd";
		System.Windows.Forms.TextBox textBox4 = this.txtOrderEnd;
		size = new System.Drawing.Size(74, 20);
		textBox4.Size = size;
		this.txtOrderEnd.TabIndex = 19;
		System.Windows.Forms.TextBox textBox5 = this.txtOrder;
		location = new System.Drawing.Point(81, 49);
		textBox5.Location = location;
		this.txtOrder.Name = "txtOrder";
		System.Windows.Forms.TextBox textBox6 = this.txtOrder;
		size = new System.Drawing.Size(119, 20);
		textBox6.Size = size;
		this.txtOrder.TabIndex = 20;
		this.lblProg.AutoSize = true;
		System.Windows.Forms.Label label5 = this.lblProg;
		location = new System.Drawing.Point(19, 279);
		label5.Location = location;
		this.lblProg.Name = "lblProg";
		System.Windows.Forms.Label label6 = this.lblProg;
		size = new System.Drawing.Size(0, 13);
		label6.Size = size;
		this.lblProg.TabIndex = 21;
		System.Windows.Forms.Button button7 = this.btnPopulateQrCodes;
		location = new System.Drawing.Point(173, 157);
		button7.Location = location;
		this.btnPopulateQrCodes.Name = "btnPopulateQrCodes";
		System.Windows.Forms.Button button8 = this.btnPopulateQrCodes;
		size = new System.Drawing.Size(106, 23);
		button8.Size = size;
		this.btnPopulateQrCodes.TabIndex = 22;
		this.btnPopulateQrCodes.Text = "Populate QRCodes";
		this.btnPopulateQrCodes.UseVisualStyleBackColor = true;
		this.lblReportName.AutoSize = true;
		System.Windows.Forms.Label label7 = this.lblReportName;
		location = new System.Drawing.Point(25, 227);
		label7.Location = location;
		this.lblReportName.Name = "lblReportName";
		System.Windows.Forms.Label label8 = this.lblReportName;
		size = new System.Drawing.Size(70, 13);
		label8.Size = size;
		this.lblReportName.TabIndex = 23;
		this.lblReportName.Text = "Report Name";
		this.cmbReportName.FormattingEnabled = true;
		this.cmbReportName.Items.AddRange(new object[2] { "Tag Report", "Tag Report with QRCodes" });
		System.Windows.Forms.ComboBox comboBox = this.cmbReportName;
		location = new System.Drawing.Point(102, 227);
		comboBox.Location = location;
		this.cmbReportName.Name = "cmbReportName";
		System.Windows.Forms.ComboBox comboBox2 = this.cmbReportName;
		size = new System.Drawing.Size(160, 21);
		comboBox2.Size = size;
		this.cmbReportName.TabIndex = 24;
		System.Windows.Forms.Button button9 = this.Button1;
		location = new System.Drawing.Point(173, 180);
		button9.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button10 = this.Button1;
		size = new System.Drawing.Size(75, 23);
		button10.Size = size;
		this.Button1.TabIndex = 25;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.chkUseAero.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox11 = this.chkUseAero;
		location = new System.Drawing.Point(14, 29);
		checkBox11.Location = location;
		this.chkUseAero.Name = "chkUseAero";
		System.Windows.Forms.CheckBox checkBox12 = this.chkUseAero;
		size = new System.Drawing.Size(70, 17);
		checkBox12.Size = size;
		this.chkUseAero.TabIndex = 26;
		this.chkUseAero.Text = "Use Aero";
		this.chkUseAero.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button11 = this.Button2;
		location = new System.Drawing.Point(218, 0);
		button11.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button12 = this.Button2;
		size = new System.Drawing.Size(94, 20);
		button12.Size = size;
		this.Button2.TabIndex = 27;
		this.Button2.Text = "Edit Order Info";
		this.Button2.UseVisualStyleBackColor = true;
		this.ViewOrderWithQRCodeTableAdapter1.ClearBeforeFill = true;
		System.Windows.Forms.Button button13 = this.btnLoadProduct;
		location = new System.Drawing.Point(118, 0);
		button13.Location = location;
		this.btnLoadProduct.Name = "btnLoadProduct";
		System.Windows.Forms.Button button14 = this.btnLoadProduct;
		size = new System.Drawing.Size(95, 20);
		button14.Size = size;
		this.btnLoadProduct.TabIndex = 28;
		this.btnLoadProduct.Text = "Set Products";
		this.btnLoadProduct.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(312, 324);
		this.ClientSize = size;
		this.Controls.Add(this.btnLoadProduct);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.chkUseAero);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.cmbReportName);
		this.Controls.Add(this.lblReportName);
		this.Controls.Add(this.btnPopulateQrCodes);
		this.Controls.Add(this.lblProg);
		this.Controls.Add(this.txtOrder);
		this.Controls.Add(this.txtOrderEnd);
		this.Controls.Add(this.txtOrderStart);
		this.Controls.Add(this.lblAnd);
		this.Controls.Add(this.dtTo);
		this.Controls.Add(this.lblTo);
		this.Controls.Add(this.dtFrom);
		this.Controls.Add(this.PictureBox1);
		this.Controls.Add(this.ProgressProcessing);
		this.Controls.Add(this.btnReprint);
		this.Controls.Add(this.btnClose);
		this.Controls.Add(this.btnExport);
		this.Controls.Add(this.chkPreviewLabels);
		this.Controls.Add(this.chkPrint);
		this.Controls.Add(this.chkHist);
		this.Controls.Add(this.chkDelete);
		this.Controls.Add(this.rbUseDates);
		this.Controls.Add(this.rbOrderNumbers);
		this.Controls.Add(this.rbOrderNumber);
		this.Controls.Add(this.chkUk);
		this.Controls.Add(this.MainMenu);
		this.MainMenuStrip = this.MainMenu;
		this.Name = "FrmMain";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Export Data - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
		this.MainMenu.ResumeLayout(false);
		this.MainMenu.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	public void QuickBooksProgram(string OrderNo)
	{
		OrderInfoHandler OH = new OrderInfoHandler();
		List<Parts> parts = new PartsHandler().GetParts(MySettingsProperty.Settings.AccessDatabaseConnectionString) ?? new List<Parts>();
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(OrderNo, Conversions.ToString(conStr), MySettingsProperty.Settings.AccessDatabaseConnectionString);
		if (SalesOrderLineList == null)
			return;
		List<OrderInfo> OrderList = new List<OrderInfo>();
		List<OrderInfo> FinalOrderList = new List<OrderInfo>();
		List<OrderInfo> BeltOrdersList = new List<OrderInfo>();
		List<OrderInfo> MotorOrdersList = new List<OrderInfo>();
		List<OrderInfo> OrdersListFinal = new List<OrderInfo>();
		string BeltOrderNumber = "";
		string OrderNumber = "";
		int Quantity = 0;
		OH.DeleteOrderInfo(MySettingsProperty.Settings.AccessDatabaseConnectionString);
		foreach (Parts row in parts)
		{
			foreach (SalesOrderLine item in SalesOrderLineList)
			{
				if (item.SalesOrderLineGroupItemGroupRefFullName == null || !item.SalesOrderLineGroupItemGroupRefFullName.StartsWith(row.PartType))
				{
					continue;
				}
				Quantity = Convert.ToInt32(item.SalesLineQuantity);
				int num = Quantity;
				int i = 1;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					string[] ItemName = (item.SalesOrderLineItemRefFullName ?? "").Split(':');
					if (ItemName.Length > 1 && ItemName[0].StartsWith("M-"))
					{
						item.Motor = ItemName[1];
					}
					else if (ItemName.Length > 1 && ItemName[0].StartsWith("B-"))
					{
						item.Belt = ItemName[1];
					}
					OrderInfo o = new OrderInfo();
					o.OrderNumber = item.RefNumber + "-" + Conversions.ToString(item.SalesOrderLineSeqNo);
					o.PartType = item.PartType;
					o.OrderNumber = o.OrderNumber + "-" + Conversions.ToString(i);
					o.Belt = item.Belt;
					o.Motor = item.Motor;
					o.PartType = item.PartType;
					OH.DeleteOrderInfo(MySettingsProperty.Settings.AccessDatabaseConnectionString);
					if ((Operators.CompareString(o.Motor, "", TextCompare: false) != 0) | (Operators.CompareString(o.Belt, "", TextCompare: false) != 0))
					{
						OrderList.Add(o);
					}
					i = checked(i + 1);
				}
			}
		}
		foreach (OrderInfo m in OrderList)
		{
			if (Operators.CompareString(m.Motor, "", TextCompare: false) != 0)
			{
				OrderInfo o2 = new OrderInfo();
				o2.OrderNumber = m.OrderNumber;
				o2.PartType = m.PartType;
				o2.Motor = m.Motor;
				o2.Belt = m.Belt;
				MotorOrdersList.Add(o2);
			}
		}
		foreach (OrderInfo b in OrderList)
		{
			if (Operators.CompareString(b.Belt, "", TextCompare: false) != 0)
			{
				OrderInfo o3 = new OrderInfo();
				o3.OrderNumber = b.OrderNumber;
				o3.PartType = b.PartType;
				o3.Motor = b.Motor;
				o3.Belt = b.Belt;
				BeltOrdersList.Add(o3);
			}
		}
		foreach (OrderInfo item2 in OrderList)
		{
			OrderInfo o4 = new OrderInfo();
			o4.OrderNumber = item2.OrderNumber;
			o4.PartType = item2.PartType;
			o4.Motor = item2.Motor;
			o4.Belt = item2.Belt;
			o4.CopiedNo = "";
			OH.AddOrderInfo(o4, MySettingsProperty.Settings.AccessDatabaseConnectionString);
			CheckCopied(o4, OH);
		}
		foreach (OrderInfo m2 in MotorOrdersList)
		{
			foreach (OrderInfo b2 in BeltOrdersList)
			{
				if (Operators.CompareString(m2.OrderNumber, b2.OrderNumber, TextCompare: false) == 0)
				{
					OrderInfo o5 = new OrderInfo();
					o5.OrderNumber = m2.OrderNumber;
					o5.PartType = m2.PartType;
					o5.Motor = m2.Motor;
					o5.Belt = b2.Belt;
					o5.CopiedNo = "";
					OH.AddOrderInfo(o5, MySettingsProperty.Settings.AccessDatabaseConnectionString);
					CheckCopied(o5, OH);
				}
			}
		}
	}

	private void btnExport_Click(object sender, EventArgs e)
	{
		if (!_qbConnected)
		{
			MessageBox.Show(
				"Not connected to QuickBooks. Please connect first.",
				"QBTag",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning);
			AttemptQBConnection();
			return;
		}
		OrderInfoHandler OH = new OrderInfoHandler();
		List<Parts> parts = new PartsHandler().GetParts(MySettingsProperty.Settings.AccessDatabaseConnectionString) ?? new List<Parts>();
		List<OrderInfo> OrderList = new List<OrderInfo>();
		List<OrderInfo> FinalOrderList = new List<OrderInfo>();
		List<OrderInfo> BeltOrdersList = new List<OrderInfo>();
		List<OrderInfo> MotorOrdersList = new List<OrderInfo>();
		List<OrderInfo> OrdersListFinal = new List<OrderInfo>();
		string BeltOrderNumber = "";
		string OrderNumber = "";
		int Quantity = 0;
		if (chkDelete.Checked)
		{
			OH.DeleteOrderInfo(MySettingsProperty.Settings.AccessDatabaseConnectionString);
		}
		checked
		{
			if (rbOrderNumber.Checked)
			{
				if (Operators.CompareString(txtOrder.Text, "", TextCompare: false) == 0)
				{
					Interaction.MsgBox("You must enter a valid number", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					txtOrder.Focus();
					return;
				}
				ProgressProcessing.Value = 30;
				List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(txtOrder.Text, Conversions.ToString(conStr), MySettingsProperty.Settings.AccessDatabaseConnectionString);
				if (SalesOrderLineList == null)
				{
					Interaction.MsgBox("No order found, the order may already be in history", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					lblProg.Text = "Finished";
					ProgressProcessing.Value = 100;
					return;
				}
				int count = 0;
				Products prds = new Products();
				hashProduct = prds.GetProducts();
				foreach (Parts row in parts)
				{
					foreach (SalesOrderLine item in SalesOrderLineList)
					{
						if (item.SalesOrderLineGroupItemGroupRefFullName != null)
						{
							if (!item.SalesOrderLineGroupItemGroupRefFullName.StartsWith(row.PartType) || !(((double)item.SalesOrderLineGroupSeqNo == Conversions.ToDouble("999")) & (decimal.Compare(item.SalesLineGroupQuantity, 0m) > 0)))
							{
								continue;
							}
							Quantity = Convert.ToInt32(item.SalesLineGroupQuantity);
							int num = Quantity;
							int i = 1;
							while (true)
							{
								int num2 = i;
								int num3 = num;
								if (num2 <= num3)
								{
									OrderInfo o = new OrderInfo();
									if (item.SalesOrderLineSeqNo < 10)
									{
										o.OrderNumber = item.RefNumber + "-0" + Conversions.ToString(item.SalesOrderLineSeqNo);
									}
									else
									{
										o.OrderNumber = item.RefNumber + "-" + Conversions.ToString(item.SalesOrderLineSeqNo);
									}
									if (i < 10)
									{
										o.OrderNumber = o.OrderNumber + "-0" + Conversions.ToString(i);
									}
									else
									{
										o.OrderNumber = o.OrderNumber + "-" + Conversions.ToString(i);
									}
									o.Belt = "";
									o.Motor = "";
									o.Belt = item.Belt;
									o.Motor = item.Motor;
									o.PartType = item.PartType;
									OrderList.Add(o);
									i++;
									continue;
								}
								break;
							}
						}
						else
						{
							if (Operators.CompareString(item.SalesOrderLineGroupItemGroupRefFullName, "", TextCompare: false) != 0)
							{
								continue;
							}
							try
							{
								if (!(item.SalesOrderLineItemRefFullName ?? "").Trim().StartsWith((row.PartType ?? "").Trim()))
								{
									continue;
								}
								Quantity = Convert.ToInt32(item.SalesLineQuantity);
								int num4 = Quantity;
								int i2 = 1;
								while (true)
								{
									int num5 = i2;
									int num3 = num4;
									if (num5 <= num3)
									{
										OrderInfo o2 = new OrderInfo();
										if (item.SalesOrderLineSeqNo < 10)
										{
											o2.OrderNumber = item.RefNumber + "-0" + Conversions.ToString(item.SalesOrderLineSeqNo);
										}
										else
										{
											o2.OrderNumber = item.RefNumber + "-" + Conversions.ToString(item.SalesOrderLineSeqNo);
										}
										o2.PartType = (item.SalesOrderLineItemRefFullName ?? "").Trim();
										if (i2 < 10)
										{
											o2.OrderNumber = o2.OrderNumber + "-0" + Conversions.ToString(i2);
										}
										else
										{
											o2.OrderNumber = o2.OrderNumber + "-" + Conversions.ToString(i2);
										}
										o2.Belt = "";
										o2.Motor = "";
										OrderList.Add(o2);
										i2++;
										continue;
									}
									break;
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Logs.Log.Add(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				foreach (OrderInfo m in OrderList)
				{
					if (Operators.CompareString(m.Motor, "", TextCompare: false) != 0)
					{
						OrderInfo o3 = new OrderInfo();
						o3.OrderNumber = m.OrderNumber;
						o3.PartType = m.PartType;
						o3.Motor = m.Motor;
						o3.Belt = m.Belt;
						MotorOrdersList.Add(o3);
					}
				}
				foreach (OrderInfo b in OrderList)
				{
					if (Operators.CompareString(b.Belt, "", TextCompare: false) != 0)
					{
						OrderInfo o4 = new OrderInfo();
						o4.OrderNumber = b.OrderNumber;
						o4.PartType = b.PartType;
						o4.Motor = b.Motor;
						o4.Belt = b.Belt;
						BeltOrdersList.Add(o4);
					}
				}
				foreach (OrderInfo item2 in OrderList)
				{
					OrderInfo o5 = new OrderInfo();
					o5.OrderNumber = item2.OrderNumber;
					o5.PartType = item2.PartType;
					o5.Motor = item2.Motor;
					o5.Belt = item2.Belt;
					o5.CopiedNo = "";
					OH.AddOrderInfo(o5, MySettingsProperty.Settings.AccessDatabaseConnectionString);
					CheckCopied(o5, OH);
				}
				foreach (OrderInfo m2 in MotorOrdersList)
				{
					foreach (OrderInfo b2 in BeltOrdersList)
					{
						if (Operators.CompareString(m2.OrderNumber, b2.OrderNumber, TextCompare: false) == 0)
						{
							OrderInfo o6 = new OrderInfo();
							o6.OrderNumber = m2.OrderNumber;
							o6.PartType = m2.PartType;
							o6.Motor = m2.Motor;
							o6.Belt = b2.Belt;
							o6.CopiedNo = "";
							OH.AddOrderInfo(o6, MySettingsProperty.Settings.AccessDatabaseConnectionString);
							CheckCopied(o6, OH);
						}
					}
				}
			}
			else if (rbOrderNumbers.Checked)
			{
				if (Operators.CompareString(txtOrderStart.Text, "", TextCompare: false) == 0)
				{
					Interaction.MsgBox("You must enter a valid number", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					txtOrder.Focus();
					return;
				}
				ProgressProcessing.Value = 30;
				if (Operators.CompareString(txtOrderEnd.Text, "", TextCompare: false) == 0)
				{
					Interaction.MsgBox("You must enter a valid number", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					txtOrder.Focus();
					return;
				}
				if (Operators.CompareString(txtOrderEnd.Text, txtOrderStart.Text, TextCompare: false) < 0)
				{
					Interaction.MsgBox("Starting order number should be smaller than the Ending Order Number", MsgBoxStyle.OkOnly, "QBTag");
					txtOrderStart.Focus();
					return;
				}
				ProgressProcessing.Value = 20;
				List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(txtOrderStart.Text, txtOrderEnd.Text, Conversions.ToString(conStr), MySettingsProperty.Settings.AccessDatabaseConnectionString);
				if (SalesOrderLineList == null)
				{
					Interaction.MsgBox("No order found, the order may already be in history", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					lblProg.Text = "Finished";
					ProgressProcessing.Value = 100;
				}
				else
				{
					int count2 = 0;
					foreach (Parts row2 in parts)
					{
						foreach (SalesOrderLine item3 in SalesOrderLineList)
						{
							if (item3.SalesOrderLineGroupItemGroupRefFullName != null)
							{
								if (!item3.SalesOrderLineGroupItemGroupRefFullName.StartsWith(row2.PartType) || !((item3.SalesOrderLineGroupSeqNo == 999) & (decimal.Compare(item3.SalesLineGroupQuantity, 0m) > 0)))
								{
									continue;
								}
								Quantity = Convert.ToInt32(item3.SalesLineGroupQuantity);
								int num6 = Quantity;
								int i3 = 1;
								while (true)
								{
									int num7 = i3;
									int num3 = num6;
									if (num7 <= num3)
									{
										OrderInfo o7 = new OrderInfo();
										if (item3.SalesOrderLineSeqNo < 10)
										{
											o7.OrderNumber = item3.RefNumber + "-0" + Conversions.ToString(item3.SalesOrderLineSeqNo);
										}
										else
										{
											o7.OrderNumber = item3.RefNumber + "-" + Conversions.ToString(item3.SalesOrderLineSeqNo);
										}
										if (i3 < 10)
										{
											o7.OrderNumber = o7.OrderNumber + "-0" + Conversions.ToString(i3);
										}
										else
										{
											o7.OrderNumber = o7.OrderNumber + "-" + Conversions.ToString(i3);
										}
										o7.Belt = "";
										o7.Motor = "";
										o7.Belt = item3.Belt;
										o7.Motor = item3.Motor;
										o7.PartType = item3.PartType;
										OrderList.Add(o7);
										i3++;
										continue;
									}
									break;
								}
							}
							else
							{
								if (Operators.CompareString(item3.SalesOrderLineGroupItemGroupRefFullName, "", TextCompare: false) != 0)
								{
									continue;
								}
								try
								{
									if (!(item3.SalesOrderLineItemRefFullName ?? "").Trim().StartsWith((row2.PartType ?? "").Trim()))
									{
										continue;
									}
									Quantity = Convert.ToInt32(item3.SalesLineQuantity);
									int num8 = Quantity;
									int i4 = 1;
									while (true)
									{
										int num9 = i4;
										int num3 = num8;
										if (num9 <= num3)
										{
											OrderInfo o8 = new OrderInfo();
											if (item3.SalesOrderLineSeqNo < 10)
											{
												o8.OrderNumber = item3.RefNumber + "-0" + Conversions.ToString(item3.SalesOrderLineSeqNo);
											}
											else
											{
												o8.OrderNumber = item3.RefNumber + "-" + Conversions.ToString(item3.SalesOrderLineSeqNo);
											}
											o8.PartType = (item3.SalesOrderLineItemRefFullName ?? "").Trim();
											if (i4 < 10)
											{
												o8.OrderNumber = o8.OrderNumber + "-0" + Conversions.ToString(i4);
											}
											else
											{
												o8.OrderNumber = o8.OrderNumber + "-" + Conversions.ToString(i4);
											}
											o8.Belt = "";
											o8.Motor = "";
											OrderList.Add(o8);
											i4++;
											continue;
										}
										break;
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Logs.Log.Add(ex3);
									Exception ex4 = ex3;
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					foreach (OrderInfo m3 in OrderList)
					{
						if (Operators.CompareString(m3.Motor, "", TextCompare: false) != 0)
						{
							OrderInfo o9 = new OrderInfo();
							o9.OrderNumber = m3.OrderNumber;
							o9.PartType = m3.PartType;
							o9.Motor = m3.Motor;
							o9.Belt = m3.Belt;
							MotorOrdersList.Add(o9);
						}
					}
					foreach (OrderInfo b3 in OrderList)
					{
						if (Operators.CompareString(b3.Belt, "", TextCompare: false) != 0)
						{
							OrderInfo o10 = new OrderInfo();
							o10.OrderNumber = b3.OrderNumber;
							o10.PartType = b3.PartType;
							o10.Motor = b3.Motor;
							o10.Belt = b3.Belt;
							BeltOrdersList.Add(o10);
						}
					}
					foreach (OrderInfo item4 in OrderList)
					{
						OrderInfo o11 = new OrderInfo();
						o11.OrderNumber = item4.OrderNumber;
						o11.PartType = item4.PartType;
						o11.Motor = item4.Motor;
						o11.Belt = item4.Belt;
						o11.CopiedNo = "";
						OH.AddOrderInfo(o11, MySettingsProperty.Settings.AccessDatabaseConnectionString);
						CheckCopied(o11, OH);
					}
					foreach (OrderInfo m4 in MotorOrdersList)
					{
						foreach (OrderInfo b4 in BeltOrdersList)
						{
							if (Operators.CompareString(m4.OrderNumber, b4.OrderNumber, TextCompare: false) == 0)
							{
								OrderInfo o12 = new OrderInfo();
								o12.OrderNumber = m4.OrderNumber;
								o12.PartType = m4.PartType;
								o12.Motor = m4.Motor;
								o12.Belt = b4.Belt;
								o12.CopiedNo = "";
								OH.AddOrderInfo(o12, MySettingsProperty.Settings.AccessDatabaseConnectionString);
								CheckCopied(o12, OH);
							}
						}
					}
				}
			}
			else
			{
				if (DateTime.Compare(dtFrom.Value, DateTime.MinValue) == 0)
				{
					Interaction.MsgBox("You must enter a valid date from", MsgBoxStyle.OkOnly, "QBTag");
					dtFrom.Focus();
					return;
				}
				if (DateTime.Compare(dtTo.Value, DateTime.MinValue) == 0)
				{
					Interaction.MsgBox("You must enter a valid date to", MsgBoxStyle.OkOnly, "QBTag");
					dtTo.Focus();
					return;
				}
				if (DateTime.Compare(dtTo.Value, dtFrom.Value) < 0)
				{
					Interaction.MsgBox("From Date should be smaller than the To Date", MsgBoxStyle.OkOnly, "QBTag");
					dtFrom.Focus();
					return;
				}
				ProgressProcessing.Value = 20;
				List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(dtFrom.Value, dtTo.Value, Conversions.ToString(conStr));
				if (SalesOrderLineList == null)
				{
					Interaction.MsgBox("No order found, the order may already be in history", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
					lblProg.Text = "Finished";
					ProgressProcessing.Value = 100;
				}
				else
				{
					int count3 = 0;
					foreach (Parts row3 in parts)
					{
						foreach (SalesOrderLine item5 in SalesOrderLineList)
						{
							if (item5.SalesOrderLineGroupItemGroupRefFullName != null)
							{
								if (!item5.SalesOrderLineGroupItemGroupRefFullName.StartsWith(row3.PartType) || !((item5.SalesOrderLineGroupSeqNo == 999) & (decimal.Compare(item5.SalesLineGroupQuantity, 0m) > 0)))
								{
									continue;
								}
								Quantity = Convert.ToInt32(item5.SalesLineGroupQuantity);
								int num10 = Quantity;
								int i5 = 1;
								while (true)
								{
									int num11 = i5;
									int num3 = num10;
									if (num11 <= num3)
									{
										OrderInfo o13 = new OrderInfo();
										if (item5.SalesOrderLineSeqNo < 10)
										{
											o13.OrderNumber = item5.RefNumber + "-0" + Conversions.ToString(item5.SalesOrderLineSeqNo);
										}
										else
										{
											o13.OrderNumber = item5.RefNumber + "-" + Conversions.ToString(item5.SalesOrderLineSeqNo);
										}
										if (i5 < 10)
										{
											o13.OrderNumber = o13.OrderNumber + "-0" + Conversions.ToString(i5);
										}
										else
										{
											o13.OrderNumber = o13.OrderNumber + "-" + Conversions.ToString(i5);
										}
										o13.Belt = item5.Belt;
										o13.Motor = item5.Motor;
										o13.PartType = item5.PartType;
										OrderList.Add(o13);
										i5++;
										continue;
									}
									break;
								}
							}
							else
							{
								if (Operators.CompareString(item5.SalesOrderLineGroupItemGroupRefFullName, "", TextCompare: false) != 0)
								{
									continue;
								}
								try
								{
									if (!(item5.SalesOrderLineItemRefFullName ?? "").Trim().StartsWith((row3.PartType ?? "").Trim()))
									{
										continue;
									}
									Quantity = Convert.ToInt32(item5.SalesLineQuantity);
									int num12 = Quantity;
									int i6 = 1;
									while (true)
									{
										int num13 = i6;
										int num3 = num12;
										if (num13 <= num3)
										{
											OrderInfo o14 = new OrderInfo();
											if (item5.SalesOrderLineSeqNo < 10)
											{
												o14.OrderNumber = item5.RefNumber + "-0" + Conversions.ToString(item5.SalesOrderLineSeqNo);
											}
											else
											{
												o14.OrderNumber = item5.RefNumber + "-" + Conversions.ToString(item5.SalesOrderLineSeqNo);
											}
											o14.PartType = (item5.SalesOrderLineItemRefFullName ?? "").Trim();
											if (i6 < 10)
											{
												o14.OrderNumber = o14.OrderNumber + "-0" + Conversions.ToString(i6);
											}
											else
											{
												o14.OrderNumber = o14.OrderNumber + "-" + Conversions.ToString(i6);
											}
											o14.Belt = "";
											o14.Motor = "";
											OrderList.Add(o14);
											i6++;
											continue;
										}
										break;
									}
								}
								catch (Exception ex5)
								{
									ProjectData.SetProjectError(ex5);
									Logs.Log.Add(ex5);
									Exception ex6 = ex5;
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					foreach (OrderInfo m5 in OrderList)
					{
						if (Operators.CompareString(m5.Motor, "", TextCompare: false) != 0)
						{
							OrderInfo o15 = new OrderInfo();
							o15.OrderNumber = m5.OrderNumber;
							o15.PartType = m5.PartType;
							o15.Motor = m5.Motor;
							o15.Belt = m5.Belt;
							MotorOrdersList.Add(o15);
						}
					}
					foreach (OrderInfo b5 in OrderList)
					{
						if (Operators.CompareString(b5.Belt, "", TextCompare: false) != 0)
						{
							OrderInfo o16 = new OrderInfo();
							o16.OrderNumber = b5.OrderNumber;
							o16.PartType = b5.PartType;
							o16.Motor = b5.Motor;
							o16.Belt = b5.Belt;
							BeltOrdersList.Add(o16);
						}
					}
					foreach (OrderInfo item6 in OrderList)
					{
						OrderInfo o17 = new OrderInfo();
						o17.OrderNumber = item6.OrderNumber;
						o17.PartType = item6.PartType;
						o17.Motor = item6.Motor;
						o17.Belt = item6.Belt;
						o17.CopiedNo = "";
						OH.AddOrderInfo(o17, MySettingsProperty.Settings.AccessDatabaseConnectionString);
						CheckCopied(o17, OH);
					}
					foreach (OrderInfo m6 in MotorOrdersList)
					{
						foreach (OrderInfo b6 in BeltOrdersList)
						{
							if (Operators.CompareString(m6.OrderNumber, b6.OrderNumber, TextCompare: false) == 0)
							{
								OrderInfo o18 = new OrderInfo();
								o18.OrderNumber = m6.OrderNumber;
								o18.PartType = m6.PartType;
								o18.Motor = m6.Motor;
								o18.Belt = b6.Belt;
								o18.CopiedNo = "";
								OH.AddOrderInfo(o18, MySettingsProperty.Settings.AccessDatabaseConnectionString);
								CheckCopied(o18, OH);
							}
						}
					}
				}
			}
			if (chkPrint.Checked | chkPreviewLabels.Checked)
			{
				PrintNewTags();
			}
			lblProg.Text = "Finished";
			ProgressProcessing.Value = 100;
		}
	}

	public void CheckCopied(OrderInfo o, OrderInfoHandler OH)
	{
		if (hashProduct[o.PartType.ToLower()] == null)
		{
			return;
		}
		Products prd = (Products)hashProduct[o.PartType.ToLower()];
		checked
		{
			int num = (int)Math.Round(prd.Quantity - 1.0);
			int i = 1;
			while (true)
			{
				int num2 = i;
				int num3 = num;
				if (num2 <= num3)
				{
					o.CopiedNo = Conversions.ToString(i + 1);
					OH.AddOrderInfo(o, MySettingsProperty.Settings.AccessDatabaseConnectionString);
					i++;
					continue;
				}
				break;
			}
		}
	}

	public void PrintNewTags()
	{
		OrderInfoHandler OH = new OrderInfoHandler();
		if (Operators.CompareString(cmbReportName.SelectedItem.ToString(), "Tag Report", TextCompare: false) == 0)
		{
			if (!OH.CheckOrders(MySettingsProperty.Settings.AccessDatabaseConnectionString))
			{
				Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
				return;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(cmbReportName.SelectedItem, "Tag Report with QRCodes", TextCompare: false) && !OH.CheckOrders(MySettingsProperty.Settings.AccessDatabaseConnectionString))
		{
			Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
			return;
		}
		if (!OH.CheckOrders(MySettingsProperty.Settings.AccessDatabaseConnectionString))
		{
			Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
			return;
		}
		string FreePhone;
		string FromWhere;
		if (chkUk.Checked)
		{
			FreePhone = "Free Phone 0800 0711855";
			FromWhere = "UK";
		}
		else
		{
			FreePhone = "1-800-358-SKIM (7546)";
			FromWhere = "US";
		}
		MyProject.Forms.FrmCRViewer.FreePhone = FreePhone;
		MyProject.Forms.FrmCRViewer.FromWhere = FromWhere;
		MyProject.Forms.FrmCRViewer.Print = chkPrint.Checked;
		MyProject.Forms.FrmCRViewer.Preview = chkPreviewLabels.Checked;
		MyProject.Forms.FrmCRViewer.Aerodyne = chkUseAero.Checked;
		MyProject.Forms.FrmCRViewer.Text = cmbReportName.SelectedItem.ToString();
		MyProject.Forms.FrmCRViewer.Show();
	}

	public void PrintTags()
	{
		ConnectionString = MySettingsProperty.Settings.AccessDatabaseConnectionString;
		if (Operators.CompareString(cmbReportName.SelectedItem.ToString(), "Tag Report", TextCompare: false) == 0)
		{
			DbConnection = new OleDbConnection(ConnectionString);
			DbCommand = new OleDbCommand("select * from orderinfo", DbConnection);
			DbDataset = new DataSet();
			DbDataAdapter = new OleDbDataAdapter(DbCommand);
			DbDataAdapter.SelectCommand = DbCommand;
			DbDataAdapter.Fill(DbDataset, "orderinfo");
			if (DbDataset.Tables[0].Rows.Count == 0)
			{
				Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
				return;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(cmbReportName.SelectedItem, "Tag Report with QRCodes", TextCompare: false))
		{
			DbConnection = new OleDbConnection(ConnectionString);
			DbCommand = new OleDbCommand("select * from orderinfo", DbConnection);
			DbDataset = new DataSet();
			DbDataAdapter = new OleDbDataAdapter(DbCommand);
			DbDataAdapter.SelectCommand = DbCommand;
			DbDataAdapter.Fill(DbDataset, "orderinfo");
			if (DbDataset.Tables[0].Rows.Count == 0)
			{
				Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
				return;
			}
		}
		DbConnection = new OleDbConnection(ConnectionString);
		DbCommand = new OleDbCommand("select * from orderinfo", DbConnection);
		DbDataset = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(DbDataset, "orderinfo");
		if (DbDataset.Tables[0].Rows.Count == 0)
		{
			Interaction.MsgBox("No labels to print", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
			return;
		}
		string FreePhone;
		string FromWhere;
		if (chkUk.Checked)
		{
			FreePhone = "Free Phone 0800 0711855";
			FromWhere = "UK";
		}
		else
		{
			FreePhone = "1-800-358-SKIM (7546)";
			FromWhere = "US";
		}
		if (chkPrint.Checked | chkPrint.Checked)
		{
			MyProject.Forms.FrmCRViewer.FreePhone = FreePhone;
			MyProject.Forms.FrmCRViewer.FromWhere = FromWhere;
			if (Operators.CompareString(cmbReportName.SelectedItem.ToString(), "Tag Report", TextCompare: false) == 0)
			{
				MyProject.Forms.FrmCRViewer.Text = "Tag Report";
			}
			else if (Operators.ConditionalCompareObjectEqual(cmbReportName.SelectedItem, "Tag Report with QRCodes", TextCompare: false))
			{
				MyProject.Forms.FrmCRViewer.Text = "Tag Report with QRCodes";
			}
			MyProject.Forms.FrmCRViewer.Show();
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void rbOrderNumber_CheckedChanged(object sender, EventArgs e)
	{
		dtFrom.Enabled = false;
		dtTo.Enabled = false;
		txtOrder.Enabled = true;
		txtOrderStart.Enabled = false;
		txtOrderEnd.Enabled = false;
		txtOrder.Focus();
	}

	private void rbOrderNumbers_CheckedChanged(object sender, EventArgs e)
	{
		txtOrder.Enabled = false;
		dtFrom.Enabled = false;
		dtTo.Enabled = false;
		txtOrderStart.Enabled = true;
		txtOrderEnd.Enabled = true;
		txtOrderStart.Focus();
	}

	private void rbUseDates_CheckedChanged(object sender, EventArgs e)
	{
		txtOrder.Enabled = false;
		dtFrom.Enabled = true;
		dtTo.Enabled = true;
		txtOrderStart.Enabled = false;
		txtOrderEnd.Enabled = false;
		dtFrom.Focus();
	}

	private void btnReprint_Click(object sender, EventArgs e)
	{
		PrintNewTags();
	}

	private bool _qbConnected;

	private void FrmMain_Load(object sender, EventArgs e)
	{
		// On first run or if DB path uses |DataDirectory| (Program Files = read-only),
		// migrate to AppData where we have write permission
		string dbPath = MySettingsProperty.Settings.AccessDBDataSource;
		if (string.IsNullOrEmpty(dbPath) || dbPath.Contains("|DataDirectory|"))
		{
			dbPath = FrmConfig.DefaultDbPath();
			MySettingsProperty.Settings.AccessDBDataSource = dbPath;
			MySettingsProperty.Settings.AccessDatabaseConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
			try { MySettingsProperty.Settings.Save(); } catch { }
		}
		FrmConfig.EnsureDatabaseExists(dbPath);

		rbOrderNumber.Checked = true;
		btnPopulateQrCodes.Visible = false;
		Button1.Visible = false;

		// Load custom reports into dropdown
		string custom = MySettingsProperty.Settings.CustomReportPaths;
		if (!string.IsNullOrEmpty(custom))
		{
			foreach (string item in custom.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
			{
				string name = item.Split('|')[0];
				if (!cmbReportName.Items.Contains(name))
					cmbReportName.Items.Add(name);
			}
		}
		cmbReportName.SelectedIndex = 0;
		SetControlsEnabled(false);
		AttemptQBConnection();
	}

	private void AttemptQBConnection()
	{
		_qbConnected = Manager.ConnectToQB();
		if (_qbConnected)
		{
			SetControlsEnabled(true);
			lblProg.Text = "Connected to QuickBooks";
			txtOrder.Focus();
		}
		else
		{
			string diagnosis = Manager.DiagnoseConnectionError(Manager.LastConnectionError);
			lblProg.Text = "Not connected to QuickBooks";
			DialogResult result = MessageBox.Show(
				"Cannot connect to QuickBooks.\n\n" + diagnosis,
				"QBTag - Connection Error",
				MessageBoxButtons.RetryCancel,
				MessageBoxIcon.Warning);
			if (result == DialogResult.Retry)
			{
				AttemptQBConnection();
			}
		}
	}

	private void SetControlsEnabled(bool enabled)
	{
		btnExport.Enabled = enabled;
		btnReprint.Enabled = enabled;
		txtOrder.Enabled = enabled;
		txtOrderStart.Enabled = enabled;
		txtOrderEnd.Enabled = enabled;
		dtFrom.Enabled = enabled;
		dtTo.Enabled = enabled;
	}

	private void MenuItemConfigureDatabases_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmConfig.Show();
	}

	private void MenuItemManageReports_Click(object sender, EventArgs e)
	{
		using (Form dlg = new Form())
		{
			dlg.Text = "Manage Report Templates";
			dlg.Size = new Size(500, 300);
			dlg.StartPosition = FormStartPosition.CenterParent;
			dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
			dlg.MaximizeBox = false;
			dlg.MinimizeBox = false;

			ListBox lst = new ListBox();
			lst.Location = new Point(12, 12);
			lst.Size = new Size(360, 200);

			Button btnAdd = new Button();
			btnAdd.Text = "Add Report...";
			btnAdd.Location = new Point(380, 12);
			btnAdd.Size = new Size(95, 28);
			btnAdd.Click += delegate
			{
				using (OpenFileDialog ofd = new OpenFileDialog())
				{
					ofd.Filter = "Crystal Reports (*.rpt)|*.rpt";
					ofd.Title = "Select a report template";
					if (ofd.ShowDialog() == DialogResult.OK)
					{
						string name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
						string entry = name + "|" + ofd.FileName;
						if (!lst.Items.Contains(entry))
						{
							lst.Items.Add(entry);
						}
					}
				}
			};

			Button btnRemove = new Button();
			btnRemove.Text = "Remove";
			btnRemove.Location = new Point(380, 46);
			btnRemove.Size = new Size(95, 28);
			btnRemove.Click += delegate
			{
				if (lst.SelectedIndex >= 0)
				{
					string sel = lst.SelectedItem.ToString();
					// Don't allow removing the two built-in reports
					if (sel.StartsWith("Tag Report|") || sel.StartsWith("Tag Report with QRCodes|"))
					{
						MessageBox.Show("Cannot remove built-in reports.", "QBTag");
						return;
					}
					lst.Items.RemoveAt(lst.SelectedIndex);
				}
			};

			Button btnOk = new Button();
			btnOk.Text = "Save";
			btnOk.Location = new Point(380, 220);
			btnOk.Size = new Size(95, 28);
			btnOk.DialogResult = DialogResult.OK;

			dlg.Controls.Add(lst);
			dlg.Controls.Add(btnAdd);
			dlg.Controls.Add(btnRemove);
			dlg.Controls.Add(btnOk);
			dlg.AcceptButton = btnOk;

			// Load current reports
			string tagRpt = Application.StartupPath + "\\tag.rpt";
			string qrRpt = Application.StartupPath + "\\TagWithQRCodes.rpt";
			lst.Items.Add("Tag Report|" + tagRpt);
			lst.Items.Add("Tag Report with QRCodes|" + qrRpt);

			// Load custom reports from settings
			string custom = MySettingsProperty.Settings.CustomReportPaths;
			if (!string.IsNullOrEmpty(custom))
			{
				foreach (string item in custom.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
				{
					lst.Items.Add(item);
				}
			}

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				// Save custom reports (skip the 2 built-ins)
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				cmbReportName.Items.Clear();
				for (int i = 0; i < lst.Items.Count; i++)
				{
					string entry = lst.Items[i].ToString();
					string name = entry.Split('|')[0];
					cmbReportName.Items.Add(name);
					if (i >= 2) // skip built-ins
					{
						if (sb.Length > 0) sb.Append(";");
						sb.Append(entry);
					}
				}
				MySettingsProperty.Settings.CustomReportPaths = sb.ToString();
				try { MySettingsProperty.Settings.Save(); } catch { }
				if (cmbReportName.Items.Count > 0)
					cmbReportName.SelectedIndex = 0;
			}
		}
	}

	private void btnPopulateQrCodes_Click(object sender, EventArgs e)
	{
	}

	public void testwherenow()
	{
		MessageBox.Show(WhereNow.ToString());
	}

	public object LoadImage(string path)
	{
		try
		{
			FileInfo fiImage = new FileInfo(path);
			m_lImageFileLength = fiImage.Length;
			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			m_barrImg = new byte[checked(Convert.ToInt32(m_lImageFileLength) - 1 + 1)];
			int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
			fs.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logs.Log.Add(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "QBTag");
			ProjectData.ClearProjectError();
		}
		return m_barrImg;
	}

	public object UpdateQrCodes(string ProductNumber, string Link, string QrPhoto)
	{
		using OleDbConnection DbConnection = new OleDbConnection(ConnectionString);
		DbCommand = new OleDbCommand("Update tblQrCode Set Link=@Link,QrPhoto=@QrPhoto where ProductNumber=@ProductNumber", DbConnection);
		DbCommand.Parameters.AddWithValue("@ProductNumber", ProductNumber);
		DbCommand.Parameters.AddWithValue("@Link", Link);
		DbCommand.Parameters.AddWithValue("@QrPhoto", RuntimeHelpers.GetObjectValue(LoadImage("F:\\Directory\\" + QrPhoto)));
		DbConnection.Open();
		if (DbCommand.ExecuteNonQuery() > 0)
		{
			return true;
		}
		return false;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		testwherenow();
	}

	private void MenuItemConfigureQRCodes_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmAddNewQrCodes.Show();
	}

	private void chkUseAero_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmOrderInfo.Show();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Manager.Disconnect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logs.Log.Add(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btnLoadProduct_Click(object sender, EventArgs e)
	{
		try
		{
			FrmProducts dialog = new FrmProducts();
			dialog.ShowDialog();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logs.Log.Add(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
