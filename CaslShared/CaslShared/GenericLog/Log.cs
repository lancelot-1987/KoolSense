// Decompiled with JetBrains decompiler
// Type: GenericLog.Log
// Assembly: CaslShared, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 2B86D546-C3FF-4F7D-8628-2CB9C7CFB6C7
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\CaslShared.dll

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Xml;

namespace GenericLog
{
    [Serializable]
    public class Log
    {
        private const string CloseLogTag = "</LogFile>";
        private const string NewLine = "\r\n";
        public const string LOG_DEFAULT_LOGFILE_NAME = "\\GENERICLOGS.xml";
        private uint iMaxFileSize;
        private static EventLog elEmergency;
        private enLogType eLogType;
        private string sLogFile;
        private string sPolicyFile;
        private string sIdentity;
        private string sSubIdentity;
        private string sProcessName;
        private string sApplicationName;
        private string sUserName;
        private string sLastErrorMessage;
        private enXmlEscape eXmlEscape;
        private bool bAutoSave;
        private bool bAppendMode;
        private bool bShowTimeStamp;
        private bool bShowUserName;
        private bool bShowIdentity;
        private bool bShowSubIdentity;
        private bool bShowApplicationName;
        private bool bShowProcessName;
        private bool bShowLogLevel;
        private bool bShowMessage;
        private bool bShowLabels;
        private bool bShowThreadId;
        private enLogLevel eMinLogLevel;
        private enLogLevel eMaxLogLevel;
        private bool bByteDumpAllowed;
        private bool bIsOpen;
        private bool bChanged;
        private XmlDocument xdXmlFile;
        private EventLog elEventLog;
        private FileStream fileStream;
        private byte[] baCloseLogTag;
        private byte[] baNewLine;

        public enLogLevel EMinLogLevel
        {
            get
            {
                return this.eMinLogLevel;
            }
            set
            {
                this.eMinLogLevel = value;
            }
        }

        public enLogLevel EMaxLogLevel
        {
            get
            {
                return this.eMaxLogLevel;
            }
            set
            {
                this.eMaxLogLevel = value;
            }
        }

        public bool BByteDumpAllowed
        {
            get
            {
                return this.bByteDumpAllowed;
            }
            set
            {
                this.bByteDumpAllowed = value;
            }
        }

        public enLogType ELogType
        {
            get
            {
                return this.eLogType;
            }
            set
            {
                this.eLogType = value;
            }
        }

        public string SLogFile
        {
            get
            {
                return this.sLogFile;
            }
            set
            {
                this.sLogFile = value;
            }
        }

        public uint MaxLogFileSize
        {
            get
            {
                return this.iMaxFileSize;
            }
            set
            {
                this.iMaxFileSize = value;
            }
        }

        public string SIdentity
        {
            get
            {
                return this.sIdentity;
            }
            set
            {
                this.sIdentity = value;
            }
        }

        public string SubIdentity
        {
            get
            {
                return this.sSubIdentity;
            }
            set
            {
                this.sSubIdentity = value;
            }
        }

        public string SApplicationName
        {
            get
            {
                return this.sApplicationName;
            }
            set
            {
                this.sApplicationName = value;
            }
        }

        public string SProcessName
        {
            get
            {
                return this.sProcessName;
            }
            set
            {
                this.sProcessName = value;
            }
        }

        public bool BShowTimeStamp
        {
            get
            {
                return this.bShowTimeStamp;
            }
            set
            {
                this.bShowTimeStamp = value;
            }
        }

        public string SUserName
        {
            get
            {
                return this.sUserName;
            }
            set
            {
                this.sUserName = value;
            }
        }

        public bool BShowUserName
        {
            get
            {
                return this.bShowUserName;
            }
            set
            {
                this.bShowUserName = value;
            }
        }

        public bool BShowApplicationName
        {
            get
            {
                return this.bShowApplicationName;
            }
            set
            {
                this.bShowApplicationName = value;
            }
        }

        public bool BShowIdentity
        {
            get
            {
                return this.bShowIdentity;
            }
            set
            {
                this.bShowIdentity = value;
            }
        }

        public bool BShowSubIdentity
        {
            get
            {
                return this.bShowSubIdentity;
            }
            set
            {
                this.bShowSubIdentity = value;
            }
        }

        public bool BShowProcessName
        {
            get
            {
                return this.bShowProcessName;
            }
            set
            {
                this.bShowProcessName = value;
            }
        }

        public bool BShowLogLevel
        {
            get
            {
                return this.bShowLogLevel;
            }
            set
            {
                this.bShowLogLevel = value;
            }
        }

        public bool BShowMessage
        {
            get
            {
                return this.bShowMessage;
            }
            set
            {
                this.bShowMessage = value;
            }
        }

        public bool BShowThreadId
        {
            get
            {
                return this.bShowThreadId;
            }
            set
            {
                this.bShowThreadId = value;
            }
        }

        public bool BAutoSave
        {
            get
            {
                return this.bAutoSave;
            }
            set
            {
                this.bAutoSave = value;
            }
        }

        public bool BAppendMode
        {
            get
            {
                return this.bAppendMode;
            }
            set
            {
                this.bAppendMode = value;
            }
        }

        public bool BShowLabels
        {
            get
            {
                return this.bShowLabels;
            }
            set
            {
                this.bShowLabels = value;
            }
        }

        public string LastErrorMessage
        {
            get
            {
                return this.sLastErrorMessage;
            }
            set
            {
                this.sLastErrorMessage = value;
            }
        }

        public static char[] LOG_NUMBERS
        {
            get
            {
                return new char[10]
                {
          '0',
          '1',
          '2',
          '3',
          '4',
          '5',
          '6',
          '7',
          '8',
          '9'
                };
            }
        }

        public Log(string FileName)
        {
            int A_1 = 12;
            this.iMaxFileSize = 1048576U;
            this.sLogFile = string.Empty;
            this.sPolicyFile = string.Empty;
            this.sIdentity = string.Empty;
            this.sSubIdentity = string.Empty;
            this.sProcessName = string.Empty;
            this.sApplicationName = string.Empty;
            this.sUserName = string.Empty;
            this.sLastErrorMessage = string.Empty;
            this.bAutoSave = true;
            this.bAppendMode = true;
            this.bShowTimeStamp = true;
            this.bShowIdentity = true;
            this.bShowSubIdentity = true;
            this.bShowProcessName = true;
            this.bShowLogLevel = true;
            this.bShowMessage = true;
            this.bShowThreadId = true;
            this.eMinLogLevel = enLogLevel.NoLogging;
            this.eMaxLogLevel = enLogLevel.NoLogging;
            // ISSUE: explicit constructor call
            if (string.IsNullOrEmpty(FileName))
                throw new ArgumentException(GenericLog.Log.a("ࡀⵂ㍄♆╈≊⥌潎㵐㱒\x3254睖㽘\x325Aㅜ㩞䅠ൢѤ੦౨", A_1));
            this.SLogFile = FileName;
            this.SApplicationName = Environment.GetCommandLineArgs()[0];
            this.SUserName = WindowsIdentity.GetCurrent().Name;
            this.EMinLogLevel = enLogLevel.Error;
            this.EMaxLogLevel = enLogLevel.Critical;
            try
            {
                this.SProcessName = Process.GetCurrentProcess().ProcessName;
                if (!string.IsNullOrEmpty(this.SProcessName))
                    this.SProcessName = this.SProcessName.Trim();
            }
            catch (Exception ex)
            {
                this.SProcessName = this.SApplicationName;
            }
            this.InitByteArrays();
            this.HandleMaxFileSize();
        }

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
        private void InitByteArrays()
        {
            int A_1 = 10;
            if (1 == 0)
                ;
            this.baCloseLogTag = Encoding.UTF8.GetBytes(Log.a("̾湀ག⩄⁆\x0F48≊⅌⩎潐", A_1));
            this.baNewLine = Encoding.UTF8.GetBytes(Log.a("㈾䭀", A_1));
        }

