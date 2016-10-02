// Decompiled with JetBrains decompiler
// Type: CaslSmBios.hpSMBIOS
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using hpCasl;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Management;
using System.Runtime.InteropServices;

namespace CaslSmBios
{
    public class hpSMBIOS
    {
        protected CaslLogger A1;
        private byte[] B1;
        private int C1;

        public static string a(string A_0, int A_1)
        {
            char[] chArray1 = A_0.ToCharArray();
            int num1 = 433430423 + A_1;
            int num2 = 0;
            int num3 = 1;
            if (num2 < num3)
                goto label_2;
            label_1:
            int index1 = num2;
            char[] chArray2 = chArray1;
            int index2 = index1;
            int num4 = (int)(short)chArray1[index1];
            int num5 = (int)byte.MaxValue;
            int num6 = num4 & num5;
            int num7 = num1;
            int num8 = 1;
            int num9 = num7 + num8;
            byte num10 = (byte)(num6 ^ num7);
            int num11 = 8;
            int num12 = num4 >> num11;
            int num13 = num9;
            int num14 = 1;
            num1 = num13 + num14;
            int num15 = (int)(byte)(num12 ^ num13);
            int num16 = (int)(ushort)((uint)num10 << 8 | (uint)(byte)num15);
            chArray2[index2] = (char)num16;
            int num17 = 1;
            num2 += num17;
            label_2:
            int length = chArray1.Length;
            if (num2 >= length)
                return string.Intern(new string(chArray1));
            goto label_1;
        }

        public hpSMBIOS()
        {
            int A_1 = 12;
            // ISSUE: explicit constructor call

            this.A1 = new CaslLogger();
            if (!this.D(out this.B1))
            {
                if (this.B(out this.B1))
                    this.A1.WarningMessage(hpSMBIOS.a("\xF7A3\xEBA5\xEAA7\xE3A9\xE3ABﶭ邯욱햳풵풷\xDFB9鲻톽ꊿ뛁ꗃ꿅ꛇ꿉\xA8CB\xEECDꗏꇑ뷓룕뿗龎进\xA7DD鏟雡臣该죧ꯩ볫\xA7ED", A_1));
                else if (this.A(out this.B1))
                {
                    this.A1.WarningMessage(hpSMBIOS.a("\xF7A3\xEBA5\xEAA7\xE3A9\xE3ABﶭ邯욱햳풵풷\xDFB9鲻톽ꊿ뛁ꗃ꿅ꛇ꿉\xA8CB\xEECDꗏꇑ뷓룕뿗龎軛믝蟟诡韣鋥髧鏩", A_1));
                }
                else
                {
                    this.A1.ErrorMessage(hpSMBIOS.a("\xE7A3장욧쒩쎫\xDAAD邯삱톳ힵ\xDCB7骹\xEFBB\xF3BD芿证诃闅\xE8C7뻉\xA4CB볍뿏\xA7D1돓뻕\xF8D7럙\xA9DB닝铟诡铣諥跧쫩臫语釯鳱蟳", A_1));
                    throw new InvalidOperationException(hpSMBIOS.a("\xE7A3장욧쒩쎫\xDAAD邯삱톳ힵ\xDCB7骹\xEFBB\xF3BD芿证诃闅", A_1));
                }
            }
            if (this.B1 == null)
                return;
            this.C1 = this.B1.Length;
        }

        public void GetBIOSInfo(ref hpSMBIOS.BIOSINFO_TYPE_0 info)
        {
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 0, ref iLength);
            int num1 = 1;
            int num2 = 0;
            int num3 = 0;
            ArrayList stringList = null;
            int num4 = 0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num1 = 12;
                        continue;
                    case 1:
                        if (@struct != -1)
                        {
                            num1 = 11;
                            continue;
                        }
                        goto label_33;
                    case 2:
                        if (@struct <= this.C1)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto label_31;
                    case 3:
                        num1 = 14;
                        continue;
                    case 4:
                        info.sVendor = ((string)stringList[num4 - 1]).Trim();
                        num1 = 6;
                        continue;
                    case 5:
                        stringList = this.GetStringList(@struct, iLength);
                        num4 = (int)this.B1[@struct + 4];
                        num3 = (int)this.B1[@struct + 5];
                        num2 = (int)this.B1[@struct + 8];
                        num1 = 15;
                        continue;
                    case 6:
                        num1 = 16;
                        continue;
                    case 7:
                        num1 = 9;
                        continue;
                    case 8:
                        if (num4 - 1 < stringList.Count)
                        {
                            num1 = 4;
                            continue;
                        }
                        goto case 6;
                    case 9:
                        if (num3 - 1 < stringList.Count)
                        {
                            if (1 == 0)
                                ;
                            num1 = 10;
                            continue;
                        }
                        goto case 0;
                    case 10:
                        info.sBIOSVersion = ((string)stringList[num3 - 1]).Trim();
                        num1 = 0;
                        continue;
                    case 11:
                        num1 = 2;
                        continue;
                    case 12:
                        if (num2 != 0)
                        {
                            num1 = 3;
                            continue;
                        }
                        goto case 13;
                    case 13:
                        info.usStartSegment = this.MakeWord(@struct + 6);
                        info.byROMSize = this.B1[@struct + 9];
                        info.uiCharacteristics1 = this.MakeDWord(@struct + 10);
                        info.uiCharacteristics2 = this.MakeDWord(@struct + 14);
                        info.byExtension = this.B1[@struct + 18];
                        num1 = 18;
                        continue;
                    case 14:
                        if (num2 - 1 < stringList.Count)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 13;
                    case 15:
                        if (num4 != 0)
                        {
                            num1 = 17;
                            continue;
                        }
                        goto case 6;
                    case 16:
                        if (num3 != 0)
                        {
                            num1 = 7;
                            continue;
                        }
                        goto case 0;
                    case 17:
                        num1 = 8;
                        continue;
                    case 18:
                        goto label_29;
                    case 19:
                        info.sReleaseDate = ((string)stringList[num2 - 1]).Trim();
                        num1 = 13;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_29:
            return;
            label_33:
            return;
            label_31:;
        }

