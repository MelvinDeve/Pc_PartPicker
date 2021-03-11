using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public static class testImage2
    {
            /*
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\\Users\\melvi\\source\\PCPartPicker\\Pc_PartPicker\\images\\CPU_R5_3600.jpg", UriKind.Absolute);
            bitmap.EndInit();
            public Image img = new Image();
            img.Source = bitmap;
            */


    }
    /// <summary>
    /// Interaction logic for Build.xaml
    /// </summary>
    public partial class Build : Window
    {
        public Build()
        {
        InitializeComponent();
            DataTable TabData = new DataTable();


            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\\Users\\melvi\\source\\PCPartPicker\\Pc_PartPicker\\Pc_PartPicker\\images\\CPU_R5_3600.jpg", UriKind.Absolute);
            bitmap.EndInit();

            /*
            
            
            FrameworkElementFactory dgtc = new FrameworkElementFactory(typeof(DataGridTemplateColumn));
            FrameworkElementFactory dgtcct = new FrameworkElementFactory(typeof(DataGridTemplateColumn.CellTemplate));
            dgtc.AppendChild(dgtcct);
            */
            FrameworkElementFactory image = new FrameworkElementFactory(typeof(Image));
            image.SetBinding(Image.SourceProperty, new Binding(@"C:\\Users\\melvi\\source\\PCPartPicker\\Pc_PartPicker\\Pc_PartPicker\\images\\CPU_R5_3600.jpg"));
            DataTemplate dt = new DataTemplate();
            Image img = new Image();
            img.Source = bitmap;

            DataColumn col = new DataColumn();
            col.DataType = typeof(Image);




            var column = new DataGridTemplateColumn();
            column.CanUserResize = false;
            column.CanUserReorder = false;
            column.Header = "";

            //Create FrameworkElementFactory
            var imga = new FrameworkElementFactory(typeof(Image));
            //Create binding
            Binding binding = new Binding("img");

           

            //Set the converter
            //binding.Converter = new ImageSourceConverter();
            //imga.SetBinding(Image.SourceProperty, binding);
            imga.SetValue(Image.SourceProperty, img.Source);

            //Create data template
            var template = new DataTemplate();
            template.VisualTree = imga;
            column.CellTemplate = template;

            TableItems.Columns.Add(column);





            TabData.Columns.Add("fdsg");
            TabData.Columns.Add("image", typeof(DataTemplate));
            TabData.Columns.Add("Name1");
            TabData.Columns.Add("Name2");
            TabData.Rows.Add(new object[] { 123, template, "Foo", "Bar" });
            TableItems.DataContext = TabData.DefaultView;
            

            

        }

        

        



        private void btn_overview_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }
    }
}
