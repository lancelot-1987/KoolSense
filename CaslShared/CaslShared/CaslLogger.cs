// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslLogger
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using GenericLog;
using System;

namespace hpCasl
{
  public class CaslLogger
  {
    protected CaslLog m_log;

    public CaslLogger()
    {
      try
      {
        this.m_log = new CaslLog(Constants.LogFile);
      }
      catch (Exception ex)
      {
        this.m_log = (CaslLog) null;
      }
    }

    public bool Message(enLogLevel eLogLevel, string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      if (1 == 0)
        ;
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            flag = this.m_log.Message(eLogLevel, sIdentity, sSubIdentity, sMessage);
            num = 1;
            continue;
          case 1:
            goto label_7;
          case 2:
            if (this.m_log != null)
            {
              num = 0;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool Message(enLogLevel eLogLevel, string sMessage)
    {
label_2:
      if (1 == 0)
        ;
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            flag = this.m_log.Message(eLogLevel, sMessage);
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool TraceInMessage(string sMessage)
    {
label_2:
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            flag = this.m_log.Message(enLogLevel.TraceIn, sMessage);
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 1:
            if (this.m_log != null)
            {
              num = 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool TraceOutMessage(string sMessage)
    {
label_2:
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.m_log != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            flag = this.m_log.Message(enLogLevel.TraceOut, sMessage);
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
      return flag;
    }

    public bool InformationMessage(string sMessage)
    {
label_2:
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (1 == 0)
              ;
            flag = this.m_log.Message(enLogLevel.Information, sMessage);
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool WarningMessage(string sMessage)
    {
label_2:
      if (1 == 0)
        ;
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_log != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 1:
            goto label_7;
          case 2:
            flag = this.m_log.Message(enLogLevel.Warning, sMessage);
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool FormatTraceInMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
label_3:
        string sMessage = string.Format(sFormat, list);
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = 3;
              continue;
            case 1:
              if (this.m_log != null)
              {
                num = 2;
                continue;
              }
              goto case 0;
            case 2:
              if (1 == 0)
                ;
              flag = this.m_log.TraceInMessage(sIdentity, sSubIdentity, sMessage);
              num = 0;
              continue;
            case 3:
              goto label_10;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_10:
      return flag;
    }

    public bool FormatTraceOutMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
label_3:
        string sMessage = string.Format(sFormat, list);
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (1 == 0)
                break;
              break;
            case 1:
              if (this.m_log != null)
              {
                num = 2;
                continue;
              }
              break;
            case 2:
              flag = this.m_log.TraceOutMessage(sIdentity, sSubIdentity, sMessage);
              num = 0;
              continue;
            case 3:
              goto label_10;
            default:
              goto label_3;
          }
          num = 3;
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_10:
      return flag;
    }

    public bool TraceInMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
      if (1 == 0)
        ;
label_2:
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.m_log != null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 2:
            flag = this.m_log.Message(enLogLevel.TraceIn, sIdentity, sSubIdentity, sMessage);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      return flag;
    }

    public bool TraceOutMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      bool flag = false;
      if (1 == 0)
        ;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            flag = this.m_log.Message(enLogLevel.TraceOut, sIdentity, sSubIdentity, sMessage);
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool FormatInformationMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
label_3:
        string sMessage = string.Format(sFormat, list);
        if (1 == 0)
          ;
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              flag = this.m_log.InformationMessage(sIdentity, sSubIdentity, sMessage);
              num = 3;
              continue;
            case 1:
              if (this.m_log != null)
              {
                num = 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_10;
            case 3:
              num = 2;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_10:
      return flag;
    }

    public bool FormatUserMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
        if (1 == 0)
          ;
label_3:
        string sMessage = string.Format(sFormat, list);
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              flag = this.m_log.UserMessage(sIdentity, sSubIdentity, sMessage);
              num = 1;
              continue;
            case 1:
              num = 2;
              continue;
            case 2:
              goto label_9;
            case 3:
              if (this.m_log != null)
              {
                num = 0;
                continue;
              }
              goto case 1;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_9:
      return flag;
    }

    public bool FormatWarningMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
label_3:
        string sMessage = string.Format(sFormat, list);
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = 3;
              continue;
            case 1:
              if (this.m_log != null)
              {
                num = 2;
                continue;
              }
              goto case 0;
            case 2:
              flag = this.m_log.WarningMessage(sIdentity, sSubIdentity, sMessage);
              num = 0;
              continue;
            case 3:
              goto label_9;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_9:
      if (1 == 0)
        ;
      return flag;
    }

    public bool FormatErrorMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      bool flag = false;
      try
      {
label_3:
        string sMessage = string.Format(sFormat, list);
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = 3;
              continue;
            case 1:
              if (this.m_log != null)
              {
                num = 2;
                continue;
              }
              goto case 0;
            case 2:
              flag = this.m_log.ErrorMessage(sIdentity, sSubIdentity, sMessage);
              num = 0;
              continue;
            case 3:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_8:
        if (1 == 0)
          ;
      }
      catch (Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    public bool FormatCriticalMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
    {
      if (1 == 0)
        ;
      bool flag = false;
      try
      {
label_4:
        string sMessage = string.Format(sFormat, list);
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = 1;
              continue;
            case 1:
              goto label_10;
            case 2:
              flag = this.m_log.CriticalMessage(sIdentity, sSubIdentity, sMessage);
              num = 0;
              continue;
            case 3:
              if (this.m_log != null)
              {
                num = 2;
                continue;
              }
              goto case 0;
            default:
              goto label_4;
          }
        }
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_10:
      return flag;
    }

    public bool InformationMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (1 == 0)
              ;
            flag = this.m_log.Message(enLogLevel.Information, sIdentity, sSubIdentity, sMessage);
            num = 1;
            continue;
          case 1:
            goto label_7;
          case 2:
            if (this.m_log != null)
            {
              num = 0;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool WarningMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            flag = this.m_log.Message(enLogLevel.Warning, sIdentity, sSubIdentity, sMessage);
            if (1 == 0)
              ;
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool ErrorMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
      if (1 == 0)
        ;
label_2:
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_6;
          case 1:
            flag = this.m_log.Message(enLogLevel.Error, sIdentity, sSubIdentity, sMessage);
            num = 2;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_6:
      return flag;
    }

    public bool CriticalMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            flag = this.m_log.Message(enLogLevel.Critical, sIdentity, sSubIdentity, sMessage);
            if (1 == 0)
              ;
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool UserMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
label_2:
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_log != null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 1:
            goto label_6;
          case 2:
            flag = this.m_log.Message(enLogLevel.User, sIdentity, sSubIdentity, sMessage);
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      if (1 == 0)
        ;
      return flag;
    }

    public bool ErrorMessage(string sMessage)
    {
label_2:
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.m_log != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            flag = this.m_log.Message(enLogLevel.Error, sMessage);
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
      return flag;
    }

    public bool CDATAMessage(string sIdentity, string sSubIdentity, string sMessage)
    {
      int A_1 = 9;
label_2:
      if (1 == 0)
        ;
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          case 1:
            sMessage = Log.a("Ƚ愿\x1941݃Ʌेṉോᕍ", A_1) + sMessage + Log.a("挽\x1D3F籁", A_1);
            flag = this.m_log.Message(enLogLevel.Information, sIdentity, sSubIdentity, sMessage);
            num = 2;
            continue;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool DearAby(byte[] abyBytes, string sFileName)
    {
label_2:
      bool flag = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (1 == 0)
              ;
            flag = this.m_log.DearAby(abyBytes, sFileName);
            num = 0;
            continue;
          case 2:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool Clear()
    {
label_2:
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_log != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          case 1:
            flag = this.m_log.Clear();
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public bool Save()
    {
label_2:
      if (1 == 0)
        ;
      bool flag = false;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            flag = this.m_log.Save();
            num = 2;
            continue;
          case 1:
            if (this.m_log != null)
            {
              num = 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }
  }
}
