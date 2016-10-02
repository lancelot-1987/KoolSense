// Decompiled with JetBrains decompiler
// Type: hpCasl.CaslSharedInformation
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using System.Diagnostics;
using System.Reflection;

namespace hpCasl
{
  public class CaslSharedInformation
  {
    public static string Location
    {
      get
      {
        string str = string.Empty;
        return Assembly.GetExecutingAssembly().Location;
      }
    }

    public static string FileVersion
    {
      get
      {
        string str = string.Empty;
        return FileVersionInfo.GetVersionInfo(CaslSharedInformation.Location).FileVersion;
      }
    }
  }
}
