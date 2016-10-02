// Decompiled with JetBrains decompiler
// Type: CaslWmi.WmiBios
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using hpCasl;
using System;
using System.Management;

namespace CaslWmi
{
  public class WmiBios
  {
    private static byte[] E = new byte[4]
    {
      (byte) 83,
      (byte) 69,
      (byte) 67,
      (byte) 85
    };
    private CaslLog A = new CaslLog(Constants.LogFile);
    private bool B;
    private ManagementObject C;
    private ManagementClass D;

    private bool BSupportedSystem
    {
      get
      {
        return this.B;
      }
      set
      {
        this.B = value;
      }
    }

    public WmiBios()
    {
      this.BSupportedSystem = this.InitMgmtClassObjects();
    }

    private bool A1()
    {
      int A_1 = 19;
      bool flag = false;
      try
      {
label_3:
        ManagementObjectCollection objectCollection = new ManagementObjectSearcher(new ManagementScope(Module.a("\x0558ݚ獜͞፠ౢ\x0A64፦㕨㱪\x206C♮", A_1)), new ObjectQuery(Module.a("\x0A58Ṛᅜᩞ≠㝢䕤䵦䥨\x2D6A㽬\x206E㱰卲ᵴݶ\x0878㥺㑼ᅾ\xF580캂", A_1))).Get();
        if (1 == 0)
          ;
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_10;
            case 1:
              flag = true;
              num = 3;
              continue;
            case 2:
              if (objectCollection.Count > 0)
              {
                num = 1;
                continue;
              }
              goto case 3;
            case 3:
              num = 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (ManagementException ex)
      {
        this.A.ErrorMessage(this.GetType().ToString() + Module.a("ᑘ㩚㍜㹞٠٢\x0864ɦݨὪ⡬ᝮተᙲմͶၸᑺ\x137C彾즀\xE282\xF684Ꞇ\xE688\xE88A\xEE8C搜\xE390\xE192\xF094\xF396릘", A_1) + ex.Message);
      }
label_10:
      return flag;
    }

    public bool InitMgmtClassObjects()
    {
      int A_1 = 4;
      this.BSupportedSystem = this.A1();
      try
      {
        int num1 = 5;
        
        ManagementObjectCollection.ManagementObjectEnumerator enumerator= null;
        while (true)
        {
          switch (num1)
          {
            case 0:
              try
              {
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      num2 = 3;
                      continue;
                    case 3:
                      goto label_20;
                    case 4:
                      if (!enumerator.MoveNext())
                      {
                        num2 = 1;
                        continue;
                      }
                      this.C = (ManagementObject) enumerator.Current;
                      this.C.Get();
                      num2 = 0;
                      continue;
                    default:
                      num2 = 4;
                      continue;
                  }
                }
              }
              finally
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_17;
                    case 2:
                      enumerator.Dispose();
                      num2 = 0;
                      continue;
                    default:
                      if (enumerator != null)
                      {
                        num2 = 2;
                        continue;
                      }
                      goto label_17;
                  }
                }
label_17:;
              }
label_20:
              this.D = new ManagementClass(new ManagementPath()
              {
                ClassName = Module.a("≉㱋㽍\x124Fᙑ㕓≕㥗ፙ\x325B", A_1),
                NamespacePath = Module.a("㡉⍋⅍\x244F๑⍓㭕ㅗ", A_1)
              });
              num1 = 3;
              continue;
            case 1:
              num1 = 2;
              continue;
            case 2:
              goto label_25;
            case 3:
              if (this.D == null)
              {
                num1 = 6;
                continue;
              }
              goto case 1;
            case 4:
              enumerator = new ManagementClass(new ManagementPath()
              {
                ClassName = Module.a("≉㱋㽍\x124F᭑㩓≕ᕗ", A_1),
                NamespacePath = Module.a("㡉⍋⅍\x244F๑⍓㭕ㅗ", A_1)
              }).GetInstances().GetEnumerator();
              num1 = 0;
              continue;
            case 6:
              this.BSupportedSystem = false;
              num1 = 1;
              continue;
            default:
              if (this.BSupportedSystem)
              {
                num1 = 4;
                continue;
              }
              goto case 1;
          }
        }
      }
      catch (ManagementException ex)
      {
        ex.ErrorInformation.ToString();
        this.A.ErrorMessage(this.GetType().ToString() + Module.a("݉ⵋ⁍ㅏ㕑ㅓ㭕㵗㑙⡛᭝ᡟšţᙥᱧͩͫm偯㩱ᕳյ塷ᕹύᵽ\xF57F\xF081\xF683\xE385\xEC87ꪉ", A_1) + ex.Message);
        this.BSupportedSystem = false;
      }
