using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;
using QuickBooksHandler;
using QuickBooksModel;

namespace QBtag;

[DesignerGenerated]
public class FrmTestODBC : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnTest")]
	private Button _btnTest;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("btnLoadData")]
	private Button _btnLoadData;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	public object conStr;

	public string AccessConStr;

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

	public string ConnectionString;

	public string ConnectionString2;

	public string WhereNow;

	public string PdfPath;

	public string ExcelPath;

	public OleDbCommand DbCommand;

	public OdbcCommand DbCommand2;

	public OdbcCommand DbCommand3;

	public OdbcCommand DbCommand4;

	public OdbcCommand DbCommand5;

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

	internal virtual Button btnTest
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnTest_Click;
			if (_btnTest != null)
			{
				_btnTest.Click -= value2;
			}
			_btnTest = value;
			if (_btnTest != null)
			{
				_btnTest.Click += value2;
			}
		}
	}

	internal virtual DataGridView DataGridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView1 = value;
		}
	}

	internal virtual Button btnLoadData
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLoadData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnLoadData_Click;
			if (_btnLoadData != null)
			{
				_btnLoadData.Click -= value2;
			}
			_btnLoadData = value;
			if (_btnLoadData != null)
			{
				_btnLoadData.Click += value2;
			}
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

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button3_Click;
			if (_Button3 != null)
			{
				_Button3.Click -= value2;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				_Button3.Click += value2;
			}
		}
	}

	public FrmTestODBC()
	{
		__ENCAddToList(this);
		conStr = MySettingsProperty.Settings.QuickBooksDBConnectionString;
		AccessConStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
		ConnectionString = "";
		ConnectionString2 = "";
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
		this.btnTest = new System.Windows.Forms.Button();
		this.DataGridView1 = new System.Windows.Forms.DataGridView();
		this.btnLoadData = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		this.SuspendLayout();
		System.Windows.Forms.Button button = this.btnTest;
		System.Drawing.Point location = new System.Drawing.Point(61, 12);
		button.Location = location;
		this.btnTest.Name = "btnTest";
		System.Windows.Forms.Button button2 = this.btnTest;
		System.Drawing.Size size = new System.Drawing.Size(75, 23);
		button2.Size = size;
		this.btnTest.TabIndex = 0;
		this.btnTest.Text = "Test";
		this.btnTest.UseVisualStyleBackColor = true;
		this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		System.Windows.Forms.DataGridView dataGridView = this.DataGridView1;
		location = new System.Drawing.Point(12, 76);
		dataGridView.Location = location;
		this.DataGridView1.Name = "DataGridView1";
		System.Windows.Forms.DataGridView dataGridView2 = this.DataGridView1;
		size = new System.Drawing.Size(1447, 514);
		dataGridView2.Size = size;
		this.DataGridView1.TabIndex = 1;
		System.Windows.Forms.Button button3 = this.btnLoadData;
		location = new System.Drawing.Point(258, 12);
		button3.Location = location;
		this.btnLoadData.Name = "btnLoadData";
		System.Windows.Forms.Button button4 = this.btnLoadData;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnLoadData.TabIndex = 2;
		this.btnLoadData.Text = "Load Data";
		this.btnLoadData.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button5 = this.Button1;
		location = new System.Drawing.Point(509, 11);
		button5.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button6 = this.Button1;
		size = new System.Drawing.Size(75, 23);
		button6.Size = size;
		this.Button1.TabIndex = 3;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button7 = this.Button2;
		location = new System.Drawing.Point(753, 23);
		button7.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button8 = this.Button2;
		size = new System.Drawing.Size(75, 23);
		button8.Size = size;
		this.Button2.TabIndex = 4;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button9 = this.Button3;
		location = new System.Drawing.Point(376, 23);
		button9.Location = location;
		this.Button3.Name = "Button3";
		System.Windows.Forms.Button button10 = this.Button3;
		size = new System.Drawing.Size(75, 23);
		button10.Size = size;
		this.Button3.TabIndex = 5;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(1458, 596);
		this.ClientSize = size;
		this.Controls.Add(this.Button3);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.btnLoadData);
		this.Controls.Add(this.DataGridView1);
		this.Controls.Add(this.btnTest);
		this.Name = "FrmTestODBC";
		this.Text = "FrmTestODBC";
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		this.ResumeLayout(false);
	}

	private void btnTest_Click(object sender, EventArgs e)
	{
		List<Parts> parts = new PartsHandler().GetParts(AccessConStr);
		SalesOrderLineHandler SOLH = new SalesOrderLineHandler();
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders("24965", Conversions.ToString(conStr), AccessConStr);
		string input = "test, and test but not testing.  But yes to test";
		string pattext = "testing";
		string pattern = "\\b" + pattext + "\\b";
		string replace = "text";
		foreach (Parts row in parts)
		{
			foreach (SalesOrderLine item in SalesOrderLineList)
			{
				if (Regex.IsMatch(item.SalesOrderLineItemRefFullName, "\\b" + row.PartType + "\\b", RegexOptions.Singleline))
				{
					MessageBox.Show(item.SalesOrderLineItemRefFullName + "  " + row.PartType);
				}
			}
		}
	}

	private void btnLoadData_Click(object sender, EventArgs e)
	{
		TomProgram("2737");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		BindSalesLineListView("25508");
	}

	public void BindSalesOrderLineListView(string OrderNumber, string conStr)
	{
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(OrderNumber, conStr, AccessConStr);
		List<OrderInfo> OrderList = new List<OrderInfo>();
		OrderInfo orderinfo = new OrderInfo();
		foreach (SalesOrderLine Item in SalesOrderLineList)
		{
			if (Operators.CompareString(Item.SalesOrderLineGroupItemGroupRefFullName, "", TextCompare: false) != 0)
			{
				orderinfo.PartType = Item.SalesOrderLineGroupItemGroupRefFullName;
			}
			OrderInfo odr = new OrderInfo();
			odr.PartType = orderinfo.PartType;
			odr.Belt = Item.Belt;
			odr.Motor = Item.Motor;
			odr.OrderNumber = Item.SerialNumber;
		}
	}

	public void BindSalesLineListView(string OrderNumber)
	{
		SalesOrderLineHandler SOLH = new SalesOrderLineHandler();
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders(OrderNumber, Conversions.ToString(conStr), AccessConStr);
		List<OrderInfo> OrderList = new List<OrderInfo>();
		List<OrderInfo> OrderListFinal = new List<OrderInfo>();
		List<OrderInfo> FinalOrderList = new List<OrderInfo>();
		foreach (SalesOrderLine Item in SalesOrderLineList)
		{
			OrderInfo odr = new OrderInfo();
			odr.PartType = Item.SalesOrderLineGroupItemGroupRefFullName;
			if (Operators.CompareString(Item.Belt, "", TextCompare: false) != 0)
			{
				odr.Belt = Item.Belt;
				odr.OrderNumber = Item.SerialNumber;
				OrderList.Add(odr);
			}
			if (Operators.CompareString(Item.Motor, "", TextCompare: false) != 0)
			{
				odr.Motor = Item.Motor;
				odr.OrderNumber = Item.SerialNumber;
				OrderList.Add(odr);
			}
		}
		foreach (OrderInfo itm in OrderList)
		{
			OrderInfo orderinfo = new OrderInfo();
			if (!itm.OrderNumber.EndsWith(Conversions.ToString(0)))
			{
				orderinfo.PartType = itm.PartType;
				orderinfo.Belt = itm.Belt;
				orderinfo.Motor = itm.Motor;
				orderinfo.OrderNumber = itm.OrderNumber;
				OrderListFinal.Add(orderinfo);
			}
		}
		foreach (OrderInfo m in OrderList)
		{
			foreach (OrderInfo b in OrderList)
			{
				if ((Operators.CompareString(m.OrderNumber, b.OrderNumber, TextCompare: false) == 0) & (Operators.CompareString(m.PartType, b.PartType, TextCompare: false) == 0))
				{
					OrderInfo order = new OrderInfo();
					order.OrderNumber = m.OrderNumber;
					order.Motor = m.Motor;
					order.Belt = b.Belt;
					order.PartType = m.PartType;
					FinalOrderList.Add(order);
				}
			}
		}
		DataGridView1.DataSource = SalesOrderLineList;
	}

	public void BindSalesLineListView(string OrderNumber, string SalesLineType)
	{
		List<SalesLine> SalesLineList = new SalesLineHandler().GetSalesLineOrders(OrderNumber, SalesLineType);
		SalesLineHandler SLH = new SalesLineHandler();
		List<OrderInfo> OrderList = new List<OrderInfo>();
		OrderInfo orderinfo = new OrderInfo();
		foreach (SalesLine Item in SalesLineList)
		{
			if (Operators.CompareString(Item.Belt, "", TextCompare: false) != 0)
			{
				orderinfo.OrderNumber = Item.SerialNumber;
				orderinfo.Belt = Item.Belt;
				orderinfo.Motor = SLH.GetSalesLineOrderMotor(Item.RefNumber, Item.SalesLineType, Conversions.ToString(conStr)).Motor;
				orderinfo.PartType = Item.PartType;
				OrderList.Add(orderinfo);
			}
		}
		DataGridView1.DataSource = OrderList;
	}

	public void BindSalesLineListView(string FromOrderNumber, string ToOrderNumber, string SalesLineType)
	{
		List<SalesLine> SalesLineList = new SalesLineHandler().GetSalesLineOrders(FromOrderNumber, ToOrderNumber, SalesLineType);
		SalesLineHandler SLH = new SalesLineHandler();
		OrderInfoHandler OIH = new OrderInfoHandler();
		List<OrderInfo> OrderList = new List<OrderInfo>();
		foreach (SalesLine Item in SalesLineList)
		{
			if (Operators.CompareString(Item.Belt, "", TextCompare: false) != 0)
			{
				OrderInfo orderinfo = new OrderInfo();
				orderinfo.OrderNumber = Item.SerialNumber;
				orderinfo.Belt = Item.Belt;
				orderinfo.Motor = SLH.GetSalesLineOrderMotor(Item.RefNumber, Item.SalesLineType, Conversions.ToString(conStr)).Motor;
				orderinfo.PartType = Item.PartType;
				OIH.AddOrderInfo(orderinfo, Conversions.ToString(conStr));
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		OrderInfoHandler OH = new OrderInfoHandler();
		List<Parts> parts = new PartsHandler().GetParts(AccessConStr);
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders("25980", Conversions.ToString(conStr), AccessConStr);
		List<OrderInfo> OrderList = new List<OrderInfo>();
		List<OrderInfo> FinalOrderList = new List<OrderInfo>();
		List<OrderInfo> BeltOrdersList = new List<OrderInfo>();
		List<OrderInfo> MotorOrdersList = new List<OrderInfo>();
		List<OrderInfo> OrdersListFinal = new List<OrderInfo>();
		string BeltOrderNumber = "";
		string OrderNumber = "";
		int Quantity = 0;
		DataGridView1.DataSource = SalesOrderLineList;
	}

	public List<OrderInfo> ListRemoveDups(List<OrderInfo> Source, bool MatchCase = false)
	{
		Source.Sort();
		checked
		{
			int x = Source.Count - 1;
			while (true)
			{
				int num = x;
				int num2 = 1;
				if (num < num2)
				{
					break;
				}
				if (MatchCase)
				{
					if (Operators.CompareString(Source[x].OrderNumber, Source[x - 1].OrderNumber, TextCompare: false) == 0)
					{
						Source.RemoveAt(x);
					}
				}
				else if (Operators.CompareString(Source[x].OrderNumber, Source[x - 1].OrderNumber, TextCompare: false) == 0)
				{
					Source.RemoveAt(x);
				}
				x += -1;
			}
			return Source;
		}
	}

	public void TomProgram(string ReferenceNumber)
	{
		OdbcConnection cn = new OdbcConnection("dsn=QuickBooks Data;uid=Admin;pwd=Abanaki1;");
		string mystring = "Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'";
		OdbcCommand cmd = new OdbcCommand(mystring, cn);
		OdbcDataAdapter daQODBC = new OdbcDataAdapter(cmd);
		DataSet dsQODBC = new DataSet();
		cn.Open();
		string OrderNumber = "";
		int Quantity = 0;
		string Motor = "";
		string Belt = "";
		daQODBC.Fill(dsQODBC);
		cn.Close();
		dsQODBC.Tables[0].Rows[2][2] = "0";
		DataGridView1.DataSource = dsQODBC.Tables[0];
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		OrderInfoHandler OH = new OrderInfoHandler();
		List<Parts> parts = new PartsHandler().GetParts(AccessConStr);
		List<SalesOrderLine> SalesOrderLineList = new SalesOrderLineHandler().GetSalesOrderLineOrders("25066", Conversions.ToString(conStr), AccessConStr);
		List<OrderInfo> OrderList = new List<OrderInfo>();
		List<OrderInfo> FinalOrderList = new List<OrderInfo>();
		List<OrderInfo> BeltOrdersList = new List<OrderInfo>();
		List<OrderInfo> MotorOrdersList = new List<OrderInfo>();
		List<OrderInfo> OrdersListFinal = new List<OrderInfo>();
		string BeltOrderNumber = "";
		string OrderNumber = "";
		int Quantity = 0;
		OH.DeleteOrderInfo(AccessConStr);
		foreach (Parts row in parts)
		{
			foreach (SalesOrderLine item in SalesOrderLineList)
			{
				if (!item.SalesOrderLineGroupItemGroupRefFullName.StartsWith(row.PartType))
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
					string[] ItemName = item.SalesOrderLineItemRefFullName.Split(':');
					if (ItemName[0].ToString().StartsWith("M-"))
					{
						item.Motor = ItemName[1].ToString();
					}
					else if (ItemName[0].ToString().StartsWith("B-"))
					{
						item.Belt = ItemName[1].ToString();
					}
					OrderInfo o = new OrderInfo();
					o.OrderNumber = item.RefNumber + "-" + Conversions.ToString(item.SalesOrderLineSeqNo);
					o.PartType = item.PartType;
					o.OrderNumber = o.OrderNumber + "-" + Conversions.ToString(i);
					o.Belt = item.Belt;
					o.Motor = item.Motor;
					o.PartType = item.PartType;
					OH.DeleteOrderInfo(AccessConStr);
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
			OH.AddOrderInfo(o4, AccessConStr);
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
					OH.AddOrderInfo(o5, AccessConStr);
				}
			}
		}
	}
}
