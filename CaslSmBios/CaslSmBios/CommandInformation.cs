// Decompiled with JetBrains decompiler
// Type: CaslSmBios.CommandInformation
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using hpCasl;
using System;
using System.Collections.Generic;

namespace CaslSmBios
{
  public class CommandInformation : Command
  {
    private enReturnCode I = enReturnCode.e_NULL_VALUE;
    private hpSMBIOS bios;
    public static hpSMBIOS.BIOSINFO_TYPE_0 B1;
    public static hpSMBIOS.SYSTEMINFO_TYPE_1 C1;
    public static hpSMBIOS.BASEBOARDINFO_TYPE_2 D1;
    public static hpSMBIOS.SYSTEMENCLOSUREINFO_TYPE_3 E1;
    public static hpSMBIOS.PROCESSORINFO_TYPE_4 F1;
    public static hpSMBIOS.ONBOARD_DEVICES_INFO_TYPE_10 G1;
    public static hpSMBIOS.MEMORYDEVICE_TYPE_17 H1;

    public enReturnCode InitGet()
    {
      int A_1 = 8;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      try
      {
        this.bios = new hpSMBIOS();
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        if (1 == 0)
          ;
        CommandInformation.B1 = new hpSMBIOS.BIOSINFO_TYPE_0();
        CommandInformation.B1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.C1 = new hpSMBIOS.SYSTEMINFO_TYPE_1();
        CommandInformation.C1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.D1 = new hpSMBIOS.BASEBOARDINFO_TYPE_2();
        CommandInformation.D1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.E1 = new hpSMBIOS.SYSTEMENCLOSUREINFO_TYPE_3();
        CommandInformation.E1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.F1 = new hpSMBIOS.PROCESSORINFO_TYPE_4();
        CommandInformation.F1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.G1 = new hpSMBIOS.ONBOARD_DEVICES_INFO_TYPE_10();
        CommandInformation.G1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      try
      {
        CommandInformation.H1 = new hpSMBIOS.MEMORYDEVICE_TYPE_17();
        CommandInformation.H1.bUseCachedData = false;
      }
      catch (Exception ex)
      {
        base.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE99F첡춣튥\xEFA7쾩\xD8AB", A_1), ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
      return enReturnCode;
    }

    private enReturnCode InformationBios(string sCommandName, out object dataOut)
    {
      int A_1 = 18;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num1 = 18;
      int startIndex=0;
      string str1=string.Empty;
      string sIdentity = string.Empty; ;
      string sSubIdentity = string.Empty; ;
      string key1 = string.Empty; ;
      int num2 = 0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            num1 = 19;
            continue;
          case 1:
            this.bios.GetBIOSInfo(ref CommandInformation.B1);
            CommandInformation.B1.bUseCachedData = true;
            num1 = 8;
            continue;
          case 2:
            num1 = 27;
            continue;
          case 3:
            num1 = 25;
            continue;
          case 4:
            if (startIndex > 0)
            {
              num1 = 12;
              continue;
            }
            if (1 == 0)
              ;
            startIndex = CommandInformation.B1.sBIOSVersion.IndexOf(hpSMBIOS.a("誩", A_1));
            str1 = CommandInformation.B1.sBIOSVersion.Substring(startIndex);
            num1 = 21;
            continue;
          case 5:
          case 10:
          case 17:
          case 20:
          case 22:
          case 24:
          case 28:
            num1 = 23;
            continue;
          case 6:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(6);
            string key2 = hpSMBIOS.a("睊삫쾭쒯풱\xDBB3쒵햷钹ﺻ\xF7BD辿釁鋃ꏅ뫇막ꗋꇍ뻏黑믓룕뿗", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
           dictionary.Add(key2, num3);
            string key3 = hpSMBIOS.a("睊삫쾭쒯풱\xDBB3쒵햷钹ﺻ\xF7BD辿釁雃ꏅ\xA4C7꿉귋뷍뗏雑뗓ꋕ뷗", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = hpSMBIOS.a("睊삫쾭쒯풱\xDBB3쒵햷钹ﺻ\xF7BD辿釁鋃ꏅꛇ껉ꏋ볍", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = hpSMBIOS.a("睊삫쾭쒯풱\xDBB3쒵햷钹\xF5BB춽钿ꏁꛃ\xAAC5귇뻉", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = hpSMBIOS.a("\xECA9즫쾭쒯잱욳펵隷\xEDB9햻첽ꖿ껁ꇃ뗅믇ﻉ\xE2CB鷍ꗏꋑꓓ맕\xAAD7껙맛뫝", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = hpSMBIOS.a("睊삫쾭쒯풱\xDBB3쒵햷钹ﺻ\xF7BD辿釁鋃ꏅ뫇막ꗋꇍ뻏臑볓맕\xAAD7껙", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            // ISSUE: reference to a compiler-generated field
            global::A.C = dictionary;
            num1 = 3;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 26;
              continue;
            }
            goto label_40;
          case 8:
            num1 = 7;
            continue;
          case 9:
            goto label_40;
          case 11:
            num1 = 16;
            continue;
          case 12:
            str1 = CommandInformation.B1.sBIOSVersion.Substring(startIndex + 4);
            num1 = 13;
            continue;
          case 13:
          case 21:
            dataOut = (object) str1.Trim();
            num1 = 5;
            continue;
          case 14:
            if ((key1 = sCommandName) != null)
            {
              num1 = 11;
              continue;
            }
            goto case 27;
          case 15:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("蒩", A_1), hpSMBIOS.a("誩", A_1)) + hpSMBIOS.a("誩\xDAAB쾭\xDCAF잱톳隵\xE3B7骹", A_1) + dataOut.ToString() + hpSMBIOS.a("誩\xF1AB", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num1 = 9;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            if (global::A.C == null)
            {
              num1 = 6;
              continue;
            }
            goto case 3;
          case 18:
            if (!CommandInformation.B1.bUseCachedData)
            {
              num1 = 1;
              continue;
            }
            goto case 8;
          case 19:
            switch (num2)
            {
              case 0:
                dataOut = (object) CommandInformation.B1.sBIOSVersion;
                num1 = 20;
                continue;
              case 1:
                dataOut = (object) CommandInformation.B1.sReleaseDate;
                num1 = 17;
                continue;
              case 2:
                dataOut = (object) CommandInformation.B1.sVendor;
                num1 = 22;
                continue;
              case 3:
                dataOut = (object)  (((int) CommandInformation.B1.uiCharacteristics2 & 524288) != 0 ? 1 : 0);
                num1 = 28;
                continue;
              case 4:
                dataOut = (object) (((int)B1.uiCharacteristics2 & 1) != 0 ? 1 : 0);
                num1 = 24;
                continue;
              case 5:
                startIndex = CommandInformation.B1.sBIOSVersion.IndexOf(hpSMBIOS.a("ﲩ즫\xDCAD麯", A_1));
                num1 = 4;
                continue;
              default:
                num1 = 2;
                continue;
            }
          case 23:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num1 = 15;
              continue;
            }
            goto label_40;
          case 25:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.C.TryGetValue(key1, out num2))
            {
              num1 = 0;
              continue;
            }
            goto case 27;
          case 26:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("\xE3A9슫좭\xDFAF삱\xD9B3ힵ첷펹펻킽芿ꯁꯃ뗅", A_1);
            string str2 = string.Empty;
            num1 = 14;
            continue;
          case 27:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 10;
            continue;
          default:
            goto label_2;
        }
      }
label_40:
      return enReturnCode;
    }

    private enReturnCode InformationSystem(string sCommandName, out object dataOut)
    {
      int A_1 = 9;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num1 = 0;
      string sIdentity = string.Empty;
      string sSubIdentity = string.Empty;
      int num2 = 0;
      string key1 = string.Empty;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (!CommandInformation.C1.bUseCachedData)
            {
              num1 = 20;
              continue;
            }
            goto case 17;
          case 1:
          case 3:
          case 4:
          case 9:
          case 10:
          case 18:
          case 19:
          case 24:
            num1 = 6;
            continue;
          case 2:
            switch (num2)
            {
              case 0:
                dataOut = (object) CommandInformation.C1.sManufacturer;
                num1 = 3;
                continue;
              case 1:
                dataOut = (object) CommandInformation.C1.sProductName;
                num1 = 9;
                continue;
              case 2:
                dataOut = (object) CommandInformation.C1.sSerialNumber;
                num1 = 18;
                continue;
              case 3:
                dataOut = (object) CommandInformation.C1.sSKUNumber;
                num1 = 10;
                continue;
              case 4:
                dataOut = (object) CommandInformation.C1.sFamily;
                num1 = 1;
                continue;
              case 5:
                dataOut = (object) CommandInformation.C1.guidUUID;
                num1 = 19;
                continue;
              case 6:
                dataOut = (object) CommandInformation.C1.A;
                num1 = 24;
                continue;
              default:
                num1 = 25;
                continue;
            }
          case 5:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("辠", A_1), hpSMBIOS.a("膠", A_1)) + hpSMBIOS.a("膠햢쒤쮦\xDCA8캪趬\xF4AE醰", A_1) + dataOut.ToString() + hpSMBIOS.a("膠ﺢ", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num1 = 22;
            continue;
          case 6:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num1 = 5;
              continue;
            }
            goto label_36;
          case 7:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.D.TryGetValue(key1, out num2))
            {
              if (1 == 0)
                ;
              num1 = 21;
              continue;
            }
            goto case 11;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 23;
              continue;
            }
            goto label_36;
          case 11:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 4;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            if (global::A.D == null)
            {
              num1 = 15;
              continue;
            }
            goto case 16;
          case 13:
            num1 = 12;
            continue;
          case 14:
            if ((key1 = sCommandName) != null)
            {
              num1 = 13;
              continue;
            }
            goto case 11;
          case 15:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(7);
            string key2 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰ﺲ풴\xD9B6첸\xDDBA\xDCBC\xDCBE뗀뛂럄ꋆ믈", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key2, num3);
            string key3 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰ﺲ\xDAB4펶\xDCB8ힺ\xF3BC\xDEBE곀ꛂ", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰\xE0B2킴얶킸\xDABA톼\xF1BE듀껂\xA7C4ꋆ믈", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰\xE0B2ﺴ\xE2B6\xF7B8캺킼\xDDBE꓀뇂", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰\xF5B2풴\xDAB6킸ힺ쒼", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰\xE6B2\xE0B4ﺶﶸ", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            string key8 = hpSMBIOS.a("\xF1A0쾢쒤펦쾨쒪\xDFAC슮龰삲\xE0B4\xE2B6\xF0B8ﾺ", A_1);
            int num9 = 6;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key8, num9);
            // ISSUE: reference to a compiler-generated field
            global::A.D = dictionary;
            num1 = 16;
            continue;
          case 16:
            num1 = 7;
            continue;
          case 17:
            num1 = 8;
            continue;
          case 20:
            this.bios.GetSystemInfo(ref CommandInformation.C1);
            CommandInformation.C1.bUseCachedData = true;
            num1 = 17;
            continue;
          case 21:
            num1 = 2;
            continue;
          case 22:
            goto label_36;
          case 23:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("\xE8A0춢쎤좦\xDBA8욪첬\xDBAE\xD8B0\xDCB2\xDBB4\xE4B6삸좺즼\xDABE곀", A_1);
            string str = string.Empty;
            num1 = 14;
            continue;
          case 25:
            num1 = 11;
            continue;
          default:
            goto label_2;
        }
      }
