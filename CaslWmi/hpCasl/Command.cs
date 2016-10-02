// Decompiled with JetBrains decompiler
// Type: hpCasl.Command
// Assembly: CaslWmi, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 7CA79F23-83D3-4AB3-BF5F-FD2E2E45E09A
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslWmi.dll

using CaslWmi.Properties;
using GenericPolicy;
using System;
using System.Collections.Generic;

namespace hpCasl
{
    public abstract class Command
    {
        protected CaslLogger log = new CaslLogger();
        protected CaslPolicy Globalpolicy = new CaslPolicy(Policy.enPolicyType.Global, Resources.PolicyEmulation);
        protected List<Command.Property> propertyGetList = new List<Command.Property>();
        protected List<Command.Property> propertySetList = new List<Command.Property>();
        protected List<Command.CommandExecute> executeList = new List<Command.CommandExecute>();

        public Command()
        {
            this.InitPropertyGetList();
            this.InitPropertySetList();
            this.InitExecuteList();
        }

        protected abstract void InitPropertyGetList();

        protected abstract void InitPropertySetList();

        protected abstract void InitExecuteList();

        public string[] SupportedGetCommands()
        {
            label_2:
            string[] strArray = new string[this.propertyGetList.Count];
            int index = 0;
            if (1 == 0)
                ;
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (index >= strArray.Length)
                        {
                            num = 2;
                            continue;
                        }
                        strArray[index] = this.propertyGetList[index].DataName;
                        ++index;
                        num = 3;
                        continue;
                    case 1:
                    case 3:
                        num = 0;
                        continue;
                    case 2:
                        goto label_8;
                    default:
                        goto label_2;
                }
            }
            label_8:
            return strArray;
        }

        public enReturnCode TypeOfGet(string sCommandName, out Type tDataOut)
        {
            enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
            tDataOut = (Type)null;
            using (List<Command.Property>.Enumerator enumerator = this.propertyGetList.GetEnumerator())
            {
                int num = 5;
                while (true)
                {
                    Command.Property current = new Property();
                    switch (num)
                    {
                        case 0:
                            if (current.DataName == sCommandName)
                            {
                                num = 1;
                                continue;
                            }
                            break;
                        case 1:
                            tDataOut = current.DataType;
                            enReturnCode = enReturnCode.e_OK;
                            if (1 == 0)
                                ;
                            num = 6;
                            continue;
                        case 2:
                        case 6:
                            num = 3;
                            continue;
                        case 3:
                            goto label_13;
                        case 4:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num = 0;
                                continue;
                            }
                            num = 2;
                            continue;
                    }
                    num = 4;
                }
            }
            label_13:
            return enReturnCode;
        }

        public bool IsGetSupported(string sCommandName)
        {
            return Array.IndexOf<string>(this.SupportedGetCommands(), sCommandName) != -1;
        }

        public bool IsGetSecured(string sCommandName)
        {
            bool flag = false;
            using (List<Command.Property>.Enumerator enumerator = this.propertyGetList.GetEnumerator())
            {
                int num = 3;
                while (true)
                {
                    Command.Property current = new Property();
                    switch (num)
                    {
                        case 0:
                            flag = current.IsSecured;
                            num = 2;
                            continue;
                        case 1:
                            goto label_12;
                        case 2:
                        case 4:
                            num = 1;
                            continue;
                        case 5:
                            if (current.DataName == sCommandName)
                            {
                                num = 0;
                                continue;
                            }
                            break;
                        case 6:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num = 5;
                                continue;
                            }
                            num = 4;
                            continue;
                    }
                    num = 6;
                }
            }
            label_12:
            if (1 == 0)
                ;
            return flag;
        }

        public enReturnCode Get(string sCommandName, out object dataOut)
        {
            int A_1 = 12;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ő⁓㝕⩗\x2E59㥛㩝䁟㥡ᝣ╥ݧݩū\x0F6Dṯᙱ㩳\x1775ᕷό䙻", A_1) + sCommandName + Module.a("ད", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            dataOut = (object)null;
            int num1 = 1;
            Command.DataFunctionGetDelegate functionGetDelegate = null;
            List<Command.Property>.Enumerator enumerator = new List<Property>.Enumerator();
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto label_29;
                    case 2:
                        enReturnCode = enReturnCode.e_NODE_NOT_FOUND;
                        functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                        enumerator = this.propertyGetList.GetEnumerator();
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_5:
            try
            {
                int num2 = 4;
                Command.Property current = new Property();

                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            enReturnCode = functionGetDelegate(sCommandName, out dataOut);
                            num2 = 1;
                            continue;
                        case 1:
                        case 2:
                        case 3:
                            num2 = 7;
                            continue;
                        case 5:
                            try
                            {
                                this.log.InformationMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("≑♓㥕⡗㽙\x2E5B⩝ᥟ䱡\x2063ݥᱧ୩⩫᭭ṯᅱsή\x1777ᑹ䙻幽", A_1) + current.DataFunction);
                                functionGetDelegate = (Command.DataFunctionGetDelegate)Delegate.CreateDelegate(typeof(Command.DataFunctionGetDelegate), (object)this, current.DataFunction);
                            }
                            catch (ArgumentNullException ex)
                            {
                                functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ፑ♓ㅕⵗ㝙㥛そᑟⱡᅣ\x0A65ѧ⽩ᑫ൭ᕯɱsή\x1777ᑹ䙻幽", A_1) + ex.Message);
                            }
                            catch (ArgumentException ex)
                            {
                                functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ፑ♓ㅕⵗ㝙㥛そᑟ❡ᱣե൧ᩩᡫݭὯᱱ乳噵", A_1) + ex.Message);
                            }
                            catch (MissingMethodException ex)
                            {
                                functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ὑ㵓╕⭗㍙\x325B㥝ⵟݡၣ\x0E65ݧ\x0E69⥫᙭\x136F\x1771ѳɵᅷᕹቻ䑽ꁿ", A_1) + ex.Message);
                            }
                            catch (MethodAccessException ex)
                            {
                                functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ὑㅓ≕し㕙㡛Ὕ͟šţᕥ᭧⽩ᑫ൭ᕯɱsή\x1777ᑹ䙻幽", A_1) + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                                this.log.ErrorMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ᝑⱓ㕕㵗⩙⡛㝝ཟౡ幣䙥", A_1) + ex.Message);
                            }
                            num2 = 10;
                            continue;
                        case 6:
                            this.log.InformationMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("≑♓㥕⡗㽙\x2E5B⩝ᥟ䱡\x2063ݥᱧ୩≫\x0F6Dᵯ\x1771乳噵", A_1) + current.DataName);
                            functionGetDelegate = (Command.DataFunctionGetDelegate)null;
                            num2 = 5;
                            continue;
                        case 7:
                            goto label_29;
                        case 8:
                            if (current.DataName == sCommandName)
                            {
                                num2 = 6;
                                continue;
                            }
                            break;
                        case 9:
                            if (!enumerator.MoveNext())
                            {
                                num2 = 3;
                                continue;
                            }
                            current = enumerator.Current;
                            num2 = 8;
                            continue;
                        case 10:
                            if (functionGetDelegate == null)
                            {
                                enReturnCode = enReturnCode.e_UNKNOWN;
                                num2 = 2;
                                continue;
                            }
                            num2 = 0;
                            continue;
                    }
                    num2 = 9;
                }
            }
            finally
            {
                if (1 == 0)
                    ;
                enumerator.Dispose();
            }
            label_29:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᕑㅓ≕", A_1), Module.a("ᅑ㭓㭕⡗㙙㥛⩝՟١䑣ᅥŧṩѫ呭偯", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        public string[] SupportedSetCommands()
        {
            label_2:
            string[] strArray = new string[this.propertySetList.Count];
            int index = 0;
            if (1 == 0)
                ;
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (index >= strArray.Length)
                        {
                            num = 1;
                            continue;
                        }
                        strArray[index] = this.propertySetList[index].DataName;
                        ++index;
                        num = 3;
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
            label_8:
            return strArray;
        }

        public enReturnCode TypeOfSet(string sCommandName, out Type tDataIn)
        {
            enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
            tDataIn = (Type)null;
            List<Command.Property>.Enumerator enumerator = this.propertySetList.GetEnumerator();
            try
            {
                int num = 4;
                while (true)
                {
                    Command.Property current = new Property();
                    switch (num)
                    {
                        case 0:
                            tDataIn = current.DataType;
                            enReturnCode = enReturnCode.e_OK;
                            num = 1;
                            continue;
                        case 1:
                        case 5:
                            num = 2;
                            continue;
                        case 2:
                            goto label_13;
                        case 3:
                            if (current.DataName == sCommandName)
                            {
                                num = 0;
                                continue;
                            }
                            break;
                        case 6:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num = 3;
                                continue;
                            }
                            num = 5;
                            continue;
                    }
                    num = 6;
                }
            }
            finally
            {
                if (1 == 0)
                    ;
                enumerator.Dispose();
            }
            label_13:
            return enReturnCode;
        }

        public bool IsSetSupported(string sCommandName)
        {
            return Array.IndexOf<string>(this.SupportedSetCommands(), sCommandName) != -1;
        }

        public bool IsSetSecured(string sCommandName)
        {
            bool flag = false;
            using (List<Command.Property>.Enumerator enumerator = this.propertySetList.GetEnumerator())
            {
                int num = 5;
                while (true)
                {
                    Command.Property current = new Property();
                    switch (num)
                    {
                        case 0:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num = 2;
                                continue;
                            }
                            num = 3;
                            continue;
                        case 1:
                            flag = current.IsSecured;
                            num = 4;
                            continue;
                        case 2:
                            if (current.DataName == sCommandName)
                            {
                                num = 1;
                                continue;
                            }
                            break;
                        case 3:
                        case 4:
                            num = 6;
                            continue;
                        case 6:
                            goto label_12;
                    }
                    num = 0;
                }
            }
            label_12:
            if (1 == 0)
                ;
            return flag;
        }

        public enReturnCode Set(string sCommandName, object dataIn)
        {
            int A_1 = 1;
            if (1 == 0)
                ;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊", A_1), Module.a("ᑆ㵈⩊㽌㭎㑐㝒畔ౖ⩘ᡚ\x325C\x325Eౠɢ\x0B64ͦ❨੪l੮䭰", A_1) + sCommandName + Module.a("ᩆ", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            int num1 = 1;
            List<Command.Property>.Enumerator enumerator = new List<Property>.Enumerator();
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 2;
                            continue;
                        }
                        goto label_24;
                    case 2:
                        enReturnCode = enReturnCode.e_NODE_NOT_FOUND;
                        enumerator = this.propertySetList.GetEnumerator();
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_5:
            try
            {
                int num2 = 4;
                Command.Property current = new Property();
                Command.DataFunctionSetDelegate functionSetDelegate = null;

                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            goto label_24;
                        case 1:
                        case 3:
                        case 8:
                            num2 = 0;
                            continue;
                        case 2:
                            if (current.DataName == sCommandName)
                            {
                                num2 = 9;
                                continue;
                            }
                            break;
                        case 5:
                            if (functionSetDelegate == null)
                            {
                                enReturnCode = enReturnCode.e_UNKNOWN;
                                num2 = 3;
                                continue;
                            }
                            num2 = 7;
                            continue;
                        case 6:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num2 = 2;
                                continue;
                            }
                            num2 = 8;
                            continue;
                        case 7:
                            enReturnCode = functionSetDelegate(sCommandName, dataIn);
                            num2 = 1;
                            continue;
                        case 9:
                            functionSetDelegate = (Command.DataFunctionSetDelegate)null;
                            num2 = 10;
                            continue;
                        case 10:
                            try
                            {
                                functionSetDelegate = (Command.DataFunctionSetDelegate)Delegate.CreateDelegate(typeof(Command.DataFunctionSetDelegate), (object)this, current.DataFunction);
                            }
                            catch
                            {
                            }
                            num2 = 5;
                            continue;
                    }
                    num2 = 6;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            label_24:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("ᑆⱈ㽊", A_1), Module.a("ц♈♊㵌⍎㑐❒ご㍖祘ⱚ㑜\x2B5Eॠ奢䕤", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        public string[] SupportedExecuteCommands()
        {
            label_2:
            string[] strArray = new string[this.executeList.Count];
            int index = 0;
            if (1 == 0)
                ;
            int num = 1;
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
                        if (index >= strArray.Length)
                        {
                            num = 0;
                            continue;
                        }
                        strArray[index] = this.executeList[index].Name;
                        ++index;
                        num = 2;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_8:
            return strArray;
        }

        public enReturnCode TypeOfExecute(string sCommandName, out Type typeIn, out Type typeOut)
        {
            enReturnCode enReturnCode = enReturnCode.e_INVALID_COMMAND;
            typeIn = (Type)null;
            typeOut = (Type)null;
            using (List<Command.CommandExecute>.Enumerator enumerator = this.executeList.GetEnumerator())
            {
                int num = 3;
                while (true)
                {
                    Command.CommandExecute current = new CommandExecute();
                    switch (num)
                    {
                        case 0:
                            goto label_13;
                        case 1:
                        case 6:
                            num = 0;
                            continue;
                        case 2:
                            if (current.Name == sCommandName)
                            {
                                num = 4;
                                continue;
                            }
                            break;
                        case 4:
                            typeIn = current.TypeIn;
                            typeOut = current.TypeOut;
                            enReturnCode = enReturnCode.e_OK;
                            num = 1;
                            continue;
                        case 5:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                if (1 == 0)
                                    ;
                                num = 2;
                                continue;
                            }
                            num = 6;
                            continue;
                    }
                    num = 5;
                }
            }
            label_13:
            return enReturnCode;
        }

        public bool IsExecuteSupported(string sCommandName)
        {
            return Array.IndexOf<string>(this.SupportedExecuteCommands(), sCommandName) != -1;
        }

        public bool IsExecuteSecured(string sCommandName)
        {
            bool flag = false;
            using (List<Command.CommandExecute>.Enumerator enumerator = this.executeList.GetEnumerator())
            {
                int num = 3;
                while (true)
                {
                    Command.CommandExecute current = new CommandExecute();
                    switch (num)
                    {
                        case 0:
                            if (current.Name == sCommandName)
                            {
                                num = 1;
                                continue;
                            }
                            break;
                        case 1:
                            flag = current.IsSecured;
                            num = 6;
                            continue;
                        case 2:
                        case 6:
                            num = 4;
                            continue;
                        case 3:
                            if (1 == 0)
                                break;
                            break;
                        case 4:
                            goto label_13;
                        case 5:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num = 0;
                                continue;
                            }
                            num = 2;
                            continue;
                    }
                    num = 5;
                }
            }
            label_13:
            return flag;
        }

        public enReturnCode Execute(string sCommandName, object dataIn, out object dataOut)
        {
            int A_1 = 18;
            label_2:
            this.log.TraceInMessage(this.GetType().ToString(), Module.a("\x1D57≙㥛㵝ᕟᙡţ", A_1), Module.a("ୗ\x2E59㵛ⱝᑟݡc䙥㍧ᥩ⽫ŭᵯάᕳᡵᱷ㑹ᵻ\x137D\xE57F뢁", A_1) + sCommandName + Module.a("\x0557", A_1));
            enReturnCode enReturnCode = enReturnCode.e_OK;
            dataOut = (object)null;
            int num1 = 0;
            List<Command.CommandExecute>.Enumerator enumerator = new List<CommandExecute>.Enumerator();
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        if (enReturnCode == enReturnCode.e_OK)
                        {
                            num1 = 1;
                            continue;
                        }
                        goto label_25;
                    case 1:
                        enReturnCode = enReturnCode.e_NODE_NOT_FOUND;
                        enumerator = this.executeList.GetEnumerator();
                        if (1 == 0)
                            ;
                        num1 = 2;
                        continue;
                    case 2:
                        goto label_5;
                    default:
                        goto label_2;
                }
            }
            label_5:
            try
            {
                int num2 = 2;
                while (true)
                {
                    Command.CommandExecute current = new CommandExecute();
                    Command.ExecuteDelegate executeDelegate = null;
                    switch (num2)
                    {
                        case 0:
                            if (enumerator.MoveNext())
                            {
                                current = enumerator.Current;
                                num2 = 4;
                                continue;
                            }
                            num2 = 10;
                            continue;
                        case 1:
                            if (executeDelegate == null)
                            {
                                enReturnCode = enReturnCode.e_UNKNOWN;
                                num2 = 9;
                                continue;
                            }
                            num2 = 6;
                            continue;
                        case 3:
                            try
                            {
                                executeDelegate = (Command.ExecuteDelegate)Delegate.CreateDelegate(typeof(Command.ExecuteDelegate), (object)this, current.Function);
                            }
                            catch
                            {
                            }
                            num2 = 1;
                            continue;
                        case 4:
                            if (current.Name == sCommandName)
                            {
                                num2 = 8;
                                continue;
                            }
                            break;
                        case 5:
                        case 9:
                        case 10:
                            num2 = 7;
                            continue;
                        case 6:
                            enReturnCode = executeDelegate(sCommandName, dataIn, out dataOut);
                            num2 = 5;
                            continue;
                        case 7:
                            goto label_25;
                        case 8:
                            executeDelegate = (Command.ExecuteDelegate)null;
                            num2 = 3;
                            continue;
                    }
                    num2 = 0;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            label_25:
            this.log.TraceOutMessage(this.GetType().ToString(), Module.a("\x1D57≙㥛㵝ᕟᙡţ", A_1), Module.a("᭗㕙ㅛ\x2E5D\x0C5Fݡၣͥ౧䩩᭫ݭѯᩱ乳噵", A_1) + enReturnCode.ToString());
            return enReturnCode;
        }

        protected struct Property
        {
            public string DataName;
            public Type DataType;
            public string DataFunction;
            public bool IsSecured;

            public Property(string sCommandName, Type dataType, string dataFunction, bool isSecured)
            {
                this.DataName = sCommandName;
                this.DataType = dataType;
                this.DataFunction = dataFunction;
                this.IsSecured = isSecured;
            }
        }

        protected delegate enReturnCode DataFunctionGetDelegate(string sCommandName, out object dataOut);

        protected delegate enReturnCode DataFunctionSetDelegate(string sCommandName, object dataIn);

        protected struct CommandExecute
        {
            public string Name;
            public Type TypeIn;
            public Type TypeOut;
            public string Function;
            public bool IsSecured;

            public CommandExecute(string name, Type typeIn, Type typeOut, string function, bool isSecured)
            {
                this.Name = name;
                this.TypeIn = typeIn;
                this.TypeOut = typeOut;
                this.Function = function;
                this.IsSecured = isSecured;
            }
        }

        protected delegate enReturnCode ExecuteDelegate(string sCommandName, object dataIn, out object dataOut);
    }
}
