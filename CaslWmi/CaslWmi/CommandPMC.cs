// Decompiled with JetBrains decompiler
// Type: CaslWmi.CommandPMC
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
using System.Xml;

namespace CaslWmi
{
  internal class CommandPMC : Command
  {
    private enReturnCode M1 = enReturnCode.e_NULL_VALUE;
    private enReturnCode P1 = enReturnCode.e_NULL_VALUE;
    private bool Q1 = true;
    private static CaslLogger A1;
    private static bool? B1;
    private static XmlDocument C1;
    public static uint? E1;
    private static bool? F1;
    private static bool G1;
    private static XmlEdit.XmlNodeBool[] H1;
    private static XmlEdit.XmlNodeBool[] I1;
    private static XmlEdit.XmlNodeBool[] J1;
    private static XmlEdit.XmlNodeBool[] K1;
    private CommandPMC.B L1;
    private bool N1;
    private CommandPMC.A O1;

    public static bool PMC2Supported
    {
      get
      {
label_2:
        bool A_1 = false;
        bool A_2 = false;
        int num = 2;
        enReturnCode enReturnCode=0;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 5:
              goto label_11;
            case 1:
              A_1 = CommandPMC.F1.Value;
              num = 0;
              continue;
            case 2:
              if (1 == 0)
                ;
              if (CommandPMC.F1.HasValue)
              {
                num = 1;
                continue;
              }
              XmlDocument A_0 = new XmlDocument();
              enReturnCode = CommandPMC.BB(out A_0, ref A_1, ref A_2);
              num = 3;
              continue;
            case 3:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_11;
            case 4:
              CommandPMC.F1 = new bool?(A_1);
              CommandPMC.B1 = new bool?(A_2);
              num = 5;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return A_1;
      }
    }

    public static bool BIOSPMCEventSupported
    {
      get
      {
label_2:
        bool A_1 = false;
        bool A_2 = false;
        int num = 5;
        enReturnCode enReturnCode=0;
        while (true)
        {
          switch (num)
          {
            case 0:
              A_2 = CommandPMC.B1.Value;
              num = 2;
              continue;
            case 1:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num = 4;
                continue;
              }
              goto label_11;
            case 2:
            case 3:
              goto label_11;
            case 4:
              CommandPMC.B1 = new bool?(A_2);
              CommandPMC.F1 = new bool?(A_1);
              num = 3;
              continue;
            case 5:
              if (CommandPMC.B1.HasValue)
              {
                if (1 == 0)
                  ;
                num = 0;
                continue;
              }
              XmlDocument A_0 = new XmlDocument();
              enReturnCode = CommandPMC.BB(out A_0, ref A_1, ref A_2);
              num = 1;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return A_2;
      }
    }

    public static uint PMCEventRate
    {
      get
      {
label_2:
        uint A_0 = 0U;
        int num = 1;
        enReturnCode enReturnCode=0;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 2:
            case 3:
            case 4:
              goto label_14;
            case 1:
              num = !CommandPMC.E1.HasValue ? 7 : 5;
              continue;
            case 5:
              A_0 = CommandPMC.E1.Value;
              num = 4;
              continue;
            case 6:
              A_0 = 0U;
              CommandPMC.E1 = new uint?(A_0);
              num = 0;
              continue;
            case 7:
              if (CommandPMC.G1)
              {
                num = 6;
                continue;
              }
              if (1 == 0)
                ;
              enReturnCode = CommandPMC.BC(out A_0);
              num = 8;
              continue;
            case 8:
              if (enReturnCode != enReturnCode.e_OK)
              {
                CommandPMC.E1 = new uint?(0U);
                num = 2;
                continue;
              }
              num = 9;
              continue;
            case 9:
              CommandPMC.E1 = new uint?(A_0);
              num = 3;
              continue;
            default:
              goto label_2;
          }
        }
label_14:
        return A_0;
      }
    }

