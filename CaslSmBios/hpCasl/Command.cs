// Decompiled with JetBrains decompiler
// Type: hpCasl.Command
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using System;
using System.Collections.Generic;
using CaslSmBios;
namespace hpCasl
{
  public abstract class Command
  {
    protected CaslLogger A1;
    protected string[] B1;
    protected string[] C1;
    protected string[] D1;
    protected List<Command.Property> E1;
    protected List<Command.Property> F1;

    public Command()
    {
      int A_1 = 15;
      // ISSUE: explicit constructor call
      this.A1 = new CaslLogger();
      try
      {
        this.E1 = new List<Command.Property>();
        this.B();
        this.B1 = this.SupportedGetCommands();
      }
      catch (Exception ex)
      {
        this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE4A6욨욪사캮\xDFB0ힲ", A_1), ex.Message);
      }
      try
      {
        this.F1 = new List<Command.Property>();
        this.A();
        this.C1 = this.SupportedSetCommands();
      }
      catch (Exception ex)
      {
        this.A1.ErrorMessage(this.GetType().ToString(), hpSMBIOS.a("\xE4A6욨욪사캮\xDFB0ힲ", A_1), ex.Message);
      }
    }

    public abstract void B();

    protected abstract void A();

    public string[] SupportedGetCommands()
    {
      string[] strArray;
      try
      {
label_3:
        strArray = new string[this.E1.Count];
        int index = 0;
        if (1 == 0)
          ;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 4:
              num = 3;
              continue;
            case 1:
              goto label_11;
            case 2:
              num = 1;
              continue;
            case 3:
              if (index < strArray.Length)
              {
                strArray[index] = this.E1[index].DataName;
                ++index;
                num = 4;
                continue;
              }
              num = 2;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        strArray = (string[]) null;
      }
label_11:
      return strArray;
    }

    public enReturnCode TypeOfGet(string sCommandName, out Type tDataOut)
    {
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataOut = (Type) null;
      try
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              int index = Array.IndexOf<string>(this.B1, sCommandName);
              tDataOut = this.E1[index].DataType;
              enReturnCode = enReturnCode.e_OK;
              num = 3;
              continue;
            case 1:
              this.B1 = this.SupportedGetCommands();
              num = 0;
              continue;
            case 3:
              goto label_8;
            default:
              if (this.B1 == null)
              {
                num = 1;
                continue;
              }
              goto case 0;
          }
        }
      }
      catch (Exception ex)
      {
        enReturnCode = enReturnCode.e_INVALID_COMMAND;
      }
label_8:
      if (1 == 0)
        ;
      return enReturnCode;
    }

    public bool IsGetSupported(string sCommandName)
    {
      int num1 = 0;
      try
      {
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              this.B1 = this.SupportedGetCommands();
              num2 = 2;
              continue;
            case 2:
              num1 = Array.IndexOf<string>(this.B1, sCommandName);
              num2 = 0;
              continue;
            default:
              if (this.B1 == null)
              {
                num2 = 1;
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
label_7:
      if (1 == 0)
        ;
      return num1 != -1;
    }

    public bool IsGetSecured(string sCommandName)
    {
      return false;
    }

    public enReturnCode Get(string sCommandName, out object dataOut)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      dataOut = (object) null;
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            if (1 == 0)
              ;
            enReturnCode = enReturnCode.e_NODE_NOT_FOUND;
            num1 = 0;
            continue;
          case 2:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 1;
              continue;
            }
            goto label_22;
          default:
            goto label_2;
        }
      }
