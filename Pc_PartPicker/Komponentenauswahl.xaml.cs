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
using System.Windows.Shapes;

namespace Pc_PartPicker
{
    /// <summary>
    /// Interaction logic for Komponentenauswahl.xaml
    /// </summary>
    public partial class Komponentenauswahl : Window
    {
        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        void ToolWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Code to remove close box from window
            var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
        }

        public Komponentenauswahl()
        {
            InitializeComponent();
            Loaded += ToolWindow_Loaded;
        }

        private void btn_case_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Build build = new Build(Constants.CASECONST);
            build.ShowDialog();
            this.Show();
        }

        private void btn_CPU_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Build build = new Build(Constants.CPUCONST);
            build.ShowDialog();
            this.Show();
        }

         
        private void btn_RAM_Click(object sender, RoutedEventArgs e)
        {
            
                if (configuration.motherboard != null)
                {
                    this.Hide();
                    Build build = new Build(Constants.MEMORYCONST);
                    build.ShowDialog();
                    this.Show();
                }
                else
                  {
                MessageBox.Show("Please select a Motherboard first.");
                  }
          
        }

        private void btn_GPU_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Build build = new Build(Constants.GPUCONST);
            build.ShowDialog();
            this.Show();
        }

        private void btn_Mainboard_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Build build = new Build(Constants.MOTHERBOARDCONST);
            build.ShowDialog();
            this.Show();
        }

        private void btn_SSD_Click(object sender, RoutedEventArgs e)
        {
            if (configuration.motherboard != null)
            {
                this.Hide();
                Build build = new Build(Constants.STORAGECONST);
                build.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a Motherboard first.");
            }

        }

        private void btn_PSU_Click(object sender, RoutedEventArgs e)
        {
            if ((configuration.gpu != null) && (configuration.cpu != null))
            {
                this.Hide();
                Build build = new Build(Constants.PSUCONST);
                build.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a CPU and a GPU first.");
            }
        }

        private void btn_CPU_Cooler_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Build build = new Build(Constants.CPUCOOLERCONST);
            build.ShowDialog();
            this.Show();
        }
      
        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewBuild view = new ViewBuild();
            view.ShowDialog();
            this.Show();
        }
    }
}
