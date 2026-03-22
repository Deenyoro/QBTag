#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace QBtag.usmanDataSetTableAdapters;

[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
public class TableAdapterManager : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	/// <summary>
	/// Used to sort self-referenced table's rows
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private DataRow GetRoot(DataRow row, ref int distance)
		{
			Debug.Assert(row != null);
			DataRow root = row;
			distance = 0;
			IDictionary<DataRow, DataRow> traversedRows = new Dictionary<DataRow, DataRow>();
			traversedRows[row] = row;
			DataRow parent = row.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while ((parent != null && !traversedRows.ContainsKey(parent)) ? true : false)
				{
					distance++;
					root = parent;
					traversedRows[parent] = parent;
					parent = parent.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (distance == 0)
				{
					traversedRows.Clear();
					traversedRows[row] = row;
					parent = row.GetParentRow(_relation, DataRowVersion.Original);
					while ((parent != null && !traversedRows.ContainsKey(parent)) ? true : false)
					{
						distance++;
						root = parent;
						traversedRows[parent] = parent;
						parent = parent.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return root;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Compare(DataRow row1, DataRow row2)
		{
			if (object.ReferenceEquals(row1, row2))
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int distance1 = 0;
			DataRow root1 = GetRoot(row1, ref distance1);
			int distance2 = 0;
			DataRow root2 = GetRoot(row2, ref distance2);
			if (object.ReferenceEquals(root1, root2))
			{
				return checked(_childFirst * distance1.CompareTo(distance2));
			}
			Debug.Assert((root1.Table != null && root2.Table != null) ? true : false);
			if (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow row1, DataRow row2)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(row1, row2);
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private UpdateOrderOption _updateOrder;

	private dbo_OrderInfoTableAdapter _dbo_OrderInfoTableAdapter;

	private PartsTableAdapter _partsTableAdapter;

	private SalesOrderLineTableAdapter _salesOrderLineTableAdapter;

	private tblQrCodeTableAdapter _tblQrCodeTableAdapter;

	private OrderInfoTableAdapter _orderInfoTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public dbo_OrderInfoTableAdapter dbo_OrderInfoTableAdapter
	{
		get
		{
			return _dbo_OrderInfoTableAdapter;
		}
		set
		{
			_dbo_OrderInfoTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public PartsTableAdapter PartsTableAdapter
	{
		get
		{
			return _partsTableAdapter;
		}
		set
		{
			_partsTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public SalesOrderLineTableAdapter SalesOrderLineTableAdapter
	{
		get
		{
			return _salesOrderLineTableAdapter;
		}
		set
		{
			_salesOrderLineTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public tblQrCodeTableAdapter tblQrCodeTableAdapter
	{
		get
		{
			return _tblQrCodeTableAdapter;
		}
		set
		{
			_tblQrCodeTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public OrderInfoTableAdapter OrderInfoTableAdapter
	{
		get
		{
			return _orderInfoTableAdapter;
		}
		set
		{
			_orderInfoTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if ((_dbo_OrderInfoTableAdapter != null && _dbo_OrderInfoTableAdapter.Connection != null) ? true : false)
			{
				return _dbo_OrderInfoTableAdapter.Connection;
			}
			if ((_partsTableAdapter != null && _partsTableAdapter.Connection != null) ? true : false)
			{
				return _partsTableAdapter.Connection;
			}
			if ((_salesOrderLineTableAdapter != null && _salesOrderLineTableAdapter.Connection != null) ? true : false)
			{
				return _salesOrderLineTableAdapter.Connection;
			}
			if ((_tblQrCodeTableAdapter != null && _tblQrCodeTableAdapter.Connection != null) ? true : false)
			{
				return _tblQrCodeTableAdapter.Connection;
			}
			if ((_orderInfoTableAdapter != null && _orderInfoTableAdapter.Connection != null) ? true : false)
			{
				return _orderInfoTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public int TableAdapterInstanceCount
	{
		get
		{
			int count = 0;
			checked
			{
				if (_dbo_OrderInfoTableAdapter != null)
				{
					count++;
				}
				if (_partsTableAdapter != null)
				{
					count++;
				}
				if (_salesOrderLineTableAdapter != null)
				{
					count++;
				}
				if (_tblQrCodeTableAdapter != null)
				{
					count++;
				}
				if (_orderInfoTableAdapter != null)
				{
					count++;
				}
				return count;
			}
		}
	}

	[DebuggerNonUserCode]
	public TableAdapterManager()
	{
		__ENCAddToList(this);
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

	/// <summary>
	/// Update rows in top-down order.
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateUpdatedRows(usmanDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		int result = 0;
		checked
		{
			if (_tblQrCodeTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.tblQrCode.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
				if ((updatedRows != null && 0 < updatedRows.Length) ? true : false)
				{
					result += _tblQrCodeTableAdapter.Update(updatedRows);
					allChangedRows.AddRange(updatedRows);
				}
			}
			if (_orderInfoTableAdapter != null)
			{
				DataRow[] updatedRows2 = dataSet.OrderInfo.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows2 = GetRealUpdatedRows(updatedRows2, allAddedRows);
				if ((updatedRows2 != null && 0 < updatedRows2.Length) ? true : false)
				{
					result += _orderInfoTableAdapter.Update(updatedRows2);
					allChangedRows.AddRange(updatedRows2);
				}
			}
			if (_salesOrderLineTableAdapter != null)
			{
				DataRow[] updatedRows3 = dataSet.SalesOrderLine.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows3 = GetRealUpdatedRows(updatedRows3, allAddedRows);
				if ((updatedRows3 != null && 0 < updatedRows3.Length) ? true : false)
				{
					result += _salesOrderLineTableAdapter.Update(updatedRows3);
					allChangedRows.AddRange(updatedRows3);
				}
			}
			if (_dbo_OrderInfoTableAdapter != null)
			{
				DataRow[] updatedRows4 = dataSet.dbo_OrderInfo.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows4 = GetRealUpdatedRows(updatedRows4, allAddedRows);
				if ((updatedRows4 != null && 0 < updatedRows4.Length) ? true : false)
				{
					result += _dbo_OrderInfoTableAdapter.Update(updatedRows4);
					allChangedRows.AddRange(updatedRows4);
				}
			}
			if (_partsTableAdapter != null)
			{
				DataRow[] updatedRows5 = dataSet.Parts.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows5 = GetRealUpdatedRows(updatedRows5, allAddedRows);
				if ((updatedRows5 != null && 0 < updatedRows5.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(updatedRows5);
					allChangedRows.AddRange(updatedRows5);
				}
			}
			return result;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateInsertedRows(usmanDataSet dataSet, List<DataRow> allAddedRows)
	{
		int result = 0;
		checked
		{
			if (_tblQrCodeTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.tblQrCode.Select(null, null, DataViewRowState.Added);
				if ((addedRows != null && 0 < addedRows.Length) ? true : false)
				{
					result += _tblQrCodeTableAdapter.Update(addedRows);
					allAddedRows.AddRange(addedRows);
				}
			}
			if (_orderInfoTableAdapter != null)
			{
				DataRow[] addedRows2 = dataSet.OrderInfo.Select(null, null, DataViewRowState.Added);
				if ((addedRows2 != null && 0 < addedRows2.Length) ? true : false)
				{
					result += _orderInfoTableAdapter.Update(addedRows2);
					allAddedRows.AddRange(addedRows2);
				}
			}
			if (_salesOrderLineTableAdapter != null)
			{
				DataRow[] addedRows3 = dataSet.SalesOrderLine.Select(null, null, DataViewRowState.Added);
				if ((addedRows3 != null && 0 < addedRows3.Length) ? true : false)
				{
					result += _salesOrderLineTableAdapter.Update(addedRows3);
					allAddedRows.AddRange(addedRows3);
				}
			}
			if (_dbo_OrderInfoTableAdapter != null)
			{
				DataRow[] addedRows4 = dataSet.dbo_OrderInfo.Select(null, null, DataViewRowState.Added);
				if ((addedRows4 != null && 0 < addedRows4.Length) ? true : false)
				{
					result += _dbo_OrderInfoTableAdapter.Update(addedRows4);
					allAddedRows.AddRange(addedRows4);
				}
			}
			if (_partsTableAdapter != null)
			{
				DataRow[] addedRows5 = dataSet.Parts.Select(null, null, DataViewRowState.Added);
				if ((addedRows5 != null && 0 < addedRows5.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(addedRows5);
					allAddedRows.AddRange(addedRows5);
				}
			}
			return result;
		}
	}

	/// <summary>
	/// Delete rows in bottom-up order.
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateDeletedRows(usmanDataSet dataSet, List<DataRow> allChangedRows)
	{
		int result = 0;
		checked
		{
			if (_partsTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.Parts.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows != null && 0 < deletedRows.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(deletedRows);
					allChangedRows.AddRange(deletedRows);
				}
			}
			if (_dbo_OrderInfoTableAdapter != null)
			{
				DataRow[] deletedRows2 = dataSet.dbo_OrderInfo.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows2 != null && 0 < deletedRows2.Length) ? true : false)
				{
					result += _dbo_OrderInfoTableAdapter.Update(deletedRows2);
					allChangedRows.AddRange(deletedRows2);
				}
			}
			if (_salesOrderLineTableAdapter != null)
			{
				DataRow[] deletedRows3 = dataSet.SalesOrderLine.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows3 != null && 0 < deletedRows3.Length) ? true : false)
				{
					result += _salesOrderLineTableAdapter.Update(deletedRows3);
					allChangedRows.AddRange(deletedRows3);
				}
			}
			if (_orderInfoTableAdapter != null)
			{
				DataRow[] deletedRows4 = dataSet.OrderInfo.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows4 != null && 0 < deletedRows4.Length) ? true : false)
				{
					result += _orderInfoTableAdapter.Update(deletedRows4);
					allChangedRows.AddRange(deletedRows4);
				}
			}
			if (_tblQrCodeTableAdapter != null)
			{
				DataRow[] deletedRows5 = dataSet.tblQrCode.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows5 != null && 0 < deletedRows5.Length) ? true : false)
				{
					result += _tblQrCodeTableAdapter.Update(deletedRows5);
					allChangedRows.AddRange(deletedRows5);
				}
			}
			return result;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> realUpdatedRows = new List<DataRow>();
		foreach (DataRow row in updatedRows)
		{
			if (!allAddedRows.Contains(row))
			{
				realUpdatedRows.Add(row);
			}
		}
		return realUpdatedRows.ToArray();
	}

	/// <summary>
	/// Update all changes to the dataset.
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int UpdateAll(usmanDataSet dataSet)
	{
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if ((_dbo_OrderInfoTableAdapter != null && !MatchTableAdapterConnection(_dbo_OrderInfoTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if ((_partsTableAdapter != null && !MatchTableAdapterConnection(_partsTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if ((_salesOrderLineTableAdapter != null && !MatchTableAdapterConnection(_salesOrderLineTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if ((_tblQrCodeTableAdapter != null && !MatchTableAdapterConnection(_tblQrCodeTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if ((_orderInfoTableAdapter != null && !MatchTableAdapterConnection(_orderInfoTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		IDbConnection workConnection = Connection;
		if (workConnection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool workConnOpened = false;
		if ((workConnection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			workConnection.Close();
		}
		if (workConnection.State == ConnectionState.Closed)
		{
			workConnection.Open();
			workConnOpened = true;
		}
		IDbTransaction workTransaction = workConnection.BeginTransaction();
		if (workTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> allChangedRows = new List<DataRow>();
		List<DataRow> allAddedRows = new List<DataRow>();
		List<DataAdapter> adaptersWithAcceptChangesDuringUpdate = new List<DataAdapter>();
		Dictionary<object, IDbConnection> revertConnections = new Dictionary<object, IDbConnection>();
		int result = 0;
		DataSet backupDataSet = null;
		if (BackupDataSetBeforeUpdate)
		{
			backupDataSet = new DataSet();
			backupDataSet.Merge(dataSet);
		}
		checked
		{
			try
			{
				if (_dbo_OrderInfoTableAdapter != null)
				{
					revertConnections.Add(_dbo_OrderInfoTableAdapter, _dbo_OrderInfoTableAdapter.Connection);
					_dbo_OrderInfoTableAdapter.Connection = (OleDbConnection)workConnection;
					_dbo_OrderInfoTableAdapter.Transaction = (OleDbTransaction)workTransaction;
					if (_dbo_OrderInfoTableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_dbo_OrderInfoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						adaptersWithAcceptChangesDuringUpdate.Add(_dbo_OrderInfoTableAdapter.Adapter);
					}
				}
				if (_partsTableAdapter != null)
				{
					revertConnections.Add(_partsTableAdapter, _partsTableAdapter.Connection);
					_partsTableAdapter.Connection = (OleDbConnection)workConnection;
					_partsTableAdapter.Transaction = (OleDbTransaction)workTransaction;
					if (_partsTableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_partsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						adaptersWithAcceptChangesDuringUpdate.Add(_partsTableAdapter.Adapter);
					}
				}
				if (_salesOrderLineTableAdapter != null)
				{
					revertConnections.Add(_salesOrderLineTableAdapter, _salesOrderLineTableAdapter.Connection);
					_salesOrderLineTableAdapter.Connection = (OleDbConnection)workConnection;
					_salesOrderLineTableAdapter.Transaction = (OleDbTransaction)workTransaction;
					if (_salesOrderLineTableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_salesOrderLineTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						adaptersWithAcceptChangesDuringUpdate.Add(_salesOrderLineTableAdapter.Adapter);
					}
				}
				if (_tblQrCodeTableAdapter != null)
				{
					revertConnections.Add(_tblQrCodeTableAdapter, _tblQrCodeTableAdapter.Connection);
					_tblQrCodeTableAdapter.Connection = (OleDbConnection)workConnection;
					_tblQrCodeTableAdapter.Transaction = (OleDbTransaction)workTransaction;
					if (_tblQrCodeTableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_tblQrCodeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						adaptersWithAcceptChangesDuringUpdate.Add(_tblQrCodeTableAdapter.Adapter);
					}
				}
				if (_orderInfoTableAdapter != null)
				{
					revertConnections.Add(_orderInfoTableAdapter, _orderInfoTableAdapter.Connection);
					_orderInfoTableAdapter.Connection = (OleDbConnection)workConnection;
					_orderInfoTableAdapter.Transaction = (OleDbTransaction)workTransaction;
					if (_orderInfoTableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_orderInfoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						adaptersWithAcceptChangesDuringUpdate.Add(_orderInfoTableAdapter.Adapter);
					}
				}
				if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
				{
					result += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
					result += UpdateInsertedRows(dataSet, allAddedRows);
				}
				else
				{
					result += UpdateInsertedRows(dataSet, allAddedRows);
					result += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
				}
				result += UpdateDeletedRows(dataSet, allChangedRows);
				workTransaction.Commit();
				if (0 < allAddedRows.Count)
				{
					DataRow[] rows = new DataRow[allAddedRows.Count - 1 + 1];
					allAddedRows.CopyTo(rows);
					foreach (DataRow row in rows)
					{
						row.AcceptChanges();
					}
				}
				if (0 < allChangedRows.Count)
				{
					DataRow[] rows2 = new DataRow[allChangedRows.Count - 1 + 1];
					allChangedRows.CopyTo(rows2);
					foreach (DataRow row2 in rows2)
					{
						row2.AcceptChanges();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				workTransaction.Rollback();
				if (BackupDataSetBeforeUpdate)
				{
					Debug.Assert(backupDataSet != null);
					dataSet.Clear();
					dataSet.Merge(backupDataSet);
				}
				else if (0 < allAddedRows.Count)
				{
					DataRow[] rows3 = new DataRow[allAddedRows.Count - 1 + 1];
					allAddedRows.CopyTo(rows3);
					foreach (DataRow row3 in rows3)
					{
						row3.AcceptChanges();
						row3.SetAdded();
					}
				}
				throw ex2;
			}
			finally
			{
				if (workConnOpened)
				{
					workConnection.Close();
				}
				if (_dbo_OrderInfoTableAdapter != null)
				{
					_dbo_OrderInfoTableAdapter.Connection = (OleDbConnection)revertConnections[_dbo_OrderInfoTableAdapter];
					_dbo_OrderInfoTableAdapter.Transaction = null;
				}
				if (_partsTableAdapter != null)
				{
					_partsTableAdapter.Connection = (OleDbConnection)revertConnections[_partsTableAdapter];
					_partsTableAdapter.Transaction = null;
				}
				if (_salesOrderLineTableAdapter != null)
				{
					_salesOrderLineTableAdapter.Connection = (OleDbConnection)revertConnections[_salesOrderLineTableAdapter];
					_salesOrderLineTableAdapter.Transaction = null;
				}
				if (_tblQrCodeTableAdapter != null)
				{
					_tblQrCodeTableAdapter.Connection = (OleDbConnection)revertConnections[_tblQrCodeTableAdapter];
					_tblQrCodeTableAdapter.Transaction = null;
				}
				if (_orderInfoTableAdapter != null)
				{
					_orderInfoTableAdapter.Connection = (OleDbConnection)revertConnections[_orderInfoTableAdapter];
					_orderInfoTableAdapter.Transaction = null;
				}
				if (0 < adaptersWithAcceptChangesDuringUpdate.Count)
				{
					DataAdapter[] adapters = new DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count - 1 + 1];
					adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
					foreach (DataAdapter adapter in adapters)
					{
						adapter.AcceptChangesDuringUpdate = true;
					}
				}
			}
			return result;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
