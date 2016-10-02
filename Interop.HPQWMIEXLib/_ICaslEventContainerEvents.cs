// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib._ICaslEventContainerEvents
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [InterfaceType((short) 2)]
  [Guid("98AE6A34-855A-4B1B-ADF2-984C8BF9A317")]
  [TypeLibType((short) 4096)]
  [ComImport]
  public interface _ICaslEventContainerEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool Callback([MarshalAs(UnmanagedType.BStr), In] string Sender, [MarshalAs(UnmanagedType.BStr), In] string CallbackData);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool Callback2([MarshalAs(UnmanagedType.BStr), In] string Sender, [MarshalAs(UnmanagedType.Struct), In] object CallbackData);
  }
}
