// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandFeature
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace CaslWmi
{
  public class CommandFeature : Command
  {
    private enReturnCode C1 = enReturnCode.e_NULL_VALUE;
    private CommandFeature.Information A1;
    private bool B1;

    private string FeatureEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ᑑㅓ㝕ⱗ⽙\x2E5B㭝╟ཡᅣ\x0A65१ṩիŭṯ山ⱳ㭵㑷", 12);
      }
    }

    private enReturnCode C()
    {
      int A_1 = 9;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154ၖ㱘⽚", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.A1.A = false;
      this.A1.B = false;
      this.A1.C = false;
      this.A1.D = false;
      this.A1.E = false;
      this.A1.F = false;
      this.A1.G = false;
      this.A1.H = false;
      this.A1.I = false;
      this.A1.J = false;
      this.B1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      if (1 == 0)
        ;
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
            goto label_8;
          case 1:
            enReturnCode = this.B();
            num = 0;
            continue;
          case 3:
            if (this.B1)
            {
              num = 1;
              continue;
            }
            enReturnCode = this.A();
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("َ㽐㩒\x2154ၖ㱘⽚", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪ᙬ彮\x0C70", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B()
    {
      int A_1 = 13;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴ㉶ᑸ\x0E7AᅼṾ\xF580\xEA82\xEA84\xE986", A_1), Module.a("R\x2154㙖⭘⽚㡜㭞", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 7;
      XmlEdit xmlEdit=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            xmlEdit = new XmlEdit(xmlDoc);
            num1 = 2;
            continue;
          case 1:
          case 3:
            goto label_22;
          case 2:
            if (xmlEdit != null)
            {
              if (1 == 0)
                ;
              num1 = 5;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴ㉶ᑸ\x0E7AᅼṾ\xF580\xEA82\xEA84\xE986", A_1), Module.a("ᩒ㭔\x2456ⵘ㩚㍜\x2B5E\x0860ɢᅤ\x0E66٨ժ䵬nᝰ卲\x2D74᩶ᕸ㹺\x197Cᙾ\xF580ꎂ\xF784\xE286ﶈﺊﾌ\xE18E\xF490\xF792떔練\xEC98\xF79A\xF19C", A_1));
            num1 = 3;
            continue;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_22;
          case 5:
            this.A1.A = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬㹮Ѱᩲᙴᱶ㕸ᑺቼᑾ뎀킂\xF084\xF786麗\xE48Aﾌﮎ\xF490\xF792", A_1));
            this.A1.B = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬㹮Ѱᩲᙴᱶ㕸ᑺቼᑾ뎀킂\xF084\xF786麗\xE48Aﾌﮎ\xF490\xF792", A_1));
            this.A1.B = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬⥮ၰrŴ㭶ᙸᑺᙼ䱾튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590", A_1));
            this.A1.D = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬⥮❰㙲♴ɶ\x0978\x0B7Aቼൾ\xF580\xE682\xE184", A_1));
            this.A1.E = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬㩮\x2470㡲♴ɶ\x0978\x0B7Aቼൾ\xF580\xE682\xE184", A_1));
            this.A1.F = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬❮ⅰ\x2072մᙶ\x0B78Ṻ㙼\x1A7E\xF880킂\xF084\xF786麗\xE48Aﾌﮎ\xF490\xF792", A_1));
            this.A1.G = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬㽮㍰⍲ݴᡶ\x1D78\x0E7AṼ\x0B7E\xE880\xF582\xEC84\xF386\xF088\xD88A\xF88Cﾎ\xE190ﲒ\xE794\xE396ﲘﾚ", A_1));
            this.A1.H = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬\x2B6Eၰੲ♴Ͷ\x1878ॺॼ\x1A7E\xF380놂횄\xF286麗ﮊ\xE28Cﶎ\xE590\xF692\xF194", A_1));
            this.A1.I = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬⍮ᡰᝲ♴vၸེṼ\x177E튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590", A_1));
            this.A1.J = xmlEdit.GetBool(Module.a("籒穔ᡖⱘ⽚ⵜ⩞ᕠ䱢Ⅴ٦\x1D68੪䉬㹮Ѱᩲᙴᱶ\x2E78Ṻὼ䱾튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590", A_1));
            num1 = 1;
            continue;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 8;
              continue;
            }
            goto label_22;
          case 7:
            try
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(this.FeatureEmulationFile);
                    num2 = 3;
                    continue;
                  case 1:
                    File.WriteAllText(this.FeatureEmulationFile, Resources.FeatureEmulation);
                    num2 = 0;
                    continue;
                  case 3:
                    goto label_19;
                  default:
                    if (!File.Exists(this.FeatureEmulationFile))
                    {
                      num2 = 1;
                      continue;
                    }
                    goto case 0;
                }
              }
            }
            catch (Exception ex)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴ㉶ᑸ\x0E7AᅼṾ\xF580\xEA82\xEA84\xE986", A_1), Module.a("ᙒⵔ㑖㱘\x2B5A⥜㙞\x0E60ൢ䕤୦٨੪६ٮὰᑲ啴ቶᑸ\x0E7AᅼṾ\xF580\xEA82\xEA84\xE986ꦈ\xED8A\xE48C\xE38E\xF490ꦒ떔낖\xE298ꪚ\xE09C뢞", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_19:
            num1 = 6;
            continue;
          case 8:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_22:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴ㉶ᑸ\x0E7AᅼṾ\xF580\xEA82\xEA84\xE986", A_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode A()
    {
      int A_1 = 13;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("R\x2154㙖⭘⽚㡜㭞", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            this.A1.D = Utility.GetBit(dataOut[0], 5);
            num = 1;
            continue;
          case 1:
          case 7:
            goto label_18;
          case 2:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Security, enSecurityCmdType.GetBIOSSecuritySupportCapability, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_4);
            num = 6;
            continue;
          case 3:
            if (wmiBiosClient != null)
            {
              num = 9;
              continue;
            }
            goto case 2;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 5;
              continue;
            }
            goto label_18;
          case 5:
            this.A1.D = Utility.GetBit(dataOut[0], 7);
            this.A1.E = Utility.GetBit(dataOut[1], 2);
            this.A1.F = Utility.GetBit(dataOut[0], 3);
            this.A1.G = Utility.GetBit(dataOut[1], 1);
            num = 7;
            continue;
          case 6:
            if (enReturnCode != enReturnCode.e_OK)
            {
              enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Security, enSecurityCmdType.GetAuthNextSystemCapabilities, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
              num = 4;
              continue;
            }
            num = 0;
            continue;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 10;
              continue;
            }
            goto case 2;
          case 9:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.FeaturesReporting, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 8;
            continue;
          case 10:
            this.A1.A = Utility.GetBit(dataOut[0], 2);
            this.A1.B = Utility.GetBit(dataOut[0], 3);
            this.A1.C = Utility.GetBit(dataOut[1], 2);
            this.A1.H = Utility.GetBit(dataOut[1], 5);
            this.A1.I = Utility.GetBit(dataOut[1], 6);
            this.A1.J = Utility.GetBit(dataOut[2], 2);
            if (1 == 0)
              ;
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Œごㅖ⭘㹚\x2E5C㝞❠٢Ѥ፦ᱨᥪ\x086C♮ὰᕲᩴㅶ\x0B78ᑺၼ㵾좀첂횄", A_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode FeatureSupportedGet(string sCommandName, out object dataOut)
    {
      int A_1 = 8;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ࡍ㕏㍑⁓⍕⩗㽙ཛ\x2B5Dၟቡୣᑥᱧཀྵ\x086B⥭ᕯٱ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙籛⥝य़ᙡౣ䙥", A_1) + sCommandName);
      enReturnCode enReturnCode = this.C1;
      dataOut = (object) null;
      int num1 = 18;
      string key1=null;
      int num2=0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(10);
            string key2 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ཝᕟୡݣ\x0D65\x2467թͫխ䉯山❳͵\x0877\x0A79\x137B\x0C7D\xF47F\xE781\xE083", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key2, num3);
            string key3 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ཝᕟୡݣ\x0D65\x2467թͫխ䍯山❳͵\x0877\x0A79\x137B\x0C7D\xF47F\xE781\xE083", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ᡝşᅡၣ⩥ݧթݫ嵭幯ⅱųٵ\x0877ᕹ\x0E7B\x0A7D\xE57F\xE681", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ᡝ㙟❡䩣㕥\x1D67ᩩᱫŭɯٱᅳት", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ଢ଼㕟⥡䩣㕥\x1D67ᩩᱫŭɯٱᅳት", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ᙝたㅡᑣݥᩧཀྵ❫୭९山❳͵\x0877\x0A79\x137B\x0C7D\xF47F\xE781\xE083", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            string key8 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛\x0E5D≟㉡ᙣ॥౧Ὡཫᩭ\x196Fѱᵳɵŷ呹⽻\x0B7D\xF07F\xF281\xEB83\xF485ﲇ\xEF89\xE88B", A_1);
            int num9 = 6;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key8, num9);
            string key9 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ᩝş᭡㝣ብ१ᡩᡫ୭ɯ䁱婳╵\x0D77\x0A79\x0C7Bᅽ\xF27F\xF681\xE183\xE285", A_1);
            int num10 = 7;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key9, num10);
            string key10 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ቝय़١㝣ᅥŧṩཫ٭幯ⅱųٵ\x0877ᕹ\x0E7B\x0A7D\xE57F\xE681", A_1);
            int num11 = 8;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key10, num11);
            string key11 = Module.a("ࡍ㕏㍑⁓⍕⩗㽙牛ཝᕟୡݣ\x0D65㽧ཀྵ\x0E6B嵭幯ⅱųٵ\x0877ᕹ\x0E7B\x0A7D\xE57F\xE681", A_1);
            int num12 = 9;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key11, num12);
            // ISSUE: reference to a compiler-generated field
            global::A.D = dictionary;
            num1 = 16;
            continue;
          case 1:
          case 3:
          case 5:
          case 6:
          case 9:
          case 11:
          case 12:
          case 13:
          case 15:
          case 17:
          case 20:
            goto label_31;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (global::A.D == null)
            {
              num1 = 0;
              continue;
            }
            goto case 16;
          case 4:
            num1 = 19;
            continue;
          case 7:
            if ((key1 = sCommandName) != null)
            {
              num1 = 14;
              continue;
            }
            goto case 21;
          case 8:
            num1 = 21;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.D.TryGetValue(key1, out num2))
            {
              num1 = 4;
              continue;
            }
            goto case 21;
          case 14:
            num1 = 2;
            continue;
          case 16:
            num1 = 10;
            continue;
          case 18:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 22;
              continue;
            }
            goto label_31;
          case 19:
            switch (num2)
            {
              case 0:
                if (1 == 0)
                  ;
                dataOut = (object)(this.A1.A ? 1 : 0);
                num1 = 12;
                continue;
              case 1:
                dataOut = (object)(this.A1.B ? 1 : 0);
                num1 = 15;
                continue;
              case 2:
                dataOut = (object)(this.A1.C ? 1 : 0);
                num1 = 13;
                continue;
              case 3:
                dataOut = (object)(this.A1.D ? 1 : 0);
                num1 = 17;
                continue;
              case 4:
                dataOut = (object)(this.A1.E ? 1 : 0);
                num1 = 3;
                continue;
              case 5:
                dataOut = (object)(this.A1.F ? 1 : 0);
                num1 = 11;
                continue;
              case 6:
                dataOut = (object)(this.A1.G ? 1 : 0);
                num1 = 6;
                continue;
              case 7:
                dataOut = (object)(this.A1.H ? 1 : 0);
                num1 = 20;
                continue;
              case 8:
                dataOut = (object)(this.A1.I ? 1 : 0);
                num1 = 1;
                continue;
              case 9:
                dataOut = (object)(this.A1.J ? 1 : 0);
                num1 = 5;
                continue;
              default:
                num1 = 8;
                continue;
            }
          case 21:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 9;
            continue;
          case 22:
            num1 = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_31:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ࡍ㕏㍑⁓⍕⩗㽙ཛ\x2B5Dၟቡୣᑥᱧཀྵ\x086B⥭ᕯٱ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg䩩ᝫ幭൯", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 19;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮㙰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
      this.C1 = this.C();
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦㡨ṪѬ౮ᩰ㽲ᩴᡶቸ䥺卼Ȿ\xF480\xF382\xF584\xE886ﮈﾊ\xE88C\xEB8E", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦㡨ṪѬ౮ᩰ㽲ᩴᡶቸ䡺卼Ȿ\xF480\xF382\xF584\xE886ﮈﾊ\xE88C\xEB8E", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦⽨੪Ṭ᭮㵰ᱲᩴᱶ䩸啺\x2E7C\x0A7E\xF180\xF382\xEA84\xF586ﶈ\xEE8A\xE98C", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦⽨㵪⡬䅮≰ٲմݶᙸॺॼ\x1A7E\xE580", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦㱨㹪♬䅮≰ٲմݶᙸॺॼ\x1A7E\xE580", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦Ⅸ㭪㹬ὮၰŲၴ㱶\x1C78ɺ卼Ȿ\xF480\xF382\xF584\xE886ﮈﾊ\xE88C\xEB8E", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦㥨⥪㵬ᵮṰᝲtᑶ\x0D78ቺ\x0B7Cᙾ\xF580廒\xAB84풆ﲈﮊﶌ\xE08E\xE390\xE792\xF094\xF396", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦\x2D68੪ᑬ㱮հቲݴͶ\x1C78ॺ佼兾튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦╨ɪ६㱮ٰᩲŴᑶᅸ啺\x2E7C\x0A7E\xF180\xF382\xEA84\xF586ﶈ\xEE8A\xE98C", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd䥦㡨ṪѬ౮ᩰ\x2472ၴᕶ䩸啺\x2E7C\x0A7E\xF180\xF382\xEA84\xF586ﶈ\xEE8A\xE98C", A_1), typeof (bool), Module.a("\x1F58㹚㱜\x2B5Eᑠᅢd㑦ᱨ᭪ᵬnͰݲၴ\x1376㹸Ṻॼ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮㙰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨", A_1));
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ࡗ⡙㍛\x2E5D՟ၡၣὥ㭧ཀྵᡫ≭\x196Fűs", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ࡗ⡙㍛\x2E5D՟ၡၣὥ㭧ཀྵᡫ≭\x196Fűs", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 16;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ὕ㙗㍙⡛᭝ᡟݡݣ፥ᱧཀྵ\x206Bݭͯٱ", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ὕ㙗㍙⡛᭝ᡟݡݣ፥ᱧཀྵ\x206Bݭͯٱ", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ", A_1));
    }

    public static enReturnCode A(ref bool A_0)
    {
      int A_1 = 4;
label_2:
      CaslLogger caslLogger = new CaslLogger();
      caslLogger.TraceInMessage(Module.a("ॉⵋ㵍㱏Ց㥓㽕癗ᥙ㍛㍝\x0D5F͡\x0A63ɥ\x2E67ཀྵ൫ᩭկqᅳ", A_1), Module.a("\x0D49⥋㩍ᱏ㭑こՕ⽗㍙⡛㵝\x085Fㅡᅣᙥᡧթṫᩭᕯᙱ", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.FeaturesReporting, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 3;
            continue;
          case 2:
            A_0 = Utility.GetBit(dataOut[1], 6);
            num = 0;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_10;
          case 4:
            if (wmiBiosClient != null)
            {
              num = 1;
              continue;
            }
            goto label_10;
          default:
            goto label_2;
        }
      }
label_6:
      if (1 == 0)
        ;
label_10:
      caslLogger.FormatTraceOutMessage(Module.a("ॉⵋ㵍㱏Ց㥓㽕癗ᥙ㍛㍝\x0D5F͡\x0A63ɥ\x2E67ཀྵ൫ᩭկqᅳ", A_1), Module.a("\x0D49⥋㩍ᱏ㭑こՕ⽗㍙⡛㵝\x085Fㅡᅣᙥᡧթṫᩭᕯᙱ", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ䙥፧婩ᅫ䉭偯ၱ❳͵\x0877\x0A79\x137B\x0C7D\xF47F\xE781\xE083ꚅ떇ꪉ\xF78B뾍\xED8F", A_1), (object) enReturnCode.ToString(), (object) A_0.ToString());
      return enReturnCode;
    }

    private struct Information
    {
      public bool A;
      public bool B;
      public bool C;
      public bool D;
      public bool E;
      public bool F;
      public bool G;
      public bool H;
      public bool I;
      public bool J;
    }
  }
}
