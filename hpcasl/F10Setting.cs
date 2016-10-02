// Decompiled with JetBrains decompiler
// Type: hpCasl.F10Setting
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class F10Setting
  {
    public static class DayStarter2
    {
      public static bool Enabled
      {
        get
        {
          return Util.CommandGetBool(Casl.a("쮌뺎ꆐ삒\xF094\xE396\xED98\xF29A\xF39C\xF89E辠\xE7A2쒤\xDEA6直\xDFAA첬\xDDAE얰횲잴薶鞸ﺺ펼\xDEBEꏀ꿂ꃄꏆ", 16));
        }
      }
    }

    public static class CustomLogo
    {
      public static bool Enabled
      {
        get
        {
          return Util.CommandGetBool(Casl.a("잃\xF385ﮇﺉ\xE38B\xE38D\xDC8F\xFD91\xF393秊뚗\xDF99\xF29Bﾝ슟캡솣슥", 7));
        }
      }
    }
  }
}
