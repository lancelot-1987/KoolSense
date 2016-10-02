// Decompiled with JetBrains decompiler
// Type: GenericPolicy.Policy
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using GenericLog;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace GenericPolicy
{
  public class Policy
  {
    private string A = string.Empty;
    private bool D = true;
    private Dictionary<string, Policy.CPolicies> G = new Dictionary<string, Policy.CPolicies>();
    private string B;
    private string C;
    private Policy.enPolicyType E;
    private Dictionary<string, Policy.CPolicies> F;

    public string SRegistryOverride
    {
      get
      {
        return this.B;
      }
      set
      {
        this.B = value;
      }
    }

    public string SCurrentRegistryOverride
    {
      get
      {
        return this.C;
      }
      set
      {
        this.C = value;
      }
    }

    public Policy.enPolicyType EPolicyType
    {
      get
      {
        return this.E;
      }
      set
      {
        this.E = value;
      }
    }

    public string MasterPolicyFile
    {
      get
      {
        return this.A;
      }
      set
      {
        this.A = value;
      }
    }

    public Policy(Policy.enPolicyType eWhichPolicyType, string sMasterPolicyFile)
    {
      this.Init(eWhichPolicyType, sMasterPolicyFile);
    }

    private bool IsNumeric(string sToCheck)
    {
      int A_1 = 7;
      return Regex.IsMatch(sToCheck, GenericLog.Log.a("戻戽\x243F楁汃ᩅ晇ᙉ⡋敍祏浑灓", A_1));
    }

    public void refresh(Policy.enPolicyType eWhichPolicyType, string sMasterPolicyFile)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = 4;
            continue;
          case 1:
            this.F.Clear();
            num = 0;
            continue;
          case 3:
            this.G.Clear();
            num = 5;
            continue;
          case 4:
            if (this.G != null)
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            goto label_10;
          default:
            if (this.F != null)
            {
              if (1 == 0)
                ;
              num = 1;
              continue;
            }
            goto case 0;
        }
      }
