using System.Runtime.InteropServices;

namespace QBFC12Lib;

[ComImport]
[CoClass(typeof(QBSessionManagerClass))]
[Guid("7C3E5148-601E-478F-9470-A39240522AE5")]
public interface QBSessionManager : IQBSessionManager
{
}
