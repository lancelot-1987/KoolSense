// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPluginLoader
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Reflection;

namespace hpCasl
{
  internal class CommandPluginLoader : CommandPlugin
  {
    private CommandPluginLoader.SupportedGetCommandsDelegate supportedGetCommands;
    private CommandPluginLoader.TypeOfGetDelegate typeOfGet;
    private CommandPluginLoader.IsGetSupportedDelegate isGetSupported;
    private CommandPluginLoader.IsGetSecuredDelegate isGetSecured;
    private CommandPluginLoader.GetDelegate get;
    private CommandPluginLoader.SupportedSetCommandsDelegate supportedSetCommands;
    private CommandPluginLoader.TypeOfSetDelegate typeOfSet;
    private CommandPluginLoader.IsSetSupportedDelegate isSetSupported;
    private CommandPluginLoader.IsSetSecuredDelegate isSetSecured;
    private CommandPluginLoader.SetDelegate set;
    private CommandPluginLoader.SupportedExecuteCommandsDelegate supportedExecuteCommands;
    private CommandPluginLoader.TypeOfExecuteDelegate typeOfExecute;
    private CommandPluginLoader.IsExecuteSupportedDelegate isExecuteSupported;
    private CommandPluginLoader.IsExecuteSecuredDelegate isExecuteSecured;
    private CommandPluginLoader.ExecuteDelegate execute;
    private Assembly pluginAssembly;

    public override Assembly PluginAssembly
    {
      get
      {
        return this.pluginAssembly;
      }
    }

