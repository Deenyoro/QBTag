using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.usmanDataSetTableAdapters;

namespace QBtag;

[DesignerGenerated]
public class FormOrdShowU : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UsmanDataSet")]
	private usmanDataSet _UsmanDataSet;

	[AccessedThroughProperty("Dbo_OrderInfoBindingSource")]
	private BindingSource _Dbo_OrderInfoBindingSource;

	[AccessedThroughProperty("Dbo_OrderInfoTableAdapter")]
	private dbo_OrderInfoTableAdapter _Dbo_OrderInfoTableAdapter;

	[AccessedThroughProperty("TableAdapterManager")]
	private TableAdapterManager _TableAdapterManager;

	[AccessedThroughProperty("Dbo_OrderInfoBindingNavigator")]
	private BindingNavigator _Dbo_OrderInfoBindingNavigator;

	[AccessedThroughProperty("BindingNavigatorAddNewItem")]
	private ToolStripButton _BindingNavigatorAddNewItem;

	[AccessedThroughProperty("BindingNavigatorCountItem")]
	private ToolStripLabel _BindingNavigatorCountItem;

	[AccessedThroughProperty("BindingNavigatorDeleteItem")]
	private ToolStripButton _BindingNavigatorDeleteItem;

	[AccessedThroughProperty("BindingNavigatorMoveFirstItem")]
	private ToolStripButton _BindingNavigatorMoveFirstItem;

	[AccessedThroughProperty("BindingNavigatorMovePreviousItem")]
	private ToolStripButton _BindingNavigatorMovePreviousItem;

	[AccessedThroughProperty("BindingNavigatorSeparator")]
	private ToolStripSeparator _BindingNavigatorSeparator;

	[AccessedThroughProperty("BindingNavigatorPositionItem")]
	private ToolStripTextBox _BindingNavigatorPositionItem;

	[AccessedThroughProperty("BindingNavigatorSeparator1")]
	private ToolStripSeparator _BindingNavigatorSeparator1;

	[AccessedThroughProperty("BindingNavigatorMoveNextItem")]
	private ToolStripButton _BindingNavigatorMoveNextItem;

	[AccessedThroughProperty("BindingNavigatorMoveLastItem")]
	private ToolStripButton _BindingNavigatorMoveLastItem;

	[AccessedThroughProperty("BindingNavigatorSeparator2")]
	private ToolStripSeparator _BindingNavigatorSeparator2;

	[AccessedThroughProperty("Dbo_OrderInfoBindingNavigatorSaveItem")]
	private ToolStripButton _Dbo_OrderInfoBindingNavigatorSaveItem;

	[AccessedThroughProperty("OrderInfoTableAdapter")]
	private OrderInfoTableAdapter _OrderInfoTableAdapter;

	[AccessedThroughProperty("OrderInfoBindingSource")]
	private BindingSource _OrderInfoBindingSource;

	[AccessedThroughProperty("OrderInfoDataGridView")]
	private DataGridView _OrderInfoDataGridView;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal virtual usmanDataSet UsmanDataSet
	{
		[DebuggerNonUserCode]
		get
		{
			return _UsmanDataSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UsmanDataSet = value;
		}
	}

	internal virtual BindingSource Dbo_OrderInfoBindingSource
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dbo_OrderInfoBindingSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dbo_OrderInfoBindingSource = value;
		}
	}

	internal virtual dbo_OrderInfoTableAdapter Dbo_OrderInfoTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dbo_OrderInfoTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dbo_OrderInfoTableAdapter = value;
		}
	}

	internal virtual TableAdapterManager TableAdapterManager
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableAdapterManager;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableAdapterManager = value;
		}
	}

	internal virtual BindingNavigator Dbo_OrderInfoBindingNavigator
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dbo_OrderInfoBindingNavigator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dbo_OrderInfoBindingNavigator = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorAddNewItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorAddNewItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorAddNewItem = value;
		}
	}

	internal virtual ToolStripLabel BindingNavigatorCountItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorCountItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorCountItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorDeleteItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorDeleteItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorDeleteItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveFirstItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveFirstItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveFirstItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMovePreviousItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMovePreviousItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMovePreviousItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator = value;
		}
	}

	internal virtual ToolStripTextBox BindingNavigatorPositionItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorPositionItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorPositionItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator1 = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveNextItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveNextItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveNextItem = value;
		}
	}

	internal virtual ToolStripButton BindingNavigatorMoveLastItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorMoveLastItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorMoveLastItem = value;
		}
	}

	internal virtual ToolStripSeparator BindingNavigatorSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindingNavigatorSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindingNavigatorSeparator2 = value;
		}
	}

	internal virtual ToolStripButton Dbo_OrderInfoBindingNavigatorSaveItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dbo_OrderInfoBindingNavigatorSaveItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Dbo_OrderInfoBindingNavigatorSaveItem_Click;
			if (_Dbo_OrderInfoBindingNavigatorSaveItem != null)
			{
				_Dbo_OrderInfoBindingNavigatorSaveItem.Click -= value2;
			}
			_Dbo_OrderInfoBindingNavigatorSaveItem = value;
			if (_Dbo_OrderInfoBindingNavigatorSaveItem != null)
			{
				_Dbo_OrderInfoBindingNavigatorSaveItem.Click += value2;
			}
		}
	}

	internal virtual OrderInfoTableAdapter OrderInfoTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _OrderInfoTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OrderInfoTableAdapter = value;
		}
	}

	internal virtual BindingSource OrderInfoBindingSource
	{
		[DebuggerNonUserCode]
		get
		{
			return _OrderInfoBindingSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OrderInfoBindingSource = value;
		}
	}

	internal virtual DataGridView OrderInfoDataGridView
	{
		[DebuggerNonUserCode]
		get
		{
			return _OrderInfoDataGridView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OrderInfoDataGridView = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
		}
	}

	[DebuggerNonUserCode]
	public FormOrdShowU()
	{
		base.Load += FormOrdShow_Load;
		__ENCAddToList(this);
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QBtag.FormOrdShowU));
		this.UsmanDataSet = new QBtag.usmanDataSet();
		this.Dbo_OrderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.Dbo_OrderInfoTableAdapter = new QBtag.usmanDataSetTableAdapters.dbo_OrderInfoTableAdapter();
		this.TableAdapterManager = new QBtag.usmanDataSetTableAdapters.TableAdapterManager();
		this.OrderInfoTableAdapter = new QBtag.usmanDataSetTableAdapters.OrderInfoTableAdapter();
		this.Dbo_OrderInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
		this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
		this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
		this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
		this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
		this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.Dbo_OrderInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
		this.OrderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.OrderInfoDataGridView = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.UsmanDataSet).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Dbo_OrderInfoBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Dbo_OrderInfoBindingNavigator).BeginInit();
		this.Dbo_OrderInfoBindingNavigator.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.OrderInfoBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.OrderInfoDataGridView).BeginInit();
		this.SuspendLayout();
		this.UsmanDataSet.DataSetName = "usmanDataSet";
		this.UsmanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.Dbo_OrderInfoBindingSource.DataMember = "dbo_OrderInfo";
		this.Dbo_OrderInfoBindingSource.DataSource = this.UsmanDataSet;
		this.Dbo_OrderInfoTableAdapter.ClearBeforeFill = true;
		this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
		this.TableAdapterManager.dbo_OrderInfoTableAdapter = this.Dbo_OrderInfoTableAdapter;
		this.TableAdapterManager.OrderInfoTableAdapter = this.OrderInfoTableAdapter;
		this.TableAdapterManager.PartsTableAdapter = null;
		this.TableAdapterManager.SalesOrderLineTableAdapter = null;
		this.TableAdapterManager.tblQrCodeTableAdapter = null;
		this.TableAdapterManager.UpdateOrder = QBtag.usmanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
		this.OrderInfoTableAdapter.ClearBeforeFill = true;
		this.Dbo_OrderInfoBindingNavigator.AddNewItem = this.BindingNavigatorAddNewItem;
		this.Dbo_OrderInfoBindingNavigator.BindingSource = this.Dbo_OrderInfoBindingSource;
		this.Dbo_OrderInfoBindingNavigator.CountItem = this.BindingNavigatorCountItem;
		this.Dbo_OrderInfoBindingNavigator.DeleteItem = this.BindingNavigatorDeleteItem;
		this.Dbo_OrderInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[12]
		{
			this.BindingNavigatorMoveFirstItem, this.BindingNavigatorMovePreviousItem, this.BindingNavigatorSeparator, this.BindingNavigatorPositionItem, this.BindingNavigatorCountItem, this.BindingNavigatorSeparator1, this.BindingNavigatorMoveNextItem, this.BindingNavigatorMoveLastItem, this.BindingNavigatorSeparator2, this.BindingNavigatorAddNewItem,
			this.BindingNavigatorDeleteItem, this.Dbo_OrderInfoBindingNavigatorSaveItem
		});
		System.Windows.Forms.BindingNavigator dbo_OrderInfoBindingNavigator = this.Dbo_OrderInfoBindingNavigator;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		dbo_OrderInfoBindingNavigator.Location = location;
		this.Dbo_OrderInfoBindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
		this.Dbo_OrderInfoBindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
		this.Dbo_OrderInfoBindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
		this.Dbo_OrderInfoBindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
		this.Dbo_OrderInfoBindingNavigator.Name = "Dbo_OrderInfoBindingNavigator";
		this.Dbo_OrderInfoBindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
		System.Windows.Forms.BindingNavigator dbo_OrderInfoBindingNavigator2 = this.Dbo_OrderInfoBindingNavigator;
		System.Drawing.Size size = new System.Drawing.Size(542, 25);
		dbo_OrderInfoBindingNavigator2.Size = size;
		this.Dbo_OrderInfoBindingNavigator.TabIndex = 0;
		this.Dbo_OrderInfoBindingNavigator.Text = "BindingNavigator1";
		this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorAddNewItem.Image");
		this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
		this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem = this.BindingNavigatorAddNewItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorAddNewItem.Size = size;
		this.BindingNavigatorAddNewItem.Text = "Add new";
		this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
		System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem = this.BindingNavigatorCountItem;
		size = new System.Drawing.Size(35, 22);
		bindingNavigatorCountItem.Size = size;
		this.BindingNavigatorCountItem.Text = "of {0}";
		this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
		this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
		this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
		this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem = this.BindingNavigatorDeleteItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorDeleteItem.Size = size;
		this.BindingNavigatorDeleteItem.Text = "Delete";
		this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorMoveFirstItem.Image");
		this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
		this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem = this.BindingNavigatorMoveFirstItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorMoveFirstItem.Size = size;
		this.BindingNavigatorMoveFirstItem.Text = "Move first";
		this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorMovePreviousItem.Image");
		this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
		this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem = this.BindingNavigatorMovePreviousItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorMovePreviousItem.Size = size;
		this.BindingNavigatorMovePreviousItem.Text = "Move previous";
		this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
		System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator = this.BindingNavigatorSeparator;
		size = new System.Drawing.Size(6, 25);
		bindingNavigatorSeparator.Size = size;
		this.BindingNavigatorPositionItem.AccessibleName = "Position";
		this.BindingNavigatorPositionItem.AutoSize = false;
		this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
		System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem = this.BindingNavigatorPositionItem;
		size = new System.Drawing.Size(50, 23);
		bindingNavigatorPositionItem.Size = size;
		this.BindingNavigatorPositionItem.Text = "0";
		this.BindingNavigatorPositionItem.ToolTipText = "Current position";
		this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
		System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2 = this.BindingNavigatorSeparator1;
		size = new System.Drawing.Size(6, 25);
		bindingNavigatorSeparator2.Size = size;
		this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorMoveNextItem.Image");
		this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
		this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem = this.BindingNavigatorMoveNextItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorMoveNextItem.Size = size;
		this.BindingNavigatorMoveNextItem.Text = "Move next";
		this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.BindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("BindingNavigatorMoveLastItem.Image");
		this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
		this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
		System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem = this.BindingNavigatorMoveLastItem;
		size = new System.Drawing.Size(23, 22);
		bindingNavigatorMoveLastItem.Size = size;
		this.BindingNavigatorMoveLastItem.Text = "Move last";
		this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
		System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3 = this.BindingNavigatorSeparator2;
		size = new System.Drawing.Size(6, 25);
		bindingNavigatorSeparator3.Size = size;
		this.Dbo_OrderInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.Dbo_OrderInfoBindingNavigatorSaveItem.Image = (System.Drawing.Image)resources.GetObject("Dbo_OrderInfoBindingNavigatorSaveItem.Image");
		this.Dbo_OrderInfoBindingNavigatorSaveItem.Name = "Dbo_OrderInfoBindingNavigatorSaveItem";
		System.Windows.Forms.ToolStripButton dbo_OrderInfoBindingNavigatorSaveItem = this.Dbo_OrderInfoBindingNavigatorSaveItem;
		size = new System.Drawing.Size(23, 22);
		dbo_OrderInfoBindingNavigatorSaveItem.Size = size;
		this.Dbo_OrderInfoBindingNavigatorSaveItem.Text = "Save Data";
		this.OrderInfoBindingSource.DataMember = "OrderInfo";
		this.OrderInfoBindingSource.DataSource = this.UsmanDataSet;
		this.OrderInfoDataGridView.AutoGenerateColumns = false;
		this.OrderInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.OrderInfoDataGridView.Columns.AddRange(this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4);
		this.OrderInfoDataGridView.DataSource = this.OrderInfoBindingSource;
		this.OrderInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.DataGridView orderInfoDataGridView = this.OrderInfoDataGridView;
		location = new System.Drawing.Point(0, 25);
		orderInfoDataGridView.Location = location;
		System.Windows.Forms.DataGridView orderInfoDataGridView2 = this.OrderInfoDataGridView;
		System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(2);
		orderInfoDataGridView2.Margin = margin;
		this.OrderInfoDataGridView.Name = "OrderInfoDataGridView";
		this.OrderInfoDataGridView.RowTemplate.Height = 24;
		System.Windows.Forms.DataGridView orderInfoDataGridView3 = this.OrderInfoDataGridView;
		size = new System.Drawing.Size(542, 467);
		orderInfoDataGridView3.Size = size;
		this.OrderInfoDataGridView.TabIndex = 1;
		this.DataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
		this.DataGridViewTextBoxColumn1.HeaderText = "OrderNumber";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn2.DataPropertyName = "Motor";
		this.DataGridViewTextBoxColumn2.HeaderText = "Motor";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn3.DataPropertyName = "Belt";
		this.DataGridViewTextBoxColumn3.HeaderText = "Belt";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn4.DataPropertyName = "PartType";
		this.DataGridViewTextBoxColumn4.HeaderText = "PartType";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(542, 492);
		this.ClientSize = size;
		this.Controls.Add(this.OrderInfoDataGridView);
		this.Controls.Add(this.Dbo_OrderInfoBindingNavigator);
		this.Name = "FormOrdShowU";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "OrderInfo";
		((System.ComponentModel.ISupportInitialize)this.UsmanDataSet).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Dbo_OrderInfoBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Dbo_OrderInfoBindingNavigator).EndInit();
		this.Dbo_OrderInfoBindingNavigator.ResumeLayout(false);
		this.Dbo_OrderInfoBindingNavigator.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.OrderInfoBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.OrderInfoDataGridView).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FormOrdShow_Load(object sender, EventArgs e)
	{
		OrderInfoTableAdapter.Fill(UsmanDataSet.OrderInfo);
		Dbo_OrderInfoTableAdapter.Fill(UsmanDataSet.dbo_OrderInfo);
	}

	private void Dbo_OrderInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		Validate();
		Dbo_OrderInfoBindingSource.EndEdit();
		TableAdapterManager.UpdateAll(UsmanDataSet);
	}

	private void OrderInfoDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}
}
