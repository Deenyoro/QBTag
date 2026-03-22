using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("00000611-0000-0010-8000-00AA006D2EA4")]
public interface Tables : _Collection
{
	void _VtblGap1_3();

	[DispId(0)]
	Table this[[In][MarshalAs(UnmanagedType.Struct)] object Item]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
