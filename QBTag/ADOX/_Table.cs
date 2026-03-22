using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX;

[ComImport]
[CompilerGenerated]
[Guid("00000610-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
[DefaultMember("Columns")]
public interface _Table
{
	[DispId(0)]
	Columns Columns
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
