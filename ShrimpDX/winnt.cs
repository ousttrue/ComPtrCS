// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Sequential)]
    public struct _LARGE_INTEGER__anonymous_2 // 1
    {
        public uint LowPart;
        public int HighPart;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _LARGE_INTEGER__anonymous_3 // 2
    {
        public uint LowPart;
        public int HighPart;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER // 1
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER__anonymous_2 __param__1;
        [FieldOffset(0)]
        public _LARGE_INTEGER__anonymous_3 __param__2;
        [FieldOffset(0)]
        public _LARGE_INTEGER__anonymous_3 u;
        [FieldOffset(0)]
        public long QuadPart;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct LUID // 2
    {
        public uint LowPart;
        public int HighPart;
    }
    public struct LPCWSTR { public IntPtr Value; } // 935
}
