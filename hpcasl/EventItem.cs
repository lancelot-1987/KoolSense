// Decompiled with JetBrains decompiler
// Type: hpCasl.EventItem
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Threading;

namespace hpCasl
{
  internal class EventItem
  {
    public string EventName;
    private Mutex mutexEvent;
    private EventWaitHandle ewhGlobalDefault;
    private Thread tGlobalDefault;
    private EventPluginLoader eventPlugin;

    public enReturnCode Register(EventPluginLoader eventPlugin, string eventName, enEventType eEventType, CaslEventHandler onEvent)
    {
      int A_1 = 11;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.EventName = eventName;
      this.eventPlugin = eventPlugin;
      string name1 = Casl.a("\xE087憎쾋\xEF8D\xE38Fﺑ몓", A_1) + this.EventName + Casl.a("ꢇ쾉\xF48B\xED8Dﲏ\xE791\xE793ﾕ\xEE97ﾙ", A_1);
      string name2 = Casl.a("\xE087憎쾋\xEF8D\xE38Fﺑ몓", A_1) + this.EventName + Casl.a("ꢇ\xD989\xE48B\xEF8D\xE28F\xF791\xF093", A_1);
      string name3 = Casl.a("\xE087憎쾋\xEF8D\xE38Fﺑ몓", A_1) + this.EventName + Casl.a("ꢇ캉\xE98B\xE88D\xF18F\xE791\xF893\xE295", A_1);
      int num1 = 24;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (eEventType != enEventType.Default)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), Casl.a("\xDD87\xE489\xE48B\xEF8Dﺏ\xF691\xF893\xF395ﲗ몙\xE89B\xE79D킟잡", A_1));
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num1 = 4;
              continue;
            }
            num1 = 1;
            continue;
          case 1:
            try
            {
label_7:
              bool createdNew = false;
              this.ewhGlobalDefault = new EventWaitHandle(true, EventResetMode.AutoReset, name3, out createdNew);
              int num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    if (!createdNew)
                    {
                      num2 = 1;
                      continue;
                    }
                    goto case 3;
                  case 1:
                    Thread.Sleep(200);
                    num2 = 3;
                    continue;
                  case 2:
                    goto label_57;
                  case 3:
                    num2 = 2;
                    continue;
                  default:
                    goto label_7;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto case 4;
            }
          case 2:
            try
            {
label_37:
              bool createdNew = false;
              new Mutex(false, name1, out createdNew).Close();
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    num2 = 3;
                    continue;
                  case 1:
                    if (!createdNew)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 0;
                  case 2:
                    Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), Casl.a("춇\xF289\xEF8B\xE28D\xE58F\xE191ﶓ\xE095ﶗ몙鍊\xE89D얟첡킣蚥즧용\xDEAB쮭톯횱춳隵\xDDB7승햻춽뒿뇁", A_1));
                    enReturnCode = enReturnCode.e_EVENT_REGISTERED_AS_EXCLUSIVE;
                    num2 = 0;
                    continue;
                  case 3:
                    goto label_71;
                  default:
                    goto label_37;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto label_71;
            }
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 5;
              continue;
            }
            goto label_81;
          case 4:
