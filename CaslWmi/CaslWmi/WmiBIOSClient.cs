// Decompiled with JetBrains decompiler
// Type: CaslWmi.WmiBIOSClient
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using hpCasl;
using HPQWMIEXLib;
using System;
using System.Threading;

namespace CaslWmi
{
  public class WmiBIOSClient
  {
    public const int m_DiagsThermalSizeIn = 4;
    private hpqCallBiosExClass A;

    public WmiBIOSClient()
    {
      this.A = new hpqCallBiosExClass();
    }

    public enReturnCode ExecMethodClient(enBIOSCommands eCmd, enBIOSCommandTypes eCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
      return this.ExecMethodClient(eCmd, (uint) eCmdType, dataIn, iSizeIn, out dataOut, eSizeOut);
    }

    public enReturnCode ExecMethodClient(enBIOSCommands eCmd, enPMCManagementCmdType eCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
      return this.ExecMethodClient(eCmd, (uint) eCmdType, dataIn, iSizeIn, out dataOut, eSizeOut);
    }

    public enReturnCode ExecMethodClient(enBIOSCommands eCmd, enReadCmdType eCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
      return this.ExecMethodClient(eCmd, (uint) eCmdType, dataIn, iSizeIn, out dataOut, eSizeOut);
    }

    public enReturnCode ExecMethodClient(enBIOSCommands eCmd, enSecurityCmdType eCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
      return this.ExecMethodClient(eCmd, (uint) eCmdType, dataIn, iSizeIn, out dataOut, eSizeOut);
    }

    public enReturnCode ExecMethodClient(enBIOSCommands eCmd, enWriteCmdType eCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
      return this.ExecMethodClient(eCmd, (uint) eCmdType, dataIn, iSizeIn, out dataOut, eSizeOut);
    }

    protected enReturnCode ExecMethodClient(enBIOSCommands eCmd, uint iCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, enSizeOut eSizeOut)
    {
label_2:
      if (1 == 0)
        ;
      uint iRetCode = (uint) byte.MaxValue;
      dataOut = (byte[]) null;
      enReturnCode enReturnCode = (enReturnCode) this.CallBios(eCmd, (enBIOSCommandTypes) iCmdType, (int) iSizeIn, (int) eSizeOut, ref iRetCode, dataIn, ref dataOut);
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (enReturnCode != enReturnCode.e_BIOS_INVALID_COMMAND_TYPE)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return enReturnCode;
    }

    protected uint CallBios(enBIOSCommands eCmd, enBIOSCommandTypes eCmdType, int iSizeIn, int iSizeOut, ref uint iRetCode, byte[] abyDataIn, ref byte[] abyDataOut)
    {
      int A_1 = 16;
label_2:
      iRetCode = 0U;
      int num1 = iSizeIn;
      int num2 = iSizeOut;
      byte[] numArray1 = (byte[]) null;
      byte[] numArray2 = (byte[]) null;
      byte[] numArray3 = abyDataIn;
      int num3 = 14;
      byte[] numArray4 = null;
      object lpVarDataOut= null;
      int num4 = 0;
      int index1= 0;
      object lpVarDataIn= null;
      int index2 = 0;
      while (true)
      {
        switch (num3)
        {
          case 0:
            lpVarDataOut = (object) numArray4;
            num4 = 0;
            num3 = 16;
            continue;
          case 1:
            lpVarDataIn = (object) numArray3;
            numArray4 = abyDataOut;
            num3 = 13;
            continue;
          case 2:
          case 7:
            num3 = 12;
            continue;
          case 3:
            numArray3 = new byte[iSizeIn];
            num3 = 1;
            continue;
          case 4:
          case 9:
            num3 = 11;
            continue;
          case 5:
            if (num4 >= 3)
            {
              num3 = 10;
              continue;
            }
            try
            {
              int num5 = 3;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    this.A.hpqExecMethodEx((uint) eCmd, (uint) eCmdType, (uint) iSizeIn, (uint) iSizeOut, out iRetCode, ref lpVarDataIn, ref lpVarDataOut);
                    num5 = 4;
                    continue;
                  case 1:
                    abyDataOut = (byte[]) lpVarDataOut;
                    num5 = 2;
                    continue;
                  case 2:
                    num5 = 5;
                    continue;
                  case 4:
                    if (((int) iRetCode & (int) ushort.MaxValue) == 0)
                    {
                      num5 = 1;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    goto label_45;
                  default:
                    if (this.A != null)
                    {
                      num5 = 0;
                      continue;
                    }
                    goto label_31;
                }
              }
label_31:
              throw new Exception(Module.a("ŕᕗፙ籛\x0D5D՟ၡባཥ୧ཀྵ䱫mὯٱ味ཱུᵷ\x0E79屻ώ\xF67F\xE381\xED83\xEA85\xE987\xE889\xE08B\xEB8D", A_1));
            }
            catch (Exception ex)
            {
              if (num4 >= 3)
              {
                iRetCode = 0U;
                string message = ex.Message;
                goto case 16;
              }
              else
              {
                Thread.Sleep(500);
                iSizeIn = num1;
                iSizeOut = num2;
                iRetCode = 597U;
                numArray4 = (byte[]) null;
                numArray3 = (byte[]) null;
                numArray3 = new byte[numArray1.Length];
                for (int index3 = 0; index3 < numArray1.Length; ++index3)
                  numArray3[index3] = numArray1[index3];
                numArray4 = new byte[numArray2.Length];
                for (int index3 = 0; index3 < numArray2.Length; ++index3)
                  numArray4[index3] = numArray2[index3];
                lpVarDataIn = (object) numArray3;
                lpVarDataOut = (object) numArray4;
                goto case 16;
              }
            }
            finally
            {
              ++num4;
            }
          case 6:
            numArray2 = new byte[numArray4.Length];
            index1 = 0;
            num3 = 4;
            continue;
          case 8:
            numArray1 = new byte[numArray3.Length];
            index2 = 0;
            num3 = 2;
            continue;
          case 10:
            goto label_45;
          case 11:
            if (index1 >= numArray2.Length)
            {
              num3 = 0;
              continue;
            }
            numArray2[index1] = numArray4[index1];
            ++index1;
            num3 = 9;
            continue;
          case 12:
            if (index2 >= numArray1.Length)
            {
              num3 = 6;
              continue;
            }
            numArray1[index2] = numArray3[index2];
            ++index2;
            num3 = 7;
            continue;
          case 13:
            if (numArray4 == null)
            {
              num3 = 15;
              continue;
            }
            goto case 8;
          case 14:
            if (numArray3 == null)
            {
              num3 = 3;
              continue;
            }
            goto case 1;
          case 15:
            numArray4 = new byte[ (uint) iSizeOut];
            if (1 == 0)
              ;
            num3 = 8;
            continue;
          case 16:
            num3 = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_45:
      return iRetCode;
    }
  }
}
