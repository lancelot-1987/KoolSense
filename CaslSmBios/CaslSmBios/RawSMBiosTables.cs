// Decompiled with JetBrains decompiler
// Type: CaslSmBios.RawSMBiosTables
// Assembly: CaslSmBios, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: AB0ECDCC-5213-46BA-9053-3364BC265F0A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslSmBios.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Management;

namespace CaslSmBios
{
  public class RawSMBiosTables : Component
  {
    private static string A;
    private static string B;
    private static ManagementScope C;
    private RawSMBiosTables.ManagementSystemProperties D;
    private ManagementObject E;
    private bool F;
    private ManagementBaseObject G;
    private ManagementBaseObject H;
    private bool I;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string OriginatingNamespace
    {
      get
      {
        return hpSMBIOS.a("\xE99A\xF29C\xF09E햠ﾢ튤쪦삨", 3);
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ManagementClassName
    {
      get
      {
        int A_1 = 10;
label_2:
        string str = RawSMBiosTables.B;
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 0:
              str = RawSMBiosTables.B;
              num = 3;
              continue;
            case 1:
              num = 7;
              continue;
            case 2:
              if (this.H.ClassPath != null)
              {
                num = 4;
                continue;
              }
              goto label_16;
            case 3:
              goto label_16;
            case 4:
              str = (string) this.H[hpSMBIOS.a("ﶡﮣ\xE5A5\xE4A7\xEBA9ﾫﶭ", A_1)];
              num = 8;
              continue;
            case 5:
              if (this.H != null)
              {
                num = 6;
                continue;
              }
              goto label_16;
            case 6:
              if (1 == 0)
                ;
              num = 2;
              continue;
            case 7:
              if (str == string.Empty)
              {
                num = 0;
                continue;
              }
              goto label_16;
            case 8:
              if (str != null)
              {
                num = 1;
                continue;
              }
              goto case 0;
            default:
              goto label_2;
          }
        }
label_16:
        return str;
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RawSMBiosTables.ManagementSystemProperties SystemProperties
    {
      get
      {
        return this.D;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ManagementBaseObject LateBoundObject
    {
      get
      {
        return this.H;
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ManagementScope Scope
    {
      get
      {
        if (!this.I)
          return this.E.Scope;
        return (ManagementScope) null;
      }
      set
      {
        if (this.I)
          return;
        this.E.Scope = value;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AutoCommit
    {
      get
      {
        return this.F;
      }
      set
      {
        this.F = value;
      }
    }

    [Browsable(true)]
    public ManagementPath Path
    {
      get
      {
        if (!this.I)
          return this.E.Path;
        return (ManagementPath) null;
      }
      set
      {
        int A_1 = 10;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              num = 4;
              continue;
            case 3:
              goto label_7;
            case 4:
              if (this.CheckIfProperClass((ManagementScope) null, value, (ObjectGetOptions) null))
              {
                this.E.Path = value;
                num = 1;
                continue;
              }
              num = 3;
              continue;
            default:
              if (!this.I)
              {
                if (1 == 0)
                  ;
                num = 2;
                continue;
              }
              goto label_11;
          }
        }
label_6:
        return;
label_11:
        return;
label_7:
        throw new ArgumentException(hpSMBIOS.a("\xE1A1좣장\xDBA7\xD9A9貫삭톯\xDFB1톳隵\xDCB7햹\xD9BB춽\xE0BF곁ꯃ닅\xE8C7\xA7C9귋뫍돏뫑䀘", A_1));
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public static ManagementScope StaticScope
    {
      get
      {
        return RawSMBiosTables.C;
      }
      set
      {
        RawSMBiosTables.C = value;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsActiveNull
    {
      get
      {
        return this.H[hpSMBIOS.a("\xD898\xF89A\xE99C\xF69E힠욢", 1)] == null;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    [Browsable(true)]
    public bool Active
    {
      get
      {
        int A_1 = 11;
        if (this.H[hpSMBIOS.a("\xE2A2욤펦삨\xDDAA좬", A_1)] == null)
          return Convert.ToBoolean(0);
        if (1 == 0)
          ;
        return (bool) this.H[hpSMBIOS.a("\xE2A2욤펦삨\xDDAA좬", A_1)];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsDmiRevisionNull
    {
      get
      {
        return this.H[hpSMBIOS.a("\xE3A6쒨슪ﾬ쪮잰\xDAB2운\xDEB6횸햺", 15)] == null;
      }
    }

    [Browsable(true)]
    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public byte DmiRevision
    {
      get
      {
        int A_1 = 16;
        if (this.H[hpSMBIOS.a("\xECA7잩얫ﲭ햯쒱\xDDB3억톷햹튻", A_1)] == null)
          return Convert.ToByte(0);
        if (1 == 0)
          ;
        return (byte) this.H[hpSMBIOS.a("\xECA7잩얫ﲭ햯쒱\xDDB3억톷햹튻", A_1)];
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string InstanceName
    {
      get
      {
        return (string) this.H[hpSMBIOS.a("\xEAA2쮤풦\xDDA8쪪쎬첮풰ﶲ풴\xDAB6\xDCB8", 11)];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsSizeNull
    {
      get
      {
        return this.H[hpSMBIOS.a("즙\xF59B\xE49D얟", 2)] == null;
      }
    }

    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public uint Size
    {
      get
      {
        int A_1 = 12;
        if (this.H[hpSMBIOS.a("\xF7A3쾥튧쾩", A_1)] != null)
          return (uint) this.H[hpSMBIOS.a("\xF7A3쾥튧쾩", A_1)];
        if (1 == 0)
          ;
        return Convert.ToUInt32(0);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public byte[] SMBiosData
    {
      get
      {
        return (byte[]) this.H[hpSMBIOS.a("\xF1A1\xE9A3\xE4A5솧얩\xDFAB\xEAAD톯욱햳", 10)];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsSmbiosMajorVersionNull
    {
      get
      {
        return this.H[hpSMBIOS.a("\xF7A3쮥쪧쎩쎫\xDDADﶯ펱\xDEB3\xD9B5쪷\xECB9\xD9BB첽뎿ꯁꯃ\xA8C5", 12)] == null;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    public byte SmbiosMajorVersion
    {
      get
      {
        int A_1 = 13;
        if (this.H[hpSMBIOS.a("\xF6A4쪦쮨슪슬\xDCAEﲰ튲\xDFB4\xD8B6쮸\xEDBA\xD8BC춾닀ꫂ\xAAC4꧆", A_1)] != null)
          return (byte) this.H[hpSMBIOS.a("\xF6A4쪦쮨슪슬\xDCAEﲰ튲\xDFB4\xD8B6쮸\xEDBA\xD8BC춾닀ꫂ\xAAC4꧆", A_1)];
        if (1 == 0)
          ;
        return Convert.ToByte(0);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsSmbiosMinorVersionNull
    {
      get
      {
        return this.H[hpSMBIOS.a("ﮧ잩캫잭\xDFAF솱靈\xDFB5횷햹캻\xE8BDꖿ냁럃꿅\xA7C7\xA4C9", 16)] == null;
      }
    }

    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public byte SmbiosMinorVersion
    {
      get
      {
        int A_1 = 6;
        if (this.H[hpSMBIOS.a("춝춟삡춣즥\xDBA7\xE7A9얫삭\xDFAF삱\xE2B3펵쪷즹햻톽꺿", A_1)] != null)
          return (byte) this.H[hpSMBIOS.a("춝춟삡춣즥\xDBA7\xE7A9얫삭\xDFAF삱\xE2B3펵쪷즹햻톽꺿", A_1)];
        if (1 == 0)
          ;
        return Convert.ToByte(0);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsUsed20CallingMethodNull
    {
      get
      {
        return this.H[hpSMBIOS.a("\xF3A5\xDBA7쾩좫鲭肯\xF1B1햳\xDAB5풷펹튻\xD9BD趿\xA7C1냃껅\xA7C7껉", 14)] == null;
      }
    }

    [Browsable(true)]
    [TypeConverter(typeof (RawSMBiosTables.WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Used20CallingMethod
    {
      get
      {
        int A_1 = 17;
        if (this.H[hpSMBIOS.a("ﲨ\xD8AA좬쮮莰莲\xF6B4횶햸ힺ풼톾ꛀ軂ꃄ돆ꇈ\xA4CA꧌", A_1)] != null)
          return (bool) this.H[hpSMBIOS.a("ﲨ\xD8AA좬쮮莰莲\xF6B4횶햸ힺ풼톾ꛀ軂ꃄ돆ꇈ\xA4CA꧌", A_1)];
        if (1 == 0)
          ;
        return Convert.ToBoolean(0);
      }
    }

    static RawSMBiosTables()
    {
      int A_1 = 7;
      RawSMBiosTables.A = hpSMBIOS.a("\xED9E캠첢톤ﮦ\xDEA8욪쒬", A_1);
      RawSMBiosTables.B = hpSMBIOS.a("튞\xF2A0\xF0A2좤\xE5A6삨쒪\xDEAC\xF0AE\xE3B0튲슴\xE4B6\xF4B8了풼킾닀韂꓄ꗆꗈ껊뻌", A_1);
      RawSMBiosTables.C = (ManagementScope) null;
    }

    public RawSMBiosTables()
    {
      this.InitializeObject((ManagementScope) null, (ManagementPath) null, (ObjectGetOptions) null);
    }

    public RawSMBiosTables(string keyInstanceName)
    {
      this.InitializeObject((ManagementScope) null, new ManagementPath(RawSMBiosTables.ConstructPath(keyInstanceName)), (ObjectGetOptions) null);
    }

    public RawSMBiosTables(ManagementScope mgmtScope, string keyInstanceName)
    {
      this.InitializeObject(mgmtScope, new ManagementPath(RawSMBiosTables.ConstructPath(keyInstanceName)), (ObjectGetOptions) null);
    }

    public RawSMBiosTables(ManagementPath path, ObjectGetOptions getOptions)
    {
      this.InitializeObject((ManagementScope) null, path, getOptions);
    }

    public RawSMBiosTables(ManagementScope mgmtScope, ManagementPath path)
    {
      this.InitializeObject(mgmtScope, path, (ObjectGetOptions) null);
    }

    public RawSMBiosTables(ManagementPath path)
    {
      this.InitializeObject((ManagementScope) null, path, (ObjectGetOptions) null);
    }

    public RawSMBiosTables(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
    {
      this.InitializeObject(mgmtScope, path, getOptions);
    }

    public RawSMBiosTables(ManagementObject theObject)
    {
      int A_1 = 3;
      // ISSUE: explicit constructor call
      this.Initialize();
      if (!this.CheckIfProperClass((ManagementBaseObject) theObject))
        throw new ArgumentException(hpSMBIOS.a("\xD89A\xF19Cﺞ튠킢薤즦좨욪좬辮햰\xDCB2킴쒶馸햺튼쮾\xE1C0껂꓄돆\xAAC8ꏊ\xE3CC", A_1));
      this.E = theObject;
      this.D = new RawSMBiosTables.ManagementSystemProperties((ManagementBaseObject) this.E);
      this.H = (ManagementBaseObject) this.E;
    }

    public RawSMBiosTables(ManagementBaseObject theObject)
    {
      int A_1 = 15;
      // ISSUE: explicit constructor call
      this.Initialize();
      if (!this.CheckIfProperClass(theObject))
        throw new ArgumentException(hpSMBIOS.a("\xE4A6얨쪪\xDEAC\xDCAE醰\xDDB2풴\xDAB6\xDCB8鮺\xD9BC킾꓀냂\xE5C4꧆ꛈ뿊\xEDCCꋎ냐\xA7D2뛔뿖\xF7D8", A_1));
      this.G = theObject;
      this.D = new RawSMBiosTables.ManagementSystemProperties(theObject);
      this.H = this.G;
      this.I = true;
    }

    private bool CheckIfProperClass(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions OptionsParam)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 2;
            continue;
          case 1:
            goto label_5;
          case 2:
            if (string.Compare(path.ClassName, this.ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
            {
              num = 1;
              continue;
            }
            goto label_9;
          default:
            if (1 == 0)
              ;
            if (path != null)
            {
              num = 0;
              continue;
            }
            goto label_9;
        }
      }
label_5:
      return true;
label_9:
      return this.CheckIfProperClass((ManagementBaseObject) new ManagementObject(mgmtScope, path, OptionsParam));
    }

    private bool CheckIfProperClass(ManagementBaseObject theObj)
    {
      int A_1 = 17;
      int num = 2;
      while (true)
      {
        Array array = null;
        int index = 0;
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (array != null)
            {
              num = 5;
              continue;
            }
            goto label_19;
          case 3:
            num = index < array.Length ? 4 : 10;
            continue;
          case 4:
            if (string.Compare((string) array.GetValue(index), this.ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
            {
              num = 9;
              continue;
            }
            ++index;
            num = 11;
            continue;
          case 5:
            index = 0;
            num = 7;
            continue;
          case 6:
            num = 8;
            continue;
          case 7:
            if (1 == 0)
              goto case 11;
            else
              goto case 11;
          case 8:
            if (string.Compare((string) theObj[hpSMBIOS.a("\xF6A8\xF4AA\xEEAC\xE3AE\xF0B0\xE0B2\xE6B4", A_1)], this.ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
            {
              num = 0;
              continue;
            }
            break;
          case 9:
            goto label_4;
          case 10:
            goto label_19;
          case 11:
            num = 3;
            continue;
          default:
            if (theObj != null)
            {
              num = 6;
              continue;
            }
            break;
        }
        array = (Array) theObj[hpSMBIOS.a("\xF6A8\xF4AA\xE9AC\xEAAE\xE3B0者\xE3B4\xF6B6\xEDB8\xF2BA\xF2BC\xF1BE", A_1)];
        num = 1;
      }
label_4:
      return true;
label_7:
      return true;
label_19:
      return false;
    }

    private bool ShouldSerializeActive()
    {
      return !this.IsActiveNull;
    }

    private bool ShouldSerializeDmiRevision()
    {
      return !this.IsDmiRevisionNull;
    }

    private bool ShouldSerializeSize()
    {
      return !this.IsSizeNull;
    }

    private bool ShouldSerializeSmbiosMajorVersion()
    {
      return !this.IsSmbiosMajorVersionNull;
    }

    private bool ShouldSerializeSmbiosMinorVersion()
    {
      return !this.IsSmbiosMinorVersionNull;
    }

    private bool ShouldSerializeUsed20CallingMethod()
    {
      return !this.IsUsed20CallingMethodNull;
    }

    [Browsable(true)]
    public void CommitObject()
    {
      if (this.I)
        return;
      this.E.Put();
    }

    [Browsable(true)]
    public void CommitObject(PutOptions putOptions)
    {
      if (this.I)
        return;
      this.E.Put(putOptions);
    }

    private void Initialize()
    {
      this.F = true;
      this.I = false;
    }

    private static string ConstructPath(string keyInstanceName)
    {
      int A_1 = 19;
      if (1 == 0)
        ;
      return hpSMBIOS.a("\xD9AA슬삮얰\xEFB2슴\xDAB6킸膺\xF0BC\xECBE鋀껂蟄껆ꛈ룊鋌鷎냐ꓒ蛔髖鯘닚닜곞뗠苢蟤详賨飪", A_1) + (hpSMBIOS.a("薪\xE4AC솮슰잲풴\xD9B6\xDAB8\xDEBA\xF3BC\xDEBE곀ꛂ\xF8C4", A_1) + (hpSMBIOS.a("親", A_1) + (keyInstanceName + hpSMBIOS.a("親", A_1))));
    }

    private void InitializeObject(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
    {
      int A_1 = 6;
label_2:
      this.Initialize();
      if (1 == 0)
        ;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 3;
            continue;
          case 1:
            goto label_6;
          case 2:
            if (path != null)
            {
              num = 0;
              continue;
            }
            goto label_10;
          case 3:
            if (!this.CheckIfProperClass(mgmtScope, path, getOptions))
            {
              num = 1;
              continue;
            }
            goto label_10;
          default:
            goto label_2;
        }
      }
label_6:
      throw new ArgumentException(hpSMBIOS.a("\xDD9D첟쎡힣향袧쒩춫쎭햯銱킳\xD9B5\xDDB7즹鲻킽꾿뛁\xE4C3ꯅ꧇뻉꿋ꛍﻏ", A_1));
label_10:
      this.E = new ManagementObject(mgmtScope, path, getOptions);
      this.D = new RawSMBiosTables.ManagementSystemProperties((ManagementBaseObject) this.E);
      this.H = (ManagementBaseObject) this.E;
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances()
    {
      return RawSMBiosTables.GetInstances((ManagementScope) null, (string) null, (string[]) null);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(string condition)
    {
      return RawSMBiosTables.GetInstances((ManagementScope) null, condition, (string[]) null);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(string[] selectedProperties)
    {
      return RawSMBiosTables.GetInstances((ManagementScope) null, (string) null, selectedProperties);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(string condition, string[] selectedProperties)
    {
      return RawSMBiosTables.GetInstances((ManagementScope) null, condition, selectedProperties);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
    {
      int A_1 = 8;
      int num = 1;
      ManagementClass managementClass = null;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 3;
            continue;
          case 2:
          case 8:
            if (1 == 0)
              ;
            managementClass = new ManagementClass(mgmtScope, new ManagementPath()
            {
              ClassName = hpSMBIOS.a("\xED9F\xF1A1\xF7A3쮥\xEAA7쎩쎫\xDDAD\xEFAF\xE0B1햳솵\xEBB7\xF7B9ﺻힽ꾿뇁郃\xA7C5\xAAC7ꛉ꧋뷍", A_1),
              NamespacePath = hpSMBIOS.a("튟춡쮣튥\xF4A7\xDDA9솫잭", A_1)
            }, (ObjectGetOptions) null);
            num = 5;
            continue;
          case 3:
            if (RawSMBiosTables.C != null)
            {
              mgmtScope = RawSMBiosTables.C;
              num = 2;
              continue;
            }
            num = 4;
            continue;
          case 4:
            mgmtScope = new ManagementScope();
            mgmtScope.Path.NamespacePath = hpSMBIOS.a("튟춡쮣튥\xF4A7\xDDA9솫잭", A_1);
            num = 8;
            continue;
          case 5:
            if (enumOptions == null)
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 6:
            enumOptions = new EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            num = 7;
            continue;
          case 7:
            goto label_14;
          default:
            if (mgmtScope == null)
            {
              num = 0;
              continue;
            }
            goto case 2;
        }
      }
label_14:
      return new RawSMBiosTables.RawSMBiosTablesCollection(managementClass.GetInstances(enumOptions));
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(ManagementScope mgmtScope, string condition)
    {
      return RawSMBiosTables.GetInstances(mgmtScope, condition, (string[]) null);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
    {
      return RawSMBiosTables.GetInstances(mgmtScope, (string) null, selectedProperties);
    }

    public static RawSMBiosTables.RawSMBiosTablesCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
    {
      int A_1 = 2;
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 4:
            goto label_10;
          case 1:
            mgmtScope = new ManagementScope();
            mgmtScope.Path.NamespacePath = hpSMBIOS.a("\xE899\xF39B\xF19D풟ﺡ펣쮥솧", A_1);
            num = 4;
            continue;
          case 2:
            num = 3;
            continue;
          case 3:
            if (RawSMBiosTables.C != null)
            {
              mgmtScope = RawSMBiosTables.C;
              num = 0;
              continue;
            }
            num = 1;
            continue;
          default:
            if (mgmtScope == null)
            {
              if (1 == 0)
                ;
              num = 2;
              continue;
            }
            goto label_10;
        }
      }
label_10:
      return new RawSMBiosTables.RawSMBiosTablesCollection(new ManagementObjectSearcher(mgmtScope, (ObjectQuery) new SelectQuery(hpSMBIOS.a("힙쾛춝춟\xE0A1춣즥\xDBA7\xF5A9ﺫ쾭잯\xE1B1靈\xF4B5톷햹쾻\xEABDꆿꃁꣃꏅ믇", A_1), condition, selectedProperties))
      {
        Options = new EnumerationOptions()
        {
          EnsureLocatable = true
        }
      }.Get());
    }

    [Browsable(true)]
    public static RawSMBiosTables CreateInstance()
    {
label_2:
      ManagementScope scope = (ManagementScope) null;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 3:
            goto label_8;
          case 1:
            if (1 == 0)
              ;
            scope = new ManagementScope();
            scope.Path.NamespacePath = RawSMBiosTables.A;
            num = 0;
            continue;
          case 2:
            if (RawSMBiosTables.C == null)
            {
              num = 1;
              continue;
            }
            scope = RawSMBiosTables.C;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      ManagementPath path = new ManagementPath(RawSMBiosTables.B);
      return new RawSMBiosTables(new ManagementClass(scope, path, (ObjectGetOptions) null).CreateInstance());
    }

    [Browsable(true)]
    public void Delete()
    {
      this.E.Delete();
    }

    public class RawSMBiosTablesCollection : ICollection
    {
      private ManagementObjectCollection privColObj;

      public virtual int Count
      {
        get
        {
          return this.privColObj.Count;
        }
      }

      public virtual bool IsSynchronized
      {
        get
        {
          return this.privColObj.IsSynchronized;
        }
      }

      public virtual object SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      public RawSMBiosTablesCollection(ManagementObjectCollection objCollection)
      {
        this.privColObj = objCollection;
      }

      public virtual void CopyTo(Array array, int index)
      {
label_2:
        this.privColObj.CopyTo(array, index);
        int index1 = 0;
        if (1 == 0)
          ;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 1:
              num = 3;
              continue;
            case 2:
              goto label_8;
            case 3:
              if (index1 >= array.Length)
              {
                num = 2;
                continue;
              }
              array.SetValue((object) new RawSMBiosTables((ManagementObject) array.GetValue(index1)), index1);
              ++index1;
              num = 1;
              continue;
            default:
              goto label_2;
          }
        }
label_8:;
      }

      public virtual IEnumerator GetEnumerator()
      {
        return (IEnumerator) new RawSMBiosTables.RawSMBiosTablesCollection.RawSMBiosTablesEnumerator(this.privColObj.GetEnumerator());
      }

      public class RawSMBiosTablesEnumerator : IEnumerator
      {
        private ManagementObjectCollection.ManagementObjectEnumerator A;

        public virtual object Current
        {
          get
          {
            return (object) new RawSMBiosTables((ManagementObject) this.A.Current);
          }
        }

        public RawSMBiosTablesEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum)
        {
          this.A = objEnum;
        }

        public virtual bool MoveNext()
        {
          return this.A.MoveNext();
        }

        public virtual void Reset()
        {
          this.A.Reset();
        }
      }
    }

    public class WMIValueTypeConverter : TypeConverter
    {
      private TypeConverter A;
      private Type B;

      public WMIValueTypeConverter(Type inBaseType)
      {
        this.A = TypeDescriptor.GetConverter(inBaseType);
        this.B = inBaseType;
      }

      public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
      {
        return this.A.CanConvertFrom(context, srcType);
      }

      public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
      {
        return this.A.CanConvertTo(context, destinationType);
      }

      public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
      {
        return this.A.ConvertFrom(context, culture, value);
      }

      public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
      {
        return this.A.CreateInstance(context, dictionary);
      }

      public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
      {
        return this.A.GetCreateInstanceSupported(context);
      }

      public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
      {
        return this.A.GetProperties(context, value, attributeVar);
      }

      public override bool GetPropertiesSupported(ITypeDescriptorContext context)
      {
        return this.A.GetPropertiesSupported(context);
      }

      public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
      {
        return this.A.GetStandardValues(context);
      }

      public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
      {
        return this.A.GetStandardValuesExclusive(context);
      }

      public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
      {
        return this.A.GetStandardValuesSupported(context);
      }

      public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
      {
        int A_1 = 11;
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (!context.PropertyDescriptor.ShouldSerializeValue(context.Instance))
              {
                num = 8;
                continue;
              }
              goto label_33;
            case 1:
              if (context != null)
              {
                num = 16;
                continue;
              }
              goto label_26;
            case 2:
              goto label_16;
            case 4:
              num = 1;
              continue;
            case 5:
              num = 10;
              continue;
            case 6:
              if (context != null)
              {
                if (1 == 0)
                  ;
                num = 12;
                continue;
              }
              goto label_33;
            case 7:
              num = 6;
              continue;
            case 8:
              goto label_28;
            case 9:
              num = value.GetType() != destinationType ? 13 : 2;
              continue;
            case 10:
              if (this.B.BaseType == typeof (ValueType))
              {
                num = 23;
                continue;
              }
              break;
            case 11:
              if (value == null)
              {
                num = 4;
                continue;
              }
              goto label_26;
            case 12:
              num = 0;
              continue;
            case 13:
              if (value == null)
              {
                num = 7;
                continue;
              }
              goto label_33;
            case 14:
              if (this.B == typeof (bool))
              {
                num = 5;
                continue;
              }
              break;
            case 15:
              num = 21;
              continue;
            case 16:
              num = 19;
              continue;
            case 17:
              goto label_17;
            case 18:
              num = 9;
              continue;
            case 19:
              if (!context.PropertyDescriptor.ShouldSerializeValue(context.Instance))
              {
                num = 17;
                continue;
              }
              goto label_26;
            case 20:
              if (context != null)
              {
                num = 15;
                continue;
              }
              goto label_40;
            case 21:
              if (!context.PropertyDescriptor.ShouldSerializeValue(context.Instance))
              {
                num = 22;
                continue;
              }
              goto label_40;
            case 22:
              goto label_27;
            case 23:
              num = 11;
              continue;
            default:
              num = this.B.BaseType != typeof (Enum) ? 14 : 18;
              continue;
          }
          num = 20;
        }
label_16:
        return value;
label_17:
        return (object) "";
label_26:
        return this.A.ConvertTo(context, culture, value, destinationType);
label_27:
        return (object) "";
label_28:
        return (object) hpSMBIOS.a("\xEDA2\xF0A4\xEBA6\xE5A8\xF4AA\xE8AC\xE1AE\xE4B0ﺲ\xEAB4\xE1B6\xF8B8\xF7BA\xE8BC諭", A_1);
label_33:
        return this.A.ConvertTo(context, culture, value, destinationType);
label_40:
        return this.A.ConvertTo(context, culture, value, destinationType);
      }
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class ManagementSystemProperties
    {
      private ManagementBaseObject PrivateLateBoundObject;

      [Browsable(true)]
      public int GENUS
      {
        get
        {
          return (int) this.PrivateLateBoundObject[hpSMBIOS.a("ﺠﲢ\xE2A4\xE2A6\xE7A8ﺪﺬ", 9)];
        }
      }

      [Browsable(true)]
      public string CLASS
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("殮\xF7A7\xE9A9\xE0AB\xEFAD\xE3AF\xE1B1", 14)];
        }
      }

      [Browsable(true)]
      public string SUPERCLASS
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("삞ﺠ\xF0A2\xF0A4\xF7A6\xECA8寧\xEEAC\xE3AE\xF0B0\xE0B2\xE6B4", 7)];
        }
      }

      [Browsable(true)]
      public string DYNASTY
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("ﲢ瘝\xE3A6\xF0A8\xE5AA\xECACﲮ\xE5B0\xEAB2", 11)];
        }
      }

      [Browsable(true)]
      public string RELPATH
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("삞ﺠ\xF1A2\xE0A4\xEBA6令\xEAAA怜\xE7AE", 7)];
        }
      }

      [Browsable(true)]
      public int PROPERTY_COUNT
      {
        get
        {
          return (int) this.PrivateLateBoundObject[hpSMBIOS.a("얙쎛캝\xF29F\xEDA1\xF4A3\xE3A5盛ﺩ\xF5AB\xF1AD\xF3AFﶱ\xE1B3\xF8B5\xECB7", 2)];
        }
      }

      [Browsable(true)]
      public string[] DERIVATION
      {
        get
        {
          return (string[]) this.PrivateLateBoundObject[hpSMBIOS.a("삞ﺠ\xE7A2\xE0A4\xF5A6\xE0A8ﶪ\xECACﮮ\xF8B0ﲲ﮴", 7)];
        }
      }

      [Browsable(true)]
      public string SERVER
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("\xF8A6\xF6A8\xF8AA\xE8ACﶮ\xE7B0\xF6B2\xE7B4", 15)];
        }
      }

      [Browsable(true)]
      public string NAMESPACE
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("슜삞\xEFA0\xE2A2\xE8A4\xE2A6直ﮪ\xECAC\xECAE\xF4B0", 5)];
        }
      }

      [Browsable(true)]
      public string PATH
      {
        get
        {
          return (string) this.PrivateLateBoundObject[hpSMBIOS.a("쒚슜쾞\xE0A0\xF7A2\xEDA4", 3)];
        }
      }

      public ManagementSystemProperties(ManagementBaseObject ManagedObject)
      {
        this.PrivateLateBoundObject = ManagedObject;
      }
    }
  }
}
