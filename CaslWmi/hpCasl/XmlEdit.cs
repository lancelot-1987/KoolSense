// Decompiled with JetBrains decompiler
// Type: hpCasl.XmlEdit
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace hpCasl
{
  internal class XmlEdit
  {
    private const bool logNodeNotFoundWarnings = true;
    private XmlDocument xDoc;
    private XmlNamespaceManager xnm;

    public XmlDocument XmlDoc
    {
      get
      {
        return this.xDoc;
      }
    }

    public XmlEdit(XmlDocument xmlDoc)
    {
      int A_1 = 15;
      // ISSUE: explicit constructor call

      this.xDoc = new XmlDocument();
      this.xDoc.LoadXml(xmlDoc.OuterXml);
      this.xnm = new XmlNamespaceManager(this.xDoc.NameTable);
      this.xnm.AddNamespace(Module.a("㭔\x2456桘", A_1), this.xDoc.DocumentElement.NamespaceURI);
    }

    public string GetString(string sNode)
    {
      int A_1 = 3;
      string str = (string) null;
      try
      {
        if (1 == 0)
          ;
        str = this.xDoc.SelectSingleNode(Regex.Replace(sNode, Module.a("慈瑊煌牎繐⽒\x0B54繖煘摚恜͞ᙠ䩢䵤塦䡨㝪ᩬ䑮䭰婲", A_1), Module.a("❈㡊籌畎", A_1)), this.xnm).InnerText;
      }
      catch
      {
        CaslLogger caslLogger = new CaslLogger();
        string sMessage = Module.a("݈⑊⥌⩎煐\x1D52㩔⍖祘\x1D5A\x325C⩞འݢ彤", A_1) + sNode;
        caslLogger.WarningMessage(this.GetType().ToString(), Module.a("่\x2E4A㥌ᱎ═\x2152㱔㥖㹘", A_1), sMessage);
      }
      return str;
    }

    public string[] GetStrings(string sNode)
    {
      int A_1 = 11;
      string[] strArray = (string[]) null;
      try
      {
        XmlNodeList xmlNodeList = this.xDoc.SelectNodes(Regex.Replace(sNode, Module.a("祐汒楔橖癘❚͜癞䥠屢塤㭦Ṩ䉪䕬偮偰⽲ɴ屶䍸剺", A_1), Module.a("㽐⁒摔浖", A_1)), this.xnm);
        strArray = new string[xmlNodeList.Count];
        int num1 = 0;
        IEnumerator enumerator = xmlNodeList.GetEnumerator();
        try
        {
          int num2 = 3;
          while (true)
          {
            switch (num2)
            {
              case 0:
                num2 = 2;
                continue;
              case 1:
                if (enumerator.MoveNext())
                {
                  XmlNode xmlNode = (XmlNode) enumerator.Current;
                  strArray[num1++] = xmlNode.InnerText;
                  num2 = 4;
                  continue;
                }
                num2 = 0;
                continue;
              case 2:
                goto label_17;
              default:
                num2 = 1;
                continue;
            }
          }
        }
        finally
        {
label_11:
          IDisposable disposable = enumerator as IDisposable;
          int num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 0:
                if (disposable != null)
                {
                  num2 = 2;
                  continue;
                }
                goto label_15;
              case 1:
                goto label_15;
              case 2:
                disposable.Dispose();
                num2 = 1;
                continue;
              default:
                goto label_11;
            }
          }
label_15:;
        }
      }
      catch
      {
      }
label_17:
      if (1 == 0)
        ;
      return strArray;
    }

    public ushort[] GetUInt16s(string sNode)
    {
      ushort[] numArray = (ushort[]) null;
      try
      {
label_3:
        string[] strings = this.GetStrings(sNode);
        numArray = new ushort[strings.Length];
        int num1 = 0;
        string[] strArray = strings;
        int index = 0;
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
            case 2:
              num2 = 4;
              continue;
            case 3:
              num2 = 0;
              continue;
            case 4:
              if (index < strArray.Length)
              {
                string str = strArray[index];
                numArray[num1++] = Convert.ToUInt16(str);
                ++index;
                num2 = 2;
                continue;
              }
              num2 = 3;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch
      {
      }
label_10:
      if (1 == 0)
        ;
      return numArray;
    }

    public ushort GetUInt16(string sNode)
    {
      ushort num = (ushort) 0;
      string @string = this.GetString(sNode);
      if (@string != null)
      {
        try
        {
          num = Convert.ToUInt16(@string);
        }
        catch
        {
        }
        return num;
      }
      if (1 == 0)
        ;
      return (ushort) 0;
    }

    public ushort GetUInt16(string sNode, int iBase)
    {
      ushort num = (ushort) 0;
      string @string = this.GetString(sNode);
      if (@string == null)
      {
        if (1 == 0)
          ;
        return (ushort) 0;
      }
      try
      {
        num = Convert.ToUInt16(@string, iBase);
      }
      catch
      {
      }
      return num;
    }

    public uint GetUInt32(string sNode)
    {
      uint num = 0U;
      string @string = this.GetString(sNode);
      if (@string == null)
      {
        if (1 == 0)
          ;
        return 0U;
      }
      try
      {
        num = Convert.ToUInt32(@string);
      }
      catch
      {
      }
      return num;
    }

    public uint GetUInt32(string sNode, int iBase)
    {
      uint num = 0U;
      string @string = this.GetString(sNode);
      if (@string != null)
      {
        try
        {
          num = Convert.ToUInt32(@string, iBase);
        }
        catch
        {
        }
        return num;
      }
      if (1 == 0)
        ;
      return 0U;
    }

    public ulong GetUInt64(string sNode)
    {
      ulong num = 0UL;
      string @string = this.GetString(sNode);
      if (@string != null)
      {
        try
        {
          num = Convert.ToUInt64(@string);
        }
        catch
        {
        }
        return num;
      }
      if (1 == 0)
        ;
      return 0UL;
    }

    public byte GetByte(string sNode)
    {
      if (1 == 0)
        ;
      byte num = (byte) 0;
      string @string = this.GetString(sNode);
      if (@string == null)
        return (byte) 0;
      try
      {
        num = Convert.ToByte(@string);
      }
      catch
      {
      }
      return num;
    }

    public byte[] GetBytes(string sNode)
    {
      byte[] numArray;
      try
      {
label_3:
        string[] strArray1 = this.GetString(sNode).Split(',');
        numArray = new byte[strArray1.Length];
        int num1 = 0;
        string[] strArray2 = strArray1;
        int index = 0;
        if (1 == 0)
          ;
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              if (index < strArray2.Length)
              {
                string str = strArray2[index];
                numArray[num1++] = Convert.ToByte(str, 16);
                ++index;
                num2 = 3;
                continue;
              }
              num2 = 1;
              continue;
            case 1:
              num2 = 4;
              continue;
            case 2:
            case 3:
              num2 = 0;
              continue;
            case 4:
              goto label_11;
            default:
              goto label_3;
          }
        }
      }
      catch
      {
        numArray = (byte[]) null;
      }