        public void GetSystemInfo(ref hpSMBIOS.SYSTEMINFO_TYPE_1 info)
        {
            int A_1 = 3;
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 1, ref iLength);
            int num1 = 22;
            int num2 = 0;
            ArrayList stringList = null;
            int num3 = 0;
            int num4 = 0;
            byte[] b = null;
            string str = null;
            int index = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        info.sSerialNumber = ((string)stringList[num3 - 1]).Trim();
                        num1 = 17;
                        continue;
                    case 1:
                        if (num2 != 0)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto case 4;
                    case 2:
                        num1 = 16;
                        continue;
                    case 3:
                        info.sManufacturer = ((string)stringList[num5 - 1]).Trim();
                        num1 = 19;
                        continue;
                    case 4:
                        b = new byte[16];
                        str = "";
                        index = 0;
                        num1 = 35;
                        continue;
                    case 5:
                        num1 = 38;
                        continue;
                    case 6:
                        num1 = 10;
                        continue;
                    case 7:
                        num1 = 27;
                        continue;
                    case 8:
                        if (num7 != 0)
                        {
                            num1 = 9;
                            continue;
                        }
                        goto case 13;
                    case 9:
                        num1 = 21;
                        continue;
                    case 10:
                        if (num6 - 1 < stringList.Count)
                        {
                            num1 = 29;
                            continue;
                        }
                        goto case 30;
                    case 11:
                        if (index >= 16)
                        {
                            num1 = 25;
                            continue;
                        }
                        b[index] = this.B1[@struct + 8 + index];
                        str += string.Format(hpSMBIOS.a("\xE09A궜ꖞ裂醢\xD8A4", A_1), (object)this.B1[@struct + 8 + index]);
                        ++index;
                        num1 = 28;
                        continue;
                    case 12:
                        if (num5 - 1 < stringList.Count)
                        {
                            num1 = 3;
                            continue;
                        }
                        goto case 19;
                    case 13:
                        num1 = 24;
                        continue;
                    case 14:
                        goto label_51;
                    case 15:
                        num1 = 37;
                        continue;
                    case 16:
                        if (num2 - 1 < stringList.Count)
                        {
                            num1 = 34;
                            continue;
                        }
                        goto case 4;
                    case 17:
                        num1 = 36;
                        continue;
                    case 18:
                        stringList = this.GetStringList(@struct, iLength);
                        num5 = (int)this.B1[@struct + 4];
                        num4 = (int)this.B1[@struct + 5];
                        num7 = (int)this.B1[@struct + 6];
                        num3 = (int)this.B1[@struct + 7];
                        num6 = (int)this.B1[@struct + 25];
                        num2 = (int)this.B1[@struct + 26];
                        num1 = 23;
                        continue;
                    case 19:
                        num1 = 20;
                        continue;
                    case 20:
                        if (num4 != 0)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto case 33;
                    case 21:
                        if (num7 - 1 < stringList.Count)
                        {
                            num1 = 31;
                            continue;
                        }
                        goto case 13;
                    case 22:
                        if (@struct != -1)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_59;
                    case 23:
                        if (num5 != 0)
                        {
                            num1 = 26;
                            continue;
                        }
                        goto case 19;
                    case 24:
                        if (num3 != 0)
                        {
                            num1 = 7;
                            continue;
                        }
                        goto case 17;
                    case 25:
                        info.A = str.ToString();
                        info.guidUUID = new Guid(b);
                        info.eWakeupType = (hpSMBIOS.enWAKEUPTYPE)this.B1[@struct + 24];
                        num1 = 14;
                        continue;
                    case 26:
                        num1 = 12;
                        continue;
                    case 27:
                        if (num3 - 1 < stringList.Count)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto case 17;
                    case 28:
                    case 35:
                        if (1 == 0)
                            ;
                        num1 = 11;
                        continue;
                    case 29:
                        info.sSKUNumber = ((string)stringList[num6 - 1]).Trim();
                        num1 = 30;
                        continue;
                    case 30:
                        num1 = 1;
                        continue;
                    case 31:
                        info.sVersion = ((string)stringList[num7 - 1]).Trim();
                        num1 = 13;
                        continue;
                    case 32:
                        info.sProductName = ((string)stringList[num4 - 1]).Trim();
                        num1 = 33;
                        continue;
                    case 33:
                        num1 = 8;
                        continue;
                    case 34:
                        info.sFamily = ((string)stringList[num2 - 1]).Trim();
                        num1 = 4;
                        continue;
                    case 36:
                        if (num6 != 0)
                        {
                            num1 = 6;
                            continue;
                        }
                        goto case 30;
                    case 37:
                        if (@struct <= this.C1)
                        {
                            num1 = 18;
                            continue;
                        }
                        goto label_55;
                    case 38:
                        if (num4 - 1 < stringList.Count)
                        {
                            num1 = 32;
                            continue;
                        }
                        goto case 33;
                    default:
                        goto label_2;
                }
            }
            label_51:
            return;
            label_59:
            return;
            label_55:;
        }

        public void GetBaseBoardInfo(ref hpSMBIOS.BASEBOARDINFO_TYPE_2 info)
        {
            int A_1 = 1;
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 2, ref iLength);
            int num1 = 3;
            ArrayList stringList = new ArrayList();
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        if (num2 - 1 < stringList.Count)
                        {
                            num1 = 21;
                            continue;
                        }
                        goto case 9;
                    case 1:
                        num1 = 7;
                        continue;
                    case 2:
                        num1 = 17;
                        continue;
                    case 3:
                        if (@struct != -1)
                        {
                            num1 = 13;
                            continue;
                        }
                        goto label_41;
                    case 4:
                        num1 = 0;
                        continue;
                    case 5:
                        goto label_24;
                    case 6:
                        if (num4 != 0)
                        {
                            num1 = 10;
                            continue;
                        }
                        goto case 2;
                    case 7:
                        if (num3 - 1 < stringList.Count)
                        {
                            num1 = 16;
                            continue;
                        }
                        goto case 23;
                    case 8:
                        stringList = this.GetStringList(@struct, iLength);
                        num4 = (int)this.B1[@struct + 4];
                        num3 = (int)this.B1[@struct + 5];
                        num2 = (int)this.B1[@struct + 6];
                        num5 = (int)this.B1[@struct + 7];
                        info.sManufacturer = (string)null;
                        info.sProduct = (string)null;
                        info.sVersion = (string)null;
                        info.sSerialNumber = (string)null;
                        num1 = 6;
                        continue;
                    case 9:
                        num1 = 18;
                        continue;
                    case 10:
                        num1 = 14;
                        continue;
                    case 11:
                        if (num2 != 0)
                        {
                            if (1 == 0)
                                ;
                            num1 = 4;
                            continue;
                        }
                        goto case 9;
                    case 12:
                        num1 = 20;
                        continue;
                    case 13:
                        num1 = 22;
                        continue;
                    case 14:
                        if (num4 - 1 < stringList.Count)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 2;
                    case 15:
                        info.sSerialNumber = ((string)stringList[num5 - 1]).Trim();
                        num1 = 5;
                        continue;
                    case 16:
                        info.sProduct = ((string)stringList[num3 - 1]).Trim();
                        info.sProduct = info.sProduct.Replace(hpSMBIOS.a("\xF198", A_1), "");
                        info.sProduct = info.sProduct.Replace(hpSMBIOS.a("톘", A_1), "");
                        num1 = 23;
                        continue;
                    case 17:
                        if (num3 != 0)
                        {
                            num1 = 1;
                            continue;
                        }
                        goto case 23;
                    case 18:
                        if (num5 != 0)
                        {
                            num1 = 12;
                            continue;
                        }
                        goto label_33;
                    case 19:
                        info.sManufacturer = ((string)stringList[num4 - 1]).Trim();
                        num1 = 2;
                        continue;
                    case 20:
                        if (num5 - 1 < stringList.Count)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_37;
                    case 21:
                        info.sVersion = ((string)stringList[num2 - 1]).Trim();
                        num1 = 9;
                        continue;
                    case 22:
                        if (@struct <= this.C1)
                        {
                            num1 = 8;
                            continue;
                        }
                        goto label_28;
                    case 23:
                        num1 = 11;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_24:
            return;
            label_41:
            return;
            label_37:
            return;
            label_33:
            return;
            label_28:;
        }

        public void GetSystemEnclosureInfo(ref hpSMBIOS.SYSTEMENCLOSUREINFO_TYPE_3 info)
        {
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 3, ref iLength);
            int num1 = 17;
            ArrayList stringList = new ArrayList();
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num1 = 20;
                        continue;
                    case 1:
                        num1 = 11;
                        continue;
                    case 2:
                        if (@struct <= this.C1)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_36;
                    case 3:
                        if (num3 - 1 < stringList.Count)
                        {
                            num1 = 12;
                            continue;
                        }
                        goto case 18;
                    case 4:
                        if (num2 - 1 < stringList.Count)
                        {
                            num1 = 14;
                            continue;
                        }
                        goto case 1;
                    case 5:
                        info.sAssetTag = ((string)stringList[num4 - 1]).Trim();
                        num1 = 7;
                        continue;
                    case 6:
                        goto label_32;
                    case 7:
                        info.eEnclosureType = (byte)((uint)this.B1[@struct + 5] & (uint)sbyte.MaxValue);
                        info.bChassisLock = ((int)this.B1[@struct + 5] & 128) != 0;
                        info.eBootupState = this.B1[@struct + 9];
                        info.ePowerSupplyState = this.B1[@struct + 10];
                        info.eThermalState = this.B1[@struct + 11];
                        info.eSecurityStatus = this.B1[@struct + 12];
                        info.uiOemDefined = this.MakeDWord(@struct + 13);
                        num1 = 6;
                        continue;
                    case 8:
                        if (1 == 0)
                            ;
                        num1 = 21;
                        continue;
                    case 9:
                        num1 = 2;
                        continue;
                    case 10:
                        if (num2 != 0)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 1;
                    case 11:
                        if (num4 != 0)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto case 7;
                    case 12:
                        info.sManufacturer = ((string)stringList[num3 - 1]).Trim();
                        num1 = 18;
                        continue;
                    case 13:
                        if (num3 != 0)
                        {
                            num1 = 16;
                            continue;
                        }
                        goto case 18;
                    case 14:
                        info.sSerialNumber = ((string)stringList[num2 - 1]).Trim();
                        num1 = 1;
                        continue;
                    case 15:
                        stringList = this.GetStringList(@struct, iLength);
                        num3 = (int)this.B1[@struct + 4];
                        num5 = (int)this.B1[@struct + 6];
                        num2 = (int)this.B1[@struct + 7];
                        num4 = (int)this.B1[@struct + 8];
                        info.sManufacturer = (string)null;
                        info.sVersion = (string)null;
                        info.sSerialNumber = (string)null;
                        info.sAssetTag = (string)null;
                        num1 = 13;
                        continue;
                    case 16:
                        num1 = 3;
                        continue;
                    case 17:
                        if (@struct != -1)
                        {
                            num1 = 9;
                            continue;
                        }
                        goto label_40;
                    case 18:
                        num1 = 24;
                        continue;
                    case 19:
                        num1 = 4;
                        continue;
                    case 20:
                        if (num4 - 1 < stringList.Count)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto case 7;
                    case 21:
                        if (num5 - 1 < stringList.Count)
                        {
                            num1 = 23;
                            continue;
                        }
                        goto case 22;
                    case 22:
                        num1 = 10;
                        continue;
                    case 23:
                        info.sVersion = ((string)stringList[num5 - 1]).Trim();
                        num1 = 22;
                        continue;
                    case 24:
                        if (num5 != 0)
                        {
                            num1 = 8;
                            continue;
                        }
                        goto case 22;
                    default:
                        goto label_2;
                }
            }
            label_32:
            return;
            label_40:
            return;
            label_36:;
        }

        public void GetPhysicalMemoryInfo(ref hpSMBIOS.MEMORYDEVICE_TYPE_17 info)
        {
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 17, ref iLength);
            int num = 7;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (@struct != -1)
                        {
                            num = 8;
                            continue;
                        }
                        goto label_26;
                    case 1:
                    case 12:
                        num = 0;
                        continue;
                    case 2:
                        info.unTotalMemory = (uint)this.MakeWord(@struct + 12);
                        num = 4;
                        continue;
                    case 3:
                        num = 11;
                        continue;
                    case 4:
                        @struct += iLength;
                        num = 12;
                        continue;
                    case 5:
                        goto label_24;
                    case 6:
                        if (@struct > this.C1)
                        {
                            num = 5;
                            continue;
                        }
                        @struct = this.FindStruct(@struct, 17, ref iLength);
                        num = 10;
                        continue;
                    case 7:
                        if (@struct != -1)
                        {
                            num = 3;
                            continue;
                        }
                        goto case 4;
                    case 8:
                        if (1 == 0)
                            ;
                        num = 6;
                        continue;
                    case 9:
                        num = 13;
                        continue;
                    case 10:
                        if (@struct != -1)
                        {
                            num = 9;
                            continue;
                        }
                        goto case 14;
                    case 11:
                        if (@struct <= this.C1)
                        {
                            num = 2;
                            continue;
                        }
                        goto case 4;
                    case 13:
                        if (@struct <= this.C1)
                        {
                            num = 15;
                            continue;
                        }
                        goto case 14;
                    case 14:
                        @struct += iLength;
                        num = 1;
                        continue;
                    case 15:
                        info.unTotalMemory += (uint)this.MakeWord(@struct + 12);
                        num = 14;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_24:
            return;
            label_26:;
        }

        public void GetProcessorInfo(ref hpSMBIOS.PROCESSORINFO_TYPE_4 info)
        {
            label_2:
            int iLength = -1;
            int @struct = this.FindStruct(0, 4, ref iLength);
            int num1 = 3;
            int num2 = 0;
            int num3 = 0;
            ArrayList stringList = new ArrayList();
            int num4 = 0;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num1 = 4;
                        continue;
                    case 1:
                        num1 = 16;
                        continue;
                    case 2:
                        if (@struct <= this.C1)
                        {
                            num1 = 5;
                            continue;
                        }
                        goto label_31;
                    case 3:
                        if (@struct != -1)
                        {
                            num1 = 15;
                            continue;
                        }
                        goto label_33;
                    case 4:
                        if (num4 - 1 < stringList.Count)
                        {
                            num1 = 18;
                            continue;
                        }
                        goto case 12;
                    case 5:
                        if (1 == 0)
                            ;
                        stringList = this.GetStringList(@struct, iLength);
                        num4 = (int)this.B1[@struct + 4];
                        num2 = (int)this.B1[@struct + 7];
                        num3 = (int)this.B1[@struct + 16];
                        info.sProcessorManuf = (string)null;
                        info.sSocketDesignation = (string)null;
                        info.sProcessorVersion = (string)null;
                        num1 = 10;
                        continue;
                    case 6:
                        info.sProcessorVersion = ((string)stringList[num3 - 1]).Trim();
                        num1 = 1;
                        continue;
                    case 7:
                        info.byProcessorType = this.B1[@struct + 5];
                        info.byProcessorFamily = this.B1[@struct + 6];
                        info.byVoltage = this.B1[@struct + 17];
                        info.usExternalClockMHz = this.MakeWord(@struct + 18);
                        info.usMaxSpeed = this.MakeWord(@struct + 20);
                        info.usCurrentSpeed = this.MakeWord(@struct + 22);
                        info.byStatus = (byte)((uint)this.B1[@struct + 24] & 7U);
                        info.byProcessorUpgrade = this.B1[@struct + 25];
                        info.uiProcessorID1 = 0U;
                        info.uiProcessorID2 = 0U;
                        info.usL1CacheHandle = this.MakeWord(@struct + 26);
                        info.usL2CacheHandle = this.MakeWord(@struct + 28);
                        info.usL3CacheHandle = this.MakeWord(@struct + 30);
                        num1 = 8;
                        continue;
                    case 8:
                        goto label_29;
                    case 9:
                        num1 = 11;
                        continue;
                    case 10:
                        if (num4 != 0)
                        {
                            num1 = 0;
                            continue;
                        }
                        goto case 12;
                    case 11:
                        if (num3 - 1 < stringList.Count)
                        {
                            num1 = 6;
                            continue;
                        }
                        goto case 1;
                    case 12:
                        num1 = 14;
                        continue;
                    case 13:
                        info.sProcessorManuf = ((string)stringList[num2 - 1]).Trim();
                        num1 = 7;
                        continue;
                    case 14:
                        if (num3 != 0)
                        {
                            num1 = 9;
                            continue;
                        }
                        goto case 1;
                    case 15:
                        num1 = 2;
                        continue;
                    case 16:
                        if (num2 != 0)
                        {
                            num1 = 19;
                            continue;
                        }
                        goto case 7;
                    case 17:
                        if (num2 - 1 < stringList.Count)
                        {
                            num1 = 13;
                            continue;
                        }
                        goto case 7;
                    case 18:
                        info.sSocketDesignation = ((string)stringList[num4 - 1]).Trim();
                        num1 = 12;
                        continue;
                    case 19:
                        num1 = 17;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_29:
            return;
            label_33:
            return;
            label_31:;
        }

        public void GetOnBoardDevicesInfo(ref hpSMBIOS.ONBOARD_DEVICES_INFO_TYPE_10 info)
        {
            label_2:
            if (1 == 0)
                ;
            hpSMBIOS.enONBOARD_DEVICE_TYPES iDeviceType = hpSMBIOS.enONBOARD_DEVICE_TYPES.Video;
            int num1 = this.GetOnBoardDevicesInfo_Type_10(ref info, iDeviceType);
            int num2 = 1;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        if (-1 == num1)
                        {
                            num2 = 2;
                            continue;
                        }
                        goto label_8;
                    case 2:
                        num1 = this.GetOnBoardDevicesInfo_Type_41(ref info, iDeviceType);
                        num2 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_6:
            return;
            label_8:;
        }

        public int GetOnBoardDevicesInfo_Type_41(ref hpSMBIOS.ONBOARD_DEVICES_INFO_TYPE_10 info, hpSMBIOS.enONBOARD_DEVICE_TYPES iDeviceType)
        {
            label_2:
            int iLength = -1;
            int num1 = -1;
            int @struct = this.FindStruct(0, 41, ref iLength);
            int num2 = 6;
            ArrayList stringList1 = new ArrayList();
            int num3 = 0;
            byte num4 = 0;
            byte num5 = 0;
            ArrayList stringList2 = new ArrayList();
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        num3 = (int)this.B1[@struct + 4];
                        int index1 = (int)this.B1[@struct + 5];
                        num4 = (byte)((uint)this.B1[index1] & 128U);
                        num5 = (byte)((uint)this.B1[index1] & (uint)sbyte.MaxValue);
                        num2 = 12;
                        continue;
                    case 1:
                        if (@struct <= this.C1)
                        {
                            num2 = 0;
                            continue;
                        }
                        goto case 15;
                    case 2:
                        if (@struct <= this.C1)
                        {
                            num2 = 23;
                            continue;
                        }
                        goto label_48;
                    case 3:
                        if (num1 != -1)
                        {
                            if (1 == 0)
                                ;
                            num2 = 7;
                            continue;
                        }
                        @struct = this.FindStruct(@struct, 41, ref iLength);
                        num2 = 30;
                        continue;
                    case 4:
                        if (@struct != -1)
                        {
                            num2 = 21;
                            continue;
                        }
                        goto label_48;
                    case 5:
                        if (num3 - 1 < stringList1.Count)
                        {
                            num2 = 31;
                            continue;
                        }
                        goto case 20;
                    case 6:
                        if (@struct != -1)
                        {
                            num2 = 9;
                            continue;
                        }
                        goto label_48;
                    case 7:
                        goto label_48;
                    case 8:
                        num1 = @struct;
                        num2 = 16;
                        continue;
                    case 9:
                        num2 = 11;
                        continue;
                    case 10:
                        if (num3 != 0)
                        {
                            num2 = 27;
                            continue;
                        }
                        goto case 20;
                    case 11:
                        if (@struct <= this.C1)
                        {
                            num2 = 22;
                            continue;
                        }
                        goto label_48;
                    case 12:
                        if ((int)num5 == (int)(byte)iDeviceType)
                        {
                            num2 = 28;
                            continue;
                        }
                        goto case 13;
                    case 13:
                        @struct += iLength;
                        num2 = 15;
                        continue;
                    case 14:
                        num2 = 29;
                        continue;
                    case 15:
                    case 24:
                        num2 = 4;
                        continue;
                    case 16:
                        @struct += iLength;
                        num2 = 24;
                        continue;
                    case 17:
                        if ((int)num5 == (int)(byte)iDeviceType)
                        {
                            num2 = 25;
                            continue;
                        }
                        goto case 16;
                    case 18:
                        if (num3 != 0)
                        {
                            num2 = 14;
                            continue;
                        }
                        goto case 8;
                    case 19:
                        num2 = 1;
                        continue;
                    case 20:
                        num1 = @struct;
                        num2 = 13;
                        continue;
                    case 21:
                        num2 = 2;
                        continue;
                    case 22:
                        num3 = (int)this.B1[@struct + 4];
                        int index2 = (int)this.B1[@struct + 5];
                        num4 = (byte)((uint)this.B1[index2] & 128U);
                        num5 = (byte)((uint)this.B1[index2] & (uint)sbyte.MaxValue);
                        num2 = 17;
                        continue;
                    case 23:
                        num2 = 3;
                        continue;
                    case 25:
                        stringList2 = this.GetStringList(@struct, iLength);
                        info.usDeviceType = (ushort)num5;
                        info.byDeviceState = num4;
                        num2 = 18;
                        continue;
                    case 26:
                        info.usUMAVideoMemory = ((string)stringList2[num3 - 1]).Trim();
                        info.unUmaVideoMemory = Convert.ToUInt32(info.usUMAVideoMemory);
                        num2 = 8;
                        continue;
                    case 27:
                        num2 = 5;
                        continue;
                    case 28:
                        stringList1 = this.GetStringList(@struct, iLength);
                        info.usDeviceType = (ushort)num5;
                        info.byDeviceState = num4;
                        num2 = 10;
                        continue;
                    case 29:
                        if (num3 - 1 < stringList2.Count)
                        {
                            num2 = 26;
                            continue;
                        }
                        goto case 8;
                    case 30:
                        if (@struct != -1)
                        {
                            num2 = 19;
                            continue;
                        }
                        goto case 15;
                    case 31:
                        info.usUMAVideoMemory = ((string)stringList1[num3 - 1]).Trim();
                        info.unUmaVideoMemory = Convert.ToUInt32(info.usUMAVideoMemory);
                        num2 = 20;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_48:
            return num1;
        }

        public int GetOnBoardDevicesInfo_Type_10(ref hpSMBIOS.ONBOARD_DEVICES_INFO_TYPE_10 info, hpSMBIOS.enONBOARD_DEVICE_TYPES iDeviceType)
        {
            label_2:
            int iLength = -1;
            int num1 = -1;
            int @struct = this.FindStruct(0, 10, ref iLength);
            int num2 = 7;
            int num3 = 0;
            byte num4 = 0;
            byte num5 = 0;
            int num6 = 0;
            int iStrLen = 0;
            int num7 = 0;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                    case 11:
                        num2 = 9;
                        continue;
                    case 1:
                        if (@struct <= this.C1)
                        {
                            num2 = 3;
                            continue;
                        }
                        goto label_21;
                    case 2:
                        if (num1 != -1)
                        {
                            num2 = 5;
                            continue;
                        }
                        int num8 = 5 + 2 * (num3 - 1);
                        iStrLen = iLength - num8;
                        num6 = num8 + @struct;
                        int index = 4 + 2 * (num3 - 1) + @struct;
                        num5 = (byte)((uint)this.B1[index] & 128U);
                        num4 = (byte)((uint)this.B1[index] & (uint)sbyte.MaxValue);
                        num2 = 10;
                        continue;
                    case 3:
                        num7 = ((int)this.B1[@struct + 1] - 4) / 2;
                        num3 = 1;
                        num2 = 11;
                        continue;
                    case 4:
                        ++num3;
                        if (1 == 0)
                            ;
                        num2 = 0;
                        continue;
                    case 5:
                        goto label_21;
                    case 6:
                        info.usDeviceType = (ushort)num4;
                        info.byDeviceState = num5;
                        info.usUMAVideoMemory = this.GetStringOfSize(num6 + 1, iStrLen);
                        info.unUmaVideoMemory = Convert.ToUInt32(info.usUMAVideoMemory);
                        num1 = @struct;
                        num2 = 4;
                        continue;
                    case 7:
                        if (@struct != -1)
                        {
                            num2 = 12;
                            continue;
                        }
                        goto label_21;
                    case 8:
                        num2 = 2;
                        continue;
                    case 9:
                        if (num3 <= num7)
                        {
                            num2 = 8;
                            continue;
                        }
                        goto label_21;
                    case 10:
                        if ((int)num4 == (int)(byte)iDeviceType)
                        {
                            num2 = 6;
                            continue;
                        }
                        goto case 4;
                    case 12:
                        num2 = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_21:
            return num1;
        }

        public int FindStruct(int iStart, int iType, ref int iLength)
        {
            label_2:
            int num1 = -1;
            int index = iStart;
            iLength = 0;
            int num2 = 3;
            int endOfStruct = 0;
            int num3 = 0;

            int num4 = 0;
            while (true)
            {
            
                switch (num2)
                {
                    case 0:
                        num2 = 12;
                        continue;
                    case 1:
                        if ((int)this.B1[index] == iType)
                        {
                            num2 = 10;
                            continue;
                        }
                        goto case 11;
                    case 2:
                        num2 = endOfStruct == -1 ? 6 : 0;
                        continue;
                    case 3:
                    case 14:
                        num2 = 9;
                        continue;
                    case 4:
                        num2 = 1;
                        continue;
                    case 5:
                        goto label_23;
                    case 6:
                        num4 = this.C1;
                        break;
                    case 7:
                        if (iType != -1)
                        {
                            num2 = 4;
                            continue;
                        }
                        goto case 10;
                    case 8:
                        if (num1 == -1)
                        {
                            int num5 = (int)this.B1[index + 1];
                            endOfStruct = this.FindEndOfStruct(index + num5);
                            num2 = 2;
                            continue;
                        }
                        num2 = 5;
                        continue;
                    case 9:
                        if (index < this.C1)
                        {
                            num2 = 13;
                            continue;
                        }
                        goto label_23;
                    case 10:
                        iLength = num3 - index;
                        num1 = index;
                        num2 = 11;
                        continue;
                    case 11:
                        index = num3;
                        num2 = 14;
                        continue;
                    case 12:
                        num4 = endOfStruct + 2;
                        break;
                    case 13:
                        num2 = 8;
                        continue;
                    default:
                        goto label_2;
                }
                num3 = num4;
                if (1 == 0)
                    ;
                num2 = 7;
            }
            label_23:
            return num1;
        }

        private bool D(out byte[] A_0)
        {
            int A_1 = 15;
            if (1 == 0)
                ;
            bool flag = false;
            A_0 = (byte[])null;
            try
            {
                IEnumerator enumerator = RawSMBiosTables.GetInstances().GetEnumerator();
                try
                {
                    int num = 4;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                goto label_18;
                            case 2:
                                num = 0;
                                continue;
                            case 3:
                                if (enumerator.MoveNext())
                                {
                                    RawSMBiosTables rawSmBiosTables = (RawSMBiosTables)enumerator.Current;
                                    A_0 = rawSmBiosTables.SMBiosData;
                                    flag = true;
                                    num = 1;
                                    continue;
                                }
                                num = 2;
                                continue;
                            default:
                                num = 3;
                                continue;
                        }
                    }
                }
                finally
                {
                    label_12:
                    IDisposable disposable = enumerator as IDisposable;
                    int num = 2;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                goto label_16;
                            case 1:
                                disposable.Dispose();
                                num = 0;
                                continue;
                            case 2:
                                if (disposable != null)
                                {
                                    num = 1;
                                    continue;
                                }
                                goto label_16;
                            default:
                                goto label_12;
                        }
                    }
                    label_16:;
                }
            }
            catch (Exception ex)
            {
                this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE0A6첨\xDFAAﺬ\xE2AE\xF3B0者華\xE4B6\xEDB8\xDABA\xDFBC펾꓀雂뛄껆\xA7C8곊髌苎飐", A_1), ex.Message);
                A_0 = (byte[])null;
                flag = false;
            }
            label_18:
            return flag;
        }

        private bool C(out byte[] A_0)
        {
            int A_1 = 8;
            bool flag = false;
            A_0 = (byte[])null;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(new ManagementScope(hpSMBIOS.a("튟춡쮣튥\xF4A7\xDDA9솫잭", A_1)), (ObjectQuery)new SelectQuery(hpSMBIOS.a("\xED9F\xF1A1\xF7A3쮥\xEAA7쎩쎫\xDDAD\xEFAF\xE0B1햳솵\xEBB7\xF7B9ﺻힽ꾿뇁郃\xA7C5\xAAC7ꛉ꧋뷍", A_1))).Get().GetEnumerator();
                try
                {
                    int num = 1;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                num = 4;
                                continue;
                            case 2:
                                num = 3;
                                continue;
                            case 3:
                                goto label_17;
                            case 4:
                                if (enumerator.MoveNext())
                                {
                                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                                    A_0 = (byte[])managementObject[hpSMBIOS.a("\xF39F\xEFA1\xE6A3쾥잧\xD9A9\xE8AB쾭쒯펱", A_1)];
                                    flag = true;
                                    num = 0;
                                    continue;
                                }
                                num = 2;
                                continue;
                            default:
                                if (1 == 0)
                                    goto case 0;
                                else
                                    goto case 0;
                        }
                    }
                }
                finally
                {
                    int num = 1;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                enumerator.Dispose();
                                num = 2;
                                continue;
                            case 2:
                                goto label_15;
                            default:
                                if (enumerator != null)
                                {
                                    num = 0;
                                    continue;
                                }
                                goto label_15;
                        }
                    }
                    label_15:;
                }
            }
            catch (Exception ex)
            {
                this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE79F잡킣\xF5A5\xE5A7\xE8A9\xE5AB\xE1AD\xE3AF\xE6B1햳풵풷\xDFB9\xE9BB춽ꦿ곁ꏃ釅藇菉ﻋ", A_1), ex.Message);
                A_0 = (byte[])null;
                flag = false;
            }
            label_17:
            return flag;
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetSystemFirmwareTable(uint A_0, uint A_1, byte[] A_2, uint A_3);

        private bool B(out byte[] A_0)
        {
            int A_1 = 18;
            bool flag = false;
            A_0 = (byte[])null;
            try
            {
                int num = 2;
                while (true)
                {
                    uint A_0_1 = 0;
                    uint systemFirmwareTable = 0;
                    byte[] A_2 = null;
                    switch (num)
                    {
                        case 0:
                            label123456:
                            num = 1;
                            continue;
                        case 1:
                            goto label_15;
                        case 2:
                            if (1 == 0)
                                break;
                            break;
                        case 3:
                            if (systemFirmwareTable > 0U)
                            {
                                num = 5;
                                continue;
                            }
                            goto case 0;
                        case 4:
                            A_0_1 = BitConverter.ToUInt32(new byte[4]
                            {
                (byte) 66,
                (byte) 77,
                (byte) 83,
                (byte) 82
                            }, 0);
                            systemFirmwareTable = hpSMBIOS.GetSystemFirmwareTable(A_0_1, 0U, (byte[])null, 0U);
                            num = 3;
                            continue;
                        case 5:
                            A_2 = new byte[systemFirmwareTable];
                            systemFirmwareTable = hpSMBIOS.GetSystemFirmwareTable(A_0_1, 0U, A_2, systemFirmwareTable);
                            num = 6;
                            continue;
                        case 6:
                            if (systemFirmwareTable > 0U)
                            {
                                num = 7;
                                continue;
                            }
                            goto case 0;
                        case 7:
                            A_0 = new byte[(systemFirmwareTable - 8U)];
                            Array.Copy((Array)A_2, 8L, (Array)A_0, 0L, (long)(systemFirmwareTable - 8U));
                            flag = true;
                            num = 0;
                            continue;
                    }
                  /*  if (this.A())
                    {
                        num = 4;
                    }
                    else
                    {
                        goto label123456;

                    }*/ //??????
                }
            }
            catch (Exception ex)
            {
                this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xEDA9즫\xDAAD\xE3AFﾱ\xF6B3ﾵ\xF7B7\xE9B9\xE8BB\xDFBDꊿ껁ꇃ鏅믇ꏉꋋ꧍菏ꯑ\xA7D3ꋕ뷗럙鷛軝꧟", A_1), ex.Message);
                A_0 = (byte[])null;
                flag = false;
            }
            label_15:
            return flag;
        }

        private bool A(out byte[] A_0)
        {
            int A_1 = 16;
            bool flag = false;
            A_0 = (byte[])null;
            try
            {
                label_3:
                byte[] numArray = (byte[])Registry.LocalMachine.OpenSubKey(hpSMBIOS.a("ﮧ\xF3A9ﾫ節\xF5AFﾱ\xE8B3\xF5B5춷좹캻\xDBBD꺿뛁蟃꧅ꛇ뻉뻋ꇍ볏臑뇓ꋕ蓗觙맛곝雟诡蟣菥鯧뛩ꇫ鷭華\x9FF1雳\x9FF5韷觹ꃻ뫽懿瘁攃", A_1)).GetValue(hpSMBIOS.a("ﮧ\xE7A9\xEEAB잭\xDFAF솱\xF0B3ힵ첷\xDBB9", A_1));
                int num = 0;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            if (numArray != null)
                            {
                                num = 3;
                                continue;
                            }
                            goto case 1;
                        case 1:
                            num = 2;
                            continue;
                        case 2:
                            goto label_9;
                        case 3:
                            A_0 = new byte[numArray.Length - 8];
                            Array.Copy((Array)numArray, 8, (Array)A_0, 0, numArray.Length - 8);
                            flag = true;
                            num = 1;
                            continue;
                        default:
                            goto label_3;
                    }
                }
            }
            catch (Exception ex)
            {
                this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xEFA7쾩\xD8ABﶭﶯ\xF0B1ﶳ例\xEBB7\xEEB9\xDDBB\xDCBD겿\xA7C1釃뗅ꇇ\xA4C9ꯋ鳍뗏뗑뷓ꗕ곗꣙ꗛ", A_1), ex.Message);
                A_0 = (byte[])null;
                flag = false;
            }
            label_9:
            if (1 == 0)
                ;
            return flag;
        }

        private bool A()
        {
            label_2:
            bool flag = false;
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        num = 2;
                        continue;
                    case 1:
                        goto label_10;
                    case 2:
                        if (Environment.OSVersion.Version.Major >= 6)
                        {
                            num = 4;
                            continue;
                        }
                        goto label_10;
                    case 3:
                        if (1 == 0)
                            ;
                        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_10;
                    case 4:
                        flag = true;
                        num = 1;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_10:
            return flag;
        }

        private ushort MakeWord(int iIndex)
        {
            if (1 == 0)
                ;
            return (ushort)((uint)(ushort)((uint)(ushort)this.B1[iIndex + 1] << 8) | (uint)this.B1[iIndex]);
        }

        private uint MakeDWord(int iIndex)
        {
            if (1 == 0)
                ;
            return (((uint)this.B1[iIndex + 3] << 8 | (uint)this.B1[iIndex + 2]) << 8 | (uint)this.B1[iIndex + 1]) << 8 | (uint)this.B1[iIndex];
        }

        private int FindEndOfStruct(int iStart)
        {
            label_2:
            int num1 = -1;
            int index = iStart;
            int num2 = 3;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        num1 = index;
                        num2 = 8;
                        continue;
                    case 1:
                        if (index < this.C1 - 1)
                        {
                            num2 = 4;
                            continue;
                        }
                        goto label_16;
                    case 2:
                        num2 = 9;
                        continue;
                    case 3:
                    case 6:
                        num2 = 1;
                        continue;
                    case 4:
                        num2 = 7;
                        continue;
                    case 5:
                        if ((int)this.B1[index] == 0)
                        {
                            num2 = 2;
                            continue;
                        }
                        goto case 8;
                    case 7:
                        if (1 == 0)
                            ;
                        num2 = num1 == -1 ? 5 : 10;
                        continue;
                    case 8:
                        ++index;
                        num2 = 6;
                        continue;
                    case 9:
                        if ((int)this.B1[index + 1] == 0)
                        {
                            num2 = 0;
                            continue;
                        }
                        goto case 8;
                    case 10:
                        goto label_16;
                    default:
                        goto label_2;
                }
            }
            label_16:
            return num1;
        }

        private string GetString(int iIndex)
        {
            label_2:
            string str = "";
            int index = iIndex;
            int num = 1;
            char ch=(char)0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_11;
                    case 1:
                    case 4:
                        num = 3;
                        continue;
                    case 2:
                        if (1 == 0)
                            ;
                        if ((int)ch != 0)
                        {
                            num = 5;
                            continue;
                        }
                        goto label_11;
                    case 3:
                        if (index >= this.C1)
                        {
                            num = 0;
                            continue;
                        }
                        ch = (char)this.B1[index];
                        num = 2;
                        continue;
                    case 5:
                        str += Convert.ToString(ch);
                        ++index;
                        num = 4;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_11:
            return str;
        }

        private ArrayList GetStringList(int iIndex, int iLength)
        {
            label_3:
            ArrayList arrayList = new ArrayList();
            string str = string.Empty;
            int num1 = (int)this.B1[iIndex + 1];
            int iIndex1 = iIndex + num1;
            int num2 = 0;
            while (true)
            {
                if (1 == 0)
                    ;
                switch (num2)
                {
                    case 0:
                    case 5:
                        num2 = 1;
                        continue;
                    case 1:
                        num2 = iIndex1 < this.C1 ? 3 : 2;
                        continue;
                    case 2:
                        goto label_9;
                    case 3:
                        if ((int)this.B1[iIndex1] != 0)
                        {
                            num2 = 4;
                            continue;
                        }
                        goto label_9;
                    case 4:
                        string @string = this.GetString(iIndex1);
                        arrayList.Add((object)@string);
                        iIndex1 += @string.Length + 1;
                        num2 = 5;
                        continue;
                    default:
                        goto label_3;
                }
            }
            label_9:
            return arrayList;
        }

        private string GetStringOfSize(int iIndex, int iStrLen)
        {
            label_2:
            string str = "";
            int num1 = iStrLen;
            int index = iIndex;
            int num2 = 3;
            char ch = (char)0;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                    case 3:
                        num2 = 2;
                        continue;
                    case 1:
                        if ((int)ch != 0)
                        {
                            num2 = 4;
                            continue;
                        }
                        goto label_14;
                    case 2:
                        if (index < this.C1)
                        {
                            num2 = 7;
                            continue;
                        }
                        goto label_14;
                    case 4:
                        if (1 == 0)
                            ;
                        str += (string)(object)ch;
                        ++index;
                        --num1;
                        num2 = 0;
                        continue;
                    case 5:
                        goto label_14;
                    case 6:
                        if (num1 > 0)
                        {
                            ch = (char)this.B1[index];
                            num2 = 1;
                            continue;
                        }
                        num2 = 5;
                        continue;
                    case 7:
                        num2 = 6;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_14:
            return str;
        }

        [Flags]
        public enum Characteristics2
        {
            Wireless4 = 1,
            Tablet = 524288,
        }

        public struct BIOSINFO_TYPE_0
        {
            public bool bUseCachedData;
            public string sVendor;
            public string sBIOSVersion;
            public ushort usStartSegment;
            public string sReleaseDate;
            public byte byROMSize;
            public uint uiCharacteristics1;
            public uint uiCharacteristics2;
            public byte byExtension;
        }

        public struct SYSTEMINFO_TYPE_1
        {
            public bool bUseCachedData;
            public string sManufacturer;
            public string sProductName;
            public string sVersion;
            public string sSerialNumber;
            public Guid guidUUID;
            public string A;
            public hpSMBIOS.enWAKEUPTYPE eWakeupType;
            public string sSKUNumber;
            public string sFamily;
        }

        public struct BASEBOARDINFO_TYPE_2
        {
            public bool bUseCachedData;
            public string sManufacturer;
            public string sProduct;
            public string sVersion;
            public string sSerialNumber;
        }

        public struct SYSTEMENCLOSUREINFO_TYPE_3
        {
            public bool bUseCachedData;
            public string sManufacturer;
            public byte eEnclosureType;
            public bool bChassisLock;
            public string sVersion;
            public string sSerialNumber;
            public string sAssetTag;
            public byte eBootupState;
            public byte ePowerSupplyState;
            public byte eThermalState;
            public byte eSecurityStatus;
            public uint uiOemDefined;
        }

        public struct PROCESSORINFO_TYPE_4
        {
            public bool bUseCachedData;
            public string sSocketDesignation;
            public byte byProcessorType;
            public byte byProcessorFamily;
            public string sProcessorManuf;
            public uint uiProcessorID1;
            public uint uiProcessorID2;
            public string sProcessorVersion;
            public byte byVoltage;
            public ushort usExternalClockMHz;
            public ushort usMaxSpeed;
            public ushort usCurrentSpeed;
            public byte byStatus;
            public byte byProcessorUpgrade;
            public ushort usL1CacheHandle;
            public ushort usL2CacheHandle;
            public ushort usL3CacheHandle;
        }

        public struct ONBOARD_DEVICES_INFO_TYPE_10
        {
            public bool bUseCachedData;
            public ushort usDeviceType;
            public byte byDeviceState;
            public uint unUmaVideoMemory;
            public string usUMAVideoMemory;
        }

        public struct MEMORYDEVICE_TYPE_17
        {
            public bool bUseCachedData;
            public uint unTotalMemory;
        }

        public enum enWAKEUPTYPE
        {
            eReserved,
            eOther,
            eUnknown,
            eAPM_Timer,
            eModem_Ring,
            eLAN_Remote,
            ePower_Switch,
            ePCI_PME,
            eAC_Power_Restored,
        }

        public enum enMEMORY_LOCATION
        {
            Other = 1,
            Unknown = 2,
            motherboard = 3,
            ISA_card = 4,
            EISA_card = 5,
            PCI_card = 6,
            MCA_card = 7,
            PCMCIA_card = 8,
            Proprietary_card = 9,
            NuBus = 10,
            PC98_C20_card = 160,
            PC98_C24_card = 161,
            PC98_E_card = 162,
            PC98_Local_card = 163,
        }

        public enum enMEMORY_USE
        {
            Other = 1,
            Unknown = 2,
            System = 3,
            Video = 4,
            Flash = 5,
            Non_volatile_RAM = 6,
            Cache = 7,
        }

        public enum enONBOARD_DEVICE_TYPES
        {
            Other = 1,
            Unknown = 2,
            Video = 3,
            SCSI_Controller = 4,
            Ethernet = 5,
            Token_Ring = 6,
            Sound = 7,
            PATA_Controller = 8,
            SATA_Controller = 9,
            SAS_Controller = 10,
        }
    }
}
