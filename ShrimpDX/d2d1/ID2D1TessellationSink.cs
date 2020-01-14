// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1TessellationSink: IUnknown
    {
        static Guid s_uuid = new Guid("2cd906c1-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void AddTriangles(
            ref D2D1_TRIANGLE triangles,
            uint trianglesCount
        ){
            var fp = GetFunctionPointer(3);
            if(m_AddTrianglesFunc==null) m_AddTrianglesFunc = (AddTrianglesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddTrianglesFunc));
            
            m_AddTrianglesFunc(m_ptr, ref triangles, trianglesCount);
        }
        delegate void AddTrianglesFunc(IntPtr self, ref D2D1_TRIANGLE triangles, uint trianglesCount);
        AddTrianglesFunc m_AddTrianglesFunc;

        public virtual int Close(
        ){
            var fp = GetFunctionPointer(4);
            if(m_CloseFunc==null) m_CloseFunc = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
            
            return m_CloseFunc(m_ptr);
        }
        delegate int CloseFunc(IntPtr self);
        CloseFunc m_CloseFunc;

    }
}