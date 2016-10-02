// Decompiled with JetBrains decompiler
// Type: hpCasl.Validate
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using CaslSmBios;
namespace hpCasl
{
  public class Validate
  {
    private static byte[] C = new byte[276]
    {
      (byte) 6,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 36,
      (byte) 0,
      (byte) 0,
      (byte) 82,
      (byte) 83,
      (byte) 65,
      (byte) 49,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 229,
      (byte) 231,
      byte.MaxValue,
      (byte) 36,
      (byte) 127,
      (byte) 134,
      (byte) 44,
      (byte) 107,
      (byte) 186,
      (byte) 194,
      (byte) 232,
      (byte) 186,
      (byte) 158,
      (byte) 70,
      (byte) 175,
      (byte) 206,
      (byte) 240,
      (byte) 175,
      (byte) 208,
      (byte) 85,
      (byte) 70,
      (byte) 177,
      (byte) 51,
      (byte) 214,
      (byte) 214,
      (byte) 233,
      (byte) 169,
      (byte) 91,
      (byte) 179,
      (byte) 202,
      (byte) 31,
      (byte) 146,
      (byte) 114,
      (byte) 254,
      (byte) 166,
      (byte) 233,
      (byte) 54,
      (byte) 133,
      (byte) 119,
      (byte) 244,
      (byte) 29,
      (byte) 112,
      (byte) 223,
      (byte) 210,
      (byte) 237,
      (byte) 125,
      (byte) 220,
      (byte) 42,
      (byte) 148,
      (byte) 155,
      (byte) 254,
      (byte) 204,
      (byte) 182,
      (byte) 153,
      (byte) 169,
      (byte) 220,
      (byte) 37,
      (byte) 207,
      (byte) 27,
      (byte) 209,
      (byte) 114,
      (byte) 178,
      (byte) 28,
      (byte) 166,
      (byte) 217,
      (byte) 223,
      (byte) 161,
      (byte) 70,
      (byte) 194,
      (byte) 146,
      (byte) 240,
      (byte) 210,
      (byte) 18,
      (byte) 148,
      (byte) 60,
      (byte) 89,
      (byte) 251,
      (byte) 47,
      (byte) 187,
      (byte) 115,
      (byte) 150,
      (byte) 193,
      (byte) 221,
      (byte) 38,
      (byte) 142,
      (byte) 154,
      (byte) 83,
      (byte) 39,
      (byte) 65,
      (byte) 196,
      byte.MaxValue,
      (byte) 97,
      (byte) 253,
      (byte) 12,
      (byte) 65,
      (byte) 77,
      (byte) 59,
      (byte) 99,
      (byte) 1,
      (byte) 48,
      (byte) 174,
      (byte) 129,
      (byte) 171,
      (byte) 121,
      (byte) 190,
      (byte) 162,
      (byte) 113,
      (byte) 241,
      (byte) 197,
      (byte) 241,
      (byte) 176,
      (byte) 107,
      (byte) 41,
      (byte) 215,
      (byte) 35,
      (byte) 33,
      (byte) 150,
      (byte) 201,
      (byte) 120,
      (byte) 178,
      (byte) 54,
      (byte) 204,
      (byte) 216,
      (byte) 229,
      (byte) 83,
      (byte) 51,
      (byte) 158,
      (byte) 86,
      (byte) 225,
      (byte) 101,
      (byte) 164,
      (byte) 51,
      (byte) 138,
      (byte) 237,
      (byte) 73,
      (byte) 134,
      (byte) 98,
      (byte) 25,
      (byte) 135,
      (byte) 143,
      (byte) 97,
      (byte) 232,
      (byte) 229,
      (byte) 223,
      (byte) 132,
      (byte) 29,
      (byte) 150,
      (byte) 229,
      byte.MaxValue,
      (byte) 58,
      (byte) 13,
      (byte) 135,
      (byte) 14,
      (byte) 63,
      (byte) 12,
      (byte) 28,
      (byte) 104,
      (byte) 94,
      (byte) 120,
      (byte) 122,
      (byte) 254,
      (byte) 160,
      (byte) 187,
      (byte) 154,
      (byte) 172,
      (byte) 91,
      (byte) 173,
      (byte) 242,
      (byte) 208,
      (byte) 157,
      (byte) 70,
      (byte) 231,
      (byte) 61,
      (byte) 141,
      (byte) 235,
      (byte) 55,
      (byte) 127,
      (byte) 62,
      (byte) 55,
      (byte) 5,
      (byte) 89,
      (byte) 251,
      (byte) 108,
      (byte) 103,
      (byte) 225,
      (byte) 157,
      (byte) 151,
      (byte) 98,
      (byte) 249,
      (byte) 239,
      (byte) 86,
      (byte) 122,
      (byte) 37,
      (byte) 0,
      (byte) 32,
      (byte) 89,
      (byte) 29,
      (byte) 184,
      (byte) 150,
      (byte) 221,
      (byte) 232,
      (byte) 161,
      (byte) 231,
      (byte) 138,
      (byte) 179,
      (byte) 24,
      (byte) 102,
      (byte) 213,
      (byte) 223,
      (byte) 3,
      (byte) 127,
      (byte) 150,
      (byte) 249,
      (byte) 33,
      (byte) 31,
      (byte) 76,
      (byte) 230,
      (byte) 7,
      (byte) 82,
      (byte) 11,
      (byte) 167,
      (byte) 13,
      (byte) 6,
      (byte) 77,
      (byte) 73,
      (byte) 233,
      (byte) 126,
      (byte) 245,
      (byte) 20,
      (byte) 179,
      (byte) 149,
      (byte) 200,
      (byte) 2,
      (byte) 213,
      (byte) 92,
      (byte) 168,
      (byte) 111,
      (byte) 233,
      (byte) 0,
      (byte) 8,
      (byte) 102,
      (byte) 215,
      (byte) byte.MinValue, //sbyte.MinValue????
      (byte) 7,
      (byte) 230,
      (byte) 232,
      (byte) 19,
      (byte) 159,
      (byte) 141,
      (byte) 178,
      (byte) 82,
      (byte) 118,
      (byte) 214,
      (byte) 111,
      (byte) 30,
      (byte) 183
    };
    private const int A = 5;
    private const string B = "hpCASL";

