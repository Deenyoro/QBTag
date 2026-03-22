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

/// <summary>
/// Represents a strongly typed in-memory cache of data.
/// </summary>
[Serializable]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
[ToolboxItem(true)]
[XmlRoot("usmanDataSet")]
public class usmanDataSet : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void dbo_OrderInfoRowChangeEventHandler(object sender, dbo_OrderInfoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void PartsRowChangeEventHandler(object sender, PartsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void SalesOrderLineRowChangeEventHandler(object sender, SalesOrderLineRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void tblQrCodeRowChangeEventHandler(object sender, tblQrCodeRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void OrderInfoRowChangeEventHandler(object sender, OrderInfoRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class dbo_OrderInfoDataTable : TypedTableBase<dbo_OrderInfoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnOrderNumber;

		private DataColumn columnMotor;

		private DataColumn columnBelt;

		private DataColumn columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OrderNumberColumn => columnOrderNumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MotorColumn => columnMotor;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BeltColumn => columnBelt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PartTypeColumn => columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dbo_OrderInfoRow this[int index] => (dbo_OrderInfoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event dbo_OrderInfoRowChangeEventHandler dbo_OrderInfoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event dbo_OrderInfoRowChangeEventHandler dbo_OrderInfoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event dbo_OrderInfoRowChangeEventHandler dbo_OrderInfoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event dbo_OrderInfoRowChangeEventHandler dbo_OrderInfoRowDeleted;

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
		public dbo_OrderInfoDataTable()
		{
			__ENCAddToList(this);
			TableName = "dbo_OrderInfo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal dbo_OrderInfoDataTable(DataTable table)
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
		protected dbo_OrderInfoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Adddbo_OrderInfoRow(dbo_OrderInfoRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dbo_OrderInfoRow Adddbo_OrderInfoRow(string OrderNumber, string Motor, string Belt, string PartType)
		{
			dbo_OrderInfoRow rowdbo_OrderInfoRow = (dbo_OrderInfoRow)NewRow();
			object[] columnValuesArray = new object[4] { OrderNumber, Motor, Belt, PartType };
			rowdbo_OrderInfoRow.ItemArray = columnValuesArray;
			Rows.Add(rowdbo_OrderInfoRow);
			return rowdbo_OrderInfoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dbo_OrderInfoRow FindByOrderNumber(string OrderNumber)
		{
			return (dbo_OrderInfoRow)Rows.Find(new object[1] { OrderNumber });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			dbo_OrderInfoDataTable cln = (dbo_OrderInfoDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new dbo_OrderInfoDataTable();
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
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnOrderNumber }, isPrimaryKey: true));
			columnOrderNumber.AllowDBNull = false;
			columnOrderNumber.Unique = true;
			columnOrderNumber.MaxLength = 50;
			columnMotor.MaxLength = 50;
			columnBelt.MaxLength = 50;
			columnPartType.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public dbo_OrderInfoRow Newdbo_OrderInfoRow()
		{
			return (dbo_OrderInfoRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new dbo_OrderInfoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(dbo_OrderInfoRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (dbo_OrderInfoRowChanged != null)
			{
				dbo_OrderInfoRowChanged?.Invoke(this, new dbo_OrderInfoRowChangeEvent((dbo_OrderInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (dbo_OrderInfoRowChanging != null)
			{
				dbo_OrderInfoRowChanging?.Invoke(this, new dbo_OrderInfoRowChangeEvent((dbo_OrderInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (dbo_OrderInfoRowDeleted != null)
			{
				dbo_OrderInfoRowDeleted?.Invoke(this, new dbo_OrderInfoRowChangeEvent((dbo_OrderInfoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (dbo_OrderInfoRowDeleting != null)
			{
				dbo_OrderInfoRowDeleting?.Invoke(this, new dbo_OrderInfoRowChangeEvent((dbo_OrderInfoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Removedbo_OrderInfoRow(dbo_OrderInfoRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			usmanDataSet ds = new usmanDataSet();
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
			attribute2.FixedValue = "dbo_OrderInfoDataTable";
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
	public class PartsDataTable : TypedTableBase<PartsRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PartTypeColumn => columnPartType;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public PartsRow AddPartsRow(string PartType)
		{
			PartsRow rowPartsRow = (PartsRow)NewRow();
			object[] columnValuesArray = new object[1] { PartType };
			rowPartsRow.ItemArray = columnValuesArray;
			Rows.Add(rowPartsRow);
			return rowPartsRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			PartsDataTable cln = (PartsDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new PartsDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (PartsRowDeleting != null)
			{
				PartsRowDeleting?.Invoke(this, new PartsRowChangeEvent((PartsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovePartsRow(PartsRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			usmanDataSet ds = new usmanDataSet();
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

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class SalesOrderLineDataTable : TypedTableBase<SalesOrderLineRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnTxnID;

		private DataColumn columnTimeCreated;

		private DataColumn columnTimeModified;

		private DataColumn columnEditSequence;

		private DataColumn columnTxnNumber;

		private DataColumn columnCustomerRefListID;

		private DataColumn columnCustomerRefFullName;

		private DataColumn columnClassRefListID;

		private DataColumn columnClassRefFullName;

		private DataColumn columnTemplateRefListID;

		private DataColumn columnTemplateRefFullName;

		private DataColumn columnTxnDate;

		private DataColumn columnTxnDateMacro;

		private DataColumn columnRefNumber;

		private DataColumn columnBillAddressAddr1;

		private DataColumn columnBillAddressAddr2;

		private DataColumn columnBillAddressAddr3;

		private DataColumn columnBillAddressAddr4;

		private DataColumn columnBillAddressAddr5;

		private DataColumn columnBillAddressCity;

		private DataColumn columnBillAddressState;

		private DataColumn columnBillAddressProvince;

		private DataColumn columnBillAddressCounty;

		private DataColumn columnBillAddressPostalCode;

		private DataColumn columnBillAddressCountry;

		private DataColumn columnBillAddressNote;

		private DataColumn columnBillAddressBlockAddr1;

		private DataColumn columnBillAddressBlockAddr2;

		private DataColumn columnBillAddressBlockAddr3;

		private DataColumn columnBillAddressBlockAddr4;

		private DataColumn columnBillAddressBlockAddr5;

		private DataColumn columnShipAddressAddr1;

		private DataColumn columnShipAddressAddr2;

		private DataColumn columnShipAddressAddr3;

		private DataColumn columnShipAddressAddr4;

		private DataColumn columnShipAddressAddr5;

		private DataColumn columnShipAddressCity;

		private DataColumn columnShipAddressState;

		private DataColumn columnShipAddressProvince;

		private DataColumn columnShipAddressCounty;

		private DataColumn columnShipAddressPostalCode;

		private DataColumn columnShipAddressCountry;

		private DataColumn columnShipAddressNote;

		private DataColumn columnShipAddressBlockAddr1;

		private DataColumn columnShipAddressBlockAddr2;

		private DataColumn columnShipAddressBlockAddr3;

		private DataColumn columnShipAddressBlockAddr4;

		private DataColumn columnShipAddressBlockAddr5;

		private DataColumn columnPONumber;

		private DataColumn columnTermsRefListID;

		private DataColumn columnTermsRefFullName;

		private DataColumn columnDueDate;

		private DataColumn columnSalesRepRefListID;

		private DataColumn columnSalesRepRefFullName;

		private DataColumn columnFOB;

		private DataColumn columnShipDate;

		private DataColumn columnShipMethodRefListID;

		private DataColumn columnShipMethodRefFullName;

		private DataColumn columnSubtotal;

		private DataColumn columnItemSalesTaxRefListID;

		private DataColumn columnItemSalesTaxRefFullName;

		private DataColumn columnSalesTaxPercentage;

		private DataColumn columnSalesTaxTotal;

		private DataColumn columnTotalAmount;

		private DataColumn columnIsManuallyClosed;

		private DataColumn columnIsFullyInvoiced;

		private DataColumn columnMemo;

		private DataColumn columnCustomerMsgRefListID;

		private DataColumn columnCustomerMsgRefFullName;

		private DataColumn columnIsToBePrinted;

		private DataColumn columnIsToBeEmailed;

		private DataColumn columnIsTaxIncluded;

		private DataColumn columnCustomerSalesTaxCodeRefListID;

		private DataColumn columnCustomerSalesTaxCodeRefFullName;

		private DataColumn columnCustomerTaxCodeRefListID;

		private DataColumn columnCustomFieldOther;

		private DataColumn columnSalesOrderLineSeqNo;

		private DataColumn columnSalesOrderLineGroupTxnLineID;

		private DataColumn columnSalesOrderLineGroupItemGroupRefListID;

		private DataColumn columnSalesOrderLineGroupItemGroupRefFullName;

		private DataColumn columnSalesOrderLineGroupDesc;

		private DataColumn columnSalesOrderLineGroupQuantity;

		private DataColumn columnSalesOrderLineGroupUnitOfMeasure;

		private DataColumn columnSalesOrderLineGroupOverrideUOMSetRefListID;

		private DataColumn columnSalesOrderLineGroupOverrideUOMSetRefFullName;

		private DataColumn columnSalesOrderLineGroupIsPrintItemsInGroup;

		private DataColumn columnSalesOrderLineGroupTotalAmount;

		private DataColumn columnSalesOrderLineGroupSeqNo;

		private DataColumn columnSalesOrderLineTxnLineID;

		private DataColumn columnSalesOrderLineItemRefListID;

		private DataColumn columnSalesOrderLineItemRefFullName;

		private DataColumn columnSalesOrderLineDesc;

		private DataColumn columnSalesOrderLineQuantity;

		private DataColumn columnSalesOrderLineUnitOfMeasure;

		private DataColumn columnSalesOrderLineOverrideUOMSetRefListID;

		private DataColumn columnSalesOrderLineOverrideUOMSetRefFullName;

		private DataColumn columnSalesOrderLineRate;

		private DataColumn columnSalesOrderLineRatePercent;

		private DataColumn columnSalesOrderLinePriceLevelRefListID;

		private DataColumn columnSalesOrderLinePriceLevelRefFullName;

		private DataColumn columnSalesOrderLineClassRefListID;

		private DataColumn columnSalesOrderLineClassRefFullName;

		private DataColumn columnSalesOrderLineAmount;

		private DataColumn columnSalesOrderInventorySiteRefListID;

		private DataColumn columnSalesOrderInventorySiteRefFullName;

		private DataColumn columnSalesOrderLineSerialNumber;

		private DataColumn columnSalesOrderLineLotNumber;

		private DataColumn columnSalesOrderLineTaxAmount;

		private DataColumn columnSalesOrderLineSalesTaxCodeRefListID;

		private DataColumn columnSalesOrderLineSalesTaxCodeRefFullName;

		private DataColumn columnSalesOrderLineTaxCodeRefListID;

		private DataColumn columnSalesOrderLineTaxCodeRefFullName;

		private DataColumn columnSalesOrderLineInvoiced;

		private DataColumn columnSalesOrderLineIsManuallyClosed;

		private DataColumn columnCustomFieldSalesOrderLineOther1;

		private DataColumn columnCustomFieldSalesOrderLineOther2;

		private DataColumn columnTax1Total;

		private DataColumn columnTax2Total;

		private DataColumn columnExchangeRate;

		private DataColumn columnAmountIncludesVAT;

		private DataColumn columnFQSaveToCache;

		private DataColumn columnFQPrimaryKey;

		private DataColumn columnFQTxnLinkKey;

		private DataColumn columnCustomFieldSalesOrderLineCycleCount;

		private DataColumn columnCustomFieldSalesOrderLineGroupCycleCount;

		private DataColumn columnCustomFieldSalesOrderLineGroupLineCycleCount;

		private DataColumn columnCustomFieldCollect;

		private DataColumn columnCustomFieldPPDCOL;

		private DataColumn columnCustomFieldRep;

		private DataColumn columnCustomFieldShipDate;

		private DataColumn columnCustomFieldShipVia;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TxnIDColumn => columnTxnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TimeCreatedColumn => columnTimeCreated;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TimeModifiedColumn => columnTimeModified;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EditSequenceColumn => columnEditSequence;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TxnNumberColumn => columnTxnNumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomerRefListIDColumn => columnCustomerRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomerRefFullNameColumn => columnCustomerRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ClassRefListIDColumn => columnClassRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ClassRefFullNameColumn => columnClassRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TemplateRefListIDColumn => columnTemplateRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TemplateRefFullNameColumn => columnTemplateRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TxnDateColumn => columnTxnDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TxnDateMacroColumn => columnTxnDateMacro;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RefNumberColumn => columnRefNumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressAddr1Column => columnBillAddressAddr1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressAddr2Column => columnBillAddressAddr2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressAddr3Column => columnBillAddressAddr3;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressAddr4Column => columnBillAddressAddr4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressAddr5Column => columnBillAddressAddr5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressCityColumn => columnBillAddressCity;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressStateColumn => columnBillAddressState;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressProvinceColumn => columnBillAddressProvince;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressCountyColumn => columnBillAddressCounty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressPostalCodeColumn => columnBillAddressPostalCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressCountryColumn => columnBillAddressCountry;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressNoteColumn => columnBillAddressNote;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressBlockAddr1Column => columnBillAddressBlockAddr1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressBlockAddr2Column => columnBillAddressBlockAddr2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressBlockAddr3Column => columnBillAddressBlockAddr3;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BillAddressBlockAddr4Column => columnBillAddressBlockAddr4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BillAddressBlockAddr5Column => columnBillAddressBlockAddr5;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressAddr1Column => columnShipAddressAddr1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressAddr2Column => columnShipAddressAddr2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressAddr3Column => columnShipAddressAddr3;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressAddr4Column => columnShipAddressAddr4;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressAddr5Column => columnShipAddressAddr5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressCityColumn => columnShipAddressCity;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressStateColumn => columnShipAddressState;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressProvinceColumn => columnShipAddressProvince;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressCountyColumn => columnShipAddressCounty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressPostalCodeColumn => columnShipAddressPostalCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressCountryColumn => columnShipAddressCountry;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressNoteColumn => columnShipAddressNote;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressBlockAddr1Column => columnShipAddressBlockAddr1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressBlockAddr2Column => columnShipAddressBlockAddr2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipAddressBlockAddr3Column => columnShipAddressBlockAddr3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressBlockAddr4Column => columnShipAddressBlockAddr4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipAddressBlockAddr5Column => columnShipAddressBlockAddr5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PONumberColumn => columnPONumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TermsRefListIDColumn => columnTermsRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TermsRefFullNameColumn => columnTermsRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DueDateColumn => columnDueDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesRepRefListIDColumn => columnSalesRepRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesRepRefFullNameColumn => columnSalesRepRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOBColumn => columnFOB;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ShipDateColumn => columnShipDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipMethodRefListIDColumn => columnShipMethodRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ShipMethodRefFullNameColumn => columnShipMethodRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SubtotalColumn => columnSubtotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ItemSalesTaxRefListIDColumn => columnItemSalesTaxRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ItemSalesTaxRefFullNameColumn => columnItemSalesTaxRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesTaxPercentageColumn => columnSalesTaxPercentage;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesTaxTotalColumn => columnSalesTaxTotal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalAmountColumn => columnTotalAmount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsManuallyClosedColumn => columnIsManuallyClosed;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsFullyInvoicedColumn => columnIsFullyInvoiced;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MemoColumn => columnMemo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomerMsgRefListIDColumn => columnCustomerMsgRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomerMsgRefFullNameColumn => columnCustomerMsgRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsToBePrintedColumn => columnIsToBePrinted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsToBeEmailedColumn => columnIsToBeEmailed;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IsTaxIncludedColumn => columnIsTaxIncluded;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomerSalesTaxCodeRefListIDColumn => columnCustomerSalesTaxCodeRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomerSalesTaxCodeRefFullNameColumn => columnCustomerSalesTaxCodeRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomerTaxCodeRefListIDColumn => columnCustomerTaxCodeRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldOtherColumn => columnCustomFieldOther;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineSeqNoColumn => columnSalesOrderLineSeqNo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupTxnLineIDColumn => columnSalesOrderLineGroupTxnLineID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupItemGroupRefListIDColumn => columnSalesOrderLineGroupItemGroupRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineGroupItemGroupRefFullNameColumn => columnSalesOrderLineGroupItemGroupRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineGroupDescColumn => columnSalesOrderLineGroupDesc;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupQuantityColumn => columnSalesOrderLineGroupQuantity;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineGroupUnitOfMeasureColumn => columnSalesOrderLineGroupUnitOfMeasure;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineGroupOverrideUOMSetRefListIDColumn => columnSalesOrderLineGroupOverrideUOMSetRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupOverrideUOMSetRefFullNameColumn => columnSalesOrderLineGroupOverrideUOMSetRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineGroupIsPrintItemsInGroupColumn => columnSalesOrderLineGroupIsPrintItemsInGroup;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupTotalAmountColumn => columnSalesOrderLineGroupTotalAmount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineGroupSeqNoColumn => columnSalesOrderLineGroupSeqNo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineTxnLineIDColumn => columnSalesOrderLineTxnLineID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineItemRefListIDColumn => columnSalesOrderLineItemRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineItemRefFullNameColumn => columnSalesOrderLineItemRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineDescColumn => columnSalesOrderLineDesc;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineQuantityColumn => columnSalesOrderLineQuantity;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineUnitOfMeasureColumn => columnSalesOrderLineUnitOfMeasure;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineOverrideUOMSetRefListIDColumn => columnSalesOrderLineOverrideUOMSetRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineOverrideUOMSetRefFullNameColumn => columnSalesOrderLineOverrideUOMSetRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineRateColumn => columnSalesOrderLineRate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineRatePercentColumn => columnSalesOrderLineRatePercent;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLinePriceLevelRefListIDColumn => columnSalesOrderLinePriceLevelRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLinePriceLevelRefFullNameColumn => columnSalesOrderLinePriceLevelRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineClassRefListIDColumn => columnSalesOrderLineClassRefListID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineClassRefFullNameColumn => columnSalesOrderLineClassRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineAmountColumn => columnSalesOrderLineAmount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderInventorySiteRefListIDColumn => columnSalesOrderInventorySiteRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderInventorySiteRefFullNameColumn => columnSalesOrderInventorySiteRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineSerialNumberColumn => columnSalesOrderLineSerialNumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineLotNumberColumn => columnSalesOrderLineLotNumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineTaxAmountColumn => columnSalesOrderLineTaxAmount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineSalesTaxCodeRefListIDColumn => columnSalesOrderLineSalesTaxCodeRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineSalesTaxCodeRefFullNameColumn => columnSalesOrderLineSalesTaxCodeRefFullName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineTaxCodeRefListIDColumn => columnSalesOrderLineTaxCodeRefListID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SalesOrderLineTaxCodeRefFullNameColumn => columnSalesOrderLineTaxCodeRefFullName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineInvoicedColumn => columnSalesOrderLineInvoiced;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SalesOrderLineIsManuallyClosedColumn => columnSalesOrderLineIsManuallyClosed;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomFieldSalesOrderLineOther1Column => columnCustomFieldSalesOrderLineOther1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldSalesOrderLineOther2Column => columnCustomFieldSalesOrderLineOther2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Tax1TotalColumn => columnTax1Total;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Tax2TotalColumn => columnTax2Total;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ExchangeRateColumn => columnExchangeRate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AmountIncludesVATColumn => columnAmountIncludesVAT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FQSaveToCacheColumn => columnFQSaveToCache;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FQPrimaryKeyColumn => columnFQPrimaryKey;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FQTxnLinkKeyColumn => columnFQTxnLinkKey;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomFieldSalesOrderLineCycleCountColumn => columnCustomFieldSalesOrderLineCycleCount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldSalesOrderLineGroupCycleCountColumn => columnCustomFieldSalesOrderLineGroupCycleCount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldSalesOrderLineGroupLineCycleCountColumn => columnCustomFieldSalesOrderLineGroupLineCycleCount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomFieldCollectColumn => columnCustomFieldCollect;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldPPDCOLColumn => columnCustomFieldPPDCOL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomFieldRepColumn => columnCustomFieldRep;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomFieldShipDateColumn => columnCustomFieldShipDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CustomFieldShipViaColumn => columnCustomFieldShipVia;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public SalesOrderLineRow this[int index] => (SalesOrderLineRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event SalesOrderLineRowChangeEventHandler SalesOrderLineRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event SalesOrderLineRowChangeEventHandler SalesOrderLineRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event SalesOrderLineRowChangeEventHandler SalesOrderLineRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event SalesOrderLineRowChangeEventHandler SalesOrderLineRowDeleted;

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
		public SalesOrderLineDataTable()
		{
			__ENCAddToList(this);
			TableName = "SalesOrderLine";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SalesOrderLineDataTable(DataTable table)
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
		protected SalesOrderLineDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddSalesOrderLineRow(SalesOrderLineRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public SalesOrderLineRow AddSalesOrderLineRow(string TxnID, DateTime TimeCreated, DateTime TimeModified, string EditSequence, int TxnNumber, string CustomerRefListID, string CustomerRefFullName, string ClassRefListID, string ClassRefFullName, string TemplateRefListID, string TemplateRefFullName, DateTime TxnDate, string TxnDateMacro, string RefNumber, string BillAddressAddr1, string BillAddressAddr2, string BillAddressAddr3, string BillAddressAddr4, string BillAddressAddr5, string BillAddressCity, string BillAddressState, string BillAddressProvince, string BillAddressCounty, string BillAddressPostalCode, string BillAddressCountry, string BillAddressNote, string BillAddressBlockAddr1, string BillAddressBlockAddr2, string BillAddressBlockAddr3, string BillAddressBlockAddr4, string BillAddressBlockAddr5, string ShipAddressAddr1, string ShipAddressAddr2, string ShipAddressAddr3, string ShipAddressAddr4, string ShipAddressAddr5, string ShipAddressCity, string ShipAddressState, string ShipAddressProvince, string ShipAddressCounty, string ShipAddressPostalCode, string ShipAddressCountry, string ShipAddressNote, string ShipAddressBlockAddr1, string ShipAddressBlockAddr2, string ShipAddressBlockAddr3, string ShipAddressBlockAddr4, string ShipAddressBlockAddr5, string PONumber, string TermsRefListID, string TermsRefFullName, DateTime DueDate, string SalesRepRefListID, string SalesRepRefFullName, string FOB, DateTime ShipDate, string ShipMethodRefListID, string ShipMethodRefFullName, decimal Subtotal, string ItemSalesTaxRefListID, string ItemSalesTaxRefFullName, decimal SalesTaxPercentage, decimal SalesTaxTotal, decimal TotalAmount, bool IsManuallyClosed, bool IsFullyInvoiced, string Memo, string CustomerMsgRefListID, string CustomerMsgRefFullName, bool IsToBePrinted, bool IsToBeEmailed, bool IsTaxIncluded, string CustomerSalesTaxCodeRefListID, string CustomerSalesTaxCodeRefFullName, string CustomerTaxCodeRefListID, string CustomFieldOther, int SalesOrderLineSeqNo, string SalesOrderLineGroupTxnLineID, string SalesOrderLineGroupItemGroupRefListID, string SalesOrderLineGroupItemGroupRefFullName, string SalesOrderLineGroupDesc, decimal SalesOrderLineGroupQuantity, string SalesOrderLineGroupUnitOfMeasure, string SalesOrderLineGroupOverrideUOMSetRefListID, string SalesOrderLineGroupOverrideUOMSetRefFullName, bool SalesOrderLineGroupIsPrintItemsInGroup, decimal SalesOrderLineGroupTotalAmount, int SalesOrderLineGroupSeqNo, string SalesOrderLineTxnLineID, string SalesOrderLineItemRefListID, string SalesOrderLineItemRefFullName, string SalesOrderLineDesc, decimal SalesOrderLineQuantity, string SalesOrderLineUnitOfMeasure, string SalesOrderLineOverrideUOMSetRefListID, string SalesOrderLineOverrideUOMSetRefFullName, decimal SalesOrderLineRate, decimal SalesOrderLineRatePercent, string SalesOrderLinePriceLevelRefListID, string SalesOrderLinePriceLevelRefFullName, string SalesOrderLineClassRefListID, string SalesOrderLineClassRefFullName, decimal SalesOrderLineAmount, string SalesOrderInventorySiteRefListID, string SalesOrderInventorySiteRefFullName, string SalesOrderLineSerialNumber, string SalesOrderLineLotNumber, decimal SalesOrderLineTaxAmount, string SalesOrderLineSalesTaxCodeRefListID, string SalesOrderLineSalesTaxCodeRefFullName, string SalesOrderLineTaxCodeRefListID, string SalesOrderLineTaxCodeRefFullName, decimal SalesOrderLineInvoiced, bool SalesOrderLineIsManuallyClosed, string CustomFieldSalesOrderLineOther1, string CustomFieldSalesOrderLineOther2, decimal Tax1Total, decimal Tax2Total, decimal ExchangeRate, bool AmountIncludesVAT, bool FQSaveToCache, string FQPrimaryKey, string FQTxnLinkKey, string CustomFieldSalesOrderLineCycleCount, string CustomFieldSalesOrderLineGroupCycleCount, string CustomFieldSalesOrderLineGroupLineCycleCount, string CustomFieldCollect, string CustomFieldPPDCOL, string CustomFieldRep, string CustomFieldShipDate, string CustomFieldShipVia)
		{
			SalesOrderLineRow rowSalesOrderLineRow = (SalesOrderLineRow)NewRow();
			object[] columnValuesArray = new object[131]
			{
				TxnID, TimeCreated, TimeModified, EditSequence, TxnNumber, CustomerRefListID, CustomerRefFullName, ClassRefListID, ClassRefFullName, TemplateRefListID,
				TemplateRefFullName, TxnDate, TxnDateMacro, RefNumber, BillAddressAddr1, BillAddressAddr2, BillAddressAddr3, BillAddressAddr4, BillAddressAddr5, BillAddressCity,
				BillAddressState, BillAddressProvince, BillAddressCounty, BillAddressPostalCode, BillAddressCountry, BillAddressNote, BillAddressBlockAddr1, BillAddressBlockAddr2, BillAddressBlockAddr3, BillAddressBlockAddr4,
				BillAddressBlockAddr5, ShipAddressAddr1, ShipAddressAddr2, ShipAddressAddr3, ShipAddressAddr4, ShipAddressAddr5, ShipAddressCity, ShipAddressState, ShipAddressProvince, ShipAddressCounty,
				ShipAddressPostalCode, ShipAddressCountry, ShipAddressNote, ShipAddressBlockAddr1, ShipAddressBlockAddr2, ShipAddressBlockAddr3, ShipAddressBlockAddr4, ShipAddressBlockAddr5, PONumber, TermsRefListID,
				TermsRefFullName, DueDate, SalesRepRefListID, SalesRepRefFullName, FOB, ShipDate, ShipMethodRefListID, ShipMethodRefFullName, Subtotal, ItemSalesTaxRefListID,
				ItemSalesTaxRefFullName, SalesTaxPercentage, SalesTaxTotal, TotalAmount, IsManuallyClosed, IsFullyInvoiced, Memo, CustomerMsgRefListID, CustomerMsgRefFullName, IsToBePrinted,
				IsToBeEmailed, IsTaxIncluded, CustomerSalesTaxCodeRefListID, CustomerSalesTaxCodeRefFullName, CustomerTaxCodeRefListID, CustomFieldOther, SalesOrderLineSeqNo, SalesOrderLineGroupTxnLineID, SalesOrderLineGroupItemGroupRefListID, SalesOrderLineGroupItemGroupRefFullName,
				SalesOrderLineGroupDesc, SalesOrderLineGroupQuantity, SalesOrderLineGroupUnitOfMeasure, SalesOrderLineGroupOverrideUOMSetRefListID, SalesOrderLineGroupOverrideUOMSetRefFullName, SalesOrderLineGroupIsPrintItemsInGroup, SalesOrderLineGroupTotalAmount, SalesOrderLineGroupSeqNo, SalesOrderLineTxnLineID, SalesOrderLineItemRefListID,
				SalesOrderLineItemRefFullName, SalesOrderLineDesc, SalesOrderLineQuantity, SalesOrderLineUnitOfMeasure, SalesOrderLineOverrideUOMSetRefListID, SalesOrderLineOverrideUOMSetRefFullName, SalesOrderLineRate, SalesOrderLineRatePercent, SalesOrderLinePriceLevelRefListID, SalesOrderLinePriceLevelRefFullName,
				SalesOrderLineClassRefListID, SalesOrderLineClassRefFullName, SalesOrderLineAmount, SalesOrderInventorySiteRefListID, SalesOrderInventorySiteRefFullName, SalesOrderLineSerialNumber, SalesOrderLineLotNumber, SalesOrderLineTaxAmount, SalesOrderLineSalesTaxCodeRefListID, SalesOrderLineSalesTaxCodeRefFullName,
				SalesOrderLineTaxCodeRefListID, SalesOrderLineTaxCodeRefFullName, SalesOrderLineInvoiced, SalesOrderLineIsManuallyClosed, CustomFieldSalesOrderLineOther1, CustomFieldSalesOrderLineOther2, Tax1Total, Tax2Total, ExchangeRate, AmountIncludesVAT,
				FQSaveToCache, FQPrimaryKey, FQTxnLinkKey, CustomFieldSalesOrderLineCycleCount, CustomFieldSalesOrderLineGroupCycleCount, CustomFieldSalesOrderLineGroupLineCycleCount, CustomFieldCollect, CustomFieldPPDCOL, CustomFieldRep, CustomFieldShipDate,
				CustomFieldShipVia
			};
			rowSalesOrderLineRow.ItemArray = columnValuesArray;
			Rows.Add(rowSalesOrderLineRow);
			return rowSalesOrderLineRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public SalesOrderLineRow FindByFQPrimaryKey(string FQPrimaryKey)
		{
			return (SalesOrderLineRow)Rows.Find(new object[1] { FQPrimaryKey });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			SalesOrderLineDataTable cln = (SalesOrderLineDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new SalesOrderLineDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnTxnID = base.Columns["TxnID"];
			columnTimeCreated = base.Columns["TimeCreated"];
			columnTimeModified = base.Columns["TimeModified"];
			columnEditSequence = base.Columns["EditSequence"];
			columnTxnNumber = base.Columns["TxnNumber"];
			columnCustomerRefListID = base.Columns["CustomerRefListID"];
			columnCustomerRefFullName = base.Columns["CustomerRefFullName"];
			columnClassRefListID = base.Columns["ClassRefListID"];
			columnClassRefFullName = base.Columns["ClassRefFullName"];
			columnTemplateRefListID = base.Columns["TemplateRefListID"];
			columnTemplateRefFullName = base.Columns["TemplateRefFullName"];
			columnTxnDate = base.Columns["TxnDate"];
			columnTxnDateMacro = base.Columns["TxnDateMacro"];
			columnRefNumber = base.Columns["RefNumber"];
			columnBillAddressAddr1 = base.Columns["BillAddressAddr1"];
			columnBillAddressAddr2 = base.Columns["BillAddressAddr2"];
			columnBillAddressAddr3 = base.Columns["BillAddressAddr3"];
			columnBillAddressAddr4 = base.Columns["BillAddressAddr4"];
			columnBillAddressAddr5 = base.Columns["BillAddressAddr5"];
			columnBillAddressCity = base.Columns["BillAddressCity"];
			columnBillAddressState = base.Columns["BillAddressState"];
			columnBillAddressProvince = base.Columns["BillAddressProvince"];
			columnBillAddressCounty = base.Columns["BillAddressCounty"];
			columnBillAddressPostalCode = base.Columns["BillAddressPostalCode"];
			columnBillAddressCountry = base.Columns["BillAddressCountry"];
			columnBillAddressNote = base.Columns["BillAddressNote"];
			columnBillAddressBlockAddr1 = base.Columns["BillAddressBlockAddr1"];
			columnBillAddressBlockAddr2 = base.Columns["BillAddressBlockAddr2"];
			columnBillAddressBlockAddr3 = base.Columns["BillAddressBlockAddr3"];
			columnBillAddressBlockAddr4 = base.Columns["BillAddressBlockAddr4"];
			columnBillAddressBlockAddr5 = base.Columns["BillAddressBlockAddr5"];
			columnShipAddressAddr1 = base.Columns["ShipAddressAddr1"];
			columnShipAddressAddr2 = base.Columns["ShipAddressAddr2"];
			columnShipAddressAddr3 = base.Columns["ShipAddressAddr3"];
			columnShipAddressAddr4 = base.Columns["ShipAddressAddr4"];
			columnShipAddressAddr5 = base.Columns["ShipAddressAddr5"];
			columnShipAddressCity = base.Columns["ShipAddressCity"];
			columnShipAddressState = base.Columns["ShipAddressState"];
			columnShipAddressProvince = base.Columns["ShipAddressProvince"];
			columnShipAddressCounty = base.Columns["ShipAddressCounty"];
			columnShipAddressPostalCode = base.Columns["ShipAddressPostalCode"];
			columnShipAddressCountry = base.Columns["ShipAddressCountry"];
			columnShipAddressNote = base.Columns["ShipAddressNote"];
			columnShipAddressBlockAddr1 = base.Columns["ShipAddressBlockAddr1"];
			columnShipAddressBlockAddr2 = base.Columns["ShipAddressBlockAddr2"];
			columnShipAddressBlockAddr3 = base.Columns["ShipAddressBlockAddr3"];
			columnShipAddressBlockAddr4 = base.Columns["ShipAddressBlockAddr4"];
			columnShipAddressBlockAddr5 = base.Columns["ShipAddressBlockAddr5"];
			columnPONumber = base.Columns["PONumber"];
			columnTermsRefListID = base.Columns["TermsRefListID"];
			columnTermsRefFullName = base.Columns["TermsRefFullName"];
			columnDueDate = base.Columns["DueDate"];
			columnSalesRepRefListID = base.Columns["SalesRepRefListID"];
			columnSalesRepRefFullName = base.Columns["SalesRepRefFullName"];
			columnFOB = base.Columns["FOB"];
			columnShipDate = base.Columns["ShipDate"];
			columnShipMethodRefListID = base.Columns["ShipMethodRefListID"];
			columnShipMethodRefFullName = base.Columns["ShipMethodRefFullName"];
			columnSubtotal = base.Columns["Subtotal"];
			columnItemSalesTaxRefListID = base.Columns["ItemSalesTaxRefListID"];
			columnItemSalesTaxRefFullName = base.Columns["ItemSalesTaxRefFullName"];
			columnSalesTaxPercentage = base.Columns["SalesTaxPercentage"];
			columnSalesTaxTotal = base.Columns["SalesTaxTotal"];
			columnTotalAmount = base.Columns["TotalAmount"];
			columnIsManuallyClosed = base.Columns["IsManuallyClosed"];
			columnIsFullyInvoiced = base.Columns["IsFullyInvoiced"];
			columnMemo = base.Columns["Memo"];
			columnCustomerMsgRefListID = base.Columns["CustomerMsgRefListID"];
			columnCustomerMsgRefFullName = base.Columns["CustomerMsgRefFullName"];
			columnIsToBePrinted = base.Columns["IsToBePrinted"];
			columnIsToBeEmailed = base.Columns["IsToBeEmailed"];
			columnIsTaxIncluded = base.Columns["IsTaxIncluded"];
			columnCustomerSalesTaxCodeRefListID = base.Columns["CustomerSalesTaxCodeRefListID"];
			columnCustomerSalesTaxCodeRefFullName = base.Columns["CustomerSalesTaxCodeRefFullName"];
			columnCustomerTaxCodeRefListID = base.Columns["CustomerTaxCodeRefListID"];
			columnCustomFieldOther = base.Columns["CustomFieldOther"];
			columnSalesOrderLineSeqNo = base.Columns["SalesOrderLineSeqNo"];
			columnSalesOrderLineGroupTxnLineID = base.Columns["SalesOrderLineGroupTxnLineID"];
			columnSalesOrderLineGroupItemGroupRefListID = base.Columns["SalesOrderLineGroupItemGroupRefListID"];
			columnSalesOrderLineGroupItemGroupRefFullName = base.Columns["SalesOrderLineGroupItemGroupRefFullName"];
			columnSalesOrderLineGroupDesc = base.Columns["SalesOrderLineGroupDesc"];
			columnSalesOrderLineGroupQuantity = base.Columns["SalesOrderLineGroupQuantity"];
			columnSalesOrderLineGroupUnitOfMeasure = base.Columns["SalesOrderLineGroupUnitOfMeasure"];
			columnSalesOrderLineGroupOverrideUOMSetRefListID = base.Columns["SalesOrderLineGroupOverrideUOMSetRefListID"];
			columnSalesOrderLineGroupOverrideUOMSetRefFullName = base.Columns["SalesOrderLineGroupOverrideUOMSetRefFullName"];
			columnSalesOrderLineGroupIsPrintItemsInGroup = base.Columns["SalesOrderLineGroupIsPrintItemsInGroup"];
			columnSalesOrderLineGroupTotalAmount = base.Columns["SalesOrderLineGroupTotalAmount"];
			columnSalesOrderLineGroupSeqNo = base.Columns["SalesOrderLineGroupSeqNo"];
			columnSalesOrderLineTxnLineID = base.Columns["SalesOrderLineTxnLineID"];
			columnSalesOrderLineItemRefListID = base.Columns["SalesOrderLineItemRefListID"];
			columnSalesOrderLineItemRefFullName = base.Columns["SalesOrderLineItemRefFullName"];
			columnSalesOrderLineDesc = base.Columns["SalesOrderLineDesc"];
			columnSalesOrderLineQuantity = base.Columns["SalesOrderLineQuantity"];
			columnSalesOrderLineUnitOfMeasure = base.Columns["SalesOrderLineUnitOfMeasure"];
			columnSalesOrderLineOverrideUOMSetRefListID = base.Columns["SalesOrderLineOverrideUOMSetRefListID"];
			columnSalesOrderLineOverrideUOMSetRefFullName = base.Columns["SalesOrderLineOverrideUOMSetRefFullName"];
			columnSalesOrderLineRate = base.Columns["SalesOrderLineRate"];
			columnSalesOrderLineRatePercent = base.Columns["SalesOrderLineRatePercent"];
			columnSalesOrderLinePriceLevelRefListID = base.Columns["SalesOrderLinePriceLevelRefListID"];
			columnSalesOrderLinePriceLevelRefFullName = base.Columns["SalesOrderLinePriceLevelRefFullName"];
			columnSalesOrderLineClassRefListID = base.Columns["SalesOrderLineClassRefListID"];
			columnSalesOrderLineClassRefFullName = base.Columns["SalesOrderLineClassRefFullName"];
			columnSalesOrderLineAmount = base.Columns["SalesOrderLineAmount"];
			columnSalesOrderInventorySiteRefListID = base.Columns["SalesOrderInventorySiteRefListID"];
			columnSalesOrderInventorySiteRefFullName = base.Columns["SalesOrderInventorySiteRefFullName"];
			columnSalesOrderLineSerialNumber = base.Columns["SalesOrderLineSerialNumber"];
			columnSalesOrderLineLotNumber = base.Columns["SalesOrderLineLotNumber"];
			columnSalesOrderLineTaxAmount = base.Columns["SalesOrderLineTaxAmount"];
			columnSalesOrderLineSalesTaxCodeRefListID = base.Columns["SalesOrderLineSalesTaxCodeRefListID"];
			columnSalesOrderLineSalesTaxCodeRefFullName = base.Columns["SalesOrderLineSalesTaxCodeRefFullName"];
			columnSalesOrderLineTaxCodeRefListID = base.Columns["SalesOrderLineTaxCodeRefListID"];
			columnSalesOrderLineTaxCodeRefFullName = base.Columns["SalesOrderLineTaxCodeRefFullName"];
			columnSalesOrderLineInvoiced = base.Columns["SalesOrderLineInvoiced"];
			columnSalesOrderLineIsManuallyClosed = base.Columns["SalesOrderLineIsManuallyClosed"];
			columnCustomFieldSalesOrderLineOther1 = base.Columns["CustomFieldSalesOrderLineOther1"];
			columnCustomFieldSalesOrderLineOther2 = base.Columns["CustomFieldSalesOrderLineOther2"];
			columnTax1Total = base.Columns["Tax1Total"];
			columnTax2Total = base.Columns["Tax2Total"];
			columnExchangeRate = base.Columns["ExchangeRate"];
			columnAmountIncludesVAT = base.Columns["AmountIncludesVAT"];
			columnFQSaveToCache = base.Columns["FQSaveToCache"];
			columnFQPrimaryKey = base.Columns["FQPrimaryKey"];
			columnFQTxnLinkKey = base.Columns["FQTxnLinkKey"];
			columnCustomFieldSalesOrderLineCycleCount = base.Columns["CustomFieldSalesOrderLineCycleCount"];
			columnCustomFieldSalesOrderLineGroupCycleCount = base.Columns["CustomFieldSalesOrderLineGroupCycleCount"];
			columnCustomFieldSalesOrderLineGroupLineCycleCount = base.Columns["CustomFieldSalesOrderLineGroupLineCycleCount"];
			columnCustomFieldCollect = base.Columns["CustomFieldCollect"];
			columnCustomFieldPPDCOL = base.Columns["CustomFieldPPDCOL"];
			columnCustomFieldRep = base.Columns["CustomFieldRep"];
			columnCustomFieldShipDate = base.Columns["CustomFieldShipDate"];
			columnCustomFieldShipVia = base.Columns["CustomFieldShipVia"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnTxnID = new DataColumn("TxnID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTxnID);
			columnTimeCreated = new DataColumn("TimeCreated", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnTimeCreated);
			columnTimeModified = new DataColumn("TimeModified", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnTimeModified);
			columnEditSequence = new DataColumn("EditSequence", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEditSequence);
			columnTxnNumber = new DataColumn("TxnNumber", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTxnNumber);
			columnCustomerRefListID = new DataColumn("CustomerRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerRefListID);
			columnCustomerRefFullName = new DataColumn("CustomerRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerRefFullName);
			columnClassRefListID = new DataColumn("ClassRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnClassRefListID);
			columnClassRefFullName = new DataColumn("ClassRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnClassRefFullName);
			columnTemplateRefListID = new DataColumn("TemplateRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTemplateRefListID);
			columnTemplateRefFullName = new DataColumn("TemplateRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTemplateRefFullName);
			columnTxnDate = new DataColumn("TxnDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnTxnDate);
			columnTxnDateMacro = new DataColumn("TxnDateMacro", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTxnDateMacro);
			columnRefNumber = new DataColumn("RefNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRefNumber);
			columnBillAddressAddr1 = new DataColumn("BillAddressAddr1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressAddr1);
			columnBillAddressAddr2 = new DataColumn("BillAddressAddr2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressAddr2);
			columnBillAddressAddr3 = new DataColumn("BillAddressAddr3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressAddr3);
			columnBillAddressAddr4 = new DataColumn("BillAddressAddr4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressAddr4);
			columnBillAddressAddr5 = new DataColumn("BillAddressAddr5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressAddr5);
			columnBillAddressCity = new DataColumn("BillAddressCity", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressCity);
			columnBillAddressState = new DataColumn("BillAddressState", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressState);
			columnBillAddressProvince = new DataColumn("BillAddressProvince", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressProvince);
			columnBillAddressCounty = new DataColumn("BillAddressCounty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressCounty);
			columnBillAddressPostalCode = new DataColumn("BillAddressPostalCode", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressPostalCode);
			columnBillAddressCountry = new DataColumn("BillAddressCountry", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressCountry);
			columnBillAddressNote = new DataColumn("BillAddressNote", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressNote);
			columnBillAddressBlockAddr1 = new DataColumn("BillAddressBlockAddr1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressBlockAddr1);
			columnBillAddressBlockAddr2 = new DataColumn("BillAddressBlockAddr2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressBlockAddr2);
			columnBillAddressBlockAddr3 = new DataColumn("BillAddressBlockAddr3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressBlockAddr3);
			columnBillAddressBlockAddr4 = new DataColumn("BillAddressBlockAddr4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressBlockAddr4);
			columnBillAddressBlockAddr5 = new DataColumn("BillAddressBlockAddr5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBillAddressBlockAddr5);
			columnShipAddressAddr1 = new DataColumn("ShipAddressAddr1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressAddr1);
			columnShipAddressAddr2 = new DataColumn("ShipAddressAddr2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressAddr2);
			columnShipAddressAddr3 = new DataColumn("ShipAddressAddr3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressAddr3);
			columnShipAddressAddr4 = new DataColumn("ShipAddressAddr4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressAddr4);
			columnShipAddressAddr5 = new DataColumn("ShipAddressAddr5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressAddr5);
			columnShipAddressCity = new DataColumn("ShipAddressCity", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressCity);
			columnShipAddressState = new DataColumn("ShipAddressState", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressState);
			columnShipAddressProvince = new DataColumn("ShipAddressProvince", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressProvince);
			columnShipAddressCounty = new DataColumn("ShipAddressCounty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressCounty);
			columnShipAddressPostalCode = new DataColumn("ShipAddressPostalCode", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressPostalCode);
			columnShipAddressCountry = new DataColumn("ShipAddressCountry", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressCountry);
			columnShipAddressNote = new DataColumn("ShipAddressNote", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressNote);
			columnShipAddressBlockAddr1 = new DataColumn("ShipAddressBlockAddr1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressBlockAddr1);
			columnShipAddressBlockAddr2 = new DataColumn("ShipAddressBlockAddr2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressBlockAddr2);
			columnShipAddressBlockAddr3 = new DataColumn("ShipAddressBlockAddr3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressBlockAddr3);
			columnShipAddressBlockAddr4 = new DataColumn("ShipAddressBlockAddr4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressBlockAddr4);
			columnShipAddressBlockAddr5 = new DataColumn("ShipAddressBlockAddr5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipAddressBlockAddr5);
			columnPONumber = new DataColumn("PONumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPONumber);
			columnTermsRefListID = new DataColumn("TermsRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTermsRefListID);
			columnTermsRefFullName = new DataColumn("TermsRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTermsRefFullName);
			columnDueDate = new DataColumn("DueDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDueDate);
			columnSalesRepRefListID = new DataColumn("SalesRepRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesRepRefListID);
			columnSalesRepRefFullName = new DataColumn("SalesRepRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesRepRefFullName);
			columnFOB = new DataColumn("FOB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFOB);
			columnShipDate = new DataColumn("ShipDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnShipDate);
			columnShipMethodRefListID = new DataColumn("ShipMethodRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipMethodRefListID);
			columnShipMethodRefFullName = new DataColumn("ShipMethodRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnShipMethodRefFullName);
			columnSubtotal = new DataColumn("Subtotal", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSubtotal);
			columnItemSalesTaxRefListID = new DataColumn("ItemSalesTaxRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnItemSalesTaxRefListID);
			columnItemSalesTaxRefFullName = new DataColumn("ItemSalesTaxRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnItemSalesTaxRefFullName);
			columnSalesTaxPercentage = new DataColumn("SalesTaxPercentage", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesTaxPercentage);
			columnSalesTaxTotal = new DataColumn("SalesTaxTotal", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesTaxTotal);
			columnTotalAmount = new DataColumn("TotalAmount", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTotalAmount);
			columnIsManuallyClosed = new DataColumn("IsManuallyClosed", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsManuallyClosed);
			columnIsFullyInvoiced = new DataColumn("IsFullyInvoiced", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsFullyInvoiced);
			columnMemo = new DataColumn("Memo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMemo);
			columnCustomerMsgRefListID = new DataColumn("CustomerMsgRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerMsgRefListID);
			columnCustomerMsgRefFullName = new DataColumn("CustomerMsgRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerMsgRefFullName);
			columnIsToBePrinted = new DataColumn("IsToBePrinted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsToBePrinted);
			columnIsToBeEmailed = new DataColumn("IsToBeEmailed", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsToBeEmailed);
			columnIsTaxIncluded = new DataColumn("IsTaxIncluded", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsTaxIncluded);
			columnCustomerSalesTaxCodeRefListID = new DataColumn("CustomerSalesTaxCodeRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerSalesTaxCodeRefListID);
			columnCustomerSalesTaxCodeRefFullName = new DataColumn("CustomerSalesTaxCodeRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerSalesTaxCodeRefFullName);
			columnCustomerTaxCodeRefListID = new DataColumn("CustomerTaxCodeRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerTaxCodeRefListID);
			columnCustomFieldOther = new DataColumn("CustomFieldOther", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldOther);
			columnSalesOrderLineSeqNo = new DataColumn("SalesOrderLineSeqNo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineSeqNo);
			columnSalesOrderLineGroupTxnLineID = new DataColumn("SalesOrderLineGroupTxnLineID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupTxnLineID);
			columnSalesOrderLineGroupItemGroupRefListID = new DataColumn("SalesOrderLineGroupItemGroupRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupItemGroupRefListID);
			columnSalesOrderLineGroupItemGroupRefFullName = new DataColumn("SalesOrderLineGroupItemGroupRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupItemGroupRefFullName);
			columnSalesOrderLineGroupDesc = new DataColumn("SalesOrderLineGroupDesc", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupDesc);
			columnSalesOrderLineGroupQuantity = new DataColumn("SalesOrderLineGroupQuantity", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupQuantity);
			columnSalesOrderLineGroupUnitOfMeasure = new DataColumn("SalesOrderLineGroupUnitOfMeasure", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupUnitOfMeasure);
			columnSalesOrderLineGroupOverrideUOMSetRefListID = new DataColumn("SalesOrderLineGroupOverrideUOMSetRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupOverrideUOMSetRefListID);
			columnSalesOrderLineGroupOverrideUOMSetRefFullName = new DataColumn("SalesOrderLineGroupOverrideUOMSetRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupOverrideUOMSetRefFullName);
			columnSalesOrderLineGroupIsPrintItemsInGroup = new DataColumn("SalesOrderLineGroupIsPrintItemsInGroup", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupIsPrintItemsInGroup);
			columnSalesOrderLineGroupTotalAmount = new DataColumn("SalesOrderLineGroupTotalAmount", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupTotalAmount);
			columnSalesOrderLineGroupSeqNo = new DataColumn("SalesOrderLineGroupSeqNo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineGroupSeqNo);
			columnSalesOrderLineTxnLineID = new DataColumn("SalesOrderLineTxnLineID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineTxnLineID);
			columnSalesOrderLineItemRefListID = new DataColumn("SalesOrderLineItemRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineItemRefListID);
			columnSalesOrderLineItemRefFullName = new DataColumn("SalesOrderLineItemRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineItemRefFullName);
			columnSalesOrderLineDesc = new DataColumn("SalesOrderLineDesc", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineDesc);
			columnSalesOrderLineQuantity = new DataColumn("SalesOrderLineQuantity", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineQuantity);
			columnSalesOrderLineUnitOfMeasure = new DataColumn("SalesOrderLineUnitOfMeasure", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineUnitOfMeasure);
			columnSalesOrderLineOverrideUOMSetRefListID = new DataColumn("SalesOrderLineOverrideUOMSetRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineOverrideUOMSetRefListID);
			columnSalesOrderLineOverrideUOMSetRefFullName = new DataColumn("SalesOrderLineOverrideUOMSetRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineOverrideUOMSetRefFullName);
			columnSalesOrderLineRate = new DataColumn("SalesOrderLineRate", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineRate);
			columnSalesOrderLineRatePercent = new DataColumn("SalesOrderLineRatePercent", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineRatePercent);
			columnSalesOrderLinePriceLevelRefListID = new DataColumn("SalesOrderLinePriceLevelRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLinePriceLevelRefListID);
			columnSalesOrderLinePriceLevelRefFullName = new DataColumn("SalesOrderLinePriceLevelRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLinePriceLevelRefFullName);
			columnSalesOrderLineClassRefListID = new DataColumn("SalesOrderLineClassRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineClassRefListID);
			columnSalesOrderLineClassRefFullName = new DataColumn("SalesOrderLineClassRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineClassRefFullName);
			columnSalesOrderLineAmount = new DataColumn("SalesOrderLineAmount", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineAmount);
			columnSalesOrderInventorySiteRefListID = new DataColumn("SalesOrderInventorySiteRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderInventorySiteRefListID);
			columnSalesOrderInventorySiteRefFullName = new DataColumn("SalesOrderInventorySiteRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderInventorySiteRefFullName);
			columnSalesOrderLineSerialNumber = new DataColumn("SalesOrderLineSerialNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineSerialNumber);
			columnSalesOrderLineLotNumber = new DataColumn("SalesOrderLineLotNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineLotNumber);
			columnSalesOrderLineTaxAmount = new DataColumn("SalesOrderLineTaxAmount", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineTaxAmount);
			columnSalesOrderLineSalesTaxCodeRefListID = new DataColumn("SalesOrderLineSalesTaxCodeRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineSalesTaxCodeRefListID);
			columnSalesOrderLineSalesTaxCodeRefFullName = new DataColumn("SalesOrderLineSalesTaxCodeRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineSalesTaxCodeRefFullName);
			columnSalesOrderLineTaxCodeRefListID = new DataColumn("SalesOrderLineTaxCodeRefListID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineTaxCodeRefListID);
			columnSalesOrderLineTaxCodeRefFullName = new DataColumn("SalesOrderLineTaxCodeRefFullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineTaxCodeRefFullName);
			columnSalesOrderLineInvoiced = new DataColumn("SalesOrderLineInvoiced", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineInvoiced);
			columnSalesOrderLineIsManuallyClosed = new DataColumn("SalesOrderLineIsManuallyClosed", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnSalesOrderLineIsManuallyClosed);
			columnCustomFieldSalesOrderLineOther1 = new DataColumn("CustomFieldSalesOrderLineOther1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldSalesOrderLineOther1);
			columnCustomFieldSalesOrderLineOther2 = new DataColumn("CustomFieldSalesOrderLineOther2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldSalesOrderLineOther2);
			columnTax1Total = new DataColumn("Tax1Total", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTax1Total);
			columnTax2Total = new DataColumn("Tax2Total", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTax2Total);
			columnExchangeRate = new DataColumn("ExchangeRate", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnExchangeRate);
			columnAmountIncludesVAT = new DataColumn("AmountIncludesVAT", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnAmountIncludesVAT);
			columnFQSaveToCache = new DataColumn("FQSaveToCache", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnFQSaveToCache);
			columnFQPrimaryKey = new DataColumn("FQPrimaryKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFQPrimaryKey);
			columnFQTxnLinkKey = new DataColumn("FQTxnLinkKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFQTxnLinkKey);
			columnCustomFieldSalesOrderLineCycleCount = new DataColumn("CustomFieldSalesOrderLineCycleCount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldSalesOrderLineCycleCount);
			columnCustomFieldSalesOrderLineGroupCycleCount = new DataColumn("CustomFieldSalesOrderLineGroupCycleCount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldSalesOrderLineGroupCycleCount);
			columnCustomFieldSalesOrderLineGroupLineCycleCount = new DataColumn("CustomFieldSalesOrderLineGroupLineCycleCount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldSalesOrderLineGroupLineCycleCount);
			columnCustomFieldCollect = new DataColumn("CustomFieldCollect", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldCollect);
			columnCustomFieldPPDCOL = new DataColumn("CustomFieldPPDCOL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldPPDCOL);
			columnCustomFieldRep = new DataColumn("CustomFieldRep", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldRep);
			columnCustomFieldShipDate = new DataColumn("CustomFieldShipDate", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldShipDate);
			columnCustomFieldShipVia = new DataColumn("CustomFieldShipVia", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomFieldShipVia);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnFQPrimaryKey }, isPrimaryKey: true));
			columnTxnID.MaxLength = 36;
			columnEditSequence.MaxLength = 16;
			columnCustomerRefListID.MaxLength = 36;
			columnCustomerRefFullName.MaxLength = 209;
			columnClassRefListID.MaxLength = 36;
			columnClassRefFullName.MaxLength = 159;
			columnTemplateRefListID.MaxLength = 36;
			columnTemplateRefFullName.MaxLength = 159;
			columnTxnDateMacro.MaxLength = 23;
			columnRefNumber.MaxLength = 11;
			columnBillAddressAddr1.MaxLength = 41;
			columnBillAddressAddr2.MaxLength = 41;
			columnBillAddressAddr3.MaxLength = 41;
			columnBillAddressAddr4.MaxLength = 41;
			columnBillAddressAddr5.MaxLength = 41;
			columnBillAddressCity.MaxLength = 31;
			columnBillAddressState.MaxLength = 21;
			columnBillAddressProvince.MaxLength = 21;
			columnBillAddressCounty.MaxLength = 21;
			columnBillAddressPostalCode.MaxLength = 13;
			columnBillAddressCountry.MaxLength = 31;
			columnBillAddressNote.MaxLength = 41;
			columnBillAddressBlockAddr1.MaxLength = 41;
			columnBillAddressBlockAddr2.MaxLength = 41;
			columnBillAddressBlockAddr3.MaxLength = 41;
			columnBillAddressBlockAddr4.MaxLength = 41;
			columnBillAddressBlockAddr5.MaxLength = 41;
			columnShipAddressAddr1.MaxLength = 41;
			columnShipAddressAddr2.MaxLength = 41;
			columnShipAddressAddr3.MaxLength = 41;
			columnShipAddressAddr4.MaxLength = 41;
			columnShipAddressAddr5.MaxLength = 41;
			columnShipAddressCity.MaxLength = 31;
			columnShipAddressState.MaxLength = 21;
			columnShipAddressProvince.MaxLength = 21;
			columnShipAddressCounty.MaxLength = 21;
			columnShipAddressPostalCode.MaxLength = 13;
			columnShipAddressCountry.MaxLength = 31;
			columnShipAddressNote.MaxLength = 41;
			columnShipAddressBlockAddr1.MaxLength = 41;
			columnShipAddressBlockAddr2.MaxLength = 41;
			columnShipAddressBlockAddr3.MaxLength = 41;
			columnShipAddressBlockAddr4.MaxLength = 41;
			columnShipAddressBlockAddr5.MaxLength = 41;
			columnPONumber.MaxLength = 25;
			columnTermsRefListID.MaxLength = 36;
			columnTermsRefFullName.MaxLength = 31;
			columnSalesRepRefListID.MaxLength = 36;
			columnSalesRepRefFullName.MaxLength = 5;
			columnFOB.MaxLength = 13;
			columnShipMethodRefListID.MaxLength = 36;
			columnShipMethodRefFullName.MaxLength = 15;
			columnItemSalesTaxRefListID.MaxLength = 36;
			columnItemSalesTaxRefFullName.MaxLength = 31;
			columnMemo.MaxLength = 536870910;
			columnCustomerMsgRefListID.MaxLength = 36;
			columnCustomerMsgRefFullName.MaxLength = 101;
			columnCustomerSalesTaxCodeRefListID.MaxLength = 36;
			columnCustomerSalesTaxCodeRefFullName.MaxLength = 3;
			columnCustomerTaxCodeRefListID.MaxLength = 36;
			columnCustomFieldOther.MaxLength = 29;
			columnSalesOrderLineGroupTxnLineID.MaxLength = 36;
			columnSalesOrderLineGroupItemGroupRefListID.MaxLength = 36;
			columnSalesOrderLineGroupItemGroupRefFullName.MaxLength = 159;
			columnSalesOrderLineGroupDesc.MaxLength = 536870910;
			columnSalesOrderLineGroupUnitOfMeasure.MaxLength = 31;
			columnSalesOrderLineGroupOverrideUOMSetRefListID.MaxLength = 36;
			columnSalesOrderLineGroupOverrideUOMSetRefFullName.MaxLength = 31;
			columnSalesOrderLineTxnLineID.MaxLength = 36;
			columnSalesOrderLineItemRefListID.MaxLength = 36;
			columnSalesOrderLineItemRefFullName.MaxLength = 159;
			columnSalesOrderLineDesc.MaxLength = 536870910;
			columnSalesOrderLineUnitOfMeasure.MaxLength = 31;
			columnSalesOrderLineOverrideUOMSetRefListID.MaxLength = 36;
			columnSalesOrderLineOverrideUOMSetRefFullName.MaxLength = 31;
			columnSalesOrderLinePriceLevelRefListID.MaxLength = 36;
			columnSalesOrderLinePriceLevelRefFullName.MaxLength = 159;
			columnSalesOrderLineClassRefListID.MaxLength = 36;
			columnSalesOrderLineClassRefFullName.MaxLength = 159;
			columnSalesOrderInventorySiteRefListID.MaxLength = 36;
			columnSalesOrderInventorySiteRefFullName.MaxLength = 31;
			columnSalesOrderLineSerialNumber.MaxLength = 536870910;
			columnSalesOrderLineLotNumber.MaxLength = 40;
			columnSalesOrderLineSalesTaxCodeRefListID.MaxLength = 36;
			columnSalesOrderLineSalesTaxCodeRefFullName.MaxLength = 3;
			columnSalesOrderLineTaxCodeRefListID.MaxLength = 36;
			columnSalesOrderLineTaxCodeRefFullName.MaxLength = 3;
			columnCustomFieldSalesOrderLineOther1.MaxLength = 29;
			columnCustomFieldSalesOrderLineOther2.MaxLength = 29;
			columnFQPrimaryKey.AllowDBNull = false;
			columnFQPrimaryKey.Unique = true;
			columnFQPrimaryKey.MaxLength = 110;
			columnFQTxnLinkKey.MaxLength = 110;
			columnCustomFieldSalesOrderLineCycleCount.MaxLength = 30;
			columnCustomFieldSalesOrderLineGroupCycleCount.MaxLength = 30;
			columnCustomFieldSalesOrderLineGroupLineCycleCount.MaxLength = 30;
			columnCustomFieldCollect.MaxLength = 30;
			columnCustomFieldPPDCOL.MaxLength = 30;
			columnCustomFieldRep.MaxLength = 30;
			columnCustomFieldShipDate.MaxLength = 30;
			columnCustomFieldShipVia.MaxLength = 30;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesOrderLineRow NewSalesOrderLineRow()
		{
			return (SalesOrderLineRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new SalesOrderLineRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(SalesOrderLineRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (SalesOrderLineRowChanged != null)
			{
				SalesOrderLineRowChanged?.Invoke(this, new SalesOrderLineRowChangeEvent((SalesOrderLineRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (SalesOrderLineRowChanging != null)
			{
				SalesOrderLineRowChanging?.Invoke(this, new SalesOrderLineRowChangeEvent((SalesOrderLineRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (SalesOrderLineRowDeleted != null)
			{
				SalesOrderLineRowDeleted?.Invoke(this, new SalesOrderLineRowChangeEvent((SalesOrderLineRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (SalesOrderLineRowDeleting != null)
			{
				SalesOrderLineRowDeleting?.Invoke(this, new SalesOrderLineRowChangeEvent((SalesOrderLineRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveSalesOrderLineRow(SalesOrderLineRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			usmanDataSet ds = new usmanDataSet();
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
			attribute2.FixedValue = "SalesOrderLineDataTable";
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
	public class tblQrCodeDataTable : TypedTableBase<tblQrCodeRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnLink;

		private DataColumn columnProductNumber;

		private DataColumn columnQrPhoto;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LinkColumn => columnLink;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProductNumberColumn => columnProductNumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QrPhotoColumn => columnQrPhoto;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public tblQrCodeRow this[int index] => (tblQrCodeRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event tblQrCodeRowChangeEventHandler tblQrCodeRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event tblQrCodeRowChangeEventHandler tblQrCodeRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event tblQrCodeRowChangeEventHandler tblQrCodeRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event tblQrCodeRowChangeEventHandler tblQrCodeRowDeleted;

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
		public tblQrCodeDataTable()
		{
			__ENCAddToList(this);
			TableName = "tblQrCode";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal tblQrCodeDataTable(DataTable table)
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
		protected tblQrCodeDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddtblQrCodeRow(tblQrCodeRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public tblQrCodeRow AddtblQrCodeRow(string Link, string ProductNumber, byte[] QrPhoto)
		{
			tblQrCodeRow rowtblQrCodeRow = (tblQrCodeRow)NewRow();
			object[] columnValuesArray = new object[3] { Link, ProductNumber, QrPhoto };
			rowtblQrCodeRow.ItemArray = columnValuesArray;
			Rows.Add(rowtblQrCodeRow);
			return rowtblQrCodeRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			tblQrCodeDataTable cln = (tblQrCodeDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new tblQrCodeDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnLink = base.Columns["Link"];
			columnProductNumber = base.Columns["ProductNumber"];
			columnQrPhoto = base.Columns["QrPhoto"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnLink = new DataColumn("Link", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLink);
			columnProductNumber = new DataColumn("ProductNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProductNumber);
			columnQrPhoto = new DataColumn("QrPhoto", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnQrPhoto);
			columnLink.MaxLength = 30;
			columnProductNumber.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public tblQrCodeRow NewtblQrCodeRow()
		{
			return (tblQrCodeRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new tblQrCodeRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(tblQrCodeRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (tblQrCodeRowChanged != null)
			{
				tblQrCodeRowChanged?.Invoke(this, new tblQrCodeRowChangeEvent((tblQrCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (tblQrCodeRowChanging != null)
			{
				tblQrCodeRowChanging?.Invoke(this, new tblQrCodeRowChangeEvent((tblQrCodeRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (tblQrCodeRowDeleted != null)
			{
				tblQrCodeRowDeleted?.Invoke(this, new tblQrCodeRowChangeEvent((tblQrCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (tblQrCodeRowDeleting != null)
			{
				tblQrCodeRowDeleting?.Invoke(this, new tblQrCodeRowChangeEvent((tblQrCodeRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovetblQrCodeRow(tblQrCodeRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			usmanDataSet ds = new usmanDataSet();
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
			attribute2.FixedValue = "tblQrCodeDataTable";
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
	public class OrderInfoDataTable : TypedTableBase<OrderInfoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnOrderNumber;

		private DataColumn columnMotor;

		private DataColumn columnBelt;

		private DataColumn columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OrderNumberColumn => columnOrderNumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MotorColumn => columnMotor;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BeltColumn => columnBelt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PartTypeColumn => columnPartType;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnOrderNumber = base.Columns["OrderNumber"];
			columnMotor = base.Columns["Motor"];
			columnBelt = base.Columns["Belt"];
			columnPartType = base.Columns["PartType"];
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (OrderInfoRowChanged != null)
			{
				OrderInfoRowChanged?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (OrderInfoRowChanging != null)
			{
				OrderInfoRowChanging?.Invoke(this, new OrderInfoRowChangeEvent((OrderInfoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
			usmanDataSet ds = new usmanDataSet();
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

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class dbo_OrderInfoRow : DataRow
	{
		private dbo_OrderInfoDataTable tabledbo_OrderInfo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string OrderNumber
		{
			get
			{
				return Conversions.ToString(this[tabledbo_OrderInfo.OrderNumberColumn]);
			}
			set
			{
				this[tabledbo_OrderInfo.OrderNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Motor
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledbo_OrderInfo.MotorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Motor' in table 'dbo_OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tabledbo_OrderInfo.MotorColumn] = value;
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
					return Conversions.ToString(this[tabledbo_OrderInfo.BeltColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Belt' in table 'dbo_OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tabledbo_OrderInfo.BeltColumn] = value;
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
					return Conversions.ToString(this[tabledbo_OrderInfo.PartTypeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'PartType' in table 'dbo_OrderInfo' is DBNull.", e);
				}
			}
			set
			{
				this[tabledbo_OrderInfo.PartTypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal dbo_OrderInfoRow(DataRowBuilder rb)
			: base(rb)
		{
			tabledbo_OrderInfo = (dbo_OrderInfoDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMotorNull()
		{
			return IsNull(tabledbo_OrderInfo.MotorColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMotorNull()
		{
			this[tabledbo_OrderInfo.MotorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBeltNull()
		{
			return IsNull(tabledbo_OrderInfo.BeltColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBeltNull()
		{
			this[tabledbo_OrderInfo.BeltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPartTypeNull()
		{
			return IsNull(tabledbo_OrderInfo.PartTypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPartTypeNull()
		{
			this[tabledbo_OrderInfo.PartTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class PartsRow : DataRow
	{
		private PartsDataTable tableParts;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal PartsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableParts = (PartsDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPartTypeNull()
		{
			return IsNull(tableParts.PartTypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPartTypeNull()
		{
			this[tableParts.PartTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class SalesOrderLineRow : DataRow
	{
		private SalesOrderLineDataTable tableSalesOrderLine;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TxnID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TxnIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TxnID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TxnIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime TimeCreated
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableSalesOrderLine.TimeCreatedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TimeCreated' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TimeCreatedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime TimeModified
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableSalesOrderLine.TimeModifiedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TimeModified' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TimeModifiedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string EditSequence
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.EditSequenceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'EditSequence' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.EditSequenceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int TxnNumber
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tableSalesOrderLine.TxnNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TxnNumber' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TxnNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomerRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomerRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ClassRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ClassRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ClassRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ClassRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ClassRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ClassRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ClassRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ClassRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TemplateRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TemplateRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TemplateRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TemplateRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TemplateRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TemplateRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TemplateRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TemplateRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime TxnDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableSalesOrderLine.TxnDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TxnDate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TxnDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TxnDateMacro
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TxnDateMacroColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TxnDateMacro' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TxnDateMacroColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string RefNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.RefNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'RefNumber' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.RefNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressAddr1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressAddr1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressAddr1' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressAddr1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressAddr2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressAddr2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressAddr2' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressAddr2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressAddr3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressAddr3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressAddr3' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressAddr3Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressAddr4
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressAddr4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressAddr4' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressAddr4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressAddr5
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressAddr5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressAddr5' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressAddr5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressCity
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressCityColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressCity' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressCityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressState
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressStateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressState' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressStateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressProvince
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressProvinceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressProvince' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressProvinceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressCounty
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressCountyColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressCounty' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressCountyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressPostalCode
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressPostalCodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressPostalCode' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressPostalCodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressCountry
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressCountryColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressCountry' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressCountryColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressNote
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressNoteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressNote' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressNoteColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressBlockAddr1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressBlockAddr1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressBlockAddr1' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressBlockAddr1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BillAddressBlockAddr2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressBlockAddr2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressBlockAddr2' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressBlockAddr2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressBlockAddr3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressBlockAddr3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressBlockAddr3' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressBlockAddr3Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressBlockAddr4
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressBlockAddr4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressBlockAddr4' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressBlockAddr4Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BillAddressBlockAddr5
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.BillAddressBlockAddr5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'BillAddressBlockAddr5' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.BillAddressBlockAddr5Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressAddr1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressAddr1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressAddr1' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressAddr1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressAddr2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressAddr2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressAddr2' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressAddr2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressAddr3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressAddr3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressAddr3' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressAddr3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressAddr4
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressAddr4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressAddr4' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressAddr4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressAddr5
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressAddr5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressAddr5' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressAddr5Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressCity
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressCityColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressCity' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressCityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressState
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressStateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressState' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressStateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressProvince
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressProvinceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressProvince' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressProvinceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressCounty
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressCountyColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressCounty' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressCountyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressPostalCode
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressPostalCodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressPostalCode' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressPostalCodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressCountry
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressCountryColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressCountry' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressCountryColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressNote
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressNoteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressNote' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressNoteColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressBlockAddr1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressBlockAddr1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressBlockAddr1' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressBlockAddr1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressBlockAddr2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressBlockAddr2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressBlockAddr2' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressBlockAddr2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressBlockAddr3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressBlockAddr3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressBlockAddr3' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressBlockAddr3Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipAddressBlockAddr4
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressBlockAddr4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressBlockAddr4' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressBlockAddr4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ShipAddressBlockAddr5
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipAddressBlockAddr5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipAddressBlockAddr5' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipAddressBlockAddr5Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PONumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.PONumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'PONumber' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.PONumberColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TermsRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TermsRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TermsRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TermsRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TermsRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.TermsRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TermsRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TermsRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DueDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableSalesOrderLine.DueDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'DueDate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.DueDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesRepRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesRepRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesRepRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesRepRefListIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesRepRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesRepRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesRepRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesRepRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FOB
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.FOBColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'FOB' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.FOBColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime ShipDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableSalesOrderLine.ShipDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipDate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipMethodRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipMethodRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipMethodRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipMethodRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ShipMethodRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ShipMethodRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ShipMethodRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ShipMethodRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Subtotal
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SubtotalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Subtotal' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SubtotalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ItemSalesTaxRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ItemSalesTaxRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ItemSalesTaxRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ItemSalesTaxRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ItemSalesTaxRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.ItemSalesTaxRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ItemSalesTaxRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ItemSalesTaxRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal SalesTaxPercentage
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesTaxPercentageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesTaxPercentage' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesTaxPercentageColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal SalesTaxTotal
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesTaxTotalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesTaxTotal' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesTaxTotalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal TotalAmount
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.TotalAmountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'TotalAmount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.TotalAmountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsManuallyClosed
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.IsManuallyClosedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'IsManuallyClosed' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.IsManuallyClosedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFullyInvoiced
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.IsFullyInvoicedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'IsFullyInvoiced' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.IsFullyInvoicedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Memo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.MemoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Memo' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.MemoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomerMsgRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerMsgRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerMsgRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerMsgRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomerMsgRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerMsgRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerMsgRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerMsgRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsToBePrinted
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.IsToBePrintedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'IsToBePrinted' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.IsToBePrintedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsToBeEmailed
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.IsToBeEmailedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'IsToBeEmailed' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.IsToBeEmailedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTaxIncluded
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.IsTaxIncludedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'IsTaxIncluded' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.IsTaxIncludedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomerSalesTaxCodeRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerSalesTaxCodeRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerSalesTaxCodeRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerSalesTaxCodeRefListIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomerSalesTaxCodeRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerSalesTaxCodeRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerSalesTaxCodeRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerSalesTaxCodeRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomerTaxCodeRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomerTaxCodeRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomerTaxCodeRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomerTaxCodeRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomFieldOther
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldOtherColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldOther' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldOtherColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int SalesOrderLineSeqNo
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tableSalesOrderLine.SalesOrderLineSeqNoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineSeqNo' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineSeqNoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineGroupTxnLineID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupTxnLineIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupTxnLineID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupTxnLineIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineGroupItemGroupRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupItemGroupRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefListIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineGroupItemGroupRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupItemGroupRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineGroupDesc
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupDescColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupDesc' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupDescColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal SalesOrderLineGroupQuantity
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineGroupQuantityColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupQuantity' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupQuantityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineGroupUnitOfMeasure
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupUnitOfMeasureColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupUnitOfMeasure' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupUnitOfMeasureColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineGroupOverrideUOMSetRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupOverrideUOMSetRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineGroupOverrideUOMSetRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupOverrideUOMSetRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool SalesOrderLineGroupIsPrintItemsInGroup
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.SalesOrderLineGroupIsPrintItemsInGroupColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupIsPrintItemsInGroup' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupIsPrintItemsInGroupColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal SalesOrderLineGroupTotalAmount
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineGroupTotalAmountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupTotalAmount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupTotalAmountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int SalesOrderLineGroupSeqNo
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tableSalesOrderLine.SalesOrderLineGroupSeqNoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineGroupSeqNo' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineGroupSeqNoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineTxnLineID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineTxnLineIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineTxnLineID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineTxnLineIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineItemRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineItemRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineItemRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineItemRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineItemRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineItemRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineItemRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineItemRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineDesc
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineDescColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineDesc' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineDescColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal SalesOrderLineQuantity
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineQuantityColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineQuantity' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineQuantityColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineUnitOfMeasure
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineUnitOfMeasureColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineUnitOfMeasure' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineUnitOfMeasureColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineOverrideUOMSetRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineOverrideUOMSetRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineOverrideUOMSetRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineOverrideUOMSetRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal SalesOrderLineRate
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineRateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineRate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineRateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal SalesOrderLineRatePercent
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineRatePercentColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineRatePercent' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineRatePercentColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLinePriceLevelRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLinePriceLevelRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLinePriceLevelRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLinePriceLevelRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLinePriceLevelRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLinePriceLevelRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLinePriceLevelRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLinePriceLevelRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineClassRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineClassRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineClassRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineClassRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineClassRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineClassRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineClassRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineClassRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal SalesOrderLineAmount
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineAmountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineAmount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineAmountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderInventorySiteRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderInventorySiteRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderInventorySiteRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderInventorySiteRefListIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderInventorySiteRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderInventorySiteRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderInventorySiteRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderInventorySiteRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineSerialNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineSerialNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineSerialNumber' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineSerialNumberColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineLotNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineLotNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineLotNumber' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineLotNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal SalesOrderLineTaxAmount
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineTaxAmountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineTaxAmount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineTaxAmountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineSalesTaxCodeRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineSalesTaxCodeRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineSalesTaxCodeRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineSalesTaxCodeRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefFullNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SalesOrderLineTaxCodeRefListID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineTaxCodeRefListIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineTaxCodeRefListID' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineTaxCodeRefListIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SalesOrderLineTaxCodeRefFullName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.SalesOrderLineTaxCodeRefFullNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineTaxCodeRefFullName' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineTaxCodeRefFullNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal SalesOrderLineInvoiced
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.SalesOrderLineInvoicedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineInvoiced' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineInvoicedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool SalesOrderLineIsManuallyClosed
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.SalesOrderLineIsManuallyClosedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'SalesOrderLineIsManuallyClosed' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.SalesOrderLineIsManuallyClosedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomFieldSalesOrderLineOther1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldSalesOrderLineOther1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldSalesOrderLineOther1' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldSalesOrderLineOther1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldSalesOrderLineOther2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldSalesOrderLineOther2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldSalesOrderLineOther2' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldSalesOrderLineOther2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Tax1Total
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.Tax1TotalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Tax1Total' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.Tax1TotalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal Tax2Total
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.Tax2TotalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Tax2Total' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.Tax2TotalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal ExchangeRate
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableSalesOrderLine.ExchangeRateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ExchangeRate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.ExchangeRateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool AmountIncludesVAT
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.AmountIncludesVATColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'AmountIncludesVAT' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.AmountIncludesVATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool FQSaveToCache
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableSalesOrderLine.FQSaveToCacheColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'FQSaveToCache' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.FQSaveToCacheColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FQPrimaryKey
		{
			get
			{
				return Conversions.ToString(this[tableSalesOrderLine.FQPrimaryKeyColumn]);
			}
			set
			{
				this[tableSalesOrderLine.FQPrimaryKeyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FQTxnLinkKey
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.FQTxnLinkKeyColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'FQTxnLinkKey' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.FQTxnLinkKeyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomFieldSalesOrderLineCycleCount
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldSalesOrderLineCycleCountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldSalesOrderLineCycleCount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldSalesOrderLineCycleCountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldSalesOrderLineGroupCycleCount
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupCycleCountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldSalesOrderLineGroupCycleCount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupCycleCountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldSalesOrderLineGroupLineCycleCount
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupLineCycleCountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldSalesOrderLineGroupLineCycleCount' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupLineCycleCountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldCollect
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldCollectColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldCollect' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldCollectColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldPPDCOL
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldPPDCOLColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldPPDCOL' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldPPDCOLColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldRep
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldRepColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldRep' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldRepColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomFieldShipDate
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldShipDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldShipDate' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldShipDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CustomFieldShipVia
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableSalesOrderLine.CustomFieldShipViaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'CustomFieldShipVia' in table 'SalesOrderLine' is DBNull.", e);
				}
			}
			set
			{
				this[tableSalesOrderLine.CustomFieldShipViaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SalesOrderLineRow(DataRowBuilder rb)
			: base(rb)
		{
			tableSalesOrderLine = (SalesOrderLineDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTxnIDNull()
		{
			return IsNull(tableSalesOrderLine.TxnIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTxnIDNull()
		{
			this[tableSalesOrderLine.TxnIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTimeCreatedNull()
		{
			return IsNull(tableSalesOrderLine.TimeCreatedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTimeCreatedNull()
		{
			this[tableSalesOrderLine.TimeCreatedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTimeModifiedNull()
		{
			return IsNull(tableSalesOrderLine.TimeModifiedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTimeModifiedNull()
		{
			this[tableSalesOrderLine.TimeModifiedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsEditSequenceNull()
		{
			return IsNull(tableSalesOrderLine.EditSequenceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetEditSequenceNull()
		{
			this[tableSalesOrderLine.EditSequenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTxnNumberNull()
		{
			return IsNull(tableSalesOrderLine.TxnNumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTxnNumberNull()
		{
			this[tableSalesOrderLine.TxnNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomerRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.CustomerRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerRefListIDNull()
		{
			this[tableSalesOrderLine.CustomerRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomerRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.CustomerRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomerRefFullNameNull()
		{
			this[tableSalesOrderLine.CustomerRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsClassRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.ClassRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetClassRefListIDNull()
		{
			this[tableSalesOrderLine.ClassRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsClassRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.ClassRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetClassRefFullNameNull()
		{
			this[tableSalesOrderLine.ClassRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTemplateRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.TemplateRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTemplateRefListIDNull()
		{
			this[tableSalesOrderLine.TemplateRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTemplateRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.TemplateRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTemplateRefFullNameNull()
		{
			this[tableSalesOrderLine.TemplateRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTxnDateNull()
		{
			return IsNull(tableSalesOrderLine.TxnDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTxnDateNull()
		{
			this[tableSalesOrderLine.TxnDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTxnDateMacroNull()
		{
			return IsNull(tableSalesOrderLine.TxnDateMacroColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTxnDateMacroNull()
		{
			this[tableSalesOrderLine.TxnDateMacroColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRefNumberNull()
		{
			return IsNull(tableSalesOrderLine.RefNumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRefNumberNull()
		{
			this[tableSalesOrderLine.RefNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBillAddressAddr1Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressAddr1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBillAddressAddr1Null()
		{
			this[tableSalesOrderLine.BillAddressAddr1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBillAddressAddr2Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressAddr2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressAddr2Null()
		{
			this[tableSalesOrderLine.BillAddressAddr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressAddr3Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressAddr3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressAddr3Null()
		{
			this[tableSalesOrderLine.BillAddressAddr3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBillAddressAddr4Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressAddr4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressAddr4Null()
		{
			this[tableSalesOrderLine.BillAddressAddr4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressAddr5Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressAddr5Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBillAddressAddr5Null()
		{
			this[tableSalesOrderLine.BillAddressAddr5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressCityNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressCityColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressCityNull()
		{
			this[tableSalesOrderLine.BillAddressCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressStateNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressStateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressStateNull()
		{
			this[tableSalesOrderLine.BillAddressStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressProvinceNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressProvinceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressProvinceNull()
		{
			this[tableSalesOrderLine.BillAddressProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBillAddressCountyNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressCountyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressCountyNull()
		{
			this[tableSalesOrderLine.BillAddressCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressPostalCodeNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressPostalCodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressPostalCodeNull()
		{
			this[tableSalesOrderLine.BillAddressPostalCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressCountryNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressCountryColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressCountryNull()
		{
			this[tableSalesOrderLine.BillAddressCountryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressNoteNull()
		{
			return IsNull(tableSalesOrderLine.BillAddressNoteColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBillAddressNoteNull()
		{
			this[tableSalesOrderLine.BillAddressNoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressBlockAddr1Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressBlockAddr1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressBlockAddr1Null()
		{
			this[tableSalesOrderLine.BillAddressBlockAddr1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressBlockAddr2Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressBlockAddr2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressBlockAddr2Null()
		{
			this[tableSalesOrderLine.BillAddressBlockAddr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressBlockAddr3Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressBlockAddr3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressBlockAddr3Null()
		{
			this[tableSalesOrderLine.BillAddressBlockAddr3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBillAddressBlockAddr4Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressBlockAddr4Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBillAddressBlockAddr4Null()
		{
			this[tableSalesOrderLine.BillAddressBlockAddr4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBillAddressBlockAddr5Null()
		{
			return IsNull(tableSalesOrderLine.BillAddressBlockAddr5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBillAddressBlockAddr5Null()
		{
			this[tableSalesOrderLine.BillAddressBlockAddr5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressAddr1Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressAddr1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressAddr1Null()
		{
			this[tableSalesOrderLine.ShipAddressAddr1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressAddr2Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressAddr2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressAddr2Null()
		{
			this[tableSalesOrderLine.ShipAddressAddr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressAddr3Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressAddr3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressAddr3Null()
		{
			this[tableSalesOrderLine.ShipAddressAddr3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressAddr4Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressAddr4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressAddr4Null()
		{
			this[tableSalesOrderLine.ShipAddressAddr4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressAddr5Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressAddr5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressAddr5Null()
		{
			this[tableSalesOrderLine.ShipAddressAddr5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressCityNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressCityColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressCityNull()
		{
			this[tableSalesOrderLine.ShipAddressCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressStateNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressStateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetShipAddressStateNull()
		{
			this[tableSalesOrderLine.ShipAddressStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressProvinceNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressProvinceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressProvinceNull()
		{
			this[tableSalesOrderLine.ShipAddressProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressCountyNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressCountyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressCountyNull()
		{
			this[tableSalesOrderLine.ShipAddressCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressPostalCodeNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressPostalCodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressPostalCodeNull()
		{
			this[tableSalesOrderLine.ShipAddressPostalCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressCountryNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressCountryColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressCountryNull()
		{
			this[tableSalesOrderLine.ShipAddressCountryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressNoteNull()
		{
			return IsNull(tableSalesOrderLine.ShipAddressNoteColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetShipAddressNoteNull()
		{
			this[tableSalesOrderLine.ShipAddressNoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressBlockAddr1Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressBlockAddr1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressBlockAddr1Null()
		{
			this[tableSalesOrderLine.ShipAddressBlockAddr1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressBlockAddr2Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressBlockAddr2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressBlockAddr2Null()
		{
			this[tableSalesOrderLine.ShipAddressBlockAddr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressBlockAddr3Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressBlockAddr3Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetShipAddressBlockAddr3Null()
		{
			this[tableSalesOrderLine.ShipAddressBlockAddr3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipAddressBlockAddr4Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressBlockAddr4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressBlockAddr4Null()
		{
			this[tableSalesOrderLine.ShipAddressBlockAddr4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipAddressBlockAddr5Null()
		{
			return IsNull(tableSalesOrderLine.ShipAddressBlockAddr5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipAddressBlockAddr5Null()
		{
			this[tableSalesOrderLine.ShipAddressBlockAddr5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPONumberNull()
		{
			return IsNull(tableSalesOrderLine.PONumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPONumberNull()
		{
			this[tableSalesOrderLine.PONumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTermsRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.TermsRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTermsRefListIDNull()
		{
			this[tableSalesOrderLine.TermsRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTermsRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.TermsRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTermsRefFullNameNull()
		{
			this[tableSalesOrderLine.TermsRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDueDateNull()
		{
			return IsNull(tableSalesOrderLine.DueDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDueDateNull()
		{
			this[tableSalesOrderLine.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesRepRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesRepRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesRepRefListIDNull()
		{
			this[tableSalesOrderLine.SalesRepRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesRepRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesRepRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesRepRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesRepRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOBNull()
		{
			return IsNull(tableSalesOrderLine.FOBColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFOBNull()
		{
			this[tableSalesOrderLine.FOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipDateNull()
		{
			return IsNull(tableSalesOrderLine.ShipDateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipDateNull()
		{
			this[tableSalesOrderLine.ShipDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsShipMethodRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.ShipMethodRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetShipMethodRefListIDNull()
		{
			this[tableSalesOrderLine.ShipMethodRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsShipMethodRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.ShipMethodRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetShipMethodRefFullNameNull()
		{
			this[tableSalesOrderLine.ShipMethodRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSubtotalNull()
		{
			return IsNull(tableSalesOrderLine.SubtotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSubtotalNull()
		{
			this[tableSalesOrderLine.SubtotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsItemSalesTaxRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.ItemSalesTaxRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetItemSalesTaxRefListIDNull()
		{
			this[tableSalesOrderLine.ItemSalesTaxRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsItemSalesTaxRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.ItemSalesTaxRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetItemSalesTaxRefFullNameNull()
		{
			this[tableSalesOrderLine.ItemSalesTaxRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesTaxPercentageNull()
		{
			return IsNull(tableSalesOrderLine.SalesTaxPercentageColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesTaxPercentageNull()
		{
			this[tableSalesOrderLine.SalesTaxPercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesTaxTotalNull()
		{
			return IsNull(tableSalesOrderLine.SalesTaxTotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesTaxTotalNull()
		{
			this[tableSalesOrderLine.SalesTaxTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTotalAmountNull()
		{
			return IsNull(tableSalesOrderLine.TotalAmountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTotalAmountNull()
		{
			this[tableSalesOrderLine.TotalAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIsManuallyClosedNull()
		{
			return IsNull(tableSalesOrderLine.IsManuallyClosedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsManuallyClosedNull()
		{
			this[tableSalesOrderLine.IsManuallyClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIsFullyInvoicedNull()
		{
			return IsNull(tableSalesOrderLine.IsFullyInvoicedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetIsFullyInvoicedNull()
		{
			this[tableSalesOrderLine.IsFullyInvoicedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMemoNull()
		{
			return IsNull(tableSalesOrderLine.MemoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMemoNull()
		{
			this[tableSalesOrderLine.MemoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCustomerMsgRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.CustomerMsgRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomerMsgRefListIDNull()
		{
			this[tableSalesOrderLine.CustomerMsgRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCustomerMsgRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.CustomerMsgRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerMsgRefFullNameNull()
		{
			this[tableSalesOrderLine.CustomerMsgRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIsToBePrintedNull()
		{
			return IsNull(tableSalesOrderLine.IsToBePrintedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsToBePrintedNull()
		{
			this[tableSalesOrderLine.IsToBePrintedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIsToBeEmailedNull()
		{
			return IsNull(tableSalesOrderLine.IsToBeEmailedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsToBeEmailedNull()
		{
			this[tableSalesOrderLine.IsToBeEmailedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIsTaxIncludedNull()
		{
			return IsNull(tableSalesOrderLine.IsTaxIncludedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsTaxIncludedNull()
		{
			this[tableSalesOrderLine.IsTaxIncludedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCustomerSalesTaxCodeRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.CustomerSalesTaxCodeRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerSalesTaxCodeRefListIDNull()
		{
			this[tableSalesOrderLine.CustomerSalesTaxCodeRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomerSalesTaxCodeRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.CustomerSalesTaxCodeRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerSalesTaxCodeRefFullNameNull()
		{
			this[tableSalesOrderLine.CustomerSalesTaxCodeRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomerTaxCodeRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.CustomerTaxCodeRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerTaxCodeRefListIDNull()
		{
			this[tableSalesOrderLine.CustomerTaxCodeRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldOtherNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldOtherColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldOtherNull()
		{
			this[tableSalesOrderLine.CustomFieldOtherColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineSeqNoNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineSeqNoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineSeqNoNull()
		{
			this[tableSalesOrderLine.SalesOrderLineSeqNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupTxnLineIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupTxnLineIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupTxnLineIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupTxnLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupItemGroupRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupItemGroupRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupItemGroupRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupItemGroupRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupItemGroupRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupItemGroupRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupItemGroupRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupDescNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupDescColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupDescNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupQuantityNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupQuantityColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupQuantityNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupQuantityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineGroupUnitOfMeasureNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupUnitOfMeasureColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineGroupUnitOfMeasureNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupUnitOfMeasureColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupOverrideUOMSetRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineGroupOverrideUOMSetRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineGroupOverrideUOMSetRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineGroupOverrideUOMSetRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupOverrideUOMSetRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupIsPrintItemsInGroupNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupIsPrintItemsInGroupColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupIsPrintItemsInGroupNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupIsPrintItemsInGroupColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineGroupTotalAmountNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupTotalAmountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineGroupTotalAmountNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupTotalAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineGroupSeqNoNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineGroupSeqNoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineGroupSeqNoNull()
		{
			this[tableSalesOrderLine.SalesOrderLineGroupSeqNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineTxnLineIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineTxnLineIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineTxnLineIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineTxnLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineItemRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineItemRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineItemRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineItemRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineItemRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineItemRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineItemRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineItemRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineDescNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineDescColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineDescNull()
		{
			this[tableSalesOrderLine.SalesOrderLineDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineQuantityNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineQuantityColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineQuantityNull()
		{
			this[tableSalesOrderLine.SalesOrderLineQuantityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineUnitOfMeasureNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineUnitOfMeasureColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineUnitOfMeasureNull()
		{
			this[tableSalesOrderLine.SalesOrderLineUnitOfMeasureColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineOverrideUOMSetRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineOverrideUOMSetRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineOverrideUOMSetRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineOverrideUOMSetRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineOverrideUOMSetRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineRateNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineRateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineRateNull()
		{
			this[tableSalesOrderLine.SalesOrderLineRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineRatePercentNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineRatePercentColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineRatePercentNull()
		{
			this[tableSalesOrderLine.SalesOrderLineRatePercentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLinePriceLevelRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLinePriceLevelRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLinePriceLevelRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLinePriceLevelRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLinePriceLevelRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLinePriceLevelRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLinePriceLevelRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLinePriceLevelRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineClassRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineClassRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineClassRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineClassRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineClassRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineClassRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineClassRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineClassRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineAmountNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineAmountColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineAmountNull()
		{
			this[tableSalesOrderLine.SalesOrderLineAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderInventorySiteRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderInventorySiteRefListIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderInventorySiteRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderInventorySiteRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderInventorySiteRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderInventorySiteRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderInventorySiteRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderInventorySiteRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineSerialNumberNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineSerialNumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineSerialNumberNull()
		{
			this[tableSalesOrderLine.SalesOrderLineSerialNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineLotNumberNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineLotNumberColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineLotNumberNull()
		{
			this[tableSalesOrderLine.SalesOrderLineLotNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineTaxAmountNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineTaxAmountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineTaxAmountNull()
		{
			this[tableSalesOrderLine.SalesOrderLineTaxAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineSalesTaxCodeRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineSalesTaxCodeRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineSalesTaxCodeRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefFullNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineSalesTaxCodeRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineSalesTaxCodeRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSalesOrderLineTaxCodeRefListIDNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineTaxCodeRefListIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineTaxCodeRefListIDNull()
		{
			this[tableSalesOrderLine.SalesOrderLineTaxCodeRefListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineTaxCodeRefFullNameNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineTaxCodeRefFullNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineTaxCodeRefFullNameNull()
		{
			this[tableSalesOrderLine.SalesOrderLineTaxCodeRefFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineInvoicedNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineInvoicedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSalesOrderLineInvoicedNull()
		{
			this[tableSalesOrderLine.SalesOrderLineInvoicedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSalesOrderLineIsManuallyClosedNull()
		{
			return IsNull(tableSalesOrderLine.SalesOrderLineIsManuallyClosedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSalesOrderLineIsManuallyClosedNull()
		{
			this[tableSalesOrderLine.SalesOrderLineIsManuallyClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldSalesOrderLineOther1Null()
		{
			return IsNull(tableSalesOrderLine.CustomFieldSalesOrderLineOther1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomFieldSalesOrderLineOther1Null()
		{
			this[tableSalesOrderLine.CustomFieldSalesOrderLineOther1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldSalesOrderLineOther2Null()
		{
			return IsNull(tableSalesOrderLine.CustomFieldSalesOrderLineOther2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldSalesOrderLineOther2Null()
		{
			this[tableSalesOrderLine.CustomFieldSalesOrderLineOther2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTax1TotalNull()
		{
			return IsNull(tableSalesOrderLine.Tax1TotalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTax1TotalNull()
		{
			this[tableSalesOrderLine.Tax1TotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTax2TotalNull()
		{
			return IsNull(tableSalesOrderLine.Tax2TotalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTax2TotalNull()
		{
			this[tableSalesOrderLine.Tax2TotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsExchangeRateNull()
		{
			return IsNull(tableSalesOrderLine.ExchangeRateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetExchangeRateNull()
		{
			this[tableSalesOrderLine.ExchangeRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAmountIncludesVATNull()
		{
			return IsNull(tableSalesOrderLine.AmountIncludesVATColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAmountIncludesVATNull()
		{
			this[tableSalesOrderLine.AmountIncludesVATColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFQSaveToCacheNull()
		{
			return IsNull(tableSalesOrderLine.FQSaveToCacheColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFQSaveToCacheNull()
		{
			this[tableSalesOrderLine.FQSaveToCacheColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFQTxnLinkKeyNull()
		{
			return IsNull(tableSalesOrderLine.FQTxnLinkKeyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFQTxnLinkKeyNull()
		{
			this[tableSalesOrderLine.FQTxnLinkKeyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldSalesOrderLineCycleCountNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldSalesOrderLineCycleCountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldSalesOrderLineCycleCountNull()
		{
			this[tableSalesOrderLine.CustomFieldSalesOrderLineCycleCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldSalesOrderLineGroupCycleCountNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldSalesOrderLineGroupCycleCountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldSalesOrderLineGroupCycleCountNull()
		{
			this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupCycleCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCustomFieldSalesOrderLineGroupLineCycleCountNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldSalesOrderLineGroupLineCycleCountColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomFieldSalesOrderLineGroupLineCycleCountNull()
		{
			this[tableSalesOrderLine.CustomFieldSalesOrderLineGroupLineCycleCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldCollectNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldCollectColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldCollectNull()
		{
			this[tableSalesOrderLine.CustomFieldCollectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldPPDCOLNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldPPDCOLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomFieldPPDCOLNull()
		{
			this[tableSalesOrderLine.CustomFieldPPDCOLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldRepNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldRepColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldRepNull()
		{
			this[tableSalesOrderLine.CustomFieldRepColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomFieldShipDateNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldShipDateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCustomFieldShipDateNull()
		{
			this[tableSalesOrderLine.CustomFieldShipDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCustomFieldShipViaNull()
		{
			return IsNull(tableSalesOrderLine.CustomFieldShipViaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomFieldShipViaNull()
		{
			this[tableSalesOrderLine.CustomFieldShipViaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class tblQrCodeRow : DataRow
	{
		private tblQrCodeDataTable tabletblQrCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Link
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletblQrCode.LinkColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'Link' in table 'tblQrCode' is DBNull.", e);
				}
			}
			set
			{
				this[tabletblQrCode.LinkColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ProductNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletblQrCode.ProductNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'ProductNumber' in table 'tblQrCode' is DBNull.", e);
				}
			}
			set
			{
				this[tabletblQrCode.ProductNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public byte[] QrPhoto
		{
			get
			{
				try
				{
					return (byte[])this[tabletblQrCode.QrPhotoColumn];
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("The value for column 'QrPhoto' in table 'tblQrCode' is DBNull.", e);
				}
			}
			set
			{
				this[tabletblQrCode.QrPhotoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal tblQrCodeRow(DataRowBuilder rb)
			: base(rb)
		{
			tabletblQrCode = (tblQrCodeDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLinkNull()
		{
			return IsNull(tabletblQrCode.LinkColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLinkNull()
		{
			this[tabletblQrCode.LinkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsProductNumberNull()
		{
			return IsNull(tabletblQrCode.ProductNumberColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetProductNumberNull()
		{
			this[tabletblQrCode.ProductNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQrPhotoNull()
		{
			return IsNull(tabletblQrCode.QrPhotoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQrPhotoNull()
		{
			this[tabletblQrCode.QrPhotoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class OrderInfoRow : DataRow
	{
		private OrderInfoDataTable tableOrderInfo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMotorNull()
		{
			return IsNull(tableOrderInfo.MotorColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class dbo_OrderInfoRowChangeEvent : EventArgs
	{
		private dbo_OrderInfoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dbo_OrderInfoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dbo_OrderInfoRowChangeEvent(dbo_OrderInfoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class PartsRowChangeEvent : EventArgs
	{
		private PartsRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class SalesOrderLineRowChangeEvent : EventArgs
	{
		private SalesOrderLineRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public SalesOrderLineRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesOrderLineRowChangeEvent(SalesOrderLineRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class tblQrCodeRowChangeEvent : EventArgs
	{
		private tblQrCodeRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public tblQrCodeRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public tblQrCodeRowChangeEvent(tblQrCodeRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class OrderInfoRowChangeEvent : EventArgs
	{
		private OrderInfoRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public OrderInfoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public OrderInfoRowChangeEvent(OrderInfoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private dbo_OrderInfoDataTable tabledbo_OrderInfo;

	private PartsDataTable tableParts;

	private SalesOrderLineDataTable tableSalesOrderLine;

	private tblQrCodeDataTable tabletblQrCode;

	private OrderInfoDataTable tableOrderInfo;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public dbo_OrderInfoDataTable dbo_OrderInfo => tabledbo_OrderInfo;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public PartsDataTable Parts => tableParts;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SalesOrderLineDataTable SalesOrderLine => tableSalesOrderLine;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public tblQrCodeDataTable tblQrCode => tabletblQrCode;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public OrderInfoDataTable OrderInfo => tableOrderInfo;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public usmanDataSet()
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
	protected usmanDataSet(SerializationInfo info, StreamingContext context)
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
			if (ds.Tables["dbo_OrderInfo"] != null)
			{
				base.Tables.Add(new dbo_OrderInfoDataTable(ds.Tables["dbo_OrderInfo"]));
			}
			if (ds.Tables["Parts"] != null)
			{
				base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
			}
			if (ds.Tables["SalesOrderLine"] != null)
			{
				base.Tables.Add(new SalesOrderLineDataTable(ds.Tables["SalesOrderLine"]));
			}
			if (ds.Tables["tblQrCode"] != null)
			{
				base.Tables.Add(new tblQrCodeDataTable(ds.Tables["tblQrCode"]));
			}
			if (ds.Tables["OrderInfo"] != null)
			{
				base.Tables.Add(new OrderInfoDataTable(ds.Tables["OrderInfo"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		usmanDataSet cln = (usmanDataSet)base.Clone();
		cln.InitVars();
		cln.SchemaSerializationMode = SchemaSerializationMode;
		return cln;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			if (ds.Tables["dbo_OrderInfo"] != null)
			{
				base.Tables.Add(new dbo_OrderInfoDataTable(ds.Tables["dbo_OrderInfo"]));
			}
			if (ds.Tables["Parts"] != null)
			{
				base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
			}
			if (ds.Tables["SalesOrderLine"] != null)
			{
				base.Tables.Add(new SalesOrderLineDataTable(ds.Tables["SalesOrderLine"]));
			}
			if (ds.Tables["tblQrCode"] != null)
			{
				base.Tables.Add(new tblQrCodeDataTable(ds.Tables["tblQrCode"]));
			}
			if (ds.Tables["OrderInfo"] != null)
			{
				base.Tables.Add(new OrderInfoDataTable(ds.Tables["OrderInfo"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		tabledbo_OrderInfo = (dbo_OrderInfoDataTable)base.Tables["dbo_OrderInfo"];
		if (initTable && tabledbo_OrderInfo != null)
		{
			tabledbo_OrderInfo.InitVars();
		}
		tableParts = (PartsDataTable)base.Tables["Parts"];
		if (initTable && tableParts != null)
		{
			tableParts.InitVars();
		}
		tableSalesOrderLine = (SalesOrderLineDataTable)base.Tables["SalesOrderLine"];
		if (initTable && tableSalesOrderLine != null)
		{
			tableSalesOrderLine.InitVars();
		}
		tabletblQrCode = (tblQrCodeDataTable)base.Tables["tblQrCode"];
		if (initTable && tabletblQrCode != null)
		{
			tabletblQrCode.InitVars();
		}
		tableOrderInfo = (OrderInfoDataTable)base.Tables["OrderInfo"];
		if (initTable && tableOrderInfo != null)
		{
			tableOrderInfo.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "usmanDataSet";
		Prefix = "";
		Namespace = "http://tempuri.org/usmanDataSet.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tabledbo_OrderInfo = new dbo_OrderInfoDataTable();
		base.Tables.Add(tabledbo_OrderInfo);
		tableParts = new PartsDataTable();
		base.Tables.Add(tableParts);
		tableSalesOrderLine = new SalesOrderLineDataTable();
		base.Tables.Add(tableSalesOrderLine);
		tabletblQrCode = new tblQrCodeDataTable();
		base.Tables.Add(tabletblQrCode);
		tableOrderInfo = new OrderInfoDataTable();
		base.Tables.Add(tableOrderInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializedbo_OrderInfo()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeParts()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeSalesOrderLine()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializetblQrCode()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeOrderInfo()
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		usmanDataSet ds = new usmanDataSet();
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