label_10:
      this.Init(this.EPolicyType, this.MasterPolicyFile);
    }

    private void Init(Policy.enPolicyType eWhichPolicyType, string sMasterPolicyFile)
    {
label_2:
      this.EPolicyType = eWhichPolicyType;
      this.MasterPolicyFile = sMasterPolicyFile;
      XmlDocument xdocPolicies = new XmlDocument();
      int num1 = 2;
      XmlDocument xDoc = null;
      bool flag = false;
      while (true)
      {
        switch (num1)
        {
          case 0:
            if (flag)
            {
              num1 = 3;
              continue;
            }
            goto label_22;
          case 1:
            goto label_19;
          case 2:
            try
            {
              if (1 == 0)
                ;
              this.G = this.GetAllPolicies(this.MasterPolicyFile);
              xdocPolicies.LoadXml(this.MasterPolicyFile);
            }
            catch (Exception ex)
            {
              string message = ex.Message;
            }
            this.SRegistryOverride = this.FindPolicyLocation(this.EPolicyType, xdocPolicies);
            this.SCurrentRegistryOverride = this.FindPolicyLocation(this.EPolicyType, xdocPolicies);
            this.F = new Dictionary<string, Policy.CPolicies>();
            xDoc = new XmlDocument();
            flag = false;
            num1 = 4;
            continue;
          case 3:
            try
            {
              this.F = this.GetAllPolicies(xDoc);
              this.CollatePolicyFiles(ref this.G, this.F);
            }
            catch (Exception ex)
            {
              string message = ex.Message;
            }
            this.F = (Dictionary<string, Policy.CPolicies>) null;
            num1 = 1;
            continue;
          case 4:
            try
            {
label_14:
              int policyFromRegistry = this.GetOverridePolicyFromRegistry(ref xDoc);
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    flag = true;
                    num2 = 2;
                    continue;
                  case 1:
                    goto label_8;
                  case 2:
                    num2 = 1;
                    continue;
                  case 3:
                    if (policyFromRegistry == 0)
                    {
                      num2 = 0;
                      continue;
                    }
                    goto case 2;
                  default:
                    goto label_14;
                }
              }
            }
            catch (Exception ex)
            {
              string message = ex.Message;
            }
label_8:
            num1 = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_19:
      return;
label_22:;
    }

    private int GetOverridePolicyFromRegistry(ref XmlDocument xDoc)
    {
      int A_1 = 0;
      int num1 = 0;
      try
      {
label_3:
        string policySkeleton = this.CreatePolicySkeleton();
        xDoc.LoadXml(policySkeleton);
        RegistryKey registryKey = (RegistryKey) null;
        int num2 = 24;
        string[] valueNames=null;
        int index =0;
        XmlNode xmlNode=null;
        string str1=null;
        string name=null;
        string str2=null;
        while (true)
        {
          switch (num2)
          {
            case 0:
              str1 = GenericLog.Log.a("圴堶嘸场", A_1);
              num2 = 14;
              continue;
            case 1:
            case 22:
              num2 = 15;
              continue;
            case 2:
              registryKey = Registry.LocalMachine.OpenSubKey(this.SRegistryOverride);
              num2 = 22;
              continue;
            case 3:
            case 4:
              num2 = 17;
              continue;
            case 5:
              num2 = 18;
              continue;
            case 6:
            case 8:
              num2 = 19;
              continue;
            case 7:
            case 12:
            case 14:
              string xpath = GenericLog.Log.a("ᨴᠶ", A_1) + Policy.enPolicyName.Policies.ToString();
              xmlNode = xDoc.SelectSingleNode(xpath);
              num2 = 13;
              continue;
            case 9:
              ++index;
              num2 = 8;
              continue;
            case 10:
              XmlNode newChild1 = (XmlNode) xDoc.CreateElement(Policy.enPolicyName.Policy.ToString());
              xmlNode.AppendChild(newChild1);
              XmlNode newChild2 = (XmlNode) xDoc.CreateElement(Policy.enPolicyName.Name.ToString());
              newChild2.InnerText = name;
              newChild1.AppendChild(newChild2);
              XmlNode newChild3 = (XmlNode) xDoc.CreateElement(Policy.enPolicyName.Value.ToString());
              newChild3.InnerText = str2;
              newChild1.AppendChild(newChild3);
              XmlNode newChild4 = (XmlNode) xDoc.CreateElement(Policy.enPolicyName.Type.ToString());
              newChild4.InnerText = str1;
              newChild1.AppendChild(newChild4);
              xmlNode.AppendChild(newChild1);
              num2 = 9;
              continue;
            case 11:
              valueNames = registryKey.GetValueNames();
              index = 0;
              num2 = 6;
              continue;
            case 13:
              if (xmlNode != null)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
            case 15:
              if (registryKey == null)
              {
                num1 = 1;
                num2 = 3;
                continue;
              }
              num2 = 11;
              continue;
            case 16:
              if (str2.ToLowerInvariant().CompareTo(Log.a("匴嘶唸䠺堼", A_1)) != 0)
              {
                str1 = Log.a("䘴䌶䬸刺匼堾", A_1);
                num2 = 12;
                continue;
              }
              num2 = 0;
              continue;
            case 17:
              goto label_36;
            case 18:
              if (str2.ToLowerInvariant().CompareTo(Log.a("䄴䔶䰸帺", A_1)) != 0)
              {
                num2 = 20;
                continue;
              }
              goto case 0;
            case 19:
              if (index >= valueNames.Length)
              {
                num2 = 23;
                continue;
              }
              name = valueNames[index];
              str2 = registryKey.GetValue(name).ToString();
              num2 = 21;
              continue;
            case 20:
              num2 = 16;
              continue;
            case 21:
              if (registryKey.GetValueKind(name) == RegistryValueKind.String)
              {
                num2 = 5;
                continue;
              }
              str1 = Log.a("尴夶䴸࠺༼", A_1);
              num2 = 7;
              continue;
            case 23:
              num2 = 4;
              continue;
            case 24:
              if (this.EPolicyType == Policy.enPolicyType.Global)
              {
                num2 = 2;
                continue;
              }
              registryKey = Registry.CurrentUser.OpenSubKey(this.SCurrentRegistryOverride);
              num2 = 1;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        num1 = 1;
      }
label_36:
      if (1 == 0)
        ;
      return num1;
    }

    public int Get(string sName, out object oValue)
    {
      if (1 == 0)
        ;
      string sDefault = (string) null;
      string sError = (string) null;
      string sMinValue = (string) null;
      string sMaxValue = (string) null;
      return this.Get(sName, out oValue, out sDefault, out sMinValue, out sMaxValue, out sError);
    }

    public int Get(string sName, ref bool bValue)
    {
      object oValue = (object) null;
      string sDefault = (string) null;
      string sError = (string) null;
      string sMinValue = (string) null;
      string sMaxValue = (string) null;
      int num = this.Get(sName, out oValue, out sDefault, out sMinValue, out sMaxValue, out sError);
      if (num == 0)
      {
        try
        {
          bValue = (bool) oValue;
        }
        catch (InvalidCastException ex)
        {
          num = 1;
        }
        catch
        {
          num = 1;
        }
      }
      if (1 == 0)
        ;
      return num;
    }

    public int Get(string sName, out object oValue, out string sDefault, out string sMinValue, out string sMaxValue, out string sError)
    {
      int A_1 = 19;
label_3:
      int num1 = 0;
      sDefault = (string) null;
      oValue = (object) null;
      sMinValue = (string) null;
      sMaxValue = (string) null;
      sError = (string) null;
      string sType = (string) null;
      int num2 = 1;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num2)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.G.ContainsKey(sName))
            {
              num2 = 3;
              continue;
            }
            num1 = 4;
            sError = Log.a("େ╉㥋≍㑏牑㩓㥕ⱗ穙㩛㝝\x0E5F١䑣", A_1) + sName + Log.a("桇⍉≋湍⁏㵑㡓㽕㭗⍙籛\x325Dय़ᅡၣ", A_1);
            num2 = 2;
            continue;
          case 2:
            goto label_15;
          case 3:
            sDefault = this.G[sName].Default;
            sMinValue = this.G[sName].MinValue;
            sMaxValue = this.G[sName].MaxValue;
            sType = this.G[sName].Type.ToLowerInvariant();
            oValue = this.G[sName].Value;
            num2 = 0;
            continue;
          default:
            goto label_3;
        }
      }
