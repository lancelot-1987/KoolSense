// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPlugin
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using CaslSmBios;
using System;
using System.Diagnostics;

namespace hpCasl
{
  internal class CommandPlugin
  {
    private Command[] A1;
    protected CaslLogger B1;
    private bool C1;
    protected string[] D1;
    protected string[] E1;
    protected string[] F1;

    public CommandPlugin()
    {
      int A_1 = 7;
      // ISSUE: explicit constructor call
      this.B1 = new CaslLogger();
      this.B1.InformationMessage(this.GetType().ToString(), hpSMBIOS.a("\xDC9E캠캢좤욦잨쾪ﶬ쎮쒰풲\xDCB4\xD9B6", A_1), hpSMBIOS.a("첞햠슢\xD7A4펦첨쾪趬첮\xD9B0횲횴\xDCB6킸햺\xDABC龾뗀ꯂꃄ\xE7C6\xAAC8\xAACAꇌꏎ룐뷒닔\xF7D6룘\xA8DA껜뫞賠臢觤黦", A_1));
      bool flag = false;
      StackTrace stackTrace = new StackTrace(true);
      int index=0;
      for (index = 0; index < stackTrace.FrameCount; ++index)
      {
        StackFrame frame = stackTrace.GetFrame(index);
        frame.GetFileName();
        string fullName = frame.GetMethod().DeclaringType.Assembly.FullName;
        if (fullName.StartsWith(hpSMBIOS.a("\xF79E토삢쒤풦얨", A_1)) && fullName.EndsWith(hpSMBIOS.a("\xA69E슠関쎤龦骨쾪颬춮蚰햲蚴펶覸芺誼", A_1)))
        {
          flag = true;
          break;
        }
      }
      this.B1.InformationMessage(this.GetType().ToString(), hpSMBIOS.a("\xDC9E캠캢좤욦잨쾪ﶬ쎮쒰풲\xDCB4\xD9B6", A_1), hpSMBIOS.a("\xDC9E캠캢햤쮦첨\xDFAA좬쮮醰킲\xDDB4튶\xDAB8킺풼톾ꛀ\xE3C2뇄꿆곈\xEBCA껌껎뷐뿒볔맖뻘ﯚ볜곞鋠蛢裤藦藨鋪췬싮\xDCF0폲틴듶飸裺釼\xD8FE℀樂瘄✆", A_1) + flag.ToString() + hpSMBIOS.a("놞膠", A_1) + index.ToString() + hpSMBIOS.a("뾞토슢횤풦첨\xD8AA莬", A_1));
      this.C1 = flag;
      try
      {
        this.A1 = new Command[1]
        {
          (Command) new CommandInformation()
        };
        this.D1 = this.SupportedGetCommands();
        this.E1 = this.SupportedSetCommands();
        this.F1 = this.SupportedExecuteCommands();
      }
      catch (Exception ex)
      {
        this.A1 = (Command[]) null;
      }
    }

    private string[] A(string[] A_0, string[] A_1)
    {
      int A_1_1 = 14;
label_2:
      int index = 0;
      int num1 = 0;
      string[] strArray = (string[]) null;
      int num2 = 0;
      while (true)
      {
        switch (num2)
        {
          case 0:
            if (A_0 != null)
            {
              if (1 == 0)
                ;
              num2 = 2;
              continue;
            }
            goto case 5;
          case 1:
            if (A_1 != null)
            {
              num2 = 3;
              continue;
            }
            goto label_6;
          case 2:
            index = A_0.Length;
            num2 = 5;
            continue;
          case 3:
            num1 = A_1.Length;
            num2 = 4;
            continue;
          case 4:
            goto label_6;
          case 5:
            num2 = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      try
      {
label_8:
        strArray = new string[index + num1];
        int num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 0:
              if (index != 0)
              {
                num3 = 2;
                continue;
              }
              goto case 1;
            case 1:
              num3 = 3;
              continue;
            case 2:
              A_0.CopyTo((Array) strArray, 0);
              num3 = 1;
              continue;
            case 3:
              if (num1 != 0)
              {
                num3 = 4;
                continue;
              }
              goto case 6;
            case 4:
              A_1.CopyTo((Array) strArray, index);
              num3 = 6;
              continue;
            case 5:
              goto label_23;
            case 6:
              num3 = 5;
              continue;
            default:
              goto label_8;
          }
        }
      }
      catch (Exception ex)
      {
        this.B1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xEBA5춧\xD8A9쮫쮭", A_1_1), ex.Message);
      }
label_23:
      return strArray;
    }

