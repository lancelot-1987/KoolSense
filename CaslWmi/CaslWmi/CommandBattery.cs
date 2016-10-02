// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandBattery
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace CaslWmi
{
  internal class CommandBattery : Command
  {
    private bool? A = new bool?();
    private enReturnCode C = enReturnCode.e_NULL_VALUE;
    private bool B;

    private bool BatteryInfoSupported
    {
      get
      {
label_2:
        bool bSupported = false;
        int num = 5;
        enReturnCode enReturnCode=0;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 2:
              goto label_11;
            case 1:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_11;
            case 3:
              bSupported = this.A.Value;
              num = 0;
              continue;
            case 4:
              this.A = new bool?(bSupported);
              num = 2;
              continue;
            case 5:
              if (1 == 0)
                ;
              if (this.A.HasValue)
              {
                num = 3;
                continue;
              }
              enReturnCode = this.IsBatteryInfoSupported(ref bSupported);
              num = 1;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return bSupported;
      }
    }

    private string BatteryInfoEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ཇ⽉㡋్ㅏ♑⁓㍕⩗⍙ᕛそٟൡ\x2B63፥ᱧᩩᥫᩭ幯⩱㥳㩵", 2);
      }
    }

    private enReturnCode Initialize()
    {
      int A_1 = 5;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ɋ⍌♎═㩒㑔㭖じ\x215A㡜", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.B = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ɋ⍌♎═㩒㑔㭖じ\x215A㡜", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode IsBatteryInfoSupported(ref bool bSupported)
    {
      int A_1 = 12;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᭑❓ᑕ㥗\x2E59⡛㭝\x125F᭡ⵣ\x0865\x0E67թ㽫᭭oɱ᭳ѵ\x0C77ό\x187B", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (1 == 0)
              ;
            bSupported = true;
            num = 8;
            continue;
          case 1:
            if (this.B)
            {
              num = 7;
              continue;
            }
            byte[] abyBatteryInfo = (byte[]) null;
            enReturnCode = this.GetBatteryInfoFromBIOS((byte) 0, ref abyBatteryInfo);
            num = 3;
            continue;
          case 2:
          case 5:
          case 8:
          case 9:
            goto label_14;
          case 3:
            num = enReturnCode != enReturnCode.e_OK ? 4 : 0;
            continue;
          case 4:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("᭑❓ᑕ㥗\x2E59⡛㭝\x125F᭡ⵣ\x0865\x0E67թ㽫᭭oɱ᭳ѵ\x0C77ό\x187B", A_1), Module.a("ᝑ♓\x2455㝗⡙籛湝ᡟᥡ呣᭥䡧౩ṫŭᵯ剱㙳㽵㝷⥹屻⥽쵿쮁ꒃ\xE585\xE987\xE689\xE08B꺍슏\xF791\xF593\xF295랗ꪙ\xAB9B\xF69D肟햡첣쾥쒧쾩貫즭햯욱삳\xDFB5횷\xDDB9鲻\xDCBDꆿ뛁냃ꏅ뫇돉\xECCB\xA7CD뻏듑믓", A_1), (object) enReturnCode);
              num = 2;
              continue;
            }
            num = 6;
            continue;
          case 6:
            bSupported = false;
            num = 9;
            continue;
          case 7:
            bSupported = true;
            this.log.InformationMessage(this.GetType().ToString(), Module.a("᭑❓ᑕ㥗\x2E59⡛㭝\x125F᭡ⵣ\x0865\x0E67թ㽫᭭oɱ᭳ѵ\x0C77ό\x187B", A_1), Module.a("ᝑ㥓⍕㑗㭙⡛㝝ཟౡ䑣ཥ᭧䩩\x0E6B୭\x196Fᱱ\x1373噵\x0D77ॹ\x197B\x1A7Dꁿ뾁릃뢅ꢇ궉\xDF8Bﮍ\xE08F\xE291ﮓ\xE495\xEC97붙벛\xF79D펟芡첣장\xDAA7캩쾫솭풯ힱ킳隵\xD9B7즹鲻馽뒿냁뇃ꏅ\xEFC7\xEAC9\xE4CBꃍ뿏ꛑ\xF4D3돕껗뿙닛ﻝ菟諡臣藥菧菩苫觭탯냱뷳맵꯷폹", A_1));
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᭑❓ᑕ㥗\x2E59⡛㭝\x125F᭡ⵣ\x0865\x0E67թ㽫᭭oɱ᭳ѵ\x0C77ό\x187B", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetBatteryInfoFromBIOS(byte byBatteryNum, ref byte[] abyBatteryInfo)
    {
      int A_1 = 11;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ\x2B6CᵮṰṲ㝴㹶㙸⡺", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataIn = new byte[1]
      {
        byBatteryNum
      };
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            num = enReturnCode != enReturnCode.e_OK ? 5 : 7;
            continue;
          case 2:
          case 3:
          case 6:
            goto label_14;
          case 4:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.BatteryInfo, dataIn, 1U, out dataOut, enSizeOut.eSIZE_128);
            num = 1;
            continue;
          case 5:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ\x2B6CᵮṰṲ㝴㹶㙸⡺", A_1), Module.a("ᑐ\x2152❔㡖⭘筚浜❞᩠卢ᡤ䝦ཨᥪɬɮ兰ㅲ㱴㡶⩸孺⩼㉾좀ꎂ\xE684\xE686\xE588\xE78A권\xDD8E\xF490\xF292\xF194뢖ꦘ겚\xF59C뾞횠쮢첤쮦첨讪쪬쪮얰잲\xDCB4\xD9B6\xDEB8鮺\xDFBC\xDEBE뗀럂ꃄ뗆냈\xEBCA\xA4CCꇎ럐볒", A_1), (object) enReturnCode);
              num = 6;
              continue;
            }
            num = 9;
            continue;
          case 7:
            abyBatteryInfo = dataOut;
            num = 0;
            continue;
          case 8:
            if (wmiBiosClient != null)
            {
              num = 4;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ\x2B6CᵮṰṲ㝴㹶㙸⡺", A_1), Module.a("ᡐ㵒♔⍖㡘㕚⥜㙞`ᝢ\x0C64\x0866ݨ䭪ɬ८兰\x2472ᡴṶ㭸㉺㉼Ȿ슀\xEF82\xEC84\xE286\xE788ﾊ권ﶎ\xF490\xE792\xE094\xE596\xF798ﺚ列뾞쾠횢즤쮦", A_1));
            num = 2;
            continue;
          case 9:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      if (1 == 0)
        ;
label_14:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ\x2B6CᵮṰṲ㝴㹶㙸⡺", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᑮ䅰\x0E72", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetBatteryInfoXML(byte byBatteryNum, ref XmlDocument xdocBatteryInfo)
    {
      int A_1 = 13;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᑒご⍖᭘㩚⥜\x2B5EѠᅢᱤ\x2E66ݨ൪ɬ㝮㱰㽲", A_1), Module.a("R\x2154㙖⭘⽚㡜㭞", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      byte[] abyBatteryInfo=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 8:
          case 9:
            num = 5;
            continue;
          case 1:
            if (this.B)
            {
              num = 4;
              continue;
            }
            abyBatteryInfo = (byte[]) null;
            enReturnCode = this.GetBatteryInfoFromBIOS(byBatteryNum, ref abyBatteryInfo);
            num = 2;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᑒご⍖᭘㩚⥜\x2B5EѠᅢᱤ\x2E66ݨ൪ɬ㝮㱰㽲", A_1), Module.a("ᙒ❔╖㙘⥚絜潞ᥠᡢ啤ᩦ䥨൪Ὤnᱰ卲㝴㹶㙸⡺嵼⡾첀쪂ꖄ\xE486\xE888\xE78A\xE18C꾎쎐\xF692\xF494\xF396뚘\xAB9Aꪜ\xF79E膠풢춤캦얨캪趬좮풰잲솴\xDEB6ힸ\xDCBA鶼\xDDBEꃀ럂뇄ꋆ믈닊\xEDCCꛎ뿐뗒뫔", A_1), (object) enReturnCode);
            num = 8;
            continue;
          case 3:
            enReturnCode = this.ConvertBatteryInfoBytesToXML(abyBatteryInfo, out xdocBatteryInfo);
            num = 0;
            continue;
          case 4:
            enReturnCode = this.GetBatteryInfoEmulated(out xdocBatteryInfo);
            num = 9;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_16;
          case 6:
            goto label_11;
          case 7:
            enReturnCode = new XmlTools().Validate(xdocBatteryInfo.InnerXml, Resources.hpCASL);
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      if (1 == 0)
        ;
label_16:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᑒご⍖᭘㩚⥜\x2B5EѠᅢᱤ\x2E66ݨ൪ɬ㝮㱰㽲", A_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ConvertBatteryInfoBytesToXML(byte[] abyData, out XmlDocument xdocBatteryInfo)
    {
      int A_1 = 9;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0C4E㹐㵒⍔\x3256⭘⽚\x1F5C㹞ᕠᝢdᕦၨ≪ͬ८Ṱㅲ\x0C74Ͷ\x1C78\x087A⥼ၾ\xD980캂즄", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      string str1 = string.Empty;
      xdocBatteryInfo = new XmlDocument();
      xdocBatteryInfo.PreserveWhitespace = true;
      string str2 = Module.a("獎湐⭒㡔㭖祘ⵚ㡜ⵞበ\x0A62\x0A64०周䥪屬䅮䅰兲啴ቶ\x1778\x187Aቼ\x1B7E\xE880\xED82\xE284몆\xAB88ﺊ歷\xE98E벐\xAB92랔ꢖ\xA798醚ꆜ\xD89E쒠힢\xE7A4욦\xDDA8\xDFAA좬\xDDAE좰者\xDBB4톶횸\xF4BA좼쮾뇀뛂뇄\xE7C6뇈ꛊꇌꇎꋐ\xEED2\xF7D4ꓖ뫘돚룜닞胠郢죤迦駨웪軬胮鳰\xDDF2雴零諸韺\xDFFC쇾\x0B00⌂┄✆⤈㜊䈌税攐挒怔挖✘ᄚ㴜㼞Ġ̢Ԥܦनପᄬ欮倰䜲吴श㌸", A_1);
      uint uiIndex = 0U;
      string uint16Element1 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0B4E㑐⁒㱔ざ㝘ᡚ㱜⽞`b\x0C64፦ၨ", A_1));
      string str3 = str2 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element1;
      string uint16Element2 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("͎ぐ⁒\x2154ᅖⱘ㝚ㅜᱞॠɢᝤf౨⡪౬ὮၰၲᱴͶx", A_1));
      string str4 = str3 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element2;
      string uint16Element3 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x1D4E㑐㹒㑔㹖㝘\x325A㍜㡞≠ɢᕤ٦੨ɪᥬ᙮", A_1));
      string str5 = str4 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element3;
      string uint16Element4 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("Ɏぐ⭒ၔ╖⭘㑚⽜", A_1));
      string str6 = str5 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element4;
      string uint16Element5 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E⡐げ㥔\x3256ᩘ㑚⡜ㅞᕠ", A_1));
      string str7 = str6 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element5;
      string uint16Element6 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x1B4E㑐㹒╔\x3256⭘㩚⥜⩞፠٢", A_1));
      string str8 = str7 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element6;
      string uint16Element7 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("᥎㹐㽒\x2154㙖㹘㹚", A_1));
      string str9 = str8 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element7;
      string uint16Element8 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E\x2450\x2152❔\x3256㝘⽚", A_1));
      string str10 = str9 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element8;
      string uint16Element9 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0B4E㑐⁒㱔ざ㝘\x0D5A\x325C㍞ᕠɢɤɦ", A_1));
      string str11 = str10 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element9;
      string uint16Element10 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("ᱎ═\x3252\x2154≖⩘\x0C5A\x325Cⵞ\x0560", A_1));
      string str12 = str11 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element10;
      string uint16Element11 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E㑐㽒㥔Ŗ㙘㝚⥜㹞٠٢呤", A_1));
      string str13 = str12 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element11;
      string uint16Element12 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E㑐㽒㥔Ŗ㙘㝚⥜㹞٠٢坤", A_1));
      string str14 = str13 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element12;
      string uint16Element13 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E㑐㽒㥔Ŗ㙘㝚⥜㹞٠٢噤", A_1));
      string str15 = str14 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element13;
      string uint16Element14 = this.CreateUInt16Element(abyData, ref uiIndex, Module.a("\x0C4E㑐㽒㥔Ŗ㙘㝚⥜㹞٠٢兤", A_1));
      string str16 = str15 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + uint16Element14;
      string stringElement1 = this.CreateStringElement(abyData, ref uiIndex, Module.a("ᱎ㑐\x2152㱔㙖㕘ᕚ⡜\x325E͠٢ᝤ", A_1), 16U);
      string str17 = str16 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + stringElement1;
      string stringElement2 = this.CreateStringElement(abyData, ref uiIndex, Module.a("Ɏぐ㵒⁔ㅖ㡘㡚⥜⩞፠٢ᝤ", A_1), 18U);
      string str18 = str17 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + stringElement2;
      string stringElement3 = this.CreateStringElement(abyData, ref uiIndex, Module.a("\x0C4EՐὒ㑔㕖㱘㝚", A_1), 16U);
      string xml = str18 + Module.a("潎煐獒畔睖祘筚絜罞", A_1) + stringElement3 + Module.a("潎煐獒畔睖祘筚絜捞习❢Ѥ፦\x0868啪杬佮兰卲啴䭶噸㑺\x087C\x0B7E\xF180\xF682\xF184릆莈랊ꊌ좎\xF490\xE792힔\xF696\xED98\xEF9A\xF89C\xED9E\xD8A0\xEAA2쮤솦욨\xE4AA\xD8AC\xDBAE솰욲솴覶", A_1);
      try
      {
        if (1 == 0)
          ;
        xdocBatteryInfo.LoadXml(xml);
      }
      catch (Exception ex)
      {
        this.log.ErrorMessage(this.GetType().ToString(), Module.a("\x0C4E㹐㵒⍔\x3256⭘⽚\x1F5C㹞ᕠᝢdᕦၨ≪ͬ८Ṱㅲ\x0C74Ͷ\x1C78\x087A⥼ၾ\xD980캂즄", A_1), Module.a("\x0A4E⥐げご❖ⵘ\x325A\x325Cㅞ孠䍢", A_1) + ex.Message);
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0C4E㹐㵒⍔\x3256⭘⽚\x1F5C㹞ᕠᝢdᕦၨ≪ͬ८Ṱㅲ\x0C74Ͷ\x1C78\x087A⥼ၾ\xD980캂즄", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪ᙬ彮\x0C70", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private string CreateUInt16Element(byte[] abyData, ref uint uiIndex, string sElementName)
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      string str1 = string.Empty;
      string str2 = string.Empty;
      string str3 = Module.a("汏", A_1) + sElementName + Module.a("湏", A_1);
      ushort num = (ushort)(abyData[uiIndex] + (abyData[(uiIndex + 1U)] << 8));
      string str4 = string.Format(Module.a("\x2B4F扑⥓", A_1), (object) num);
      string str5 = str3 + str4 + Module.a("汏絑", A_1) + sElementName + Module.a("湏塑", A_1);
      uiIndex += 2U;
      return str5;
    }

    private string CreateStringElement(byte[] abyData, ref uint uiIndex, string sElementName, uint uiMaxChars)
    {
      int A_1 = 10;
label_2:
      string str1 = string.Empty;
      string str2 = string.Empty;
      string str3 = Module.a("汏", A_1) + sElementName + Module.a("湏", A_1);
      uint num1 = (uint) ((int) uiIndex + (int) uiMaxChars - 1);
      int num2 = 3;
      bool flag=false;
      while (true)
      {
        switch (num2)
        {
          case 0:
            flag = true;
            num2 = 1;
            continue;
          case 1:
            goto label_3;
          case 2:
            --num1;
            num2 = 6;
            continue;
          case 3:
          case 6:
            num2 = 5;
            continue;
          case 4:
            if ((int) abyData[ num1] == 0)
            {
              num2 = 2;
              continue;
            }
            goto case 0;
          case 5:
            num2 = num1 >= uiIndex ? 4 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_3:
      try
      {
label_5:
        uint num3 = uiIndex;
        int num4 = 4;
        while (true)
        {
          switch (num4)
          {
            case 0:
              if ((int) abyData[ num3] == 34)
              {
                num4 = 19;
                continue;
              }
              ++num3;
              num4 = 5;
              continue;
            case 1:
              num4 = 16;
              continue;
            case 2:
              if (!char.IsControl((char) abyData[ num3]))
              {
                num4 = 12;
                continue;
              }
              break;
            case 3:
              num4 = num3 <= num1 ? 2 : 15;
              continue;
            case 4:
            case 5:
              num4 = 3;
              continue;
            case 6:
              goto label_41;
            case 7:
            case 13:
              num4 = 6;
              continue;
            case 8:
              str2 = Encoding.ASCII.GetString(abyData, (int) uiIndex, (int) num1 - (int) uiIndex + 1);
              num4 = 7;
              continue;
            case 9:
              if ((int) abyData[ num3] != 60)
              {
                num4 = 18;
                continue;
              }
              break;
            case 10:
              num4 = 11;
              continue;
            case 11:
              if ((int) abyData[ num3] != 38)
              {
                num4 = 1;
                continue;
              }
              break;
            case 12:
              num4 = 9;
              continue;
            case 14:
            case 15:
              num4 = 20;
              continue;
            case 16:
              if ((int) abyData[ num3] != 39)
              {
                num4 = 17;
                continue;
              }
              break;
            case 17:
              num4 = 0;
              continue;
            case 18:
              num4 = 21;
              continue;
            case 19:
              if (1 == 0)
                break;
              break;
            case 20:
              if (flag)
              {
                num4 = 8;
                continue;
              }
              str2 = string.Empty;
              this.log.FormatWarningMessage(this.GetType().ToString(), Module.a("ፏ⁑ㅓ㝕ⱗ㽙ཛ⩝\x125Fୡ\x0A63ťⵧ٩५ͭᕯᱱs", A_1), Module.a("\x124F᭑᭓Օ硗⡙㥛⩝ᕟၡ\x0A63ͥ౧䩩ᥫm嵯⩱㥳㩵啷᭹ṻች\xE57Fꊁ\xE683ﾅﲇ\xEF89ﾋ꺍\xF68F\xFD91\xE693뚕\xE397ꪙ\xE19B낝肟\xF1A1솣튥\xDCA7쎩슫즭邯욱\xDBB3隵\xDDB7횹\xD9BB펽ꖿ곁냃\xE6C5ꯇꗉꋋ뫍뗏병ꃓꗕ\xF8D7껙돛ﻝ藟迡铣鋥釧쫩\x9FEB髭苯鯱髳釵훷", A_1), (object) sElementName);
              num4 = 13;
              continue;
            case 21:
              if ((int) abyData[ num3] != 62)
              {
                num4 = 10;
                continue;
              }
              break;
            default:
              goto label_5;
          }
          flag = false;
          num4 = 14;
        }
      }
      catch (Exception ex)
      {
        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ፏ⁑ㅓ㝕ⱗ㽙ཛ⩝\x125Fୡ\x0A63ťⵧ٩५ͭᕯᱱs", A_1), Module.a("ᕏ⩑㝓㍕⡗\x2E59㕛ㅝ\x0E5F䉡ݣ॥٧ᱩ५ᱭѯ᭱ᩳᅵ塷㭹⽻㵽쥿쮁ꒃ\xE485\xF187ﺉ\xE98Bﶍ낏\xE691ﮓ뚕\xEB97\xEE99\xEE9B\xF79D캟얡麣蚥", A_1) + ex.Message);
        str2 = string.Empty;
      }
label_41:
      string str4 = str3 + str2 + Module.a("汏絑", A_1) + sElementName + Module.a("湏塑", A_1);
      uiIndex += uiMaxChars;
      return str4;
    }

    private enReturnCode GetBatteryInfoEmulated(out XmlDocument xdocBatteryInfo)
    {
      int A_1 = 3;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌ൎぐ❒\x2154\x3256⭘≚ᑜㅞݠౢ\x2064੦ᱨݪ౬᭮ᑰᝲ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocBatteryInfo = new XmlDocument();
      try
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_9;
            case 2:
              File.WriteAllText(this.BatteryInfoEmulationFile, Resources.GetBatteryInfoOutput);
              num = 3;
              continue;
            case 3:
              xdocBatteryInfo.Load(this.BatteryInfoEmulationFile);
              num = 0;
              continue;
            default:
              if (!File.Exists(this.BatteryInfoEmulationFile))
              {
                num = 2;
                continue;
              }
              goto case 3;
          }
        }
      }
      catch
      {
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_9:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌ൎぐ❒\x2154\x3256⭘≚ᑜㅞݠౢ\x2064੦ᱨݪ౬᭮ᑰᝲ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ彤䝦", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode BatteryInfoGet(string sCommandName, out object dataOut)
    {
      int A_1 = 7;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཌ\x2E4E═❒ご╖⁘ቚ㍜㥞\x0E60\x2462d፦", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘筚⩜㙞ᕠୢ䕤", A_1) + sCommandName);
      enReturnCode enReturnCode = this.C;
      dataOut = (object) null;
      int num = 7;
      while (true)
      {
        string str=null;
        switch (num)
        {
          case 0:
          case 4:
            goto label_14;
          case 1:
            if ((str = sCommandName) != null)
            {
              num = 2;
              continue;
            }
            break;
          case 2:
            num = 5;
            continue;
          case 3:
            dataOut = (object) (this.BatteryInfoSupported ? 1 : 0);
            num = 4;
            continue;
          case 5:
            if (str == Module.a("ཌ\x2E4E═❒ご╖⁘畚ᑜㅞݠౢ䭤㑦ᱨ᭪ᵬnͰݲၴ\x1376", A_1))
            {
              num = 3;
              continue;
            }
            break;
          case 6:
            if (1 == 0)
              ;
            num = 1;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 6;
              continue;
            }
            goto label_14;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 0;
      }