label_6:
      try
      {
        int num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              num3 = 1;
              continue;
            case 1:
              goto label_15;
            case 3:
              num1 = 2;
              num3 = 0;
              continue;
            default:
              if (!this.ValidateTypeValuePair(sType, ref oValue, out sError))
              {
                num3 = 3;
                continue;
              }
              goto case 0;
          }
        }
      }
      catch (Exception ex)
      {
        sError = Log.a("େ╉㥋≍㑏牑㩓㥕ⱗ穙㽛ㅝ\x0E5Fᑡţᑥᱧ䩩", A_1) + this.G[sName].Value.ToString() + GenericLog.Log.a("桇㹉⍋湍", A_1) + sType + Log.a("桇㹉㕋㹍㕏籑瑓ፕ⁗㥙㥛\x2E5Dᑟୡୣ\x0865剧䩩", A_1) + ex.Message;
        num1 = 1;
      }
label_15:
      return num1;
    }

    public int Set(string sName, string sValue)
    {
      int A_1 = 16;
label_2:
      int num1 = 0;
      string sError = (string) null;
      int num2 = 5;
      while (true)
      {
        switch (num2)
        {
          case 0:
            num2 = 4;
            continue;
          case 1:
            num2 = 2;
            continue;
          case 2:
            if (this.EPolicyType == Policy.enPolicyType.Global)
            {
              num2 = 3;
              continue;
            }
            goto label_13;
          case 3:
            num1 = this.Set(this.EPolicyType, sName, sValue, Log.a("㙄㍆㭈≊⍌⡎", A_1), out sError);
            num2 = 6;
            continue;
          case 4:
            if (this.D)
            {
              num2 = 1;
              continue;
            }
            goto label_13;
          case 5:
            if (this.EPolicyType != Policy.enPolicyType.Current)
            {
              if (1 == 0)
                ;
              num2 = 0;
              continue;
            }
            goto case 3;
          case 6:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return num1;
    }

    public int Set(string sName, bool bValue)
    {
      int A_1 = 3;
label_2:
      int num1 = 0;
      string sError = (string) null;
      int num2 = 8;
      while (true)
      {
        switch (num2)
        {
          case 0:
            if (this.EPolicyType == Policy.enPolicyType.Global)
            {
              num2 = 2;
              continue;
            }
            break;
          case 1:
          case 5:
            goto label_17;
          case 2:
            num1 = this.Set(this.EPolicyType, sName, bValue.ToString(), Log.a("娷唹医刽", A_1), out sError);
            num2 = 9;
            continue;
          case 3:
            if (1 == 0)
              ;
            num2 = 4;
            continue;
          case 4:
            if (this.D)
            {
              num2 = 6;
              continue;
            }
            break;
          case 6:
            num2 = 0;
            continue;
          case 7:
            num2 = 5;
            continue;
          case 8:
            if (this.EPolicyType != Policy.enPolicyType.Current)
            {
              num2 = 3;
              continue;
            }
            goto case 2;
          case 9:
            if (num1 != 0)
            {
              num2 = 7;
              continue;
            }
            goto label_17;
          default:
            goto label_2;
        }
        num1 = 3;
        num2 = 1;
      }
label_17:
      return num1;
    }

    public int Set(Policy.enPolicyType ePolicyType, string sName, string sValue, string sType, out string sError)
    {
      int A_1 = 14;
      int num1 = 6;
      int num2 = 0;
            sError = string.Empty;
      while (true)
      {
        object obj = null;
        bool flag =false;
        int num3=0;
        int num4=0;
        switch (num1)
        {
          case 0:
            if (num2 == 0)
            {
              num1 = 14;
              continue;
            }
            goto label_64;
          case 1:
            try
            {
              int num5 = 11;
              int num6 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    num6 = int.Parse(sValue);
                    num5 = 8;
                    continue;
                  case 1:
                    num5 = 3;
                    continue;
                  case 2:
                    num3 = int.Parse(this.G[sName].MinValue);
                    num5 = 9;
                    continue;
                  case 3:
                    goto label_25;
                  case 4:
                    if (num6 < num3)
                    {
                      num5 = 5;
                      continue;
                    }
                    goto case 1;
                  case 5:
                    num2 = 5;
                    sError = Log.a("ൂ⁄う楈㵊ⱌ⍎\x2450㙒畔畖", A_1) + sValue + Log.a("慂楄杆⁈㡊浌⁎\x2450❒畔㡖㽘筚⽜㹞འѢd䥦", A_1);
                    num5 = 1;
                    continue;
                  case 6:
                    num4 = int.Parse(this.G[sName].MaxValue);
                    num5 = 10;
                    continue;
                  case 7:
                    num5 = 4;
                    continue;
                  case 8:
                    if (num6 <= num4)
                    {
                      num5 = 7;
                      continue;
                    }
                    goto case 5;
                  case 9:
                    if (this.IsNumeric(this.G[sName].MaxValue))
                    {
                      num5 = 6;
                      continue;
                    }
                    goto case 1;
                  case 10:
                    if (this.IsNumeric(sValue))
                    {
                      num5 = 0;
                      continue;
                    }
                    goto case 1;
                  default:
                    if (this.IsNumeric(this.G[sName].MinValue))
                    {
                      num5 = 2;
                      continue;
                    }
                    goto case 1;
                }
              }
            }
            catch (Exception ex)
            {
              num2 = 1;
              sError = ex.Message;
              break;
            }
          case 2:
            if (flag)
            {
              try
              {
                int num5 = 10;
                RegistryKey registryKey = null;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      Registry.CurrentUser.CreateSubKey(this.SRegistryOverride);
                      num5 = 6;
                      continue;
                    case 1:
                      Registry.CurrentUser.CreateSubKey(this.SCurrentRegistryOverride);
                      num5 = 12;
                      continue;
                    case 2:
                      if (sType.CompareTo(Log.a("⩂⭄㍆穈祊", A_1)) != 0)
                      {
                        registryKey.SetValue(sName, obj, RegistryValueKind.String);
                        num5 = 9;
                        continue;
                      }
                      num5 = 4;
                      continue;
                    case 3:
                      if (registryKey == null)
                      {
                        num5 = 1;
                        continue;
                      }
                      goto case 12;
                    case 4:
                      registryKey.SetValue(sName, obj, RegistryValueKind.DWord);
                      num5 = 7;
                      continue;
                    case 5:
                      if (registryKey == null)
                      {
                        num5 = 0;
                        continue;
                      }
                      goto case 6;
                    case 6:
                      registryKey = Registry.CurrentUser.OpenSubKey(this.SRegistryOverride, true);
                      num5 = 14;
                      continue;
                    case 7:
                    case 9:
                      num5 = 13;
                      continue;
                    case 8:
                      registryKey = Registry.LocalMachine.OpenSubKey(this.SRegistryOverride, true);
                      num5 = 5;
                      continue;
                    case 11:
                    case 14:
                      num5 = 2;
                      continue;
                    case 12:
                      registryKey = Registry.CurrentUser.OpenSubKey(this.SCurrentRegistryOverride, true);
                      num5 = 11;
                      continue;
                    case 13:
                      goto label_32;
                    default:
                      if (this.EPolicyType == Policy.enPolicyType.Global)
                      {
                        num5 = 8;
                        continue;
                      }
                      registryKey = Registry.CurrentUser.OpenSubKey(this.SCurrentRegistryOverride, true);
                      num5 = 3;
                      continue;
                  }
                }
              }
              catch (Exception ex)
              {
                num2 = 1;
                sError = ex.Message;
                goto case 4;
              }
            }
            else
            {
              num1 = 5;
              continue;
            }
          case 3:
            sType = Log.a("⩂⭄㍆穈祊", A_1);
            num1 = 12;
            continue;
          case 4:
label_32:
            num1 = 0;
            continue;
          case 5:
            num2 = 3;
            sError = Log.a("โ⑄㑆㵈\x2E4A㽌潎\x2150㱒㥔㹖㩘≚絜ⱞ`ᩢᙤ䝦\x1D68ͪ౬᭮兰ݲᵴṶ\x0A78孺ർၾ\xED80\xEA82\xE684ﺆꦈ\xE88A\xEC8C\xE18E놐\xDD92\xDA94쎖릘連\xF89C뾞캠햢삤햦\xDBA8슪즬쮮풰\xDDB2鮴", A_1);
            num1 = 4;
            continue;
          case 7:
            num1 = 9;
            continue;
          case 8:
            if (this.G.ContainsKey(sName))
            {
              num1 = 15;
              continue;
            }
            break;
          case 9:
            if (sType.ToLowerInvariant().CompareTo(Log.a("⅂⩄⡆╈", A_1)) != 0)
            {
              num1 = 3;
              continue;
            }
            goto case 12;
          case 10:
            goto label_64;
          case 11:
            num1 = 2;
            continue;
          case 12:
            num2 = 0;
            sError = (string) null;
            obj = (object) sValue;
            XmlDocument xmlDocument = new XmlDocument();
            flag = false;
            num3 = 0;
            num4 = 1;
            if (1 == 0)
              ;
            num1 = 8;
            continue;
          case 13:
            if (num2 == 0)
            {
              num1 = 11;
              continue;
            }
            goto case 4;
          case 14:
            this.refresh(this.EPolicyType, this.MasterPolicyFile);
            num1 = 10;
            continue;
          case 15:
            flag = this.G[sName].CanOverride;
            num1 = 1;
            continue;
          default:
            if (sType.ToLowerInvariant().CompareTo(Log.a("あㅄ㕆⁈╊⩌", A_1)) != 0)
            {
              num1 = 7;
              continue;
            }
            goto case 12;
        }
