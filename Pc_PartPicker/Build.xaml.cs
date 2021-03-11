using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
    /// Interaction logic for Build.xaml
    /// </summary>
    public partial class Build : Window
    {
       

        public Build(int component)
        {
            InitializeComponent();
            DataTable TabData = new DataTable();
            SQLiteConnection sqlite_conn = Database.CreateConnection();

            TabData = Database.ReadDataTable(sqlite_conn, component);
            TableItems.DataContext = TabData.DefaultView;

            switch (component)
            {
                case Constants.CASECONST:
                    TypeLabel.Content = "Case";
                    break;
                case Constants.CPUCONST:
                    TypeLabel.Content = "CPU";
                    break;
                case Constants.CPUCOOLERCONST:
                    TypeLabel.Content = "CPU Cooler";
                    break;
                case Constants.GPUCONST:
                    TypeLabel.Content = "GPU";
                    break;
                case Constants.MEMORYCONST:
                    TypeLabel.Content = "Memory";
                    break;
                case Constants.MOTHERBOARDCONST:
                    TypeLabel.Content = "Mainboard";
                    break;
                case Constants.PSUCONST:
                    TypeLabel.Content = "Power Supply";
                    break;
                case Constants.STORAGECONST:
                    TypeLabel.Content = "Storage";
                    break;
            }
                
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_overview_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Komponentenauswahl komp = new Komponentenauswahl();
            komp.ShowDialog();
            this.Show();
        }

        private void btn_menu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Show();
        }


        private void btn_Select_Click(object sender, RoutedEventArgs e)
        {
            if (TableItems.SelectedItem != null)
            {
                DataRowView selectedRow;
                selectedRow = (DataRowView)TableItems.SelectedItem;
                switch (TypeLabel.Content)
                {
                    case "Case":
                        configuration.pcCase = new Case(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), double.Parse(selectedRow.Row.ItemArray[2].ToString()));
                        break;
                    case "CPU":
                        configuration.cpu = new CPU(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(),
                            selectedRow.Row.ItemArray[3].ToString(), selectedRow.Row.ItemArray[4].ToString(), selectedRow.Row.ItemArray[5].ToString(), selectedRow.Row.ItemArray[6].ToString(),
                            selectedRow.Row.ItemArray[7].ToString(), selectedRow.Row.ItemArray[8].ToString(), double.Parse(selectedRow.Row.ItemArray[9].ToString()));
                        break;
                    case "CPU Cooler":
                        configuration.cpuCooler = new CPU_Cooler(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(),
                            selectedRow.Row.ItemArray[3].ToString(), double.Parse(selectedRow.Row.ItemArray[4].ToString()));
                        break;
                    case "GPU":
                        configuration.gpu = new Gpu(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(), selectedRow.Row.ItemArray[3].ToString(),
                            double.Parse(selectedRow.Row.ItemArray[4].ToString()));
                        break;
                    case "Mainboard":
                        configuration.motherboard = new Motherboard(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(), selectedRow.Row.ItemArray[3].ToString(),
                            selectedRow.Row.ItemArray[4].ToString(), selectedRow.Row.ItemArray[5].ToString(), selectedRow.Row.ItemArray[6].ToString(), double.Parse(selectedRow.Row.ItemArray[7].ToString()));
                        break;
                    case "Memory":
                        configuration.memory.Add(new Memory(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(),
                            selectedRow.Row.ItemArray[3].ToString(), double.Parse(selectedRow.Row.ItemArray[4].ToString())));
                        break;
                    case "Storage":
                        configuration.storage.Add(new Storage(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(),
                             double.Parse(selectedRow.Row.ItemArray[3].ToString())));
                        break;
                    case "Power Supply":
                        configuration.psu = new Psu(selectedRow.Row.ItemArray[0].ToString(), selectedRow.Row.ItemArray[1].ToString(), selectedRow.Row.ItemArray[2].ToString(),
                            double.Parse(selectedRow.Row.ItemArray[3].ToString()));
                        break;
                }



                this.Hide();
                Komponentenauswahl komp = new Komponentenauswahl();
                komp.ShowDialog();
                this.Show();
            }
        }
    }
}
