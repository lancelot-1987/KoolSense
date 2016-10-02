// Decompiled with JetBrains decompiler
// Type: hpCasl.ALS
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class ALS
  {
    public static bool Enabled
    {
      get
      {
        return Util.CommandGetBool(Casl.a("㱼㍾튀궂삄\xE986\xE888\xE98A\xE18C\xEA8E\xF590", 0));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("쪊소\xDC8E뾐횒ﮔ\xF696ﮘ\xF79A\xF89Cﮞ", 14), (value ? 1 : 0));
      }
    }

    public static bool Supported
    {
      get
      {
        return Util.CommandGetBool(Casl.a("입쒇\xD989ꊋ\xDD8D\xE58F\xE291\xE493秊\xEA97\xEE99鍊瞧", 9));
      }
    }
  }
}
