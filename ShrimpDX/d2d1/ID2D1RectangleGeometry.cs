// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1RectangleGeometry: ID2D1Geometry
    {
        static Guid s_uuid = new Guid("2cd906a2-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetRect(
            out System.Numerics.Vector4 rect
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetRectFunc==null) m_GetRectFunc = (GetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRectFunc));
            
            m_GetRectFunc(m_ptr, out rect);
        }
        delegate void GetRectFunc(IntPtr self, out System.Numerics.Vector4 rect);
        GetRectFunc m_GetRectFunc;

    }
}