label_25:
        num1 = 13;
      }
label_64:
      return num2;
    }

    private string CreatePolicySkeleton()
    {
      int A_1 = 10;
      if (1 == 0)
        ;
      return Log.a("̾繀㭂⡄⭆楈㵊⡌㵎≐㩒㩔㥖摘祚汜煞兠䅢䕤ɦݨ\x086Aɬ୮ᡰᵲቴ䩶學\x0E7Aॼ\x197E검뮂Ꞅ뢆랈膊", A_1) + Log.a("̾", A_1) + Policy.enPolicyName.Policies.ToString() + Log.a("ľ", A_1) + Log.a("̾湀", A_1) + Policy.enPolicyName.Policies.ToString() + Log.a("ľ", A_1);
    }

    private bool ValidateTypeValuePair(string sType, ref object oValue, out string sError)
    {
      int A_1 = 7;
      sError = string.Empty;
      if (1 == 0)
        ;
      bool flag = true;
      
      try
      {
        int num1 = 17;
        string key1 = null;
        int num2 = 0;
        while (true)
        {
          switch (num1)
          {
            case 0:
              Dictionary<string, int> dictionary = new Dictionary<string, int>(23);
              string key2 = Log.a("伻嘽⼿ぁぃ", A_1);
              int num3 = 0;
              // ISSUE: explicit non-virtual call
               dictionary.Add(key2, num3);
              string key3 = Log.a("唻倽㐿獁牃", A_1);
              int num4 = 1;
              // ISSUE: explicit non-virtual call
           dictionary.Add(key3, num4);
              string key4 = Log.a("唻倽㐿", A_1);
              int num5 = 2;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key4, num5);
              string key5 = Log.a("唻倽㐿煁癃", A_1);
              int num6 = 3;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key5, num6);
              string key6 = Log.a("帻儽⼿\x2E41", A_1);
              int num7 = 4;
              // ISSUE: explicit non-virtual call
      dictionary.Add(key6, num7);
              string key7 = Log.a("帻儽⼿\x2E41⅃❅♇", A_1);
              int num8 = 5;
              // ISSUE: explicit non-virtual call
            dictionary.Add(key7, num8);
              string key8 = Log.a("帻䜽㐿❁", A_1);
              int num9 = 6;
              // ISSUE: explicit non-virtual call
          dictionary.Add(key8, num9);
              string key9 = Log.a("伻尽㤿㙁⅃", A_1);
              int num10 = 7;
              // ISSUE: explicit non-virtual call
           dictionary.Add(key9, num10);
              string key10 = Log.a("弻嘽ℿぁ", A_1);
              int num11 = 8;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key10, num11);
              string key11 = Log.a("堻嬽⌿⭁⥃❅⑇", A_1);
              int num12 = 9;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key11, num12);
              string key12 = Log.a("堻儽㔿⁁⡃⍅", A_1);
              int num13 = 10;
              // ISSUE: explicit non-virtual call
            dictionary.Add(key12, num13);
              string key13 = Log.a("娻刽⼿⍁ぃ", A_1);
              int num14 = 11;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key13, num14);
              string key14 = Log.a("伻圽\x2E3F╁⡃⍅", A_1);
              int num15 = 12;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key14, num15);
              string key15 = Log.a("䤻圽\x2E3F㙁", A_1);
              int num16 = 13;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key15, num16);
              string key16 = Log.a("䤻圽\x2E3F㙁睃瑅", A_1);
              int num17 = 14;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key16, num17);
              string key17 = Log.a("倻儽\x2E3F╁", A_1);
              int num18 = 15;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key17, num18);
              string key18 = Log.a("唻倽㐿瑁灃", A_1);
              int num19 = 16;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key18, num19);
              string key19 = Log.a("䤻刽⼿ⱁ⍃", A_1);
              int num20 = 17;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key19, num20);
              string key20 = Log.a("䤻圽\x2E3F㙁牃牅", A_1);
              int num21 = 18;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key20, num21);
              string key21 = Log.a("医尽⨿❁❃㉅", A_1);
              int num22 = 19;
              // ISSUE: explicit non-virtual call
             dictionary.Add(key21, num22);
              string key22 = Log.a("䤻䴽⠿ⵁ㙃㉅", A_1);
              int num23 = 20;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key22, num23);
              string key23 = Log.a("䤻圽\x2E3F㙁畃灅", A_1);
              int num24 = 21;
              // ISSUE: explicit non-virtual call
            dictionary.Add(key23, num24);
              string key24 = Log.a("伻䨽㈿⭁⩃ⅅ", A_1);
              int num25 = 22;
              // ISSUE: explicit non-virtual call
              dictionary.Add(key24, num25);
              // ISSUE: reference to a compiler-generated field
              global::A.C = dictionary;
              num1 = 4;
              continue;
            case 1:
            case 2:
            case 3:
            case 5:
            case 6:
            case 7:
            case 8:
            case 11:
            case 12:
            case 14:
            case 15:
            case 18:
            case 23:
            case 24:
            case 25:
