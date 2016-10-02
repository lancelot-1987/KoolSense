// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandALS
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
  internal class CommandALS : Command
  {
    private enReturnCode C1 = enReturnCode.e_NULL_VALUE;
    private CommandALS.A A1;
    private bool B1;

    private string ALSEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ᕓᩕୗὙㅛ\x2B5D\x0C5F͡ၣཥݧѩ䉫㙭㵯㹱", 14);
      }
    }

    private enReturnCode InitGet()
    {
      int A_1 = 0;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཅ♇⍉㡋्㕏♑", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
      this.A1.aA = new bool?();
      this.A1.Ba = new bool?();
      this.B1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      enReturnCode enReturnCode = this.B(ref this.A1.aA, ref this.A1.Ba);
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ཅ♇⍉㡋्㕏♑", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ὣ噥ᕧ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B(ref bool? A_0, ref bool? A_1)
    {
      int A_1_1 = 2;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋ཌྷᱏő\x1D53㡕㹗㕙", A_1_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      if (1 == 0)
        ;
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 1:
            goto label_8;
          case 2:
            enReturnCode = this.AA(ref A_0, ref A_1);
            num = 1;
            continue;
          case 3:
            if (this.B1)
            {
              num = 2;
              continue;
            }
            enReturnCode = this.GetALSInfoFromBIOS(ref A_0, ref A_1);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋ཌྷᱏő\x1D53㡕㹗㕙", A_1_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61䑣\x1D65塧ᝩ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode AA(ref bool? A_0, ref bool? A_1)
    {
      int A_1_1 = 10;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 3;
            continue;
          case 1:
            goto label_18;
          case 2:
            try
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(this.ALSEmulationFile);
                    num2 = 3;
                    continue;
                  case 2:
                    File.WriteAllText(this.ALSEmulationFile, Resources.ALSEmulation);
                    num2 = 0;
                    continue;
                  case 3:
                    goto label_6;
                  default:
                    if (!File.Exists(this.ALSEmulationFile))
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
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1_1), Module.a("ᕏ⩑㝓㍕⡗\x2E59㕛ㅝ\x0E5F䉡\x0863॥१\x0E69իmᝯ剱ᅳ᭵\x0D77ᙹᵻ\x0A7D\xE97F\xED81\xEA83ꚅ\xEE87\xE389\xE08B\xEB8Dꪏ늑뎓\xED95ꦗ\xE799뮛", A_1_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_6:
            num1 = 5;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 4;
              continue;
            }
            goto label_18;
          case 4:
            if (1 == 0)
              ;
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            A_0 = new bool?(xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩\x2D6B≭⍯ⅱųٵ\x0877ᕹ\x0E7B\x0A7D\xE57F\xE681", A_1_1)));
            A_1 = new bool?(xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩\x2D6B≭⍯㝱ᩳ\x1775᩷ᙹ\x197B\x1A7D", A_1_1)));
            num1 = 1;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_18;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡⅣ\x0B65\x1D67٩൫ᩭ\x196Fᵱᩳ", A_1_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetALSInfoFromBIOS(ref bool? bALSSupported, ref bool? bALSEnabled)
    {
      int A_1 = 10;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.AmbientLightSensorState, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_4);
            num = 3;
            continue;
          case 1:
          case 2:
          case 9:
            goto label_14;
          case 3:
            num = enReturnCode != enReturnCode.e_OK ? 8 : 4;
            continue;
          case 4:
            bALSEnabled = new bool?(Utility.GetBit(dataOut[0], 0));
            bALSSupported = new bool?(true);
            num = 7;
            continue;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 0;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("᥏㱑❓≕㥗㑙⡛㝝şᙡൣ॥٧䩩ͫ\x086D偯╱ᥳή㩷㍹㍻\x2D7D썿\xEE81\xED83\xE385\xE687ﺉ겋ﲍ\xF58F\xE691\xE193\xE495\xF697ﾙ\xF89B뺝캟힡좣쪥", A_1));
            num = 1;
            continue;
          case 6:
            bALSSupported = new bool?(false);
            bALSEnabled = new bool?(false);
            enReturnCode = enReturnCode.e_OK;
            num = 9;
            continue;
          case 7:
            goto label_12;
          case 8:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("ᕏ⁑♓㥕⩗穙汛♝᭟剡ᥣ䙥\x0E67ᡩͫͭ偯ぱ㵳㥵\x2B77婹\x2B7B㍽쥿ꊁ\xE783\xE785\xE487\xE689겋\xDC8D\xF58F\xF391\xF093릕ꢗꦙ\xF49B뺝힟쪡춣쪥춧誩쮫쮭쒯욱\xDDB3\xD8B5\xDFB7骹ﶻ\xF2BD鎿\xE2C1럃닅꧇뻉꧋", A_1), (object) enReturnCode);
              num = 2;
              continue;
            }
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      if (1 == 0)
        ;
label_14:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓\x1755ᑗख़ᕛそٟൡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ALSInfoGet(string sCommandName, out object dataOut)
    {
      int A_1_1 = 13;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ቒᥔіၘ㕚㭜ぞ♠٢ᅤ", A_1_1), Module.a("R\x2154㙖⭘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪", A_1_1) + sCommandName);
      enReturnCode enReturnCode = this.C1;
      bool? A_0 = new bool?();
      bool? A_1_2 = new bool?();
      dataOut = (object) null;
      int num1 = 23;
      while (true)
      {
        string str=null;
        bool? nullable=false;
        int num2=0;
        switch (num1)
        {
          case 0:
            num1 = str == Module.a("ቒᥔі睘࡚⡜⽞ᅠౢᝤ፦౨ཪ", A_1_1) ? 13 : 17;
            continue;
          case 1:
            num1 = 8;
            continue;
          case 2:
            dataOut = (object) A_1_2;
            num1 = 3;
            continue;
          case 3:
          case 5:
          case 10:
          case 14:
            goto label_35;
          case 4:
            num1 = 24;
            continue;
          case 6:
            num1 = 11;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 15;
              continue;
            }
            goto label_35;
          case 8:
            num2 = nullable.HasValue ? 1 : 0;
            break;
          case 9:
            num1 = 0;
            continue;
          case 11:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 10;
            continue;
          case 12:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 18;
              continue;
            }
            goto label_35;
          case 13:
            if (this.A1.aA.HasValue)
            {
              num1 = 16;
              continue;
            }
            enReturnCode = this.B(ref A_0, ref A_1_2);
            num1 = 7;
            continue;
          case 15:
            this.A1.aA = A_0;
            dataOut = (object) A_0;
            num1 = 14;
            continue;
          case 16:
            dataOut = (object) this.A1.aA;
            num1 = 21;
            continue;
          case 17:
            num1 = 22;
            continue;
          case 18:
            nullable = A_0;
            num1 = 20;
            continue;
          case 19:
            num2 = 0;
            break;
          case 20:
            num1 = !nullable.GetValueOrDefault() ? 19 : 1;
            continue;
          case 21:
            goto label_24;
          case 22:
            if (str == Module.a("ቒᥔі睘Ṛ㍜㹞͠རdͦ", A_1_1))
            {
              enReturnCode = this.B(ref A_0, ref A_1_2);
              num1 = 12;
              continue;
            }
            num1 = 6;
            continue;
          case 23:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 4;
              continue;
            }
            goto label_35;
          case 24:
            if ((str = sCommandName) != null)
            {
              num1 = 9;
              continue;
            }
            goto case 11;
          default:
            goto label_2;
        }
        if (num2 == 0)
        {
          enReturnCode = enReturnCode.e_NOT_SUPPORTED;
          num1 = 5;
        }
        else
          num1 = 2;
      }
