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
    /// Логика взаимодействия для Dogovor.xaml
    /// </summary>
    public partial class Dogovor : Page
    {
        public Dogovor()
        {
            InitializeComponent();
        }

        private void kvartir_click(object sender, RoutedEventArgs e)
        {
            Windows.Buy_kvartir w1 = new Windows.Buy_kvartir();
            w1.Show();
        }
    }
}
