using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using QuickBooksModel;

namespace QuickBooksDAL;

public class QRCODESDAL
{
	[DebuggerNonUserCode]
	public QRCODESDAL()
	{
	}

	public List<QrCodes> SelectQrCodes(string conStr)
	{
		OleDbConnection con = DALUTIL.getAccessConnection(conStr);
		OleDbCommand cmd = new OleDbCommand("select * from tblQrCode ORDER BY ProductNumber", con);
		return fetchQrCodes(cmd);
	}

	private List<QrCodes> fetchQrCodes(OleDbCommand cmd)
	{
		OleDbConnection con = cmd.Connection;
		List<QrCodes> QrCodesList = null;
		DALUTIL.OpenAccessConnection(con);
		using (con)
		{
			OleDbDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				QrCodesList = new List<QrCodes>();
				while (dr.Read())
				{
					QrCodes QrCode = new QrCodes();
					QrCode.Link = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["Link"]));
					QrCode.ProductNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["ProductNumber"]));
					QrCode.QrPhoto = RuntimeHelpers.GetObjectValue(dr["QrPhoto"]);
					QrCodesList.Add(QrCode);
				}
				QrCodesList.TrimExcess();
			}
			return QrCodesList;
		}
	}

	public object LoadImage(string path)
	{
		long m_lImageFileLength = 0L;
		FileInfo fiImage = new FileInfo(path);
		m_lImageFileLength = fiImage.Length;
		FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		byte[] m_barrImg = new byte[checked(Convert.ToInt32(m_lImageFileLength) - 1 + 1)];
		int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
		fs.Close();
		return m_barrImg;
	}
}
