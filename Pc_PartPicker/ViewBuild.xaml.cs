using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ViewBuild.xaml
    /// </summary>
    public partial class ViewBuild : Window
    {
        
        public ViewBuild()
        {

            InitializeComponent();
            DataTable TabData = new DataTable();
            TabData.Columns.Add("Part");
            TabData.Columns.Add("Product");
            TabData.Columns.Add("Price");

            int fullPrice = 0;

            if (configuration.pcCase != null)
            {
                TabData.Rows.Add(new Object[] { "Case", configuration.pcCase.name, configuration.pcCase.price });
                fullPrice = fullPrice + (int)configuration.pcCase.price;
            }
            

            if(configuration.cpu != null)
            {
                TabData.Rows.Add(new Object[] {"CPU", configuration.cpu.name, configuration.cpu.price });
                fullPrice = fullPrice + (int)configuration.cpu.price;
            }
            
            if (configuration.cpuCooler != null)
            {
                TabData.Rows.Add(new Object[] { "CPU Cooler", configuration.cpuCooler.name, configuration.cpuCooler.price });
                fullPrice = fullPrice + (int)configuration.cpuCooler.price;
            }

            if (configuration.motherboard != null)
            {
                TabData.Rows.Add(new Object[] { "Mainboard", configuration.motherboard.name, configuration.motherboard.price });
                fullPrice = fullPrice + (int)configuration.motherboard.price;
            }

            if (configuration.memory != null)
            {
                foreach (Memory ram in configuration.memory)
                {
                    TabData.Rows.Add(new Object[] { "RAM", ram.name, ram.price });
                    fullPrice = fullPrice + (int)ram.price;
                }
            }

            if (configuration.gpu != null)
            {
                TabData.Rows.Add(new Object[] { "GPU", configuration.gpu.name, configuration.gpu.price });
                fullPrice = fullPrice + (int)configuration.gpu.price;
            }

            if (configuration.storage != null)
            {
                foreach (Storage storage in configuration.storage)
                {
                    TabData.Rows.Add(new Object[] { "Storage", storage.name, storage.price });
                    fullPrice = fullPrice + (int)storage.price;
                }
            }

            if (configuration.psu != null)
            {
                TabData.Rows.Add(new Object[] { "Power Supply", configuration.psu.name, configuration.psu.price });
                fullPrice = fullPrice + (int)configuration.psu.price;
            }

            if (configuration.pcCase != null || configuration.cpu != null || configuration.cpuCooler != null || configuration.motherboard != null || configuration.memory != null || configuration.gpu != null || configuration.storage != null || configuration.psu != null)
            {
                TabData.Rows.Add(new Object[] { "", "", "" });
                TabData.Rows.Add(new Object[] { "", "Total Price", fullPrice });
            }

                TableItems.DataContext = TabData.DefaultView;

        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btn_menu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Show();
        }

        private void btn_overview_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Komponentenauswahl komp = new Komponentenauswahl();
            komp.ShowDialog();
            this.Show();
        }

        

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (TableItems.SelectedItem != null)
            {
                DataRowView selectedRow;
                selectedRow = (DataRowView)TableItems.SelectedItem;
                switch (selectedRow.Row.ItemArray[0])
                {
                    case "Case":
                        configuration.pcCase = null;
                        break;
                    case "CPU":
                        configuration.cpu = null;
                        configuration.psu = null;
                        break;
                    case "CPU Cooler":
                        configuration.cpuCooler = null;
                        break;
                    case "GPU":
                        configuration.gpu = null;
                        configuration.psu = null;
                        break;
                    case "Mainboard":
                        configuration.motherboard = null;
                        configuration.memory.Clear();
                        configuration.storage.Clear();
                        break;
                    case "RAM":
                        configuration.memory.RemoveAt(configuration.memory.Count - 1);
                        break;
                    case "Storage":
                        for (int i = 0; i < configuration.storage.Count; i++)
                        {
                            if (configuration.storage[i].name == (string)selectedRow.Row.ItemArray[1])
                            {
                                configuration.storage.RemoveAt(i);
                                break;
                            }
                        }
                        break;
                    case "Power Supply":
                        configuration.psu = null;
                        break;
                }

            }
            this.Hide();
            ViewBuild vb = new ViewBuild();
            vb.ShowDialog();
            this.Show();
        }
    }
}
