// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandDebug
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.ComponentModel;
using System.IO;
using System.ServiceProcess;
using System.Xml;

namespace CaslWmi
{
  internal class CommandDebug : Command
  {
    private enReturnCode C1 = enReturnCode.e_NULL_VALUE;
    private const int A1 = 254;
    private bool B1;

    private string DebugEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ࡋ\x2B4D\x324F❑㍓ፕ㕗⽙せ㽝ᑟୡୣ\x0865䙧㉩Ⅻ≭", 6);
      }
    }

    private enReturnCode B()
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ὗ㽙⡛", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.B1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ὗ㽙⡛", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode DebugGet(string sCommandName, out object dataOut)
    {
      int A_1 = 7;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ौ⩎㍐♒\x3254ၖ㱘⽚", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘筚⩜㙞ᕠୢ䕤", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
      dataOut = (object) null;
      int num = 7;
      while (true)
      {
        string str=null;
        string sPowerSource=null;
        switch (num)
        {
          case 0:
          case 6:
            goto label_14;
          case 1:
            if (str == Module.a("ौ⩎㍐♒\x3254祖क़㑚⩜㩞፠ぢ\x0A64ቦ᭨\x086A\x086C", A_1))
            {
              num = 4;
              continue;
            }
            break;
          case 2:
            if (1 == 0)
              ;
            num = 1;
            continue;
          case 3:
            dataOut = (object) sPowerSource;
            num = 6;
            continue;
          case 4:
            sPowerSource = string.Empty;
            enReturnCode = this.GetPowerSource(out sPowerSource);
            num = 5;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto label_14;
          case 7:
            if ((str = sCommandName) != null)
            {
              num = 2;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 0;
      }
label_14:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ौ⩎㍐♒\x3254ၖ㱘⽚", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨ၪ嵬ቮ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPowerSource(out string sPowerSource)
    {
      int A_1 = 16;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59\x0C5Bㅝ\x175Fݡᙣ㕥ݧὩṫ൭ᕯ", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١", A_1));
      sPowerSource = (string) null;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (this.B1)
            {
              num = 1;
              continue;
            }
            enReturnCode = this.A(out sPowerSource);
            num = 2;
            continue;
          case 1:
            enReturnCode = this.B(out sPowerSource);
            if (1 == 0)
              ;
            num = 3;
            continue;
          case 2:
          case 3:
            goto label_8;
          default:
            goto label_2;
        }
      }
