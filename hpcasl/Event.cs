// Decompiled with JetBrains decompiler
// Type: hpCasl.Event
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Collections.Generic;
using System.Reflection;

namespace hpCasl
{
  public static class Event
  {
    private static List<EventPluginLoader> eventPluginList;

    internal static List<Assembly> AssemblyList
    {
      get
      {
        List<Assembly> list = new List<Assembly>();
        using (List<EventPluginLoader>.Enumerator enumerator = Event.eventPluginList.GetEnumerator())
        {
          int num = 3;
          while (true)
          {
            EventPluginLoader current = null;
            switch (num)
            {
              case 0:
                if (1 == 0)
                  ;
                if (enumerator.MoveNext())
                {
                  current = enumerator.Current;
                  num = 6;
                  continue;
                }
                num = 4;
                continue;
              case 1:
                list.Add(current.PluginAssembly);
                num = 5;
                continue;
              case 2:
                goto label_13;
              case 4:
                num = 2;
                continue;
              case 6:
                if (current.PluginAssembly != null)
                {
                  num = 1;
                  continue;
                }
                break;
            }
            num = 0;
          }
        }
label_13:
        return list;
      }
    }

    static Event()
    {
label_2:
      Event.eventPluginList = new List<EventPluginLoader>();
      string[] plugins = CaslEnumerator.GetPlugins();
      int num = 7;
      int index = 0;
      EventPluginLoader eventPluginLoader = null;
      string[] strArray = null;
      while (true)
      {
        switch (num)
        {
          case 0:
            ++index;
            num = 5;
            continue;
          case 1:
            if (index >= strArray.Length)
            {
              num = 2;
              continue;
            }
            eventPluginLoader = EventPluginLoader.Load(strArray[index]);
            num = 6;
            continue;
          case 2:
            goto label_12;
          case 3:
          case 5:
            num = 1;
            continue;
          case 4:
            Event.eventPluginList.Add(eventPluginLoader);
            num = 0;
            continue;
          case 6:
            if (eventPluginLoader != null)
            {
              num = 4;
              continue;
            }
            goto case 0;
          case 7:
            if (plugins != null)
            {
              num = 8;
              continue;
            }
            goto label_16;
          case 8:
            if (1 == 0)
              ;
            strArray = plugins;
            index = 0;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      return;
label_16:;
    }

    public static enReturnCode Register(string eventName, enEventType eEventType, CaslEventHandler onEvent)
    {
      int A_1 = 8;
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힄\xE286\xEE88\xE28Aﺌﮎ\xF490\xE192", A_1), Casl.a("횄\xF386\xE888力歷\xEA8E\xF590", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      try
      {
        int num1 = 5;
        while (true)
        {
          List<EventPluginLoader>.Enumerator enumerator = new List<EventPluginLoader>.Enumerator();
          switch (num1)
          {
            case 0:
              num1 = 8;
              continue;
            case 1:
              try
              {
                int num2 = 0;
                EventPluginLoader current = null;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_29;
                    case 3:
                    case 7:
                      num2 = 1;
                      continue;
                    case 4:
                      if (!enumerator.MoveNext())
                      {
                        num2 = 3;
                        continue;
                      }
                      current = enumerator.Current;
                      num2 = 6;
                      continue;
                    case 5:
                      enReturnCode = EventTypeManager.Register(current, eventName, eEventType, onEvent);
                      num2 = 7;
                      continue;
                    case 6:
                      if (!current.IsSupported(eventName))
                      {
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num2 = 2;
                        continue;
                      }
                      num2 = 5;
                      continue;
                    default:
                      num2 = 4;
                      continue;
                  }
                }
              }
              finally
              {
                enumerator.Dispose();
              }
            case 2:
              num1 = 4;
              continue;
            case 3:
              if (onEvent == null)
              {
                num1 = 7;
                continue;
              }
              goto case 2;
            case 4:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num1 = 10;
                continue;
              }
              break;
            case 6:
              num1 = 3;
              continue;
            case 7:
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
              num1 = 2;
              continue;
            case 8:
              if (Enum.IsDefined(typeof (enEventType), (object) eEventType))
              {
                num1 = 6;
                continue;
              }
              goto case 7;
            case 9:
              goto label_31;
            case 10:
              if (1 == 0)
                ;
              enReturnCode = enReturnCode.e_MISSING_COMPONENT;
              enumerator = Event.eventPluginList.GetEnumerator();
              num1 = 1;
              continue;
            default:
              if (!string.IsNullOrEmpty(eventName))
              {
                num1 = 0;
                continue;
              }
              goto case 7;
          }
label_29:
          num1 = 9;
        }
      }
      catch (Exception ex)
      {
        Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힄\xE286\xEE88\xE28Aﺌﮎ\xF490\xE192", A_1), Casl.a("쒄Ꞇ첈\xF38A\xEE8C\xEA8E\xE190\xE792ﲔ\xF896\xF798뮚\xF29Cﲞ슠횢\xD7A4햦첨쾪鞬辮쪰莲좴", A_1), (object) ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_31:
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힄\xE286\xEE88\xE28Aﺌﮎ\xF490\xE192", A_1), Casl.a("욄\xE886\xE488ﮊ\xE18C\xEA8E\xE590\xF692\xF194", A_1));
      return enReturnCode;
    }

