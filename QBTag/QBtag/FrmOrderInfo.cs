using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;
using QuickBooksHandler;
using QuickBooksModel;

namespace QBtag;

[DesignerGenerated]
public class FrmOrderInfo : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtOrderNumber")]
	private TextBox _txtOrderNumber;

	[AccessedThroughProperty("txtBelt")]
	private TextBox _txtBelt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtMotor")]
	private TextBox _txtMotor;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtPartType")]
	private TextBox _txtPartType;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("DataGridViewOrders")]
	private DataGridView _DataGridViewOrders;

	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[AccessedThroughProperty("btnAdd")]
	private Button _btnAdd;

	public string AccessConStr;

	public string ConnectionString;

	public string ConnectionString2;

	private string OrderNumber;

	public object conStr;

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

	internal virtual TextBox txtOrderNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrderNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrderNumber = value;
		}
	}

	internal virtual TextBox txtBelt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBelt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBelt = value;
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

	internal virtual TextBox txtMotor
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMotor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMotor = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox txtPartType
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPartType = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Button btnSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnSave_Click;
			if (_btnSave != null)
			{
				_btnSave.Click -= value2;
			}
			_btnSave = value;
			if (_btnSave != null)
			{
				_btnSave.Click += value2;
			}
		}
	}

	internal virtual DataGridView DataGridViewOrders
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewOrders;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataGridViewCellMouseEventHandler value2 = DataGridViewOrders_RowHeaderMouseClick;
			if (_DataGridViewOrders != null)
			{
				_DataGridViewOrders.RowHeaderMouseClick -= value2;
			}
			_DataGridViewOrders = value;
			if (_DataGridViewOrders != null)
			{
				_DataGridViewOrders.RowHeaderMouseClick += value2;
			}
		}
	}

	internal virtual Button btnDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnDelete_Click;
			if (_btnDelete != null)
			{
				_btnDelete.Click -= value2;
			}
			_btnDelete = value;
			if (_btnDelete != null)
			{
				_btnDelete.Click += value2;
			}
		}
	}

	internal virtual Button btnAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAdd_Click;
			if (_btnAdd != null)
			{
				_btnAdd.Click -= value2;
			}
			_btnAdd = value;
			if (_btnAdd != null)
			{
				_btnAdd.Click += value2;
			}
		}
	}

	public FrmOrderInfo()
	{
		base.Load += FrmOrderInfo_Load;
		__ENCAddToList(this);
		AccessConStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
		ConnectionString = "";
		ConnectionString2 = "";
		OrderNumber = "";
		conStr = MySettingsProperty.Settings.QuickBooksDBConnectionString;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.txtOrderNumber = new System.Windows.Forms.TextBox();
		this.txtBelt = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.txtMotor = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtPartType = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.DataGridViewOrders = new System.Windows.Forms.DataGridView();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.DataGridViewOrders).BeginInit();
		this.SuspendLayout();
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		System.Drawing.Point location = new System.Drawing.Point(12, 9);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		System.Drawing.Size size = new System.Drawing.Size(73, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Order Number";
		System.Windows.Forms.TextBox textBox = this.txtOrderNumber;
		location = new System.Drawing.Point(86, 6);
		textBox.Location = location;
		this.txtOrderNumber.Name = "txtOrderNumber";
		System.Windows.Forms.TextBox textBox2 = this.txtOrderNumber;
		size = new System.Drawing.Size(100, 20);
		textBox2.Size = size;
		this.txtOrderNumber.TabIndex = 1;
		System.Windows.Forms.TextBox textBox3 = this.txtBelt;
		location = new System.Drawing.Point(270, 6);
		textBox3.Location = location;
		this.txtBelt.Name = "txtBelt";
		System.Windows.Forms.TextBox textBox4 = this.txtBelt;
		size = new System.Drawing.Size(100, 20);
		textBox4.Size = size;
		this.txtBelt.TabIndex = 3;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(212, 9);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(25, 13);
		label4.Size = size;
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Belt";
		System.Windows.Forms.TextBox textBox5 = this.txtMotor;
		location = new System.Drawing.Point(86, 32);
		textBox5.Location = location;
		this.txtMotor.Name = "txtMotor";
		System.Windows.Forms.TextBox textBox6 = this.txtMotor;
		size = new System.Drawing.Size(100, 20);
		textBox6.Size = size;
		this.txtMotor.TabIndex = 5;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(12, 35);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(34, 13);
		label6.Size = size;
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Motor";
		System.Windows.Forms.TextBox textBox7 = this.txtPartType;
		location = new System.Drawing.Point(270, 32);
		textBox7.Location = location;
		this.txtPartType.Name = "txtPartType";
		System.Windows.Forms.TextBox textBox8 = this.txtPartType;
		size = new System.Drawing.Size(100, 20);
		textBox8.Size = size;
		this.txtPartType.TabIndex = 7;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(212, 35);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(53, 13);
		label8.Size = size;
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Part Type";
		System.Windows.Forms.Button button = this.btnSave;
		location = new System.Drawing.Point(177, 71);
		button.Location = location;
		this.btnSave.Name = "btnSave";
		System.Windows.Forms.Button button2 = this.btnSave;
		size = new System.Drawing.Size(75, 23);
		button2.Size = size;
		this.btnSave.TabIndex = 8;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		System.Windows.Forms.DataGridView dataGridViewOrders = this.DataGridViewOrders;
		location = new System.Drawing.Point(-3, 138);
		dataGridViewOrders.Location = location;
		this.DataGridViewOrders.Name = "DataGridViewOrders";
		System.Windows.Forms.DataGridView dataGridViewOrders2 = this.DataGridViewOrders;
		size = new System.Drawing.Size(450, 401);
		dataGridViewOrders2.Size = size;
		this.DataGridViewOrders.TabIndex = 9;
		System.Windows.Forms.Button button3 = this.btnDelete;
		location = new System.Drawing.Point(258, 71);
		button3.Location = location;
		this.btnDelete.Name = "btnDelete";
		System.Windows.Forms.Button button4 = this.btnDelete;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnDelete.TabIndex = 10;
		this.btnDelete.Text = "Delete";
		this.btnDelete.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button5 = this.btnAdd;
		location = new System.Drawing.Point(96, 71);
		button5.Location = location;
		this.btnAdd.Name = "btnAdd";
		System.Windows.Forms.Button button6 = this.btnAdd;
		size = new System.Drawing.Size(75, 23);
		button6.Size = size;
		this.btnAdd.TabIndex = 11;
		this.btnAdd.Text = "Add";
		this.btnAdd.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(444, 551);
		this.ClientSize = size;
		this.Controls.Add(this.btnAdd);
		this.Controls.Add(this.btnDelete);
		this.Controls.Add(this.DataGridViewOrders);
		this.Controls.Add(this.btnSave);
		this.Controls.Add(this.txtPartType);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.txtMotor);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.txtBelt);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.txtOrderNumber);
		this.Controls.Add(this.Label1);
		this.Name = "FrmOrderInfo";
		this.Text = "FrmOrderInfo";
		((System.ComponentModel.ISupportInitialize)this.DataGridViewOrders).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmOrderInfo_Load(object sender, EventArgs e)
	{
		GetOrders();
	}

	public void GetOrders()
	{
		OrderInfoHandler OH = new OrderInfoHandler();
		List<OrderInfo> orders = new OrderInfoHandler().GetOrders(AccessConStr);
		DataGridViewOrders.DataSource = orders;
	}

	private void DataGridViewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		DataGridView dataGridViewOrders = DataGridViewOrders;
		foreach (DataGridViewRow r in dataGridViewOrders.SelectedRows)
		{
			OrderNumber = DataGridViewOrders.Rows[r.Index].Cells[0].Value.ToString();
			txtOrderNumber.Text = DataGridViewOrders.Rows[r.Index].Cells[0].Value.ToString();
			txtMotor.Text = DataGridViewOrders.Rows[r.Index].Cells[1].Value.ToString();
			txtBelt.Text = DataGridViewOrders.Rows[r.Index].Cells[2].Value.ToString();
			txtPartType.Text = DataGridViewOrders.Rows[r.Index].Cells[3].Value.ToString();
		}
		dataGridViewOrders = null;
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtOrderNumber.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter order number");
			txtOrderNumber.Focus();
			return;
		}
		if (Operators.CompareString(txtPartType.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter Part Type");
			txtPartType.Focus();
			return;
		}
		OrderInfoHandler OH = new OrderInfoHandler();
		OrderInfo Order = new OrderInfo();
		Order.OrderNumber = txtOrderNumber.Text;
		Order.Motor = txtMotor.Text;
		Order.Belt = txtBelt.Text;
		Order.PartType = txtPartType.Text;
		if (MessageBox.Show("Are you sure you want to Update Order Number " + txtOrderNumber.Text + "?") == DialogResult.OK)
		{
			OH.UpdateOrderInfo(Order, AccessConStr, OrderNumber);
			GetOrders();
			ClearFields();
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtOrderNumber.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter order number");
			txtOrderNumber.Focus();
			return;
		}
		if (Operators.CompareString(txtPartType.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter Part Type");
			txtPartType.Focus();
			return;
		}
		OrderInfoHandler OH = new OrderInfoHandler();
		OrderInfo Order = new OrderInfo();
		Order.OrderNumber = txtOrderNumber.Text;
		Order.Motor = txtMotor.Text;
		Order.Belt = txtBelt.Text;
		Order.PartType = txtPartType.Text;
		if (OH.CheckOrderNumber(AccessConStr, txtOrderNumber.Text))
		{
			MessageBox.Show("Order Number: " + txtOrderNumber.Text + " already exists");
			txtOrderNumber.Focus();
		}
		else if (MessageBox.Show("Are you sure you want to insert Order Number " + txtOrderNumber.Text + "?") == DialogResult.OK)
		{
			OH.AddOrderInfo(Order, AccessConStr);
			GetOrders();
			ClearFields();
		}
	}

	public void ClearFields()
	{
		txtOrderNumber.Text = "";
		txtPartType.Text = "";
		txtMotor.Text = "";
		txtBelt.Text = "";
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtOrderNumber.Text, "", TextCompare: false) == 0)
		{
			MessageBox.Show("Please enter order number");
			txtOrderNumber.Focus();
			return;
		}
		OrderInfoHandler OH = new OrderInfoHandler();
		if (MessageBox.Show("Are you sure you want to Delete Order Number " + txtOrderNumber.Text + "?") == DialogResult.OK)
		{
			OH.DeleteOrderInfo(AccessConStr, txtOrderNumber.Text);
			GetOrders();
			ClearFields();
		}
	}
}
