using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace QBtag;

[Serializable]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlRoot("MacolaReports")]
public class MacolaReports : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void OrderInfoRowChangeEventHandler(object sender, OrderInfoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void PartsRowChangeEventHandler(object sender, PartsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ViewOrderWithQRCodeRowChangeEventHandler(object sender, ViewOrderWithQRCodeRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class OrderInfoDataTable : TypedTableBase<OrderInfoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnOrderNumber;

		private DataColumn columnMotor;

		private DataColumn columnBelt;

		private DataColumn columnPartType;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OrderNumberColumn => columnOrderNumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MotorColumn => columnMotor;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BeltColumn => columnBelt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PartTypeColumn => columnPartType;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public OrderInfoRow this[int index] => (OrderInfoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event OrderInfoRowChangeEventHandler OrderInfoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event OrderInfoRowChangeEventHandler OrderInfoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event OrderInfoRowChangeEventHandler OrderInfoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event OrderInfoRowChangeEventHandler OrderInfoRowDeleted;

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
		public OrderInfoDataTable()
		{
			__ENCAddToList(this);
			TableName = "OrderInfo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal OrderInfoDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected OrderInfoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddOrderInfoRow(OrderInfoRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public OrderInfoRow AddOrderInfoRow(string OrderNumber, string Motor, string Belt, string PartType)
		{
			OrderInfoRow rowOrderInfoRow = (OrderInfoRow)NewRow();
			object[] columnValuesArray = new object[4] { OrderNumber, Motor, Belt, PartType };
			rowOrderInfoRow.ItemArray = columnValuesArray;
			Rows.Add(rowOrderInfoRow);
			return rowOrderInfoRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			OrderInfoDataTable cln = (OrderInfoDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new OrderInfoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnOrderNumber = base.Columns["OrderNumber"];
			columnMotor = base.Columns["Motor"];
			columnBelt = base.Columns["Belt"];
			columnPartType = base.Columns["PartType"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnOrderNumber = new DataColumn("OrderNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOrderNumber);
			columnMotor = new DataColumn("Motor", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMotor);
			columnBelt = new DataColumn("Belt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBelt);
			columnPartType = new DataColumn("PartType", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPartType);
			columnOrderNumber.MaxLength = 50;
			columnMotor.MaxLength = 50;
			columnBelt.MaxLength = 50;
			columnPartType.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public OrderInfoRow NewOrderInfoRow()
		{
			return (OrderInfoRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new OrderInfoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(OrderInfoRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (OrderInfoRowChanged != null)
			{
				OrderInfoRowChanged?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (OrderInfoRowChanging != null)
			{
				OrderInfoRowChanging?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (OrderInfoRowDeleted != null)
			{
				OrderInfoRowDeleted?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (OrderInfoRowDeleting != null)
			{
				OrderInfoRowDeleting?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveOrderInfoRow(OrderInfoRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			MacolaReports ds = new MacolaReports();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			any1.MinOccurs = num;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			any2.MinOccurs = num;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "OrderInfoDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						schema.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while ((s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte()) ? true : false)
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class PartsDataTable : TypedTableBase<PartsRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnPartType;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PartTypeColumn => columnPartType;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public PartsRow this[int index] => (PartsRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event PartsRowChangeEventHandler PartsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event PartsRowChangeEventHandler PartsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event PartsRowChangeEventHandler PartsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event PartsRowChangeEventHandler PartsRowDeleted;

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
		public PartsDataTable()
		{
			__ENCAddToList(this);
			TableName = "Parts";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal PartsDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected PartsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddPartsRow(PartsRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public PartsRow AddPartsRow(string PartType)
		{
			PartsRow rowPartsRow = (PartsRow)NewRow();
			object[] columnValuesArray = new object[1] { PartType };
			rowPartsRow.ItemArray = columnValuesArray;
			Rows.Add(rowPartsRow);
			return rowPartsRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			PartsDataTable cln = (PartsDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new PartsDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnPartType = base.Columns["PartType"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnPartType = new DataColumn("PartType", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPartType);
			columnPartType.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public PartsRow NewPartsRow()
		{
			return (PartsRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new PartsRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(PartsRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (PartsRowChanged != null)
			{
				PartsRowChanged?.Invoke(this, new PartsRowChangeEvent((PartsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (PartsRowChanging != null)
			{
				PartsRowChanging?.Invoke(this, new PartsRowChangeEvent((PartsRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (PartsRowDeleted != null)
			{
				PartsRowDeleted?.Invoke(this, new PartsRowChangeEvent((PartsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (PartsRowDeleting != null)
			{
				PartsRowDeleting?.Invoke(this, new PartsRowChangeEvent((PartsRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovePartsRow(PartsRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			MacolaReports ds = new MacolaReports();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			any1.MinOccurs = num;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			any2.MinOccurs = num;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "PartsDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						schema.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while ((s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte()) ? true : false)
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ViewOrderWithQRCodeDataTable : TypedTableBase<ViewOrderWithQRCodeRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnOrderNumber;

		private DataColumn columnMotor;

		private DataColumn columnBelt;

		private DataColumn columnPartType;

		private DataColumn columnLink;

		private DataColumn columnQrPhoto;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OrderNumberColumn => columnOrderNumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MotorColumn => columnMotor;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BeltColumn => columnBelt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PartTypeColumn => columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LinkColumn => columnLink;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QrPhotoColumn => columnQrPhoto;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ViewOrderWithQRCodeRow this[int index] => (ViewOrderWithQRCodeRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event ViewOrderWithQRCodeRowChangeEventHandler ViewOrderWithQRCodeRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event ViewOrderWithQRCodeRowChangeEventHandler ViewOrderWithQRCodeRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event ViewOrderWithQRCodeRowChangeEventHandler ViewOrderWithQRCodeRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event ViewOrderWithQRCodeRowChangeEventHandler ViewOrderWithQRCodeRowDeleted;

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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ViewOrderWithQRCodeDataTable()
		{
			__ENCAddToList(this);
			TableName = "ViewOrderWithQRCode";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ViewOrderWithQRCodeDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected ViewOrderWithQRCodeDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddViewOrderWithQRCodeRow(ViewOrderWithQRCodeRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ViewOrderWithQRCodeRow AddViewOrderWithQRCodeRow(string OrderNumber, string Motor, string Belt, string PartType, string Link, byte[] QrPhoto)
		{
			ViewOrderWithQRCodeRow rowViewOrderWithQRCodeRow = (ViewOrderWithQRCodeRow)NewRow();
			object[] columnValuesArray = new object[6] { OrderNumber, Motor, Belt, PartType, Link, QrPhoto };
			rowViewOrderWithQRCodeRow.ItemArray = columnValuesArray;
			Rows.Add(rowViewOrderWithQRCodeRow);
			return rowViewOrderWithQRCodeRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			ViewOrderWithQRCodeDataTable cln = (ViewOrderWithQRCodeDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ViewOrderWithQRCodeDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnOrderNumber = base.Columns["OrderNumber"];
			columnMotor = base.Columns["Motor"];
			columnBelt = base.Columns["Belt"];
			columnPartType = base.Columns["PartType"];
			columnLink = base.Columns["Link"];
			columnQrPhoto = base.Columns["QrPhoto"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnOrderNumber = new DataColumn("OrderNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOrderNumber);
			columnMotor = new DataColumn("Motor", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMotor);
			columnBelt = new DataColumn("Belt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBelt);
			columnPartType = new DataColumn("PartType", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPartType);
			columnLink = new DataColumn("Link", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLink);
			columnQrPhoto = new DataColumn("QrPhoto", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnQrPhoto);
			columnOrderNumber.MaxLength = 50;
			columnMotor.MaxLength = 50;
			columnBelt.MaxLength = 50;
			columnPartType.MaxLength = 50;
			columnLink.MaxLength = 30;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ViewOrderWithQRCodeRow NewViewOrderWithQRCodeRow()
		{
			return (ViewOrderWithQRCodeRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ViewOrderWithQRCodeRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ViewOrderWithQRCodeRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ViewOrderWithQRCodeRowChanged != null)
			{
				ViewOrderWithQRCodeRowChanged?.Invoke(this, new ViewOrderWithQRCodeRowChangeEvent((ViewOrderWithQRCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ViewOrderWithQRCodeRowChanging != null)
			{
				ViewOrderWithQRCodeRowChanging?.Invoke(this, new ViewOrderWithQRCodeRowChangeEvent((ViewOrderWithQRCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ViewOrderWithQRCodeRowDeleted != null)
			{
				ViewOrderWithQRCodeRowDeleted?.Invoke(this, new ViewOrderWithQRCodeRowChangeEvent((ViewOrderWithQRCodeRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ViewOrderWithQRCodeRowDeleting != null)
			{
				ViewOrderWithQRCodeRowDeleting?.Invoke(this, new ViewOrderWithQRCodeRowChangeEvent((ViewOrderWithQRCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveViewOrderWithQRCodeRow(ViewOrderWithQRCodeRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			MacolaReports ds = new MacolaReports();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			any1.MinOccurs = num;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			any2.MinOccurs = num;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "ViewOrderWithQRCodeDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						schema.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while ((s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte()) ? true : false)
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	public class OrderInfoRow : DataRow
	{
		private OrderInfoDataTable tableOrderInfo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string OrderNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableOrderInfo.OrderNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'OrderNumber' in table 'OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tableOrderInfo.OrderNumberColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Motor
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableOrderInfo.MotorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Motor' in table 'OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tableOrderInfo.MotorColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Belt
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableOrderInfo.BeltColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Belt' in table 'OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tableOrderInfo.BeltColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PartType
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableOrderInfo.PartTypeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'PartType' in table 'OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tableOrderInfo.PartTypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal OrderInfoRow(DataRowBuilder rb)
			: base(rb)
		{
			tableOrderInfo = (OrderInfoDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOrderNumberNull()
		{
			return IsNull(tableOrderInfo.OrderNumberColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetOrderNumberNull()
		{
			this[tableOrderInfo.OrderNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMotorNull()
		{
			return IsNull(tableOrderInfo.MotorColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMotorNull()
		{
			this[tableOrderInfo.MotorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBeltNull()
		{
			return IsNull(tableOrderInfo.BeltColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBeltNull()
		{
			this[tableOrderInfo.BeltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPartTypeNull()
		{
			return IsNull(tableOrderInfo.PartTypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPartTypeNull()
		{
			this[tableOrderInfo.PartTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class PartsRow : DataRow
	{
		private PartsDataTable tableParts;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PartType
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableParts.PartTypeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'PartType' in table 'Parts' is DBNull.", e);
				}
			}
			set
			{
				this[tableParts.PartTypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal PartsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableParts = (PartsDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPartTypeNull()
		{
			return IsNull(tableParts.PartTypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPartTypeNull()
		{
			this[tableParts.PartTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class ViewOrderWithQRCodeRow : DataRow
	{
		private ViewOrderWithQRCodeDataTable tableViewOrderWithQRCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string OrderNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableViewOrderWithQRCode.OrderNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'OrderNumber' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.OrderNumberColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Motor
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableViewOrderWithQRCode.MotorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Motor' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.MotorColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Belt
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableViewOrderWithQRCode.BeltColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Belt' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.BeltColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PartType
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableViewOrderWithQRCode.PartTypeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'PartType' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.PartTypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Link
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableViewOrderWithQRCode.LinkColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Link' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.LinkColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public byte[] QrPhoto
		{
			get
			{
				try
				{
					return (byte[])this[tableViewOrderWithQRCode.QrPhotoColumn];
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'QrPhoto' in table 'ViewOrderWithQRCode' is DBNull.", e);
				}
			}
			set
			{
				this[tableViewOrderWithQRCode.QrPhotoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ViewOrderWithQRCodeRow(DataRowBuilder rb)
			: base(rb)
		{
			tableViewOrderWithQRCode = (ViewOrderWithQRCodeDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOrderNumberNull()
		{
			return IsNull(tableViewOrderWithQRCode.OrderNumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOrderNumberNull()
		{
			this[tableViewOrderWithQRCode.OrderNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMotorNull()
		{
			return IsNull(tableViewOrderWithQRCode.MotorColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMotorNull()
		{
			this[tableViewOrderWithQRCode.MotorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBeltNull()
		{
			return IsNull(tableViewOrderWithQRCode.BeltColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBeltNull()
		{
			this[tableViewOrderWithQRCode.BeltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPartTypeNull()
		{
			return IsNull(tableViewOrderWithQRCode.PartTypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPartTypeNull()
		{
			this[tableViewOrderWithQRCode.PartTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLinkNull()
		{
			return IsNull(tableViewOrderWithQRCode.LinkColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLinkNull()
		{
			this[tableViewOrderWithQRCode.LinkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQrPhotoNull()
		{
			return IsNull(tableViewOrderWithQRCode.QrPhotoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQrPhotoNull()
		{
			this[tableViewOrderWithQRCode.QrPhotoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class OrderInfoRowChangeEvent : EventArgs
	{
		private OrderInfoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public OrderInfoRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public OrderInfoRowChangeEvent(OrderInfoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class PartsRowChangeEvent : EventArgs
	{
		private PartsRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public PartsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public PartsRowChangeEvent(PartsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ViewOrderWithQRCodeRowChangeEvent : EventArgs
	{
		private ViewOrderWithQRCodeRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ViewOrderWithQRCodeRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ViewOrderWithQRCodeRowChangeEvent(ViewOrderWithQRCodeRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private OrderInfoDataTable tableOrderInfo;

	private PartsDataTable tableParts;

	private ViewOrderWithQRCodeDataTable tableViewOrderWithQRCode;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public OrderInfoDataTable OrderInfo => tableOrderInfo;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public PartsDataTable Parts => tableParts;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public ViewOrderWithQRCodeDataTable ViewOrderWithQRCode => tableViewOrderWithQRCode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DebuggerNonUserCode]
	[Browsable(true)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public MacolaReports()
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler;
		base.Relations.CollectionChanged += schemaChangedHandler;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected MacolaReports(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler schemaChangedHandler1 = SchemaChanged;
			Tables.CollectionChanged += schemaChangedHandler1;
			Relations.CollectionChanged += schemaChangedHandler1;
			return;
		}
		string strSchema = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet ds = new DataSet();
			ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
			if (ds.Tables["OrderInfo"] != null)
			{
				base.Tables.Add(new OrderInfoDataTable(ds.Tables["OrderInfo"]));
			}
			if (ds.Tables["Parts"] != null)
			{
				base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
			}
			if (ds.Tables["ViewOrderWithQRCode"] != null)
			{
				base.Tables.Add(new ViewOrderWithQRCodeDataTable(ds.Tables["ViewOrderWithQRCode"]));
			}
			DataSetName = ds.DataSetName;
			Prefix = ds.Prefix;
			Namespace = ds.Namespace;
			Locale = ds.Locale;
			CaseSensitive = ds.CaseSensitive;
			EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler schemaChangedHandler2 = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler2;
		Relations.CollectionChanged += schemaChangedHandler2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		MacolaReports cln = (MacolaReports)base.Clone();
		cln.InitVars();
		cln.SchemaSerializationMode = SchemaSerializationMode;
		return cln;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			if (ds.Tables["OrderInfo"] != null)
			{
				base.Tables.Add(new OrderInfoDataTable(ds.Tables["OrderInfo"]));
			}
			if (ds.Tables["Parts"] != null)
			{
				base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
			}
			if (ds.Tables["ViewOrderWithQRCode"] != null)
			{
				base.Tables.Add(new ViewOrderWithQRCodeDataTable(ds.Tables["ViewOrderWithQRCode"]));
			}
			DataSetName = ds.DataSetName;
			Prefix = ds.Prefix;
			Namespace = ds.Namespace;
			Locale = ds.Locale;
			CaseSensitive = ds.CaseSensitive;
			EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream stream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(stream, null));
		stream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(stream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableOrderInfo = (OrderInfoDataTable)base.Tables["OrderInfo"];
		if (initTable && tableOrderInfo != null)
		{
			tableOrderInfo.InitVars();
		}
		tableParts = (PartsDataTable)base.Tables["Parts"];
		if (initTable && tableParts != null)
		{
			tableParts.InitVars();
		}
		tableViewOrderWithQRCode = (ViewOrderWithQRCodeDataTable)base.Tables["ViewOrderWithQRCode"];
		if (initTable && tableViewOrderWithQRCode != null)
		{
			tableViewOrderWithQRCode.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		DataSetName = "MacolaReports";
		Prefix = "";
		Namespace = "http://tempuri.org/MacolaReports.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableOrderInfo = new OrderInfoDataTable();
		base.Tables.Add(tableOrderInfo);
		tableParts = new PartsDataTable();
		base.Tables.Add(tableParts);
		tableViewOrderWithQRCode = new ViewOrderWithQRCodeDataTable();
		base.Tables.Add(tableViewOrderWithQRCode);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeOrderInfo()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeParts()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeViewOrderWithQRCode()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		MacolaReports ds = new MacolaReports();
		XmlSchemaComplexType type = new XmlSchemaComplexType();
		XmlSchemaSequence sequence = new XmlSchemaSequence();
		XmlSchemaAny any = new XmlSchemaAny();
		any.Namespace = ds.Namespace;
		sequence.Items.Add(any);
		type.Particle = sequence;
		XmlSchema dsSchema = ds.GetSchemaSerializable();
		if (xs.Contains(dsSchema.TargetNamespace))
		{
			MemoryStream s1 = new MemoryStream();
			MemoryStream s2 = new MemoryStream();
			try
			{
				XmlSchema schema = null;
				dsSchema.Write(s1);
				IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
				while (schemas.MoveNext())
				{
					schema = (XmlSchema)schemas.Current;
					s2.SetLength(0L);
					schema.Write(s2);
					if (s1.Length == s2.Length)
					{
						s1.Position = 0L;
						s2.Position = 0L;
						while ((s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte()) ? true : false)
						{
						}
						if (s1.Position == s1.Length)
						{
							return type;
						}
					}
				}
			}
			finally
			{
				s1?.Close();
				s2?.Close();
			}
		}
		xs.Add(dsSchema);
		return type;
	}
}