    public string[] SupportedGetCommands()
    {
      int A_1 = 10;
label_2:
      string[] A_0 = (string[]) null;
      int num1 = 0;
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A1톣횥\xD8A7얩\xDEAB\xDAAD햯횱\xF3B3펵첷惡펻펽궿ꏁ\xAAC3ꋅ믇", A_1), hpSMBIOS.a("\xF1A1킣장\xDAA7\xDEA9즫쪭邯鲱骳颵", A_1));
      int num2 = 2;
      Command[] commandArray = null;
      int index = 0;
      while (true)
      {
        switch (num2)
        {
          case 0:
          case 8:
            goto label_16;
          case 1:
          case 7:
            num2 = 5;
            continue;
          case 2:
            if (this.C1)
            {
              num2 = 4;
              continue;
            }
            this.B1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A1톣횥\xD8A7얩\xDEAB\xDAAD햯횱\xF3B3펵첷惡펻펽궿ꏁ\xAAC3ꋅ", A_1), hpSMBIOS.a("\xE3A1킣튥춧잩\xDCAB\xDAAD邯욱\xDBB3隵\xDBB7\xDBB9킻튽\xE0BF\xE5C1뿃\xF6C5뗇\xEDC9\xECCB귍뿏뿑맓럕뛗뻙ﳛ뫝觟蛡쓣裥蟧黩쳫觭\x9FEF틱胳黵諷闹觻駽棿∁䜃䜅嬇䘉Ⰻ戍礏瀑易眕樗挙㈛", A_1));
            num2 = 0;
            continue;
          case 3:
            A_0 = this.D1;
            num1 = this.D1.GetLength(0);
            if (1 == 0)
              ;
            num2 = 8;
            continue;
          case 4:
            num2 = 9;
            continue;
          case 5:
            if (index < commandArray.Length)
            {
              Command command = commandArray[index];
              this.D1 = this.A(A_0, command.SupportedGetCommands());
              ++index;
              num2 = 1;
              continue;
            }
            num2 = 3;
            continue;
          case 6:
            commandArray = this.A1;
            index = 0;
            num2 = 7;
            continue;
          case 9:
            if (this.D1 == null)
            {
              num2 = 6;
              continue;
            }
            goto case 3;
          default:
            goto label_2;
        }
      }
label_16:
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A1톣횥\xD8A7얩\xDEAB\xDAAD햯횱\xF3B3펵첷惡펻펽궿ꏁ\xAAC3ꋅ믇", A_1), hpSMBIOS.a("\xE1A1쮣쮥\xD8A7용즫\xDAAD햯횱骳颵隷骹請톽떿곁ꃃﳅ", A_1) + num1.ToString() + hpSMBIOS.a("芡\xE3A3쎥\xDCA7誩\xEFAB솭\xDDAF\xDFB1햳\xD8B5\xDCB7즹鲻", A_1));
      return A_0;
    }

