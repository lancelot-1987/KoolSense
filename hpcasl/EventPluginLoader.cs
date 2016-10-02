// Decompiled with JetBrains decompiler
// Type: hpCasl.EventPluginLoader
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Reflection;

namespace hpCasl
{
  internal class EventPluginLoader
  {
    private EventPluginLoader.SupportedEventsDelegate supportedEvents;
    private EventPluginLoader.IsEventSupportedDelegate isEventSupported;
    private EventPluginLoader.RegisterDelegate register;
    private EventPluginLoader.UnregisterDelegate unregister;
    private Assembly pluginAssembly;

    public virtual Assembly PluginAssembly
    {
      get
      {
        return this.pluginAssembly;
      }
    }

    public static EventPluginLoader Load(string sPath)
    {
      int A_1 = 13;
label_2:
      EventPluginLoader eventPluginLoader = (EventPluginLoader) null;
      Assembly assembly = (Assembly) null;
      if (1 == 0)
        ;
      int num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            try
            {
              assembly = Assembly.LoadFrom(sPath);
            }
            catch
            {
            }
            num1 = 2;
            continue;
          case 1:
            goto label_4;
          case 2:
            if (assembly != null)
            {
              num1 = 1;
              continue;
            }
            goto label_26;
          default:
            goto label_2;
        }
      }
label_4:
      try
      {
label_6:
        object instance = Activator.CreateInstance(assembly.GetType(Casl.a("\xE289ﲋ춍\xF18F\xE191\xF893뢕\xDD97\xEC99鍊\xF09D풟\xF2A1좣펥쾧쎩슫", A_1)));
        eventPluginLoader = new EventPluginLoader();
        eventPluginLoader.pluginAssembly = assembly;
        eventPluginLoader.supportedEvents = (EventPluginLoader.SupportedEventsDelegate) Delegate.CreateDelegate(typeof (EventPluginLoader.SupportedEventsDelegate), instance, Casl.a("\xD989曆ﺍ\xE08F\xFD91\xE693\xE295ﶗﺙ\xD99B\xE89D얟첡킣향", A_1));
        eventPluginLoader.isEventSupported = (EventPluginLoader.IsEventSupportedDelegate) Delegate.CreateDelegate(typeof (EventPluginLoader.IsEventSupportedDelegate), instance, Casl.a("쎉ﾋ쮍\xE68F\xF791望\xE295쮗\xEF99\xEC9B\xEE9D쾟킡킣쎥첧", A_1));
        eventPluginLoader.register = (EventPluginLoader.RegisterDelegate) Delegate.CreateDelegate(typeof (EventPluginLoader.RegisterDelegate), instance, Casl.a("\xD889\xE98B\xE98D憐\xE191\xE093\xF395\xEA97", A_1));
        eventPluginLoader.unregister = (EventPluginLoader.UnregisterDelegate) Delegate.CreateDelegate(typeof (EventPluginLoader.UnregisterDelegate), instance, Casl.a("\xDF89\xE28Bﲍ\xF58F\xF591ﶓ\xE595\xEC97ﾙ\xEE9B", A_1));
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              if (eventPluginLoader.register != null)
              {
                num2 = 8;
                continue;
              }
              goto case 4;
            case 1:
              if (eventPluginLoader.supportedEvents != null)
              {
                num2 = 7;
                continue;
              }
              goto case 4;
            case 2:
              goto label_26;
            case 3:
              num2 = 0;
              continue;
            case 4:
              eventPluginLoader = (EventPluginLoader) null;
              num2 = 6;
              continue;
            case 5:
              if (eventPluginLoader.unregister == null)
              {
                num2 = 4;
                continue;
              }
              goto case 6;
            case 6:
              num2 = 2;
              continue;
            case 7:
              num2 = 9;
              continue;
            case 8:
              num2 = 5;
              continue;
            case 9:
              if (eventPluginLoader.isEventSupported != null)
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            default:
              goto label_6;
          }
        }
      }
      catch
      {
        eventPluginLoader = (EventPluginLoader) null;
      }
label_26:
      return eventPluginLoader;
    }

    public string[] SupportedEvents()
    {
label_2:
      if (1 == 0)
        ;
      string[] strArray = (string[]) null;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.supportedEvents != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 1:
            goto label_7;
          case 2:
            strArray = this.supportedEvents();
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return strArray;
    }

    public bool IsSupported(string eventName)
    {
label_2:
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (this.isEventSupported != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            flag = this.isEventSupported(eventName);
            if (1 == 0)
              ;
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public enReturnCode Register(string sEventName, enEventType eEventType, CaslEventHandler onEvent)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_MISSING_COMPONENT;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.register != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            enReturnCode = this.register(sEventName, eEventType, onEvent);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      if (1 == 0)
        ;
label_7:
      return enReturnCode;
    }

    public enReturnCode Unregister(string sEventName)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_MISSING_COMPONENT;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.unregister != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          case 1:
            if (1 == 0)
              ;
            enReturnCode = this.unregister(sEventName);
            num = 2;
            continue;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return enReturnCode;
    }

    private delegate string[] SupportedEventsDelegate();

    private delegate bool IsEventSupportedDelegate(string eventName);

    private delegate enReturnCode RegisterDelegate(string eventName, enEventType eEventType, CaslEventHandler onEventHandler);

    private delegate enReturnCode UnregisterDelegate(string eventName);
  }
}
