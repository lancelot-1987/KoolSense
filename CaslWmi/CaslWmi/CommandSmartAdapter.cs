// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandSmartAdapter
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.IO;
using System.Xml;

namespace CaslWmi
{
  internal class CommandSmartAdapter : Command
  {
    private enReturnCode E1 = enReturnCode.e_NULL_VALUE;
    private bool? A1;
    private int? B1;
    private bool C1;

    private static string SmartAdapterEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ୗ㝙㵛ⱝᑟ⍡cݥᡧṩ५ᱭ㕯άų᩵\x1977\x0E79ᕻᅽ\xEE7F겁\xDC83쮅쒇", 18);
      }
    }

    private enReturnCode InitGet()
    {
      int A_1_1 = 9;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154ၖ㱘⽚", A_1_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1_1));
      this.C1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      this.A1 = new bool?();
      this.B1 = new int?();
      bool A_0 = false;
      int A_1_2 = 0;
      enReturnCode enReturnCode = CommandSmartAdapter.B(ref A_0, ref A_1_2);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            this.A1 = new bool?(A_0);
            this.B1 = new int?(A_1_2);
            num = 0;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
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
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154ၖ㱘⽚", A_1_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪ᙬ彮\x0C70", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode B(ref bool A_0, ref int A_1)
    {
      int A_1_1 = 18;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ╵ᕷ᭹\x0E7B\x0A7D셿\xE681\xE583\xF685ﲇ\xEF89ﺋ", A_1_1), Module.a("ὗ㽙⡛\x0D5D\x0D5F͡ᙣብ⥧\x0E69൫ṭѯ\x1771ٳ╵\x0C77᭹\x087B\x0B7D\xF37F", A_1_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      bool allowEmulation = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      if (1 == 0)
        ;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 3:
            goto label_8;
          case 1:
            if (allowEmulation)
            {
              num = 2;
              continue;
            }
            enReturnCode = CommandSmartAdapter.GetSmartAdapterStatusFromBIOS(ref A_0, ref A_1);
            num = 0;
            continue;
          case 2:
            enReturnCode = CommandSmartAdapter.A(ref A_0, ref A_1);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      caslLogger.FormatTraceOutMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ╵ᕷ᭹\x0E7B\x0A7D셿\xE681\xE583\xF685ﲇ\xEF89ﺋ", A_1_1), Module.a("ὗ㽙⡛\x0D5D\x0D5F͡ᙣብ⥧\x0E69൫ṭѯ\x1771ٳ╵\x0C77᭹\x087B\x0B7D\xF37F", A_1_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ味\x0D75䡷ݹ偻幽\xE27F톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691뒓\xAB95뢗\xE199궛\xE39D貟芡춣\xF5A5\xDCA7쮩\xD8AB\xDBAD쎯銱観隵袷승잻貽붿", A_1_1), (object) enReturnCode.ToString(), (object) A_0.ToString(), (object) A_1.ToString(Module.a("W", A_1_1)));
      return enReturnCode;
    }

    public static enReturnCode A(ref bool A_0, ref int A_1)
    {
      int A_1_1 = 16;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ❳᭵\x1977\x0879\x087B㽽\xE47F\xE381\xF483\xF285\xED87\xF889", A_1_1), Module.a("ᅕ㵗\x2E59ཛ㍝şၡၣ❥౧୩ᱫᩭᕯq❳ɵ\x1977\x0E79ॻൽ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1_1), Module.a("Օⱗ㭙\x2E5B⩝՟١", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 7;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 5;
              continue;
            }
            goto label_22;
          case 1:
            enReturnCode = enReturnCode.e_INVALID_XML;
            caslLogger.FormatErrorMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ❳᭵\x1977\x0879\x087B㽽\xE47F\xE381\xF483\xF285\xED87\xF889", A_1_1), Module.a("ᅕ㵗\x2E59ཛ㍝şၡၣ❥౧୩ᱫᩭᕯq❳ɵ\x1977\x0E79ॻൽ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1_1), Module.a("ὕ㙗ⱙ㵛\x325Dय़١䑣ၥ१٩ᥫ୭屯剱ཱི䙵շ噹屻\x187D\xF27F\xED81\xE983ꚅ\xED87\xE789曆\xE28D\xF18F\xE691ﶓ秊\xF697몙瀞\xF79D첟잡蒣삥잧\xD8A9貫ﶭ\xDDAF펱욳습醴\xDEB9\xDDBB캽뒿\xA7C1뛃\xE6C5믇뻉귋뫍ꗏꇑ", A_1_1), (object) A_1.ToString());
            num1 = 4;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 6;
              continue;
            }
            goto label_22;
          case 3:
            goto label_22;
          case 4:
            goto label_18;
          case 5:
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            A_1 = (int) xmlEdit.GetUInt32(Module.a("祕睗ᕙ⥛⩝ၟᝡၣ䥥Ⱨ୩ᡫ\x0F6D彯ⅱᥳ\x1775\x0A77\x0E79㵻\x1A7D\xE17F\xF281\xF083\xE385慎\xD989\xF88B\xEF8D\xE48F\xE791\xE793", A_1_1));
            num1 = 8;
            continue;
          case 6:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 0;
            continue;
          case 7:
            try
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(CommandSmartAdapter.SmartAdapterEmulationFile);
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_19;
                  case 3:
                    File.WriteAllText(CommandSmartAdapter.SmartAdapterEmulationFile, Resources.SmartAdapterEmulation);
                    num2 = 0;
                    continue;
                  default:
                    if (!File.Exists(CommandSmartAdapter.SmartAdapterEmulationFile))
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 0;
                }
              }
            }
            catch (Exception ex)
            {
              caslLogger.FormatErrorMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ❳᭵\x1977\x0879\x087B㽽\xE47F\xE381\xF483\xF285\xED87\xF889", A_1_1), Module.a("ᅕ㵗\x2E59ཛ㍝şၡၣ❥౧୩ᱫᩭᕯq❳ɵ\x1977\x0E79ॻൽ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1_1), Module.a("ፕ⁗㥙㥛\x2E5Dᑟୡୣ\x0865䡧٩ͫ\x0F6Dᑯ᭱ᩳᅵ塷όᅻ\x0B7D\xEC7F\xE381\xF083\xEF85\xE787\xE489겋\xE88D憐ﺑ\xF193겕뢗붙\xE79B꾝\xDD9F薡", A_1_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_19:
            num1 = 2;
            continue;
          case 8:
            if (A_1 > 3)
            {
              num1 = 1;
              continue;
            }
            A_0 = A_1 > 0;
            num1 = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_18:
      if (1 == 0)
        ;
label_22:
      caslLogger.FormatTraceOutMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ❳᭵\x1977\x0879\x087B㽽\xE47F\xE381\xF483\xF285\xED87\xF889", A_1_1), Module.a("ᅕ㵗\x2E59ཛ㍝şၡၣ❥౧୩ᱫᩭᕯq❳ɵ\x1977\x0E79ॻൽ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ剱ཱི䙵շ噹屻\x1C7D퍿\xF781\xF483\xF685\xE787\xF889\xF88B\xEB8D\xF48F늑ꦓ뚕\xE397\xAB99\xE19B늝肟쮡\xF7A3튥즧\xDEA9\xD9AB\xDDAD邯辱钳蚵삷솹躻쎽", A_1_1), (object) enReturnCode.ToString(), (object) A_0.ToString(), (object) A_1.ToString(Module.a("๕", A_1_1)));
      return enReturnCode;
    }

    public static enReturnCode GetSmartAdapterStatusFromBIOS(ref bool bSupported, ref int iStatus)
    {
      int A_1 = 15;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ\x2072ᡴᙶ\x0B78ེ㱼\x1B7E\xE080\xF382\xF184\xE286ﮈ", A_1), Module.a("ቔ\x3256ⵘ࡚ぜ㹞፠ᝢ\x2464ͦ\x0868᭪ᥬ੮Ͱ\x2072Ŵᙶ\x0D78\x0E7A\x0E7C㥾\xF380\xEC82\xE884얆삈쒊\xDE8C", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            iStatus = BitConverter.ToInt32(dataOut, 0);
            bSupported = iStatus > 0;
            num = 4;
            continue;
          case 1:
            iStatus = 0;
            bSupported = false;
            enReturnCode = enReturnCode.e_OK;
            num = 3;
            continue;
          case 2:
            num = enReturnCode != enReturnCode.e_OK ? 9 : 0;
            continue;
          case 3:
          case 7:
          case 8:
            goto label_14;
          case 4:
            goto label_12;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 6;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            caslLogger.ErrorMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ\x2072ᡴᙶ\x0B78ེ㱼\x1B7E\xE080\xF382\xF184\xE286ﮈ", A_1), Module.a("ቔ\x3256ⵘ࡚ぜ㹞፠ᝢ\x2464ͦ\x0868᭪ᥬ੮Ͱ\x2072Ŵᙶ\x0D78\x0E7A\x0E7C㥾\xF380\xEC82\xE884얆삈쒊\xDE8C", A_1), Module.a("᱔㥖⩘⽚㱜ㅞᕠ\x0A62Ѥ፦hѪͬ佮Ṱᕲ啴\x2076ᑸቺ㽼㙾캀킂욄\xEB86\xE088\xEE8A\xE38Cﮎ놐\xE192\xF094\xE396\xEC98\xE99A\xF39C爵얠莢쮤튦얨잪", A_1));
            num = 8;
            continue;
          case 6:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.SmartAdapterStatus, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_4);
            num = 2;
            continue;
          case 9:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              caslLogger.FormatErrorMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ\x2072ᡴᙶ\x0B78ེ㱼\x1B7E\xE080\xF382\xF184\xE286ﮈ", A_1), Module.a("ቔ\x3256ⵘ࡚ぜ㹞፠ᝢ\x2464ͦ\x0868᭪ᥬ੮Ͱ\x2072Ŵᙶ\x0D78\x0E7A\x0E7C㥾\xF380\xEC82\xE884얆삈쒊\xDE8C", A_1), Module.a("ၔ╖⭘㑚⽜罞᩠卢ᡤ䝦ཨᥪɬɮ兰ㅲ㱴㡶⩸孺⩼㉾좀ꎂ\xE684\xE686\xE588\xE78A권\xDD8E\xF490\xF292\xF194뢖ꦘ\xDD9A\xF59C뾞횠쮢첤쮦첨讪쪬쪮얰잲\xDCB4\xD9B6\xDEB8鮺\xEEBC튾ꃀ뇂뇄蛆귈\xAACA뷌믎듐ꇒ\xF5D4ꓖ귘뫚\xA9DC뫞", A_1), (object) enReturnCode);
              num = 7;
              continue;
            }
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      if (1 == 0)
        ;
