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

namespace Pc_PartPicker
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = Database.CreateConnection();
            Database db = new Database();
            Database.ReadData(sqlite_conn);
            InitializeComponent();
            
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Komponentenauswahl komponenten = new Komponentenauswahl();
            komponenten.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
