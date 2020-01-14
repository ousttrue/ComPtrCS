// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1PrintControl: IUnknown
    {
        static Guid s_uuid = new Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int AddPage(
            ID2D1CommandList commandList,
            D2D_SIZE_F pageSize,
            IStream pagePrintTicketStream,
            out ulong tag1,
            out ulong tag2
        ){
            var fp = GetFunctionPointer(3);
            if(m_AddPageFunc==null) m_AddPageFunc = (AddPageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddPageFunc));
            
            return m_AddPageFunc(m_ptr, commandList!=null ? commandList.Ptr : IntPtr.Zero, pageSize, pagePrintTicketStream!=null ? pagePrintTicketStream.Ptr : IntPtr.Zero, out tag1, out tag2);
        }
        delegate int AddPageFunc(IntPtr self, IntPtr commandList, D2D_SIZE_F pageSize, IntPtr pagePrintTicketStream, out ulong tag1, out ulong tag2);
        AddPageFunc m_AddPageFunc;

        public virtual int Close(
        ){
            var fp = GetFunctionPointer(4);
            if(m_CloseFunc==null) m_CloseFunc = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
            
            return m_CloseFunc(m_ptr);
        }
        delegate int CloseFunc(IntPtr self);
        CloseFunc m_CloseFunc;

    }
}