label_8:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59\x0C5Bㅝ\x175Fݡᙣ㕥ݧὩṫ൭ᕯ", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ剱ཱི䙵շ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B(out string A_0)
    {
      int A_1 = 1;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C⁎♐㙒❔і㙘\x2E5A⽜㱞Ѡ♢\x0864ቦը੪ᥬٮṰᵲ", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      A_0 = (string) null;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            try
            {
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_24;
                  case 1:
                    File.WriteAllText(this.DebugEmulationFile, Resources.DebugEmulation);
                    num2 = 2;
                    continue;
                  case 2:
                    xmlDoc.Load(this.DebugEmulationFile);
                    num2 = 0;
                    continue;
                  default:
                    if (!File.Exists(this.DebugEmulationFile))
                    {
                      num2 = 1;
                      continue;
                    }
                    goto case 2;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C⁎♐㙒❔і㙘\x2E5A⽜㱞Ѡ♢\x0864ቦը੪ᥬٮṰᵲ", A_1), Module.a("Ɇㅈ⡊⡌㽎═㩒㩔㥖祘㝚\x325C㹞\x0560\x0A62\x0B64f䥨\x0E6AlᩮᵰቲŴṶᙸᕺ嵼\x197E\xE880\xEF82\xE084붆ꦈ겊\xF68C뺎\xEC90뒒", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_24:
            num1 = 3;
            continue;
          case 1:
            num1 = 9;
            continue;
          case 2:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 8;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 2;
              continue;
            }
            goto label_27;
          case 4:
            if (string.Compare(A_0, Module.a("ņ♈㥊\x2E4C⩎㕐\x0C52ᅔᑖ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 1;
              continue;
            }
            goto label_27;
          case 5:
            if (string.Compare(A_0, Module.a("ॆ♈㥊⁌\x2E4E㵐", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 6;
              continue;
            }
            goto label_27;
          case 6:
            num1 = 4;
            continue;
          case 7:
            if (1 == 0)
              ;
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            A_0 = xmlEdit.GetString(Module.a("框晈ъ㡌㭎\x2150♒\x2154硖\x1D58㩚⥜㹞习㍢\x0A64ၦ౨ᥪ㹬nѰŲᙴቶ", A_1));
            num1 = 5;
            continue;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 7;
              continue;
            }
            goto label_27;
          case 9:
            if (string.Compare(A_0, Module.a("ņ♈㥊\x2E4C⩎㕐\x0C52ᑔᑖ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 11;
              continue;
            }
            goto label_27;
          case 10:
            goto label_27;
          case 11:
            enReturnCode = enReturnCode.e_INVALID_XML;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C⁎♐㙒❔і㙘\x2E5A⽜㱞Ѡ♢\x0864ቦը੪ᥬٮṰᵲ", A_1), Module.a("\x0E46❈㵊ⱌ⍎㡐㝒畔ݖ㙘ⱚ㡜ⵞ㉠ౢၤᕦ੨\x0E6A䵬\x196Eၰὲtቶ奸屺ټ佾ﲀꒂꖄ\xF586\xEC88\xEA8A\xE98C꾎\xF790\xE192杖殺릘ﺚ\xF09C\xEA9E춠슢톤캦욨얪趬즮\xD8B0\xDFB2킴馶", A_1), (object) A_0);
            num1 = 10;
            continue;
          default:
            goto label_2;
        }
      }
label_27:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C⁎♐㙒❔і㙘\x2E5A⽜㱞Ѡ♢\x0864ቦը੪ᥬٮṰᵲ", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode A(out string A_0)
    {
      int A_1 = 14;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ፓ㍕ⱗਖ਼㍛⥝՟ၡ㝣॥\x1D67ᡩཫ୭㙯q᭳᭵㩷㍹㍻\x2D7D", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ", A_1));
      A_0 = (string) null;
      byte[] abyDebugTabConfiguration = (byte[]) null;
      enReturnCode configurationFromBios = this.GetDebugTabConfigurationFromBIOS(out abyDebugTabConfiguration);
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (configurationFromBios == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto label_15;
          case 1:
            num = 7;
            continue;
          case 2:
            num = 3;
            continue;
          case 3:
            if (!Utility.GetBit(abyDebugTabConfiguration[1], 4))
            {
              A_0 = Module.a("ቓ㥕⩗㥙㥛㩝㽟⍡❣", A_1);
              num = 6;
              continue;
            }
            num = 5;
            continue;
          case 4:
          case 6:
          case 8:
            goto label_15;
          case 5:
            A_0 = Module.a("ቓ㥕⩗㥙㥛㩝㽟♡❣", A_1);
            num = 8;
            continue;
          case 7:
            if (Utility.GetBit(abyDebugTabConfiguration[1], 3))
            {
              num = 2;
              continue;
            }
            if (1 == 0)
              ;
            A_0 = Module.a("ᩓ㥕⩗㝙㵛\x325D", A_1);
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ፓ㍕ⱗਖ਼㍛⥝՟ၡ㝣॥\x1D67ᡩཫ୭㙯q᭳᭵㩷㍹㍻\x2D7D", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭䩯剱", A_1) + configurationFromBios.ToString());
      return configurationFromBios;
    }

    private enReturnCode GetDebugTabConfigurationFromBIOS(out byte[] abyDebugTabConfiguration)
    {
      int A_1 = 0;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ࡋ\x2B4D\x324F❑㍓ɕ㥗㡙Ὓㅝ\x0E5Fѡൣť\x1D67ᡩ൫ᩭ\x196Fᵱᩳふ\x0A77ᕹᅻ㱽쥿춁힃", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      abyDebugTabConfiguration = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (wmiBiosClient != null)
            {
              num = 4;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ࡋ\x2B4D\x324F❑㍓ɕ㥗㡙Ὓㅝ\x0E5Fѡൣť\x1D67ᡩ൫ᩭ\x196Fᵱᩳふ\x0A77ᕹᅻ㱽쥿춁힃", A_1), Module.a("ཅ♇㥉㡋⽍㹏♑㵓㝕ⱗ㍙㍛そ䁟ൡɣ䙥㽧ݩիⱭ㥯㵱❳㕵ᑷ\x1379\x197Bၽ\xF47Fꊁ\xF683\xE385ﲇﾉﺋ\xE08D\xF58F\xF691뒓\xF895\xED97\xF699\xF09B", A_1));
            num = 3;
            continue;
          case 1:
            if (enReturnCode != enReturnCode.e_OK)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ࡋ\x2B4D\x324F❑㍓ɕ㥗㡙Ὓㅝ\x0E5Fѡൣť\x1D67ᡩ൫ᩭ\x196Fᵱᩳふ\x0A77ᕹᅻ㱽쥿춁힃", A_1), Module.a("ͅ㩇㡉⍋㱍灏⥑摓⭕硗㱙\x2E5Bㅝ\x0D5F䉡♣⽥❧㥩䱫㥭㵯㭱味ᕵ\x1977ᙹၻ幽퉿\xE781\xE583\xE285ꞇ뮉뒋\xE68D낏\xE591ﲓﾕ\xF497ﾙ벛劣얟횡킣쾥욧충貫節톯킱钳\xF5B5ힷ풹\xDABBힽ\xA7BF럁뛃\xA7C5볇ꏉꏋꃍ\xF0CF雑뗓ꋕ맗", A_1), (object) enReturnCode);
              num = 2;
              continue;
            }
            num = 5;
            continue;
          case 2:
          case 3:
          case 6:
            goto label_12;
          case 4:
            if (1 == 0)
              ;
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetDebugTabConfiguration, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 1;
            continue;
          case 5:
            abyDebugTabConfiguration = dataOut;
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ࡋ\x2B4D\x324F❑㍓ɕ㥗㡙Ὓㅝ\x0E5Fѡൣť\x1D67ᡩ൫ᩭ\x196Fᵱᩳふ\x0A77ᕹᅻ㱽쥿춁힃", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F塡䑣", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 1;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x1F4E⍐㱒╔\x3256⭘⽚\x245CᡞѠᝢ⥤\x0E66ᩨὪ", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      this.C1 = this.B();
      this.propertyGetList.Add(new Command.Property(Module.a("͆ⱈ⥊㡌⡎罐͒㩔⁖㱘⥚\x0E5Cぞᑠᅢ٤ɦ", A_1), typeof (string), Module.a("͆ⱈ⥊㡌⡎ᙐ㙒\x2154", A_1), true));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x1F4E⍐㱒╔\x3256⭘⽚\x245CᡞѠᝢ⥤\x0E66ᩨὪ", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖", A_1));
    }

    private enReturnCode DebugSet(string sCommandName, object dataIn)
    {
      int A_1 = 18;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᱗㽙㹛\x2B5Dݟㅡţብ", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1));
      enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
      int num = 9;
      string str=null;
      string sPowerSource=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = this.SetPowerSource(sPowerSource);
            num = 12;
            continue;
          case 1:
            num = 2;
            continue;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 7;
            continue;
          case 3:
            try
            {
              sPowerSource = (string) dataIn;
              enReturnCode = enReturnCode.e_OK;
            }
            catch
            {
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            }
            num = 5;
            continue;
          case 4:
            num = 6;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 0;
              continue;
            }
            goto label_22;
          case 6:
            if (!(str == Module.a("᱗㽙㹛\x2B5Dݟ䱡㑣॥ὧཀྵṫ㵭Ὧݱٳᕵᵷ", A_1)))
            {
              num = 1;
              continue;
            }
            sPowerSource = string.Empty;
            num = 3;
            continue;
          case 7:
          case 10:
          case 12:
            goto label_22;
          case 8:
            if (1 == 0)
              ;
            if (!(str == Module.a("᱗㽙㹛\x2B5Dݟ䱡卣啥屧⥩呫幭䙯䭱女㉵䅷䥹䑻卽둿\xE481\xE683늅ꖇ좉릋몍ꢏ뾑ꂓꂕ꾗겙ꦛꪝ鞟邡\xE2A3醥\xE9A7颩", A_1)))
            {
              num = 4;
              continue;
            }
            enReturnCode = this.A();
            num = 10;
            continue;
          case 9:
            if ((str = sCommandName) != null)
            {
              num = 11;
              continue;
            }
            goto case 2;
          case 11:
            num = 8;
            continue;
          default:
            goto label_2;
        }
      }
