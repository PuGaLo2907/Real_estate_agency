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
    /// Логика взаимодействия для Buy_home_add.xaml
    /// </summary>
    public partial class Buy_home_add : Window
    {
        private Buy_home buy_home;
        public Buy_home_add(Buy_home selectedBuy_home)
        {
            InitializeComponent();
            this.buy_home = selectedBuy_home;
            DataContext = selectedBuy_home;
            kvartir_box.ItemsSource = MainWindow.Real_estate_agenc.Home.ToList();
            owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            staff_box.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            byuer_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            pay_box.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
        }
        private void button_save_click(object sender, RoutedEventArgs e)
        {

            if (buy_home.ID == 0)
            {
                MainWindow.Real_estate_agenc.Buy_home.Add(buy_home);
            }
            buy_home.Date_Dogovor = Convert.ToDateTime(Data_box.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            if (MessageBox.Show($"Договор на продажу квартиры № {buy_home.ID} составлен, хотите перейти к договору?",
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
