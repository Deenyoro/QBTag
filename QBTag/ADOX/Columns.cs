using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX;

[ComImport]
[Guid("0000061D-0000-0010-8000-00AA006D2EA4")]
[CompilerGenerated]
[TypeIdentifier]
public interface Columns : _Collection
{
	void _VtblGap1_3();

	[DispId(0)]
	Column this[[In][MarshalAs(UnmanagedType.Struct)] object Item]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
