// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandWireless
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using hpCasl;
using HPQWMIEXLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

namespace CaslWmi
{
    public class CommandWireless : Command
    {
        private enReturnCode B1 = enReturnCode.e_NULL_VALUE;
        private enReturnCode D1 = enReturnCode.e_NULL_VALUE;
        private enReturnCode G1 = enReturnCode.e_NULL_VALUE;
        private bool H1 = true;
        private bool? I1 = new bool?();
        private bool? J1 = new bool?();
        private bool A1;
        private CommandWireless.A C1;
        private bool E1;
        private CommandWireless.B F1;

        private string WirelessEmulationFile
        {
            get
            {
                return Constants.EmulationFolder + Module.a("ొ⡌㭎ِ㩒❔\x3256㕘㹚\x2E5Cⱞ╠٢፤\x0E66੨\x0E6A\x246CŮᝰᱲ㩴ɶ\x0D78\x0B7A\x087C\x0B7E꾀\xDB82좄쮆", 5);
            }
        }

        private string GlobalWirelessEmulationFile
        {
            get
            {
                return Constants.EmulationFolder + Module.a("ቔ\x3256ⵘᱚㅜぞ͠ɢ।てhᥪ\x086Cͮᑰrٴ㍶\x1C78ൺᑼ᱾\xE480쪂\xEB84\xE186\xE688쒊\xF88Cﮎ\xE190\xE692\xE194릖솘횚톜", 15);
            }
        }

