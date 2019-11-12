using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using CaslWmi;
using hpCasl;
using TrayApp.Properties;

namespace TrayApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MyCustomApplicationContext());
        }
    }


    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private ToolStripMenuItem btnQuiet;
        private ToolStripMenuItem btnOptimized;
        private ToolStripMenuItem btnCool;
        private CommandDiags diags;

        private enum ThermalStatus
        {
            Quiet = 2,
            Cool = 1,
            Optimized = 0
        }

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
         
            btnQuiet = new ToolStripMenuItem("Quiet", null, btn_Checked)
            {
                CheckOnClick = true
            };
            btnOptimized = new ToolStripMenuItem("Optimized", null, btn_Checked)
            {
                CheckOnClick = true
            };
            btnCool = new ToolStripMenuItem("Cool", null, btn_Checked)
            {
                CheckOnClick = true
            };

            diags = new CommandDiags();
            ThermalStatus status = GetThermalStatus();
            UpdateMenu(status);



            var icon = SystemIcons.Application;
            trayIcon = new NotifyIcon()
            {
                Icon = icon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items =
                    {
                        btnQuiet,
                        btnOptimized,
                        btnCool,
                        new ToolStripMenuItem("Exit", null, Exit)
                    }
                },
                Visible = true
            };
        }

        private void UpdateMenu(ThermalStatus status)
        {
            switch (status)
            {
                case ThermalStatus.Cool:
                {
                    btnCool.Checked = true;
                    btnQuiet.Checked = false; 
                    btnOptimized.Checked = false;
                }
                    break;
                case ThermalStatus.Optimized:
                {
                    btnCool.Checked = false;
                    btnQuiet.Checked = false; 
                    btnOptimized.Checked = true;
                }
                    break;
                case ThermalStatus.Quiet:
                {
                    btnCool.Checked = false;
                    btnQuiet.Checked = true; 
                    btnOptimized.Checked = false;
                }
                    break;
            }
        }

        private void btn_Checked(object sender, EventArgs e)
        {
            ThermalStatus newStatus = ThermalStatus.Quiet;
            if (sender == btnCool)
            {
                newStatus = ThermalStatus.Cool;
            }
            else if (sender == btnOptimized)
            {
                newStatus = ThermalStatus.Optimized;
            }
            else if (sender == btnQuiet)
            {
                newStatus = ThermalStatus.Quiet;
            }

            UpdateMenu(newStatus);
            SetThermalStatus(newStatus);
            // UpdateStatusLabel(GetThermalStatus());
        }

        private byte[] GetByteStatus()
        {
            object thermalStatus = null;
            enReturnCode ret = diags.Get(Constants.DiagsThermalControl, out thermalStatus);
            byte[] byteDiags = (byte[]) thermalStatus;
            return byteDiags;
        }

        private ThermalStatus GetThermalStatus()
        {
            return (ThermalStatus) GetByteStatus()[2];
        }

        private void SetThermalStatus(ThermalStatus status)
        {
            byte[] bytes = GetByteStatus();
            bytes[1] = (byte) status;
            bytes[2] = (byte) status;
            enReturnCode c = diags.Set(Constants.DiagsThermalControl, bytes);
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}