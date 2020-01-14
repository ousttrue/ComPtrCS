// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11ShaderReflectionVariable: ComPtr
    {
        static Guid s_uuid = new Guid("51f23923-f3e5-4bd1-91cb-606177d8db4c");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetDesc(
            out _D3D11_SHADER_VARIABLE_DESC pDesc
        ){
            var fp = GetFunctionPointer(0);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out _D3D11_SHADER_VARIABLE_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual ID3D11ShaderReflectionType GetComType(
        ){
            var fp = GetFunctionPointer(1);
            if(m_GetTypeFunc==null) m_GetTypeFunc = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
            
            return m_GetTypeFunc(m_ptr);
        }
        delegate ID3D11ShaderReflectionType GetTypeFunc(IntPtr self);
        GetTypeFunc m_GetTypeFunc;

        public virtual ID3D11ShaderReflectionConstantBuffer GetBuffer(
        ){
            var fp = GetFunctionPointer(2);
            if(m_GetBufferFunc==null) m_GetBufferFunc = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
            
            return m_GetBufferFunc(m_ptr);
        }
        delegate ID3D11ShaderReflectionConstantBuffer GetBufferFunc(IntPtr self);
        GetBufferFunc m_GetBufferFunc;

        public virtual uint GetInterfaceSlot(
            uint uArrayIndex
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetInterfaceSlotFunc==null) m_GetInterfaceSlotFunc = (GetInterfaceSlotFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterfaceSlotFunc));
            
            return m_GetInterfaceSlotFunc(m_ptr, uArrayIndex);
        }
        delegate uint GetInterfaceSlotFunc(IntPtr self, uint uArrayIndex);
        GetInterfaceSlotFunc m_GetInterfaceSlotFunc;

    }
}