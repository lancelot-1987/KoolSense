// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.hpqCallBiosExClass
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [TypeLibType((short) 2)]
  [ClassInterface((short) 0)]
  [Guid("F5539356-2F02-40D4-999E-FA61F45FE12E")]
  [ComImport]
  public class hpqCallBiosExClass : IhpqCallBiosEx, hpqCallBiosEx
  {

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern void hpqExecMethodEx([In] uint dwCmd, [In] uint dwType, [In] uint dwSizeIn, [In] uint dwSizeOut, out uint lpdwRetCode, [MarshalAs(UnmanagedType.Struct), In] ref object lpVarDataIn, [MarshalAs(UnmanagedType.Struct), In, Out] ref object lpVarDataOut);
  }
}
