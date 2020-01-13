// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IPropertyBag2: IUnknown
    {
        static Guid s_uuid = new Guid("22f55882-280b-11d0-a8a9-00a0c90c2004");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Read(
            uint cProperties,
            out tagPROPBAG2 pPropBag,
            IErrorLog pErrLog,
            out tagVARIANT pvarValue,
            out int phrError
        ){
            var fp = GetFunctionPointer(3);
            var callback = (ReadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFunc));
            
            return callback(m_ptr, cProperties, out pPropBag, pErrLog!=null ? pErrLog.Ptr : IntPtr.Zero, out pvarValue, out phrError);
        }
        delegate int ReadFunc(IntPtr self, uint cProperties, out tagPROPBAG2 pPropBag, IntPtr pErrLog, out tagVARIANT pvarValue, out int phrError);

        public virtual int Write(
            uint cProperties,
            out tagPROPBAG2 pPropBag,
            out tagVARIANT pvarValue
        ){
            var fp = GetFunctionPointer(4);
            var callback = (WriteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteFunc));
            
            return callback(m_ptr, cProperties, out pPropBag, out pvarValue);
        }
        delegate int WriteFunc(IntPtr self, uint cProperties, out tagPROPBAG2 pPropBag, out tagVARIANT pvarValue);

        public virtual int CountProperties(
            out uint pcProperties
        ){
            var fp = GetFunctionPointer(5);
            var callback = (CountPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CountPropertiesFunc));
            
            return callback(m_ptr, out pcProperties);
        }
        delegate int CountPropertiesFunc(IntPtr self, out uint pcProperties);

        public virtual int GetPropertyInfo(
            uint iProperty,
            uint cProperties,
            out tagPROPBAG2 pPropBag,
            out uint pcProperties
        ){
            var fp = GetFunctionPointer(6);
            var callback = (GetPropertyInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyInfoFunc));
            
            return callback(m_ptr, iProperty, cProperties, out pPropBag, out pcProperties);
        }
        delegate int GetPropertyInfoFunc(IntPtr self, uint iProperty, uint cProperties, out tagPROPBAG2 pPropBag, out uint pcProperties);

        public virtual int LoadObject(
            ref ushort pstrName,
            uint dwHint,
            IUnknown pUnkObject,
            IErrorLog pErrLog
        ){
            var fp = GetFunctionPointer(7);
            var callback = (LoadObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadObjectFunc));
            
            return callback(m_ptr, ref pstrName, dwHint, pUnkObject!=null ? pUnkObject.Ptr : IntPtr.Zero, pErrLog!=null ? pErrLog.Ptr : IntPtr.Zero);
        }
        delegate int LoadObjectFunc(IntPtr self, ref ushort pstrName, uint dwHint, IntPtr pUnkObject, IntPtr pErrLog);

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPROPBAG2 // 1
    {
        public uint dwType;
        public ushort vt;
        public ushort cfType;
        public uint dwHint;
        public IntPtr pstrName;
        public Guid clsid;
    }
}