label_36:
      return enReturnCode;
    }

    private enReturnCode InformationBaseboard(string sCommandName, out object dataOut)
    {
      int A_1 = 15;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num = 14;
      string sIdentity=string.Empty;
      string sSubIdentity=string.Empty;
      string str1 = string.Empty;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 8;
            continue;
          case 1:
          case 3:
          case 13:
            num = 16;
            continue;
          case 2:
            if (str1 == hpSMBIOS.a("\xF7A6얨쪪\xD9AC즮\xDEB0솲\xD8B4馶\xF4B8\xDABA\xDEBCힾꣀ귂ꃄ軆跈", A_1))
            {
              dataOut = (object) CommandInformation.D1.sProduct;
              num = 3;
              continue;
            }
            if (1 == 0)
              ;
            num = 4;
            continue;
          case 4:
            num = 5;
            continue;
          case 5:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 1;
            continue;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_27;
          case 7:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("\xEEA6잨춪슬\xDDAE\xDCB0튲솴\xDEB6횸햺ﾼ\xDEBE닀ꛂ蟄\xA8C6\xA8C8맊꧌", A_1);
            string str2 = string.Empty;
            num = 15;
            continue;
          case 8:
            if (str1 == hpSMBIOS.a("\xF7A6얨쪪\xD9AC즮\xDEB0솲\xD8B4馶\xF2B8了ﺼ\xE9BE꓀뇂뛄껆ꛈꗊ", A_1))
            {
              dataOut = (object) CommandInformation.D1.sVersion;
              num = 13;
              continue;
            }
            num = 10;
            continue;
          case 9:
            goto label_27;
          case 10:
            num = 2;
            continue;
          case 11:
            this.bios.GetBaseBoardInfo(ref CommandInformation.D1);
            CommandInformation.D1.bUseCachedData = true;
            num = 12;
            continue;
          case 12:
            num = 6;
            continue;
          case 14:
            if (!CommandInformation.D1.bUseCachedData)
            {
              num = 11;
              continue;
            }
            goto case 12;
          case 15:
            if ((str1 = sCommandName) != null)
            {
              num = 0;
              continue;
            }
            goto case 5;
          case 16:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num = 17;
              continue;
            }
            goto label_27;
          case 17:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("覦", A_1), hpSMBIOS.a("螦", A_1)) + hpSMBIOS.a("螦\xDFA8쪪솬\xDAAE풰鎲\xEEB4鞶", A_1) + dataOut.ToString() + hpSMBIOS.a("螦\xF4A8", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num = 9;
            continue;
          default:
            goto label_2;
        }
      }