label_24:
      if (1 == 0)
        ;
label_35:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ቒᥔіၘ㕚㭜ぞ♠٢ᅤ", A_1_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 19;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮㙰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
      this.C1 = this.InitGet();
      this.propertyGetList.Add(new Command.Property(Module.a("ᡘ\x175A\x0E5C煞㉠ᙢᕤᝦ٨ᥪᥬ੮ᕰ", A_1), typeof (bool), Module.a("ᡘ\x175A\x0E5Cᙞའբ\x0A64\x2066౨Ὢ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("ᡘ\x175A\x0E5C煞\x2460ൢѤզը\x0E6A६", A_1), typeof (bool), Module.a("ᡘ\x175A\x0E5Cᙞའբ\x0A64\x2066౨Ὢ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮㙰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨", A_1));
    }

    private enReturnCode ALSInfoSet(string sCommandName, object dataIn)
    {
      int A_1 = 10;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅏṑݓὕ㙗㱙㍛\x0D5D՟ᙡ", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
      enReturnCode enReturnCode = this.C1;
      int num1 = 6;
      while (true)
      {
        string str=null;
        bool? nullable=false;
        int num2=0;
        switch (num1)
        {
          case 0:
          case 9:
          case 13:
            goto label_29;
          case 1:
            if (!this.A1.aA.HasValue)
            {
              num1 = 12;
              continue;
            }
            break;
          case 2:
            num2 = 0;
            goto label_22;
          case 3:
            nullable = this.A1.aA;
            num1 = 18;
            continue;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 3;
              continue;
            }
            goto label_29;
          case 5:
            if (1 == 0)
              break;
            break;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 8;
              continue;
            }
            goto label_29;
          case 7:
            num1 = 1;
            continue;
          case 8:
            num1 = 17;
            continue;
          case 10:
            if (str == Module.a("ᅏṑݓ硕\x1D57㑙㵛㱝\x0C5Fݡc", A_1))
            {
              num1 = 7;
              continue;
            }
            goto label_16;
          case 11:
            num1 = 10;
            continue;
          case 12:
            enReturnCode = this.B(ref this.A1.aA, ref this.A1.Ba);
            num1 = 5;
            continue;
          case 14:
            num1 = 16;
            continue;
          case 15:
            enReturnCode = this.B((bool) dataIn);
            num1 = 0;
            continue;
          case 16:
            num2 = nullable.HasValue ? 1 : 0;
            goto label_22;
          case 17:
            if ((str = sCommandName) != null)
            {
              num1 = 11;
              continue;
            }
            goto label_16;
          case 18:
            num1 = !nullable.GetValueOrDefault() ? 2 : 14;
            continue;
          default:
            goto label_2;
        }
        num1 = 4;
        continue;
label_16:
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num1 = 13;
        continue;
label_22:
        if (num2 != 0)
        {
          num1 = 15;
        }
        else
        {
          enReturnCode = enReturnCode.e_NOT_SUPPORTED;
          num1 = 9;
        }
      }
label_29:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᅏṑݓὕ㙗㱙㍛\x0D5D՟ᙡ", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode B(bool A_0)
    {
      int A_1 = 11;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ɐ㙒\x2154ᙖᕘ࡚ᑜㅞݠౢ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
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
            enReturnCode = this.SetALSInfoInBIOS(A_0);
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 1:
            enReturnCode = this.AAA(A_0);
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
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ɐ㙒\x2154ᙖᕘ࡚ᑜㅞݠౢ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᑮ䅰\x0E72", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode AAA(bool A_0)
    {
      int A_1 = 5;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ၐὒٔṖ㝘㵚\x325Cᩞౠᙢ।٦\x1D68ɪɬŮ", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xmlDoc = new XmlDocument();
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = new XmlTools().Validate(xmlDoc.InnerXml, Resources.hpCASL);
            num1 = 1;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 4;
              continue;
            }
            goto label_18;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_18;
          case 3:
            if (1 == 0)
              ;
            try
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    xmlDoc.Load(this.ALSEmulationFile);
                    num2 = 3;
                    continue;
                  case 2:
                    File.WriteAllText(this.ALSEmulationFile, Resources.ALSEmulation);
                    num2 = 0;
                    continue;
                  case 3:
                    goto label_7;
                  default:
                    if (!File.Exists(this.ALSEmulationFile))
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
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ၐὒٔṖ㝘㵚\x325Cᩞౠᙢ।٦\x1D68ɪɬŮ", A_1), Module.a("๊㕌ⱎ㑐⍒\x2154㹖㙘㕚絜㍞\x0E60ɢŤ\x0E66ݨ౪䵬੮ᱰٲᥴᙶ\x0D78ቺቼᅾꆀ\xE582\xEC84\xEB86\xEC88놊권ꢎ\xEA90ꊒ\xE894낖", A_1), (object) ex.Message);
              enReturnCode = enReturnCode.e_INVALID_XML;
            }
label_7:
            num1 = 2;
            continue;
          case 4:
            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
            xmlEdit.SetBool(Module.a("摊扌N\x2450❒╔≖ⵘ瑚ᥜ㹞ᕠɢ䩤♦╨㡪⡬Ůၰᅲᥴቶ\x1D78", A_1), A_0);
            xmlEdit.XmlDoc.Save(this.ALSEmulationFile);
            num1 = 5;
            continue;
          case 5:
            goto label_18;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᡊ⡌㭎ၐὒٔṖ㝘㵚\x325Cᩞౠᙢ।٦\x1D68ɪɬŮ", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetALSInfoInBIOS(bool bALSEnabled)
    {
      int A_1 = 19;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜ṞⵠぢⱤ०ཨѪ\x246CŮ㍰㩲㩴\x2476", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] dataIn = new byte[4];
      int num = 5;
      byte[] dataOut=null;
      WmiBIOSClient wmiBiosClient=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_10;
          case 1:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetAmbientLightSensor, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
            num = 4;
            continue;
          case 2:
            if (wmiBiosClient != null)
            {
              num = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜ṞⵠぢⱤ०ཨѪ\x246CŮ㍰㩲㩴\x2476", A_1), Module.a("ၘ㕚\x2E5C\x2B5E`ൢᅤ\x0E66\x0868ὪѬnὰ卲ᩴᅶ奸ⱺၼᙾ쎀쪂쪄풆쪈\xE78A\xE48C\xEA8Eﾐ\xE792떔\xE596ﲘ\xEF9A\xE89C\xED9E쾠욢솤螦잨\xDEAA솬쎮", A_1));
            num = 0;
            continue;
          case 3:
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜ṞⵠぢⱤ०ཨѪ\x246CŮ㍰㩲㩴\x2476", A_1), Module.a("᱘⥚⽜ぞ፠䍢啤ὦቨ孪ၬ佮ᝰŲᩴ᩶奸㥺㑼ま튀ꎂ튄쪆삈\xAB8A\xEE8C\xEE8E\xFD90ﾒ떔삖\xEB98\xF29A\xE99C爵躠鎢隤쾦覨\xDCAA얬욮\xDDB0횲閴쒶\xDCB8쾺즼횾꿀꓂\xE5C4蛆藈飊\xEDCC볎ꗐ닒ꇔ닖", A_1), (object) enReturnCode);
            num = 6;
            continue;
          case 4:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto label_12;
          case 5:
            dataIn[0] = bALSEnabled ? (byte) 1 : (byte) 0;
            dataOut = (byte[]) null;
            wmiBiosClient = new WmiBIOSClient();
            num = 2;
            continue;
          case 6:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_10:
      if (1 == 0)
        ;
label_12:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜ṞⵠぢⱤ०ཨѪ\x246CŮ㍰㩲㩴\x2476", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲啴\x0C76䥸ٺ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 11;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      this.propertySetList.Add(new Command.Property(Module.a("ၐὒٔ祖᱘㕚㱜㵞ൠ٢Ť", A_1), typeof (bool), Module.a("ၐὒٔṖ㝘㵚\x325C\x0C5EѠᝢ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖क़⥚\x325C⽞ѠᅢᅤṦ㩨\x0E6Aᥬ⍮ᡰrŴ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ፕ⁗㽙㽛\x2B5Dᑟݡ⡣ཥ᭧ṩ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
    }

    private struct A
    {
      public bool? aA;
      public bool? Ba;
    }
  }
}
