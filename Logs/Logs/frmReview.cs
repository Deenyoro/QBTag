using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Logs;

public class frmReview : Form
{
	private IContainer components;

	private DataGridView dgvBill;

	private Button btnClose;

	private Button btnPrint;

	private PrintDocument printDocument1;

	private PrintPreviewDialog printPreviewDialog1;

	private Label label1;

	private int RowIndex = -1;

	private DataTable dtView;

	private static bool isRestart;

	private int intRow;

	private double TotalRow;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs.frmReview));
		this.dgvBill = new System.Windows.Forms.DataGridView();
		this.btnClose = new System.Windows.Forms.Button();
		this.btnPrint = new System.Windows.Forms.Button();
		this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		this.label1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvBill).BeginInit();
		base.SuspendLayout();
		this.dgvBill.AllowUserToAddRows = false;
		this.dgvBill.AllowUserToDeleteRows = false;
		this.dgvBill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dgvBill.BackgroundColor = System.Drawing.Color.White;
		this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvBill.Location = new System.Drawing.Point(12, 12);
		this.dgvBill.Name = "dgvBill";
		this.dgvBill.RowHeadersVisible = false;
		this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvBill.Size = new System.Drawing.Size(473, 215);
		this.dgvBill.TabIndex = 0;
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnClose.Location = new System.Drawing.Point(410, 233);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(75, 23);
		this.btnClose.TabIndex = 1;
		this.btnClose.Text = "Close";
		this.btnClose.UseVisualStyleBackColor = true;
		this.btnClose.Click += new System.EventHandler(btnClose_Click);
		this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnPrint.Location = new System.Drawing.Point(329, 233);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(75, 23);
		this.btnPrint.TabIndex = 11;
		this.btnPrint.Text = "Print";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.btnPrint.Click += new System.EventHandler(btnPrint_Click);
		this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
		this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		this.printPreviewDialog1.Enabled = true;
		this.printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
		this.printPreviewDialog1.Name = "printPreviewDialog1";
		this.printPreviewDialog1.Visible = false;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(461, 364);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(0, 13);
		this.label1.TabIndex = 12;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(497, 268);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.btnClose);
		base.Controls.Add(this.dgvBill);
		base.Name = "frmReview";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Review";
		base.Load += new System.EventHandler(frmReview_Load);
		((System.ComponentModel.ISupportInitialize)this.dgvBill).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(int handle);

	public frmReview(DataTable dtView)
	{
		InitializeComponent();
		this.dtView = dtView;
	}

	private void frmReview_Load(object sender, EventArgs e)
	{
		dgvBill.DataSource = dtView;
		dgvBill.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool DrawText(Graphics target)
	{
		DrawGrid(target);
		if (TotalRow <= 0.0)
		{
			isRestart = true;
			return true;
		}
		return false;
	}

	private void DrawGrid(Graphics e)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			new Pen(Color.Black, 2.5f);
			num = 10;
			num2 = 10;
			for (int i = 0; i < dgvBill.Columns.Count; i++)
			{
				if (dgvBill.Columns[i].Visible)
				{
					e.DrawRectangle(Pens.Black, num, num2, dgvBill.Columns[i].Width, dgvBill.Rows[0].Height);
					e.DrawString(dgvBill.Columns[i].HeaderText, dgvBill.Font, Brushes.Black, new RectangleF(num + 2, num2, dgvBill.Columns[i].Width - 2, dgvBill.Rows[0].Height), stringFormat);
					num += dgvBill.Columns[i].Width;
				}
			}
			num = 10;
			num2 = 10 + dgvBill.Rows[0].Height;
			int num3 = intRow;
			if (TotalRow > 45.0)
			{
				for (int j = num3; j < 45 + num3; j++)
				{
					for (int k = 0; k < dgvBill.Columns.Count; k++)
					{
						if (dgvBill.Columns[k].Visible)
						{
							e.DrawRectangle(Pens.Black, num, num2, dgvBill.Columns[k].Width, dgvBill.Rows[0].Height);
							e.DrawString(dgvBill.Rows[j].Cells[k].Value.ToString(), dgvBill.Font, Brushes.Black, new RectangleF(num + 5, num2, dgvBill.Columns[k].Width - 5, dgvBill.Rows[0].Height), stringFormat);
							num += dgvBill.Columns[k].Width;
						}
					}
					num = 10;
					num2 += dgvBill.Rows[j].Height;
					TotalRow -= 1.0;
					intRow++;
				}
			}
			else
			{
				if (!(0.0 < TotalRow) || !(TotalRow < 45.0))
				{
					return;
				}
				double totalRow = TotalRow;
				for (int l = num3; (double)l < totalRow + (double)num3; l++)
				{
					for (int m = 0; m < dgvBill.Columns.Count; m++)
					{
						if (dgvBill.Columns[m].Visible)
						{
							e.DrawRectangle(Pens.Black, num, num2, dgvBill.Columns[m].Width, dgvBill.Rows[0].Height);
							e.DrawString(dgvBill.Rows[l].Cells[m].Value.ToString(), dgvBill.Font, Brushes.Black, new RectangleF(num + 5, num2, dgvBill.Columns[m].Width - 5, dgvBill.Rows[0].Height), stringFormat);
							num += dgvBill.Columns[m].Width;
						}
					}
					num = 10;
					num2 += dgvBill.Rows[0].Height;
					TotalRow -= 1.0;
					intRow++;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}

	private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		if (isRestart)
		{
			TotalRow = dgvBill.Rows.Count;
			intRow = 0;
			isRestart = false;
		}
		if (DrawText(e.Graphics))
		{
			e.HasMorePages = false;
		}
		else
		{
			e.HasMorePages = true;
		}
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		TotalRow = dgvBill.Rows.Count;
		intRow = 0;
		printPreviewDialog1.Document = printDocument1;
		printPreviewDialog1.ShowDialog();
	}
}
