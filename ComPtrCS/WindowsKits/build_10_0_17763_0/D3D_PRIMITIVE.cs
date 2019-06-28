/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D_PRIMITIVE {
    UNDEFINED = 0x00000000,
    POINT = 0x00000001,
    LINE = 0x00000002,
    TRIANGLE = 0x00000003,
    LINE_ADJ = 0x00000006,
    TRIANGLE_ADJ = 0x00000007,
    _1_CONTROL_POINT_PATCH = 0x00000008,
    _2_CONTROL_POINT_PATCH = 0x00000009,
    _3_CONTROL_POINT_PATCH = 0x0000000a,
    _4_CONTROL_POINT_PATCH = 0x0000000b,
    _5_CONTROL_POINT_PATCH = 0x0000000c,
    _6_CONTROL_POINT_PATCH = 0x0000000d,
    _7_CONTROL_POINT_PATCH = 0x0000000e,
    _8_CONTROL_POINT_PATCH = 0x0000000f,
    _9_CONTROL_POINT_PATCH = 0x00000010,
    _10_CONTROL_POINT_PATCH = 0x00000011,
    _11_CONTROL_POINT_PATCH = 0x00000012,
    _12_CONTROL_POINT_PATCH = 0x00000013,
    _13_CONTROL_POINT_PATCH = 0x00000014,
    _14_CONTROL_POINT_PATCH = 0x00000015,
    _15_CONTROL_POINT_PATCH = 0x00000016,
    _16_CONTROL_POINT_PATCH = 0x00000017,
    _17_CONTROL_POINT_PATCH = 0x00000018,
    _18_CONTROL_POINT_PATCH = 0x00000019,
    _19_CONTROL_POINT_PATCH = 0x0000001a,
    _20_CONTROL_POINT_PATCH = 0x0000001b,
    _21_CONTROL_POINT_PATCH = 0x0000001c,
    _22_CONTROL_POINT_PATCH = 0x0000001d,
    _23_CONTROL_POINT_PATCH = 0x0000001e,
    _24_CONTROL_POINT_PATCH = 0x0000001f,
    _25_CONTROL_POINT_PATCH = 0x00000020,
    _26_CONTROL_POINT_PATCH = 0x00000021,
    _27_CONTROL_POINT_PATCH = 0x00000022,
    _28_CONTROL_POINT_PATCH = 0x00000023,
    _29_CONTROL_POINT_PATCH = 0x00000024,
    _30_CONTROL_POINT_PATCH = 0x00000025,
    _31_CONTROL_POINT_PATCH = 0x00000026,
    _32_CONTROL_POINT_PATCH = 0x00000027,
    D3D10_PRIMITIVE_UNDEFINED = 0x00000000,
    D3D10_PRIMITIVE_POINT = 0x00000001,
    D3D10_PRIMITIVE_LINE = 0x00000002,
    D3D10_PRIMITIVE_TRIANGLE = 0x00000003,
    D3D10_PRIMITIVE_LINE_ADJ = 0x00000006,
    D3D10_PRIMITIVE_TRIANGLE_ADJ = 0x00000007,
    D3D11_PRIMITIVE_UNDEFINED = 0x00000000,
    D3D11_PRIMITIVE_POINT = 0x00000001,
    D3D11_PRIMITIVE_LINE = 0x00000002,
    D3D11_PRIMITIVE_TRIANGLE = 0x00000003,
    D3D11_PRIMITIVE_LINE_ADJ = 0x00000006,
    D3D11_PRIMITIVE_TRIANGLE_ADJ = 0x00000007,
    D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH = 0x00000008,
    D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH = 0x00000009,
    D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH = 0x0000000a,
    D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH = 0x0000000b,
    D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH = 0x0000000c,
    D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH = 0x0000000d,
    D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH = 0x0000000e,
    D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH = 0x0000000f,
    D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH = 0x00000010,
    D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH = 0x00000011,
    D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH = 0x00000012,
    D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH = 0x00000013,
    D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH = 0x00000014,
    D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH = 0x00000015,
    D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH = 0x00000016,
    D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH = 0x00000017,
    D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH = 0x00000018,
    D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH = 0x00000019,
    D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH = 0x0000001a,
    D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH = 0x0000001b,
    D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH = 0x0000001c,
    D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH = 0x0000001d,
    D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH = 0x0000001e,
    D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH = 0x0000001f,
    D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH = 0x00000020,
    D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH = 0x00000021,
    D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH = 0x00000022,
    D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH = 0x00000023,
    D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH = 0x00000024,
    D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH = 0x00000025,
    D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH = 0x00000026,
    D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH = 0x00000027,
}
}