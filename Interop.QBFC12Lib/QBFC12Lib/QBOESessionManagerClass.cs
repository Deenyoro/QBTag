using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[Guid("6527B7E2-930A-4A51-9771-479A19BD201A")]
[ClassInterface((ClassInterfaceType)0)]
[TypeLibType(18)]
public class QBOESessionManagerClass : IQBOESessionManager, QBOESessionManager
{
	[DispId(11)]
	public virtual extern Array QBXMLVersionsForSession
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(11)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
		get;
	}

	[DispId(20)]
	public virtual extern bool EnableErrorRecovery
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
	public virtual extern bool SaveAllMsgSetRequestInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[param: In]
		set;
	}

	[DispId(24)]
	public virtual extern IQBGUIDType ErrorRecoveryID
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(24)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(25)]
	public virtual extern ENConnectionType ConnectionType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(25)]
		get;
	}

	[DispId(27)]
	public virtual extern IQBAuthPreferences QBAuthPreferences
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(27)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(30)]
	public virtual extern Array QBXMLVersionsForSubscription
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(30)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
		get;
	}

	[DispId(31)]
	public virtual extern IQBStringType ApplicationLogin
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(31)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(32)]
	public virtual extern IQBStringType ConnectionTicket
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(32)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(33)]
	public virtual extern IQBIDType InstallationID
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(33)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(34)]
	public virtual extern IQBStringType Language
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(34)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(35)]
	public virtual extern IQBStringType AppID
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(35)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(36)]
	public virtual extern IQBStringType AppVer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(36)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(37)]
	public virtual extern IQBStringType SessionTicket
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(37)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(38)]
	public virtual extern IQBIDType AuthID
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(38)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	public virtual extern void OpenConnection([MarshalAs(UnmanagedType.BStr)] string AppID, [MarshalAs(UnmanagedType.BStr)] string AppName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	public virtual extern void BeginSession([MarshalAs(UnmanagedType.BStr)] string qbFile, ENOpenMode openMode);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	public virtual extern void EndSession();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	public virtual extern void CloseConnection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetCurrentCompanyFileName();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetRequest CreateMsgSetRequest([MarshalAs(UnmanagedType.BStr)] string Country, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetResponse ToMsgSetResponse([MarshalAs(UnmanagedType.BStr)] string qbXMLResponse, [MarshalAs(UnmanagedType.BStr)] string Country, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetResponse DoRequests([MarshalAs(UnmanagedType.Interface)] IMsgSetRequest request);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	public virtual extern void GetVersion(out short MajorVersion, out short MinorVersion, out ENReleaseLevel releaseLevel, out short releaseNumber);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetResponse DoRequestsFromXMLString([MarshalAs(UnmanagedType.BStr)] string qbXMLRequest);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ISubscriptionMsgSetRequest CreateSubscriptionMsgSetRequest(short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ISubscriptionMsgSetResponse ToSubscriptionMsgSetResponse([MarshalAs(UnmanagedType.BStr)] string qbXMLSubscriptionResponse, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ISubscriptionMsgSetResponse DoSubscriptionRequests([MarshalAs(UnmanagedType.Interface)] ISubscriptionMsgSetRequest request);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ISubscriptionMsgSetResponse DoSubscriptionRequestsFromXMLString([MarshalAs(UnmanagedType.BStr)] string qbXMLSubscriptionRequest);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IEventsMsgSet ToEventsMsgSet([MarshalAs(UnmanagedType.BStr)] string qbXMLEventsResponse, short qbXMLMajorVersion, short qbXMLMinorVersion);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetRequest ToMsgSetRequest([MarshalAs(UnmanagedType.BStr)] string qbXMLRequest);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	public virtual extern bool IsErrorRecoveryInfo();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	public virtual extern void ClearErrorRecovery();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetResponse GetErrorRecoveryStatus();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IMsgSetRequest GetSavedMsgSetRequest();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	public virtual extern void OpenConnection2([MarshalAs(UnmanagedType.BStr)] string AppID, [MarshalAs(UnmanagedType.BStr)] string AppName, ENConnectionType connType);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	public virtual extern void CommunicateOutOfProcess([In] bool useOutOfProc);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	public virtual extern void CommunicateOutOfProcessEx([In] bool useOutOfProc, [MarshalAs(UnmanagedType.BStr)] string outOfProcCLSID);
}
