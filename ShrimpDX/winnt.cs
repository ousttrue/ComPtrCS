// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;
using HRESULT = System.Int32;

namespace ShrimpDX {
    public static partial class Constants {
    }
    public struct HRESULT { public int Value; }
    public struct LPCSTR { public IntPtr Value; }
    public struct CHAR { public sbyte Value; }
    public struct LPSTR { public IntPtr Value; }
    public struct INT { public int Value; }
    public struct LONG { public int Value; }
    public struct HANDLE { public IntPtr Value; }
    public struct ULONGLONG { public ulong Value; }
    public struct WCHAR { public ushort Value; }
    public struct LARGE_INTEGER { public _LARGE_INTEGER Value; }
    [StructLayout(LayoutKind.Sequential)]
    public struct _LARGE_INTEGER
    {
       // anonymous struct ;
       // anonymous struct ;
       // anonymous struct u;
        public LONGLONG QuadPart;
    }
    // struct nameless
    // struct nameless
    public struct LONGLONG { public long Value; }
    public struct LUID { public _LUID Value; }
    [StructLayout(LayoutKind.Sequential)]
    public struct _LUID
    {
        public DWORD LowPart;
        public LONG HighPart;
    }
    public struct LPCWSTR { public IntPtr Value; }
    public static class winnt {
    }
}