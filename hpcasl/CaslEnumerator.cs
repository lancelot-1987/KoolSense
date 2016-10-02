// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslEnumerator
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace hpCasl
{
  internal class CaslEnumerator
  {
    public static string[] GetPlugins()
    {
      int A_1 = 12;
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷\xDF8E\xFD90\xE692\xF294ﺖ\xF798\xE89A", A_1), Casl.a("\xDA88ﾊ\xEC8Cﶎ\xE590\xF692\xF194", A_1));
      List<string> list = new List<string>();
      string name = Casl.a("\xDA88\xE48A\xEB8Cﮎ\xE690\xF292\xE794\xF296얘쮚\xF29C\xF39E좠삢첤슦\xDAA8\xF7AA\xE5AC쪮우\xDFB2킴쎶춸隺\xEDBC\xDEBEꋀꣂ꓄뗆귈韊藌\x9FCE\xF1D0郒뫔뫖듘듚돜\xFFDEꃠ胢蛤苦髨飪췬볮铰臲菴黶髸黺\xDDFC돾栀愂眄昆笈爊ⴌ弎紐昒爔縖眘栚", A_1);
      try
      {
label_3:
        RegistryKey registryKey1 = Registry.LocalMachine.OpenSubKey(name);
        int num = 5;
        string[] strArray = null;
        int index = 0;
        RegistryKey registryKey2 = null;
        object obj = null;
        string[] subKeyNames = null;
        while (true)
        {
          switch (num)
          {
            case 0:
              subKeyNames = registryKey1.GetSubKeyNames();
              num = 9;
              continue;
            case 1:
              obj = registryKey2.GetValue(Casl.a("\xD988\xEA8A歷\xE78E", A_1));
              num = 2;
              continue;
            case 2:
              if (File.Exists((string) obj))
              {
                num = 13;
                continue;
              }
              goto case 10;
            case 3:
            case 12:
              num = 7;
              continue;
            case 4:
              if (registryKey2 != null)
              {
                num = 1;
                continue;
              }
              goto case 10;
            case 5:
              if (registryKey1 != null)
              {
                num = 0;
                continue;
              }
              goto case 11;
            case 6:
              goto label_24;
            case 7:
              if (index < strArray.Length)
              {
                string str = strArray[index];
                registryKey2 = Registry.LocalMachine.OpenSubKey(name + Casl.a("했", A_1) + str);
                num = 4;
                continue;
              }
              num = 14;
              continue;
            case 8:
              strArray = subKeyNames;
              index = 0;
              num = 12;
              continue;
            case 9:
              if (subKeyNames != null)
              {
                num = 8;
                continue;
              }
              goto case 14;
            case 10:
              registryKey2.Close();
              registryKey2 = (RegistryKey) null;
              ++index;
              num = 3;
              continue;
            case 11:
              num = 6;
              continue;
            case 13:
              list.Add((string) obj);
              Global.Log.InformationMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷\xDF8E\xFD90\xE692\xF294ﺖ\xF798\xE89A", A_1), Casl.a("쾈\xE48A\xF88C\xE18E\xF590뎒\xE594ﮖ\xEC98ﲚ\xF49C\xF19E鮠莢", A_1) + (string) obj);
              num = 10;
              continue;
            case 14:
              registryKey1.Close();
              registryKey1 = (RegistryKey) null;
              num = 11;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch
      {
      }
label_24:
      if (1 == 0)
        ;
      Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷\xDF8E\xFD90\xE692\xF294ﺖ\xF798\xE89A", A_1), Casl.a("쪈\xE48A\xE08Cﾎ\xFD90\xF692\xE194\xF296ﶘ뮚\xEA9C\xF69E햠쮢薤\xDCA6馨횪趬\xDFAE\xDDB0욲튴\xDEB6ힸ좺鶼\xD9BE껀뛂ꯄꏆ", A_1), (object) (list == null ? 0 : list.Count));
      return list.ToArray();
    }
  }
}
