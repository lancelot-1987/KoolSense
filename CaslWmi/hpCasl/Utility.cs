// Decompiled with JetBrains decompiler
// Type: hpCasl.Utility
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using System;
using System.Collections.Generic;

namespace hpCasl
{
  internal static class Utility
  {
    public const string DiagsGet = "DiagsGet";
    public const string DiagsSet = "DiagsSet";
    public const string DiagsExecute = "DiagsExecute";
    public const string EDIDDataGet = "EDIDDataGet";
    public const string VTGet = "VTGet";
    public const string DockGet = "DockGet";
    public const string GENERATE_METHOD_POINTER = "CaslWmi.GenerateMethodPointer";
    private static Dictionary<string, string> m_Methods;

    public static bool AddMethod(string sIndex, string sMethodName)
    {
      Utility.GetMethodsDictionary();
      return Utility.AddMethodToDictionary(sIndex, sMethodName);
    }

    private static bool AddMethodToDictionary(string sIndex, string sMethodName)
    {
label_2:
      bool flag = false;
      if (1 == 0)
        ;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 3:
            goto label_8;
          case 1:
            if (Utility.m_Methods == null)
            {
              num = 2;
              continue;
            }
            flag = Utility.FileMethod(sIndex, sMethodName);
            num = 3;
            continue;
          case 2:
            flag = false;
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      return flag;
    }

    private static bool FileMethod(string sIndex, string sMethodName)
    {
      try
      {
        if (1 == 0)
          ;
        Utility.m_Methods[sIndex] = sMethodName;
        return true;
      }
      catch
      {
        return false;
      }
    }

    private static void GetMethodsDictionary()
    {
      if (Utility.m_Methods != null)
        return;
      Utility.m_Methods = new Dictionary<string, string>();
    }

    public static bool QueryMethod(string sIndex, out string sMethodName)
    {
            sMethodName = null;
label_2:
      bool bResult = false;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            sMethodName = string.Empty;
            bResult = false;
            if (1 == 0)
              ;
            num = 1;
            continue;
          case 1:
          case 3:
            goto label_8;
          case 2:
            if (Utility.m_Methods == null)
            {
              num = 0;
              continue;
            }
            sMethodName = Utility.RetrieveMethod(sIndex, ref bResult);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      return bResult;
    }

    private static string RetrieveMethod(string sIndex, ref bool bResult)
    {
      int num = 1;
      string str=null;
      while (true)
      {
        switch (num)
        {
          case 0:
            str = Utility.m_Methods[sIndex];
            bResult = true;
            num = 2;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_5;
          default:
            if (Utility.m_Methods.ContainsKey(sIndex))
            {
              num = 0;
              continue;
            }
            str = string.Empty;
            bResult = false;
            num = 3;
            continue;
        }
      }
label_5:
      if (1 == 0)
        ;
label_7:
      return str;
    }

    public static string GetMethodName(string sMethodIndex)
    {
      string str = Utility.QueryMethod(sMethodIndex);
      if (string.IsNullOrEmpty(str))
        str = sMethodIndex;
      return str;
    }

    private static string QueryMethod(string sMethodIndex)
    {
      string sMethodName = string.Empty;
      if (!Utility.QueryMethod(sMethodIndex, out sMethodName))
        sMethodName = sMethodIndex;
      return sMethodName;
    }

    internal static byte ConvertFromBCD(byte bBCD)
    {
      if (1 == 0)
        ;
      return (byte) ((((int) bBCD & 240) >> 4) * 10 + ((int) bBCD & 15));
    }

    internal static byte ConvertToBCD(byte bDecimal)
    {
      if (1 == 0)
        ;
      return (byte) ((int) bDecimal / 10 * 16 + (int) bDecimal % 10);
    }

    internal static void SetBit(ref byte bByte, int nBit, bool bState)
    {
      int A_1 = 10;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 2:
            goto label_9;
          case 3:
            if (bState)
            {
              num = 0;
              continue;
            }
            goto label_10;
          default:
            if (nBit > 7)
            {
              num = 2;
              continue;
            }
            if (1 == 0)
              ;
            num = 3;
            continue;
        }
      }
label_4:
      bByte |= (byte) (1 << nBit);
      return;
label_9:
      throw new Exception(Module.a("͏㝑⁓ᑕㅗ\x2E59籛そ≟ୡၣ䙥噧䩩孫呭偯", A_1) + (object) nBit);
label_10:
      bByte &= (byte) ~(1 << nBit);
    }

    internal static bool GetBit(byte bByte, int nBit)
    {
      int A_1 = 10;
      if (nBit > 7)
      {
        if (1 == 0)
          ;
        throw new Exception(Module.a("ᝏ㝑⁓ᑕㅗ\x2E59籛そ≟ୡၣ䙥噧䩩孫呭偯", A_1) + (object) nBit);
      }
      return ((int) bByte & 1 << nBit) != 0;
    }
  }
}