    public static CommandPluginLoader Load(string sPath)
    {
      int A_1 = 18;
label_2:
      CommandPluginLoader commandPluginLoader = (CommandPluginLoader) null;
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
            goto label_59;
          default:
            goto label_2;
        }
      }
label_4:
      try
      {
label_6:
        object instance = Activator.CreateInstance(assembly.GetType(Casl.a("\xE78E\xE190킒\xF494\xE496\xF598떚\xDE9C\xF09E철캢쒤즦춨ﮪ솬\xDAAE횰\xDAB2\xDBB4", A_1)));
        commandPluginLoader = new CommandPluginLoader();
        commandPluginLoader.pluginAssembly = assembly;
        commandPluginLoader.supportedGetCommands = (CommandPluginLoader.SupportedGetCommandsDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.SupportedGetCommandsDelegate), instance, Casl.a("\xDC8E\xE490\xE392\xE594\xF896\xEB98\xEF9A\xF89Cﮞ\xE6A0욢톤\xE4A6욨욪사캮\xDFB0ힲ운", A_1));
        commandPluginLoader.typeOfGet = (CommandPluginLoader.TypeOfGetDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.TypeOfGetDelegate), instance, Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ\xDC9A\xF89C\xEB9E", A_1));
        commandPluginLoader.isGetSupported = (CommandPluginLoader.IsGetSupportedDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsGetSupportedDelegate), instance, Casl.a("욎\xE290풒\xF094\xE396쪘\xEE9A\xED9C\xEF9E캠톢톤슦춨", A_1));
        commandPluginLoader.isGetSecured = (CommandPluginLoader.IsGetSecuredDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsGetSecuredDelegate), instance, Casl.a("욎\xE290풒\xF094\xE396쪘ﺚﺜ\xEA9E펠욢솤", A_1));
        commandPluginLoader.get = (CommandPluginLoader.GetDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.GetDelegate), instance, Casl.a("좎\xF490\xE792", A_1));
        commandPluginLoader.supportedSetCommands = (CommandPluginLoader.SupportedSetCommandsDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.SupportedSetCommandsDelegate), instance, Casl.a("\xDC8E\xE490\xE392\xE594\xF896\xEB98\xEF9A\xF89Cﮞ\xF2A0욢톤\xE4A6욨욪사캮\xDFB0ힲ운", A_1));
        commandPluginLoader.typeOfSet = (CommandPluginLoader.TypeOfSetDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.TypeOfSetDelegate), instance, Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ좚\xF89C\xEB9E", A_1));
        commandPluginLoader.isSetSupported = (CommandPluginLoader.IsSetSupportedDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsSetSupportedDelegate), instance, Casl.a("욎\xE290삒\xF094\xE396쪘\xEE9A\xED9C\xEF9E캠톢톤슦춨", A_1));
        commandPluginLoader.isSetSecured = (CommandPluginLoader.IsSetSecuredDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsSetSecuredDelegate), instance, Casl.a("욎\xE290삒\xF094\xE396쪘ﺚﺜ\xEA9E펠욢솤", A_1));
        commandPluginLoader.set = (CommandPluginLoader.SetDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.SetDelegate), instance, Casl.a("\xDC8E\xF490\xE792", A_1));
        commandPluginLoader.supportedExecuteCommands = (CommandPluginLoader.SupportedExecuteCommandsDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.SupportedExecuteCommandsDelegate), instance, Casl.a("\xDC8E\xE490\xE392\xE594\xF896\xEB98\xEF9A\xF89Cﮞ\xE4A0\xDBA2삤쒦\xDCA8\xDFAA좬\xECAE\xDEB0\xDEB2\xD8B4횶ힸ\xDFBA캼", A_1));
        commandPluginLoader.typeOfExecute = (CommandPluginLoader.TypeOfExecuteDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.TypeOfExecuteDelegate), instance, Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ\xDE9A\xE59C爵슠횢톤슦", A_1));
        commandPluginLoader.isExecuteSupported = (CommandPluginLoader.IsExecuteSupportedDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsExecuteSupportedDelegate), instance, Casl.a("욎\xE290횒\xED94\xF296滛\xEE9A\xE99C爵\xF2A0횢햤\xD7A6욨\xD9AA\xD9AC쪮햰", A_1));
        commandPluginLoader.isExecuteSecured = (CommandPluginLoader.IsExecuteSecuredDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.IsExecuteSecuredDelegate), instance, Casl.a("욎\xE290횒\xED94\xF296滛\xEE9A\xE99C爵\xF2A0욢욤튦\xDBA8캪즬", A_1));
        commandPluginLoader.execute = (CommandPluginLoader.ExecuteDelegate) Delegate.CreateDelegate(typeof (CommandPluginLoader.ExecuteDelegate), instance, Casl.a("쪎\xE990\xF692\xF694\xE296\xED98ﺚ", A_1));
        int num2 = 12;
        while (true)
        {
          switch (num2)
          {
            case 0:
              num2 = 27;
              continue;
            case 1:
              if (commandPluginLoader.typeOfGet != null)
              {
                num2 = 2;
                continue;
              }
              goto case 18;
            case 2:
              num2 = 28;
              continue;
            case 3:
              if (commandPluginLoader.isExecuteSecured != null)
              {
                num2 = 15;
                continue;
              }
              goto case 18;
            case 4:
              num2 = 1;
              continue;
            case 5:
              goto label_59;
            case 6:
              num2 = 30;
              continue;
            case 7:
              if (commandPluginLoader.isGetSecured != null)
              {
                num2 = 17;
                continue;
              }
              goto case 18;
            case 8:
              num2 = 5;
              continue;
            case 9:
              if (commandPluginLoader.supportedExecuteCommands != null)
              {
                num2 = 31;
                continue;
              }
              goto case 18;
            case 10:
              if (commandPluginLoader.isExecuteSupported != null)
              {
                num2 = 21;
                continue;
              }
              goto case 18;
            case 11:
              num2 = 19;
              continue;
            case 12:
              if (commandPluginLoader.supportedGetCommands != null)
              {
                num2 = 4;
                continue;
              }
              goto case 18;
            case 13:
              num2 = 14;
              continue;
            case 14:
              if (commandPluginLoader.supportedSetCommands != null)
              {
                num2 = 11;
                continue;
              }
              goto case 18;
            case 15:
              num2 = 23;
              continue;
            case 16:
              if (commandPluginLoader.set != null)
              {
                num2 = 29;
                continue;
              }
              goto case 18;
            case 17:
              num2 = 22;
              continue;
            case 18:
              commandPluginLoader = (CommandPluginLoader) null;
              num2 = 8;
              continue;
            case 19:
              if (commandPluginLoader.typeOfSet != null)
              {
                num2 = 0;
                continue;
              }
              goto case 18;
            case 20:
              num2 = 10;
              continue;
            case 21:
              num2 = 3;
              continue;
            case 22:
              if (commandPluginLoader.get != null)
              {
                num2 = 13;
                continue;
              }
              goto case 18;
            case 23:
              if (commandPluginLoader.execute == null)
              {
                num2 = 18;
                continue;
              }
              goto case 8;
            case 24:
              num2 = 16;
              continue;
            case 25:
              if (commandPluginLoader.typeOfExecute != null)
              {
                num2 = 20;
                continue;
              }
              goto case 18;
            case 26:
              num2 = 7;
              continue;
            case 27:
              if (commandPluginLoader.isSetSupported != null)
              {
                num2 = 6;
                continue;
              }
              goto case 18;
            case 28:
              if (commandPluginLoader.isGetSupported != null)
              {
                num2 = 26;
                continue;
              }
              goto case 18;
            case 29:
              num2 = 9;
              continue;
            case 30:
              if (commandPluginLoader.isSetSecured != null)
              {
                num2 = 24;
                continue;
              }
              goto case 18;
            case 31:
              num2 = 25;
              continue;
            default:
              goto label_6;
          }
        }
      }
      catch
      {
        commandPluginLoader = (CommandPluginLoader) null;
      }
