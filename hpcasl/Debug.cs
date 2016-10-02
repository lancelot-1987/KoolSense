// Decompiled with JetBrains decompiler
// Type: hpCasl.Debug
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class Debug
  {
    public static string PowerSource
    {
      get
      {
        return Util.CommandGetString(Casl.a("캉\xE98B\xEC8D\xE58F\xF591몓욕\xF797\xED99鍊\xEC9D\xF39F춡톣풥쮧쾩", 13));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("㩽\xE57F\xE081\xF183\xE185ꚇ\xDA89\xE38B轢\xF58F\xE091잓秊\xED97\xE899ﾛﮝ", 1), (object) value);
      }
    }
  }
}
