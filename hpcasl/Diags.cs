// Decompiled with JetBrains decompiler
// Type: hpCasl.Diags
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;

namespace hpCasl
{
  public static class Diags
  {
    public static uint BatteryChargeControl
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("첇\xE389\xED8B\xE98D\xE38F벑횓\xF795\xEC97\xEE99鍊\xEC9D\xD99F\xE1A1첣장\xDAA7충즫\xEDAD\xDFAF\xDCB1삳쒵ힷ횹", 11));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("㭾\xE880\xE282\xE284\xF486\xA788즊\xEC8Cﮎ\xE590\xF692\xE794\xEE96\xDA98\xF39Aﲜ\xED9E욠욢\xE6A4좦잨\xDFAA\xDFAC삮\xDDB0", 2), (object) value);
      }
    }

    public static uint BIOSUpdateStatus
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("쎆\xE088\xEA8A\xEA8Cﲎ뾐톒\xDC94\xD896쪘캚\xED9Cﮞ삠힢삤\xF4A6\xDDA8쪪\xD9AC\xDAAE슰", 10));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("㭾\xE880\xE282\xE284\xF486\xA788즊쒌삎슐욒\xE594\xF396\xF898\xEF9A\xF89C첞햠슢톤튦\xDAA8", 2), (object) value);
      }
    }

    public static uint LaunchCommandStatus
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("쑿\xEB81\xE583\xE185ﮇꒉ삋\xEF8D\xE58Fﲑ\xF793ﺕ\xDB97\xF599\xF19B\xF39D솟첡삣\xF5A5\xDCA7쮩\xD8AB\xDBAD쎯", 3));
      }
    }

    public static DateTime Warranty
    {
      get
      {
        return Util.CommandGetDateTime(Casl.a("첇\xE389\xED8B\xE98D\xE38F벑쎓\xF795\xEA97\xE899ﶛ\xF09D풟\xDBA1", 11));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("쮎\xF890\xF292\xF294\xE496래첚ﲜ\xED9E펠슢쮤펦킨", 18), (object) value);
      }
    }

    public static byte[] DeviceFirmwareUpdateStatus
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("즌\xE68E\xF090\xF492\xE694릖\xDD98ﺚ\xEB9C\xF69E슠욢\xE3A4캦\xDBA8욪\xDAAC캮쎰횲\xE0B4잶\xDDB8\xDABA즼\xDABE鋀럂꓄돆볈룊", 16));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("㩽\xE97F\xE381\xE383\xF585ꚇ캉\xE98B\xF88D憐\xF191\xF193킕\xF197\xE899\xF19B\xE99D솟킡솣\xF3A5\xD8A7캩춫\xDAAD햯\xE1B1삳ힵ첷쾹쾻", 1), (object) value);
      }
    }

    public static byte[] ThermalDiagnostics
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("슅\xE187\xEB89\xEB8Bﶍ뺏욑ﲓ\xF395\xEA97\xF799ﶛ\xF29D\xE49F쮡얣솥욧얩\xDFAB\xDAAD\xD9AF톱잳", 9));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("얀\xEA82\xE484\xE086愈ꖊ\xD98C\xE78E\xF490\xE192\xF894\xF696\xF598\xDF9A\xF49Cﺞ욠춢쪤풦\xDDA8슪캬\xDCAE", 4), (object) value);
      }
    }

    public static byte[] FactoryControl
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("욁\xED83\xE785\xEF87黎ꊋ좍\xF18F\xF191\xE093秊\xEA97\xE399\xDF9B\xF19D캟횡횣즥쒧", 5));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("솄\xEE86\xE888\xEC8Aﺌꆎ힐\xF292\xF694\xE396\xF698\xE99A\xE49C\xDC9E캠춢톤햦욨잪", 8), (object) value);
      }
    }

    public static byte[] PostCodeError
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("풏ﮑ\xF593\xF195\xEB97뒙첛\xF19D펟횡\xE7A3즥첧쾩\xE9AB\xDCAD슯\xDDB1욳", 19));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("㥼ᙾ\xE080\xE482\xF684ꦆ\xD988\xE48Aﺌﮎ튐ﲒ\xF194\xF296\xDC98\xE99A\xEF9C\xF09E펠", 0), (object) value);
      }
    }

    public static byte[] BatteryChargeControlOverride
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("풏ﮑ\xF593\xF195\xEB97뒙\xDE9Bﾝ풟횡솣풥톧\xE9A9쒫쾭슯햱톳\xF5B5ힷ풹좻첽꾿껁诃냅귇룉뻋\xA7CD듏럑", 19));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("쮎\xF890\xF292\xF294\xE496래\xD99Aﲜ\xEB9E햠욢\xD7A4\xDEA6\xEAA8쎪첬\xDDAE횰횲\xF6B4\xD8B6ힸ쾺쾼킾귀賂도ꋆ믈맊\xA4CCꯎ듐", 18), (object) value);
      }
    }

    public static byte[] ThermalControl
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("㭾\xE880\xE282\xE284\xF486\xA788\xDF8A\xE58C\xEA8E\xE390ﺒ\xF494ﮖ\xDA98\xF49A\xF39C\xEB9E펠첢즤", 2));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("솄\xEE86\xE888\xEC8Aﺌꆎ얐ﮒ\xF094\xE596\xF498漢\xF19C\xDC9E캠춢톤햦욨잪", 8), (object) value);
      }
    }
  }
}