label_14:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ཌ\x2E4E═❒ご╖⁘ቚ㍜㥞\x0E60\x2462d፦", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨ၪ嵬ቮ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 7;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ьⅎ㡐❒Ք╖㙘\x2B5A㡜ⵞᕠᩢ≤ɦ\x1D68❪Ѭᱮհ", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘", A_1));
      this.C = this.Initialize();
      this.propertyGetList.Add(new Command.Property(Module.a("ཌ\x2E4E═❒ご╖⁘畚ᑜㅞݠౢ䭤㑦ᱨ᭪ᵬnͰݲၴ\x1376", A_1), typeof (bool), Module.a("ཌ\x2E4E═❒ご╖⁘ቚ㍜㥞\x0E60\x2462d፦", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ьⅎ㡐❒Ք╖㙘\x2B5A㡜ⵞᕠᩢ≤ɦ\x1D68❪Ѭᱮհ", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜", A_1));
    }

    private enReturnCode BatteryInfoSet(string sCommandName, object dataIn)
    {
      int A_1 = 17;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ㹬੮հ", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 2;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
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
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᕖ㡘⽚⥜㩞፠ᩢⱤ०ཨѪ㹬੮հ", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ卲\x0E74䝶Ѹ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 3;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞㉠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞㉠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘", A_1));
    }

    private enReturnCode BatteryInfoExecute(string sCommandName, object dataIn, out object dataOut)
    {
      int A_1 = 10;
label_3:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x124F㍑⁓≕㵗⡙╛\x175D\x0E5Fѡୣ⍥ၧཀྵཫ᭭ѯ\x1771", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      dataOut = (object) null;
      int num = 2;
      while (true)
      {
        if (1 == 0)
          ;
        XmlDocument xdocBatteryInfo=null;
        string str=null;
        switch (num)
        {
          case 0:
            num = 7;
            continue;
          case 1:
            if ((str = sCommandName) != null)
            {
              num = 0;
              continue;
            }
            break;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 5;
              continue;
            }
            goto label_17;
          case 3:
          case 6:
            goto label_17;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_17;
          case 5:
            num = 1;
            continue;
          case 7:
            if (str == Module.a("\x124F㍑⁓≕㵗⡙╛灝⥟ౡɣ॥", A_1))
            {
              num = 9;
              continue;
            }
            break;
          case 8:
            dataOut = (object) xdocBatteryInfo;
            num = 3;
            continue;
          case 9:
            xdocBatteryInfo = (XmlDocument) null;
            enReturnCode = this.GetBatteryInfoXML((byte) dataIn, ref xdocBatteryInfo);
            num = 4;
            continue;
          default:
            goto label_3;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 6;
      }
label_17:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x124F㍑⁓≕㵗⡙╛\x175D\x0E5Fѡୣ⍥ၧཀྵཫ᭭ѯ\x1771", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitExecuteList()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      this.executeList.Add(new Command.CommandExecute(Module.a("్ㅏ♑⁓㍕⩗⍙牛\x175D\x0E5Fѡୣ", A_1), typeof (byte), typeof (XmlDocument), Module.a("్ㅏ♑⁓㍕⩗⍙ᕛそٟൡⅣṥ൧३ᥫᩭᕯ", A_1), true));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
    }
  }
}
