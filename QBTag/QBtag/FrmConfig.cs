using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ADOX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;
using QuickBooksHandler;
using QuickBooksModel;

namespace QBtag;

[DesignerGenerated]
public class FrmConfig : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GbTabExportDatabase")]
	private GroupBox _GbTabExportDatabase;

	[AccessedThroughProperty("txtTagDB")]
	private TextBox _txtTagDB;

	[AccessedThroughProperty("btnCreateTagDatabase")]
	private Button _btnCreateTagDatabase;

	[AccessedThroughProperty("GbPartTypes")]
	private GroupBox _GbPartTypes;

	[AccessedThroughProperty("txtPartTypes")]
	private TextBox _txtPartTypes;

	[AccessedThroughProperty("btnRemovePartType")]
	private Button _btnRemovePartType;

	[AccessedThroughProperty("btnAddPartType")]
	private Button _btnAddPartType;

	[AccessedThroughProperty("btnGetPartType")]
	private Button _btnGetPartType;

	[AccessedThroughProperty("btnSetPartType")]
	private Button _btnSetPartType;

	[AccessedThroughProperty("lstParts")]
	private ListBox _lstParts;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	private Button _btnBrowseDB;

	private DataSet DbDataset;

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

	public OdbcConnection QuickBooksDBConnection;

	public DataTable DbDataTable;

	public string ConnectionString;

	public string ConnectionString2;

	public string ConStr;

	internal virtual GroupBox GbTabExportDatabase
	{
		[DebuggerNonUserCode]
		get
		{
			return _GbTabExportDatabase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GbTabExportDatabase = value;
		}
	}

	internal virtual TextBox txtTagDB
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTagDB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTagDB = value;
		}
	}

	internal virtual Button btnCreateTagDatabase
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCreateTagDatabase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnCreateTagDatabase_Click;
			if (_btnCreateTagDatabase != null)
			{
				_btnCreateTagDatabase.Click -= value2;
			}
			_btnCreateTagDatabase = value;
			if (_btnCreateTagDatabase != null)
			{
				_btnCreateTagDatabase.Click += value2;
			}
		}
	}

	internal virtual GroupBox GbPartTypes
	{
		[DebuggerNonUserCode]
		get
		{
			return _GbPartTypes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GbPartTypes = value;
		}
	}

	internal virtual TextBox txtPartTypes
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPartTypes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPartTypes = value;
		}
	}

	internal virtual Button btnRemovePartType
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnRemovePartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnRemovePartType_Click;
			if (_btnRemovePartType != null)
			{
				_btnRemovePartType.Click -= value2;
			}
			_btnRemovePartType = value;
			if (_btnRemovePartType != null)
			{
				_btnRemovePartType.Click += value2;
			}
		}
	}

	internal virtual Button btnAddPartType
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAddPartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAddPartType_Click;
			if (_btnAddPartType != null)
			{
				_btnAddPartType.Click -= value2;
			}
			_btnAddPartType = value;
			if (_btnAddPartType != null)
			{
				_btnAddPartType.Click += value2;
			}
		}
	}

	internal virtual Button btnGetPartType
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGetPartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnGetPartType_Click;
			if (_btnGetPartType != null)
			{
				_btnGetPartType.Click -= value2;
			}
			_btnGetPartType = value;
			if (_btnGetPartType != null)
			{
				_btnGetPartType.Click += value2;
			}
		}
	}

	internal virtual Button btnSetPartType
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnSetPartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnSetPartType_Click;
			if (_btnSetPartType != null)
			{
				_btnSetPartType.Click -= value2;
			}
			_btnSetPartType = value;
			if (_btnSetPartType != null)
			{
				_btnSetPartType.Click += value2;
			}
		}
	}

	internal virtual ListBox lstParts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstParts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstParts = value;
		}
	}

	internal virtual Button btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnOk_Click;
			if (_btnOk != null)
			{
				_btnOk.Click -= value2;
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				_btnOk.Click += value2;
			}
		}
	}

	internal virtual Button btnCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnCancel_Click;
			if (_btnCancel != null)
			{
				_btnCancel.Click -= value2;
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
				_btnCancel.Click += value2;
			}
		}
	}

	public FrmConfig()
	{
		base.Load += FrmConfig_Load;
		__ENCAddToList(this);
		ConnectionString = "";
		ConnectionString2 = "";
		ConStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
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
		this.GbTabExportDatabase = new System.Windows.Forms.GroupBox();
		this.GbPartTypes = new System.Windows.Forms.GroupBox();
		this.lstParts = new System.Windows.Forms.ListBox();
		this.btnSetPartType = new System.Windows.Forms.Button();
		this.btnGetPartType = new System.Windows.Forms.Button();
		this.btnRemovePartType = new System.Windows.Forms.Button();
		this.btnAddPartType = new System.Windows.Forms.Button();
		this.txtPartTypes = new System.Windows.Forms.TextBox();
		this.btnCreateTagDatabase = new System.Windows.Forms.Button();
		this._btnBrowseDB = new System.Windows.Forms.Button();
		this.txtTagDB = new System.Windows.Forms.TextBox();
		this.btnOk = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.GbTabExportDatabase.SuspendLayout();
		this.GbPartTypes.SuspendLayout();
		this.SuspendLayout();
		this.GbTabExportDatabase.Controls.Add(this.GbPartTypes);
		this.GbTabExportDatabase.Controls.Add(this.btnCreateTagDatabase);
		this.GbTabExportDatabase.Controls.Add(this._btnBrowseDB);
		this.GbTabExportDatabase.Controls.Add(this.txtTagDB);
		this.GbTabExportDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.GroupBox gbTabExportDatabase = this.GbTabExportDatabase;
		System.Drawing.Point location = new System.Drawing.Point(12, 21);
		gbTabExportDatabase.Location = location;
		this.GbTabExportDatabase.Name = "GbTabExportDatabase";
		System.Windows.Forms.GroupBox gbTabExportDatabase2 = this.GbTabExportDatabase;
		System.Drawing.Size size = new System.Drawing.Size(284, 183);
		gbTabExportDatabase2.Size = size;
		this.GbTabExportDatabase.TabIndex = 1;
		this.GbTabExportDatabase.TabStop = false;
		this.GbTabExportDatabase.Text = "Tab Export Database";
		this.GbPartTypes.Controls.Add(this.lstParts);
		this.GbPartTypes.Controls.Add(this.btnSetPartType);
		this.GbPartTypes.Controls.Add(this.btnGetPartType);
		this.GbPartTypes.Controls.Add(this.btnRemovePartType);
		this.GbPartTypes.Controls.Add(this.btnAddPartType);
		this.GbPartTypes.Controls.Add(this.txtPartTypes);
		this.GbPartTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.GroupBox gbPartTypes = this.GbPartTypes;
		location = new System.Drawing.Point(9, 46);
		gbPartTypes.Location = location;
		this.GbPartTypes.Name = "GbPartTypes";
		System.Windows.Forms.GroupBox gbPartTypes2 = this.GbPartTypes;
		size = new System.Drawing.Size(268, 128);
		gbPartTypes2.Size = size;
		this.GbPartTypes.TabIndex = 7;
		this.GbPartTypes.TabStop = false;
		this.GbPartTypes.Text = "Part Types";
		this.lstParts.FormattingEnabled = true;
		System.Windows.Forms.ListBox listBox = this.lstParts;
		location = new System.Drawing.Point(149, 9);
		listBox.Location = location;
		this.lstParts.Name = "lstParts";
		System.Windows.Forms.ListBox listBox2 = this.lstParts;
		size = new System.Drawing.Size(113, 108);
		listBox2.Size = size;
		this.lstParts.TabIndex = 12;
		System.Windows.Forms.Button button = this.btnSetPartType;
		location = new System.Drawing.Point(68, 94);
		button.Location = location;
		this.btnSetPartType.Name = "btnSetPartType";
		System.Windows.Forms.Button button2 = this.btnSetPartType;
		size = new System.Drawing.Size(81, 23);
		button2.Size = size;
		this.btnSetPartType.TabIndex = 11;
		this.btnSetPartType.Text = "Set Part Type";
		this.btnSetPartType.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button3 = this.btnGetPartType;
		location = new System.Drawing.Point(68, 69);
		button3.Location = location;
		this.btnGetPartType.Name = "btnGetPartType";
		System.Windows.Forms.Button button4 = this.btnGetPartType;
		size = new System.Drawing.Size(81, 23);
		button4.Size = size;
		this.btnGetPartType.TabIndex = 10;
		this.btnGetPartType.Text = "Get Part Type";
		this.btnGetPartType.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button5 = this.btnRemovePartType;
		location = new System.Drawing.Point(121, 34);
		button5.Location = location;
		this.btnRemovePartType.Name = "btnRemovePartType";
		System.Windows.Forms.Button button6 = this.btnRemovePartType;
		size = new System.Drawing.Size(28, 23);
		button6.Size = size;
		this.btnRemovePartType.TabIndex = 9;
		this.btnRemovePartType.Text = "<<";
		this.btnRemovePartType.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button7 = this.btnAddPartType;
		location = new System.Drawing.Point(121, 9);
		button7.Location = location;
		this.btnAddPartType.Name = "btnAddPartType";
		System.Windows.Forms.Button button8 = this.btnAddPartType;
		size = new System.Drawing.Size(28, 23);
		button8.Size = size;
		this.btnAddPartType.TabIndex = 8;
		this.btnAddPartType.Text = ">>";
		this.btnAddPartType.UseVisualStyleBackColor = true;
		System.Windows.Forms.TextBox textBox = this.txtPartTypes;
		location = new System.Drawing.Point(6, 23);
		textBox.Location = location;
		this.txtPartTypes.Name = "txtPartTypes";
		System.Windows.Forms.TextBox textBox2 = this.txtPartTypes;
		size = new System.Drawing.Size(109, 20);
		textBox2.Size = size;
		this.txtPartTypes.TabIndex = 7;
		this.btnCreateTagDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.Button button9 = this.btnCreateTagDatabase;
		location = new System.Drawing.Point(159, 19);
		button9.Location = location;
		this.btnCreateTagDatabase.Name = "btnCreateTagDatabase";
		System.Windows.Forms.Button button10 = this.btnCreateTagDatabase;
		size = new System.Drawing.Size(118, 23);
		button10.Size = size;
		this.btnCreateTagDatabase.TabIndex = 1;
		this.btnCreateTagDatabase.Text = "Create Tag Database";
		this.btnCreateTagDatabase.UseVisualStyleBackColor = true;
		this.txtTagDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.TextBox textBox3 = this.txtTagDB;
		location = new System.Drawing.Point(14, 20);
		textBox3.Location = location;
		this.txtTagDB.Name = "txtTagDB";
		System.Windows.Forms.TextBox textBox4 = this.txtTagDB;
		size = new System.Drawing.Size(109, 20);
		textBox4.Size = size;
		this.txtTagDB.TabIndex = 0;
		this._btnBrowseDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.Button btnBrowse = this._btnBrowseDB;
		location = new System.Drawing.Point(124, 19);
		btnBrowse.Location = location;
		this._btnBrowseDB.Name = "btnBrowseDB";
		System.Windows.Forms.Button btnBrowse2 = this._btnBrowseDB;
		size = new System.Drawing.Size(33, 23);
		btnBrowse2.Size = size;
		this._btnBrowseDB.TabIndex = 13;
		this._btnBrowseDB.Text = "...";
		this._btnBrowseDB.UseVisualStyleBackColor = true;
		this._btnBrowseDB.Click += btnBrowseDB_Click;
		System.Windows.Forms.Button button11 = this.btnOk;
		location = new System.Drawing.Point(155, 210);
		button11.Location = location;
		this.btnOk.Name = "btnOk";
		System.Windows.Forms.Button button12 = this.btnOk;
		size = new System.Drawing.Size(64, 23);
		button12.Size = size;
		this.btnOk.TabIndex = 2;
		this.btnOk.Text = "Ok";
		this.btnOk.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button13 = this.btnCancel;
		location = new System.Drawing.Point(225, 210);
		button13.Location = location;
		this.btnCancel.Name = "btnCancel";
		System.Windows.Forms.Button button14 = this.btnCancel;
		size = new System.Drawing.Size(64, 23);
		button14.Size = size;
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(328, 245);
		this.ClientSize = size;
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.btnOk);
		this.Controls.Add(this.GbTabExportDatabase);
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "FrmConfig";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Database Configuration - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
		this.GbTabExportDatabase.ResumeLayout(false);
		this.GbTabExportDatabase.PerformLayout();
		this.GbPartTypes.ResumeLayout(false);
		this.GbPartTypes.PerformLayout();
		this.ResumeLayout(false);
	}

	private void SetIntegratedSecurity(bool value)
	{
	}

	private void btnRemovePartType_Click(object sender, EventArgs e)
	{
		if (lstParts.SelectedIndex != -1)
		{
			txtPartTypes.Text = lstParts.Text;
			lstParts.Items.RemoveAt(lstParts.SelectedIndex);
		}
		if (lstParts.Items.Count > 0)
		{
			lstParts.SelectedIndex = 0;
		}
	}

	public void BindFields()
	{
		txtTagDB.Text = ResolveDbPath(MySettingsProperty.Settings.AccessDBDataSource);
	}

	public void UpdateDBSettings()
	{
		if (Operators.CompareString(txtTagDB.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Please enter the Access Database path", MsgBoxStyle.OkOnly, "QBTag");
			txtTagDB.Focus();
		}
		else
		{
			MySettingsProperty.Settings.AccessDBDataSource = txtTagDB.Text;
			MySettingsProperty.Settings.AccessDatabaseConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtTagDB.Text;
			MySettingsProperty.Settings.Save();
		}
	}

	public void MakeConnection()
	{
		try
		{
			StringBuilder Con = new StringBuilder("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=");
			Con.Append(txtTagDB.Text);
			string strCon = Con.ToString();
			updateConfigFile(strCon);
			OleDbConnection Db = new OleDbConnection();
			ConfigurationManager.RefreshSection("Macola.My.MySettings.MacolaAccessDatabaseConnectionString");
			Db.ConnectionString = ConfigurationManager.ConnectionStrings["Macola.My.MySettings.MacolaAccessDatabaseConnectionString"].ToString();
			OleDbDataAdapter da = new OleDbDataAdapter("select * from orderinfo", Db);
			DataTable dt = new DataTable();
			da.Fill(dt);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception E = ex;
			MessageBox.Show(ConfigurationManager.ConnectionStrings["Macola.My.MySettings.MacolaAccessDatabaseConnectionString"].ToString() + ".This is invalid connection", "Incorrect server/Database");
			ProjectData.ClearProjectError();
		}
	}

	public void updateConfigFile(string con)
	{
		XmlDocument XmlDoc = new XmlDocument();
		XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
		foreach (XmlElement xElement in XmlDoc.DocumentElement)
		{
			if (Operators.CompareString(xElement.Name, "connectionStrings", TextCompare: false) == 0)
			{
				xElement.FirstChild.Attributes[1].Value = con;
			}
		}
		XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
	}

	private void btnCreateTagDatabase_Click(object sender, EventArgs e)
	{
		CreateTagDatabaseAccess(txtTagDB.Text);
		string SQLCreate = "";
		SQLCreate = "CREATE TABLE OrderInfo(";
		SQLCreate += " OrderNumber TEXT(50),";
		SQLCreate += " Motor TEXT(50),";
		SQLCreate += " Belt TEXT(50),";
		SQLCreate += " PartType TEXT(50),";
		SQLCreate += " CopiedNo TEXT(50)";
		SQLCreate += " )";
		CreateTagTable(txtTagDB.Text, SQLCreate);
		SQLCreate = "CREATE TABLE tblProducts(";
		SQLCreate += " ProductName TEXT(50),";
		SQLCreate += " Quantity TEXT(50)";
		SQLCreate += " )";
		CreateTagTable(txtTagDB.Text, SQLCreate);
		SQLCreate = "";
		SQLCreate = "CREATE TABLE Parts(";
		SQLCreate += " PartType TEXT(50)";
		SQLCreate += " )";
		CreateTagTable(txtTagDB.Text, SQLCreate);
		SQLCreate = "";
		SQLCreate += " CREATE TABLE tblQrCode(";
		SQLCreate += " Link NUMBER PRIMARY KEY,";
		SQLCreate += " ProductNumber TEXT(50) NOT NULL,";
		SQLCreate += " QrPhoto image NOT NULL";
		SQLCreate += " )";
		CreateTagTable(txtTagDB.Text, SQLCreate);
		SQLCreate = "";
		SQLCreate += " CREATE VIEW ViewOrderWithQRCode\r\n";
		SQLCreate += " AS\r\n";
		SQLCreate += " SELECT OrderInfo.OrderNumber,OrderInfo.Motor,OrderInfo.Belt,OrderInfo.PartType,tblQrCode.Link,tblQrCode.QrPhoto";
		SQLCreate += " FROM OrderInfo INNER JOIN tblQrCode ON OrderInfo.PartType =tblQrCode.ProductNumber";
		CreateTagTable(txtTagDB.Text, SQLCreate);
	}

	public void CreateTagDatabase(string TagDatabaseName)
	{
		using OleDbConnection DbConnection = new OleDbConnection(getSQLConnString());
		DbCommand = new OleDbCommand("Create database " + txtTagDB.Text, DbConnection);
		DbConnection.Open();
		try
		{
			DbCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Database couldn't be created due to error:" + ex2.Message.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public bool CreateTagDatabaseAccess(string DatabaseFullPath)
	{
		Guid clsid = new Guid("00000602-0000-0010-8000-00AA006D2EA4");
		Catalog cat = (Catalog)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		bool bAns;
		try
		{
			string sCreateString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DatabaseFullPath;
			cat.Create(sCreateString);
			bAns = true;
		}
		catch (COMException ex)
		{
			ProjectData.SetProjectError(ex);
			COMException ex2 = ex;
			bAns = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			cat = null;
		}
		return bAns;
	}

	public void CreateTagTable(string TagDatabaseName, string TableScript)
	{
		using OleDbConnection DbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + TagDatabaseName);
		DbCommand = new OleDbCommand(TableScript, DbConnection);
		DbConnection.Open();
		try
		{
			DbCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Table/View couldn't be created due to error:" + ex2.Message.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void btnGetPartType_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Strings.Trim(txtTagDB.Text), "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Please Enter the Name of Database to be created", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
			return;
		}
		lstParts.Items.Clear();
		List<Parts> parts = new PartsHandler().GetParts(ConStr);
		if (parts != null)
		{
			foreach (Parts item in parts)
			{
				lstParts.Items.Add(item.PartType);
			}
		}
		if (lstParts.Items.Count == 0)
		{
			Interaction.MsgBox("No Parts Type available", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
		}
	}

	private void btnSetPartType_Click(object sender, EventArgs e)
	{
		PartsHandler PH = new PartsHandler();
		if (Operators.CompareString(Strings.Trim(txtTagDB.Text), "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Please Enter the Name of Database to be created", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
		}
		else if (lstParts.Items.Count == 0)
		{
			Interaction.MsgBox("There are no parts Type to set", MsgBoxStyle.OkOnly, "Abanaki QB Tag");
			PH.DeletePart(ConStr);
		}
		else
		{
			if (Interaction.MsgBox("Existing Parts type in the database will be overwritten\r\n\r\nAre You Sure ?  ", MsgBoxStyle.YesNo, "Abanaki QB Tag") != MsgBoxResult.Yes)
			{
				return;
			}
			PH.DeletePart(ConStr);
			foreach (object item2 in lstParts.Items)
			{
				object item = RuntimeHelpers.GetObjectValue(item2);
				Parts part = new Parts();
				part.PartType = item.ToString();
				PH.AddPart(part, ConStr);
			}
		}
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		UpdateDBSettings();
	}

	private string getSQLConnString()
	{
		return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\MacolaDatabase.mdb";
	}

	private void btnAddPartType_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtPartTypes.Text, "", TextCompare: false) != 0)
		{
			lstParts.Items.Add(txtPartTypes.Text);
			txtPartTypes.Text = "";
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void rdWindowsIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
	{
		SetIntegratedSecurity(value: true);
	}

	private void rdSqlServerSecurity_CheckedChanged(object sender, EventArgs e)
	{
		SetIntegratedSecurity(value: false);
	}

	private void btnBrowseDB_Click(object sender, EventArgs e)
	{
		using (SaveFileDialog sfd = new SaveFileDialog())
		{
			sfd.Filter = "Access Database (*.mdb)|*.mdb";
			sfd.Title = "Select or create database file";
			sfd.FileName = "usman.mdb";
			sfd.OverwritePrompt = false;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				txtTagDB.Text = sfd.FileName;
			}
		}
	}

	/// <summary>
	/// Creates the database at the given path if it doesn't already exist.
	/// Called automatically on startup and from the config dialog.
	/// </summary>
	public static string ResolveDbPath(string dbPath)
	{
		if (string.IsNullOrEmpty(dbPath) || dbPath.Contains("|DataDirectory|"))
		{
			dbPath = DefaultDbPath();
		}
		return dbPath;
	}

	public static string DefaultDbPath()
	{
		return System.IO.Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			"QBTag", "usman.mdb");
	}

	public static bool EnsureDatabaseExists(string dbPath)
	{
		dbPath = ResolveDbPath(dbPath);
		// Ensure parent directory exists
		try
		{
			string dir = System.IO.Path.GetDirectoryName(dbPath);
			if (!System.IO.Directory.Exists(dir))
				System.IO.Directory.CreateDirectory(dir);
		}
		catch { }
		if (System.IO.File.Exists(dbPath)) return true;
		try
		{
			// Create the MDB file using ADOX
			Guid clsid = new Guid("00000602-0000-0010-8000-00AA006D2EA4");
			Catalog cat = (Catalog)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
			cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath);
			cat = null;

			// Create tables
			using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath))
			{
				con.Open();
				string[] scripts = new string[]
				{
					"CREATE TABLE OrderInfo(OrderNumber TEXT(50), Motor TEXT(50), Belt TEXT(50), PartType TEXT(50), CopiedNo TEXT(50))",
					"CREATE TABLE Parts(PartType TEXT(50))",
					"CREATE TABLE tblProducts(ProductName TEXT(50), Quantity TEXT(50))",
					"CREATE TABLE tblQrCode(Link COUNTER PRIMARY KEY, ProductNumber TEXT(50), QrPhoto IMAGE)",
					"CREATE VIEW ViewOrderWithQRCode AS SELECT OrderInfo.OrderNumber,OrderInfo.Motor,OrderInfo.Belt,OrderInfo.PartType,tblQrCode.Link,tblQrCode.QrPhoto FROM OrderInfo INNER JOIN tblQrCode ON OrderInfo.PartType=tblQrCode.ProductNumber"
				};
				foreach (string sql in scripts)
				{
					try
					{
						using (OleDbCommand cmd = new OleDbCommand(sql, con))
						{
							cmd.ExecuteNonQuery();
						}
					}
					catch { }
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void FrmConfig_Load(object sender, EventArgs e)
	{
		BindFields();
	}
}
