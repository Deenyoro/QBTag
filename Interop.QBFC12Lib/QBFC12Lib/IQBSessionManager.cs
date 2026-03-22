using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[Guid("7C3E5148-601E-478F-9470-A39240522AE5")]
[TypeLibType(4160)]
public interface IQBSessionManager
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	void OpenConnection([MarshalAs(UnmanagedType.BStr)] string AppID, [MarshalAs(UnmanagedType.BStr)] string AppName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	void BeginSession([MarshalAs(UnmanagedType.BStr)] string qbFile, ENOpenMode openMode);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	void EndSession();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	void CloseConnection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCurrentCompanyFileName();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetRequest CreateMsgSetRequest([MarshalAs(UnmanagedType.BStr)] string Country, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetResponse ToMsgSetResponse([MarshalAs(UnmanagedType.BStr)] string qbXMLResponse, [MarshalAs(UnmanagedType.BStr)] string Country, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetResponse DoRequests([MarshalAs(UnmanagedType.Interface)] IMsgSetRequest request);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	void GetVersion(out short MajorVersion, out short MinorVersion, out ENReleaseLevel releaseLevel, out short releaseNumber);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetResponse DoRequestsFromXMLString([MarshalAs(UnmanagedType.BStr)] string qbXMLRequest);

	[DispId(11)]
	Array QBXMLVersionsForSession
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(11)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISubscriptionMsgSetRequest CreateSubscriptionMsgSetRequest(short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISubscriptionMsgSetResponse ToSubscriptionMsgSetResponse([MarshalAs(UnmanagedType.BStr)] string qbXMLSubscriptionResponse, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISubscriptionMsgSetResponse DoSubscriptionRequests([MarshalAs(UnmanagedType.Interface)] ISubscriptionMsgSetRequest request);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISubscriptionMsgSetResponse DoSubscriptionRequestsFromXMLString([MarshalAs(UnmanagedType.BStr)] string qbXMLSubscriptionRequest);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEventsMsgSet ToEventsMsgSet([MarshalAs(UnmanagedType.BStr)] string qbXMLEventsResponse, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetRequest ToMsgSetRequest([MarshalAs(UnmanagedType.BStr)] string qbXMLRequest);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	bool IsErrorRecoveryInfo();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	void ClearErrorRecovery();

	[DispId(20)]
	bool EnableErrorRecovery
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		[param: In]
		set;
	}

	[DispId(21)]
	bool SaveAllMsgSetRequestInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetResponse GetErrorRecoveryStatus();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsgSetRequest GetSavedMsgSetRequest();

	[DispId(24)]
	IQBGUIDType ErrorRecoveryID
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(24)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(25)]
	ENConnectionType ConnectionType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(25)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	void OpenConnection2([MarshalAs(UnmanagedType.BStr)] string AppID, [MarshalAs(UnmanagedType.BStr)] string AppName, ENConnectionType connType);

	[DispId(27)]
	IQBAuthPreferences QBAuthPreferences
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(27)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	void CommunicateOutOfProcess([In] bool useOutOfProc);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	void CommunicateOutOfProcessEx([In] bool useOutOfProc, [MarshalAs(UnmanagedType.BStr)] string outOfProcCLSID);

	[DispId(30)]
	Array QBXMLVersionsForSubscription
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(30)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
		get;
	}
}
