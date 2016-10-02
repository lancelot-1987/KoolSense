// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPlugin
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi;
using System;
using System.Diagnostics;

namespace hpCasl
{
  public class CommandPlugin
  {
    private Command[] commandList;
    private CaslLogger log;
    private bool m_bCallingAssemblyIsCasl;

    public CommandPlugin()
    {
      int A_1 = 6;
      this.commandList = new Command[11]
      {
        (Command) new CommandFeature(),
        (Command) new CommandWireless(),
        (Command) new CommandPMC(),
        (Command) new CommandALS(),
        (Command) new CommandPanelBrightness(),
        (Command) new CommandSmartAdapter(),
        (Command) new CommandBattery(),
        (Command) new CommandDiags(),
        (Command) new CommandDebug(),
        (Command) new CommandF10Setting(),
        (Command) new CommandLidSwitch(),
   
      };
      this.log = new CaslLogger();
      // ISSUE: explicit constructor call

      this.log.InformationMessage(this.GetType().ToString(), Module.a("ཋ⅍㵏㽑㕓㡕㱗ਖ਼せ\x2B5Dݟୡ\x0A63", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗穙㽛㙝՟šལཥ٧൩䱫ᩭᡯ\x1771味ᕵ\x1977ᙹၻ\x177D\xEE7F\xE581ꒃ\xE785ﮇ黎\xE98B\xE38D\xF28Fﺑ\xED93", A_1));
      bool flag = false;
      StackTrace stackTrace = new StackTrace(true);
      int index=0;
      for (index = 0; index < stackTrace.FrameCount; ++index)
      {
        StackFrame frame = stackTrace.GetFrame(index);
        frame.GetFileName();
        string fullName = frame.GetMethod().DeclaringType.Assembly.FullName;
        if (fullName.StartsWith(Module.a("\x244B㹍㍏㍑❓㩕", A_1)) && fullName.EndsWith(Module.a("畋ⵍ晏㑑汓敕㱗潙㹛楝ٟ兡c噥內嵩", A_1)))
        {
          flag = true;
          break;
        }
      }
      this.log.InformationMessage(this.GetType().ToString(), Module.a("ཋ⅍㵏㽑㕓㡕㱗ਖ਼せ\x2B5Dݟୡ\x0A63", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝͟\x0A61ţեͧͩɫ७偯ٱᱳ\x1375塷\x1979ᵻች\xEC7F\xEB81\xEA83\xE185ꢇ\xEB89ﾋﶍ\xF58Fﾑ\xF693歹\xE197몙놛뎝肟薡\xE7A3장\xDBA7용讫躭\xD9AF솱钳", A_1) + flag.ToString() + Module.a("手湍", A_1) + index.ToString() + Module.a("汋㹍ㅏ\x2151❓㍕⭗瑙", A_1));
      if (flag)
        this.m_bCallingAssemblyIsCasl = true;
      else
        this.m_bCallingAssemblyIsCasl = false;
    }

    private string[] Merge(string[] array1, string[] array2)
    {
label_2:
      int index = 0;
      int num1 = 0;
      int num2 = 5;
      string[] strArray=null;
      while (true)
      {
        switch (num2)
        {
          case 0:
            num1 = array2.Length;
            num2 = 8;
            continue;
          case 1:
            goto label_19;
          case 2:
            if (num1 != 0)
            {
              num2 = 7;
              continue;
            }
            goto label_19;
          case 3:
            if (index != 0)
            {
              num2 = 6;
              continue;
            }
            break;
          case 4:
            index = array1.Length;
            num2 = 10;
            continue;
          case 5:
            if (array1 != null)
            {
              num2 = 4;
              continue;
            }
            goto case 10;
          case 6:
            array1.CopyTo((Array) strArray, 0);
            num2 = 11;
            continue;
          case 7:
            array2.CopyTo((Array) strArray, index);
            num2 = 1;
            continue;
          case 8:
            strArray = new string[index + num1];
            num2 = 3;
            continue;
          case 9:
            if (array2 != null)
            {
              num2 = 0;
              continue;
            }
            goto case 8;
          case 10:
            num2 = 9;
            continue;
          case 11:
            if (1 == 0)
              break;
            break;
          default:
            goto label_2;
        }
        num2 = 2;
      }
label_19:
      return strArray;
    }

    public string[] SupportedGetCommands()
    {
      int A_1 = 11;
label_2:
      string[] array1 = (string[]) null;
      int num = 4;
      int index=0;
      Command[] commandArray=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 6;
            continue;
          case 1:
            if (1 == 0)
              ;
            commandArray = this.commandList;
            index = 0;
            num = 2;
            continue;
          case 2:
          case 3:
            num = 7;
            continue;
          case 4:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 1;
              continue;
            }
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ɐ♒╔❖㙘⥚⥜㩞\x0560\x2462d፦⩨Ѫlɮၰᵲᅴ", A_1), Module.a("ၐ❒\x2154\x3256㑘\x2B5A⥜罞ᕠౢ䕤Ѧ\x0868ݪŬ佮噰\x0872䕴\x0A76幸孺Ṽၾ\xEC80\xEE82\xE484\xE986\xED88\xAB8A\xE98C\xE68E\xF590뎒ﮔ\xF896\xED98뮚煮\xF09E膠힢춤햦욨\xDEAA쪬잮醰\xF0B2\xF4B4\xE4B6\xF5B8鮺톼횾ꏀ뇂꓄뗆냈\xE5CA", A_1));
            num = 5;
            continue;
          case 5:
          case 6:
            goto label_13;
          case 7:
            if (index >= commandArray.Length)
            {
              num = 0;
              continue;
            }
            Command command = commandArray[index];
            array1 = this.Merge(array1, command.SupportedGetCommands());
            ++index;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_13:
      return array1;
    }

    public enReturnCode TypeOfGet(string sCommandName, out Type tDataOut)
    {
      int A_1 = 0;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataOut = (Type) null;
      int num = 10;
      int index=0;
      Command[] commandArray=null;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_19;
          case 1:
            num = 5;
            continue;
          case 2:
          case 4:
            num = 6;
            continue;
          case 3:
            goto label_19;
          case 5:
            goto label_15;
          case 6:
            if (index >= commandArray.Length)
            {
              num = 1;
              continue;
            }
            command = commandArray[index];
            num = 11;
            continue;
          case 7:
            commandArray = this.commandList;
            index = 0;
            num = 2;
            continue;
          case 8:
            ++index;
            num = 4;
            continue;
          case 9:
            enReturnCode = command.TypeOfGet(sCommandName, out tDataOut);
            num = 0;
            continue;
          case 10:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 7;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ቅㅇ㩉⥋ō㙏ᕑㅓ≕", A_1), Module.a("݅㱇㹉⥋⍍⁏♑瑓≕㝗穙㽛㽝\x0C5F\x0E61䑣䅥፧婩ᅫ䥭偯ᅱ᭳᭵ᕷ᭹ቻ\x1A7Dꁿ\xE681\xED83\xE285ꢇ\xE489\xE38B揄낏\xF591ﮓ뚕\xEC97\xF299\xEE9B\xF19D햟얡첣蚥\xEBA7\xEBA9ﾫ\xE2AD邯\xDEB1\xDDB3풵쪷\xDBB9캻잽\xEEBF", A_1), (object) sCommandName);
            num = 3;
            continue;
          case 11:
            if (command.IsGetSupported(sCommandName))
            {
              num = 9;
              continue;
            }
            goto case 8;
          default:
            goto label_2;
        }
      }
label_15:
      if (1 == 0)
        ;
label_19:
      return enReturnCode;
    }

    public bool IsGetSecured(string sCommandName)
    {
label_2:
      bool flag = false;
      Command[] commandArray = this.commandList;
      int index = 0;
      int num = 0;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 6:
            num = 3;
            continue;
          case 1:
            if (!command.IsGetSupported(sCommandName))
            {
              ++index;
              num = 6;
              continue;
            }
            num = 2;
            continue;
          case 2:
            flag = command.IsGetSecured(sCommandName);
            num = 5;
            continue;
          case 3:
            if (1 == 0)
              ;
            if (index < commandArray.Length)
            {
              command = commandArray[index];
              num = 1;
              continue;
            }
            num = 4;
            continue;
          case 4:
          case 5:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_12:
      return flag;
    }

    public bool IsGetSupported(string sCommandName)
    {
      bool flag=false;
      try
      {
        flag = Array.IndexOf<string>(this.SupportedGetCommands(), sCommandName) != -1;
      }
      catch
      {
        flag = false;
      }
      if (1 == 0)
        ;
      return flag;
    }

    public enReturnCode Get(string sCommandName, out object dataOut)
    {
      int A_1 = 6;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244F", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗穙ݛⵝ⍟ൡॣ\x0B65१ѩ\x086B\x206Dᅯάᅳ䱵", A_1) + sCommandName + Module.a("ᅋ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      dataOut = (object) null;
      int num = 6;
      int index=0;
      Command[] commandArray=null;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = command.Get(sCommandName, out dataOut);
            num = 8;
            continue;
          case 1:
            if (!command.IsGetSupported(sCommandName))
            {
              ++index;
              num = 2;
              continue;
            }
            num = 0;
            continue;
          case 2:
          case 3:
            num = 4;
            continue;
          case 4:
            if (1 == 0)
              ;
            if (index >= commandArray.Length)
            {
              num = 5;
              continue;
            }
            command = commandArray[index];
            num = 1;
            continue;
          case 5:
            num = 7;
            continue;
          case 6:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 10;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244F", A_1), Module.a("ോ㩍\x244F㝑㥓♕ⱗ穙⡛ㅝ䁟šգ\x0A65ѧ䩩䭫ᕭ䁯ཱ即噵᭷ᕹᅻ\x137D\xE17F\xEC81\xE083ꚅ\xEC87\xE389\xE88B꺍ﺏ\xFD91\xE093뚕ﾗ\xF599벛\xEA9D좟킡쮣펥쾧슩貫\xEDAD\xF1AF\xE1B1\xF8B3隵풷펹\xDEBB첽ꆿ냁뷃\xE8C5", A_1), (object) sCommandName);
            num = 9;
            continue;
          case 7:
          case 8:
          case 9:
            goto label_17;
          case 10:
            commandArray = this.commandList;
            index = 0;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244F", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65剧䩩", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public string[] SupportedSetCommands()
    {
      int A_1 = 7;
label_2:
      string[] array1 = (string[]) null;
      int num = 2;
      int index=0;
      Command[] commandArray=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (index >= commandArray.Length)
            {
              num = 4;
              continue;
            }
            Command command = commandArray[index];
            array1 = this.Merge(array1, command.SupportedSetCommands());
            ++index;
            num = 7;
            continue;
          case 1:
          case 7:
            num = 0;
            continue;
          case 2:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 6;
              continue;
            }
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ṍ㩎\x2150⍒㩔╖ⵘ㹚㥜\x0C5EѠᝢ♤\x0866Ѩ٪౬Ůᕰr", A_1), Module.a("ౌ㭎═㙒㡔❖ⵘ筚⥜ぞ䅠bѤ୦ը䭪䩬ᑮ䅰\x0E72剴坶᩸ᑺၼቾ\xE080\xED82\xE184Ꞇ\xED88\xE28A\xE98C꾎ﾐﲒ\xE194랖ﺘ\xF49A붜\xEB9E즠톢쪤튦캨쎪趬\xECAE\xF0B0\xE0B2領鞶햸튺\xDFBC춾ꃀ뇂별\xE9C6", A_1));
            num = 3;
            continue;
          case 3:
          case 5:
            goto label_13;
          case 4:
            num = 5;
            continue;
          case 6:
            if (1 == 0)
              ;
            commandArray = this.commandList;
            index = 0;
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_13:
      return array1;
    }

    public enReturnCode TypeOfSet(string sCommandName, out Type tDataIn)
    {
      int A_1 = 7;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataIn = (Type) null;
      int num = 5;
      int index=0;
      Command[] commandArray=null;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 10;
              continue;
            }
            goto label_19;
          case 1:
            num = 6;
            continue;
          case 2:
            enReturnCode = command.TypeOfSet(sCommandName, out tDataIn);
            num = 0;
            continue;
          case 3:
            if (command.IsSetSupported(sCommandName))
            {
              num = 2;
              continue;
            }
            goto case 10;
          case 4:
            if (1 == 0)
              ;
            if (index >= commandArray.Length)
            {
              num = 1;
              continue;
            }
            command = commandArray[index];
            num = 3;
            continue;
          case 5:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 11;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("᥌㙎\x2150㙒ᩔㅖ\x0A58㹚⥜", A_1), Module.a("ౌ㭎═㙒㡔❖ⵘ筚⥜ぞ䅠bѤ୦ը䭪䩬ᑮ䅰\x0E72剴坶᩸ᑺၼቾ\xE080\xED82\xE184Ꞇ\xED88\xE28A\xE98C꾎ﾐﲒ\xE194랖ﺘ\xF49A붜\xEB9E즠톢쪤튦캨쎪趬\xECAE\xF0B0\xE0B2領鞶햸튺\xDFBC춾ꃀ뇂별\xE9C6", A_1), (object) sCommandName);
            num = 9;
            continue;
          case 6:
          case 9:
            goto label_19;
          case 7:
          case 8:
            num = 4;
            continue;
          case 10:
            ++index;
            num = 8;
            continue;
          case 11:
            commandArray = this.commandList;
            index = 0;
            num = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      return enReturnCode;
    }