    public static enReturnCode Unregister(string eventName)
    {
      int A_1 = 18;
label_2:
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDA8Eﾐ\xE192\xF094\xF096\xF098\xE89A\xE99C爵펠", A_1), Casl.a("\xDC8E\xE590\xF292\xE794\xE396ﲘﾚ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num1 = 1;
      List<EventPluginLoader>.Enumerator enumerator = new List<EventPluginLoader>.Enumerator();
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            enumerator = Event.eventPluginList.GetEnumerator();
            num1 = 2;
            continue;
          case 1:
            if (string.IsNullOrEmpty(eventName))
            {
              num1 = 3;
              continue;
            }
            goto case 4;
          case 2:
            goto label_5;
          case 3:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 4;
            continue;
          case 4:
            num1 = 5;
            continue;
          case 5:
            if (1 == 0)
              ;
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_23;
          default:
            goto label_2;
        }
      }
label_5:
      try
      {
        int num2 = 7;
        EventPluginLoader current = null;
        while (true)
        {
          switch (num2)
          {
            case 0:
              enReturnCode = EventTypeManager.Unregister(eventName);
              num2 = 1;
              continue;
            case 1:
            case 5:
              num2 = 3;
              continue;
            case 2:
              if (!enumerator.MoveNext())
              {
                num2 = 5;
                continue;
              }
              current = enumerator.Current;
              num2 = 4;
              continue;
            case 3:
              goto label_23;
            case 4:
              if (!current.IsSupported(eventName))
              {
                enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                num2 = 6;
                continue;
              }
              num2 = 0;
              continue;
            default:
              num2 = 2;
              continue;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
label_23:
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDA8Eﾐ\xE192\xF094\xF096\xF098\xE89A\xE99C爵펠", A_1), Casl.a("첎ﺐﺒ\xE594ﮖﲘ\xEF9A\xF89Cﮞ", A_1));
      return enReturnCode;
    }

    public static string[] SupportedEvents()
    {
      int A_1 = 5;
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xE095ﶗ\xF499\xE89B\xED9D", A_1), Casl.a("톁\xF083\xE785慎ﺉ\xE98B\xEA8D", A_1));
      string[] Array1 = (string[]) null;
      try
      {
        using (List<EventPluginLoader>.Enumerator enumerator = Event.eventPluginList.GetEnumerator())
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                num = 1;
                continue;
              case 1:
                goto label_11;
              case 4:
                if (enumerator.MoveNext())
                {
                  EventPluginLoader current = enumerator.Current;
                  Array1 = Util.Merge(Array1, current.SupportedEvents());
                  num = 3;
                  continue;
                }
                num = 0;
                continue;
              default:
                num = 4;
                continue;
            }
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xE095ﶗ\xF499\xE89B\xED9D", A_1), Casl.a("쎁\xEA83ꚅ\xED87\xF289\xEF8B\xEB8D\xE08F\xE691ﶓ秊\xF697몙\xF39Bﶝ쎟힡횣풥춧캩貫햭肯쾱", A_1), (object) ex.Message);
      }
label_11:
      if (1 == 0)
        ;
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xE095ﶗ\xF499\xE89B\xED9D", A_1), Casl.a("솁\xEB83\xEB85\xF887\xE689\xE98B揄\xF58F\xF691", A_1));
      return Array1;
    }
  }
}