label_27:
      return enReturnCode;
    }

    private enReturnCode InformationSystemEnclosure(string sCommandName, out object dataOut)
    {
      int A_1 = 1;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num = 4;
      string sIdentity = string.Empty;
      string sSubIdentity = string.Empty;
            string str1 = string.Empty;
            while (true)
      {
        switch (num)
        {
          case 0:
            if ((str1 = sCommandName) != null)
            {
              num = 7;
              continue;
            }
            goto case 10;
          case 1:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num = 12;
              continue;
            }
            goto label_27;
          case 2:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("킘\xF59Aﮜ\xF09E펠캢쒤펦삨쒪쎬ﲮ좰삲솴튶풸ﺺ펼\xDCBE귀곂뛄닆믈껊", A_1);
            string str2 = string.Empty;
            num = 0;
            continue;
          case 3:
          case 6:
          case 17:
            num = 1;
            continue;
          case 4:
            if (!CommandInformation.E1.bUseCachedData)
            {
              num = 16;
              continue;
            }
            goto case 9;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              if (1 == 0)
                ;
              num = 2;
              continue;
            }
            goto label_27;
          case 7:
            num = 8;
            continue;
          case 8:
            if (str1 == hpSMBIOS.a("즘\xF79Aﲜ\xEB9E잠첢\xD7A4쪦螨\xE2AA\xDEACﾮ\xDEB0솲솴횶\xDBB8ힺ\xD8BC", A_1))
            {
              dataOut = (object)  ((int) CommandInformation.E1.eEnclosureType == 10 ? 1 : 0);
              num = 6;
              continue;
            }
            num = 11;
            continue;
          case 9:
            num = 5;
            continue;
          case 10:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 3;
            continue;
          case 11:
            num = 13;
            continue;
          case 12:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("래", A_1), hpSMBIOS.a("릘", A_1)) + hpSMBIOS.a("릘\xED9Aﲜ\xF39E풠욢薤ﲦ覨", A_1) + dataOut.ToString() + hpSMBIOS.a("릘욚", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num = 14;
            continue;
          case 13:
            if (str1 == hpSMBIOS.a("즘\xF79Aﲜ\xEB9E잠첢\xD7A4쪦螨\xEAAA\xDEAC\xDCAE풰잲\xE1B4횶\xDEB8", A_1))
            {
              dataOut = (object) CommandInformation.E1.sAssetTag;
              num = 17;
              continue;
            }
            num = 15;
            continue;
          case 14:
            goto label_27;
          case 15:
            num = 10;
            continue;
          case 16:
            this.bios.GetSystemEnclosureInfo(ref CommandInformation.E1);
            CommandInformation.E1.bUseCachedData = true;
            num = 9;
            continue;
          default:
            goto label_2;
        }
      }
