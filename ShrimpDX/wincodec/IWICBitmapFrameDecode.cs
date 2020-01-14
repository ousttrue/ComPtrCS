// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICBitmapFrameDecode: IWICBitmapSource
    {
        static Guid s_uuid = new Guid("3b16811b-6a43-4ec9-a813-3d930c13b940");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetMetadataQueryReader(
            out IWICMetadataQueryReader ppIMetadataQueryReader
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetMetadataQueryReaderFunc==null) m_GetMetadataQueryReaderFunc = (GetMetadataQueryReaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetadataQueryReaderFunc));
            ppIMetadataQueryReader = new IWICMetadataQueryReader();
            return m_GetMetadataQueryReaderFunc(m_ptr, out ppIMetadataQueryReader.PtrForNew);
        }
        delegate int GetMetadataQueryReaderFunc(IntPtr self, out IntPtr ppIMetadataQueryReader);
        GetMetadataQueryReaderFunc m_GetMetadataQueryReaderFunc;

        public virtual int GetColorContexts(
            uint cCount,
            out IWICColorContext ppIColorContexts,
            out uint pcActualCount
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetColorContextsFunc==null) m_GetColorContextsFunc = (GetColorContextsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorContextsFunc));
            ppIColorContexts = new IWICColorContext();
            return m_GetColorContextsFunc(m_ptr, cCount, out ppIColorContexts.PtrForNew, out pcActualCount);
        }
        delegate int GetColorContextsFunc(IntPtr self, uint cCount, out IntPtr ppIColorContexts, out uint pcActualCount);
        GetColorContextsFunc m_GetColorContextsFunc;

        public virtual int GetThumbnail(
            out IWICBitmapSource ppIThumbnail
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetThumbnailFunc==null) m_GetThumbnailFunc = (GetThumbnailFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetThumbnailFunc));
            ppIThumbnail = new IWICBitmapSource();
            return m_GetThumbnailFunc(m_ptr, out ppIThumbnail.PtrForNew);
        }
        delegate int GetThumbnailFunc(IntPtr self, out IntPtr ppIThumbnail);
        GetThumbnailFunc m_GetThumbnailFunc;

    }
}