        private void SetDefaultLogFile()
        {
            int A_1 = 9;
            this.SetLoggingLocation();
            try
            {
                label_3:
                DirectoryInfo directoryInfo = new DirectoryInfo(this.SLogFile);
                int num = 5;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            num = 3;
                            continue;
                        case 1:
                            if (!directoryInfo.Exists)
                            {
                                num = 2;
                                continue;
                            }
                            goto case 0;
                        case 2:
                            directoryInfo.Create();
                            if (1 == 0)
                                ;
                            num = 0;
                            continue;
                        case 3:
                            goto label_13;
                        case 4:
                            num = 1;
                            continue;
                        case 5:
                            if (directoryInfo != null)
                            {
                                num = 4;
                                continue;
                            }
                            goto case 0;
                        default:
                            goto label_3;
                    }
                }
            }
            catch
            {
            }
            label_13:
            this.SLogFile += Log.a("戽ܿ݁\x0A43ͅᩇ͉ཋɍ\x1F4Fᕑݓ硕⁗㝙せ", A_1);
        }

        private void HandleMaxFileSize()
        {
            try
            {
                int num = 2;
                FileInfo A_0 = null;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            goto label_12;
                        case 1:
                            if (this.A(A_0))
                            {
                                num = 4;
                                continue;
                            }
                            goto case 3;
                        case 3:
                            num = 0;
                            continue;
                        case 4:
                            this.P(this.C(A_0));
                            num = 3;
                            continue;
                        case 5:
                            A_0 = new FileInfo(this.SLogFile);
                            num = 1;
                            continue;
                        default:
                            if (File.Exists(this.SLogFile))
                            {
                                num = 5;
                                continue;
                            }
                            goto case 3;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            label_12:
            if (1 != 0)
                ;
        }

        private string C(FileInfo A_0)
        {
            int A_1_1 = 16;
            label_2:
            string A_0_1 = string.Empty;
            StringCollection A_1_2;
            int A_2;
            this.A(A_0, out A_1_2, out A_2);
            int num = 0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (A_2 < 10)
                        {
                            num = 3;
                            continue;
                        }
                        A_0_1 = this.A(A_0_1, A_0, A_1_2);
                        num = 1;
                        continue;
                    case 1:
                        goto label_6;
                    case 2:
                        goto label_8;
                    case 3:
                        A_0_1 = this.A(A_0_1, A_0, Log.a("畄睆祈", A_1_1) + A_2.ToString());
                        num = 2;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_6:
            if (1 == 0)
                ;
            label_8:
            return A_0_1;
        }

        private void A(FileInfo A_0, out StringCollection A_1, out int A_2)
        {
            if (1 == 0)
                ;
            A_1 = this.B(A_0);
            A_2 = Log.A(A_1);
        }

        private static int A(StringCollection A_0)
        {
            if (1 == 0)
                ;
            int A_1 = 0;
            return Log.A(A_0, A_1) + 1;
        }

        private static int A(StringCollection A_0, int A_1)
        {
            StringEnumerator enumerator = A_0.GetEnumerator();
            try
            {
                int num = 4;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            if (enumerator.MoveNext())
                            {
                                string current = enumerator.Current;
                                A_1 = Log.B(A_1, current);
                                num = 3;
                                continue;
                            }
                            num = 1;
                            continue;
                        case 1:
                            num = 2;
                            continue;
                        case 2:
                            goto label_16;
                        default:
                            num = 0;
                            continue;
                    }
                }
            }
            finally
            {
                label_10:
                if (1 == 0)
                    ;
                IDisposable disposable = enumerator as IDisposable;
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
                            goto label_15;
                        case 1:
                            disposable.Dispose();
                            num = 2;
                            continue;
                        case 2:
                            goto label_15;
                        default:
                            goto label_10;
                    }
                }
                label_15:;
            }
            label_16:
            return A_1;
        }

        private StringCollection B(FileInfo A_0)
        {
            int A_1 = 0;
            label_2:
            string[] files = Directory.GetFiles(A_0.DirectoryName, Log.a("ἴᤶ䄸嘺儼", A_1));
            StringCollection stringCollection = new StringCollection();
            string[] strArray = files;
            int index = 0;
            int num = 6;
            string A_0_1 = null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        ++index;
                        num = 5;
                        continue;
                    case 1:
                        goto label_12;
                    case 2:
                        stringCollection.Add(A_0_1);
                        num = 0;
                        continue;
                    case 3:
                        if (index < strArray.Length)
                        {
                            A_0_1 = strArray[index];
                            num = 4;
                            continue;
                        }
                        num = 1;
                        continue;
                    case 4:
                        if (this.O(A_0_1))
                        {
                            num = 2;
                            continue;
                        }
                        goto case 0;
                    case 5:
                    case 6:
                        if (1 == 0)
                            ;
                        num = 3;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_12:
            return stringCollection;
        }

        private string A(string A_0, FileInfo A_1, string A_2)
        {
            int A_1_1 = 19;
            if (1 == 0)
                ;
            A_0 = A_1.DirectoryName + Log.a("ᑇ", A_1_1) + Path.GetFileNameWithoutExtension(this.SLogFile) + Log.a("ᝇ", A_1_1) + A_2 + Log.a("晇\x3249⅋≍", A_1_1);
            return A_0;
        }

        private void P(string A_0)
        {
            File.Copy(this.SLogFile, A_0, true);
            File.Delete(this.SLogFile);
        }

        private string A(string A_0, FileInfo A_1, StringCollection A_2)
        {
            int A_1_1 = 13;
            DateTime dateTime = File.GetLastWriteTime(A_1.DirectoryName + Log.a("ṁ", A_1_1) + Path.GetFileNameWithoutExtension(this.SLogFile) + Log.a("\x1D41瑃癅硇獉手㙍㵏㹑", A_1_1));
            string str = A_2[0];
            StringEnumerator enumerator = A_2.GetEnumerator();
            try
            {
                int num = 5;
                while (true)
                {
                    string current = null;
                    DateTime lastWriteTime = DateTime.Now;
                    switch (num)
                    {
                        case 0:
                            if (enumerator.MoveNext())
                            {
                                if (1 == 0)
                                    ;
                                current = enumerator.Current;
                                lastWriteTime = File.GetLastWriteTime(current);
                                num = 1;
                                continue;
                            }
                            num = 6;
                            continue;
                        case 1:
                            if (lastWriteTime.CompareTo(dateTime) < 0)
                            {
                                num = 2;
                                continue;
                            }
                            break;
                        case 2:
                            dateTime = lastWriteTime;
                            str = current;
                            num = 4;
                            continue;
                        case 3:
                            goto label_19;
                        case 6:
                            num = 3;
                            continue;
                    }
                    num = 0;
                }
            }
            finally
            {
                label_14:
                IDisposable disposable = enumerator as IDisposable;
                int num = 0;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            if (disposable != null)
                            {
                                num = 2;
                                continue;
                            }
                            goto label_18;
                        case 1:
                            goto label_18;
                        case 2:
                            disposable.Dispose();
                            num = 1;
                            continue;
                        default:
                            goto label_14;
                    }
                }
                label_18:;
            }
            label_19:
            A_0 = str;
            return A_0;
        }

        private static int B(int A_0, string A_1)
        {
            int A_1_1 = 18;
            label_2:
            int count = A_1.IndexOfAny(Log.LOG_NUMBERS, 0);
            if (1 == 0)
                ;
            int num = 1;
            string A_1_2 = null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        if (count > 0)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_9;
                    case 2:
                        A_1_2 = A_1.Remove(0, count).Replace(Log.a("楆ㅈ♊⅌", A_1_1), string.Empty);
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_6:
            try
            {
                A_0 = Log.A(A_0, A_1_2);
            }
            catch (Exception ex)
            {
            }
            label_9:
            return A_0;
        }

        private static int A(int A_0, string A_1)
        {
            int num = (int)Convert.ToInt16(A_1);
            if (num > A_0)
                A_0 = num;
            return A_0;
        }

        private bool O(string A_0)
        {
            return A_0.Contains(Path.GetFileNameWithoutExtension(this.SLogFile));
        }

        private bool A(FileInfo A_0)
        {
            return A_0.Length > (long)this.MaxLogFileSize;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool Message(enLogLevel eLogLevel, string sIdentity, string sSubIdentity, string sMessage)
        {
            try
            {
                this.A(eLogLevel, ref sIdentity, ref sSubIdentity, ref sMessage);
            }
            catch (Exception ex)
            {
                Log.B(eLogLevel, sIdentity, sSubIdentity, sMessage, ex.Message);
            }
            if (1 == 0)
                ;
            return true;
        }

        private void A(enLogLevel A_0, ref string A_1, ref string A_2, ref string A_3)
        {
            if (1 == 0)
                ;
            Log.A(ref A_1, ref A_2, ref A_3);
            this.A(A_0, A_1, A_2, A_3);
        }

        private void A(enLogLevel A_0, string A_1, string A_2, string A_3)
        {
            if (1 == 0)
                ;
            string A_2_1;
            string A_3_1;
            this.A(A_1, A_2, out A_2_1, out A_3_1);
            this.Message(A_0, A_3);
            this.B(A_2_1, A_3_1);
        }

        private void B(string A_0, string A_1)
        {
            this.SIdentity = A_0;
            this.SubIdentity = A_1;
        }

        private void A(string A_0, string A_1, out string A_2, out string A_3)
        {
            if (1 == 0)
                ;
            A_2 = this.SIdentity;
            this.SIdentity = A_0;
            A_3 = this.SubIdentity;
            this.SubIdentity = A_1;
        }

        private static void B(enLogLevel A_0, string A_1, string A_2, string A_3, string A_4)
        {
            try
            {
                if (1 == 0)
                    ;
                Log.LogToEventLog(Log.A(A_0, A_1, A_2, A_3, A_4), EventLogEntryType.Error, 100);
            }
            catch (Exception ex)
            {
                Log.A(ex);
            }
        }

        private static string A(enLogLevel A_0, string A_1, string A_2, string A_3, string A_4)
        {
            int A_1_1 = 2;
            if (1 == 0)
                ;
            return Log.a("笶嘸尺\x1D3C匾⑀㕂⁄⭆獈歊", A_1_1) + A_0.ToString() + Log.a("ᤶ㌸爺夼娾⽀㝂ⱄ㍆え煊浌", A_1_1) + A_1 + Log.a("ᤶ㌸栺䠼崾⡀❂⁄⥆㵈≊㥌㙎歐獒", A_1_1) + A_2 + Log.a("ᤶ㌸瘺堼䰾㉀≂≄≆獈歊", A_1_1) + A_3 + Log.a("ᤶ㌸縺䔼尾⑀㍂ㅄ\x2E46♈╊浌㵎㑐げご㹖⽘㹚㥜罞ᕠᅢᱤ\x0E66ݨ౪䵬᭮Ṱ卲ᥴᡶṸ䅺嵼", A_1_1) + A_4;
        }

        private static void A(Exception A_0)
        {
            int A_1 = 7;
            try
            {
                if (1 == 0)
                    ;
                Log.LogToEventLog(Log.a("礻䘽⌿❁㑃㉅ⅇ╉≋湍ㅏ♑⁓㍕㕗⩙⡛㝝\x0E5Fա䑣ብݧ䩩kŭᝯ剱s\x1975塷\x0E79ᑻ\x1B7Dꁿ잁\xF283\xE385\xE687ﺉ겋슍ﾏ\xF591꺓뚕", A_1) + A_0.Message, EventLogEntryType.Error, 100);
            }
            catch
            {
            }
        }

        private static void A(ref string A_0, ref string A_1, ref string A_2)
        {
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        A_2 = string.Empty;
                        num = 7;
                        continue;
                    case 1:
                        num = 6;
                        continue;
                    case 2:
                        A_1 = string.Empty;
                        num = 4;
                        continue;
                    case 4:
                        num = 8;
                        continue;
                    case 5:
                        A_0 = string.Empty;
                        num = 1;
                        continue;
                    case 6:
                        if (A_1 == null)
                        {
                            num = 2;
                            continue;
                        }
                        goto case 4;
                    case 7:
                        goto label_15;
                    case 8:
                        if (A_2 == null)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_15;
                    default:
                        if (A_0 == null)
                        {
                            num = 5;
                            continue;
                        }
                        goto case 1;
                }
            }
            label_15:
            if (1 != 0)
                ;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool Message(enLogLevel eLogLevel, string sMessage)
        {
            bool A_0 = false;
            try
            {
                int num = 2;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            this.K();
                            num = 1;
                            continue;
                        case 1:
                            if (this.G())
                            {
                                num = 4;
                                continue;
                            }
                            goto case 5;
                        case 3:
                            A_0 = this.A(A_0);
                            num = 5;
                            continue;
                        case 4:
                            num = 7;
                            continue;
                        case 5:
                            num = 6;
                            continue;
                        case 6:
                            goto label_14;
                        case 7:
                            if (this.C(eLogLevel, sMessage))
                            {
                                num = 3;
                                continue;
                            }
                            goto case 5;
                        default:
                            if (this.A(eLogLevel))
                            {
                                num = 0;
                                continue;
                            }
                            goto case 5;
                    }
                }
            }
            catch (Exception ex)
            {
                A_0 = Log.N(ex.Message);
            }
            label_14:
            if (1 == 0)
                ;
            return A_0;
        }

        private void K()
        {
            this.L(string.Empty);
        }

        private bool C(enLogLevel A_0, string A_1)
        {
            label_2:
            bool flag = false;
            string A_2 = this.TimeStampNow();
            enLogType elogType = this.ELogType;
            int num = 4;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                    case 2:
                        goto label_10;
                    case 3:
                        num = 5;
                        continue;
                    case 4:
                        if (1 == 0)
                            ;
                        switch (elogType)
                        {
                            case enLogType.XmlFile:
                                flag = this.B(A_0, A_1, A_2);
                                num = 1;
                                continue;
                            case enLogType.EventLog:
                                flag = this.B(A_0, A_1);
                                num = 2;
                                continue;
                            default:
                                num = 3;
                                continue;
                        }
                    case 5:
                        flag = this.J();
                        num = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_10:
            return flag;
        }

        private static bool N(string A_0)
        {
            int A_1 = 12;
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        Log.CreateEmergencyLogger();
                        Log.OpenEmergencyLogger();
                        if (1 == 0)
                            ;
                        num = 1;
                        continue;
                    case 1:
                        goto label_6;
                    default:
                        if (Log.elEmergency == null)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            Log.LogToEventLog(Log.a("р㭂♄≆㥈㽊\x244C⁎㽐獒㥔㡖㹘㱚㑜ㅞ٠䍢Ѥ䝦Ѩ\x0E6AṬᱮၰᑲၴ坶\x0E78ቺॼ\x177Eꆀ삂\xE984\xE886\xEE88놊권", A_1) + A_0 + Log.a("䭀䥂", A_1), EventLogEntryType.Warning, 100);
            return false;
        }

        private bool A(bool A_0)
        {
            label_2:
            this.bChanged = true;
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        A_0 = this.Save();
                        if (1 == 0)
                            ;
                        num = 1;
                        continue;
                    case 1:
                        goto label_7;
                    case 2:
                        if (this.BAutoSave)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_7;
                    default:
                        goto label_2;
                }
            }
            label_7:
            return A_0;
        }

        private bool J()
        {
            this.LastErrorMessage = Log.a("ౄ⥆㽈⩊⅌♎㕐獒㥔㡖㹘筚⥜♞ᅠ٢", 16);
            return false;
        }

        private bool B(enLogLevel A_0, string A_1)
        {
            if (1 == 0)
                ;
            bool flag = false;
            try
            {
                this.elEventLog.Source = this.SProcessName;
                this.elEventLog.WriteEntry(A_1, this.MapLogLevelToEventLogEntryType(A_0));
                flag = true;
            }
            catch (Exception ex)
            {
                this.LastErrorMessage = ex.Message;
            }
            return flag;
        }

        private bool B(enLogLevel A_0, string A_1, string A_2)
        {
            if (1 == 0)
                ;
            string A_0_1 = this.A(A_0, A_1, A_2);
            try
            {
                return this.M(A_0_1);
            }
            catch (Exception ex)
            {
                this.L(ex.Message);
                return false;
            }
        }

        private bool M(string A_0)
        {
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        goto label_5;
                    case 2:
                        this.J(A_0);
                        num = 0;
                        continue;
                    default:
                        if (this.I())
                        {
                            num = 2;
                            continue;
                        }
                        this.K(A_0);
                        num = 1;
                        continue;
                }
            }
            label_5:
            if (1 == 0)
                ;
            label_7:
            return true;
        }

        private void L(string A_0)
        {
            this.LastErrorMessage = A_0;
        }

        private void K(string A_0)
        {
            this.SetupNewLogFile();
            this.WriteTextToLogFile(A_0);
        }

        private void J(string A_0)
        {
            this.WriteTextToLogFile(A_0);
        }

        private bool I()
        {
            if (this.BAppendMode)
                return File.Exists(this.SLogFile);
            return false;
        }

        private string A(enLogLevel A_0, string A_1, string A_2)
        {
            if (1 == 0)
                ;
            string A_1_1 = string.Empty;
            string A_1_2 = this.F(this.E(this.D(this.C(this.B(this.A(A_2, A_1_1))))));
            string A_1_3 = this.A(A_0, A_1_2);
            this.A(A_1, ref A_1_3);
            return this.SimpleXmlElement(enNodeLogName.LogEntry.ToString(), this.I(A_1_3), true);
        }

        private string I(string A_0)
        {
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        string sText = Log.H();
                        A_0 += this.SimpleXmlElement(enNodeLogName.ThreadId.ToString(), sText);
                        num = 0;
                        continue;
                    default:
                        if (this.BShowThreadId)
                        {
                            if (1 == 0)
                                ;
                            num = 1;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_0;
        }

        private static string H()
        {
            int A_1 = 13;
            string str1 = string.Empty;
            string str2;
            try
            {
                str2 = Log.a("牁㱃", A_1) + Thread.CurrentThread.ManagedThreadId.ToString(Log.a("ᩁ", A_1));
            }
            catch
            {
                str2 = Log.a("ୁ⩃≅ⵇ㹉⥋㱍㵏㭑㩓㝕ⱗ㽙籛\x0A5D\x085Fၡţݥ౧䩩╫⩭", A_1);
            }
            if (1 == 0)
                ;
            return str2;
        }

        private void A(string A_0, ref string A_1)
        {
            int num = 4;
            enXmlEscape enXmlEscape = new enXmlEscape();
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 3:
                    case 6:
                        A_1 += this.SimpleXmlElement(enNodeLogName.Message.ToString(), A_0);
                        num = 1;
                        continue;
                    case 1:
                        goto label_11;
                    case 2:
                        enXmlEscape = this.eXmlEscape;
                        num = 5;
                        continue;
                    case 5:
                        switch (enXmlEscape)
                        {
                            case enXmlEscape.CData:
                                A_0 = Log.H(A_0);
                                num = 0;
                                continue;
                            case enXmlEscape.Ampersand:
                                A_0 = Log.G(A_0);
                                if (1 == 0)
                                    ;
                                num = 6;
                                continue;
                            default:
                                num = 7;
                                continue;
                        }
                    case 7:
                        num = 3;
                        continue;
                    default:
                        if (this.BShowMessage)
                        {
                            num = 2;
                            continue;
                        }
                        goto label_13;
                }
            }
            label_11:
            return;
            label_13:;
        }

        private static string H(string A_0)
        {
            int A_1 = 19;
            if (1 == 0)
                ;
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_9;
                    case 1:
                        num = 4;
                        continue;
                    case 2:
                        A_0 = Log.a("瑇歉ᝋ്ᑏፑS\x1755͗", A_1) + A_0 + Log.a("ᕇᝉ牋", A_1);
                        num = 0;
                        continue;
                    case 4:
                        if (A_0.Contains(Log.a("瑇", A_1)))
                        {
                            num = 2;
                            continue;
                        }
                        goto label_9;
                    default:
                        if (!A_0.Contains(Log.a("湇", A_1)))
                        {
                            num = 1;
                            continue;
                        }
                        goto case 2;
                }
            }
            label_9:
            return A_0;
        }

        private static string G(string A_0)
        {
            int A_1 = 4;
            int num = 3;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        num = 1;
                        continue;
                    case 1:
                        if (A_0.Contains(Log.a("Ը", A_1)))
                        {
                            num = 2;
                            continue;
                        }
                        goto label_9;
                    case 2:
                        A_0 = A_0.Replace(Log.a("Ἰ", A_1), Log.a("Ἰ娺值伾穀", A_1));
                        A_0 = A_0.Replace(Log.a("Ը", A_1), Log.a("Ἰ场䤼о", A_1));
                        num = 4;
                        continue;
                    case 4:
                        goto label_9;
                    default:
                        if (!A_0.Contains(Log.a("Ἰ", A_1)))
                        {
                            if (1 == 0)
                                ;
                            num = 0;
                            continue;
                        }
                        goto case 2;
                }
            }
            label_9:
            return A_0;
        }

        private string A(enLogLevel A_0, string A_1)
        {
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        A_1 += this.SimpleXmlElement(enNodeLogName.LogLevel.ToString(), A_0.ToString());
                        num = 2;
                        continue;
                    case 2:
                        goto label_5;
                    default:
                        if (this.BShowLogLevel)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_5:
            if (1 == 0)
                ;
            label_6:
            return A_1;
        }

        private string F(string A_0)
        {
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        A_0 += this.SimpleXmlElement(enNodeLogName.User.ToString(), this.SUserName);
                        num = 0;
                        continue;
                    case 2:
                        if (1 == 0)
                            break;
                        break;
                }
                if (this.BShowUserName)
                    num = 1;
                else
                    break;
            }
            label_6:
            return A_0;
        }

        private string E(string A_0)
        {
            int num = 1;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        A_0 += this.SimpleXmlElement(enNodeLogName.SubIdentity.ToString(), this.SubIdentity);
                        num = 2;
                        continue;
                    case 2:
                        goto label_6;
                    default:
                        if (this.BShowSubIdentity)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_0;
        }

        private string D(string A_0)
        {
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        if (1 == 0)
                            ;
                        A_0 += this.SimpleXmlElement(enNodeLogName.Identity.ToString(), this.SIdentity);
                        num = 1;
                        continue;
                    case 1:
                        goto label_6;
                    default:
                        if (this.bShowIdentity)
                        {
                            num = 0;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_0;
        }

        private string C(string A_0)
        {
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        if (1 == 0)
                            ;
                        A_0 += this.SimpleXmlElement(enNodeLogName.ApplicationName.ToString(), this.SApplicationName);
                        num = 0;
                        continue;
                    default:
                        if (this.BShowApplicationName)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_0;
        }

        private string B(string A_0)
        {
            int num = 2;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        goto label_6;
                    case 1:
                        A_0 += this.SimpleXmlElement(enNodeLogName.Process.ToString(), this.SProcessName);
                        num = 0;
                        continue;
                    default:
                        if (this.BShowProcessName)
                        {
                            if (1 == 0)
                                ;
                            num = 1;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_0;
        }

        private string A(string A_0, string A_1)
        {
            int num = 0;
            while (true)
            {
                switch (num)
                {
                    case 1:
                        A_1 += this.SimpleXmlElement(enNodeLogName.TimeStamp.ToString(), A_0);
                        num = 2;
                        continue;
                    case 2:
                        goto label_6;
                    default:
                        if (1 == 0)
                            ;
                        if (this.BShowTimeStamp)
                        {
                            num = 1;
                            continue;
                        }
                        goto label_6;
                }
            }
            label_6:
            return A_1;
        }

        private bool G()
        {
            if (!this.bIsOpen)
                return this.Open();
            return true;
        }

        private bool A(enLogLevel A_0)
        {
            return this.PolicyAllowsLogging(A_0);
        }

        private void WriteTextToLogFile(string sText)
        {
            if (1 == 0)
                ;
            this.F();
            this.A(Encoding.UTF8.GetBytes(sText));
            this.BAutoSave = false;
        }

        private void A(byte[] A_0)
        {
            if (1 == 0)
                ;
            this.fileStream.Write(A_0, 0, A_0.Length);
            this.fileStream.Write(this.baNewLine, 0, this.baNewLine.Length);
            this.fileStream.Write(this.baCloseLogTag, 0, this.baCloseLogTag.Length);
            this.fileStream.Flush();
            this.fileStream.Close();
        }

        private void F()
        {
            if (1 == 0)
                ;
            this.fileStream = new FileStream(this.SLogFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            this.fileStream.Seek(this.fileStream.Length - (long)(enNodeLogName.LogFile.ToString().Length + 5), SeekOrigin.Begin);
        }

        public static void LogToEventLog(string sError, EventLogEntryType evType, int iEventId)
        {
            try
            {
                Log.E();
                Log.A(sError, evType, iEventId);
            }
            catch
            {
            }
        }

        private static void A(string A_0, EventLogEntryType A_1, int A_2)
        {
            if (Log.elEmergency == null)
                return;
            Log.elEmergency.WriteEntry(A_0, A_1, A_2);
        }

        private static void E()
        {
            if (Log.elEmergency != null)
                return;
            try
            {
                Log.OpenEmergencyLogger();
            }
            catch
            {
                Log.elEmergency = (EventLog)null;
            }
        }

        public static void CreateEmergencyLogger()
        {
            int A_1 = 3;
            if (!EventLog.Exists(Log.a("缷弹刻嬽㈿⭁❃", A_1)))
            {
                try
                {
                    EventLog.CreateEventSource(new EventSourceCreationData(Log.a("缷弹刻嬽㈿⭁❃", A_1), Log.a("礷䨹䰻刽⤿⅁╃㉅ⅇ╉≋", A_1)));
                }
                catch (Exception ex)
                {
                }
            }
            if (1 != 0)
                ;
        }

        private static void OpenEmergencyLogger()
        {
            int A_1 = 13;
            try
            {
                Log.elEmergency = new EventLog(Log.a("́㑃㙅⑇⍉⽋⽍\x244F㭑㭓㡕", A_1), Environment.MachineName, Log.a("Ձ⅃⡅ⵇ㡉╋ⵍ", A_1));
            }
            catch (Exception ex)
            {
                Log.elEmergency = (EventLog)null;
            }
            if (1 != 0)
                ;
        }

        public bool TraceInMessage(string sMessage)
        {
            return this.Message(enLogLevel.TraceIn, sMessage);
        }

        public bool TraceOutMessage(string sMessage)
        {
            return this.Message(enLogLevel.TraceOut, sMessage);
        }

        public bool InformationMessage(string sMessage)
        {
            return this.Message(enLogLevel.Information, sMessage);
        }

        public bool WarningMessage(string sMessage)
        {
            return this.Message(enLogLevel.Warning, sMessage);
        }

        public bool FormatTraceInMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.TraceInMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatTraceOutMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.TraceOutMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool TraceInMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.TraceIn, sIdentity, sSubIdentity, sMessage);
        }

        public bool TraceOutMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.TraceOut, sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatInformationMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.InformationMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatUserMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.UserMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatWarningMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.WarningMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatErrorMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.ErrorMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool FormatCriticalMessage(string sIdentity, string sSubIdentity, string sFormat, params object[] list)
        {
            string sMessage = string.Format(sFormat, list);
            return this.CriticalMessage(sIdentity, sSubIdentity, sMessage);
        }

        public bool InformationMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.Information, sIdentity, sSubIdentity, sMessage);
        }

        public bool WarningMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.Warning, sIdentity, sSubIdentity, sMessage);
        }

        public bool ErrorMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.Error, sIdentity, sSubIdentity, sMessage);
        }

        public bool CriticalMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.Critical, sIdentity, sSubIdentity, sMessage);
        }

        public bool UserMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            return this.Message(enLogLevel.User, sIdentity, sSubIdentity, sMessage);
        }

        public bool ErrorMessage(string sMessage)
        {
            return this.Message(enLogLevel.Error, sMessage);
        }

        public bool CDATAMessage(string sIdentity, string sSubIdentity, string sMessage)
        {
            int A_1 = 4;
            if (1 == 0)
                ;
            sMessage = Log.a("Ըᨺ昼簾Հɂᅄنቈ", A_1) + sMessage + Log.a("搸昺̼", A_1);
            return this.Message(enLogLevel.Information, sIdentity, sSubIdentity, sMessage);
        }

        public bool Clear()
        {
            int A_1 = 19;
            label_2:
            bool flag = false;
            this.LastErrorMessage = string.Empty;
            enLogType elogType = this.ELogType;
            int num = 0;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        switch (elogType)
                        {
                            case enLogType.XmlFile:
                                flag = this.D();
                                if (1 == 0)
                                    ;
                                num = 4;
                                continue;
                            case enLogType.EventLog:
                                flag = true;
                                num = 2;
                                continue;
                            default:
                                num = 1;
                                continue;
                        }
                    case 1:
                        num = 3;
                        continue;
                    case 2:
                    case 4:
                    case 5:
                        goto label_10;
                    case 3:
                        this.LastErrorMessage = Log.a("Ň⑉㩋⽍㱏㭑こ癕㑗㕙㭛繝ᑟ᭡ᑣͥ", A_1);
                        num = 5;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_10:
            return flag;
        }

        private bool D()
        {
            int num1 = 3;
            bool flag = false;
            while (true)
            {
                int num2;
                switch (num1)
                {
                    case 0:
                        num2 = 1;
                        break;
                    case 1:
                        num2 = this.Close() ? 1 : 0;
                        break;
                    case 2:
                        goto label_3;
                    case 4:
                        num1 = 0;
                        continue;
                    default:
                        num1 = this.bIsOpen ? 1 : 4;
                        continue;
                }
                flag = num2 != 0;
                num1 = 2;
            }
            label_3:
            try
            {
                int num2 = 2;
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            try
                            {
                                File.Delete(this.SLogFile);
                                flag = false;
                                break;
                            }
                            catch (Exception ex)
                            {
                                this.LastErrorMessage = ex.Message;
                                flag = true;
                                break;
                            }
                        case 1:
                            if (File.Exists(this.SLogFile))
                            {
                                num2 = 0;
                                continue;
                            }
                            break;
                        case 3:
                            num2 = 1;
                            continue;
                        case 4:
                            goto label_19;
                        default:
                            if (1 == 0)
                                ;
                            if (flag)
                            {
                                num2 = 3;
                                continue;
                            }
                            break;
                    }
                    num2 = 4;
                }
            }
            catch (Exception ex)
            {
                this.LastErrorMessage = ex.Message;
            }
            label_19:
            return flag;
        }

        public bool Save()
        {
            int A_1 = 11;
            if (1 == 0)
                ;
            label_2:
            this.LastErrorMessage = string.Empty;
            bool flag = false;
            int num1 = 5;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        label_5:
                        num1 = 3;
                        continue;
                    case 1:
                        try
                        {
                            label_11:
                            enLogType elogType = this.ELogType;
                            int num2 = 5;
                            while (true)
                            {
                                switch (num2)
                                {
                                    case 0:
                                        goto label_5;
                                    case 1:
                                        num2 = 4;
                                        continue;
                                    case 2:
                                    case 3:
                                    case 6:
                                        num2 = 0;
                                        continue;
                                    case 4:
                                        this.LastErrorMessage = Log.a("िⱁ㉃❅⑇⍉⡋湍㱏㵑㍓癕ⱗ⍙ⱛ㭝", A_1);
                                        num2 = 2;
                                        continue;
                                    case 5:
                                        switch (elogType)
                                        {
                                            case enLogType.XmlFile:
                                                this.xdXmlFile.Save(this.SLogFile);
                                                this.bChanged = false;
                                                flag = true;
                                                num2 = 6;
                                                continue;
                                            case enLogType.EventLog:
                                                flag = true;
                                                num2 = 3;
                                                continue;
                                            default:
                                                num2 = 1;
                                                continue;
                                        }
                                    default:
                                        goto label_11;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            this.LastErrorMessage = ex.Message;
                            goto case 0;
                        }
                    case 2:
                        goto label_21;
                    case 3:
                        if (flag)
                        {
                            num1 = 4;
                            continue;
                        }
                        goto label_21;
                    case 4:
                        this.bChanged = false;
                        num1 = 2;
                        continue;
                    case 5:
                        if (this.bIsOpen)
                        {
                            num1 = 1;
                            continue;
                        }
                        this.LastErrorMessage = Log.a("ؿ⭁⡃⍅桇⑉⍋㩍灏㵑\x2453㍕㙗", A_1);
                        num1 = 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_21:
            return flag;
        }

        public bool DearAby(byte[] abyBytes, string sFileName)
        {
            int A_1 = 17;
            label_2:
            bool flag = false;
            int num = 3;
            string str = null;
            int index = 0;
            string contents = null;
            while (true)
            {
                switch (num)
                {
                    case 0:
                        str = Path.GetDirectoryName(Path.GetFullPath(this.SLogFile)) + Log.a("ᩅ", A_1) + sFileName;
                        num = 7;
                        continue;
                    case 1:
                        File.Copy(str, str + Guid.NewGuid().ToString() + Log.a("桅㱇\x3249㡋", A_1));
                        num = 5;
                        continue;
                    case 2:
                    case 8:
                        num = 4;
                        continue;
                    case 3:
                        if (this.BByteDumpAllowed)
                        {
                            num = 9;
                            continue;
                        }
                        goto label_16;
                    case 4:
                        if (index >= abyBytes.Length)
                        {
                            num = 0;
                            continue;
                        }
                        contents += string.Format(Log.a("⑅ㅇ㹉⥋湍\x0B4F⥑摓⭕\x0557穙慛繝᭟卡ᥣ䙥䡧䩩屫᙭୯䍱乳\x2E75䩷ݹ屻幽ꁿ辁躃", A_1), (object)index, (object)abyBytes[index]);
                        ++index;
                        num = 2;
                        continue;
                    case 5:
                        File.WriteAllText(str, contents);
                        flag = true;
                        num = 6;
                        continue;
                    case 6:
                        goto label_16;
                    case 7:
                        if (1 == 0)
                            ;
                        if (File.Exists(str))
                        {
                            num = 1;
                            continue;
                        }
                        goto case 5;
                    case 9:
                        contents = string.Empty;
                        index = 0;
                        num = 8;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_16:
            return flag;
        }

        private bool Open()
        {
            int A_1 = 13;
            this.LastErrorMessage = string.Empty;
            bool flag = false;
            if (!this.bIsOpen)
            {
                try
                {
                    label_3:
                    enLogType elogType = this.ELogType;
                    int num = 0;
                    string directoryName = null;
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                switch (elogType)
                                {
                                    case enLogType.XmlFile:
                                        num = 8;
                                        continue;
                                    case enLogType.EventLog:
                                        this.elEventLog = new EventLog();
                                        flag = true;
                                        num = 19;
                                        continue;
                                    default:
                                        num = 15;
                                        continue;
                                }
                            case 1:
                                goto label_30;
                            case 2:
                                num = 9;
                                continue;
                            case 3:
                                directoryName = Path.GetDirectoryName(Path.GetFullPath(this.SLogFile));
                                num = 6;
                                continue;
                            case 4:
                                num = 14;
                                continue;
                            case 5:
                                this.LastErrorMessage = Log.a("ୁ⩃ぅ⥇♉╋⩍灏㹑㭓ㅕ硗\x2E59╛\x2E5D՟", A_1);
                                flag = false;
                                num = 7;
                                continue;
                            case 6:
                                if (!Directory.Exists(directoryName))
                                {
                                    num = 12;
                                    continue;
                                }
                                goto case 2;
                            case 7:
                            case 10:
                            case 19:
                                this.bIsOpen = flag;
                                num = 11;
                                continue;
                            case 8:
                                if (!File.Exists(this.SLogFile))
                                {
                                    num = 3;
                                    continue;
                                }
                                goto case 2;
                            case 9:
                                if (this.BAppendMode)
                                {
                                    num = 4;
                                    continue;
                                }
                                goto case 16;
                            case 11:
                                if (flag)
                                {
                                    num = 13;
                                    continue;
                                }
                                goto case 18;
                            case 12:
                                Directory.CreateDirectory(directoryName);
                                num = 2;
                                continue;
                            case 13:
                                this.bChanged = false;
                                num = 18;
                                continue;
                            case 14:
                                if (!File.Exists(this.SLogFile))
                                {
                                    num = 16;
                                    continue;
                                }
                                goto case 17;
                            case 15:
                                num = 5;
                                continue;
                            case 16:
                                this.SetupNewLogFile();
                                num = 17;
                                continue;
                            case 17:
                                flag = true;
                                num = 10;
                                continue;
                            case 18:
                                num = 1;
                                continue;
                            default:
                                goto label_3;
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.LastErrorMessage = ex.Message;
                }
            }
            label_30:
            if (1 == 0)
                ;
            return flag;
        }

        private void SetupNewLogFile()
        {
            int A_1 = 13;
            if (1 == 0)
                ;
            string str = Log.a("แ⭃ⅅ桇ⱉ╋≍㕏牑", A_1) + Path.GetFileName(this.SLogFile) + Log.a("扁❃㑅ⵇ⭉㡋\x2B4D㑏牑㙓⽕硗", A_1) + this.SApplicationName + Log.a("扁╃㉅桇", A_1) + this.TimeStampNow();
            File.WriteAllLines(this.SLogFile, new string[4]
            {
        Log.a("繁筃㹅╇♉汋㡍㕏⁑❓㽕㝗㑙慛籝兟䱡呣䑥䡧ཀྵɫ൭Ὧᙱᵳᡵί䝹幻\x0B7D\xF47F\xE481ꦃ뺅ꪇ떉늋", A_1),
        Log.a("繁敃歅敇橉", A_1) + str + Log.a("扁楃歅癇", A_1),
        Log.a("繁ࡃ⥅⽇\x0C49╋≍㕏汑", A_1),
        Log.a("繁歃\x0A45❇ⵉੋ❍㱏㝑橓", A_1)
            });
            this.BAppendMode = true;
        }

        private bool Close()
        {
            int A_1 = 7;
            this.LastErrorMessage = string.Empty;
            bool flag = false;
            try
            {
                int num = 6;
                enLogType elogType = new enLogType();
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            num = 10;
                            continue;
                        case 1:
                            this.Save();
                            num = 3;
                            continue;
                        case 2:
                            num = 13;
                            continue;
                        case 3:
                            elogType = this.ELogType;
                            num = 7;
                            continue;
                        case 4:
                        case 5:
                        case 16:
                            num = 8;
                            continue;
                        case 7:
                            switch (elogType)
                            {
                                case enLogType.XmlFile:
                                    this.xdXmlFile = (XmlDocument)null;
                                    flag = true;
                                    num = 4;
                                    continue;
                                case enLogType.EventLog:
                                    this.elEventLog = (EventLog)null;
                                    flag = true;
                                    num = 16;
                                    continue;
                                default:
                                    num = 14;
                                    continue;
                            }
                        case 8:
                            if (flag)
                            {
                                num = 9;
                                continue;
                            }
                            goto case 0;
                        case 9:
                            this.bIsOpen = false;
                            num = 0;
                            continue;
                        case 10:
                            goto label_25;
                        case 11:
                            if (this.BAutoSave)
                            {
                                num = 2;
                                continue;
                            }
                            goto case 3;
                        case 12:
                            num = 11;
                            continue;
                        case 13:
                            if (this.bChanged)
                            {
                                num = 1;
                                continue;
                            }
                            goto case 3;
                        case 14:
                            num = 15;
                            continue;
                        case 15:
                            this.LastErrorMessage = Log.a("画倽㘿⍁⡃⽅ⱇ橉⁋⅍㝏牑⁓⽕⡗㽙", A_1);
                            flag = false;
                            num = 5;
                            continue;
                        default:
                            if (this.bIsOpen)
                            {
                                num = 12;
                                continue;
                            }
                            goto case 3;
                    }
                }
            }
            catch (Exception ex)
            {
                this.LastErrorMessage = ex.Message;
            }
            label_25:
            if (1 == 0)
                ;
            return flag;
        }

        public uint LogLevelToUInt(enLogLevel eLogLevel)
        {
            label_2:
            if (1 == 0)
                ;
            uint num1 = 4U;
            enLogLevel enLogLevel = eLogLevel;
            int num2 = 0;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        switch (enLogLevel)
                        {
                            case enLogLevel.TraceIn:
                                num1 = 0U;
                                num2 = 8;
                                continue;
                            case enLogLevel.TraceOut:
                                num1 = 1U;
                                num2 = 11;
                                continue;
                            case enLogLevel.Information:
                                num1 = 2U;
                                num2 = 1;
                                continue;
                            case enLogLevel.Warning:
                                num1 = 3U;
                                num2 = 4;
                                continue;
                            case enLogLevel.Error:
                                num1 = 4U;
                                num2 = 6;
                                continue;
                            default:
                                num2 = 10;
                                continue;
                        }
                    case 1:
                    case 4:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 11:
                    case 12:
                        goto label_18;
                    case 2:
                        num1 = 99U;
                        num2 = 9;
                        continue;
                    case 3:
                        num2 = 2;
                        continue;
                    case 5:
                        switch (enLogLevel)
                        {
                            case enLogLevel.Critical:
                                num1 = 100U;
                                num2 = 12;
                                continue;
                            case enLogLevel.User:
                                num1 = 101U;
                                num2 = 7;
                                continue;
                            default:
                                num2 = 3;
                                continue;
                        }
                    case 10:
                        num2 = 5;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_18:
            return num1;
        }

        public enLogLevel StringToLogLevel(string sLogLevel)
        {
            return enLogLevel.TraceOut;
        }

        private bool PolicyAllowsLogging(enLogLevel eLogLevel)
        {
            label_2:
            uint num1 = this.LogLevelToUInt(eLogLevel);
            int num2 = 3;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        num2 = 2;
                        continue;
                    case 1:
                        goto label_5;
                    case 2:
                        goto label_7;
                    case 3:
                        if (1 == 0)
                            ;
                        num2 = num1 < this.LogLevelToUInt(this.EMinLogLevel) ? 1 : 0;
                        continue;
                    default:
                        goto label_2;
                }
            }
            label_5:
            int num3 = 0;
            goto label_8;
            label_7:
            num3 = num1 <= this.LogLevelToUInt(this.EMaxLogLevel) ? 1 : 0;
            label_8:
            return num3 != 0;
        }

        private string SimpleXmlElement(string sName, string sText)
        {
            return this.SimpleXmlElement(sName, sText, false);
        }

        private string SimpleXmlElement(string sName, string sText, bool bLineBreakAfterOpeningTag)
        {
            int A_1 = 11;
            if (1 == 0)
                ;
            return Log.a("簿", A_1) + sName + Log.a("縿", A_1) + (bLineBreakAfterOpeningTag ? Log.a("䨿", A_1) : "") + sText + Log.a("簿流", A_1) + sName + Log.a("縿䡁", A_1);
        }

        private string TimeStamp(DateTime dt)
        {
            int A_1 = 9;
            if (1 == 0)
                ;
            return dt.Year.ToString(Log.a("稽琿", A_1)) + Log.a("ᄽ", A_1) + dt.Month.ToString(Log.a("稽爿", A_1)) + Log.a("ᄽ", A_1) + dt.Day.ToString(Log.a("稽爿", A_1)) + Log.a("ḽ", A_1) + dt.Hour.ToString(Log.a("稽爿", A_1)) + Log.a("н", A_1) + dt.Minute.ToString(Log.a("稽爿", A_1)) + Log.a("н", A_1) + dt.Second.ToString(Log.a("稽爿", A_1)) + Log.a("ွ", A_1) + dt.Millisecond.ToString(Log.a("稽猿", A_1));
        }

        private string TimeStampNow()
        {
            return this.TimeStamp(DateTime.Now);
        }

        public void SetLoggingLocation()
        {
            int A_1 = 10;
            try
            {
                label_3:
                this.SLogFile = Log.A(Log.a("績ᅀፂńن\x1D48\x0A4A", A_1));
                int num = 5;
                while (true)
                {
                    switch (num)
                    {
                        case 0:
                            num = 2;
                            continue;
                        case 1:
                            this.SLogFile = Log.A(Log.a("績ീག၄ᑆై᥊Ṍ\x1F4E͐᱒ፔṖᕘṚ", A_1));
                            num = 4;
                            continue;
                        case 2:
                            goto label_12;
                        case 3:
                            this.B();
                            num = 0;
                            continue;
                        case 4:
                            if (!this.A())
                            {
                                num = 3;
                                continue;
                            }
                            goto case 0;
                        case 5:
                            if (!this.A())
                            {
                                num = 1;
                                continue;
                            }
                            goto case 0;
                        default:
                            goto label_3;
                    }
                }
            }
            catch (Exception ex)
            {
                this.B();
            }
            label_12:
            if (1 == 0)
                ;
            this.C();
        }

        private void C()
        {
            this.SLogFile += Log.a("᥄ཆ᥈ᩊŌNᙐ", 16);
        }

        private void B()
        {
            this.SLogFile = Log.a("B罄ᭆ", 14);
        }

        private static string A(string A_0)
        {
            return Environment.GetEnvironmentVariable(A_0);
        }

        private bool A()
        {
            return !string.IsNullOrEmpty(this.SLogFile);
        }

        private EventLogEntryType MapLogLevelToEventLogEntryType(enLogLevel eLogLevel)
        {
            label_2:
            EventLogEntryType eventLogEntryType = EventLogEntryType.Error;
            enLogLevel enLogLevel = eLogLevel;
            int num = 5;
            while (true)
            {
                switch (num)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 7:
                        goto label_13;
                    case 3:
                        num = 6;
                        continue;
                    case 4:
                        num = 7;
                        continue;
                    case 5:
                        {
                            switch (enLogLevel)
                            {
                                case enLogLevel.TraceIn:
                                case enLogLevel.TraceOut:
                                case enLogLevel.Information:
                                    eventLogEntryType = EventLogEntryType.Information;
                                    num = 0;
                                    continue;
                                case enLogLevel.Warning:
                                    eventLogEntryType = EventLogEntryType.Warning;
                                    num = 2;
                                    continue;
                                case enLogLevel.Error:
                                    break;
                                default:
                                    if (1 == 0)
                                        ;
                                    num = 3;
                                    continue;
                            }
                        }
                        break;
                    case 6:
                        if (enLogLevel != enLogLevel.Critical)
                        {
                            num = 4;
                            continue;
                        }
                        break;
                    default:
                        goto label_2;
                }
                eventLogEntryType = EventLogEntryType.Error;
                num = 1;
            }
            label_13:
            return eventLogEntryType;
        }
    }
}
