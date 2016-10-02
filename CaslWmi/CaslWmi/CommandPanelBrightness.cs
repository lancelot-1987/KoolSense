// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandPanelBrightness
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Threading;
using System.Xml;

namespace CaslWmi
{
  internal class CommandPanelBrightness : Command
  {
    private object A1 = new object();
    private object B1 = new object();
    private bool? C1 = new bool?();
    public bool? D1 = new bool?();
    private enReturnCode I1 = enReturnCode.e_NULL_VALUE;
    private enReturnCode J1 = enReturnCode.e_NULL_VALUE;
    private XmlDocument E1;
    private ushort[] F1;
    private ushort[] G1;
    private double[] H1;
    private bool K1;

    public bool BPanelBrightnessSupported
    {
      get
      {
label_2:
        bool bSupported = false;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (1 == 0)
                ;
              if (this.C1.HasValue)
              {
                num = 3;
                continue;
              }
              this.J1 = this.GetPanelBrightnessSupported(ref bSupported);
              num = 2;
              continue;
            case 1:
            case 5:
              goto label_11;
            case 2:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_11;
            case 3:
              bSupported = this.C1.Value;
              this.J1 = enReturnCode.e_OK;
              num = 1;
              continue;
            case 4:
              this.C1 = new bool?(bSupported);
              num = 5;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return bSupported;
      }
    }

    public bool BPanelBrightnessTablesSupported
    {
      get
      {
label_2:
        bool bSupported = false;
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 3:
              goto label_11;
            case 1:
              bSupported = this.D1.Value;
              this.J1 = enReturnCode.e_OK;
              num = 0;
              continue;
            case 2:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_11;
            case 4:
              this.D1 = new bool?(bSupported);
              num = 3;
              continue;
            case 5:
              if (this.D1.HasValue)
              {
                if (1 == 0)
                  ;
                num = 1;
                continue;
              }
              this.J1 = this.GetPanelBrightnessTablesSupported(ref bSupported);
              num = 2;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return bSupported;
      }
    }

    public XmlDocument PanelBrightnessTablesXML
    {
      get
      {
label_2:
        XmlDocument xdocTables = (XmlDocument) null;
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (1 == 0)
                ;
              xdocTables = this.E1;
              this.J1 = enReturnCode.e_OK;
              num = 5;
              continue;
            case 1:
              this.E1 = xdocTables;
              num = 3;
              continue;
            case 2:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 1;
                continue;
              }
              goto label_11;
            case 3:
            case 5:
              goto label_11;
            case 4:
              if (this.E1 != null)
              {
                num = 0;
                continue;
              }
              this.J1 = this.GetPanelBrightnessTables(out xdocTables);
              num = 2;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return xdocTables;
      }
    }

    public ushort[] BrightnessPercentTable
    {
      get
      {
label_2:
        ushort[] numArray = (ushort[]) null;
        int num = 5;
        while (true)
        {
          XmlDocument xdocTables=null;
          switch (num)
          {
            case 0:
              num = 6;
              continue;
            case 1:
            case 2:
              goto label_14;
            case 3:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_14;
            case 4:
              if (1 == 0)
                ;
              this.E1 = xdocTables;
              numArray = this.F1;
              num = 2;
              continue;
            case 5:
              if (this.F1 != null)
              {
                num = 0;
                continue;
              }
              break;
            case 6:
              if (this.F1.Length > 0)
              {
                num = 7;
                continue;
              }
              break;
            case 7:
              numArray = this.F1;
              this.J1 = enReturnCode.e_OK;
              num = 1;
              continue;
            default:
              goto label_2;
          }
          xdocTables = (XmlDocument) null;
          this.J1 = this.GetPanelBrightnessTables(out xdocTables);
          num = 3;
        }
label_14:
        return numArray;
      }
    }

    public ushort[] BrightnessNitTable
    {
      get
      {
label_2:
        ushort[] numArray = (ushort[]) null;
        int num = 2;
        while (true)
        {
          XmlDocument xdocTables=null;
          switch (num)
          {
            case 0:
              if (1 == 0)
                ;
              num = 3;
              continue;
            case 1:
            case 5:
              goto label_14;
            case 2:
              if (this.G1 != null)
              {
                num = 0;
                continue;
              }
              break;
            case 3:
              if (this.G1.Length > 0)
              {
                num = 4;
                continue;
              }
              break;
            case 4:
              numArray = this.G1;
              this.J1 = enReturnCode.e_OK;
              num = 5;
              continue;
            case 6:
              this.E1 = xdocTables;
              numArray = this.G1;
              num = 1;
              continue;
            case 7:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 6;
                continue;
              }
              goto label_14;
            default:
              goto label_2;
          }
          xdocTables = (XmlDocument) null;
          this.J1 = this.GetPanelBrightnessTables(out xdocTables);
          num = 7;
        }
label_14:
        return numArray;
      }
    }

    public double[] BrightnessPowerTable
    {
      get
      {
label_2:
        double[] numArray = (double[]) null;
        int num = 1;
        while (true)
        {
          XmlDocument xdocTables=null;
          switch (num)
          {
            case 0:
              if (this.J1 == enReturnCode.e_OK)
              {
                num = 3;
                continue;
              }
              goto label_14;
            case 1:
              if (this.H1 != null)
              {
                num = 2;
                continue;
              }
              break;
            case 2:
              if (1 == 0)
                ;
              num = 7;
              continue;
            case 3:
              this.E1 = xdocTables;
              numArray = this.H1;
              num = 6;
              continue;
            case 4:
              numArray = this.H1;
              this.J1 = enReturnCode.e_OK;
              num = 5;
              continue;
            case 5:
            case 6:
              goto label_14;
            case 7:
              if (this.H1.Length > 0)
              {
                num = 4;
                continue;
              }
              break;
            default:
              goto label_2;
          }
          xdocTables = (XmlDocument) null;
          this.J1 = this.GetPanelBrightnessTables(out xdocTables);
          num = 0;
        }
label_14:
        return numArray;
      }
    }

    private string PanelBrightnessPowerTablesEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ᕑㅓ≕ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ♵\x1777൹\x197B\x0C7D푿\xE381\xE683\xEA85\xED87黎쎋ﮍ\xE48F\xE291\xE193\xE295뚗슙톛튝", 12);
      }
    }

    private string PanelBrightnessEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ṍㅏ㱑ㅓ㩕ᩗ⡙㕛㥝\x085Fᙡ\x0A63ͥ᭧ᥩ⥫ͭկṱᕳɵᅷᕹቻ偽\xD87F쾁좃", 8);
      }
    }

    private enReturnCode Initialize()
    {
      int A_1 = 9;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154㹖㡘㝚㑜╞Ѡ", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.K1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154㹖㡘㝚㑜╞Ѡ", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪ᙬ彮\x0C70", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PanelBrightnessGet(string sCommandName, out object dataOut)
    {
      int A_1 = 18;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳㅵᵷ\x0E79", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc䙥ὧͩᡫ٭偯", A_1) + sCommandName);
      enReturnCode enReturnCode = this.I1;
      dataOut = (object) null;
      int num1 = 3;
      ushort uiData1=0;
      ushort uiData2=0;
      int num2=0;
      ushort uiData3=0;
      ushort uiData4=0;
      string key1=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 18;
              continue;
            }
            goto label_43;
          case 1:
          case 2:
          case 4:
          case 5:
          case 6:
          case 7:
          case 11:
          case 15:
          case 20:
          case 26:
          case 29:
            goto label_43;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 12;
              continue;
            }
            goto label_43;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 21;
              continue;
            }
            goto label_43;
          case 9:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.E.TryGetValue(key1, out num2))
            {
              num1 = 10;
              continue;
            }
            goto case 22;
          case 10:
            num1 = 27;
            continue;
          case 12:
            num1 = 19;
            continue;
          case 13:
            dataOut = (object) uiData3;
            num1 = 5;
            continue;
          case 14:
            num1 = 9;
            continue;
          case 16:
            if (1 == 0)
              ;
            num1 = 28;
            continue;
          case 17:
            dataOut = (object) uiData2;
            num1 = 2;
            continue;
          case 18:
            dataOut = (object) uiData1;
            num1 = 6;
            continue;
          case 19:
            if ((key1 = sCommandName) != null)
            {
              num1 = 16;
              continue;
            }
            goto case 22;
          case 21:
            dataOut = (object) uiData4;
            num1 = 15;
            continue;
          case 22:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 1;
            continue;
          case 23:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 13;
              continue;
            }
            goto label_43;
          case 24:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(10);
            string key2 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵\x2B77ཹ\x0C7B\x0E7D\xEF7F\xF081\xF083\xE385\xEC87", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key2, num3);
            string key3 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵⡷ό\x0E7Bᵽ\xE57F\xEC81\xF083", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ㅷᑹ\x187B\x1B7D\xF87F", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵㙷\x1379\x087Bൽ", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵⡷\x2D79ㅻ", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ⱷ᭹ṻች\xE57F\xF181ꪃ햅ﶇ憎ﲋ\xE18D\xE28F\xE691\xF193\xF295", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            string key8 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ⱷ᭹ṻች\xE57F\xF181ꪃ입\xE487\xE689", A_1);
            int num9 = 6;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key8, num9);
            string key9 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ⱷ᭹ṻች\xE57F\xF181ꪃ횅\xED87\xF889\xEF8B\xEB8Dﺏ\xE691", A_1);
            int num10 = 7;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key9, num10);
            string key10 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ⱷ᭹ṻች\xE57F\xF181ꪃ종\xE187ﺉﾋ", A_1);
            int num11 = 8;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key10, num11);
            string key11 = Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳ塵ⱷ᭹ṻች\xE57F\xF181ꪃ횅\xE787ﶉ\xE98Bﲍ쒏\xF391\xF693歹ﶗ\xE999", A_1);
            int num12 = 9;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key11, num12);
            // ISSUE: reference to a compiler-generated field
            global::A.E = dictionary;
            num1 = 14;
            continue;
          case 25:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 17;
              continue;
            }
            goto label_43;
          case 27:
            switch (num2)
            {
              case 0:
                dataOut =(object) (this.BPanelBrightnessSupported ? 1 : 0);
                enReturnCode = this.J1;
                num1 = 20;
                continue;
              case 1:
                uiData4 = (ushort) 0;
                enReturnCode = this.GetCurrentPanelBrightness(enPanelBrightnessDataType.Percent, ref uiData4);
                num1 = 8;
                continue;
              case 2:
                uiData3 = (ushort) 0;
                enReturnCode = this.GetCurrentPanelBrightness(enPanelBrightnessDataType.Index, ref uiData3);
                num1 = 23;
                continue;
              case 3:
                uiData2 = (ushort) 0;
                enReturnCode = this.GetCurrentPanelBrightness(enPanelBrightnessDataType.Nits, ref uiData2);
                num1 = 25;
                continue;
              case 4:
                uiData1 = (ushort) 0;
                enReturnCode = this.GetCurrentPanelBrightness(enPanelBrightnessDataType.PWM, ref uiData1);
                num1 = 0;
                continue;
              case 5:
                dataOut =(object) (this.BPanelBrightnessTablesSupported ? 1 : 0);
                enReturnCode = this.J1;
                num1 = 26;
                continue;
              case 6:
                dataOut = (object) this.PanelBrightnessTablesXML;
                enReturnCode = this.J1;
                num1 = 7;
                continue;
              case 7:
                dataOut = (object) this.BrightnessPercentTable;
                enReturnCode = this.J1;
                num1 = 29;
                continue;
              case 8:
                dataOut = (object) this.BrightnessNitTable;
                enReturnCode = this.J1;
                num1 = 4;
                continue;
              case 9:
                dataOut = (object) this.BrightnessPowerTable;
                enReturnCode = this.J1;
                num1 = 11;
                continue;
              default:
                num1 = 30;
                continue;
            }
          case 28:
            // ISSUE: reference to a compiler-generated field
            if (global::A.E == null)
            {
              num1 = 24;
              continue;
            }
            goto case 14;
          case 30:
            num1 = 22;
            continue;
          default:
            goto label_2;
        }
      }
