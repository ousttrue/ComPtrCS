// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectVectorVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("62b98c44-1f82-4c67-bcd0-72cf8f217e81");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int SetBoolVector(
            out int pData
        ){
            var fp = GetFunctionPointer(25);
            if(m_SetBoolVectorFunc==null) m_SetBoolVectorFunc = (SetBoolVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBoolVectorFunc));
            
            return m_SetBoolVectorFunc(m_ptr, out pData);
        }
        delegate int SetBoolVectorFunc(IntPtr self, out int pData);
        SetBoolVectorFunc m_SetBoolVectorFunc;

        public virtual int SetIntVector(
            out int pData
        ){
            var fp = GetFunctionPointer(26);
            if(m_SetIntVectorFunc==null) m_SetIntVectorFunc = (SetIntVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIntVectorFunc));
            
            return m_SetIntVectorFunc(m_ptr, out pData);
        }
        delegate int SetIntVectorFunc(IntPtr self, out int pData);
        SetIntVectorFunc m_SetIntVectorFunc;

        public virtual int SetFloatVector(
            out float pData
        ){
            var fp = GetFunctionPointer(27);
            if(m_SetFloatVectorFunc==null) m_SetFloatVectorFunc = (SetFloatVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFloatVectorFunc));
            
            return m_SetFloatVectorFunc(m_ptr, out pData);
        }
        delegate int SetFloatVectorFunc(IntPtr self, out float pData);
        SetFloatVectorFunc m_SetFloatVectorFunc;

        public virtual int GetBoolVector(
            out int pData
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetBoolVectorFunc==null) m_GetBoolVectorFunc = (GetBoolVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoolVectorFunc));
            
            return m_GetBoolVectorFunc(m_ptr, out pData);
        }
        delegate int GetBoolVectorFunc(IntPtr self, out int pData);
        GetBoolVectorFunc m_GetBoolVectorFunc;

        public virtual int GetIntVector(
            out int pData
        ){
            var fp = GetFunctionPointer(29);
            if(m_GetIntVectorFunc==null) m_GetIntVectorFunc = (GetIntVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIntVectorFunc));
            
            return m_GetIntVectorFunc(m_ptr, out pData);
        }
        delegate int GetIntVectorFunc(IntPtr self, out int pData);
        GetIntVectorFunc m_GetIntVectorFunc;

        public virtual int GetFloatVector(
            out float pData
        ){
            var fp = GetFunctionPointer(30);
            if(m_GetFloatVectorFunc==null) m_GetFloatVectorFunc = (GetFloatVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFloatVectorFunc));
            
            return m_GetFloatVectorFunc(m_ptr, out pData);
        }
        delegate int GetFloatVectorFunc(IntPtr self, out float pData);
        GetFloatVectorFunc m_GetFloatVectorFunc;

        public virtual int SetBoolVectorArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(31);
            if(m_SetBoolVectorArrayFunc==null) m_SetBoolVectorArrayFunc = (SetBoolVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBoolVectorArrayFunc));
            
            return m_SetBoolVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetBoolVectorArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        SetBoolVectorArrayFunc m_SetBoolVectorArrayFunc;

        public virtual int SetIntVectorArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(32);
            if(m_SetIntVectorArrayFunc==null) m_SetIntVectorArrayFunc = (SetIntVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIntVectorArrayFunc));
            
            return m_SetIntVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetIntVectorArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        SetIntVectorArrayFunc m_SetIntVectorArrayFunc;

        public virtual int SetFloatVectorArray(
            out float pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(33);
            if(m_SetFloatVectorArrayFunc==null) m_SetFloatVectorArrayFunc = (SetFloatVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFloatVectorArrayFunc));
            
            return m_SetFloatVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int SetFloatVectorArrayFunc(IntPtr self, out float pData, uint Offset, uint Count);
        SetFloatVectorArrayFunc m_SetFloatVectorArrayFunc;

        public virtual int GetBoolVectorArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(34);
            if(m_GetBoolVectorArrayFunc==null) m_GetBoolVectorArrayFunc = (GetBoolVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBoolVectorArrayFunc));
            
            return m_GetBoolVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetBoolVectorArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        GetBoolVectorArrayFunc m_GetBoolVectorArrayFunc;

        public virtual int GetIntVectorArray(
            out int pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(35);
            if(m_GetIntVectorArrayFunc==null) m_GetIntVectorArrayFunc = (GetIntVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIntVectorArrayFunc));
            
            return m_GetIntVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetIntVectorArrayFunc(IntPtr self, out int pData, uint Offset, uint Count);
        GetIntVectorArrayFunc m_GetIntVectorArrayFunc;

        public virtual int GetFloatVectorArray(
            out float pData,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(36);
            if(m_GetFloatVectorArrayFunc==null) m_GetFloatVectorArrayFunc = (GetFloatVectorArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFloatVectorArrayFunc));
            
            return m_GetFloatVectorArrayFunc(m_ptr, out pData, Offset, Count);
        }
        delegate int GetFloatVectorArrayFunc(IntPtr self, out float pData, uint Offset, uint Count);
        GetFloatVectorArrayFunc m_GetFloatVectorArrayFunc;

    }
}