    public bool IsSetSecured(string sCommandName)
    {
label_2:
      bool flag = false;
      Command[] commandArray = this.commandList;
      int index = 0;
      int num = 1;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (!command.IsSetSupported(sCommandName))
            {
              ++index;
              num = 5;
              continue;
            }
            num = 4;
            continue;
          case 1:
          case 5:
            if (1 == 0)
              ;
            num = 3;
            continue;
          case 2:
          case 6:
            goto label_12;
          case 3:
            if (index < commandArray.Length)
            {
              command = commandArray[index];
              num = 0;
              continue;
            }
            num = 6;
            continue;
          case 4:
            flag = command.IsSetSecured(sCommandName);
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      return flag;
    }

    public bool IsSetSupported(string sCommandName)
    {
      return Array.IndexOf<string>(this.SupportedSetCommands(), sCommandName) != -1;
    }

    public enReturnCode Set(string sCommandName, object dataIn)
    {
      int A_1 = 6;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ὃ\x2B4D\x244F", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗穙ݛⵝ⍟ൡॣ\x0B65१ѩ\x086B\x206Dᅯάᅳ䱵", A_1) + sCommandName + Module.a("ᅋ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Type tDataIn = (Type) null;
      if (1 == 0)
        ;
      int num = 20;
      Command command=null;
      Command[] commandArray=null;
      int index=0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (index >= commandArray.Length)
            {
              num = 11;
              continue;
            }
            command = commandArray[index];
            num = 14;
            continue;
          case 1:
          case 24:
            num = 5;
            continue;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            commandArray = this.commandList;
            index = 0;
            num = 21;
            continue;
          case 3:
            if (tDataIn != typeof (void))
            {
              num = 10;
              continue;
            }
            goto case 1;
          case 4:
          case 9:
          case 23:
            goto label_35;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_35;
          case 6:
            if (tDataIn != dataIn.GetType())
            {
              num = 13;
              continue;
            }
            goto case 1;
          case 7:
            enReturnCode = this.TypeOfSet(sCommandName, out tDataIn);
            num = 19;
            continue;
          case 8:
            num = dataIn != null ? 6 : 22;
            continue;
          case 10:
            num = 15;
            continue;
          case 11:
            num = 4;
            continue;
          case 12:
          case 21:
            num = 0;
            continue;
          case 13:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 1;
            continue;
          case 14:
            if (command.IsSetSupported(sCommandName))
            {
              num = 16;
              continue;
            }
            ++index;
            num = 12;
            continue;
          case 15:
            if (tDataIn != null)
            {
              num = 18;
              continue;
            }
            goto case 1;
          case 16:
            enReturnCode = command.Set(sCommandName, dataIn);
            num = 9;
            continue;
          case 17:
            num = 8;
            continue;
          case 18:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 24;
            continue;
          case 19:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 17;
              continue;
            }
            goto case 1;
          case 20:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 7;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Ὃ\x2B4D\x244F", A_1), Module.a("ോ㩍\x244F㝑㥓♕ⱗ穙⡛ㅝ䁟šգ\x0A65ѧ䩩䭫ᕭ䁯ཱ即噵᭷ᕹᅻ\x137D\xE17F\xEC81\xE083ꚅ\xEC87\xE389\xE88B꺍ﺏ\xFD91\xE093뚕ﾗ\xF599벛\xEA9D좟킡쮣펥쾧슩貫\xEDAD\xF1AF\xE1B1\xF8B3隵풷펹\xDEBB첽ꆿ냁뷃\xE8C5", A_1), (object) sCommandName);
            num = 23;
            continue;
          case 22:
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_35:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ὃ\x2B4D\x244F", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65剧䩩", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public string[] SupportedExecuteCommands()
    {
      int A_1 = 17;
label_2:
      string[] array1 = (string[]) null;
      int num = 0;
      int index=0;
      Command[] commandArray=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 1;
              continue;
            }
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("іⱘ\x2B5Aⵜぞ፠ᝢdͦⱨ\x136A\x086C౮Ѱݲၴ㑶ᙸᙺၼṾ\xEF80\xE782\xF684", A_1), Module.a("ᙖⵘ⽚㡜\x325Eᅠᝢ䕤፦٨䭪\x0E6C\x0E6Eᵰὲ啴偶ɸ䭺|塾ꆀ\xE082\xEA84\xEA86\xE488\xEA8A\xE38C\xEB8E놐\xF792ﲔ\xF396릘\xF59A\xF29C\xEB9E膠쒢쪤螦\xDDA8쎪\xDFAC삮쒰풲\xDDB4鞶視諸\xEEBC\xF3BE\xE1C0꿂계ꗆ믈\xAACA뿌뛎\xFFD0", A_1));
            num = 3;
            continue;
          case 1:
            commandArray = this.commandList;
            index = 0;
            num = 6;
            continue;
          case 2:
          case 3:
            goto label_13;
          case 4:
          case 6:
            num = 7;
            continue;
          case 5:
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 7:
            if (index >= commandArray.Length)
            {
              num = 5;
              continue;
            }
            Command command = commandArray[index];
            array1 = this.Merge(array1, command.SupportedExecuteCommands());
            ++index;
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_13:
      return array1;
    }

    public enReturnCode TypeOfExecute(string sCommandName, out Type tDataIn, out Type tDataOut)
    {
      int A_1 = 18;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataIn = (Type) null;
      tDataOut = (Type) null;
      int num = 7;
      int index=0;
      Command[] commandArray=null;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 1:
          case 5:
            goto label_17;
          case 2:
          case 4:
            if (1 == 0)
              ;
            num = 10;
            continue;
          case 3:
            enReturnCode = command.TypeOfExecute(sCommandName, out tDataIn, out tDataOut);
            num = 5;
            continue;
          case 6:
            if (!command.IsExecuteSupported(sCommandName))
            {
              ++index;
              num = 4;
              continue;
            }
            num = 3;
            continue;
          case 7:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 8;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("\x0C57⍙ⱛ㭝⽟ѡⅣṥ൧३ᥫᩭᕯ", A_1), Module.a("ᥗ\x2E59⡛㭝\x0D5Fቡၣ䙥ᱧթ䱫൭ᅯṱᡳ噵彷Ź䱻ͽꝿꊁ\xE783\xE985\xE587\xE789\xED8B\xE08D\xF48F늑\xF093ﾕﲗ몙\xF29B\xF19D풟芡쎣즥袧\xDEA9쒫\xDCAD\xDFAF잱펳\xDEB5颷惡ﶻ\xEDBD貿\xE2C1ꣃ꿅\xAAC7룉귋볍\xA9CFﳑ", A_1), (object) sCommandName);
            num = 0;
            continue;
          case 8:
            commandArray = this.commandList;
            index = 0;
            num = 2;
            continue;
          case 9:
            num = 1;
            continue;
          case 10:
            if (index >= commandArray.Length)
            {
              num = 9;
              continue;
            }
            command = commandArray[index];
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      return enReturnCode;
    }

    public bool IsExecuteSecured(string sCommandName)
    {
label_2:
      bool flag = false;
      Command[] commandArray = this.commandList;
      int index = 0;
      int num = 1;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
            goto label_12;
          case 1:
          case 3:
            num = 5;
            continue;
          case 4:
            if (!command.IsExecuteSupported(sCommandName))
            {
              ++index;
              if (1 == 0)
                ;
              num = 3;
              continue;
            }
            num = 6;
            continue;
          case 5:
            if (index < commandArray.Length)
            {
              command = commandArray[index];
              num = 4;
              continue;
            }
            num = 2;
            continue;
          case 6:
            flag = command.IsExecuteSecured(sCommandName);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      return flag;
    }

    public bool IsExecuteSupported(string sCommandName)
    {
      return Array.IndexOf<string>(this.SupportedExecuteCommands(), sCommandName) != -1;
    }

    public enReturnCode Execute(string sCommandName, object dataIn, out object dataOut)
    {
      int A_1 = 14;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅓ\x2E55㵗㥙⥛⩝՟", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ䉡㽣ᕥ\x2B67թūͭᅯᱱၳ㡵\x1977\x1779\x197B䑽", A_1) + sCommandName + Module.a("॓", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Type tDataIn = (Type) null;
      Type tDataOut = (Type) null;
      dataOut = (object) null;
      int num = 18;
      Command command=null;
      Command[] commandArray=null;
      int index=0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (command.IsExecuteSupported(sCommandName))
            {
              if (1 == 0)
                ;
              num = 9;
              continue;
            }
            ++index;
            num = 10;
            continue;
          case 1:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 24;
            continue;
          case 2:
          case 24:
            num = 14;
            continue;
          case 3:
          case 4:
          case 19:
            goto label_35;
          case 5:
            if (index >= commandArray.Length)
            {
              num = 6;
              continue;
            }
            command = commandArray[index];
            num = 0;
            continue;
          case 6:
            num = 4;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 16;
              continue;
            }
            goto case 2;
          case 8:
            num = dataIn != null ? 22 : 21;
            continue;
          case 9:
            enReturnCode = command.Execute(sCommandName, dataIn, out dataOut);
            num = 19;
            continue;
          case 10:
          case 23:
            num = 5;
            continue;
          case 11:
            if (tDataIn != typeof (void))
            {
              num = 12;
              continue;
            }
            goto case 2;
          case 12:
            num = 13;
            continue;
          case 13:
            if (tDataIn != null)
            {
              num = 17;
              continue;
            }
            goto case 2;
          case 14:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 15;
              continue;
            }
            goto label_35;
          case 15:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            commandArray = this.commandList;
            index = 0;
            num = 23;
            continue;
          case 16:
            num = 8;
            continue;
          case 17:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 2;
            continue;
          case 18:
            if (this.m_bCallingAssemblyIsCasl)
            {
              num = 20;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᅓ\x2E55㵗㥙⥛⩝՟", A_1), Module.a("ᕓ≕ⱗ㽙ㅛ\x2E5Dᑟ䉡ၣ॥䡧३൫ɭᱯ剱即\x0D75䡷ݹ孻幽\xE37F\xED81\xE983\xEB85\xE987\xE489\xE88B꺍\xF48Fﮑ\xF093뚕\xF697\xF599\xE89B뺝잟춡蒣튥삧\xD8A9쎫\xDBAD\xD7AF\xDAB1钳\xF5B5醴\xE9B9\xF0BB麽겿ꯁꛃ듅꧇룉뗋\xE0CD", A_1), (object) sCommandName);
            num = 3;
            continue;
          case 20:
            enReturnCode = this.TypeOfExecute(sCommandName, out tDataIn, out tDataOut);
            num = 7;
            continue;
          case 21:
            num = 11;
            continue;
          case 22:
            if (tDataIn != dataIn.GetType())
            {
              num = 1;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
      }
label_35:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅓ\x2E55㵗㥙⥛⩝՟", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭䩯剱", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }
  }
}