label_25:
      if (1 == 0)
        ;
      return this.BSupportedSystem;
    }

    public enReturnCode ExecMethod(uint eCmd, uint iCmdType, byte[] dataIn, uint iSizeIn, out byte[] dataOut, uint eSizeOut)
    {
      int A_1 = 4;
      this.A.TraceInMessage(this.GetType().ToString(), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛", A_1), Module.a("᥉㡋⽍≏♑ㅓ\x3255硗řὛㅝ\x0D5Fཡգ\x0865౧偩", A_1) + eCmd.ToString() + Module.a("ᝉ汋ᕍፏ㵑㥓㭕㥗㑙㡛繝㑟᭡ᑣͥ剧", A_1) + iCmdType.ToString() + Module.a("ᝉ汋ᕍ͏㭑\x2E53㍕硗ፙ\x325B摝", A_1) + iSizeIn.ToString() + Module.a("ᝉ汋ᕍ͏㭑\x2E53㍕硗ᕙ⥛⩝婟", A_1) + ((int) eSizeOut).ToString() + Module.a("ᝉ", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      dataOut = (byte[]) null;
      uint num1 = 0U;
      try
      {
        int num2 = 7;
        ManagementBaseObject managementBaseObject = null;
        while (true)
        {
          switch (num2)
          {
            case 0:
            case 5:
            case 6:
              num2 = 2;
              continue;
            case 1:
              ManagementObject instance = this.D.CreateInstance();
              instance[Module.a("᥉╋⥍㹏", A_1)] = (object) WmiBios.E;
              instance[Module.a("ॉ⍋⍍㵏㍑㩓\x3255", A_1)] = (object) eCmd;
              instance[Module.a("ॉ⍋⍍㵏㍑㩓\x3255\x0C57⍙ⱛ㭝", A_1)] = (object) iCmdType;
              instance[Module.a("᥉╋㑍㕏", A_1)] = (object) iSizeIn;
              instance[Module.a("≉㱋㽍\x124Fᙑ㕓≕㥗", A_1)] = (object) dataIn;
              string methodName = Module.a("≉㱋㽍\x124F᭑᭓Օᅗ㑙⡛", A_1) + eSizeOut.ToString();
              ManagementBaseObject methodParameters = this.C.GetMethodParameters(methodName);
              methodParameters[Module.a("͉≋੍ㅏ♑㕓", A_1)] = (object) instance;
              managementBaseObject = (ManagementBaseObject) this.C.InvokeMethod(methodName, methodParameters, (InvokeMethodOptions) null)[Module.a("Չ㥋㩍ᑏ㍑⁓㝕", A_1)];
              num1 = (uint) managementBaseObject[Module.a("㡉㭋ᱍ㕏♑\x2153\x2455㙗ᥙ㍛㩝՟", A_1)];
              num2 = 3;
              continue;
            case 2:
              goto label_17;
            case 3:
              if ((int) num1 == 0)
              {
                num2 = 4;
                continue;
              }
              this.A.FormatErrorMessage(this.GetType().ToString(), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛", A_1), Module.a("ॉ⅋⩍я⭑\x2453㍕扗穙❛湝\x1D5F乡䑣ᑥ൧ṩᥫᱭṯ\x1771ၳ噵ͷ䭹Ż", A_1), (object) iCmdType.ToString(Module.a("\x1249", A_1)), (object) num1.ToString(Module.a("\x1249", A_1)));
              enReturnCode = (enReturnCode) num1;
              num2 = 6;
              continue;
            case 4:
              num2 = 8;
              continue;
            case 8:
              if ((int) eSizeOut != 0)
              {
                num2 = 9;
                continue;
              }
              goto case 0;
            case 9:
              dataOut = (byte[]) managementBaseObject[Module.a("้ⵋ㩍ㅏ", A_1)];
              num2 = 5;
              continue;
            default:
              if (this.BSupportedSystem)
              {
                num2 = 1;
                continue;
              }
              enReturnCode = enReturnCode.e_BIOS_WMI_NOT_SUPPORTED;
              num2 = 0;
              continue;
          }
        }
      }
      catch (ManagementException ex)
      {
        enReturnCode = enReturnCode.e_UNKNOWN;
        this.A.ErrorMessage(this.GetType().ToString(), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛", A_1), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛繝ⵟ͡\x0A63ݥཧཀྵū୭ṯٱㅳ\x0E75᭷ό\x0C7B\x0A7D\xE97F\xED81\xEA83벅ꢇ", A_1) + ex.ErrorInformation.ToString());
      }
      catch (Exception ex)
      {
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
        this.A.ErrorMessage(this.GetType().ToString(), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛", A_1), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛繝╟ᩡݣͥᡧṩիŭṯ䡱味", A_1) + ex.Message);
      }
label_17:
      if (1 == 0)
        ;
      this.A.TraceOutMessage(this.GetType().ToString(), Module.a("ཉ㑋\x2B4D㍏ὑㅓ≕し㕙㡛", A_1), Module.a("ॉ⍋⍍⁏㹑ㅓ≕㵗㹙籛⥝य़ᙡౣ履䡧", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }
  }
}
