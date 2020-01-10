// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public static partial class WM {
        public const uint _NULL = 0x0000;
        public const uint _CREATE = 0x0001;
        public const uint _DESTROY = 0x0002;
        public const uint _MOVE = 0x0003;
        public const uint _SIZE = 0x0005;
        public const uint _ACTIVATE = 0x0006;
        public const uint _SETFOCUS = 0x0007;
        public const uint _KILLFOCUS = 0x0008;
        public const uint _ENABLE = 0x000A;
        public const uint _SETREDRAW = 0x000B;
        public const uint _SETTEXT = 0x000C;
        public const uint _GETTEXT = 0x000D;
        public const uint _GETTEXTLENGTH = 0x000E;
        public const uint _PAINT = 0x000F;
        public const uint _CLOSE = 0x0010;
        public const uint _QUERYENDSESSION = 0x0011;
        public const uint _QUERYOPEN = 0x0013;
        public const uint _ENDSESSION = 0x0016;
        public const uint _QUIT = 0x0012;
        public const uint _ERASEBKGND = 0x0014;
        public const uint _SYSCOLORCHANGE = 0x0015;
        public const uint _SHOWWINDOW = 0x0018;
        public const uint _WININICHANGE = 0x001A;
        public const uint _SETTINGCHANGE = _WININICHANGE;
        public const uint _DEVMODECHANGE = 0x001B;
        public const uint _ACTIVATEAPP = 0x001C;
        public const uint _FONTCHANGE = 0x001D;
        public const uint _TIMECHANGE = 0x001E;
        public const uint _CANCELMODE = 0x001F;
        public const uint _SETCURSOR = 0x0020;
        public const uint _MOUSEACTIVATE = 0x0021;
        public const uint _CHILDACTIVATE = 0x0022;
        public const uint _QUEUESYNC = 0x0023;
        public const uint _GETMINMAXINFO = 0x0024;
        public const uint _PAINTICON = 0x0026;
        public const uint _ICONERASEBKGND = 0x0027;
        public const uint _NEXTDLGCTL = 0x0028;
        public const uint _SPOOLERSTATUS = 0x002A;
        public const uint _DRAWITEM = 0x002B;
        public const uint _MEASUREITEM = 0x002C;
        public const uint _DELETEITEM = 0x002D;
        public const uint _VKEYTOITEM = 0x002E;
        public const uint _CHARTOITEM = 0x002F;
        public const uint _SETFONT = 0x0030;
        public const uint _GETFONT = 0x0031;
        public const uint _SETHOTKEY = 0x0032;
        public const uint _GETHOTKEY = 0x0033;
        public const uint _QUERYDRAGICON = 0x0037;
        public const uint _COMPAREITEM = 0x0039;
        public const uint _GETOBJECT = 0x003D;
        public const uint _COMPACTING = 0x0041;
        public const uint _COMMNOTIFY = 0x0044;
        public const uint _WINDOWPOSCHANGING = 0x0046;
        public const uint _WINDOWPOSCHANGED = 0x0047;
        public const uint _POWER = 0x0048;
        public const uint _COPYDATA = 0x004A;
        public const uint _CANCELJOURNAL = 0x004B;
        public const uint _NOTIFY = 0x004E;
        public const uint _INPUTLANGCHANGEREQUEST = 0x0050;
        public const uint _INPUTLANGCHANGE = 0x0051;
        public const uint _TCARD = 0x0052;
        public const uint _HELP = 0x0053;
        public const uint _USERCHANGED = 0x0054;
        public const uint _NOTIFYFORMAT = 0x0055;
        public const uint _CONTEXTMENU = 0x007B;
        public const uint _STYLECHANGING = 0x007C;
        public const uint _STYLECHANGED = 0x007D;
        public const uint _DISPLAYCHANGE = 0x007E;
        public const uint _GETICON = 0x007F;
        public const uint _SETICON = 0x0080;
        public const uint _NCCREATE = 0x0081;
        public const uint _NCDESTROY = 0x0082;
        public const uint _NCCALCSIZE = 0x0083;
        public const uint _NCHITTEST = 0x0084;
        public const uint _NCPAINT = 0x0085;
        public const uint _NCACTIVATE = 0x0086;
        public const uint _GETDLGCODE = 0x0087;
        public const uint _SYNCPAINT = 0x0088;
        public const uint _NCMOUSEMOVE = 0x00A0;
        public const uint _NCLBUTTONDOWN = 0x00A1;
        public const uint _NCLBUTTONUP = 0x00A2;
        public const uint _NCLBUTTONDBLCLK = 0x00A3;
        public const uint _NCRBUTTONDOWN = 0x00A4;
        public const uint _NCRBUTTONUP = 0x00A5;
        public const uint _NCRBUTTONDBLCLK = 0x00A6;
        public const uint _NCMBUTTONDOWN = 0x00A7;
        public const uint _NCMBUTTONUP = 0x00A8;
        public const uint _NCMBUTTONDBLCLK = 0x00A9;
        public const uint _NCXBUTTONDOWN = 0x00AB;
        public const uint _NCXBUTTONUP = 0x00AC;
        public const uint _NCXBUTTONDBLCLK = 0x00AD;
        public const uint _INPUT_DEVICE_CHANGE = 0x00FE;
        public const uint _INPUT = 0x00FF;
        public const uint _KEYFIRST = 0x0100;
        public const uint _KEYDOWN = 0x0100;
        public const uint _KEYUP = 0x0101;
        public const uint _CHAR = 0x0102;
        public const uint _DEADCHAR = 0x0103;
        public const uint _SYSKEYDOWN = 0x0104;
        public const uint _SYSKEYUP = 0x0105;
        public const uint _SYSCHAR = 0x0106;
        public const uint _SYSDEADCHAR = 0x0107;
        public const uint _UNICHAR = 0x0109;
        public const uint _KEYLAST = 0x0109;
        public const uint _IME_STARTCOMPOSITION = 0x010D;
        public const uint _IME_ENDCOMPOSITION = 0x010E;
        public const uint _IME_COMPOSITION = 0x010F;
        public const uint _IME_KEYLAST = 0x010F;
        public const uint _INITDIALOG = 0x0110;
        public const uint _COMMAND = 0x0111;
        public const uint _SYSCOMMAND = 0x0112;
        public const uint _TIMER = 0x0113;
        public const uint _HSCROLL = 0x0114;
        public const uint _VSCROLL = 0x0115;
        public const uint _INITMENU = 0x0116;
        public const uint _INITMENUPOPUP = 0x0117;
        public const uint _GESTURE = 0x0119;
        public const uint _GESTURENOTIFY = 0x011A;
        public const uint _MENUSELECT = 0x011F;
        public const uint _MENUCHAR = 0x0120;
        public const uint _ENTERIDLE = 0x0121;
        public const uint _MENURBUTTONUP = 0x0122;
        public const uint _MENUDRAG = 0x0123;
        public const uint _MENUGETOBJECT = 0x0124;
        public const uint _UNINITMENUPOPUP = 0x0125;
        public const uint _MENUCOMMAND = 0x0126;
        public const uint _CHANGEUISTATE = 0x0127;
        public const uint _UPDATEUISTATE = 0x0128;
        public const uint _QUERYUISTATE = 0x0129;
        public const uint _CTLCOLORMSGBOX = 0x0132;
        public const uint _CTLCOLOREDIT = 0x0133;
        public const uint _CTLCOLORLISTBOX = 0x0134;
        public const uint _CTLCOLORBTN = 0x0135;
        public const uint _CTLCOLORDLG = 0x0136;
        public const uint _CTLCOLORSCROLLBAR = 0x0137;
        public const uint _CTLCOLORSTATIC = 0x0138;
        public const uint _MOUSEFIRST = 0x0200;
        public const uint _MOUSEMOVE = 0x0200;
        public const uint _LBUTTONDOWN = 0x0201;
        public const uint _LBUTTONUP = 0x0202;
        public const uint _LBUTTONDBLCLK = 0x0203;
        public const uint _RBUTTONDOWN = 0x0204;
        public const uint _RBUTTONUP = 0x0205;
        public const uint _RBUTTONDBLCLK = 0x0206;
        public const uint _MBUTTONDOWN = 0x0207;
        public const uint _MBUTTONUP = 0x0208;
        public const uint _MBUTTONDBLCLK = 0x0209;
        public const uint _MOUSEWHEEL = 0x020A;
        public const uint _XBUTTONDOWN = 0x020B;
        public const uint _XBUTTONUP = 0x020C;
        public const uint _XBUTTONDBLCLK = 0x020D;
        public const uint _MOUSEHWHEEL = 0x020E;
        public const uint _MOUSELAST = 0x020E;
        public const uint _PARENTNOTIFY = 0x0210;
        public const uint _ENTERMENULOOP = 0x0211;
        public const uint _EXITMENULOOP = 0x0212;
        public const uint _NEXTMENU = 0x0213;
        public const uint _SIZING = 0x0214;
        public const uint _CAPTURECHANGED = 0x0215;
        public const uint _MOVING = 0x0216;
        public const uint _POWERBROADCAST = 0x0218;
        public const uint _DEVICECHANGE = 0x0219;
        public const uint _MDICREATE = 0x0220;
        public const uint _MDIDESTROY = 0x0221;
        public const uint _MDIACTIVATE = 0x0222;
        public const uint _MDIRESTORE = 0x0223;
        public const uint _MDINEXT = 0x0224;
        public const uint _MDIMAXIMIZE = 0x0225;
        public const uint _MDITILE = 0x0226;
        public const uint _MDICASCADE = 0x0227;
        public const uint _MDIICONARRANGE = 0x0228;
        public const uint _MDIGETACTIVE = 0x0229;
        public const uint _MDISETMENU = 0x0230;
        public const uint _ENTERSIZEMOVE = 0x0231;
        public const uint _EXITSIZEMOVE = 0x0232;
        public const uint _DROPFILES = 0x0233;
        public const uint _MDIREFRESHMENU = 0x0234;
        public const uint _POINTERDEVICECHANGE = 0x238;
        public const uint _POINTERDEVICEINRANGE = 0x239;
        public const uint _POINTERDEVICEOUTOFRANGE = 0x23A;
        public const uint _TOUCH = 0x0240;
        public const uint _NCPOINTERUPDATE = 0x0241;
        public const uint _NCPOINTERDOWN = 0x0242;
        public const uint _NCPOINTERUP = 0x0243;
        public const uint _POINTERUPDATE = 0x0245;
        public const uint _POINTERDOWN = 0x0246;
        public const uint _POINTERUP = 0x0247;
        public const uint _POINTERENTER = 0x0249;
        public const uint _POINTERLEAVE = 0x024A;
        public const uint _POINTERACTIVATE = 0x024B;
        public const uint _POINTERCAPTURECHANGED = 0x024C;
        public const uint _TOUCHHITTESTING = 0x024D;
        public const uint _POINTERWHEEL = 0x024E;
        public const uint _POINTERHWHEEL = 0x024F;
        public const uint _POINTERROUTEDTO = 0x0251;
        public const uint _POINTERROUTEDAWAY = 0x0252;
        public const uint _POINTERROUTEDRELEASED = 0x0253;
        public const uint _IME_SETCONTEXT = 0x0281;
        public const uint _IME_NOTIFY = 0x0282;
        public const uint _IME_CONTROL = 0x0283;
        public const uint _IME_COMPOSITIONFULL = 0x0284;
        public const uint _IME_SELECT = 0x0285;
        public const uint _IME_CHAR = 0x0286;
        public const uint _IME_REQUEST = 0x0288;
        public const uint _IME_KEYDOWN = 0x0290;
        public const uint _IME_KEYUP = 0x0291;
        public const uint _MOUSEHOVER = 0x02A1;
        public const uint _MOUSELEAVE = 0x02A3;
        public const uint _NCMOUSEHOVER = 0x02A0;
        public const uint _NCMOUSELEAVE = 0x02A2;
        public const uint _WTSSESSION_CHANGE = 0x02B1;
        public const uint _TABLET_FIRST = 0x02c0;
        public const uint _TABLET_LAST = 0x02df;
        public const uint _DPICHANGED = 0x02E0;
        public const uint _DPICHANGED_BEFOREPARENT = 0x02E2;
        public const uint _DPICHANGED_AFTERPARENT = 0x02E3;
        public const uint _GETDPISCALEDSIZE = 0x02E4;
        public const uint _CUT = 0x0300;
        public const uint _COPY = 0x0301;
        public const uint _PASTE = 0x0302;
        public const uint _CLEAR = 0x0303;
        public const uint _UNDO = 0x0304;
        public const uint _RENDERFORMAT = 0x0305;
        public const uint _RENDERALLFORMATS = 0x0306;
        public const uint _DESTROYCLIPBOARD = 0x0307;
        public const uint _DRAWCLIPBOARD = 0x0308;
        public const uint _PAINTCLIPBOARD = 0x0309;
        public const uint _VSCROLLCLIPBOARD = 0x030A;
        public const uint _SIZECLIPBOARD = 0x030B;
        public const uint _ASKCBFORMATNAME = 0x030C;
        public const uint _CHANGECBCHAIN = 0x030D;
        public const uint _HSCROLLCLIPBOARD = 0x030E;
        public const uint _QUERYNEWPALETTE = 0x030F;
        public const uint _PALETTEISCHANGING = 0x0310;
        public const uint _PALETTECHANGED = 0x0311;
        public const uint _HOTKEY = 0x0312;
        public const uint _PRINT = 0x0317;
        public const uint _PRINTCLIENT = 0x0318;
        public const uint _APPCOMMAND = 0x0319;
        public const uint _THEMECHANGED = 0x031A;
        public const uint _CLIPBOARDUPDATE = 0x031D;
        public const uint _DWMCOMPOSITIONCHANGED = 0x031E;
        public const uint _DWMNCRENDERINGCHANGED = 0x031F;
        public const uint _DWMCOLORIZATIONCOLORCHANGED = 0x0320;
        public const uint _DWMWINDOWMAXIMIZEDCHANGE = 0x0321;
        public const uint _DWMSENDICONICTHUMBNAIL = 0x0323;
        public const uint _DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;
        public const uint _GETTITLEBARINFOEX = 0x033F;
        public const uint _HANDHELDFIRST = 0x0358;
        public const uint _HANDHELDLAST = 0x035F;
        public const uint _AFXFIRST = 0x0360;
        public const uint _AFXLAST = 0x037F;
        public const uint _PENWINFIRST = 0x0380;
        public const uint _PENWINLAST = 0x038F;
        public const uint _APP = 0x8000;
        public const uint _USER = 0x0400;
    }
}
