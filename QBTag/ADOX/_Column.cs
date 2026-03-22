using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX;

[ComImport]
[CompilerGenerated]
[DefaultMember("Name")]
[TypeIdentifier]
[Guid("0000061C-0000-0010-8000-00AA006D2EA4")]
public interface _Column
{
	[DispId(0)]
	string Name
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
