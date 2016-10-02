// Decompiled with JetBrains decompiler
// Type: hpCasl.SmartAdapter
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class SmartAdapter
  {
    public static bool Supported
    {
      get
      {
        return Util.CommandGetBool(Casl.a("\xDD8Dﶏ\xF391\xE693\xE295\xD997ﺙﶛ\xEE9D풟잡횣袥ﮧ\xDFA9\xDCAB\xDEAD\xDFAF삱삳펵\xDCB7", 17));
      }
    }

    public static uint Status
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("\xDA88\xE68A\xEC8Cﶎ\xE590튒\xF194\xF696\xE998\xEF9A\xF89C\xED9E辠\xF0A2톤욦\xDDA8\xDEAA\xDEAC", 12));
      }
    }
  }
}
