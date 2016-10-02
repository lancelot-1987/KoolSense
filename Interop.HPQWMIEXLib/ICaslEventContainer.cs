// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.ICaslEventContainer
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [Guid("3BC7CF8D-342E-4D94-A705-A762B8921C44")]
  [InterfaceType((short) 1)]
  [TypeLibType((short) 384)]
  [ComImport]
  public interface ICaslEventContainer
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void IsEventSupported([MarshalAs(UnmanagedType.BStr), In] string eventName, out int pbSupported);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Register([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string WindowsEventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SupportedEvents([MarshalAs(UnmanagedType.Struct)] out object pEvents);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Unregister([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string WindowsEventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Notify([MarshalAs(UnmanagedType.Struct), In] object Caller, [MarshalAs(UnmanagedType.Struct), In] object Data);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetData([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string DataValueName, [MarshalAs(UnmanagedType.Struct)] out object pData);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetData([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string DataValueName, [MarshalAs(UnmanagedType.Struct)] object DataValue);
  }
}
