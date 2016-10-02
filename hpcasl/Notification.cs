// Decompiled with JetBrains decompiler
// Type: hpCasl.Notification
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using GenericPolicy;
using hpCasl.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;

namespace hpCasl
{
  public static class Notification
  {
    private static CaslPolicy globalToasterPolicy;
    private static CaslPolicy currentToasterPolicy;
    private static CaslPolicy globalSigningPolicy;

    private static bool NotificationEnabled
    {
      get
      {
label_2:
        bool flag = true;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (!Notification.globalToasterPolicy.AllowToasterNotification)
              {
                num = 4;
                continue;
              }
              goto case 3;
            case 1:
              flag = false;
              num = 2;
              continue;
            case 2:
              goto label_11;
            case 3:
              num = 5;
              continue;
            case 4:
              flag = false;
              num = 3;
              continue;
            case 5:
              if (!Notification.currentToasterPolicy.AllowToasterNotification)
              {
                if (1 == 0)
                  ;
                num = 1;
                continue;
              }
              goto label_11;
            default:
              goto label_2;
          }
        }
label_11:
        return flag;
      }
    }

    private static string ProgramFilesx86
    {
      get
      {
        int A_1 = 12;
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(Casl.a("\xD988\xD98A슌첎풐삒요\xD896쮘쒚\xDC9C춞\xE2A0\xEBA2\xECA4\xF3A6\xECA8ﲪ鮬鮮芰膲", A_1))))
              {
                num = 1;
                continue;
              }
              goto label_9;
            case 1:
              goto label_5;
            case 2:
              num = 0;
              continue;
            default:
              if (1 == 0)
                ;
              if (8 != IntPtr.Size)
              {
                num = 2;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return Environment.GetEnvironmentVariable(Casl.a("\xD988力\xE28C\xE88E\xE390\xF292\xF894톖\xF098\xF79A\xF89C\xEC9E覠\xDBA2鶤醦肨", A_1));
label_9:
        return Environment.GetEnvironmentVariable(Casl.a("\xD988力\xE28C\xE88E\xE390\xF292\xF894톖\xF098\xF79A\xF89C\xEC9E", A_1));
      }
    }

    private static string CaslNotificationPath
    {
      get
      {
        return Notification.ProgramFilesx86 + Casl.a("\xDD80쮂\xE084\xF086\xE588\xEE8A歷ﮎ벐쎒\xF494\xF496\xF298漢\xEF9Cﮞﶠ\xF0A2춤욦\xDBA8캪즬\xF3AE\xD9B0쎲\xF6B4횶쪸ힺ\xF3BC킾뗀ꫂꏄ껆\xAAC8\xAACA만ꛎ뻐뷒ﯔ닖ꇘ뻚", 4);
      }
    }

    static Notification()
    {
      if (1 == 0)
        ;
      Notification.globalToasterPolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyToaster);
      Notification.currentToasterPolicy = new CaslPolicy(Policy.enPolicyType.Current, Resources.PolicyToaster);
      Notification.globalSigningPolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicySigning);
    }

    public static enReturnCode PopUp(ref uint uiIdentity, string sIconPath, string sTitle, string sText, string sPath, string sParameters)
    {
      int A_1 = 10;
label_2:
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("풆ﶈ\xEA8Aﾌﮎ\xF490\xF792", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Random random = new Random();
      int num1 = 13;
      while (true)
      {
        switch (num1)
        {
          case 0:
            Global.Log.ErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("캆\xE788ﶊ\xEC8C\xE38E\xF890\xF792떔ﺖ滛\xF49A\xF39C", A_1));
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 11;
            continue;
          case 1:
            goto label_11;
          case 2:
            if (!string.IsNullOrEmpty(sIconPath))
            {
              num1 = 8;
              continue;
            }
            goto case 11;
          case 3:
            num1 = 17;
            continue;
          case 4:
            num1 = 5;
            continue;
          case 5:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            goto label_55;
          case 6:
            num1 = 12;
            continue;
          case 7:
            if (!File.Exists(sIconPath))
            {
              num1 = 0;
              continue;
            }
            goto case 11;
          case 8:
            num1 = 7;
            continue;
          case 9:
            uiIdentity = (uint) random.Next();
            num1 = 6;
            continue;
          case 10:
            if (1 == 0)
              ;
            if (string.IsNullOrEmpty(sText))
            {
              num1 = 14;
              continue;
            }
            goto case 19;
          case 11:
            num1 = 18;
            continue;
          case 12:
            if (!string.IsNullOrEmpty(sTitle))
            {
              num1 = 16;
              continue;
            }
            goto case 14;
          case 13:
            if ((int) uiIdentity == 0)
            {
              num1 = 9;
              continue;
            }
            goto case 6;
          case 14:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            Global.Log.ErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("캆\xE788ﶊ\xEC8C\xE38E\xF890\xF792떔쎖\xF098\xF79A\xF89C뾞캠톢薤\xF3A6첨펪\xD9AC", A_1));
            num1 = 19;
            continue;
          case 15:
            Global.Log.ErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("캆\xE788ﶊ\xEC8C\xE38E\xF890\xF792떔튖\xE198ﺚﺜ\xEA9E햠슢잤쮦첨讪ﶬ캮얰\xDBB2", A_1));
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num1 = 4;
            continue;
          case 16:
            num1 = 10;
            continue;
          case 17:
            if (!File.Exists(sPath))
            {
              num1 = 15;
              continue;
            }
            goto case 4;
          case 18:
            if (!string.IsNullOrEmpty(sPath))
            {
              num1 = 3;
              continue;
            }
            goto case 4;
          case 19:
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      try
      {
label_13:
        string str1 = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        string str5 = "";
        int num2 = 9;
        while (true)
        {
          switch (num2)
          {
            case 0:
              if (sParameters != "")
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            case 1:
              string str6 = Casl.a("뮆삈쾊뎌", A_1) + uiIdentity.ToString() + Casl.a("뮆Ꚉ슊즌놎", A_1);
              string str7 = str1 + str2 + str3 + str6 + str4 + str5;
              enReturnCode = Notification.SendNotification(Casl.a("뮆\xE188ﮊ쎌\xE08E\xE590朗\xF394ﺖ滛漢\xE99C\xF69E캠춢鮤鮦ﶨ쒪첬\xDCAE얰趲", A_1) + str7 + Casl.a("뮆Ꚉ\xDF8A\xE28C\xEE8E\xE290\xE792\xAB94\xAB96뚘\xF39A\xED9C톞캠힢첤솦삨좪첬\xDBAE\xD8B0\xDCB2\xDBB4覶", A_1));
              num2 = 8;
              continue;
            case 2:
              str4 = Casl.a("뮆\xD988\xEA8A歷\xE78E꾐", A_1) + Notification.MakeSafe(sPath) + Casl.a("뮆Ꚉ\xDB8A\xEC8Cﮎ戀궒", A_1);
              num2 = 4;
              continue;
            case 3:
              num2 = 7;
              continue;
            case 4:
              num2 = 0;
              continue;
            case 5:
              num2 = 13;
              continue;
            case 6:
              str5 = Casl.a("뮆\xD988\xEA8Aﾌ\xEE8Eﲐ\xF692\xE194\xF296\xEB98\xE89Aꎜ", A_1) + Notification.MakeSafe(sParameters) + Casl.a("뮆Ꚉ\xDB8A\xEC8Cﶎ\xF090ﺒ\xF094\xE396ﲘ\xE99A\xEE9Cꆞ", A_1);
              num2 = 1;
              continue;
            case 7:
              if (sPath != "")
              {
                num2 = 2;
                continue;
              }
              goto case 4;
            case 8:
              goto label_55;
            case 9:
              if (sTitle != "")
              {
                num2 = 15;
                continue;
              }
              goto case 14;
            case 10:
              str3 = Casl.a("뮆삈\xE88A\xE28C\xE18E손\xF292\xE194ﾖ\xA798", A_1) + Notification.MakeSafe(sIconPath) + Casl.a("뮆Ꚉ슊\xEE8C\xE08Eﾐ쎒\xF494\xE396\xF198ꖚ", A_1);
              num2 = 3;
              continue;
            case 11:
              if (sText != "")
              {
                num2 = 12;
                continue;
              }
              goto case 5;
            case 12:
              str2 = Casl.a("뮆\xDD88\xEE8A\xF58Cﮎ꾐", A_1) + Notification.MakeSafe(sText) + Casl.a("뮆Ꚉ\xDF8A\xE88C\xF78E\xE590궒", A_1);
              num2 = 5;
              continue;
            case 13:
              if (sIconPath != "")
              {
                num2 = 10;
                continue;
              }
              goto case 3;
            case 14:
              num2 = 11;
              continue;
            case 15:
              str1 = Casl.a("뮆\xDD88\xE28A歷\xE38E\xF490궒", A_1) + Notification.MakeSafe(sTitle) + Casl.a("뮆Ꚉ\xDF8A\xE48Cﮎ\xFD90\xF692\xAB94", A_1);
              num2 = 14;
              continue;
            default:
              goto label_13;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("욆\xE788\xAB8A좌\xF78E\xF290\xF692\xE594\xE396\xF098\xF49A\xF39C뾞캠삢욤튦\xDBA8\xD9AA좬쮮记좲薴쪶", A_1), (object) ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_55:
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("힆\xE688ﮊ\xD88Cﾎ", A_1), Casl.a("쒆\xE688\xE68Aﶌ\xE38E\xF490\xE792\xF094\xF396", A_1));
      return enReturnCode;
    }

    public static enReturnCode ProgressBar(ref uint uiIdentity, uint Percentage, string LeftIconPath, string RightIconPath)
    {
      int A_1 = 1;
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\x2E7D\xF27F\xED81\xE383\xF485\xED87黎ﾋ첍\xF18F\xE091", A_1), Casl.a("\x2D7D\xF47F\xE381\xF683\xF285\xED87\xEE89", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      try
      {
        int num = 0;
        string str1 = null;
        string str2 = null;
        string str3 = null;
        while (true)
        {
          switch (num)
          {
            case 1:
              string str4 = Casl.a("䉽큿\xF081\xEB83\xE185慎\xEF89ﾋﶍ튏\xF391\xE693ꢕ", A_1) + str3 + str1 + str2 + Casl.a("䉽꽿튁\xF683\xE985\xEF87\xF889\xE98Bﶍ\xE38F킑\xF593\xE495ꚗ", A_1);
              enReturnCode = Notification.SendNotification(Casl.a("䉽\xE87F\xF281쪃\xE985ﲇ\xE389\xEA8B\xE78D\xF38F\xF391\xE093ﾕ\xF797\xF499ꊛ", A_1) + str4 + Casl.a("䉽꽿\xEA81\xF483종\xE787ﺉ\xE58B\xE88D憐\xF191\xF593\xE295\xF197\xF599\xF29Bꂝ", A_1));
              num = 9;
              continue;
            case 2:
              if (LeftIconPath != "")
              {
                num = 8;
                continue;
              }
              goto case 5;
            case 3:
            case 9:
              num = 7;
              continue;
            case 4:
              if (1 == 0)
                ;
              str2 = Casl.a("䉽퉿\xEB81\xE383\xEE85ﲇ쎉\xEF8B\xE18Dﺏ슑\xF593\xE295\xF097꒙", A_1) + Notification.MakeSafe(RightIconPath) + Casl.a("䉽꽿킁\xED83\xE185\xE087ﺉ얋\xED8Dﾏﲑ쒓\xF795\xEC97\xF299ꊛ", A_1);
              num = 1;
              continue;
            case 5:
              num = 10;
              continue;
            case 6:
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
              num = 3;
              continue;
            case 7:
              goto label_18;
            case 8:
              str1 = Casl.a("䉽챿\xE781\xE283\xF285솇\xE989\xE38B\xE08D삏\xF391\xE093ﺕꚗ", A_1) + Notification.MakeSafe(LeftIconPath) + Casl.a("䉽꽿캁\xE183\xE085ﲇ쎉\xEF8B\xE18Dﺏ슑\xF593\xE295\xF097꒙", A_1);
              num = 5;
              continue;
            case 10:
              if (RightIconPath != "")
              {
                num = 4;
                continue;
              }
              goto case 1;
            default:
              if (Percentage > 100U)
              {
                num = 6;
                continue;
              }
              str1 = "";
              str2 = "";
              str3 = Casl.a("䉽큿\xE781\xF683\xE585\xED87\xE489\xF88B\xEF8D\xF78F\xF791ꪓ", A_1) + (object) Percentage + Casl.a("䉽꽿튁\xE183\xF485\xEB87\xEF89\xE28B揄\xF18F\xF591\xF193ꢕ", A_1);
              num = 2;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\x2E7D\xEF7F\xF281톃\xF685", A_1), Casl.a("㽽\xEE7Fꊁ솃ﺅ\xEB87\xEF89ﲋ揄憐\xFD91望뚕\xF797蓮ﾛ\xEB9D튟킡솣슥銧톩鲫펭", A_1), (object) ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_18:
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\x2E7D\xF27F\xED81\xE383\xF485\xED87黎ﾋ첍\xF18F\xE091", A_1), Casl.a("㵽\xEF7F\xEF81\xF483\xEA85\xED87ﺉ\xE98B\xEA8D", A_1));
      return enReturnCode;
    }

    public static enReturnCode MultiIcon(ref uint uiIdentity, string LeftIconPath, string MiddleIconPath, string RightIconPath)
    {
      int A_1 = 10;
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쪆ﲈ\xE78A歷\xE68E\xD890\xF092杖練", A_1), Casl.a("풆ﶈ\xEA8Aﾌﮎ\xF490\xF792", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      try
      {
label_3:
        Random random = new Random();
        int num = 0;
        string str1 = string.Empty;
        string str2 = string.Empty; ;
        string str3 = string.Empty; ;
        while (true)
        {
          switch (num)
          {
            case 0:
              if ((int) uiIdentity == 0)
              {
                num = 2;
                continue;
              }
              goto case 7;
            case 1:
              string str4 = Casl.a("뮆삈쾊뎌", A_1) + uiIdentity.ToString() + Casl.a("뮆Ꚉ슊즌놎", A_1) + str1 + str2 + str3;
              enReturnCode = Notification.SendNotification(Casl.a("뮆\xE188ﮊ쎌\xE08E\xE590朗\xF394ﺖ滛漢\xE99C\xF69E캠춢鮤鮦\xE4A8\xDEAA솬\xDBAE\xD8B0者횴\xD8B6ힸ薺", A_1) + str4 + Casl.a("뮆Ꚉ욊\xF88C\xE38E\xE590朗\xDC94\xF496\xF698\xF59Aꎜꎞ躠쮢햤\xE9A6욨\xDFAA쒬즮\xD8B0킲풴쎶킸풺펼膾", A_1));
              num = 5;
              continue;
            case 2:
              uiIdentity = (uint) random.Next();
              num = 7;
              continue;
            case 3:
              if (MiddleIconPath != "")
              {
                num = 9;
                continue;
              }
              goto case 10;
            case 4:
              str3 = Casl.a("뮆\xDB88\xE28A\xEA8C\xE78E\xE590\xDA92\xF694\xF896\xF798쮚ﲜ\xEB9E즠鶢", A_1) + Notification.MakeSafe(RightIconPath) + Casl.a("뮆Ꚉ\xD98A\xE48C\xE88E戀\xE792\xDC94\xF496\xF698\xF59A출ﺞ햠쮢鮤", A_1);
              num = 1;
              continue;
            case 5:
              goto label_21;
            case 6:
              str1 = Casl.a("뮆얈\xEE8A\xEB8Cﮎ\xD890\xF092杖練즘漢\xE99C\xF79E龠", A_1) + Notification.MakeSafe(LeftIconPath) + Casl.a("뮆Ꚉ잊\xE88C\xE98E\xE590\xDA92\xF694\xF896\xF798쮚ﲜ\xEB9E즠鶢", A_1);
              num = 8;
              continue;
            case 7:
              str1 = "";
              str2 = "";
              str3 = "";
              num = 12;
              continue;
            case 8:
              num = 3;
              continue;
            case 9:
              str2 = Casl.a("뮆쒈\xE28A\xE98C\xEB8E\xFD90\xF692\xDC94\xF496\xF698\xF59A출ﺞ햠쮢鮤", A_1) + Notification.MakeSafe(MiddleIconPath) + Casl.a("뮆Ꚉ욊\xE48C\xEB8E\xF590ﾒ\xF094\xDE96滛\xF49A\xF39C쾞삠힢춤馦", A_1);
              num = 10;
              continue;
            case 10:
              num = 11;
              continue;
            case 11:
              if (RightIconPath != "")
              {
                num = 4;
                continue;
              }
              goto case 1;
            case 12:
              if (LeftIconPath != "")
              {
                num = 6;
                continue;
              }
              goto case 8;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쪆ﲈ\xE78A歷\xE68E\xD890\xF092杖練", A_1), Casl.a("욆\xE788\xAB8A좌\xF78E\xF290\xF692\xE594\xE396\xF098\xF49A\xF39C뾞캠삢욤튦\xDBA8\xD9AA좬쮮记좲薴쪶", A_1), (object) ex.Message);
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_21:
      if (1 == 0)
        ;
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쪆ﲈ\xE78A歷\xE68E\xD890\xF092杖練", A_1), Casl.a("쒆\xE688\xE68Aﶌ\xE38E\xF490\xE792\xF094\xF396", A_1));
      return enReturnCode;
    }

    private static enReturnCode SendNotification(string sParameter)
    {
      int A_1 = 16;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (Notification.NotificationEnabled)
            {
              num1 = 3;
              continue;
            }
            goto label_35;
          case 1:
            if (!Win32Notification.Send(sParameter))
            {
              num1 = 4;
              continue;
            }
            goto label_35;
          case 2:
            num1 = 0;
            continue;
          case 3:
            num1 = 1;
            continue;
          case 4:
            goto label_6;
          case 5:
            if (1 == 0)
              ;
            if (Win32Notification.WTSGetActiveConsoleSessionId() == Process.GetCurrentProcess().SessionId)
            {
              num1 = 2;
              continue;
            }
            goto label_35;
          default:
            goto label_2;
        }
      }
label_6:
      try
      {
label_8:
        sParameter = Casl.a("꾌", A_1) + sParameter + Casl.a("꾌", A_1);
        Process process = new Process();
        process.StartInfo.FileName = Notification.CaslNotificationPath;
        process.StartInfo.Arguments = sParameter;
        int num2 = 16;
        while (true)
        {
          switch (num2)
          {
            case 0:
              enReturnCode = enReturnCode.e_OK;
              num2 = 13;
              continue;
            case 1:
            case 5:
            case 13:
              num2 = 4;
              continue;
            case 2:
            case 12:
            case 15:
              num2 = 11;
              continue;
            case 3:
              if (!process.Start())
              {
                enReturnCode = enReturnCode.e_NOTIFICATION_FAILED;
                num2 = 5;
                continue;
              }
              num2 = 0;
              continue;
            case 4:
              goto label_35;
            case 6:
              num2 = 3;
              continue;
            case 7:
              enReturnCode = enReturnCode.e_OK;
              num2 = 12;
              continue;
            case 8:
              num2 = 10;
              continue;
            case 9:
              if (Validate.IsValidSignature(Notification.CaslNotificationPath))
              {
                num2 = 7;
                continue;
              }
              enReturnCode = enReturnCode.e_INVALID_HP_SIGNATURE;
              num2 = 15;
              continue;
            case 10:
              num2 = Notification.globalSigningPolicy.AllowUnsignedAssemblies ? 9 : 14;
              continue;
            case 11:
              if (enReturnCode == enReturnCode.e_OK)
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            case 14:
              enReturnCode = enReturnCode.e_OK;
              num2 = 2;
              continue;
            case 16:
              if (File.Exists(Notification.CaslNotificationPath))
              {
                num2 = 8;
                continue;
              }
              enReturnCode = enReturnCode.e_MISSING_COMPONENT;
              num2 = 1;
              continue;
            default:
              goto label_8;
          }
        }
      }
      catch
      {
        enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
      }
label_35:
      return enReturnCode;
    }

    private static string MakeSafe(string str)
    {
      string str1 = str;
      try
      {
        str1 = SecurityElement.Escape(str);
      }
      catch
      {
      }
      if (1 == 0)
        ;
      return str1;
    }
  }
}