label_43:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ࡗ㭙\x325B㭝\x0C5F\x2061ᙣཥཧɩᡫmᕯűݳㅵᵷ\x0E79", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩ཫŭᵯάᕳᡵᱷ婹ݻ乽ﵿꊁ\xF383\xEF85ﲇ\xE289겋\xF58Dꆏ\xEF91", A_1), (object) sCommandName, (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPanelBrightnessSupported(ref bool bSupported)
    {
      int A_1 = 3;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      int num1 = 27;
      while (true)
      {
        WmiBIOSClient wmiBiosClient=null;
        OperatingSystem osVersion=null;
        bool flag=false;
        int num2=0;
        switch (num1)
        {
          case 0:
          case 1:
          case 4:
          case 6:
          case 15:
          case 21:
          case 23:
          case 25:
            goto label_37;
          case 2:
            if (1 == 0)
              ;
            if (enReturnCode == enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              num1 = 20;
              continue;
            }
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("ై㥊㽌⁎⍐獒敔⽖≘歚⁜罞ݠᅢ\x0A64੦䥨⥪\x246C\x206E≰卲≴㩶へ孺ṼṾ\xED80\xEF82ꖄ햆\xEC88\xEA8A\xE98Cꂎꎐꊒﶔ랖\xEE98\xF39A\xF49C\xF39E쒠莢스슦\xDDA8\xDFAA쒬솮횰鎲\xE5B4횶ힸ\xDEBA톼ﶾ돀ꫂꋄ꿆뷈ꗊ\xA8CC볎ꋐ\xF3D2볔맖뿘듚", A_1), (object) enReturnCode);
            num1 = 21;
            continue;
          case 3:
            if (this.C1.HasValue)
            {
              num1 = 22;
              continue;
            }
            wmiBiosClient = new WmiBIOSClient();
            num1 = 26;
            continue;
          case 5:
            this.log.InformationMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("وᡊ浌♎≐獒͔㹖⩘⽚㱜罞\x0E60ᅢ䕤୦\x0868Ὢ\x086Cᵮ彰卲啴偶⩸\x0E7Aർཾ\xEE80\xF182\xF184ꂆꦈ\xE28Aﺌ꾎\xF290\xF292璉\xF496\xEC98\xF79Aﲜ\xEB9E쒠잢薤얦좨\xD8AA좬쮮醰\xDCB2\xDBB4鞶쾸튺\xD9BC\xDABE껀\xE3C2ꇄ뗆ꃈ뷊\xA8CC뷎\xF1D0뫒믔ꓖ귘뫚뇜돞蓠蟢쯤쟦뫨\x9FEA賬臮闰鋲蟴鏶\xD9F8귺뫼뻾℀琂氄欆攈⬊缌樎成昒礔挖㤘爚猜㼞删嘢唤圦䘨太夬䨮唰ጲ圴制倸唺娼Ἶ݀ɂॄᑆై", A_1));
            num1 = 23;
            continue;
          case 7:
            num1 = enReturnCode != enReturnCode.e_OK ? 2 : 19;
            continue;
          case 8:
            byte[] dataIn = new byte[4];
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetCurrentPanelBrightness, dataIn, 4U, out dataOut, enSizeOut.eSIZE_4);
            num1 = 7;
            continue;
          case 9:
            num1 = osVersion.Platform != PlatformID.Win32NT ? 16 : 17;
            continue;
          case 10:
            bSupported = this.C1.Value;
            enReturnCode = enReturnCode.e_OK;
            num1 = 1;
            continue;
          case 11:
            num1 = 28;
            continue;
          case 12:
            num2 = osVersion.Version.Major >= 6 ? 1 : 0;
            break;
          case 13:
            num1 = !flag ? 3 : 11;
            continue;
          case 14:
            bSupported = true;
            this.log.InformationMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("ై♊㡌⍎ぐ❒㱔㡖㝘筚㑜ⱞ䅠Ţd\x0E66ݨ౪䵬ᩮɰᙲᅴ坶䑸䙺䍼彾Ꚁ킂\xF084\xF786麗\xE48Aﾌﮎ뚐뎒ﲔ\xE496릘\xF39Aﲜ\xED9E얠삢쪤쎦첨쾪趬캮슰鎲銴쎶쮸캺\xD8BC颾\xE1C0\xEBC2ꯄ\xA8C6뷈\xEBCA\xA8CC많듐뷒\xF5D4듖뇘뻚뻜듞裠跢苤쟦ꯨꋪꋬ볮\xDEF0볲꛴\xDEF6", A_1));
            num1 = 4;
            continue;
          case 16:
            num2 = 0;
            break;
          case 17:
            num1 = 12;
            continue;
          case 18:
            bSupported = this.C1.Value;
            num1 = 5;
            continue;
          case 19:
            bSupported = true;
            num1 = 0;
            continue;
          case 20:
            bSupported = false;
            enReturnCode = enReturnCode.e_OK;
            num1 = 15;
            continue;
          case 22:
            bSupported = this.C1.Value;
            enReturnCode = enReturnCode.e_OK;
            num1 = 6;
            continue;
          case 24:
            if (this.C1.HasValue)
            {
              num1 = 18;
              continue;
            }
            goto case 5;
          case 26:
            if (wmiBiosClient != null)
            {
              num1 = 8;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("H╊㹌㭎ぐ㵒\x2154㹖㡘⽚㑜ぞའ䍢\x0A64Ŧ䥨㱪lٮ㍰㩲㩴\x2476㩸\x177Aᑼ\x1A7E\xEF80\xF782ꖄ\xF586\xEC88ﾊ\xF88Cﶎﾐ\xF692\xF194랖\xF798\xEE9A\xF19C\xF39E", A_1));
            num1 = 25;
            continue;
          case 27:
            if (this.K1)
            {
              num1 = 14;
              continue;
            }
            osVersion = Environment.OSVersion;
            num1 = 9;
            continue;
          case 28:
            if (this.C1.HasValue)
            {
              num1 = 10;
              continue;
            }
            ushort uiData = (ushort) 0;
            enReturnCode = this.GetCurrentPanelBrightnessFromOS(enPanelBrightnessDataType.Percent, out uiData);
            num1 = 24;
            continue;
          default:
            goto label_2;
        }
        flag = num2 != 0;
        num1 = 13;
      }