    public enReturnCode TypeOfGet(string sCommandName, out Type tDataOut)
    {
      int A_1 = 13;
label_2:
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataOut = (Type) null;
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A4\xDEA6\xD9A8캪\xE2AC즮\xF6B0횲솴", A_1), hpSMBIOS.a("\xF6A4펦좨\xD9AA\xD9AC쪮햰鎲\xEEB4쒶視풺킼튾ꃀ귂ꇄ视\xA8C8ꛊ\xA8CC\xF5CE", A_1) + sCommandName + hpSMBIOS.a("\xF8A4", A_1));
      int num = 9;
      while (true)
      {
        int index = 0;
        Command[] commandArray =null;
        string str = null;
        Command command = null;
        switch (num)
        {
          case 0:
            if (command.IsGetSupported(sCommandName))
            {
              num = 1;
              continue;
            }
            break;
          case 1:
            enReturnCode = command.TypeOfGet(sCommandName, out tDataOut);
            num = 8;
            continue;
          case 2:
          case 4:
            goto label_22;
          case 3:
          case 13:
            num = 6;
            continue;
          case 5:
            if (str.Length > 0)
            {
              num = 10;
              continue;
            }
            goto label_22;
          case 6:
            if (index >= commandArray.Length)
            {
              num = 12;
              continue;
            }
            command = commandArray[index];
            num = 0;
            continue;
          case 7:
            if (1 == 0)
              break;
            break;
          case 8:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 7;
              continue;
            }
            goto label_22;
          case 9:
            if (this.C1)
            {
              num = 11;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.B1.FormatErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A4\xDEA6\xD9A8캪\xE2AC즮\xF6B0횲솴", A_1), hpSMBIOS.a("\xE4A4펦\xDDA8캪사\xDFAE얰鎲솴\xD8B6馸\xD8BA\xDCBC펾귀\xE3C2\xE2C4볆杻뛊\xEACC\xEFCE닐볒룔뫖룘뗚맜\xFFDE藠諢臤쟦蟨蓪駬쿮雰鳲헴菶釸觺鋼諾昀欂┄䐆䠈堊䄌⼎紐稒眔攖砘椚搜ㄞ", A_1), (object) sCommandName);
            num = 2;
            continue;
          case 10:
            commandArray = this.A1;
            index = 0;
            num = 3;
            continue;
          case 11:
            str = sCommandName.Trim();
            num = 5;
            continue;
          case 12:
            num = 4;
            continue;
          default:
            goto label_2;
        }
        ++index;
        num = 13;
      }
label_22:
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("\xF1A4\xDEA6\xD9A8캪\xE2AC즮\xF6B0횲솴", A_1), hpSMBIOS.a("\xE6A4좦쒨\xDBAA솬쪮얰횲톴鞶\xE2B8좺ﺼ킾곀껂꓄꧆귈藊곌ꋎ듐\xE9D2", A_1) + sCommandName + hpSMBIOS.a("\xF8A4螦\xDEA8슪\xD9AC잮记鎲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public bool IsGetSecured(string sCommandName)
    {
      return false;
    }

    public bool IsGetSupported(string sCommandName)
    {
      int A_1 = 2;
      int num1 = -1;
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("펙\xEF9B\xD99D얟횡\xF7A3펥\xD8A7\xDAA9쎫\xDCAD쒯ힱ킳", A_1), hpSMBIOS.a("즙\xE89Bﾝ튟횡솣슥袧\xF1A9\xDFAB\xEDAD\xDFAF\xDFB1\xD9B3ힵ횷\xDEB9\xF2BB\xDFBD궿\xA7C1ﻃ", A_1) + sCommandName + hpSMBIOS.a("잙", A_1));
      if (sCommandName.Trim().Length > 0)
      {
        try
        {
          int num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_8;
              case 2:
                num1 = Array.IndexOf<string>(this.D1, sCommandName);
                num2 = 1;
                continue;
              case 3:
                this.D1 = this.SupportedGetCommands();
                num2 = 2;
                continue;
              default:
                if (this.D1 == null)
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
            }
          }
        }
        catch (Exception ex)
        {
          num1 = -1;
        }
      }
label_8:
      if (1 == 0)
        ;
      bool flag = num1 != -1;
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("펙\xEF9B\xD99D얟횡\xF7A3펥\xD8A7\xDAA9쎫\xDCAD쒯ힱ킳", A_1), hpSMBIOS.a("\xD999\xF39B\xF39D킟캡솣튥춧캩貫\xF5AD쎯\xF1B1\xDBB3\xDBB5햷\xDBB9튻\xDABD躿ꏁ꧃ꏅ\xF2C7", A_1) + sCommandName + hpSMBIOS.a("잙벛\xF79D펟芡\xF7A3펥\xD8A7\xDAA9쎫\xDCAD쒯ힱ킳隵邷鎹", A_1) + flag.ToString());
      return flag;
    }

    public enReturnCode Get(string sCommandName, out object dataOut)
    {
      int A_1 = 13;
label_2:
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("\xE2A4슦\xDDA8", A_1), hpSMBIOS.a("\xF6A4펦좨\xD9AA\xD9AC쪮햰鎲\xEEB4쒶視풺킼튾ꃀ귂ꇄ视\xA8C8ꛊ\xA8CC\xF5CE", A_1) + sCommandName + hpSMBIOS.a("\xF8A4", A_1));
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      dataOut = (object) null;
      int num = 4;
      int index=0;
      Command[] commandArray=null;
      string str=null;
      Command command=null;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 15:
            num = 2;
            continue;
          case 1:
            commandArray = this.A1;
            index = 0;
            num = 0;
            continue;
          case 2:
            if (index >= commandArray.Length)
            {
              num = 12;
              continue;
            }
            command = commandArray[index];
            num = 6;
            continue;
          case 3:
            ++index;
            num = 15;
            continue;
          case 4:
            if (this.C1)
            {
              num = 11;
              continue;
            }
            if (1 == 0)
              ;
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.B1.FormatErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE2A4슦\xDDA8", A_1), hpSMBIOS.a("\xE4A4펦\xDDA8캪사\xDFAE얰鎲솴\xD8B6馸\xD8BA\xDCBC펾귀\xE3C2\xE2C4볆杻뛊\xEACC\xEFCE닐볒룔뫖룘뗚맜\xFFDE藠諢臤쟦蟨蓪駬쿮雰鳲헴菶釸觺鋼諾昀欂┄䐆䠈堊䄌⼎紐稒眔攖砘椚搜ㄞ", A_1), (object) sCommandName);
            num = 14;
            continue;
          case 5:
            if (this.A1 == null)
            {
              num = 7;
              continue;
            }
            goto label_25;
          case 6:
            if (command.IsGetSupported(sCommandName))
            {
              num = 9;
              continue;
            }
            goto case 3;
          case 7:
            enReturnCode = enReturnCode.e_NULL_VALUE;
            num = 10;
            continue;
          case 8:
            if (str.Length > 0)
            {
              num = 1;
              continue;
            }
            goto case 12;
          case 9:
            enReturnCode = command.Get(sCommandName, out dataOut);
            num = 13;
            continue;
          case 10:
          case 14:
            goto label_25;
          case 11:
            str = sCommandName.Trim();
            num = 8;
            continue;
          case 12:
            num = 5;
            continue;
          case 13:
            if (enReturnCode != enReturnCode.e_OK)
            {
              num = 3;
              continue;
            }
            goto case 12;
          default:
            goto label_2;
        }
      }
