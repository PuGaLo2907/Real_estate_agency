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
    /// Логика взаимодействия для Rent_premis_add.xaml
    /// </summary>
    public partial class Rent_premis_add : Window
    {
        private Rent_promises rent_promises;
        public Rent_premis_add(Rent_promises selectedrent_apartment)
        {
            InitializeComponent();
            this.rent_promises = selectedrent_apartment;
            DataContext = selectedrent_apartment;
            Owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            Staff_box.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            Tenant_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            kvartir_box.ItemsSource = MainWindow.Real_estate_agenc.Premises.ToList();
        }
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            if (rent_promises.ID == 0)
            {
                MainWindow.Real_estate_agenc.Rent_promises.Add(rent_promises);
            }
            rent_promises.Deal_date = Convert.ToDateTime(Deal_date_box.SelectedDate);
            rent_promises.Arrival_date = Convert.ToDateTime(Arrival_date_box.SelectedDate);
            rent_promises.Date_of_departure = Convert.ToDateTime(Date_of_departure_box.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            if (MessageBox.Show($"Договор на аренду квартиры № {rent_promises.ID} составлен, хотите перейти к договору?",
                    "Агенство недвижимости",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Windows.Rent_premis w1 = new Windows.Rent_premis();
                w1.Show();
                this.Close();
            }
        }
    }
}
