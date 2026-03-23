using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Logs;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;

namespace QBtag;

[DesignerGenerated]
public class FrmAddNewQrCodes : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblQrCode")]
	private Label _lblQrCode;

	[AccessedThroughProperty("btnAddQrCode")]
	private Button _btnAddQrCode;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("lblProducrNumber")]
	private Label _lblProducrNumber;

	[AccessedThroughProperty("lblQrImage")]
	private Label _lblQrImage;

	[AccessedThroughProperty("btnBrowse")]
	private Button _btnBrowse;

	[AccessedThroughProperty("txtQrImage")]
	private TextBox _txtQrImage;

	[AccessedThroughProperty("txtQrCode")]
	private TextBox _txtQrCode;

	[AccessedThroughProperty("txtProductNumber")]
	private TextBox _txtProductNumber;

	[AccessedThroughProperty("chkQrCodeImage")]
	private CheckBox _chkQrCodeImage;

	[AccessedThroughProperty("DataGridViewQrCodes")]
	private DataGridView _DataGridViewQrCodes;

	[AccessedThroughProperty("OpenPictureDialog")]
	private OpenFileDialog _OpenPictureDialog;

	[AccessedThroughProperty("PictureBoxQrCodeImage")]
	private PictureBox _PictureBoxQrCodeImage;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	public string ConnectionString;

	public string ConnectionString2;

	private object conStr;

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

	private string QRCode;

	private string ProductNumber;

	internal virtual Label lblQrCode
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblQrCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblQrCode = value;
		}
	}

	internal virtual Button btnAddQrCode
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAddQrCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAddQrCode_Click;
			if (_btnAddQrCode != null)
			{
				_btnAddQrCode.Click -= value2;
			}
			_btnAddQrCode = value;
			if (_btnAddQrCode != null)
			{
				_btnAddQrCode.Click += value2;
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

	internal virtual Label lblProducrNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProducrNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProducrNumber = value;
		}
	}

	internal virtual Label lblQrImage
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblQrImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblQrImage = value;
		}
	}

	internal virtual Button btnBrowse
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnBrowse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnBrowse_Click;
			if (_btnBrowse != null)
			{
				_btnBrowse.Click -= value2;
			}
			_btnBrowse = value;
			if (_btnBrowse != null)
			{
				_btnBrowse.Click += value2;
			}
		}
	}

	internal virtual TextBox txtQrImage
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtQrImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtQrImage = value;
		}
	}

	internal virtual TextBox txtQrCode
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtQrCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtQrCode = value;
		}
	}

	internal virtual TextBox txtProductNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProductNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtProductNumber = value;
		}
	}

	internal virtual CheckBox chkQrCodeImage
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkQrCodeImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = chkQrCodeImage_CheckedChanged;
			if (_chkQrCodeImage != null)
			{
				_chkQrCodeImage.CheckedChanged -= value2;
			}
			_chkQrCodeImage = value;
			if (_chkQrCodeImage != null)
			{
				_chkQrCodeImage.CheckedChanged += value2;
			}
		}
	}

	internal virtual DataGridView DataGridViewQrCodes
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewQrCodes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataGridViewCellMouseEventHandler value2 = DataGridViewQrCodes_RowHeaderMouseClick;
			if (_DataGridViewQrCodes != null)
			{
				_DataGridViewQrCodes.RowHeaderMouseClick -= value2;
			}
			_DataGridViewQrCodes = value;
			if (_DataGridViewQrCodes != null)
			{
				_DataGridViewQrCodes.RowHeaderMouseClick += value2;
			}
		}
	}

	internal virtual OpenFileDialog OpenPictureDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenPictureDialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler value2 = OpenPictureDialog_FileOk;
			if (_OpenPictureDialog != null)
			{
				_OpenPictureDialog.FileOk -= value2;
			}
			_OpenPictureDialog = value;
			if (_OpenPictureDialog != null)
			{
				_OpenPictureDialog.FileOk += value2;
			}
		}
	}

	internal virtual PictureBox PictureBoxQrCodeImage
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxQrCodeImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBoxQrCodeImage = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	public FrmAddNewQrCodes()
	{
		base.Load += FrmAddNewQrCodes_Load;
		__ENCAddToList(this);
		ConnectionString = "";
		ConnectionString2 = "";
		conStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
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
		this.lblQrCode = new System.Windows.Forms.Label();
		this.btnAddQrCode = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.lblProducrNumber = new System.Windows.Forms.Label();
		this.lblQrImage = new System.Windows.Forms.Label();
		this.btnBrowse = new System.Windows.Forms.Button();
		this.txtQrImage = new System.Windows.Forms.TextBox();
		this.txtQrCode = new System.Windows.Forms.TextBox();
		this.txtProductNumber = new System.Windows.Forms.TextBox();
		this.chkQrCodeImage = new System.Windows.Forms.CheckBox();
		this.DataGridViewQrCodes = new System.Windows.Forms.DataGridView();
		this.OpenPictureDialog = new System.Windows.Forms.OpenFileDialog();
		this.PictureBoxQrCodeImage = new System.Windows.Forms.PictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.DataGridViewQrCodes).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBoxQrCodeImage).BeginInit();
		this.SuspendLayout();
		this.lblQrCode.AutoSize = true;
		System.Windows.Forms.Label label = this.lblQrCode;
		System.Drawing.Point location = new System.Drawing.Point(3, 24);
		label.Location = location;
		this.lblQrCode.Name = "lblQrCode";
		System.Windows.Forms.Label label2 = this.lblQrCode;
		System.Drawing.Size size = new System.Drawing.Size(46, 13);
		label2.Size = size;
		this.lblQrCode.TabIndex = 0;
		this.lblQrCode.Text = "Qr Code";
		System.Windows.Forms.Button button = this.btnAddQrCode;
		location = new System.Drawing.Point(57, 202);
		button.Location = location;
		this.btnAddQrCode.Name = "btnAddQrCode";
		System.Windows.Forms.Button button2 = this.btnAddQrCode;
		size = new System.Drawing.Size(88, 23);
		button2.Size = size;
		this.btnAddQrCode.TabIndex = 1;
		this.btnAddQrCode.Text = "Add QR Code";
		this.btnAddQrCode.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button3 = this.btnCancel;
		location = new System.Drawing.Point(151, 202);
		button3.Location = location;
		this.btnCancel.Name = "btnCancel";
		System.Windows.Forms.Button button4 = this.btnCancel;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnCancel.TabIndex = 2;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.lblProducrNumber.AutoSize = true;
		System.Windows.Forms.Label label3 = this.lblProducrNumber;
		location = new System.Drawing.Point(3, 41);
		label3.Location = location;
		this.lblProducrNumber.Name = "lblProducrNumber";
		System.Windows.Forms.Label label4 = this.lblProducrNumber;
		size = new System.Drawing.Size(61, 13);
		label4.Size = size;
		this.lblProducrNumber.TabIndex = 4;
		this.lblProducrNumber.Text = "Product No";
		this.lblQrImage.AutoSize = true;
		System.Windows.Forms.Label label5 = this.lblQrImage;
		location = new System.Drawing.Point(3, 176);
		label5.Location = location;
		this.lblQrImage.Name = "lblQrImage";
		System.Windows.Forms.Label label6 = this.lblQrImage;
		size = new System.Drawing.Size(72, 13);
		label6.Size = size;
		this.lblQrImage.TabIndex = 5;
		this.lblQrImage.Text = "Add Qr Image";
		System.Windows.Forms.Button button5 = this.btnBrowse;
		location = new System.Drawing.Point(227, 173);
		button5.Location = location;
		this.btnBrowse.Name = "btnBrowse";
		System.Windows.Forms.Button button6 = this.btnBrowse;
		size = new System.Drawing.Size(59, 24);
		button6.Size = size;
		this.btnBrowse.TabIndex = 89;
		this.btnBrowse.Text = "Browse";
		this.btnBrowse.UseVisualStyleBackColor = true;
		System.Windows.Forms.TextBox textBox = this.txtQrImage;
		location = new System.Drawing.Point(81, 173);
		textBox.Location = location;
		this.txtQrImage.Name = "txtQrImage";
		System.Windows.Forms.TextBox textBox2 = this.txtQrImage;
		size = new System.Drawing.Size(140, 20);
		textBox2.Size = size;
		this.txtQrImage.TabIndex = 88;
		System.Windows.Forms.TextBox textBox3 = this.txtQrCode;
		location = new System.Drawing.Point(84, 17);
		textBox3.Location = location;
		this.txtQrCode.Name = "txtQrCode";
		System.Windows.Forms.TextBox textBox4 = this.txtQrCode;
		size = new System.Drawing.Size(100, 20);
		textBox4.Size = size;
		this.txtQrCode.TabIndex = 91;
		System.Windows.Forms.TextBox textBox5 = this.txtProductNumber;
		location = new System.Drawing.Point(84, 41);
		textBox5.Location = location;
		this.txtProductNumber.Name = "txtProductNumber";
		System.Windows.Forms.TextBox textBox6 = this.txtProductNumber;
		size = new System.Drawing.Size(100, 20);
		textBox6.Size = size;
		this.txtProductNumber.TabIndex = 92;
		this.chkQrCodeImage.AutoSize = true;
		this.chkQrCodeImage.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
		this.chkQrCodeImage.ForeColor = System.Drawing.Color.DimGray;
		System.Windows.Forms.CheckBox checkBox = this.chkQrCodeImage;
		location = new System.Drawing.Point(5, 156);
		checkBox.Location = location;
		this.chkQrCodeImage.Name = "chkQrCodeImage";
		System.Windows.Forms.CheckBox checkBox2 = this.chkQrCodeImage;
		size = new System.Drawing.Size(175, 17);
		checkBox2.Size = size;
		this.chkQrCodeImage.TabIndex = 93;
		this.chkQrCodeImage.Text = "Change Qr Code Image";
		this.chkQrCodeImage.UseVisualStyleBackColor = true;
		this.DataGridViewQrCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		System.Windows.Forms.DataGridView dataGridViewQrCodes = this.DataGridViewQrCodes;
		location = new System.Drawing.Point(5, 238);
		dataGridViewQrCodes.Location = location;
		this.DataGridViewQrCodes.Name = "DataGridViewQrCodes";
		System.Windows.Forms.DataGridView dataGridViewQrCodes2 = this.DataGridViewQrCodes;
		size = new System.Drawing.Size(442, 210);
		dataGridViewQrCodes2.Size = size;
		this.DataGridViewQrCodes.TabIndex = 94;
		this.OpenPictureDialog.FileName = "OpenFileDialog1";
		this.PictureBoxQrCodeImage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.PictureBoxQrCodeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		System.Windows.Forms.PictureBox pictureBoxQrCodeImage = this.PictureBoxQrCodeImage;
		location = new System.Drawing.Point(84, 65);
		pictureBoxQrCodeImage.Location = location;
		this.PictureBoxQrCodeImage.Name = "PictureBoxQrCodeImage";
		System.Windows.Forms.PictureBox pictureBoxQrCodeImage2 = this.PictureBoxQrCodeImage;
		size = new System.Drawing.Size(100, 90);
		pictureBoxQrCodeImage2.Size = size;
		this.PictureBoxQrCodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBoxQrCodeImage.TabIndex = 95;
		this.PictureBoxQrCodeImage.TabStop = false;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label1;
		location = new System.Drawing.Point(3, 65);
		label7.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label8 = this.Label1;
		size = new System.Drawing.Size(78, 13);
		label8.Size = size;
		this.Label1.TabIndex = 96;
		this.Label1.Text = "Qr Code Image";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label2;
		location = new System.Drawing.Point(64, 1);
		label9.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label10 = this.Label2;
		size = new System.Drawing.Size(254, 13);
		label10.Size = size;
		this.Label2.TabIndex = 97;
		this.Label2.Text = "Single Click on any row to update an existing record ";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(454, 460);
		this.ClientSize = size;
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.PictureBoxQrCodeImage);
		this.Controls.Add(this.DataGridViewQrCodes);
		this.Controls.Add(this.chkQrCodeImage);
		this.Controls.Add(this.txtProductNumber);
		this.Controls.Add(this.txtQrCode);
		this.Controls.Add(this.btnBrowse);
		this.Controls.Add(this.txtQrImage);
		this.Controls.Add(this.lblQrImage);
		this.Controls.Add(this.lblProducrNumber);
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.btnAddQrCode);
		this.Controls.Add(this.lblQrCode);
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "FrmAddNewQrCodes";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "QRCodes Form";
		((System.ComponentModel.ISupportInitialize)this.DataGridViewQrCodes).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBoxQrCodeImage).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnBrowse_Click(object sender, EventArgs e)
	{
		OpenFileDialog openPictureDialog = OpenPictureDialog;
		openPictureDialog.Title = "QrCode Image Browser";
		openPictureDialog.InitialDirectory = "c:\\";
		openPictureDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
		openPictureDialog.RestoreDirectory = true;
		openPictureDialog.FileName = "";
		openPictureDialog.CheckFileExists = true;
		if (OpenPictureDialog.ShowDialog() == DialogResult.OK)
		{
			txtQrImage.Text = OpenPictureDialog.FileName;
		}
		openPictureDialog = null;
	}

	private void FrmAddNewQrCodes_Load(object sender, EventArgs e)
	{
		chkQrCodeImage.Visible = false;
		BindQRCodes();
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

	public object AddQrCodes(string ProductNumber, string Link, string QrPhoto)
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("Insert into tblQrCode (Link,ProductNumber,QrPhoto) Values(@Link,@ProductNumber,@QrPhoto)", DbConnection);
		DbCommand.Parameters.AddWithValue("@Link", Link.Trim().ToString());
		DbCommand.Parameters.AddWithValue("@ProductNumber", ProductNumber.Trim().ToString());
		DbCommand.Parameters.AddWithValue("@QrPhoto", RuntimeHelpers.GetObjectValue(LoadImage(QrPhoto)));
		DbConnection.Open();
		if (DbCommand.ExecuteNonQuery() > 0)
		{
			return true;
		}
		return false;
	}

	public object UpdateQrCodes(string ProductNumber, string Link, string QrPhoto)
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		if (Operators.CompareString(QrPhoto, "", TextCompare: false) == 0)
		{
			DbCommand = new OleDbCommand("Update tblQrCode Set ProductNumber=@ProductNumber where Link=@Link", DbConnection);
			DbCommand.Parameters.AddWithValue("@ProductNumber", ProductNumber.Trim().ToString());
			DbCommand.Parameters.AddWithValue("@Link", Link.Trim().ToString());
			DbConnection.Open();
			if (DbCommand.ExecuteNonQuery() > 0)
			{
				return true;
			}
			return false;
		}
		DbCommand = new OleDbCommand("Update tblQrCode Set ProductNumber=@ProductNumber,QrPhoto=@QrPhoto where Link=@Link", DbConnection);
		DbCommand.Parameters.AddWithValue("@ProductNumber", ProductNumber.Trim().ToString());
		DbCommand.Parameters.AddWithValue("@QrPhoto", RuntimeHelpers.GetObjectValue(LoadImage(QrPhoto)));
		DbCommand.Parameters.AddWithValue("@Link", Link.Trim().ToString());
		DbConnection.Open();
		if (DbCommand.ExecuteNonQuery() > 0)
		{
			return true;
		}
		return false;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	public bool SearchQRCodes(string QRCode)
	{
		int i = 0;
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("select * from tblQrCode where Link='" + QRCode.ToString().Trim() + "'", DbConnection);
		DataSet DSQRCodes = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(DSQRCodes, "tblQrCode");
		if (DSQRCodes.Tables[0].Rows.Count > 0)
		{
			return true;
		}
		return false;
	}

	public bool SearchProductQRCodes(string ProductNumber)
	{
		int i = 0;
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("select * from tblQrCode where ProductNumber='" + ProductNumber.ToString().Trim() + "'", DbConnection);
		DataSet DSQRCodes = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(DSQRCodes, "tblQrCode");
		if (DSQRCodes.Tables[0].Rows.Count > 0)
		{
			return true;
		}
		return false;
	}

	public void BindQRCodes()
	{
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("select * from tblQrCode ORDER BY ProductNumber", DbConnection);
		DataSet DSQRCodes = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(DSQRCodes, "tblQrCode");
		if (DSQRCodes.Tables[0].Rows.Count > 0)
		{
			DataGridViewQrCodes.DataSource = DSQRCodes.Tables[0];
			return;
		}
		MessageBox.Show("No Qr Codes in the database.Add them", "QBTag");
		txtQrCode.Focus();
	}

	private void btnAddQrCode_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(btnAddQrCode.Text, "Add QR Code", TextCompare: false) == 0)
		{
			if (Operators.CompareString(txtQrCode.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show("Please enter QRCode", "QBTag");
				txtQrCode.Focus();
				return;
			}
			if (Operators.CompareString(txtProductNumber.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show("Please enter Product Number", "QBTag");
				txtProductNumber.Focus();
				return;
			}
			if (Operators.CompareString(txtQrImage.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show("Please browse image for QRCode", "QBTag");
				btnBrowse.Focus();
				return;
			}
			if (SearchQRCodes(txtQrCode.Text))
			{
				MessageBox.Show(txtQrCode.Text + " already exists", "QBTag");
				return;
			}
			if (SearchProductQRCodes(txtProductNumber.Text))
			{
				MessageBox.Show("QR Code of " + txtProductNumber.Text + " already exists", "QBTag");
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(AddQrCodes(txtProductNumber.Text.Trim().ToString(), txtQrCode.Text.Trim().ToString(), txtQrImage.Text), true, TextCompare: false))
			{
				MessageBox.Show("QR Code of " + txtProductNumber.Text + " added successfully", "QBTag");
				BindQRCodes();
			}
		}
		if (Operators.CompareString(btnAddQrCode.Text, "Update QrCode", TextCompare: false) != 0)
		{
			return;
		}
		if (Operators.CompareString(txtQrCode.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter QRCode", "QBTag");
			txtQrCode.Focus();
		}
		else if (Operators.CompareString(txtProductNumber.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter Product Number", "QBTag");
			txtProductNumber.Focus();
		}
		else if (chkQrCodeImage.Checked)
		{
			if (Operators.CompareString(txtQrImage.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show("Please browse image for QRCode", "QBTag");
				btnBrowse.Focus();
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(UpdateQrCodes(txtProductNumber.Text.Trim().ToString(), txtQrCode.Text.Trim().ToString(), txtQrImage.Text), true, TextCompare: false))
			{
				MessageBox.Show("QR Code of " + txtProductNumber.Text + " updated successfully", "QBTag");
				BindQRCodes();
			}
			chkQrCodeImage.Visible = false;
		}
		else
		{
			if (Operators.ConditionalCompareObjectEqual(UpdateQrCodes(txtProductNumber.Text, txtQrCode.Text, txtQrImage.Text), true, TextCompare: false))
			{
				MessageBox.Show("QR Code of " + txtProductNumber.Text + " updated successfully", "QBTag");
				BindQRCodes();
			}
			chkQrCodeImage.Visible = false;
		}
	}

	private void DataGridViewQrCodes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			DataGridView dataGridViewQrCodes = DataGridViewQrCodes;
			foreach (DataGridViewRow r in dataGridViewQrCodes.SelectedRows)
			{
				QRCode = DataGridViewQrCodes.Rows[r.Index].Cells[0].Value.ToString().Trim();
				ProductNumber = DataGridViewQrCodes.Rows[r.Index].Cells[1].Value.ToString().Trim();
				byte[] bytArrayContent = (byte[])DataGridViewQrCodes.Rows[r.Index].Cells[2].Value;
				MemoryStream stream = new MemoryStream(bytArrayContent);
				Image img = Image.FromStream(stream);
				txtQrCode.Text = QRCode;
				txtProductNumber.Text = ProductNumber;
				PictureBoxQrCodeImage.Image = img;
			}
			dataGridViewQrCodes = null;
			if (DataGridViewQrCodes.RowCount > 0)
			{
				btnAddQrCode.Text = "Update QrCode";
				chkQrCodeImage.Visible = true;
			}
			lblQrImage.Visible = false;
			txtQrImage.Visible = false;
			btnBrowse.Visible = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logs.Log.Add(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void chkQrCodeImage_CheckedChanged(object sender, EventArgs e)
	{
		if (chkQrCodeImage.Checked)
		{
			lblQrImage.Visible = true;
			txtQrImage.Visible = true;
			btnBrowse.Visible = true;
		}
		else
		{
			lblQrImage.Visible = false;
			txtQrImage.Visible = false;
			btnBrowse.Visible = false;
		}
	}

	private void OpenPictureDialog_FileOk(object sender, CancelEventArgs e)
	{
	}
}
