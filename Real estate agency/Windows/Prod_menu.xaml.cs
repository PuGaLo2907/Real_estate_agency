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

namespace Real_estate_agency.Windows
{
    /// <summary>
    /// Логика взаимодействия для Prod_menu.xaml
    /// </summary>
    public partial class Prod_menu : Window
    {
        public Prod_menu()
        {
            InitializeComponent();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void kvartir_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Prod_kvartir());
        }

        private void dom_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Prod_dom());
        }

        private void premis_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Prod_premis());
        }
    }
}
