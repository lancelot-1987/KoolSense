// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPluginEnumerator
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace hpCasl
{
  internal class CommandPluginEnumerator : CommandPlugin
  {
    private List<Assembly> assemblyList;
    private string commandPrefix;

    public override Assembly PluginAssembly
    {
      get
      {
        return (Assembly) null;
      }
    }

    public CommandPluginEnumerator(string commandPrefix, List<Assembly> list)
    {
      this.assemblyList = list;
      this.commandPrefix = commandPrefix;
    }

    public override string[] SupportedGetCommands()
    {
      int A_1 = 17;
      List<string> list = new List<string>();
      using (List<Assembly>.Enumerator enumerator = this.assemblyList.GetEnumerator())
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_10;
            case 2:
              num = 0;
              continue;
            case 3:
              num = 4;
              continue;
            case 4:
              if (enumerator.MoveNext())
              {
                string str = this.commandPrefix + enumerator.Current.GetName().Name + Casl.a("ꂍ", A_1);
                list.Add(str + Casl.a("좍\xE58Fﺑ\xF893\xF895聯\xF799鍊", A_1));
                list.Add(str + Casl.a("슍ﾏ\xF191\xF593\xE295\xF197\xF599\xF29B", A_1));
                list.Add(str + Casl.a("\xD88D\xF58F\xE091\xE793ﾕ\xF797\xF499", A_1));
                list.Add(str + Casl.a("좍憐ﺑ\xF193삕ﶗ\xE899\xEF9B\xF79D쾟첡", A_1));
                num = 3;
                continue;
              }
              num = 2;
              continue;
            default:
              if (1 == 0)
                goto case 3;
              else
                goto case 3;
          }
        }
      }
label_10:
      return list.ToArray();
    }

    public override enReturnCode TypeOfGet(string sCommandName, out Type typeOut)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      typeOut = (Type) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            typeOut = typeof (string);
            if (1 == 0)
              ;
            num = 3;
            continue;
          case 1:
          case 3:
            goto label_8;
          case 2:
            if (this.IsGetSupported(sCommandName))
            {
              num = 0;
              continue;
            }
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      return enReturnCode;
    }

    public override bool IsGetSupported(string sCommandName)
    {
      return Array.IndexOf<string>(this.SupportedGetCommands(), sCommandName) != -1;
    }

    public override enReturnCode Get(string sCommandName, out object oDataOut)
    {
      int A_1 = 9;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      oDataOut = null;
      Assembly assembly =  null;
      string str1 = null;
      int num1 = 4;
      while (true)
      {
        string str2 = null;
        List<Assembly>.Enumerator enumerator = new List<Assembly>.Enumerator();
        switch (num1)
        {
          case 0:
            num1 = 17;
            continue;
          case 1:
          case 8:
          case 11:
          case 20:
          case 21:
            goto label_46;
          case 2:
            num1 = 6;
            continue;
          case 3:
            num1 = 10;
            continue;
          case 4:
            if (string.IsNullOrEmpty(sCommandName))
            {
              num1 = 13;
              continue;
            }
            goto case 3;
          case 5:
            if (str2 == Casl.a("쪅\xE787\xE989\xED8B揄憐\xFD91望", A_1))
            {
              oDataOut = (object) assembly.Location;
              num1 = 8;
              continue;
            }
            num1 = 22;
            continue;
          case 6:
            if (str2 == Casl.a("삅\xE187\xE689\xE98B\xD88D\xF58F\xE091\xE793ﾕ\xF797\xF499", A_1))
            {
              oDataOut = (object) FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
              num1 = 21;
              continue;
            }
            num1 = 0;
            continue;
          case 7:
            try
            {
              int num2 = 4;
              while (true)
              {
                Assembly current = null;
                string str3 = null;
                switch (num2)
                {
                  case 0:
                    goto label_31;
                  case 1:
                    assembly = current;
                    str1 = sCommandName.Remove(0, str3.Length);
                    num2 = 3;
                    continue;
                  case 2:
                    if (!enumerator.MoveNext())
                    {
                      num2 = 5;
                      continue;
                    }
                    current = enumerator.Current;
                    str3 = this.commandPrefix + current.GetName().Name + Casl.a("ꢅ", A_1);
                    num2 = 6;
                    continue;
                  case 5:
                    num2 = 0;
                    continue;
                  case 6:
                    if (sCommandName.StartsWith(str3))
                    {
                      num2 = 1;
                      continue;
                    }
                    break;
                }
                num2 = 2;
              }
            }
            finally
            {
              enumerator.Dispose();
            }
          case 9:
            num1 = 5;
            continue;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 14;
              continue;
            }
            break;
          case 12:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 15;
              continue;
            }
            goto label_46;
          case 13:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 3;
            continue;
          case 14:
            enumerator = this.assemblyList.GetEnumerator();
            num1 = 7;
            continue;
          case 15:
            num1 = 23;
            continue;
          case 16:
            if (str2 == Casl.a("삅ﶇ\xE689\xE08B\xE08D\xF18Fﾑ\xF193", A_1))
            {
              oDataOut = (object) assembly.FullName;
              num1 = 1;
              continue;
            }
            num1 = 9;
            continue;
          case 17:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 11;
            continue;
          case 18:
            if (1 == 0)
              ;
            num1 = 16;
            continue;
          case 19:
            if (!(str2 == Casl.a("킅\xED87\xF889ﾋ\xE78Dﾏﲑ", A_1)))
            {
              num1 = 2;
              continue;
            }
            oDataOut = (object) assembly.GetName().Version.ToString();
            num1 = 20;
            continue;
          case 22:
            num1 = 19;
            continue;
          case 23:
            if ((str2 = str1) != null)
            {
              num1 = 18;
              continue;
            }
            goto case 17;
          default:
            goto label_2;
        }
label_31:
        num1 = 12;
      }
label_46:
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
