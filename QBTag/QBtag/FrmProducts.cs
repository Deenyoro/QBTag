using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace QBtag;

[DesignerGenerated]
public class FrmProducts : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("dgvProduct")]
	private DataGridView _dgvProduct;

	[AccessedThroughProperty("colProduct")]
	private DataGridViewTextBoxColumn _colProduct;

	[AccessedThroughProperty("colQuantity")]
	private DataGridViewTextBoxColumn _colQuantity;

	[AccessedThroughProperty("colDelete")]
	private DataGridViewTextBoxColumn _colDelete;

	private Hashtable hashCheckExist;

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

	internal virtual DataGridView dgvProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataGridViewCellEventHandler value2 = dgvProduct_CellEndEdit;
			DataGridViewCellEventHandler value3 = dgvProduct_CellContentClick;
			if (_dgvProduct != null)
			{
				_dgvProduct.CellEndEdit -= value2;
				_dgvProduct.CellContentClick -= value3;
			}
			_dgvProduct = value;
			if (_dgvProduct != null)
			{
				_dgvProduct.CellEndEdit += value2;
				_dgvProduct.CellContentClick += value3;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn colProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _colProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colProduct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colQuantity
	{
		[DebuggerNonUserCode]
		get
		{
			return _colQuantity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colQuantity = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _colDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colDelete = value;
		}
	}

	public FrmProducts()
	{
		base.Load += FrmProducts_Load;
		__ENCAddToList(this);
		hashCheckExist = new Hashtable();
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
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnClose = new System.Windows.Forms.Button();
		this.dgvProduct = new System.Windows.Forms.DataGridView();
		this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.dgvProduct).BeginInit();
		this.SuspendLayout();
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		System.Windows.Forms.Button button = this.btnSave;
		System.Drawing.Point location = new System.Drawing.Point(419, 301);
		button.Location = location;
		this.btnSave.Name = "btnSave";
		System.Windows.Forms.Button button2 = this.btnSave;
		System.Drawing.Size size = new System.Drawing.Size(75, 23);
		button2.Size = size;
		this.btnSave.TabIndex = 0;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		System.Windows.Forms.Button button3 = this.btnClose;
		location = new System.Drawing.Point(500, 301);
		button3.Location = location;
		this.btnClose.Name = "btnClose";
		System.Windows.Forms.Button button4 = this.btnClose;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnClose.TabIndex = 0;
		this.btnClose.Text = "Close";
		this.btnClose.UseVisualStyleBackColor = true;
		this.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
		DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
		this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvProduct.Columns.AddRange(this.colProduct, this.colQuantity, this.colDelete);
		System.Windows.Forms.DataGridView dataGridView = this.dgvProduct;
		location = new System.Drawing.Point(13, 13);
		dataGridView.Location = location;
		this.dgvProduct.Name = "dgvProduct";
		this.dgvProduct.RowHeadersVisible = false;
		System.Windows.Forms.DataGridView dataGridView2 = this.dgvProduct;
		size = new System.Drawing.Size(562, 273);
		dataGridView2.Size = size;
		this.dgvProduct.TabIndex = 1;
		this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.colProduct.HeaderText = "Product Name";
		this.colProduct.Name = "colProduct";
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		this.colQuantity.DefaultCellStyle = DataGridViewCellStyle2;
		this.colQuantity.HeaderText = "Quantity";
		this.colQuantity.Name = "colQuantity";
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
		this.colDelete.DefaultCellStyle = DataGridViewCellStyle3;
		this.colDelete.HeaderText = "";
		this.colDelete.Name = "colDelete";
		this.colDelete.ReadOnly = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(587, 339);
		this.ClientSize = size;
		this.Controls.Add(this.dgvProduct);
		this.Controls.Add(this.btnClose);
		this.Controls.Add(this.btnSave);
		this.Name = "FrmProducts";
		this.Text = "Products";
		((System.ComponentModel.ISupportInitialize)this.dgvProduct).EndInit();
		this.ResumeLayout(false);
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		string value = "";
		try
		{
			value = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if ((hashCheckExist != null) & (hashCheckExist[value] != null))
		{
			MessageBox.Show("Product name is exist. Please enter other product name.");
			dgvProduct.Rows[e.RowIndex].Cells[0].Value = "";
		}
		else if (value.Length > 0)
		{
			Products prd = new Products();
			prd.ProductName = value;
			if (!prd.CheckExist())
			{
				hashCheckExist[value] = value;
				dgvProduct.Rows[e.RowIndex].Cells[1].Value = 2;
				dgvProduct.Rows[e.RowIndex].Cells[2].Value = "Delete";
			}
		}
	}

	private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.ColumnIndex == 2) & (dgvProduct.Rows[e.RowIndex].Cells[2].Value != null))
		{
			if (dgvProduct.Rows[e.RowIndex].Cells[0].Value != null)
			{
				hashCheckExist.Remove(RuntimeHelpers.GetObjectValue(dgvProduct.Rows[e.RowIndex].Cells[0].Value));
			}
			Products prd = new Products();
			if (prd.Delete(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString()))
			{
				dgvProduct.Rows.RemoveAt(e.RowIndex);
			}
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		btnSave.Focus();
		if (dgvProduct.Rows.Count <= 0)
		{
			return;
		}
		DataTable dt = new DataTable();
		dt.Columns.Add("ProductName");
		List<Products> lstProduct = new List<Products>();
		int count = dgvProduct.Rows.Count;
		int i = 0;
		while (true)
		{
			int num = i;
			int num2 = count;
			if (num > num2)
			{
				break;
			}
			try
			{
				if ((dgvProduct.Rows[i].Cells[0].Value != null) & (dgvProduct.Rows[i].Cells[0].Value.ToString().Trim().Length > 0))
				{
					Products prd = new Products();
					prd.ProductName = dgvProduct.Rows[i].Cells[0].Value.ToString().Trim();
					try
					{
						prd.Quantity = double.Parse(dgvProduct.Rows[i].Cells[1].Value.ToString().Trim());
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					lstProduct.Add(prd);
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			i = checked(i + 1);
		}
		if (!((lstProduct != null) & (lstProduct.Count > 0)))
		{
			return;
		}
		foreach (Products prd2 in lstProduct)
		{
			bool isExist = prd2.CheckExist();
			bool isSave = false;
			if (isExist)
			{
				isSave = prd2.Update();
			}
			else
			{
				isSave = prd2.AddProduct();
			}
		}
		MessageBox.Show("Save done");
	}

	private void FrmProducts_Load(object sender, EventArgs e)
	{
		try
		{
			Products prds = new Products();
			Hashtable hashProduct = prds.GetProducts();
			int row = 0;
			if (!((hashProduct != null) & (hashProduct.Count > 0)))
			{
				return;
			}
			foreach (object key2 in hashProduct.Keys)
			{
				string key = Conversions.ToString(key2);
				Products prd = (Products)hashProduct[key];
				dgvProduct.Rows.Add();
				dgvProduct.Rows[row].Cells[0].Value = prd.ProductName;
				dgvProduct.Rows[row].Cells[1].Value = prd.Quantity;
				dgvProduct.Rows[row].Cells[2].Value = "Delete";
				hashCheckExist[prd.ProductName] = prd.ProductName;
				row = checked(row + 1);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
