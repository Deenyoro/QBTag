using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[Guid("F4041150-1D87-4344-B9A6-02917D0A5714")]
[CoClass(typeof(QBOESessionManagerClass))]
public interface QBOESessionManager : IQBOESessionManager
{
}