label_27:
      return enReturnCode;
    }

    private enReturnCode InformationProcessor(string sCommandName, out object dataOut)
    {
      int A_1 = 14;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num = 10;
      while (true)
      {
        string sIdentity = string.Empty;
        string sSubIdentity = string.Empty;
        string str1 = string.Empty;
        switch (num)
        {
          case 0:
            goto label_22;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_22;
          case 2:
            this.bios.GetProcessorInfo(ref CommandInformation.F1);
            CommandInformation.F1.bUseCachedData = true;
            num = 8;
            continue;
          case 3:
            if (1 == 0)
              ;
            dataOut = (object) CommandInformation.F1.sProcessorVersion;
            num = 12;
            continue;
          case 4:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("\xEFA5욧첩쎫\xDCAD\xDDAF펱삳\xDFB5ힷ풹\xECBB첽꾿ꇁꇃ뗅믇ꗉ뻋", A_1);
            string str2 = string.Empty;
            num = 6;
            continue;
          case 5:
          case 12:
            num = 11;
            continue;
          case 6:
            if ((str1 = sCommandName) != null)
            {
              num = 13;
              continue;
            }
            break;
          case 7:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("袥", A_1), hpSMBIOS.a("蚥", A_1)) + hpSMBIOS.a("蚥\xDEA7쮩삫\xDBAD햯銱\xEFB3隵", A_1) + dataOut.ToString() + hpSMBIOS.a("蚥\xF5A7", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num = 0;
            continue;
          case 8:
            num = 1;
            continue;
          case 9:
            if (str1 == hpSMBIOS.a("\xF6A5쒧쮩\xD8AB좭\xDFAF삱\xD9B3颵\xE8B7좹펻\xDDBDꖿ뇁럃꧅뫇蓉귋ꏍ뗏", A_1))
            {
              num = 3;
              continue;
            }
            break;
          case 10:
            if (!CommandInformation.F1.bUseCachedData)
            {
              num = 2;
              continue;
            }
            goto case 8;
          case 11:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num = 7;
              continue;
            }
            goto label_22;
          case 13:
            num = 9;
            continue;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 5;
      }
label_22:
      return enReturnCode;
    }

    private enReturnCode InformationOnBoardDev(string sCommandName, out object dataOut)
    {
      int A_1 = 2;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num = 0;
      string sIdentity = string.Empty;
      string sSubIdentity = string.Empty;
      string str1 = string.Empty;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (!CommandInformation.G1.bUseCachedData)
            {
              num = 17;
              continue;
            }
            goto case 15;
          case 1:
            if (str1 == hpSMBIOS.a("쪙\xF09Bﾝ풟쒡쮣풥얧蒩嶺\xE3AD\xF1AFﾱ톳\xDBB5ힷ좹얻\xEDBD뒿냁", A_1))
            {
              dataOut = (object) CommandInformation.G1.usUMAVideoMemory;
              num = 5;
              continue;
            }
            num = 11;
            continue;
          case 2:
          case 3:
          case 5:
            num = 9;
            continue;
          case 4:
            if ((str1 = sCommandName) != null)
            {
              num = 7;
              continue;
            }
            goto case 16;
          case 6:
            goto label_16;
          case 7:
            num = 12;
            continue;
          case 8:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 13;
              continue;
            }
            goto label_27;
          case 9:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num = 10;
              continue;
            }
            goto label_27;
          case 10:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("뒙", A_1), hpSMBIOS.a("몙", A_1)) + hpSMBIOS.a("몙\xEA9Bﾝ첟힡솣蚥\xF3A7誩", A_1) + dataOut.ToString() + hpSMBIOS.a("몙솛", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num = 6;
            continue;
          case 11:
            num = 16;
            continue;
          case 12:
            if (str1 == hpSMBIOS.a("쪙\xF09Bﾝ풟쒡쮣풥얧蒩嶺\xE3AD\xF1AFﾱ톳\xDBB5ힷ좹얻", A_1))
            {
              dataOut = (object) CommandInformation.G1.unUmaVideoMemory;
              num = 3;
              continue;
            }
            num = 14;
            continue;
          case 13:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("펙\xF29B\xF89D쾟킡즣장\xDCA7쎩쎫삭ﾯ\xDCB1\xF6B3\xD9B5\xD9B7좹\xD8BB諾ꖿ듁", A_1);
            string str2 = string.Empty;
            num = 4;
            continue;
          case 14:
            num = 1;
            continue;
          case 15:
            num = 8;
            continue;
          case 16:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 2;
            continue;
          case 17:
            this.bios.GetOnBoardDevicesInfo(ref CommandInformation.G1);
            CommandInformation.G1.bUseCachedData = true;
            num = 15;
            continue;
          default:
            goto label_2;
        }
      }
