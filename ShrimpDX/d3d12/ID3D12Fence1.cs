// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Fence1: ID3D12Fence
    {
        static Guid s_uuid = new Guid("433685fe-e22b-4ca0-a8db-b5b4f4dd0e4a");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual D3D12_FENCE_FLAGS GetCreationFlags(
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetCreationFlagsFunc==null) m_GetCreationFlagsFunc = (GetCreationFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationFlagsFunc));
            
            return m_GetCreationFlagsFunc(m_ptr);
        }
        delegate D3D12_FENCE_FLAGS GetCreationFlagsFunc(IntPtr self);
        GetCreationFlagsFunc m_GetCreationFlagsFunc;

    }
}