label_37:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x1F4Eぐ㵒ご㭖᭘⥚㑜㡞ॠᝢ\x0B64ɦᩨᡪ㹬ᩮŰͲᩴն\x0D78Ṻ\x197C", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ䕤ᑦ\x1D68੪ᥬᩮɰ卲䡴坶ɸ䭺|卾ꆀ\xF082\xF084\xF786麗\xE48Aﾌﮎ\xF490\xF792떔ꪖ릘\xE09A겜\xE29E", A_1), (object) enReturnCode.ToString(), (object) bSupported.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPanelBrightnessTablesSupported(ref bool bSupported)
    {
      int A_1 = 8;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("्㕏♑ѓ㝕㙗㽙せᱝ\x125Fୡͣ\x0E65ᱧѩ५ᵭͯ♱ᕳᑵᑷόཻ\x2D7D\xF57F\xF281\xF483\xE985慎ﺉ\xE98B\xEA8D", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      int num = 1;
      WmiBIOSClient wmiBiosClient=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              num = 4;
              continue;
            }
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("्㕏♑ѓ㝕㙗㽙せᱝ\x125Fୡͣ\x0E65ᱧѩ५ᵭͯ♱ᕳᑵᑷόཻ\x2D7D\xF57F\xF281\xF483\xE985慎ﺉ\xE98B\xEA8D", A_1), Module.a("୍≏⁑㭓\x2455硗橙\x245B╝偟ὡ䑣eᩧթū乭㉯㭱㭳╵塷\x2D79ㅻ㝽ꁿ\xE181\xE583\xEA85\xE487ꪉ\xDE8B\xEB8D\xF18F\xF691뮓꒕ꢗ\xF299벛\xE99D좟쮡좣쎥袧충즫\xDAAD쒯\xDBB1\xDAB3통颷\xEAB9\xDDBB킽ꖿ껁蛃듅ꇇ귉\xA4CB뫍뻏럑\xA7D3ꗕ\xF8D7동닛룝迟", A_1), (object) enReturnCode);
            num = 11;
            continue;
          case 1:
            if (this.K1)
            {
              num = 10;
              continue;
            }
            wmiBiosClient = new WmiBIOSClient();
            num = 8;
            continue;
          case 2:
          case 3:
          case 7:
          case 11:
          case 12:
            goto label_18;
          case 4:
            bSupported = false;
            enReturnCode = enReturnCode.e_OK;
            num = 7;
            continue;
          case 5:
            num = enReturnCode != enReturnCode.e_OK ? 0 : 9;
            continue;
          case 6:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetPanelBrightnessTables, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 5;
            continue;
          case 8:
            if (wmiBiosClient != null)
            {
              num = 6;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("्㕏♑ѓ㝕㙗㽙せᱝ\x125Fୡͣ\x0E65ᱧѩ५ᵭͯ♱ᕳᑵᑷόཻ\x2D7D\xF57F\xF281\xF483\xE985慎ﺉ\xE98B\xEA8D", A_1), Module.a("ݍ㹏\x2151⁓㝕㙗\x2E59㕛㽝ᑟୡୣ\x0865䡧թ੫乭❯άᵳ㑵ㅷ㕹⽻㵽\xEC7F\xEB81\xE183\xE885ﲇꪉﺋ\xEB8D\xE48F\xE791\xE693\xF895ﶗﺙ벛\xF09D햟캡좣", A_1));
            num = 3;
            continue;
          case 9:
            bSupported = true;
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 10:
            bSupported = true;
            this.log.InformationMessage(this.GetType().ToString(), Module.a("्㕏♑ѓ㝕㙗㽙せᱝ\x125Fୡͣ\x0E65ᱧѩ५ᵭͯ♱ᕳᑵᑷόཻ\x2D7D\xF57F\xF281\xF483\xE985慎ﺉ\xE98B\xEA8D", A_1), Module.a("୍㵏❑㡓㝕ⱗ㍙㍛そ䁟ୡᝣ䙥੧ཀྵիmᝯ剱ųյᵷṹ屻䍽뵿벁ꒃꆅ\xDB87ﾉﲋﺍﾏ\xE091\xE093놕뢗\xF399\xEF9B뺝좟쎡횣슥쮧얩좫쮭풯銱햳억颷鶹좻첽떿\xA7C1\xE3C3\xE6C5\xE0C7\xA4C9ꏋ뫍\xF0CF럑ꋓ돕뛗龎뿛뛝藟臡迣迥蛧跩쳫곭맯뷱\xA7F3\xD9F5럷\xA9F9헻", A_1));
            num = 12;
            continue;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("्㕏♑ѓ㝕㙗㽙せᱝ\x125Fୡͣ\x0E65ᱧѩ५ᵭͯ♱ᕳᑵᑷόཻ\x2D7D\xF57F\xF281\xF483\xE985慎ﺉ\xE98B\xEA8D", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg䩩Ὣᩭᅯٱųյ塷䝹屻ս끿ﾁꢃꚅﮇﾉﲋﺍﾏ\xE091\xE093\xF395ﲗ몙ꆛ뺝\xDB9F鎡\xD9A3", A_1), (object) enReturnCode.ToString(), (object) bSupported.ToString());
      return enReturnCode;
    }

    private enReturnCode GetCurrentPanelBrightness(enPanelBrightnessDataType eDataType, ref ushort uiData)
    {
      int A_1 = 11;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᑖⱘ⥚⽜㩞འᝢ㕤٦ݨ\x0E6AŬ\x2D6EͰᩲቴὶ\x0D78ᕺ\x187C\x0C7E\xF280", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num1 = 6;
      while (true)
      {
        OperatingSystem osVersion=null;
        bool flag=false;
        int num2=0;
        switch (num1)
        {
          case 0:
            if (!flag)
            {
              enReturnCode = this.GetCurrentPanelBrightnessFromBIOS(eDataType, ref uiData);
              num1 = 3;
              continue;
            }
            num1 = 9;
            continue;
          case 1:
          case 3:
          case 10:
            goto label_17;
          case 2:
            num1 = osVersion.Platform != PlatformID.Win32NT ? 7 : 5;
            continue;
          case 4:
            num2 = osVersion.Version.Major >= 6 ? 1 : 0;
            break;
          case 5:
            num1 = 4;
            continue;
          case 6:
            if (this.K1)
            {
              num1 = 8;
              continue;
            }
            osVersion = Environment.OSVersion;
            num1 = 2;
            continue;
          case 7:
            num2 = 0;
            break;
          case 8:
            enReturnCode = this.A(eDataType, out uiData);
            num1 = 10;
            continue;
          case 9:
            enReturnCode = this.GetCurrentPanelBrightnessFromOS(eDataType, out uiData);
            num1 = 1;
            continue;
          default:
            goto label_2;
        }
        flag = num2 != 0;
        num1 = 0;
      }
label_17:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᙐ㙒\x2154ᑖⱘ⥚⽜㩞འᝢ㕤٦ݨ\x0E6AŬ\x2D6EͰᩲቴὶ\x0D78ᕺ\x187C\x0C7E\xF280", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᱮհቲŴɶ\x0A78孺䁼彾婢뎂\xF884\xAB86ꦈﺊ\xE48C쮎\xF090\xE792\xF494랖꒘뮚\xE69C꺞\xDCA0", A_1), (object) enReturnCode.ToString(), (object) uiData.ToString());
      return enReturnCode;
    }

    private enReturnCode A(enPanelBrightnessDataType A_0, out ushort A_1)
    {
      int A_1_1 = 0;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ཋ㭍≏⁑ㅓ㡕ⱗਖ਼㵛そ՟\x0E61♣ᑥŧ൩ѫᩭṯ\x1771ݳյ㵷\x1779ॻች\xE17F\xF681\xED83\xE985\xE687", A_1_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑瑓\x2155ㅗ\x2E59㑛繝", A_1_1) + A_0.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      ushort uiPercent = (ushort) 0;
      A_1 = (ushort) 0;
      int num1 = 13;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 16;
              continue;
            }
            goto label_39;
          case 1:
            A_1 = this.ConvertPercentToNits(uiPercent).Value;
            num1 = 18;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 25;
              continue;
            }
            goto case 4;
          case 3:
            A_1 = (ushort) ((int) uiPercent * (int) byte.MaxValue / 100);
            num1 = 14;
            continue;
          case 4:
            num1 = 17;
            continue;
          case 5:
            num1 = 22;
            continue;
          case 6:
          case 12:
          case 14:
          case 18:
          case 20:
          case 21:
            goto label_39;
          case 7:
            num1 = A_0 != enPanelBrightnessDataType.Index ? 24 : 19;
            continue;
          case 8:
            num1 = A_0 != enPanelBrightnessDataType.Nits ? 7 : 23;
            continue;
          case 9:
            A_1 = uiPercent;
            num1 = 20;
            continue;
          case 10:
            if (this.BPanelBrightnessTablesSupported)
            {
              num1 = 1;
              continue;
            }
            if (1 == 0)
              ;
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num1 = 12;
            continue;
          case 11:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num1 = 6;
              continue;
            }
            num1 = 15;
            continue;
          case 13:
            try
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_28;
                  case 2:
                    File.WriteAllText(this.PanelBrightnessEmulationFile, Resources.PanelBrightnessEmulation);
                    num2 = 3;
                    continue;
                  case 3:
                    xmlDoc.Load(this.PanelBrightnessEmulationFile);
                    num2 = 0;
                    continue;
                  default:
                    if (!File.Exists(this.PanelBrightnessEmulationFile))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 3;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ཋ㭍≏⁑ㅓ㡕ⱗਖ਼㵛そ՟\x0E61♣ᑥŧ൩ѫᩭṯ\x1771ݳյ㵷\x1779ॻች\xE17F\xF681\xED83\xE985\xE687", A_1_1), Module.a("ͅぇ⥉⥋㹍\x244F㭑㭓㡕硗㙙㍛㽝џୡ\x0A63ť䡧ཀྵū᭭ᱯ\x1371sή\x1777ᑹ屻\x187D\xE97F\xEE81\xE183벅ꢇ궉\xF78B뾍\xED8F떑", A_1_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_28:
            num1 = 0;
            continue;
          case 15:
            A_1 = this.ConvertPercentToIndex(uiPercent).Value;
            num1 = 21;
            continue;
          case 16:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 2;
            continue;
          case 17:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 5;
              continue;
            }
            goto label_39;
          case 19:
            num1 = 11;
            continue;
          case 22:
            num1 = A_0 != enPanelBrightnessDataType.Percent ? 8 : 9;
            continue;
          case 23:
            num1 = 10;
            continue;
          case 24:
            if (A_0 == enPanelBrightnessDataType.PWM)
            {
              num1 = 3;
              continue;
            }
            goto label_39;
          case 25:
            uiPercent = new XmlEdit(xmlDoc).GetUInt16(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟Ⅱᅣᑥᩧཀྵɫᩭ㉯qᵳᅵၷ\x0E79ቻ\x1B7D\xF37F\xF181풃\xE385慎\xE989\xE98B\xE08D\xE48F", A_1_1));
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_39:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ņⵇ㹉ཋ㭍≏⁑ㅓ㡕ⱗਖ਼㵛そ՟\x0E61♣ᑥŧ൩ѫᩭṯ\x1771ݳյ㹷\x0879\x137B\x137D콿톁", A_1_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ᝣብ१ṩᥫᵭ偯佱味\x0D75䡷ݹ偻幽\xF57F\xEB81삃\xE785ﲇ\xEB89겋뎍낏\xE991ꖓ\xEB95", A_1_1), (object) enReturnCode.ToString(), (object) A_1.ToString());
      return enReturnCode;
    }

    private enReturnCode GetCurrentPanelBrightnessFromOS(enPanelBrightnessDataType eDataType, out ushort uiData)
    {
      int A_1 = 6;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61䑣", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      ushort uiPercent = (ushort) 0;
      uiData = (ushort) 0;
      if (1 == 0)
        ;
      int num1 = 3;
      object obj=new object();
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num1 = 2;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_85;
          case 3:
            if (eDataType == enPanelBrightnessDataType.PWM)
            {
              num1 = 0;
              continue;
            }
            Monitor.Enter(obj = this.A1);
            num1 = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      try
      {
label_8:
        bool? nullable1 = PanelBrightnessHelper.IsDreamColorEnabled();
        int num2 = 12;
        while (true)
        {
          int? nullable2=0;
          int? nullable3=0;
          ushort? nullable4=0;
          ushort? dreamColorNits=0;
          int num3=0;
          int? nullable5=0;
          switch (num2)
          {
            case 0:
              num3 = nullable1.HasValue ? 1 : 0;
              goto label_79;
            case 1:
              if (!this.BPanelBrightnessTablesSupported)
              {
                enReturnCode = enReturnCode.e_INVALID_COMMAND;
                num2 = 7;
                continue;
              }
              num2 = 35;
              continue;
            case 2:
            case 4:
            case 5:
            case 7:
            case 18:
            case 21:
            case 26:
            case 33:
            case 39:
            case 44:
              num2 = 10;
              continue;
            case 3:
              uiData = dreamColorNits.Value;
              num2 = 2;
              continue;
            case 6:
              num2 = 24;
              continue;
            case 8:
              nullable5 = nullable2;
              break;
            case 9:
              num2 = eDataType != enPanelBrightnessDataType.Nits ? 25 : 27;
              continue;
            case 10:
              goto label_85;
            case 11:
              num2 = nullable4.HasValue ? 41 : 17;
              continue;
            case 12:
              num2 = !nullable1.GetValueOrDefault() ? 15 : 36;
              continue;
            case 13:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num2 = 28;
                continue;
              }
              goto case 2;
            case 14:
              uiData = this.ConvertPercentToIndex(uiPercent).Value;
              num2 = 18;
              continue;
            case 15:
              num3 = 0;
              goto label_79;
            case 16:
              uiPercent = this.ConvertNitsToPercent(dreamColorNits.Value).Value;
              uiData = this.ConvertPercentToIndex(uiPercent).Value;
              num2 = 39;
              continue;
            case 17:
              nullable2 = new int?();
              num2 = 8;
              continue;
            case 19:
              if (this.BPanelBrightnessTablesSupported)
              {
                num2 = 14;
                continue;
              }
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num2 = 33;
              continue;
            case 20:
              num2 = 32;
              continue;
            case 22:
              if (eDataType == enPanelBrightnessDataType.Index)
              {
                num2 = 30;
                continue;
              }
              goto case 2;
            case 23:
              uiData = this.ConvertNitsToPercent(dreamColorNits.Value).Value;
              num2 = 26;
              continue;
            case 24:
              if (!this.BPanelBrightnessTablesSupported)
              {
                enReturnCode = enReturnCode.e_INVALID_COMMAND;
                num2 = 4;
                continue;
              }
              num2 = 23;
              continue;
            case 25:
              if (eDataType == enPanelBrightnessDataType.Index)
              {
                num2 = 29;
                continue;
              }
              goto case 2;
            case 27:
              num2 = 1;
              continue;
            case 28:
              num2 = 40;
              continue;
            case 29:
              num2 = 19;
              continue;
            case 30:
              num2 = 34;
              continue;
            case 31:
              uiData = uiPercent;
              num2 = 44;
              continue;
            case 32:
              num2 = eDataType != enPanelBrightnessDataType.Nits ? 42 : 3;
              continue;
            case 34:
              if (this.BPanelBrightnessTablesSupported)
              {
                num2 = 16;
                continue;
              }
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num2 = 5;
              continue;
            case 35:
              uiData = this.ConvertPercentToNits(uiPercent).Value;
              num2 = 21;
              continue;
            case 36:
              num2 = 0;
              continue;
            case 37:
              this.log.InformationMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("ࡋ㱍㕏㍑㥓ᕕ㝗㙙㍛ⱝ䁟ݡ\x0A63ݥ੧٩५੭幯剱味ㅵᵷ\x0E79\x087B\x177D\xEE7F\xE581ꒃ\xE885\xE187ﺉﾋꂍ", A_1));
              dreamColorNits = PanelBrightnessHelper.GetDreamColorNits();
              nullable4 = dreamColorNits;
              num2 = 11;
              continue;
            case 38:
              try
              {
label_55:
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Module.a("㹋⅍㽏♑ࡓ\x2155㕗㍙", A_1), Module.a("㽋\x2B4D㱏㝑㝓≕硗灙籛㡝\x125Fൡॣ䙥㽧ݩի⍭Ὧᱱᵳɵ\x1777\x0879㹻\x0C7D\xE97F\xE581\xEC83\xF285\xE687\xEF89ﾋﶍ", A_1)).Get().GetEnumerator();
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      if (!this.C1.HasValue)
                      {
                        num4 = 2;
                        continue;
                      }
                      goto case 3;
                    case 1:
                      try
                      {
                        int num5 = 3;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_70;
                            case 2:
                              num5 = 1;
                              continue;
                            case 4:
                              if (!enumerator.MoveNext())
                              {
                                num5 = 2;
                                continue;
                              }
                              uiPercent = (ushort) (byte) enumerator.Current[Module.a("ཋ㭍≏⁑ㅓ㡕ⱗᡙ\x2E5B㝝ݟ\x0A61ၣ\x0865൧ᥩὫ", A_1)];
                              num5 = 0;
                              continue;
                            default:
                              num5 = 4;
                              continue;
                          }
                        }
                      }
                      finally
                      {
                        int num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 0:
                              goto label_68;
                            case 2:
                              enumerator.Dispose();
                              num5 = 0;
                              continue;
                            default:
                              if (enumerator != null)
                              {
                                num5 = 2;
                                continue;
                              }
                              goto label_68;
                          }
                        }
label_68:;
                      }
