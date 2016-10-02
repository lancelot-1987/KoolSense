// Decompiled with JetBrains decompiler
// Type: hpCasl.CXmlTools
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace hpCasl
{
  internal class CXmlTools
  {
    private string m_sValidateErrorMessage = "";
    private int m_nValidationErrors;

    private void ValidateHandler(object sender, ValidationEventArgs args)
    {
      int A_1 = 19;
      if (1 == 0)
        ;
      this.m_sValidateErrorMessage = this.m_sValidateErrorMessage + args.Message + Casl.a("鶏频", A_1);
      ++this.m_nValidationErrors;
    }

    public enReturnCode Validate(string sXML, string sXSD)
    {
      int A_1 = 10;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.m_sValidateErrorMessage = "";
      this.m_nValidationErrors = 0;
      try
      {
label_3:
        XmlTextReader xmlTextReader1 = new XmlTextReader((TextReader) new StringReader(sXML));
        XmlTextReader xmlTextReader2 = new XmlTextReader((TextReader) new StringReader(sXSD));
        XmlSchemaSet schemas = new XmlSchemaSet();
        schemas.Add((string) null, (XmlReader) xmlTextReader2);
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.Schemas.Add(schemas);
        settings.ValidationType = ValidationType.Schema;
        settings.ValidationEventHandler += new ValidationEventHandler(this.ValidateHandler);
        XmlReader xmlReader = XmlReader.Create((XmlReader) xmlTextReader1, settings);
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("톆\xE888\xE78A\xE48C\xEB8E\xF090\xE792\xF094", A_1), this.m_sValidateErrorMessage);
              enReturnCode = enReturnCode.e_INVALID_XML;
              num = 2;
              continue;
            case 1:
              num = 3;
              continue;
            case 2:
              num = 6;
              continue;
            case 3:
              if (!xmlReader.Read())
              {
                num = 5;
                continue;
              }
              goto case 1;
            case 4:
              if (this.m_nValidationErrors > 0)
              {
                if (1 == 0)
                  ;
                num = 0;
                continue;
              }
              goto case 2;
            case 5:
              xmlReader.Close();
              num = 4;
              continue;
            case 6:
              goto label_14;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        Global.Log.ErrorMessage(this.GetType().ToString(), Casl.a("톆\xE888\xE78A\xE48C\xEB8E\xF090\xE792\xF094", A_1), ex.Message);
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_14:
      return enReturnCode;
    }
  }
}