label_32:
              num1 = 9;
              continue;
            case 4:
              num1 = 22;
              continue;
            case 9:
              goto label_34;
            case 10:
              num1 = 19;
              continue;
            case 13:
              num1 = 16;
              continue;
            case 16:
              switch (num2)
              {
                case 0:
                case 1:
                  oValue = (object) Convert.ToInt16(oValue);
                  num1 = 12;
                  continue;
                case 2:
                case 3:
                  oValue = (object) Convert.ToInt32(oValue);
                  num1 = 14;
                  continue;
                case 4:
                case 5:
                  oValue = Convert.ToBoolean(oValue) ? 1 : 0;
                  num1 = 8;
                  continue;
                case 6:
                  oValue = (object) Convert.ToByte(oValue);
                  num1 = 6;
                  continue;
                case 7:
                  oValue = (object) Convert.ToSByte(oValue);
                  num1 = 15;
                  continue;
                case 8:
                  oValue = (object) Convert.ToChar(oValue);
                  num1 = 18;
                  continue;
                case 9:
                  oValue = (object) Convert.ToDecimal(oValue);
                  num1 = 1;
                  continue;
                case 10:
                  oValue = (object) Convert.ToDouble(oValue);
                  num1 = 11;
                  continue;
                case 11:
                case 12:
                  oValue = (object) Convert.ToSingle(oValue);
                  num1 = 23;
                  continue;
                case 13:
                case 14:
                  oValue = (object) Convert.ToUInt32(oValue);
                  num1 = 2;
                  continue;
                case 15:
                case 16:
                  oValue = (object) Convert.ToInt64(oValue);
                  num1 = 25;
                  continue;
                case 17:
                case 18:
                  oValue = (object) Convert.ToUInt64(oValue);
                  num1 = 3;
                  continue;
                case 19:
                  goto label_32;
                case 20:
                case 21:
                  oValue = (object) Convert.ToUInt16(oValue);
                  num1 = 7;
                  continue;
                case 22:
                  oValue = (object) oValue.ToString();
                  num1 = 5;
                  continue;
                default:
                  num1 = 10;
                  continue;
              }
            case 19:
              sError = Log.a("椻倽㈿❁❃⥅⽇⑉╋㑍㕏㙑瑓≕\x2157⩙㥛摝䁟", A_1) + sType + Log.a("᰻䴽㔿⁁⥃⽅㱇㹉⥋⩍", A_1);
              flag = false;
              oValue = (object) null;
              num1 = 24;
              continue;
            case 20:
              num1 = 21;
              continue;
            case 21:
              // ISSUE: reference to a compiler-generated field
              if (global::A.C == null)
              {
                num1 = 0;
                continue;
              }
              goto case 4;
            case 22:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit non-virtual call
              if (global::A.C.TryGetValue(key1, out num2))
              {
                num1 = 13;
                continue;
              }
              goto case 19;
            default:
              if ((key1 = sType) != null)
              {
                num1 = 20;
                continue;
              }
              goto case 19;
          }
        }
      }
      catch (Exception ex)
      {
        sError = ex.Message;
        flag = false;
      }