    public static bool IsValidSignature(string sFile)
    {
      int A_1 = 13;
      string sSignatureFile = sFile + hpSMBIOS.a("认쾦\xD9A8\xD8AA쒬좮\xDFB0", A_1);
      return Validate.IsValidSignature(sFile, sSignatureFile);
    }

    public static bool IsValidSignature(string sFile, string sSignatureFile)
    {
      int A_1 = 1;
label_2:
      bool flag1 = true;
      string str = sFile + hpSMBIOS.a("\xF198\xEB9A\xDE9C\xDE9E\xF2A0\xEFA2", A_1);
      int num1 = 35;
      HashAlgorithm hashAlgorithm = null;
      RSACryptoServiceProvider cryptoServiceProvider1=null;
      RSACryptoServiceProvider cryptoServiceProvider2=null;
      byte[] signature=null;
      byte[] buffer=null;
      while (true)
      {
        bool flag2=false;
        int num2=0;
        CspParameters parameters=null;
        int num3=0;
        bool flag3=false;
        switch (num1)
        {
          case 0:
            if (File.Exists(sFile))
            {
              num1 = 17;
              continue;
            }
            goto case 34;
          case 1:
            if (num3 >= 5)
            {
              num1 = 27;
              continue;
            }
            goto case 44;
          case 2:
            num1 = 4;
            continue;
          case 3:
          case 24:
            num1 = 19;
            continue;
          case 4:
            if (flag2)
            {
              num1 = 16;
              continue;
            }
            goto case 22;
          case 5:
            if (!flag3)
            {
              num1 = 14;
              continue;
            }
            goto case 2;
          case 6:
            if (flag3)
            {
              if (1 == 0)
                ;
              Array.Reverse((Array) signature);
              num1 = 24;
              continue;
            }
            num1 = 22;
            continue;
          case 7:
            if (num2 >= 5)
            {
              num1 = 8;
              continue;
            }
            try
            {
              cryptoServiceProvider1 = new RSACryptoServiceProvider(parameters);
            }
            catch
            {
              cryptoServiceProvider1 = (RSACryptoServiceProvider) null;
            }
            num1 = 11;
            continue;
          case 8:
            num1 = 9;
            continue;
          case 9:
            if (cryptoServiceProvider1 != null)
            {
              num1 = 39;
              continue;
            }
            goto label_75;
          case 10:
            goto label_43;
          case 11:
            if (cryptoServiceProvider1 != null)
            {
              num1 = 43;
              continue;
            }
            break;
          case 12:
            if (hashAlgorithm != null)
            {
              num1 = 10;
              continue;
            }
            goto label_75;
          case 13:
            num2 = 0;
            num1 = 33;
            continue;
          case 14:
            num1 = 21;
            continue;
          case 15:
            if (cryptoServiceProvider1 == null)
            {
              num1 = 20;
              continue;
            }
            goto case 33;
          case 16:
            num1 = 6;
            continue;
          case 17:
            num1 = 25;
            continue;
          case 18:
            num1 = 36;
            continue;
          case 19:
            if (flag1)
            {
              num1 = 32;
              continue;
            }
            goto label_104;
          case 20:
            Thread.Sleep(300);
            ++num2;
            num1 = 38;
            continue;
          case 21:
            if (num3 >= 5)
            {
              num1 = 2;
              continue;
            }
            goto case 42;
          case 22:
            flag1 = false;
            num1 = 3;
            continue;
          case 23:
            num1 = 7;
            continue;
          case 25:
            if (!File.Exists(sSignatureFile))
            {
              num1 = 34;
              continue;
            }
            goto case 40;
          case 26:
            if (cryptoServiceProvider1 == null)
            {
              num1 = 23;
              continue;
            }
            goto case 8;
          case 27:
            num3 = 0;
            flag3 = false;
            num1 = 42;
            continue;
          case 28:
            if (parameters != null)
            {
              num1 = 18;
              continue;
            }
            goto label_75;
          case 29:
            num3 = 0;
            flag2 = false;
            num1 = 44;
            continue;
          case 30:
            try
            {
              parameters = new CspParameters();
              parameters.KeyContainerName = str;
              parameters.Flags = CspProviderFlags.NoPrompt;
            }
            catch
            {
              parameters = (CspParameters) null;
            }
            try
            {
              hashAlgorithm = (HashAlgorithm) new SHA1CryptoServiceProvider();
            }
            catch
            {
              hashAlgorithm = (HashAlgorithm) null;
            }
            num1 = 28;
            continue;
          case 31:
            num1 = 1;
            continue;
          case 32:
            flag1 = false;
            parameters = (CspParameters) null;
            cryptoServiceProvider1 = (RSACryptoServiceProvider) null;
            hashAlgorithm = (HashAlgorithm) null;
            num1 = 30;
            continue;
          case 33:
          case 38:
            num1 = 26;
            continue;
          case 34:
            flag1 = false;
            num1 = 40;
            continue;
          case 35:
            try
            {
label_35:
              Process currentProcess = Process.GetCurrentProcess();
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    num4 = 2;
                    continue;
                  case 1:
                    if (currentProcess != null)
                    {
                      num4 = 3;
                      continue;
                    }
                    goto case 0;
                  case 2:
                    goto label_83;
                  case 3:
                    str = currentProcess.ProcessName + hpSMBIOS.a("욘", A_1) + str;
                    num4 = 0;
                    continue;
                  default:
                    goto label_35;
                }
              }
            }
            catch
            {
            }
label_83:
            buffer = (byte[]) null;
            signature = (byte[]) null;
            num1 = 0;
            continue;
          case 36:
            if (hashAlgorithm != null)
            {
              num1 = 13;
              continue;
            }
            goto label_75;
          case 37:
            if (!flag2)
            {
              num1 = 31;
              continue;
            }
            goto case 27;
          case 39:
            num1 = 12;
            continue;
          case 40:
            num1 = 41;
            continue;
          case 41:
            if (flag1)
            {
              num1 = 29;
              continue;
            }
            goto case 3;
          case 42:
            try
            {
              signature = File.ReadAllBytes(sSignatureFile);
              flag3 = true;
              goto case 2;
            }
            catch
            {
              Thread.Sleep(300);
              ++num3;
              flag3 = false;
            }
            num1 = 5;
            continue;
          case 43:
            try
            {
              cryptoServiceProvider1.PersistKeyInCsp = false;
              cryptoServiceProvider1.Clear();
              cryptoServiceProvider2 = (RSACryptoServiceProvider) null;
            }
            catch
            {
              cryptoServiceProvider2 = (RSACryptoServiceProvider) null;
            }
            try
            {
              cryptoServiceProvider1 = new RSACryptoServiceProvider(parameters);
              break;
            }
            catch
            {
              cryptoServiceProvider1 = (RSACryptoServiceProvider) null;
              break;
            }
          case 44:
            try
            {
              buffer = File.ReadAllBytes(sFile);
              flag2 = true;
              goto case 27;
            }
            catch
            {
              Thread.Sleep(300);
              ++num3;
              flag2 = false;
            }
            num1 = 37;
            continue;
          default:
            goto label_2;
        }
        num1 = 15;
      }
label_43:
      try
      {
        cryptoServiceProvider1.PersistKeyInCsp = false;
        cryptoServiceProvider1.ImportCspBlob(Validate.C);
        flag1 = cryptoServiceProvider1.VerifyData(buffer, (object) hashAlgorithm, signature);
      }
      catch
      {
        flag1 = false;
      }
label_75:
      try
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              hashAlgorithm.Clear();
              hashAlgorithm = (HashAlgorithm) null;
              num2 = 2;
              continue;
            case 2:
              num2 = 3;
              continue;
            case 3:
              goto label_24;
            default:
              if (hashAlgorithm != null)
              {
                num2 = 0;
                continue;
              }
              goto case 2;
          }
        }
      }
      catch
      {
      }
label_24:
      try
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_104;
            case 2:
              num2 = 0;
              continue;
            case 3:
              cryptoServiceProvider1.PersistKeyInCsp = false;
              cryptoServiceProvider1.Clear();
              cryptoServiceProvider1 = (RSACryptoServiceProvider) null;
              num2 = 2;
              continue;
            default:
              if (cryptoServiceProvider1 != null)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
          }
        }
      }
      catch
      {
        cryptoServiceProvider2 = (RSACryptoServiceProvider) null;
      }
label_104:
      return flag1;
    }
  }
}
