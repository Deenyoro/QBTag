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

namespace QBtag.MacolaReportsTableAdapters;

/// <summary>
/// TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class TableAdapterManager : Component
{
	/// <summary>
	/// Update Order Option
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	private OrderInfoTableAdapter _orderInfoTableAdapter;

	private PartsTableAdapter _partsTableAdapter;

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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
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

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if ((_orderInfoTableAdapter != null && _orderInfoTableAdapter.Connection != null) ? true : false)
			{
				return _orderInfoTableAdapter.Connection;
			}
			if ((_partsTableAdapter != null && _partsTableAdapter.Connection != null) ? true : false)
			{
				return _partsTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public int TableAdapterInstanceCount
	{
		get
		{
			int count = 0;
			checked
			{
				if (_orderInfoTableAdapter != null)
				{
					count++;
				}
				if (_partsTableAdapter != null)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateUpdatedRows(MacolaReports dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		int result = 0;
		checked
		{
			if (_partsTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.Parts.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
				if ((updatedRows != null && 0 < updatedRows.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(updatedRows);
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
			return result;
		}
	}

	/// <summary>
	/// Insert rows in top-down order.
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateInsertedRows(MacolaReports dataSet, List<DataRow> allAddedRows)
	{
		int result = 0;
		checked
		{
			if (_partsTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.Parts.Select(null, null, DataViewRowState.Added);
				if ((addedRows != null && 0 < addedRows.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(addedRows);
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
			return result;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateDeletedRows(MacolaReports dataSet, List<DataRow> allChangedRows)
	{
		int result = 0;
		checked
		{
			if (_orderInfoTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.OrderInfo.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows != null && 0 < deletedRows.Length) ? true : false)
				{
					result += _orderInfoTableAdapter.Update(deletedRows);
					allChangedRows.AddRange(deletedRows);
				}
			}
			if (_partsTableAdapter != null)
			{
				DataRow[] deletedRows2 = dataSet.Parts.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows2 != null && 0 < deletedRows2.Length) ? true : false)
				{
					result += _partsTableAdapter.Update(deletedRows2);
					allChangedRows.AddRange(deletedRows2);
				}
			}
			return result;
		}
	}

	/// <summary>
	/// Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int UpdateAll(MacolaReports dataSet)
	{
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if ((_orderInfoTableAdapter != null && !MatchTableAdapterConnection(_orderInfoTableAdapter.Connection)) ? true : false)
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if ((_partsTableAdapter != null && !MatchTableAdapterConnection(_partsTableAdapter.Connection)) ? true : false)
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
				if (_orderInfoTableAdapter != null)
				{
					_orderInfoTableAdapter.Connection = (OleDbConnection)revertConnections[_orderInfoTableAdapter];
					_orderInfoTableAdapter.Transaction = null;
				}
				if (_partsTableAdapter != null)
				{
					_partsTableAdapter.Connection = (OleDbConnection)revertConnections[_partsTableAdapter];
					_partsTableAdapter.Transaction = null;
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
