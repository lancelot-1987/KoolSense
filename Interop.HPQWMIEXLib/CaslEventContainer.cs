// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib.CaslEventContainer
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [Guid("3BC7CF8D-342E-4D94-A705-A762B8921C44")]
  [CoClass(typeof (CaslEventContainerClass))]
  [ComImport]
  public interface CaslEventContainer : ICaslEventContainer, _ICaslEventContainerEvents_Event
  {
  }
}
