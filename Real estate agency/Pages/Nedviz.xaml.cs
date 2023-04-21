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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Real_estate_agency.Pages
{
    /// <summary>
    /// Логика взаимодействия для Nedviz.xaml
    /// </summary>
    public partial class Nedviz : Page
    {
        public Nedviz()
        {
            InitializeComponent();
        }

        private void button_kvartir_click(object sender, RoutedEventArgs e)
        {
            Windows.Kvartira w1 = new Windows.Kvartira();
            w1.Show();
        }

        private void button_home_click(object sender, RoutedEventArgs e)
        {
            Windows.House w1 = new Windows.House();
            w1.Show();
        }

        private void button_pomesh_click(object sender, RoutedEventArgs e)
        {
            Windows.Promises w1 = new Windows.Promises();
            w1.Show();
        }
    }
}
