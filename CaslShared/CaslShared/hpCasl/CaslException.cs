// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslException
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using System;
using System.Runtime.Serialization;
using GenericLog;
namespace hpCasl
{
  [Serializable]
  public class CaslException : ApplicationException
  {
    public enReturnCode eRetCode;

    public CaslException()
    {
    }

    public CaslException(string message)
      : base(message)
    {
    }

    public CaslException(string message, Exception inner)
      : base(message, inner)
    {
    }

    protected CaslException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public CaslException(enReturnCode eRetCode)
      : base(eRetCode.ToString())
    {
      this.eRetCode = eRetCode;
    }

    public CaslException(string message, enReturnCode eRetCode): base(message + Log.a("ᔴἶ", 0) + eRetCode.ToString() + Log.a("ᰴ", 0))
    {
    
      this.eRetCode = eRetCode;
    }
    public CaslException(string message, Exception inner, enReturnCode eRetCode): base(message + Log.a("慀歂", 12) + eRetCode.ToString() + Log.a("桀", 12), inner)
        {

      this.eRetCode = eRetCode;
    }
  }
}
