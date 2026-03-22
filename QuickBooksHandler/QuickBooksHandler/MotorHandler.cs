using System.Collections.Generic;
using System.Diagnostics;
using QuickBooksDAL;
using QuickBooksModel;

namespace QuickBooksHandler;

public class MotorHandler
{
	[DebuggerNonUserCode]
	public MotorHandler()
	{
	}

	public List<Motor> GetMotors(string ReferenceNumber, string conStr)
	{
		return new MOTORDAL().SelectMotors(ReferenceNumber, conStr);
	}
}