label_14:
      caslLogger.FormatTraceOutMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ\x2072ᡴᙶ\x0B78ེ㱼\x1B7E\xE080\xF382\xF184\xE286ﮈ", A_1), Module.a("ቔ\x3256ⵘ࡚ぜ㹞፠ᝢ\x2464ͦ\x0868᭪ᥬ੮Ͱ\x2072Ŵᙶ\x0D78\x0E7A\x0E7C㥾\xF380\xEC82\xE884얆삈쒊\xDE8C", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76啸孺ὼⱾ\xF480\xF382\xF584\xE886ﮈﾊ\xE88C\xEB8E놐꺒떔\xEC96ꢘ\xE69A놜뾞좠\xF0A2톤욦\xDDA8\xDEAA\xDEAC辮貰鎲薴쾶슸覺삼", A_1), (object) enReturnCode.ToString(), (object) bSupported.ToString(), (object) iStatus.ToString(Module.a("\x0D54", A_1)));
      return enReturnCode;
    }

    private enReturnCode SmartAdapterGet(string sCommandName, out object dataOut)
    {
      int A_1_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٔ㩖㡘⥚⥜Ṟ\x0560ɢᕤ፦౨ᥪ⩬੮հ", A_1_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬", A_1_1) + sCommandName);
      enReturnCode enReturnCode = this.E1;
      bool A_0 = false;
      int A_1_2 = 0;
      dataOut = (object) null;
      int num = 5;
      while (true)
      {
        string str=null;
        switch (num)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 6;
            continue;
          case 1:
            if (1 == 0)
              ;
            num = 11;
            continue;
          case 2:
            num = 0;
            continue;
          case 3:
          case 6:
          case 9:
          case 15:
            goto label_30;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 16;
              continue;
            }
            goto label_30;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 13;
              continue;
            }
            goto label_30;
          case 7:
            num = str == Module.a("ٔ㩖㡘⥚⥜Ṟ\x0560ɢᕤ፦౨ᥪ䍬㱮ѰͲմᡶ\x0B78ེ\x187C\x1B7E", A_1_1) ? 20 : 17;
            continue;
          case 8:
            if (!(str == Module.a("ٔ㩖㡘⥚⥜Ṟ\x0560ɢᕤ፦౨ᥪ䍬㱮հቲŴɶ\x0A78", A_1_1)))
            {
              num = 2;
              continue;
            }
            enReturnCode = CommandSmartAdapter.B(ref A_0, ref A_1_2);
            num = 14;
            continue;
          case 10:
            dataOut = (object) this.A1;
            num = 15;
            continue;
          case 11:
            if (!this.C1)
            {
              num = 10;
              continue;
            }
            break;
          case 12:
            num = 7;
            continue;
          case 13:
            num = 19;
            continue;
          case 14:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 18;
              continue;
            }
            goto label_30;
          case 16:
            this.A1 = new bool?(A_0);
            dataOut = (object) this.A1;
            num = 3;
            continue;
          case 17:
            num = 8;
            continue;
          case 18:
            dataOut = (object) A_1_2;
            num = 9;
            continue;
          case 19:
            if ((str = sCommandName) != null)
            {
              num = 12;
              continue;
            }
            goto case 0;
          case 20:
            if (this.A1.HasValue)
            {
              num = 1;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        enReturnCode = CommandSmartAdapter.B(ref A_0, ref A_1_2);
        num = 4;
      }
