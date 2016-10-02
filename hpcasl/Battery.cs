// Decompiled with JetBrains decompiler
// Type: hpCasl.Battery
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class Battery
  {
    public static class Info
    {
      public static bool Supported
      {
        get
        {
          return Util.CommandGetBool(Casl.a("㱽\xE17F\xF681\xF083\xE385慎\xF389ꊋ잍ﺏ\xF491ﮓ뢕쮗\xEF99\xEC9B\xEE9D쾟킡킣쎥첧", 1));
        }
      }
    }
  }
}
