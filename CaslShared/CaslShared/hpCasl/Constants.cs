// Decompiled with JetBrains decompiler
// Type: hpCasl.Constants
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using System;
using System.Diagnostics;
using System.IO;

namespace hpCasl
{
  public class Constants
  {
    public const string HpSignExtension = ".hpsign";
    public const string NotImplemented = "Not Implemented";
    public const string CaslFullName = "Casl.Fullname";
    public const string CaslLocation = "Casl.Location";
    public const string CaslVersion = "Casl.Version";
    public const string CaslFileVersion = "Casl.FileVersion";
    public const string CaslPlugins = "Casl.Plugins";
    public const string EDIDData = "EDID.Data";
    public const string EDIDSupported = "EDID.Supported";
    public const string DebugPowerSource = "Debug.PowerSource";
    public const string DebugPowerStartHppaService = "Debug.734C8069-D938-4fb4-B548-46765472F7A2";
    public const string SmartAdapterSupported = "SmartAdapter.Supported";
    public const string SmartAdapterStatus = "SmartAdapter.Status";
    public const string ALSEnabled = "ALS.Enabled";
    public const string ALSSupported = "ALS.Supported";
    public const string BatteryInfoSupported = "Battery.Info.Supported";
    public const string DiagsBatteryChargeControl = "Diags.BatteryChargeControl";
    public const string DiagsBIOSUpdateStatus = "Diags.BIOSUpdateStatus";
    public const string DiagsLaunchCommandStatus = "Diags.LaunchCommandStatus";
    public const string DiagsDeviceFirmwareUpdateStatus = "Diags.DeviceFirmwareUpdateStatus";
    public const string DiagsThermalDiagnostics = "Diags.ThermalDiagnostics";
    public const string DiagsFactoryControl = "Diags.FactoryControl";
    public const string DiagsPostCodeError = "Diags.PostCodeError";
    public const string DiagsBatteryChargeControlOverride = "Diags.BatteryChargeControlOverride";
    public const string DiagsWarranty = "Diags.Warranty";
    public const string DiagsThermalControl = "Diags.ThermalControl";
    public const string F10SettingDayStarter2Enabled = "F10Setting.DayStarter2.Enabled";
    public const string F10SettingCustomLogoEnabled = "F10Setting.CustomLogo.Enabled";
    public const string FeatureDayStarter2Supported = "Feature.DayStarter2.Supported";
    public const string FeaturePBProductivitySupported = "Feature.PBProductivity.Supported";
    public const string FeatureQuickLook2Supported = "Feature.QuickLook2.Supported";
    public const string FeatureQuickLook3Supported = "Feature.QuickLook3.Supported";
    public const string FeatureFastLook3Supported = "Feature.FastLook3.Supported";
    public const string FeatureFVESupported = "Feature.FVE.Supported";
    public const string FeatureUUKSupported = "Feature.UUK.Supported";
    public const string FeatureHPSpareKeySupported = "Feature.HPSpareKey.Supported";
    public const string FeatureWireless4Supported = "Feature.Wireless4.Supported";
    public const string FeatureLidSwitchSupported = "Feature.LidSwitch.Supported";
    public const string FeatureQuickWeb3Supported = "Feature.QuickWeb3.Supported";
    public const string PanelBrightnessSupported = "PanelBrightness.Supported";
    public const string PanelBrightnessIndex = "PanelBrightness.Index";
    public const string PanelBrightnessNits = "PanelBrightness.Nits";
    public const string PanelBrightnessPercent = "PanelBrightness.Percent";
    public const string PanelBrightnessPWM = "PanelBrightness.PWM";
    public const string PanelBrightnessTablesSupported = "PanelBrightness.Tables.Supported";
    public const string PanelBrightnessTablesAll = "PanelBrightness.Tables.All";
    public const string PanelBrightnessTablesNits = "PanelBrightness.Tables.Nits";
    public const string PanelBrightnessTablesPercent = "PanelBrightness.Tables.Percent";
    public const string PanelBrightnessTablesPowerTables = "PanelBrightness.Tables.PowerTables";
    public const string PlatformManufacturer = "Platform.Manufacturer";
    public const string PlatformModelName = "Platform.ModelName";
    public const string PlatformsUUID = "Platform.sUUID";
    public const string PlatformUUID = "Platform.UUID";
    public const string PlatformAssetTag = "Platform.AssetTag";
    public const string PlatformProcessorName = "Platform.ProcessorName";
    public const string PlatformUMAMemory = "Platform.UMAMemory";
    public const string PlatformTotalMemory = "Platform.TotalMemory";
    public const string PlatformIsPortable = "Platform.IsPortable";
    public const string PlatformIsTablet = "Platform.IsTablet";
    public const string PlatformMachineID = "Platform.MachineID";
    public const string PlatformBIOSVersionShort = "Platform.BIOSVersionShort";
    public const string PlatformKBCVersion = "Platform.KBCVersion";
    public const string PlatformSerialNumber = "Platform.SerialNumber";
    public const string PlatformFamily = "Platform.Family";
    public const string PlatformSKUNumber = "Platform.SKUNumber";
    public const string PlatformBIOSVersionLong = "Platform.BIOSVersionLong";
    public const string PlatformBIOSVendor = "Platform.BIOSVendor";
    public const string PlatformBIOSReleaseDate = "Platform.BIOSReleaseDate";
    public const string PMCCalibrationData = "PMC.CalibrationData";
    public const string PMCCapabilities2 = "PMC.Capabilities2";
    public const string PMCEventRate = "PMC.EventRate";
    public const string PMCData = "PMC.Data";
    public const string PMCCapabilities = "PMC.Capabilities";
    public const string VTStatus = "VT.Status";
    public const string VTSupported = "VT.Supported";
    public const string WirelessWLANPresent = "Wireless.WLAN.Present";
    public const string WirelessAllEnabled = "Wireless.All.Enabled";
    public const string WirelessGPSPresent = "Wireless.GPS.Present";
    public const string WirelessWWANPresent = "Wireless.WWAN.Present";
    public const string WirelessGlobalChanged = "Wireless.GlobalChanged";
    public const string WirelessGlobalChangedNoCache = "Wireless.GlobalChanged.NoCache";
    public const string WirelessGlobalChanged_2_0 = "Wireless.GlobalChanged.2.0";
    public const string WirelessGlobalChanged_2_0_NoCache = "Wireless.GlobalChanged.2.0.NoCache";
    public const string WirelessDeviceInfo = "Wireless.DeviceInfo";
    public const string WirelessSetDeviceState = "Wireless.SetDeviceState";
    public const string WirelessBluetoothPresent = "Wireless.Bluetooth.Present";
    public const string WirelessSupported = "Wireless.Supported";
    public const string DockState = "Docked.State";
    public const string DockSupported = "Docked.State.Supported";
    public const string HpqQmiExDefaultMetadataCommand = "Default.Data";
    public const string HpqQmiExNoCacheMetadataCommand = "Bust.The.Cache.Data";
    public const string WirelessWlanEnabled = "Wireless.WLAN.Enabled";
    public const string WirelessBluetoothEnabled = "Wireless.Bluetooth.Enabled";
    public const string WirelessWwanEnabled = "Wireless.WWAN.Enabled";
    public const string WirelessGpsEnabled = "Wireless.GPS.Enabled";
    public const string WirelessRefresh = "Wireless.Refresh";
    public const string WirelessAutoRefresh = "Wireless.AutoRefresh";
    public const string ONOFFTYPE_ON = "on";
    public const string ONOFFTYPE_OFF = "off";
    public const string YESNOTYPE_YES = "yes";
    public const string YESNOTYPE_NO = "no";
    public const string BOOLEAN_TRUE = "true";
    public const string BOOLEAN_FALSE = "false";
    public const string CASL_LOG_FILE_NO_PROCESS = "%appdata%\\hpqlog\\casllogs.xml";
    public const string CASL_LOG_FILE_EXTENSION = ".xml";
    public const string CASL_LOG_FILE_PREFIX = "%appdata%\\hpqlog\\casllogs_";
    public const string HP_CASL_NAME = "HP Common Access Library";
    public const string HP_CASL_ASSEMBLY_FULLNAME = "hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097";
    public const string HP_CASL_ASSEMBLY_PUBKEYTOKEN = "9c6f83d5b7f3d097";
    public const string CASL_EMULATION_SUBFOLDER = "\\Hewlett-Packard\\HPSWF\\Emulation\\";
    public const string CASL_ALLUSERSPROFILE = "ALLUSERSPROFILE";
    public const string CASL_APPDATA = "APPDATA";
    public const string CASL_ROOT_CDRIVE = "C:\\";
    public const string CASL_HPQLOG_PLUS_BEGINNING_SLASH = "\\HPQLOG";
    public const int REG_NOTIFY_CHANGE_NAME = 1;
    public const int REG_NOTIFY_CHANGE_ATTRIBUTES = 2;
    public const int REG_NOTIFY_CHANGE_LAST_SET = 4;
    public const int REG_NOTIFY_CHANGE_SECURITY = 8;
    public const int KEY_ALL_ACCESS = 983103;
    public const int KEY_CREATE_LINK = 32;
    public const int KEY_CREATE_SUB_KEY = 4;
    public const int KEY_ENUMERATE_SUB_KEYS = 8;
    public const int KEY_EXECUTE = 131097;
    public const int KEY_NOTIFY = 16;
    public const int KEY_QUERY_VALUE = 1;
    public const int KEY_READ = 131097;
    public const int KEY_SET_VALUE = 2;
    public const int KEY_WOW64_32KEY = 512;
    public const int KEY_WOW64_64KEY = 256;
    public const int KEY_WRITE = 131078;
    public const int HKEY_CLASSES_ROOT = -2147483648;
    public const int HKEY_CURRENT_USER = -2147483647;
    public const int HKEY_LOCAL_MACHINE = -2147483646;
    public const int HKEY_USERS = -2147483645;
    public const int HKEY_PERFORMANCE_DATA = -2147483644;
    public const int HKEY_PERFORMANCE_TEXT = -2147483568;
    public const int HKEY_PERFORMANCE_NLSTEXT = -2147483552;
    public const int HKEY_CURRENT_CONFIG = -2147483643;
    public const int HKEY_DYN_DATA = -2147483642;
    public const int HKEY_UNKNOWN = 0;
    public const uint RRF_RT_ANY = 65535U;
    public const uint RRF_RT_DWORD = 24U;
    public const uint RRF_RT_QWORD = 72U;
    public const uint RRF_RT_REG_BINARY = 8U;
    public const uint RRF_RT_REG_DWORD = 16U;
    public const uint RRF_RT_REG_EXPAND_SZ = 4U;
    public const uint RRF_RT_REG_MULTI_SZ = 32U;
    public const uint RRF_RT_REG_NONE = 1U;
    public const uint RRF_RT_REG_QWORD = 64U;
    public const uint RRF_RT_REG_SZ = 2U;
    public const uint RRF_NOEXPAND = 268435456U;
    public const uint RRF_ZEROONFAILURE = 536870912U;
    public const string SERVICE_NAME_HPQWMIEX = "hpqWmiEx";

