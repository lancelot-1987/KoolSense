// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandF10Setting
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.IO;
using System.Management;
using System.Xml;

namespace CaslWmi
{
  internal class CommandF10Setting : Command
  {
    private enReturnCode C1 = enReturnCode.e_NULL_VALUE;
    private CommandF10Setting.A A1;
    private bool B1;

    private string F10SettingEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("็等籋\x1D4D㕏♑⁓㽕㙗㵙ᥛ㍝ᕟ\x0E61գብŧթɫ䁭⡯㽱㡳", 2);
      }
    }

    private enReturnCode E()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ᅕ㵗\x2E59", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ᅕ㵗\x2E59", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg䩩ᝫ幭൯", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode C()
    {
      int A_1 = 1;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌ࡎ㑐❒", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 5:
          case 8:
            goto label_17;
          case 1:
            if (this.A1 == null)
            {
              num = 7;
              continue;
            }
            goto label_17;
          case 2:
            if (this.B1)
            {
              num = 4;
              continue;
            }
            enReturnCode = this.AA();
            num = 0;
            continue;
          case 3:
            enReturnCode = enReturnCode.e_OUT_OF_MEMORY;
            num = 8;
            continue;
          case 4:
            enReturnCode = this.B();
            num = 5;
            continue;
          case 6:
            if (this.A1 != null)
            {
              this.A1.Aa = false;
              this.A1.Ba = false;
              this.B1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
              if (1 == 0)
                ;
              num = 2;
              continue;
            }
            num = 3;
            continue;
          case 7:
            try
            {
              this.A1 = new CommandF10Setting.A();
            }
            catch (Exception ex)
            {
              this.log.ErrorMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌ࡎ㑐❒", A_1), Module.a("Ɇㅈ⡊⡌㽎═㩒㩔㥖祘\x325A㍜ⱞᕠɢ\x0B64፦h੪ᥬٮὰᑲ啴\x2476\x1C78ེॼᙾ\xEF80\xE482ꖄ\xE886\xEB88\xE18A\xE88C\xEC8E\xE590ꦒ떔", A_1) + ex.Message);
              this.A1 = (CommandF10Setting.A) null;
            }
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌ࡎ㑐❒", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B()
    {
      int A_1 = 7;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ὄ⩎㝐\x2152ご\x2456ㅘ࡚㡜\x2B5Eᕠ\x0A62\x0B64fᩨ\x2D6AὬnᱰ㙲ᡴɶᕸ᩺ॼᙾ\xEE80\xED82", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 0;
     XmlEdit xmlEdit=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            try
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    File.WriteAllText(this.F10SettingEmulationFile, Resources.F10SettingEmulation);
                    num2 = 3;
                    continue;
                  case 1:
                    goto label_22;
                  case 3:
                    xmlDoc.Load(this.F10SettingEmulationFile);
                    num2 = 1;
                    continue;
                  default:
                    if (!File.Exists(this.F10SettingEmulationFile))
                    {
                      num2 = 0;
                      continue;
                    }
                    goto case 3;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Ὄ⩎㝐\x2152ご\x2456ㅘ࡚㡜\x2B5Eᕠ\x0A62\x0B64fᩨ\x2D6AὬnᱰ㙲ᡴɶᕸ᩺ॼᙾ\xEE80\xED82", A_1), Module.a("ࡌ㝎㉐㙒╔⍖じ㑚㍜罞ൠౢѤͦhժ੬佮ᑰṲt᭶\x1878ེᑼၾ\xEF80ꎂ\xE384\xEE86\xE588\xEE8A람꾎뚐\xE892꒔\xEA96뺘", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_22:
            num1 = 10;
            continue;
          case 1:
            num1 = 7;
            continue;
          case 2:
          case 9:
            goto label_25;
          case 3:
            if (1 == 0)
              ;
            xmlEdit = new XmlEdit(xmlDoc);
            num1 = 6;
            continue;
          case 4:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 8;
            continue;
          case 5:
            this.A1.Aa = xmlEdit.GetBool(Module.a("扌恎Ṑ♒\x2154❖ⱘ⽚牜᭞`ᝢѤ䡦\x2D68੪ᑬ㱮հቲݴͶ\x1C78ॺ佼㩾\xEF80\xE282\xE784\xEB86\xEC88\xEF8A", A_1));
            this.A1.Ba = xmlEdit.GetBool(Module.a("扌恎Ṑ♒\x2154❖ⱘ⽚牜᭞`ᝢѤ䡦⩨ṪṬ᭮ṰṲ㥴ᡶṸᑺ㡼ᅾ\xE080\xE182\xE984\xE286\xED88", A_1));
            num1 = 2;
            continue;
          case 6:
            if (xmlEdit != null)
            {
              num1 = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ὄ⩎㝐\x2152ご\x2456ㅘ\x1D5A㡜㹞ᕠᙢᝤɦ\x2068ժ୬n㑰Ṳt᭶\x1878ེᑼၾ\xEF80", A_1), Module.a("ьⅎ≐❒㑔㥖ⵘ\x325A㱜\x2B5E\x0860ౢ\x0B64䝦٨൪䵬㝮ᱰὲぴ\x1376ၸེ嵼ൾ\xE480\xF782\xF084\xF586\xE788\xEE8A\xE98C꾎ﾐ\xE692璉ﮖ", A_1));
            num1 = 9;
            continue;
          case 7:
            if (this.A1 != null)
            {
              num1 = 5;
              continue;
            }
            goto label_25;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 3;
              continue;
            }
            goto label_25;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 4;
              continue;
            }
            goto label_25;
          default:
            goto label_2;
        }
      }
