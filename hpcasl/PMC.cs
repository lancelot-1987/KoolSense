// Decompiled with JetBrains decompiler
// Type: hpCasl.PMC
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System.Xml;

namespace hpCasl
{
  public static class PMC
  {
    public static XmlDocument CalibrationData
    {
      get
      {
        return Util.CommandGetXml(Casl.a("햄쪆쪈ꖊ캌\xEE8E\xFD90朗\xF794\xE596\xF898\xEF9A\xF49C\xF09E쾠\xE7A2쒤펦좨", 8));
      }
    }

    public static XmlDocument Capabilities
    {
      get
      {
        return Util.CommandGetXml(Casl.a("\xD887잉쾋ꂍ펏\xF391\xE493\xF795流\xF399\xF09B\xF79D풟쮡솣향", 11));
      }
    }

    public static XmlDocument Data
    {
      get
      {
        return Util.CommandGetXml(Casl.a("삏\xDF91힓뢕\xDC97ﮙ\xE89Bﾝ", 19));
      }
    }

    public static XmlDocument Capabilities2
    {
      get
      {
        return Util.CommandGetXml(Casl.a("\xDA89솋춍뺏톑\xF593\xE695聯\xF899\xF59B\xF29D즟횡춣쎥\xDBA7颩", 13));
      }
    }

    public static uint EventRate
    {
      get
      {
        return Util.CommandGetUInt32(Casl.a("\xDD8C슎튐붒킔\xE196ﲘ\xF59A\xE99C춞삠힢삤", 16));
      }
      set
      {
        int num = (int) Command.Set(Casl.a("\x2D7C㉾슀궂삄\xF186\xEC88\xE58A歷\xDD8E\xF090\xE792\xF094", 0), (object) value);
      }
    }
  }
}