    private static string PMCCalibrationDataEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("\x1F4E᱐ၒᙔ㙖㕘\x325A㽜ⵞ`ᝢ\x0C64\x0866ݨ⽪౬᭮ၰ嵲\x2D74㩶㕸", 9);
      }
    }

    private static string PMCCapabilitiesEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("ᭊL\x0C4Eቐ\x3252╔㙖㭘\x325Aㅜ㙞ᕠ\x0A62dᑦ䝨㍪\x206C⍮", 5);
      }
    }

    private static string PMCDataEmulationFile
    {
      get
      {
        return Constants.EmulationFolder + Module.a("\x1F4E᱐ၒᅔ㙖ⵘ㩚獜ݞⱠ⽢", 9);
      }
    }

    static CommandPMC()
    {
      int A_1 = 18;
      if (1 == 0)
        ;
      CommandPMC.A1 = new CaslLogger();
      CommandPMC.B1 = new bool?();
      CommandPMC.C1 = (XmlDocument) null;
      CommandPMC.E1 = new uint?();
      CommandPMC.F1 = new bool?();
      CommandPMC.G1 = false;
      CommandPMC.H1 = new XmlEdit.XmlNodeBool[17]
      {
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE0A5馧骩ﾫ쮭쒯욱\xDDB3\xD8B5\xDFB7﮹쪻\xDFBDꦿ껁ꗃ꓅\xA4C7꿉", A_1), 6, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE5A5즧용얫청슯펱삳\xDFB5ힷ풹\xEFBB쮽낿닁ꯃ듅볇", A_1), 6, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE7A5쮧즩\xD9AB쎭얯\xDEB1햳습\xDDB7\xDEB9\xF8BB\xDFBD뒿ꏁ蟃꧅\xA4C7ꛉ꧋귍\xA4CF믑믓룕诗꿙곛껝迟郡郣", A_1), 6, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xEFA5욧\xD9A9\xD8AB쾭\xDEAF욱햳\xD8B5\xDDB7햹즻춽蒿ꏁ냃\xA7C5诇ꗉꃋꋍ뗏뇑ꃓ뿕럗듙进ꯝ郟鋡诣铥鳧", A_1), 6, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓럕곗뿙\x9FDB뛝臟賡菣菥믧\x9FE9鳫黭\x9FEF胱胳", A_1), 8, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1雓럕곗껙맛곝駟ꇡ賣蟥髧跩觫뷭藯英蓳駵諷軹", A_1), 8, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓闕鳗駙裛곝臟賡韣迥鳧菩菫胭ꏯ蟱蓳蛵韷裹裻", A_1), 8, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1胓ꓕ맗곙맛닝ꇟ蛡藣雥鳧迩黫뷭藯英蓳駵諷軹", A_1), 8, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓돕맗뻙进ꯝ郟鋡诣铥鳧", A_1), 8, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙諗믙\xA8DB믝ꏟ諡藣裥迧迩뿫鯭胯英鯳蓵賷", A_1), 12, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙髗믙\xA8DB\xAADD藟郡鷣ꗥ胧诩黫觭闯ꇱ至蛵裷闹軻諽", A_1), 12, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗駙飛鷝듟郡藣裥鯧菩飫蟭\x9FEF鳱\xA7F3菵裷諹鏻賽瓿", A_1), 12, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙賗꣙뷛\xA8DD藟軡ꗣ若觧髩飫语苯ꇱ至蛵裷闹軻諽", A_1), 12, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗동껛믝蓟곡귣ꗥ뿧诩蟫语뿯鳱룳럵뛷\xA9F9觻軽烿洁瘃爅", A_1), 12, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗雙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 13, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗跙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 13, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗韙裛鏝ꗟ뇡釣雥飧藩黫髭", A_1), 13, 2, false)
      };
      CommandPMC.I1 = new XmlEdit.XmlNodeBool[46]
      {
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE0A5馧骩ﾫ쮭쒯욱\xDDB3\xD8B5\xDFB7﮹쪻\xDFBDꦿ껁ꗃ꓅\xA4C7꿉", A_1), 6, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE5A5즧용얫청슯펱삳\xDFB5ힷ풹\xEFBB쮽낿닁ꯃ듅볇", A_1), 6, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEAAD톯욱햳\xF5B5ힷ횹킻\xDBBDꎿ뛁귃꧅ꛇ駉맋뻍ꃏ뷑ꛓꋕ", A_1), 6, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEAAD톯욱햳\xF5B5ힷ횹킻\xDBBDꎿ뛁귃꧅ꛇ駉맋뻍ꃏ뷑ꛓꋕ", A_1), 6, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF6B1햳습\xD9B7惡펻튽겿\xA7C1\xA7C3닅ꇇꗉꋋ鷍ꗏꋑꓓ맕\xAAD7껙", A_1), 6, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEEA9\xEFAB\xEAAD톯욱햳\xF5B5ힷ횹킻\xDBBDꎿ뛁귃꧅ꛇ駉맋뻍ꃏ뷑ꛓꋕ", A_1), 6, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEAAD톯욱햳\xF5B5ힷ횹킻\xDBBDꎿ뛁귃꧅ꛇ駉맋뻍ꃏ뷑ꛓꋕ", A_1), 6, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF6B1햳습\xD9B7惡펻튽겿\xA7C1\xA7C3닅ꇇꗉꋋ鷍ꗏꋑꓓ맕\xAAD7껙", A_1), 6, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xE7A5쮧즩\xD9AB쎭얯\xDEB1햳습\xDDB7\xDEB9\xF8BB\xDFBD뒿ꏁ蟃꧅\xA4C7ꛉ꧋귍\xA4CF믑믓룕诗꿙곛껝迟郡郣", A_1), 7, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xEFA5욧\xD9A9\xD8AB쾭\xDEAF욱햳\xD8B5\xDDB7햹즻춽蒿ꏁ냃\xA7C5诇ꗉꃋꋍ뗏뇑ꃓ뿕럗듙进ꯝ郟鋡诣铥鳧", A_1), 7, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓럕곗뿙\x9FDB뛝臟賡菣菥믧\x9FE9鳫黭\x9FEF胱胳", A_1), 8, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1雓럕곗껙맛곝駟ꇡ賣蟥髧跩觫뷭藯英蓳駵諷軹", A_1), 8, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓闕鳗駙裛곝臟賡韣迥鳧菩菫胭ꏯ蟱蓳蛵韷裹裻", A_1), 8, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1胓ꓕ맗곙맛닝ꇟ蛡藣雥鳧迩黫뷭藯英蓳駵諷軹", A_1), 8, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓돕맗뻙进ꯝ郟鋡诣铥鳧", A_1), 8, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓럕곗뿙\x9FDB뛝臟賡菣菥믧\x9FE9鳫黭\x9FEF胱胳", A_1), 12, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1雓럕곗껙맛곝駟ꇡ賣蟥髧跩觫뷭藯英蓳駵諷軹", A_1), 12, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓闕鳗駙裛곝臟賡韣迥鳧菩菫胭ꏯ蟱蓳蛵韷裹裻", A_1), 12, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1胓ꓕ맗곙맛닝ꇟ蛡藣雥鳧迩黫뷭藯英蓳駵諷軹", A_1), 12, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓뿕\xAAD7뿙룛郝꧟ꇡ돣蟥菧迩ꏫ胭볯돱뫳ꗵ跷諹賻釽狿瘁", A_1), 12, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓髕駗铙诛뿝诟蟡ꯣ裥ꓧꯩꋫ뷭藯英蓳駵諷軹", A_1), 13, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓臕駗铙诛뿝诟蟡ꯣ裥ꓧꯩꋫ뷭藯英蓳駵諷軹", A_1), 13, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEBA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓鯕賗韙駛距闟鋡铣觥髧黩", A_1), 13, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙諗믙\xA8DB믝ꏟ諡藣裥迧迩뿫鯭胯英鯳蓵賷", A_1), 16, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙髗믙\xA8DB\xAADD藟郡鷣ꗥ胧诩黫觭闯ꇱ至蛵裷闹軻諽", A_1), 16, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗駙飛鷝듟郡藣裥鯧菩飫蟭\x9FEF鳱\xA7F3菵裷諹鏻賽瓿", A_1), 16, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙賗꣙뷛\xA8DD藟軡ꗣ若觧髩飫语苯ꇱ至蛵裷闹軻諽", A_1), 16, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗동껛믝蓟곡귣ꗥ뿧诩蟫语뿯鳱룳럵뛷\xA9F9觻軽烿洁瘃爅", A_1), 16, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗雙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 17, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗跙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 17, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEFAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗韙裛鏝ꗟ뇡釣雥飧藩黫髭", A_1), 17, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓럕곗뿙\x9FDB뛝臟賡菣菥믧\x9FE9鳫黭\x9FEF胱胳", A_1), 20, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓闕鳗駙裛곝臟賡韣迥鳧菩菫胭ꏯ蟱蓳蛵韷裹裻", A_1), 20, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5颧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓돕맗뻙进ꯝ郟鋡诣铥鳧", A_1), 20, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1蛓럕곗뿙\x9FDB뛝臟賡菣菥믧\x9FE9鳫黭\x9FEF胱胳", A_1), 24, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓闕鳗駙裛곝臟賡韣迥鳧菩菫胭ꏯ蟱蓳蛵韷裹裻", A_1), 24, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓뿕\xAAD7뿙룛郝꧟ꇡ돣蟥菧迩ꏫ胭볯돱뫳ꗵ跷諹賻釽狿瘁", A_1), 24, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓髕駗铙诛뿝诟蟡ꯣ裥ꓧꯩꋫ뷭藯英蓳駵諷軹", A_1), 25, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1菓臕駗铙诛뿝诟蟡ꯣ裥ꓧꯩꋫ뷭藯英蓳駵諷軹", A_1), 25, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鮧\xEEA9\xEFAB\xEDAD톯슱햳풵톷횹햻쪽ꦿ\xA7C1럃铅귇꧉ꏋ볍듏\xFDD1闓鯕賗韙駛距闟鋡铣觥髧黩", A_1), 25, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙諗믙\xA8DB믝ꏟ諡藣裥迧迩뿫鯭胯英鯳蓵賷", A_1), 28, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗駙飛鷝듟郡藣裥鯧菩飫蟭\x9FEF鳱\xA7F3菵裷諹鏻賽瓿", A_1), 28, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗동껛믝蓟곡귣ꗥ뿧诩蟫语뿯鳱룳럵뛷\xA9F9觻軽烿洁瘃爅", A_1), 28, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗雙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 29, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙迗跙鷛郝럟菡迣菥\xA7E7蓩ꃫ꿭뻯ꇱ至蛵裷闹軻諽", A_1), 29, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣╥१ᩩ൫౭\x196Fṱᵳɵᅷόཻ䱽콿\xF781\xF083\xF685ﶇﺉꎋ속\xE58F\xE691\xE493\xE395\xEC97떙\xD89Bﾝ풟쎡讣\xF5A5鲧囹馫\xEAAD\xF3AF\xF1B1햳욵\xD9B7\xD8B9햻튽ꦿ뛁귃ꏅ믇飉꧋귍뿏ꃑ냓崙駗韙裛鏝ꗟ뇡釣雥飧藩黫髭", A_1), 29, 2, false)
      };
      CommandPMC.J1 = new XmlEdit.XmlNodeBool[15]
      {
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓킕ꦗꪙ\xDE9B힝\xEF9F\xF1A1\xF7A3쎥\xDCA7\xDEA9얫삭\xD7AF\xE1B1삳ힵ첷\xDFB9僚킽ꆿꃁꣃꏅ곇", A_1), 9, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓햕聯\xF699\xF59Bﲝ튟쎡킣쾥잧쒩ﾫ\xDAAD톯욱솳억", A_1), 9, 1, true),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xD9B7캹\xD9BBﶽꢿꏁ\xAAC3ꇅ귇藉꿋귍ꗏꃑꛓ돕볗", A_1), 12, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF4B5\xD9B7캹좻\xDBBD늿믁蟃껅꧇룉ꯋꯍ\x9FCF뇑럓ꏕ\xAAD7꣙맛뫝", A_1), 12, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5﮷ﺹﾻ\xEABD늿ꏁ\xAAC3뗅ꇇ뻉ꗋꇍ뻏鷑럓뗕귗꣙껛믝蓟", A_1), 12, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE2B5쪷\xDBB9쪻\xDBBD겿菁ꃃ\xA7C5룇뻉꧋볍量ꛑꃓ럕믗닙맛뫝", A_1), 12, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xDDB7\xDBB9\xD8BB\xEDBD뒿ꏁ냃독믇", A_1), 12, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xE8B9\xDDBB쪽ꖿ臁곃\xA7C5ꛇ귉꧋臍돏뇑ꇓꓕ\xAAD7뿙룛", A_1), 23, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xF8B9\xDDBB쪽뒿\xA7C1뛃뿅诇ꋉ귋볍럏럑鯓뗕믗꿙껛곝藟蛡", A_1), 23, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷﮹ﾻ諾莿雁뛃\xA7C5ꛇ막ꗋ뫍맏뷑뫓駕믗맙\xA9DB곝鋟蟡胣", A_1), 23, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEEB9캻\xDFBD뚿\xA7C1ꣃ蟅곇ꯉ볋뫍뗏ꃑ闓ꋕ곗믙뿛뛝藟蛡", A_1), 23, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9햻첽ꖿꛁ諃迅诇鷉귋ꗍ뗏鷑뫓髕駗铙进\xAADD臟雡釣闥귧蓩跫賭鳯韱郳", A_1), 23, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9\xF0BBﾽ躿闁ꗃ귅귇藉ꋋ苍量鳑蟓ꋕ맗껙\xA9DB귝ꗟ賡藣蓥蓧迩裫", A_1), 24, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9\xEBBBﾽ躿闁ꗃ귅귇藉ꋋ苍量鳑蟓ꋕ맗껙\xA9DB귝ꗟ賡藣蓥蓧迩裫", A_1), 24, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷﮹\xE8BB\xF3BD趿蟁韃닅꧇뻉맋뷍", A_1), 24, 2, false)
      };
      CommandPMC.K1 = new XmlEdit.XmlNodeBool[29]
      {
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓킕ꦗꪙ\xDE9B힝\xEF9F\xF1A1\xF7A3쎥\xDCA7\xDEA9얫삭\xD7AF\xE1B1삳ힵ첷\xDFB9僚킽ꆿꃁꣃꏅ곇", A_1), 2, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓햕聯\xF699\xF59Bﲝ튟쎡킣쾥잧쒩ﾫ\xDAAD톯욱솳억", A_1), 2, 1, true),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xD9B7캹\xD9BBﶽꢿꏁ\xAAC3ꇅ귇藉꿋귍ꗏꃑꛓ돕볗", A_1), 5, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF4B5\xD9B7캹좻\xDBBD늿믁蟃껅꧇룉ꯋꯍ\x9FCF뇑럓ꏕ\xAAD7꣙맛뫝", A_1), 5, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5﮷ﺹﾻ\xEABD늿ꏁ\xAAC3뗅ꇇ뻉ꗋꇍ뻏鷑럓뗕귗꣙껛믝蓟", A_1), 5, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE2B5쪷\xDBB9쪻\xDBBD겿菁ꃃ\xA7C5룇뻉꧋볍量ꛑꃓ럕믗닙맛뫝", A_1), 5, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5袷\xE8B9\xD9BB\xDFBD꒿釁냃\xA7C5볇뿉뿋跍뿏뻑룓돕믗껙맛뫝", A_1), 5, 6, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xD9B7캹\xD9BBﶽꢿꏁ\xAAC3ꇅ귇藉꿋귍ꗏꃑꛓ돕볗", A_1), 16, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF4B5\xD9B7캹좻\xDBBD늿믁蟃껅꧇룉ꯋꯍ\x9FCF뇑럓ꏕ\xAAD7꣙맛뫝", A_1), 16, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5﮷ﺹﾻ\xEABD늿ꏁ\xAAC3뗅ꇇ뻉ꗋꇍ뻏鷑럓뗕귗꣙껛믝蓟", A_1), 16, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE2B5쪷\xDBB9쪻\xDBBD겿菁ꃃ\xA7C5룇뻉꧋볍量ꛑꃓ럕믗닙맛뫝", A_1), 16, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE1B5톷좹\xD9BB\xDABD躿证蟃釅꧇ꇉ꧋臍뻏黑闓飕诗껙뷛\xAADD闟釡ꇣ裥觧裩胫语铯", A_1), 16, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE1B5\xF4B7﮹\xF2BB\xE9BDꆿ꧁ꇃ觅ꛇ蛉跋胍菏ꛑ뗓ꋕ귗꧙駛냝臟胡裣菥賧", A_1), 17, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE1B5\xEFB7﮹\xF2BB\xE9BDꆿ꧁ꇃ觅ꛇ蛉跋胍菏ꛑ뗓ꋕ귗꧙駛냝臟胡裣菥賧", A_1), 17, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5\xF5B7\xEEB9\xF1BB﮽鎿뛁ꗃ닅뷇막觋ꃍ뇏냑룓돕볗", A_1), 17, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xE8B9\xDDBB쪽ꖿ臁곃\xA7C5ꛇ귉꧋臍돏뇑ꇓꓕ\xAAD7뿙룛", A_1), 27, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xF8B9\xDDBB쪽뒿\xA7C1뛃뿅诇ꋉ귋볍럏럑鯓뗕믗꿙껛곝藟蛡", A_1), 27, 3, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷﮹ﾻ諾莿雁뛃\xA7C5ꛇ막ꗋ뫍맏뷑뫓駕믗맙\xA9DB곝鋟蟡胣", A_1), 27, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEEB9캻\xDFBD뚿\xA7C1ꣃ蟅곇ꯉ볋뫍뗏ꃑ闓ꋕ곗믙뿛뛝藟蛡", A_1), 27, 5, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9햻첽ꖿꛁ諃迅诇鷉귋ꗍ뗏鷑뫓髕駗铙进\xAADD臟雡釣闥귧蓩跫賭鳯韱郳", A_1), 27, 7, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9\xF0BBﾽ躿闁ꗃ귅귇藉ꋋ苍量鳑蟓ꋕ맗껙\xA9DB귝ꗟ賡藣蓥蓧迩裫", A_1), 28, 0, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEDB9\xEBBBﾽ躿闁ꗃ귅귇藉ꋋ苍量鳑蟓ꋕ맗껙\xA9DB귝ꗟ賡藣蓥蓧迩裫", A_1), 28, 1, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷﮹\xF1BB\xEABD趿蟁韃닅꧇뻉맋뷍闏병뗓듕듗뿙룛", A_1), 28, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xD9B7캹\xD9BBﶽꢿꏁ\xAAC3ꇅ귇藉꿋귍ꗏꃑꛓ돕볗", A_1), 38, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5﮷ﺹﾻ\xEABD늿ꏁ\xAAC3뗅ꇇ뻉ꗋꇍ뻏鷑럓뗕귗꣙껛믝蓟", A_1), 38, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE4B5\xD9B7캹\xD9BBﶽꢿꏁ\xAAC3ꇅ귇藉꿋귍ꗏꃑꛓ돕볗", A_1), 49, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕\xAB97\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xF7B5﮷ﺹﾻ\xEABD늿ꏁ\xAAC3뗅ꇇ뻉ꗋꇍ뻏鷑럓뗕귗꣙껛믝蓟", A_1), 49, 4, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDA9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xE8B9\xDDBB쪽ꖿ臁곃\xA7C5ꛇ귉꧋臍돏뇑ꇓꓕ\xAAD7뿙룛", A_1), 60, 2, false),
        new XmlEdit.XmlNodeBool(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDA9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷﮹ﾻ諾莿雁뛃\xA7C5ꛇ막ꗋ뫍맏뷑뫓駕믗맙\xA9DB곝鋟蟡胣", A_1), 60, 4, false)
      };
    }

    private static void InitEmulation()
    {
      int A_1 = 11;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㽮㱰ひ", A_1), Module.a("ᡐ㵒㱔⍖᱘㙚⡜㍞`ᝢ\x0C64\x0866ݨ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      CommandPMC.G1 = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation).AllowEmulation;
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            XmlDocument xmlDocument1 = new XmlDocument();
            xmlDocument1.LoadXml(Resources.GetPMCData2Output);
            xmlDocument1.Save(CommandPMC.PMCDataEmulationFile);
            num = 5;
            continue;
          case 1:
            if (!File.Exists(CommandPMC.PMCCapabilitiesEmulationFile))
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 2:
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.LoadXml(Resources.GetPMCCapabilities2Output);
            xmlDocument2.Save(CommandPMC.PMCCapabilitiesEmulationFile);
            num = 3;
            continue;
          case 3:
            num = 8;
            continue;
          case 4:
            if (CommandPMC.G1)
            {
              num = 9;
              continue;
            }
            goto label_18;
          case 5:
            goto label_18;
          case 6:
            if (1 == 0)
              break;
            break;
          case 7:
            XmlDocument xmlDocument3 = new XmlDocument();
            xmlDocument3.LoadXml(Resources.GetPMCCalibrationDataOutput);
            xmlDocument3.Save(CommandPMC.PMCCalibrationDataEmulationFile);
            num = 6;
            continue;
          case 8:
            if (!File.Exists(CommandPMC.PMCDataEmulationFile))
            {
              num = 0;
              continue;
            }
            goto label_18;
          case 9:
            num = 10;
            continue;
          case 10:
            if (!File.Exists(CommandPMC.PMCCalibrationDataEmulationFile))
            {
              num = 7;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        num = 1;
      }
label_18:
      CommandPMC.A1.TraceOutMessage(Module.a("ቐ\x3252♔㭖๘㙚㑜煞≠ౢ\x0864੦\x0868ժ६㽮㱰ひ", A_1), Module.a("ᡐ㵒㱔⍖᱘㙚⡜㍞`ᝢ\x0C64\x0866ݨ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560", A_1));
    }

    private enReturnCode ConvertPMCCapabilitiesXmlToArray(XmlDocument xdocPMCCapabilities, out byte[] abyPMCCapabilities)
    {
      int A_1 = 9;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1F4E᱐ၒᙔ㙖⥘㩚㽜㙞ൠ\x0A62ᅤ\x0E66౨ᡪ\x2E6Cnὰղၴն\x0D78⍺ၼ\x137E햀\xEC82쒄\xF586ﮈ\xEA8A\xF48C", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      abyPMCCapabilities = (byte[]) null;
      int num = 7;
      while (true)
      {
        XmlEdit xmlEdit=null;
        switch (num)
        {
          case 0:
            xmlEdit.GetBools(CommandPMC.I1, ref abyPMCCapabilities);
            num = 8;
            continue;
          case 1:
            if (CommandPMC.PMC2Supported)
            {
              num = 0;
              continue;
            }
            xmlEdit.GetBools(CommandPMC.H1, ref abyPMCCapabilities);
            bool bool1 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜꾞\xE0A0\xE0A2\xE1A4욦\xDDA8쪪\xEEAC삮\xDDB0\xDFB2킴풶춸튺튼톾鋀뛂뗄럆ꛈ맊만", A_1));
            bool bool2 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜겞\xE0A0\xE0A2\xE1A4욦\xDDA8쪪\xEEAC삮\xDDB0\xDFB2킴풶춸튺튼톾鋀뛂뗄럆ꛈ맊만", A_1));
            bool bool3 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜\xAB9E\xF2A0隢\xE4A4\xE4A6\xEDA8쪪\xD9AC캮\xF2B0\xDCB2\xD9B4\xDBB6\xDCB8\xD8BA즼횾껀귂雄닆마믊ꋌ뷎ꗐ", A_1));
            bool bool4 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜꾞\xE5A0\xE0A2\xE1A4욦\xDDA8쪪\xEEAC삮\xDDB0\xDFB2킴풶춸튺튼톾鋀뛂뗄럆ꛈ맊만", A_1));
            bool bool5 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜겞\xE5A0\xE0A2\xE1A4욦\xDDA8쪪\xEEAC삮\xDDB0\xDFB2킴풶춸튺튼톾鋀뛂뗄럆ꛈ맊만", A_1));
            bool bool6 = xmlEdit.GetBool(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚캜\xAB9E\xF2A0隢\xE1A4\xE4A6\xEDA8쪪\xD9AC캮\xF2B0\xDCB2\xD9B4\xDBB6\xDCB8\xD8BA즼횾껀귂雄닆마믊ꋌ뷎ꗐ", A_1));
            Utility.SetBit(ref abyPMCCapabilities[6], 2, bool1 | bool4);
            Utility.SetBit(ref abyPMCCapabilities[6], 3, bool2 | bool3);
            Utility.SetBit(ref abyPMCCapabilities[6], 4, bool1 | bool2 | bool3);
            Utility.SetBit(ref abyPMCCapabilities[6], 5, bool4 | bool5 | bool6);
            num = 5;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto label_15;
          case 3:
            abyPMCCapabilities = new byte[128];
            xmlEdit = new XmlEdit(xdocPMCCapabilities);
            uint uint32 = xmlEdit.GetUInt32(Module.a("恎ᙐ㙒\x2154ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr䝴㡶\x0C78ེർ\x0A7E\xF580겂쪄\xF286ﶈﮊ\xF88Cﮎ뺐힒\xF494\xE396\xF898뒚킜ﺞ\xD9A0쪢좤튦쒨\xEAAA\xEEAC瑩킰\xDFB2살튶", A_1));
            abyPMCCapabilities[0] = (byte) 1;
            abyPMCCapabilities[1] = (byte) 0;
            abyPMCCapabilities[4] = (byte) (uint32 % 256U);
            abyPMCCapabilities[5] = (byte) (uint32 / 256U & 15U);
            num = 1;
            continue;
          case 4:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 6;
            continue;
          case 5:
          case 8:
            goto label_15;
          case 6:
            if (1 == 0)
              break;
            break;
          case 7:
            if (xdocPMCCapabilities == null)
            {
              num = 4;
              continue;
            }
            break;
          default:
            goto label_2;
        }
        num = 2;
      }
label_15:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1F4E᱐ၒᙔ㙖⥘㩚㽜㙞ൠ\x0A62ᅤ\x0E66౨ᡪ\x2E6Cnὰղၴն\x0D78⍺ၼ\x137E햀\xEC82쒄\xF586ﮈ\xEA8A\xF48C", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ䭪ᙬ彮\x0C70", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ConvertPMCDataXmlToArray(XmlDocument xdocPMCData, out byte[] abyPMCData)
    {
      int A_1 = 6;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1C4B͍ፏᙑ㕓≕㥗ᥙ㍛そᙟݡᙣብでݩk㩭Ὧ㍱ٳѵ\x1977\x0379", A_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      abyPMCData = (byte[]) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            abyPMCData = new byte[128];
            XmlEdit xmlEdit = new XmlEdit(xdocPMCData);
            DateTime dateTime = DateTime.Parse(xmlEdit.GetString(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ캉\xED8B揄\xF58F욑ﶓﮕﶗ", A_1)));
            uint uint32_1 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989벋\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙쾛ﾝ춟튡좣쎥盛쮩\xD8AB쮭", A_1));
            uint uint32_2 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989벋\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xEBA5춧쮩\xDFAB\xDBAD슯ힱ\xD9B3펵횷캹\xE8BB잽낿\xA7C1", A_1));
            uint uint32_3 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989벋\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xEBA5춧쮩\xDFAB\xDBAD슯ힱ\xD9B3펵횷캹\xECBB첽ꖿꇁ귃뗅ꇇꗉꋋ", A_1));
            ulong uint64_1 = xmlEdit.GetUInt64(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989벋\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xE2A5즧\xDEA9춫", A_1));
            uint uint32_4 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989벋\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙쾛ﾝ춟튡좣쎥\xDBA7\xE9A9쎫슭\xDCAFힱힳ습\xDDB7\xDEB9", A_1));
            uint uint32_5 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989\xF48B\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙쾛ﾝ춟튡좣쎥盛쮩\xD8AB쮭", A_1));
            uint uint32_6 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989\xF48B\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xEBA5춧쮩\xDFAB\xDBAD슯ힱ\xD9B3펵횷캹\xE8BB잽낿\xA7C1", A_1));
            uint uint32_7 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989\xF48B\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xEBA5춧쮩\xDFAB\xDBAD슯ힱ\xD9B3펵횷캹\xECBB첽ꖿꇁ귃뗅ꇇꗉꋋ", A_1));
            ulong uint64_2 = xmlEdit.GetUInt64(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989\xF48B\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙첛\xF19D힟잡횣\xE2A5즧\xDEA9춫", A_1));
            uint uint32_8 = xmlEdit.GetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ṙ㵛⩝ş偡\x2B63፥ᱧᩩᥫᩭ彯㵱ųɵ\x0877ཹ\x087B兽쑿\xE381\xF083\xE785ꞇ\xD989\xF48B\xDC8D\xF58F\xF191ﮓ\xE495ﲗ떙쾛ﾝ춟튡좣쎥\xDBA7\xE9A9쎫슭\xDCAFힱힳ습\xDDB7\xDEB9", A_1));
            abyPMCData[0] = (byte) 1;
            abyPMCData[1] = (byte) 0;
            abyPMCData[2] = Utility.ConvertToBCD((byte) dateTime.Hour);
            abyPMCData[3] = Utility.ConvertToBCD((byte) dateTime.Minute);
            abyPMCData[4] = Utility.ConvertToBCD((byte) dateTime.Second);
            abyPMCData[5] = Utility.ConvertToBCD((byte) dateTime.Month);
            abyPMCData[6] = Utility.ConvertToBCD((byte) dateTime.Day);
            abyPMCData[7] = Utility.ConvertToBCD((byte) (dateTime.Year % 100));
            abyPMCData[8] = Utility.ConvertToBCD((byte) (dateTime.Year / 100));
            abyPMCData[12] |= (byte) (uint32_1 & 3U);
            abyPMCData[13] |= (byte) ((int) uint32_2 << 7 & 128);
            abyPMCData[14] |= (byte) (uint32_2 >> 1 & 3U);
            abyPMCData[14] |= (byte) ((int) uint32_3 << 2 & 252);
            Array.Copy((Array) BitConverter.GetBytes(uint64_1), 0, (Array) abyPMCData, 15, 4);
            Array.Copy((Array) BitConverter.GetBytes(uint32_4), 0, (Array) abyPMCData, 19, 4);
            abyPMCData[23] |= (byte) (uint32_5 & 3U);
            abyPMCData[24] |= (byte) ((int) uint32_6 << 7 & 128);
            abyPMCData[25] |= (byte) (uint32_6 >> 1 & 3U);
            abyPMCData[25] |= (byte) ((int) uint32_7 << 2 & 252);
            Array.Copy((Array) BitConverter.GetBytes(uint64_2), 0, (Array) abyPMCData, 26, 4);
            Array.Copy((Array) BitConverter.GetBytes(uint32_8), 0, (Array) abyPMCData, 30, 4);
            xmlEdit.GetBools(CommandPMC.J1, ref abyPMCData);
            num = 1;
            continue;
          case 1:
            goto label_11;
          case 2:
            if (xdocPMCData == null)
            {
              if (1 == 0)
                ;
              num = 3;
              continue;
            }
            goto case 4;
          case 3:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 4;
            continue;
          case 4:
            num = 5;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 0;
              continue;
            }
            goto label_11;
          default:
            goto label_2;
        }
      }
label_11:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1C4B͍ፏᙑ㕓≕㥗ᥙ㍛そᙟݡᙣብでݩk㩭Ὧ㍱ٳѵ\x1977\x0379", A_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65䡧ᅩ屫\x136D", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PMCGet(string sCommandName, out object dataOut)
    {
      int A_1_1 = 0;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᙅՇॉୋ\x2B4D\x244F", A_1_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑瑓\x2155ㅗ\x2E59㑛繝", A_1_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      bool A_1_2 = false;
      bool A_2 = false;
      dataOut = (object) null;
      int num = 15;
      XmlDocument A_0_1=null;
      XmlDocument xdocPMCCalibrationData=null;
      string str=null;
      uint A_0_2=0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (str == Module.a("ᙅՇॉ手୍♏㝑㩓≕\x0A57㭙⡛㭝", A_1_1))
            {
              A_0_2 = 0U;
              enReturnCode = CommandPMC.BC(out A_0_2);
              num = 11;
              continue;
            }
            num = 6;
            continue;
          case 1:
          case 9:
          case 13:
          case 19:
            goto label_32;
          case 2:
            num = 17;
            continue;
          case 3:
            dataOut = (object) A_0_1;
            num = 9;
            continue;
          case 4:
            dataOut = (object) xdocPMCCalibrationData;
            num = 19;
            continue;
          case 5:
            num = 8;
            continue;
          case 6:
            num = 20;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            goto label_32;
          case 8:
            if (!(str == Module.a("ᙅՇॉ手്ㅏ≑㕓㑕ㅗ㙙㕛⩝य़ݡᝣ呥", A_1_1)))
            {
              if (1 == 0)
                ;
              num = 16;
              continue;
            }
            A_0_1 = new XmlDocument();
            enReturnCode = CommandPMC.BB(out A_0_1, ref A_1_2, ref A_2);
            num = 18;
            continue;
          case 10:
            if (!(str == Module.a("ᙅՇॉ手്ㅏ㹑㵓㑕⩗㭙⡛㝝ཟౡ\x2063ݥᱧ୩", A_1_1)))
            {
              num = 5;
              continue;
            }
            xdocPMCCalibrationData = new XmlDocument();
            enReturnCode = this.GetPMCCalibrationData(out xdocPMCCalibrationData);
            num = 7;
            continue;
          case 11:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 14;
              continue;
            }
            goto label_32;
          case 12:
            num = 10;
            continue;
          case 14:
            dataOut = (object) A_0_2;
            num = 1;
            continue;
          case 15:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_32;
          case 16:
            num = 0;
            continue;
          case 17:
            if ((str = sCommandName) != null)
            {
              num = 12;
              continue;
            }
            goto case 20;
          case 18:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto label_32;
          case 20:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 13;
            continue;
          default:
            goto label_2;
        }
      }
label_32:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᙅՇॉୋ\x2B4D\x244F", A_1_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ὣ噥ᕧ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    public enReturnCode GetPMCCalibrationData(out XmlDocument xdocPMCCalibrationData)
    {
      int A_1 = 18;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ὗ㽙⡛\x0E5DⵟⅡ❣ݥѧͩ\x0E6Bᱭᅯٱᵳ\x1975ᙷ㹹ᵻ\x0A7D\xE17F", A_1), Module.a("硗ख़⡛㽝\x125Fᙡţɥ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocPMCCalibrationData = (XmlDocument) null;
      byte[] abyPMCCalibrationData = (byte[]) null;
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = this.GetPMCCalibrationDataEmulation(out xdocPMCCalibrationData);
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 1:
            goto label_15;
          case 2:
          case 6:
            num = 4;
            continue;
          case 3:
            if (CommandPMC.G1)
            {
              num = 0;
              continue;
            }
            enReturnCode = this.GetPMCCalibrationDataFromBIOS(out abyPMCCalibrationData);
            num = 5;
            continue;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_15;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto case 2;
          case 7:
            enReturnCode = this.ConvertPMCCalibrationDataArrayToXml(abyPMCCalibrationData, out xdocPMCCalibrationData);
            num = 6;
            continue;
          case 8:
            enReturnCode = new XmlTools().Validate(xdocPMCCalibrationData.InnerXml, Resources.hpCASL);
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ὗ㽙⡛\x0E5DⵟⅡ❣ݥѧͩ\x0E6Bᱭᅯٱᵳ\x1975ᙷ㹹ᵻ\x0A7D\xE17F", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ乳噵", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPMCCalibrationDataEmulation(out XmlDocument xdocPMCCalibrationData)
    {
      int A_1 = 16;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգ\x0A65ŧ\x0869ṫ\x0F6Dѯ᭱᭳ᡵ㱷᭹\x087Bώ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1), Module.a("癕ୗ\x2E59㵛ⱝᑟݡc", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocPMCCalibrationData = new XmlDocument();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            goto label_9;
          case 2:
            if (xdocPMCCalibrationData != null)
            {
              num = 0;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգ\x0A65ŧ\x0869ṫ\x0F6Dѯ᭱᭳ᡵ㱷᭹\x087Bώ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1), Module.a("ὕ㙗⥙⡛㽝\x0E5Fᙡൣݥᱧͩͫm偯ᵱታ噵\x2077\x1779ၻ㩽\xEF7F\xE181\xF183\xEB85\xED87\xE489\xF88B꺍\xE28F\xF791\xE093\xE395\xEA97\xF499鍊瞧肟첡톣쪥쒧", A_1));
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      try
      {
        xdocPMCCalibrationData.Load(CommandPMC.PMCCalibrationDataEmulationFile);
      }
      catch
      {
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_9:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգ\x0A65ŧ\x0869ṫ\x0F6Dѯ᭱᭳ᡵ㱷᭹\x087Bώ앿\xEF81\xF183\xEA85\xE987ﺉ\xE58B\xE18Dﺏ", A_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ䡱味", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode GetPMCCalibrationDataFromBIOS(out byte[] abyPMCCalibrationData)
    {
      int A_1 = 19;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜ཞⱠ\x2062♤٦ըɪཬᵮၰݲᱴᡶ\x1778㽺\x1C7C\x0B7E\xE080얂\xF784\xE886\xE488즊쒌삎슐", A_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      abyPMCCalibrationData = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
          case 6:
            goto label_12;
          case 1:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.Read, enReadCmdType.GetPMCCalibrationData, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 3;
            continue;
          case 3:
            if (enReturnCode != enReturnCode.e_OK)
            {
              this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜ཞⱠ\x2062♤٦ըɪཬᵮၰݲᱴᡶ\x1778㽺\x1C7C\x0B7E\xE080얂\xF784\xE886\xE488즊쒌삎슐", A_1), Module.a("᱘⥚⽜ぞ፠䍢啤ὦቨ孪ၬ佮ᝰŲᩴ᩶奸㥺㑼ま튀ꎂ튄쪆삈\xAB8A\xEE8C\xEE8E\xFD90ﾒ떔얖ﲘ漢列낞邠\xE0A2薤킦솨슪솬쪮醰풲킴쎶춸튺펼\xD8BE\xE1C0鏂裄蓆\xE9C8裊곌ꏎ룐뇒\xA7D4뛖귘닚닜뇞쇠\xA7E2蓤鏦裨쯪蓬臮韰鳲", A_1), (object) enReturnCode);
              num = 0;
              continue;
            }
            num = 5;
            continue;
          case 4:
            if (wmiBiosClient != null)
            {
              num = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜ཞⱠ\x2062♤٦ըɪཬᵮၰݲᱴᡶ\x1778㽺\x1C7C\x0B7E\xE080얂\xF784\xE886\xE488즊쒌삎슐", A_1), Module.a("ၘ㕚\x2E5C\x2B5E`ൢᅤ\x0E66\x0868ὪѬnὰ卲ᩴᅶ奸ⱺၼᙾ쎀쪂쪄풆쪈\xE78A\xE48C\xEA8Eﾐ\xE792떔\xE596ﲘ\xEF9A\xE89C\xED9E쾠욢솤螦잨\xDEAA솬쎮", A_1));
            num = 2;
            continue;
          case 5:
            if (1 == 0)
              ;
            abyPMCCalibrationData = dataOut;
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("Ṙ㹚⥜ཞⱠ\x2062♤٦ըɪཬᵮၰݲᱴᡶ\x1778㽺\x1C7C\x0B7E\xE080얂\xF784\xE886\xE488즊쒌삎슐", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲佴坶", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ConvertPMCCalibrationDataArrayToXml(byte[] abyPMCCalibrationData, out XmlDocument xdocPMCCalibrationData)
    {
      int A_1 = 4;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ࡗ\x1759Ὓ\x1D5Dş\x0E61ൣѥᩧ୩ᡫݭὯᱱび\x1775\x0C77᭹㵻\x0C7D\xF27F\xE381ﶃ튅\xE787튉\xE18B\xE28D", A_1), Module.a("橉Ὃ㩍ㅏ⁑⁓㍕㱗", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocPMCCalibrationData = (XmlDocument) null;
      int num1 = 11;
      double num2=0;
      double num3=0;
      while (true)
      {
        switch (num1)
        {
          case 0:
          case 1:
          case 3:
            num1 = 16;
            continue;
          case 2:
            num1 = 12;
            continue;
          case 4:
            if (!double.IsInfinity(num3))
            {
              num1 = 2;
              continue;
            }
            goto case 21;
          case 5:
            xdocPMCCalibrationData = new XmlDocument();
            num2 = 0.0;
            num3 = 0.0;
            num1 = 6;
            continue;
          case 6:
            num1 = !CommandPMC.G1 ? 17 : 20;
            continue;
          case 7:
            num2 = 0.0;
            num3 = 0.0;
            num1 = 0;
            continue;
          case 8:
            num1 = 18;
            continue;
          case 9:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 14;
            continue;
          case 10:
            num1 = 4;
            continue;
          case 11:
            if (abyPMCCalibrationData == null)
            {
              num1 = 9;
              continue;
            }
            goto case 14;
          case 12:
            if (!double.IsNaN(num2))
            {
              num1 = 8;
              continue;
            }
            goto case 21;
          case 13:
          case 19:
            goto label_31;
          case 14:
            num1 = 15;
            continue;
          case 15:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 5;
              continue;
            }
            goto label_31;
          case 16:
            if (!double.IsNaN(num3))
            {
              num1 = 10;
              continue;
            }
            goto case 21;
          case 17:
            if (Utility.GetBit(abyPMCCalibrationData[2], 0))
            {
              double num4 = (double) (ushort) ((uint) abyPMCCalibrationData[4] + (uint) abyPMCCalibrationData[5] * 256U);
              double num5 = (double) (ushort) ((uint) abyPMCCalibrationData[6] + (uint) abyPMCCalibrationData[7] * 256U);
              double num6 = (double) (ushort) ((uint) abyPMCCalibrationData[8] + (uint) abyPMCCalibrationData[9] * 256U);
              double num7 = (double) (ushort) ((uint) abyPMCCalibrationData[10] + (uint) abyPMCCalibrationData[11] * 256U);
              double num8 = (double) (ushort) ((uint) abyPMCCalibrationData[12] + (uint) abyPMCCalibrationData[13] * 256U);
              double num9 = (double) (ushort) ((uint) abyPMCCalibrationData[14] + (uint) abyPMCCalibrationData[15] * 256U);
              double num10 = (double) (ushort) ((uint) abyPMCCalibrationData[16] + (uint) abyPMCCalibrationData[17] * 256U);
              double num11 = (double) (ushort) ((uint) abyPMCCalibrationData[18] + (uint) abyPMCCalibrationData[19] * 256U);
              num3 = (num7 * (num5 * num6 / num10) - num4 * (num8 * num9 / num11)) / (num4 - num7);
              num2 = (num4 - num7) / (num5 * num6 / num10 - num8 * num9 / num11);
              num1 = 3;
              continue;
            }
            num1 = 7;
            continue;
          case 18:
            if (!double.IsInfinity(num2))
            {
              xdocPMCCalibrationData.LoadXml(Resources.GetPMCCalibrationDataOutput);
              XmlEdit xmlEdit = new XmlEdit(xdocPMCCalibrationData);
              xmlEdit.SetDouble(Module.a("敉ୋ\x2B4D\x244Fɑᥓᕕ᭗㭙せ㝝ɟၡգብŧթɫ⩭ᅯٱᕳ㥵\x0D77\x0E79\x0C7B\x0B7D\xF47F궁쮃\xF385ﲇ憎曆揄뾏횑\xF593\xE295聯떙\xDB9Bﾝ즟첡", A_1), num2);
              xmlEdit.SetDouble(Module.a("敉ୋ\x2B4D\x244Fɑᥓᕕ᭗㭙せ㝝ɟၡգብŧթɫ⩭ᅯٱᕳ㥵\x0D77\x0E79\x0C7B\x0B7D\xF47F궁쮃\xF385ﲇ憎曆揄뾏횑\xF593\xE295聯떙펛\xF89D욟톡솣튥", A_1), num3);
              XmlEdit.XmlNodeBool[] xmlNodeBools = new XmlEdit.XmlNodeBool[2]
              {
                new XmlEdit.XmlNodeBool(Module.a("敉ୋ\x2B4D\x244Fɑᥓᕕ᭗㭙せ㝝ɟၡգብŧթɫ⩭ᅯٱᕳ㥵\x0D77\x0E79\x0C7B\x0B7D\xF47F궁쮃\xF385ﲇ憎曆揄뾏횑\xF593\xE295聯떙\xDA9B꾝邟\xE0A1\xEDA3\xE9A5ﮧ囹\xD8AB쾭쒯ힱ\xF1B3\xD8B5\xD9B7\xD8B9킻\xDBBD꒿", A_1), 2, 0, false),
                new XmlEdit.XmlNodeBool(Module.a("敉ୋ\x2B4D\x244Fɑᥓᕕ᭗㭙せ㝝ɟၡգብŧթɫ⩭ᅯٱᕳ㥵\x0D77\x0E79\x0C7B\x0B7D\xF47F궁쮃\xF385ﲇ憎曆揄뾏횑\xF593\xE295聯떙\xDF9Bﾝ첟쮡욣풥즧\xDEA9얫솭\xDEAF\xE1B1삳ힵ첷쾹쾻", A_1), 2, 1, true)
              };
              xmlEdit.SetBools(xmlNodeBools, abyPMCCalibrationData);
              xdocPMCCalibrationData = xmlEdit.XmlDoc;
              num1 = 19;
              continue;
            }
            num1 = 21;
            continue;
          case 20:
            num2 = BitConverter.ToDouble(abyPMCCalibrationData, 4);
            num3 = BitConverter.ToDouble(abyPMCCalibrationData, 12);
            num1 = 1;
            continue;
          case 21:
            xdocPMCCalibrationData = (XmlDocument) null;
            enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
            num1 = 13;
            continue;
          default:
            goto label_2;
        }
      }
label_31:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ॉ⍋⁍♏㝑♓≕ࡗ\x1759Ὓ\x1D5Dş\x0E61ൣѥᩧ୩ᡫݭὯᱱび\x1775\x0C77᭹㵻\x0C7D\xF27F\xE381ﶃ튅\xE787튉\xE18B\xE28D", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ履䡧", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode BB(out XmlDocument A_0, ref bool A_1, ref bool A_2)
    {
      int A_1_1 = 8;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("്ㅏ\x2151㡓ŕ㕗㍙牛\x1D5Dཟཡॣݥ٧\x0E69㱫⍭㍯", A_1_1), Module.a("्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ", A_1_1), Module.a("湍͏♑㕓\x2455ⱗ㽙㡛", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_0 = (XmlDocument) null;
      byte[] A_0_1 = (byte[]) null;
      int num = 9;
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
            goto label_17;
          case 1:
            if (1 == 0)
              ;
            enReturnCode = CommandPMC.AAAAAA(A_0_1, A_1, out A_0);
            CommandPMC.C1 = A_0;
            num = 8;
            continue;
          case 2:
          case 4:
          case 8:
            num = 0;
            continue;
          case 3:
            enReturnCode = CommandPMC.AAA(out A_0_1, ref A_1, ref A_2);
            num = 7;
            continue;
          case 5:
            if (CommandPMC.C1 != null)
            {
              A_0 = CommandPMC.C1;
              num = 2;
              continue;
            }
            num = 3;
            continue;
          case 6:
            goto label_17;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto case 2;
          case 9:
            num = !CommandPMC.G1 ? 5 : 10;
            continue;
          case 10:
            enReturnCode = CommandPMC.AA(out A_0, ref A_1, ref A_2);
            num = 4;
            continue;
          case 11:
            enReturnCode = new XmlTools().Validate(A_0.InnerXml, Resources.hpCASL);
            num = 6;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      CommandPMC.A1.TraceOutMessage(Module.a("്ㅏ\x2151㡓ŕ㕗㍙牛\x1D5Dཟཡॣݥ٧\x0E69㱫⍭㍯", A_1_1), Module.a("्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ", A_1_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝䁟ᕡൣብg偩䱫", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode AA(out XmlDocument A_0, ref bool A_1, ref bool A_2)
    {
      int A_1_1 = 16;
label_2:
      if (1 == 0)
        ;
      CommandPMC.A1.TraceInMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ\x2473㭵㭷", A_1_1), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգᙥ१\x0869իɭ\x196Fٱᵳ\x1375\x0B77㽹ᅻ\x0B7D\xEC7F\xE381\xF083\xEF85\xE787\xE489", A_1_1), Module.a("癕ୗ\x2E59㵛ⱝᑟݡc", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_0 = new XmlDocument();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_7;
          case 2:
            if (A_0 != null)
            {
              num = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ\x2473㭵㭷", A_1_1), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգᙥ१\x0869իɭ\x196Fٱᵳ\x1375\x0B77㽹ᅻ\x0B7D\xEC7F\xE381\xF083\xEF85\xE787\xE489", A_1_1), Module.a("ὕ㙗⥙⡛㽝\x0E5Fᙡൣݥᱧͩͫm偯ᵱታ噵\x2077\x1779ၻ㩽\xEF7F\xE181\xF183\xEB85\xED87\xE489\xF88B꺍\xE28F\xF791\xE093\xE395\xEA97\xF499鍊瞧肟첡톣쪥쒧", A_1_1));
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      try
      {
        A_0.Load(CommandPMC.PMCCapabilitiesEmulationFile);
        A_1 = true;
        A_2 = false;
      }
      catch
      {
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_9:
      CommandPMC.A1.TraceOutMessage(Module.a("ᕕ㥗⥙せढ़\x0D5Fୡ䩣╥ݧݩū\x0F6Dṯᙱ\x2473㭵㭷", A_1_1), Module.a("ᅕ㵗\x2E59\x0C5B፝⍟Ⅱգᙥ१\x0869իɭ\x196Fٱᵳ\x1375\x0B77㽹ᅻ\x0B7D\xEC7F\xE381\xF083\xEF85\xE787\xE489", A_1_1), Module.a("ᕕ㝗㝙ⱛ\x325D՟ᙡţɥ䡧\x1D69իᩭᡯ䡱味", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode AAA(out byte[] A_0, ref bool A_1, ref bool A_2)
    {
      int A_1_1 = 18;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1_1), Module.a("ὗ㽙⡛\x0E5DⵟⅡ❣ݥᡧ୩\x0E6Bݭᱯ᭱sήᵷॹ㩻\x0C7D\xEF7F\xEF81욃쾅잇\xD989", A_1_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1_1));
      A_0 = (byte[]) null;
      enReturnCode enReturnCode = CommandPMC.BBB(out A_0);
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 0:
            A_1 = false;
            A_2 = false;
            num = 5;
            continue;
          case 1:
          case 3:
            num = 2;
            continue;
          case 2:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 0;
              continue;
            }
            goto label_12;
          case 4:
            if (1 == 0)
              ;
            A_1 = true;
            A_2 = Utility.GetBit(A_0[7], 2);
            CommandPMC.AAAA(A_1, A_2);
            num = 3;
            continue;
          case 5:
            goto label_12;
          case 6:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 4;
              continue;
            }
            A_1 = false;
            A_2 = false;
            enReturnCode = CommandPMC.AAAAA(out A_0);
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      CommandPMC.A1.TraceOutMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1_1), Module.a("ὗ㽙⡛\x0E5DⵟⅡ❣ݥᡧ୩\x0E6Bݭᱯ᭱sήᵷॹ㩻\x0C7D\xEF7F\xEF81욃쾅잇\xD989", A_1_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ乳噵", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static void AAAA(bool A_0, bool A_1)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            CommandPMC.F1 = new bool?(A_0);
            num = 5;
            continue;
          case 2:
            if (!CommandPMC.B1.HasValue)
            {
              num = 4;
              continue;
            }
            goto label_11;
          case 4:
            CommandPMC.B1 = new bool?(A_1);
            if (1 == 0)
              ;
            num = 0;
            continue;
          case 5:
            num = 2;
            continue;
          default:
            if (!CommandPMC.F1.HasValue)
            {
              num = 1;
              continue;
            }
            goto case 5;
        }
      }
label_9:
      return;
label_11:;
    }

    private static enReturnCode BBB(out byte[] A_0)
    {
      int A_1 = 5;
label_3:
      CommandPMC.A1.TraceInMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㥨♪\x2E6C", A_1), Module.a("ొ⡌㭎ŐṒᙔᑖ㡘\x2B5A㱜㵞\x0860ར\x0C64፦h\x0E6AṬ嵮㝰Ųᩴ᩶㭸㉺㉼Ȿ", A_1), Module.a("ᡊ㥌\x2E4E⍐❒ご㍖", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      A_0 = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 4;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num)
        {
          case 0:
          case 3:
          case 5:
            goto label_12;
          case 1:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, enPMCManagementCmdType.GetPMCCapabilities2, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 2;
            continue;
          case 2:
            if (enReturnCode != enReturnCode.e_OK)
            {
              CommandPMC.A1.FormatErrorMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㥨♪\x2E6C", A_1), Module.a("ొ⡌㭎ŐṒᙔᑖ㡘\x2B5A㱜㵞\x0860ར\x0C64፦h\x0E6AṬ嵮㝰Ųᩴ᩶㭸㉺㉼Ȿ", A_1), Module.a("๊㽌㵎㹐\x2152畔杖\x2158⁚浜≞䅠բᝤ\x0866Ѩ䭪⽬♮㹰\x2072啴\x2076㑸㉺嵼᱾\xE080\xEF82\xE984Ꞇ\xD988욊캌ꂎꆐꆒﶔ랖\xEE98\xF39A\xF49C\xF39E쒠莢스슦\xDDA8\xDFAA쒬솮횰鎲\xE5B4襁視鮺ﺼ\xDEBE뇀ꋂ\xA7C4껆ꗈꋊ만ꛎ듐ꃒ\xF5D4뻖럘뷚닜", A_1), (object) enReturnCode);
              num = 5;
              continue;
            }
            num = 6;
            continue;
          case 4:
            if (wmiBiosClient != null)
            {
              num = 1;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㥨♪\x2E6C", A_1), Module.a("ొ⡌㭎ŐṒᙔᑖ㡘\x2B5A㱜㵞\x0860ར\x0C64፦h\x0E6AṬ嵮㝰Ųᩴ᩶㭸㉺㉼Ȿ", A_1), Module.a("Ɋ⍌㱎═\x3252㭔⍖じ㩚⥜㙞\x0E60ൢ䕤\x0866ཨ䭪㩬ɮᡰㅲ㱴㡶⩸㡺ᅼᙾ\xE480\xED82\xF184Ꞇﮈ\xEE8A歷搜\xE390ﶒ\xF094\xF396릘\xF59A\xE89C\xF39E춠", A_1));
            num = 0;
            continue;
          case 6:
            A_0 = dataOut;
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_12:
      CommandPMC.A1.TraceOutMessage(Module.a("ࡊⱌ㱎㵐ђ㡔㹖睘ᡚ\x325C\x325Eౠɢ\x0B64ͦ㥨♪\x2E6C", A_1), Module.a("ొ⡌㭎ŐṒᙔᑖ㡘\x2B5A㱜㵞\x0860ར\x0C64፦h\x0E6AṬ嵮㝰Ųᩴ᩶㭸㉺㉼Ȿ", A_1), Module.a("ࡊ≌≎\x2150㽒ご⍖㱘㽚絜⡞\x0860ᝢ\x0D64嵦䥨", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode AAAAA(out byte[] A_0)
    {
      int A_1 = 9;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘᡚ㱜⽞`Ţ\x0C64୦hὪѬ੮ɰ䉲㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      A_0 = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
          case 5:
            goto label_12;
          case 1:
            if (1 == 0)
              ;
            A_0 = dataOut;
            num = 0;
            continue;
          case 3:
            if (enReturnCode != enReturnCode.e_OK)
            {
              CommandPMC.A1.FormatErrorMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘᡚ㱜⽞`Ţ\x0C64୦hὪѬ੮ɰ䉲㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("\x0A4E⍐\x2152㩔╖祘歚╜\x245E兠Ṣ䕤Ŧ᭨Ѫl佮㍰㩲㩴\x2476奸ⱺぼ㙾ꆀ\xE082\xE484\xEB86\xE588\xAB8A\xDD8C슎튐벒ꖔ\xA796\xF198뮚\xEA9C\xF79E좠쾢삤螦캨캪\xD9AC\xDBAE\xD8B0\xDDB2튴鞶\xE9B8\xF6BAﺼ龾苀ꋂ뗄ꛆꯈꋊꇌꛎꗐ뫒냔ꓖ律닚돜맞軠", A_1), (object) enReturnCode);
              num = 2;
              continue;
            }
            num = 1;
            continue;
          case 4:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, enPMCManagementCmdType.GetPMCCapabilities, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 3;
            continue;
          case 6:
            if (wmiBiosClient != null)
            {
              num = 4;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘᡚ㱜⽞`Ţ\x0C64୦hὪѬ੮ɰ䉲㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("َ㽐⁒\x2154㙖㝘⽚㑜㹞ᕠ\x0A62\x0A64०䥨Ѫ୬佮♰Ṳᱴ㕶へ㑺\x2E7C㱾\xED80\xEA82\xE084\xE986ﶈ\xAB8Aﾌ\xEA8E\xE590\xE692\xE794練ﲘﾚ붜\xF19E풠쾢즤", A_1));
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_12:
      CommandPMC.A1.TraceOutMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘᡚ㱜⽞`Ţ\x0C64୦hὪѬ੮ɰ䉲㍴նᙸᙺ㽼㙾캀킂", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ兪䵬", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode AAAAAA(byte[] A_0, bool A_1, out XmlDocument A_2)
    {
      int A_1_1 = 6;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ཋ⽍⍏㹑͓㭕ㅗ瑙Ὓㅝ\x0D5Fཡգ\x0865౧㩩Ⅻ\x2D6D", A_1_1), Module.a("ཋ⅍㹏\x2451ㅓ\x2455ⱗਖ਼ᅛ\x1D5D⍟͡ᑣݥ੧ͩkݭѯ᭱ᅳյ㥷\x0879\x0E7Bώ勵횁\xEB83\xDE85\xE587\xE689", A_1_1), Module.a("Ὃ㩍ㅏ⁑⁓㍕㱗", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_2 = (XmlDocument) null;
      int num = 1;
      XmlEdit xmlEdit=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 9;
            continue;
          case 1:
            if (A_0 == null)
            {
              num = 0;
              continue;
            }
            goto case 9;
          case 2:
            if (1 == 0)
              goto case 7;
            else
              goto case 7;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 6;
              continue;
            }
            goto label_16;
          case 4:
            xmlEdit.SetBools(CommandPMC.I1, A_0);
            num = 7;
            continue;
          case 5:
            if (!A_1)
            {
              xmlEdit.SetBools(CommandPMC.H1, A_0);
              bool bit1 = Utility.GetBit(A_0[6], 2);
              bool bit2 = Utility.GetBit(A_0[6], 3);
              bool bit3 = Utility.GetBit(A_0[6], 4);
              bool bit4 = Utility.GetBit(A_0[6], 5);
              xmlEdit.SetBool(Module.a("捋्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ䁱㭳͵\x0C77\x0A79ॻ\x0A7D꽿춁\xF183\xF285\xF887ﾉ\xF88Bꆍ풏\xF391\xE093\xF795랗즙겛\xDF9D\xE39F\xE6A1얣튥즧\xE9A9쎫슭\xDCAFힱힳ습톷햹튻\xEDBD떿닁듃꧅뫇뻉", A_1_1), bit1 & bit3);
              xmlEdit.SetBool(Module.a("捋्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ䁱㭳͵\x0C77\x0A79ॻ\x0A7D꽿춁\xF183\xF285\xF887ﾉ\xF88Bꆍ풏\xF391\xE093\xF795랗즙ꢛ춝閟\xE3A1\xE7A3\xE2A5즧\xDEA9춫\xEDAD\xDFAF\xDEB1\xD8B3펵\xDBB7캹햻톽꺿釁뇃뛅룇ꗉ뻋뫍", A_1_1), bit2 & bit3);
              xmlEdit.SetBool(Module.a("捋्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ䁱㭳͵\x0C77\x0A79ॻ\x0A7D꽿춁\xF183\xF285\xF887ﾉ\xF88Bꆍ풏\xF391\xE093\xF795랗즙겛\xDA9D\xE39F\xE6A1얣튥즧\xE9A9쎫슭\xDCAFힱힳ습톷햹튻\xEDBD떿닁듃꧅뫇뻉", A_1_1), false);
              xmlEdit.SetBool(Module.a("捋्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ䁱㭳͵\x0C77\x0A79ॻ\x0A7D꽿춁\xF183\xF285\xF887ﾉ\xF88Bꆍ풏\xF391\xE093\xF795랗즙ꢛ춝閟\xE6A1\xE7A3\xE2A5즧\xDEA9춫\xEDAD\xDFAF\xDEB1\xD8B3펵\xDBB7캹햻톽꺿釁뇃뛅룇ꗉ뻋뫍", A_1_1), bit2 & bit4);
              num = 2;
              continue;
            }
            num = 4;
            continue;
          case 6:
            A_2 = new XmlDocument();
            uint nValue = (uint) A_0[4] + (uint) (((int) A_0[5] & 15) * 256);
            A_2.LoadXml(Resources.GetPMCCapabilities2Output);
            xmlEdit = new XmlEdit(A_2);
            xmlEdit.SetUInt32(Module.a("捋्㕏♑ѓ᭕᭗ᥙ㵛\x2E5Dşaൣ\x0A65ŧṩի୭ͯ䁱㭳͵\x0C77\x0A79ॻ\x0A7D꽿춁\xF183\xF285\xF887ﾉ\xF88Bꆍ풏\xF391\xE093\xF795랗힙ﶛ\xE69D즟쾡톣쮥\xE9A7\xE9A9磌쾭\xDCAF잱톳", A_1_1), nValue);
            num = 5;
            continue;
          case 7:
            A_2 = xmlEdit.XmlDoc;
            num = 8;
            continue;
          case 8:
            goto label_16;
          case 9:
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_16:
      CommandPMC.A1.TraceOutMessage(Module.a("ཋ⽍⍏㹑͓㭕ㅗ瑙Ὓㅝ\x0D5Fཡգ\x0865౧㩩Ⅻ\x2D6D", A_1_1), Module.a("ཋ⅍㹏\x2451ㅓ\x2455ⱗਖ਼ᅛ\x1D5D⍟͡ᑣݥ੧ͩkݭѯ᭱ᅳյ㥷\x0879\x0E7Bώ勵횁\xEB83\xDE85\xE587\xE689", A_1_1), Module.a("ཋ⅍㵏≑㡓㍕ⱗ㽙㡛繝\x175Fୡၣ\x0E65剧䩩", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode GetPMCData(out XmlDocument xdocPMCData)
    {
      int A_1 = 19;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ᩘ㩚\x2E5C㍞㙠\x0E62\x0C64䥦⩨Ѫlɮၰᵲᅴ\x2776㑸㡺", A_1), Module.a("Ṙ㹚⥜ཞⱠ\x2062Ⅴ٦\x1D68੪", A_1), Module.a("祘࡚⥜㹞፠ᝢdͦ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocPMCData = (XmlDocument) null;
      byte[] abyPMCData = (byte[]) null;
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 4:
            num = 2;
            continue;
          case 1:
            enReturnCode = CommandPMC.ConvertPMCDataArrayToXml(abyPMCData, out xdocPMCData);
            num = 4;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_14;
          case 3:
            goto label_14;
          case 5:
            enReturnCode = CommandPMC.GetPMCDataEmulation(out xdocPMCData);
            num = 0;
            continue;
          case 6:
            if (CommandPMC.G1)
            {
              num = 5;
              continue;
            }
            enReturnCode = CommandPMC.GetPMCDataFromBIOS(out abyPMCData);
            num = 7;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto case 0;
          case 8:
            enReturnCode = new XmlTools().Validate(xdocPMCData.InnerXml, Resources.hpCASL);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      if (1 == 0)
        ;
      CommandPMC.A1.TraceOutMessage(Module.a("ᩘ㩚\x2E5C㍞㙠\x0E62\x0C64䥦⩨Ѫlɮၰᵲᅴ\x2776㑸㡺", A_1), Module.a("Ṙ㹚⥜ཞⱠ\x2062Ⅴ٦\x1D68੪", A_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲佴坶", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode C(byte[] A_0, out XmlDocument A_1)
    {
      int A_1_1 = 19;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ᩘ㩚\x2E5C㍞㙠\x0E62\x0C64䥦⩨Ѫlɮၰᵲᅴ\x2776㑸㡺", A_1_1), Module.a("Ṙ㹚⥜ཞⱠ\x2062Ⅴ٦\x1D68੪\x2B6CᵮṰṲ㝴\x0E76\x0D78Ṻ\x0E7C", A_1_1), Module.a("祘࡚⥜㹞፠ᝢdͦ", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_1 = (XmlDocument) null;
      if (1 == 0)
        ;
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = CommandPMC.GetPMCDataEmulation(out A_1);
            num = 5;
            continue;
          case 1:
            num = !CommandPMC.G1 ? 10 : 0;
            continue;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 4;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_17;
          case 4:
            num = 1;
            continue;
          case 5:
          case 9:
            num = 3;
            continue;
          case 6:
            goto label_17;
          case 7:
            if (A_0 == null)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 8:
            enReturnCode = new XmlTools().Validate(A_1.InnerXml, Resources.hpCASL);
            num = 6;
            continue;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 11;
              continue;
            }
            goto case 5;
          case 11:
            enReturnCode = CommandPMC.ConvertPMCDataArrayToXml(A_0, out A_1);
            num = 9;
            continue;
          default:
            goto label_2;
        }
      }
label_17:
      CommandPMC.A1.TraceOutMessage(Module.a("ᩘ㩚\x2E5C㍞㙠\x0E62\x0C64䥦⩨Ѫlɮၰᵲᅴ\x2776㑸㡺", A_1_1), Module.a("Ṙ㹚⥜ཞⱠ\x2062Ⅴ٦\x1D68੪\x2B6CᵮṰṲ㝴\x0E76\x0D78Ṻ\x0E7C", A_1_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲佴坶", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode GetPMCDataEmulation(out XmlDocument xdocPMCData)
    {
      int A_1 = 18;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1), Module.a("ὗ㽙⡛\x0E5DⵟⅡ\x2063ݥᱧ୩⥫ͭկṱᕳɵᅷᕹቻ", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      xdocPMCData = new XmlDocument();
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (xdocPMCData != null)
            {
              num = 2;
              continue;
            }
            if (1 == 0)
              ;
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1), Module.a("ὗ㽙⡛\x0E5DⵟⅡ\x2063ݥᱧ୩⥫ͭկṱᕳɵᅷᕹቻ", A_1), Module.a("ᅗ㑙⽛⩝şౡၣཥ१ṩիŭṯ剱᭳ၵ塷≹ᅻች쑿\xED81\xE783\xF385\xE587\xEF89\xE28B揄낏\xE091\xF193\xE295\xED97\xE899\xF29Bﮝ쒟芡쪣펥쒧용", A_1));
            num = 1;
            continue;
          case 1:
            goto label_9;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:
      try
      {
        xdocPMCData.Load(CommandPMC.PMCDataEmulationFile);
      }
      catch
      {
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_9:
      CommandPMC.A1.FormatTraceOutMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1), Module.a("ὗ㽙⡛\x0E5DⵟⅡ\x2063ݥᱧ୩⥫ͭկṱᕳɵᅷᕹቻ", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ味\x0D75䡷ݹ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode GetPMCDataFromBIOS(out byte[] abyPMCData)
    {
      int A_1 = 9;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘ\x1F5A㱜\x2B5E`╢ᝤ\x0866Ѩ⥪\x246C\x206E≰", A_1), Module.a("ᱎ═\x3252❔⍖㱘㽚", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      abyPMCData = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, CommandPMC.PMC2Supported ? enPMCManagementCmdType.GetPMCData2 : enPMCManagementCmdType.GetPMCData, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_128);
            num = 3;
            continue;
          case 1:
          case 4:
          case 7:
            goto label_13;
          case 2:
            if (1 == 0)
              ;
            abyPMCData = dataOut;
            num = 7;
            continue;
          case 3:
            if (enReturnCode != enReturnCode.e_OK)
            {
              CommandPMC.A1.FormatErrorMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘ\x1F5A㱜\x2B5E`╢ᝤ\x0866Ѩ⥪\x246C\x206E≰", A_1), Module.a("\x0A4E⍐\x2152㩔╖祘歚╜\x245E兠Ṣ䕤Ŧ᭨Ѫl佮㍰㩲㩴\x2476奸ⱺぼ㙾ꆀ\xE082\xE484\xEB86\xE588\xAB8A戴\xE78E\xF890ﾒ\xF094랖ﺘﺚ\xE99C\xEB9E좠춢스螦令\xE6AA\xEEAC辮\xF5B0튲솴횶", A_1), (object) enReturnCode);
              num = 4;
              continue;
            }
            num = 2;
            continue;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 6;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘ\x1F5A㱜\x2B5E`╢ᝤ\x0866Ѩ⥪\x246C\x206E≰", A_1), Module.a("َ㽐⁒\x2154㙖㝘⽚㑜㹞ᕠ\x0A62\x0A64०䥨Ѫ୬佮♰Ṳᱴ㕶へ㑺\x2E7C㱾\xED80\xEA82\xE084\xE986ﶈ\xAB8Aﾌ\xEA8E\xE590\xE692\xE794練ﲘﾚ붜\xF19E풠쾢즤", A_1));
            num = 1;
            continue;
          case 6:
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_13:
      CommandPMC.A1.TraceOutMessage(Module.a("\x0C4Eぐ⁒㥔V㑘\x325A獜ᱞ\x0E60\x0E62\x0864٦ݨཪ㵬≮㉰", A_1), Module.a("ࡎ㑐❒Քᩖᩘ\x1F5A㱜\x2B5E`╢ᝤ\x0866Ѩ⥪\x246C\x206E≰", A_1), Module.a("\x0C4E㹐㹒╔㭖㱘⽚㡜㭞䅠ᑢ\x0C64፦Ũ兪䵬", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode ConvertPMCDataArrayToXml(byte[] abyPMCData, out XmlDocument xdocPMCData)
            
    {
            xdocPMCData = null;
      int A_1 = 15;
label_3:
      CommandPMC.A1.TraceInMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ⍲㡴㑶", A_1), Module.a("ᙔ㡖㝘ⵚ㡜ⵞᕠ㍢⡤\x2466\x2D68੪ᥬ\x0E6EばŲݴᙶx⽺ቼ\x277E\xEC80\xEF82", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num)
        {
          case 0:
          case 2:
            goto label_8;
          case 1:
            if (CommandPMC.PMC2Supported)
            {
              num = 3;
              continue;
            }
            enReturnCode = CommandPMC.BBA(abyPMCData, out xdocPMCData);
            num = 0;
            continue;
          case 3:
            enReturnCode = CommandPMC.BBBB(abyPMCData, out xdocPMCData);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_8:
      CommandPMC.A1.TraceOutMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ⍲㡴㑶", A_1), Module.a("ᙔ㡖㝘ⵚ㡜ⵞᕠ㍢⡤\x2466\x2D68੪ᥬ\x0E6EばŲݴᙶx⽺ቼ\x277E\xEC80\xEF82", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode BBBB(byte[] A_0, out XmlDocument A_1)
    {
      int A_1_1 = 14;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ᝓ㝕⭗㙙\x0B5B㍝य़䱡❣॥էݩ൫mᑯ≱㥳㕵", A_1_1), Module.a("ᝓ㥕㙗ⱙ㥛ⱝᑟ㉡⥣╥Ⱨ୩ᡫ\x0F6D䉯㍱ٳѵ\x1977\x0379⡻ᅽ\xD87F\xEF81\xE883", A_1_1), Module.a("ݓ≕㥗⡙⡛㭝џ", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_1 = (XmlDocument) null;
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 5;
              continue;
            }
            goto label_11;
          case 1:
            if (A_0 == null)
            {
              num1 = 2;
              continue;
            }
            goto case 4;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 4;
            continue;
          case 3:
            goto label_11;
          case 4:
            num1 = 0;
            continue;
          case 5:
            if (1 == 0)
              ;
            A_1 = new XmlDocument();
            uint num2 = (uint) A_0[5] & 3U;
            uint num3 = (uint) (((int) A_0[7] & 3) << 1 | ((int) A_0[6] & 128) >> 7);
            uint num4 = (uint) (((int) A_0[7] & 252) >> 2);
            uint num5 = BitConverter.ToUInt32(A_0, 8);
            uint num6 = BitConverter.ToUInt32(A_0, 12);
            uint num7 = (uint) A_0[16] & 3U;
            uint num8 = (uint) (((int) A_0[18] & 3) << 1 | ((int) A_0[17] & 128) >> 7);
            uint num9 = (uint) (((int) A_0[18] & 252) >> 2);
            uint num10 = BitConverter.ToUInt32(A_0, 19);
            uint num11 = BitConverter.ToUInt32(A_0, 23);
            uint num12 = (uint) A_0[27] & 3U;
            uint num13 = (uint) (((int) A_0[29] & 3) << 1 | ((int) A_0[28] & 128) >> 7);
            uint num14 = (uint) (((int) A_0[29] & 252) >> 2);
            uint num15 = BitConverter.ToUInt32(A_0, 30);
            uint num16 = BitConverter.ToUInt32(A_0, 34);
            uint num17 = (uint) A_0[38] & 3U;
            uint num18 = (uint) (((int) A_0[40] & 3) << 1 | ((int) A_0[39] & 128) >> 7);
            uint num19 = (uint) (((int) A_0[40] & 252) >> 2);
            uint num20 = BitConverter.ToUInt32(A_0, 41);
            uint num21 = BitConverter.ToUInt32(A_0, 45);
            uint num22 = (uint) A_0[49] & 3U;
            uint num23 = (uint) (((int) A_0[51] & 3) << 1 | ((int) A_0[50] & 128) >> 7);
            uint num24 = (uint) (((int) A_0[51] & 252) >> 2);
            uint num25 = BitConverter.ToUInt32(A_0, 52);
            uint num26 = BitConverter.ToUInt32(A_0, 56);
            uint num27 = (uint) A_0[60] & 3U;
            uint num28 = (uint) (((int) A_0[62] & 3) << 1 | ((int) A_0[61] & 128) >> 7);
            uint num29 = (uint) (((int) A_0[62] & 252) >> 2);
            uint num30 = BitConverter.ToUInt32(A_0, 63);
            uint num31 = BitConverter.ToUInt32(A_0, 67);
            A_1.LoadXml(Resources.GetPMCData2Output);
            XmlEdit xmlEdit = new XmlEdit(A_1);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏횑\xF593\xE295ﶗ캙\xF59B\xF39D얟", A_1_1), (object) DateTime.Now.ToString(Module.a("❓", A_1_1)));
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB\xECBDꆿ뛁ꇃ", A_1_1), (object) num2);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF蛑귓ꛕ뷗", A_1_1), (object) num3);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF苑ꛓ돕믗동꿛럝迟賡", A_1_1), (object) num4);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF8BB\xDFBD뒿ꏁ", A_1_1), (object) num5);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB춽莿귁ꣃ\xAAC5귇꧉룋ꯍ듏", A_1_1), (object) num6);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB\xECBDꆿ뛁ꇃ", A_1_1), (object) num7);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF蛑귓ꛕ뷗", A_1_1), (object) num8);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF苑ꛓ돕믗동꿛럝迟賡", A_1_1), (object) num9);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF8BB\xDFBD뒿ꏁ", A_1_1), (object) num10);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ힕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB춽莿귁ꣃ\xAAC5귇꧉룋ꯍ듏", A_1_1), (object) num11);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ郁ꗃ닅귇", A_1_1), (object) num12);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ苕ꇗ\xAAD9맛", A_1_1), (object) num13);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ蛕\xAAD7뿙뿛럝鏟诡诣裥", A_1_1), (object) num14);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽蒿ꏁ냃\xA7C5", A_1_1), (object) num15);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ뇁蟃꧅\xA4C7ꛉ꧋귍\xA4CF럑냓", A_1_1), (object) num16);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB\xECBDꆿ뛁ꇃ", A_1_1), (object) num17);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF蛑귓ꛕ뷗", A_1_1), (object) num18);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF苑ꛓ돕믗동꿛럝迟賡", A_1_1), (object) num19);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF8BB\xDFBD뒿ꏁ", A_1_1), (object) num20);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑꒓튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB춽莿귁ꣃ\xAAC5귇꧉룋ꯍ듏", A_1_1), (object) num21);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB\xECBDꆿ뛁ꇃ", A_1_1), (object) num22);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF蛑귓ꛕ뷗", A_1_1), (object) num23);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF1BB\xDBBDꆿ뇁뇃듅귇\xA7C9꧋ꃍ\xA4CF苑ꛓ돕믗동꿛럝迟賡", A_1_1), (object) num24);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE2B1\xDBB3솵\xDDB7좹\xF8BB\xDFBD뒿ꏁ", A_1_1), (object) num25);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꞓ튕\xDB97쪙\xF39B\xE99D얟킡\xF6A3쎥쮧얩\xDEAB쪭龯\xE1B1햳\xDBB5좷횹\xD9BB춽莿귁ꣃ\xAAC5귇꧉룋ꯍ듏", A_1_1), (object) num26);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ郁ꗃ닅귇", A_1_1), (object) num27);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ苕ꇗ\xAAD9맛", A_1_1), (object) num28);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ蛕\xAAD7뿙뿛럝鏟诡诣裥", A_1_1), (object) num29);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽蒿ꏁ냃\xA7C5", A_1_1), (object) num30);
            xmlEdit.Set(Module.a("筓ᅕ㵗\x2E59\x0C5B፝⍟♡գብ१塩⍫᭭ѯɱųɵ坷㕹ॻ\x0A7D\xF07F\xF781\xF083ꦅ첇\xEB89\xF88B\xEF8D뾏솑ꂓ얕궗\xDE99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ뇁蟃꧅\xA4C7ꛉ꧋귍\xA4CF럑냓", A_1_1), (object) num31);
            xmlEdit.SetBools(CommandPMC.K1, A_0);
            A_1 = xmlEdit.XmlDoc;
            num1 = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      CommandPMC.A1.TraceOutMessage(Module.a("ᝓ㝕⭗㙙\x0B5B㍝य़䱡❣॥էݩ൫mᑯ≱㥳㕵", A_1_1), Module.a("ᝓ㥕㙗ⱙ㥛ⱝᑟ㉡⥣╥Ⱨ୩ᡫ\x0F6D䉯㍱ٳѵ\x1977\x0379⡻ᅽ\xD87F\xEF81\xE883", A_1_1), Module.a("ᝓ㥕㕗⩙せ㭝ᑟݡc䙥ὧͩᡫ٭䩯剱", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode BBA(byte[] A_0, out XmlDocument A_1)
    {
      int A_1_1 = 18;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1_1), Module.a("᭗㕙\x325B⡝՟ၡၣ㙥╧⥩⡫\x0F6Dѯ\x1371䕳㝵\x0A77\x0879ᵻݽ푿\xED81\xDC83\xEB85\xE487", A_1_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_1 = (XmlDocument) null;
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            num1 = 1;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 3;
              continue;
            }
            goto label_10;
          case 2:
            goto label_10;
          case 3:
            A_1 = new XmlDocument();
            uint num2 = (uint) Utility.ConvertFromBCD(A_0[2]);
            uint num3 = (uint) Utility.ConvertFromBCD(A_0[3]);
            uint num4 = (uint) Utility.ConvertFromBCD(A_0[4]);
            uint num5 = (uint) Utility.ConvertFromBCD(A_0[5]);
            uint num6 = (uint) Utility.ConvertFromBCD(A_0[6]);
            uint num7 = (uint) Utility.ConvertFromBCD(A_0[7]) + (uint) Utility.ConvertFromBCD(A_0[8]) * 100U;
            uint num8 = (uint) A_0[12] & 3U;
            uint num9 = (uint) (((int) A_0[13] & 128) >> 7 | ((int) A_0[14] & 3) << 1);
            uint num10 = (uint) (((int) A_0[14] & 252) >> 2);
            uint num11 = BitConverter.ToUInt32(A_0, 15);
            uint num12 = BitConverter.ToUInt32(A_0, 19);
            uint num13 = (uint) A_0[23] & 3U;
            uint num14 = (uint) (((int) A_0[24] & 128) >> 7 | ((int) A_0[25] & 3) << 1);
            uint num15 = (uint) (((int) A_0[25] & 252) >> 2);
            uint num16 = BitConverter.ToUInt32(A_0, 26);
            uint num17 = BitConverter.ToUInt32(A_0, 30);
            A_1.LoadXml(Resources.GetPMCData2Output);
            XmlEdit xmlEdit = new XmlEdit(A_1);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓튕聯\xEE99鍊쪝즟쾡솣", A_1_1), (object) (num7.ToString(Module.a("᱗湙", A_1_1)) + Module.a("畗", A_1_1) + num5.ToString(Module.a("᱗桙", A_1_1)) + Module.a("畗", A_1_1) + num6.ToString(Module.a("᱗桙", A_1_1)) + Module.a("\x0C57", A_1_1) + num2.ToString(Module.a("᱗桙", A_1_1)) + Module.a("扗", A_1_1) + num3.ToString(Module.a("᱗桙", A_1_1)) + Module.a("扗", A_1_1) + num4.ToString(Module.a("᱗桙", A_1_1))));
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ郁ꗃ닅귇", A_1_1), (object) num8);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ苕ꇗ\xAAD9맛", A_1_1), (object) num9);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽趿\xA7C1ꗃ뗅뷇룉꧋ꏍ뗏병ꃓ蛕\xAAD7뿙뿛럝鏟诡诣裥", A_1_1), (object) num10);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE6B5ힷ춹\xD9BB첽蒿ꏁ냃\xA7C5", A_1_1), (object) num11);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕ꢗ\xDB99\xDF9B캝쾟햡솣풥盛쾩쾫솭슯횱鮳\xE5B5\xD9B7ힹ첻튽ꖿ뇁蟃꧅\xA4C7ꛉ꧋귍\xA4CF럑냓", A_1_1), (object) num12);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xE9B9\xDDBB펽낿껁ꇃ铅꧇뻉꧋", A_1_1), (object) num13);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEAB9펻즽ꖿ냁觃ꏅ꧇막맋볍뗏뿑뇓룕곗軙ꗛ껝藟", A_1_1), (object) num14);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEAB9펻즽ꖿ냁觃ꏅ꧇막맋볍뗏뿑뇓룕곗諙껛믝菟诡韣迥蟧蓩", A_1_1), (object) num15);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xEAB9펻즽ꖿ냁胃\xA7C5볇ꯉ", A_1_1), (object) num16);
            xmlEdit.Set(Module.a("睗\x1D59㥛⩝た⽡❣≥१ṩ൫屭㽯ݱsٵ\x0D77\x0E79卻ㅽ\xF57F\xF681\xF483\xF385ﲇꖉ좋\xEF8D\xE48F\xF391뮓얕겗즙ꦛ\xDF9D\xE39F\xF2A1쮣톥춧\xD8A9ﺫ쮭펯\xDDB1욳튵鞷\xE9B9\xDDBB펽낿껁ꇃ뗅诇ꗉꃋꋍ뗏뇑ꃓ돕볗", A_1_1), (object) num17);
            xmlEdit.SetBools(CommandPMC.J1, A_0);
            A_1 = xmlEdit.XmlDoc;
            num1 = 2;
            continue;
          case 4:
            if (A_0 == null)
            {
              num1 = 5;
              continue;
            }
            goto case 0;
          case 5:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_10:
      if (1 == 0)
        ;
      CommandPMC.A1.TraceOutMessage(Module.a("᭗㭙⽛\x325D㝟ཡൣ䡥\x2B67թūͭᅯᱱၳ♵㕷㥹", A_1_1), Module.a("᭗㕙\x325B⡝՟ၡၣ㙥╧⥩⡫\x0F6Dѯ\x1371䕳㝵\x0A77\x0879ᵻݽ푿\xED81\xDC83\xEB85\xE487", A_1_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ乳噵", A_1_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public static enReturnCode BC(out uint A_0)
    {
      int A_1 = 15;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ⍲㡴㑶", A_1), Module.a("ቔ\x3256ⵘ\x0B5Aၜᱞ\x2460ᕢd०\x1D68㥪౬᭮ᑰ", A_1), Module.a("畔іⵘ㩚⽜\x2B5EѠݢ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      A_0 = 0U;
      int num1 = 0;
      CaslEventContainerClass eventContainerClass=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (CommandPMC.G1)
            {
              num1 = 3;
              continue;
            }
          //  eventContainerClass = new CaslEventContainerClass();???
            num1 = 2;
            continue;
          case 1:
          case 4:
            goto label_29;
          case 2:
            if (eventContainerClass == null)
            {
              CommandPMC.A1.ErrorMessage(typeof (CommandPMC).ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ\x2460ᕢd०\x1D68㥪౬᭮ᑰ", A_1), Module.a("ፔ㙖じ㝚㡜㭞䅠ᝢ\x0A64䝦hժṬ᭮ၰᵲŴṶ\x1878ེ\x187C彾\xE080ꎂ욄\xE686愈\xE78A좌年\xF490ﶒ\xE194풖\xF698\xF59A\xE99Cﺞ좠춢삤햦\xEAA8잪첬\xDCAE슰鎲\xDAB4햶편\xDEBA\xDEBC쮾\xE1C0듂귄ꋆ\xA7C8\xEBCA만뷎꣐뫒믔냖律꿚닜\xFFDE蛠蛢釤쟦맨ꛪ껬쿮듰藲郴駶跸\xDBFA꿼黾甀昂┄愆笈搊怌⼎成瘒朔愖瀘砚砜ㄞ", A_1));
              enReturnCode = enReturnCode.e_OUT_OF_MEMORY;
              num1 = 1;
              continue;
            }
            if (1 == 0)
              ;
            num1 = 5;
            continue;
          case 3:
            A_0 = CommandPMC.PMCEventRate;
            num1 = 4;
            continue;
          case 5:
            goto label_5;
          default:
            goto label_2;
        }
      }
label_5:
      try
      {
label_7:
        object pData;
        eventContainerClass.GetData(Module.a("Քᩖᩘ畚ᥜ㹞ᕠɢ", A_1), Module.a("ၔ\x2156㱘㕚⥜\x0D5E`ᝢd", A_1), out pData);
        int num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              if (pData.GetType() != typeof (uint))
              {
                num2 = 2;
                continue;
              }
              goto case 3;
            case 1:
              if (pData.GetType() != typeof (byte))
              {
                A_0 = uint.MaxValue;
                enReturnCode = enReturnCode.e_VALUE_OUT_OF_RANGE;
                num2 = 10;
                continue;
              }
              num2 = 3;
              continue;
            case 2:
              num2 = 8;
              continue;
            case 3:
              A_0 = (uint) pData;
              num2 = 6;
              continue;
            case 4:
              goto label_29;
            case 5:
              if (pData.GetType() != typeof (ulong))
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 6:
            case 10:
              num2 = 4;
              continue;
            case 7:
              num2 = 1;
              continue;
            case 8:
              if (pData.GetType() != typeof (ushort))
              {
                num2 = 9;
                continue;
              }
              goto case 3;
            case 9:
              num2 = 5;
              continue;
            default:
              goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
        CommandPMC.A1.ErrorMessage(typeof (CommandPMC).ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ\x2460ᕢd०\x1D68㥪౬᭮ᑰ", A_1), Module.a("ၔ⽖㩘㹚ⵜ\x2B5E\x0860ౢ\x0B64䝦੨੪Ŭͮᡰᵲቴ坶㹸Ṻॼ㭾\xE080\xF782\xE484붆ꦈ", A_1) + ex.Message);
        enReturnCode = enReturnCode.e_DATA_NOT_AVAILABLE;
      }
label_29:
      CommandPMC.A1.TraceOutMessage(Module.a("ᙔ㙖⩘㝚ੜ\x325E\x0860䵢♤\x0866Ѩ٪౬Ůᕰ⍲㡴㑶", A_1), Module.a("ቔ\x3256ⵘ\x0B5Aၜᱞ\x2460ᕢd०\x1D68㥪౬᭮ᑰ", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private static enReturnCode BA(out uint A_0)
    {
      int A_1 = 0;
label_2:
      CommandPMC.A1.TraceInMessage(Module.a("Յ⥇㥉⁋᥍㵏㭑穓ᕕ㝗㝙ㅛ㽝\x0E5F١㑣\x2B65\x2B67", A_1), Module.a("Ņⵇ㹉\x1C4B͍ፏᝑ≓㍕㙗\x2E59๛㽝ᑟݡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      A_0 = 0U;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 5;
      bool bit=false;
      while (true)
      {
        switch (num)
        {
          case 0:
            A_0 = (uint) (((int) dataOut[0] & (int) sbyte.MaxValue) * 60);
            num = 1;
            continue;
          case 1:
          case 2:
          case 4:
          case 6:
            goto label_16;
          case 3:
            bit = Utility.GetBit(dataOut[0], 7);
            num = 8;
            continue;
          case 5:
            if (wmiBiosClient != null)
            {
              num = 9;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            CommandPMC.A1.ErrorMessage(Module.a("Յ⥇㥉⁋᥍㵏㭑穓ᕕ㝗㝙ㅛ㽝\x0E5F١㑣\x2B65\x2B67", A_1), Module.a("Ņⵇ㹉\x1C4B͍ፏᝑ≓㍕㙗\x2E59๛㽝ᑟݡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("ཅ♇㥉㡋⽍㹏♑㵓㝕ⱗ㍙㍛そ䁟ൡɣ䙥㽧ݩիⱭ㥯㵱❳㕵ᑷ\x1379\x197Bၽ\xF47Fꊁ\xF683\xE385ﲇﾉﺋ\xE08D\xF58F\xF691뒓\xF895\xED97\xF699\xF09B", A_1));
            num = 2;
            continue;
          case 7:
            if (enReturnCode != enReturnCode.e_OK)
            {
              if (1 == 0)
                ;
              CommandPMC.A1.FormatErrorMessage(Module.a("Յ⥇㥉⁋᥍㵏㭑穓ᕕ㝗㝙ㅛ㽝\x0E5F١㑣\x2B65\x2B67", A_1), Module.a("Ņⵇ㹉\x1C4B͍ፏᝑ≓㍕㙗\x2E59๛㽝ᑟݡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("ͅ㩇㡉⍋㱍灏扑ⱓⵕ桗❙籛㡝\x125Fൡॣ䙥⩧⍩⍫㵭偯╱㥳㽵塷\x1979ᵻች\xEC7Fꊁ풃쮅쮇ꖉ벋뮍\xF88F늑\xE393ﺕ\xF197\xF699鍊뺝잟잡킣튥솧쒩쮫躭\xE0AFﾱ\xF7B3隵ﶷ첹\xD9BB킽뒿\xE2C1雃\xA7C5볇꿉", A_1), (object) enReturnCode);
              num = 6;
              continue;
            }
            num = 3;
            continue;
          case 8:
            if (bit)
            {
              num = 0;
              continue;
            }
            A_0 = (uint) dataOut[0];
            num = 4;
            continue;
          case 9:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, enPMCManagementCmdType.GetPMCEventRate, (byte[]) null, 0U, out dataOut, enSizeOut.eSIZE_4);
            num = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_16:
      CommandPMC.A1.TraceOutMessage(Module.a("Յ⥇㥉⁋᥍㵏㭑穓ᕕ㝗㝙ㅛ㽝\x0E5F١㑣\x2B65\x2B67", A_1), Module.a("Ņⵇ㹉\x1C4B͍ፏᝑ≓㍕㙗\x2E59๛㽝ᑟݡ≣ᑥݧݩ\x2E6B❭㽯ⅱ", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F塡䑣", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PMCCapabilitiesGet(string sCommandName, out object dataOut)
    {
      int A_1 = 17;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr㉴ቶ\x0D78", A_1), Module.a("іⵘ㩚⽜\x2B5EѠݢ䕤ၦhὪլ佮", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      dataOut = (object) null;
      int num1 = 2;
      int num2=0;
      string key1=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            num1 = 29;
            continue;
          case 1:
          case 3:
          case 4:
          case 7:
          case 8:
          case 9:
          case 10:
          case 11:
          case 13:
          case 14:
          case 15:
          case 17:
          case 18:
          case 19:
          case 21:
          case 22:
          case 23:
          case 25:
          case 26:
          case 27:
          case 33:
          case 34:
          case 35:
            goto label_48;
          case 2:
            if (this.N1)
            {
              num1 = 20;
              continue;
            }
            goto case 6;
          case 5:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(23);
            string key2 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶㡸\x0E7Aॼၾ펀\xE682\xE384\xF586\xEC88\xF88A\xE58C", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key2, num3);
            string key3 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶㑸᩺ռᙾ\xEC80\xF682\xE884욆쪈\xDD8A\xEC8C\xE38E\xE490\xF692", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ쾌욎\xDE90삒요\xF296\xED98\xEF9A\xF49C\xF19E욠", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ캌\xEE8E\xFD90朗\xF794\xE596\xF898\xEF9A\xF49C\xF09E쾠", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xF8AA鶬", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xF8AA햬", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            string key8 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xEAAA\xEEAC", A_1);
            int num9 = 6;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key8, num9);
            string key9 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xE9AA첬\xDBAE얰횲잴캶", A_1);
            int num10 = 7;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key9, num10);
            string key10 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xEAAA캬첮쒰\xDEB2살\xDBB6\xD8B8쾺\xD8BC\xDBBE", A_1);
            int num11 = 8;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key10, num11);
            string key11 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ즌\xEE8E\xE590\xF292횔\xF896\xF598\xF79A\xF89Cﲞ햠쪢쪤즦螨\xE2AA쎬\xDCAE얰튲\xDBB4쎶\xD8B8햺\xD8BC킾듀냂", A_1);
            int num12 = 9;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key11, num12);
            string key12 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C뾎뾐삒\xF494殺\xE998\xF79A\xF89C춞삠힢삤\xE4A6솨쪪쎬좮풰", A_1);
            int num13 = 10;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key12, num13);
            string key13 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C뾎뾐톒\xF494\xE396\xED98ﺚ\xEF9C\xE69E\xE2A0쮢쒤햦캨캪", A_1);
            int num14 = 11;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key13, num14);
            string key14 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C뾎뾐튒횔펖\xDA98쾚\xEF9Cﺞ쾠킢첤펦삨쒪쎬", A_1);
            int num15 = 12;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key14, num15);
            string key15 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C뾎뾐잒\xE794\xF696\xEF98ﺚ\xF19C\xDE9E얠슢햤펦첨\xD9AA", A_1);
            int num16 = 13;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key15, num16);
            string key16 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C뾎뾐솒\xF094\xF696ﶘ", A_1);
            int num17 = 14;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key16, num17);
            string key17 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐삒\xF494殺\xE998\xF79A\xF89C춞삠힢삤\xE4A6솨쪪쎬좮풰", A_1);
            int num18 = 15;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key17, num18);
            string key18 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐톒\xF494\xE396\xED98ﺚ\xEF9C\xE69E\xE2A0쮢쒤햦캨캪", A_1);
            int num19 = 16;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key18, num19);
            string key19 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐튒횔펖\xDA98쾚\xEF9Cﺞ쾠킢첤펦삨쒪쎬", A_1);
            int num20 = 17;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key19, num20);
            string key20 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐잒\xE794\xF696\xEF98ﺚ\xF19C\xDE9E얠슢햤펦첨\xD9AA", A_1);
            int num21 = 18;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key20, num21);
            string key21 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐쒒\xF494ﲖﲘ풚\xF39C펞\xE0A0\xEDA2认\xEBA6\xE8A8\xE5AA", A_1);
            int num22 = 19;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key21, num22);
            string key22 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐쒒\xF494ﲖﲘ풚\xF39C펞\xE0A0\xEDA2认\xF0A6\xE5A8\xEAAA\xE3AC", A_1);
            int num23 = 20;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key22, num23);
            string key23 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐쒒\xF494ﲖﲘ풚\xF39C펞\xE0A0\xEDA2认\xF0A6ﺨ\xEAAA\xE3AC", A_1);
            int num24 = 21;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key23, num24);
            string key24 = Module.a("ݖᑘᡚ獜ᱞ`።ѤզhݪѬ᭮ᡰᙲٴ奶⩸\x0E7Aർཾ\xEE80\xF182\xF184\xE286\xED88ꖊ\xDE8C\xF78E뾐튒\xD894쎖풘\xDE9A", A_1);
            int num25 = 22;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key24, num25);
            // ISSUE: reference to a compiler-generated field
            global::A.F = dictionary;
            num1 = 0;
            continue;
          case 6:
            enReturnCode = this.M1;
            num1 = 36;
            continue;
          case 12:
            if ((key1 = sCommandName) != null)
            {
              num1 = 32;
              continue;
            }
            goto case 28;
          case 16:
            num1 = 28;
            continue;
          case 20:
            this.M1 = this.CapabilitiesRefresh();
            num1 = 6;
            continue;
          case 24:
            num1 = 12;
            continue;
          case 28:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 4;
            continue;
          case 29:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.F.TryGetValue(key1, out num2))
            {
              num1 = 38;
              continue;
            }
            goto case 28;
          case 30:
            switch (num2)
            {
              case 0:
                dataOut = (object) (this.N1 ? 1 : 0);
                num1 = 18;
                continue;
              case 1:
                dataOut = (object) this.L1.A;
                num1 = 22;
                continue;
              case 2:
                dataOut = (object) (this.L1.Bb ? 1 : 0);
                num1 = 8;
                continue;
              case 3:
                dataOut = (object) (this.L1.C ? 1 : 0);
                num1 = 23;
                continue;
              case 4:
                dataOut = (object) (this.L1.D ? 1 : 0);
                num1 = 10;
                continue;
              case 5:
                dataOut = (object) (this.L1.E ? 1 : 0);
                num1 = 19;
                continue;
              case 6:
                dataOut = (object) (this.L1.F ? 1 : 0);
                num1 = 26;
                continue;
              case 7:
                dataOut = (object) (this.L1.G ? 1 : 0);
                num1 = 7;
                continue;
              case 8:
                dataOut = (object) (this.L1.H ? 1 : 0);
                num1 = 34;
                continue;
              case 9:
                dataOut = (object) (this.L1.I ? 1 : 0);
                num1 = 17;
                continue;
              case 10:
                dataOut = (object) (this.L1.J ? 1 : 0);
                num1 = 21;
                continue;
              case 11:
                dataOut = (object) (this.L1.K ? 1 : 0);
                num1 = 13;
                continue;
              case 12:
                dataOut = (object) (this.L1.L ? 1 : 0);
                num1 = 3;
                continue;
              case 13:
                dataOut = (object) (this.L1.M ? 1 : 0);
                num1 = 27;
                continue;
              case 14:
                dataOut = (object) (this.L1.N ? 1 : 0);
                num1 = 1;
                continue;
              case 15:
                dataOut = (object) (this.L1.O ? 1 : 0);
                num1 = 33;
                continue;
              case 16:
                dataOut = (object) (this.L1.P ? 1 : 0);
                num1 = 15;
                continue;
              case 17:
                dataOut = (object) (this.L1.Q ? 1 : 0);
                num1 = 31;
                continue;
              case 18:
                dataOut = (object) (this.L1.R ? 1 : 0);
                num1 = 11;
                continue;
              case 19:
                dataOut = (object) (this.L1.S ? 1 : 0);
                num1 = 14;
                continue;
              case 20:
                dataOut = (object) (this.L1.T ? 1 : 0);
                num1 = 35;
                continue;
              case 21:
                dataOut = (object) (this.L1.U ? 1 : 0);
                num1 = 25;
                continue;
              case 22:
                dataOut = (object) (this.L1.V ? 1 : 0);
                num1 = 9;
                continue;
              default:
                num1 = 16;
                continue;
            }
          case 31:
            goto label_35;
          case 32:
            num1 = 37;
            continue;
          case 36:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 24;
              continue;
            }
            goto label_48;
          case 37:
            // ISSUE: reference to a compiler-generated field
            if (global::A.F == null)
            {
              num1 = 5;
              continue;
            }
            goto case 0;
          case 38:
            num1 = 30;
            continue;
          default:
            goto label_2;
        }
      }