label_5:
      try
      {
        int num2 = 2;
        Command.DataFunctionGetDelegate functionGetDelegate = null;
        int index = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
            case 8:
              num2 = 5;
              continue;
            case 1:
              try
              {
                functionGetDelegate = (Command.DataFunctionGetDelegate) Delegate.CreateDelegate(typeof (Command.DataFunctionGetDelegate), (object) this, this.E1[index].DataFunction);
              }
              catch
              {
              }
              num2 = 6;
              continue;
            case 3:
              index = Array.IndexOf<string>(this.B1, sCommandName);
              functionGetDelegate = (Command.DataFunctionGetDelegate) null;
              num2 = 1;
              continue;
            case 4:
              enReturnCode = functionGetDelegate(sCommandName, out dataOut);
              num2 = 0;
              continue;
            case 5:
              goto label_22;
            case 6:
              if (functionGetDelegate != null)
              {
                num2 = 4;
                continue;
              }
              enReturnCode = enReturnCode.e_UNKNOWN;
              num2 = 8;
              continue;
            case 7:
              this.B1 = this.SupportedGetCommands();
              num2 = 3;
              continue;
            default:
              if (this.B1 == null)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
          }
        }
      }
      catch (Exception ex)
      {
        enReturnCode = enReturnCode.e_UNKNOWN;
      }
label_22:
      return enReturnCode;
    }

    public string[] SupportedSetCommands()
    {
      return (string[]) null;
    }

    public enReturnCode TypeOfSet(string sCommandName, out Type tDataIn)
    {
      enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
      tDataIn = (Type) null;
      return enReturnCode;
    }

    public bool IsSetSecured(string sCommandName)
    {
      return false;
    }

    public bool IsSetSupported(string sCommandName)
    {
      return -1 != -1;
    }

    public enReturnCode Set(string sCommandName, object dataIn)
    {
label_2:
      enReturnCode enReturnCode = enReturnCode.e_OK;
      if (1 == 0)
        ;
      int num1 = 1;
      List<Command.Property>.Enumerator enumerator = new List<Property>.Enumerator();
      while (true)
      {
        switch (num1)
        {
          case 0:
            enReturnCode = enReturnCode.e_NODE_NOT_FOUND;
            enumerator = this.F1.GetEnumerator();
            num1 = 2;
            continue;
          case 1:
            if (enReturnCode == enReturnCode.e_OK)
            {
              num1 = 0;
              continue;
            }
            goto label_25;
          case 2:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_6:
      try
      {
        int num2 = 10;
        while (true)
        {
                    Command.Property current = new Property();
          Command.DataFunctionSetDelegate functionSetDelegate = null;
          switch (num2)
          {
            case 0:
            case 5:
            case 7:
              num2 = 3;
              continue;
            case 1:
              try
              {
                functionSetDelegate = (Command.DataFunctionSetDelegate) Delegate.CreateDelegate(typeof (Command.DataFunctionSetDelegate), (object) this, current.DataFunction);
              }
              catch
              {
              }
              num2 = 4;
              continue;
            case 2:
              functionSetDelegate = (Command.DataFunctionSetDelegate) null;
              num2 = 1;
              continue;
            case 3:
              goto label_25;
            case 4:
              if (functionSetDelegate == null)
              {
                enReturnCode = enReturnCode.e_UNKNOWN;
                num2 = 0;
                continue;
              }
              num2 = 6;
              continue;
            case 6:
              enReturnCode = functionSetDelegate(sCommandName, dataIn);
              num2 = 7;
              continue;
            case 8:
              if (current.DataName == sCommandName)
              {
                num2 = 2;
                continue;
              }
              break;
            case 9:
              if (enumerator.MoveNext())
              {
                current = enumerator.Current;
                num2 = 8;
                continue;
              }
              num2 = 5;
              continue;
          }
          num2 = 9;
        }
      }
      finally
      {
        enumerator.Dispose();
      }
label_25:
      return enReturnCode;
    }

    protected struct Property
    {
      public string DataName;
      public Type DataType;
      public string DataFunction;
      public bool IsSecured;

      public Property(string A_0, Type A_1, string A_2, bool A_3)
      {
        this.DataName = A_0;
        this.DataType = A_1;
        this.DataFunction = A_2;
        this.IsSecured = A_3;
      }
    }

    protected delegate enReturnCode DataFunctionGetDelegate(string A_0, out object A_1);

    protected delegate enReturnCode DataFunctionSetDelegate(string A_0, object A_1);
  }
}