label_59:
      return commandPluginLoader;
    }

    public override string[] SupportedGetCommands()
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
            if (this.supportedGetCommands != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          case 1:
            strArray = this.supportedGetCommands();
            num = 2;
            continue;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      return strArray;
    }

    public override enReturnCode TypeOfGet(string sCommandName, out Type typeOut)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      typeOut = (Type) null;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.typeOfGet != null)
            {
              num = 2;
              continue;
            }
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 3;
            continue;
          case 1:
          case 3:
            goto label_8;
          case 2:
            enReturnCode = this.typeOfGet(sCommandName, out typeOut);
            if (1 == 0)
              ;
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
label_2:
      bool flag = false;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.isGetSupported != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 1:
            goto label_6;
          case 2:
            flag = this.isGetSupported(sCommandName);
            num = 1;
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

    public override enReturnCode Get(string sCommandName, out object oDataOut)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      oDataOut = (object) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = this.get(sCommandName, out oDataOut);
            num = 5;
            continue;
          case 1:
            if (!Global.AllowSecured)
            {
              num = 6;
              continue;
            }
            goto case 7;
          case 2:
            if (this.get == null)
            {
              num = 3;
              continue;
            }
            goto case 12;
          case 3:
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            if (1 == 0)
              ;
            num = 12;
            continue;
          case 4:
            num = 10;
            continue;
          case 5:
            goto label_21;
          case 6:
            enReturnCode = enReturnCode.e_INVALID_HP_SIGNATURE;
            num = 7;
            continue;
          case 7:
            num = 8;
            continue;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 0;
              continue;
            }
            goto label_21;
          case 9:
            num = 1;
            continue;
          case 10:
            if (this.isGetSecured(sCommandName))
            {
              num = 9;
              continue;
            }
            goto case 7;
          case 11:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 12:
            num = 11;
            continue;
          default:
            goto label_2;
        }
      }
label_21:
      return enReturnCode;
    }

    public override string[] SupportedSetCommands()
    {
label_2:
      if (1 == 0)
        ;
      string[] strArray = (string[]) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            strArray = this.supportedSetCommands();
            num = 0;
            continue;
          case 2:
            if (this.supportedSetCommands != null)
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
      return strArray;
    }

    public override enReturnCode TypeOfSet(string sCommandName, out Type typeIn)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      typeIn = (Type) null;
      if (1 == 0)
        ;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.typeOfSet != null)
            {
              num = 2;
              continue;
            }
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 1;
            continue;
          case 1:
          case 3:
            goto label_8;
          case 2:
            enReturnCode = this.typeOfSet(sCommandName, out typeIn);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      return enReturnCode;
    }

    public override bool IsSetSupported(string sCommandName)
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
            if (this.isSetSupported != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            if (1 == 0)
              ;
            flag = this.isSetSupported(sCommandName);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return flag;
    }

    public override enReturnCode Set(string sCommandName, object oDataIn)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 2;
            continue;
          case 1:
            if (this.set == null)
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 12;
              continue;
            }
            goto label_21;
          case 3:
            num = 6;
            continue;
          case 4:
            num = 8;
            continue;
          case 5:
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 7;
            continue;
          case 6:
            if (this.isSetSecured(sCommandName))
            {
              num = 4;
              continue;
            }
            goto case 0;
          case 7:
            num = 9;
            continue;
          case 8:
            if (!Global.AllowSecured)
            {
              num = 10;
              continue;
            }
            goto case 0;
          case 9:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto case 0;
          case 10:
            enReturnCode = enReturnCode.e_INVALID_HP_SIGNATURE;
            if (1 == 0)
              ;
            num = 0;
            continue;
          case 11:
            goto label_21;
          case 12:
            enReturnCode = this.set(sCommandName, oDataIn);
            num = 11;
            continue;
          default:
            goto label_2;
        }
      }
