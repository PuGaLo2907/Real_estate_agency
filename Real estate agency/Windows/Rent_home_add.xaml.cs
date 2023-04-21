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
    /// Логика взаимодействия для Rent_home_add.xaml
    /// </summary>
    public partial class Rent_home_add : Window
    {
        private Rent_home rent_home;
        public Rent_home_add(Rent_home selectedrent_apartment)
        {
            InitializeComponent();
            this.rent_home = selectedrent_apartment;
            DataContext = selectedrent_apartment;
            Owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            Staff_box.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            Tenant_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            kvartir_box.ItemsSource = MainWindow.Real_estate_agenc.Home.ToList();
        }
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            if (rent_home.ID == 0)
            {
                MainWindow.Real_estate_agenc.Rent_home.Add(rent_home);
            }
            rent_home.Deal_date = Convert.ToDateTime(Deal_date_box.SelectedDate);
            rent_home.Arrival_date = Convert.ToDateTime(Arrival_date_box.SelectedDate);
            rent_home.Date_of_departure = Convert.ToDateTime(Date_of_departure_box.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            if (MessageBox.Show($"Договор на аренду квартиры № {rent_home.ID} составлен, хотите перейти к договору?",
                    "Агенство недвижимости",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Windows.Rent_Kvartir w1 = new Windows.Rent_Kvartir();
                w1.Show();
                this.Close();
            }
        }
    }
}