label_34:
      return flag;
    }

    private Dictionary<string, Policy.CPolicies> GetAllPolicies(string sPolicyFile)
    {
      XmlDocument xdocPolicies = new XmlDocument();
      xdocPolicies.LoadXml(sPolicyFile);
      return this.GetAllPolicies(xdocPolicies);
    }

    private Dictionary<string, Policy.CPolicies> GetAllPolicies(XmlDocument xdocPolicies)
    {
      int A_1 = 8;
      Dictionary<string, Policy.CPolicies> dictionary = new Dictionary<string, Policy.CPolicies>();
      XmlElement documentElement = xdocPolicies.DocumentElement;
      string xpath = Log.a("ሼှ", A_1) + Policy.enPolicyName.Policies.ToString() + Log.a("ሼ", A_1) + Policy.enPolicyName.Policy.ToString();
      XmlNodeList xmlNodeList1 = xdocPolicies.SelectNodes(xpath);
      string str1 = string.Empty;
      string str2 = string.Empty;
      Policy.CPolicies cpolicies = (Policy.CPolicies) null;
      XmlNode xmlNode1 = (XmlNode) null;
      XmlNode xmlNode2 = (XmlNode) null;
      XmlNode xmlNode3 = (XmlNode) null;
      XmlNode xmlNode4 = (XmlNode) null;
      XmlNode xmlNode5 = (XmlNode) null;
      XmlNode xmlNode6 = (XmlNode) null;
      XmlNode xmlNode7 = (XmlNode) null;
      XmlNode xmlNode8 = (XmlNode) null;
      XmlNodeList xmlNodeList2 = (XmlNodeList) null;
      IEnumerator enumerator1 = xmlNodeList1.GetEnumerator();
      try
      {
        int num1 = 34;
        while (true)
        {
          IEnumerator enumerator2 = null;
          XmlNode xmlNode9 = null;
          switch (num1)
          {
            case 0:
              cpolicies.AdminCanEdit = true;
              num1 = 23;
              continue;
            case 1:
              try
              {
                int num2 = 3;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      num2 = 4;
                      continue;
                    case 1:
                      if (enumerator2.MoveNext())
                      {
                        XmlNode xmlNode10 = (XmlNode) enumerator2.Current;
                        cpolicies.AddPossibleValue(xmlNode10.InnerText);
                        num2 = 2;
                        continue;
                      }
                      num2 = 0;
                      continue;
                    case 4:
                      goto label_62;
                    default:
                      num2 = 1;
                      continue;
                  }
                }
              }
              finally
              {
label_20:
                IDisposable disposable = enumerator2 as IDisposable;
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      disposable.Dispose();
                      num2 = 1;
                      continue;
                    case 1:
                      goto label_24;
                    case 2:
                      if (disposable != null)
                      {
                        num2 = 0;
                        continue;
                      }
                      goto label_24;
                    default:
                      goto label_20;
                  }
                }
label_24:;
              }
            case 2:
              xmlNode4 = xmlNode9.SelectSingleNode(Policy.enPolicyName.MinValue.ToString());
              num1 = 18;
              continue;
            case 3:
              goto label_74;
            case 4:
              cpolicies.MinValue = xmlNode4.InnerText;
              num1 = 8;
              continue;
            case 5:
              num1 = 3;
              continue;
            case 6:
              if (xmlNode2 != null)
              {
                num1 = 22;
                continue;
              }
              cpolicies.DisplayName = cpolicies.Name;
              num1 = 30;
              continue;
            case 7:
            case 30:
              xmlNode3 = xmlNode9.SelectSingleNode(Policy.enPolicyName.Description.ToString());
              num1 = 29;
              continue;
            case 8:
              xmlNode5 = xmlNode9.SelectSingleNode(Policy.enPolicyName.MaxValue.ToString());
              num1 = 21;
              continue;
            case 9:
            case 26:
              xmlNode1 = xmlNode9.SelectSingleNode(Policy.enPolicyName.Default.ToString());
              num1 = 14;
              continue;
            case 10:
              cpolicies.Default = xmlNode1.InnerText;
              num1 = 2;
              continue;
            case 11:
            case 25:
              xmlNode7 = xmlNode9.SelectSingleNode(Policy.enPolicyName.AdminCanEdit.ToString());
              num1 = 33;
              continue;
            case 12:
              xmlNode6 = xmlNode9.SelectSingleNode(Policy.enPolicyName.CanOverride.ToString());
              num1 = 35;
              continue;
            case 13:
            case 23:
              xmlNode8 = xmlNode9.SelectSingleNode(Policy.enPolicyName.PossibleValues.ToString());
              num1 = 16;
              continue;
            case 14:
              if (xmlNode1 != null)
              {
                num1 = 10;
                continue;
              }
              goto case 2;
            case 15:
              if (xmlNode6.InnerText.ToLowerInvariant() == Log.a("䤼䴾㑀♂", A_1))
              {
                num1 = 32;
                continue;
              }
              break;
            case 16:
              if (xmlNode8 != null)
              {
                num1 = 28;
                continue;
              }
              goto label_62;
            case 17:
              if (xmlNode7.InnerText.ToLowerInvariant() == GenericLog.Log.a("䤼䴾㑀♂", A_1))
              {
                num1 = 0;
                continue;
              }
              goto label_40;
            case 18:
              if (xmlNode4 != null)
              {
                num1 = 4;
                continue;
              }
              goto case 8;
            case 19:
              string innerText1 = xmlNode3.InnerText;
              cpolicies.Description = innerText1;
              num1 = 26;
              continue;
            case 21:
              if (xmlNode5 != null)
              {
                num1 = 38;
                continue;
              }
              goto case 12;
            case 22:
              string innerText2 = xmlNode2.InnerText;
              cpolicies.DisplayName = innerText2;
              num1 = 7;
              continue;
            case 24:
              num1 = 15;
              continue;
            case 27:
              if (!enumerator1.MoveNext())
              {
                num1 = 5;
                continue;
              }
              xmlNode9 = (XmlNode) enumerator1.Current;
              cpolicies = new Policy.CPolicies();
              cpolicies.Name = xmlNode9.SelectSingleNode(Policy.enPolicyName.Name.ToString()).InnerText;
              cpolicies.Value = (object) xmlNode9.SelectSingleNode(Policy.enPolicyName.Value.ToString()).InnerText;
              cpolicies.Type = xmlNode9.SelectSingleNode(Policy.enPolicyName.Type.ToString()).InnerText;
              xmlNode2 = xmlNode9.SelectSingleNode(Policy.enPolicyName.DisplayName.ToString());
              num1 = 6;
              continue;
            case 28:
              xmlNodeList2 = xmlNode8.SelectNodes(Policy.enPolicyName.Value.ToString());
              num1 = 37;
              continue;
            case 29:
              if (xmlNode3 == null)
              {
                cpolicies.Description = cpolicies.Name;
                num1 = 9;
                continue;
              }
              num1 = 19;
              continue;
            case 31:
              enumerator2 = xmlNodeList2.GetEnumerator();
              num1 = 1;
              continue;
            case 32:
              cpolicies.CanOverride = true;
              num1 = 11;
              continue;
            case 33:
              if (xmlNode7 != null)
              {
                num1 = 36;
                continue;
              }
              goto label_40;
            case 35:
              if (xmlNode6 != null)
              {
                num1 = 24;
                continue;
              }
              break;
            case 36:
              num1 = 17;
              continue;
            case 37:
              if (xmlNodeList2 != null)
              {
                num1 = 31;
                continue;
              }
              goto label_62;
            case 38:
              cpolicies.MaxValue = xmlNode5.InnerText;
              num1 = 12;
              continue;
            default:
              num1 = 27;
              continue;
          }
          cpolicies.CanOverride = false;
          num1 = 25;
          continue;