label_57:
            num1 = 20;
            continue;
          case 5:
            num1 = 10;
            continue;
          case 6:
            try
            {
label_16:
              bool createdNew = false;
              new Mutex(false, name2, out createdNew).Close();
              int num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    if (!createdNew)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 3;
                  case 1:
                    goto label_46;
                  case 2:
                    Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), Casl.a("\xDB87\xE289\xED8Bﲍ\xF58F\xF691뒓\xF395\xEE97ﾙ\xF29B\xEA9D肟쎡좣풥춧쮩좫\xD7AD邯ힱ첳\xDFB5쮷캹쾻", A_1));
                    enReturnCode = enReturnCode.e_EVENT_REGISTERED_AS_SHARED;
                    num2 = 3;
                    continue;
                  case 3:
                    num2 = 1;
                    continue;
                  default:
                    goto label_16;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto label_46;
            }
          case 7:
            try
            {
label_51:
              bool createdNew = false;
              EventWaitHandle eventWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset, name3, out createdNew);
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    eventWaitHandle.Close();
                    eventWaitHandle = (EventWaitHandle) null;
                    num2 = 2;
                    continue;
                  case 1:
                    if (!createdNew)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 0;
                  case 2:
                    goto label_32;
                  case 3:
                    eventWaitHandle.Set();
                    Thread.Sleep(200);
                    num2 = 0;
                    continue;
                  default:
                    goto label_51;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto label_32;
            }
          case 8:
            try
            {
              this.mutexEvent = new Mutex(false, name2);
              goto case 4;
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto case 4;
            }
          case 9:
            goto label_81;
          case 10:
            if (eEventType == enEventType.Default)
            {
              num1 = 17;
              continue;
            }
            goto label_81;
          case 11:
            try
            {
label_65:
              bool createdNew = false;
              this.mutexEvent = new Mutex(false, name1, out createdNew);
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    this.mutexEvent.Close();
                    this.mutexEvent = (Mutex) null;
                    Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), Casl.a("춇\xF289\xEF8B\xE28D\xE58F\xE191ﶓ\xE095ﶗ몙鍊\xE89D얟첡킣蚥즧용\xDEAB쮭톯횱춳隵\xDDB7승햻춽뒿뇁\xE4C3\xEBC5\xE8C7ꏉ룋\xEECDꏏ뫑믓ꏕ듗뻙ﳛ냝迟雡쓣蟥鳧쫩飫蛭駯臱퓳蛵韷鏹鋻諽\x20FF欁樃★簇戉椋⸍猏紑瀓猕", A_1));
                    enReturnCode = enReturnCode.e_EVENT_REGISTERED_AS_EXCLUSIVE;
                    num2 = 3;
                    continue;
                  case 1:
                    if (!createdNew)
                    {
                      num2 = 0;
                      continue;
                    }
                    goto case 3;
                  case 2:
                    goto label_57;
                  case 3:
                    num2 = 2;
                    continue;
                  default:
                    goto label_65;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              goto case 4;
            }
          case 12:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 23;
              continue;
            }
            goto case 4;
          case 13:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 25;
              continue;
            }
            goto label_46;
          case 14:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 7;
              continue;
            }
            goto label_32;
          case 15:
            if (eEventType != enEventType.Exclusive)
            {
              num1 = 18;
              continue;
            }
            goto case 6;
          case 16:
            try
            {
              enReturnCode = eventPlugin.Register(eventName, eEventType, onEvent);
              break;
            }
            catch (Exception ex)
            {
              int num2 = (int) this.Clean();
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDA87\xEF89\xEB8B\xE78D\xE38F\xE691\xF193\xE495", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
              break;
            }
          case 17:
            this.tGlobalDefault = new Thread(new ThreadStart(this.DefaultEventThread));
            this.tGlobalDefault.IsBackground = true;
            this.tGlobalDefault.Start();
            num1 = 9;
            continue;
          case 18:
            if (1 == 0)
              ;
            num1 = 22;
            continue;
          case 19:
            num1 = eEventType != enEventType.Shared ? 0 : 8;
            continue;
          case 20:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 16;
              continue;
            }
            break;
          case 21:
            num1 = eEventType != enEventType.Exclusive ? 19 : 11;
            continue;
          case 22:
            if (eEventType == enEventType.Default)
            {
              num1 = 6;
              continue;
            }
            goto label_46;
          case 23:
            num1 = 21;
            continue;
          case 24:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 2;
              continue;
            }
            goto label_71;
          case 25:
            num1 = 15;
            continue;
          default:
            goto label_2;
        }
        num1 = 3;
        continue;
label_32:
        num1 = 12;
        continue;
label_46:
        num1 = 14;
        continue;
label_71:
        num1 = 13;
      }
