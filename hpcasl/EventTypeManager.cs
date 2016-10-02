// Decompiled with JetBrains decompiler
// Type: hpCasl.EventTypeManager
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System.Collections.Generic;
using System.Threading;

namespace hpCasl
{
  internal static class EventTypeManager
  {
    private static List<EventItem> eventItemList = new List<EventItem>();
    private const string globalMutex = "hpCaslEvents.GlobalMutex";

    public static enReturnCode Register(EventPluginLoader eventPlugin, string eventName, enEventType eEventType, CaslEventHandler onEvent)
    {
      int A_1 = 4;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Mutex mutex = new Mutex(false, Casl.a("\xE980\xF382욄\xE686愈\xE78A좌年\xF490ﶒ\xE194\xE496래\xDC9A\xF19C\xF09E쎠슢즤\xEAA6\xDCA8\xDFAA좬\xD7AE", A_1));
      mutex.WaitOne();
      int num = 7;
      EventItem eventItem = null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 9;
              continue;
            }
            goto label_17;
          case 1:
            EventTypeManager.eventItemList.Add(eventItem);
            num = 3;
            continue;
          case 2:
            num = 0;
            continue;
          case 3:
            goto label_17;
          case 4:
            if (EventTypeManager.GetEventItem(eventName) != null)
            {
              num = 5;
              continue;
            }
            goto case 2;
          case 5:
            enReturnCode = enReturnCode.e_EVENT_ALREADY_REGISTERED;
            num = 2;
            continue;
          case 6:
            num = 4;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto label_17;
          case 9:
            if (1 == 0)
              ;
            eventItem = new EventItem();
            enReturnCode = eventItem.Register(eventPlugin, eventName, eEventType, onEvent);
            num = 8;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      mutex.ReleaseMutex();
      return enReturnCode;
    }

    public static enReturnCode Unregister(string eventName)
    {
      int A_1 = 7;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Mutex mutex = new Mutex(false, Casl.a("\xEC83\xF685쮇\xEB89ﾋ\xE28D햏\xE491\xF193\xF895\xEC97\xE999늛\xD99D첟춡욣장쒧\xE7A9\xD9AB\xDAAD햯쪱", A_1));
      mutex.WaitOne();
      EventItem eventItem = EventTypeManager.GetEventItem(eventName);
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_11;
          case 1:
            enReturnCode = enReturnCode.e_EVENT_NOT_REGISTERED;
            num = 2;
            continue;
          case 2:
            num = 0;
            continue;
          case 3:
            goto label_11;
          case 4:
            EventTypeManager.eventItemList.Remove(eventItem);
            enReturnCode = eventItem.Unregister();
            eventItem = (EventItem) null;
            num = 3;
            continue;
          case 5:
            if (eventItem == null)
            {
              if (1 == 0)
                ;
              num = 1;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
      }
label_11:
      mutex.ReleaseMutex();
      return enReturnCode;
    }

    private static EventItem GetEventItem(string eventName)
    {
      EventItem eventItem = (EventItem) null;
      using (List<EventItem>.Enumerator enumerator = EventTypeManager.eventItemList.GetEnumerator())
      {
        int num = 0;
        while (true)
        {
          EventItem current = null;
          switch (num)
          {
            case 1:
            case 2:
              num = 6;
              continue;
            case 3:
              eventItem = current;
              num = 2;
              continue;
            case 4:
              if (enumerator.MoveNext())
              {
                current = enumerator.Current;
                num = 5;
                continue;
              }
              num = 1;
              continue;
            case 5:
              if (current.EventName == eventName)
              {
                num = 3;
                continue;
              }
              break;
            case 6:
              goto label_12;
          }
          num = 4;
        }
      }
label_12:
      if (1 == 0)
        ;
      return eventItem;
    }
  }
}
