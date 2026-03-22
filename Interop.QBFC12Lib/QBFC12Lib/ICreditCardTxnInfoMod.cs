using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[Guid("56000773-AAED-4579-AAEE-F65FDAD0766A")]
[TypeLibType(4160)]
public interface ICreditCardTxnInfoMod : IQBBase
{
	[DispId(1)]
	new IObjectType Type
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(4)]
	ICreditCardTxnInputInfoMod CreditCardTxnInputInfoMod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	ICreditCardTxnResultInfoMod CreditCardTxnResultInfoMod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
