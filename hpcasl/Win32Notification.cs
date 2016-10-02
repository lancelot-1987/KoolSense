// Decompiled with JetBrains decompiler
// Type: hpCasl.Win32Notification
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace hpCasl
{
  public class Win32Notification
  {
    public const int WM_COPYDATA = 74;
    public const string WindowName = "hpNotification.c9c74d8c-a080-41c1-8521-4148c8764789";
    private const string globalMutex = "hpNotification.GlobalMutex";

    [DllImport("kernel32.dll")]
    public static extern int WTSGetActiveConsoleSessionId();

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern bool IsWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    public static bool Send(string Message)
    {
      int A_1 = 14;
      bool flag = false;
      Mutex mutex = new Mutex(false, Casl.a("\xE38Aﶌ솎ﺐ\xE792ﲔ\xF196\xF098\xF89Aﲜ\xEB9E좠첢쮤覦\xEEA8잪슬춮킰\xDFB2\xF8B4슶춸\xDEBA얼", A_1));
      mutex.WaitOne();
      try
      {
label_3:
        IntPtr window = Win32Notification.FindWindow((string) null, Casl.a("\xE38Aﶌ솎ﺐ\xE792ﲔ\xF196\xF098\xF89Aﲜ\xEB9E좠첢쮤覦쪨銪캬颮薰ힲ趴풶钸\xDABA趼螾\xF1C0\xEEC2\xF1C4\xF6C6\xAAC8響\xE0CC\xF7CE\xE4D0\xE1D2\xE4D4𥳐\xEDD8\xEADA\xE9DC\xE7DE苠\xDBE2틤퇦\xDDE8\xDCEA헬훮", A_1));
        if (1 == 0)
          ;
        int num1 = 0;
        while (true)
        {
          switch (num1)
          {
            case 0:
              if (Win32Notification.IsWindow(window))
              {
                num1 = 3;
                continue;
              }
              goto case 2;
            case 1:
              goto label_10;
            case 2:
              num1 = 1;
              continue;
            case 3:
              Win32Notification.CopyDataStruct copyDataStruct = new Win32Notification.CopyDataStruct();
              copyDataStruct.dwData = (IntPtr) 1;
              copyDataStruct.cbData = (Message.Length + 1) * 2;
              copyDataStruct.lpData = Marshal.StringToHGlobalUni(Message);
              IntPtr num2 = Marshal.AllocHGlobal(Marshal.SizeOf((object) copyDataStruct));
              Marshal.StructureToPtr((object) copyDataStruct, num2, true);
              Win32Notification.SendMessage(window, 74U, IntPtr.Zero, num2);
              Marshal.FreeHGlobal(copyDataStruct.lpData);
              Marshal.FreeHGlobal(num2);
              flag = true;
              num1 = 2;
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
      mutex.ReleaseMutex();
      return flag;
    }

    public struct CopyDataStruct
    {
      public IntPtr dwData;
      public int cbData;
      public IntPtr lpData;
    }
  }
}
