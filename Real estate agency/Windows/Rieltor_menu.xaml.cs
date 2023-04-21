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
    /// Логика взаимодействия для Rieltor_menu.xaml
    /// </summary>
    public partial class Rieltor_menu : Window
    {
        public Rieltor_menu()
        {
            InitializeComponent();
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
        private void Client_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Client_pages());
        }
        private void nedviz_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Nedviz());
        }
        private void Button_Dogovor_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Vid_dogovor());
        }

       
    }
}