label_16:
      if (1 == 0)
        ;
label_27:
      return enReturnCode;
    }

    private enReturnCode InformationMemory(string sCommandName, out object dataOut)
    {
      int A_1 = 3;
label_2:
      enReturnCode enReturnCode = this.I;
      dataOut = (object) null;
      int num = 3;
      while (true)
      {
        string sIdentity = string.Empty;
        string sSubIdentity = string.Empty;
        string str1 = string.Empty;
        switch (num)
        {
          case 0:
            num = 9;
            continue;
          case 1:
            goto label_22;
          case 2:
            if ((str1 = sCommandName) != null)
            {
              num = 0;
              continue;
            }
            break;
          case 3:
            if (!CommandInformation.H1.bUseCachedData)
            {
              num = 8;
              continue;
            }
            goto case 5;
          case 4:
            sIdentity = this.GetType().ToString();
            sSubIdentity = hpSMBIOS.a("튚\xF39C咽캠톢좤욦\xDDA8슪슬솮ﲰ횲\xD8B4\xD8B6쮸슺", A_1);
            string str2 = string.Empty;
            num = 2;
            continue;
          case 5:
            num = 7;
            continue;
          case 6:
            num = 10;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_22;
          case 8:
            this.bios.GetPhysicalMemoryInfo(ref CommandInformation.H1);
            CommandInformation.H1.bUseCachedData = true;
            num = 5;
            continue;
          case 9:
            if (str1 == hpSMBIOS.a("쮚\xF19Cﺞ햠얢쪤햦쒨薪怜삮얰튲\xD9B4襁\xDCB8횺튼춾룀", A_1))
            {
              num = 13;
              continue;
            }
            break;
          case 10:
            if (enReturnCode != enReturnCode.e_INVALID_PARAMETER)
            {
              num = 11;
              continue;
            }
            goto label_22;
          case 11:
            string sMessage = sCommandName.Replace(hpSMBIOS.a("떚", A_1), hpSMBIOS.a("뮚", A_1)) + hpSMBIOS.a("뮚\xEB9Cﺞ춠횢삤螦\xF2A8讪", A_1) + dataOut.ToString() + hpSMBIOS.a("뮚삜", A_1);
            base.A1.InformationMessage(sIdentity, sSubIdentity, sMessage);
            num = 1;
            continue;
          case 12:
            if (1 == 0)
              goto case 6;
            else
              goto case 6;
          case 13:
            dataOut = (object) CommandInformation.H1.unTotalMemory;
            num = 6;
            continue;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 12;
      }
label_22:
      return enReturnCode;
    }

    public override void B()
    {
      int A_1 = 5;
      if (1 == 0)
        ;
      this.I = this.InitGet();
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xEDAE\xF8B0ﲲ\xE6B4\xE1B6\xDCB8즺캼횾껀귂规\xA8C6\xA7C8곊", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xEDAE\xF8B0ﲲ\xE6B4\xE5B6\xDCB8ힺ\xD8BC\xDEBE닀ꛂ臄ꛆ뷈껊", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xEDAE\xF8B0ﲲ\xE6B4\xE1B6\xDCB8햺\xD9BC킾돀", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE2AE킰\xDDB2살톶\xD8B8\xD8BA즼쪾돀ꛂ럄", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE2AE\xDEB0ힲ킴\xDBB6\xF7B8\xDABA킼\xDABE", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬ﲮ練\xE6B2﮴슶풸\xD9BA\xD8BC춾", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE9AE킰\xDEB2\xDCB4\xDBB6삸", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬ﲮ풰솲\xDCB4횶햸\xF5BA좼튾ꏀꛂ럄", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xEDAE\xF8B0ﲲ\xE6B4\xE1B6\xDCB8즺캼횾껀귂雄꿆ꛈ맊만", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE2AE킰킲\xDDB4\xDEB6ힸ\xDEBA\xF4BC﮾", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2풴쒶\xDCB8\xD9BA튼\xDEBE돀\xA7C2", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE4AE\xF3B0\xF0B2\xE3B4튶쮸좺풼킾꿀", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2풴쒶\xDCB8\xD9BA튼\xDEBE돀\xA7C2", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE6AE슰\xE7B2풴햶햸\xDEBA즼", A_1), typeof (bool), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xE6AE슰\xE3B2\xDAB4얶춸\xDABA\xDFBC펾꓀", A_1), typeof (bool), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼諭꿀ꃂ꧄\xA8C6뫈뻊뿌\xAACE", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("\xDB9C爵삠힢키햦첨薪窱욮쎰횲\xD9B4튶쪸좺覼醾鋀뛂뗄럆ꛈ맊만\xAACE뗐", A_1), typeof (bool), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xF1B2\xDCB4\xD8B6쪸", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬ﮮ\xDEB0잲풴\xDBB6\xF4B8\xDEBA킼킾돀뫂", A_1), typeof (uint), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0ﺲ킴\xDAB6횸즺쒼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬类ﲰ\xF2B2\xF8B4튶풸풺쾼욾", A_1), typeof (uint), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0ﲲ\xDBB4\xF5B6횸\xDABA쾼\xDBBE藀ꛂ도", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬ﾮ쎰\xDCB2횴튶쪸좺튼춾迀ꋂ꣄ꋆ", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE3B2잴\xD8B6\xDAB8\xDEBA캼첾껀뇂", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xEEAE슰삲킴쎶\xEDB8\xDABA\xDABC", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼諭꿀ꃂ꧄\xA8C6뫈뻊뿌\xAACE", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬类\xE4B0者\xF1B4", A_1), typeof (Guid), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
      base.E1.Add(new Command.Property(hpSMBIOS.a("출\xF39E삠힢쎤좦\xDBA8욪莬\xDCAE\xE4B0\xE6B2ﲴ\xF3B6", A_1), typeof (string), hpSMBIOS.a("풜\xF19E잠첢\xD7A4쪦좨\xDFAA쒬삮\xDFB0\xE0B2체쒶춸\xDEBA킼", A_1), false));
    }

    protected override void A()
    {
    }
  }
}
