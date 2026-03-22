using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class QrCodesHandler
{
	[DebuggerNonUserCode]
	public QrCodesHandler()
	{
	}

	public List<QrCodes> GetQRCodes(string conStr)
	{
		return new QRCODESDAL().SelectQrCodes(conStr);
	}
}
