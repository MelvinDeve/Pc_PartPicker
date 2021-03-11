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
    /// Interaction logic for Build.xaml
    /// </summary>
    public partial class Build : Window
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

        public Build()
        {
            InitializeComponent();
            Loaded += ToolWindow_Loaded;
            DataTable TabData = new DataTable();

            TabData.Columns.Add("id");
            TabData.Columns.Add("image");
            TabData.Columns.Add("Name1");
            TabData.Columns.Add("Name2");
            TabData.Rows.Add(new object[] { 123, "image.png", "Foo", "Bar" });
            TabData.Rows.Add(new object[] { 123, "image.png", "Foo", "Bar" });
            TabData.Rows.Add(new object[] { 123, "image.png", "Foo", "Bar" });
            TabData.Rows.Add(new object[] { 123, "image.png", "Foo", "Bar" });
            TableItems.DataContext = TabData.DefaultView;
                
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Komponentenauswahl komp = new Komponentenauswahl();
            komp.ShowDialog();
            this.Show();

            
            
        
        }
    }
}
