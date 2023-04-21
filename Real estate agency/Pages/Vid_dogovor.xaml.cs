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
    /// Логика взаимодействия для Vid_dogovor.xaml
    /// </summary>
    public partial class Vid_dogovor : Page
    {
        public Vid_dogovor()
        {
            InitializeComponent();
        }

        private void prod_click(object sender, RoutedEventArgs e)
        {
            Windows.Prod_menu w1 = new Windows.Prod_menu();
            w1.Show();
        }

        private void arenda_click(object sender, RoutedEventArgs e)
        {
            Windows.Rent_menu w1 = new Windows.Rent_menu();
            w1.Show();
        }
    }
}