label_35:
      if (1 == 0)
        ;
label_48:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ݖᑘᡚṜ㹞ᅠɢݤ\x0E66ըɪᥬٮᑰr㉴ቶ\x0D78", A_1), Module.a("ᑖ㙘㙚ⵜ㍞Ѡᝢdͦ䥨ᱪѬ᭮ᥰ卲\x0E74䝶Ѹ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PMCDataGet(string sCommandName, out object dataOut)
    {
      int A_1 = 7;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1D4CɎቐᝒ㑔⍖㡘ᱚ㡜\x2B5E", A_1), Module.a("Ṍ㭎ぐ\x2152\x2154\x3256㵘筚⩜㙞ᕠୢ䕤", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      dataOut = (object) null;
      int num1 = 12;
      int num2=0;
      string key1=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
          case 1:
          case 3:
          case 4:
          case 5:
          case 6:
          case 7:
          case 8:
          case 9:
          case 10:
          case 13:
          case 14:
          case 15:
          case 16:
          case 17:
          case 18:
          case 20:
          case 21:
          case 23:
          case 27:
          case 29:
          case 30:
          case 31:
          case 32:
          case 34:
          case 38:
            goto label_50;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 16;
            continue;
          case 11:
            if ((key1 = sCommandName) != null)
            {
              num1 = 26;
              continue;
            }
            goto case 2;
          case 12:
            if (this.Q1)
            {
              num1 = 28;
              continue;
            }
            goto case 22;
          case 19:
            // ISSUE: reference to a compiler-generated field
            if (global::A.G == null)
            {
              num1 = 39;
              continue;
            }
            goto case 37;
          case 22:
            if (1 == 0)
              ;
            enReturnCode = this.P1;
            num1 = 25;
            continue;
          case 24:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit non-virtual call
            if (global::A.G.TryGetValue(key1, out num2))
            {
              num1 = 35;
              continue;
            }
            goto case 2;
          case 25:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 40;
              continue;
            }
            goto label_50;
          case 26:
            num1 = 19;
            continue;
          case 28:
            this.P1 = this.DataRefresh();
            num1 = 22;
            continue;
          case 33:
            num1 = 2;
            continue;
          case 35:
            num1 = 36;
            continue;
          case 36:
            switch (num2)
            {
              case 0:
                dataOut = (object) (this.Q1 ? 1 : 0);
                num1 = 29;
                continue;
              case 1:
                dataOut = (object) this.O1.date;
                num1 = 9;
                continue;
              case 2:
                dataOut = (object) (this.O1.B ? 1 : 0);
                num1 = 1;
                continue;
              case 3:
                dataOut = (object) (this.O1.C ? 1 : 0);
                num1 = 4;
                continue;
              case 4:
                dataOut = (object) this.O1.D;
                num1 = 17;
                continue;
              case 5:
                dataOut = (object) (this.O1.E ? 1 : 0);
                num1 = 6;
                continue;
              case 6:
                dataOut = (object) (this.O1.F ? 1 : 0);
                num1 = 3;
                continue;
              case 7:
                dataOut = (object) (this.O1.G ? 1 : 0);
                num1 = 8;
                continue;
              case 8:
                dataOut = (object) (this.O1.I ? 1 : 0);
                num1 = 30;
                continue;
              case 9:
                dataOut = (object) this.O1.J;
                num1 = 27;
                continue;
              case 10:
                dataOut = (object) this.O1.K;
                num1 = 5;
                continue;
              case 11:
                dataOut = (object) this.O1.L;
                num1 = 13;
                continue;
              case 12:
                dataOut = (object) this.O1.M;
                num1 = 10;
                continue;
              case 13:
                dataOut = (object) this.O1.N;
                num1 = 14;
                continue;
              case 14:
                dataOut = (object) (this.O1.O ? 1 : 0);
                num1 = 7;
                continue;
              case 15:
                dataOut = (object) (this.O1.P ? 1 : 0);
                num1 = 34;
                continue;
              case 16:
                dataOut = (object) (this.O1.Q ? 1 : 0);
                num1 = 0;
                continue;
              case 17:
                dataOut = (object) (this.O1.S ? 1 : 0);
                num1 = 15;
                continue;
              case 18:
                dataOut = (object) (this.O1.T ? 1 : 0);
                num1 = 20;
                continue;
              case 19:
                dataOut = (object) (this.O1.U ? 1 : 0);
                num1 = 18;
                continue;
              case 20:
                dataOut = (object) (this.O1.V ? 1 : 0);
                num1 = 32;
                continue;
              case 21:
                dataOut = (object) this.O1.W;
                num1 = 38;
                continue;
              case 22:
                dataOut = (object) this.O1.X;
                num1 = 23;
                continue;
              case 23:
                dataOut = (object) this.O1.Y;
                num1 = 31;
                continue;
              case 24:
                dataOut = (object) this.O1.Z;
                num1 = 21;
                continue;
              default:
                num1 = 33;
                continue;
            }
          case 37:
            num1 = 24;
            continue;
          case 39:
            Dictionary<string, int> dictionary = new Dictionary<string, int>(25);
            string key2 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜Ṟᑠᝢ\x0A64㕦౨൪Ὤ੮ɰ᭲", A_1);
            int num3 = 0;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key2, num3);
            string key3 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0B5E\x0860\x0E62d㑦\x1D68੪lὮ", A_1);
            int num4 = 1;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key3, num4);
            string key4 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜ᩞའɢݤ୦౨ཪ䍬\x2D6E㡰㱲♴", A_1);
            int num5 = 2;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key4, num5);
            string key5 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜ᱞ`ར\x0C64զ᭨੪ᥬ੮ᕰ", A_1);
            int num6 = 3;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key5, num6);
            string key6 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㙤٦Ѩ᭪Ŭ੮⍰ቲŴቶ", A_1);
            int num7 = 4;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key6, num7);
            string key7 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㙤٦Ѩ᭪Ŭ੮⍰ቲŴቶ㩸\x137A\x1C7Cᅾ\xE680\xE682", A_1);
            int num8 = 5;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
            string key8 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢❤٦\x1D68Ὢ\x086Cᵮ\x0870ひᵴᙶ\x0B78\x1C7A\x187C", A_1);
            int num9 = 6;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key8, num9);
            string key9 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢\x2464\x2466\x2D68⡪㥬ᵮၰᵲٴṶ\x0D78ቺቼᅾ", A_1);
            int num10 = 7;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key9, num10);
            string key10 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㝤ɦ\x0868ཪ", A_1);
            int num11 = 8;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key10, num11);
            string key11 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㕤\x0866Ṩ\x0E6AὬ≮ᑰቲٴɶ\x0B78Ṻၼ\x1A7E\xEF80\xF782톄ﺆ麗\xEE8A", A_1);
            int num12 = 9;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key11, num12);
            string key12 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㕤\x0866Ṩ\x0E6AὬ≮ᑰቲٴɶ\x0B78Ṻၼ\x1A7E\xEF80\xF782햄\xF586\xEC88\xE88A\xE48Cﲎ\xF890ﲒﮔ", A_1);
            int num13 = 10;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key12, num13);
            string key13 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㕤\x0866Ṩ\x0E6AὬ\x2B6Eၰݲᑴ", A_1);
            int num14 = 11;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key13, num14);
            string key14 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5E兠䵢㙤٦Ѩ᭪Ŭ੮ɰひᩴ᭶ᕸṺṼ\x0B7E\xE480\xE782", A_1);
            int num15 = 12;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key14, num15);
            string key15 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㙤٦Ѩ᭪Ŭ੮⍰ቲŴቶ", A_1);
            int num16 = 13;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key15, num16);
            string key16 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㙤٦Ѩ᭪Ŭ੮⍰ቲŴቶ㩸\x137A\x1C7Cᅾ\xE680\xE682", A_1);
            int num17 = 14;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key16, num17);
            string key17 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢❤٦\x1D68Ὢ\x086Cᵮ\x0870ひᵴᙶ\x0B78\x1C7A\x187C", A_1);
            int num18 = 15;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key17, num18);
            string key18 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢\x2464\x2466\x2D68⡪㥬ᵮၰᵲٴṶ\x0D78ቺቼᅾ", A_1);
            int num19 = 16;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key18, num19);
            string key19 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㉤٦ɨ\x0E6A≬Ů㵰㉲㭴奶㕸㩺㍼", A_1);
            int num20 = 17;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key19, num20);
            string key20 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㉤٦ɨ\x0E6A≬Ů㵰㉲㭴奶\x2E78㝺㱼ㅾ", A_1);
            int num21 = 18;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key20, num21);
            string key21 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㉤٦ɨ\x0E6A≬Ů㵰㉲㭴奶\x2E78ⱺ㱼ㅾ", A_1);
            int num22 = 19;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key21, num22);
            string key22 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢\x2464⩦㵨♪⡬", A_1);
            int num23 = 20;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key22, num23);
            string key23 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㕤\x0866Ṩ\x0E6AὬ≮ᑰቲٴɶ\x0B78Ṻၼ\x1A7E\xEF80\xF782톄ﺆ麗\xEE8A", A_1);
            int num24 = 21;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key23, num24);
            string key24 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㕤\x0866Ṩ\x0E6AὬ≮ᑰቲٴɶ\x0B78Ṻၼ\x1A7E\xEF80\xF782햄\xF586\xEC88\xE88A\xE48Cﲎ\xF890ﲒﮔ", A_1);
            int num25 = 22;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key24, num25);
            string key25 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㕤\x0866Ṩ\x0E6AὬ\x2B6Eၰݲᑴ", A_1);
            int num26 = 23;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key25, num26);
            string key26 = Module.a("\x1D4CɎቐ絒ᅔ㙖ⵘ㩚獜\x0C5Eᥠ䵢㙤٦Ѩ᭪Ŭ੮ɰひᩴ᭶ᕸṺṼ\x0B7E\xE480\xE782", A_1);
            int num27 = 24;
            // ISSUE: explicit non-virtual call
            dictionary.Add(key26, num27);
            // ISSUE: reference to a compiler-generated field
            global::A.G = dictionary;
            num1 = 37;
            continue;
          case 40:
            num1 = 11;
            continue;
          default:
            goto label_2;
        }
      }
label_50:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("\x1D4CɎቐᝒ㑔⍖㡘ᱚ㡜\x2B5E", A_1), Module.a("์⁎㱐⍒㥔\x3256ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨ၪ嵬ቮ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertyGetList()
    {
      int A_1 = 18;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅗ㑙㕛⩝たၡୣᙥ൧ᡩᡫ\x176D㝯\x1771s㩵ᅷॹ\x087B", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc", A_1));
      CommandPMC.InitEmulation();
      this.propertyGetList.Add(new Command.Property(Module.a("ࡗ\x1759Ὓ灝⍟͡\x0863ཥ੧ᡩ൫ᩭ\x196Fᵱᩳ㉵\x1977\x0E79ᵻ", A_1), typeof (XmlDocument), Module.a("ࡗ\x1759Ὓᥝ՟ᙡ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("ࡗ\x1759Ὓ灝⍟͡ᑣݥ੧ͩkݭѯ᭱ᅳյ䩷", A_1), typeof (XmlDocument), Module.a("ࡗ\x1759Ὓᥝ՟ᙡ", A_1), false));
      this.propertyGetList.Add(new Command.Property(Module.a("ࡗ\x1759Ὓ灝╟ᑡţ\x0865ᱧ㡩൫ᩭᕯ", A_1), typeof (uint), Module.a("ࡗ\x1759Ὓᥝ՟ᙡ", A_1), false));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᅗ㑙㕛⩝たၡୣᙥ൧ᡩᡫ\x176D㝯\x1771s㩵ᅷॹ\x087B", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧", A_1));
    }

    private enReturnCode PMCSet(string sCommandName, object dataIn)
    {
      int A_1 = 18;
label_2:
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ࡗ\x1759Ὓ\x0D5D՟ᙡ", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc䙥ὧͩᡫ٭偯", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 5;
      while (true)
      {
        uint A_0=0;
        string str=null;
        switch (num)
        {
          case 0:
            try
            {
              A_0 = (uint) dataIn;
            }
            catch
            {
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            }
            num = 2;
            continue;
          case 1:
            num = 16;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 12;
              continue;
            }
            goto label_40;
          case 3:
            num = 4;
            continue;
          case 4:
            if (A_0 > 120U)
            {
              num = 7;
              continue;
            }
            goto case 10;
          case 5:
            if (dataIn == null)
            {
              num = 6;
              continue;
            }
            goto case 8;
          case 6:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 8;
            continue;
          case 7:
            num = 17;
            continue;
          case 8:
            num = 14;
            continue;
          case 9:
          case 11:
          case 19:
            goto label_40;
          case 10:
            enReturnCode = this.BBCB(A_0);
            num = 11;
            continue;
          case 12:
            num = 21;
            continue;
          case 13:
            num = 15;
            continue;
          case 14:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 20;
              continue;
            }
            goto label_40;
          case 15:
            if (str == Module.a("ࡗ\x1759Ὓ灝╟ᑡţ\x0865ᱧ㡩൫ᩭᕯ", A_1))
            {
              num = 22;
              continue;
            }
            break;
          case 16:
            if (A_0 <= 7620U)
            {
              num = 23;
              continue;
            }
            goto label_29;
          case 17:
            if (A_0 >= 180U)
            {
              num = 1;
              continue;
            }
            goto label_29;
          case 18:
            if ((str = sCommandName) != null)
            {
              num = 13;
              continue;
            }
            break;
          case 20:
            num = 18;
            continue;
          case 21:
            if (A_0 > 0U)
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 22:
            A_0 = 0U;
            num = 0;
            continue;
          case 23:
            num = 24;
            continue;
          case 24:
            if ((int) (A_0 % 60U) == 0)
            {
              num = 10;
              continue;
            }
            goto label_29;
          default:
            goto label_2;
        }
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 9;
        continue;
label_29:
        enReturnCode = enReturnCode.e_INVALID_PARAMETER;
        num = 19;
      }
label_40:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ࡗ\x1759Ὓ\x0D5D՟ᙡ", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ味\x0D75䡷ݹ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode BBCB(uint A_0)
    {
      int A_1 = 1;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊\x1D4CɎቐᙒ⍔\x3256㝘⽚ཛྷ㹞ᕠ٢", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 4;
      CaslEventContainerClass eventContainerClass=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_15;
          case 1:
           // eventContainerClass = new CaslEventContainerClass();???
            num = 7;
            continue;
          case 2:
            //eventContainerClass.SetData(Module.a("ᝆшࡊ捌\x0B4Eぐ❒㑔", A_1), Module.a("Ɇ㽈\x2E4A⍌㭎͐\x3252\x2154\x3256", A_1), (object) A_0);
            num = 6;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto label_15;
          case 4:
            if (!CommandPMC.G1)
            {
              num = 1;
              continue;
            }
            goto case 5;
          case 5:
          case 6:
            num = 3;
            continue;
          case 7:
            if (1 == 0)
              ;
            if (eventContainerClass == null)
            {
              this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊\x1D4CɎቐᙒ⍔\x3256㝘⽚ཛྷ㹞ᕠ٢", A_1), Module.a("ņ⡈≊⅌⩎㕐獒\x2154㡖祘\x325A㍜ⱞᕠɢ\x0B64፦h੪ᥬ੮兰ቲ啴㑶\x1878\x087Aᅼ㩾\xF780\xE682\xEB84\xF386쪈\xE48A\xE38Cﮎ\xF090朗ﮔ\xF296\xEB98\xD89A\xF19Cﺞ튠킢薤좦쮨솪좬첮얰鎲슴\xDFB6\xDCB8햺鶼쮾돀뫂계꧆껈\xEBCA만ꃎ\xF1D0뷒뫔ꏖ냘뷚ꓜ\xFFDE鋠蛢韤釦胨裪裬쿮黰闲헴\xA7F6듸룺\xDDFC뫾眀昂欄猆⤈夊氌笎琐㌒瘔编砘甚稜稞", A_1));
              enReturnCode = enReturnCode.e_OUT_OF_MEMORY;
              num = 5;
              continue;
            }
            num = 2;
            continue;
          case 8:
            CommandPMC.E1 = new uint?(A_0);
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊\x1D4CɎቐᙒ⍔\x3256㝘⽚ཛྷ㹞ᕠ٢", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ奢䕤", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode BBBA(uint A_0)
    {
      int A_1 = 3;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x1F4E᱐ၒၔ\x2156㱘㕚⥜\x0D5E`ᝢd㍦٨⥪\x246C\x206E≰", A_1), Module.a("ᩈ㽊ⱌ㵎═㙒ㅔ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataIn = (byte[]) null;
      byte[] dataOut = (byte[]) null;
      int num1 = 4;
    WmiBIOSClient wmiBiosClient=null;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (wmiBiosClient != null)
            {
              num1 = 5;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x1F4E᱐ၒၔ\x2156㱘㕚⥜\x0D5E`ᝢd㍦٨⥪\x246C\x206E≰", A_1), Module.a("H╊㹌㭎ぐ㵒\x2154㹖㡘⽚㑜ぞའ䍢\x0A64Ŧ䥨㱪lٮ㍰㩲㩴\x2476㩸\x177Aᑼ\x1A7E\xEF80\xF782ꖄ\xF586\xEC88ﾊ\xF88Cﶎﾐ\xF692\xF194랖\xF798\xEE9A\xF19C\xF39E", A_1));
            num1 = 3;
            continue;
          case 1:
          case 9:
            wmiBiosClient = new WmiBIOSClient();
            num1 = 0;
            continue;
          case 2:
          case 3:
            goto label_16;
          case 4:
            if (A_0 <= 120U)
            {
              num1 = 7;
              continue;
            }
            uint num2 = A_0 / 60U;
            dataIn = BitConverter.GetBytes(0U);
            dataIn[0] = (byte) num2;
            Utility.SetBit(ref dataIn[0], 7, true);
            num1 = 9;
            continue;
          case 5:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, enPMCManagementCmdType.SetPMCEventRate, dataIn, 4U, out dataOut, enSizeOut.eSIZE_0);
            num1 = 8;
            continue;
          case 6:
            if (1 == 0)
              ;
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x1F4E᱐ၒၔ\x2156㱘㕚⥜\x0D5E`ᝢd㍦٨⥪\x246C\x206E≰", A_1), Module.a("ై㥊㽌⁎⍐獒敔⽖≘歚⁜罞ݠᅢ\x0A64੦䥨⥪\x246C\x206E≰卲≴㩶へ孺ṼṾ\xED80\xEF82ꖄ힆쒈좊ꊌ뾎Ꞑﮒ떔\xE096\xF198\xF29A\xF19C爵膠킢삤펦\xDDA8슪쎬좮醰\xE3B2\xF8B4\xF4B6馸ﺺ쮼\xDABE꿀럂\xE5C4闆\xA8C8뿊\xA8CC", A_1), (object) enReturnCode);
            num1 = 2;
            continue;
          case 7:
            dataIn = BitConverter.GetBytes(A_0);
            num1 = 1;
            continue;
          case 8:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num1 = 6;
              continue;
            }
            goto label_16;
          default:
            goto label_2;
        }
      }
