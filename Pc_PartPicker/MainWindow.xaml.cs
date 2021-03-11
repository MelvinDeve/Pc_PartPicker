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
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.ComponentModel;

namespace Pc_PartPicker
{
    static class Constants
    {
        public const int CPUCONST = 1;
        public const int CPUCOOLERCONST = 2;
        public const int GPUCONST = 6;
        public const int CASECONST = 7;
        public const int MEMORYCONST = 4;
        public const int MOTHERBOARDCONST = 3;
        public const int PSUCONST = 8;
        public const int STORAGECONST = 5;
    }

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            SQLiteConnection sqlite_conn;
            sqlite_conn = Database.CreateConnection();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Komponentenauswahl komponenten = new Komponentenauswahl();
            komponenten.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}