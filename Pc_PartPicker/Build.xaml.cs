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
        public Build()
        {
            InitializeComponent();
            DataTable TabData = new DataTable();

            TabData.Columns.Add("id");
            TabData.Columns.Add("image");
            TabData.Columns.Add("Name1");
            TabData.Columns.Add("Name2");
            TabData.Rows.Add(new object[] { 123, "image.png", "Foo", "Bar" });
            TableItems.DataContext = TabData.DefaultView;
                
        }
    }
}
