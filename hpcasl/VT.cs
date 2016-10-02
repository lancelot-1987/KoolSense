// Decompiled with JetBrains decompiler
// Type: hpCasl.VT
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class VT
  {
    public static bool Supported
    {
      get
      {
        return Util.CommandGetBool(Casl.a("\xD88D쒏벑잓\xE395\xE897\xEA99\xF39B\xEC9D풟잡삣", 17));
      }
    }

    public static string Status
    {
      get
      {
        return Util.CommandGetString(Casl.a("⥾햀궂횄\xF386\xE888ﾊ\xF88Cﲎ", 2));
      }
    }
  }
}
