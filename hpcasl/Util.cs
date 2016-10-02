// Decompiled with JetBrains decompiler
// Type: hpCasl.Util
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace hpCasl
{
  internal static class Util
  {
    public static string GetCurrentProperty()
    {
      int A_1 = 5;
      if (1 == 0)
        ;
      MethodBase method = new StackTrace(false).GetFrame(1).GetMethod();
      return method.DeclaringType.ToString().Substring(method.ReflectedType.Namespace.Length + 1).Replace('+', '.') + Casl.a("겁", A_1) + method.Name.Substring(4);
    }

    public static object CommandGet(string commandName)
    {
      int A_1 = 14;
label_2:
      object oDataOut = (object) null;
      enReturnCode eRetCode = enReturnCode.e_OK;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            if (1 == 0)
              ;
            if (commandName == null)
            {
              num = 0;
              continue;
            }
            try
            {
              eRetCode = Command.Get(commandName, out oDataOut);
            }
            catch (Exception ex)
            {
              throw new CaslException(commandName + Casl.a("\xAB8A\xEB8C\xEE8E\xF890ﾒ\xF094\xF396", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
            }
            num = 3;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (eRetCode != enReturnCode.e_OK)
            {
              num = 2;
              continue;
            }
            goto label_13;
          default:
            goto label_2;
        }
      }
label_9:
      throw new CaslException(commandName + Casl.a("\xAB8A\xEB8C\xEE8E\xF890ﾒ\xF094\xF396", A_1), enReturnCode.e_NULL_VALUE);
label_10:
      throw new CaslException(commandName + Casl.a("\xAB8A\xEB8C\xEE8E\xF890ﾒ\xF094\xF396", A_1), eRetCode);
label_13:
      return oDataOut;
    }

    public static string CommandGetString(string commandName)
    {
      int A_1 = 14;
      string str=null;
      try
      {
        str = (string) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("\xAB8A\xEB8C\xEE8E\xF890ﾒ\xF094\xF396", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return str;
    }

    public static string[] CommandGetStringList(string commandName)
    {
      int A_1 = 8;
      string[] strArray;
      try
      {
        strArray = (string[]) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꖄ\xE186\xE888\xE28A\xE18C\xEA8E\xF590", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return strArray;
    }

    public static bool CommandGetBool(string commandName)
    {
      int A_1 = 3;
      bool flag=false;
      try
      {
        flag = (bool) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꁿ\xE481\xE583\xEF85\xE487\xEF89\xE88B", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return flag;
    }

    public static uint CommandGetUInt32(string commandName)
    {
      int A_1 = 2;
      try
      {
        if (1 == 0)
          ;
        return (uint) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("彾\xE780\xE282\xEC84\xEB86\xEC88\xEF8A", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
    }

    public static ushort CommandGetUInt16(string commandName)
    {
      int A_1 = 9;
      try
      {
        if (1 == 0)
          ;
        return (ushort) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꚅ\xEE87\xEB89\xE58B\xE28D\xF58F\xF691", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
    }

    public static ushort[] CommandGetUInt16Array(string commandName)
    {
      int A_1 = 13;
      try
      {
        if (1 == 0)
          ;
        return (ushort[]) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꪉ\xEA8B\xEF8D憐ﺑ\xF193\xF295", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
    }

    public static double[] CommandGetDoubleArray(string commandName)
    {
      int A_1 = 6;
      double[] numArray;
      try
      {
        numArray = (double[]) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꎂ\xE384\xE686\xE088\xE78A\xE88C\xEB8E", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return numArray;
    }

    public static DateTime CommandGetDateTime(string commandName)
    {
      int A_1 = 3;
      if (1 == 0)
        ;
      DateTime now = DateTime.Now;
      try
      {
        return (DateTime) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꁿ\xE481\xE583\xEF85\xE487\xEF89\xE88B", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
    }

    public static string[] Merge(string[] Array1, string[] Array2)
    {
label_2:
      int index = 0;
      int num1 = 0;
      int num2 = 6;
      string[] strArray = null;
      while (true)
      {
        switch (num2)
        {
          case 0:
            if (index != 0)
            {
              num2 = 10;
              continue;
            }
            goto case 4;
          case 1:
            index = Array1.Length;
            num2 = 8;
            continue;
          case 2:
            num1 = Array2.Length;
            num2 = 9;
            continue;
          case 3:
            if (1 == 0)
              ;
            if (num1 != 0)
            {
              num2 = 11;
              continue;
            }
            goto label_19;
          case 4:
            num2 = 3;
            continue;
          case 5:
            goto label_19;
          case 6:
            if (Array1 != null)
            {
              num2 = 1;
              continue;
            }
            goto case 8;
          case 7:
            if (Array2 != null)
            {
              num2 = 2;
              continue;
            }
            goto case 9;
          case 8:
            num2 = 7;
            continue;
          case 9:
            strArray = new string[index + num1];
            num2 = 0;
            continue;
          case 10:
            Array1.CopyTo((Array) strArray, 0);
            num2 = 4;
            continue;
          case 11:
            Array2.CopyTo((Array) strArray, index);
            num2 = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      return strArray;
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
      int A_1 = 2;
      int num = 0;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num)
        {
          case 1:
            if (bState)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 2:
            goto label_4;
          case 3:
            goto label_7;
          default:
            num = nBit <= 7 ? 1 : 3;
            continue;
        }
      }
label_4:
      bByte |= (byte) (1 << nBit);
      return;
label_7:
      throw new Exception(Casl.a("Ȿ\xE480\xF782임\xEE86ﶈ\xAB8A\xE38C춎\xF890\xE792떔ꦖ릘겚\xA79C뾞", A_1) + (object) nBit);
label_8:
      bByte &= (byte) ~(1 << nBit);
    }

    internal static bool GetBit(byte bByte, int nBit)
    {
      int A_1 = 5;
      if (nBit > 7)
      {
        if (1 == 0)
          ;
        throw new Exception(Casl.a("얁\xE183\xF285쪇\xE389\xF88B꺍ﺏ킑ﶓ\xE295뢗꒙벛ꦝ骟芡", A_1) + (object) nBit);
      }
      return ((int) bByte & 1 << nBit) != 0;
    }

    public static Guid CommandGetGuid(string commandName)
    {
      int A_1 = 5;
      Guid guid1 = Guid.Empty;
      Guid guid2;
      try
      {
        guid2 = (Guid) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("ꊁ\xE283\xE785\xE187\xE689\xE98B\xEA8D", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return guid2;
    }

    public static XmlDocument CommandGetXml(string commandName)
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      try
      {
        return (XmlDocument) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("Ꞇ\xEF88\xEA8A\xE48C\xE38E\xF490\xF792", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
    }

    public static byte[] CommandGetByteArray(string commandName)
    {
      int A_1 = 16;
      byte[] numArray;
      try
      {
        numArray = (byte[]) Util.CommandGet(commandName);
      }
      catch (CaslException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new CaslException(commandName + Casl.a("권\xE98E\xF090朗璉\xF296ﶘ", A_1), ex, enReturnCode.e_GENERAL_EXCEPTION);
      }
      if (1 == 0)
        ;
      return numArray;
    }
  }
}