label_25:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ὄ⩎㝐\x2152ご\x2456ㅘ࡚㡜\x2B5Eᕠ\x0A62\x0B64fᩨ\x2D6AὬnᱰ㙲ᡴɶᕸ᩺ॼᙾ\xEE80\xED82", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨ၪ嵬ቮ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode AA()
    {
      int A_1_1 = 19;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0B58㹚㭜ⵞѠၢ\x0D64㑦౨Ὢᥬٮὰᑲٴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1_1));
      bool A_0 = false;
      bool A_1_2 = false;
      enReturnCode enReturnCode = this.AAA(out A_0, out A_1_2);
      int num = 0;
      while (true)
      {
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
            num = 3;
            continue;
          case 2:
          case 5:
            goto label_11;
          case 3:
            if (this.A1 == null)
            {
              enReturnCode = enReturnCode.e_NULL_VALUE;
              num = 2;
              continue;
            }
            if (1 == 0)
              ;
            num = 4;
            continue;
          case 4:
            this.A1.Aa = A_0;
            this.A1.Ba = A_1_2;
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0B58㹚㭜ⵞѠၢ\x0D64㑦౨Ὢᥬٮὰᑲٴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲啴\x0C76䥸ٺ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode AAA(out bool A_0, out bool A_1)
    {
      int A_1_1 = 4;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0D49⥋㩍O❑㙓㩕ㅗ㥙\x0B5B፝⥟\x2B61ၣͥէᥩ", A_1_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255", A_1_1));
      string A_1_2 = string.Empty;
      A_0 = false;
      A_1 = false;
      enReturnCode enReturnCode = this.B(Module.a("ɉ\x1C4B湍ᑏ㍑ⵓՕⱗ㭙\x2E5B⩝՟ၡ", A_1_1), out A_1_2);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            A_0 = false;
            enReturnCode = enReturnCode.e_OK;
            num = 11;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_NOT_SUPPORTED)
            {
              num = 5;
              continue;
            }
            goto label_15;
          case 2:
            num = enReturnCode != enReturnCode.e_OK ? 10 : 8;
            continue;
          case 3:
          case 11:
            enReturnCode = this.B(Module.a("ॉ㥋㵍\x244F㵑㥓癕ᑗ㕙㭛ㅝ", A_1_1), out A_1_2);
            num = 9;
            continue;
          case 4:
          case 7:
            goto label_15;
          case 5:
            A_1 = false;
            enReturnCode = enReturnCode.e_OK;
            num = 7;
            continue;
          case 6:
            A_1 = string.Compare(A_1_2, Module.a("⽉≋⽍\x324F㹑ㅓ", A_1_1), true) == 0;
            num = 4;
            continue;
          case 8:
            if (1 == 0)
              ;
            A_0 = string.Compare(A_1_2, Module.a("⽉≋⽍\x324F㹑ㅓ", A_1_1), true) == 0;
            num = 3;
            continue;
          case 9:
            num = enReturnCode != enReturnCode.e_OK ? 1 : 6;
            continue;
          case 10:
            if (enReturnCode == enReturnCode.e_NOT_SUPPORTED)
            {
              num = 0;
              continue;
            }
            goto case 3;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0D49⥋㩍O❑㙓㩕ㅗ㥙\x0B5B፝⥟\x2B61ၣͥէᥩ", A_1_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ䙥፧婩ᅫ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B(string A_0, out string A_1)
    {
      int A_1_1 = 1;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C㩎㍐㽒㱔㑖๘ᙚᑜ\x0C5EѠᝢᅤ\x0E66ݨ౪㭬\x0E6Eᵰٲၴ", A_1_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_1 = string.Empty;
      int num1 = 0;
      string queryString=null;
      string A_0_1=null;
      string str1=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (1 == 0)
              ;
            if (A_0 == null)
            {
              num1 = 3;
              continue;
            }
            A_0_1 = string.Empty;
            string str2 = string.Empty;
            str1 = string.Empty;
            queryString = string.Format(Module.a("ᑆై݊ࡌ\x0C4EՐ獒͔㙖㕘\x2E5A㡜罞❠ㅢ⩤⩦䥨⍪㵬の㍰㩲㩴\x2476⩸Ṻॼ\x0B7E\xE880\xED82\xE284Ꞇ\xDE88쎊좌\xDD8E풐뎒\xDB94\xF696\xF498ﺚ붜ꊞ膠蒢\xDEA4鞦풨貪", A_1_1), (object) A_0);
            num1 = 1;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_31;
          case 3:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      try
      {
label_8:
        ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Module.a("㕆♈⑊㥌ፎ㥐⍒॔㹖㝘⡚⥜ⵞᑠ\x0E62d०\x1D68\x0E6A६൮ᡰᱲٴ", A_1_1), queryString).Get().GetEnumerator();
        int num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              try
              {
                int num3 = 4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_24;
                    case 2:
                      num3 = 1;
                      continue;
                    case 3:
                      if (!enumerator.MoveNext())
                      {
                        num3 = 2;
                        continue;
                      }
                      ManagementObject managementObject = (ManagementObject) enumerator.Current;
                      A_0_1 = (string) managementObject[Module.a("ᅆ⡈❊㡌⩎", A_1_1)];
                      str1 = (string) managementObject[Module.a("ᡆᙈࡊŌ๎ɐR", A_1_1)];
                      num3 = 0;
                      continue;
                    default:
                      num3 = 3;
                      continue;
                  }
                }
              }
              finally
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      enumerator.Dispose();
                      num3 = 1;
                      continue;
                    case 1:
                      goto label_21;
                    default:
                      if (enumerator != null)
                      {
                        num3 = 0;
                        continue;
                      }
                      goto label_21;
                  }
                }
