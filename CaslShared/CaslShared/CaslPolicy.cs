// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslPolicy
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using GenericPolicy;
using System;

namespace hpCasl
{
  public class CaslPolicy : Policy
  {
    public string MinLevelLogging
    {
      get
      {
label_2:
        if (1 == 0)
          ;
        string str = string.Empty;
        int num = 0;
        object oValue = null;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (this.Get(CaslPolicy.enKnownPolicies.MinLevelLogging.ToString(), out oValue) == 0)
              {
                num = 1;
                continue;
              }
              goto label_7;
            case 1:
              str = oValue.ToString();
              num = 2;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_2;
          }
        }
label_7:
        return str;
      }
    }

    public string MaxLevelLogging
    {
      get
      {
label_2:
        if (1 == 0)
          ;
        string str = string.Empty;
        int num = 2;
        object oValue = null;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              str = oValue.ToString();
              num = 0;
              continue;
            case 2:
              if (this.Get(CaslPolicy.enKnownPolicies.MaxLevelLogging.ToString(), out oValue) == 0)
              {
                num = 1;
                continue;
              }
              goto label_7;
            default:
              goto label_2;
          }
        }
label_7:
        return str;
      }
    }

    public bool AllowUnsignedAssemblies
    {
      get
      {
label_2:
        bool bValue = false;
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              bValue = false;
              if (1 == 0)
                ;
              num = 0;
              continue;
            case 2:
              if (this.Get(CaslPolicy.enKnownPolicies.AllowUnsignedAssemblies.ToString(), ref bValue) != 0)
              {
                num = 1;
                continue;
              }
              goto label_7;
            default:
              goto label_2;
          }
        }
label_7:
        return bValue;
      }
    }

    public bool AllowToasterNotification
    {
      get
      {
        if (1 == 0)
          ;
        bool bValue = false;
        this.Get(CaslPolicy.enKnownPolicies.AllowToasterNotification.ToString(), ref bValue);
        return bValue;
      }
    }

    public uint ToasterNotificationType
    {
      get
      {
label_2:
        uint num1 = uint.MaxValue;
        int num2 = 1;
        object oValue = null;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              if (this.Get(CaslPolicy.enKnownPolicies.ToasterNotificationType.ToString(), out oValue) == 0)
              {
                num2 = 2;
                continue;
              }
              goto label_7;
            case 2:
              if (1 == 0)
                ;
              num1 = (uint) Convert.ToInt32(oValue);
              num2 = 0;
              continue;
            default:
              goto label_2;
          }
        }
label_7:
        return num1;
      }
    }

    public bool AllowEmulation
    {
      get
      {
label_2:
        if (1 == 0)
          ;
        bool bValue = false;
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              if (this.Get(CaslPolicy.enKnownPolicies.AllowEmulation.ToString(), ref bValue) != 0)
              {
                num = 2;
                continue;
              }
              goto label_7;
            case 2:
              bValue = false;
              num = 0;
              continue;
            default:
              goto label_2;
          }
        }
label_7:
        return bValue;
      }
    }

    public bool AllowByteDump
    {
      get
      {
label_2:
        if (1 == 0)
          ;
        bool bValue = false;
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              if (this.Get(CaslPolicy.enKnownPolicies.AllowByteDump.ToString(), ref bValue) != 0)
              {
                num = 2;
                continue;
              }
              goto label_7;
            case 2:
              bValue = false;
              num = 0;
              continue;
            default:
              goto label_2;
          }
        }
label_7:
        return bValue;
      }
    }

    public CaslPolicy(Policy.enPolicyType eWhichType, string sMasterPolicy)
      : base(eWhichType, sMasterPolicy)
    {
    }

    public enum enKnownPolicies
    {
      MinLevelLogging,
      MaxLevelLogging,
      AllowUnsignedAssemblies,
      AllowToasterNotification,
      ToasterNotificationType,
      AllowEmulation,
      AllowByteDump,
    }
  }
}