label_70:
                      this.log.FormatInformationMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("ṋ\x2B4Dㅏ㙑瑓㕕ⵗ⡙\x2E5B㭝\x0E5Fᙡ䑣ѥᩧͩ୫٭ѯᱱᅳյ\x0B77婹呻\x0E7D\xE57F\xF081\xE783\xE385\xE687ﺉꖋ꺍\xF68F\xE091ﮓﮕ뢗춙\xF19B\xF79D\xED9F춡쪣쾥\xDCA7얩\xDEAB\xECAD슯\xDBB1펳\xDEB5첷풹\xD9BB춽뎿\xE2C1\xA7C3\xAAC5꧇막뿋\xF4CD\xF0CF꧑\xE4D3ꯕ\xF6D7", A_1), (object) uiPercent.ToString());
                      num4 = 0;
                      continue;
                    case 2:
                      this.C1 = new bool?(true);
                      num4 = 3;
                      continue;
                    case 3:
                      num4 = 4;
                      continue;
                    case 4:
                      goto label_49;
                    default:
                      goto label_55;
                  }
                }
              }
              catch (Exception ex)
              {
                enReturnCode = enReturnCode.e_INVALID_COMMAND;
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("ो㙍㍏㝑\x2453≕ㅗ㕙\x325B繝ཟšݣ፥ᩧᡩ५੭偯᭱ᩳ噵ॷཹ\x197B\x0C7D勵\xEB81\xEA83\xE185ꢇ\xDD89솋잍낏\xF491ﮓ\xE495뢗춙\xF19B\xF79D\xED9F춡쪣쾥\xDCA7얩\xDEAB\xECAD슯\xDBB1펳\xDEB5첷풹\xD9BB춽뎿\xF8C1\xE4C3\xE1C5돇韛뇋\xE9CD", A_1), (object) ex.Message);
                this.C1 = new bool?(false);
              }
label_49:
              num2 = 13;
              continue;
            case 40:
              num2 = eDataType != enPanelBrightnessDataType.Percent ? 9 : 31;
              continue;
            case 41:
              nullable5 = new int?((int) nullable4.GetValueOrDefault());
              break;
            case 42:
              num2 = eDataType != enPanelBrightnessDataType.Percent ? 22 : 6;
              continue;
            case 43:
              if (nullable3.HasValue)
              {
                num2 = 20;
                continue;
              }
              goto case 2;
            default:
              goto label_8;
          }
          nullable3 = nullable5;
          num2 = 43;
          continue;
label_79:
          if (num3 == 0)
          {
            this.log.InformationMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("ࡋ㱍㕏㍑㥓ᕕ㝗㙙㍛ⱝ䁟ୡᝣ䙥♧╩㡫乭ᕯᱱᕳᑵᑷό\x187B偽ꁿꊁ쎃\xE385ﲇﺉ\xE58B\xE08D\xF78F늑\xE493\xF395\xEA97蓮鍊\xF09D풟쎡쎣쎥蚧", A_1));
            num2 = 38;
          }
          else
            num2 = 37;
        }
      }
      finally
      {
        Monitor.Exit(obj);
      }
