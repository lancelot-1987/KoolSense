// Decompiled with JetBrains decompiler
// Type: hpCasl.Event
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

namespace hpCasl
{
  internal abstract class Event
  {
    protected CaslLogger log = new CaslLogger();

    public abstract string[] SupportedEvents();

    public abstract bool IsEventSupported(string eventName);

    public abstract enReturnCode Register(string eventName, CaslEventHandler onEventHandler);

    public abstract enReturnCode Unregister(string eventName);
  }
}