label_21:;
              }
label_24:
              num2 = 5;
              continue;
            case 1:
            case 3:
              num2 = 2;
              continue;
            case 2:
              goto label_31;
            case 4:
              enReturnCode = this.AAAA(A_0_1, out A_1);
              this.log.FormatInformationMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C㩎㍐㽒㱔㑖๘ᙚᑜ\x0C5EѠᝢᅤ\x0E66ݨ౪㭬\x0E6Eᵰٲၴ", A_1_1), Module.a("ᕆⱈ⩊⥌潎癐⡒敔⩖繘筚\x2E5C㩞ᕠᝢ\x0C64०\x0E68䭪୬ᵮṰṲ啴㽶⥸\x247A㽼㙾캀킂횄\xE286ﶈﾊ\xE48C\xE18E\xF690뎒\xF694ﮖ\xF898\xE89A\xEE9Cꖞ膠蒢\xDEA4隦풨貪莬", A_1_1), (object) A_0, (object) A_1);
              num2 = 3;
              continue;
            case 5:
              if (!(str1 == Module.a("ཆ᥈ॊьNɐ\x0C52\x1754Ṗᙘ࡚ᡜㅞᑠ\x0E62dᕦ\x0868ὪѬnὰ", A_1_1)))
              {
                enReturnCode = enReturnCode.e_NOT_SUPPORTED;
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C㩎㍐㽒㱔㑖๘ᙚᑜ\x0C5EѠᝢᅤ\x0E66ݨ౪㭬\x0E6Eᵰٲၴ", A_1_1), Module.a("ц╈⩊㹌㱎煐❒ⱔ❖㱘筚穜\x245E兠Ṣ䉤䝦ݨѪᥬ佮ɰٲմݶᙸॺॼ\x1A7E\xE580ꎂ궄\xE086\xEC88ﾊ歷\xE68Eﾐ\xF492떔\xE196\xF898\xF79A\xE89C爵膠얢쪤햦覨\xD8AA좬\xDBAE얰\xDAB2\xDBB4킶莸鮺骼쒾\xF0C0뻂\xE2C4\xEEC6", A_1_1), (object) str1, (object) A_0);
                num2 = 1;
                continue;
              }
              num2 = 4;
              continue;
            default:
              goto label_8;
          }
        }
      }
      catch (Exception ex)
      {
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
        this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C㩎㍐㽒㱔㑖๘ᙚᑜ\x0C5EѠᝢᅤ\x0E66ݨ౪㭬\x0E6Eᵰٲၴ", A_1_1), Module.a("Ɇㅈ⡊⡌㽎═㩒㩔㥖祘㑚㹜㱞ᑠᅢᝤɦ൨䭪ѬŮ兰ɲtቶ\x0B78ɺᑼᅾ\xE680ꎂ튄쪆삈\xAB8A\xEB8C\xE08E\xE390뎒\xE194ﾖﲘ뮚몜\xE49E醠\xDEA2芤螦\xDAA8캪\xD9AC\xDBAE\xD8B0\xDDB2튴趶馸鲺욼躾변\xE4C2", A_1_1), (object) A_0, (object) ex.Message);
      }
