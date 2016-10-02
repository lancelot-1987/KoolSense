// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslLog
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using GenericLog;
using GenericPolicy;
using hpCasl.Properties;

namespace hpCasl
{
  public class CaslLog : Log
  {
    public CaslLog(string FileName)
      : base(FileName)
    {
      this.BShowUserName = true;
      this.MaxLogFileSize = 100U;
      CaslPolicy caslPolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyLogging);
      if (caslPolicy == null)
        return;
      this.EMaxLogLevel = this.StringToLogLevel(caslPolicy.MaxLevelLogging);
      this.EMinLogLevel = this.StringToLogLevel(caslPolicy.MinLevelLogging);
      this.BByteDumpAllowed = caslPolicy.AllowByteDump;
    }
  }
}
