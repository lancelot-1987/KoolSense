// Decompiled with JetBrains decompiler
// Type: hpCasl.Casl
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

namespace hpCasl
{
  public static class Casl
  {
       public static string a(string A_0, int A_1)
        {
            char[] chArray1 = A_0.ToCharArray();
            int num1 = 618376572 + A_1;
            int num2 = 0;
            int num3 = 1;
            if (num2 < num3)
                goto label_2;
            label_1:
            int index1 = num2;
            char[] chArray2 = chArray1;
            int index2 = index1;
            int num4 = (int)(short)chArray1[index1];
            int num5 = (int)byte.MaxValue;
            int num6 = num4 & num5;
            int num7 = num1;
            int num8 = 1;
            int num9 = num7 + num8;
            byte num10 = (byte)(num6 ^ num7);
            int num11 = 8;
            int num12 = num4 >> num11;
            int num13 = num9;
            int num14 = 1;
            num1 = num13 + num14;
            int num15 = (int)(byte)(num12 ^ num13);
            int num16 = (int)(ushort)((uint)num10 << 8 | (uint)(byte)num15);
            chArray2[index2] = (char)num16;
            int num17 = 1;
            num2 += num17;
            label_2:
            int length = chArray1.Length;
            if (num2 >= length)
                return string.Intern(new string(chArray1));
            goto label_1;
        }
        public static string Fullname
    {
      get
      {
        return Util.CommandGetString(Casl.a("삂\xE484\xF486\xE588ꖊ쮌搜\xFD90ﾒﮔ\xF696\xF498ﺚ", 6));
      }
    }

    public static string Location
    {
      get
      {
        return Util.CommandGetString(Casl.a("욄\xE686愈\xE78Aꎌ쎎ﺐ\xF092\xF494\xE396\xF098\xF49A\xF39C", 8));
      }
    }

    public static string Version
    {
      get
      {
        return Util.CommandGetString(Casl.a("잃\xE785ﮇ\xE689ꊋ\xD88D\xF58F\xE091\xE793ﾕ\xF797\xF499", 7));
      }
    }

    public static string FileVersion
    {
      get
      {
        return Util.CommandGetString(Casl.a("슀\xE282\xF684\xEB86\xA788춊\xE48C\xE38E\xF490얒\xF094\xE596\xEA98\xF29A\xF29C\xF19E", 4));
      }
    }

    public static string[] Plugins
    {
      get
      {
        return Util.CommandGetStringList(Casl.a("쪈\xEA8Aﺌ\xE38E뾐쎒璉\xE296ﺘ\xF29A\xF39C\xEC9E", 12));
      }
    }

    public static class Plugin
    {
      public static class CommandCaslWmi
      {
        public static string Fullname
        {
          get
          {
            return Casl.a("욇\xE589\xF88B꺍\xD98Fﾑ\xE493歹ﶗ\xF799鍊\xF09D풟잡삣", 11);
          }
        }

        public static string Location
        {
          get
          {
            return Casl.a("춂\xEA84\xF386ꦈ슊\xE08Cﾎ\xFD90\xF692\xF894\xF296\xF798\xEF9A\xF89Cﮞ", 6);
          }
        }

        public static string Version
        {
          get
          {
            return Casl.a("춂\xEA84\xF386ꦈ슊\xE08Cﾎ\xFD90\xF692\xF894\xF296\xF798\xEF9A\xF89Cﮞ", 6);
          }
        }

        public static string FileVersion
        {
          get
          {
            return Casl.a("쎌\xE08E\xE590뎒\xDC94殺\xE998\xF79A\xF89C\xF29E쒠춢톤슦춨", 16);
          }
        }
      }

      public static class CommandCaslSmBios
      {
        public static string Fullname
        {
          get
          {
            return Casl.a("종\xE787ﺉ겋잍ﶏ\xE291\xF893\xF395\xF597ﾙ\xF29B\xEA9D얟욡", 9);
          }
        }

        public static string Location
        {
          get
          {
            return Casl.a("욇\xE589\xF88B꺍\xD98Fﾑ\xE493歹ﶗ\xF799鍊\xF09D풟잡삣", 11);
          }
        }

        public static string Version
        {
          get
          {
            return Casl.a("쾀\xEC82\xF184Ꞇ삈\xE68Aﶌ\xE38E\xF490ﺒ\xF094練\xED98ﺚ列", 4);
          }
        }

        public static string FileVersion
        {
          get
          {
            return Casl.a("칿\xED81\xF083ꚅ솇\xE789ﲋ\xE28D\xF58Fﾑ\xF193\xF895\xEC97ﾙ\xF89B", 3);
          }
        }
      }

      public static class EventCaslWmi
      {
        public static string Fullname
        {
          get
          {
            return Casl.a("삍ﾏ\xE691뒓\xDF95\xF597\xEA99\xF09Bﮝ춟잡쪣튥춧캩", 17);
          }
        }

        public static string Location
        {
          get
          {
            return Casl.a("\xDE8F\xFD91\xE093뚕톗\xF799\xEC9B\xF29D얟쾡솣좥\xDCA7쾩좫", 19);
          }
        }

        public static string Version
        {
          get
          {
            return Casl.a("칿\xED81\xF083ꚅ솇\xE789ﲋ\xE28D\xF58Fﾑ\xF193\xF895\xEC97ﾙ\xF89B", 3);
          }
        }

        public static string FileVersion
        {
          get
          {
            return Casl.a("쪃\xE985ﲇꪉ얋\xE38D\xE08Fﺑ\xF193ﮕﶗ\xF499\xE89Bﮝ쒟", 7);
          }
        }
      }
    }
  }
}
