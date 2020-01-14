// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectScalarVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("00e48f7b-d2c8-49e8-a86c-022dee53431f");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int SetFloat(
            float Value
        ){
            var fp = GetFunctionPointer(25);
            if(m_SetFloatFunc==null) m_SetFloatFunc = (SetFloatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFloatFunc));
            
            return m_SetFloatFunc(m_ptr, Value);
        }
        delegate int SetFloatFunc(IntPtr self, float Value);
        SetFloatFunc m_SetFloatFunc;

        public virtual int GetFloat(
            out float pValue
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetFloatFunc==null) m_GetFloatFunc = (GetFloatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFloatFunc));
            
            return m_GetFloatFunc(m_ptr, out pValue);
        }
        delegate int GetFloatFunc(IntPtr self, out float pValue);
        GetFloatFunc m_GetFloatFunc;

        public virtual int SetFloatArray(
            out float pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(27);
            if(m_SetFloatArrayFunc==null) m_SetFloatArrayFunc = (SetFloatArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFloatArrayFunc));
            
            return m_SetFloatArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetFloatArrayFunc(IntPtr self, out float pData, uint Offset, uint Count);
        SetFloatArrayFunc m_SetFloatArrayFunc;

        public virtual int GetFloatArray(
            out float pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetFloatArrayFunc==null) m_GetFloatArrayFunc = (GetFloatArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFloatArrayFunc));
            
            return m_GetFloatArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetFloatArrayFunc(IntPtr self, out float pData, uint Offset, uint Count);
        GetFloatArrayFunc m_GetFloatArrayFunc;

        public virtual int SetInt(
            int Value
        ){
            var fp = GetFunctionPointer(29);
            if(m_SetIntFunc==null) m_SetIntFunc = (SetIntFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIntFunc));
            
            return m_SetIntFunc(m_ptr, Value);
        }
        delegate int SetIntFunc(IntPtr self, int Value);
        SetIntFunc m_SetIntFunc;

        public virtual int GetInt(
            out int pValue
        ){
            var fp = GetFunctionPointer(30);
            if(m_GetIntFunc==null) m_GetIntFunc = (GetIntFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIntFunc));
            
            return m_GetIntFunc(m_ptr, out pValue);
        }
        delegate int GetIntFunc(IntPtr self, out int pValue);
        GetIntFunc m_GetIntFunc;

        public virtual int SetIntArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(31);
            if(m_SetIntArrayFunc==null) m_SetIntArrayFunc = (SetIntArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIntArrayFunc));
            
            return m_SetIntArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetIntArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        SetIntArrayFunc m_SetIntArrayFunc;

        public virtual int GetIntArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(32);
            if(m_GetIntArrayFunc==null) m_GetIntArrayFunc = (GetIntArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIntArrayFunc));
            
            return m_GetIntArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetIntArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        GetIntArrayFunc m_GetIntArrayFunc;

        public virtual int SetBool(
            int Value
        ){
            var fp = GetFunctionPointer(33);
            if(m_SetBoolFunc==null) m_SetBoolFunc = (SetBoolFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBoolFunc));
            
            return m_SetBoolFunc(m_ptr, Value);
        }
        delegate int SetBoolFunc(IntPtr self, int Value);
        SetBoolFunc m_SetBoolFunc;

        public virtual int GetBool(
            out int pValue
        ){
            var fp = GetFunctionPointer(34);
            if(m_GetBoolFunc==null) m_GetBoolFunc = (GetBoolFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoolFunc));
            
            return m_GetBoolFunc(m_ptr, out pValue);
        }
        delegate int GetBoolFunc(IntPtr self, out int pValue);
        GetBoolFunc m_GetBoolFunc;

        public virtual int SetBoolArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(35);
            if(m_SetBoolArrayFunc==null) m_SetBoolArrayFunc = (SetBoolArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBoolArrayFunc));
            
            return m_SetBoolArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetBoolArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        SetBoolArrayFunc m_SetBoolArrayFunc;

        public virtual int GetBoolArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(36);
            if(m_GetBoolArrayFunc==null) m_GetBoolArrayFunc = (GetBoolArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoolArrayFunc));
            
            return m_GetBoolArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetBoolArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        GetBoolArrayFunc m_GetBoolArrayFunc;

    }
}