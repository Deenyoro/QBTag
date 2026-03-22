using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[TypeLibType(4160)]
[Guid("52869B13-F977-4BE1-AB39-26FF7951CD2D")]
public interface IResponseType : IObjectType
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	new short GetValue();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetAsString();
}
