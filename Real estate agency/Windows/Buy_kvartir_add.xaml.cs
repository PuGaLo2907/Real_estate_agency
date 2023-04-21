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
    /// Логика взаимодействия для Buy_kvartir_add.xaml
    /// </summary>
    public partial class Buy_kvartir_add : Window
    {
        private Buy_apartment buy_apartment;
        public Buy_kvartir_add(Buy_apartment selectedBuy_apartment)
        {
            InitializeComponent();
            this.buy_apartment = selectedBuy_apartment;
            DataContext = selectedBuy_apartment;
            kvartir_box.ItemsSource = MainWindow.Real_estate_agenc.Apartment.ToList();
            owner_box.ItemsSource= MainWindow.Real_estate_agenc.Client.ToList();
            staff_box.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            byuer_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            pay_box.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
            Data_box.SelectedDate = DateTime.Now;

        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            
            if (buy_apartment.ID == 0)
            {
                MainWindow.Real_estate_agenc.Buy_apartment.Add(buy_apartment);
            }
            buy_apartment.Date_Dogovor = Convert.ToDateTime(Data_box.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            if (MessageBox.Show($"Договор на продажу квартиры № {buy_apartment.ID} составлен, хотите перейти к договору?",
                    "Агенство недвижимости",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Windows.Buy_kvartir w1 = new Windows.Buy_kvartir();
                w1.Show();
                this.Close();
            }
        }
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