        private bool BWireless4Supported
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
                            if (this.I1.HasValue)
                            {
                                if (1 == 0)
                                    ;
                                num = 2;
                                continue;
                            }
                            this.B1 = CommandWireless.GetWireless4SupportedFromBIOS(ref bSupported);
                            num = 6;
                            continue;
                        case 1:
                        case 4:
                        case 5:
                            goto label_12;
                        case 2:
                            bSupported = this.I1.Value;
                            this.B1 = enReturnCode.e_OK;
                            num = 4;
                            continue;
                        case 3:
                            this.I1 = new bool?(bSupported);
                            num = 1;
                            continue;
                        case 6:
                            if (this.B1 == enReturnCode.e_OK)
                            {
                                num = 3;
                                continue;
                            }
                            bSupported = false;
                            num = 5;
                            continue;
                        default:
                            goto label_2;
                    }
                }
                label_12:
                return bSupported;
            }
        }

        private bool BWirelessLegacySupported
        {
            get
            {
                label_2:
                bool bSupported = false;
                int num = 4;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            this.J1 = new bool?(bSupported);
                            num = 3;
                            continue;
                        case 1:
                        case 2:
                        case 3:
                            goto label_12;
                        case 4:
                            if (this.J1.HasValue)
                            {
                                num = 6;
                                continue;
                            }
                            this.B1 = CommandWireless.GetWirelessLegacySupportedFromBIOS(ref bSupported);
                            num = 5;
                            continue;
                        case 5:
                            if (this.B1 == enReturnCode.e_OK)
                            {
                                num = 0;
                                continue;
                            }
                            bSupported = false;
                            num = 1;
                            continue;
                        case 6:
                            if (1 == 0)
                                ;
                            bSupported = this.J1.Value;
                            this.B1 = enReturnCode.e_OK;
                            num = 2;
                            continue;
                        default:
                            goto label_2;
                    }
                }
                label_12:
                return bSupported;
            }
        }

        private bool bWirelessSupported
        {
            get
            {
                return this.BWireless4Supported || this.BWirelessLegacySupported;
            }
        }

        private enReturnCode BBB()
        {
            int A_1 = 10;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ㅗ㭙せ㝝\x1A5Fݡ", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            this.A1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("᥏㱑㵓≕ㅗ㭙せ㝝\x1A5Fݡ", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public enReturnCode GetDeviceInfoXml(out XmlDocument xdocDeviceInfo)
        {
            int A_1 = 16;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59ᡛ㭝ᙟୡݣͥⅧѩ੫ŭ", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            xdocDeviceInfo = (XmlDocument)null;
            int num = 9;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_19;
                    case 1:
                        enReturnCode = this.GetDeviceInfoXmlW4(out xdocDeviceInfo);
                        num = 6;
                        continue;
                    case 2:
                        if (xdocDeviceInfo != null)
                        {
                            num = 13;
                            continue;
                        }
                        goto label_19;
                    case 3:
                        num = 2;
                        continue;
                    case 4:
                        if (1 == 0)
                            ;
                        if (!this.BWirelessLegacySupported)
                        {
                            enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            num = 7;
                            continue;
                        }
                        num = 11;
                        continue;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        num = 12;
                        continue;
                    case 9:
                        num = !this.A1 ? 14 : 10;
                        continue;
                    case 10:
                        enReturnCode = this.BB(out xdocDeviceInfo);
                        num = 8;
                        continue;
                    case 11:
                        enReturnCode = this.GetDeviceInfoXmlLegacy(out xdocDeviceInfo);
                        num = 5;
                        continue;
                    case 12:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 3;
                            continue;
                        }
                        goto label_19;
                    case 13:
                        enReturnCode = new XmlTools().Validate(xdocDeviceInfo.InnerXml, Resources.hpCASL);
                        num = 0;
                        continue;
                    case 14:
                        num = !this.BWireless4Supported ? 4 : 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_19:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59ᡛ㭝ᙟୡݣͥⅧѩ੫ŭ", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ䡱味", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BB(out XmlDocument A_0)
        {
            int A_1 = 15;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⩮ᱰٲᥴᙶ\x0D78ቺቼᅾ", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_0 = new XmlDocument();
            int num1 = 2;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⩮ᱰٲᥴᙶ\x0D78ቺቼᅾ", A_1), Module.a("᱔㥖⩘⽚㱜ㅞᕠ\x0A62Ѥ፦hѪͬ佮Ṱᕲ啴⽶ᑸ\x177A㥼ၾ\xE280\xF682\xE884\xE286\xE788ﾊ권ﶎ\xF490\xE792\xE094\xE596\xF798ﺚ列뾞쾠횢즤쮦", A_1));
                        num1 = 1;
                        continue;
                    case 1:
                        goto label_14;
                    case 2:
                        if (A_0 == null)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto label_5;
                    default:
                        goto label_2;
                }
            }
            label_5:
            try
            {
                int num2 = 0;
                while (true)
                {
                    switch (num2)
                    {
                        case 1:
                            goto label_14;
                        case 2:
                            A_0.Load(this.WirelessEmulationFile);
                            num2 = 1;
                            continue;
                        case 3:
                            File.WriteAllText(this.WirelessEmulationFile, Resources.GetWirelessDeviceInfoOutput);
                            num2 = 2;
                            continue;
                        default:
                            if (!File.Exists(this.WirelessEmulationFile))
                            {
                                num2 = 3;
                                continue;
                            }
                            goto case 2;
                    }
                }
            }
            catch (Exception ex)
            {
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⩮ᱰٲᥴᙶ\x0D78ቺቼᅾ", A_1), Module.a("ၔ⽖㩘㹚ⵜ\x2B5E\x0860ౢ\x0B64䝦ըѪ౬୮ᡰᵲቴ坶\x1C78ᙺ\x087C\x137E\xE080\xF782\xEC84\xE886\xE788\xAB8A\xEB8C\xE68E\xFD90\xF692꾔랖뺘\xE09A겜\xE29E蚠", A_1), (object)ex.Message);
                enReturnCode = enReturnCode.e_INVALID_XML;
            }
            label_14:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⩮ᱰٲᥴᙶ\x0D78ቺቼᅾ", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode AA()
        {
            int A_1 = 10;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ɏ㝑\x3253\x2455㵗⥙㑛\x0D5Dᑟၡᅣեᱧᥩ⩫ᱭὯάⱳ㭵㑷", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            XmlDocument xdocDeviceInfo = (XmlDocument)null;
            enReturnCode enReturnCode = this.GetDeviceInfoXml(out xdocDeviceInfo);
            int num = 18;
            XmlEdit xmlEdit=null;
            bool flag1=false;
            bool flag2=false;
            bool flag3=false;
            CommandWireless.D d1 = new D();
            bool bool1=false;
            CommandWireless.D d2 = new D();
            bool bool2=false;
            byte byte1=0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        flag1 = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDE89\xE98B\xED8D\xF88Fﲑﮓ歹\xF797ﶙ\xE59B쪝\xD99F튡솣ﶥ蚧鞩讫玲ﲯ\xF3B1荒醵\xE5B7", A_1)) != null;
                        flag2 = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDE89\xE98B\xED8D\xF88Fﲑﮓ歹\xF797ﶙ\xE59B쪝\xD99F튡솣ﶥ蚧鞩讫\xECAD\xDCAF잱톳습ힷ햹좻횽\xE7BF鿁", A_1)) != null;
                        flag3 = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDE89\xE98B\xED8D\xF88Fﲑﮓ歹\xF797ﶙ\xE59B쪝\xD99F튡솣ﶥ蚧鞩讫玲\xE7AF\xF3B1荒醵\xE5B7", A_1)) != null;
                        byte byte2 = xmlEdit.GetByte(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⽫\x0F6Do\x1371ᙳήᑷ\x1379\x087B\x177D\xE57F\xF181\xAB83종ﶇ\xE789\xEE8B\xEB8D\xE28F\xDD91\xF293욕\xF797\xED99鍊\xEC9D\xF39F춡톣풥쮧쾩\xDFAB", A_1));
                        this.C1.B = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⽫\x0F6Do\x1371ᙳήᑷ\x1379\x087B\x177D\xE57F\xF181\xAB83솅\xE487\xE589\xEE8B\xEF8Dﲏ풑\xF193\xF795\xEC97\xEF99\xEE9Bﮝ펟趡\xF3A3\xF1A5\xE9A7\xE4A9\xEDAB삭쒯ힱ\xDAB3\xD8B5\xD9B7", A_1));
                        this.C1.C = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⽫\x0F6Do\x1371ᙳήᑷ\x1379\x087B\x177D\xE57F\xF181\xAB83솅\xE487\xE589\xEE8B\xEF8Dﲏ풑\xF193\xF795\xEC97\xEF99\xEE9Bﮝ펟趡\xE3A3\xF6A5ﮧ\xE3A9슫춭\xDCAF잱킳펵\xDCB7", A_1));
                        this.C1.Aa = byte2;
                        num = 8;
                        continue;
                    case 1:
                        this.F1.A = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ즉曆ﲍ\xE28F\xF791望\xE295쮗\xEE99ﶛ\xEA9D얟說誣袥螧ﺩ즫춭\xD8AF\xDCB1\xDBB3\xDAB5ힷ\xDDB9얻\xEABD릿닁ꇃ\xFBC5\xEFC7鷉胋迍黏\xF5D1觓", A_1));
                        this.F1.Bb = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xE7AFﾱﶳ\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡돣ꫥ\xA9E7ꓩ쯫돭", A_1));
                        this.F1.C = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF6AF莱蒳\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡돣ꫥ\xA9E7ꓩ쯫돭", A_1));
                        this.F1.D = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF8AF펱욳튵쾷\xDBB9캻\xDBBD芿럁냃닅\xA7C7\xA4C9韋\xE0CDﻏ\xFDD1䀘\xF8D5\xF7D7軙맛뷝裟賡诣諥蟧跩闫뫭觯英釳쯵\xDFF7극냻뿽仿━夃", A_1));
                        this.F1.E = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ즉曆ﲍ\xE28F\xF791望\xE295쮗\xEE99ﶛ\xEA9D얟說誣袥螧ﺩ즫춭\xD8AF\xDCB1\xDBB3\xDAB5ힷ\xDDB9얻\xEABD릿닁ꇃ\xFBC5\xEFC7裉ꃋ믍뗏ꛑ믓맕곗닙ﯛ菝", A_1));
                        this.F1.F = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xE7AFﾱﶳ\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡ꛣ諥鷧迩飫臭\x9FEF蛱鳳퇵ꗷ", A_1));
                        this.F1.G = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF6AF莱蒳\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡ꛣ諥鷧迩飫臭\x9FEF蛱鳳퇵ꗷ", A_1));
                        this.F1.H = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF8AF펱욳튵쾷\xDBB9캻\xDBBD芿럁냃닅\xA7C7\xA4C9韋\xE0CDﻏ\xFDD1䀘\xF8D5\xF7D7軙맛뷝裟賡诣諥蟧跩闫뫭觯英釳쯵\xDFF7룹郻诽旿瘁欃椅簇戉⬋匍", A_1));
                        this.F1.I = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ즉曆ﲍ\xE28F\xF791望\xE295쮗\xEE99ﶛ\xEA9D얟說誣袥螧ﺩ즫춭\xD8AF\xDCB1\xDBB3\xDAB5ힷ\xDDB9얻\xEABD릿닁ꇃ\xFBC5\xEFC7鷉鯋迍黏\xF5D1觓", A_1));
                        this.F1.J = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xE7AFﾱﶳ\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡돣뇥\xA9E7ꓩ쯫돭", A_1));
                        this.F1.K = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF6AF莱蒳\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡돣뇥\xA9E7ꓩ쯫돭", A_1));
                        this.F1.L = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF8AF펱욳튵쾷\xDBB9캻\xDBBD芿럁냃닅\xA7C7\xA4C9韋\xE0CDﻏ\xFDD1䀘\xF8D5\xF7D7軙맛뷝裟賡诣諥蟧跩闫뫭觯英釳쯵\xDFF7극\xABFB뿽仿━夃", A_1));
                        this.F1.M = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ즉曆ﲍ\xE28F\xF791望\xE295쮗\xEE99ﶛ\xEA9D얟說誣袥螧ﺩ즫춭\xD8AF\xDCB1\xDBB3\xDAB5ힷ\xDDB9얻\xEABD릿닁ꇃ\xFBC5\xEFC7跉鳋鷍\xF7CF近", A_1));
                        this.F1.N = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xE7AFﾱﶳ\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡ꏣ뛥믧췩뇫", A_1));
                        this.F1.O = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF6AF莱蒳\xEDB5隷钹鎻邽\xEEBF\xEDC1郃ꏅꯇꋉꋋꇍ볏뷑돓꿕賗ꏙ곛믝\xDDDF엡ꏣ뛥믧췩뇫", A_1));
                        this.F1.P = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ욉\xED8Bﶍ\xE48F삑\xF193\xE795\xED97ﾙ\xEF9B\xEA9D얟욡\xF7A3튥즧\xDEA9즫膭\xF8AF펱욳튵쾷\xDBB9캻\xDBBD芿럁냃닅\xA7C7\xA4C9韋\xE0CDﻏ\xFDD1䀘\xF8D5\xF7D7軙맛뷝裟賡诣諥蟧跩闫뫭觯英釳쯵\xDFF7뷹곻귽⟿弁", A_1));
                        this.C1 = new CommandWireless.A();
                        num = 14;
                        continue;
                    case 2:
                        this.C1.E = new CommandWireless.D()
                        {
                            A = Module.a("\x124F㹑\x2153㍕ⱗ㕙㍛⩝\x085F", A_1),
                            B = true,
                            C = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ좉曆ﶍ쒏\xEB91\xE493\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽芿껁뇃ꏅ볇ꗉꏋ뫍룏\xF5D1觓", A_1)),
                            D1 = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDC89\xE98B\xE08D\xF48F\xFD91\xE693\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF胁ꣃ독귇뻉ꏋꇍ\xA4CF뫑\xF3D3试", A_1), 16),
                            E = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ캉\xE98B\xF88D憐\xF191\xF193\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF胁ꣃ독귇뻉ꏋꇍ\xA4CF뫑\xF3D3试", A_1), 16),
                            F = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D욏\xF791望\xF295\xF797\xE899햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5談ꛉ맋ꯍ\xA4CF뷑믓ꋕ냗\xFDD9臛", A_1), 16),
                            G = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D쎏\xEB91\xE793\xE295ﶗ\xF799햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5談ꛉ맋ꯍ\xA4CF뷑믓ꋕ냗\xFDD9臛", A_1), 16),
                            H = xmlEdit.GetByte(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDA89\xE38B轢\xF58F\xE091잓秊\xED97\xE899ﾛﮝﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5談ꛉ맋ꯍ\xA4CF뷑믓ꋕ냗\xFDD9臛", A_1)),
                            I = (ushort)0
                        };
                        num = 15;
                        continue;
                    case 3:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_31;
                    case 4:
                        num = 11;
                        continue;
                    case 5:
                    case 13:
                        goto label_31;
                    case 6:
                        d2.I = (ushort)((((int)byte1 & 7) << 1) + (bool2 ? 1 : 0));
                        this.C1.D = d2;
                        num = 13;
                        continue;
                    case 7:
                        d1 = new CommandWireless.D();
                        d1.A = Module.a("ݏṑᕓᡕ", A_1);
                        d1.B = true;
                        d1.C = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ좉曆ﶍ쒏\xEB91\xE493\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽鞿軁藃装\xEFC7韉", A_1));
                        d1.D1 = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDC89\xE98B\xE08D\xF48F\xFD91\xE693\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF闁裃蟅蛇\xEDC9釋", A_1), 16);
                        d1.E = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ캉\xE98B\xF88D憐\xF191\xF193\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF闁裃蟅蛇\xEDC9釋", A_1), 16);
                        d1.F = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D욏\xF791望\xF295\xF797\xE899햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇蛉跋胍\xF7CF近", A_1), 16);
                        d1.G = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D쎏\xEB91\xE793\xE295ﶗ\xF799햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇蛉跋胍\xF7CF近", A_1), 16);
                        d1.H = xmlEdit.GetByte(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDA89\xE38B轢\xF58F\xE091잓秊\xED97\xE899ﾛﮝﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇蛉跋胍\xF7CF近", A_1));
                        bool1 = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDD89삋쾍\xDE8F풑\xF193\xF795\xEC97\xEF99\xEE9Bﮝ펟趡\xE8A3\xE7A5\xE6A7ﶩ\xEDAB\xE0AD\xE3AF얱\xDDB3습\xDBB7특햻킽\xA7BF駁\xEAC3\xE8C5\xE7C7\xE4C9\xE2CB\xE1CD蓏럑럓뻕뛗뗙냛뇝蟟鯡냣\x9FE5飧迩퇫짭\xA7EF뻱뗳룵\xDFF7\xA7F9", A_1));
                        num = 12;
                        continue;
                    case 8:
                        if (flag1)
                        {
                            num = 7;
                            continue;
                        }
                        goto case 4;
                    case 9:
                        if (xmlEdit != null)
                        {
                            num = 1;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ɏ㝑\x3253\x2455㵗⥙㑛\x0D5Dᑟၡᅣեᱧᥩ⩫ᱭὯάⱳ㭵㑷", A_1), Module.a("᥏㱑❓≕㥗㑙⡛㝝şᙡൣ॥٧䩩ͫ\x086D偯⩱ᥳ᩵㵷ṹᕻ\x0A7Dꁿ\xF081\xE183\xF285ﶇ\xF889\xE28B\xEB8D\xF48F늑望\xE395\xF497\xF699", A_1));
                        num = 5;
                        continue;
                    case 10:
                        if (1 == 0)
                            ;
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ɏ㝑\x3253\x2455㵗⥙㑛\x0D5Dᑟၡᅣեᱧᥩ⩫ᱭὯάⱳ㭵㑷", A_1), Module.a("᥏㱑❓≕㥗㑙⡛㝝şᙡൣ॥٧䩩ͫ\x086D偯╱ᵳѵᵷᙹ\x197Bൽ\xF37F톁\xF083\xE785ﲇ\xE389\xEF8B잍ﺏ\xF491ﮓ뚕\xEA97ﾙ\xE89B\xEB9D튟첡솣슥袧쒩\xD9AB슭\xDCAF", A_1));
                        num = 17;
                        continue;
                    case 11:
                        if (flag2)
                        {
                            num = 2;
                            continue;
                        }
                        goto case 15;
                    case 12:
                        d1.I = bool1 ? (ushort)1 : (ushort)0;
                        this.C1.F = d1;
                        num = 4;
                        continue;
                    case 14:
                        if (this.C1 == null)
                        {
                            num = 10;
                            continue;
                        }
                        goto case 17;
                    case 15:
                        num = 20;
                        continue;
                    case 16:
                        d2 = new CommandWireless.D();
                        d2.A = Module.a("ݏՑᕓᡕ", A_1);
                        d2.B = true;
                        d2.C = xmlEdit.GetString(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ좉曆ﶍ쒏\xEB91\xE493\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽鞿闁藃装\xEFC7韉", A_1));
                        d2.D1 = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDC89\xE98B\xE08D\xF48F\xFD91\xE693\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF闁鏃蟅蛇\xEDC9釋", A_1), 16);
                        d2.E = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ캉\xE98B\xF88D憐\xF191\xF193\xDF95\xDC97솙늛낝辟\xF6A1솣얥삧쒩쎫슭\xDFAF햱춳\xE2B5솷쪹\xD9BB莽\xE7BF闁鏃蟅蛇\xEDC9釋", A_1), 16);
                        d2.F = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D욏\xF791望\xF295\xF797\xE899햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇鷉跋胍\xF7CF近", A_1), 16);
                        d2.G = xmlEdit.GetUInt16(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xD989曆\xEC8D쎏\xEB91\xE793\xE295ﶗ\xF799햛\xDA9Dﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇鷉跋胍\xF7CF近", A_1), 16);
                        d2.H = xmlEdit.GetByte(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDA89\xE38B轢\xF58F\xE091잓秊\xED97\xE899ﾛﮝﮟ財誣覥ﲧ쾩쾫욭\xDEAF\xDDB1\xD8B3\xD9B5\xDFB7쎹\xE8BB잽낿\xA7C1遼\xE1C5鿇鷉跋胍\xF7CF近", A_1));
                        bool2 = xmlEdit.GetBool(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDD89\xDB8B쾍\xDE8F풑\xF193\xF795\xEC97\xEF99\xEE9Bﮝ펟趡\xF7A3\xEFA5\xE5A7\xE9A9춫\xDCAD풯\xF3B1ힳ햵\xDDB7즹쾻\xE5BD\xEEBF\xECC1\xEBC3\xE8C5\xE6C7\xE5C9飋ꯍ돏뫑뫓맕듗뗙믛\xA7DD듟鯡铣菥헧췩믫맭뇯볱폳꯵", A_1));
                        byte1 = xmlEdit.GetByte(Module.a("罏絑᭓⍕ⱗ⩙⥛⩝佟♡գብ१䕩⡫୭ٯ᭱ᝳ\x1375\x0B77啹㡻\x1B7D\xF67F\xEB81\xE783\xE385ꞇ\xDD89\xDB8B쾍\xDE8F풑\xF193\xF795\xEC97\xEF99\xEE9Bﮝ펟趡\xF4A3풥춧첩즫\xDCAD슯ힱ킳﮵ힷ\xD8B9햻튽ꖿ跁듃ꏅ뫇ꯉ룋ꇍꋏ臑뇓ꋕ곗동닛망믟쳡쫣짥웧쓩쏫뫭闯釱鳳飵韷雹鏻駽秿嘁紃瘅洇㜉⬋复䜏匑娓ㄕ䔗", A_1));
                        num = 6;
                        continue;
                    case 17:
                        num = 3;
                        continue;
                    case 18:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 19;
                            continue;
                        }
                        goto label_31;
                    case 19:
                        xmlEdit = new XmlEdit(xdocDeviceInfo);
                        num = 9;
                        continue;
                    case 20:
                        if (flag3)
                        {
                            num = 16;
                            continue;
                        }
                        goto label_31;
                    default:
                        goto label_2;
                }
            }
            label_31:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ɏ㝑\x3253\x2455㵗⥙㑛\x0D5Dᑟၡᅣեᱧᥩ⩫ᱭὯάⱳ㭵㑷", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ䱫ᕭ䁯ཱ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDeviceInfoXmlW4(out XmlDocument xdocDeviceInfo)
        {
            int A_1 = 16;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59ᡛ㭝ᙟୡݣͥⅧѩ੫ŭ⡯άᡳⅵ䱷", A_1), Module.a("Օⱗ㭙\x2E5B⩝՟١", A_1));
            xdocDeviceInfo = (XmlDocument)null;
            enReturnCode enReturnCode = this.RefreshStructsFromDeviceInfoW4();
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        enReturnCode = this.BuildDeviceInfoXmlFromStructs(out xdocDeviceInfo);
                        num = 1;
                        continue;
                    case 1:
                        goto label_7;
                    case 2:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_7;
                    default:
                        goto label_2;
                }
            }
            label_7:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59ᡛ㭝ᙟୡݣͥⅧѩ੫ŭ⡯άᡳⅵ䱷", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ䡱味", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode RefreshStructsFromDeviceInfoW4()
        {
            int A_1 = 15;
            label_2:
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݔ\x3256㽘⥚㡜ⱞॠ❢dᅦh\x086A\x086C♮ὰᕲᩴ\x2076䵸⡺ॼൾ\xF480\xE082\xF184\xF486", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
            byte[] abyDeviceInfo = (byte[])null;
            enReturnCode enReturnCode = this.GetDeviceInfoW4FromBIOS(out abyDeviceInfo);
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        enReturnCode = this.SaveDeviceInfoW4ToStructs(abyDeviceInfo);
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
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݔ\x3256㽘⥚㡜ⱞॠ❢dᅦh\x086A\x086C♮ὰᕲᩴ\x2076䵸⡺ॼൾ\xF480\xE082\xF184\xF486", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SaveDeviceInfoW4ToStructs(byte[] abyW4DeviceInfo)
        {
            int A_1 = 12;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ő㕓⁕㵗ṙ㥛⡝य़šţ⽥٧౩ͫ㥭䑯♱᭳╵\x0C77\x0879ॻᵽ\xF47F\xF181", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 11;
            CommandWireless.D d = new D();
            bool bit1=false;
            bool bit2=false;
            bool bit3=false;
            bool bit4=false;
            int index=0;
            ushort num2=0;
            ushort num3=0;
            ushort num4=0;
            ushort num5=0;
            ushort num6=0;
            ushort num7=0;
            byte num8 = 0;
            
            ushort num9=0;
            ushort num10=0;
            int num11=0;
            byte num12=0;
            ushort num13=0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 10:
                        num1 = 14;
                        continue;
                    case 1:
                        switch (num10)
                        {
                            case (ushort)0:
                                if (1 == 0)
                                    ;
                                d.C = Module.a("ɑᝓὕ", A_1);
                                num1 = 5;
                                continue;
                            case (ushort)1:
                                d.C = Module.a("ݑݓᑕ", A_1);
                                num1 = 2;
                                continue;
                            default:
                                num1 = 19;
                                continue;
                        }
                    case 2:
                    case 5:
                    case 15:
                        d.D1 = num4;
                        d.E = num5;
                        d.F = num6;
                        d.G = num7;
                        d.H = num8;
                        d.I = num9;
                        num13 = num2;
                        num1 = 4;
                        continue;
                    case 3:
                    case 9:
                    case 12:
                    case 13:
                    case 16:
                        index += 16;
                        ++num11;
                        num1 = 10;
                        continue;
                    case 4:
                        switch (num13)
                        {
                            case (ushort)0:
                                d.A = Module.a("Ցᡓ\x1755ᙗ", A_1);
                                this.C1.F = d;
                                this.F1.A = bit1;
                                this.F1.Bb = bit2;
                                this.F1.C = bit3;
                                this.F1.D = bit4;
                                num1 = 9;
                                continue;
                            case (ushort)1:
                                d.A = Module.a("ၑ㡓⍕㵗\x2E59㍛ㅝᑟ\x0A61", A_1);
                                this.C1.E = d;
                                this.F1.E = bit1;
                                this.F1.F = bit2;
                                this.F1.G = bit3;
                                this.F1.H = bit4;
                                num1 = 16;
                                continue;
                            case (ushort)2:
                                d.A = Module.a("Ց͓\x1755ᙗ", A_1);
                                this.C1.D = d;
                                this.F1.I = bit1;
                                this.F1.J = bit2;
                                this.F1.K = bit3;
                                this.F1.L = bit4;
                                num1 = 13;
                                continue;
                            case (ushort)3:
                                d.A = Module.a("ᕑѓՕ", A_1);
                                this.C1.G = d;
                                this.F1.M = bit1;
                                this.F1.N = bit2;
                                this.F1.O = bit3;
                                this.F1.P = bit4;
                                num1 = 12;
                                continue;
                            default:
                                num1 = 7;
                                continue;
                        }
                    case 6:
                    case 20:
                        goto label_32;
                    case 7:
                        num1 = 3;
                        continue;
                    case 8:
                        num1 = 6;
                        continue;
                    case 11:
                        if (this.C1 == null)
                        {
                            num1 = 17;
                            continue;
                        }
                        goto case 22;
                    case 14:
                        if (num11 < (int)num12)
                        {
                            d = new CommandWireless.D();
                            num2 = (ushort)abyW4DeviceInfo[index];
                            num3 = (ushort)abyW4DeviceInfo[index + 1];
                            num4 = BitConverter.ToUInt16(abyW4DeviceInfo, index + 2);
                            num5 = BitConverter.ToUInt16(abyW4DeviceInfo, index + 4);
                            num6 = BitConverter.ToUInt16(abyW4DeviceInfo, index + 6);
                            num7 = BitConverter.ToUInt16(abyW4DeviceInfo, index + 8);
                            num8 = abyW4DeviceInfo[index + 10];
                            bit1 = Utility.GetBit(abyW4DeviceInfo[index + 11], 0);
                            bit2 = Utility.GetBit(abyW4DeviceInfo[index + 11], 1);
                            bit3 = Utility.GetBit(abyW4DeviceInfo[index + 11], 2);
                            bit4 = Utility.GetBit(abyW4DeviceInfo[index + 11], 3);
                            num9 = BitConverter.ToUInt16(abyW4DeviceInfo, index + 12);
                            d.B = true;
                            num10 = num3;
                            num1 = 1;
                            continue;
                        }
                        num1 = 8;
                        continue;
                    case 17:
                        this.C1 = new CommandWireless.A();
                        num1 = 22;
                        continue;
                    case 18:
                        d.C = string.Format(Module.a("ݑ㩓㵕㙗㕙\x2B5Bそ䡟ᥡ呣᭥䅧", A_1), (object)num3);
                        num1 = 15;
                        continue;
                    case 19:
                        num1 = 18;
                        continue;
                    case 21:
                        this.C1.B = Utility.GetBit(abyW4DeviceInfo[2], 0);
                        this.C1.C = Utility.GetBit(abyW4DeviceInfo[2], 1);
                        this.C1.Aa = abyW4DeviceInfo[6];
                        index = 16;
                        num12 = abyW4DeviceInfo[7];
                        num11 = 0;
                        num1 = 0;
                        continue;
                    case 22:
                        num1 = 23;
                        continue;
                    case 23:
                        if (this.C1 != null)
                        {
                            num1 = 21;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ő㕓⁕㵗ṙ㥛⡝य़šţ⽥٧౩ͫ㥭䑯♱᭳╵\x0C77\x0879ॻᵽ\xF47F\xF181", A_1), Module.a("᱑\x2153㩕㑗穙㕛そ፟ᙡգ\x0865ᱧͩ൫ᩭ\x196Fᵱᩳ噵\x1777\x1C79屻⥽\xE97F\xF081\xE183\xEA85\xED87黎ﾋ\xDD8D\xE48F\xF391\xE093ﾕﮗ펙\xF29B\xF89D쾟芡쮣쒥슧쾩쾫\xDAAD", A_1));
                        num1 = 20;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_32:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ő㕓⁕㵗ṙ㥛⡝य़šţ⽥٧౩ͫ㥭䑯♱᭳╵\x0C77\x0879ॻᵽ\xF47F\xF181", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ呭偯", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BuildDeviceInfoXmlFromStructs(out XmlDocument xDeviceInfo)
        {
            int A_1 = 9;
            label_3:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ൎ\x2450㩒㥔㍖\x1D58㹚\x2B5C㙞ɠ٢Ɽ०ཨѪ㕬ɮᵰ㕲ݴᡶᑸ⡺ॼൾ\xF480\xE082\xF184\xF486", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            xDeviceInfo = (XmlDocument)null;
            string xml = "";
            int num = 2;
            while (true)
            {
                if (1 == 0)
                    ;
                object[] objArray=null;
                switch (num)
                {
                    case 0:
                        objArray[3] = this.C1.B ? (object)Module.a("㭎⍐♒ご", A_1) : (object)Module.a("⥎ぐ㽒♔\x3256", A_1);
                        objArray[4] = (object)Module.a("獎繐ђɔᙖ\x1758ᩚ㍜\x2B5EѠൢ\x0B64٦坨坪⩬㽮≰㩲᭴ᑶᕸ\x0E7A\x197C\x1A7E\xE580붂", A_1);
                        num = 3;
                        continue;
                    case 1:
                        goto label_9;
                    case 2:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 4;
                            continue;
                        }
                        goto label_11;
                    case 3:
                        objArray[5] = this.C1.C ? (object)Module.a("㭎⍐♒ご", A_1) : (object)Module.a("⥎ぐ㽒♔\x3256", A_1);
                        objArray[6] = (object)Module.a("獎繐ᑒՔіၘ㕚㹜㍞ᑠݢdͦ坨坪䉬⡮ᵰᱲ\x1774ᙶᕸ㵺\x187CṾ\xF580\xF682\xF784\xE286愈떊놌ꂎ튐\xF292\xE594\xF696ﮘ\xF29A\xF19C\xF69E햠쪢삤풦鞨鞪\xE9AC쪮잰\xDAB2횴튶쪸薺", A_1);
                        xml = string.Concat(objArray) + this.CreateDeviceNode(this.C1.D) + this.CreateDeviceNode(this.C1.E) + this.CreateDeviceNode(this.C1.F) + this.CreateDeviceNode(this.C1.G) + Module.a("獎繐ᝒご\x2156じ㡚㡜ⱞ彠形䩤⍦\x0868Ὢ౬兮䵰屲㩴ɶ\x0D78\x0B7A\x087C\x0B7E뾀뾂ꪄ삆\xEC88ﾊ\xDA8C\xE68E\xE390\xF692璉\xF296\xEA98\xE89A\xD99C爵힠쪢욤슦\xE0A8얪쮬삮ﺰ욲솴잶첸쾺莼", A_1);
                        num = 1;
                        continue;
                    case 4:
                        xDeviceInfo = new XmlDocument();
                        objArray = new object[7];
                        objArray[0] = (object)Module.a("獎湐⭒㡔㭖祘ⵚ㡜ⵞበ\x0A62\x0A64०周䥪屬䅮䅰兲啴ቶ\x1778\x187Aቼ\x1B7E\xE880\xED82\xE284몆\xAB88ﺊ歷\xE98E벐\xAB92랔ꢖ\xA798\xA79A\xDA9C爵햠\xF4A2첤햦첨잪좬\xDCAE슰\xF7B2킴솶킸\xD8BA\xD8BC\xF6BE꿀ꗂ\xAAC4裆볈뿊뷌뫎ꗐ\xF3D2귔뫖뗘뗚껜\xE2DE쏠郢蛤迦賨蛪賬鳮\xDCF0鯲藴\xDAF6髸铺郼퇾戀戂瘄欆⬈㔊ㄌ䀎搐朒攔或洘┚ℜ嬞䀠圢䐤ᤦᔨ株䰬弮倰儲尴嬶倸伺吼娾㉀終祄ॆ㱈♊⽌⩎⍐᱒㍔ݖ㙘ⱚ㡜ⵞ㉠ౢၤᕦ੨\x0E6AṬ兮", A_1);
                        objArray[1] = (object)this.C1.Aa;
                        objArray[2] = (object)Module.a("獎繐\x1D52⁔㩖㭘㹚⽜ၞݠ㍢\x0A64ၦ౨ᥪ㹬nѰŲᙴቶ\x0A78䕺䅼㡾\xED80\xEC82\xE784\xE686\xE588춊\xE88C\xEE8E\xE590\xE692\xE794\xF296\xEA98ꖚꆜ좞\xF6A0\xE2A2\xEBA4\xE6A6잨\xDFAA좬솮\xDFB0튲讴", A_1);
                        num = 0;
                        continue;
                    default:
                        goto label_3;
                }
            }
            label_9:
            try
            {
                xDeviceInfo.LoadXml(xml);
            }
            catch
            {
                xDeviceInfo = (XmlDocument)null;
                enReturnCode = enReturnCode.e_INVALID_XML;
            }
            label_11:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ൎ\x2450㩒㥔㍖\x1D58㹚\x2B5C㙞ɠ٢Ɽ०ཨѪ㕬ɮᵰ㕲ݴᡶᑸ⡺ॼൾ\xF480\xE082\xF184\xF486", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ兪䵬", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private string CreateDeviceNode(CommandWireless.D wirelessDeviceIDInfo)
        {
            int A_1 = 2;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("େ㡉⥋⽍\x244F㝑ၓ㍕\x2E57㍙㽛㭝\x2E5Fൡcͥ", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
            string str1 = string.Empty;
            int num1 = 3;
            bool flag1=false;
            bool flag2=false;
            bool flag3=false;
            bool flag4=false;
            string str2=null;
            string[] strArray1=null;
            string str3=null;
            bool bit1=false;
            bool bit2=false;
            int num2=0;
            string[] strArray2=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num1 = 23;
                        continue;
                    case 1:
                        strArray1[16] = flag3 ? Module.a("❇⑉", A_1) : Module.a("❇ⱉ⩋", A_1);
                        strArray1[17] = Module.a("瑇敉ੋ罍恏汑桓ṕ㥗⡙㡛⥝şၡţ\x2465\x1D67ṩᡫŭṯ䱱", A_1);
                        num1 = 20;
                        continue;
                    case 2:
                    case 16:
                    case 29:
                        str1 += Module.a("瑇敉ࡋ\x2B4D♏㭑㝓㍕晗", A_1);
                        num1 = 4;
                        continue;
                    case 3:
                        if (wirelessDeviceIDInfo.B)
                        {
                            num1 = 28;
                            continue;
                        }
                        goto label_51;
                    case 4:
                        goto label_51;
                    case 5:
                        if ((str3 = wirelessDeviceIDInfo.A) != null)
                        {
                            num1 = 7;
                            continue;
                        }
                        goto case 2;
                    case 6:
                    case 9:
                    case 18:
                    case 21:
                    case 32:
                        strArray1 = new string[20]
                        {
              str1,
              Module.a("瑇᱉⥋⁍㑏㵑♓ὕ᱗摙", A_1),
              wirelessDeviceIDInfo.D1.ToString(Module.a("၇繉", A_1)),
              Module.a("瑇敉ᩋ\x2B4D㹏㙑㭓\x2455ᅗṙ扛扝\x245Fݡባཥ୧ཀྵ╫⩭乯", A_1),
              wirelessDeviceIDInfo.E.ToString(Module.a("၇繉", A_1)),
              Module.a("瑇敉ࡋ\x2B4D♏㭑㝓㍕ᅗṙ扛扝㍟ᝡ٣づ൧ѩ\x086Bŭɯ㭱び䡵", A_1),
              wirelessDeviceIDInfo.F.ToString(Module.a("၇繉", A_1)),
              Module.a("瑇敉Ὃ㭍\x324Fёㅓ㡕㱗㕙\x2E5B\x175D\x245F屡塣㕥\x1D67\x0869㽫\x176Dͯٱᅳ᭵ㅷ㹹䉻", A_1),
              wirelessDeviceIDInfo.G.ToString(Module.a("၇繉", A_1)),
              Module.a("瑇敉Ὃ㭍\x324Főⵓ╕ⱗ㽙ㅛ\x175D\x245F屡塣㙥ݧ\x1D69५ᱭ⍯ᵱųѵ᭷ό䉻", A_1),
              wirelessDeviceIDInfo.H.ToString(),
              Module.a("瑇敉\x1C4B⅍❏㝑♓Օ㝗⽙\x2E5B㵝՟屡塣╥\x1D67ᡩṫ୭ṯٱ❳ɵ\x1977\x0E79\x197B䁽", A_1),
              null,
              null,
              null,
              null,
              null,
              null,
              null,
              null
                        };
                        num1 = 14;
                        continue;
                    case 7:
                        num1 = 36;
                        continue;
                    case 8:
                        str1 = str1 + Module.a("瑇\x1D49Kཌྷṏᑑㅓ㝕ⱗ⽙\x2E5B㭝፟屡塣⩥⥧\x2469㭫⽭㹯ⅱͳή\x0C77\x1979ᑻ\x177D\xEE7F\xE581몃", A_1) + (bit1 ? Module.a("㱇㡉㥋\x2B4D", A_1) : Module.a("\x2E47⭉⁋㵍㕏", A_1)) + Module.a("瑇敉KཌྷṏՑᕓᡕୗⵙ㕛⩝͟\x0A61ൣ\x0865ཧ呩偫䅭❯㹱㕳㡵㹷όᵻ\x0A7D\xF57F\xF081\xE183\xF585뚇", A_1);
                        num1 = 29;
                        continue;
                    case 10:
                        num1 = 27;
                        continue;
                    case 11:
                        if (!(str2 == Module.a("ੇ♉㥋\x2B4D\x244F㵑㭓≕し", A_1)))
                        {
                            num1 = 19;
                            continue;
                        }
                        flag1 = this.F1.E;
                        flag2 = this.F1.F;
                        flag3 = this.F1.G;
                        flag4 = this.F1.H;
                        num1 = 18;
                        continue;
                    case 12:
                        if (!(str2 == Module.a("\x1F47ىോM", A_1)))
                        {
                            num1 = 26;
                            continue;
                        }
                        flag1 = this.F1.A;
                        flag2 = this.F1.Bb;
                        flag3 = this.F1.C;
                        flag4 = this.F1.D;
                        num1 = 9;
                        continue;
                    case 13:
                        if ((str2 = wirelessDeviceIDInfo.A) != null)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto case 6;
                    case 14:
                        strArray1[12] = flag1 ? Module.a("❇⑉", A_1) : Module.a("❇ⱉ⩋", A_1);
                        strArray1[13] = Module.a("瑇敉ཋ㭍≏⁑ㅓ㡕ⱗख़⡛㽝ᑟݡ婣婥\x2467୩Ὣᩭ≯\x1771ճ͵ᵷॹ\x087B\x1B7D\xE47F톁\xF083\xE785ﲇ\xEF89늋늍잏\xDF91\xDD93ꢕ", A_1);
                        num1 = 33;
                        continue;
                    case 15:
                        num1 = 12;
                        continue;
                    case 17:
                        num1 = 21;
                        continue;
                    case 19:
                        num1 = 25;
                        continue;
                    case 20:
                        strArray1[18] = flag4 ? Module.a("❇⑉", A_1) : Module.a("❇ⱉ⩋", A_1);
                        strArray1[19] = Module.a("瑇敉ы⽍≏㙑⍓㝕⩗㽙ṛ\x2B5Dᑟᙡୣ\x0865噧噩䍫≭ᅯűs\x2475ᵷ\x0B79ॻ\x1B7D\xF37F\xF681\xE183\xE285\xDB87ﺉ\xED8B揄\xF58F겑", A_1);
                        str1 = string.Concat(strArray1);
                        num1 = 5;
                        continue;
                    case 22:
                        num1 = 34;
                        continue;
                    case 23:
                        if (!(str2 == Module.a("ཇᩉὋ", A_1)))
                        {
                            num1 = 17;
                            continue;
                        }
                        flag1 = this.F1.M;
                        flag2 = this.F1.N;
                        flag3 = this.F1.O;
                        flag4 = this.F1.P;
                        num1 = 6;
                        continue;
                    case 24:
                        num1 = 16;
                        continue;
                    case 25:
                        if (!(str2 == Module.a("\x1F47\x1D49ോM", A_1)))
                        {
                            num1 = 0;
                            continue;
                        }
                        if (1 == 0)
                            ;
                        flag1 = this.F1.I;
                        flag2 = this.F1.J;
                        flag3 = this.F1.K;
                        flag4 = this.F1.L;
                        num1 = 32;
                        continue;
                    case 26:
                        num1 = 11;
                        continue;
                    case 27:
                        if (!(str3 == Module.a("\x1F47\x1D49ോM", A_1)))
                        {
                            num1 = 22;
                            continue;
                        }
                        bit2 = Utility.GetBit((byte)wirelessDeviceIDInfo.I, 0);
                        num2 = ((int)wirelessDeviceIDInfo.I & 14) >> 1;
                        string str4 = str1;
                        strArray2 = new string[6];
                        strArray2[0] = str4;
                        strArray2[1] = Module.a("瑇\x1D49ᭋཌྷṏᑑㅓ㝕ⱗ⽙\x2E5B㭝፟屡塣㕥Ⅷ❩⽫\x0F6Dɯᙱ㕳ᕵ᭷όཻൽ빿", A_1);
                        num1 = 30;
                        continue;
                    case 28:
                        flag1 = false;
                        flag2 = false;
                        flag3 = false;
                        flag4 = false;
                        str1 = str1 + Module.a("瑇้⥋㡍㥏ㅑㅓ桕", A_1) + Module.a("瑇ṉ⥋ⵍ㡏㱑㭓㩕㝗㵙╛\x0A5Dᥟቡţ塥", A_1) + wirelessDeviceIDInfo.A + Module.a("瑇敉ᡋ\x2B4D㍏㩑㩓㥕㑗㕙㭛❝㑟᭡ᑣͥ噧", A_1) + Module.a("瑇ࡉ㥋㵍я⭑\x2453㍕晗", A_1) + wirelessDeviceIDInfo.C + Module.a("瑇敉๋㭍⍏ّⵓ♕㵗摙", A_1);
                        num1 = 13;
                        continue;
                    case 30:
                        strArray2[2] = bit2 ? Module.a("㱇㡉㥋\x2B4D", A_1) : Module.a("\x2E47⭉⁋㵍㕏", A_1);
                        strArray2[3] = Module.a("瑇敉Ὃݍ\x1D4Fᅑ㕓\x2455㱗᭙㽛㵝՟ᅡᝣ塥呧㩩ṫ୭ᙯ\x1771ٳѵᵷṹㅻᅽ\xE27F\xEB81\xE883\xE385잇憎\xE98Bﲍ\xF18F\xE691ﮓ\xE495쮗ﾙ\xE89B\xEA9D즟첡쎣颥", A_1);
                        strArray2[4] = num2.ToString();
                        strArray2[5] = Module.a("瑇敉\x1C4B㱍㕏㑑ㅓ\x2455⩗㽙㡛፝ཟaൣ\x0A65൧╩ᱫ୭ɯ\x1371s\x1975\x0A77⥹\x197B\x0A7D\xF47F\xEB81\xEA83\xE185뚇뚉ꎋ\xD98D잏펑\xDA93킕ﶗﮙ\xE89B\xEB9D튟잡힣颥", A_1);
                        str1 = string.Concat(strArray2);
                        num1 = 2;
                        continue;
                    case 31:
                        num1 = 35;
                        continue;
                    case 33:
                        strArray1[14] = flag2 ? Module.a("❇⑉", A_1) : Module.a("❇ⱉ⩋", A_1);
                        strArray1[15] = Module.a("瑇敉ᭋ͍᥏汑桓ၕ楗橙扛", A_1);
                        num1 = 1;
                        continue;
                    case 34:
                        if (!(str3 == Module.a("ཇᩉὋ", A_1)))
                        {
                            num1 = 24;
                            continue;
                        }
                        goto case 2;
                    case 35:
                        if (!(str3 == Module.a("ੇ♉㥋\x2B4D\x244F㵑㭓≕し", A_1)))
                        {
                            num1 = 10;
                            continue;
                        }
                        goto case 2;
                    case 36:
                        if (!(str3 == Module.a("\x1F47ىോM", A_1)))
                        {
                            num1 = 31;
                            continue;
                        }
                        bit1 = Utility.GetBit((byte)wirelessDeviceIDInfo.I, 0);
                        num1 = 8;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_51:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("େ㡉⥋⽍\x244F㝑ၓ㍕\x2E57㍙㽛㭝\x2E5Fൡcͥ", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗", A_1));
            return str1;
        }

        private enReturnCode GetDeviceInfoXmlLegacy(out XmlDocument xdocDeviceInfo)
        {
            int A_1 = 10;
            label_2:
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓ቕ㵗ⱙ㕛㵝՟\x2B61\x0A63eݧ㉩ūɭ㱯\x1771\x1373\x1775᭷\x0379", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            xdocDeviceInfo = (XmlDocument)null;
            enReturnCode enReturnCode = this.RefreshStructsFromDeviceInfoLegacy();
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
                        enReturnCode = this.BuildDeviceInfoXmlFromStructs(out xdocDeviceInfo);
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_7:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᝏ㝑⁓ቕ㵗ⱙ㕛㵝՟\x2B61\x0A63eݧ㉩ūɭ㱯\x1771\x1373\x1775᭷\x0379", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ", A_1));
            return enReturnCode;
        }

        private enReturnCode RefreshStructsFromDeviceInfo()
        {
            int A_1 = 3;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᭈ\x2E4A⭌㵎㑐⁒㵔іⵘ⥚⡜㱞ᕠၢ⍤ᕦ٨٪⥬੮ݰᩲᙴቶへᕺ᭼ၾ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num = 6;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        enReturnCode = this.AA();
                        num = 7;
                        continue;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                        goto label_12;
                    case 2:
                        enReturnCode = this.RefreshStructsFromDeviceInfoLegacy();
                        if (1 == 0)
                            ;
                        num = 5;
                        continue;
                    case 4:
                        if (!this.BWirelessLegacySupported)
                        {
                            enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            num = 3;
                            continue;
                        }
                        num = 2;
                        continue;
                    case 6:
                        num = !this.A1 ? 9 : 0;
                        continue;
                    case 8:
                        enReturnCode = this.RefreshStructsFromDeviceInfoW4();
                        num = 1;
                        continue;
                    case 9:
                        num = !this.BWireless4Supported ? 4 : 8;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_12:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᭈ\x2E4A⭌㵎㑐⁒㵔іⵘ⥚⡜㱞ᕠၢ⍤ᕦ٨٪⥬੮ݰᩲᙴቶへᕺ᭼ၾ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDeviceInfoW4FromBIOS(out byte[] abyDeviceInfo)
        {
            int A_1 = 8;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("्㕏♑ၓ㍕\x2E57㍙㽛㭝⥟ౡɣ॥㽧幩⩫ᱭὯά㙳㽵㝷⥹", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
            enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
            byte[] dataOut = (byte[])null;
            abyDeviceInfo = (byte[])null;
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
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("्㕏♑ၓ㍕\x2E57㍙㽛㭝⥟ౡɣ॥㽧幩⩫ᱭὯά㙳㽵㝷⥹", A_1), Module.a("ݍ㹏\x2151⁓㝕㙗\x2E59㕛㽝ᑟୡୣ\x0865䡧թ੫乭❯άᵳ㑵ㅷ㕹⽻㵽\xEC7F\xEB81\xE183\xE885ﲇꪉﺋ\xEB8D\xE48F\xE791\xE693\xF895ﶗﺙ벛\xF09D햟캡좣", A_1));
                        num = 2;
                        continue;
                    case 1:
                    case 2:
                        goto label_12;
                    case 3:
                        abyDeviceInfo = dataOut;
                        this.log.DearAby(abyDeviceInfo, Module.a("्㕏♑ၓ㍕\x2E57㍙㽛㭝⥟ౡɣ॥㽧幩⩫ᱭὯά㙳㽵㝷⥹剻\x0A7D\xF87F\xF681", A_1));
                        num = 1;
                        continue;
                    case 4:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetWirelessDeviceInfo, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 6;
                        continue;
                    case 5:
                        goto label_6;
                    case 6:
                        if (enReturnCode != enReturnCode.e_OK)
                        {
                            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("्㕏♑ၓ㍕\x2E57㍙㽛㭝⥟ౡɣ॥㽧幩⩫ᱭὯά㙳㽵㝷⥹", A_1), Module.a("୍≏⁑㭓\x2455硗橙\x245B╝偟ὡ䑣eᩧթū乭㉯㭱㭳╵塷\x2D79ㅻ㝽ꁿ\xE181\xE583\xEA85\xE487ꪉ\xDE8B\xEB8D\xF18F\xF691뮓\xA795\xDA97\xF299벛\xE99D좟쮡좣쎥袧충즫\xDAAD쒯\xDBB1\xDAB3통颷\xEDB9햻첽ꖿ껁ꇃ뗅믇\xEAC9ꗋꃍ뛏뷑", A_1), (object)enReturnCode);
                            num = 5;
                            continue;
                        }
                        num = 3;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_6:
            if (1 == 0)
                ;
            label_12:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("्㕏♑ၓ㍕\x2E57㍙㽛㭝⥟ౡɣ॥㽧幩⩫ᱭὯά㙳㽵㝷⥹", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg偩䱫", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode RefreshStructsFromDeviceInfoLegacy()
        {
            int A_1 = 6;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ṋ\x2B4D㙏⁑ㅓ╕しख़⡛ⱝᕟšၣᕥ\x2E67ᡩͫͭ㑯\x1771ɳή᭷ό㕻ၽ\xE67F\xED81좃\xE385\xEF87\xEB89\xEF8B\xF78D", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗", A_1));
            byte[] abyStateInfo = (byte[])null;
            enReturnCode enReturnCode = this.GetDeviceStateLegacyFromBIOS(out abyStateInfo);
            int num1 = 24;
            bool flag = false;
            byte[] abyDeviceInfo = null;
            bool bit1 = false;
            bool bit2 = false;
            bool bit3 = false;
            int index = 0;
            CommandWireless.D d = new CommandWireless.D();
            byte num2 = 0;
            byte num3 = 0;
            int num4 = 0;
            while (true)
            {
            
                switch (num1)
                {
                    case 0:
                        num1 = 7;
                        continue;
                    case 1:
                        num1 = !(d.C == Module.a("\x1C4B്᥏", A_1)) ? 8 : 10;
                        continue;
                    case 2:
                    case 16:
                    case 31:
                    case 38:
                        num1 = 1;
                        continue;
                    case 3:
                        switch (num3)
                        {
                            case (byte)1:
                                d.A = Module.a("ᭋɍᅏ᱑", A_1);
                                d.H = (byte)0;
                                num1 = 11;
                                continue;
                            case (byte)2:
                                d.A = Module.a("๋≍╏㝑⁓㥕㝗\x2E59㑛", A_1);
                                d.H = (byte)1;
                                this.C1.E = d;
                                num1 = 38;
                                continue;
                            case (byte)3:
                                d.A = Module.a("ᭋ᥍ᅏ᱑", A_1);
                                d.H = (byte)2;
                                d.I = (ushort)(((int)abyStateInfo[3] & 240) >> 4);
                                this.C1.D = d;
                                num1 = 31;
                                continue;
                            default:
                                num1 = 5;
                                continue;
                        }
                    case 4:
                        d.F = BitConverter.ToUInt16(abyDeviceInfo, index + 6);
                        d.G = BitConverter.ToUInt16(abyDeviceInfo, index + 8);
                        num1 = 44;
                        continue;
                    case 5:
                        num1 = 2;
                        continue;
                    case 6:
                        if (flag)
                        {
                            num1 = 21;
                            continue;
                        }
                        goto label_65;
                    case 7:
                        d.C = string.Format(Module.a("᥋⁍㭏㱑㭓\x2155㙗牙❛湝\x1D5F䭡", A_1), (object)abyDeviceInfo[index]);
                        num1 = 20;
                        continue;
                    case 8:
                        if (d.C == Module.a("᥋\x1D4D\x124F", A_1))
                        {
                            num1 = 47;
                            continue;
                        }
                        goto label_65;
                    case 9:
                        if (1 == 0)
                            ;
                        this.F1.A = Utility.GetBit(abyStateInfo[1], 0);
                        this.F1.Bb = Utility.GetBit(abyStateInfo[1], 1);
                        this.F1.C = Utility.GetBit(abyStateInfo[1], 2);
                        this.F1.D = Utility.GetBit(abyStateInfo[1], 3);
                        this.F1.E = Utility.GetBit(abyStateInfo[2], 0);
                        this.F1.F = Utility.GetBit(abyStateInfo[2], 1);
                        this.F1.G = Utility.GetBit(abyStateInfo[2], 2);
                        this.F1.H = Utility.GetBit(abyStateInfo[2], 3);
                        this.F1.I = Utility.GetBit(abyStateInfo[3], 0);
                        this.F1.J = Utility.GetBit(abyStateInfo[3], 1);
                        this.F1.K = Utility.GetBit(abyStateInfo[3], 2);
                        this.F1.L = Utility.GetBit(abyStateInfo[3], 3);
                        this.F1.M = false;
                        this.F1.N = false;
                        this.F1.O = false;
                        this.F1.P = false;
                        flag = false;
                        num1 = 43;
                        continue;
                    case 10:
                        index += 10;
                        num1 = 36;
                        continue;
                    case 11:
                        if (((int)abyStateInfo[0] & 8) != 0)
                        {
                            num1 = 30;
                            continue;
                        }
                        d.I = (ushort)0;
                        num1 = 18;
                        continue;
                    case 12:
                        num4 = 0;
                        break;
                    case 13:
                    case 15:
                    case 36:
                        num1 = 34;
                        continue;
                    case 14:
                    case 20:
                    case 39:
                        d.D1 = BitConverter.ToUInt16(abyDeviceInfo, index + 2);
                        d.E = BitConverter.ToUInt16(abyDeviceInfo, index + 4);
                        num1 = 48;
                        continue;
                    case 17:
                        if (this.C1 == null)
                        {
                            num1 = 41;
                            continue;
                        }
                        goto case 22;
                    case 18:
                    case 25:
                    case 42:
                        this.C1.F = d;
                        num1 = 16;
                        continue;
                    case 19:
                        switch (num2)
                        {
                            case (byte)1:
                                d.C = Module.a("\x1C4B്᥏", A_1);
                                num1 = 14;
                                continue;
                            case (byte)2:
                                d.C = Module.a("᥋\x1D4D\x124F", A_1);
                                num1 = 39;
                                continue;
                            default:
                                num1 = 0;
                                continue;
                        }
                    case 21:
                        abyDeviceInfo = (byte[])null;
                        enReturnCode = this.GetDeviceInfoLegacyFromBIOS(out abyDeviceInfo);
                        num1 = 27;
                        continue;
                    case 22:
                        num1 = 28;
                        continue;
                    case 23:
                        goto label_65;
                    case 24:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 9;
                            continue;
                        }
                        goto label_65;
                    case 26:
                        bit1 = Utility.GetBit(abyStateInfo[0], 0);
                        bit2 = Utility.GetBit(abyStateInfo[0], 1);
                        bit3 = Utility.GetBit(abyStateInfo[0], 2);
                        num1 = 29;
                        continue;
                    case 27:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 26;
                            continue;
                        }
                        goto label_65;
                    case 28:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 37;
                            continue;
                        }
                        goto label_65;
                    case 29:
                        num1 = bit1 ? 45 : 35;
                        continue;
                    case 30:
                        num1 = 46;
                        continue;
                    case 32:
                        d.I = (ushort)(((int)abyStateInfo[1] & 16) >> 4);
                        num1 = 42;
                        continue;
                    case 33:
                    case 44:
                        num3 = abyDeviceInfo[index + 1];
                        num1 = 3;
                        continue;
                    case 34:
                        if ((int)abyDeviceInfo[index] != 0)
                        {
                            d = new CommandWireless.D();
                            d.B = true;
                            num2 = abyDeviceInfo[index];
                            num1 = 19;
                            continue;
                        }
                        num1 = 23;
                        continue;
                    case 35:
                        num1 = 12;
                        continue;
                    case 37:
                        num1 = 6;
                        continue;
                    case 40:
                        flag = true;
                        this.C1 = new CommandWireless.A();
                        num1 = 17;
                        continue;
                    case 41:
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ṋ\x2B4D㙏⁑ㅓ╕しख़⡛ⱝᕟšၣᕥ\x2E67ᡩͫͭ㑯\x1771ɳή᭷ό㕻ၽ\xE67F\xED81좃\xE385\xEF87\xEB89\xEF8B\xF78D", A_1), Module.a("Ջ⁍⍏♑㕓㡕ⱗ㍙㵛⩝य़ൡ\x0A63䙥ݧ౩䱫㥭\x196Fqᅳ᩵ᵷॹཻ\x2D7D\xF47F\xE381\xF083\xEF85\xEB87쎉\xE28B\xE88Dﾏ늑\xE693\xF395\xEC97\xEF99\xEE9B\xF09D얟욡蒣좥\xDDA7용삫", A_1));
                        num1 = 22;
                        continue;
                    case 43:
                        if (this.C1 == null)
                        {
                            num1 = 40;
                            continue;
                        }
                        goto case 22;
                    case 45:
                        num4 = 1;
                        break;
                    case 46:
                        if (((int)abyStateInfo[0] & 16) != 0)
                        {
                            num1 = 32;
                            continue;
                        }
                        d.I = (ushort)0;
                        num1 = 25;
                        continue;
                    case 47:
                        index += 6;
                        num1 = 15;
                        continue;
                    case 48:
                        if (d.C == Module.a("\x1C4B്᥏", A_1))
                        {
                            num1 = 4;
                            continue;
                        }
                        d.F = (ushort)0;
                        d.G = (ushort)0;
                        num1 = 33;
                        continue;
                    default:
                        goto label_2;
                }
                int num5 = bit2 ? 1 : 0;
                byte num6 = (byte)(num4 + num5 + (bit3 ? 1 : 0));
                this.C1.B = Utility.GetBit(abyStateInfo[0], 6);
                this.C1.C = Utility.GetBit(abyStateInfo[0], 7);
                this.C1.Aa = num6;
                index = 0;
                num1 = 13;
            }
            label_65:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᭋ❍≏㝑㡓㍕⭗⥙ᕛそٟൡᙣ\x0B65१ṩիŭṯ\x2071ᅳၵ\x0A77όཻᙽ챿\xE781\xE383\xE785\xEB87\xF389", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65䡧ᅩ屫\x136D", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDeviceStateLegacyFromBIOS(out byte[] abyStateInfo)
        {
            int A_1 = 7;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ੌ⩎═ᝒご\x2156じ㡚㡜\x0C5Eᕠɢᅤɦ╨\x0E6A੬\x0E6Eተੲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘", A_1));
            enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
            byte[] dataOut = (byte[])null;
            abyStateInfo = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                    case 5:
                        goto label_12;
                    case 2:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ੌ⩎═ᝒご\x2156じ㡚㡜\x0C5Eᕠɢᅤɦ╨\x0E6A੬\x0E6Eተੲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("ьⅎ≐❒㑔㥖ⵘ\x325A㱜\x2B5E\x0860ౢ\x0B64䝦٨൪䵬㡮ᱰᩲ㝴㹶㙸⡺㹼\x137E\xE880\xE682\xEB84\xF386ꦈ力\xE88Cﮎ\xE490\xE192ﮔ\xF296ﶘ뮚\xF39C\xEA9E춠쾢", A_1));
                        num = 1;
                        continue;
                    case 3:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.WirelessState, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 6;
                        continue;
                    case 4:
                        if (1 == 0)
                            ;
                        abyStateInfo = dataOut;
                        this.log.DearAby(abyStateInfo, Module.a("ੌ⩎═ᝒご\x2156じ㡚㡜\x0C5Eᕠɢᅤɦ╨\x0E6A੬\x0E6Eተੲ㍴նᙸᙺ㽼㙾캀킂\xAB84\xF386\xF188ﾊ", A_1));
                        num = 5;
                        continue;
                    case 6:
                        if (enReturnCode != enReturnCode.e_OK)
                        {
                            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ੌ⩎═ᝒご\x2156じ㡚㡜\x0C5Eᕠɢᅤɦ╨\x0E6A੬\x0E6Eተੲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("ࡌ㵎⍐㱒❔睖楘⍚♜潞ᱠ䍢ͤᕦ٨٪䵬\x2D6E㡰㱲♴坶\x2E78㙺㑼彾\xE280\xE282\xE984\xEB86ꦈ\xD98A\xE88C\xEE8E\xF590벒ꖔꊖ\xF198뮚\xEA9C\xF79E좠쾢삤螦캨캪\xD9AC\xDBAE\xD8B0\xDDB2튴鞶\xEEB8튺쾼\xDABE귀ꛂ뛄듆\xE9C8ꋊꏌ\xA9CE뻐", A_1), (object)enReturnCode);
                            num = 0;
                            continue;
                        }
                        num = 4;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_12:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ੌ⩎═ᝒご\x2156じ㡚㡜\x0C5Eᕠɢᅤɦ╨\x0E6A੬\x0E6Eተੲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས卨䭪", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode GetDeviceInfoLegacyFromBIOS(out byte[] abyDeviceInfo)
        {
            int A_1 = 15;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⍮ᑰᑲᑴᑶx㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
            enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
            byte[] dataOut = (byte[])null;
            abyDeviceInfo = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 5;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 3:
                    case 4:
                        goto label_12;
                    case 1:
                        abyDeviceInfo = dataOut;
                        this.log.DearAby(abyDeviceInfo, Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⍮ᑰᑲᑴᑶx㵺ོၾ\xEC80솂첄좆\xDA88ꖊ歷\xF78E\xE590", A_1));
                        num = 0;
                        continue;
                    case 2:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.WirelessDeviceIDs, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 6;
                        continue;
                    case 5:
                        if (wmiBiosClient != null)
                        {
                            num = 2;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⍮ᑰᑲᑴᑶx㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("᱔㥖⩘⽚㱜ㅞᕠ\x0A62Ѥ፦hѪͬ佮Ṱᕲ啴\x2076ᑸቺ㽼㙾캀킂욄\xEB86\xE088\xEE8A\xE38Cﮎ놐\xE192\xF094\xE396\xEC98\xE99A\xF39C爵얠莢쮤튦얨잪", A_1));
                        num = 4;
                        continue;
                    case 6:
                        if (enReturnCode != enReturnCode.e_OK)
                        {
                            if (1 == 0)
                                ;
                            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⍮ᑰᑲᑴᑶx㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("ၔ╖⭘㑚⽜罞兠᭢Ṥ坦ᑨ䭪୬ᵮṰṲ啴㕶へ㑺\x2E7C彾횀캂첄Ꞇ\xEA88\xEA8A\xE18C\xE38E놐솒\xF094\xF696ﶘ뒚궜\xDA9E즠莢튤쾦삨잪좬辮횰횲솴쎶킸햺\xDABC龾雀ꫂ럄ꋆꗈ껊뻌볎\xF1D0뫒믔뇖뛘", A_1), (object)enReturnCode);
                            num = 3;
                            continue;
                        }
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_12:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ቔ\x3256ⵘ\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ⍮ᑰᑲᑴᑶx㵺ོၾ\xEC80솂첄좆\xDA88", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode WirelessStateRefreshLegacy()
        {
            int A_1 = 0;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅅⅇ㡉⥋≍㕏\x2151❓Օⱗ㭙⡛㭝\x325Fݡɣᑥ൧ᥩѫ≭ᕯᕱᕳᕵŷ", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
            byte[] dataOut = (byte[])null;
            enReturnCode enReturnCode = new WmiBIOSClient().ExecMethodClient(enBIOSCommands.Read, enReadCmdType.WirelessState, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                        goto label_7;
                    case 2:
                        this.F1.A = Utility.GetBit(dataOut[1], 0);
                        this.F1.Bb = Utility.GetBit(dataOut[1], 1);
                        this.F1.C = Utility.GetBit(dataOut[1], 2);
                        this.F1.D = Utility.GetBit(dataOut[1], 3);
                        this.F1.E = Utility.GetBit(dataOut[2], 0);
                        this.F1.F = Utility.GetBit(dataOut[2], 1);
                        this.F1.G = Utility.GetBit(dataOut[2], 2);
                        this.F1.H = Utility.GetBit(dataOut[2], 3);
                        this.F1.I = Utility.GetBit(dataOut[3], 0);
                        this.F1.J = Utility.GetBit(dataOut[3], 1);
                        this.F1.K = Utility.GetBit(dataOut[3], 2);
                        this.F1.L = Utility.GetBit(dataOut[3], 3);
                        num = 0;
                        continue;
                    case 3:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 2;
                            continue;
                        }
                        this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᅅⅇ㡉⥋≍㕏\x2151❓ὕ㙗㱙㍛ⱝ\x0D5F͡ၣཥݧѩ㹫୭ᙯqᅳյၷ", A_1), Module.a("ͅ㩇㡉⍋㱍灏扑ⱓⵕ桗❙籛㡝\x125Fൡॣ䙥⩧⍩⍫㵭偯╱㥳㽵塷\x1979ᵻች\xEC7Fꊁ횃\xE385\xE987\xEE89ꎋ뺍ꖏ晴뒓\xE195\xF097\xF399\xF09Bﮝ肟얡솣튥\xDCA7쎩슫즭邯\xE5B1\xDDB3쒵\xDDB7횹\xD9BB춽뎿\xE2C1럃닅꧇뻉꧋", A_1), (object)enReturnCode);
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_7:
            if (1 == 0)
                ;
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᅅⅇ㡉⥋≍㕏\x2151❓Օⱗ㭙⡛㭝\x325Fݡɣᑥ൧ᥩѫ≭ᕯᕱᕳᕵŷ", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ὣ噥ᕧ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode WirelessStateRefresh()
        {
            int A_1 = 12;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ց㵓\x2455㵗㙙㥛ⵝ፟ㅡၣݥᱧཀྵ㹫୭ᙯqᅳյၷ", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
            enReturnCode enReturnCode = this.WirelessStateRefreshLegacy();
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Ց㵓\x2455㵗㙙㥛ⵝ፟ㅡၣݥᱧཀྵ㹫୭ᙯqᅳյၷ", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static enReturnCode GetWirelessSupportedFromBIOS(ref bool bSupported)
        {
            int A_1 = 6;
            label_2:
            CaslLogger caslLogger = new CaslLogger();
            caslLogger.TraceInMessage(Module.a("ཋ⽍⍏㹑͓㭕ㅗ瑙Ὓㅝ\x0D5Fཡգ\x0865౧㵩իᱭᕯṱᅳյ\x0B77", A_1), Module.a("ୋ\x2B4D\x244FՑ㵓\x2455㵗㙙㥛ⵝ፟ㅡᅣᙥᡧթṫᩭᕯᙱ㉳ѵ\x1777\x1779㹻㝽콿톁", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗", A_1));
            enReturnCode supportedFromBios = CommandWireless.GetWireless4SupportedFromBIOS(ref bSupported);
            int num = 4;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (!bSupported)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_10;
                    case 1:
                        num = 0;
                        continue;
                    case 2:
                        supportedFromBios = CommandWireless.GetWirelessLegacySupportedFromBIOS(ref bSupported);
                        num = 3;
                        continue;
                    case 3:
                        goto label_6;
                    case 4:
                        if (supportedFromBios == enReturnCode.e_OK)
                        {
                            num = 1;
                            continue;
                        }
                        goto case 2;
                    default:
                        goto label_2;
                }
            }
            label_6:
            if (1 == 0)
                ;
            label_10:
            caslLogger.FormatTraceOutMessage(Module.a("ཋ⽍⍏㹑͓㭕ㅗ瑙Ὓㅝ\x0D5Fཡգ\x0865౧㵩իᱭᕯṱᅳյ\x0B77", A_1), Module.a("ୋ\x2B4D\x244FՑ㵓\x2455㵗㙙㥛ⵝ፟ㅡᅣᙥᡧթṫᩭᕯᙱ㉳ѵ\x1777\x1779㹻㝽콿톁", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65䡧ᅩ屫\x136D", A_1), (object)supportedFromBios.ToString());
            return supportedFromBios;
        }

        public static enReturnCode GetWireless4SupportedFromBIOS(ref bool bSupported)
        {
            int A_1 = 5;
            label_2:
            CaslLogger caslLogger = new CaslLogger();
            caslLogger.TraceInMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㹨ɪὬ੮ᵰᙲٴѶ", A_1), Module.a("ొ⡌㭎ِ㩒❔\x3256㕘㹚\x2E5Cⱞ啠ぢၤᝦᥨѪὬ᭮ᑰᝲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] dataOut = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 5;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                    case 3:
                    case 4:
                        goto label_14;
                    case 2:
                        bSupported = false;
                        num = 1;
                        continue;
                    case 5:
                        if (wmiBiosClient != null)
                        {
                            num = 6;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        caslLogger.ErrorMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㹨ɪὬ੮ᵰᙲٴѶ", A_1), Module.a("ొ⡌㭎ِ㩒❔\x3256㕘㹚\x2E5Cⱞ啠ぢၤᝦᥨѪὬ᭮ᑰᝲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("Ɋ⍌㱎═\x3252㭔⍖じ㩚⥜㙞\x0E60ൢ䕤\x0866ཨ䭪㩬ɮᡰㅲ㱴㡶⩸㡺ᅼᙾ\xE480\xED82\xF184Ꞇﮈ\xEE8A歷搜\xE390ﶒ\xF094\xF396릘\xF59A\xE89C\xF39E춠", A_1));
                        num = 0;
                        continue;
                    case 6:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetWirelessDeviceInfo, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_128);
                        num = 8;
                        continue;
                    case 7:
                        if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
                        {
                            caslLogger.FormatErrorMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㹨ɪὬ੮ᵰᙲٴѶ", A_1), Module.a("ొ⡌㭎ِ㩒❔\x3256㕘㹚\x2E5Cⱞ㉠ᙢᕤᝦ٨ᥪᥬ੮ᕰ㕲ݴᡶᑸ㥺㑼ま튀", A_1), Module.a("๊㽌㵎㹐\x2152畔杖\x2158⁚浜≞䅠բᝤ\x0866Ѩ䭪⽬♮㹰\x2072啴\x2076㑸㉺嵼᱾\xE080\xEF82\xE984Ꞇ\xDB88\xEE8A\xEC8C\xEB8E뺐ꊒ힔ﾖ릘\xEC9A\xF59C\xF69E춠욢薤삦첨\xDFAA\xD9AC욮\xDFB0풲閴\xE0B6킸즺\xD8BC펾꓀냂뛄\xE7C6뫈뿊곌믎듐", A_1), (object)enReturnCode);
                            num = 3;
                            continue;
                        }
                        num = 2;
                        continue;
                    case 8:
                        num = enReturnCode != enReturnCode.e_OK ? 7 : 9;
                        continue;
                    case 9:
                        bSupported = true;
                        if (1 == 0)
                            ;
                        num = 4;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_14:
            caslLogger.FormatTraceOutMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㹨ɪὬ੮ᵰᙲٴѶ", A_1), Module.a("ొ⡌㭎ِ㩒❔\x3256㕘㹚\x2E5Cⱞ啠ぢၤᝦᥨѪὬ᭮ᑰᝲ㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64䝦ቨ孪ၬ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static enReturnCode GetWirelessLegacySupportedFromBIOS(ref bool bSupported)
        {
            int A_1 = 11;
            label_2:
            if (1 == 0)
                ;
            CaslLogger caslLogger = new CaslLogger();
            caslLogger.TraceInMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㡮ᡰŲၴ᭶\x1C78\x087A\x0E7C", A_1), Module.a("ᙐ㙒\x2154Vじ⥚㡜㍞Ѡၢᙤ\x2B66౨౪౬౮\x0870\x2072tݶ\x0978ᑺོ\x0B7E\xE480\xE782쎄\xF586\xE688\xE68A쾌욎\xDE90삒", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] dataOut = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        bSupported = true;
                        num = 1;
                        continue;
                    case 1:
                    case 4:
                    case 5:
                    case 6:
                        goto label_14;
                    case 2:
                        if (wmiBiosClient != null)
                        {
                            num = 3;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        caslLogger.ErrorMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㡮ᡰŲၴ᭶\x1C78\x087A\x0E7C", A_1), Module.a("ᙐ㙒\x2154Vじ⥚㡜㍞Ѡၢᙤ\x2B66౨౪౬౮\x0870\x2072tݶ\x0978ᑺོ\x0B7E\xE480\xE782쎄\xF586\xE688\xE68A쾌욎\xDE90삒", A_1), Module.a("ᡐ㵒♔⍖㡘㕚⥜㙞`ᝢ\x0C64\x0866ݨ䭪ɬ८兰\x2472ᡴṶ㭸㉺㉼Ȿ슀\xEF82\xEC84\xE286\xE788ﾊ권ﶎ\xF490\xE792\xE094\xE596\xF798ﺚ列뾞쾠횢즤쮦", A_1));
                        num = 5;
                        continue;
                    case 3:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.WirelessState, (byte[])null, 0U, out dataOut, enSizeOut.eSIZE_4);
                        num = 7;
                        continue;
                    case 7:
                        num = enReturnCode != enReturnCode.e_OK ? 9 : 0;
                        continue;
                    case 8:
                        bSupported = false;
                        num = 4;
                        continue;
                    case 9:
                        if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
                        {
                            caslLogger.FormatErrorMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㡮ᡰŲၴ᭶\x1C78\x087A\x0E7C", A_1), Module.a("ᙐ㙒\x2154Vじ⥚㡜㍞Ѡၢᙤ\x2B66౨౪౬౮\x0870\x2072tݶ\x0978ᑺོ\x0B7E\xE480\xE782쎄\xF586\xE688\xE68A쾌욎\xDE90삒", A_1), Module.a("ᑐ\x2152❔㡖⭘筚浜❞᩠卢ᡤ䝦ཨᥪɬɮ兰ㅲ㱴㡶⩸孺⩼㉾좀ꎂ\xE684\xE686\xE588\xE78A권\xDD8E\xF490\xF292\xF194뢖ꦘ꺚\xF59C뾞횠쮢첤쮦첨讪쪬쪮얰잲\xDCB4\xD9B6\xDEB8鮺\xEABC횾돀ꛂ꧄ꋆ뫈룊\xEDCC볎ꗐ닒ꇔ닖", A_1), (object)enReturnCode);
                            num = 6;
                            continue;
                        }
                        num = 8;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_14:
            caslLogger.FormatTraceOutMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㡮ᡰŲၴ᭶\x1C78\x087A\x0E7C", A_1), Module.a("ᙐ㙒\x2154Vじ⥚㡜㍞Ѡၢᙤ\x2B66౨౪౬౮\x0870\x2072tݶ\x0978ᑺོ\x0B7E\xE480\xE782쎄\xF586\xE688\xE68A쾌욎\xDE90삒", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᑮ䅰\x0E72", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode WirelessInformationGet(string sCommandName, out object dataOut)
        {
            int A_1 = 13;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("R\x2154㙖⭘⽚㡜㭞", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            dataOut = (object)null;
            int num1 = 88;
            XmlDocument xmlDocument1=null;
            string key1=null;
            int num2=0;
            string DataValueName=null;
            object pData=null;
            CaslEventContainerClass eventContainerClass=null;
            XmlDocument xmlDocument2=null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        if ((int)this.C1.G.G != 0)
                        {
                            num1 = 101;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 50;
                        continue;
                    case 1:
                        if ((int)this.C1.G.D1 != 0)
                        {
                            num1 = 44;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 107;
                        continue;
                    case 2:
                    case 5:
                    case 6:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 23:
                    case 24:
                    case 29:
                    case 30:
                    case 32:
                    case 33:
                    case 34:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                    case 45:
                    case 47:
                    case 50:
                    case 54:
                    case 55:
                    case 57:
                    case 59:
                    case 63:
                    case 65:
                    case 71:
                    case 73:
                    case 74:
                    case 80:
                    case 82:
                    case 83:
                    case 85:
                    case 93:
                    case 94:
                    case 96:
                    case 99:
                    case 100:
                    case 103:
                    case 107:
                    case 110:
                    case 112:
                    case 118:
                    case 122:
                    case 123:
                    case (int)sbyte.MaxValue:
                    case 130:
                    case 131:
                        goto label_180;
                    case 3:
                        try
                        {
                            eventContainerClass.GetData(sCommandName, DataValueName, out pData);
                        }
                        catch (COMException ex)
                        {
                            this.log.InformationMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("ቒ畔ᑖᙘᙚ絜ᩞᥠbdᝦ\x1D68ɪɬŮ兰ᱲᙴᑶ\x0C78ॺོ\x1A7E\xE580ꎂ뾄Ꞇ", A_1) + ex.Message + Module.a("罒畔㽖⭘慚絜", A_1) + ex.ErrorCode.ToString(Module.a("\x0B52", A_1)));
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        }
                        catch (Exception ex)
                        {
                            this.log.InformationMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("ቒ㭔睖᱘⍚㹜㩞ᅠᝢ\x0C64\x0866ݨ䭪ɬ౮ተٲݴն\x1C78ὺ嵼䕾ꆀ", A_1) + ex.Message);
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        }
                        num1 = 106;
                        continue;
                    case 4:
                        dataOut = (object)this.C1.D.C;
                        num1 = 73;
                        continue;
                    case 7:
                        dataOut = (object)this.C1.F.F;
                        num1 = 110;
                        continue;
                    case 8:
                        switch (num2)
                        {
                            case 0:
                                dataOut = (object)(this.bWirelessSupported ? 1 : 0);
                                enReturnCode = enReturnCode.e_OK;
                                num1 = 29;
                                continue;
                            case 1:
                                xmlDocument1 = (XmlDocument)null;
                                enReturnCode = this.GetDeviceInfoXml(out xmlDocument1);
                                num1 = 108;
                                continue;
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                num1 = 49;
                                continue;
                            case 6:
                                dataOut = (object)(this.E1 ? 1 : 0);
                                num1 = 82;
                                continue;
                            case 7:
                                this.D1 = this.RefreshStructsFromDeviceInfo();
                                num1 = 94;
                                continue;
                            case 8:
                                dataOut = (object)(this.C1.F.B ? 1 : 0);
                                num1 = 54;
                                continue;
                            case 9:
                                num1 = 26;
                                continue;
                            case 10:
                                num1 = 128;
                                continue;
                            case 11:
                                num1 = 40;
                                continue;
                            case 12:
                                num1 = 9;
                                continue;
                            case 13:
                                num1 = 46;
                                continue;
                            case 14:
                                dataOut = (object)(this.C1.E.B ? 1 : 0);
                                num1 = 71;
                                continue;
                            case 15:
                                num1 = 115;
                                continue;
                            case 16:
                                num1 = 121;
                                continue;
                            case 17:
                                num1 = 58;
                                continue;
                            case 18:
                                num1 = 109;
                                continue;
                            case 19:
                                num1 = 31;
                                continue;
                            case 20:
                                dataOut = (object)(this.C1.D.B ? 1 : 0);
                                num1 = 96;
                                continue;
                            case 21:
                                num1 = 76;
                                continue;
                            case 22:
                                num1 = 56;
                                continue;
                            case 23:
                                num1 = 35;
                                continue;
                            case 24:
                                num1 = 111;
                                continue;
                            case 25:
                                num1 = 86;
                                continue;
                            case 26:
                                dataOut = (object)(this.C1.C ? 1 : 0);
                                num1 = 99;
                                continue;
                            case 27:
                                num1 = 19;
                                continue;
                            case 28:
                                num1 = 1;
                                continue;
                            case 29:
                                num1 = 51;
                                continue;
                            case 30:
                                num1 = 102;
                                continue;
                            case 31:
                                num1 = 0;
                                continue;
                            default:
                                num1 = 124;
                                continue;
                        }
                    case 9:
                        if ((int)this.C1.F.F == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 11;
                            continue;
                        }
                        num1 = 7;
                        continue;
                    case 15:
                        dataOut = (object)this.C1.D.F;
                        num1 = 80;
                        continue;
                    case 16:
                        dataOut = (object)this.C1.D.E;
                        num1 = 112;
                        continue;
                    case 17:
                        num1 = 98;
                        continue;
                    case 18:
                        dataOut = (object)this.C1.E.G;
                        num1 = 123;
                        continue;
                    case 19:
                        if (this.C1.G.C == null)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 45;
                            continue;
                        }
                        num1 = 114;
                        continue;
                    case 20:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.H.TryGetValue(key1, out num2))
                        {
                            num1 = 21;
                            continue;
                        }
                        goto case 81;
                    case 21:
                        num1 = 8;
                        continue;
                    case 22:
                        enReturnCode = enReturnCode.e_OK;
                        num1 = 92;
                        continue;
                    case 25:
                    case 79:
                        xmlDocument2 = new XmlDocument();
                        //     eventContainerClass = new CaslEventContainerClass();???
                        pData = (object)null;
                        num1 = 3;
                        continue;
                    case 26:
                        if (this.C1.F.C == null)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 118;
                            continue;
                        }
                        num1 = 68;
                        continue;
                    case 27:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 117;
                            continue;
                        }
                        goto label_180;
                    case 28:
                        goto label_147;
                    case 31:
                        if ((int)this.C1.E.G != 0)
                        {
                            num1 = 18;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 24;
                        continue;
                    case 35:
                        if ((int)this.C1.D.E != 0)
                        {
                            num1 = 16;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 14;
                        continue;
                    case 40:
                        if ((int)this.C1.F.E == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 100;
                            continue;
                        }
                        num1 = 48;
                        continue;
                    case 41:
                        enReturnCode = this.RefreshStructsFromDeviceInfo();
                        num1 = 77;
                        continue;
                    case 42:
                        num1 = 97;
                        continue;
                    case 43:
                        if (!(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾쾀\xEC82욄\xE686\xEA88\xE38A\xE88C", A_1) == sCommandName))
                        {
                            num1 = 66;
                            continue;
                        }
                        goto case 120;
                    case 44:
                        dataOut = (object)this.C1.G.D1;
                        num1 = 122;
                        continue;
                    case 46:
                        if ((int)this.C1.F.G == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 65;
                            continue;
                        }
                        num1 = 129;
                        continue;
                    case 48:
                        dataOut = (object)this.C1.F.E;
                        num1 = 55;
                        continue;
                    case 49:
                        if (this.A1)
                        {
                            num1 = 60;
                            continue;
                        }
                        DataValueName = string.Empty;
                        num1 = 43;
                        continue;
                    case 51:
                        if ((int)this.C1.G.E == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 2;
                            continue;
                        }
                        num1 = 53;
                        continue;
                    case 52:
                        num1 = 67;
                        continue;
                    case 53:
                        dataOut = (object)this.C1.G.E;
                        num1 = 131;
                        continue;
                    case 56:
                        if ((int)this.C1.D.D1 == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 32;
                            continue;
                        }
                        num1 = 116;
                        continue;
                    case 58:
                        if ((int)this.C1.E.E != 0)
                        {
                            num1 = 95;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 103;
                        continue;
                    case 60:
                        enReturnCode = this.AAAA(out xmlDocument1);
                        num1 = 27;
                        continue;
                    case 61:
                        if (this.C1 == null)
                        {
                            num1 = 41;
                            continue;
                        }
                        goto case 77;
                    case 62:
                        num1 = !(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾뎀궂떄ꦆ있\xE48A캌\xEE8E\xF290ﮒ\xF094", A_1) == sCommandName) ? 61 : 22;
                        continue;
                    case 64:
                        if (!(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾뎀궂떄ꦆ있\xE48A캌\xEE8E\xF290ﮒ\xF094", A_1) == sCommandName))
                        {
                            DataValueName = Module.a("ᅒ⁔\x2456ⵘ畚ड़㝞Ѡ䵢♤٦੨ͪ\x086C䅮㕰ቲŴᙶ", A_1);
                            num1 = 25;
                            continue;
                        }
                        num1 = 120;
                        continue;
                    case 66:
                        num1 = 64;
                        continue;
                    case 67:
                        if ((key1 = sCommandName) != null)
                        {
                            num1 = 104;
                            continue;
                        }
                        goto case 81;
                    case 68:
                        dataOut = (object)this.C1.F.C;
                        num1 = 93;
                        continue;
                    case 69:
                        enReturnCode = this.RefreshStructsFromDeviceInfo();
                        num1 = 113;
                        continue;
                    case 70:
                        dataOut = (object)xmlDocument1;
                        num1 = 57;
                        continue;
                    case 72:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.H == null)
                        {
                            num1 = 78;
                            continue;
                        }
                        goto case 89;
                    case 75:
                        if (1 == 0)
                            ;
                        num1 = 62;
                        continue;
                    case 76:
                        if (this.C1.D.C == null)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 83;
                            continue;
                        }
                        num1 = 4;
                        continue;
                    case 77:
                    case 92:
                    case 113:
                        num1 = 125;
                        continue;
                    case 78:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(32);
                        string key2 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㙤ቦᥨ᭪ɬᵮհᙲᅴ", A_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢ⅤɦὨɪ\x0E6C੮㡰ᵲ\x1374ᡶ", A_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾쾀\xEC82욄\xE686\xEA88\xE38A\xE88C", A_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾뎀궂떄ꦆ있\xE48A캌\xEE8E\xF290ﮒ\xF094", A_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C", A_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾뎀궂떄", A_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        string key8 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢Ɽ०ཨѪὬɮၰݲᱴᡶ\x1778啺㱼\x0A7E\xF580\xEC82힄\xE286\xEF88力\xE88Cﲎ戀", A_1);
                        int num9 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num9);
                        string key9 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢Ɽ०ཨѪὬɮၰݲᱴᡶ\x1778啺⽼\x1A7E\xE780\xF182\xE084\xF486\xE188", A_1);
                        int num10 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num10);
                        string key10 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬㽮Ͱᙲٴቶ\x1778ེ", A_1);
                        int num11 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num11);
                        string key11 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬\x2D6EѰrⅴ\x0E76\x0978Ṻ", A_1);
                        int num12 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num12);
                        string key12 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬㥮ᑰᵲᅴᡶ\x0B78㉺㥼", A_1);
                        int num13 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num13);
                        string key13 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬\x2B6Eᑰղᱴᑶ\x1C78㉺㥼", A_1);
                        int num14 = 11;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key13, num14);
                        string key14 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬㱮Ѱᅲ\x0374ቶ\x1778ὺቼൾ좀잂", A_1);
                        int num15 = 12;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key14, num15);
                        string key15 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤\x2B66⡨╪䍬㱮Ѱᅲٴ\x0E76\x0A78ེ\x187Cቾ좀잂", A_1);
                        int num16 = 13;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key15, num16);
                        string key16 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶⥸ॺ\x187C\x0C7E\xE480\xED82\xF184", A_1);
                        int num17 = 14;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key16, num17);
                        string key17 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶㭸\x0E7A\x0E7C\x2B7E\xF880\xF382\xE084", A_1);
                        int num18 = 15;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key17, num18);
                        string key18 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶⽸Ṻ\x137C\x1B7E\xEE80\xF182첄쎆", A_1);
                        int num19 = 16;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key18, num19);
                        string key19 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶㵸Ṻ\x0B7Cᙾ\xE280\xE682첄쎆", A_1);
                        int num20 = 17;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key19, num20);
                        string key20 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶⩸\x0E7Aὼॾ\xE480\xED82\xE184\xE886ﮈ슊즌", A_1);
                        int num21 = 18;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key20, num21);
                        string key21 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢❤୦ᱨ\x0E6AᥬnṰݲᵴ奶⩸\x0E7Aὼ\x0C7E\xF880\xF082\xF184\xE286\xE488슊즌", A_1);
                        int num22 = 19;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key21, num22);
                        string key22 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬㽮Ͱᙲٴቶ\x1778ེ", A_1);
                        int num23 = 20;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key22, num23);
                        string key23 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬\x2D6EѰrⅴ\x0E76\x0978Ṻ", A_1);
                        int num24 = 21;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key23, num24);
                        string key24 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬㥮ᑰᵲᅴᡶ\x0B78㉺㥼", A_1);
                        int num25 = 22;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key24, num25);
                        string key25 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬\x2B6Eᑰղᱴᑶ\x1C78㉺㥼", A_1);
                        int num26 = 23;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key25, num26);
                        string key26 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬㱮Ѱᅲ\x0374ቶ\x1778ὺቼൾ좀잂", A_1);
                        int num27 = 24;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key26, num27);
                        string key27 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢㉤て⡨╪䍬㱮Ѱᅲٴ\x0E76\x0A78ེ\x187Cቾ좀잂", A_1);
                        int num28 = 25;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key27, num28);
                        string key28 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪㵬ᵮᑰrၴ\x1976\x0D78", A_1);
                        int num29 = 26;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key28, num29);
                        string key29 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪⽬ᩮɰ❲\x0C74ݶ\x1C78", A_1);
                        int num30 = 27;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key29, num30);
                        string key30 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪㭬੮ὰᝲᩴնへ㽺", A_1);
                        int num31 = 28;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key30, num31);
                        string key31 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪⥬੮ݰᩲᙴቶへ㽺", A_1);
                        int num32 = 29;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key31, num32);
                        string key32 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪㹬ᩮ\x1370ղၴ\x1976\x1D78ᑺོ㙾얀", A_1);
                        int num33 = 30;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key32, num33);
                        string key33 = Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤㝦㩨䕪㹬ᩮ\x1370r\x0C74Ѷ\x0D78Ṻၼ㙾얀", A_1);
                        int num34 = 31;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key33, num34);
                        // ISSUE: reference to a compiler-generated field
                        global::A.H = dictionary;
                        num1 = 89;
                        continue;
                    case 81:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 36;
                        continue;
                    case 84:
                        dataOut = (object)this.C1.F.D1;
                        num1 = 85;
                        continue;
                    case 86:
                        if ((int)this.C1.D.G == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 5;
                            continue;
                        }
                        num1 = 91;
                        continue;
                    case 87:
                        dataOut = (object)this.C1.G.F;
                        num1 = 63;
                        continue;
                    case 88:
                        num1 = !this.A1 ? 90 : 69;
                        continue;
                    case 89:
                        num1 = 20;
                        continue;
                    case 90:
                        if (!(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C", A_1) == sCommandName))
                        {
                            num1 = 42;
                            continue;
                        }
                        goto case 22;
                    case 91:
                        dataOut = (object)this.C1.D.G;
                        num1 = 10;
                        continue;
                    case 95:
                        dataOut = (object)this.C1.E.E;
                        num1 = 74;
                        continue;
                    case 97:
                        if (!(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾뎀궂떄", A_1) == sCommandName))
                        {
                            num1 = 17;
                            continue;
                        }
                        goto case 22;
                    case 98:
                        if (!(Module.a("ђ㱔╖㱘㝚㡜ⱞበ䵢≤୦٨४౬ͮ㉰᭲ᑴ\x1976ṸṺ\x197C兾쾀\xEC82욄\xE686\xEA88\xE38A\xE88C", A_1) == sCommandName))
                        {
                            num1 = 75;
                            continue;
                        }
                        goto case 22;
                    case 101:
                        dataOut = (object)this.C1.G.G;
                        num1 = 12;
                        continue;
                    case 102:
                        if ((int)this.C1.G.F == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 13;
                            continue;
                        }
                        num1 = 87;
                        continue;
                    case 104:
                        num1 = 72;
                        continue;
                    case 105:
                        dataOut = (object)this.C1.E.F;
                        num1 = 59;
                        continue;
                    case 106:
                        if (pData != null)
                        {
                            num1 = 28;
                            continue;
                        }
                        goto label_180;
                    case 108:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 70;
                            continue;
                        }
                        goto label_180;
                    case 109:
                        if ((int)this.C1.E.F != 0)
                        {
                            num1 = 105;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 39;
                        continue;
                    case 111:
                        if ((int)this.C1.D.F == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 33;
                            continue;
                        }
                        num1 = 15;
                        continue;
                    case 114:
                        dataOut = (object)this.C1.G.C;
                        num1 = 37;
                        continue;
                    case 115:
                        if (this.C1.E.C != null)
                        {
                            num1 = 119;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 30;
                        continue;
                    case 116:
                        dataOut = (object)this.C1.D.D1;
                        num1 = 6;
                        continue;
                    case 117:
                        dataOut = (object)xmlDocument1;
                        num1 = 38;
                        continue;
                    case 119:
                        dataOut = (object)this.C1.E.C;
                        num1 = (int)sbyte.MaxValue;
                        continue;
                    case 120:
                        DataValueName = Module.a("ᝒごㅖ㡘\x2E5Aㅜ\x2B5E你❢Ѥ፦\x0868", A_1);
                        num1 = 79;
                        continue;
                    case 121:
                        if ((int)this.C1.E.D1 == 0)
                        {
                            enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                            num1 = 130;
                            continue;
                        }
                        num1 = 126;
                        continue;
                    case 124:
                        num1 = 81;
                        continue;
                    case 125:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 52;
                            continue;
                        }
                        goto label_180;
                    case 126:
                        dataOut = (object)this.C1.E.D1;
                        num1 = 47;
                        continue;
                    case 128:
                        if ((int)this.C1.F.D1 != 0)
                        {
                            num1 = 84;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
                        num1 = 23;
                        continue;
                    case 129:
                        dataOut = (object)this.C1.F.G;
                        num1 = 34;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_147:
            try
            {
                label_149:
                xmlDocument2.LoadXml(pData.ToString());
                XmlTools xmlTools = new XmlTools();
                enReturnCode = xmlTools.Validate(xmlDocument2.InnerXml, Resources.hpCASL);
                int num35 = 0;
                while (true)
                {
                    switch (num35)
                    {
                        case 0:
                            if (enReturnCode == enReturnCode.e_OK)
                            {
                                num35 = 2;
                                continue;
                            }
                            this.log.FormatInformationMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("\x0B52ᡔ᭖祘ⵚ㱜㍞\x0860ݢѤ፦hѪͬ佮ᝰቲᱴ᭶\x1C78ὺ䝼彾婢뎂\xF884\xAB86ꦈ\xF08A벌\xF28E붐뎒\xEE94ꖖ\xE498", A_1), (object)xmlTools.ErrorMessage, (object)xmlTools.Errors, (object)enReturnCode.ToString());
                            num35 = 3;
                            continue;
                        case 1:
                            goto label_180;
                        case 2:
                            dataOut = (object)xmlDocument2;
                            num35 = 4;
                            continue;
                        case 3:
                        case 4:
                            num35 = 1;
                            continue;
                        default:
                            goto label_149;
                    }
                }
            }
            catch (Exception ex)
            {
                this.log.FormatInformationMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("ቒ㭔睖᱘⍚㹜㩞ᅠᝢ\x0C64\x0866ݨ䭪ɬ౮ተٲݴն\x1C78ὺ嵼䕾ꆀ\xF882떄惘", A_1), (object)ex.Message);
                enReturnCode = enReturnCode.e_INVALID_XML;
            }
            label_180:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ђ㱔╖㱘㝚㡜ⱞበ⩢\x0B64Ŧ٨ᥪl\x0E6Eհᩲᩴ\x1976㹸Ṻॼ", A_1), Module.a("ၒ㩔㩖⥘㝚㡜\x2B5EѠݢ䕤ၦhὪլ佮ੰ䍲\x0874", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode AAAA(out XmlDocument A_0)
        {
            int A_1 = 1;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Fⱈ㽊ੌ⍎㹐ㅒ㑔㭖๘\x325A⽜㩞ൠ٢ᙤᑦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_0 = new XmlDocument();
            int num1 = 1;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        goto label_13;
                    case 1:
                        if (A_0 == null)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto label_5;
                    case 2:
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊ੌ⍎㹐ㅒ㑔㭖๘\x325A⽜㩞ൠ٢ᙤᑦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("\x0E46❈㡊㥌\x2E4E㽐❒㱔㙖ⵘ\x325A\x325Cㅞ䅠ౢͤ䝦ㅨ٪Ŭ\x2B6EṰၲt᩶\x1C78ᕺॼ彾\xF380\xE682\xF184\xF286ﮈ\xE58A\xE88C\xEB8E놐ﶒ\xE094ﮖ\xF598", A_1));
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_5:
            try
            {
                int num2 = 2;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            goto label_13;
                        case 1:
                            File.WriteAllText(this.GlobalWirelessEmulationFile, Resources.WirelessGlobalDeviceInfoOutput);
                            num2 = 3;
                            continue;
                        case 3:
                            A_0.Load(this.GlobalWirelessEmulationFile);
                            num2 = 0;
                            continue;
                        default:
                            if (!File.Exists(this.GlobalWirelessEmulationFile))
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
                this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Fⱈ㽊ੌ⍎㹐ㅒ㑔㭖๘\x325A⽜㩞ൠ٢ᙤᑦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("Ɇㅈ⡊⡌㽎═㩒㩔㥖祘㝚\x325C㹞\x0560\x0A62\x0B64f䥨\x0E6AlᩮᵰቲŴṶᙸᕺ嵼\x197E\xE880\xEF82\xE084붆ꦈ겊\xF68C뺎\xEC90뒒", A_1), (object)ex.Message);
                enReturnCode = enReturnCode.e_INVALID_XML;
            }
            label_13:
            if (1 == 0)
                ;
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Fⱈ㽊ੌ⍎㹐ㅒ㑔㭖๘\x325A⽜㩞ൠ٢ᙤᑦⱨ٪ᡬͮၰݲᱴᡶ\x1778", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ䍢Ṥ坦ᑨ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode WirelessStateGet(string sCommandName, out object dataOut)
        {
            int A_1 = 18;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㕱ᅳɵ", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1));
            dataOut = (object)null;
            enReturnCode enReturnCode = this.RefreshStructsFromDeviceInfo();
            int num1 = 24;
            int num2 = 0;
            string key1 = null;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num1 = 21;
                        continue;
                    case 1:
                        switch (num2)
                        {
                            case 0:
                                dataOut = (object)(this.H1 ? 1 : 0);
                                num1 = 29;
                                continue;
                            case 1:
                                dataOut = (object)(this.F1.A ? 1 : 0);
                                num1 = 11;
                                continue;
                            case 2:
                                dataOut = (object)(this.F1.Bb ? 1 : 0);
                                num1 = 17;
                                continue;
                            case 3:
                                dataOut = (object)(this.F1.C ? 1 : 0);
                                num1 = 28;
                                continue;
                            case 4:
                                dataOut = (object)(this.F1.D ? 1 : 0);
                                num1 = 27;
                                continue;
                            case 5:
                                dataOut = (object)(this.F1.E ? 1 : 0);
                                num1 = 23;
                                continue;
                            case 6:
                                dataOut = (object)(this.F1.F ? 1 : 0);
                                num1 = 13;
                                continue;
                            case 7:
                                dataOut = (object)(this.F1.G ? 1 : 0);
                                num1 = 14;
                                continue;
                            case 8:
                                dataOut = (object)(this.F1.H ? 1 : 0);
                                num1 = 6;
                                continue;
                            case 9:
                                dataOut = (object)(this.F1.I ? 1 : 0);
                                num1 = 9;
                                continue;
                            case 10:
                                dataOut = (object)(this.F1.J ? 1 : 0);
                                num1 = 25;
                                continue;
                            case 11:
                                dataOut = (object)(this.F1.K ? 1 : 0);
                                num1 = 16;
                                continue;
                            case 12:
                                dataOut = (object)(this.F1.L ? 1 : 0);
                                num1 = 18;
                                continue;
                            case 13:
                                dataOut = (object)(this.F1.M ? 1 : 0);
                                num1 = 2;
                                continue;
                            case 14:
                                dataOut = (object)(this.F1.N ? 1 : 0);
                                num1 = 8;
                                continue;
                            case 15:
                                dataOut = (object)(this.F1.O ? 1 : 0);
                                num1 = 10;
                                continue;
                            case 16:
                                dataOut = (object)(this.F1.P ? 1 : 0);
                                num1 = 12;
                                continue;
                            default:
                                num1 = 19;
                                continue;
                        }
                    case 2:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 16:
                    case 17:
                    case 18:
                    case 23:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                        goto label_38;
                    case 3:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 26;
                        continue;
                    case 4:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.I == null)
                        {
                            num1 = 22;
                            continue;
                        }
                        goto case 15;
                    case 5:
                        num1 = 1;
                        continue;
                    case 7:
                        if (1 == 0)
                            ;
                        num1 = 4;
                        continue;
                    case 15:
                        num1 = 20;
                        continue;
                    case 19:
                        num1 = 3;
                        continue;
                    case 20:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.I.TryGetValue(key1, out num2))
                        {
                            num1 = 5;
                            continue;
                        }
                        goto case 3;
                    case 21:
                        if ((key1 = sCommandName) != null)
                        {
                            num1 = 7;
                            continue;
                        }
                        goto case 3;
                    case 22:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(17);
                        string key2 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧\x2B69ᥫᩭὯ\x2071ᅳၵ\x0A77όཻᙽ", A_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩\x206B⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F", A_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩\x206B⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ\xDF87잉얋", A_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩\x206B⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ쪇쎉쎋\xDD8D", A_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩\x206B⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ\xDF87\xE389ﺋ\xEB8Dﲏ\xF791\xE793\xE595\xDA97\xEF99\xE89B\xEA9D쾟첡", A_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧⡩k᭭ᕯٱ᭳\x1975\x0C77ቹ剻㭽\xEE7F\xE381\xE683\xEA85\xED87\xEE89", A_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        string key8 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧⡩k᭭ᕯٱ᭳\x1975\x0C77ቹ剻㭽\xEE7F\xE381\xE683\xEA85\xED87\xEE89캋\xF78D뺏양\xD993\xDF95", A_1);
                        int num9 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num9);
                        string key9 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧⡩k᭭ᕯٱ᭳\x1975\x0C77ቹ剻㭽\xEE7F\xE381\xE683\xEA85\xED87\xEE89캋\xF78D뺏킑\xDD93\xD995쮗", A_1);
                        int num10 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num10);
                        string key10 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧⡩k᭭ᕯٱ᭳\x1975\x0C77ቹ剻㭽\xEE7F\xE381\xE683\xEA85\xED87\xEE89캋\xF78D뺏양ﶓ\xE495ﶗ\xF699鍊\xED9D펟\xE0A1톣튥\xDCA7얩슫", A_1);
                        int num11 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num11);
                        string key11 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩㭫⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F", A_1);
                        int num12 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num12);
                        string key12 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩㭫⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ\xDF87잉얋", A_1);
                        int num13 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num13);
                        string key13 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩㭫⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ쪇쎉쎋\xDD8D", A_1);
                        int num14 = 11;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key13, num14);
                        string key14 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧㵩㭫⽭㹯山ㅳᡵ\x1977\x1879ၻ\x1B7D\xE47F삁ﶃꢅ\xDF87\xE389ﺋ\xEB8Dﲏ\xF791\xE793\xE595\xDA97\xEF99\xE89B\xEA9D쾟첡", A_1);
                        int num15 = 12;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key14, num15);
                        string key15 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧\x2D69㱫㵭幯㝱ᩳ\x1775᩷ᙹ\x197B\x1A7D", A_1);
                        int num16 = 13;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key15, num16);
                        string key16 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧\x2D69㱫㵭幯㝱ᩳ\x1775᩷ᙹ\x197B\x1A7D쉿ﮁꪃ톅얇쎉", A_1);
                        int num17 = 14;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key16, num17);
                        string key17 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧\x2D69㱫㵭幯㝱ᩳ\x1775᩷ᙹ\x197B\x1A7D쉿ﮁꪃ쒅솇얉\xDF8B", A_1);
                        int num18 = 15;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key17, num18);
                        string key18 = Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ䙧\x2D69㱫㵭幯㝱ᩳ\x1775᩷ᙹ\x197B\x1A7D쉿ﮁꪃ톅\xE187\xF889\xE98B\xE28D\xF58F\xE191\xE793풕\xED97\xEE99\xE89B\xF19D캟", A_1);
                        int num19 = 16;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key18, num19);
                        // ISSUE: reference to a compiler-generated field
                        global::A.I = dictionary;
                        num1 = 15;
                        continue;
                    case 24:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto label_38;
                    default:
                        goto label_2;
                }
            }
            label_38:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㕱ᅳɵ", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ味\x0D75䡷ݹ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        protected override void InitPropertyGetList()
        {
            int A_1 = 3;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞♠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
            int num1 = (int)this.BBB();
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘\x0C5AᅜṞ⽠䵢㕤ᕦ౨ᡪ\x086CŮհ", A_1), typeof(bool), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᥚㅜ⩞Ѡᝢ\x0A64\x0866\x1D68ͪ䍬㽮Ͱᙲٴቶ\x1778ེ", A_1), typeof(bool), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘\x0C5AੜṞ⽠䵢㕤ᕦ౨ᡪ\x086CŮհ", A_1), typeof(bool), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᱚ\x0D5C\x0C5E你㍢ᝤɦᩨ\x0E6Aͬ᭮", A_1), typeof(bool), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            int num2 = this.BWireless4Supported ? 1 : 0;
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘\x1F5A㡜⥞\x0860bd\x2E66ݨ൪ɬ", A_1), typeof(XmlDocument), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᱚㅜぞ͠ɢ।\x2466Ũ੪ͬ\x086Eᑰᝲ", A_1), typeof(XmlDocument), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᱚㅜぞ͠ɢ।\x2466Ũ੪ͬ\x086Eᑰᝲ孴䕶坸䭺", A_1), typeof(XmlDocument), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᱚㅜぞ͠ɢ।\x2466Ũ੪ͬ\x086Eᑰᝲ孴㥶ᙸ㡺\x1C7C᱾\xE980\xE682", A_1), typeof(XmlDocument), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘ᱚㅜぞ͠ɢ।\x2466Ũ੪ͬ\x086Eᑰᝲ孴䕶坸䭺卼ㅾ\xEE80삂\xE484\xE486\xE188\xEE8A", A_1), typeof(XmlDocument), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.propertyGetList.Add(new Command.Property(Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456睘࡚⡜⽞ᅠౢᝤ፦౨ཪ", A_1), typeof(bool), Module.a("Ṉ≊㽌⩎㵐㙒♔\x2456ၘ㕚㭜ぞ፠\x0E62Ѥ፦hѪͬ⡮ᑰݲ", A_1), false));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎Ő\x2152㩔❖㱘⥚⥜♞♠٢ᅤ\x2B66hᡪᥬ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘", A_1));
        }

        private enReturnCode WirelessStateSet(string sCommandName, object dataIn)
        {
            int A_1 = 11;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ㉠ᝢѤ፦౨㡪\x086C᭮", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 7;
            string key1=null;
            int num2=0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 12:
                        goto label_20;
                    case 1:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.J.TryGetValue(key1, out num2))
                        {
                            num1 = 5;
                            continue;
                        }
                        goto case 11;
                    case 2:
                        switch (num2)
                        {
                            case 0:
                                enReturnCode = this.AAA(dataIn);
                                num1 = 12;
                                continue;
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                enReturnCode = this.SetWirelessStateForDevice(sCommandName, dataIn);
                                num1 = 8;
                                continue;
                            default:
                                num1 = 10;
                                continue;
                        }
                    case 3:
                        num1 = 9;
                        continue;
                    case 4:
                        num1 = 1;
                        continue;
                    case 5:
                        num1 = 2;
                        continue;
                    case 6:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(6);
                        string key2 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你ぢd፦\x2D68\x0E6A᭬ٮተᙲ♴Ͷ\x1878ེ\x187C", A_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你㑢⥤♦❨䕪⡬Ůၰᅲᥴቶ\x1D78", A_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你Ⅲ।ቦ౨Ὢɬnհ᭲孴㉶\x1778᩺ὼ\x137E\xE480\xE782", A_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你㑢㉤♦❨䕪⡬Ůၰᅲᥴቶ\x1D78", A_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你\x2462㕤㑦䝨\x2E6Aͬ\x0E6E\x1370ὲၴ\x1376", A_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ你≢।୦䝨\x2E6Aͬ\x0E6E\x1370ὲၴ\x1376", A_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        // ISSUE: reference to a compiler-generated field
                        global::A.J = dictionary;
                        num1 = 4;
                        continue;
                    case 7:
                        if ((key1 = sCommandName) != null)
                        {
                            num1 = 3;
                            continue;
                        }
                        goto case 11;
                    case 8:
                        goto label_13;
                    case 9:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.J == null)
                        {
                            num1 = 6;
                            continue;
                        }
                        goto case 4;
                    case 10:
                        num1 = 11;
                        continue;
                    case 11:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_13:
            if (1 == 0)
                ;
            label_20:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ِ㩒❔\x3256㕘㹚\x2E5Cⱞ㉠ᝢѤ፦౨㡪\x086C᭮", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᑮ䅰\x0E72", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode AAA(object A_0)
        {
            int A_1 = 12;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("őㅓ≕བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㑱ٳ\x1975ᕷ≹ᅻች", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            XmlDocument A_0_1 = (XmlDocument)null;
            int num = 6;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        num = !this.A1 ? 12 : 10;
                        continue;
                    case 1:
                        enReturnCode = this.BBBA(A_0_1);
                        num = 11;
                        continue;
                    case 2:
                        try
                        {
                            A_0_1 = (XmlDocument)A_0;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        num = 17;
                        continue;
                    case 3:
                        if (!this.BWirelessLegacySupported)
                        {
                            enReturnCode = enReturnCode.e_INVALID_COMMAND;
                            num = 16;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 4:
                        num = 0;
                        continue;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 4;
                            continue;
                        }
                        goto label_25;
                    case 6:
                        if (A_0 == null)
                        {
                            num = 14;
                            continue;
                        }
                        goto case 2;
                    case 7:
                    case 11:
                    case 15:
                    case 16:
                        goto label_25;
                    case 8:
                        num = 5;
                        continue;
                    case 9:
                        enReturnCode = new XmlTools().Validate(A_0_1.InnerXml, Resources.hpCASL);
                        num = 8;
                        continue;
                    case 10:
                        enReturnCode = this.BC(A_0_1);
                        if (1 == 0)
                            ;
                        num = 15;
                        continue;
                    case 12:
                        num = !this.BWireless4Supported ? 3 : 13;
                        continue;
                    case 13:
                        enReturnCode = this.CB(A_0_1);
                        num = 7;
                        continue;
                    case 14:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 2;
                        continue;
                    case 17:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 9;
                            continue;
                        }
                        goto case 8;
                    default:
                        goto label_2;
                }
            }
            label_25:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("őㅓ≕བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㑱ٳ\x1975ᕷ≹ᅻች", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ乭୯䉱ॳ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BC(XmlDocument A_0)
        {
            int A_1 = 0;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ᭋ❍≏㝑㡓㍕⭗⥙ཛ⩝şᙡţ\x2065ᩧթū㙭ᵯṱㅳ᭵\x0D77ᙹᵻ\x0A7D\xE97F\xED81\xEA83", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
            enReturnCode enReturnCode = new XmlTools().Validate(A_0.InnerXml, Resources.hpCASL);
            CommandWireless.E[] eArray1 = new CommandWireless.E[2]
            {
        new CommandWireless.E(this.BB),
        new CommandWireless.E(this.AAAA)
            };
            int num = 10;
            XmlEdit xmlEdit1=null;
            byte @byte=0;
            bool @bool=false;
            XmlEdit xmlEdit2=null;
            CommandWireless.E e = null;
            int index=0;
            string sText=null;
            CommandWireless.E[] eArray2=null;
            string str=null;
            while (true)
            {

                switch (num)
                {
                    case 0:
                    case 20:
                    case 23:
                        num = 3;
                        continue;
                    case 1:
                        str = Module.a("⥅\x2E47ⱉ", A_1);
                        break;
                    case 2:
                        xmlEdit1.XmlDoc.Save(this.WirelessEmulationFile);
                        num = 4;
                        continue;
                    case 3:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 14;
                            continue;
                        }
                        goto case 4;
                    case 4:
                    case 7:
                    case 9:
                    case 24:
                        ++index;
                        num = 19;
                        continue;
                    case 5:
                        if ((int)@byte == (int)byte.MaxValue)
                        {
                            if (1 == 0)
                                ;
                            num = 16;
                            continue;
                        }
                        goto case 0;
                    case 6:
                        goto label_42;
                    case 8:
                        string sNode1 = string.Format(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽썿\xF781\xF683\xF485\xED87\xE489\xF88B\xDD8D\xE48F\xF391\xE093\xF395쎗뒙늛놝\xF09F춡펣쎥\xDAA7囹쎫\xDBAD슯톱톳讵龷솹費쎽\xE7BF鿁", A_1), (object)@byte);
                        xmlEdit1.SetString(sNode1, sText);
                        string sNode2 = string.Format(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xF1A5\xE5A7\xE3A9\xF7AB肭麯鶱骳颵鞷\xEAB9펻즽ꖿ냁韃꧅뷇룉꿋ꯍ\xEDCF\xF5D1꿓\xE6D5ꗗ\xFDD9臛", A_1), (object)@byte);
                        xmlEdit1.SetString(sNode2, sText);
                        num = 0;
                        continue;
                    case 10:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 22;
                            continue;
                        }
                        goto label_42;
                    case 11:
                        @byte = xmlEdit2.GetByte(Module.a("楅杇͉≋㹍╏♑筓ቕ㥗\x2E59㵛煝たൡ፣ͥᩧ㥩ͫ᭭ɯᅱᅳ", A_1));
                        @bool = xmlEdit2.GetBool(Module.a("楅杇͉≋㹍╏♑筓ቕ㥗\x2E59㵛煝\x325Fݡᕣ፥൧ᥩᡫ୭ᑯⅱs\x1775\x0C77ό", A_1));
                        XmlDocument A_0_1 = (XmlDocument)null;
                        enReturnCode = e(out A_0_1);
                        xmlEdit1 = new XmlEdit(A_0_1);
                        num = 13;
                        continue;
                    case 12:
                        if (index >= eArray2.Length)
                        {
                            num = 6;
                            continue;
                        }
                        e = eArray2[index];
                        xmlEdit2 = new XmlEdit(A_0);
                        num = 27;
                        continue;
                    case 13:
                        if (xmlEdit1 == null)
                        {
                            enReturnCode = enReturnCode.e_NULL_VALUE;
                            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ᭋ❍≏㝑㡓㍕⭗⥙ཛ⩝şᙡţ\x2065ᩧթū㙭ᵯṱㅳ᭵\x0D77ᙹᵻ\x0A7D\xE97F\xED81\xEA83", A_1), Module.a("ཅ♇㥉㡋⽍㹏♑㵓㝕ⱗ㍙㍛そ䁟ൡɣ䙥でݩk\x2B6Dᑯ᭱s噵ṷᕹ\x0E7B幽\xEF7F\xF781\xF083\xF685ﶇﺉ겋\xE88D憐ﺑ\xF193뚕\xEA97ﾙ\xE89B\xEB9D튟첡솣슥袧쒩\xD9AB슭\xDCAF", A_1));
                            num = 24;
                            continue;
                        }
                        num = 21;
                        continue;
                    case 14:
                        num = 15;
                        continue;
                    case 15:
                        if (new CommandWireless.E(this.BB) == e)
                        {
                            num = 2;
                            continue;
                        }
                        xmlEdit1.XmlDoc.Save(this.GlobalWirelessEmulationFile);
                        num = 9;
                        continue;
                    case 16:
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xEEA5즧\xD8A9좫\xD9AD톯삱톳\xF4B5춷캹좻톽꺿駁\xEAC3\xE8C5\xE7C7\xE4C9\xE2CB\xE1CD蓏럑럓뻕뛗뗙냛뇝蟟鯡냣\x9FE5飧迩퇫짭\xA7EF뻱뗳룵\xDFF7\xA7F9", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xEEA5즧\xD8A9좫\xD9AD톯삱톳\xF4B5춷캹좻톽꺿駁\xEAC3\xE8C5\xE7C7\xE4C9\xE2CB\xE1CD蓏럑럓뻕뛗뗙냛뇝蟟鯡냣\x9FE5飧迩퇫짭닯黱至鏵賷闹鏻諽棿━夃", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xEEA5즧\xD8A9좫\xD9AD톯삱톳\xF4B5춷캹좻톽꺿駁\xEAC3\xE8C5\xE7C7\xE4C9\xE2CB\xE1CD蓏럑럓뻕뛗뗙냛뇝蟟鯡냣\x9FE5飧迩퇫짭\xA7EFꗱ뗳룵\xDFF7\xA7F9", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xEEA5즧\xD8A9좫\xD9AD톯삱톳\xF4B5춷캹좻톽꺿駁\xEAC3\xE8C5\xE7C7\xE4C9\xE2CB\xE1CD蓏럑럓뻕뛗뗙냛뇝蟟鯡냣\x9FE5飧迩퇫짭럯ꋱ\xA7F3퇵ꗷ", A_1), sText);
                        num = 20;
                        continue;
                    case 17:
                        num = @bool ? 18 : 28;
                        continue;
                    case 18:
                        str = Module.a("⥅♇", A_1);
                        break;
                    case 19:
                    case 30:
                        num = 12;
                        continue;
                    case 21:
                        num = 17;
                        continue;
                    case 22:
                        eArray2 = eArray1;
                        index = 0;
                        num = 30;
                        continue;
                    case 25:
                        if ((int)@byte >= 254)
                        {
                            xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽썿\xF781\xF683\xF485\xED87\xE489\xF88B\xDD8D\xE48F\xF391\xE093\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽鞿軁藃装\xEFC7韉", A_1), sText);
                            xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽썿\xF781\xF683\xF485\xED87\xE489\xF88B\xDD8D\xE48F\xF391\xE093\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽芿껁뇃ꏅ볇ꗉꏋ뫍룏\xF5D1觓", A_1), sText);
                            xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽썿\xF781\xF683\xF485\xED87\xE489\xF88B\xDD8D\xE48F\xF391\xE093\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽鞿闁藃装\xEFC7韉", A_1), sText);
                            xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽썿\xF781\xF683\xF485\xED87\xE489\xF88B\xDD8D\xE48F\xF391\xE093\xF395쎗뒙늛놝\xF49F잡잣캥욧얩삫솭\xD7AF쮱\xE0B3쾵좷\xDFB9膻馽螿鋁韃\xE1C5闇", A_1), sText);
                            num = 29;
                            continue;
                        }
                        num = 8;
                        continue;
                    case 26:
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xF1A5\xE5A7\xE3A9\xF7AB肭麯鶱骳颵鞷\xEEB9\xD9BB\xDDBDꢿ곁ꯃ\xAAC5\xA7C7귉뗋髍\xA9CFꋑ뇓\xEBD5ￗ跙郛\x9FDD껟엡맣", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xF1A5\xE5A7\xE3A9\xF7AB肭麯鶱骳颵鞷\xEEB9\xD9BB\xDDBDꢿ곁ꯃ\xAAC5\xA7C7귉뗋髍\xA9CFꋑ뇓\xEBD5ￗ飙냛ꯝ藟雡诣觥鳧苩쯫돭", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xF1A5\xE5A7\xE3A9\xF7AB肭麯鶱骳颵鞷\xEEB9\xD9BB\xDDBDꢿ곁ꯃ\xAAC5\xA7C7귉뗋髍\xA9CFꋑ뇓\xEBD5ￗ跙诛\x9FDD껟엡맣", A_1), sText);
                        xmlEdit1.SetString(Module.a("楅杇Չ㥋㩍⁏❑⁓祕᱗㭙⡛㽝佟♡ţၥŧ३५ᵭ彯㙱ᅳuᅷ\x1979\x197B兽챿\xE381\xF783\xF285\xDA87\xEF89ﶋﮍ\xF58F\xE191\xE093\xF395ﲗ즙\xE89Bﾝ풟잡讣\xF1A5\xE5A7\xE3A9\xF7AB肭麯鶱骳颵鞷\xEEB9\xD9BB\xDDBDꢿ곁ꯃ\xAAC5\xA7C7귉뗋髍\xA9CFꋑ뇓\xEBD5ￗ鷙賛距쟟뿡", A_1), sText);
                        num = 23;
                        continue;
                    case 27:
                        if (xmlEdit2 == null)
                        {
                            enReturnCode = enReturnCode.e_NULL_VALUE;
                            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ᭋ❍≏㝑㡓㍕⭗⥙ཛ⩝şᙡţ\x2065ᩧթū㙭ᵯṱㅳ᭵\x0D77ᙹᵻ\x0A7D\xE97F\xED81\xEA83", A_1), Module.a("ཅ♇㥉㡋⽍㹏♑㵓㝕ⱗ㍙㍛そ䁟ൡɣ䙥でݩk\x2B6Dᑯ᭱s噵ṷᕹ\x0E7B幽\xE97F\xEC81\xF483\xF385ﲇꪉ\xEA8B\xE78Dﲏ\xF791뒓\xE495ﶗ\xEE99\xE99B\xEC9D캟잡삣蚥욧\xDFA9삫슭", A_1));
                            num = 7;
                            continue;
                        }
                        num = 11;
                        continue;
                    case 28:
                        num = 1;
                        continue;
                    case 29:
                        num = (int)@byte != 254 ? 5 : 26;
                        continue;
                    default:
                        goto label_2;
                }
                sText = str;
                num = 25;
            }
            label_42:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ᭋ❍≏㝑㡓㍕⭗⥙ཛ⩝şᙡţ\x2065ᩧթū㙭ᵯṱㅳ᭵\x0D77ᙹᵻ\x0A7D\xE97F\xED81\xEA83", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ὣ噥ᕧ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode CB(XmlDocument A_0)
        {
            int A_1_1 = 15;
            label_3:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0C5A㑜ⵞѠརdᑦᩨ㡪ᥬ\x0E6Eհᙲ㍴նᙸᙺ╼ቾ\xED80풂놄", A_1_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] A_2_1 = (byte[])null;
            int num = 4;
            while (true)
            {
                if (1 == 0)
                    ;
                byte A_1_2=0;
                bool A_2_2=false;
                switch (num)
                {
                    case 0:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 9;
                            continue;
                        }
                        goto label_17;
                    case 1:
                        enReturnCode = this.BBBB(A_1_2, A_2_2, out A_2_1);
                        num = 5;
                        continue;
                    case 2:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 6;
                        continue;
                    case 3:
                        goto label_17;
                    case 4:
                        if (A_0 == null)
                        {
                            num = 2;
                            continue;
                        }
                        goto case 6;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 8;
                            continue;
                        }
                        goto label_17;
                    case 6:
                        num = 0;
                        continue;
                    case 7:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_17;
                    case 8:
                        enReturnCode = this.SetDeviceStateInBIOSW4(A_2_1);
                        num = 3;
                        continue;
                    case 9:
                        enReturnCode = this.BA(A_0, out A_1_2, out A_2_2);
                        num = 7;
                        continue;
                    default:
                        goto label_3;
                }
            }
            label_17:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0C5A㑜ⵞѠརdᑦᩨ㡪ᥬ\x0E6Eհᙲ㍴նᙸᙺ╼ቾ\xED80풂놄", A_1_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76", A_1_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BA(XmlDocument A_0, out byte A_1, out bool A_2)
        {
            int A_1_1 = 8;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ṍㅏ⁑❓㍕W㝙せᩝşᙡգ", A_1_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_1 = (byte)0;
            A_2 = false;
            int num = 8;
            string @string=null;
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
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 0;
                        continue;
                    case 2:
                        if (@string == null)
                        {
                            num = 9;
                            continue;
                        }
                        goto case 3;
                    case 3:
                        num = 4;
                        continue;
                    case 4:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 7;
                            continue;
                        }
                        goto label_19;
                    case 5:
                        XmlEdit xmlEdit = new XmlEdit(A_0);
                        A_2 = xmlEdit.GetBool(Module.a("慍罏őㅓ≕བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㭱ᩳٵ\x0D77\x0E79卻㝽\xEE7F\xF281\xF183\xF285ꞇ캉\xED8B揄\xF18F붑욓\xF395\xE997\xEF99鍊\xED9D풟잡삣\xF5A5\xDCA7쮩\xD8AB쮭", A_1_1));
                        @string = xmlEdit.GetString(Module.a("慍罏őㅓ≕བྷ㍙\x2E5B㭝\x0C5Fݡᝣᕥ㭧ṩ൫ᩭᕯ㭱ᩳٵ\x0D77\x0E79卻㝽\xEE7F\xF281\xF183\xF285ꞇ캉\xED8B揄\xF18F붑쒓秊\xEF97ﾙ\xEE9B춝쾟힡횣얥춧", A_1_1));
                        num = 2;
                        continue;
                    case 6:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 5;
                            continue;
                        }
                        goto label_19;
                    case 7:
                        goto label_14;
                    case 8:
                        if (A_0 == null)
                        {
                            num = 1;
                            continue;
                        }
                        goto case 0;
                    case 9:
                        enReturnCode = enReturnCode.e_INVALID_XML;
                        num = 3;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_14:
            try
            {
                A_1 = Convert.ToByte(@string);
            }
            catch
            {
                enReturnCode = enReturnCode.e_INVALID_COMMAND;
            }
            label_19:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ṍㅏ⁑❓㍕W㝙せᩝşᙡգ", A_1_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg偩䱫", A_1_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BBBB(byte A_0, bool A_1, out byte[] A_2)
        {
            int A_1_1 = 4;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕W㝙せ\x0A5Dཟ⍡ᙣᑥ१\x1369㭫婭", A_1_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_2 = new byte[4];
            A_2[0] = (byte)1;
            A_2[1] = (byte)0;
            A_2[2] = A_0;
            Utility.SetBit(ref A_2[3], 0, A_1);
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕W㝙せ\x0A5Dཟ⍡ᙣᑥ१\x1369㭫婭", A_1_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ履䡧", A_1_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetDeviceStateInBIOSW4(byte[] abyDeviceState)
        {
            int A_1 = 0;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ࡋ\x2B4D♏㭑㝓㍕ୗ\x2E59㵛⩝՟\x2B61\x0A63\x2465Ⅷ╩㽫㥭䑯", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            byte[] dataOut = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetWirelessDeviceState, abyDeviceState, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num = 2;
                        continue;
                    case 1:
                    case 2:
                        goto label_8;
                    case 3:
                        if (wmiBiosClient != null)
                        {
                            num = 0;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ࡋ\x2B4D♏㭑㝓㍕ୗ\x2E59㵛⩝՟\x2B61\x0A63\x2465Ⅷ╩㽫㥭䑯", A_1), Module.a("ཅ♇㥉㡋⽍㹏♑㵓㝕ⱗ㍙㍛そ䁟ൡɣ䙥㽧ݩիⱭ㥯㵱❳㕵ᑷ\x1379\x197Bၽ\xF47Fꊁ\xF683\xE385ﲇﾉﺋ\xE08D\xF58F\xF691뒓\xF895\xED97\xF699\xF09B", A_1));
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_8:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉ࡋ\x2B4D♏㭑㝓㍕ୗ\x2E59㵛⩝՟\x2B61\x0A63\x2465Ⅷ╩㽫㥭䑯", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F塡䑣", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BBBA(XmlDocument A_0)
        {
            int A_1_1 = 6;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ὃ\x2B4D\x244FՑ㵓\x2455㵗㙙㥛ⵝ፟ㅡၣݥᱧཀྵ⩫ᱭὯάⱳ᭵ᑷ㙹\x197B\x197D\xE17F\xE181ﶃ", A_1_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] A_2_1 = (byte[])null;
            int num = 3;
            byte A_1_2=0;
            bool A_2_2=false;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 4;
                        continue;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_17;
                    case 2:
                        enReturnCode = this.BA(A_0, out A_1_2, out A_2_2);
                        num = 6;
                        continue;
                    case 3:
                        if (A_0 == null)
                        {
                            num = 0;
                            continue;
                        }
                        goto case 4;
                    case 4:
                        num = 1;
                        continue;
                    case 5:
                        goto label_17;
                    case 6:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            if (1 == 0)
                                ;
                            num = 7;
                            continue;
                        }
                        goto label_17;
                    case 7:
                        enReturnCode = this.BBA(A_1_2, A_2_2, out A_2_1);
                        num = 9;
                        continue;
                    case 8:
                        enReturnCode = this.SetDeviceStateInBIOSLegacy(A_2_1);
                        num = 5;
                        continue;
                    case 9:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 8;
                            continue;
                        }
                        goto label_17;
                    default:
                        goto label_2;
                }
            }
            label_17:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ὃ\x2B4D\x244FՑ㵓\x2455㵗㙙㥛ⵝ፟ㅡၣݥᱧཀྵ⩫ᱭὯάⱳ᭵ᑷ㙹\x197B\x197D\xE17F\xE181ﶃ", A_1_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65剧䩩", A_1_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode BBA(byte A_0, bool A_1, out byte[] A_2)
        {
            int A_1_1 = 2;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("େ╉≋㡍㕏⁑⁓๕㕗㙙ᡛ㽝ᑟ͡っ॥⥧ᡩṫ\x0F6D९㹱ᅳᅵ\x1977\x1979ջ", A_1_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            A_2 = new byte[4];
            int num = 9;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        num = 19;
                        continue;
                    case 1:
                    case 8:
                    case 10:
                    case 15:
                    case 16:
                        goto label_24;
                    case 2:
                        Utility.SetBit(ref A_2[0], 1, A_1);
                        Utility.SetBit(ref A_2[1], 1, true);
                        num = 8;
                        continue;
                    case 3:
                        num = (int)this.C1.E.H != (int)A_0 ? 11 : 2;
                        continue;
                    case 4:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_24;
                    case 5:
                        Utility.SetBit(ref A_2[0], 0, A_1);
                        Utility.SetBit(ref A_2[1], 0, true);
                        num = 16;
                        continue;
                    case 6:
                        num = 17;
                        continue;
                    case 7:
                        Utility.SetBit(ref A_2[0], 3, A_1);
                        Utility.SetBit(ref A_2[1], 3, true);
                        num = 1;
                        continue;
                    case 9:
                        if (this.C1 == null)
                        {
                            num = 14;
                            continue;
                        }
                        goto case 13;
                    case 11:
                        num = (int)this.C1.D.H != (int)A_0 ? 18 : 12;
                        continue;
                    case 12:
                        Utility.SetBit(ref A_2[0], 2, A_1);
                        Utility.SetBit(ref A_2[1], 2, true);
                        num = 10;
                        continue;
                    case 13:
                        num = 4;
                        continue;
                    case 14:
                        enReturnCode = this.RefreshStructsFromDeviceInfoLegacy();
                        num = 13;
                        continue;
                    case 17:
                        if ((int)A_0 != (int)byte.MaxValue)
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                            num = 15;
                            continue;
                        }
                        num = 7;
                        continue;
                    case 18:
                        if (1 == 0)
                            ;
                        if ((int)A_0 != 254)
                        {
                            num = 6;
                            continue;
                        }
                        goto case 7;
                    case 19:
                        num = (int)this.C1.F.H != (int)A_0 ? 3 : 5;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_24:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("େ╉≋㡍㕏⁑⁓๕㕗㙙ᡛ㽝ᑟ͡っ॥⥧ᡩṫ\x0F6D९㹱ᅳᅵ\x1977\x1979ջ", A_1_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61幣䙥", A_1_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetWirelessStateForDevice(string sCommandName, object dataIn)
        {
            int A_1 = 8;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1D4D㕏♑͓㽕⩗㽙せ㭝፟ᅡ㝣ብ१ṩ५⡭Ὧqび\x1375\x0E77\x1379ύ\x1B7D", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (this.BWireless4Supported)
                        {
                            num = 1;
                            continue;
                        }
                        enReturnCode = this.SetWirelessStateForDeviceLegacy(sCommandName, dataIn);
                        num = 4;
                        continue;
                    case 1:
                        enReturnCode = this.SetWirelessStateForDeviceW4(sCommandName, dataIn);
                        num = 3;
                        continue;
                    case 2:
                        num = !this.A1 ? 0 : 5;
                        continue;
                    case 3:
                        goto label_5;
                    case 4:
                    case 6:
                        goto label_10;
                    case 5:
                        enReturnCode = this.AA(sCommandName, dataIn);
                        num = 6;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_5:
            if (1 == 0)
                ;
            label_10:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1D4D㕏♑͓㽕⩗㽙せ㭝፟ᅡ㝣ብ१ṩ५⡭Ὧqび\x1375\x0E77\x1379ύ\x1B7D", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg䩩ᝫ幭൯", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode AA(string A_0, object A_1)
        {
            int A_1_1 = 19;
            label_2:
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜࡞\x0860ᅢd୦౨ᡪṬ㱮հቲŴቶ㽸ᑺོ㭾\xE480\xF582\xEC84\xE486\xEC88캊\xE08C搜\xFD90\xF292\xE194ﺖ\xF698\xF59A", A_1_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            bool flag = false;
            int num1 = 13;
            XmlEdit xmlEdit=null;
            string key1=null;
            int num2=0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                    case 4:
                    case 6:
                    case 7:
                    case 21:
                    case 35:
                        label_48:
                        num1 = 23;
                        continue;
                    case 1:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0釒맔ꋖ볘꿚닜냞闠询실뫦", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 19;
                        continue;
                    case 2:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0蓒苔雖韘ﳚ胜", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 8;
                        continue;
                    case 3:
                        switch (num2)
                        {
                            case 0:
                                num1 = 9;
                                continue;
                            case 1:
                                num1 = 16;
                                continue;
                            case 2:
                                num1 = 36;
                                continue;
                            case 3:
                                num1 = 10;
                                continue;
                            case 4:
                                num1 = 17;
                                continue;
                            case 5:
                                goto label_48;
                            default:
                                num1 = 5;
                                continue;
                        }
                    case 5:
                        num1 = 24;
                        continue;
                    case 8:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪뫬룮냰뷲틴꫶", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 15;
                        continue;
                    case 9:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0蓒駔雖韘ﳚ胜", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 40;
                        continue;
                    case 10:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0铒藔蓖ﻘ蛚", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 28;
                        continue;
                    case 11:
                        if ((key1 = A_0) != null)
                        {
                            num1 = 27;
                            continue;
                        }
                        goto case 24;
                    case 12:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪뫬ꏮ냰뷲틴꫶", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 1;
                        continue;
                    case 13:
                        try
                        {
                            flag = (bool)A_1;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        num1 = 14;
                        continue;
                    case 14:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 31;
                            continue;
                        }
                        goto label_53;
                    case 15:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0铒藔蓖ﻘ蛚", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 29;
                        continue;
                    case 16:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0釒맔ꋖ볘꿚닜냞闠询실뫦", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 39;
                        continue;
                    case 17:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0蓒駔雖韘ﳚ胜", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 12;
                        continue;
                    case 18:
                    case 38:
                        goto label_53;
                    case 19:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪꿬菮蓰雲致飶雸迺闼\xD8FE尀", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 2;
                        continue;
                    case 20:
                        num1 = 3;
                        continue;
                    case 22:
                        if (xmlEdit != null)
                        {
                            num1 = 34;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜࡞\x0860ᅢd୦౨ᡪṬ㱮հቲŴቶ㽸ᑺོ㭾\xE480\xF582\xEC84\xE486\xEC88캊\xE08C搜\xFD90\xF292\xE194ﺖ\xF698\xF59A", A_1_1), Module.a("ၘ㕚\x2E5C\x2B5E`ൢᅤ\x0E66\x0868ὪѬnὰ卲ᩴᅶ奸⍺ၼ\x137E쒀\xE782\xEC84\xF386ꦈ力\xE88Cﮎ\xE490\xE192ﮔ\xF296ﶘ뮚\xF39C\xEA9E춠쾢", A_1_1));
                        num1 = 18;
                        continue;
                    case 23:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 25;
                            continue;
                        }
                        goto label_53;
                    case 24:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num1 = 6;
                        continue;
                    case 25:
                        xmlEdit.XmlDoc.Save(this.WirelessEmulationFile);
                        num1 = 38;
                        continue;
                    case 26:
                        Dictionary<string, int> dictionary = new Dictionary<string, int>(6);
                        string key2 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨㱪Ⅼ\x2E6E㽰嵲ぴ\x1976\x1878\x197Aᅼ\x1A7E\xE580", A_1_1);
                        int num3 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num3);
                        string key3 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨⥪Ŭᩮᑰݲᩴᡶ\x0D78\x137A卼㩾\xEF80\xE282\xE784\xEB86\xEC88\xEF8A", A_1_1);
                        int num4 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num4);
                        string key4 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨㱪㩬\x2E6E㽰嵲ぴ\x1976\x1878\x197Aᅼ\x1A7E\xE580", A_1_1);
                        int num5 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num5);
                        string key5 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨ⱪ㵬㱮彰㙲᭴ᙶ᭸\x177A\x187C\x1B7E", A_1_1);
                        int num6 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num6);
                        string key6 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨⩪Ŭͮ彰㙲᭴ᙶ᭸\x177A\x187C\x1B7E", A_1_1);
                        int num7 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num7);
                        string key7 = Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨㡪\x086C᭮㕰ᙲ\x0374Ṷ᩸Ṻ\x2E7C\x0B7E\xE080\xF782\xE084", A_1_1);
                        int num8 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num8);
                        // ISSUE: reference to a compiler-generated field
                        global::A.K = dictionary;
                        num1 = 33;
                        continue;
                    case 27:
                        num1 = 37;
                        continue;
                    case 28:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪ꫬ뿮ꋰ퓲ꣴ", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 7;
                        continue;
                    case 29:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪ꫬ뿮ꋰ퓲ꣴ", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 21;
                        continue;
                    case 30:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit non-virtual call
                        if (global::A.K.TryGetValue(key1, out num2))
                        {
                            num1 = 20;
                            continue;
                        }
                        goto case 24;
                    case 31:
                        XmlDocument xdocDeviceInfo = (XmlDocument)null;
                        enReturnCode = this.GetDeviceInfoXml(out xdocDeviceInfo);
                        xmlEdit = new XmlEdit(xdocDeviceInfo);
                        num1 = 22;
                        continue;
                    case 32:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪뫬룮냰뷲틴꫶", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 0;
                        continue;
                    case 33:
                        num1 = 30;
                        continue;
                    case 34:
                        num1 = 11;
                        continue;
                    case 36:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐킒\xE094\xE596\xEB98ﺚ\xF39C\xEB9E\xF2A0힢쒤펦첨\xF0AA莬膮麰\xE7B2킴풶톸햺튼펾껀꓂별鏆냈믊\xA8CC\xF2CE\xF6D0蓒苔雖韘ﳚ胜", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 32;
                        continue;
                    case 37:
                        // ISSUE: reference to a compiler-generated field
                        if (global::A.K == null)
                        {
                            num1 = 26;
                            continue;
                        }
                        goto case 33;
                    case 39:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪꿬菮蓰雲致飶雸迺闼\xD8FE尀", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 4;
                        continue;
                    case 40:
                        xmlEdit.SetString(Module.a("癘瑚ቜ⩞ᕠ።ၤ፦䙨⽪౬᭮ၰ屲ㅴቶླྀቺṼ\x1A7E\xF280겂솄\xE286ﾈ\xE28A\xEE8C\xEA8E뺐\xDF92\xF494\xE496\xED98즚\xF89C\xEE9E풠욢횤펦첨쾪ﺬ\xDBAE킰잲킴颶\xEEB8\xF6BA\xF4BC\xE4BE\xEFC0\xEDC2\xEAC4\xE9C6\xE7C8\xE4CA駌\xAACE닐믒믔룖뗘듚뫜ꛞ뗠髢闤苦퓨쳪뫬ꏮ냰뷲틴꫶", A_1_1), flag ? Module.a("㙘㕚", A_1_1) : Module.a("㙘㵚㭜", A_1_1));
                        num1 = 35;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_53:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜࡞\x0860ᅢd୦౨ᡪṬ㱮հቲŴቶ㽸ᑺོ㭾\xE480\xF582\xEC84\xE486\xEC88캊\xE08C搜\xFD90\xF292\xE194ﺖ\xF698\xF59A", A_1_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲啴\x0C76䥸ٺ", A_1_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetWirelessStateForDeviceW4(string sCommandName, object dataIn)
        {
            int A_1 = 14;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݓ㍕ⱗ\x0D59㕛ⱝ՟\x0E61ţᕥ᭧㥩ᡫ\x0F6Dѯ\x1771㉳\x1975\x0A77㹹\x197B\x087D\xE97F\xE181\xE183톅벇", A_1), Module.a("ݓ≕㥗⡙⡛㭝џ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] abyDeviceState = new byte[4];
            bool flag = false;
            int num = 16;
            while (true)
            {
                string str=null;
                switch (num)
                {
                    case 0:
                    case 4:
                    case 8:
                    case 9:
                    case 11:
                    case 17:
                        num = 5;
                        continue;
                    case 1:
                        num = 25;
                        continue;
                    case 2:
                        if (str == Module.a("͓㽕⩗㽙せ㭝፟ᅡ䩣ㅥ\x2467\x2B69≫䁭㕯ᱱᕳᑵᑷό\x187B", A_1))
                        {
                            abyDeviceState[2] = this.C1.F.H;
                            num = 4;
                            continue;
                        }
                        num = 6;
                        continue;
                    case 3:
                        if (1 == 0)
                            break;
                        break;
                    case 5:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 12;
                            continue;
                        }
                        goto label_43;
                    case 6:
                        num = 14;
                        continue;
                    case 7:
                        abyDeviceState[0] = (byte)1;
                        abyDeviceState[1] = (byte)0;
                        num = 24;
                        continue;
                    case 10:
                        abyDeviceState[3] = flag ? (byte)1 : (byte)0;
                        enReturnCode = this.SetDeviceStateInBIOSW4(abyDeviceState);
                        num = 21;
                        continue;
                    case 12:
                        num = 10;
                        continue;
                    case 13:
                        if ((str = sCommandName) != null)
                        {
                            num = 28;
                            continue;
                        }
                        break;
                    case 14:
                        if (!(str == Module.a("͓㽕⩗㽙せ㭝፟ᅡ䩣\x2465ѧὩ५ᩭὯᵱsṵ噷㽹ቻώ\xE27F\xEE81\xE183\xE285", A_1)))
                        {
                            num = 15;
                            continue;
                        }
                        abyDeviceState[2] = this.C1.E.H;
                        num = 17;
                        continue;
                    case 15:
                        num = 22;
                        continue;
                    case 16:
                        try
                        {
                            flag = (bool)dataIn;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        num = 23;
                        continue;
                    case 18:
                        num = 3;
                        continue;
                    case 19:
                        if (str == Module.a("͓㽕⩗㽙せ㭝፟ᅡ䩣Ⅵ㡧㥩䉫\x2B6Dṯ\x1371ᙳ᩵ᵷṹ", A_1))
                        {
                            abyDeviceState[2] = this.C1.G.H;
                            num = 9;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 20:
                        num = 19;
                        continue;
                    case 21:
                        goto label_43;
                    case 22:
                        if (!(str == Module.a("͓㽕⩗㽙せ㭝፟ᅡ䩣ㅥ㽧\x2B69≫䁭㕯ᱱᕳᑵᑷό\x187B", A_1)))
                        {
                            num = 20;
                            continue;
                        }
                        abyDeviceState[2] = this.C1.D.H;
                        num = 11;
                        continue;
                    case 23:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 7;
                            continue;
                        }
                        goto case 0;
                    case 24:
                        if (this.C1 == null)
                        {
                            num = 27;
                            continue;
                        }
                        goto case 26;
                    case 25:
                        if (str == Module.a("͓㽕⩗㽙せ㭝፟ᅡ䩣❥ѧ٩䉫\x2B6Dṯ\x1371ᙳ᩵ᵷṹ", A_1))
                        {
                            abyDeviceState[2] = (byte)254;
                            num = 8;
                            continue;
                        }
                        num = 18;
                        continue;
                    case 26:
                        num = 13;
                        continue;
                    case 27:
                        enReturnCode = this.RefreshStructsFromDeviceInfo();
                        num = 26;
                        continue;
                    case 28:
                        num = 2;
                        continue;
                    default:
                        goto label_2;
                }
                enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                num = 0;
            }
            label_43:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ݓ㍕ⱗ\x0D59㕛ⱝ՟\x0E61ţᕥ᭧㥩ᡫ\x0F6Dѯ\x1771㉳\x1975\x0A77㹹\x197B\x087D\xE97F\xE181\xE183톅벇", A_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭偯\x0971䑳\x0B75", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetWirelessStateForDeviceLegacy(string sCommandName, object dataIn)
        {
            int A_1 = 15;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0C5A㑜ⵞѠརdᑦᩨ㡪ᥬ\x0E6Eհᙲ㍴ᡶ\x0B78㽺\x187Cॾ\xE880\xE082\xE084쮆\xEC88\xEC8A\xEC8C\xEC8E\xE890", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            byte[] abyDeviceState = new byte[4];
            bool bState = false;
            int num = 11;
            string str=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 21;
                        continue;
                    case 1:
                        num = 2;
                        continue;
                    case 2:
                        if (str == Module.a("ɔ㹖⭘㹚ㅜ㩞በၢ䭤て㹨⩪⍬䅮㑰ᵲᑴᕶᕸṺ\x197C", A_1))
                        {
                            Utility.SetBit(ref abyDeviceState[0], 2, bState);
                            Utility.SetBit(ref abyDeviceState[1], 2, true);
                            num = 6;
                            continue;
                        }
                        if (1 == 0)
                            ;
                        num = 14;
                        continue;
                    case 3:
                    case 6:
                    case 7:
                    case 18:
                    case 21:
                        num = 13;
                        continue;
                    case 4:
                        num = 5;
                        continue;
                    case 5:
                        if ((str = sCommandName) != null)
                        {
                            num = 8;
                            continue;
                        }
                        goto case 0;
                    case 8:
                        num = 12;
                        continue;
                    case 9:
                        num = 0;
                        continue;
                    case 10:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 4;
                            continue;
                        }
                        goto case 3;
                    case 11:
                        try
                        {
                            bState = (bool)dataIn;
                        }
                        catch
                        {
                            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        }
                        num = 10;
                        continue;
                    case 12:
                        if (!(str == Module.a("ɔ㹖⭘㹚ㅜ㩞በၢ䭤て╨⩪⍬䅮㑰ᵲᑴᕶᕸṺ\x197C", A_1)))
                        {
                            num = 19;
                            continue;
                        }
                        Utility.SetBit(ref abyDeviceState[0], 0, bState);
                        Utility.SetBit(ref abyDeviceState[1], 0, true);
                        num = 3;
                        continue;
                    case 13:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 16;
                            continue;
                        }
                        goto label_34;
                    case 14:
                        num = 17;
                        continue;
                    case 15:
                        if (str == Module.a("ɔ㹖⭘㹚ㅜ㩞በၢ䭤╦ըṪ\x086C᭮ṰᱲŴὶ坸㹺\x137CṾ\xE380\xEF82\xE084\xE386", A_1))
                        {
                            Utility.SetBit(ref abyDeviceState[0], 1, bState);
                            Utility.SetBit(ref abyDeviceState[1], 1, true);
                            num = 7;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 16:
                        enReturnCode = this.SetDeviceStateInBIOSLegacy(abyDeviceState);
                        num = 20;
                        continue;
                    case 17:
                        if (!(str == Module.a("ɔ㹖⭘㹚ㅜ㩞በၢ䭤♦ըݪ䍬⩮ὰቲ\x1774᭶\x1C78ὺ", A_1)))
                        {
                            num = 9;
                            continue;
                        }
                        Utility.SetBit(ref abyDeviceState[0], 3, bState);
                        Utility.SetBit(ref abyDeviceState[1], 3, true);
                        num = 18;
                        continue;
                    case 19:
                        num = 15;
                        continue;
                    case 20:
                        goto label_34;
                    default:
                        goto label_2;
                }
            }
            label_34:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0C5A㑜ⵞѠརdᑦᩨ㡪ᥬ\x0E6Eհᙲ㍴ᡶ\x0B78㽺\x187Cॾ\xE880\xE082\xE084쮆\xEC88\xEC8A\xEC8C\xEC8E\xE890", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode SetDeviceStateInBIOSLegacy(byte[] abyDeviceState)
        {
            int A_1 = 10;
            label_2:
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕ㵗ⱙ㕛㵝՟ㅡၣݥᱧཀྵ╫m㉯㭱㭳╵㑷ό᭻ώ\xE37Fﮁ", A_1), Module.a("͏♑㕓\x2455ⱗ㽙㡛", A_1));
            enReturnCode enReturnCode = enReturnCode.e_UNKNOWN;
            byte[] dataOut = (byte[])null;
            WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Write, enWriteCmdType.SetWirelessState, abyDeviceState, 4U, out dataOut, enSizeOut.eSIZE_0);
                        num = 2;
                        continue;
                    case 1:
                    case 2:
                        goto label_8;
                    case 3:
                        if (wmiBiosClient != null)
                        {
                            num = 0;
                            continue;
                        }
                        enReturnCode = enReturnCode.e_NULL_VALUE;
                        this.log.ErrorMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕ㵗ⱙ㕛㵝՟ㅡၣݥᱧཀྵ╫m㉯㭱㭳╵㑷ό᭻ώ\xE37Fﮁ", A_1), Module.a("᥏㱑❓≕㥗㑙⡛㝝şᙡൣ॥٧䩩ͫ\x086D偯╱ᥳή㩷㍹㍻\x2D7D썿\xEE81\xED83\xE385\xE687ﺉ겋ﲍ\xF58F\xE691\xE193\xE495\xF697ﾙ\xF89B뺝캟힡좣쪥", A_1));
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_8:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("͏㝑⁓ቕ㵗ⱙ㕛㵝՟ㅡၣݥᱧཀྵ╫m㉯㭱㭳╵㑷ό᭻ώ\xE37Fﮁ", A_1), Module.a("ፏ㵑㥓♕㑗㽙⡛㭝џ䉡፣ཥᱧɩ噫乭", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        private enReturnCode WirelessStateSetIsThisNecessary(string sCommandName, object dataIn)
        {
            int A_1 = 2;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1F47⍉㹋\x2B4D㱏㝑❓╕ୗ\x2E59㵛⩝՟ㅡţብ", A_1), Module.a("ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num = 7;
            string str=null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (str == Module.a("\x1F47⍉㹋\x2B4D㱏㝑❓╕癗࡙㥛㡝\x125Fݡᝣ\x0E65", A_1))
                        {
                            this.G1 = this.RefreshStructsFromDeviceInfo();
                            num = 2;
                            continue;
                        }
                        num = 4;
                        continue;
                    case 1:
                        num = 9;
                        continue;
                    case 2:
                    case 3:
                    case 11:
                        goto label_19;
                    case 4:
                        num = 6;
                        continue;
                    case 5:
                        num = 0;
                        continue;
                    case 6:
                        if (str == Module.a("\x1F47⍉㹋\x2B4D㱏㝑❓╕癗᭙⥛⩝ཟちţeᩧཀྵὫ٭", A_1))
                        {
                            this.H1 = (bool)dataIn;
                            num = 3;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 7:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 8;
                            continue;
                        }
                        goto label_19;
                    case 8:
                        num = 10;
                        continue;
                    case 9:
                        if (1 == 0)
                            ;
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 11;
                        continue;
                    case 10:
                        if ((str = sCommandName) != null)
                        {
                            num = 5;
                            continue;
                        }
                        goto case 9;
                    default:
                        goto label_2;
                }
            }
            label_19:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1F47⍉㹋\x2B4D㱏㝑❓╕ୗ\x2E59㵛⩝՟ㅡţብ", A_1), Module.a("େ╉⅋㹍㱏㝑⁓㍕㱗穙\x2B5B㝝ᑟ\x0A61䑣\x1D65塧ᝩ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        protected override void InitPropertySetList()
        {
            int A_1 = 19;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮≰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
            this.propertySetList.Add(new Command.Property(Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨㡪\x086C᭮㕰ᙲ\x0374Ṷ᩸Ṻ\x2E7C\x0B7E\xE080\xF782\xE084", A_1), typeof(XmlDocument), Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ㩨Ὢ౬᭮ᑰ\x2072ၴͶ", A_1), false));
            this.propertySetList.Add(new Command.Property(Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ䝨⩪Ŭͮ彰㙲᭴ᙶ᭸\x177A\x187C\x1B7E", A_1), typeof(bool), Module.a("๘\x325A⽜㩞ൠ٢ᙤᑦ㩨Ὢ౬᭮ᑰ\x2072ၴͶ", A_1), false));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ၘ㕚㑜\x2B5Eㅠᅢ\x0A64ᝦ౨ᥪᥬ᙮≰ᙲŴ㭶ၸ\x087Aॼ", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨", A_1));
        }

        private enReturnCode WirelessExecute(string sCommandName, object dataIn, out object dataOut)
        {
            int A_1 = 17;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("Vじ⥚㡜㍞Ѡၢᙤ≦ᅨ\x0E6A\x0E6Cᩮհᙲ", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            dataOut = (object)null;
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_7;
                    case 2:
                        if (1 == 0)
                            ;
                        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_7:
            this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("Vじ⥚㡜㍞Ѡၢᙤ≦ᅨ\x0E6A\x0E6Cᩮհᙲ", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ卲\x0E74䝶Ѹ", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        protected override void InitExecuteList()
        {
            int A_1 = 3;
            if (1 == 0)
                ;
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎ᑐ⭒ご㑖ⱘ⽚㡜፞\x0860ၢᅤ", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("H╊\x244C㭎ᑐ⭒ご㑖ⱘ⽚㡜፞\x0860ၢᅤ", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘", A_1));
        }

        public enum C
        {
            A,
            B,
            C,
            D,
        }

        private struct D
        {
            public string A;
            public bool B;
            public string C;
            public ushort D1;
            public ushort E;
            public ushort F;
            public ushort G;
            public byte H;
            public ushort I;
        }

        private class A
        {
            public byte Aa;
            public bool B;
            public bool C;
            public CommandWireless.D D;
            public CommandWireless.D E;
            public CommandWireless.D F;
            public CommandWireless.D G;
        }

        private struct B
        {
            public bool A;
            public bool Bb;
            public bool C;
            public bool D;
            public bool E;
            public bool F;
            public bool G;
            public bool H;
            public bool I;
            public bool J;
            public bool K;
            public bool L;
            public bool M;
            public bool N;
            public bool O;
            public bool P;
        }

        protected delegate enReturnCode E(out XmlDocument A_0);
    }
}
