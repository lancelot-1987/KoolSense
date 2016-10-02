// Decompiled with JetBrains decompiler
// Type: hpCasl.Command
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Collections.Generic;
using System.Reflection;

namespace hpCasl
{
    public static class Command
    {
        private static List<CommandPlugin> commandPluginList;

        internal static List<Assembly> AssemblyList
        {
            get
            {
                List<Assembly> list = new List<Assembly>();
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 6;
                    while (true)
                    {
                        CommandPlugin current = enumerator.Current;
                        switch (num)
                        {
                            case 0:
                                num = 4;
                                continue;
                            case 1:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    num = 2;
                                    continue;
                                }
                                num = 0;
                                continue;
                            case 2:
                                if (current != null && current.PluginAssembly != null)
                                {
                                    num = 5;
                                    continue;
                                }
                                break;
                            case 4:
                                goto label_13;
                            case 5:
                                list.Add(current.PluginAssembly);
                                if (1 == 0)
                                    ;
                                num = 3;
                                continue;
                        }
                        num = 1;
                    }
                }
                label_13:
                return list;
            }
        }

        static Command()
        {
            int A_1 = 11;
            label_2:
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쮇\xE589\xE18B\xE38D\xF18Fﲑ\xF093", A_1), Casl.a("\xDB87ﺉ\xED8Bﲍ\xE48F\xF791\xF093", A_1));
            Command.commandPluginList = new List<CommandPlugin>();
            string[] plugins = CaslEnumerator.GetPlugins();
            int num = 4;
            int index = 0;
            CommandPluginLoader commandPluginLoader = null;
            string[] strArray = null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        ++index;
                        num = 3;
                        continue;
                    case 1:
                        goto label_15;
                    case 2:
                        if (1 == 0)
                            ;
                        strArray = plugins;
                        index = 0;
                        num = 6;
                        continue;
                    case 3:
                    case 6:
                        num = 5;
                        continue;
                    case 4:
                        if (plugins != null)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_15;
                    case 5:
                        if (index >= strArray.Length)
                        {
                            num = 1;
                            continue;
                        }
                        commandPluginLoader = CommandPluginLoader.Load(strArray[index]);
                        num = 7;
                        continue;
                    case 7:
                        if (commandPluginLoader != null)
                        {
                            num = 8;
                            continue;
                        }
                        goto case 0;
                    case 8:
                        Command.commandPluginList.Add((CommandPlugin)commandPluginLoader);
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_15:
            Command.AddPlugin((CommandPlugin)new CommandPluginInformation());
            Command.AddPlugin((CommandPlugin)new CommandPluginEnumerator(Casl.a("쮇\xEB89ﾋ\xE28D뺏슑\xF893\xE395ﾗ\xF399\xF29B낝\xE39F춡즣쮥즧쒩좫", A_1), Command.AssemblyList));
            Command.AddPlugin((CommandPlugin)new CommandPluginEnumerator(Casl.a("쮇\xEB89ﾋ\xE28D뺏슑\xF893\xE395ﾗ\xF399\xF29B낝\xE59F풡솣좥\xDCA7", A_1), Event.AssemblyList));
            Global.Log.TraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쮇\xE589\xE18B\xE38D\xF18Fﲑ\xF093", A_1), Casl.a("쮇\xE589\xE18Bﺍﲏ\xF791\xE093\xF395ﲗ", A_1));
        }

        internal static void AddPlugin(CommandPlugin commandPlugin)
        {
            Command.commandPluginList.Add(commandPlugin);
        }

        public static string[] SupportedGetCommands()
        {
            int A_1 = 4;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590풒\xF094\xE396\xDA98\xF49A\xF09C\xF29E삠춢솤풦", A_1), Casl.a("튀\xF782\xE484\xF586ﶈ\xEE8A\xE98C", A_1));
            string[] Array1 = (string[])null;
            enReturnCode enReturnCode = enReturnCode.e_OK;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 0;
                    while (true)
                    {
                        switch (num)
                        {
                            case 1:
                                if (enumerator.MoveNext())
                                {
                                    CommandPlugin current = enumerator.Current;
                                    Array1 = Util.Merge(Array1, current.SupportedGetCommands());
                                    num = 4;
                                    continue;
                                }
                                num = 2;
                                continue;
                            case 2:
                                num = 3;
                                continue;
                            case 3:
                                goto label_11;
                            default:
                                num = 1;
                                continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590풒\xF094\xE396\xDA98\xF49A\xF09C\xF29E삠춢솤풦", A_1), Casl.a("삀\xED82ꖄ\xE286\xF188\xE88A\xE88Cﾎ\xE590朗杖練릘\xF49Aﺜﲞ풠톢\xD7A4슦춨讪횬龮첰", A_1), (object)ex.Message);
            }
            label_11:
            if (1 == 0)
                ;
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("튀\xF682\xF584\xF786\xE688力歷\xEA8E\xF590풒\xF094\xE396\xDA98\xF49A\xF09C\xF29E삠춢솤풦", A_1), Casl.a("슀\xEC82\xE884\xF786\xE588\xEE8A歷\xEA8E\xF590뎒\xE294ﺖ\xED98\xF39A붜\xE49E醠\xDEA2", A_1), (object)enReturnCode.ToString());
            return Array1;
        }

        public static enReturnCode TypeOfGet(string sCommandName, out Type typeOut)
        {
            int A_1 = 18;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ\xDC9A\xF89C\xEB9E", A_1), Casl.a("\xDC8E\xE590\xF292\xE794\xE396ﲘﾚ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            typeOut = (Type)null;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 6;
                    while (true)
                    {
                        CommandPlugin current = null;
                        switch (num)
                        {
                            case 0:
                            case 2:
                                num = 3;
                                continue;
                            case 1:
                                enReturnCode = current.TypeOfGet(sCommandName, out typeOut);
                                num = 2;
                                continue;
                            case 3:
                                goto label_14;
                            case 4:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    num = 5;
                                    continue;
                                }
                                num = 0;
                                continue;
                            case 5:
                                if (current.IsGetSupported(sCommandName))
                                {
                                    num = 1;
                                    continue;
                                }
                                break;
                        }
                        num = 4;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ\xDC9A\xF89C\xEB9E", A_1), Casl.a("캎ﾐ뎒\xF094\xEF96滛ﺚ\xED9C\xEB9E좠첢쮤螦욨좪캬\xDAAE쎰솲킴펶馸삺趼슾", A_1), (object)ex.Message);
            }
            label_14:
            if (1 == 0)
                ;
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDB8E\xE890\xE392\xF094\xD896ﾘ\xDC9A\xF89C\xEB9E", A_1), Casl.a("첎ﺐﺒ\xE594ﮖﲘ\xEF9A\xF89Cﮞ膠풢첤펦솨讪횬龮첰", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static enReturnCode Get(string sCommandName, out object oDataOut)
        {
            int A_1 = 12;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷", A_1), Casl.a("\xDA88ﾊ\xEC8Cﶎ\xE590\xF692\xF194랖\xEE98\xF29A\xE99C\xF79E膠", A_1) + sCommandName);
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            oDataOut = (object)null;
            try
            {
                int num1 = 1;
                while (true)
                {
                    List<CommandPlugin>.Enumerator enumerator = new List<CommandPlugin>.Enumerator();
                    switch (num1)
                    {
                        case 0:
                            enumerator = Command.commandPluginList.GetEnumerator();
                            if (1 == 0)
                                ;
                            num1 = 2;
                            continue;
                        case 2:
                            try
                            {
                                int num2 = 3;
                                while (true)
                                {
                                    CommandPlugin current = null;
                                    switch (num2)
                                    {
                                        case 0:
                                            if (enReturnCode != enReturnCode.e_OK)
                                            {
                                                num2 = 6;
                                                continue;
                                            }
                                            goto case 7;
                                        case 1:
                                            if (current.IsGetSupported(sCommandName))
                                            {
                                                num2 = 5;
                                                continue;
                                            }
                                            break;
                                        case 2:
                                            goto label_20;
                                        case 4:
                                            if (!enumerator.MoveNext())
                                            {
                                                num2 = 7;
                                                continue;
                                            }
                                            current = enumerator.Current;
                                            num2 = 1;
                                            continue;
                                        case 5:
                                            enReturnCode = current.Get(sCommandName, out oDataOut);
                                            num2 = 0;
                                            continue;
                                        case 7:
                                            num2 = 2;
                                            continue;
                                    }
                                    num2 = 4;
                                }
                            }
                            finally
                            {
                                enumerator.Dispose();
                            }
                        case 3:
                            goto label_23;
                        default:
                            if (Command.commandPluginList.Count > 0)
                            {
                                num1 = 0;
                                continue;
                            }
                            break;
                    }
                    label_20:
                    num1 = 3;
                }
            }
            catch (CaslException ex)
            {
                enReturnCode = ex.eRetCode;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷", A_1), Casl.a("좈\xE58A권\xEA8E\xE990\xF092\xF094\xE796\xED98\xF29A\xF29C\xF19E膠첢욤쒦\xDCA8\xD9AA\xDFAC쪮햰鎲캴螶쒸", A_1), (object)ex.Message);
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷", A_1), Casl.a("좈\xE58A권\xEA8E\xE990\xF092\xF094\xE796\xED98\xF29A\xF29C\xF19E膠첢욤쒦\xDCA8\xD9AA\xDFAC쪮햰鎲캴螶쒸", A_1), (object)ex.Message);
            }
            label_23:
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("캈\xEE8A歷", A_1), Casl.a("쪈\xE48A\xE08Cﾎ\xFD90\xF692\xE194\xF296ﶘ뮚\xEA9C\xF69E햠쮢薤\xDCA6馨횪", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static string[] SupportedSetCommands()
        {
            int A_1 = 14;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD88A\xF88Cﾎ\xE190ﲒ\xE794\xE396ﲘﾚ캜爵햠\xE0A2쪤쪦쒨쪪쎬쮮슰", A_1), Casl.a("\xD88A歷\xEE8E\xE390\xE792\xF094\xF396", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            string[] Array1 = (string[])null;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 2;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                goto label_10;
                            case 1:
                                if (enumerator.MoveNext())
                                {
                                    CommandPlugin current = enumerator.Current;
                                    Array1 = Util.Merge(Array1, current.SupportedSetCommands());
                                    num = 4;
                                    continue;
                                }
                                num = 3;
                                continue;
                            case 3:
                                num = 0;
                                continue;
                            default:
                                num = 1;
                                continue;
                        }
                    }
                }
                label_10:
                if (1 == 0)
                    ;
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD88A\xF88Cﾎ\xE190ﲒ\xE794\xE396ﲘﾚ캜爵햠\xE0A2쪤쪦쒨쪪쎬쮮슰", A_1), Casl.a("쪊\xE38C꾎\xF490\xEB92\xF694\xF296\xE998\xEF9A\xF49C\xF09E쾠莢쪤쒦쪨\xDEAA\xDFAC\xDDAE풰ힲ閴첶覸욺", A_1), (object)ex.Message);
            }
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD88A\xF88Cﾎ\xE190ﲒ\xE794\xE396ﲘﾚ캜爵햠\xE0A2쪤쪦쒨쪪쎬쮮슰", A_1), Casl.a("좊\xE28C\xE28E\xE190ﾒ\xF094\xE396ﲘﾚ붜\xE89E좠힢춤螦튨鮪킬", A_1), (object)enReturnCode.ToString());
            return Array1;
        }

        public static enReturnCode TypeOfSet(string sCommandName, out Type typeIn)
        {
            int A_1 = 11;
            if (1 == 0)
                ;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDC87\xF389ﲋ\xEB8D\xDF8F\xF491잓\xF395\xEC97", A_1), Casl.a("\xDB87ﺉ\xED8Bﲍ\xE48F\xF791\xF093", A_1));
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            typeIn = (Type)null;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 4;
                    while (true)
                    {
                        CommandPlugin current = null;

                        switch (num)
                        {
                            case 0:
                            case 6:
                                num = 1;
                                continue;
                            case 1:
                                goto label_15;
                            case 2:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    num = 3;
                                    continue;
                                }
                                num = 0;
                                continue;
                            case 3:
                                if (current.IsSetSupported(sCommandName))
                                {
                                    num = 5;
                                    continue;
                                }
                                break;
                            case 5:
                                enReturnCode = current.TypeOfSet(sCommandName, out typeIn);
                                num = 6;
                                continue;
                        }
                        num = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDC87\xF389ﲋ\xEB8D\xDF8F\xF491잓\xF395\xEC97", A_1), Casl.a("즇\xE489겋\xEB8D\xE88F\xF191\xF193\xE695\xEC97\xF399\xF39B\xF09D肟춡잣얥\xDDA7\xD8A9\xDEAB쮭풯銱쾳蚵얷", A_1), (object)ex.Message);
            }
            label_15:
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xDC87\xF389ﲋ\xEB8D\xDF8F\xF491잓\xF395\xEC97", A_1), Casl.a("쮇\xE589\xE18Bﺍﲏ\xF791\xE093\xF395ﲗ몙\xEB9B\xF79D풟쪡蒣\xDDA5颧\xD7A9", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static enReturnCode Set(string sCommandName, object data)
        {
            int A_1 = 6;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("킂\xE084\xF386", A_1), Casl.a("킂\xF184\xE686ﮈﾊ\xE88C\xEB8E놐\xE492ﲔ\xE396\xF198뮚", A_1) + sCommandName);
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 4;
                    while (true)
                    {
                        CommandPlugin current = null;
                        switch (num)
                        {
                            case 0:
                                num = 3;
                                continue;
                            case 1:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    if (1 == 0)
                                        ;
                                    num = 7;
                                    continue;
                                }
                                num = 0;
                                continue;
                            case 2:
                                if (enReturnCode != enReturnCode.e_OK)
                                {
                                    num = 5;
                                    continue;
                                }
                                goto case 0;
                            case 3:
                                goto label_17;
                            case 6:
                                enReturnCode = current.Set(sCommandName, data);
                                num = 2;
                                continue;
                            case 7:
                                if (current.IsSetSupported(sCommandName))
                                {
                                    num = 6;
                                    continue;
                                }
                                break;
                        }
                        num = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("킂\xE084\xF386", A_1), Casl.a("슂\xEB84Ꞇ\xEC88\xF38A\xEE8C\xEA8E\xE190\xE792ﲔ\xF896\xF798뮚\xF29Cﲞ슠횢\xD7A4햦첨쾪趬풮膰캲", A_1), (object)ex.Message);
            }
            label_17:
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("킂\xE084\xF386", A_1), Casl.a("삂\xEA84\xEA86麗\xE78A\xE88Cﮎ\xF490\xF792떔\xE096\xF098\xEF9A\xF59C뾞\xDAA0鎢\xD8A4", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static string[] SupportedExecuteCommands()
        {
            int A_1 = 5;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xEE95ﶗ蓮\xE99B\xEA9D얟\xE1A1쮣쮥얧쮩슫쪭쎯", A_1), Casl.a("톁\xF083\xE785慎ﺉ\xE98B\xEA8D", A_1));
            string[] Array1 = (string[])null;
            enReturnCode enReturnCode = enReturnCode.e_OK;
            try
            {
                if (1 == 0)
                    ;
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 1;
                    while (true)
                    {
                        switch (num)
                        {
                            case 2:
                                num = 3;
                                continue;
                            case 3:
                                goto label_12;
                            case 4:
                                if (enumerator.MoveNext())
                                {
                                    CommandPlugin current = enumerator.Current;
                                    Array1 = Util.Merge(Array1, current.SupportedExecuteCommands());
                                    num = 0;
                                    continue;
                                }
                                num = 2;
                                continue;
                            default:
                                num = 4;
                                continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xEE95ﶗ蓮\xE99B\xEA9D얟\xE1A1쮣쮥얧쮩슫쪭쎯", A_1), Casl.a("쎁\xEA83ꚅ\xED87\xF289\xEF8B\xEB8D\xE08F\xE691ﶓ秊\xF697몙\xF39Bﶝ쎟힡횣풥춧캩貫햭肯쾱", A_1), (object)ex.Message);
            }
            label_12:
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("톁\xF183\xF685\xF887\xE589ﺋ揄\xF58F\xF691톓\xEE95ﶗ蓮\xE99B\xEA9D얟\xE1A1쮣쮥얧쮩슫쪭쎯", A_1), Casl.a("솁\xEB83\xEB85\xF887\xE689\xE98B揄\xF58F\xF691뒓\xE195\xF197\xEE99\xF49B뺝\xDB9F銡\xD9A3", A_1), (object)enReturnCode.ToString());
            return Array1;
        }

        public static enReturnCode TypeOfExecute(string sCommandName, out Type tDataIn, out Type tDataOut)
        {
            int A_1 = 16;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD98C\xF68E\xE190\xF692\xDA94\xF196\xDC98\xE39A\xF89Cﲞ풠힢삤", A_1), Casl.a("\xDE8Cﮎ\xF090\xE192\xE194\xF296ﶘ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            tDataIn = (Type)null;
            tDataOut = (Type)null;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 3;
                    while (true)
                    {
                        CommandPlugin current = null;
                        switch (num)
                        {
                            case 0:
                                enReturnCode = current.TypeOfExecute(sCommandName, out tDataIn, out tDataOut);
                                num = 2;
                                continue;
                            case 1:
                                num = 6;
                                continue;
                            case 2:
                                if (enReturnCode != enReturnCode.e_OK)
                                {
                                    num = 7;
                                    continue;
                                }
                                goto case 1;
                            case 4:
                                if (current.IsExecuteSupported(sCommandName))
                                {
                                    num = 0;
                                    continue;
                                }
                                break;
                            case 5:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    num = 4;
                                    continue;
                                }
                                num = 1;
                                continue;
                            case 6:
                                goto label_16;
                        }
                        num = 5;
                    }
                }
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD98C\xF68E\xE190\xF692\xDA94\xF196\xDC98\xE39A\xF89Cﲞ풠힢삤", A_1), Casl.a("첌\xE18E놐\xF692\xED94\xF496ﲘ\xEB9A\xE99C\xF69E캠춢薤좦쪨좪\xD8AC\xDDAE쎰횲톴鞶슸论삼", A_1), (object)ex.Message);
            }
            label_16:
            if (1 == 0)
                ;
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("\xD98C\xF68E\xE190\xF692\xDA94\xF196\xDC98\xE39A\xF89Cﲞ풠힢삤", A_1), Casl.a("캌\xE08Eﲐ\xE392璉\xF296\xED98ﺚ列뾞횠쪢톤쾦覨킪鶬튮", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }

        public static enReturnCode Execute(string sCommandName, object oDataIn, out object oDataOut)
        {
            int A_1 = 13;
            Global.Log.TraceInMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쾉\xF48B\xEB8D\xF38F\xE791\xE093\xF395", A_1), Casl.a("\xD989\xF88B\xEF8D\xE28F\xE691\xF193\xF295뢗\xED99\xF59B\xEA9D좟芡", A_1) + sCommandName);
            enReturnCode enReturnCode = enReturnCode.e_INVALID_PARAMETER;
            oDataOut = (object)null;
            try
            {
                using (List<CommandPlugin>.Enumerator enumerator = Command.commandPluginList.GetEnumerator())
                {
                    int num = 1;
                    while (true)
                    {
                        CommandPlugin current = null;
                        switch (num)
                        {
                            case 0:
                                if (enReturnCode != enReturnCode.e_OK)
                                {
                                    num = 5;
                                    continue;
                                }
                                goto case 2;
                            case 2:
                                num = 6;
                                continue;
                            case 3:
                                enReturnCode = current.Execute(sCommandName, oDataIn, out oDataOut);
                                num = 0;
                                continue;
                            case 4:
                                if (current.IsExecuteSupported(sCommandName))
                                {
                                    num = 3;
                                    continue;
                                }
                                break;
                            case 6:
                                goto label_15;
                            case 7:
                                if (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    num = 4;
                                    continue;
                                }
                                num = 2;
                                continue;
                        }
                        num = 7;
                    }
                }
                label_15:
                if (1 == 0)
                    ;
            }
            catch (Exception ex)
            {
                enReturnCode = enReturnCode.e_GENERAL_EXCEPTION;
                Global.Log.FormatErrorMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쾉\xF48B\xEB8D\xF38F\xE791\xE093\xF395", A_1), Casl.a("쮉\xE28B꺍\xF58F\xEA91\xF793\xF395\xE897\xEE99\xF59B\xF19D캟芡쮣얥쮧\xDFA9\xDEAB\xDCAD햯횱钳춵袷잹", A_1), (object)ex.Message);
            }
            Global.Log.FormatTraceOutMessage(MethodBase.GetCurrentMethod().DeclaringType.ToString(), Casl.a("쾉\xF48B\xEB8D\xF38F\xE791\xE093\xF395", A_1), Casl.a("즉\xE38B\xE38D\xE08Fﺑ\xF193\xE295ﶗﺙ벛\xE99D즟횡첣蚥펧骩톫", A_1), (object)enReturnCode.ToString());
            return enReturnCode;
        }
    }
}