label_25:
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("\xE2A4슦\xDDA8", A_1), hpSMBIOS.a("\xE6A4좦쒨\xDBAA솬쪮얰횲톴鞶\xE2B8좺ﺼ킾곀껂꓄꧆귈藊곌ꋎ듐\xE9D2", A_1) + sCommandName + hpSMBIOS.a("\xF8A4螦\xDEA8슪\xD9AC잮记鎲", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public string[] SupportedSetCommands()
    {
      return (string[]) null;
    }

    public enReturnCode TypeOfSet(string sCommandName, out Type tDataIn)
    {
      int A_1 = 4;
      if (1 == 0)
        ;
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataIn = (Type) null;
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("좛\xE79D킟잡\xEBA3삥ﮧ쾩\xD8AB", A_1), hpSMBIOS.a("쾛\xEA9D솟킡킣쎥첧誩\xF7AB\xDDAD\xF3AF\xDDB1\xD9B3\xDBB5\xD9B7풹\xD8BB\xF0BDꆿ꿁ꇃﳅ", A_1) + sCommandName + hpSMBIOS.a("솛", A_1));
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("좛\xE79D킟잡\xEBA3삥ﮧ쾩\xD8AB", A_1), hpSMBIOS.a("\xDF9B\xF19D춟튡좣쎥\xDCA7쾩좫躭\xEBAF솱\xF7B3\xD9B5햷ힹ\xDDBB킽꒿賁ꗃꯅ귇\xF0C9", A_1) + sCommandName + hpSMBIOS.a("솛뺝힟쮡킣캥銧誩", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public bool IsSetSecured(string sCommandName)
    {
      return false;
    }

    public bool IsSetSupported(string sCommandName)
    {
      int A_1 = 10;
      int num1 = -1;
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("\xEBA1힣\xF5A5춧\xDEA9ﾫ\xDBAD삯슱\xDBB3쒵첷\xDFB9\xD8BB", A_1), hpSMBIOS.a("\xF1A1킣장\xDAA7\xDEA9즫쪭邯\xE9B1잳\xF5B5ힷힹ톻\xDFBD꺿ꛁ諃\xA7C5ꗇ꿉\xF6CB", A_1) + sCommandName + hpSMBIOS.a("ﾡ", A_1));
      if (sCommandName.Trim().Length > 0)
      {
        if (1 == 0)
          ;
        try
        {
          int num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_9;
              case 2:
                num1 = Array.IndexOf<string>(this.E1, sCommandName);
                num2 = 1;
                continue;
              case 3:
                this.E1 = this.SupportedSetCommands();
                num2 = 2;
                continue;
              default:
                if (this.E1 == null)
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
            }
          }
        }
        catch (Exception ex)
        {
          num1 = -1;
        }
      }
