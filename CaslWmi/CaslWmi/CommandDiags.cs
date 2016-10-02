// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandDiags
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace CaslWmi
{
    public class CommandDiags : Command
    {
        private enWarrantySize B1 = enWarrantySize.eNotSet_0;
        private bool? C1 = new bool?();
        private enReturnCode E1 = enReturnCode.e_NULL_VALUE;
        private bool A1;
        private string F1;
        private string G1;
        private string H1;

        private enWarrantySize WarrantySize
        {
            get
            {
                if (this.B8DigitWarrantyDate)
                    this.B1 = enWarrantySize.eEight_8;
                return this.B1;
            }
            set
            {
                this.B1 = value;
            }
        }

        private bool B8DigitWarrantyDate
        {
            get
            {
                int A_1 = 9;
                label_2:
                bool A_0 = false;
                enReturnCode enReturnCode = enReturnCode.e_OK;
                int num = 3;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ൎ楐ᝒ㱔ざじ⽚ੜ㹞፠ᅢѤ०\x1D68ቪ⥬\x0E6Eհᙲ", A_1), Module.a("\x0A4E⍐\x2152㩔╖畘筚㡜\x0D5EѠᝢ彤䝦", A_1) + enReturnCode.ToString());
                            num = 9;
                            continue;
                        case 1:
                            goto label_16;
                        case 2:
                            A_0 = this.C1.Value;
                            enReturnCode = enReturnCode.e_OK;
                            num = 8;
                            continue;
                        case 3:
                            if (this.C1.HasValue)
                            {
                                num = 2;
                                continue;
                            }
                            enReturnCode = this.A(out A_0);
                            num = 4;
                            continue;
                        case 4:
                            if (enReturnCode != enReturnCode.e_OK)
                            {
                                num = 0;
                                continue;
                            }
                            this.C1 = new bool?(A_0);
                            num = 7;
                            continue;
                        case 5:
                            A_0 = false;
                            num = 1;
                            continue;
                        case 6:
                            if (enReturnCode != enReturnCode.e_OK)
                            {
                                num = 5;
                                continue;
                            }
                            goto label_16;
                        case 7:
                        case 8:
                        case 9:
                            if (1 == 0)
                                ;
                            num = 6;
                            continue;
                        default:
                            goto label_2;
                    }
                }
                label_16:
                return A_0;
            }
        }

        private string DiagsEmulationFile
        {
            get
            {
                return Constants.EmulationFolder + Module.a("ཊ\x244C\x2E4E㙐⁒ၔ㩖ⱘ㝚㱜\x2B5E\x0860ౢ\x0B64䥦ㅨ♪Ⅼ", 5);
            }
        }

        private int WarrantyDateLength
        {
            get
            {
                return !this.B8DigitWarrantyDate ? 6 : 8;
            }
        }

        private enReturnCode Initialize()
        {
            int A_1 = 5;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ɋ⍌♎═㩒㑔㭖じ\x215A㡜", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            this.A1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
            object dataOut = (object)null;
            object dataIn = (object)null;
            int num = 8;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (this.G1 == null)
                        {
                            num = 12;
                            continue;
                        }
                        goto case 2;
                    case 1:
                        enReturnCode = this.DiagsExecute(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᱚ㡜ㅞѠᅢѤ፦౨♪\x086C᭮ᥰᱲᅴ\x2776ᙸቺ\x137C\x0B7E\xE480\xF182", A_1), dataIn, out dataOut);
                        this.H1 = Utility.GetMethodName(Module.a("ཊ\x244C\x2E4E㙐⁒ၔ⽖㱘㡚⡜\x2B5EѠ", A_1));
                        num = 13;
                        continue;
                    case 2:
                        num = 4;
                        continue;
                    case 3:
                        this.F1 = Module.a("ཊ\x244C\x2E4E㙐⁒ቔ\x3256ⵘ", A_1);
                        num = 6;
                        continue;
                    case 4:
                        if (this.H1 == null)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_24;
                    case 5:
                        enReturnCode = this.DiagsGet(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᱚ㡜ㅞѠᅢѤ፦౨♪\x086C᭮ᥰᱲᅴ\x2776ᙸቺ\x137C\x0B7E\xE480\xF182", A_1), out dataOut);
                        this.F1 = Utility.GetMethodName(Module.a("ཊ\x244C\x2E4E㙐⁒ቔ\x3256ⵘ", A_1));
                        num = 10;
                        continue;
                    case 6:
                        num = 0;
                        continue;
                    case 7:
                        this.H1 = Module.a("ཊ\x244C\x2E4E㙐⁒ၔ⽖㱘㡚⡜\x2B5EѠ", A_1);
                        num = 14;
                        continue;
                    case 8:
                        if (this.F1 == null)
                        {
                            num = 5;
                            continue;
                        }
                        goto case 6;
                    case 9:
                        if (string.IsNullOrEmpty(this.G1))
                        {
                            num = 11;
                            continue;
                        }
                        goto case 2;
                    case 10:
                        if (string.IsNullOrEmpty(this.F1))
                        {
                            num = 3;
                            continue;
                        }
                        goto case 6;
                    case 11:
                        this.G1 = Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1);
                        if (1 == 0)
                            ;
                        num = 2;
                        continue;
                    case 12:
                        enReturnCode = this.DiagsSet(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᱚ㡜ㅞѠᅢѤ፦౨♪\x086C᭮ᥰᱲᅴ\x2776ᙸቺ\x137C\x0B7E\xE480\xF182", A_1), dataOut);
                        this.G1 = Utility.GetMethodName(Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1));
                        num = 9;
                        continue;
                    case 13:
                        if (string.IsNullOrEmpty(this.H1))
                        {
                            num = 7;
                            continue;
                        }
                        goto label_24;
                    case 14:
                        goto label_24;
                    default:
                        goto label_2;
                }
            }
            label_24:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ɋ⍌♎═㩒㑔㭖じ\x215A㡜", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode A(out bool A_0)
        {
            int A_1 = 19;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜࡞`ᅢᝤ٦ݨὪᑬ\x2B6Eၰݲၴ\x2476ၸź\x187C", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
            A_0 = false;
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] dataOut = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_10;
                    case 1:
                        A_0 = Utility.GetBit(dataOut[1], 4);
                        this.log.InformationMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜࡞`ᅢᝤ٦ݨὪᑬ\x2B6Eၰݲၴ\x2476ၸź\x187C", A_1), Module.a("慘癚ᥜ㙞٠\x0A62ᅤ䝦㹨੪ὬᵮၰᵲŴ\x0E76奸ቺ\x0E7C䕾ꆀ", A_1) + A_0.ToString());
                        num = 4;
                        continue;
                    case 2:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        goto label_10;
                    case 3:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.FeaturesReporting, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 0;
                        continue;
                    case 4:
                        goto label_10;
                    default:
                        goto label_2;
                }
            }
            label_10:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜࡞`ᅢᝤ٦ݨὪᑬ\x2B6Eၰݲၴ\x2476ၸź\x187C", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲啴\x0C76䥸ٺ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDiagsXml(ref XmlDocument xdocDiags)
        {
            int A_1 = 3;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x0B4E㡐\x3252\x3254\x2456Ř㙚ㅜ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        enReturnCode = new XmlTools().Validate(xdocDiags.InnerXml, Resources.hpCASL);
                        num = 2;
                        continue;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_12;
                    case 2:
                        goto label_12;
                    case 3:
                        if (this.A1)
                        {
                            num = 5;
                            continue;
                        }
                        enReturnCode = this.A(out xdocDiags);
                        num = 4;
                        continue;
                    case 4:
                    case 6:
                        num = 1;
                        continue;
                    case 5:
                        enReturnCode = this.B(out xdocDiags);
                        num = 6;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_12:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌\x0B4E㡐\x3252\x3254\x2456Ř㙚ㅜ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode B(out XmlDocument A_0)
        {
            int A_1 = 10;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓ቕㅗ㭙㭛ⵝ㡟ཡ\x0863⍥էὩk\x0F6Dѯ\x1771ၳ", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_0 = new XmlDocument();
            try
            {
                int num1 = 3;
                while (true)
                {
                    switch (num1)
                    {
                        case 0:
                            A_0.Load(this.DiagsEmulationFile);
                            num1 = 1;
                            continue;
                        case 1:
                            goto label_8;
                        case 2:
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(Resources.DiagsEmulation);
                            XmlEdit xmlEdit = new XmlEdit(xmlDoc);
                            byte[] bytes = new byte[128];
                            int num2 = (int)xmlEdit.SetBytes(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩㡫٭ᕯqᥳ\x1775ᑷ㹹ᕻώ\xE77F\xEC81\xEB83\xF585ﲇ\xE389\xEF8Bﶍ", A_1), bytes);
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num1 = 0;
                            continue;
                        default:
                            if (!File.Exists(this.DiagsEmulationFile))
                            {
                                num1 = 2;
                                continue;
                            }
                            goto case 0;
                    }
                }
            }
            catch
            {
                enReturnCode = enReturnCode.e_INVALID_XML;
            }
            label_8:
            if (1 == 0)
                ;
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓ቕㅗ㭙㭛ⵝ㡟ཡ\x0863⍥էὩk\x0F6Dѯ\x1771ၳ", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ噫乭", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode A(out XmlDocument A_0)
        {
            int A_1 = 19;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜᭞\x0860ɢɤᑦㅨ٪Ŭ⥮Ͱᱲᡴ㕶へ㑺\x2E7C", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
            enReturnCode enReturnCode1 = enReturnCode.e_OK;
            A_0 = (XmlDocument)null;
            string xml = Module.a("敘摚╜\x325Eൠ䍢፤ɦ᭨ᡪѬnὰ乲坴䙶坸䭺彼彾\xE480\xED82\xE684\xE886\xED88\xE28A\xE38C\xE88E겐높\xE094\xE396ﾘ뚚ꖜ붞麠鶢馤\xE0A6첨\xDFAA\xE9AC욮킰풲운\xF3B6\xD8B8쾺\xDCBC\xF0BE듀럂뗄닆뷈\xEBCA뗌ꋎ뷐뷒ꛔ\xEAD6ﯘ\xA8DA뻜럞蓠転蓤铦쓨菪鷬싮鋰鳲飴\xD9F6髸髺軼鏾⌀㴂┄✆⤈㜊䈌税攐挒怔挖✘㬚㴜㼞Ġ̢Ԥᬦ洨䨪夬丮\x0F30", A_1);
            DateTime A_0_1 = new DateTime();
            enReturnCode enReturnCode2 = this.A(ref A_0_1);
            int num = 14;
            byte[] abyBatteryChargeControl=null;
            uint uiDiagsLaunchCommandStatus=0;
            enReturnCode launchCommandStatus=0;
            enReturnCode batteryChargeControl=0;
            uint uiBIOSUpdateStatus=0;
            enReturnCode biosUpdateStatus=0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        xml = xml + Module.a("敘\x1F5A㑜㹞٠ၢ⥤٦ᱨժ\x0E6Cݮ㉰ᱲᡴ᩶\x1878ᕺ\x197CⱾ\xF580\xE282\xF184\xF286愈떊", A_1) + uiDiagsLaunchCommandStatus.ToString() + Module.a("敘瑚ᥜ㙞`Ѣᙤ\x2B66\x0868Ṫͬ౮ᥰひᩴ᩶ᑸ᩺\x137C\x1B7E튀\xF782\xE484\xF386ﲈ\xF88A뎌", A_1);
                        num = 5;
                        continue;
                    case 1:
                        xml += Module.a("敘瑚\x1F5C㹞ᕠᝢdᕦၨ⡪լ\x0E6EͰᑲၴ㑶ᙸᕺॼൾ\xEE80\xEF82뮄", A_1);
                        num = 3;
                        continue;
                    case 2:
                        xml = string.Concat(new object[4]
                        {
              (object) xml,
              (object) Module.a("敘ᥚ㱜\x2B5Eᕠ٢ᝤṦ坨坪\x246C୮佰䉲䥴塶へὺ䍼䍾튀\xF782\xE484\xF386\xEC88떊", A_1),
              (object) abyBatteryChargeControl[1],
              (object) Module.a("敘瑚\x0E5C\x2B5E`ᝢd奦啨䑪⽬\x0E6Eհݲၴնx䕺", A_1)
                        });
                        num = 1;
                        continue;
                    case 3:
                        xml += Module.a("祘筚絜罞䅠䍢奤䡦\x2D68੪ᥬ\x0E6E佰卲啴坶䕸呺㉼\x0A7E\xF580\xF382\xF084\xF386랈랊ꊌ좎\xF490\xE792톔ﺖ\xF898ﲚ\xEE9C\xDB9E삠힢쒤\xE8A6\xDCA8\xDFAA\xDDAC\xDAAE얰趲", A_1);
                        num = 20;
                        continue;
                    case 4:
                        num = 7;
                        continue;
                    case 5:
                        uiBIOSUpdateStatus = 0U;
                        biosUpdateStatus = this.GetBIOSUpdateStatus(out uiBIOSUpdateStatus);
                        num = 13;
                        continue;
                    case 6:
                        xml = xml + Module.a("敘\x0C5A㱜ⵞ፠ɢ\x0B64፦ၨ啪", A_1) + A_0_1.ToString() + Module.a("敘瑚ੜ㹞፠ᅢѤ०\x1D68ቪ卬", A_1);
                        num = 22;
                        continue;
                    case 7:
                        if ((int)abyBatteryChargeControl[1] != (int)byte.MaxValue)
                        {
                            num = 2;
                            continue;
                        }
                        goto case 1;
                    case 8:
                        if (launchCommandStatus == enReturnCode.e_OK)
                        {
                            if (1 == 0)
                                ;
                            num = 0;
                            continue;
                        }
                        goto case 5;
                    case 9:
                        xml = string.Concat(new object[4]
                        {
              (object) xml,
              (object) Module.a("敘ᥚ㱜\x2B5Eᕠ٢ᝤṦ坨坪\x246C୮佰䍲䥴塶へὺ䍼䍾튀\xF782\xE484\xF386\xEC88떊", A_1),
              (object) abyBatteryChargeControl[0],
              (object) Module.a("敘瑚\x0E5C\x2B5E`ᝢd奦啨䑪⽬\x0E6Eհݲၴնx䕺", A_1)
                        });
                        num = 4;
                        continue;
                    case 10:
                        if (batteryChargeControl == enReturnCode.e_OK)
                        {
                            num = 19;
                            continue;
                        }
                        goto case 3;
                    case 11:
                        goto label_26;
                    case 12:
                        uiDiagsLaunchCommandStatus = 0U;
                        launchCommandStatus = this.GetDiagsLaunchCommandStatus(out uiDiagsLaunchCommandStatus);
                        num = 8;
                        continue;
                    case 13:
                        if (biosUpdateStatus == enReturnCode.e_OK)
                        {
                            num = 16;
                            continue;
                        }
                        goto case 21;
                    case 14:
                        if (enReturnCode2 == enReturnCode.e_OK)
                        {
                            num = 6;
                            continue;
                        }
                        enReturnCode1 = enReturnCode2;
                        num = 17;
                        continue;
                    case 15:
                        if (enReturnCode1 == enReturnCode.e_OK)
                        {
                            num = 12;
                            continue;
                        }
                        goto case 3;
                    case 16:
                        xml = xml + Module.a("敘ᥚᑜၞ㉠㙢ᕤͦ\x0868Ὢ\x086C㱮հቲŴɶ\x0A78䕺", A_1) + uiBIOSUpdateStatus.ToString() + Module.a("敘瑚\x1F5Cᙞ\x2E60ぢつᝦ൨੪ᥬ੮≰ݲᑴͶ\x0C78\x087A䍼", A_1);
                        num = 21;
                        continue;
                    case 17:
                    case 22:
                        num = 15;
                        continue;
                    case 18:
                        if ((int)abyBatteryChargeControl[0] != (int)byte.MaxValue)
                        {
                            num = 9;
                            continue;
                        }
                        goto case 4;
                    case 19:
                        xml += Module.a("敘ᥚ㱜\x2B5Eᕠ٢ᝤṦ⩨ͪ౬ᵮᙰᙲ㙴ᡶ\x1778ེོၾ\xED80붂", A_1);
                        num = 18;
                        continue;
                    case 20:
                        if (enReturnCode1 == enReturnCode.e_OK)
                        {
                            num = 11;
                            continue;
                        }
                        goto label_36;
                    case 21:
                        abyBatteryChargeControl = (byte[])null;
                        batteryChargeControl = this.GetBatteryChargeControl(out abyBatteryChargeControl);
                        num = 10;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_26:
            try
            {
                A_0 = new XmlDocument();
                A_0.PreserveWhitespace = true;
                A_0.LoadXml(xml);
            }
            catch (Exception ex)
            {
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜", A_1), ex.Message);
                enReturnCode1 = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_36:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜᭞\x0860ɢɤᑦㅨ٪Ŭ⥮Ͱᱲᡴ㕶へ㑺\x2E7C", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲佴坶", A_1) + enReturnCode1.ToString());
            return enReturnCode1;
        }

        private enReturnCode A(ref DateTime A_0)
        {
            int A_1 = 2;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num = 40;
            int year1 = 0;
            int month1 = 0;
            int day1 = 0;
            int year2 = 0;
            int month2 = 0;
            int day2 = 0;
            byte[] dataOut = null;
            int index = 0;
            WmiBIOSClient wmiBiosClient = null;
            XmlDocument A_0_1 = null;
            while (true)
            {

                switch (num)
                {
                    case 0:
                    case 60:
                        goto label_85;
                    case 1:
                    case 36:
                        num = 49;
                        continue;
                    case 2:
                        index = 0;
                        num = 36;
                        continue;
                    case 3:
                    case 5:
                    case 14:
                    case 15:
                    case 17:
                    case 59:
                        num = 12;
                        continue;
                    case 4:
                    case 19:
                    case 38:
                        num = 50;
                        continue;
                    case 6:
                        num = enWarrantySize.eNotSet_0 != this.WarrantySize ? 46 : 24;
                        continue;
                    case 7:
                        year1 = 0;
                        month1 = 0;
                        day1 = 0;
                        num = 56;
                        continue;
                    case 8:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.WarrantyStartDate, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 43;
                        continue;
                    case 9:
                        num = 53;
                        continue;
                    case 10:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 39;
                        continue;
                    case 11:
                        if ((int)dataOut[2] == 0)
                        {
                            num = 48;
                            continue;
                        }
                        break;
                    case 12:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 7;
                            continue;
                        }
                        goto label_85;
                    case 13:
                        enReturnCode = enReturnCode.e_OK;
                        num = 17;
                        continue;
                    case 16:
                    case 20:
                        if (1 == 0)
                            ;
                        num = 35;
                        continue;
                    case 18:
                        num = 28;
                        continue;
                    case 21:
                        if ((int)dataOut[index] == 0)
                        {
                            num = 31;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                        num = 59;
                        continue;
                    case 22:
                        string @string = new XmlEdit(A_0_1).GetString(Module.a("杇敉͋㭍\x244F≑\x2153≕睗ṙ㵛⩝ş䵡㍣ݥᩧᡩ൫mѯୱ", A_1));
                        year2 = 2000 + Convert.ToInt32(@string.Substring(0, 2));
                        month2 = Convert.ToInt32(@string.Substring(2, 2));
                        day2 = Convert.ToInt32(@string.Substring(4, 2));
                        num = 33;
                        continue;
                    case 23:
                        num = 6;
                        continue;
                    case 24:
                        this.WarrantySize = enWarrantySize.eFive_5;
                        enReturnCode = enReturnCode.e_OK;
                        num = 15;
                        continue;
                    case 25:
                        if ((int)dataOut[0] == 0)
                        {
                            num = 57;
                            continue;
                        }
                        break;
                    case 26:
                        num = 11;
                        continue;
                    case 27:
                        this.WarrantySize = enWarrantySize.eEight_8;
                        year1 = ((int)dataOut[0] - 48) * 1000 + ((int)dataOut[1] - 48) * 100 + ((int)dataOut[2] - 48) * 10 + ((int)dataOut[3] - 48);
                        month1 = ((int)dataOut[4] - 48) * 10 + ((int)dataOut[5] - 48);
                        day1 = ((int)dataOut[6] - 48) * 10 + ((int)dataOut[7] - 48);
                        enReturnCode = enReturnCode.e_OK;
                        num = 19;
                        continue;
                    case 28:
                        if ((int)dataOut[4] == 0)
                        {
                            num = 55;
                            continue;
                        }
                        break;
                    case 29:
                        if ((int)dataOut[index] >= 48)
                        {
                            num = 54;
                            continue;
                        }
                        goto case 30;
                    case 30:
                        num = 21;
                        continue;
                    case 31:
                        num = 44;
                        continue;
                    case 32:
                        if ((int)dataOut[5] == 0)
                        {
                            num = 42;
                            continue;
                        }
                        break;
                    case 33:
                        goto label_74;
                    case 34:
                        this.WarrantySize = enWarrantySize.eFive_5;
                        year1 = 2000 + ((int)dataOut[4] - 48);
                        month1 = ((int)dataOut[0] - 48) * 10 + ((int)dataOut[1] - 48);
                        day1 = ((int)dataOut[2] - 48) * 10 + ((int)dataOut[3] - 48);
                        num = 4;
                        continue;
                    case 35:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 47;
                            continue;
                        }
                        goto case 4;
                    case 37:
                        if ((int)dataOut[3] == 0)
                        {
                            num = 18;
                            continue;
                        }
                        break;
                    case 39:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 22;
                            continue;
                        }
                        goto label_85;
                    case 40:
                        if (this.A1)
                        {
                            num = 10;
                            continue;
                        }
                        dataOut = (byte[])null;
                        wmiBiosClient = new WmiBIOSClient();
                        num = 41;
                        continue;
                    case 41:
                        if (wmiBiosClient != null)
                        {
                            num = 8;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("\x1F47❉╋్᥏\x1D51ݓᕕ㑗㍙㥛そᑟ䉡ൣ\x0865᭧ṩ൫mѯ᭱ᕳɵᅷᕹቻ幽\xF27F\xE781\xF083\xF385慎\xE489\xE98B\xEA8D낏ﲑ\xE193歹\xF497", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num = 60;
                        continue;
                    case 42:
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num = 20;
                        continue;
                    case 43:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 2;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("േ㡉㹋⅍≏牑ㅓ\x2E55㵗㥙⥛⩝य़ౡͣ䙥ὧݩիⱭ㥯㵱❳塵㵷ɹ\x197Bᵽ쵿\xE781\xF083\xEE85\xE787\xEE89쾋\xE28D憐\xF791望\xE295뒗몙鍊첝얟횡\xE7A3즥첧쾩隫躭", A_1) + enReturnCode.ToString());
                        num = 0;
                        continue;
                    case 44:
                        if (5 == index)
                        {
                            num = 9;
                            continue;
                        }
                        goto label_44;
                    case 45:
                        if ((int)dataOut[1] == 0)
                        {
                            num = 26;
                            continue;
                        }
                        break;
                    case 46:
                        if (enWarrantySize.eFive_5 != this.WarrantySize)
                        {
                            enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                            num = 14;
                            continue;
                        }
                        num = 13;
                        continue;
                    case 47:
                        num = 52;
                        continue;
                    case 48:
                        num = 37;
                        continue;
                    case 49:
                        num = index < this.WarrantyDateLength ? 29 : 3;
                        continue;
                    case 50:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 58;
                            continue;
                        }
                        goto label_85;
                    case 51:
                        if ((int)dataOut[index] > 57)
                        {
                            num = 30;
                            continue;
                        }
                        ++index;
                        num = 1;
                        continue;
                    case 52:
                        if ((int)dataOut[5] == 0)
                        {
                            num = 34;
                            continue;
                        }
                        this.WarrantySize = enWarrantySize.eSix_6;
                        year1 = 2000 + ((int)dataOut[0] - 48) * 10 + ((int)dataOut[1] - 48);
                        month1 = ((int)dataOut[2] - 48) * 10 + ((int)dataOut[3] - 48);
                        day1 = ((int)dataOut[4] - 48) * 10 + ((int)dataOut[5] - 48);
                        num = 38;
                        continue;
                    case 53:
                        if (6 == this.WarrantyDateLength)
                        {
                            num = 23;
                            continue;
                        }
                        goto label_44;
                    case 54:
                        num = 51;
                        continue;
                    case 55:
                        num = 32;
                        continue;
                    case 56:
                        num = !this.B8DigitWarrantyDate ? 25 : 27;
                        continue;
                    case 57:
                        num = 45;
                        continue;
                    case 58:
                        goto label_22;
                    default:
                        goto label_2;
                }
                enReturnCode = enReturnCode.e_OK;
                num = 16;
                continue;
                label_44:
                enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                num = 5;
            }
            label_22:
            try
            {
                A_0 = new DateTime(year1, month1, day1);
                goto label_85;
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("േ㡉㹋⅍≏牑㕓≕ⱗ㽙ㅛ\x2E5Dᑟୡ\x0A63ť䡧ṩͫ乭o\x1371ٳյᵷ婹ջ\x1B7D\xE17F\xF081ꒃ", A_1) + year1.ToString() + Module.a("摇橉⅋⅍㹏♑㱓癕", A_1) + month1.ToString() + Module.a("摇橉⡋⽍⥏牑", A_1) + day1.ToString() + Module.a("片橉", A_1) + ex.Message);
                goto label_85;
            }
            label_74:
            try
            {
                A_0 = new DateTime(year2, month2, day2);
            }
            catch
            {
                enReturnCode = enReturnCode.e_INVALID_XML;
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("\x1D47⑉ⵋⱍ㱏㝑瑓≕㝗穙㽛ㅝ\x0E5Fᑡţᑥᱧ䩩ᡫŭ偯㙱ᕳɵᵷ\x2E79ᕻ\x137D\xE57F뢁ꒃ\xDF85\xED87\xEB89ﺋ뎍\xEB8Fꊑ\xE993몕뢗힙\xF39B\xF09D풟쪡馣\xDDA5馧\xD7A9肫躭\xF4AF펱춳讵쎷袹솻", A_1), (object)(year2 - 2000), (object)month2, (object)day2);
            }
            label_85:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ཇ⽉㡋᥍ㅏ⁑♓㝕㙗\x2E59╛", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61䑣\x1D65塧ᝩ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDiagsLaunchCommandStatus(out uint uiDiagsLaunchCommandStatus)
        {
            int A_1 = 15;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] dataOut = (byte[])null;
            uiDiagsLaunchCommandStatus = 0U;
            int num = 5;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0=null;
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
                        goto label_18;
                    case 1:
                        XmlEdit xmlEdit = new XmlEdit(A_0);
                        uiDiagsLaunchCommandStatus = xmlEdit.GetUInt32(Module.a("穔硖ᙘ\x2E5A⥜⽞ᑠᝢ䩤⍦\x0868Ὢ౬䁮㕰ᩲᑴၶ\x0A78㝺\x1C7C\x0A7E\xEF80\xE082\xED84쒆\xE688\xE68A\xE08C\xEE8Eﾐ\xF792요\xE396\xF898\xEF9A\xE89C\xEC9E", A_1));
                        num = 8;
                        continue;
                    case 2:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㑜㹞٠ၢ⥤٦ᱨժ\x0E6Cݮ㉰ᱲᡴ᩶\x1878ᕺ\x197CⱾ\xF580\xE282\xF184\xF286愈", A_1), Module.a("ɔ㩖じᥚᑜၞ㉠\x2062।\x0E66౨ժᥬ佮ᡰᵲٴͶ\x1878ᕺॼᙾ\xE080\xF782\xEC84\xE886\xE788\xAB8Aﾌ\xEA8E\xE590\xE692\xE794練ﲘﾚ붜\xF19E풠쾢즤", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num = 6;
                        continue;
                    case 3:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetSystemDiagnosticLaunchCommand, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 0;
                        continue;
                    case 4:
                        if (1 == 0)
                            ;
                        uiDiagsLaunchCommandStatus = BitConverter.ToUInt32(dataOut, 0);
                        num = 10;
                        continue;
                    case 5:
                        if (this.A1)
                        {
                            num = 7;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 2;
                        continue;
                    case 6:
                    case 8:
                    case 10:
                        goto label_18;
                    case 7:
                        A_0 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0);
                        num = 9;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_18;
                    default:
                        goto label_2;
                }
            }
            label_18:
            return enReturnCode;
        }

        private enReturnCode GetBIOSUpdateStatus(out uint uiBIOSUpdateStatus)
        {
            int A_1 = 16;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_OK;
            uiBIOSUpdateStatus = 0U;
            int num = 0;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (this.A1)
                        {
                            num = 1;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 7;
                        continue;
                    case 1:
                        A_0 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0);
                        num = 5;
                        continue;
                    case 2:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 6;
                            continue;
                        }
                        goto label_18;
                    case 3:
                        dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetBIOSUpdateStatusCommand, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 2;
                        continue;
                    case 4:
                    case 8:
                        goto label_18;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 10;
                            continue;
                        }
                        goto label_18;
                    case 6:
                        uiBIOSUpdateStatus = BitConverter.ToUInt32(dataOut, 0);
                        num = 8;
                        continue;
                    case 7:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59ṛ\x175D⽟ㅡㅣᙥ౧୩ᡫ୭⍯ٱᕳɵ\x0D77ॹ", A_1), Module.a("ŕ㕗㍙ṛ\x175D⽟ㅡ❣\x0A65ŧཀྵɫᩭ偯᭱ᩳյ\x0C77᭹ቻ\x0A7D\xE97F\xE381\xF083\xEF85\xE787\xE489겋ﲍ\xF58F\xE691\xE193\xE495\xF697ﾙ\xF89B뺝캟힡좣쪥", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num = 4;
                        continue;
                    case 9:
                        goto label_14;
                    case 10:
                        XmlEdit xmlEdit = new XmlEdit(A_0);
                        uiBIOSUpdateStatus = xmlEdit.GetUInt32(Module.a("祕睗ᕙ⥛⩝ၟᝡၣ䥥Ⱨ୩ᡫ\x0F6D彯ぱ㵳㥵\x2B77⽹\x0C7B\x1A7D\xE17F\xF681\xE183햅ﲇ\xEB89\xF88Bﮍ\xE38F", A_1));
                        num = 9;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_14:
            if (1 == 0)
                ;
            label_18:
            return enReturnCode;
        }

        private enReturnCode GetBatteryChargeControl(out byte[] abyBatteryChargeControl)
        {
            abyBatteryChargeControl = null;

            int A_1 = 19;
            label_3:
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num = 2;
            if (1 == 0)
                ;
            WmiBIOSClient wmiBiosClient = null;
            XmlDocument A_0 = null;
            while (true)
            {
               
                switch (num)
                {
                    case 0:
                        abyBatteryChargeControl = new byte[4];
                        A_0 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0);
                        num = 4;
                        continue;
                    case 1:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.BatteryChargeControl, (byte[])null, 0U, out abyBatteryChargeControl, enSizeOut.eSIZE_4);
                        num = 7;
                        continue;
                    case 2:
                        if (this.A1)
                        {
                            num = 0;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 3;
                        continue;
                    case 3:
                        if (wmiBiosClient != null)
                        {
                            num = 1;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜\x1D5E`ᝢᅤɦ᭨ቪ\x2E6CݮၰŲቴቶ㩸ᑺ\x137C\x0B7E\xF380\xEC82\xE984", A_1), Module.a("๘㙚㑜\x1D5E⡠Ɫ㙤\x2466ըɪ\x086CŮհ卲ᱴ\x1976\x0A78ེ\x1C7Cᅾ\xF580\xEA82\xE484\xF386\xE088\xE48A\xE38C꾎\xE390\xF692\xE194\xE296\xEB98\xF59A\xF89Cﮞ膠춢키쮦얨", A_1));
                        abyBatteryChargeControl = (byte[])null;
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num = 5;
                        continue;
                    case 4:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 6;
                            continue;
                        }
                        goto label_15;
                    case 5:
                    case 7:
                    case 8:
                        goto label_15;
                    case 6:
                        XmlEdit xmlEdit = new XmlEdit(A_0);
                        abyBatteryChargeControl[0] = xmlEdit.GetByte(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲㝴ᙶ\x0D78ེ\x187Cൾ\xF880삂\xED84\xE686ﮈ\xEC8A\xE88C첎ﺐﶒ\xE194\xE596\xF698\xF79A늜\xDD9E삠힢톤슦\xDBA8튪芬ﲮ얰튲솴튶\xE2B8閺鎼邾裀\xA7C2\xF8C4\xE0C6杻\xECCA郌", A_1));
                        abyBatteryChargeControl[1] = xmlEdit.GetByte(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲㝴ᙶ\x0D78ེ\x187Cൾ\xF880삂\xED84\xE686ﮈ\xEC8A\xE88C첎ﺐﶒ\xE194\xE596\xF698\xF79A늜\xDD9E삠힢톤슦\xDBA8튪芬ﲮ얰튲솴튶\xE2B8閺鎼邾裀\xA7C2\xF8C4\xE0C6\xF8C8\xECCA郌", A_1));
                        num = 8;
                        continue;
                    default:
                        goto label_3;
                }
            }
            label_15:
            return enReturnCode;
        }

        private enReturnCode DiagsGet(string sCommandName, out object dataOut)
        {
            int A_1 = 3;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ൈ≊ⱌ⡎≐ᑒご⍖", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ睖\x2E58\x325A⥜㝞䅠", A_1) + sCommandName);
            enReturnCode enReturnCode = this.E1;
            dataOut = (object)null;
            int num1 = 4;
            byte[] abyBatteryChargeControl=null;
            uint uiDiagsLaunchCommandStatus=0;
            string key1=null;
            int num2=0;
            DateTime A_0=DateTime.Now;
            uint uiBIOSUpdateStatus=0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 3:
                    case 8:
                    case 13:
                    case 14:
                    case 18:
                    case 20:
                    case 26:
                    case 28:
                    case 29:
                    case 31:
                    case 35:
                    case 36:
                    case 37:
                        goto label_52;
                    case 1:
                        if (Utility.AddMethod(Module.a("ൈ≊ⱌ⡎≐ᑒご⍖", A_1), Module.a("ൈ≊ⱌ⡎≐ᑒご⍖", A_1)))
                        {
                            enReturnCode = enReturnCode.e_OK;
                            num1 = 28;
                            continue;
                        }
                        num1 = 23;
                        continue;
                    case 2:
                        num1 = 22;
                        continue;
                    case 4:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 17;
                            continue;
                        }
                        goto label_52;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 32;
                            continue;
                        }
                        goto label_52;
                    case 6:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 33;
                            continue;
                        }
                        goto label_52;
                    case 7:
                        if ((key1 = sCommandName) != null)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 22;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_52;
                    case 10:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(11);
                        string key2 = Module.a("ੈ⩊㹌⍎ِ㹒㱔祖Ṙ㹚㍜㩞፠ɢᅤɦ\x2468\x0E6AᥬݮṰᝲ╴ᡶၸᕺॼ\x1A7E\xF380", A_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("ൈ≊ⱌ⡎≐絒ɔ㙖⭘⥚㱜ㅞᕠᩢ", A_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("ൈ≊ⱌ⡎≐絒ᥔ㙖ⱘ㕚㹜㝞≠ౢ\x0864੦\x0868ժ६㱮հቲŴɶ\x0A78", A_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("ൈ≊ⱌ⡎≐絒\x1754Ṗᙘ࡚\x085C⽞\x0560ɢᅤɦ㩨Ὢ౬᭮Ѱr", A_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("ൈ≊ⱌ⡎≐絒\x1754㙖ⵘ⽚㡜ⵞᡠ\x2062\x0D64٦᭨౪\x086CⱮṰᵲŴնᙸ\x177A", A_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("ൈ≊ⱌ⡎≐絒ᅔ\x3256⽘\x325A㹜㩞❠\x0A62ᝤ੦Ṩ੪Ὤ੮\x2470Ͳᅴᙶ\x0D78Ṻ\x2E7C\x0B7E\xE080\xF782\xF084\xF486", A_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        string key8 = Module.a("ൈ≊ⱌ⡎≐絒Ŕ㽖㱘⥚ぜ㹞ൠ❢\x0C64٦\x0E68ժɬᱮհᩲᙴѶ", A_1);
                        int num9 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num9);
                        string key9 = Module.a("ൈ≊ⱌ⡎≐絒ፔ㙖㩘⽚\x325Cⵞᡠ\x2062\x0A64०\x1D68ᥪɬͮ", A_1);
                        int num10 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num10);
                        string key10 = Module.a("ൈ≊ⱌ⡎≐絒Ք㡖⩘⽚Ṝぞ\x0560٢\x2064ᕦ᭨ѪὬ", A_1);
                        int num11 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num11);
                        string key11 = Module.a("ൈ≊ⱌ⡎≐絒\x1754㙖ⵘ⽚㡜ⵞᡠ\x2062\x0D64٦᭨౪\x086CⱮṰᵲŴնᙸ\x177A㉼ॾ\xE480\xF182\xF784\xEE86\xED88\xEE8A", A_1);
                        int num12 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num12);
                        string key12 = Module.a("ൈ≊ⱌ⡎≐絒Ŕ㽖㱘⥚ぜ㹞ൠ\x2062\x0A64०\x1D68ᥪɬͮ", A_1);
                        int num13 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num13);
                        // ISSUE: reference to a compiler-generated field
                        global::A.B = dictionary;
                        num1 = 16;
                        continue;
                    case 11:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.B == null)
                        {
                            num1 = 10;
                            continue;
                        }
                        goto case 16;
                    case 12:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.B.TryGetValue(key1, out num2))
                        {
                            num1 = 24;
                            continue;
                        }
                        goto case 22;
                    case 15:
                        dataOut = (object)A_0;
                        num1 = 29;
                        continue;
                    case 16:
                        num1 = 12;
                        continue;
                    case 17:
                        num1 = 7;
                        continue;
                    case 19:
                        num1 = 11;
                        continue;
                    case 21:
                        dataOut = (object)uiDiagsLaunchCommandStatus;
                        num1 = 3;
                        continue;
                    case 22:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 14;
                        continue;
                    case 23:
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num1 = 36;
                        continue;
                    case 24:
                        num1 = 27;
                        continue;
                    case 25:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            if (1 == 0)
                                ;
                            num1 = 21;
                            continue;
                        }
                        goto label_52;
                    case 27:
                        switch (num2)
                        {
                            case 0:
                                num1 = 30;
                                continue;
                            case 1:
                                A_0 = new DateTime();
                                enReturnCode = this.A(ref A_0);
                                num1 = 9;
                                continue;
                            case 2:
                                uiDiagsLaunchCommandStatus = 0U;
                                enReturnCode = this.GetDiagsLaunchCommandStatus(out uiDiagsLaunchCommandStatus);
                                num1 = 25;
                                continue;
                            case 3:
                                uiBIOSUpdateStatus = 0U;
                                enReturnCode = this.GetBIOSUpdateStatus(out uiBIOSUpdateStatus);
                                num1 = 6;
                                continue;
                            case 4:
                                abyBatteryChargeControl = (byte[])null;
                                enReturnCode = this.GetBatteryChargeControl(out abyBatteryChargeControl);
                                num1 = 5;
                                continue;
                            case 5:
                                enReturnCode = this.G(out dataOut);
                                num1 = 0;
                                continue;
                            case 6:
                                enReturnCode = this.A(out dataOut);
                                num1 = 18;
                                continue;
                            case 7:
                                enReturnCode = this.B(out dataOut);
                                num1 = 8;
                                continue;
                            case 8:
                                enReturnCode = this.C(out dataOut);
                                num1 = 37;
                                continue;
                            case 9:
                                enReturnCode = this.E(out dataOut);
                                num1 = 26;
                                continue;
                            case 10:
                                enReturnCode = this.F(out dataOut);
                                num1 = 31;
                                continue;
                            default:
                                num1 = 2;
                                continue;
                        }
                    case 30:
                        if (!Utility.AddMethod(Module.a("ൈ≊ⱌ⡎≐ᑒご⍖", A_1), MethodBase.GetCurrentMethod().Name.ToString()))
                        {
                            num1 = 34;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_OK;
                        num1 = 13;
                        continue;
                    case 32:
                        uint num14 = BitConverter.ToUInt32(abyBatteryChargeControl, 0);
                        dataOut = (object)num14;
                        num1 = 20;
                        continue;
                    case 33:
                        dataOut = (object)uiBIOSUpdateStatus;
                        num1 = 35;
                        continue;
                    case 34:
                        num1 = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_52:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ൈ≊ⱌ⡎≐ᑒご⍖", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode G(out object A_0)
        {
            int A_1 = 15;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 5;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
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
                        goto label_26;
                    case 1:
                        A_0 = (object)dataOut;
                        num = 13;
                        continue;
                    case 2:
                        if (bytes.Length == 4)
                        {
                            num = 10;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 9;
                        continue;
                    case 3:
                        num = 2;
                        continue;
                    case 4:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("穔硖ᙘ\x2E5A⥜⽞ᑠᝢ䩤⍦\x0868Ὢ౬䁮㕰ᙲ\x0374Ṷ᩸Ṻ㭼ᙾ\xF380\xEE82\xF284\xE686ﮈ\xEE8A\xD88Cﾎ\xF590\xF292\xE194\xF296쪘\xEF9Aﲜ\xEB9E풠킢", A_1));
                        num = 15;
                        continue;
                    case 5:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 8;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 7;
                        continue;
                    case 6:
                        dataOut = new byte[4];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.DeviceFirmwareUpdateStatus, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 0;
                        continue;
                    case 7:
                        if (wmiBiosClient != null)
                        {
                            num = 6;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 11;
                        continue;
                    case 8:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 14;
                        continue;
                    case 9:
                    case 11:
                    case 12:
                    case 13:
                    case 16:
                        goto label_26;
                    case 10:
                        A_0 = (object)bytes;
                        num = 12;
                        continue;
                    case 14:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 4;
                            continue;
                        }
                        goto label_26;
                    case 15:
                        if (bytes == null)
                        {
                            if (1 == 0)
                                ;
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 16;
                            continue;
                        }
                        num = 3;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_26:
            return enReturnCode;
        }

        private enReturnCode F(out object A_0)
        {
            int A_1 = 12;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 10;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 6:
                    case 12:
                    case 16:
                        goto label_26;
                    case 1:
                        num = 7;
                        continue;
                    case 2:
                        goto label_9;
                    case 3:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("絑筓ᥕⵗ\x2E59ⱛ\x2B5Dᑟ䵡\x2063ݥᱧ୩䍫㩭ᡯ\x1771ٳ᭵\x1977ᙹ㽻ᅽ\xEE7F\xF681\xF683\xE985\xE487", A_1));
                        num = 14;
                        continue;
                    case 4:
                        A_0 = (object)bytes;
                        num = 0;
                        continue;
                    case 5:
                        A_0 = (object)dataOut;
                        num = 12;
                        continue;
                    case 7:
                        if (bytes.Length == 4)
                        {
                            num = 4;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 6;
                        continue;
                    case 8:
                        dataOut = new byte[4];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.ThermalControl, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 9;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 5;
                            continue;
                        }
                        goto label_26;
                    case 10:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 15;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 11;
                        continue;
                    case 11:
                        if (wmiBiosClient != null)
                        {
                            num = 8;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 16;
                        continue;
                    case 13:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 3;
                            continue;
                        }
                        goto label_26;
                    case 14:
                        if (bytes == null)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 2;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 15:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 13;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_9:
            if (1 == 0)
                ;
            label_26:
            return enReturnCode;
        }

        private enReturnCode E(out object A_0)
        {
            int A_1 = 0;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 10;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 14;
                        continue;
                    case 1:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 4;
                        continue;
                    case 2:
                        A_0 = (object)dataOut;
                        if (1 == 0)
                            ;
                        num = 8;
                        continue;
                    case 3:
                        dataOut = new byte[4];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.BatteryChargeControlOverride, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 9;
                        continue;
                    case 4:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 15;
                            continue;
                        }
                        goto label_26;
                    case 5:
                        if (bytes == null)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 13;
                            continue;
                        }
                        num = 16;
                        continue;
                    case 6:
                    case 8:
                    case 12:
                    case 13:
                    case 14:
                        goto label_26;
                    case 7:
                        A_0 = (object)bytes;
                        num = 12;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_26;
                    case 10:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 1;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 0;
                        continue;
                    case 11:
                        if (bytes.Length == 4)
                        {
                            num = 7;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 6;
                        continue;
                    case 15:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟\x2061գብᱧཀྵṫ\x176D㍯ᩱᕳѵίό㽻ᅽ\xEE7F\xF681\xF683\xE985\xE487얉懲\xEB8D\xE28F\xE091ﶓ\xF295ﶗ", A_1));
                        num = 5;
                        continue;
                    case 16:
                        num = 11;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_26:
            return enReturnCode;
        }

        private enReturnCode C(out object A_0)
        {
            int A_1 = 0;
            label_2:
            if (1 == 0)
                ;
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 2;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 11;
                            continue;
                        }
                        goto label_26;
                    case 1:
                        if (wmiBiosClient != null)
                        {
                            num = 15;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 12;
                        continue;
                    case 2:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 14;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 1;
                        continue;
                    case 3:
                    case 4:
                    case 6:
                    case 10:
                    case 12:
                        goto label_26;
                    case 5:
                        A_0 = (object)dataOut;
                        num = 6;
                        continue;
                    case 7:
                        if (bytes.Length == 4)
                        {
                            num = 9;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 10;
                        continue;
                    case 8:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 5;
                            continue;
                        }
                        goto label_26;
                    case 9:
                        A_0 = (object)bytes;
                        num = 3;
                        continue;
                    case 11:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟㉡ୣᕥᱧ⥩ͫ੭ᕯ㝱ٳѵ\x1777\x0879", A_1));
                        num = 13;
                        continue;
                    case 13:
                        if (bytes == null)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 4;
                            continue;
                        }
                        num = 16;
                        continue;
                    case 14:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 0;
                        continue;
                    case 15:
                        dataOut = new byte[4];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.PostCodeError, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 8;
                        continue;
                    case 16:
                        num = 7;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_26:
            return enReturnCode;
        }

        private enReturnCode B(out object A_0)
        {
            int A_1 = 4;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 6;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 2:
                    case 3:
                    case 12:
                        goto label_26;
                    case 1:
                        dataOut = new byte[4];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.ThermalControl, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 11;
                        continue;
                    case 4:
                        A_0 = (object)bytes;
                        num = 15;
                        continue;
                    case 5:
                        if (wmiBiosClient != null)
                        {
                            num = 1;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 12;
                        continue;
                    case 6:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 10;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 5;
                        continue;
                    case 7:
                        num = 8;
                        continue;
                    case 8:
                        if (bytes.Length == 128)
                        {
                            num = 4;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 2;
                        continue;
                    case 9:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("敉捋ō╏♑\x2453⍕ⱗ留ᡛ㽝ᑟ͡䭣\x2065१३ᡫŭɯୱ㝳\x1975ᙷ\x0E79\x0E7Bᅽ\xEC7F", A_1));
                        num = 13;
                        continue;
                    case 10:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 14;
                        continue;
                    case 11:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 16;
                            continue;
                        }
                        goto label_26;
                    case 13:
                        if (bytes == null)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 3;
                            continue;
                        }
                        num = 7;
                        continue;
                    case 14:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 9;
                            continue;
                        }
                        goto label_26;
                    case 15:
                        goto label_21;
                    case 16:
                        A_0 = (object)dataOut;
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_21:
            if (1 == 0)
                ;
            label_26:
            return enReturnCode;
        }

        private enReturnCode A(out object A_0)
        {
            int A_1 = 6;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_0 = (object)null;
            int num = 14;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] bytes=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 6;
                            continue;
                        }
                        goto label_26;
                    case 1:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 13;
                        continue;
                    case 2:
                        if (bytes.Length == 128)
                        {
                            num = 16;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 12;
                        continue;
                    case 3:
                        if (bytes == null)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 11;
                            continue;
                        }
                        num = 7;
                        continue;
                    case 4:
                    case 10:
                    case 11:
                    case 12:
                    case 15:
                        goto label_26;
                    case 5:
                        dataOut = new byte[128];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.ThermalDiagnostics, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 0;
                        continue;
                    case 6:
                        A_0 = (object)dataOut;
                        num = 15;
                        continue;
                    case 7:
                        num = 2;
                        continue;
                    case 8:
                        if (wmiBiosClient != null)
                        {
                            num = 5;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 10;
                        continue;
                    case 9:
                        bytes = new XmlEdit(A_0_1).GetBytes(Module.a("捋慍\x1F4F❑⁓♕ⵗ\x2E59獛ᩝşᙡգ䥥㱧ɩ५ᱭᵯ\x1371ᡳ㉵ᅷ᭹᭻ၽ\xEF7F\xF181\xF083\xEF85\xEB87黎", A_1));
                        if (1 == 0)
                            ;
                        num = 3;
                        continue;
                    case 13:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 9;
                            continue;
                        }
                        goto label_26;
                    case 14:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num = 1;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num = 8;
                        continue;
                    case 16:
                        A_0 = (object)bytes;
                        num = 4;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_26:
            return enReturnCode;
        }

        protected override void InitPropertyGetList()
        {
            int A_1 = 8;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63Ⅵ൧ṩ\x206Bݭͯٱ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
            int num = 0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (enReturnCode.e_NULL_VALUE == this.E1)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_6;
                    case 1:
                        this.E1 = this.Initialize();
                        num = 2;
                        continue;
                    case 2:
                        goto label_6;
                    default:
                        goto label_2;
                }
            }
            label_6:
            if (1 == 0)
                ;
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗\x0D59㵛ⱝ\x125F͡\x0A63ብᅧ", A_1), typeof(DateTime), this.F1, false));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ᙙ㵛\x2B5D\x0E5Fšౣ╥ݧݩū\x0F6Dṯᙱ❳ɵ\x1977\x0E79ॻൽ", A_1), typeof(uint), this.F1, false));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ᡙᕛᅝ㍟㝡ᑣɥ१ṩ५㵭ѯ\x1371s͵\x0B77", A_1), typeof(uint), this.F1, false));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ᡙ㵛⩝ᑟݡᙣὥ\x2B67ɩ൫ᱭᝯ\x1771㝳\x1975ᙷ\x0E79\x0E7Bᅽ\xEC7F", A_1), typeof(uint), this.F1, false));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ṙ㥛⡝य़šţ\x2065ŧᡩūᥭᅯqᅳ⍵\x0877ṹᵻ\x0A7D\xE57F톁\xF083\xE785ﲇﾉﾋ", A_1), typeof(byte[]), this.F1, true));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗๙㑛㭝\x125Fཡգ\x0A65Ⱨͩ൫७ṯᵱݳɵᅷ\x1979ཻ", A_1), typeof(byte[]), this.F1, true));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ਖ਼㍛ⵝᑟⅡୣɥ൧⽩ṫᱭὯq", A_1), typeof(byte[]), this.F1, true));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗᱙㵛㵝ᑟൡᙣὥ\x2B67թɫᩭɯᵱᡳ", A_1), typeof(byte[]), this.F1, true));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗ᡙ㵛⩝ᑟݡᙣὥ\x2B67ɩ൫ᱭᝯ\x1771㝳\x1975ᙷ\x0E79\x0E7Bᅽ\xEC7F춁\xF283\xE385慎\xF889\xE58B\xEA8D\xF58F", A_1), typeof(byte[]), this.F1, true));
            this.propertyGetList.Add(new Command.Property(Module.a("੍㥏㍑㍓╕癗๙㑛㭝\x125Fཡգ\x0A65\x2B67թɫᩭɯᵱᡳ", A_1), typeof(byte[]), this.F1, true));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63Ⅵ൧ṩ\x206Bݭͯٱ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
        }

        private enReturnCode DiagsSet(string sCommandName, object dataIn)
        {
            int A_1 = 5;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 21;
            int num2=0;
            string key1=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.C == null)
                        {
                            num1 = 9;
                            continue;
                        }
                        goto case 1;
                    case 1:
                        num1 = 3;
                        continue;
                    case 2:
                        num1 = 25;
                        continue;
                    case 3:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.C.TryGetValue(key1, out num2))
                        {
                            num1 = 29;
                            continue;
                        }
                        goto case 25;
                    case 4:
                    case 6:
                    case 7:
                    case 8:
                    case 12:
                    case 13:
                    case 15:
                    case 17:
                    case 18:
                    case 23:
                    case 24:
                    case 26:
                    case 27:
                    case 28:
                        goto label_40;
                    case 5:
                        num1 = 20;
                        continue;
                    case 9:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(11);
                        string key2 = Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᱚ㡜ㅞѠᅢѤ፦౨♪\x086C᭮ᥰᱲᅴ\x2776ᙸቺ\x137C\x0B7E\xE480\xF182", A_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("ཊ\x244C\x2E4E㙐⁒答V㡘⥚⽜㹞འᝢᱤ", A_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("ཊ\x244C\x2E4E㙐⁒答᭖㡘\x2E5A㍜㱞ॠ\x2062\x0A64੦Ѩ੪ͬ୮≰ݲᑴͶ\x0C78\x087A", A_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("ཊ\x244C\x2E4E㙐⁒答ᕖၘᑚ\x0E5Cਫ਼ᅠݢѤ፦౨㡪ᥬ\x0E6Eհٲٴ", A_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("ཊ\x244C\x2E4E㙐⁒答ᕖ㡘⽚⥜㩞፠ᩢ♤ས\x0868ᥪ੬੮㉰ᱲ᭴Ͷ\x0B78ᑺᅼ", A_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("ཊ\x244C\x2E4E㙐⁒答ፖ㱘ⵚ㑜㱞Ѡ╢\x0C64ᕦѨᱪ౬ᵮᑰ♲մ\x1376\x1878ེ\x187CⱾ\xF580\xE282\xF184\xF286愈", A_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        string key8 = Module.a("ཊ\x244C\x2E4E㙐⁒答͖ㅘ㹚⽜\x325E`རⅤ\x0E66\x0868౪ͬnɰݲᱴᑶ\x0A78", A_1);
                        int num9 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num9);
                        string key9 = Module.a("ཊ\x244C\x2E4E㙐⁒答ᅖ㡘㡚⥜ぞ፠ᩢ♤\x0866ݨὪὬnᵰ", A_1);
                        int num10 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num10);
                        string key10 = Module.a("ཊ\x244C\x2E4E㙐⁒答ݖ㙘⡚⥜ᱞ\x0E60ݢd≦᭨ᥪɬᵮ", A_1);
                        int num11 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num11);
                        string key11 = Module.a("ཊ\x244C\x2E4E㙐⁒答ᕖ㡘⽚⥜㩞፠ᩢ♤ས\x0868ᥪ੬੮㉰ᱲ᭴Ͷ\x0B78ᑺᅼま\xF780\xE682\xF784\xF586\xE088\xEF8A\xE88C", A_1);
                        int num12 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num12);
                        string key12 = Module.a("ཊ\x244C\x2E4E㙐⁒答͖ㅘ㹚⽜\x325E`ར♤\x0866ݨὪὬnᵰ", A_1);
                        int num13 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num13);
                        // ISSUE: reference to a compiler-generated field
                        global::A.C = dictionary;
                        num1 = 1;
                        continue;
                    case 10:
                        if (!Utility.AddMethod(Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1), Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1)))
                        {
                            num1 = 22;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_OK;
                        num1 = 27;
                        continue;
                    case 11:
                        num1 = 0;
                        continue;
                    case 14:
                        if (Utility.AddMethod(Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1), MethodBase.GetCurrentMethod().Name.ToString()))
                        {
                            enReturnCode = enReturnCode.e_OK;
                            num1 = 12;
                            continue;
                        }
                        num1 = 16;
                        continue;
                    case 16:
                        num1 = 10;
                        continue;
                    case 19:
                        switch (num2)
                        {
                            case 0:
                                num1 = 14;
                                continue;
                            case 1:
                                enReturnCode = this.A((DateTime)dataIn);
                                num1 = 15;
                                continue;
                            case 2:
                                if (1 == 0)
                                    ;
                                enReturnCode = this.SetDiagsLaunchCommandStatus((uint)dataIn);
                                num1 = 13;
                                continue;
                            case 3:
                                enReturnCode = this.SetBIOSUpdateStatusCommand((uint)dataIn);
                                num1 = 26;
                                continue;
                            case 4:
                                enReturnCode = this.A((uint)dataIn);
                                num1 = 24;
                                continue;
                            case 5:
                                enReturnCode = this.G(dataIn);
                                num1 = 18;
                                continue;
                            case 6:
                                enReturnCode = this.A(dataIn);
                                num1 = 6;
                                continue;
                            case 7:
                                enReturnCode = this.E(dataIn);
                                num1 = 23;
                                continue;
                            case 8:
                                enReturnCode = this.C(dataIn);
                                num1 = 28;
                                continue;
                            case 9:
                                enReturnCode = this.B(dataIn);
                                num1 = 4;
                                continue;
                            case 10:
                                enReturnCode = this.F(dataIn);
                                num1 = 17;
                                continue;
                            default:
                                num1 = 2;
                                continue;
                        }
                    case 20:
                        if ((key1 = sCommandName) != null)
                        {
                            num1 = 11;
                            continue;
                        }
                        goto case 25;
                    case 21:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto label_40;
                    case 22:
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num1 = 7;
                        continue;
                    case 25:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 8;
                        continue;
                    case 29:
                        num1 = 19;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_40:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ཊ\x244C\x2E4E㙐⁒ٔ\x3256ⵘ", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode G(object A_0)
        {
            int A_1 = 10;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 4;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.DeviceFirmwareUpdateStatus, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 1;
                        continue;
                    case 1:
                    case 5:
                    case 6:
                        goto label_30;
                    case 2:
                        if (dataIn.Length == 4)
                        {
                            num1 = 0;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 6;
                        continue;
                    case 3:
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 5;
                            continue;
                        }
                        num1 = 8;
                        continue;
                    case 4:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 7;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 3;
                        continue;
                    case 7:
                        goto label_10;
                    case 8:
                        dataIn = A_0 as byte[];
                        num1 = 2;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_10:
            try
            {
                label_12:
                byte[] bytes = A_0 as byte[];
                int num2 = 2;
                XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            if (1 == 0)
                                ;
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 5;
                                continue;
                            }
                            goto case 3;
                        case 1:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375㹷\x1379\x0E7B\x137D\xF77F\xE381\xF683\xE385\xDD87憎\xE88B\xEF8D\xE48F\xF791잓\xE295聯\xEE99\xE99B\xED9D", A_1), bytes);
                            num2 = 0;
                            continue;
                        case 2:
                            if (bytes.Length == 4)
                            {
                                num2 = 4;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 6;
                            continue;
                        case 3:
                        case 6:
                            num2 = 8;
                            continue;
                        case 4:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 7;
                            continue;
                        case 5:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 3;
                            continue;
                        case 7:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 1;
                                continue;
                            }
                            goto case 3;
                        case 8:
                            goto label_30;
                        default:
                            goto label_12;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_30:
            return enReturnCode;
        }

        private enReturnCode F(object A_0)
        {
            int A_1 = 12;
            label_2:
            if (1 == 0)
                ;
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 8;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 1:
                    case 4:
                        goto label_30;
                    case 2:
                        dataIn = A_0 as byte[];
                        num1 = 7;
                        continue;
                    case 3:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.ThermalControl, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 1;
                        continue;
                    case 5:
                        goto label_11;
                    case 6:
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 0;
                            continue;
                        }
                        num1 = 2;
                        continue;
                    case 7:
                        if (dataIn.Length == 4)
                        {
                            num1 = 3;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 4;
                        continue;
                    case 8:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 5;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 6;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_11:
            try
            {
                label_13:
                byte[] bytes = A_0 as byte[];
                int num2 = 4;
                XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("絑筓ᥕⵗ\x2E59ⱛ\x2B5Dᑟ䵡\x2063ݥᱧ୩䍫㩭ᡯ\x1771ٳ᭵\x1977ᙹ㽻ᅽ\xEE7F\xF681\xF683\xE985\xE487", A_1), bytes);
                            num2 = 7;
                            continue;
                        case 1:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 8;
                            continue;
                        case 2:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 0;
                                continue;
                            }
                            goto case 6;
                        case 3:
                            goto label_30;
                        case 4:
                            if (bytes.Length == 4)
                            {
                                num2 = 5;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 6;
                            continue;
                        case 5:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 2;
                            continue;
                        case 6:
                        case 8:
                            num2 = 3;
                            continue;
                        case 7:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 1;
                                continue;
                            }
                            goto case 6;
                        default:
                            goto label_13;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_30:
            return enReturnCode;
        }

        private enReturnCode E(object A_0)
        {
            int A_1 = 15;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 2;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 6:
                        goto label_30;
                    case 1:
                        dataIn = A_0 as byte[];
                        num1 = 5;
                        continue;
                    case 2:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 4;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 3;
                        continue;
                    case 3:
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 6;
                            continue;
                        }
                        num1 = 1;
                        continue;
                    case 4:
                        goto label_10;
                    case 5:
                        if (dataIn.Length == 4)
                        {
                            num1 = 7;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 8;
                        continue;
                    case 7:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.ThermalControl, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 0;
                        continue;
                    case 8:
                        goto label_26;
                    default:
                        goto label_2;
                }
            }
            label_10:
            try
            {
                label_12:
                byte[] bytes = A_0 as byte[];
                int num2 = 1;
                 XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            goto label_30;
                        case 1:
                            if (bytes.Length == 128)
                            {
                                num2 = 5;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 4;
                            continue;
                        case 2:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 7;
                            continue;
                        case 3:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("穔硖ᙘ\x2E5A⥜⽞ᑠᝢ䩤⍦\x0868Ὢ౬䁮㝰ቲᙴͶᙸॺѼ㱾\xEE80\xED82\xF184\xF586\xE688\xE78A", A_1), bytes);
                            num2 = 8;
                            continue;
                        case 4:
                        case 7:
                            num2 = 0;
                            continue;
                        case 5:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 6;
                            continue;
                        case 6:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 3;
                                continue;
                            }
                            goto case 4;
                        case 8:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 2;
                                continue;
                            }
                            goto case 4;
                        default:
                            goto label_12;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                goto label_30;
            }
            label_26:
            if (1 == 0)
                ;
            label_30:
            return enReturnCode;
        }

        private enReturnCode C(object A_0)
        {
            int A_1 = 1;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 3;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 1:
                    case 2:
                        goto label_29;
                    case 3:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 8;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 7;
                        continue;
                    case 4:
                        dataIn = A_0 as byte[];
                        num1 = 5;
                        continue;
                    case 5:
                        if (dataIn.Length == 4)
                        {
                            num1 = 6;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 0;
                        continue;
                    case 6:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.PostCodeError, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 1;
                        continue;
                    case 7:
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 2;
                            continue;
                        }
                        num1 = 4;
                        continue;
                    case 8:
                        goto label_10;
                    default:
                        goto label_2;
                }
            }
            label_10:
            try
            {
                label_12:
                byte[] bytes = A_0 as byte[];
                int num2 = 8;
                 XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            goto label_29;
                        case 1:
                        case 2:
                            num2 = 0;
                            continue;
                        case 3:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("框晈ъ㡌㭎\x2150♒\x2154硖\x1D58㩚⥜㹞习㍢\x0A64ᑦ\x1D68⡪ɬ୮ᑰ㙲ݴնᙸॺ", A_1), bytes);
                            num2 = 5;
                            continue;
                        case 4:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 7;
                            continue;
                        case 5:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 6;
                                continue;
                            }
                            goto case 1;
                        case 6:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 2;
                            continue;
                        case 7:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 3;
                                continue;
                            }
                            goto case 1;
                        case 8:
                            if (bytes.Length == 4)
                            {
                                num2 = 4;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 1;
                            continue;
                        default:
                            goto label_12;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_29:
            if (1 == 0)
                ;
            return enReturnCode;
        }

        private enReturnCode B(object A_0)
        {
            int A_1 = 17;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 6;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        goto label_10;
                    case 1:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.BatteryChargeControlOverride, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 4;
                        continue;
                    case 2:
                    case 3:
                    case 4:
                        goto label_30;
                    case 5:
                        dataIn = A_0 as byte[];
                        num1 = 7;
                        continue;
                    case 6:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 0;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 8;
                        continue;
                    case 7:
                        if (dataIn.Length == 4)
                        {
                            num1 = 1;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 2;
                        continue;
                    case 8:
                        if (1 == 0)
                            ;
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 3;
                            continue;
                        }
                        num1 = 5;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_10:
            try
            {
                label_12:
                byte[] bytes = A_0 as byte[];
                int num2 = 1;
                 XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                        case 5:
                            num2 = 3;
                            continue;
                        case 1:
                            if (bytes.Length == 4)
                            {
                                num2 = 2;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 5;
                            continue;
                        case 2:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 7;
                            continue;
                        case 3:
                            goto label_30;
                        case 4:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 6;
                                continue;
                            }
                            goto case 0;
                        case 6:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 0;
                            continue;
                        case 7:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 8;
                                continue;
                            }
                            goto case 0;
                        case 8:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("硖癘ᑚ⡜\x2B5Eᅠᙢᅤ䡦\x2D68੪ᥬ\x0E6E幰ㅲᑴͶ\x0D78Ṻོپ슀\xEB82\xE484\xF586\xEE88\xEE8A캌\xE08Eﾐ\xE792\xE794\xF896\xF598풚\xEB9C爵펠톢첤쎦첨", A_1), bytes);
                            num2 = 4;
                            continue;
                        default:
                            goto label_12;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_30:
            return enReturnCode;
        }

        private enReturnCode A(object A_0)
        {
            int A_1 = 7;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num1 = 1;
            WmiBIOSClient wmiBiosClient=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 3:
                    case 4:
                        goto label_30;
                    case 1:
                        if (this.Globalpolicy.AllowEmulation)
                        {
                            num1 = 8;
                            continue;
                        }
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 6;
                        continue;
                    case 2:
                        dataIn = A_0 as byte[];
                        num1 = 7;
                        continue;
                    case 5:
                        if (1 == 0)
                            ;
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enBIOSCommandTypes.ThermalDiagnostics, dataIn, 128U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 3;
                        continue;
                    case 6:
                        if (wmiBiosClient == null)
                        {
                            enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                            num1 = 4;
                            continue;
                        }
                        num1 = 2;
                        continue;
                    case 7:
                        if (dataIn.Length == 128)
                        {
                            num1 = 5;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_BIOS_INVALID_DATA_SIZE;
                        num1 = 0;
                        continue;
                    case 8:
                        goto label_11;
                    default:
                        goto label_2;
                }
            }
            label_11:
            try
            {
                label_13:
                byte[] bytes = A_0 as byte[];
                int num2 = 4;
                 XmlEdit xmlEdit=null;
                XmlDocument A_0_1=null;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            A_0_1 = (XmlDocument)null;
                            enReturnCode = this.B(out A_0_1);
                            num2 = 2;
                            continue;
                        case 1:
                            xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                            num2 = 7;
                            continue;
                        case 2:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 3;
                                continue;
                            }
                            goto case 7;
                        case 3:
                            xmlEdit = new XmlEdit(A_0_1);
                            enReturnCode = xmlEdit.SetBytes(Module.a("扌恎Ṑ♒\x2154❖ⱘ⽚牜᭞`ᝢѤ䡦㵨ͪ\x086Cᵮᱰቲᥴ㍶ၸ᩺᩼ᅾ\xEE80\xF082\xF184\xEE86\xEA88\xF88A", A_1), bytes);
                            num2 = 6;
                            continue;
                        case 4:
                            if (bytes.Length == 128)
                            {
                                num2 = 0;
                                continue;
                            }
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num2 = 8;
                            continue;
                        case 5:
                            goto label_30;
                        case 6:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num2 = 1;
                                continue;
                            }
                            goto case 7;
                        case 7:
                        case 8:
                            num2 = 5;
                            continue;
                        default:
                            goto label_13;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
            }
            label_30:
            return enReturnCode;
        }

        public enReturnCode SetDiagsXml(XmlDocument xdocDiags)
        {
            int A_1 = 10;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕㅗ㭙㭛ⵝ㡟ཡ\x0863", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 3;
            int index=0;
            byte[] numArray=null;
            XmlEdit xmlEdit = null;
            string[] strings1=null;
            string[] strings2=null;
            string string1=null;
            string string2=null;
            string string3=null;
            while (true)
            {
              
                switch (num1)
                {
                    case 0:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 30;
                        continue;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto label_67;
                    case 2:
                        num1 = 18;
                        continue;
                    case 3:
                        if (xdocDiags == null)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto case 30;
                    case 4:
                        if (index < strings1.Length)
                        {
                            try
                            {
                                label_22:
                                uint num2 = uint.Parse(strings1[index]);
                                uint num3 = uint.Parse(strings2[index]);
                                int num4 = 1;
                                while (true)
                                {
                                    switch (num4)
                                    {
                                        case 0:
                                            goto label_60;
                                        case 1:
                                            if (num2 < 2U)
                                            {
                                                num4 = 2;
                                                continue;
                                            }
                                            goto case 3;
                                        case 2:
                                            numArray[0] = (byte)num2;
                                            numArray[1] = (byte)num3;
                                            enReturnCode = this.A(Convert.ToUInt32((object)numArray));
                                            num4 = 3;
                                            continue;
                                        case 3:
                                            num4 = 0;
                                            continue;
                                        default:
                                            goto label_22;
                                    }
                                }
                            }
                            catch
                            {
                                enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            }
                            label_60:
                            ++index;
                            num1 = 24;
                            continue;
                        }
                        num1 = 26;
                        continue;
                    case 5:
                        string3 = xmlEdit.GetString(Module.a("罏絑\x1D53㡕⡗⽙⡛煝\x245F͡ၣݥ䝧⡩╫Ⅽ⍯❱ѳት\x1977\x0E79\x197B\x2D7D\xF47F\xE381\xF083\xF385ﮇ", A_1));
                        num1 = 9;
                        continue;
                    case 6:
                        string1 = xmlEdit.GetString(Module.a("罏絑\x1D53㡕⡗⽙⡛煝\x245F͡ၣݥ䝧㵩൫ᱭɯ\x1371ᩳɵŷ", A_1));
                        num1 = 25;
                        continue;
                    case 7:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 16;
                            continue;
                        }
                        goto case 33;
                    case 8:
                        if (strings1 != null)
                        {
                            num1 = 11;
                            continue;
                        }
                        goto label_67;
                    case 9:
                        if (string3 != null)
                        {
                            num1 = 27;
                            continue;
                        }
                        break;
                    case 10:
                        try
                        {
                            enReturnCode = this.SetDiagsLaunchCommandStatus(Convert.ToUInt32(string2));
                            goto label_8;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            goto label_8;
                        }
                    case 11:
                        num1 = 31;
                        continue;
                    case 12:
                        if (strings1.Length == strings2.Length)
                        {
                            num1 = 28;
                            continue;
                        }
                        goto label_67;
                    case 13:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_67;
                    case 14:
                        goto label_11;
                    case 15:
                        numArray = new byte[4];
                        strings1 = xmlEdit.GetStrings(Module.a("罏őㅓ≕᱗㍙㵛㥝፟♡գብ१⍩ɫṭկٱ孳㽵ᙷ\x0A79ॻ\x0A7D꽿욁\xE583\xF285\xE987ꖉ캋\xEF8D\xE48F\xE691\xF193\xE495\xE197\xD999\xF49Bﾝ튟얡솣\xE5A5잧쒩\xD8AB\xDCAD\xDFAF\xDEB1鮳\xF4B5\xD9B7캹좻\xDBBD늿믁\xEBC3迅곇", A_1));
                        strings2 = xmlEdit.GetStrings(Module.a("罏őㅓ≕᱗㍙㵛㥝፟♡գብ१⍩ɫṭկٱ孳㽵ᙷ\x0A79ॻ\x0A7D꽿욁\xE583\xF285\xE987ꖉ캋\xEF8D\xE48F\xE691\xF193\xE495\xE197\xD999\xF49Bﾝ튟얡솣\xE5A5잧쒩\xD8AB\xDCAD\xDFAF\xDEB1鮳\xF4B5\xD9B7캹좻\xDBBD늿믁\xEBC3闅볇ꯉ룋ꯍ", A_1));
                        num1 = 8;
                        continue;
                    case 16:
                        enReturnCode = new XmlTools().Validate(xdocDiags.InnerXml, Resources.hpCASL);
                        num1 = 33;
                        continue;
                    case 17:
                        if (xmlEdit != null)
                        {
                            num1 = 6;
                            continue;
                        }
                        goto case 29;
                    case 18:
                        if (this.A1)
                        {
                            num1 = 14;
                            continue;
                        }
                        xmlEdit = new XmlEdit(xdocDiags);
                        num1 = 17;
                        continue;
                    case 19:
                        enReturnCode = this.A(Convert.ToDateTime(string1));
                        num1 = 29;
                        continue;
                    case 20:
                        if (string2 != null)
                        {
                            if (1 == 0)
                                ;
                            num1 = 10;
                            continue;
                        }
                        goto label_8;
                    case 21:
                        string2 = xmlEdit.GetString(Module.a("罏絑\x1D53㡕⡗⽙⡛煝\x245F͡ၣݥ䝧\x2E69ի\x0F6Dᝯű㡳\x1775\x0D77ᑹύᙽ썿\xED81\xE983\xEB85\xE987\xE489\xE88B\xDD8D\xE48F\xF391\xE093\xE395\xEB97", A_1));
                        num1 = 20;
                        continue;
                    case 22:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 21;
                            continue;
                        }
                        goto label_8;
                    case 23:
                    case 24:
                        num1 = 4;
                        continue;
                    case 25:
                        if (string1 != null)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 29;
                    case 26:
                        goto label_67;
                    case 27:
                        try
                        {
                            enReturnCode = this.SetBIOSUpdateStatusCommand(Convert.ToUInt32(string3));
                            break;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            break;
                        }
                    case 28:
                        index = 0;
                        num1 = 23;
                        continue;
                    case 29:
                        num1 = 22;
                        continue;
                    case 30:
                        num1 = 7;
                        continue;
                    case 31:
                        if (strings2 != null)
                        {
                            num1 = 32;
                            continue;
                        }
                        goto label_67;
                    case 32:
                        num1 = 12;
                        continue;
                    case 33:
                        num1 = 1;
                        continue;
                    case 34:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 5;
                            continue;
                        }
                        break;
                    default:
                        goto label_2;
                }
                num1 = 13;
                continue;
                label_8:
                num1 = 34;
            }
            label_11:
            try
            {
                xdocDiags.Save(this.DiagsEmulationFile);
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                this.log.ErrorMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕㅗ㭙㭛ⵝ㡟ཡ\x0863", A_1), Module.a("ᕏ⩑㝓㍕⡗\x2E59㕛ㅝ\x0E5F䉡գብᱧཀྵūṭѯ᭱ᩳᅵ塷\x0E79\x137B幽\xF37F\xE381\xF283\xE385ꢇ\xEF89\xE18Bﮍﲏ\xF391\xE093ﾕ\xF797\xF499벛\xF89D즟캡솣鲥袧", A_1) + ex.Message);
            }
            label_67:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕㅗ㭙㭛ⵝ㡟ཡ\x0863", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ噫乭", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode A(DateTime A_0)
        {
            int A_1 = 1;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
            enReturnCode enReturnCode1 = enReturnCode.e_OK;
            int num = 35;
            WmiBIOSClient A_3 = null;
            int year1=0;
            int month1=0;
            int day1=0;
            string sText=null;
            int index=0;
            int year2=0;
            int month2=0;
            int day2=0;
            string str=null;
            XmlDocument xdocDiags=null;
            byte[] dataIn=null;
            enReturnCode enReturnCode2=0;
            while (true)
            {
               
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        enReturnCode1 = this.A(year2, month2, day2, A_3);
                        num = 11;
                        continue;
                    case 1:
                        if (year1 <= 2099)
                        {
                            num = 4;
                            continue;
                        }
                        goto label_24;
                    case 2:
                        if (enWarrantySize.eFive_5 == this.WarrantySize)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_60;
                    case 3:
                    case 30:
                    case 36:
                        num = 38;
                        continue;
                    case 4:
                        sText = (year1 % 100).ToString(Module.a("͆筈", A_1)) + month1.ToString(Module.a("͆筈", A_1)) + day1.ToString(Module.a("͆筈", A_1));
                        num = 3;
                        continue;
                    case 5:
                    case 19:
                    case 24:
                        num = 12;
                        continue;
                    case 6:
                        if (A_3 != null)
                        {
                            num = 8;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("၆⑈≊ཌَṐRᙔ㭖じ㹚㍜\x2B5E䅠\x0A62\x0B64ᑦ\x1D68੪ͬ᭮ᡰቲŴṶᙸᕺ嵼ൾ\xE480\xF782\xF084\xF586\xE788\xEE8A\xE98C꾎ﾐ\xE692璉ﮖ", A_1));
                        enReturnCode1 = enReturnCode.e_NULL_VALUE;
                        num = 44;
                        continue;
                    case 7:
                        this.WarrantySize = enWarrantySize.eFive_5;
                        num = 34;
                        continue;
                    case 8:
                        byte[] dataOut = (byte[])null;
                        enReturnCode1 = A_3.ExecMethodClient(enBIOSCommands.Write, enReadCmdType.WarrantyStartDate, dataIn, (uint)this.WarrantyDateLength, out dataOut, enSizeOut.eSIZE_0);
                        this.log.InformationMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("ن⽈㽊⡌㵎煐㩒㭔㹖ⵘ\x325A㱜㍞䅠ⅢⱤ⡦㩨䭪Ṭ੮հ彲啴ቶ\x2B78Ṻॼ㱾\xEE80\xE782\xE084붆ꦈ", A_1) + enReturnCode1.ToString());
                        num = 32;
                        continue;
                    case 9:
                        if (year2 >= 2000)
                        {
                            num = 27;
                            continue;
                        }
                        break;
                    case 10:
                        str = (A_0.Year % 100).ToString(Module.a("͆筈", A_1)) + A_0.Month.ToString(Module.a("͆筈", A_1)) + A_0.Day.ToString(Module.a("͆筈", A_1));
                        num = 5;
                        continue;
                    case 11:
                    case 26:
                    case 44:
                        goto label_60;
                    case 12:
                        if (enReturnCode1 == enReturnCode.e_OK)
                        {
                            num = 13;
                            continue;
                        }
                        goto label_60;
                    case 13:
                        index = 0;
                        num = 15;
                        continue;
                    case 14:
                        if (enWarrantySize.eFive_5 == this.WarrantySize)
                        {
                            num = 16;
                            continue;
                        }
                        goto case 21;
                    case 15:
                    case 33:
                        num = 40;
                        continue;
                    case 16:
                        enReturnCode1 = enReturnCode.e_OK;
                        num = 21;
                        continue;
                    case 17:
                        num = !this.B8DigitWarrantyDate ? 9 : 29;
                        continue;
                    case 18:
                        if (year1 >= 2000)
                        {
                            num = 20;
                            continue;
                        }
                        goto label_24;
                    case 20:
                        num = 1;
                        continue;
                    case 21:
                        num = 2;
                        continue;
                    case 22:
                        sText = year1.ToString(Module.a("͆筈", A_1)) + month1.ToString(Module.a("͆筈", A_1)) + day1.ToString(Module.a("͆筈", A_1));
                        num = 36;
                        continue;
                    case 23:
                        XmlEdit xmlEdit = new XmlEdit(xdocDiags);
                        xmlEdit.SetString(Module.a("框晈ъ㡌㭎\x2150♒\x2154硖\x1D58㩚⥜㹞习㑢Ѥᕦ᭨੪ͬ᭮\x0870", A_1), sText);
                        xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                        num = 26;
                        continue;
                    case 25:
                        sText = (string)null;
                        year1 = A_0.Year;
                        month1 = A_0.Month;
                        day1 = A_0.Day;
                        num = 41;
                        continue;
                    case 27:
                        num = 37;
                        continue;
                    case 28:
                        A_3 = new WmiBIOSClient();
                        num = 6;
                        continue;
                    case 29:
                        str = year2.ToString(Module.a("͆筈", A_1)) + month2.ToString(Module.a("͆筈", A_1)) + day2.ToString(Module.a("͆筈", A_1));
                        num = 19;
                        continue;
                    case 31:
                        xdocDiags = new XmlDocument();
                        enReturnCode1 = this.GetDiagsXml(ref xdocDiags);
                        num = 39;
                        continue;
                    case 32:
                        if (!this.B8DigitWarrantyDate)
                        {
                            num = 43;
                            continue;
                        }
                        goto case 21;
                    case 34:
                        num = 14;
                        continue;
                    case 35:
                        if (this.A1)
                        {
                            num = 31;
                            continue;
                        }
                        dataIn = new byte[this.WarrantyDateLength];
                        str = (string)null;
                        year2 = A_0.Year;
                        month2 = A_0.Month;
                        day2 = A_0.Day;
                        num = 17;
                        continue;
                    case 37:
                        if (year2 <= 2099)
                        {
                            num = 10;
                            continue;
                        }
                        break;
                    case 38:
                        if (enReturnCode1 == enReturnCode.e_OK)
                        {
                            num = 23;
                            continue;
                        }
                        goto label_60;
                    case 39:
                        if (enReturnCode1 == enReturnCode.e_OK)
                        {
                            num = 25;
                            continue;
                        }
                        goto label_60;
                    case 40:
                        if (index >= this.WarrantyDateLength)
                        {
                            num = 28;
                            continue;
                        }
                        dataIn[index] = (byte)str[index];
                        ++index;
                        num = 33;
                        continue;
                    case 41:
                        num = !this.B8DigitWarrantyDate ? 18 : 22;
                        continue;
                    case 42:
                        if (enReturnCode.e_VALUE_OUT_OF_RANGE == enReturnCode2)
                        {
                            num = 7;
                            continue;
                        }
                        goto case 34;
                    case 43:
                        DateTime A_0_1 = new DateTime();
                        enReturnCode2 = this.A(ref A_0_1);
                        num = 42;
                        continue;
                    default:
                        goto label_2;
                }
                enReturnCode1 = enReturnCode.e_VALUE_OUT_OF_RANGE;
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("ፆⅈ≊㹌潎≐⩒♔⍖㱘㙚絜㱞`ൢ䕤\x0866ݨݪᑬ佮ᥰቲ᭴\x1376ᕸṺ嵼䵾검\xE782\xEC84\xE086\xE088ﾊ권\xF68E\xF490\xF292\xE794\xE496떘뮚\xEA9C\xF79E좠삢춤螦쒨\xDEAA\xDEAC\xDBAE醰톲킴鞶\xDBB8\xDEBA즼좾꓀ꛂꯄ\xE7C6\xFBC8\xFBCA\xFDCCￎ\xF1D0닒믔돖律\xE9DA\xEDDC\xE6DE\xD8E0췢엤쟦냨軪賬鷮퇰菲铴蓶諸黺駼\xDFFE栀洂┄昆稈⬊瘌㼎氐㴒", A_1), (object)year2);
                num = 24;
                continue;
                label_24:
                enReturnCode1 = enReturnCode.e_VALUE_OUT_OF_RANGE;
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("ፆⅈ≊㹌潎≐⩒♔⍖㱘㙚絜㱞`ൢ䕤\x0866ݨݪᑬ佮ᥰቲ᭴\x1376ᕸṺ嵼䵾검\xE782\xEC84\xE086\xE088ﾊ권\xF68E\xF490\xF292\xE794\xE496떘뮚\xEA9C\xF79E좠삢춤螦쒨\xDEAA\xDEAC\xDBAE醰톲킴鞶\xDBB8\xDEBA즼좾꓀ꛂꯄ\xE7C6\xFBC8\xFBCA\xFDCCￎ\xF1D0닒믔돖律\xE9DA\xEDDC\xE6DE\xD8E0췢엤쟦냨軪賬鷮퇰菲铴蓶諸黺駼\xDFFE栀洂┄昆稈⬊瘌㼎氐㴒", A_1), (object)year1);
                num = 30;
            }
            label_60:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊ᩌ\x2E4E⍐\x2152㑔㥖ⵘ≚", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object)enReturnCode1.ToString());
            return enReturnCode1;
        }

        private enReturnCode A(int A_0, int A_1, int A_2, WmiBIOSClient A_3)
        {
            int A_1_1 = 15;
            label_2:
            byte[] dataOut = (byte[])null;
            enReturnCode enReturnCode = enReturnCode.e_OK;
            string str = string.Empty;
            int num = 18;
            byte[] dataIn=null;
            int index=0;
            DateTime A_0_1=DateTime.Now;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 5:
                        num = 17;
                        continue;
                    case 1:
                    case 6:
                        goto label_29;
                    case 2:
                        num = 0;
                        continue;
                    case 3:
                        A_0_1 = new DateTime();
                        num = 9;
                        continue;
                    case 4:
                    case 12:
                        num = 14;
                        continue;
                    case 7:
                        if (!this.B8DigitWarrantyDate)
                        {
                            num = 3;
                            continue;
                        }
                        goto label_29;
                    case 8:
                    case 16:
                        num = 13;
                        continue;
                    case 9:
                        if (enWarrantySize.eNotSet_0 == this.WarrantySize)
                        {
                            num = 19;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_OK;
                        num = 12;
                        continue;
                    case 10:
                        num = 7;
                        continue;
                    case 11:
                        dataOut = (byte[])null;
                        enReturnCode = A_3.ExecMethodClient(enBIOSCommands.Write, enReadCmdType.WarrantyStartDate, dataIn, (uint)this.WarrantyDateLength, out dataOut, enSizeOut.eSIZE_0);
                        this.log.InformationMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x1D5A㑜⥞Ѡ❢\x0C64fhὪ㩬\x0E6EͰŲᑴ\x1976\x0D78ɺ㥼Ṿ\xF580\xE682", A_1_1), Module.a("ᑔㅖⵘ㹚⽜罞❠⩢㍤≦䑨⽪\x246C⡮㡰❲啴㕶へ㑺\x2E7C彾\xF280\xE682\xF184\xAB86ꦈ\xEE8A\xDF8C\xEA8E\xE590킒杖\xF396ﲘꆚ붜", A_1_1) + enReturnCode.ToString());
                        num = 6;
                        continue;
                    case 13:
                        if (index < str.Length)
                        {
                            dataIn[index] = (byte)str[index];
                            ++index;
                            num = 8;
                            continue;
                        }
                        num = 2;
                        continue;
                    case 14:
                        if (enWarrantySize.eFive_5 == this.WarrantySize)
                        {
                            num = 15;
                            continue;
                        }
                        goto label_29;
                    case 15:
                        dataIn = new byte[this.WarrantyDateLength];
                        str = A_1.ToString(Module.a("ᅔ敖", A_1_1)) + A_2.ToString(Module.a("ᅔ敖", A_1_1)) + (A_0 % 10).ToString(Module.a("ᅔ晖", A_1_1));
                        index = 0;
                        num = 16;
                        continue;
                    case 17:
                        if (index < this.WarrantyDateLength)
                        {
                            if (1 == 0)
                                ;
                            dataIn[index] = (byte)0;
                            ++index;
                            num = 5;
                            continue;
                        }
                        num = 11;
                        continue;
                    case 18:
                        if (A_3 != null)
                        {
                            num = 10;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x1D5A㑜⥞Ѡ❢\x0C64fhὪ㩬\x0E6EͰŲᑴ\x1976\x0D78ɺ㥼Ṿ\xF580\xE682", A_1_1), Module.a("᭔ɖᕘ\x175A絜⡞ౠ\x0A62❤\x2E66♨㡪䵬n\x1370ᥲၴᑶ\x0D78", A_1_1));
                        num = 1;
                        continue;
                    case 19:
                        enReturnCode = this.A(ref A_0_1);
                        num = 4;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_29:
            return enReturnCode;
        }

        private enReturnCode SetDiagsLaunchCommandStatus(uint uiSetDiagsLaunchCommandStatus)
        {
            int A_1 = 16;
            label_2:
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Օ㵗\x2E59ᡛ㝝şաᝣ⩥१Ὡɫ൭ᡯㅱ᭳᭵ᕷ᭹ቻ\x1A7D퍿\xF681\xE583\xF285ﶇ黎", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١䑣ᅥŧṩѫ乭", A_1) + uiSetDiagsLaunchCommandStatus.ToString());
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 9;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument xdocDiags=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        xdocDiags = new XmlDocument();
                        enReturnCode = this.GetDiagsXml(ref xdocDiags);
                        num1 = 5;
                        continue;
                    case 1:
                    case 2:
                    case 4:
                        goto label_27;
                    case 3:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetSystemDiagnosticLaunchCommand, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 2;
                        continue;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 7;
                            continue;
                        }
                        goto label_27;
                    case 6:
                        try
                        {
                            label_20:
                            dataIn = BitConverter.GetBytes(uiSetDiagsLaunchCommandStatus);
                            int num2 = 2;
                            while (true)
                            {
                                switch (num2)
                                {
                                    case 0:
                                        goto label_14;
                                    case 1:
                                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                                        num2 = 3;
                                        continue;
                                    case 2:
                                        if (dataIn.Length != 4)
                                        {
                                            num2 = 1;
                                            continue;
                                        }
                                        goto case 3;
                                    case 3:
                                        num2 = 0;
                                        continue;
                                    default:
                                        goto label_20;
                                }
                            }
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        label_14:
                        num1 = 8;
                        continue;
                    case 7:
                        XmlEdit xmlEdit = new XmlEdit(xdocDiags);
                        xmlEdit.SetUInt32(Module.a("祕睗ᕙ⥛⩝ၟᝡၣ䥥Ⱨ୩ᡫ\x0F6D彯㙱ᵳ\x1775ίॹほώ\xF57F\xEC81\xE783\xEE85쮇\xE589\xE18B\xE38D\xF18Fﲑ\xF093얕\xEC97ﮙ\xE89B\xEB9D펟", A_1), uiSetDiagsLaunchCommandStatus);
                        xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                        num1 = 4;
                        continue;
                    case 8:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 11;
                            continue;
                        }
                        goto label_27;
                    case 9:
                        if (this.A1)
                        {
                            num1 = 0;
                            continue;
                        }
                        dataIn = (byte[])null;
                        num1 = 6;
                        continue;
                    case 10:
                        if (wmiBiosClient != null)
                        {
                            num1 = 3;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("Օ㵗\x2E59ᡛ㝝şաᝣ⩥१Ὡɫ൭ᡯㅱ᭳᭵ᕷ᭹ቻ\x1A7D퍿\xF681\xE583\xF285ﶇ黎", A_1), Module.a("ŕ㕗㍙ṛ\x175D⽟ㅡ❣\x0A65ŧཀྵɫᩭ偯᭱ᩳյ\x0C77᭹ቻ\x0A7D\xE97F\xE381\xF083\xEF85\xE787\xE489겋ﲍ\xF58F\xE691\xE193\xE495\xF697ﾙ\xF89B뺝캟힡좣쪥", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num1 = 1;
                        continue;
                    case 11:
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 10;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_27:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Օ㵗\x2E59ᡛ㝝şաᝣ⩥१Ὡɫ൭ᡯㅱ᭳᭵ᕷ᭹ቻ\x1A7D퍿\xF681\xE583\xF285ﶇ黎", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ剱ཱི䙵շ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetBIOSUpdateStatusCommand(uint uiSetBIOSUpdateStatusCommand)
        {
            int A_1 = 12;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("őㅓ≕ᩗፙ\x135B\x0D5D㕟ቡcݥᱧཀྵ㽫ᩭᅯٱųյ㭷ᕹᅻ\x137D\xE17F\xEC81\xE083", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝䁟ᕡൣብg䩩", A_1) + uiSetBIOSUpdateStatusCommand.ToString());
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 1;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument xdocDiags=null;
            byte[] dataIn=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 4;
                            continue;
                        }
                        goto label_27;
                    case 1:
                        if (this.A1)
                        {
                            num1 = 8;
                            continue;
                        }
                        dataIn = (byte[])null;
                        num1 = 11;
                        continue;
                    case 2:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetBIOSUpdateStatusCommand, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 6;
                        continue;
                    case 3:
                        if (1 == 0)
                            ;
                        XmlEdit xmlEdit = new XmlEdit(xdocDiags);
                        xmlEdit.SetUInt32(Module.a("絑筓ᥕⵗ\x2E59ⱛ\x2B5Dᑟ䵡\x2063ݥᱧ୩䍫Ɑ㥯㵱❳⍵\x0877ṹᵻ\x0A7D\xE57F톁\xF083\xE785ﲇﾉﾋ", A_1), uiSetBIOSUpdateStatusCommand);
                        xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                        num1 = 10;
                        continue;
                    case 4:
                        wmiBiosClient = new WmiBIOSClient();
                        num1 = 5;
                        continue;
                    case 5:
                        if (wmiBiosClient != null)
                        {
                            num1 = 2;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("őㅓ≕ᩗፙ\x135B\x0D5D㕟ቡcݥᱧཀྵ㽫ᩭᅯٱųյ㭷ᕹᅻ\x137D\xE17F\xEC81\xE083", A_1), Module.a("Ց㥓㽕ᩗፙ\x135B\x0D5D⍟\x0E61ൣͥ٧ṩ䱫ݭṯűs\x1775ᙷ\x0E79ᕻώ\xF47F\xEB81\xEB83\xE885ꢇ\xF889\xE98B揄\xE58F\xE091望\xF395ﲗ몙\xF29B\xEB9D첟캡", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num1 = 7;
                        continue;
                    case 6:
                    case 7:
                    case 10:
                        goto label_27;
                    case 8:
                        xdocDiags = new XmlDocument();
                        enReturnCode = this.GetDiagsXml(ref xdocDiags);
                        num1 = 9;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 3;
                            continue;
                        }
                        goto label_27;
                    case 11:
                        try
                        {
                            label_20:
                            dataIn = BitConverter.GetBytes(uiSetBIOSUpdateStatusCommand);
                            int num2 = 1;
                            while (true)
                            {
                                switch (num2)
                                {
                                    case 0:
                                        num2 = 3;
                                        continue;
                                    case 1:
                                        if (dataIn.Length != 4)
                                        {
                                            num2 = 2;
                                            continue;
                                        }
                                        goto case 0;
                                    case 2:
                                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                                        num2 = 0;
                                        continue;
                                    case 3:
                                        goto label_14;
                                    default:
                                        goto label_20;
                                }
                            }
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        label_14:
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_27:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("őㅓ≕ᩗፙ\x135B\x0D5D㕟ቡcݥᱧཀྵ㽫ᩭᅯٱųյ㭷ᕹᅻ\x137D\xE17F\xEC81\xE083", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode A(uint A_0)
        {
            int A_1 = 17;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("і㱘⽚\x1F5C㹞ᕠᝢdᕦၨ⡪լ\x0E6EͰᑲၴ㑶ᙸᕺॼൾ\xEE80\xEF82", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ䕤ၦhὪլ佮", A_1) + A_0.ToString());
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] bytes = BitConverter.GetBytes(A_0);
            int num1 = 3;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument xdocDiags=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 7:
                    case 12:
                        goto label_22;
                    case 1:
                        if (!this.A1)
                        {
                            wmiBiosClient = new WmiBIOSClient();
                            num1 = 8;
                            continue;
                        }
                        num1 = 6;
                        continue;
                    case 2:
                        byte num2 = bytes[0];
                        byte nValue = bytes[1];
                        XmlEdit xmlEdit = new XmlEdit(xdocDiags);
                        string sNode = string.Format(Module.a("硖癘ᑚ⡜\x2B5Eᅠᙢᅤ䡦\x2D68੪ᥬ\x0E6E幰ㅲᑴͶ\x0D78Ṻོپ슀\xEB82\xE484\xF586\xEE88\xEE8A캌\xE08Eﾐ\xE792\xE794\xF896\xF598뒚\xDF9Cﺞ햠힢삤햦킨蒪ﺬ\xDBAE킰잲킴\xECB6鞸閺銼\xF6BEꗀﻂ\xE2C4볆杻뛊\xEACC鋎", A_1), (object)num2);
                        xmlEdit.SetByte(sNode, nValue);
                        xmlEdit.XmlDoc.Save(this.DiagsEmulationFile);
                        num1 = 7;
                        continue;
                    case 3:
                        if (bytes.Length != 4)
                        {
                            num1 = 13;
                            continue;
                        }
                        goto case 9;
                    case 4:
                        byte[] dataOut = (byte[])null;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.BatteryChargeControl, bytes, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num1 = 0;
                        continue;
                    case 5:
                        num1 = 1;
                        continue;
                    case 6:
                        xdocDiags = new XmlDocument();
                        enReturnCode = this.GetDiagsXml(ref xdocDiags);
                        num1 = 10;
                        continue;
                    case 8:
                        if (1 == 0)
                            ;
                        if (wmiBiosClient != null)
                        {
                            num1 = 4;
                            continue;
                        }
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("і㱘⽚\x1F5C㹞ᕠᝢdᕦၨ⡪լ\x0E6EͰᑲၴ㑶ᙸᕺॼൾ\xEE80\xEF82", A_1), Module.a("V㑘\x325A\x1F5Cᙞ\x2E60ぢ♤୦h\x0E6Aͬ᭮兰ᩲ᭴Ѷ\x0D78᩺\x137C\x0B7E\xE880\xE282\xF184\xEE86\xE688\xE58A권ﶎ\xF490\xE792\xE094\xE596\xF798ﺚ列뾞쾠횢즤쮦", A_1));
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num1 = 12;
                        continue;
                    case 9:
                        num1 = 11;
                        continue;
                    case 10:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto label_22;
                    case 11:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto label_22;
                    case 13:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 9;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_22:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("і㱘⽚\x1F5C㹞ᕠᝢdᕦၨ⡪լ\x0E6EͰᑲၴ㑶ᙸᕺॼൾ\xEE80\xEF82", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ卲\x0E74䝶Ѹ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        protected override void InitPropertySetList()
        {
            int A_1 = 14;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1D53㡕ㅗ\x2E59\x0C5Bⱝཟቡţᑥᱧ\x1369㽫୭ѯ㹱ᵳյ\x0C77", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ", A_1));
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        if (enReturnCode.e_NULL_VALUE == this.E1)
                        {
                            if (1 == 0)
                                ;
                            num = 2;
                            continue;
                        }
                        goto label_7;
                    case 2:
                        this.E1 = this.Initialize();
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_7:
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝㝟͡ᙣᑥ१ѩᡫ\x176D", A_1), typeof(DateTime), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝\x2C5F͡ᅣ\x0865୧ɩ⽫ŭᵯάᕳᡵᱷ⥹\x087Bώ\xF47F\xF781\xF783", A_1), typeof(uint), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝≟\x2B61\x2B63㕥㵧ᩩ\x086B\x0F6Dѯ\x1771❳ɵ\x1977\x0E79ॻൽ", A_1), typeof(uint), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝≟͡ၣብ൧ᡩᕫ\x2D6Dᡯ\x1371ٳᅵᵷ㥹\x137Bၽ\xF47F\xF081\xEB83\xEA85", A_1), typeof(uint), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝\x245Fݡባཥ୧ཀྵ⩫ݭɯάͳ\x1775\x0A77ό⥻\x0E7D\xE47F\xE381\xF083\xE385\xDB87ﺉ\xED8B揄\xE58F\xE191", A_1), typeof(byte[]), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝㑟\x0A61ţᑥէ୩k⩭\x196F\x1371\x1373ᡵ\x1777ॹ\x087B\x177D\xE37F\xF181", A_1), typeof(byte[]), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝たൡᝣብ\x2B67թ\x086B୭㕯qٳ\x1975\x0A77", A_1), typeof(byte[]), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝♟͡ݣብݧᡩᕫ\x2D6DὯᱱsѵ\x1777ᙹ", A_1), typeof(byte[]), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝≟͡ၣብ൧ᡩᕫ\x2D6Dᡯ\x1371ٳᅵᵷ㥹\x137Bၽ\xF47F\xF081\xEB83\xEA85잇ﲉ\xE98Bﲍ\xE28Fﮑ\xF093\xF395", A_1), typeof(byte[]), this.G1, true));
            this.propertySetList.Add(new Command.Property(Module.a("ၓ㽕㥗㵙⽛灝㑟\x0A61ţᑥէ୩k\x2D6DὯᱱsѵ\x1777ᙹ", A_1), typeof(byte[]), this.G1, true));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("\x1D53㡕ㅗ\x2E59\x0C5Bⱝཟቡţᑥᱧ\x1369㽫୭ѯ㹱ᵳյ\x0C77", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc", A_1));
        }

        private enReturnCode A(object A_0, out object A_1)
        {
            int A_1_1 = 0;
            label_2:
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            A_1 = (object)null;
            int num = 20;
            int index=0;
            byte[] bytes=null;
             XmlEdit xmlEdit=null;
            string sNode=null;
            byte[] dataOut=null;
            WmiBIOSClient wmiBiosClient=null;
            XmlDocument A_0_1=null;
            byte[] dataIn=null;
            string str1=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        enReturnCode = enReturnCode.e_OUT_OF_MEMORY;
                        num = 21;
                        continue;
                    case 1:
                    case 14:
                    case 18:
                    case 29:
                        num = 9;
                        continue;
                    case 2:
                        if (bytes.Length == 128)
                        {
                            num = 28;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 22;
                        continue;
                    case 3:
                        enReturnCode = xmlEdit.SetBytes(sNode, bytes);
                        num = 7;
                        continue;
                    case 4:
                        if (index < 128)
                        {
                            bytes[index] = (byte)0;
                            ++index;
                            num = 35;
                            continue;
                        }
                        num = 3;
                        continue;
                    case 5:
                    case 7:
                    case 11:
                    case 19:
                    case 21:
                    case 22:
                    case 37:
                        goto label_51;
                    case 6:
                        if (wmiBiosClient != null)
                        {
                            num = 16;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 37;
                        continue;
                    case 8:
                        if (xmlEdit == null)
                        {
                            num = 27;
                            continue;
                        }
                        sNode = Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟㙡ౣͥᩧݩ൫ɭ㑯᭱ᕳᅵᙷᕹཻ\x0A7D\xE97F\xE181\xF783ꦅ", A_1_1) + str1;
                        bytes = xmlEdit.GetBytes(sNode);
                        num = 26;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 30;
                            continue;
                        }
                        goto label_51;
                    case 10:
                        enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                        num = 29;
                        continue;
                    case 12:
                        if (bytes != null)
                        {
                            index = 0;
                            num = 33;
                            continue;
                        }
                        num = 0;
                        continue;
                    case 13:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 34;
                            continue;
                        }
                        goto label_51;
                    case 15:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 18;
                        continue;
                    case 16:
                        dataOut = new byte[128];
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enBIOSCommandTypes.ThermalDiagnostics, dataIn, 4U, out dataOut, enSizeOut.eSIZE_128);
                        num = 31;
                        continue;
                    case 17:
                        if (!this.Globalpolicy.AllowEmulation)
                        {
                            wmiBiosClient = new WmiBIOSClient();
                            num = 6;
                            continue;
                        }
                        num = 32;
                        continue;
                    case 20:
                        num = A_0 != null ? 38 : 25;
                        continue;
                    case 23:
                        if (1 == 0)
                            ;
                        if (((byte[])A_0).Length == 4)
                        {
                            enReturnCode = enReturnCode.e_OK;
                            num = 1;
                            continue;
                        }
                        num = 10;
                        continue;
                    case 24:
                        A_1 = (object)dataOut;
                        num = 5;
                        continue;
                    case 25:
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        num = 14;
                        continue;
                    case 26:
                        if (bytes != null)
                        {
                            num = 36;
                            continue;
                        }
                        bytes = new byte[128];
                        num = 12;
                        continue;
                    case 27:
                        enReturnCode = enReturnCode.e_OUT_OF_MEMORY;
                        num = 19;
                        continue;
                    case 28:
                        A_1 = (object)bytes;
                        num = 11;
                        continue;
                    case 30:
                        dataIn = (byte[])A_0;
                        string str2 = dataIn[0].ToString(Module.a("ṅ", A_1_1));
                        str1 = Module.a("癅ぇ", A_1_1) + str2;
                        num = 17;
                        continue;
                    case 31:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 24;
                            continue;
                        }
                        goto label_51;
                    case 32:
                        A_0_1 = (XmlDocument)null;
                        enReturnCode = this.B(out A_0_1);
                        num = 13;
                        continue;
                    case 33:
                    case 35:
                        num = 4;
                        continue;
                    case 34:
                        xmlEdit = new XmlEdit(A_0_1);
                        num = 8;
                        continue;
                    case 36:
                        num = 2;
                        continue;
                    case 38:
                        num = A_0.GetType() == typeof(byte[]) ? 23 : 15;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_51:
            return enReturnCode;
        }

        private enReturnCode DiagsExecute(string sCommandName, object dataIn, out object dataOut)
        {
            int A_1 = 1;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("͆⁈⩊⩌㱎ᑐ⭒ご㑖ⱘ⽚㡜", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            dataOut = (object)null;
            int num = 5;
            string str=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                    case 11:
                    case 13:
                    case 17:
                        goto label_25;
                    case 2:
                        if (Utility.AddMethod(Module.a("͆⁈⩊⩌㱎ᑐ⭒ご㑖ⱘ⽚㡜", A_1), MethodBase.GetCurrentMethod().Name.ToString()))
                        {
                            enReturnCode = enReturnCode.e_OK;
                            num = 1;
                            continue;
                        }
                        num = 15;
                        continue;
                    case 3:
                        enReturnCode = enReturnCode.e_MISSING_COMPONENT;
                        num = 11;
                        continue;
                    case 4:
                        if (Utility.AddMethod(Module.a("͆⁈⩊⩌㱎ᑐ⭒ご㑖ⱘ⽚㡜", A_1), Module.a("͆⁈⩊⩌㱎ᑐ⭒ご㑖ⱘ⽚㡜", A_1)))
                        {
                            if (1 == 0)
                                ;
                            enReturnCode = enReturnCode.e_OK;
                            num = 13;
                            continue;
                        }
                        num = 3;
                        continue;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 12;
                            continue;
                        }
                        goto label_25;
                    case 6:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 17;
                        continue;
                    case 7:
                        num = 10;
                        continue;
                    case 8:
                        if ((str = sCommandName) != null)
                        {
                            num = 9;
                            continue;
                        }
                        goto case 6;
                    case 9:
                        num = 16;
                        continue;
                    case 10:
                        if (str == Module.a("͆⁈⩊⩌㱎罐ݒ㵔\x3256⭘㙚㱜㍞╠\x0A62ѤfݨѪṬ᭮ᡰၲٴ", A_1))
                        {
                            enReturnCode = this.A(dataIn, out dataOut);
                            num = 0;
                            continue;
                        }
                        num = 14;
                        continue;
                    case 12:
                        num = 8;
                        continue;
                    case 14:
                        num = 6;
                        continue;
                    case 15:
                        num = 4;
                        continue;
                    case 16:
                        num = str == Module.a("ц⡈㡊⅌ᡎ㱐㩒答ၖ㱘㕚㡜ⵞ`ᝢd⩦౨Ὢլnᕰ⍲ᩴṶ\x1778ེ\x187Cൾ", A_1) ? 2 : 7;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_25:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("͆⁈⩊⩌㱎ᑐ⭒ご㑖ⱘ⽚㡜", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        protected override void InitExecuteList()
        {
            int A_1 = 4;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("͉≋❍\x244Fᝑⱓ㍕㭗⽙⡛㭝\x2C5Fୡᝣብ", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255", A_1));
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        if (1 == 0)
                            ;
                        if (enReturnCode.e_NULL_VALUE == this.E1)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_7;
                    case 2:
                        this.E1 = this.Initialize();
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_7:
            this.executeList.Add(new Command.CommandExecute(Module.a("้╋⽍㝏\x2151穓ɕし㽙\x2E5B㍝ş\x0E61\x2063ཥ१൩ɫŭͯٱᵳᕵ\x0B77", A_1), typeof(byte[]), typeof(byte[]), this.H1, true));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("͉≋❍\x244Fᝑⱓ㍕㭗⽙⡛㭝\x2C5Fୡᝣብ", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙", A_1));
        }
    }
}
