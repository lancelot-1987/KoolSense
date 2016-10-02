// Decompiled with JetBrains decompiler
// Type: hpCasl.XmlTools
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace hpCasl
{
  internal class XmlTools
  {
    private CaslLogger log = new CaslLogger();
    private string validateErrorMessage = "";
    private int validationErrors;

    public int Errors
    {
      get
      {
        return this.validationErrors;
      }
    }

    public string ErrorMessage
    {
      get
      {
        return this.validateErrorMessage;
      }
    }

    private void ValidateHandler(object sender, ValidationEventArgs args)
    {
      int A_1 = 16;
      if (1 == 0)
        ;
      this.validateErrorMessage = this.validateErrorMessage + args.Message + Module.a("孕剗", A_1);
      ++this.validationErrors;
    }

    public enReturnCode Validate(string sXML, string sXSD)
    {
      int A_1 = 6;
      enReturnCode enReturnCode = enReturnCode.e_OK;
      this.validateErrorMessage = "";
      this.validationErrors = 0;
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
        int num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              num = 5;
              continue;
            case 1:
              xmlReader.Close();
              num = 4;
              continue;
            case 2:
              goto label_14;
            case 3:
              this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᩋ⽍㱏㭑こ㝕ⱗ㽙", A_1), this.validateErrorMessage);
              enReturnCode = enReturnCode.e_INVALID_XML;
              num = 6;
              continue;
            case 4:
              if (this.validationErrors > 0)
              {
                if (1 == 0)
                  ;
                num = 3;
                continue;
              }
              goto case 6;
            case 5:
              if (!xmlReader.Read())
              {
                num = 1;
                continue;
              }
              goto case 0;
            case 6:
              num = 2;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᩋ⽍㱏㭑こ㝕ⱗ㽙", A_1), ex.Message);
        enReturnCode = enReturnCode.e_INVALID_XML;
      }
label_14:
      return enReturnCode;
    }
  }
}
