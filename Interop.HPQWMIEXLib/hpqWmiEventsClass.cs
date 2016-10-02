// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.hpqWmiEventsClass
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [Guid("4BE1F202-E872-4127-8E3F-A24A4A021203")]
  [ClassInterface((short) 0)]
  [TypeLibType((short) 2)]
  [ComImport]
  public class hpqWmiEventsClass : IhpqWmiEvents, hpqWmiEvents
  {

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void hpqMonitorEvents([In] uint ulState);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void hpqRegisterEvent([MarshalAs(UnmanagedType.BStr), In] string bstrEventName, [In] uint dwEventID, out uint pulRetCode);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void hpqUnRegisterEvent([MarshalAs(UnmanagedType.BStr), In] string bstrEventName, [In] uint dwEventID, out uint pulRetCode);
  }
}
