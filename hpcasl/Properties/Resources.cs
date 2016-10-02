// Decompiled with JetBrains decompiler
// Type: hpCasl.Properties.Resources
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace hpCasl.Properties
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        int A_1 = 16;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              Resources.resourceMan = new ResourceManager(Casl.a("\xE58Cﾎ튐\xF292\xE694ﮖ래쮚\xEF9C\xF09E토욢\xD7A4펦삨캪\xDEAC膮\xE3B0횲운\xD8B6첸즺\xDEBC\xDABE닀", A_1), typeof (Resources).Assembly);
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

    internal static string PolicyEmulation
    {
      get
      {
        return Resources.ResourceManager.GetString(Casl.a("\xDC8B\xE18Dﲏﮑ\xF793\xEF95\xDD97\xF799\xE99B\xF29D솟횡춣즥욧", 15), Resources.resourceCulture);
      }
    }

    internal static string PolicyLogging
    {
      get
      {
        return Resources.ResourceManager.GetString(Casl.a("\x2E7D\xEF7F\xEE81\xED83\xE585\xF187욉\xE38B\xE98D\xF78Fﮑ望\xF195", 1), Resources.resourceCulture);
      }
    }

    internal static string PolicySigning
    {
      get
      {
        return Resources.ResourceManager.GetString(Casl.a("\xDE8Dﾏﺑﶓ\xF595\xE197즙\xF59B劣캟쮡쪣솥", 17), Resources.resourceCulture);
      }
    }

    internal static string PolicyToaster
    {
      get
      {
        return Resources.ResourceManager.GetString(Casl.a("풃\xE985\xE487\xE389\xEF8B\xF78D쒏\xFD91\xF593\xE595\xEC97ﾙ\xEE9B", 7), Resources.resourceCulture);
      }
    }

    internal Resources()
    {
    }
  }
}
