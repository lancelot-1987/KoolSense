// Decompiled with JetBrains decompiler
// Type: hpCasl.EDID
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class EDID
  {
    public static byte[] Data
    {
      get
      {
        return Util.CommandGetByteArray(Casl.a("㭽쑿쮁삃ꢅ첇\xEB89\xF88B\xEF8D", 1));
      }
    }
  }
}
