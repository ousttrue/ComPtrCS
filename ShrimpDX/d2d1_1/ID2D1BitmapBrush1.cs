// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1BitmapBrush1: ID2D1BitmapBrush
    {
        static Guid s_uuid = new Guid("41343a53-e41a-49a2-91cd-21793bbb62e5");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void SetInterpolationMode1(
            D2D1_INTERPOLATION_MODE interpolationMode
        ){
            var fp = GetFunctionPointer(16);
            if(m_SetInterpolationMode1Func==null) m_SetInterpolationMode1Func = (SetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationMode1Func));
            
            m_SetInterpolationMode1Func(m_ptr, interpolationMode);
        }
        delegate void SetInterpolationMode1Func(IntPtr self, D2D1_INTERPOLATION_MODE interpolationMode);
        SetInterpolationMode1Func m_SetInterpolationMode1Func;

        public virtual D2D1_INTERPOLATION_MODE GetInterpolationMode1(
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetInterpolationMode1Func==null) m_GetInterpolationMode1Func = (GetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationMode1Func));
            
            return m_GetInterpolationMode1Func(m_ptr);
        }
        delegate D2D1_INTERPOLATION_MODE GetInterpolationMode1Func(IntPtr self);
        GetInterpolationMode1Func m_GetInterpolationMode1Func;

    }
}