label_40:
          cpolicies.AdminCanEdit = false;
          num1 = 13;
          continue;
label_62:
          dictionary.Add(cpolicies.Name, cpolicies);
          num1 = 20;
        }
      }
      finally
      {
label_69:
        IDisposable disposable = enumerator1 as IDisposable;
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              if (disposable != null)
              {
                num = 1;
                continue;
              }
              goto label_73;
            case 1:
              disposable.Dispose();
              num = 2;
              continue;
            case 2:
              goto label_73;
            default:
              goto label_69;
          }
        }
label_73:;
      }
label_74:
      if (1 == 0)
        ;
      return dictionary;
    }

    private void CollatePolicyFiles(ref Dictionary<string, Policy.CPolicies> dMasterPolicy, Dictionary<string, Policy.CPolicies> dOverridePolicy)
    {
      using (Dictionary<string, Policy.CPolicies>.KeyCollection.Enumerator enumerator = dMasterPolicy.Keys.GetEnumerator())
      {
        int num = 6;
        while (true)
        {
          string current = null;
          switch (num)
          {
            case 0:
              if (dMasterPolicy[current].CanOverride)
              {
                num = 11;
                continue;
              }
              break;
            case 1:
              num = 9;
              continue;
            case 2:
              dMasterPolicy[current].Type = dOverridePolicy[current].Type;
              num = 10;
              continue;
            case 3:
              if (!enumerator.MoveNext())
              {
                num = 1;
                continue;
              }
              current = enumerator.Current;
              num = 7;
              continue;
            case 4:
              dMasterPolicy[current].Default = dOverridePolicy[current].Default;
              num = 2;
              continue;
            case 5:
              if (dOverridePolicy[current].Default != null)
              {
                num = 4;
                continue;
              }
              goto case 2;
            case 7:
              if (dOverridePolicy.ContainsKey(current))
              {
                num = 8;
                continue;
              }
              break;
            case 8:
              num = 0;
              continue;
            case 9:
              goto label_19;
            case 11:
              dMasterPolicy[current].Value = dOverridePolicy[current].Value;
              num = 5;
              continue;
          }
          num = 3;
        }
label_19:
        if (1 != 0)
          ;
      }
    }

    private string FindPolicyLocation(Policy.enPolicyType ePolicy, XmlDocument xdocPolicies)
    {
      int A_1 = 13;
label_3:
      string str = string.Empty;
      string xpath = Log.a("流歃ᙅ❇♉╋ⵍ㥏㝑❓祕ὗ㽙\x325B㭝\x125F͡\x0863䥥", A_1) + ePolicy.ToString();
      XmlNode xmlNode = xdocPolicies.SelectSingleNode(xpath);
      int num = 2;
      while (true)
      {
        if (1 == 0)
          ;
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            str = xmlNode.InnerText;
            num = 0;
            continue;
          case 2:
            if (xmlNode != null)
            {
              num = 1;
              continue;
            }
            goto label_7;
          default:
            goto label_3;
        }
      }