label_85:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ୋ\x2B4D\x244Fᅑ\x2153\x2455⩗㽙\x325B⩝た͡\x0A63ͥѧ⡩ṫݭᝯᩱsᡵᵷॹཻ㡽\xF27F\xED81\xE983즅\xDB87", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65䡧ᥩᡫ\x0F6Dѯݱݳ噵䕷婹ݻ乽ﵿ꺁ꒃ\xF385\xE187캉\xED8B揄\xF18F늑ꦓ뚕\xE397\xAB99\xE19B", A_1), (object) enReturnCode.ToString(), (object) uiData.ToString());
      return enReturnCode;
    }

    private ushort? ConvertNitsToPercent(ushort uiNits)
    {
      int A_1 = 4;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ᙗ㍙⡛ⵝ㑟ൡ㑣ͥᩧ३५mѯ", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡\x0A63ཥᱧᥩ八", A_1) + uiNits.ToString());
      int num1 = int.MaxValue;
      ushort? nullable = new ushort?();
      int index = 0;
      int num2 = 2;
      int num3=0;
      while (true)
      {
        switch (num2)
        {
          case 0:
            ++index;
            if (1 == 0)
              ;
            num2 = 6;
            continue;
          case 1:
            if (index < this.BrightnessNitTable.Length)
            {
              num3 = Math.Abs((int) uiNits - (int) this.BrightnessNitTable[index]);
              num2 = 5;
              continue;
            }
            num2 = 4;
            continue;
          case 2:
          case 6:
            num2 = 1;
            continue;
          case 3:
            num1 = num3;
            nullable = new ushort?(this.BrightnessPercentTable[index]);
            num2 = 0;
            continue;
          case 4:
            goto label_12;
          case 5:
            if (num3 < num1)
            {
              num2 = 3;
              continue;
            }
            goto case 0;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ᙗ㍙⡛ⵝ㑟ൡ㑣ͥᩧ३५mѯ", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ䙥ᡧཀྵṫ൭ᕯᱱs䭵", A_1) + nullable.ToString());
      return nullable;
    }

    private ushort? ConvertPercentToNits(ushort uiPercent)
    {
      int A_1 = 16;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕕ㝗㑙⩛㭝\x125Fᙡ㑣ͥᩧ३५mѯ♱᭳㡵ᅷ\x0E79ཻ", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١䑣ᅥŧṩѫ乭o\x1771ٳᕵᵷᑹ\x087B䍽", A_1) + uiPercent.ToString());
      int num1 = int.MaxValue;
      ushort? nullable = new ushort?();
      int index = 0;
      int num2 = 1;
      int num3=0;
      while (true)
      {
        switch (num2)
        {
          case 0:
            num1 = num3;
            nullable = new ushort?(this.BrightnessNitTable[index]);
            if (1 == 0)
              ;
            num2 = 6;
            continue;
          case 1:
          case 5:
            num2 = 3;
            continue;
          case 2:
            if (num3 < num1)
            {
              num2 = 0;
              continue;
            }
            goto case 6;
          case 3:
            if (index < this.BrightnessPercentTable.Length)
            {
              num3 = Math.Abs((int) uiPercent - (int) this.BrightnessPercentTable[index]);
              num2 = 2;
              continue;
            }
            num2 = 4;
            continue;
          case 4:
            goto label_12;
          case 6:
            ++index;
            num2 = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᕕ㝗㑙⩛㭝\x125Fᙡ㑣ͥᩧ३५mѯ♱᭳㡵ᅷ\x0E79ཻ", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ剱ᩳή\x0C77ॹ䅻", A_1) + nullable.ToString());
      return nullable;
    }

    private ushort? ConvertPercentToIndex(ushort uiPercent)
    {
      int A_1 = 4;
label_3:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ࡗ㽙\x2E5B㵝՟ౡၣ㉥ݧ⍩ɫ੭ᕯੱ", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ᑣͥᩧ३५mѯ佱", A_1) + uiPercent.ToString());
      int num1 = int.MaxValue;
      ushort? nullable = new ushort?();
      ushort num2 = (ushort) 0;
      int num3 = 6;
      while (true)
      {
        if (1 == 0)
          ;
        int num4=0;
        switch (num3)
        {
          case 0:
            ++num2;
            num3 = 4;
            continue;
          case 1:
            num1 = num4;
            nullable = new ushort?(num2);
            num3 = 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            if ((int) num2 < this.BrightnessPercentTable.Length)
            {
              num4 = Math.Abs((int) uiPercent - (int) this.BrightnessPercentTable[(int) num2]);
              num3 = 5;
              continue;
            }
            num3 = 2;
            continue;
          case 4:
          case 6:
            num3 = 3;
            continue;
          case 5:
            if (num4 < num1)
            {
              num3 = 1;
              continue;
            }
            goto case 0;
          default:
            goto label_3;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ࡗ㽙\x2E5B㵝՟ౡၣ㉥ݧ⍩ɫ੭ᕯੱ", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ䙥ŧѩ\x086B୭\x086F佱", A_1) + nullable.ToString());
      return nullable;
    }

    private enReturnCode GetCurrentPanelBrightnessFromBIOS(enPanelBrightnessDataType eDataType, ref ushort uiData)
    {
      int A_1 = 17;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚Ṝ⩞፠ᅢd०\x1D68㭪౬Ůᑰὲ㝴նၸ\x1C7Aᕼ\x0B7E\xEF80\xE682\xF684\xF486쾈力\xE28C\xE28E펐\xDA92\xDA94쒖", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ䕤ၦhὪլ佮", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataIn = new byte[4]
      {
        (byte) eDataType,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      dataIn[0] = (byte) 0;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 4:
          case 6:
            goto label_12;
          case 1:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetCurrentPanelBrightness, dataIn, 4U, out dataOut, enSizeOut.eSIZE_4);
            num = 2;
            continue;
          case 2:
            if (enReturnCode != enReturnCode.e_OK)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚Ṝ⩞፠ᅢd०\x1D68㭪౬Ůᑰὲ㝴նၸ\x1C7Aᕼ\x0B7E\xEF80\xE682\xF684\xF486쾈力\xE28C\xE28E펐\xDA92\xDA94쒖", A_1), Module.a("ቖ⭘⥚\x325Cⵞ䅠卢\x1D64ᱦ奨ᙪ䵬८Ͱᱲᡴ坶㭸㉺㉼Ȿꆀ풂좄캆ꦈ\xE88A\xEC8C\xE38E\xFD90뎒잔\xF296\xF898ﾚ늜궞邠쮢薤킦솨슪솬쪮醰풲킴쎶춸튺펼\xD8BE\xE1C0鏂꓄꧆곈\xA7CA迌뷎룐듒뷔ꏖ럘뻚껜곞쇠諢诤臦蛨", A_1), (object) enReturnCode);
              num = 0;
              continue;
            }
            num = 3;
            continue;
          case 3:
            if (1 == 0)
              ;
            uiData = (ushort) (((uint) dataOut[1] << 8) + (uint) dataOut[0]);
            this.log.FormatInformationMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚Ṝ⩞፠ᅢd०\x1D68㭪౬Ůᑰὲ㝴նၸ\x1C7Aᕼ\x0B7E\xEF80\xE682\xF684\xF486쾈力\xE28C\xE28E펐\xDA92\xDA94쒖", A_1), Module.a("Ֆ㱘㩚㥜罞ɠᙢᝤᕦ౨ժᥬ佮\x1370Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082ꖄ꾆\xF288뮊\xF08CꚎ놐\xF592\xE794\xF896\xF498뮚\xDF9C횞\xEEA0\xF0A2龤螦튨骪킬膮", A_1), (object) eDataType.ToString(), (object) uiData.ToString());
            num = 4;
            continue;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚Ṝ⩞፠ᅢd०\x1D68㭪౬Ůᑰὲ㝴նၸ\x1C7Aᕼ\x0B7E\xEF80\xE682\xF684\xF486쾈力\xE28C\xE28E펐\xDA92\xDA94쒖", A_1), Module.a("Ṗ㝘⡚⥜㹞འᝢ\x0C64٦\x1D68ɪɬŮ兰ᱲ\x1374坶\x2E78ᙺᑼ㵾좀첂횄쒆\xE588\xE28A\xE88C\xE18E\xE590뎒\xE794\xF296\xED98\xEE9A\xEF9C\xF19E쒠잢薤즦\xDCA8잪솬", A_1));
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚Ṝ⩞፠ᅢd०\x1D68㭪౬Ůᑰὲ㝴նၸ\x1C7Aᕼ\x0B7E\xEF80\xE682\xF684\xF486쾈力\xE28C\xE28E펐\xDA92\xDA94쒖", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ䥲啴", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public enReturnCode GetPanelBrightnessTables(out XmlDocument xdocTables)
    {
      int A_1 = 2;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋ṍㅏ㱑ㅓ㩕ᩗ⡙㕛㥝\x085Fᙡ\x0A63ͥ᭧ᥩ㡫\x0F6Dቯṱᅳյ", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocTables = (XmlDocument) null;
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = this.GetPanelBrightnessTablesEmulated(out xdocTables);
            num = 8;
            continue;
          case 1:
            num = 4;
            continue;
          case 2:
          case 8:
            num = 3;
            continue;
          case 3:
            if (1 == 0)
              ;
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_15;
          case 4:
            if (!this.K1)
            {
              enReturnCode = this.GetPanelBrightnessTablesFromBIOS(out xdocTables);
              num = 2;
              continue;
            }
            num = 0;
            continue;
          case 5:
            goto label_15;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto case 2;
          case 7:
            enReturnCode = new XmlTools().Validate(xdocTables.InnerXml, Resources.hpCASL);
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋ṍㅏ㱑ㅓ㩕ᩗ⡙㕛㥝\x085Fᙡ\x0A63ͥ᭧ᥩ㡫\x0F6Dቯṱᅳյ", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61幣䙥", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPanelBrightnessTablesEmulated(out XmlDocument xdocTables)
    {
      int A_1 = 17;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78⽺\x1C7Cᵾ\xED80\xE682\xF684슆\xE488ﺊ\xE18C\xEE8E\xE590\xF692\xF194", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocTables = new XmlDocument();
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
          case 7:
            goto label_19;
          case 1:
            try
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_16;
                  case 1:
                    File.WriteAllText(this.PanelBrightnessPowerTablesEmulationFile, Resources.GetPanelBrightnessPowerTablesOutput);
                    num2 = 3;
                    continue;
                  case 3:
                    xdocTables.Load(this.PanelBrightnessPowerTablesEmulationFile);
                    num2 = 0;
                    continue;
                  default:
                    if (!File.Exists(this.PanelBrightnessPowerTablesEmulationFile))
                    {
                      num2 = 1;
                      continue;
                    }
                    goto case 3;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78⽺\x1C7Cᵾ\xED80\xE682\xF684슆\xE488ﺊ\xE18C\xEE8E\xE590\xF692\xF194", A_1), Module.a("ቖ\x2158㡚㡜⽞ᕠ\x0A62\x0A64०䥨ݪɬ\x0E6Eᕰᩲ᭴ၶ奸Ṻၼ\x0A7E\xED80\xE282\xF184\xEE86\xE688\xE58A권\xE98E\xF890ﾒ\xF094궖릘벚\xE69C꺞\xDCA0蒢", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_16:
            num1 = 5;
            continue;
          case 2:
            num1 = 3;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 6;
              continue;
            }
            xdocTables = (XmlDocument) null;
            num1 = 0;
            continue;
          case 4:
            enReturnCode = new XmlTools().Validate(xdocTables.InnerXml, Resources.hpCASL);
            num1 = 2;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 4;
              continue;
            }
            goto case 2;
          case 6:
            XmlEdit xmlEdit = new XmlEdit(xdocTables);
            this.F1 = xmlEdit.GetUInt16s(Module.a("硖癘\x0B5A㡜ⵞɠ٢\x0B64፦\x2B68ᥪѬ\x086Eᥰݲ᭴ቶ\x0A78\x087A⥼Ṿ\xE380\xEF82\xE084ꢆ\xDF88\xEA8A\xE18C搜\xF490", A_1));
            this.G1 = xmlEdit.GetUInt16s(Module.a("硖癘ᕚ㑜\x2B5Eበ㝢Ѥզը\x0E6A䉬㥮ၰὲtቶ", A_1));
            this.H1 = new double[2];
            this.H1[0] = xmlEdit.GetDouble(Module.a("硖癘\x0B5A\x325C⡞Ѡᅢㅤ٦୨ݪ\x086C䁮㙰ቲᱴ\x1976", A_1));
            this.H1[1] = xmlEdit.GetDouble(Module.a("硖癘\x0B5A\x325C⡞Ѡᅢㅤ٦୨ݪ\x086C䁮㹰ᕲ\x1374Ѷ\x1C78ེ", A_1));
            num1 = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      if (1 == 0)
        ;
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ၖ㱘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78⽺\x1C7Cᵾ\xED80\xE682\xF684슆\xE488ﺊ\xE18C\xEE8E\xE590\xF692\xF194", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ䥲啴", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPanelBrightnessTablesFromBIOS(out XmlDocument xDocTables)
    {
      int A_1 = 5;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ొ⡌㭎Ő\x3252㭔\x3256㕘ᥚ⽜㙞٠ୢᅤ०౨ᡪṬ㭮ၰᅲᥴቶ\x0A78㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xDocTables = (XmlDocument) null;
      string xml = (string) null;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num1 = 7;
      int num2=0;
      int nTableIndex=0;
      string sTableForXML=null;
      int num3=0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            xml += sTableForXML;
            nTableIndex += (int) dataOut[nTableIndex + 1] * 2 + 2;
            ++num3;
            num1 = 4;
            continue;
          case 1:
            num2 = (int) dataOut[0];
            nTableIndex = 2;
            sTableForXML = (string) null;
            xml = Module.a("睊牌㝎㱐㽒畔\x2156㱘⥚\x2E5C㙞\x0E60ൢ塤䕦塨䕪嵬䵮兰ᙲ᭴ᑶᙸὺᑼᅾ\xE680뺂Ꞅ\xF286ﶈ\xED8Aꂌ랎뎐겒\xAB94\xAB96\xDE98ﺚ\xE99C쾞삠춢삤쮦\xEBA8\xD9AA쒬좮\xD9B0잲\xDBB4튶쪸좺\xEDBC킾뛀ꛂ럄鏆\xA8C8꧊ꇌ\xAACEꋐ鳒ꃔꏖ꧘껚\xA9DC\xFFDE駠転觤触髨훪쿬鳮鋰鯲郴髶飸裺탼韾焀⸂昄栆搈┊渌渎成缒㜔⤖┘吚栜欞儠嘢儤ᤦᔨ漪䰬嬮倰ല", A_1);
            num3 = 0;
            num1 = 5;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 10;
              continue;
            }
            goto label_25;
          case 3:
          case 8:
            num1 = 2;
            continue;
          case 4:
          case 5:
            num1 = 14;
            continue;
          case 6:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetPanelBrightnessTables, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num1 = 13;
            continue;
          case 7:
            if (wmiBiosClient != null)
            {
              if (1 == 0)
                ;
              num1 = 6;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ొ⡌㭎Ő\x3252㭔\x3256㕘ᥚ⽜㙞٠ୢᅤ०౨ᡪṬ㭮ၰᅲᥴቶ\x0A78㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("Ɋ⍌㱎═\x3252㭔⍖じ㩚⥜㙞\x0E60ൢ䕤\x0866ཨ䭪㩬ɮᡰㅲ㱴㡶⩸㡺ᅼᙾ\xE480\xED82\xF184Ꞇﮈ\xEE8A歷搜\xE390ﶒ\xF094\xF396릘\xF59A\xE89C\xF39E춠", A_1));
            num1 = 12;
            continue;
          case 9:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto case 11;
          case 10:
            goto label_14;
          case 11:
            xml += Module.a("睊扌\x0B4Eぐ❒㑔楖敘瑚ቜ⩞ᕠ።ၤ፦坨坪䉬⡮ᑰݲ╴ᙶ\x1778Ṻᅼ㵾\xF380\xEA82\xE284\xEF86ﶈ\xE58A\xE88Cﲎ\xE290쎒杖\xE096ﲘ\xE99A즜ﺞ쎠쾢삤풦\xE6A8\xDEAA\xD9AC\xDFAE쒰잲讴", A_1);
            num1 = 3;
            continue;
          case 12:
            goto label_25;
          case 13:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ొ⡌㭎Ő\x3252㭔\x3256㕘ᥚ⽜㙞٠ୢᅤ०౨ᡪṬ㭮ၰᅲᥴቶ\x0A78㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("๊㽌㵎㹐\x2152畔杖\x2158⁚浜≞䅠բᝤ\x0866Ѩ䭪⽬♮㹰\x2072啴\x2076㑸㉺嵼᱾\xE080\xEF82\xE984Ꞇ\xDB88\xEE8A\xEC8C\xEB8E뺐ꆒꖔﾖ릘\xEC9A\xF59C\xF69E춠욢薤삦첨\xDFAA\xD9AC욮\xDFB0풲閴\xE7B6\xD8B8햺\xD8BC펾菀뇂계ꃆꇈ뿊ꏌ\xAACEꋐꃒ\xF5D4뻖럘뷚닜", A_1), (object) enReturnCode);
            num1 = 8;
            continue;
          case 14:
            if (num3 >= num2)
            {
              num1 = 11;
              continue;
            }
            enReturnCode = this.ProcessPanelBrightnessTable(dataOut, nTableIndex, out sTableForXML);
            num1 = 9;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      try
      {
        xDocTables = new XmlDocument();
        xDocTables.LoadXml(xml);
      }
      catch (Exception ex)
      {
        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ొ⡌㭎Ő\x3252㭔\x3256㕘ᥚ⽜㙞٠ୢᅤ०౨ᡪṬ㭮ၰᅲᥴቶ\x0A78㵺ོၾ\xEC80솂첄좆\xDA88", A_1), ex.Message);
        xDocTables = (XmlDocument) null;
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_25:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ొ⡌㭎Ő\x3252㭔\x3256㕘ᥚ⽜㙞٠ୢᅤ०౨ᡪṬ㭮ၰᅲᥴቶ\x0A78㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64嵦䥨", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ProcessPanelBrightnessTable(byte[] byPanelBrightnessTables, int nTableIndex, out string sTableForXML)
    {
      int A_1 = 2;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡇ㡉⍋ⵍ㕏\x2151❓ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű\x2073\x1775᩷ᙹ\x197B", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ癕㥗\x2E59籛㝝\x0E5F١ţṥ䡧", A_1) + nTableIndex.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      sTableForXML = (string) null;
      int length = 0;
      int index = 0;
      int num1 = 24;
      ushort num2=0;
      double num3=0;
      byte num4=0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            if (1 == 0)
              ;
            num1 = 33;
            continue;
          case 1:
            this.H1[0] = num3;
            sTableForXML += Module.a("瑇\x0D49ⵋ❍㹏汑", A_1);
            sTableForXML += num3.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
            sTableForXML += Module.a("瑇敉ୋ⽍㥏㱑橓", A_1);
            double num5 = (double) BitConverter.ToUInt16(byPanelBrightnessTables, nTableIndex + 4) / 10.0;
            this.H1[1] = num5;
            sTableForXML += Module.a("瑇Չ⩋⡍⍏㝑⁓桕", A_1);
            sTableForXML += num5.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
            sTableForXML += Module.a("瑇敉͋⡍㙏\x2151ㅓ≕晗", A_1);
            num1 = 28;
            continue;
          case 2:
            goto label_48;
          case 3:
            num3 = -num3;
            num1 = 1;
            continue;
          case 4:
            sTableForXML += Module.a("瑇敉ɋ❍\x244F\x2151S㝕㩗㙙㥛恝", A_1);
            num1 = 6;
            continue;
          case 5:
            if (index < length)
            {
              ushort num6 = BitConverter.ToUInt16(byPanelBrightnessTables, nTableIndex + 2 + index * 2);
              this.F1[index] = num6;
              sTableForXML += Module.a("瑇᱉ⵋ≍╏㝑橓", A_1);
              sTableForXML += (string) (object) num6;
              sTableForXML += Module.a("瑇敉ᩋ⽍㱏❑ㅓ桕", A_1);
              ++index;
              num1 = 15;
              continue;
            }
            num1 = 10;
            continue;
          case 6:
          case 12:
          case 14:
          case 29:
            num1 = 18;
            continue;
          case 7:
            sTableForXML = (string) null;
            num1 = 2;
            continue;
          case 8:
            num4 = byPanelBrightnessTables[nTableIndex];
            num1 = 9;
            continue;
          case 9:
            switch (num4)
            {
              case (byte) 0:
                this.F1 = new ushort[length];
                sTableForXML = Module.a("瑇ᩉ⥋㱍㍏㝑㩓≕ᩗ⡙㕛㥝\x085Fᙡ\x0A63ͥ᭧ᥩ㡫\x0F6Dቯṱᅳ䡵", A_1);
                index = 0;
                num1 = 27;
                continue;
              case (byte) 1:
                this.G1 = new ushort[length];
                sTableForXML = Module.a("瑇щ╋㩍⍏ّ㕓㑕㑗㽙扛", A_1);
                index = 0;
                num1 = 17;
                continue;
              case (byte) 2:
                sTableForXML = Module.a("瑇ᩉ⍋㥍㕏⁑S㝕㩗㙙㥛恝", A_1);
                num1 = 34;
                continue;
              default:
                num1 = 22;
                continue;
            }
          case 10:
            sTableForXML += Module.a("瑇敉\x1C4B\x2B4D≏ㅑㅓ㡕ⱗᡙ\x2E5B㝝ݟ\x0A61ၣ\x0865൧ᥩὫ㩭ᅯၱᡳ\x1375䙷", A_1);
            num1 = 14;
            continue;
          case 11:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 19;
              continue;
            }
            goto case 33;
          case 13:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 29;
            continue;
          case 15:
          case 27:
            num1 = 5;
            continue;
          case 16:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 8;
              continue;
            }
            goto case 6;
          case 17:
          case 26:
            num1 = 32;
            continue;
          case 18:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num1 = 7;
              continue;
            }
            goto label_48;
          case 19:
            length = (int) byPanelBrightnessTables[nTableIndex + 1];
            num1 = 30;
            continue;
          case 20:
          case 28:
            sTableForXML += Module.a("瑇敉\x1C4B⅍❏㝑♓ɕ㥗㡙せ㭝幟", A_1);
            num1 = 12;
            continue;
          case 21:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 23;
            continue;
          case 22:
            num1 = 13;
            continue;
          case 23:
            num1 = 11;
            continue;
          case 24:
            if ((int) byPanelBrightnessTables[nTableIndex] > 2)
            {
              num1 = 21;
              continue;
            }
            goto case 23;
          case 25:
            if (((int) num2 & 32768) != 0)
            {
              num1 = 3;
              continue;
            }
            goto case 1;
          case 30:
            if (nTableIndex + 1 + length * 2 > (int) sbyte.MaxValue)
            {
              num1 = 0;
              continue;
            }
            goto case 33;
          case 31:
            this.H1 = new double[length];
            num2 = BitConverter.ToUInt16(byPanelBrightnessTables, nTableIndex + 2);
            num3 = (double) ((int) num2 & (int) short.MaxValue) / 10000.0;
            num1 = 25;
            continue;
          case 32:
            if (index >= length)
            {
              num1 = 4;
              continue;
            }
            ushort num7 = BitConverter.ToUInt16(byPanelBrightnessTables, nTableIndex + 2 + index * 2);
            this.G1[index] = num7;
            sTableForXML += Module.a("瑇᱉ⵋ≍╏㝑橓", A_1);
            sTableForXML += (string) (object) num7;
            sTableForXML += Module.a("瑇敉ᩋ⽍㱏❑ㅓ桕", A_1);
            ++index;
            num1 = 26;
            continue;
          case 33:
            num1 = 16;
            continue;
          case 34:
            if (length != 2)
            {
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
              num1 = 20;
              continue;
            }
            num1 = 31;
            continue;
          default:
            goto label_2;
        }
      }
