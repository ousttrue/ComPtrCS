// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IPrintDocumentPackageStatusEvent: IDispatch
    {
        static Guid s_uuid = new Guid("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int PackageStatusUpdated(
            out __MIDL___MIDL_itf_documenttarget_0000_0001_0001 packageStatus
        ){
            var fp = GetFunctionPointer(7);
            if(m_PackageStatusUpdatedFunc==null) m_PackageStatusUpdatedFunc = (PackageStatusUpdatedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PackageStatusUpdatedFunc));
            
            return m_PackageStatusUpdatedFunc(m_ptr, out packageStatus);
        }
        delegate int PackageStatusUpdatedFunc(IntPtr self, out __MIDL___MIDL_itf_documenttarget_0000_0001_0001 packageStatus);
        PackageStatusUpdatedFunc m_PackageStatusUpdatedFunc;

    }
}