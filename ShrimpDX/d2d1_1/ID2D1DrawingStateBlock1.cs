// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1DrawingStateBlock1: ID2D1DrawingStateBlock
    {
        static Guid s_uuid = new Guid("689f1f85-c72e-4e33-8f19-85754efd5ace");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetDescription(
            out D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDescriptionFunc==null) m_GetDescriptionFunc = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
            
            m_GetDescriptionFunc(m_ptr, out stateDescription);
        }
        delegate void GetDescriptionFunc(IntPtr self, out D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
        GetDescriptionFunc m_GetDescriptionFunc;

        public virtual void SetDescription(
            ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription
        ){
            var fp = GetFunctionPointer(9);
            if(m_SetDescriptionFunc==null) m_SetDescriptionFunc = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
            
            m_SetDescriptionFunc(m_ptr, ref stateDescription);
        }
        delegate void SetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
        SetDescriptionFunc m_SetDescriptionFunc;

    }
}