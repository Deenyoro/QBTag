using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Logs;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using QBtag.My;
using QuickBooksHandler;
using QuickBooksModel;

namespace QBtag;

[DesignerGenerated]
public class FrmCRViewer : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("CVReports")]
	private CrystalReportViewer _CVReports;

	[AccessedThroughProperty("PrintDialog1")]
	private PrintDialog _PrintDialog1;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	private DataSet DbDataset;

	public string ConnectionString;

	public OleDbCommand DbCommand;

	public OleDbCommand DbCommand2;

	public OleDbConnection DbConnection;

	private object conStr;

	public OleDbDataAdapter DbDataAdapter;

	public OleDbDataAdapter DbDataAdapter2;

	public OleDbDataAdapter DbDataAdapter3;

	public OleDbDataAdapter DbDataAdapter4;

	public OleDbDataAdapter DbDataAdapter5;

	public bool ShowCategory;

	public bool ShowDepartmentwise;

	public bool ShowItemwise;

	public bool ShowInvoicewise;

	public bool Printer;

	public bool Pdf;

	public bool Excel;

	public ParameterValues PValue;

	public ParameterDiscreteValue PDValue;

	public string FreePhone;

	public string FromWhere;

	public bool Print;

	public bool Preview;

	public bool Aerodyne;

	internal virtual CrystalReportViewer CVReports
	{
		[DebuggerNonUserCode]
		get
		{
			return _CVReports;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CVReports = value;
		}
	}

	internal virtual PrintDialog PrintDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintDialog1 = value;
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintDocument1 = value;
		}
	}

	public FrmCRViewer()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		base.Load += FrmCRViewer_Load;
		__ENCAddToList(this);
		ConnectionString = "";
		conStr = MySettingsProperty.Settings.AccessDatabaseConnectionString;
		PValue = new ParameterValues();
		PDValue = new ParameterDiscreteValue();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		this.CVReports = new CrystalReportViewer();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.SuspendLayout();
		this.CVReports.ActiveViewIndex = -1;
		((System.Windows.Forms.UserControl)(object)this.CVReports).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		((System.Windows.Forms.Control)(object)this.CVReports).Cursor = System.Windows.Forms.Cursors.Default;
		((System.Windows.Forms.Control)(object)this.CVReports).Dock = System.Windows.Forms.DockStyle.Fill;
		CrystalReportViewer cVReports = this.CVReports;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)cVReports).Location = location;
		((System.Windows.Forms.Control)(object)this.CVReports).Name = "CVReports";
		this.CVReports.SelectionFormula = "";
		this.CVReports.ShowGroupTreeButton = false;
		CrystalReportViewer cVReports2 = this.CVReports;
		System.Drawing.Size size = new System.Drawing.Size(925, 544);
		((System.Windows.Forms.Control)(object)cVReports2).Size = size;
		((System.Windows.Forms.Control)(object)this.CVReports).TabIndex = 0;
		this.CVReports.ToolPanelView = (ToolPanelViewType)0;
		this.CVReports.ViewTimeSelectionFormula = "";
		this.PrintDialog1.UseEXDialog = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(925, 544);
		this.ClientSize = size;
		this.Controls.Add((System.Windows.Forms.Control)(object)this.CVReports);
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "FrmCRViewer";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "FrmCRViewer";
		this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.ResumeLayout(false);
	}

	private void FrmCRViewer_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(Text, "Tag Report", TextCompare: false) == 0)
		{
			ShowTagReport(FreePhone, FromWhere, Aerodyne);
		}
		else if (Operators.CompareString(Text, "Tag Report with QRCodes", TextCompare: false) == 0)
		{
			ShowTagReportWithQRCodes(FreePhone, FromWhere, Aerodyne);
		}
	}

	public void ShowNewTagReport(string FreePhone, string FromWhere)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		OrderInfoHandler OH = new OrderInfoHandler();
		List<OrderInfo> OrdersList = new List<OrderInfo>();
		OrdersList = OH.GetOrders(Conversions.ToString(conStr));
		string reportPath = Application.StartupPath + "\\tag.rpt";
		if (!System.IO.File.Exists(reportPath))
		{
			MessageBox.Show("Report file not found:\n" + reportPath, "QBTag", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Logs.Log.Add("Report file not found: " + reportPath);
			return;
		}
		ReportDocument TagReport = new ReportDocument();
		TagReport.Load(reportPath);
		TagReport.SetDataSource((IEnumerable)OrdersList);
		PDValue.Value = FreePhone;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReport.DataDefinition.ParameterFields["FreePhone"].ApplyCurrentValues(PValue);
		PDValue.Value = FromWhere;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReport.DataDefinition.ParameterFields["FromWhere"].ApplyCurrentValues(PValue);
		CVReports.ReportSource = TagReport;
		((Control)(object)CVReports).Refresh();
		if (Preview)
		{
			((Control)(object)CVReports).Visible = true;
		}
		else
		{
			((Control)(object)CVReports).Visible = false;
		}
		if (!Print)
		{
			return;
		}
		PrintDialog1.Document = PrintDocument1;
		DialogResult dr = PrintDialog1.ShowDialog();
		if (dr == DialogResult.OK)
		{
			int nCopy = PrintDocument1.PrinterSettings.Copies;
			int sPage = PrintDocument1.PrinterSettings.FromPage;
			int ePage = PrintDocument1.PrinterSettings.ToPage;
			string PrinterName = PrintDocument1.PrinterSettings.PrinterName;
			try
			{
				TagReport.PrintOptions.PrinterName = PrinterName;
				TagReport.PrintToPrinter(nCopy, false, sPage, ePage);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Logs.Log.Add(ex);
				Exception err = ex;
				MessageBox.Show(err.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ShowTagReport(string FreePhone, string FromWhere, bool Aerodyne)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
		TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
		ConnectionInfo crConnectionInfo = new ConnectionInfo();
		string reportPath = Application.StartupPath + "\\tag.rpt";
		if (!System.IO.File.Exists(reportPath))
		{
			MessageBox.Show("Report file not found:\n" + reportPath, "QBTag", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Logs.Log.Add("Report file not found: " + reportPath);
			return;
		}
		ReportDocument TagReport = new ReportDocument();
		TagReport.Load(reportPath);
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("select * from OrderInfo ORDER BY OrderNumber", DbConnection);
		DbDataset = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter.Fill(DbDataset, "OrderInfo");
		DataTable dt = DbDataset.Tables[0];
		int count = dt.Rows.Count;
		int num = 0;
		while (true)
		{
			int num2 = num;
			int num3 = count;
			if (num2 > num3)
			{
				break;
			}
			num = checked(num + 1);
		}
		TagReport.SetDataSource(DbDataset);
		PDValue.Value = FreePhone;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReport.DataDefinition.ParameterFields["FreePhone"].ApplyCurrentValues(PValue);
		PDValue.Value = FromWhere;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReport.DataDefinition.ParameterFields["FromWhere"].ApplyCurrentValues(PValue);
		PDValue.Value = Aerodyne;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReport.DataDefinition.ParameterFields["Aero"].ApplyCurrentValues(PValue);
		CVReports.ReportSource = TagReport;
		((Control)(object)CVReports).Refresh();
		if (Preview)
		{
			((Control)(object)CVReports).Visible = true;
		}
		else
		{
			((Control)(object)CVReports).Visible = false;
		}
		if (!Print)
		{
			return;
		}
		PrintDialog1.Document = PrintDocument1;
		DialogResult dr = PrintDialog1.ShowDialog();
		if (dr == DialogResult.OK)
		{
			int nCopy = PrintDocument1.PrinterSettings.Copies;
			int sPage = PrintDocument1.PrinterSettings.FromPage;
			int ePage = PrintDocument1.PrinterSettings.ToPage;
			string PrinterName = PrintDocument1.PrinterSettings.PrinterName;
			try
			{
				TagReport.PrintOptions.PrinterName = PrinterName;
				TagReport.PrintToPrinter(nCopy, false, sPage, ePage);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Logs.Log.Add(ex);
				Exception err = ex;
				MessageBox.Show(err.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ShowTagReportWithQRCodes(string FreePhone, string FromWhere, bool Aerodyne)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
		TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
		ConnectionInfo crConnectionInfo = new ConnectionInfo();
		string reportPath = Application.StartupPath + "\\TagWithQRCodes.rpt";
		if (!System.IO.File.Exists(reportPath))
		{
			MessageBox.Show("Report file not found:\n" + reportPath, "QBTag", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Logs.Log.Add("Report file not found: " + reportPath);
			return;
		}
		ReportDocument TagReportWithQRCodes = new ReportDocument();
		TagReportWithQRCodes.Load(reportPath);
		DbConnection = new OleDbConnection(Conversions.ToString(conStr));
		DbCommand = new OleDbCommand("select * from ViewOrderWithQRCode", DbConnection);
		DbCommand2 = new OleDbCommand("select * from Parts", DbConnection);
		DbDataset = new DataSet();
		DbDataAdapter = new OleDbDataAdapter(DbCommand);
		DbDataAdapter2 = new OleDbDataAdapter(DbCommand2);
		DbDataAdapter.SelectCommand = DbCommand;
		DbDataAdapter2.SelectCommand = DbCommand2;
		DbDataAdapter.Fill(DbDataset, "ViewOrderWithQRCode");
		TagReportWithQRCodes.SetDataSource(DbDataset.Tables[0]);
		PDValue.Value = FreePhone;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReportWithQRCodes.DataDefinition.ParameterFields["FreePhone"].ApplyCurrentValues(PValue);
		PDValue.Value = FromWhere;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReportWithQRCodes.DataDefinition.ParameterFields["FromWhere"].ApplyCurrentValues(PValue);
		PDValue.Value = Aerodyne;
		PValue.Clear();
		PValue.Add((ParameterValue)(object)PDValue);
		TagReportWithQRCodes.DataDefinition.ParameterFields["Aero"].ApplyCurrentValues(PValue);
		CVReports.ReportSource = TagReportWithQRCodes;
		((Control)(object)CVReports).Refresh();
		if (Preview)
		{
			((Control)(object)CVReports).Visible = true;
		}
		else
		{
			((Control)(object)CVReports).Visible = false;
		}
		if (!Print)
		{
			return;
		}
		PrintDialog1.Document = PrintDocument1;
		DialogResult dr = PrintDialog1.ShowDialog();
		if (dr == DialogResult.OK)
		{
			int nCopy = PrintDocument1.PrinterSettings.Copies;
			int sPage = PrintDocument1.PrinterSettings.FromPage;
			int ePage = PrintDocument1.PrinterSettings.ToPage;
			string PrinterName = PrintDocument1.PrinterSettings.PrinterName;
			try
			{
				TagReportWithQRCodes.PrintOptions.PrinterName = PrinterName;
				TagReportWithQRCodes.PrintToPrinter(nCopy, false, sPage, ePage);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Logs.Log.Add(ex);
				Exception err = ex;
				MessageBox.Show(err.ToString(), "Abanaki QB Tag");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void setDBLOGONforREPORT(ConnectionInfo myconnectioninfo)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		TableLogOnInfos mytableloginfos = new TableLogOnInfos();
		mytableloginfos = CVReports.LogOnInfo;
		foreach (TableLogOnInfo item in (ArrayList)(object)mytableloginfos)
		{
			TableLogOnInfo myTableLogOnInfo = item;
			myTableLogOnInfo.ConnectionInfo = myconnectioninfo;
		}
	}
}