label_11:
      return numArray;
    }

    public enReturnCode SetBytes(string sNode, byte[] bytes)
    {
      int A_1 = 19;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      try
      {
label_3:
        XmlNode xmlNode1 = this.xDoc.SelectSingleNode(Regex.Replace(sNode, Module.a("煘摚慜扞习ὢ㭤书䅨呪偬㍮ٰ婲嵴䡶塸\x277A\x0A7C呾뮀ꪂ", A_1), Module.a("㝘⡚汜敞", A_1)), this.xnm);
        xmlNode1.InnerText = string.Empty;
        int index = 0;
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 0:
            case 7:
              num = 4;
              continue;
            case 1:
              goto label_16;
            case 2:
              num = 1;
              continue;
            case 3:
              if (index < bytes.Length - 1)
              {
                num = 5;
                continue;
              }
              XmlNode xmlNode2 = xmlNode1;
              string str1 = xmlNode2.InnerText + Module.a("楘⍚", A_1) + bytes[index].ToString(Module.a("Ř楚", A_1));
              xmlNode2.InnerText = str1;
              num = 6;
              continue;
            case 4:
              if (index >= bytes.Length)
              {
                if (1 == 0)
                  ;
                num = 2;
                continue;
              }
              num = 3;
              continue;
            case 5:
              XmlNode xmlNode3 = xmlNode1;
              string str2 = xmlNode3.InnerText + Module.a("楘⍚", A_1) + bytes[index].ToString(Module.a("Ř楚", A_1)) + Module.a("畘", A_1);
              xmlNode3.InnerText = str2;
              num = 8;
              continue;
            case 6:
            case 8:
              ++index;
              num = 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch
      {
        CaslLogger caslLogger = new CaslLogger();
        string sMessage = Module.a("\x1758㑚㥜㩞䅠ⵢ\x0A64፦䥨\x2D6Aɬᩮὰᝲ佴", A_1) + sNode;
        caslLogger.WarningMessage(this.GetType().ToString(), Module.a("\x0A58㹚⥜\x0C5Eᕠᅢ\x0C64०\x0E68", A_1), sMessage);
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_16:
      return enReturnCode;
    }

    public double GetDouble(string sNode)
    {
      if (1 == 0)
        ;
      double num = 0.0;
      string @string = this.GetString(sNode);
      if (@string == null)
        return 0.0;
      try
      {
        num = Convert.ToDouble(@string, (IFormatProvider) CultureInfo.InvariantCulture);
      }
      catch
      {
      }
      return num;
    }

    public bool GetBool(string sNode)
    {
      int A_1 = 0;
label_2:
      bool flag = false;
      string @string = this.GetString(sNode);
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (!(@string.ToLowerInvariant() == Module.a("⥅♇", A_1)))
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 1:
            num = 0;
            continue;
          case 2:
            num = 5;
            continue;
          case 3:
            goto label_11;
          case 4:
            flag = true;
            num = 8;
            continue;
          case 5:
            if (@string.ToLowerInvariant() == Module.a("㽅ⵇ㥉", A_1))
            {
              num = 4;
              continue;
            }
            goto label_17;
          case 6:
            if (!(@string.ToLowerInvariant() == Module.a("㉅㩇㽉⥋", A_1)))
            {
              num = 1;
              continue;
            }
            goto case 4;
          case 7:
            if (@string == null)
            {
              num = 3;
              continue;
            }
            if (1 == 0)
              ;
            num = 6;
            continue;
          case 8:
            goto label_17;
          default:
            goto label_2;
        }
      }
label_11:
      return false;
label_17:
      return flag;
    }

    public void SetString(string sNode, string sText)
    {
      int A_1 = 17;
      try
      {
        this.xDoc.SelectSingleNode(Regex.Replace(sNode, Module.a("罖晘杚恜灞\x1D60㵢䱤佦器噪ㅬᡮ塰孲䩴噶╸\x0C7A噼䕾ꢀ", A_1), Module.a("㥖⩘橚杜", A_1)), this.xnm).InnerText = sText;
      }
      catch
      {
        CaslLogger caslLogger = new CaslLogger();
        string sMessage = Module.a("ᥖ㙘㽚㡜罞⽠ౢᅤ䝦⽨ѪᡬŮᕰ䥲", A_1) + sNode;
        caslLogger.WarningMessage(this.GetType().ToString(), Module.a("і㱘⽚\x0E5C\x2B5E፠\x0A62\x0B64f", A_1), sMessage);
      }
      if (1 != 0)
        ;
    }

    public void SetUInt32(string sNode, uint nValue)
    {
      this.SetString(sNode, nValue.ToString());
    }

    public void SetUInt64(string sNode, ulong nValue)
    {
      this.SetString(sNode, nValue.ToString());
    }

    public void SetByte(string sNode, byte nValue)
    {
      this.SetString(sNode, nValue.ToString());
    }

    public void SetDouble(string sNode, double nValue)
    {
      this.SetString(sNode, nValue.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public void Set(string sNode, object Value)
    {
      this.SetString(sNode, Value.ToString());
    }

    public void SetBool(string sNode, bool bValue)
    {
      int A_1 = 0;
      this.SetString(sNode, bValue ? Module.a("㉅㩇㽉⥋", A_1) : Module.a("⁅⥇♉㽋\x2B4D", A_1));
    }

    public void SetBools(XmlEdit.XmlNodeBool[] xmlNodeBools, byte[] bArray)
    {
label_2:
      if (1 == 0)
        ;
      XmlEdit.XmlNodeBool[] xmlNodeBoolArray = xmlNodeBools;
      int index = 0;
      int num = 2;
            XmlEdit.XmlNodeBool xmlNodeBool = new XmlNodeBool() ;
      bool bValue = false;
      while (true)
      {
        switch (num)
        {
          case 0:
            this.SetBool(xmlNodeBool.sNode, bValue);
            ++index;
            num = 5;
            continue;
          case 1:
            if (index < xmlNodeBoolArray.Length)
            {
              xmlNodeBool = xmlNodeBoolArray[index];
              bValue = Utility.GetBit(bArray[xmlNodeBool.nByte], xmlNodeBool.nBit);
              num = 3;
              continue;
            }
            num = 6;
            continue;
          case 2:
          case 5:
            num = 1;
            continue;
          case 3:
            if (xmlNodeBool.bInverted)
            {
              num = 4;
              continue;
            }
            goto case 0;
          case 4:
            bValue = !bValue;
            num = 0;
            continue;
          case 6:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_12:;
    }

    public void SetByte(XmlEdit.XmlNodeByte[] xmlNodeBytes, byte[] bArray)
    {
label_2:
      XmlEdit.XmlNodeByte[] xmlNodeByteArray = xmlNodeBytes;
      int index = 0;
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (index >= xmlNodeByteArray.Length)
            {
              if (1 == 0)
                ;
              num = 1;
              continue;
            }
            XmlEdit.XmlNodeByte xmlNodeByte = xmlNodeByteArray[index];
            this.SetByte(xmlNodeByte.sNode, bArray[xmlNodeByte.nByte]);
            ++index;
            num = 2;
            continue;
          case 1:
            goto label_8;
          case 2:
          case 3:
            num = 0;
            continue;
          default:
            goto label_2;
        }
      }
label_8:;
    }

    public void GetBools(XmlEdit.XmlNodeBool[] boolNodes, ref byte[] bArray)
    {
label_2:
      XmlEdit.XmlNodeBool[] xmlNodeBoolArray = boolNodes;
      int index = 0;
      int num = 2;
      XmlEdit.XmlNodeBool xmlNodeBool= new XmlNodeBool();
      bool bState=false;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            if (1 == 0)
              ;
            if (index < xmlNodeBoolArray.Length)
            {
              xmlNodeBool = xmlNodeBoolArray[index];
              bState = this.GetBool(xmlNodeBool.sNode);
              num = 6;
              continue;
            }
            num = 0;
            continue;
          case 2:
          case 3:
            num = 1;
            continue;
          case 4:
            Utility.SetBit(ref bArray[xmlNodeBool.nByte], xmlNodeBool.nBit, bState);
            ++index;
            num = 3;
            continue;
          case 5:
            bState = !bState;
            num = 4;
            continue;
          case 6:
            if (xmlNodeBool.bInverted)
            {
              num = 5;
              continue;
            }
            goto case 4;
          default:
            goto label_2;
        }
      }
label_12:;
    }

    public void GetByte(XmlEdit.XmlNodeByte[] xmlNodeBytes, ref byte[] bArray)
    {
      if (1 == 0)
        ;
label_2:
      XmlEdit.XmlNodeByte[] xmlNodeByteArray = xmlNodeBytes;
      int index = 0;
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            if (index >= xmlNodeByteArray.Length)
            {
              num = 2;
              continue;
            }
            XmlEdit.XmlNodeByte xmlNodeByte = xmlNodeByteArray[index];
            bArray[xmlNodeByte.nByte] = this.GetByte(xmlNodeByte.sNode);
            ++index;
            num = 3;
            continue;
          case 1:
          case 3:
            num = 0;
            continue;
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_7:;
    }

    public struct XmlNodeBool
    {
      public string sNode;
      public int nByte;
      public int nBit;
      public bool bInverted;

      public XmlNodeBool(string Node, int Byte, int Bit, bool Inverted)
      {
        this.sNode = Node;
        this.nByte = Byte;
        this.nBit = Bit;
        this.bInverted = Inverted;
      }
    }

    public struct XmlNodeByte
    {
      public string sNode;
      public int nByte;

      public XmlNodeByte(string Node, int Byte)
      {
        this.sNode = Node;
        this.nByte = Byte;
      }
    }
  }
}