label_30:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ٔ㩖㡘⥚⥜Ṟ\x0560ɢᕤ፦౨ᥪ⩬੮հ", A_1_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63Ⅵ൧ṩ\x206Bݭͯٱ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      this.E1 = this.InitGet();
      this.propertyGetList.Add(new Command.Property(Module.a("\x1D4D㵏㍑♓≕ᥗ㹙㵛\x2E5Dᑟݡᙣ䡥㭧ὩᱫṭὯqs\x1375ᱷ", A_1), typeof (bool), Module.a("\x1D4D㵏㍑♓≕ᥗ㹙㵛\x2E5DᑟݡᙣⅥ൧ṩ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1D4D㵏㍑♓≕ᥗ㹙㵛\x2E5Dᑟݡᙣ䡥㭧ṩ൫ᩭկű", A_1), typeof (int), Module.a("\x1D4D㵏㍑♓≕ᥗ㹙㵛\x2E5DᑟݡᙣⅥ൧ṩ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63Ⅵ൧ṩ\x206Bݭͯٱ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 3;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞㉠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞㉠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 18;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅗ㑙㕛⩝╟ᩡţե\x1D67ṩ५≭\x196Fűs", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅗ㑙㕛⩝╟ᩡţե\x1D67ṩ५≭\x196Fűs", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧", A_1));
    }
  }
}
