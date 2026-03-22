using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX;

[ComImport]
[DefaultMember("Tables")]
[CompilerGenerated]
[Guid("00000603-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
public interface _Catalog
{
	[DispId(0)]
	Tables Tables
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_7();

	[DispId(6)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Create([In][MarshalAs(UnmanagedType.BStr)] string ConnectString);
}