label_9:
      bool flag = num1 != -1;
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("\xEBA1힣\xF5A5춧\xDEA9ﾫ\xDBAD삯슱\xDBB3쒵첷\xDFB9\xD8BB", A_1), hpSMBIOS.a("\xE1A1쮣쮥\xD8A7용즫\xDAAD햯횱钳\xEDB5쮷惡펻펽궿ꏁ\xAAC3ꋅ蛇ꯉꇋꯍ\xEACF", A_1) + sCommandName + hpSMBIOS.a("ﾡ蒣쾥\xDBA7誩ﾫ\xDBAD삯슱\xDBB3쒵첷\xDFB9\xD8BB麽\xE8BF\xEBC1", A_1) + flag.ToString());
      return flag;
    }

    public enReturnCode Set(string sCommandName, object dataIn)
    {
      int A_1 = 19;
label_2:
      this.B1.TraceInMessage(this.GetType().ToString(), hpSMBIOS.a("\xF8AA좬\xDBAE", A_1), hpSMBIOS.a("\xF8AA\xD9AC캮쎰잲킴펶馸\xE0BA캼ﲾ껀껂꣄ꛆ\xA7C8꿊菌껎볐뛒\xEFD4", A_1) + sCommandName + hpSMBIOS.a("\xF6AA", A_1));
      enReturnCode enReturnCode = enReturnCode.e_OK;
      Type tDataIn = (Type) null;
      int num = 10;
      Command command = null;
      Command[] commandArray=null;
      int index = 0;
      string str = null;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (tDataIn != dataIn.GetType())
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 1:
          case 21:
            num = 15;
            continue;
          case 2:
          case 23:
          case 26:
            goto label_39;
          case 3:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 27;
              continue;
            }
            goto case 1;
          case 4:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 1;
            continue;
          case 5:
            num = dataIn != null ? 0 : 9;
            continue;
          case 6:
            str = sCommandName.Trim();
            num = 12;
            continue;
          case 7:
            if (tDataIn != null)
            {
              num = 17;
              continue;
            }
            goto case 1;
          case 8:
            if (index >= commandArray.Length)
            {
              num = 11;
              continue;
            }
            command = commandArray[index];
            num = 16;
            continue;
          case 9:
            num = 13;
            continue;
          case 10:
            if (this.C1)
            {
              num = 6;
              continue;
            }
            enReturnCode = enReturnCode.e_CALLER_NOT_CASL;
            this.B1.FormatErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xF8AA좬\xDBAE", A_1), hpSMBIOS.a("\xEAAA\xD9AC\xDBAE풰\xDEB2어쎶馸쾺튼龾ꋀꋂ꧄ꯆ\xE9C8\xECCA뛌ￎ곐\xF4D2\xF5D4듖뛘뛚냜뻞迠蟢엤菦胨迪췬臮黰蟲헴郶雸\xDBFA觼韾猀氂瀄怆愈⬊丌与䈐弒㔔笖瀘礚漜縞匠娢ତ", A_1), (object) sCommandName);
            num = 19;
            continue;
          case 11:
            num = 2;
            continue;
          case 12:
            if (str.Length <= 0)
            {
              enReturnCode = enReturnCode.e_INVALID_PARAMETER;
              num = 26;
              continue;
            }
            num = 14;
            continue;
          case 13:
            if (tDataIn != typeof (void))
            {
              num = 18;
              continue;
            }
            goto case 1;
          case 14:
            enReturnCode = this.TypeOfSet(sCommandName, out tDataIn);
            num = 3;
            continue;
          case 15:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num = 22;
              continue;
            }
            goto label_39;
          case 16:
            if (!command.IsSetSupported(sCommandName))
            {
              ++index;
              num = 20;
              continue;
            }
            num = 24;
            continue;
          case 17:
            enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            num = 21;
            continue;
          case 18:
            num = 7;
            continue;
          case 19:
            goto label_24;
          case 20:
          case 25:
            num = 8;
            continue;
          case 22:
            enReturnCode = enReturnCode.e_INVALID_COMMAND;
            commandArray = this.A1;
            index = 0;
            num = 25;
            continue;
          case 24:
            enReturnCode = command.Set(sCommandName, dataIn);
            num = 23;
            continue;
          case 27:
            num = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_24:
      if (1 == 0)
        ;
label_39:
      this.B1.TraceOutMessage(this.GetType().ToString(), hpSMBIOS.a("\xF8AA좬\xDBAE", A_1), hpSMBIOS.a("\xE8AA슬슮솰\xDFB2킴쎶\xDCB8\xDFBA鶼좾ꣀ럂귄ﷆ\xE9C8", A_1) + enReturnCode.ToString());
      return enReturnCode;
    }

    public string[] SupportedExecuteCommands()
    {
      return (string[]) null;
    }

    public enReturnCode TypeOfExecute(string sCommandName, out Type dataIn, out Type dataOut)
    {
      dataIn = (Type) null;
      dataOut = (Type) null;
      return enReturnCode.e_INVALID_COMMAND;
    }

    public bool IsExecuteSecured(string sCommandName)
    {
      return false;
    }

    public bool IsExecuteSupported(string sCommandName)
    {
      return false;
    }

    public enReturnCode Execute(string sCommandName, object dataIn, out object dataOut)
    {
      dataOut = (object) null;
      return enReturnCode.e_INVALID_COMMAND;
    }
  }
}