label_16:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᩈ\x2E4A㥌\x1F4E᱐ၒၔ\x2156㱘㕚⥜\x0D5E`ᝢd㍦٨⥪\x246C\x206E≰", A_1), Module.a("ੈ⑊⁌㽎㵐㙒\x2154\x3256㵘筚⩜㙞ᕠୢ彤䝦", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public enReturnCode SetPMCConfiguration(XmlDocument xdocPMCConfiguration)
    {
      int A_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778", A_1), Module.a("畔іⵘ㩚⽜\x2B5EѠݢ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] abyPMCConfiguration = (byte[]) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 4;
            continue;
          case 1:
            if (CommandPMC.G1)
            {
              num = 6;
              continue;
            }
            enReturnCode = this.SetPMCConfigurationToBIOS(abyPMCConfiguration);
            num = 3;
            continue;
          case 2:
            if (xdocPMCConfiguration == null)
            {
              num = 0;
              continue;
            }
            goto case 4;
          case 3:
          case 5:
            goto label_23;
          case 4:
            num = 10;
            continue;
          case 6:
            enReturnCode = this.SetPMCConfigurationEmulation(abyPMCConfiguration);
            if (1 == 0)
              ;
            num = 5;
            continue;
          case 7:
            enReturnCode = new XmlTools().Validate(xdocPMCConfiguration.InnerXml, Resources.hpCASL);
            num = 9;
            continue;
          case 8:
            num = 14;
            continue;
          case 9:
            num = 13;
            continue;
          case 10:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto case 9;
          case 11:
            enReturnCode = this.ConvertPMCConfigurationXmlToArray(xdocPMCConfiguration, out abyPMCConfiguration);
            num = 8;
            continue;
          case 12:
            num = 1;
            continue;
          case 13:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 11;
              continue;
            }
            goto case 8;
          case 14:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 12;
              continue;
            }
            goto label_23;
          default:
            goto label_2;
        }
      }
label_23:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode ConvertPMCConfigurationXmlToArray(XmlDocument xdocPMCConfiguration, out byte[] abyPMCConfiguration)
    {
      int A_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᙔ㡖㝘ⵚ㡜ⵞᕠ㍢⡤\x2466⩨Ѫͬ८ᡰᑲtն\x1878ེᑼၾ\xEF80\xDB82\xE884\xEB86\xDD88\xE48A첌ﶎ\xE390\xF292\xEC94", A_1), Module.a("畔іⵘ㩚⽜\x2B5EѠݢ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      abyPMCConfiguration = (byte[]) null;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (xdocPMCConfiguration == null)
            {
              num = 4;
              continue;
            }
            goto case 5;
          case 1:
            goto label_6;
          case 2:
            abyPMCConfiguration = new byte[8];
            XmlEdit xmlEdit = new XmlEdit(xdocPMCConfiguration);
            uint uint32 = xmlEdit.GetUInt32(Module.a("穔і㱘⽚\x0D5C\x125E≠\x2062\x0A64०ཨɪ੬ᩮͰቲŴṶᙸᕺ㑼ᅾ\xF180\xF682\xF184ꢆ삈\xE58Aﶌ搜\xE590벒톔\xF696\xED98漢늜\xDC9E캠춢쎤캦캨\xDEAA\xDFAC캮얰\xDAB2\xDAB4\xD9B6隸\xE8BA\xDCBC튾뇀꿂ꃄ闆\xA8C8뿊\xA8CC", A_1));
            abyPMCConfiguration[4] |= (byte) (uint32 & 3U);
            XmlEdit.XmlNodeByte[] xmlNodeBytes = new XmlEdit.XmlNodeByte[2]
            {
              new XmlEdit.XmlNodeByte(Module.a("穔і㱘⽚\x0D5C\x125E≠\x2062\x0A64०ཨɪ੬ᩮͰቲŴṶᙸᕺ㑼ᅾ\xF180\xF682\xF184ꢆ삈\xE58Aﶌ搜\xE590벒톔\xF696\xED98漢늜튞삠즢쪤햦ﾨ캪\xDFAC\xDCAE\xD8B0\xDCB2\xDBB4", A_1), 0),
              new XmlEdit.XmlNodeByte(Module.a("穔і㱘⽚\x0D5C\x125E≠\x2062\x0A64०ཨɪ੬ᩮͰቲŴṶᙸᕺ㑼ᅾ\xF180\xF682\xF184ꢆ삈\xE58Aﶌ搜\xE590벒톔\xF696\xED98漢늜튞좠춢쪤햦ﾨ캪\xDFAC\xDCAE\xD8B0\xDCB2\xDBB4", A_1), 1)
            };
            xmlEdit.GetByte(xmlNodeBytes, ref abyPMCConfiguration);
            num = 1;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_11;
          case 4:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 5;
            continue;
          case 5:
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      if (1 == 0)
        ;
label_11:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᙔ㡖㝘ⵚ㡜ⵞᕠ㍢⡤\x2466⩨Ѫͬ८ᡰᑲtն\x1878ེᑼၾ\xEF80\xDB82\xE884\xEB86\xDD88\xE48A첌ﶎ\xE390\xF292\xEC94", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetPMCConfigurationEmulation(byte[] byPMCConfiguration)
    {
      int A_1 = 0;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉\x1C4B͍ፏᅑ㭓㡕㹗㍙㭛\x2B5D\x125F͡ၣཥݧѩ⥫ͭկṱᕳɵᅷᕹቻ", A_1), Module.a("晅ᭇ㹉ⵋ㱍\x244F㝑こ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      XmlDocument xdocPMCData = (XmlDocument) null;
      byte[] abyPMCData = (byte[]) null;
      int num1 = 1;
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
            goto label_26;
          case 1:
            if (byPMCConfiguration == null)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
          case 2:
            num1 = 9;
            continue;
          case 3:
            num1 = 13;
            continue;
          case 4:
            goto label_9;
          case 5:
            if (1 == 0)
              ;
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 2;
            continue;
          case 6:
            xdocPMCData = new XmlDocument();
            num1 = 12;
            continue;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 8;
              continue;
            }
            goto case 3;
          case 8:
            enReturnCode = this.ConvertPMCDataXmlToArray(xdocPMCData, out abyPMCData);
            num1 = 3;
            continue;
          case 9:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 6;
              continue;
            }
            break;
          case 10:
            num1 = 0;
            continue;
          case 11:
            uint num2 = (uint) byPMCConfiguration[4] & 3U;
            abyPMCData[12] &= (byte) 252;
            abyPMCData[12] |= (byte) (num2 & 3U);
            abyPMCData[23] &= (byte) 252;
            abyPMCData[23] |= (byte) (num2 & 3U);
            enReturnCode = CommandPMC.ConvertPMCDataArrayToXml(abyPMCData, out xdocPMCData);
            num1 = 10;
            continue;
          case 12:
            try
            {
              xdocPMCData.Load(CommandPMC.PMCDataEmulationFile);
              break;
            }
            catch
            {
              enReturnCode = enReturnCode.e_INVALID_XML;
              break;
            }
          case 13:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 11;
              continue;
            }
            goto case 10;
          default:
            goto label_2;
        }
        num1 = 7;
      }
label_9:
      try
      {
        xdocPMCData.Save(CommandPMC.PMCDataEmulationFile);
      }
      catch
      {
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_26:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᕅⵇ㹉\x1C4B͍ፏᅑ㭓㡕㹗㍙㭛\x2B5D\x125F͡ၣཥݧѩ⥫ͭկṱᕳɵᅷᕹቻ", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F塡䑣", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode SetPMCConfigurationToBIOS(byte[] abyPMCConfiguration)
    {
      int A_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778⽺ቼ㵾좀첂횄", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
      enReturnCode enReturnCode = enReturnCode.e_NULL_VALUE;
      byte[] dataOut = (byte[]) null;
      WmiBIOSClient wmiBiosClient = new WmiBIOSClient();
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (wmiBiosClient != null)
            {
              num = 5;
              continue;
            }
            enReturnCode = enReturnCode.e_NULL_VALUE;
            this.log.ErrorMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778⽺ቼ㵾좀첂횄", A_1), Module.a("᱔㥖⩘⽚㱜ㅞᕠ\x0A62Ѥ፦hѪͬ佮Ṱᕲ啴\x2076ᑸቺ㽼㙾캀킂욄\xEB86\xE088\xEE8A\xE38Cﮎ놐\xE192\xF094\xE396\xEC98\xE99A\xF39C爵얠莢쮤튦얨잪", A_1));
            if (1 == 0)
              ;
            num = 1;
            continue;
          case 1:
          case 4:
            goto label_11;
          case 2:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto label_11;
          case 3:
            this.log.FormatErrorMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778⽺ቼ㵾좀첂횄", A_1), Module.a("ၔ╖⭘㑚⽜罞兠᭢Ṥ坦ᑨ䭪୬ᵮṰṲ啴㕶へ㑺\x2E7C彾횀캂첄Ꞇ\xEA88\xEA8A\xE18C\xE38E놐쎒\xD894풖뚘\xAB9A꾜뾞횠쮢첤쮦첨讪\xDEAC쪮얰잲\xDCB4\xD9B6\xDEB8鮺\xEDBC\xF2BE苀\xE3C2蛄\xA8C6\xA7C8귊\xA4CC꣎ꓐꇒ듔ꏖ냘듚돜\xFFDEꗠ苢釤蛦", A_1), (object) enReturnCode);
            num = 4;
            continue;
          case 5:
            enReturnCode = wmiBiosClient.ExecMethodClient(enBIOSCommands.PMCManagement, enPMCManagementCmdType.SetPMCConfiguration, abyPMCConfiguration, 8U, out dataOut, enSizeOut.eSIZE_0);
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ٔ\x3256ⵘ\x0B5Aၜᱞ≠ౢ\x0B64Ŧh౪ᡬᵮၰݲᱴᡶ\x1778⽺ቼ㵾좀첂횄", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ䭰卲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PMCCapabilitiesSet(string sCommandName, object dataIn)
    {
      int A_1 = 0;
      if (1 == 0)
        ;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᙅՇॉཋ⽍⁏㍑㙓㽕㑗㍙⡛㝝՟ᅡ㝣ͥᱧ", A_1), Module.a("ᕅ㱇⭉㹋㩍㕏㙑瑓\x2155ㅗ\x2E59㑛繝", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 2;
      string str=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (str == Module.a("ᙅՇॉ手്ㅏ≑㕓㑕ㅗ㙙㕛⩝य़ݡᝣ䡥⥧Ὡᡫŭ≯\x1771ታѵᵷॹᑻ", A_1))
            {
              this.N1 = (bool) dataIn;
              num = 10;
              continue;
            }
            num = 4;
            continue;
          case 1:
            num = 5;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto label_18;
          case 3:
            num = 0;
            continue;
          case 4:
            num = 8;
            continue;
          case 5:
            if ((str = sCommandName) != null)
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 6:
          case 9:
          case 10:
            goto label_18;
          case 7:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 6;
            continue;
          case 8:
            if (str == Module.a("ᙅՇॉ手്ㅏ≑㕓㑕ㅗ㙙㕛⩝य़ݡᝣ䡥㩧ཀྵ੫ᱭᕯűᱳ", A_1))
            {
              this.M1 = this.CapabilitiesRefresh();
              num = 9;
              continue;
            }
            num = 11;
            continue;
          case 11:
            num = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᙅՇॉཋ⽍⁏㍑㙓㽕㑗㍙⡛㝝՟ᅡ㝣ͥᱧ", A_1), Module.a("Յ❇❉㱋≍㕏♑ㅓ\x3255硗ⵙ㕛⩝\x085F䉡ὣ噥ᕧ", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode PMCDataSet(string sCommandName, object dataIn)
    {
      int A_1 = 11;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ŐṒᙔፖ㡘⽚㱜\x0C5EѠᝢ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜罞ᙠ\x0A62ᅤས䥨", A_1) + sCommandName);
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num = 1;
      string str=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 10:
          case 11:
            goto label_19;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_19;
          case 2:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 0;
            continue;
          case 3:
            if (str == Module.a("ŐṒᙔ祖\x1D58㩚⥜㹞你ㅢdŦ᭨\x0E6AṬݮ", A_1))
            {
              this.P1 = this.DataRefresh();
              num = 11;
              continue;
            }
            num = 5;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 6:
            num = 9;
            continue;
          case 7:
            num = 8;
            continue;
          case 8:
            if ((str = sCommandName) != null)
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 9:
            if (str == Module.a("ŐṒᙔ祖\x1D58㩚⥜㹞你≢ၤ፦٨㥪\x086C८Ͱᙲٴὶ", A_1))
            {
              this.Q1 = (bool) dataIn;
              num = 10;
              continue;
            }
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ŐṒᙔፖ㡘⽚㱜\x0C5EѠᝢ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560䍢ቤ\x0E66\x1D68ͪ䵬ᑮ䅰\x0E72", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode CapabilitiesRefresh()
    {
      int A_1_1 = 19;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᩘ㩚ⵜ㹞͠\x0A62।\x0E66\x1D68ɪ\x086Cᱮ⍰ᙲ\x1374ն\x1C78\x087Aᕼ", A_1_1), Module.a("\x0A58⽚㱜ⵞᕠ٢Ť", A_1_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      bool A_1_2 = false;
      bool A_2 = false;
      byte[] numArray = (byte[]) null;
      int num = 3;
      XmlDocument A_0=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
            num = 4;
            continue;
          case 1:
            this.L1.A = (uint) numArray[4] + (uint) (((int) numArray[5] & 15) * 256);
            this.L1.Bb = Utility.GetBit(numArray[6], 0);
            this.L1.C = Utility.GetBit(numArray[6], 1);
            this.L1.D = Utility.GetBit(numArray[6], 2);
            this.L1.E = Utility.GetBit(numArray[6], 3);
            this.L1.F = Utility.GetBit(numArray[6], 4);
            this.L1.G = Utility.GetBit(numArray[6], 5);
            this.L1.H = Utility.GetBit(numArray[6], 6);
            this.L1.I = Utility.GetBit(numArray[6], 7);
            this.L1.J = Utility.GetBit(numArray[8], 2);
            this.L1.K = Utility.GetBit(numArray[8], 3);
            this.L1.L = Utility.GetBit(numArray[8], 4);
            this.L1.M = Utility.GetBit(numArray[8], 5);
            this.L1.N = Utility.GetBit(numArray[8], 6);
            this.L1.O = Utility.GetBit(numArray[12], 2);
            this.L1.P = Utility.GetBit(numArray[12], 3);
            this.L1.Q = Utility.GetBit(numArray[12], 4);
            this.L1.R = Utility.GetBit(numArray[12], 5);
            this.L1.S = Utility.GetBit(numArray[12], 7);
            this.L1.T = Utility.GetBit(numArray[13], 0);
            this.L1.U = Utility.GetBit(numArray[13], 1);
            this.L1.V = Utility.GetBit(numArray[13], 2);
            num = 6;
            continue;
          case 3:
            if (CommandPMC.G1)
            {
              num = 5;
              continue;
            }
            enReturnCode = CommandPMC.AAA(out numArray, ref A_1_2, ref A_2);
            num = 2;
            continue;
          case 4:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 1;
              continue;
            }
            goto label_15;
          case 5:
            A_0 = new XmlDocument();
            enReturnCode = CommandPMC.BB(out A_0, ref A_1_2, ref A_2);
            num = 7;
            continue;
          case 6:
            goto label_15;
          case 7:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 8;
              continue;
            }
            goto case 0;
          case 8:
            enReturnCode = this.ConvertPMCCapabilitiesXmlToArray(A_0, out numArray);
            if (1 == 0)
              ;
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᩘ㩚ⵜ㹞͠\x0A62।\x0E66\x1D68ɪ\x086Cᱮ⍰ᙲ\x1374ն\x1C78\x087Aᕼ", A_1_1), Module.a("ᩘ㑚ぜ⽞ൠ٢ᅤɦ൨䭪ᩬٮհ᭲啴\x0C76䥸ٺ", A_1_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    private enReturnCode DataRefresh()
    {
      int A_1 = 15;
label_2:
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᅔ㙖ⵘ㩚ཛྷ㩞ݠᅢdᑦŨ", A_1), Module.a("ٔ⍖㡘⥚⥜㩞\x0560", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      byte[] abyPMCData = (byte[]) null;
      if (1 == 0)
        ;
      int num = 9;
      int year=0;
      int month=0;
      int day=0;
      int hour=0;
      int minute=0;
      int second=0;
      XmlDocument xdocPMCData=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            hour = (int) Utility.ConvertFromBCD(abyPMCData[2]);
            minute = (int) Utility.ConvertFromBCD(abyPMCData[3]);
            second = (int) Utility.ConvertFromBCD(abyPMCData[4]);
            month = (int) Utility.ConvertFromBCD(abyPMCData[5]);
            day = (int) Utility.ConvertFromBCD(abyPMCData[6]);
            year = (int) Utility.ConvertFromBCD(abyPMCData[7]) + (int) Utility.ConvertFromBCD(abyPMCData[8]) * 100;
            num = 6;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 0;
              continue;
            }
            goto label_18;
          case 2:
            enReturnCode = this.ConvertPMCDataXmlToArray(xdocPMCData, out abyPMCData);
            num = 4;
            continue;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
          case 8:
            num = 1;
            continue;
          case 5:
            goto label_18;
          case 6:
            try
            {
              this.O1.date = new DateTime(year, month, day, hour, minute, second);
            }
            catch
            {
            }
            this.O1.B = Utility.GetBit(abyPMCData[9], 0);
            this.O1.C = !Utility.GetBit(abyPMCData[9], 1);
            this.O1.D = (uint) abyPMCData[12] & 3U;
            this.O1.J = (uint) (((int) abyPMCData[13] & 128) >> 7 | ((int) abyPMCData[14] & 3) << 1);
            this.O1.K = (uint) (((int) abyPMCData[14] & 252) >> 2);
            this.O1.L = BitConverter.ToUInt32(abyPMCData, 15);
            this.O1.M = BitConverter.ToUInt32(abyPMCData, 19);
            this.O1.E = Utility.GetBit(abyPMCData[12], 2);
            this.O1.F = Utility.GetBit(abyPMCData[12], 3);
            this.O1.G = Utility.GetBit(abyPMCData[12], 4);
            this.O1.H = Utility.GetBit(abyPMCData[12], 5);
            this.O1.I = Utility.GetBit(abyPMCData[12], 6);
            this.O1.N = (uint) abyPMCData[23] & 3U;
            this.O1.W = (uint) (((int) abyPMCData[24] & 128) >> 7 | ((int) abyPMCData[25] & 3) << 1);
            this.O1.X = (uint) (((int) abyPMCData[25] & 252) >> 2);
            this.O1.Y = BitConverter.ToUInt32(abyPMCData, 26);
            this.O1.Z = BitConverter.ToUInt32(abyPMCData, 30);
            this.O1.O = Utility.GetBit(abyPMCData[23], 2);
            this.O1.P = Utility.GetBit(abyPMCData[23], 3);
            this.O1.Q = Utility.GetBit(abyPMCData[23], 4);
            this.O1.R = Utility.GetBit(abyPMCData[23], 5);
            this.O1.S = Utility.GetBit(abyPMCData[23], 7);
            this.O1.T = Utility.GetBit(abyPMCData[24], 0);
            this.O1.U = Utility.GetBit(abyPMCData[24], 1);
            this.O1.V = Utility.GetBit(abyPMCData[24], 2);
            num = 5;
            continue;
          case 7:
            xdocPMCData = new XmlDocument();
            enReturnCode = CommandPMC.GetPMCDataEmulation(out xdocPMCData);
            num = 3;
            continue;
          case 9:
            if (CommandPMC.G1)
            {
              num = 7;
              continue;
            }
            enReturnCode = CommandPMC.GetPMCDataFromBIOS(out abyPMCData);
            num = 8;
            continue;
          default:
            goto label_2;
        }
      }
label_18:
      this.log.FormatTraceOutMessage(this.GetType().ToString(), Module.a("ᅔ㙖ⵘ㩚ཛྷ㩞ݠᅢdᑦŨ", A_1), Module.a("ᙔ㡖㑘\x2B5Aㅜ㩞ᕠ٢Ť䝦Ṩɪᥬݮ兰\x0872䕴\x0A76", A_1), (object) enReturnCode.ToString());
      return enReturnCode;
    }

    protected override void InitPropertySetList()
    {
      int A_1 = 8;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63㕥൧ṩ\x206Bݭͯٱ", A_1), Module.a("\x1D4D\x244F㍑♓≕㵗㹙", A_1));
      this.propertySetList.Add(new Command.Property(Module.a("ṍ\x1D4Fᅑ穓ፕ\x2E57㽙\x325B⩝\x325F͡ၣͥ", A_1), typeof (uint), Module.a("ṍ\x1D4Fᅑݓ㍕ⱗ", A_1), true));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ݍ㹏㭑⁓ٕ⩗㕙ⱛ㭝\x125Fᙡ\x1D63㕥൧ṩ\x206Bݭͯٱ", A_1), Module.a("്㽏㽑\x2453㩕㵗\x2E59㥛㩝", A_1));
    }

    protected override void InitExecuteList()
    {
      int A_1 = 11;
      if (1 == 0)
        ;
      this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖᱘⍚㡜㱞ᑠᝢd\x2B66hᡪᥬ", A_1), Module.a("ɐ❒㑔╖ⵘ㹚㥜", A_1));
      this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᡐ㵒㱔⍖᱘⍚㡜㱞ᑠᝢd\x2B66hᡪᥬ", A_1), Module.a("ቐ㱒㡔❖㕘㹚⥜㩞\x0560", A_1));
    }

    private struct B
    {
      public uint A;
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
      public bool Q;
      public bool R;
      public bool S;
      public bool T;
      public bool U;
      public bool V;
    }

    private struct A
    {
      public DateTime date;
      public bool B;
      public bool C;
      public uint D;
      public bool E;
      public bool F;
      public bool G;
      public bool H;
      public bool I;
      public uint J;
      public uint K;
      public uint L;
      public uint M;
      public uint N;
      public bool O;
      public bool P;
      public bool Q;
      public bool R;
      public bool S;
      public bool T;
      public bool U;
      public bool V;
      public uint W;
      public uint X;
      public uint Y;
      public uint Z;
    }
  }
}
