// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib._ICaslEventContainerEvents_CallbackEventHandler
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [ComVisible(false)]
  public delegate bool _ICaslEventContainerEvents_CallbackEventHandler([MarshalAs(UnmanagedType.BStr), In] string Sender, [MarshalAs(UnmanagedType.BStr), In] string CallbackData);
}
