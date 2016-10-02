// Decompiled with JetBrains decompiler
// Type: hpCasl.Properties.Resources
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties
{
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        int A_1 = 15;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              Resources.resourceMan = new ResourceManager(GenericLog.Log.a("ⱃ㙅େ⭉㽋≍繏ɑ♓㥕⡗㽙\x2E5B⩝य़ݡᝣ䡥㩧ཀྵὫŭկqᝳ\x1375\x0B77", A_1), typeof (Resources).Assembly);
              num = 1;
              continue;
            default:
              if (1 == 0)
                ;
              if (object.ReferenceEquals((object) Resources.resourceMan, (object) null))
              {
                num = 2;
                continue;
              }
              goto label_6;
          }
        }
label_6:
        return Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Resources.resourceCulture;
      }
      set
      {
        Resources.resourceCulture = value;
      }
    }

    internal static string PolicyLogging
    {
      get
      {
        return Resources.ResourceManager.GetString(GenericLog.Log.a("ፂ⩄⭆⁈⡊㑌͎㹐㑒\x3254㹖㝘㱚", 14), Resources.resourceCulture);
      }
    }

    internal Resources()
    {
    }
  }
}