label_7:
      return str;
    }

    public enum enPolicyName
    {
      Policies,
      Policy,
      Name,
      Value,
      Type,
      Default,
      MinValue,
      MaxValue,
      CanOverride,
      DisplayName,
      Description,
      AdminCanEdit,
      PossibleValues,
    }

    public enum enPolicyType
    {
      Global,
      Current,
    }

    public class CPolicies
    {
      private string A;
      private string B;
      private string C;
      private bool D;
      private Dictionary<string, string> E;
      private string F;
      private object G;
      private string H;
      private string I;
      private string J;
      private bool K;

      public string Name
      {
        get
        {
          return this.A;
        }
        set
        {
          this.A = value;
        }
      }

      public string DisplayName
      {
        get
        {
          return this.B;
        }
        set
        {
          this.B = value;
        }
      }

      public string Description
      {
        get
        {
          return this.C;
        }
        set
        {
          this.C = value;
        }
      }

      public bool AdminCanEdit
      {
        get
        {
          return this.D;
        }
        set
        {
          this.D = value;
        }
      }

      public string[] PossibleValues
      {
        get
        {
label_2:
          string[] strArray = (string[]) null;
          int num1 = 1;
          Dictionary<string, string>.Enumerator enumerator = new Dictionary<string, string>.Enumerator();
          int index = 0;
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_16;
              case 1:
                if (1 == 0)
                  ;
                if (this.E != null)
                {
                  num1 = 2;
                  continue;
                }
                strArray = new string[0];
                num1 = 0;
                continue;
              case 2:
                strArray = new string[this.E.Count];
                index = 0;
                enumerator = this.E.GetEnumerator();
                num1 = 3;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_2;
            }
          }
label_6:
          try
          {
            int num2 = 3;
            while (true)
            {
              switch (num2)
              {
                case 0:
                  goto label_16;
                case 2:
                  num2 = 0;
                  continue;
                case 4:
                  if (enumerator.MoveNext())
                  {
                    KeyValuePair<string, string> current = enumerator.Current;
                    strArray[index] = current.Key;
                    ++index;
                    num2 = 1;
                    continue;
                  }
                  num2 = 2;
                  continue;
                default:
                  num2 = 4;
                  continue;
              }
            }
          }
          finally
          {
            enumerator.Dispose();
          }
label_16:
          return strArray;
        }
      }

      public string Default
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

      public string Type
      {
        get
        {
          return this.H;
        }
        set
        {
          this.H = value;
        }
      }

      public object Value
      {
        get
        {
          return this.G;
        }
        set
        {
          this.G = value;
        }
      }

      public string MinValue
      {
        get
        {
          return this.I;
        }
        set
        {
          this.I = value;
        }
      }

      public string MaxValue
      {
        get
        {
          return this.J;
        }
        set
        {
          this.J = value;
        }
      }

      public bool CanOverride
      {
        get
        {
          return this.K;
        }
        set
        {
          this.K = value;
        }
      }

      public CPolicies()
      {
        this.A = (string) null;
        this.G = (object) null;
        this.H = (string) null;
        this.F = (string) null;
        this.I = (string) null;
        this.J = (string) null;
        this.B = (string) null;
        this.C = (string) null;
        this.K = false;
        this.D = false;
        this.E = (Dictionary<string, string>) null;
      }

      public bool AddPossibleValue(string sValue)
      {
label_2:
        if (1 == 0)
          ;
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              this.E = new Dictionary<string, string>();
              num = 0;
              continue;
            case 2:
              if (this.E == null)
              {
                num = 1;
                continue;
              }
              goto label_6;
            default:
              goto label_2;
          }
        }
label_6:
        try
        {
          this.E[sValue] = sValue;
          return true;
        }
        catch
        {
          return false;
        }
      }
    }
  }
}
