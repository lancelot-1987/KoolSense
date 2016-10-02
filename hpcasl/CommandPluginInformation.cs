// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPluginInformation
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Diagnostics;
using System.Reflection;

namespace hpCasl
{
  internal class CommandPluginInformation : CommandPlugin
  {
    public override Assembly PluginAssembly
    {
      get
      {
        return (Assembly) null;
      }
    }

    public override string[] SupportedGetCommands()
    {
      int A_1 = 7;
      if (1 == 0)
        ;
      return new string[5]
      {
        Casl.a("잃\xE785ﮇ\xE689ꊋ좍\xE58Fﺑ\xF893\xF895聯\xF799鍊", A_1),
        Casl.a("잃\xE785ﮇ\xE689ꊋ슍ﾏ\xF191\xF593\xE295\xF197\xF599\xF29B", A_1),
        Casl.a("잃\xE785ﮇ\xE689ꊋ\xD88D\xF58F\xE091\xE793ﾕ\xF797\xF499", A_1),
        Casl.a("잃\xE785ﮇ\xE689ꊋ좍憐ﺑ\xF193삕ﶗ\xE899\xEF9B\xF79D쾟첡", A_1),
        Casl.a("잃\xE785ﮇ\xE689ꊋ\xDE8Dﲏ\xE791\xF393ﾕ\xF697\xE999", A_1)
      };
    }

    public override enReturnCode TypeOfGet(string sCommandName, out Type typeOut)
    {
      int A_1 = 18;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      typeOut = (Type) null;
      int num = 9;
      while (true)
      {
        string str = string.Empty;
        switch (num)
        {
          case 0:
          case 5:
          case 10:
            goto label_28;
          case 1:
            num = 2;
            continue;
          case 2:
            if (!(str == Casl.a("첎\xF090\xE092璉릖\xDF98\xEE9A\xF19C\xF39E쾠슢좤슦", A_1)))
            {
              num = 4;
              continue;
            }
            break;
          case 3:
            if (!(str == Casl.a("첎\xF090\xE092璉릖쾘ﺚ\xEF9C\xEC9E좠첢쮤", A_1)))
            {
              num = 7;
              continue;
            }
            break;
          case 4:
            num = 17;
            continue;
          case 6:
            if (1 == 0)
              ;
            num = 13;
            continue;
          case 7:
            num = 8;
            continue;
          case 8:
            if (!(str == Casl.a("첎\xF090\xE092璉릖\xDF98\xF29A\xF19C爵\xF7A0욢\xD7A4풦삨쒪쎬", A_1)))
            {
              num = 11;
              continue;
            }
            break;
          case 9:
            if (this.IsGetSupported(sCommandName))
            {
              num = 12;
              continue;
            }
            goto label_28;
          case 11:
            num = 16;
            continue;
          case 12:
            num = 14;
            continue;
          case 13:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 10;
            continue;
          case 14:
            if ((str = sCommandName) != null)
            {
              num = 1;
              continue;
            }
            goto case 13;
          case 15:
            num = 3;
            continue;
          case 16:
            if (!(str == Casl.a("첎\xF090\xE092璉릖즘\xF79A\xE89C\xF89E좠춢횤", A_1)))
            {
              num = 6;
              continue;
            }
            typeOut = typeof (string[]);
            num = 0;
            continue;
          case 17:
            if (!(str == Casl.a("첎\xF090\xE092璉릖햘\xF49Aﺜﺞ햠쪢쪤즦", A_1)))
            {
              num = 15;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        typeOut = typeof (string);
        num = 5;
      }
label_28:
      return enReturnCode;
    }

    public override bool IsGetSupported(string sCommandName)
    {
      return Array.IndexOf<string>(this.SupportedGetCommands(), sCommandName) != -1;
    }

    public override enReturnCode Get(string sCommandName, out object oDataOut)
    {
      int A_1 = 7;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      oDataOut = (object) null;
      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      int num = 2;
      string str = null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (str == Casl.a("잃\xE785ﮇ\xE689ꊋ슍ﾏ\xF191\xF593\xE295\xF197\xF599\xF29B", A_1))
            {
              oDataOut = (object) executingAssembly.Location;
              num = 12;
              continue;
            }
            num = 9;
            continue;
          case 1:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 23;
            continue;
          case 2:
            if (string.IsNullOrEmpty(sCommandName))
            {
              num = 14;
              continue;
            }
            goto case 19;
          case 3:
          case 6:
          case 12:
          case 13:
          case 18:
          case 23:
            goto label_35;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_35;
          case 5:
            if ((str = sCommandName) != null)
            {
              num = 21;
              continue;
            }
            goto case 1;
          case 7:
            num = 5;
            continue;
          case 8:
            if (str == Casl.a("잃\xE785ﮇ\xE689ꊋ\xDE8Dﲏ\xE791\xF393ﾕ\xF697\xE999", A_1))
            {
              oDataOut = (object) CaslEnumerator.GetPlugins();
              num = 6;
              continue;
            }
            num = 15;
            continue;
          case 9:
            num = 10;
            continue;
          case 10:
            if (str == Casl.a("잃\xE785ﮇ\xE689ꊋ\xD88D\xF58F\xE091\xE793ﾕ\xF797\xF499", A_1))
            {
              oDataOut = (object) executingAssembly.GetName().Version.ToString();
              num = 3;
              continue;
            }
            num = 17;
            continue;
          case 11:
            num = 0;
            continue;
          case 14:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            if (1 == 0)
              ;
            num = 19;
            continue;
          case 15:
            num = 1;
            continue;
          case 16:
            if (str == Casl.a("잃\xE785ﮇ\xE689ꊋ좍\xE58Fﺑ\xF893\xF895聯\xF799鍊", A_1))
            {
              oDataOut = (object) executingAssembly.FullName;
              num = 18;
              continue;
            }
            num = 11;
            continue;
          case 17:
            num = 20;
            continue;
          case 19:
            num = 4;
            continue;
          case 20:
            if (str == Casl.a("잃\xE785ﮇ\xE689ꊋ좍憐ﺑ\xF193삕ﶗ\xE899\xEF9B\xF79D쾟첡", A_1))
            {
              oDataOut = (object) FileVersionInfo.GetVersionInfo(executingAssembly.Location).FileVersion;
              num = 13;
              continue;
            }
            num = 22;
            continue;
          case 21:
            num = 16;
            continue;
          case 22:
            num = 8;
            continue;
          default:
            goto label_2;
        }
      }
label_35:
      return enReturnCode;
    }

    public override string[] SupportedSetCommands()
    {
      return (string[]) null;
    }

    public override enReturnCode TypeOfSet(string sCommandName, out Type typeIn)
    {
      typeIn = (Type) null;
      return enReturnCode.e_MISSING_COMPONENT;
    }

    public override bool IsSetSupported(string sCommandName)
    {
      return false;
    }

    public override enReturnCode Set(string sCommandName, object oDataIn)
    {
      return enReturnCode.e_INVALID_PARAMETER;
    }

    public override string[] SupportedExecuteCommands()
    {
      return (string[]) null;
    }

    public override enReturnCode TypeOfExecute(string sCommandName, out Type tDataIn, out Type tDataOut)
    {
      tDataIn = (Type) null;
      tDataOut = (Type) null;
      return enReturnCode.e_INVALID_PARAMETER;
    }

    public override bool IsExecuteSupported(string sCommandName)
    {
      return false;
    }

    public override enReturnCode Execute(string sCommandName, object oDataIn, out object oDataOut)
    {
      oDataOut = (object) null;
      return enReturnCode.e_INVALID_PARAMETER;
    }
  }
}
