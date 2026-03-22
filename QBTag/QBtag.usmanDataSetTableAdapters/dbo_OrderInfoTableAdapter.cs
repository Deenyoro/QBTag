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
using QBtag.My;

namespace QBtag.usmanDataSetTableAdapters;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class dbo_OrderInfoTableAdapter : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("_adapter")]
	private OleDbDataAdapter __adapter;

	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private OleDbDataAdapter _adapter
	{
		[DebuggerNonUserCode]
		get
		{
			return __adapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__adapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal OleDbTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.DeleteCommand != null) ? true : false)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.InsertCommand != null) ? true : false)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.UpdateCommand != null) ? true : false)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
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
	public dbo_OrderInfoTableAdapter()
	{
		__ENCAddToList(this);
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		_adapter = new OleDbDataAdapter();
		DataTableMapping tableMapping = new DataTableMapping();
		tableMapping.SourceTable = "Table";
		tableMapping.DataSetTable = "dbo_OrderInfo";
		tableMapping.ColumnMappings.Add("OrderNumber", "OrderNumber");
		tableMapping.ColumnMappings.Add("Motor", "Motor");
		tableMapping.ColumnMappings.Add("Belt", "Belt");
		tableMapping.ColumnMappings.Add("PartType", "PartType");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `dbo_OrderInfo` WHERE ((`OrderNumber` = ?) AND ((? = 1 AND `Motor` IS NULL) OR (`Motor` = ?)) AND ((? = 1 AND `Belt` IS NULL) OR (`Belt` = ?)) AND ((? = 1 AND `PartType` IS NULL) OR (`PartType` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_OrderNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OrderNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Motor", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Motor", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Belt", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Belt", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PartType", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PartType", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `dbo_OrderInfo` (`OrderNumber`, `Motor`, `Belt`, `PartType`) VALUES (?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("OrderNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OrderNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Motor", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Belt", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PartType", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `dbo_OrderInfo` SET `OrderNumber` = ?, `Motor` = ?, `Belt` = ?, `PartType` = ? WHERE ((`OrderNumber` = ?) AND ((? = 1 AND `Motor` IS NULL) OR (`Motor` = ?)) AND ((? = 1 AND `Belt` IS NULL) OR (`Belt` = ?)) AND ((? = 1 AND `PartType` IS NULL) OR (`PartType` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("OrderNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OrderNumber", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Motor", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Belt", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PartType", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_OrderNumber", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OrderNumber", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Motor", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Motor", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Motor", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Belt", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Belt", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Belt", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PartType", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PartType", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PartType", DataRowVersion.Original, sourceColumnNullMapping: false, null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitConnection()
	{
		_connection = new OleDbConnection();
		_connection.ConnectionString = MySettings.Default.TomConnectionstring1;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT OrderNumber, Motor, Belt, PartType FROM dbo_OrderInfo";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Fill(usmanDataSet.dbo_OrderInfoDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual usmanDataSet.dbo_OrderInfoDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		usmanDataSet.dbo_OrderInfoDataTable dataTable = new usmanDataSet.dbo_OrderInfoDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(usmanDataSet.dbo_OrderInfoDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(usmanDataSet dataSet)
	{
		return Adapter.Update(dataSet, "dbo_OrderInfo");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return Adapter.Update(new DataRow[1] { dataRow });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return Adapter.Update(dataRows);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Delete(string Original_OrderNumber, string Original_Motor, string Original_Belt, string Original_PartType)
	{
		if (Original_OrderNumber == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_OrderNumber;
		}
		if (Original_Motor == null)
		{
			Adapter.DeleteCommand.Parameters[1].Value = 1;
			Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[1].Value = 0;
			Adapter.DeleteCommand.Parameters[2].Value = Original_Motor;
		}
		if (Original_Belt == null)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_Belt;
		}
		if (Original_PartType == null)
		{
			Adapter.DeleteCommand.Parameters[5].Value = 1;
			Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[5].Value = 0;
			Adapter.DeleteCommand.Parameters[6].Value = Original_PartType;
		}
		ConnectionState previousConnectionState = Adapter.DeleteCommand.Connection.State;
		if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			return Adapter.DeleteCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.DeleteCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Insert(string OrderNumber, string Motor, string Belt, string PartType)
	{
		if (OrderNumber == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = OrderNumber;
		}
		if (Motor == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = Motor;
		}
		if (Belt == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = Belt;
		}
		if (PartType == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = PartType;
		}
		ConnectionState previousConnectionState = Adapter.InsertCommand.Connection.State;
		if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			return Adapter.InsertCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.InsertCommand.Connection.Close();
			}
		}
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(string OrderNumber, string Motor, string Belt, string PartType, string Original_OrderNumber, string Original_Motor, string Original_Belt, string Original_PartType)
	{
		if (OrderNumber == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = OrderNumber;
		}
		if (Motor == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = Motor;
		}
		if (Belt == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = Belt;
		}
		if (PartType == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = PartType;
		}
		if (Original_OrderNumber == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = Original_OrderNumber;
		}
		if (Original_Motor == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = 1;
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = 0;
			Adapter.UpdateCommand.Parameters[6].Value = Original_Motor;
		}
		if (Original_Belt == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = 1;
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = 0;
			Adapter.UpdateCommand.Parameters[8].Value = Original_Belt;
		}
		if (Original_PartType == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = 1;
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = 0;
			Adapter.UpdateCommand.Parameters[10].Value = Original_PartType;
		}
		ConnectionState previousConnectionState = Adapter.UpdateCommand.Connection.State;
		if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			return Adapter.UpdateCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.UpdateCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string Motor, string Belt, string PartType, string Original_OrderNumber, string Original_Motor, string Original_Belt, string Original_PartType)
	{
		return Update(Original_OrderNumber, Motor, Belt, PartType, Original_OrderNumber, Original_Motor, Original_Belt, Original_PartType);
	}
}