label_21:
      return enReturnCode;
    }

    public override string[] SupportedExecuteCommands()
    {
label_2:
      string[] strArray = (string[]) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            strArray = this.supportedExecuteCommands();
            if (1 == 0)
              ;
            num = 1;
            continue;
          case 1:
            goto label_7;
          case 2:
            if (this.supportedExecuteCommands != null)
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
      return strArray;
    }

    public override enReturnCode TypeOfExecute(string sCommandName, out Type tDataIn, out Type tDataOut)
    {
label_3:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      tDataIn = (Type) null;
      tDataOut = (Type) null;
      int num = 4;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto label_11;
          case 1:
            enReturnCode = this.typeOfExecute(sCommandName, out tDataIn, out tDataOut);
            num = 5;
            continue;
          case 2:
            num = 0;
            continue;
          case 3:
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 2;
            continue;
          case 4:
            if (this.typeOfExecute == null)
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 5:
            goto label_11;
          default:
            goto label_3;
        }
      }
label_11:
      return enReturnCode;
    }

    public override bool IsExecuteSupported(string sCommandName)
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
            flag = this.isExecuteSupported(sCommandName);
            num = 0;
            continue;
          case 2:
            if (this.isExecuteSupported != null)
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

    public override enReturnCode Execute(string sCommandName, object oDataIn, out object oDataOut)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      oDataOut = (object) null;
      int num = 11;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 9;
            continue;
          case 1:
            num = 3;
            continue;
          case 2:
            enReturnCode = this.execute(sCommandName, oDataIn, out oDataOut);
            num = 8;
            continue;
          case 3:
            if (!Global.AllowSecured)
            {
              num = 12;
              continue;
            }
            goto case 0;
          case 4:
            num = 6;
            continue;
          case 5:
            num = 10;
            continue;
          case 6:
            if (this.isExecuteSecured(sCommandName))
            {
              num = 1;
              continue;
            }
            goto case 0;
          case 7:
            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
            num = 5;
            continue;
          case 8:
            goto label_21;
          case 9:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_21;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto case 0;
          case 11:
            if (this.execute == null)
            {
              num = 7;
              continue;
            }
            goto case 5;
          case 12:
            enReturnCode = enReturnCode.e_INVALID_HP_SIGNATURE;
            if (1 == 0)
              ;
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_21:
      return enReturnCode;
    }

    private delegate string[] SupportedGetCommandsDelegate();

    private delegate enReturnCode TypeOfGetDelegate(string sCommandName, out Type typeOut);

    private delegate bool IsGetSupportedDelegate(string sCommandName);

    private delegate bool IsGetSecuredDelegate(string sCommandName);

    private delegate enReturnCode GetDelegate(string sCommandName, out object data);

    private delegate string[] SupportedSetCommandsDelegate();

    private delegate enReturnCode TypeOfSetDelegate(string sCommandName, out Type typeIn);

    private delegate bool IsSetSupportedDelegate(string sCommandName);

    private delegate bool IsSetSecuredDelegate(string sCommandName);

    private delegate enReturnCode SetDelegate(string sCommandName, object data);

    private delegate string[] SupportedExecuteCommandsDelegate();

    private delegate enReturnCode TypeOfExecuteDelegate(string sCommandName, out Type dataIn, out Type dataOut);

    private delegate bool IsExecuteSupportedDelegate(string sCommandName);

    private delegate bool IsExecuteSecuredDelegate(string sCommandName);

    private delegate enReturnCode ExecuteDelegate(string sCommandName, object dataIn, out object dataOut);
  }
}
