// Decompiled with JetBrains decompiler
// Type: hpCasl.Platform
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;

namespace hpCasl
{
  public static class Platform
  {
    public static string Manufacturer
    {
      get
      {
        return Util.CommandGetString(Casl.a("햄\xEB86\xE888ﾊ\xEB8C\xE08E\xE390ﺒ뮔\xDA96\xF898\xF59A\xE89C咽삠삢톤튦\xDBA8캪\xDFAC", 8));
      }
    }

    public static string ModelName
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xD887\xE689\xED8B揄\xF68F\xFD91\xE693ﮕ뚗힙\xF39B瞧얟캡\xEAA3장얧쾩", 11));
      }
    }

    public static string SKUNumber
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xDB8A\xE18C\xEE8E\xE590\xF592杖\xE596\xF498떚캜풞\xF4A0\xEDA2키쪦쮨캪\xDFAC", 14));
      }
    }

    public static string Family
    {
      get
      {
        return Util.CommandGetString(Casl.a("힆\xE588\xEA8A歷\xE98Eﺐ\xE192\xF894릖\xDF98漢\xF09C\xF69E춠\xDAA2", 10));
      }
    }

    public static string SerialNumber
    {
      get
      {
        return Util.CommandGetString(Casl.a("⽾\xED80\xE282\xF184\xE186\xE688力\xE08Cꆎ슐\xF692\xE794ﺖ\xF898\xF79A펜\xEA9E철솢삤햦", 2));
      }
    }

    public static string BIOSVersionShort
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xDC8B\xE28D\xF18F\xE691\xF293秊\xEA97\xF799늛\xDC9D\xE99F\xEDA1\xF7A3\xF0A5춧\xD8A9\xDFAB잭\xDFAF\xDCB1\xE7B3\xDEB5ힷ좹좻", 15));
      }
    }

    public static string MachineID
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xD988\xE78A\xEC8Cﮎ\xF790ﲒ\xE794殺래횚ﲜﲞ즠쪢쮤슦\xE0A8\xEFAA", 12));
      }
    }

    public static bool IsTablet
    {
      get
      {
        return Util.CommandGetBool(Casl.a("\xDD8C\xE38E\xF090\xE792\xF394\xF896\xEB98\xF69A뎜횞튠\xF7A2쒤얦얨캪\xD9AC", 16));
      }
    }

    public static bool IsPortable
    {
      get
      {
        return Util.CommandGetBool(Casl.a("횅\xE487\xEB89\xF88B\xE88Dﾏ\xE091煉뢕톗\xE999첛\xF19D튟횡얣쒥쒧쾩", 9));
      }
    }

    public static string KBCVersion
    {
      get
      {
        return Util.CommandGetString(Casl.a("햄\xEB86\xE888ﾊ\xEB8C\xE08E\xE390ﺒ뮔\xDC96\xDB98\xD89A쮜爵펠킢첤좦잨", 8));
      }
    }

    public static string BIOSVersionLong
    {
      get
      {
        return Util.CommandGetString(Casl.a("삏ﺑ\xF593\xE295ﺗ\xF599\xEE9B\xF39D躟\xE0A1\xEDA3\xE9A5ﮧﲩ즫\xDCAD쎯\xDBB1\xDBB3\xD8B5\xF4B7햹튻\xD9BD", 19));
      }
    }

    public static string BIOSReleaseDate
    {
      get
      {
        return Util.CommandGetString(Casl.a("햄\xEB86\xE888ﾊ\xEB8C\xE08E\xE390ﺒ뮔햖킘풚캜춞쒠쾢삤욦\xDAA8캪\xE9AC캮얰횲", 8));
      }
    }

    public static string BIOSVendor
    {
      get
      {
        return Util.CommandGetString(Casl.a("큿\xEE81\xE583\xF285\xEE87\xE589ﺋ\xE38D뺏킑\xDD93\xD995쮗척鍊\xF09D쒟춡횣", 3));
      }
    }

    public static uint TotalMemory
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("\xD988\xE78A\xEC8Cﮎ\xF790ﲒ\xE794殺래쾚\xF29C\xEB9E삠쾢\xE8A4슦쒨쒪\xDFAC횮", 12));
      }
    }

    public static uint UMAMemory
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("\xDE8Dﲏ\xF391\xE093\xF095\xF797\xE899\xF19B낝\xF59F\xEFA1\xE5A3\xEBA5춧잩쎫\xDCAD즯", 17));
      }
    }

    public static string ProcessorName
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xDC8B\xE28D\xF18F\xE691\xF293秊\xEA97\xF799늛캝튟춡잣쎥\xDBA7\xD9A9쎫\xDCADﺯ펱\xD9B3펵", 15));
      }
    }

    public static string AssetTag
    {
      get
      {
        return Util.CommandGetString(Casl.a("\xDC8B\xE28D\xF18F\xE691\xF293秊\xEA97\xF799늛\xDF9D펟톡솣튥ﲧ쮩쮫", 15));
      }
    }

    public static Guid UUID
    {
      get
      {
        return Util.CommandGetGuid(Casl.a("펂\xE984\xE686ﶈ\xED8A\xE28Cﶎﲐ붒삔슖킘\xDF9A", 6));
      }
    }

    public static string sUUID
    {
      get
      {
        return Util.CommandGetString(Casl.a("\x2D7C\x137E\xE080\xF782\xE384\xE886ﮈ\xE68Aꎌﲎ쒐욒\xDC94펖", 0));
      }
    }
  }
}
