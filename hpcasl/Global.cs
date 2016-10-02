// Decompiled with JetBrains decompiler
// Type: hpCasl.Global
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using GenericPolicy;
using hpCasl.Properties;
using System;
using System.Diagnostics;
using System.Reflection;

namespace hpCasl
{
  public static class Global
  {
    internal static CaslLog Log;
    private static bool? allowSecured;

    public static bool AllowSecured
    {
      get
      {
        if (!Global.allowSecured.HasValue)
          Global.allowSecured = new bool?(Global.CheckforValidSignature());
        return Global.allowSecured.Value;
      }
    }

    private static string LogFile
    {
      get
      {
        int A_1 = 8;
label_2:
        string str1 = (string) null;
        string str2 = (string) null;
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (1 == 0)
                ;
              str2 = Environment.ExpandEnvironmentVariables(Casl.a("ꂄ\xE686麗ﮊ\xE98C\xEE8E\xE590\xF292낔쮖\xF198\xEB9A\xEC9C\xF39E캠쒢捻쒦좨\xD8AA솬쎮\xDEB0풲운馶솸횺톼", A_1));
              num = 3;
              continue;
            case 1:
              try
              {
                str1 = Process.GetCurrentProcess().ProcessName;
              }
              catch
              {
                str1 = (string) null;
              }
              num = 2;
              continue;
            case 2:
              if (str1 == null)
              {
                num = 0;
                continue;
              }
              str2 = Environment.ExpandEnvironmentVariables(Casl.a("ꂄ\xE686麗ﮊ\xE98C\xEE8E\xE590\xF292낔쮖\xF198\xEB9A\xEC9C\xF39E캠쒢捻쒦좨\xD8AA솬쎮\xDEB0풲운\xE8B6", A_1) + Process.GetCurrentProcess().ProcessName + Casl.a("\xAB84ﾆ\xE488\xE78A", A_1));
              num = 4;
              continue;
            case 3:
            case 4:
              goto label_11;
            default:
              goto label_2;
          }
        }
label_11:
        return str2;
      }
    }

    static Global()
    {
      int A_1 = 1;
      if (1 == 0)
        ;
      Global.Log = new CaslLog(Global.LogFile);
      Global.allowSecured = new bool?();
      Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("㥽\xEC7F\xED81\xE683\xE785\xE487", A_1), Casl.a("\x2D7D\xF47F\xE381\xF683\xF285\xED87\xEE89", A_1));
      Global.GetInformation();
      Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("㥽\xEC7F\xED81\xE683\xE785\xE487", A_1), Casl.a("㵽\xEF7F\xEF81\xF483\xEA85\xED87ﺉ\xE98B\xEA8D", A_1));
    }

    private static void GetInformation()
    {
      int A_1 = 17;
      if (1 == 0)
        ;
      string sMessage1 = Casl.a("춍톏솑\xD893뚕캗ﾙ\xEE9B\xED9D즟춡쪣鲥袧", A_1) + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
      Global.Log.InformationMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("즍\xF58F\xE691\xDD93\xF895ﺗ\xF599\xEE9B\xF39D솟횡춣즥욧", A_1), sMessage1);
     // CaslPolicy caslPolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation);
 //     string sMessage2 = Casl.a("쮍ﶏ\xE791\xF893\xF795\xEC97\xF399\xF39B\xF09D骟芡", A_1) + (caslPolicy.AllowEmulation ? 1 : 0);
   //   Global.Log.InformationMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("즍\xF58F\xE691\xDD93\xF895ﺗ\xF599\xEE9B\xF39D솟횡춣즥욧", A_1), sMessage2);
    }

    private static bool CheckforValidSignature()
    {
      int A_1 = 0;
label_2:
      CaslPolicy caslPolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicySigning);
      bool flag = false;
      string sFile = (string) null;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = !Validate.IsValidSignature(sFile) ? 4 : 3;
            continue;
          case 1:
            try
            {
              sFile = Process.GetCurrentProcess().MainModule.FileName;
            }
            catch
            {
              sFile = Casl.a("啼⩾\xEF80\xE882\xEB84\xE886ﺈ\xE58Aꒌ", A_1);
            }
            if (1 == 0)
              ;
            num = 0;
            continue;
          case 2:
          case 5:
          case 7:
            goto label_13;
          case 3:
            flag = true;
            num = 2;
            continue;
          case 4:
            if (caslPolicy.AllowUnsignedAssemblies)
            {
              num = 6;
              continue;
            }
            string sFormat = Casl.a("㹼Ṿ\xED80\xEF82\xEC84\xE986\xEE88\xAB8Aﶌﶎﺐ\xF092\xF094\xE496\xEA98뮚", A_1) + sFile + Casl.a("嵼\x1B7E\xEE80\xE682\xF684Ꞇ\xE788\xE48A歷꾎戀\xF292\xE394\xF296릘漢붜\xE99E삠쾢첤쎦覨\xD8AA쒬좮\xDFB0튲솴슶쮸\xDEBA鎼龾觀鏂\xE5C4蓆裈飊臌\xEFCE뷐볒듔돖냘뗚뫜\xFFDE胠臢諤闦鷨軪觬", A_1);
            Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("㩼\x1A7E\xF580쪂\xEB84\xE186\xE688力\xE08C\xEE8E\xE590朗杖練", A_1), sFormat);
            flag = false;
            num = 5;
            continue;
          case 6:
            string str = Casl.a("㕼⽾ꆀ삂\xEA84\xEA86\xE488\xE48A\xE38C꾎킐\xF092\xF694\xF296\xEA98\xE89A붜펞좠솢\xD7A4욦\xDBA8튪趬잮킰삲閴햶\xDCB8\xDEBA펼龾ꃀꃂꛄꋆ뫈룊\xA8CCꯎ\xF1D0뇒곔\xF7D6룘뗚\xFDDC꫞迠郢賤胦蟨軪觬쿮臰臲髴银鳸裺軼엾℀", A_1) + sFile;
            Global.Log.FormatWarningMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("㹼\x177E\xE480\xE082\xEE84\xE186\xE688力\xDB8C\xEE8E\xFD90朗\xF194쒖\xF098ﲚ\xF39Cﺞ햠횢\xD7A4슦", A_1), str);
            GenericLog.Log.LogToEventLog(str, EventLogEntryType.Warning, 4101);
            flag = true;
            num = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_13:
      return flag;
    }
  }
}
