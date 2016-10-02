using CaslWmi;
using hpCasl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoolSense
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CommandDiags diags;
        private enum ThermalStatus{
            Quiet = 2,
            Cool = 1,
            Optimized = 0
        }
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void btn_Checked(object sender, RoutedEventArgs e)
        {
            ThermalStatus newStatus = ThermalStatus.Quiet;
            if (sender == btnCool)
            {
                newStatus = ThermalStatus.Cool;
            }else if(sender == btnOptimized)
            {
                newStatus = ThermalStatus.Optimized;
            }else if(sender == btnQuet)
            {
                newStatus = ThermalStatus.Quiet;
            }
            SetThermalStatus(newStatus);
            UpdateStatusLabel(GetThermalStatus());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            diags = new CommandDiags();
            ThermalStatus status = GetThermalStatus();
            switch (status)
            {
                case ThermalStatus.Cool:
                    {
                        btnCool.IsChecked = true;
                    }
                    break;
                case ThermalStatus.Optimized:
                    {
                        btnOptimized.IsChecked = true;
                    }
                    break;
                case ThermalStatus.Quiet:
                    {
                        btnQuet.IsChecked = true;
                    }
                    break;
            }
        }
        private void UpdateStatusLabel(ThermalStatus status)
        {
            switch (status)
            {
                case ThermalStatus.Cool:
                    {
                        lblMode.Content = "Cool";
                    }
                    break;
                case ThermalStatus.Optimized:
                    {
                        lblMode.Content = "Optimized";
                    }
                    break;
                case ThermalStatus.Quiet:
                    {
                        lblMode.Content = "Quiet";
                    }
                    break;
            }
        }

        private byte[] GetByteStatus()
        {
            object thermalStatus = null;
            enReturnCode ret = diags.Get(Constants.DiagsThermalControl, out thermalStatus);
            byte[] byteDiags = (byte[])thermalStatus;
            return byteDiags;
        }

        private ThermalStatus GetThermalStatus()
        {
            return (ThermalStatus)GetByteStatus()[2];
        }
        private void SetThermalStatus(ThermalStatus status)
        {
            byte[] bytes = GetByteStatus();
            bytes[1] = (byte)status;
            bytes[2] = (byte)status;
           enReturnCode c = diags.Set(Constants.DiagsThermalControl, bytes);
        }
    }
}
