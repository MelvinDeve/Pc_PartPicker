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
        public Komponentenauswahl()
        {
            InitializeComponent();
        }

        private void btn_case_Click(object sender, RoutedEventArgs e)
        {
            PCcase pcase = new PCcase();
            pcase.ShowDialog();

        }

        private void btn_CPU_Click(object sender, RoutedEventArgs e)
        {
            CPU cpu = new CPU();
            cpu.ShowDialog();
        }

        private void btn_RAM_Click(object sender, RoutedEventArgs e)
        {
            RAM ram = new RAM();
            ram.ShowDialog();
        }

        private void btn_GPU_Click(object sender, RoutedEventArgs e)
        {
            GPU gpu = new GPU();
            gpu.ShowDialog();
        }

        private void btn_Mainboard_Click(object sender, RoutedEventArgs e)
        {
            Mainboard mainboard = new Mainboard();
            mainboard.ShowDialog();
        }

        private void btn_HDD_Click(object sender, RoutedEventArgs e)
        {
            SSD ssd = new SSD();
            ssd.ShowDialog();
        }

        private void btn_SSD_Click(object sender, RoutedEventArgs e)
        {
            HDD hdd = new HDD();
            hdd.ShowDialog();
        }

        private void btn_PSU_Click(object sender, RoutedEventArgs e)
        {
            PSU psu = new PSU();
            psu.ShowDialog();
        }

        private void btn_CPU_Cooler_Click(object sender, RoutedEventArgs e)
        {
            CPUcooler cpucooler = new CPUcooler();
            cpucooler.ShowDialog();
        }

        private void btn_casecooler_Click(object sender, RoutedEventArgs e)
        {
            casecooler casecooler = new casecooler();
            casecooler.ShowDialog();
        }

       
    }
}
