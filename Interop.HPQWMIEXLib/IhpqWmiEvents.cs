// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.IhpqWmiEvents
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [Guid("83FD586E-8AE5-40BC-AC5E-CFC7265B2E8F")]
  [TypeLibType((short) 4288)]
  [ComImport]
  public interface IhpqWmiEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void hpqMonitorEvents([In] uint ulState);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void hpqRegisterEvent([MarshalAs(UnmanagedType.BStr), In] string bstrEventName, [In] uint dwEventID, out uint pulRetCode);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void hpqUnRegisterEvent([MarshalAs(UnmanagedType.BStr), In] string bstrEventName, [In] uint dwEventID, out uint pulRetCode);
  }
}
