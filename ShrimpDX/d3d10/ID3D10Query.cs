// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10Query: ID3D10Asynchronous
    {
        static Guid s_uuid = new Guid("9b7e4c0e-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetDesc(
            out D3D10_QUERY_DESC pDesc
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate void GetDescFunc(IntPtr self, out D3D10_QUERY_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}