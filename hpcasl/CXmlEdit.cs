// Decompiled with JetBrains decompiler
// Type: hpCasl.CXmlEdit
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace hpCasl
{
  internal class CXmlEdit
  {
    private XmlDocument m_xDoc;
    private XmlNamespaceManager m_xnm;
    private static bool m_bLogNodeNotFoundWarnings;

    public XmlDocument XmlDoc
    {
      get
      {
        return this.m_xDoc;
      }
    }

    public CXmlEdit(XmlDocument xDoc)
    {
      int A_1 = 6;
      // ISSUE: explicit constructor call
      this.m_xDoc = new XmlDocument();
      this.m_xDoc.LoadXml(xDoc.OuterXml);
      this.m_xnm = new XmlNamespaceManager(this.m_xDoc.NameTable);
      this.m_xnm.AddNamespace(Casl.a("\xED82\xF684뚆", A_1), this.m_xDoc.DocumentElement.NamespaceURI);
    }

    public string GetString(string sNode)
    {
      int A_1 = 3;
      string str = (string) null;
      try
      {
        if (1 == 0)
          ;
        str = this.m_xDoc.SelectSingleNode(Regex.Replace(sNode, Casl.a("\xA87F북뢃뮅ꞇ\xF689튋Ɥ뢏궑ꦓ쪕\xEF97뎙뒛ꆝ膟ﺡ펣趥銧莩", A_1), Casl.a("\xEE7F\xF181떃벅", A_1)), this.m_xnm).InnerText;
      }
      catch
      {
        if (CXmlEdit.m_bLogNodeNotFoundWarnings)
        {
          string sMessage = Casl.a("칿\xED81\xE083\xE385ꢇ쒉\xE38B揄낏풑ﮓ\xE395\xF697ﺙ\xA69B", A_1) + sNode;
          Global.Log.WarningMessage(this.GetType().ToString(), Casl.a("읿\xE781\xF083햅ﲇ\xF889\xE58B\xE08D\xF78F", A_1), sMessage);
        }
      }
      return str;
    }

    public string[] GetStrings(string sNode)
    {
      int A_1 = 3;
      string[] strArray = (string[]) null;
      try
      {
        XmlNodeList xmlNodeList = this.m_xDoc.SelectNodes(Regex.Replace(sNode, Casl.a("\xA87F북뢃뮅ꞇ\xF689튋Ɥ뢏궑ꦓ쪕\xEF97뎙뒛ꆝ膟ﺡ펣趥銧莩", A_1), Casl.a("\xEE7F\xF181떃벅", A_1)), this.m_xnm);
        strArray = new string[xmlNodeList.Count];
        int num1 = 0;
        IEnumerator enumerator = xmlNodeList.GetEnumerator();
        try
        {
          int num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                if (enumerator.MoveNext())
                {
                  XmlNode xmlNode = (XmlNode) enumerator.Current;
                  strArray[num1++] = xmlNode.InnerText;
                  num2 = 1;
                  continue;
                }
                num2 = 4;
                continue;
              case 3:
                goto label_17;
              case 4:
                num2 = 3;
                continue;
              default:
                num2 = 0;
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
                  num2 = 1;
                  continue;
                }
                goto label_15;
              case 1:
                disposable.Dispose();
                num2 = 2;
                continue;
              case 2:
                goto label_15;
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

    public uint GetUInt32(string sNode)
    {
      uint num = 0U;
      string @string = this.GetString(sNode);
      if (@string == null)
        return 0U;
      try
      {
        num = Convert.ToUInt32(@string);
      }
      catch
      {
      }
      if (1 == 0)
        ;
      return num;
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
      byte num = (byte) 0;
      string @string = this.GetString(sNode);
      if (@string == null)
      {
        if (1 == 0)
          ;
        return (byte) 0;
      }
      try
      {
        num = Convert.ToByte(@string);
      }
      catch
      {
      }
      return num;
    }

    public double GetDouble(string sNode)
    {
      double num = 0.0;
      string @string = this.GetString(sNode);
      if (@string == null)
      {
        if (1 == 0)
          ;
        return 0.0;
      }
      try
      {
        num = Convert.ToDouble(@string, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      }
      catch
      {
      }
      return num;
    }

    public bool GetBool(string sNode)
    {
      int A_1 = 15;
label_2:
      bool flag = false;
      string @string = this.GetString(sNode);
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            num = @string != null ? 6 : 5;
            continue;
          case 1:
            if (1 == 0)
              ;
            num = 2;
            continue;
          case 2:
            if (@string.ToLowerInvariant() == Casl.a("\xF58B\xEB8D\xE38F", A_1))
            {
              num = 4;
              continue;
            }
            goto label_15;
          case 3:
            if (!(@string.ToLowerInvariant() == Casl.a("\xE38B\xE08D", A_1)))
            {
              num = 1;
              continue;
            }
            goto case 4;
          case 4:
            flag = true;
            num = 7;
            continue;
          case 5:
            goto label_11;
          case 6:
            if (!(@string.ToLowerInvariant() == Casl.a("\xF88Bﲍ\xE58F\xF791", A_1)))
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 7:
            goto label_15;
          case 8:
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_11:
      return false;
label_15:
      return flag;
    }

    public void SetString(string sNode, string sText)
    {
      int A_1 = 8;
      try
      {
        if (1 == 0)
          ;
        this.m_xDoc.SelectSingleNode(Regex.Replace(sNode, Casl.a("궄뢆떈뚊ꊌ\xF38E쾐몒붔ꢖ꒘잚\xEA9C뚞覠鲢蒤ﮦ\xDEA8肪鞬蚮", A_1), Casl.a("\xEB84\xF486뢈놊", A_1)), this.m_xnm).InnerText = sText;
      }
      catch
      {
        if (!CXmlEdit.m_bLogNodeNotFoundWarnings)
          return;
        string sMessage = Casl.a("쮄\xE886\xED88\xEE8A권솎ﺐ\xE792떔톖\xF698\xEE9A\xF39Cﮞ鮠", A_1) + sNode;
        Global.Log.WarningMessage(this.GetType().ToString(), Casl.a("횄\xE286ﶈ\xD88A歷ﶎ\xF890ﶒ\xF294", A_1), sMessage);
      }
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
      this.SetString(sNode, nValue.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
    }

    public void Set(string sNode, object Value)
    {
      this.SetString(sNode, Value.ToString());
    }

    public void SetBool(string sNode, bool bValue)
    {
      int A_1 = 3;
      this.SetString(sNode, bValue ? Casl.a("\xF47F\xF081\xF183\xE385", A_1) : Casl.a("\xE67F\xE381\xE883\xF585\xED87", A_1));
    }

    public void SetBool(CXmlEdit.XmlNodeBool[] xmlNodeBools, byte[] bArray)
    {
label_3:
      CXmlEdit.XmlNodeBool[] xmlNodeBoolArray = xmlNodeBools;
      int index = 0;
      int num = 3;
      while (true)
      {
        if (1 == 0)
          ;
        CXmlEdit.XmlNodeBool xmlNodeBool = new XmlNodeBool();
        bool bValue =false;
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            if (xmlNodeBool.bInverted)
            {
              num = 5;
              continue;
            }
            goto case 6;
          case 2:
            if (index < xmlNodeBoolArray.Length)
            {
              xmlNodeBool = xmlNodeBoolArray[index];
              bValue = Util.GetBit(bArray[xmlNodeBool.nByte], xmlNodeBool.nBit);
              num = 1;
              continue;
            }
            num = 0;
            continue;
          case 3:
          case 4:
            num = 2;
            continue;
          case 5:
            bValue = !bValue;
            num = 6;
            continue;
          case 6:
            this.SetBool(xmlNodeBool.sNode, bValue);
            ++index;
            num = 4;
            continue;
          default:
            goto label_3;
        }
      }
label_12:;
    }

    public void SetByte(CXmlEdit.XmlNodeByte[] xmlNodeBytes, byte[] bArray)
    {
label_2:
      CXmlEdit.XmlNodeByte[] xmlNodeByteArray = xmlNodeBytes;
      int index = 0;
      if (1 == 0)
        ;
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
          case 2:
            num = 3;
            continue;
          case 3:
            if (index >= xmlNodeByteArray.Length)
            {
              num = 0;
              continue;
            }
            CXmlEdit.XmlNodeByte xmlNodeByte = xmlNodeByteArray[index];
            this.SetByte(xmlNodeByte.sNode, bArray[xmlNodeByte.nByte]);
            ++index;
            num = 1;
            continue;
          default:
            goto label_2;
        }
      }
label_8:;
    }

    public void GetBool(CXmlEdit.XmlNodeBool[] boolNodes, ref byte[] bArray)
    {
label_2:
      CXmlEdit.XmlNodeBool[] xmlNodeBoolArray = boolNodes;
      int index = 0;
      int num = 1;
      CXmlEdit.XmlNodeBool xmlNodeBool = new CXmlEdit.XmlNodeBool();
      bool bState = false;
      while (true)
      {
        switch (num)
        {
          case 0:
            bState = !bState;
            num = 5;
            continue;
          case 1:
          case 3:
            num = 6;
            continue;
          case 2:
            if (xmlNodeBool.bInverted)
            {
              num = 0;
              continue;
            }
            goto case 5;
          case 4:
            goto label_12;
          case 5:
            if (1 == 0)
              ;
            Util.SetBit(ref bArray[xmlNodeBool.nByte], xmlNodeBool.nBit, bState);
            ++index;
            num = 3;
            continue;
          case 6:
            if (index < xmlNodeBoolArray.Length)
            {
              xmlNodeBool = xmlNodeBoolArray[index];
              bState = this.GetBool(xmlNodeBool.sNode);
              num = 2;
              continue;
            }
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_12:;
    }

    public void GetByte(CXmlEdit.XmlNodeByte[] xmlNodeBytes, ref byte[] bArray)
    {
label_2:
      CXmlEdit.XmlNodeByte[] xmlNodeByteArray = xmlNodeBytes;
      int index = 0;
      if (1 == 0)
        ;
      int num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
          case 2:
            num = 3;
            continue;
          case 1:
            goto label_8;
          case 3:
            if (index >= xmlNodeByteArray.Length)
            {
              num = 1;
              continue;
            }
            CXmlEdit.XmlNodeByte xmlNodeByte = xmlNodeByteArray[index];
            bArray[xmlNodeByte.nByte] = this.GetByte(xmlNodeByte.sNode);
            ++index;
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_8:;
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
