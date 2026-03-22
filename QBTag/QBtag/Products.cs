using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;

namespace QBtag;

public class Products
{
	private string _ProductName;

	private double _Quantity;

	public string ConnectionString;

	public string ConnectionString2;

	private object conStr;

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

	public string ProductName
	{
		get
		{
			return _ProductName;
		}
		set
		{
			_ProductName = value;
		}
	}

	public double Quantity
	{
		get
		{
			return _Quantity;
		}
		set
		{
			_Quantity = value;
		}
	}

	public Products()
	{
		ConnectionString = "";
		ConnectionString2 = "";
		conStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
	}

	public bool AddProduct()
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("Insert into tblProducts (ProductName,Quantity) Values(@ProductName,@Quantity)", DbConnection);
		DbCommand.Parameters.AddWithValue("@ProductName", ProductName.Trim().ToString());
		DbCommand.Parameters.AddWithValue("@Quantity", Quantity);
		DbConnection.Open();
		if (DbCommand.ExecuteNonQuery() > 0)
		{
			return true;
		}
		return false;
	}

	public bool Delete(string productName)
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("DELETE FROM tblProducts WHERE ProductName='" + productName + "'", DbConnection);
		DbConnection.Open();
		if (DbCommand.ExecuteNonQuery() > 0)
		{
			return true;
		}
		return false;
	}

	public bool CheckExist()
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using (OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr)))
		{
			DbCommand = new OleDbCommand("SELECT * FROM tblProducts WHERE ProductName='" + ProductName + "'", DbConnection);
			DbConnection.Open();
			DataSet ds = new DataSet();
			try
			{
				DbDataAdapter = new OleDbDataAdapter(DbCommand);
				DbDataAdapter.SelectCommand = DbCommand;
				DbDataAdapter.Fill(ds, "tblProducts");
				if (ds.Tables[0].Rows.Count > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		return false;
	}

	public bool Update()
	{
		this.DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		using (OleDbConnection DbConnection = new OleDbConnection(Conversions.ToString(conStr)))
		{
			DbCommand = new OleDbCommand("UPDATE tblProducts SET Quantity=" + Conversions.ToString(Quantity) + " WHERE ProductName='" + ProductName + "'", DbConnection);
			DbConnection.Open();
			try
			{
				if (DbCommand.ExecuteNonQuery() > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		return false;
	}

	public Hashtable GetProducts()
	{
		Hashtable hashProduct = new Hashtable();
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("SELECT * FROM tblProducts", DbConnection);
		DataSet ds = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(ds, "tblProducts");
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow row in ds.Tables[0].Rows)
			{
				Products prd = new Products();
				prd.ProductName = row["ProductName"].ToString();
				try
				{
					prd.Quantity = double.Parse(row["Quantity"].ToString());
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				hashProduct[prd.ProductName.ToLower()] = prd;
			}
		}
		return hashProduct;
	}

	public static bool Save(DataTable dt)
	{
		if ((dt != null) & (dt.Rows.Count > 0))
		{
			dt.TableName = "Products";
			dt.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "Product.xml");
		}
		return true;
	}
}