label_48:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡇ㡉⍋ⵍ㕏\x2151❓ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű\x2073\x1775᩷ᙹ\x197B", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗", A_1));
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 17;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ṗ㝘\x325A⥜ཞ፠ౢᕤɦ᭨Ὢᑬ⡮ᑰݲ㥴Ṷ\x0A78ེ", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ", A_1));
      this.I1 = this.Initialize();
      OperatingSystem osVersion = Environment.OSVersion;
      int num1 = 7;
      while (true)
      {
        bool? nullable1=false;
        bool flag=false;
        bool? nullable2=false;
        int num2;
        switch (num1)
        {
          case 0:
            if (flag)
            {
              num1 = 4;
              continue;
            }
            goto case 29;
          case 1:
            nullable2 = PanelBrightnessHelper.IsDreamColorEnabled();
            num1 = 21;
            continue;
          case 2:
            if (!this.BPanelBrightnessTablesSupported)
            {
              num1 = 25;
              continue;
            }
            goto case 20;
          case 3:
            num2 = 0;
            break;
          case 4:
            num1 = 18;
            continue;
          case 5:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴㹶\x1778ὺ\x187Cݾ", A_1), typeof (ushort), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 15;
            continue;
          case 6:
            if (this.BPanelBrightnessSupported)
            {
              num1 = 31;
              continue;
            }
            goto case 9;
          case 7:
            num1 = osVersion.Platform != PlatformID.Win32NT ? 3 : 17;
            continue;
          case 8:
            if (this.BPanelBrightnessTablesSupported)
            {
              num1 = 5;
              continue;
            }
            goto case 15;
          case 9:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴⍶\x1878\x197Aᅼ\x1A7E\xF280궂횄\xF286麗ﮊ\xE28Cﶎ\xE590\xF692\xF194", A_1), typeof (bool), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 28;
            continue;
          case 10:
            if (flag)
            {
              num1 = 35;
              continue;
            }
            goto case 5;
          case 11:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴㥶ၸེ\x0E7C", A_1), typeof (ushort), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 12;
            continue;
          case 12:
            num1 = 10;
            continue;
          case 13:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴\x2776\x2E78㙺", A_1), typeof (ushort), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 9;
            continue;
          case 14:
            num1 = 2;
            continue;
          case 15:
            num1 = 23;
            continue;
          case 16:
            num1 = 24;
            continue;
          case 17:
            num1 = 26;
            continue;
          case 18:
            if (!this.BPanelBrightnessTablesSupported)
            {
              num1 = 14;
              continue;
            }
            goto case 29;
          case 19:
            if (!nullable1.Value)
            {
              num1 = 29;
              continue;
            }
            goto case 20;
          case 20:
            num1 = 34;
            continue;
          case 21:
            if (nullable2.Value)
            {
              num1 = 11;
              continue;
            }
            goto case 12;
          case 22:
            if (!this.BPanelBrightnessTablesSupported)
            {
              num1 = 1;
              continue;
            }
            goto case 12;
          case 23:
            if (flag)
            {
              num1 = 33;
              continue;
            }
            goto case 13;
          case 24:
            if (!this.BPanelBrightnessTablesSupported)
            {
              num1 = 36;
              continue;
            }
            goto case 11;
          case 25:
            nullable1 = PanelBrightnessHelper.IsDreamColorEnabled();
            num1 = 19;
            continue;
          case 26:
            num2 = osVersion.Version.Major >= 6 ? 1 : 0;
            break;
          case 27:
            goto label_55;
          case 28:
            if (this.BPanelBrightnessTablesSupported)
            {
              num1 = 30;
              continue;
            }
            goto label_55;
          case 29:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴\x2776\x1C78ॺṼ\x1A7E\xEF80\xF782", A_1), typeof (ushort), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 20;
            continue;
          case 30:
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴⍶\x1878\x197Aᅼ\x1A7E\xF280궂쒄\xEB86\xE588", A_1), typeof (XmlDocument), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴⍶\x1878\x197Aᅼ\x1A7E\xF280궂햄\xE286ﮈ\xE88A\xE88C\xE18E\xE590", A_1), typeof (ushort[]), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴⍶\x1878\x197Aᅼ\x1A7E\xF280궂쮄\xEE86ﶈ\xF88A", A_1), typeof (ushort[]), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴⍶\x1878\x197Aᅼ\x1A7E\xF280궂햄\xE886ﺈ\xEE8Aﾌ\xDB8E\xF090\xF192璉\xF296\xEA98", A_1), typeof (double[]), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
            num1 = 27;
            continue;
          case 31:
            num1 = 0;
            continue;
          case 32:
            if (this.K1)
            {
              num1 = 13;
              continue;
            }
            goto case 9;
          case 33:
            num1 = 32;
            continue;
          case 34:
            if (1 == 0)
              ;
            if (flag)
            {
              num1 = 16;
              continue;
            }
            goto case 11;
          case 35:
            num1 = 8;
            continue;
          case 36:
            num1 = 22;
            continue;
          default:
            goto label_2;
        }
        flag = num2 != 0;
        this.propertyGetList.Add(new Command.Property(Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr孴\x2476\x0C78\x0B7Aർၾ\xF380\xF782\xE084\xE386", A_1), typeof (bool), Module.a("ݖ㡘㕚㡜㍞⍠ᅢ\x0C64fŨὪͬ੮ɰr㉴ቶ\x0D78", A_1), false));
        num1 = 6;
      }
label_55:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ṗ㝘\x325A⥜ཞ፠ౢᕤɦ᭨Ὢᑬ⡮ᑰݲ㥴Ṷ\x0A78ེ", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ", A_1));
    }

    private enReturnCode PanelBrightnessSet(string sCommandName, object dataIn)
    {
      int A_1 = 16;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű❳\x1375\x0C77", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١䑣ᅥŧṩѫ乭", A_1) + sCommandName);
      enReturnCode enReturnCode = this.I1;
      int num = 12;
      string str=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 7;
            continue;
          case 1:
          case 7:
          case 10:
          case 14:
          case 15:
            goto label_27;
          case 2:
            if ((str = sCommandName) != null)
            {
              num = 16;
              continue;
            }
            goto case 0;
          case 3:
            num = 0;
            continue;
          case 4:
            if (str == Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű婳㽵ᙷṹ\x197Bٽ", A_1))
            {
              enReturnCode = this.SetCurrentPanelBrightness(enPanelBrightnessDataType.Index, (ushort) dataIn);
              num = 1;
              continue;
            }
            num = 8;
            continue;
          case 5:
            num = 2;
            continue;
          case 6:
            if (str == Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű婳♵⽷㝹", A_1))
            {
              enReturnCode = this.SetCurrentPanelBrightness(enPanelBrightnessDataType.PWM, (ushort) dataIn);
              num = 15;
              continue;
            }
            num = 3;
            continue;
          case 8:
            num = 13;
            continue;
          case 9:
            num = 6;
            continue;
          case 11:
            num = 4;
            continue;
          case 12:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 5;
              continue;
            }
            goto label_27;
          case 13:
            if (str == Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű婳㡵ᅷ\x0E79ཻ", A_1))
            {
              enReturnCode = this.SetCurrentPanelBrightness(enPanelBrightnessDataType.Nits, (ushort) dataIn);
              num = 14;
              continue;
            }
            num = 9;
            continue;
          case 16:
            num = 17;
            continue;
          case 17:
            if (!(str == Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű婳♵ᵷ\x0879ύ\x1B7D\xEE7F\xF681", A_1)))
            {
              num = 11;
              continue;
            }
            enReturnCode = this.SetCurrentPanelBrightness(enPanelBrightnessDataType.Percent, (ushort) dataIn);
            num = 10;
            continue;
          default:
            goto label_2;
        }
      }
label_27:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ٕ㥗㑙㥛\x325D≟ၡൣťgṩɫ୭ͯű❳\x1375\x0C77", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧३ͫͭᵯ\x1371ᩳት塷Ź䱻ͽꁿ\xF581\xED83\xF285\xE087ꪉ\xF78B뾍\xED8F", A_1), (object) sCommandName, (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetCurrentPanelBrightness(enPanelBrightnessDataType eDataType, ushort uiData)
    {
      int A_1 = 8;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1D4D㕏♑ᝓ⍕⩗⡙㥛そᑟ㉡գ\x0865൧٩\x2E6Bᱭ\x196Fᕱᱳɵᙷόཻൽ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙籛⥝य़ᙡౣ䙥", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num1 = 7;
      while (true)
      {
        OperatingSystem osVersion=null;
        bool flag=false;
        int num2;
        switch (num1)
        {
          case 0:
            num2 = osVersion.Version.Major >= 6 ? 1 : 0;
            break;
          case 1:
          case 4:
          case 8:
            goto label_17;
          case 2:
            enReturnCode = this.SetCurrentPanelBrightnessInOS(eDataType, uiData);
            num1 = 8;
            continue;
          case 3:
            num1 = 0;
            continue;
          case 5:
            if (!flag)
            {
              enReturnCode = this.SetCurrentPanelBrightnessInBIOS(eDataType, uiData);
              num1 = 1;
              continue;
            }
            num1 = 2;
            continue;
          case 6:
            enReturnCode = this.A(eDataType, uiData);
            if (1 == 0)
              ;
            num1 = 4;
            continue;
          case 7:
            if (this.K1)
            {
              num1 = 6;
              continue;
            }
            osVersion = Environment.OSVersion;
            num1 = 9;
            continue;
          case 9:
            num1 = osVersion.Platform != PlatformID.Win32NT ? 10 : 3;
            continue;
          case 10:
            num2 = 0;
            break;
          default:
            goto label_2;
        }
        flag = num2 != 0;
        num1 = 5;
      }
label_17:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1D4D㕏♑ᝓ⍕⩗⡙㥛そᑟ㉡գ\x0865൧٩\x2E6Bᱭ\x196Fᕱᱳɵᙷόཻൽ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg䩩ᝫ幭൯", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode A(enPanelBrightnessDataType A_0, ushort A_1)
    {
      int A_1_1 = 3;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x0C4E\x2450\x2152❔\x3256㝘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78㹺ၼ\x0A7E\xED80\xE282\xF184\xEE86\xE688\xE58A", A_1_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 20;
      while (true)
      {
        ushort num2=0;
        switch (num1)
        {
          case 0:
            num1 = 31;
            continue;
          case 1:
            num2 = (ushort) 0;
            num1 = 11;
            continue;
          case 2:
          case 4:
          case 5:
          case 8:
          case 9:
          case 23:
          case 30:
          case 34:
            num1 = 16;
            continue;
          case 3:
            num1 = A_0 != enPanelBrightnessDataType.Nits ? 33 : 25;
            continue;
          case 6:
            if ((int) A_1 <= (int) byte.MaxValue)
            {
              num1 = 10;
              continue;
            }
            break;
          case 7:
            num1 = 35;
            continue;
          case 10:
            num2 = (ushort) ((int) A_1 * 100 / (int) byte.MaxValue);
            num1 = 4;
            continue;
          case 11:
            num1 = A_0 != enPanelBrightnessDataType.Percent ? 3 : 12;
            continue;
          case 12:
            num1 = 18;
            continue;
          case 13:
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            xmlEdit.SetUInt32(Module.a("晈摊Ɍ㩎═⍒⁔⍖癘\x1F5A㱜\x2B5E`䱢♤ቦ᭨ᥪ\x086CŮհㅲݴṶṸ\x137Aॼᅾ\xE480\xF082\xF684힆\xEC88力\xEE8C\xEA8Eﾐ\xE792", A_1_1), (uint) num2);
            xmlEdit.XmlDoc.Save(this.PanelBrightnessEmulationFile);
            num1 = 22;
            continue;
          case 14:
            num2 = A_1;
            num1 = 23;
            continue;
          case 15:
            num1 = 6;
            continue;
          case 16:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 13;
              continue;
            }
            goto label_53;
          case 17:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            goto label_53;
          case 18:
            if ((int) A_1 >= 0)
            {
              num1 = 0;
              continue;
            }
            goto label_22;
          case 19:
            if (A_0 == enPanelBrightnessDataType.PWM)
            {
              num1 = 32;
              continue;
            }
            goto case 2;
          case 20:
            try
            {
              int num3 = 3;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_8;
                  case 1:
                    File.WriteAllText(this.PanelBrightnessEmulationFile, Resources.PanelBrightnessEmulation);
                    num3 = 2;
                    continue;
                  case 2:
                    xmlDoc.Load(this.PanelBrightnessEmulationFile);
                    num3 = 0;
                    continue;
                  default:
                    if (!File.Exists(this.PanelBrightnessEmulationFile))
                    {
                      num3 = 1;
                      continue;
                    }
                    goto case 2;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x0C4E\x2450\x2152❔\x3256㝘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78㹺ၼ\x0A7E\xED80\xE282\xF184\xEE86\xE688\xE58A", A_1_1), Module.a("ై㍊\x2E4C⩎\x2150❒㱔㡖㝘筚ㅜぞ`ݢ\x0C64०\x0E68䭪\x086CɮѰὲᑴͶၸᑺ\x137C彾\xE780\xEA82\xE984\xE286뎈\xAB8Aꪌ\xF48Eꂐ\xEE92는", A_1_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_8:
            num1 = 29;
            continue;
          case 21:
            num2 = this.F1[(int) A_1];
            num1 = 5;
            continue;
          case 22:
            goto label_53;
          case 24:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 17;
            continue;
          case 25:
            num1 = 26;
            continue;
          case 26:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num1 = 8;
              continue;
            }
            num1 = 27;
            continue;
          case 27:
            num2 = this.ConvertNitsToPercent(A_1).Value;
            num1 = 30;
            continue;
          case 28:
            if ((int) A_1 >= 0)
            {
              if (1 == 0)
                ;
              num1 = 15;
              continue;
            }
            break;
          case 29:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 24;
              continue;
            }
            goto label_53;
          case 31:
            if ((int) A_1 <= 100)
            {
              num1 = 14;
              continue;
            }
            goto label_22;
          case 32:
            num1 = 28;
            continue;
          case 33:
            num1 = A_0 != enPanelBrightnessDataType.Index ? 19 : 7;
            continue;
          case 35:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num1 = 2;
              continue;
            }
            num1 = 21;
            continue;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num1 = 9;
        continue;
label_22:
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num1 = 34;
      }
label_53:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x0C4E\x2450\x2152❔\x3256㝘⽚\x0D5C㹞འ٢।╦᭨ɪ੬ݮհᵲၴѶ\x0A78㹺ၼ\x0A7E\xED80\xE282\xF184\xEE86\xE688\xE58A", A_1_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetCurrentPanelBrightnessInOS(enPanelBrightnessDataType eDataType, ushort uiData)
    {
      int A_1 = 13;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Rご⍖ᩘ\x2E5A⽜ⵞѠൢᅤ㝦\x0868ժ\x086Cͮ㍰Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082첄\xE986욈\xD88A", A_1), Module.a("R\x2154㙖⭘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte num1 = (byte) 0;
      enPanelBrightnessDataType brightnessDataType = eDataType;
      int num2 = 13;
      object obj=null;
      while (true)
      {
        int num3=0;
        int num4;
        switch (num2)
        {
          case 0:
            num2 = 19;
            continue;
          case 1:
          case 2:
          case 5:
          case 8:
          case 14:
          case 16:
          case 20:
            num2 = 24;
            continue;
          case 3:
            num3 = (int) (ushort) (this.BrightnessPercentTable.Length - 1);
            goto label_60;
          case 4:
            num4 = (int) (byte) uiData;
            break;
          case 6:
            num2 = (int) uiData < this.BrightnessPercentTable.Length ? 10 : 11;
            continue;
          case 7:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num2 = 5;
              continue;
            }
            num2 = 12;
            continue;
          case 9:
            goto label_15;
          case 10:
            num3 = (int) uiData;
            goto label_60;
          case 11:
            num2 = 3;
            continue;
          case 12:
            num1 = (byte) this.ConvertNitsToPercent(uiData).Value;
            num2 = 2;
            continue;
          case 13:
            switch (brightnessDataType)
            {
              case enPanelBrightnessDataType.Percent:
                num2 = 21;
                continue;
              case enPanelBrightnessDataType.Index:
                num2 = 18;
                continue;
              case enPanelBrightnessDataType.Nits:
                num2 = 7;
                continue;
              case enPanelBrightnessDataType.PWM:
                enReturnCode = enReturnCode.e_INVALID_COMMAND;
                num2 = 16;
                continue;
              default:
                num2 = 22;
                continue;
            }
          case 15:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num2 = 1;
            continue;
          case 17:
            Monitor.Enter(obj = this.B1);
            num2 = 9;
            continue;
          case 18:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num2 = 8;
              continue;
            }
            num2 = 23;
            continue;
          case 19:
            num4 = 100;
            break;
          case 21:
            num2 = (int) uiData <= 100 ? 4 : 0;
            continue;
          case 22:
            num2 = 15;
            continue;
          case 23:
            num2 = 6;
            continue;
          case 24:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num2 = 17;
              continue;
            }
            goto label_64;
          default:
            goto label_2;
        }
        num1 = (byte) num4;
        num2 = 20;
        continue;
label_60:
        uiData = (ushort) num3;
        num1 = (byte) this.BrightnessPercentTable[(int) uiData];
        if (1 == 0)
          ;
        num2 = 14;
      }
label_15:
      try
      {
label_17:
        ManagementObjectSearcher managementObjectSearcher = (ManagementObjectSearcher) null;
        ManagementObjectCollection objectCollection = (ManagementObjectCollection) null;
        int num3 = 4;
        while (true)
        {
          switch (num3)
          {
            case 0:
              try
              {
                objectCollection = managementObjectSearcher.Get();
                break;
              }
              catch (Exception ex)
              {
                enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("Rご⍖ᩘ\x2E5A⽜ⵞѠൢᅤ㝦\x0868ժ\x086Cͮ㍰Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082첄\xE986욈\xD88A", A_1), Module.a("ᙒⵔ㑖㱘\x2B5A⥜㙞\x0E60ൢ䕤\x0866੨\x086AᡬᵮͰᙲᅴ坶ၸᕺ嵼\x0B7E\xE980\xE682ꖄ\xE686ﶈﾊ\xE88C\xE28E\xE190\xE792떔\xE396\xF698뮚\xEF9C爵햠톢첤슦\xDFA8캪趬삮펰\xD9B2킴풶춸좺鶼\xD9BE돀곂꣄\xE7C6뫈껊곌뷎닐믒냔ꗖ\xE3D8ﯚ", A_1) + ex.Message);
                objectCollection = (ManagementObjectCollection) null;
                break;
              }
            case 1:
              goto label_64;
            case 2:
              if (objectCollection != null)
              {
                num3 = 5;
                continue;
              }
              goto label_43;
            case 3:
              if (managementObjectSearcher != null)
              {
                num3 = 0;
                continue;
              }
              break;
            case 4:
              try
              {
                managementObjectSearcher = new ManagementObjectSearcher(Module.a("\x2152㩔㡖ⵘݚ⩜\x325E\x0860", A_1), Module.a("⁒ご㭖㱘㡚⥜罞䭠䍢ͤᕦ٨٪䵬㡮ᱰᩲ㡴ᡶ\x1778ቺॼၾ\xF380솂\xF784\xEE86\xEE88\xE38A歷\xE18E\xF490\xE092\xE694\xDA96ﲘ\xEF9A\xF59C\xF09E얠킢", A_1));
              }
              catch (Exception ex)
              {
                enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("Rご⍖ᩘ\x2E5A⽜ⵞѠൢᅤ㝦\x0868ժ\x086Cͮ㍰Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082첄\xE986욈\xD88A", A_1), Module.a("ᙒⵔ㑖㱘\x2B5A⥜㙞\x0E60ൢ䕤\x0866੨\x086AᡬᵮͰᙲᅴ坶ၸᕺ嵼\x0B7E\xE980\xE682ꖄ\xE686ﶈﾊ\xE88C\xE28E\xE190\xE792떔\xE396\xF698뮚\xF49C\xF19E튠힢쒤즦\xDDA8슪첬\xDBAE풰鎲\xE2B4襁\xF0B8鮺캼\xDABEꃀ뇂ꛄ꿆곈맊\xF7CC\xEFCE", A_1) + ex.Message);
                managementObjectSearcher = (ManagementObjectSearcher) null;
              }
              num3 = 3;
              continue;
            case 5:
              try
              {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = objectCollection.GetEnumerator();
                try
                {
                  int num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        if (enumerator.MoveNext())
                        {
                          ((ManagementObject) enumerator.Current).InvokeMethod(Module.a("ђ㡔㹖\x0A58㹚⥜\x1D5E፠\x0A62ɤས\x1D68ժ\x086Cᱮɰ", A_1), new object[2]
                          {
                            (object) 0,
                            (object) num1
                          });
                          num4 = 2;
                          continue;
                        }
                        num4 = 3;
                        continue;
                      case 2:
                      case 3:
                        num4 = 4;
                        continue;
                      case 4:
                        goto label_43;
                      default:
                        num4 = 1;
                        continue;
                    }
                  }
                }
                finally
                {
                  int num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_41;
                      case 2:
                        enumerator.Dispose();
                        num4 = 1;
                        continue;
                      default:
                        if (enumerator != null)
                        {
                          num4 = 2;
                          continue;
                        }
                        goto label_41;
                    }
                  }
label_41:;
                }
              }
              catch (Exception ex)
              {
                enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("Rご⍖ᩘ\x2E5A⽜ⵞѠൢᅤ㝦\x0868ժ\x086Cͮ㍰Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082첄\xE986욈\xD88A", A_1), Module.a("ᙒⵔ㑖㱘\x2B5A⥜㙞\x0E60ൢ䕤\x0866੨\x086AᡬᵮͰᙲᅴ坶ၸᕺ\x0B7Cၾ\xEA80\xEA82\xEB84\xE086ꦈ\xDC8A\xE08C\xE68E슐\xF692\xE194햖\xEB98\xF29A煮\xF79E햠춢삤풦\xDAA8醪趬", A_1) + ex.Message);
                goto label_43;
              }
            default:
              goto label_17;
          }
          num3 = 2;
          continue;
label_43:
          num3 = 1;
        }
      }
      finally
      {
        Monitor.Exit(obj);
      }
label_64:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Rご⍖ᩘ\x2E5A⽜ⵞѠൢᅤ㝦\x0868ժ\x086Cͮ㍰Ųᱴၶᅸེ\x137C\x1A7E\xF280\xF082첄\xE986욈\xD88A", A_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetCurrentPanelBrightnessInBIOS(enPanelBrightnessDataType eDataType, ushort uiData)
    {
      int A_1 = 4;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᥉⥋㩍ፏ❑♓\x2455㵗㑙⡛\x0E5Dşౡţ\x0A65⩧ᡩի७ᡯٱᩳ\x1375\x0B77ॹ㕻ၽ쉿쮁쮃햅", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡", A_1) + eDataType.ToString());
      enReturnCode enReturnCode = enReturnCode.e_OK;
      ushort? nullable1 = new ushort?();
      enPanelBrightnessDataType brightnessDataType = eDataType;
      int num = 16;
      while (true)
      {
        int? nullable2=0;
        int? nullable3=0;
        int? nullable4=0;
        ushort? nullable5=0;
        int? nullable6=0;
        int? nullable7=0;
        int? nullable8=0;
        int? nullable9=0;
        ushort? nullable10=0;
        int? nullable11=0;
        byte[] dataIn=null;
        byte[] dataOut=null;
        WmiBIOSClient wmiBiosClient=null;
        ushort? nullable12=0;
        ushort? nullable13=0;
        int? nullable14=0;
        int? nullable15=0;
        int? nullable16=0;
        int? nullable17=0;
        switch (num)
        {
          case 0:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetCurrentPanelBrightness, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
            num = 19;
            continue;
          case 1:
            uiData = (ushort) (this.BrightnessPercentTable.Length - 1);
            num = 54;
            continue;
          case 2:
            if (this.BPanelBrightnessTablesSupported)
            {
              num = 23;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num = 39;
            continue;
          case 3:
            nullable14 = new int?((int) nullable10.GetValueOrDefault());
            goto label_37;
          case 4:
            if (nullable9.HasValue)
            {
              num = 36;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 43;
            continue;
          case 5:
          case 13:
          case 22:
          case 29:
          case 38:
          case 39:
          case 43:
          case 44:
          case 45:
          case 46:
          case 52:
          case 53:
            num = 8;
            continue;
          case 6:
            num = nullable13.HasValue ? 7 : 51;
            continue;
          case 7:
            nullable15 = new int?((int) nullable13.GetValueOrDefault());
            break;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 17;
              continue;
            }
            goto label_77;
          case 9:
            num = nullable12.HasValue ? 12 : 42;
            continue;
          case 10:
            nullable2 = new int?();
            num = 25;
            continue;
          case 11:
            nullable14 = nullable4;
            goto label_37;
          case 12:
            nullable16 = new int?((int) nullable12.GetValueOrDefault());
            goto label_50;
          case 14:
            nullable1 = this.ConvertPercentToIndex((ushort) ((int) uiData / (int) byte.MaxValue * 100));
            nullable12 = nullable1;
            num = 9;
            continue;
          case 15:
            if ((int) uiData >= (int) (ushort) this.BrightnessPercentTable.Length)
            {
              num = 1;
              continue;
            }
            goto case 54;
          case 16:
            switch (brightnessDataType)
            {
              case enPanelBrightnessDataType.Percent:
                num = 49;
                continue;
              case enPanelBrightnessDataType.Index:
                num = 50;
                continue;
              case enPanelBrightnessDataType.Nits:
                num = 2;
                continue;
              case enPanelBrightnessDataType.PWM:
                num = 27;
                continue;
              default:
                num = 41;
                continue;
            }
          case 17:
            dataIn = new byte[4]
            {
              (byte) eDataType,
              (byte) ((uint) uiData & (uint) byte.MaxValue),
              (byte) (((int) uiData & 65280) >> 8),
              (byte) 0
            };
            dataOut = (byte[]) null;
            wmiBiosClient = new WmiBIOSClient();
            num = 31;
            continue;
          case 18:
            if (nullable11.HasValue)
            {
              num = 56;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 29;
            continue;
          case 19:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 30;
              continue;
            }
            goto label_77;
          case 20:
            num = nullable10.HasValue ? 3 : 55;
            continue;
          case 21:
            nullable1 = this.ConvertPercentToIndex(nullable1.Value);
            nullable10 = nullable1;
            num = 20;
            continue;
          case 23:
            nullable1 = this.ConvertNitsToPercent(uiData);
            nullable5 = nullable1;
            num = 47;
            continue;
          case 24:
            num = 15;
            continue;
          case 25:
            nullable17 = nullable2;
            goto label_33;
          case 26:
            if (nullable8.HasValue)
            {
              num = 21;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 45;
            continue;
          case 27:
            if (this.BPanelBrightnessTablesSupported)
            {
              if (1 == 0)
                ;
              num = 14;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            num = 38;
            continue;
          case 28:
            nullable16 = nullable3;
            goto label_50;
          case 30:
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("᥉⥋㩍ፏ❑♓\x2455㵗㑙⡛\x0E5Dşౡţ\x0A65⩧ᡩի७ᡯٱᩳ\x1375\x0B77ॹ㕻ၽ쉿쮁쮃햅", A_1), Module.a("ཉ㹋㱍㽏⁑瑓晕⁗\x2159汛⍝䁟ѡᙣ॥է䩩\x2E6B❭㽯ⅱ味ⅵ㕷㍹屻ᵽ\xE17F\xEE81\xE883ꚅ\xDF87\xF889\xE58B揄\xF58F붑ꚓ\xA795\xF097몙\xEB9B\xF69D즟캡솣蚥\xDBA7쾩\xD8AB\xDAAD\xD9AF\xDCB1펳隵좷\xDBB9튻\xDBBD겿\xE2C1ꛃ듅ꇇ귉\xA4CB뫍뻏럑\xA7D3ꗕ", A_1), (object) enReturnCode);
            num = 37;
            continue;
          case 31:
            if (wmiBiosClient == null)
            {
              enReturnCode = enReturnCode.e_NULL_VALUE;
              this.log.ErrorMessage(this.GetType().ToString(), Module.a("᥉⥋㩍ፏ❑♓\x2455㵗㑙⡛\x0E5Dşౡţ\x0A65⩧ᡩի७ᡯٱᩳ\x1375\x0B77ॹ㕻ၽ쉿쮁쮃햅", A_1), Module.a("͉≋㵍\x244F㍑㩓≕ㅗ㭙⡛㝝ཟౡ䑣॥\x0E67䩩㭫ͭ\x196Fぱ㵳㥵\x2B77㥹ၻ\x177D\xE57F\xEC81\xF083ꚅ慎\xEF89\xF88Bﮍ\xE28Fﲑ\xF193\xF295뢗\xF499\xE99B\xF29D첟", A_1));
              num = 48;
              continue;
            }
            num = 0;
            continue;
          case 32:
            nullable1 = this.ConvertPercentToIndex(uiData);
            nullable13 = nullable1;
            num = 6;
            continue;
          case 33:
            nullable17 = new int?((int) nullable5.GetValueOrDefault());
            goto label_33;
          case 34:
            uiData = nullable1.Value;
            eDataType = enPanelBrightnessDataType.Index;
            enReturnCode = enReturnCode.e_OK;
            num = 44;
            continue;
          case 35:
            nullable15 = nullable6;
            break;
          case 36:
            uiData = nullable1.Value;
            eDataType = enPanelBrightnessDataType.Index;
            enReturnCode = enReturnCode.e_OK;
            num = 22;
            continue;
          case 37:
          case 48:
            goto label_77;
          case 40:
            if (nullable7.HasValue)
            {
              num = 34;
              continue;
            }
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 53;
            continue;
          case 41:
            num = 46;
            continue;
          case 42:
            nullable3 = new int?();
            num = 28;
            continue;
          case 47:
            num = nullable5.HasValue ? 33 : 10;
            continue;
          case 49:
            if (!this.BPanelBrightnessTablesSupported)
            {
              enReturnCode = enReturnCode.e_INVALID_COMMAND;
              num = 5;
              continue;
            }
            num = 32;
            continue;
          case 50:
            if (this.BPanelBrightnessTablesSupported)
            {
              num = 24;
              continue;
            }
            goto case 5;
          case 51:
            nullable6 = new int?();
            num = 35;
            continue;
          case 54:
            enReturnCode = enReturnCode.e_OK;
            num = 52;
            continue;
          case 55:
            nullable4 = new int?();
            num = 11;
            continue;
          case 56:
            uiData = nullable1.Value;
            eDataType = enPanelBrightnessDataType.Index;
            enReturnCode = enReturnCode.e_OK;
            num = 13;
            continue;
          default:
            goto label_2;
        }
        nullable7 = nullable15;
        num = 40;
        continue;
label_33:
        nullable8 = nullable17;
        num = 26;
        continue;
label_37:
        nullable9 = nullable14;
        num = 4;
        continue;
label_50:
        nullable11 = nullable16;
        num = 18;
      }
label_77:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᥉⥋㩍ፏ❑♓\x2455㵗㑙⡛\x0E5Dşౡţ\x0A65⩧ᡩի७ᡯٱᩳ\x1375\x0B77ॹ㕻ၽ쉿쮁쮃햅", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ䙥፧婩ᅫ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 1;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x1F4E⍐㱒╔\x3256⭘⽚\x245C\x0C5EѠᝢ⥤\x0E66ᩨὪ", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      OperatingSystem osVersion = Environment.OSVersion;
      int num1 = 2;
      while (true)
      {
        bool flag=false;
        int num2;
        switch (num1)
        {
          case 0:
            if (this.BPanelBrightnessTablesSupported)
            {
              num1 = 14;
              continue;
            }
            goto case 6;
          case 1:
            num1 = 15;
            continue;
          case 2:
            num1 = osVersion.Platform != PlatformID.Win32NT ? 18 : 1;
            continue;
          case 3:
            if (flag)
            {
              num1 = 16;
              continue;
            }
            goto case 14;
          case 4:
            this.propertySetList.Add(new Command.Property(Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ䭤⥦hὪṬ", A_1), typeof (ushort), Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ㙤ɦ\x1D68", A_1), false));
            num1 = 9;
            continue;
          case 5:
            goto label_32;
          case 6:
            num1 = 13;
            continue;
          case 7:
            this.propertySetList.Add(new Command.Property(Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ䭤㝦౨ᥪ\x0E6C੮ὰݲ", A_1), typeof (ushort), Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ㙤ɦ\x1D68", A_1), false));
            num1 = 17;
            continue;
          case 8:
            num1 = 20;
            continue;
          case 9:
            num1 = 3;
            continue;
          case 10:
            if (this.BPanelBrightnessSupported)
            {
              num1 = 7;
              continue;
            }
            goto label_32;
          case 11:
            if (this.K1)
            {
              num1 = 19;
              continue;
            }
            goto label_32;
          case 12:
            num1 = 11;
            continue;
          case 13:
            if (flag)
            {
              num1 = 12;
              continue;
            }
            goto case 19;
          case 14:
            if (1 == 0)
              ;
            this.propertySetList.Add(new Command.Property(Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ䭤\x2E66ݨཪ\x086Cᝮ", A_1), typeof (ushort), Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ㙤ɦ\x1D68", A_1), false));
            num1 = 6;
            continue;
          case 15:
            num2 = osVersion.Version.Major >= 6 ? 1 : 0;
            break;
          case 16:
            num1 = 0;
            continue;
          case 17:
            if (flag)
            {
              num1 = 8;
              continue;
            }
            goto case 4;
          case 18:
            num2 = 0;
            break;
          case 19:
            this.propertySetList.Add(new Command.Property(Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ䭤㝦㹨♪", A_1), typeof (ushort), Module.a("ᝆ⡈╊⡌⍎ፐ\x2152㱔ざㅘ⽚㍜㩞በၢ㙤ɦ\x1D68", A_1), false));
            num1 = 5;
            continue;
          case 20:
            if (this.BPanelBrightnessTablesSupported)
            {
              num1 = 4;
              continue;
            }
            goto case 9;
          default:
            goto label_2;
        }
        flag = num2 != 0;
        num1 = 10;
      }
label_32:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x1F4E⍐㱒╔\x3256⭘⽚\x245C\x0C5EѠᝢ⥤\x0E66ᩨὪ", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 1;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x0A4E⥐㙒㙔≖ⵘ㹚ᅜ㙞በᝢ", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("\x0E46❈≊㥌\x0A4E⥐㙒㙔≖ⵘ㹚ᅜ㙞በᝢ", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖", A_1));
    }
  }
}
