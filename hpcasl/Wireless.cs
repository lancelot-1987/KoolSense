// Decompiled with JetBrains decompiler
// Type: hpCasl.Wireless
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System.Xml;

namespace hpCasl
{
  public static class Wireless
  {
    public static XmlDocument DeviceInfo
    {
      get
      {
        return Util.CommandGetXml(Casl.a("\xD88E\xF890\xE192\xF094ﮖﲘ\xE89A\xEE9C놞\xE5A0욢펤캦쪨캪\xE4AC솮ힰ\xDCB2", 18));
      }
    }

    public static XmlDocument GlobalChanged
    {
      get
      {
        return Util.CommandGetXml(Casl.a("톅\xE187\xF889\xE98B\xE28D\xF58F\xE191\xE793뢕\xDF97\xF699\xF39Bﲝ솟캡\xE7A3캥즧쒩쮫쮭풯", 9));
      }
    }

    public static XmlDocument SetDeviceState
    {
      set
      {
        int num = (int) Command.Set(Casl.a("\xDA8C\xE68E\xE390\xF692璉\xF296\xEA98\xE89A뎜첞쒠힢\xE1A4슦\xDFA8슪캬쪮\xE2B0잲풴쎶\xDCB8", 16), (object) value);
      }
    }

    public static class WLAN
    {
      public static bool Present
      {
        get
        {
          return Util.CommandGetBool(Casl.a("⩼ᙾ\xF380\xE682\xE984\xE286愈\xF88Aꎌ\xD88E\xDD90튒\xDB94릖즘\xE99A\xF89C\xEC9E쒠춢톤", 0));
        }
      }
    }

    public static class Bluetooth
    {
      public static bool Present
      {
        get
        {
          return Util.CommandGetBool(Casl.a("펃\xEF85慎\xEF89\xE08B\xEB8D\xE38F\xE191몓풕\xF497\xEF99鍊\xEA9D쾟춡킣캥蚧睊\xDEAB쮭쎯ힱ\xDAB3습", 7));
        }
      }
    }

    public static class WWAN
    {
      public static bool Present
      {
        get
        {
          return Util.CommandGetBool(Casl.a("킆\xE088力\xE88C\xE38E\xF490\xE092\xE694릖캘첚\xDC9C톞辠\xF3A2\xD7A4슦\xDAA8캪쎬\xDBAE", 10));
        }
      }
    }

    public static class GPS
    {
      public static bool Present
      {
        get
        {
          return Util.CommandGetBool(Casl.a("킆\xE088力\xE88C\xE38E\xF490\xE092\xE694릖\xDE98쮚캜놞\xF1A0톢삤풦첨얪\xD9AC", 10));
        }
      }
    }

    public static class All
    {
      public static bool Enabled
      {
        set
        {
          int num = (int) Command.Set(Casl.a("킆\xE088力\xE88C\xE38E\xF490\xE092\xE694릖\xD898\xF79A\xF19C놞\xE4A0춢쒤얦얨캪즬", 10), (value ? 1 : 0));
        }
      }
    }
  }
}