    public static string LogFile
    {
      get
      {
        int A_1 = 15;
label_2:
        string A_0 = (string) null;
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = A_0 == null ? 4 : 3;
              continue;
            case 1:
              goto label_5;
            case 2:
              if (1 == 0)
                ;
              try
              {
                A_0 = Process.GetCurrentProcess().ProcessName;
              }
              catch
              {
                A_0 = (string) null;
              }
              num = 0;
              continue;
            case 3:
              num = 1;
              continue;
            case 4:
              goto label_10;
            default:
              goto label_2;
          }
        }
label_5:
        string name = Constants.B(A_0);
        goto label_11;
label_10:
        name = GenericLog.Log.a("慃❅㡇㩉⡋⽍\x244F㍑煓\x0A55し⩙ⵛ\x325Dཟա㡣ե१ᥩkɭὯᕱݳ塵w\x1779ၻ", A_1);
label_11:
        return Environment.ExpandEnvironmentVariables(name);
      }
    }

    public static string EmulationFolder
    {
      get
      {
        int A_1 = 9;
        string A_0 = Environment.GetEnvironmentVariable(GenericLog.Log.a("缽ిแᅃᕅേᡉὋṍɏ\x1D51ቓὕᑗὙ", A_1)) + GenericLog.Log.a("戽\x083F❁㍃⩅ⵇ㹉㡋捍O㍑㝓㵕㥗⡙㡛ɝ⡟㉡㝣ㅥ\x2E67㙩⥫ͭկṱᕳɵᅷᕹቻ≽", A_1);
        if (Constants.A(A_0))
          return A_0;
        if (1 == 0)
          ;
        return GenericLog.Log.a("紽稿ṁ", A_1);
      }
    }

    private static string B(string A_0)
    {
      int A_1 = 2;
      return GenericLog.Log.a("ሶ堸䬺䴼嬾⁀㝂⑄扆ᕈ⍊㵌㹎㵐㱒\x3254ୖ㩘㩚\x2E5C㍞ൠౢɤᑦ㙨", A_1) + (A_0 == null ? string.Empty : A_0) + GenericLog.Log.a("ᤶ䄸嘺儼", A_1);
    }

    private static bool A(string A_0)
    {
      try
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              Directory.CreateDirectory(A_0);
              num = 3;
              continue;
            case 1:
              goto label_7;
            case 3:
              num = 1;
              continue;
            default:
              if (!Directory.Exists(A_0))
              {
                num = 0;
                continue;
              }
              goto case 3;
          }
        }
      }
      catch
      {
      }
label_7:
      if (1 == 0)
        ;
      return Directory.Exists(A_0);
    }
  }
}
