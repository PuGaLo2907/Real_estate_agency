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
    /// Логика взаимодействия для Rent_menu.xaml
    /// </summary>
    public partial class Rent_menu : Window
    {
        public Rent_menu()
        {
            InitializeComponent();
        }

        private void kvartir_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.arent_kvartir());
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dom_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.arent_home());
        }

        private void pom_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.arent_promis());
        }
    }
}
