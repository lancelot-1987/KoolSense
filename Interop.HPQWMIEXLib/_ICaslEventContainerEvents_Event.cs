// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib._ICaslEventContainerEvents_Event
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [ComEventInterface(typeof (_ICaslEventContainerEvents), typeof (_ICaslEventContainerEvents_EventProvider))]
  [TypeLibType((short) 16)]
  [ComVisible(false)]
  public interface _ICaslEventContainerEvents_Event
  {
   
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0);
  }
}