label_31:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Fⱈ㽊\x1D4C㩎㍐㽒㱔㑖๘ᙚᑜ\x0C5EѠᝢᅤ\x0E66ݨ౪㭬\x0E6Eᵰٲၴ", A_1_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode AAAA(string A_0, out string A_1)
    {
      int A_1_1 = 9;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ࡎ㑐❒ᙔ≖⭘⥚㡜ㅞᕠ㕢Ѥ୦ᱨ\x0E6A", A_1_1), Module.a("ᱎ═\x3252❔⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦", A_1_1) + A_0);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_1 = string.Empty;
      int num1 = A_0.IndexOf('*');
      int num2 = 6;
      int num3=0;
      while (true)
      {
        switch (num2)
        {
          case 0:
            A_1 = A_0.Substring(num1 + 1, num3 - num1 - 1);
            num2 = 3;
            continue;
          case 1:
          case 3:
          case 5:
            goto label_12;
          case 2:
            num3 = A_0.IndexOf(',', num1 + 1);
            num2 = 4;
            continue;
          case 4:
            if (num3 == -1)
            {
              int length = A_0.Length;
              A_1 = A_0.Substring(num1 + 1, length - num1 - 1);
              num2 = 5;
              continue;
            }
            num2 = 0;
            continue;
          case 6:
            if (num1 != -1)
            {
              if (1 == 0)
                ;
              num2 = 2;
              continue;
            }
            enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ࡎ㑐❒ᙔ≖⭘⥚㡜ㅞᕠ㕢Ѥ୦ᱨ\x0E6A", A_1_1), Module.a("\x1B4E㥐㙒❔\x3256祘\x325A\x2E5C罞འౢ䕤٦ᩨὪ\x086CᵮᡰrṴ坶典兺呼彾\xE880\xED82ꖄ\xF386\xE188\xEE8A권\xE88E\xF890\xE592\xF094練릘ﺚ\xF39C\xEA9E철욢\xD7A4욦\xDDA8슪슬솮醰얲풴\xDBB6첸\xDEBA螼龾뫀\xF3C2룄\xE7C6", A_1_1), (object) A_0);
            num2 = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ࡎ㑐❒ᙔ≖⭘⥚㡜ㅞᕠ㕢Ѥ୦ᱨ\x0E6A", A_1_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪Ṭ᭮ၰݲtѶ䍸孺ټ佾ﲀ꾂ꖄ\xF486쪈ﺊﾌﶎ\xF490ﶒ\xE194솖\xF898\xF79A\xE89C爵鮠莢\xDEA4隦풨", A_1_1), (object) enReturnCode.ToString(), (object) A_1);
      return enReturnCode;
    }

    private enReturnCode F10SettingGet(string sCommandName, out object dataOut)
    {
      int A_1 = 14;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ቓ杕桗ख़㥛⩝ᑟୡ\x0A63ť⽧ཀྵᡫ", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ䉡፣ཥᱧɩ䱫", A_1) + sCommandName);
      enReturnCode enReturnCode = this.C1;
      string str1 = string.Empty;
      dataOut = (object) null;
      int num = 0;
      bool A_0_1=false;
      bool A_0_2=false;
      string str2=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 12;
              continue;
            }
            goto label_25;
          case 1:
            if (str2 == Module.a("ቓ杕桗ख़㥛⩝ᑟୡ\x0A63ť䙧\x2E69൫\x176D⍯ٱᕳѵ\x0C77ό\x0E7B䱽깿잁\xEA83\xE785\xEA87\xE689\xE98B\xEA8D", A_1))
            {
              A_0_2 = false;
              enReturnCode = this.B(out A_0_2);
              num = 10;
              continue;
            }
            num = 4;
            continue;
          case 2:
          case 5:
          case 15:
            goto label_25;
          case 3:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 15;
            continue;
          case 4:
            num = 14;
            continue;
          case 6:
            num = 3;
            continue;
          case 7:
            if (1 == 0)
              ;
            if ((str2 = sCommandName) != null)
            {
              num = 11;
              continue;
            }
            goto case 3;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 9;
              continue;
            }
            goto label_25;
          case 9:
            dataOut = (object)  (A_0_1 ? 1 : 0);
            num = 2;
            continue;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 13;
              continue;
            }
            goto label_25;
          case 11:
            num = 1;
            continue;
          case 12:
            num = 7;
            continue;
          case 13:
            dataOut = (object) (A_0_2 ? 1 : 0);
            num = 5;
            continue;
          case 14:
            if (str2 == Module.a("ቓ杕桗ख़㥛⩝ᑟୡ\x0A63ť䙧⥩ᥫᵭѯᵱᥳ㩵\x1777ᵹ\x137B偽앿\xEC81\xE583\xE485\xE487\xEF89\xE88B", A_1))
            {
              A_0_1 = false;
              enReturnCode = this.AAAA(out A_0_1);
              num = 8;
              continue;
            }
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_25:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ቓ杕桗ख़㥛⩝ᑟୡ\x0A63ť⽧ཀྵᡫ", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭偯\x0971䑳\x0B75", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B(out bool A_0)
    {
      int A_1_1 = 11;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡐ⁒ᅔ㙖⁘࡚⥜㹞፠ᝢdᕦ孨\x2E6Aͬ\x0E6E\x1370ὲၴ\x1376", A_1_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1_1));
      A_0 = false;
      string A_1_2 = string.Empty;
      enReturnCode enReturnCode = this.C();
      int num = 0;
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
            goto label_19;
          case 1:
            if (!this.B1)
            {
              enReturnCode = this.B(Module.a("ᥐ͒畔ፖ㡘≚\x0E5C\x2B5E`ᅢᅤɦ᭨", A_1_1), out A_1_2);
              num = 3;
              continue;
            }
            num = 2;
            continue;
          case 2:
            enReturnCode = this.B();
            num = 6;
            continue;
          case 3:
            num = enReturnCode != enReturnCode.e_OK ? 11 : 8;
            continue;
          case 4:
            A_0 = false;
            enReturnCode = enReturnCode.e_OK;
            num = 9;
            continue;
          case 5:
            num = 1;
            continue;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 12;
              continue;
            }
            goto label_19;
          case 7:
          case 9:
          case 10:
            goto label_19;
          case 8:
            A_0 = string.Compare(A_1_2, Module.a("㑐㵒㑔㕖㕘㹚", A_1_1), true) == 0;
            if (1 == 0)
              ;
            num = 7;
            continue;
          case 11:
            if (enReturnCode == enReturnCode.e_NOT_SUPPORTED)
            {
              num = 4;
              continue;
            }
            goto label_19;
          case 12:
            A_0 = this.A1.Aa;
            num = 10;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᡐ⁒ᅔ㙖⁘࡚⥜㹞፠ᝢdᕦ孨\x2E6Aͬ\x0E6E\x1370ὲၴ\x1376", A_1_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬੮⍰ᙲŴ㑶ᙸὺ\x187C彾벀ꎂﺄ랆\xF488꞊권\xED8E풐ﶒ\xF494\xF596\xF598ﺚ列뾞鲠莢\xDEA4隦풨", A_1_1), (object) enReturnCode.ToString(), (object) A_0.ToString());
      return enReturnCode;
    }

    private enReturnCode AAAA(out bool A_0)
    {
      int A_1_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᱔\x2456ᩘ\x2E5A\x2E5C\x2B5E\x0E60\x0E62⥤\x0866\x0E68Ѫ⡬Ůၰᅲᥴቶ\x1D78", A_1_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1_1));
      A_0 = false;
      string A_1_2 = string.Empty;
      enReturnCode enReturnCode = this.C();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_19;
          case 1:
            if (1 == 0)
              ;
            if (enReturnCode == enReturnCode.e_NOT_SUPPORTED)
            {
              num = 8;
              continue;
            }
            goto label_19;
          case 2:
            if (!this.B1)
            {
              enReturnCode = this.B(Module.a("ᙔ≖⩘⽚\x325C\x325E䅠⽢\x0A64f٨", A_1_1), out A_1_2);
              num = 3;
              continue;
            }
            num = 11;
            continue;
          case 3:
            num = enReturnCode != enReturnCode.e_OK ? 1 : 6;
            continue;
          case 4:
            A_0 = this.A1.Ba;
            num = 12;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_19;
          case 6:
            A_0 = string.Compare(A_1_2, Module.a("ご㥖㡘㥚ㅜ㩞", A_1_1), true) == 0;
            num = 10;
            continue;
          case 7:
            num = 2;
            continue;
          case 8:
            A_0 = false;
            enReturnCode = enReturnCode.e_OK;
            num = 9;
            continue;
          case 9:
          case 10:
          case 12:
            goto label_19;
          case 11:
            enReturnCode = this.B();
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᱔\x2456ᩘ\x2E5A\x2E5C\x2B5E\x0E60\x0E62⥤\x0866\x0E68Ѫ⡬Ůၰᅲᥴቶ\x1D78", A_1_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰ᙲ❴ቶ\x0D78㡺ቼ\x1B7E\xE480ꎂ뢄Ꞇ\xF288뮊\xF08Cꎎ놐\xF192킔練\xF898連\xF19C爵얠莢颤螦튨骪킬", A_1_1), (object) enReturnCode.ToString(), (object) A_0.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 12;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᭑㩓㽕ⱗਖ਼\x2E5Bㅝၟݡᙣብᅧ\x2D69५ᩭ㱯᭱ݳɵ", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
      this.C1 = this.E();
      this.propertyGetList.Add(new Command.Property(Module.a("ᑑ敓晕ୗ㽙⡛⩝य़ౡͣ䡥Ⱨ୩ᕫ㵭ѯ\x1371ٳɵᵷ\x0879乻偽앿\xEC81\xE583\xE485\xE487\xEF89\xE88B", A_1), typeof (bool), Module.a("ᑑ敓晕ୗ㽙⡛⩝य़ౡͣⅥ൧ṩ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("ᑑ敓晕ୗ㽙⡛⩝य़ౡͣ䡥\x2B67ὩὫᩭὯά㡳\x1975ίᕹ剻㭽\xEE7F\xE381\xE683\xEA85\xED87\xEE89", A_1), typeof (bool), Module.a("ᑑ敓晕ୗ㽙⡛⩝य़ౡͣⅥ൧ṩ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("᭑㩓㽕ⱗਖ਼\x2E5Bㅝၟݡᙣብᅧ\x2D69५ᩭ㱯᭱ݳɵ", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١", A_1));
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 11;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 15;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᱔㥖じ⽚ᡜ❞Ѡbၤ፦౨❪Ѭᱮհ", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("᱔㥖じ⽚ᡜ❞Ѡbၤ፦౨❪Ѭᱮհ", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť", A_1));
    }

    private class A
    {
      public bool Aa;
      public bool Ba;
    }
  }
}