label_22:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᱗㽙㹛\x2B5Dݟㅡţብ", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ味\x0D75䡷ݹ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode A()
    {
      int A_1_1 = 18;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      ServiceController A_0 = (ServiceController) null;
      int num = 0;
      string A_1_2=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            try
            {
              A_0 = new ServiceController(Module.a("し⩙ⵛढ़\x0D5FୡⅣṥ", A_1_1));
            }
            catch (Exception ex)
            {
              A_0 = (ServiceController) null;
              this.log.ErrorMessage(this.GetType().ToString(), Module.a("ୗ\x2E59㵛ⱝᑟ⩡ᑣᙥ१㥩५ᱭٯ᭱ᝳ\x1375", A_1_1), Module.a("\x1D57≙㽛㭝ၟᙡൣ॥٧䩩ཫᱭᕯ\x1371sήᙷᵹ屻ൽ\xE57F\xF081\xF283\xEF85\xEB87\xEF89겋\xED8Dﾏﲑ\xE093\xE495\xF797\xF699\xF09Bﮝ튟颡蒣", A_1_1) + ex.Message);
            }
            num = 2;
            continue;
          case 1:
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ୗ\x2E59㵛ⱝᑟ⩡ᑣᙥ१㥩५ᱭٯ᭱ᝳ\x1375", A_1_1), Module.a("ṗ㭙㕛\x325D՟١䑣ብݧ䩩൫ɭᱯᵱᝳ\x1775\x0C77ό屻ώꁿ\xF181\xE183\xF485ﺇ\xE389\xEF8B\xEB8D낏\xF191ﮓ\xF895\xEC97\xE899\xF39B\xF29D첟잡횣", A_1_1));
            num = 4;
            continue;
          case 2:
            if (A_0 != null)
            {
              if (1 == 0)
                ;
              A_1_2 = string.Empty;
              enReturnCode = CommandDebug.A(A_0, ref A_1_2);
              num = 3;
              continue;
            }
            num = 1;
            continue;
          case 3:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 4:
          case 5:
            goto label_14;
          case 6:
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ୗ\x2E59㵛ⱝᑟ⩡ᑣᙥ१㥩५ᱭٯ᭱ᝳ\x1375", A_1_1), A_1_2);
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      return enReturnCode;
    }

    private static enReturnCode A(ServiceController A_0, ref string A_1)
    {
      int A_1_1 = 8;
      enReturnCode enReturnCode;
      try
      {
        A_0.ExecuteCommand(254);
        enReturnCode = enReturnCode.e_OK;
      }
      catch (Win32Exception ex)
      {
        A_1 = Module.a("ٍɏᝑݓ͕ᑗ๙晛繝偟ᩡ", A_1_1) + ex.ErrorCode.ToString(Module.a("ᙍ", A_1_1)) + Module.a("才灏Ց㵓㡕歗桙籛㭝\x125Fၡୣᑥ䡧३ͫ੭ᕯ䡱味", A_1_1) + ex.NativeErrorCode.ToString() + Module.a("才灏Ց㵓㡕歗桙ᥛ♝͟ݡᑣብŧթɫ乭ᵯ\x1771ݳյ\x1977ᵹ\x197B䑽ꁿ", A_1_1) + ex.Message;
        enReturnCode = enReturnCode.e_NOTIFICATION_FAILED;
      }
      catch (InvalidOperationException ex)
      {
        A_1 = Module.a("ݍ㹏\x2451㕓㩕ㅗ㹙\x135B\x2E5D՟ၡգብŧթɫ\x2B6D\x086Fᅱᅳٵ\x0C77\x1379\x137Bၽꁿ\xEF81\xE183\xF585ﮇ\xEB89\xEB8B\xEB8Dꪏ늑", A_1_1) + ex.Message;
        enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
      }
      catch (Exception ex)
      {
        A_1 = Module.a("ō\x244F㩑ㅓ\x2455硗㽙\x245B㵝՟ቡၣཥݧѩ䱫ͭᕯűݳ\x1775ίό䙻幽", A_1_1) + ex.Message;
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      if (1 == 0)
        ;
      return enReturnCode;
    }

    private enReturnCode SetPowerSource(string sPowerSource)
    {
      int A_1 = 12;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (string.Compare(sPowerSource, Module.a("᱑㭓\x2455㕗㭙せ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 4;
              continue;
            }
            break;
          case 2:
            enReturnCode = this.A(sPowerSource);
            num = 0;
            continue;
          case 3:
            if (string.Compare(sPowerSource, Module.a("ᑑ㭓\x2455㭗㽙㡛ŝ\x245FⅡ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 5;
              continue;
            }
            break;
          case 4:
            num = 3;
            continue;
          case 5:
            num = 6;
            continue;
          case 6:
            if (string.Compare(sPowerSource, Module.a("ᑑ㭓\x2455㭗㽙㡛ŝ\x215FⅡ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 10;
              continue;
            }
            break;
          case 7:
            if (!this.B1)
            {
              enReturnCode = this.B(sPowerSource);
              num = 9;
              continue;
            }
            num = 2;
            continue;
          case 8:
          case 9:
            goto label_18;
          case 10:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५", A_1), Module.a("ݑ㩓㵕㙗㕙\x2B5Bそ䁟ቡୣᅥ൧ᡩ䱫ᵭὯݱٳᕵᵷ婹\x0A7Bώ\xEC7F\xF781\xE183ꚅ\xF887\xEB89ﾋﶍ\xF58F\xF691뒓ﾕ\xF697ꂙ벛릝\xDB9F銡\xD9A3膥", A_1), (object) sPowerSource);
            num = 8;
            continue;
          default:
            goto label_2;
        }
        num = 7;
      }
label_6:
      if (1 == 0)
        ;
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode A(string A_0)
    {
      int A_1 = 2;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᭇ⽉㡋ṍ㽏║ㅓ\x2455ୗ㕙⥛ⱝ͟ݡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num1 = 11;
      XmlDocument xmlDoc=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            goto label_31;
          case 1:
            xmlDoc = new XmlDocument();
            num1 = 10;
            continue;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᭇ⽉㡋ṍ㽏║ㅓ\x2455ୗ㕙⥛ⱝ͟ݡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1), Module.a("\x1D47⑉❋⁍㽏║㩓癕⡗㕙\x2B5B㭝\x125F䉡ᝣ॥\x1D67ᡩཫ୭偯ѱᕳ᩵\x0D77ό屻\x0E7D\xE17F\xF181\xF783\xE385\xEC87ꪉ\xE58B\xE08Dꪏ늑뎓\xED95ꢗ\xE799뮛", A_1), (object) A_0);
            num1 = 3;
            continue;
          case 3:
            num1 = 0;
            continue;
          case 4:
            goto label_31;
          case 5:
            if (string.Compare(A_0, Module.a("็╉㹋ⵍ㕏㙑\x0B53\x1755᭗", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 2;
              continue;
            }
            goto case 3;
          case 6:
            if (1 == 0)
              ;
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 9;
            continue;
          case 7:
            if (string.Compare(A_0, Module.a("็╉㹋ⵍ㕏㙑\x0B53ቕ᭗", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 13;
              continue;
            }
            goto case 3;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 6;
              continue;
            }
            goto label_31;
          case 9:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 12;
              continue;
            }
            goto label_31;
          case 10:
            try
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(this.DebugEmulationFile);
                    num2 = 3;
                    continue;
                  case 2:
                    File.WriteAllText(this.DebugEmulationFile, Resources.DebugEmulation);
                    num2 = 0;
                    continue;
                  case 3:
                    goto label_5;
                  default:
                    if (!File.Exists(this.DebugEmulationFile))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 0;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᭇ⽉㡋ṍ㽏║ㅓ\x2455ୗ㕙⥛ⱝ͟ݡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1), Module.a("േ\x3249⽋\x2B4D⁏♑㵓㥕㙗穙せㅝş١ൣ\x0865ཧ䩩५ͭկṱᕳɵᅷᕹቻ幽\xE67F\xEB81\xE883\xE385늇ꪉ\xAB8B\xF58Dꆏ\xEF91뎓", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_5:
            num1 = 8;
            continue;
          case 11:
            if (string.Compare(A_0, Module.a("ه╉㹋⍍ㅏ㹑", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num1 = 14;
              continue;
            }
            goto case 3;
          case 12:
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            xmlEdit.SetString(Module.a("杇敉͋㭍\x244F≑\x2153≕睗ṙ㵛⩝ş䵡㑣॥ὧཀྵṫ㵭Ὧݱٳᕵᵷ", A_1), A_0);
            xmlEdit.XmlDoc.Save(this.DebugEmulationFile);
            num1 = 4;
            continue;
          case 13:
            num1 = 5;
            continue;
          case 14:
            num1 = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_31:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᭇ⽉㡋ṍ㽏║ㅓ\x2455ୗ㕙⥛ⱝ͟ݡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61䑣\x1D65塧ᝩ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public enReturnCode B(string A_0)
    {
      int A_1 = 12;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५❭ṯぱ㵳㥵\x2B77", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝䁟ᅡ㑣॥ὧཀྵṫ㵭Ὧݱٳᕵᵷ䁹呻", A_1) + A_0 + Module.a("筑", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] abyDebugTabConfiguration = (byte[]) null;
      int num = 9;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (string.Compare(A_0, Module.a("ᑑ㭓\x2455㭗㽙㡛ŝ\x245FⅡ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 7;
              continue;
            }
            goto case 11;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 10;
              continue;
            }
            goto case 3;
          case 2:
            if (1 == 0)
              ;
            num = 14;
            continue;
          case 3:
            num = 15;
            continue;
          case 4:
          case 16:
            enReturnCode = this.SetDebugTabConfigurationInBIOS(abyDebugTabConfiguration);
            num = 5;
            continue;
          case 5:
            goto label_26;
          case 6:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५❭ṯぱ㵳㥵\x2B77", A_1), Module.a("ݑ㩓㵕㙗㕙\x2B5Bそ䁟ቡୣᅥ൧ᡩ䱫ᵭὯݱٳᕵᵷ婹\x0A7Bώ\xEC7F\xF781\xE183ꚅ\xF887\xEB89ﾋﶍ\xF58F\xF691뒓ﾕ\xF697ꂙ벛릝\xDB9F銡\xD9A3膥", A_1), (object) A_0);
            num = 11;
            continue;
          case 7:
            num = 12;
            continue;
          case 8:
            num = 0;
            continue;
          case 9:
            if (string.Compare(A_0, Module.a("᱑㭓\x2455㕗㭙せ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 8;
              continue;
            }
            goto case 11;
          case 10:
            enReturnCode = this.GetDebugTabConfigurationFromBIOS(out abyDebugTabConfiguration);
            num = 3;
            continue;
          case 11:
            num = 1;
            continue;
          case 12:
            if (string.Compare(A_0, Module.a("ᑑ㭓\x2455㭗㽙㡛ŝ\x215FⅡ", A_1), StringComparison.InvariantCultureIgnoreCase) != 0)
            {
              num = 6;
              continue;
            }
            goto case 11;
          case 13:
            Utility.SetBit(ref abyDebugTabConfiguration[1], 3, false);
            Utility.SetBit(ref abyDebugTabConfiguration[1], 4, false);
            num = 16;
            continue;
          case 14:
            if (!(A_0 == Module.a("᱑㭓\x2455㕗㭙せ", A_1)))
            {
              Utility.SetBit(ref abyDebugTabConfiguration[1], 3, true);
              Utility.SetBit(ref abyDebugTabConfiguration[1], 4, A_0 == Module.a("ᑑ㭓\x2455㭗㽙㡛ŝ\x245FⅡ", A_1));
              num = 4;
              continue;
            }
            num = 13;
            continue;
          case 15:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_26;
          default:
            goto label_2;
        }
      }
label_26:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("őㅓ≕ࡗ㕙\x2B5B㭝\x125Fㅡୣ፥ᩧ३५❭ṯぱ㵳㥵\x2B77", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ呭偯", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetDebugTabConfigurationInBIOS(byte[] abyDebugTabConfiguration)
    {
      int A_1 = 5;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ᕐ㙒㝔≖㹘ཚ㱜㵞≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778㉺\x137C㵾좀첂횄", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetDebugTabConfiguration, abyDebugTabConfiguration, 128U, out dataOut, enSizeOut.eSIZE_0);
            num = 5;
            continue;
          case 1:
          case 3:
            goto label_11;
          case 2:
            if (wmiBiosClient != null)
            {
              num = 0;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ᕐ㙒㝔≖㹘ཚ㱜㵞≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778㉺\x137C㵾좀첂횄", A_1), Module.a("Ɋ⍌㱎═\x3252㭔⍖じ㩚⥜㙞\x0E60ൢ䕤\x0866ཨ䭪㩬ɮᡰㅲ㱴㡶⩸㡺ᅼᙾ\xE480\xED82\xF184Ꞇﮈ\xEE8A歷搜\xE390ﶒ\xF094\xF396릘\xF59A\xE89C\xF39E춠", A_1));
            if (1 == 0)
              ;
            num = 3;
            continue;
          case 4:
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ᕐ㙒㝔≖㹘ཚ㱜㵞≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778㉺\x137C㵾좀첂횄", A_1), Module.a("๊㽌㵎㹐\x2152畔ⱖ楘♚絜㥞፠ౢ\x0864䝦\x2B68≪≬㱮兰\x2472㡴㹶奸\x187A\x1C7C\x137E\xED80ꎂ튄\xF586\xE088ﾊ\xE88Cꂎꂐ\xAB92ﶔ랖\xEE98\xF39A\xF49C\xF39E쒠莢횤슦\xDDA8\xDFAA쒬솮횰鎲\xE1B4횶\xDBB8鮺ﺼ킾꿀ꗂ계ꃆ볈맊곌믎룐볒믔\xF7D6鷘뫚\xA9DC뻞", A_1), (object) enReturnCode);
            num = 1;
            continue;
          case 5:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_11;
          default:
            goto label_2;
        }
      }
label_11:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ᕐ㙒㝔≖㹘ཚ㱜㵞≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778㉺\x137C㵾좀첂횄", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64嵦䥨", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 11;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      this.propertySetList.Add(new Command.Property(Module.a("ᕐ㙒㝔≖㹘畚\x0D5Cぞᙠ٢ᝤ㑦٨ṪὬ౮ᑰ", A_1), typeof (string), Module.a("ᕐ㙒㝔≖㹘࡚㡜\x2B5E", A_1), true));
      this.propertySetList.Add(new Command.Property(Module.a("ᕐ㙒㝔≖㹘畚橜汞啠\x2062嵤坦彨剪䁬\x2B6E䡰䁲䵴婶䵸ᵺὼ䭾검솂낄뎆놈Ꚋ릌릎Ꚑꖒꂔꎖ꺘ꦚ\xDB9Cꢞ\xE0A0醢", A_1), typeof (string), Module.a("ᕐ㙒㝔≖㹘࡚㡜\x2B5E", A_1), true));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 0;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཅ♇⍉㡋୍⡏㝑㝓⍕ⱗ㽙ၛ㝝፟ᙡ", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ཅ♇⍉㡋୍⡏㝑㝓⍕ⱗ㽙ၛ㝝፟ᙡ", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255", A_1));
    }
  }
}
