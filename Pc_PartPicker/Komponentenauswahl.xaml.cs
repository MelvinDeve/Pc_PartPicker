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
using System.Drawing;

namespace Pc_PartPicker
{
    /// <summary>
    /// Interaction logic for Komponentenauswahl.xaml
    /// </summary>
    public partial class Komponentenauswahl : Window
    {
        
       
        
        
        public Komponentenauswahl()
        {
            InitializeComponent();
            colorBtns();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
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
                MessageBox.Show("Please select a Mainboard first.");
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
                MessageBox.Show("Please select a Mainboard first.");
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

        private void btn_ViewBuild_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewBuild view = new ViewBuild();
            view.ShowDialog();
            this.Show();
        }

        public void colorBtns()
        {
            if (configuration.pcCase == null)
            {
                btn_case.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83 ));
            }
            else { btn_case.Background = Brushes.Green; }



            if (configuration.cpu == null)
            {
                btn_CPU.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83));
            }
            else 
            {
                btn_CPU.Background = Brushes.Green;
            }

            if (configuration.cpuCooler == null)
            {
             
                if ((configuration.cpu != null) && (configuration.cpu.integratedCooler == true))
                {
                    btn_CPU_Cooler.Background = Brushes.Yellow;
                }
                else { btn_CPU_Cooler.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83)); }
            }

            else{ btn_CPU_Cooler.Background = Brushes.Green; }

            if (configuration.motherboard == null)
            {
                btn_Mainboard.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83));
            }
            else { btn_Mainboard.Background = Brushes.Green; }

            if (configuration.memory.Count == 0)
            {
                btn_RAM.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83));
            }
            else { btn_RAM.Background = Brushes.Green; }

            if (configuration.gpu == null)
            {
                if ((configuration.cpu != null) && (configuration.cpu.integratedGraphics == true))
                {
                    btn_GPU.Background = Brushes.Yellow;
                }
                else { btn_GPU.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83)); }
            }
             
            else{ btn_GPU.Background = Brushes.Green; }

            if (configuration.storage.Count == 0)
            {
                btn_SSD.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83));
            }
            else { btn_SSD.Background = Brushes.Green; }

            if (configuration.psu == null)
            {
                btn_PSU.Background = new SolidColorBrush(Color.FromRgb(235, 42, 83));
            }
            else { btn_PSU.Background = Brushes.Green; }

        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            XMLWrite.ReadXML();
            MessageBox.Show("Successfully Loaded Build from File");
            this.Hide();
            Komponentenauswahl komp = new Komponentenauswahl();
            komp.ShowDialog();
            this.Show();
            
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            XMLWrite.WriteXML();
            MessageBox.Show("Successfully Saved Build in File");
        }

       
    }
}
