// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IRecordInfo: IUnknown
    {
        static Guid s_uuid = new Guid("0000002f-0000-0000-c000-000000000046");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int RecordInit(
            IntPtr pvNew
        ){
            var fp = GetFunctionPointer(3);
            if(m_RecordInitFunc==null) m_RecordInitFunc = (RecordInitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordInitFunc));
            
            return m_RecordInitFunc(m_ptr, pvNew);
        }
        delegate int RecordInitFunc(IntPtr self, IntPtr pvNew);
        RecordInitFunc m_RecordInitFunc;

        public virtual int RecordClear(
            IntPtr pvExisting
        ){
            var fp = GetFunctionPointer(4);
            if(m_RecordClearFunc==null) m_RecordClearFunc = (RecordClearFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordClearFunc));
            
            return m_RecordClearFunc(m_ptr, pvExisting);
        }
        delegate int RecordClearFunc(IntPtr self, IntPtr pvExisting);
        RecordClearFunc m_RecordClearFunc;

        public virtual int RecordCopy(
            IntPtr pvExisting,
            IntPtr pvNew
        ){
            var fp = GetFunctionPointer(5);
            if(m_RecordCopyFunc==null) m_RecordCopyFunc = (RecordCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCopyFunc));
            
            return m_RecordCopyFunc(m_ptr, pvExisting, pvNew);
        }
        delegate int RecordCopyFunc(IntPtr self, IntPtr pvExisting, IntPtr pvNew);
        RecordCopyFunc m_RecordCopyFunc;

        public virtual int GetGuid(
            out Guid pguid
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetGuidFunc==null) m_GetGuidFunc = (GetGuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGuidFunc));
            
            return m_GetGuidFunc(m_ptr, out pguid);
        }
        delegate int GetGuidFunc(IntPtr self, out Guid pguid);
        GetGuidFunc m_GetGuidFunc;

        public virtual int GetName(
            out IntPtr pbstrName
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetNameFunc==null) m_GetNameFunc = (GetNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNameFunc));
            
            return m_GetNameFunc(m_ptr, out pbstrName);
        }
        delegate int GetNameFunc(IntPtr self, out IntPtr pbstrName);
        GetNameFunc m_GetNameFunc;

        public virtual int GetSize(
            out uint pcbSize
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetSizeFunc==null) m_GetSizeFunc = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
            
            return m_GetSizeFunc(m_ptr, out pcbSize);
        }
        delegate int GetSizeFunc(IntPtr self, out uint pcbSize);
        GetSizeFunc m_GetSizeFunc;

        public virtual int GetTypeInfo(
            out ITypeInfo ppTypeInfo
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetTypeInfoFunc==null) m_GetTypeInfoFunc = (GetTypeInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeInfoFunc));
            ppTypeInfo = new ITypeInfo();
            return m_GetTypeInfoFunc(m_ptr, out ppTypeInfo.PtrForNew);
        }
        delegate int GetTypeInfoFunc(IntPtr self, out IntPtr ppTypeInfo);
        GetTypeInfoFunc m_GetTypeInfoFunc;

        public virtual int GetField(
            IntPtr pvData,
            ref ushort szFieldName,
            out tagVARIANT pvarField
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetFieldFunc==null) m_GetFieldFunc = (GetFieldFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldFunc));
            
            return m_GetFieldFunc(m_ptr, pvData, ref szFieldName, out pvarField);
        }
        delegate int GetFieldFunc(IntPtr self, IntPtr pvData, ref ushort szFieldName, out tagVARIANT pvarField);
        GetFieldFunc m_GetFieldFunc;

        public virtual int GetFieldNoCopy(
            IntPtr pvData,
            ref ushort szFieldName,
            out tagVARIANT pvarField,
            out IntPtr ppvDataCArray
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetFieldNoCopyFunc==null) m_GetFieldNoCopyFunc = (GetFieldNoCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldNoCopyFunc));
            
            return m_GetFieldNoCopyFunc(m_ptr, pvData, ref szFieldName, out pvarField, out ppvDataCArray);
        }
        delegate int GetFieldNoCopyFunc(IntPtr self, IntPtr pvData, ref ushort szFieldName, out tagVARIANT pvarField, out IntPtr ppvDataCArray);
        GetFieldNoCopyFunc m_GetFieldNoCopyFunc;

        public virtual int PutField(
            uint wFlags,
            IntPtr pvData,
            ref ushort szFieldName,
            out tagVARIANT pvarField
        ){
            var fp = GetFunctionPointer(12);
            if(m_PutFieldFunc==null) m_PutFieldFunc = (PutFieldFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PutFieldFunc));
            
            return m_PutFieldFunc(m_ptr, wFlags, pvData, ref szFieldName, out pvarField);
        }
        delegate int PutFieldFunc(IntPtr self, uint wFlags, IntPtr pvData, ref ushort szFieldName, out tagVARIANT pvarField);
        PutFieldFunc m_PutFieldFunc;

        public virtual int PutFieldNoCopy(
            uint wFlags,
            IntPtr pvData,
            ref ushort szFieldName,
            out tagVARIANT pvarField
        ){
            var fp = GetFunctionPointer(13);
            if(m_PutFieldNoCopyFunc==null) m_PutFieldNoCopyFunc = (PutFieldNoCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PutFieldNoCopyFunc));
            
            return m_PutFieldNoCopyFunc(m_ptr, wFlags, pvData, ref szFieldName, out pvarField);
        }
        delegate int PutFieldNoCopyFunc(IntPtr self, uint wFlags, IntPtr pvData, ref ushort szFieldName, out tagVARIANT pvarField);
        PutFieldNoCopyFunc m_PutFieldNoCopyFunc;

        public virtual int GetFieldNames(
            out uint pcNames,
            out IntPtr rgBstrNames
        ){
            var fp = GetFunctionPointer(14);
            if(m_GetFieldNamesFunc==null) m_GetFieldNamesFunc = (GetFieldNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldNamesFunc));
            
            return m_GetFieldNamesFunc(m_ptr, out pcNames, out rgBstrNames);
        }
        delegate int GetFieldNamesFunc(IntPtr self, out uint pcNames, out IntPtr rgBstrNames);
        GetFieldNamesFunc m_GetFieldNamesFunc;

        public virtual int IsMatchingType(
            IRecordInfo pRecordInfo
        ){
            var fp = GetFunctionPointer(15);
            if(m_IsMatchingTypeFunc==null) m_IsMatchingTypeFunc = (IsMatchingTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsMatchingTypeFunc));
            
            return m_IsMatchingTypeFunc(m_ptr, pRecordInfo!=null ? pRecordInfo.Ptr : IntPtr.Zero);
        }
        delegate int IsMatchingTypeFunc(IntPtr self, IntPtr pRecordInfo);
        IsMatchingTypeFunc m_IsMatchingTypeFunc;

        public virtual IntPtr RecordCreate(
        ){
            var fp = GetFunctionPointer(16);
            if(m_RecordCreateFunc==null) m_RecordCreateFunc = (RecordCreateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCreateFunc));
            
            return m_RecordCreateFunc(m_ptr);
        }
        delegate IntPtr RecordCreateFunc(IntPtr self);
        RecordCreateFunc m_RecordCreateFunc;

        public virtual int RecordCreateCopy(
            IntPtr pvSource,
            out IntPtr ppvDest
        ){
            var fp = GetFunctionPointer(17);
            if(m_RecordCreateCopyFunc==null) m_RecordCreateCopyFunc = (RecordCreateCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCreateCopyFunc));
            
            return m_RecordCreateCopyFunc(m_ptr, pvSource, out ppvDest);
        }
        delegate int RecordCreateCopyFunc(IntPtr self, IntPtr pvSource, out IntPtr ppvDest);
        RecordCreateCopyFunc m_RecordCreateCopyFunc;

        public virtual int RecordDestroy(
            IntPtr pvRecord
        ){
            var fp = GetFunctionPointer(18);
            if(m_RecordDestroyFunc==null) m_RecordDestroyFunc = (RecordDestroyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordDestroyFunc));
            
            return m_RecordDestroyFunc(m_ptr, pvRecord);
        }
        delegate int RecordDestroyFunc(IntPtr self, IntPtr pvRecord);
        RecordDestroyFunc m_RecordDestroyFunc;

    }
}
