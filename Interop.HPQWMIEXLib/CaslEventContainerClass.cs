// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.CaslEventContainerClass
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [TypeLibType((short) 2)]
  [Guid("69D77689-DA2B-4308-8404-2614CBF9896E")]
  [ClassInterface((short) 0)]
  [ComSourceInterfaces("HPQWMIEXLib._ICaslEventContainerEvents\0\0")]
  [ComImport]
  public abstract class CaslEventContainerClass : ICaslEventContainer, CaslEventContainer, _ICaslEventContainerEvents_Event
  {
      


        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void IsEventSupported([MarshalAs(UnmanagedType.BStr), In] string eventName, out int pbSupported);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void Register([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string WindowsEventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void SupportedEvents([MarshalAs(UnmanagedType.Struct)] out object pEvents);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void Unregister([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string WindowsEventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void Notify([MarshalAs(UnmanagedType.Struct), In] object Caller, [MarshalAs(UnmanagedType.Struct), In] object Data);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void GetData([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string DataValueName, [MarshalAs(UnmanagedType.Struct)] out object pData);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void SetData([MarshalAs(UnmanagedType.BStr), In] string eventName, [MarshalAs(UnmanagedType.BStr), In] string DataValueName, [MarshalAs(UnmanagedType.Struct)] object DataValue);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void add_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void remove_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void add_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void remove_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0);
  }
}
