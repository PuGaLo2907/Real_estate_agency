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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            frame.Navigate(new Pages.nachal());
        }

        private void Tip_nedviz_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Tip_nedviz());
        }
        private void Button_user_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите сменить пользователя",
                    "Агенство недвижимости",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MainWindow w1 = new MainWindow();
                w1.Show();
                this.Close();
            }
        }
        private void Button_Dogovor_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Vid_dogovor());
        }

        private void Staff_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Staff_pages());
        }

        private void Client_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Client_pages());
        }

        private void dolznnost_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.dolznost());
        }

        private void sostoyanie_nedviz_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Sostoyanie());
        }

        private void nedviz_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Nedviz());
        }

        private void tip_ob_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Obyav());
        }

        private void oplata_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Oplata());
        }

        private void kok(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Разработал: Мартынов Егор, ПР-365/б");
        }
    }
}
