using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics
{
    public struct WorkUnit256<T> where T:unmanaged
    {
        public WorkUnitFlags Flags { get; set; }
        public Vector256<T> Vector { get; set; }
    }
}