// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandLidSwitch
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
  public class CommandLidSwitch : Command
  {
    private enReturnCode C1 = enReturnCode.e_NULL_VALUE;
    private int? A1;
    private bool B1;

    private static string LidSwitchEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("Ō♎㕐R≔㹖ⵘ㡚㕜ᩞౠᙢ।٦\x1D68ɪɬŮ彰\x2B72㡴㭶", 7);
      }
    }

    private enReturnCode A()
    {
      int A_1 = 12;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᭑㩓㽕ⱗ\x1D59㥛⩝", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
      this.A1 = new int?();
      this.B1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      int A_0 = 0;
      enReturnCode enReturnCode = CommandLidSwitch.C(ref A_0);
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 1:
            goto label_7;
          case 2:
            this.A1 = new int?(A_0);
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᭑㩓㽕ⱗ\x1D59㥛⩝", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode C(ref int A_0)
    {
      int A_1 = 5;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ╨ɪ६㱮ٰᩲŴᑶᅸ", A_1), Module.a("ొ⡌㭎\x1D50㩒ㅔі\x2E58\x325A⥜㱞ॠぢᅤ٦\x1D68\x0E6A", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
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
          case 2:
            goto label_8;
          case 1:
            if (allowEmulation)
            {
              num = 3;
              continue;
            }
            enReturnCode = CommandLidSwitch.A(ref A_0);
            num = 2;
            continue;
          case 3:
            enReturnCode = CommandLidSwitch.B(ref A_0);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      caslLogger.FormatTraceOutMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ╨ɪ६㱮ٰᩲŴᑶᅸ", A_1), Module.a("ొ⡌㭎\x1D50㩒ㅔі\x2E58\x325A⥜㱞ॠぢᅤ٦\x1D68\x0E6A", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode B(ref int A_0)
    {
      int A_1 = 1;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("ц⡈㡊⅌ᡎ㱐㩒答ᑖ㙘㙚ぜ㹞འݢ⥤\x0E66൨㡪ᩬٮհၲᵴ", A_1), Module.a("Fⱈ㽊Ō♎㕐R≔㹖ⵘ㡚㕜\x0C5Eᕠɢᅤɦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (1 == 0)
              ;
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            A_0 = (int) xmlEdit.GetUInt32(Module.a("框晈ъ㡌㭎\x2150♒\x2154硖\x1D58㩚⥜㹞习⽢\x0C64ͦ㩨ᱪѬ᭮ተ᭲♴Ͷ\x1878ེ\x187C", A_1));
            num1 = 5;
            continue;
          case 1:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 4;
            continue;
          case 2:
            try
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(CommandLidSwitch.LidSwitchEmulationFile);
                    num2 = 1;
                    continue;
                  case 1:
                    goto label_6;
                  case 3:
                    File.WriteAllText(CommandLidSwitch.LidSwitchEmulationFile, Resources.LidSwitchEmulation);
                    num2 = 0;
                    continue;
                  default:
                    if (!File.Exists(CommandLidSwitch.LidSwitchEmulationFile))
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
              caslLogger.FormatErrorMessage(Module.a("ц⡈㡊⅌ᡎ㱐㩒答ᑖ㙘㙚ぜ㹞འݢ⥤\x0E66൨㡪ᩬٮհၲᵴ", A_1), Module.a("Fⱈ㽊Ō♎㕐R≔㹖ⵘ㡚㕜\x0C5Eᕠɢᅤɦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("Ɇㅈ⡊⡌㽎═㩒㩔㥖祘㝚\x325C㹞\x0560\x0A62\x0B64f䥨\x0E6AlᩮᵰቲŴṶᙸᕺ嵼\x197E\xE880\xEF82\xE084붆ꦈ겊\xF68C뺎\xEC90뒒", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_6:
            num1 = 3;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            goto label_18;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_18;
          case 5:
            goto label_18;
          default:
            goto label_2;
        }
      }
label_18:
      caslLogger.FormatTraceOutMessage(Module.a("ц⡈㡊⅌ᡎ㱐㩒答ᑖ㙘㙚ぜ㹞འݢ⥤\x0E66൨㡪ᩬٮհၲᵴ", A_1), Module.a("Fⱈ㽊Ō♎㕐R≔㹖ⵘ㡚㕜\x0C5Eᕠɢᅤɦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode A(ref int A_0)
    {
      int A_1 = 7;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("์\x2E4E≐㽒ɔ㩖じ畚Ṝぞౠ\x0E62Ѥ०൨❪Ѭ୮≰ѲᱴͶ᩸\x137A", A_1), Module.a("ੌ⩎═ὒ㱔㍖\x0A58ⱚ㑜\x2B5Eɠୢ㙤፦\x0868Ὢ\x086C⥮Ͱᱲᡴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            A_0 = BitConverter.ToInt32(dataOut, 0);
            num = 0;
            continue;
          case 2:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetCurrentLidSwitchState, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_4);
            num = 7;
            continue;
          case 3:
          case 8:
          case 9:
            goto label_14;
          case 4:
            A_0 = 0;
            enReturnCode = enReturnCode.e_OK;
            num = 3;
            continue;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 2;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            caslLogger.ErrorMessage(Module.a("์\x2E4E≐㽒ɔ㩖じ畚Ṝぞౠ\x0E62Ѥ०൨❪Ѭ୮≰ѲᱴͶ᩸\x137A", A_1), Module.a("ੌ⩎═ὒ㱔㍖\x0A58ⱚ㑜\x2B5Eɠୢ㙤፦\x0868Ὢ\x086C⥮Ͱᱲᡴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("ьⅎ≐❒㑔㥖ⵘ\x325A㱜\x2B5E\x0860ౢ\x0B64䝦٨൪䵬㡮ᱰᩲ㝴㹶㙸⡺㹼\x137E\xE880\xE682\xEB84\xF386ꦈ力\xE88Cﮎ\xE490\xE192ﮔ\xF296ﶘ뮚\xF39C\xEA9E춠쾢", A_1));
            num = 8;
            continue;
          case 6:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              caslLogger.FormatErrorMessage(Module.a("์\x2E4E≐㽒ɔ㩖じ畚Ṝぞౠ\x0E62Ѥ०൨❪Ѭ୮≰ѲᱴͶ᩸\x137A", A_1), Module.a("ੌ⩎═ὒ㱔㍖\x0A58ⱚ㑜\x2B5Eɠୢ㙤፦\x0868Ὢ\x086C⥮Ͱᱲᡴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("ࡌ㵎⍐㱒❔睖楘⍚♜潞ᱠ䍢ͤᕦ٨٪䵬\x2D6E㡰㱲♴坶\x2E78㙺㑼彾\xE280\xE282\xE984\xEB86ꦈ\xD98A\xE88C\xEE8E\xF590벒\xA794튖\xF198뮚\xEA9C\xF79E좠쾢삤螦캨캪\xD9AC\xDBAE\xD8B0\xDDB2튴鞶\xF5B8튺\xD9BC龾鋀듂계돆\xAAC8ꏊ\xEDCC鳎ꗐ닒ꇔ닖律\xA8DA\xA9DC뻞闠蛢", A_1), (object) enReturnCode);
              num = 9;
              continue;
            }
            num = 4;
            continue;
          case 7:
            num = enReturnCode != enReturnCode.e_OK ? 6 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      if (1 == 0)
        ;
label_14:
      caslLogger.FormatTraceOutMessage(Module.a("์\x2E4E≐㽒ɔ㩖じ畚Ṝぞౠ\x0E62Ѥ०൨❪Ѭ୮≰ѲᱴͶ᩸\x137A", A_1), Module.a("ੌ⩎═ὒ㱔㍖\x0A58ⱚ㑜\x2B5Eɠୢ㙤፦\x0868Ὢ\x086C⥮Ͱᱲᡴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨ၪ嵬ቮ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public enReturnCode LidSwitchStateGet(string sCommandName, out object dataOut)
    {
      int A_1 = 14;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡓ㽕㱗ख़\x2B5B㝝ᑟšౣ㕥ᱧ୩ᡫ୭㝯\x1771s", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ䉡፣ཥᱧɩ䱫", A_1) + sCommandName);
      enReturnCode enReturnCode = this.C1;
      int A_0 = 0;
      dataOut = (object) null;
      int num = 0;
            string str = null;

            while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 5;
              continue;
            }
            goto label_17;
          case 1:
          case 7:
            goto label_17;
          case 2:
            dataOut = (object) A_0;
            num = 7;
            continue;
          case 3:
            enReturnCode = CommandLidSwitch.C(ref A_0);
            num = 8;
            continue;
          case 4:
            if (1 == 0)
              ;
            num = 9;
            continue;
          case 5:
            num = 6;
            continue;
          case 6:
            if ((str = sCommandName) != null)
            {
              num = 4;
              continue;
            }
            break;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_17;
          case 9:
            if (str == Module.a("ᡓ㽕㱗ख़\x2B5B㝝ᑟšౣ䡥㭧ṩ൫ᩭᕯ", A_1))
            {
              num = 3;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 1;
      }
label_17:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᡓ㽕㱗ख़\x2B5B㝝ᑟšౣ㕥ᱧ୩ᡫ୭㝯\x1771s", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭偯\x0971䑳\x0B75", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ࡗ⡙㍛\x2E5D՟ၡၣὥ⽧ཀྵᡫ≭\x196Fűs", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      this.C1 = this.A();
      this.propertyGetList.Add(new Command.Property(Module.a("ᱏ㭑こՕ⽗㍙⡛㵝\x085F䱡㝣ብ१ṩ५", A_1), typeof (int), Module.a("ᱏ㭑こՕ⽗㍙⡛㵝\x085Fㅡၣݥᱧཀྵ\x2B6B୭ѯ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ࡗ⡙㍛\x2E5D՟ၡၣὥ⽧ཀྵᡫ≭\x196Fűs", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ", A_1));
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 7;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ьⅎ㡐❒Ք╖㙘\x2B5A㡜ⵞᕠᩢ㙤ɦ\x1D68❪Ѭᱮհ", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ьⅎ㡐❒Ք╖㙘\x2B5A㡜ⵞᕠᩢ㙤ɦ\x1D68❪Ѭᱮհ", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
    }
  }
}
