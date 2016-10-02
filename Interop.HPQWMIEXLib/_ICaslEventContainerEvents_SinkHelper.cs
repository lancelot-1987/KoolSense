// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib._ICaslEventContainerEvents_SinkHelper
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System.Runtime.InteropServices;

namespace HPQWMIEXLib
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  public sealed class _ICaslEventContainerEvents_SinkHelper : _ICaslEventContainerEvents
  {
    public _ICaslEventContainerEvents_CallbackEventHandler m_CallbackDelegate;
    public _ICaslEventContainerEvents_Callback2EventHandler m_Callback2Delegate;
    public int m_dwCookie;

    internal _ICaslEventContainerEvents_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_CallbackDelegate = (_ICaslEventContainerEvents_CallbackEventHandler) null;
      this.m_Callback2Delegate = (_ICaslEventContainerEvents_Callback2EventHandler) null;
    }

    public  bool Callback([In] string obj0, [In] string obj1)
    {
      if (this.m_CallbackDelegate != null)
        return this.m_CallbackDelegate(obj0, obj1);
      return false;
    }

    public  bool Callback2([In] string obj0, [In] object obj1)
    {
      if (this.m_Callback2Delegate != null)
        return this.m_Callback2Delegate(obj0, obj1);
      return false;
    }
  }
}
