// Decompiled with JetBrains decompiler
// Type: hpCasl.PanelBrightness
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System.Xml;

namespace hpCasl
{
  public static class PanelBrightness
  {
    public static bool Supported
    {
      get
      {
        return Util.CommandGetBool(Casl.a("\xDD8C\xEE8Eﾐ\xF692璉햖\xEB98\xF29A煮\xF79E햠춢삤풦\xDAA8薪ﺬ\xDAAE솰쎲\xDAB4얶춸\xDEBA\xD9BC", 16));
      }
    }

    public static ushort Index
    {
      get
      {
        return Util.CommandGetUInt16(Casl.a("\xD988\xEA8A\xE38C\xEA8E\xFD90톒\xE794ﺖﺘ\xF39A\xE99C\xF19E쒠킢횤覦\xE0A8얪즬쪮즰", 12));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("톀\xE282\xEB84\xE286\xE588즊ﾌ\xE68E\xF690ﮒ\xE194練ﲘ\xE89A\xEE9C놞\xE8A0춢솤슦톨", 4), (object) value);
      }
    }

    public static ushort Nits
    {
      get
      {
        return Util.CommandGetUInt16(Casl.a("큿\xE381\xEA83\xE385\xE487좉ﺋ\xE78D\xF78F晴\xE093\xF895ﶗ\xE999\xEF9B낝\xEE9F쮡킣향", 3));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("톀\xE282\xEB84\xE286\xE588즊ﾌ\xE68E\xF690ﮒ\xE194練ﲘ\xE89A\xEE9C놞\xEFA0쪢톤풦", 4), (object) value);
      }
    }

    public static ushort Percent
    {
      get
      {
        return Util.CommandGetUInt16(Casl.a("⽾\xE080\xED82\xE084\xEB86쮈力\xE48C\xE88E戀\xE792ﮔ\xF296\xEA98\xE89A뎜쾞쒠톢욤슦잨\xDFAA", 2));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("\xDE8D\xF18Fﲑ\xF193歹\xDA97\xE899\xF59B劣좟횡쪣쎥\xDBA7\xD9A9芫ﺭ햯삱ힳ펵횷캹", 17), (object) value);
      }
    }

    public static ushort PWM
    {
      get
      {
        return Util.CommandGetUInt16(Casl.a("\x2E7D\xE17F\xEC81\xE183\xEA85쪇\xF889\xE58B\xE98D\xF88F\xE691望\xF395\xEB97\xE999늛캝\xF79F\xEFA1", 1));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("\x2D7CṾ\xEF80\xE682\xE984얆ﮈ\xE28A\xEA8C\xE78E\xE590ﶒ\xF094\xE496\xEA98떚출좞\xECA0", 0), (object) value);
      }
    }

    public class Tables
    {
      public static bool Supported
      {
        get
        {
          return Util.CommandGetBool(Casl.a("\xDF8E\xF090ﶒ\xF094ﮖ\xDB98\xE99A\xF49C\xF89E즠힢쮤슦\xDAA8\xD8AA莬ﮮ킰톲\xD9B4튶쪸閺\xEEBC쪾뇀돂\xAAC4뗆뷈껊꧌", 18));
        }
      }

      public static XmlDocument All
      {
        get
        {
          return Util.CommandGetXml(Casl.a("톀\xE282\xEB84\xE286\xE588즊ﾌ\xE68E\xF690ﮒ\xE194練ﲘ\xE89A\xEE9C놞\xF5A0슢잤쮦첨\xD8AA莬\xEEAE\xDDB0\xDFB2", 4));
        }
      }

      public static ushort[] Nits
      {
        get
        {
          return Util.CommandGetUInt16Array(Casl.a("\x2D7CṾ\xEF80\xE682\xE984얆ﮈ\xE28A\xEA8C\xE78E\xE590ﶒ\xF094\xE496\xEA98떚즜ﺞ쎠쾢삤풦螨\xE5AA쒬\xDBAE슰", 0));
        }
      }

      public static ushort[] Percent
      {
        get
        {
          return Util.CommandGetUInt16Array(Casl.a("펂\xE484\xE986\xEC88\xE78A쾌ﶎ\xF890\xF492ﶔ\xE396\xF798ﺚ\xEE9C\xEC9E辠\xF7A2쒤얦얨캪\xDEAC膮\xE1B0횲잴풶\xDCB8햺즼", 6));
        }
      }

      public static double[] PowerTables
      {
        get
        {
          return Util.CommandGetDoubleArray(Casl.a("\xDB8A\xEC8C\xE18E\xF490ﾒ힔\xE596\xF098ﲚ\xF59C\xEB9E쾠욢횤풦螨ﾪ첬춮\xDDB0횲운馶\xE9B8풺쪼\xDABE돀韂꓄ꗆꗈ껊뻌", 14));
        }
      }
    }
  }
}
