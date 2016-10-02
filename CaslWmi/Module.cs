// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

internal class Module
{
 public static string a(string A_0, int A_1)
  {
    char[] chArray1 = A_0.ToCharArray();
    int num1 = 1781617221 + A_1;
    int num2 = 0;
    int num3 = 1;
    if (num2 < num3)
      goto label_2;
label_1:
    int index1 = num2;
    char[] chArray2 = chArray1;
    int index2 = index1;
    int num4 = (int) (short) chArray1[index1];
    int num5 = (int) byte.MaxValue;
    int num6 = num4 & num5;
    int num7 = num1;
    int num8 = 1;
    int num9 = num7 + num8;
    byte num10 = (byte) (num6 ^ num7);
    int num11 = 8;
    int num12 = num4 >> num11;
    int num13 = num9;
    int num14 = 1;
    num1 = num13 + num14;
    int num15 = (int) (byte) (num12 ^ num13);
    int num16 = (int) (ushort) ((uint) num10 << 8 | (uint) (byte) num15);
    chArray2[index2] = (char) num16;
    int num17 = 1;
    num2 += num17;
label_2:
    int length = chArray1.Length;
    if (num2 >= length)
      return string.Intern(new string(chArray1));
    goto label_1;
  }
}
