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
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_CPU_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_RAM_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_GPU_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_Mainboard_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_HDD_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_SSD_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_PSU_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_CPU_Cooler_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_casecooler_Click(object sender, RoutedEventArgs e)
        {
            Build build = new Build();
            build.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