label_81:
      return enReturnCode;
    }

    public enReturnCode Unregister()
    {
      int A_1 = 17;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      if (1 == 0)
        ;
      int num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 2;
              continue;
            }
            goto label_17;
          case 1:
            goto label_17;
          case 2:
            try
            {
              int num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    this.tGlobalDefault.Join();
                    num2 = 3;
                    continue;
                  case 3:
                    num2 = 1;
                    continue;
                  case 4:
                    if (this.tGlobalDefault != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 3;
                  case 5:
                    this.ewhGlobalDefault.Set();
                    num2 = 4;
                    continue;
                  default:
                    if (this.ewhGlobalDefault != null)
                    {
                      num2 = 5;
                      continue;
                    }
                    goto case 3;
                }
              }
            }
            catch (Exception ex)
            {
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("\xDB8Dﺏ삑\xF193\xF195\xF197\xE999\xE89Bﮝ튟", A_1), ex.Message);
              enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
label_6:
            int num3 = (int) this.Clean();
            num1 = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      return enReturnCode;
    }

    private void DefaultEventThread()
    {
      int A_1 = 7;
      Global.Log.TraceInMessage(this.GetType().ToString(), Casl.a("삃\xE385\xEE87\xEB89曆\xE28D\xE48F힑\xE293\xF395\xF697\xEE99좛\xF69D튟잡얣슥", A_1), Casl.a("힃\xF285\xE987\xF889\xF88B\xEB8D\xF48F늑쾓\xF395\xF697\xDF99\xEA9Bﮝ캟횡\xEDA3\xE2A5銧", A_1) + this.EventName + Casl.a("\xD983", A_1));
      try
      {
        this.ewhGlobalDefault.Reset();
        this.ewhGlobalDefault.WaitOne();
        int num = (int) this.eventPlugin.Unregister(this.EventName);
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("삃\xE385\xEE87\xEB89曆\xE28D\xE48F힑\xE293\xF395\xF697\xEE99좛\xF69D튟잡얣슥", A_1), ex.Message);
      }
      if (1 == 0)
        ;
      Global.Log.TraceOutMessage(this.GetType().ToString(), Casl.a("삃\xE385\xEE87\xEB89曆\xE28D\xE48F힑\xE293\xF395\xF697\xEE99좛\xF69D튟잡얣슥", A_1), Casl.a("잃\xE985\xE587憎\xE08B\xEB8D\xE48F\xF791\xF093", A_1));
    }

    private enReturnCode Clean()
    {
      int A_1 = 14;
      Global.Log.TraceInMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), Casl.a("\xD88A歷\xEE8E\xE390\xE792\xF094\xF396릘삚\xF89C\xF19E\xE4A0햢삤즦\xDDA8\xE2AA\xE9AC閮", A_1) + this.EventName + Casl.a("횊", A_1));
      enReturnCode enReturnCode1 = enReturnCode.e_OK;
      try
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_22;
            case 2:
              num = 0;
              continue;
            case 3:
              this.tGlobalDefault = (Thread) null;
              num = 2;
              continue;
            default:
              if (this.tGlobalDefault != null)
              {
                num = 3;
                continue;
              }
              goto case 2;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), ex.Message);
        enReturnCode1 = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_22:
      enReturnCode enReturnCode2;
      try
      {
        enReturnCode2 = this.eventPlugin.Unregister(this.EventName);
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), ex.Message);
        enReturnCode2 = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              this.ewhGlobalDefault.Close();
              this.ewhGlobalDefault = (EventWaitHandle) null;
              num = 1;
              continue;
            case 1:
              num = 2;
              continue;
            case 2:
              goto label_15;
            default:
              if (this.ewhGlobalDefault != null)
              {
                num = 0;
                continue;
              }
              goto case 1;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), ex.Message);
        enReturnCode2 = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_15:
      try
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              this.mutexEvent.Close();
              this.mutexEvent = (Mutex) null;
              num = 1;
              continue;
            case 1:
              num = 3;
              continue;
            case 3:
              goto label_24;
            default:
              if (this.mutexEvent != null)
              {
                num = 0;
                continue;
              }
              goto case 1;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), ex.Message);
        enReturnCode2 = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_24:
      if (1 == 0)
        ;
      Global.Log.TraceOutMessage(this.GetType().ToString(), Casl.a("좊\xE18C\xEA8E\xF090ﶒ", A_1), Casl.a("좊\xE28C\xE28E\xE190ﾒ\xF094\xE396ﲘﾚ붜\xE89E좠힢춤鶦覨", A_1) + enReturnCode2.ToString());
      return enReturnCode2;
    }
  }
}
