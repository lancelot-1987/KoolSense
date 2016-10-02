// Decompiled with JetBrains decompiler
// Type: CaslWmi.PanelBrightnessHelper
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using Microsoft.Win32;
using System;

namespace CaslWmi
{
  public class PanelBrightnessHelper
  {
    public static bool? IsDreamColorEnabled()
    {
label_2:
      ushort? dreamColorNits = PanelBrightnessHelper.GetDreamColorNits();
      int num1 = 0;
      int? nullable1=0;
      while (true)
      {
        int? nullable2=0;
        int? nullable3=0;
        int? nullable4=0;
        switch (num1)
        {
          case 0:
            num1 = dreamColorNits.HasValue ? 5 : 10;
            continue;
          case 1:
            if (1 == 0)
              ;
            num1 = 7;
            continue;
          case 2:
            nullable1 = nullable2;
            num1 = 9;
            continue;
          case 3:
            goto label_13;
          case 4:
            nullable4 = nullable3;
            break;
          case 5:
            nullable4 = new int?((int) dreamColorNits.GetValueOrDefault());
            break;
          case 6:
            goto label_10;
          case 7:
            goto label_6;
          case 8:
            num1 = !nullable2.HasValue ? 6 : 2;
            continue;
          case 9:
            num1 = nullable1.GetValueOrDefault() < 0 ? 3 : 1;
            continue;
          case 10:
            nullable3 = new int?();
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
        nullable2 = nullable4;
        num1 = 8;
      }
label_6:
      int num2 = nullable1.HasValue ? 1 : 0;
      goto label_16;
label_10:
      num2 = 0;
      goto label_16;
label_13:
      num2 = 0;
label_16:
      return new bool?(num2 != 0);
    }

    public static ushort? GetDreamColorNits()
    {
      int A_1 = 17;
      ushort? nullable1 = new ushort?();
      ushort? nullable2;
      try
      {
        if (1 == 0)
          ;
        nullable2 = Registry.LocalMachine.OpenSubKey(Module.a("і㙘㵚⥜⡞`ᅢd㭦Ⅸ\x0E6AᩬͮᑰݲŴ婶⥸᩺Ṽᑾ\xE080\xF182\xE184\xDB86솈\xDB8A삌쮎킐쾒", A_1)).GetValue(Module.a("ὖक़ᙚᥜṞⵠᙢ\x0864\x0E66ݨ੪ͬ౮ᑰ㽲ၴŶ\x1C78\x177A", A_1), (object) null) as ushort?;
      }
      catch (Exception ex)
      {
        nullable2 = new ushort?();
      }
      return nullable2;
    }
  }
}
