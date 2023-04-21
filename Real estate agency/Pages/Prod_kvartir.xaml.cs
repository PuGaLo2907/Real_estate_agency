using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Prod_kvartir.xaml
    /// </summary>
    public partial class Prod_kvartir : Page
    {
        private int _currentPage = 1;
        private int _countClients = 8;
        private int _maxPages;
        public Buy_apartment SelectedApartment { get; set; }
        public Prod_kvartir()
        {
            InitializeComponent();
            buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            cb1.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            cb2.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            cb3.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
            Refresh();
            UpdateBuy_apartment();
        }
        List<Buy_apartment> listBuy_apartment;
        private void Refresh()
        {
            listBuy_apartment = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            _maxPages = (int)Math.Ceiling(listBuy_apartment.Count * 1.0 / _countClients);

            var listAgentPage = listBuy_apartment.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            buy_kvartir_tabl.ItemsSource = listAgentPage;
        }
        private void UpdateBuy_apartment()
        {
            buy_kvartir_tabl.ItemsSource = null;
            buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            buy_kvartir_tabl.ItemsSource = x;
            cb1.Text = "";
            cb2.Text = "";
            cb3.Text = "";
            Refresh();
        }

        private void GoToFirstPage(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            Refresh();
        }

        private void GoToPreviousPage(object sender, RoutedEventArgs e)
        {
            if (_currentPage <= 1) _currentPage = 1;
            else _currentPage--;
            Refresh();
        }

        private void GoToNextPage(object sender, RoutedEventArgs e)
        {
            if (_currentPage >= _maxPages)
                _currentPage = _maxPages;
            else _currentPage++;
            Refresh();
        }

        private void GoToLastPage(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPages;
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {

            var Button_Delet = buy_kvartir_tabl.SelectedItem as Buy_apartment;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Buy_apartment.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateBuy_apartment();
            }
            else MessageBox.Show("Выберите запись для удаления!");
            Refresh();
        }
        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedBuy_apartment = editButton.DataContext as Buy_apartment;
            Windows.Buy_kvartir_add winNew = new Windows.Buy_kvartir_add(selectedBuy_apartment);
            winNew.ShowDialog();
            Refresh();

        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Buy_apartment newBuy_apartment = new Buy_apartment();
            Windows.Buy_kvartir_add winBuy_apartment = new Windows.Buy_kvartir_add(newBuy_apartment);
            winBuy_apartment.ShowDialog();
            UpdateBuy_apartment();
            Refresh();
        }

        private void Button_copy(object sender, RoutedEventArgs e)
        {

            var editButton = sender as Button;
            var selectedBuy_apartment = editButton.DataContext as Buy_apartment;
            using (Real_estate_agencyEntities5 db = new Real_estate_agencyEntities5())
            {
                SelectedApartment = db.Buy_apartment.FirstOrDefault(b => b.ID == selectedBuy_apartment.ID);
            }
            if (SelectedApartment != null)
            {
                var helper = new WordHelper("Dogovor.docx");

                var items = new Dictionary<string, string>{
{"<Date_from>", SelectedApartment.Date_Dogovor.ToString("dd MMMM, yyyy")},
{"<FIO_vlad>", SelectedApartment.BuyAppartment.combococks.ToString()},
{"<FIO_pokup>", SelectedApartment.BuyAppartment1.combococks.ToString()},
{"<Propiska_vlad>", SelectedApartment.BuyAppartment.Registration.ToString()},
{"<Propiska_ pokup>", SelectedApartment.BuyAppartment1.Registration.ToString()},
{"<Pasport_vlad>", SelectedApartment.BuyAppartment.Passport_number.ToString()},
{"<Pasport_ pokup>", SelectedApartment.BuyAppartment1 .Passport_number.ToString()},
{"<Kvartir_adres>", SelectedApartment.Adres.Addres.ToString()},
{"<Kvartir_cad>", SelectedApartment.Adres.Cadastral_number.ToString()},
{"<Kvartir_area>", SelectedApartment.Adres.Area.ToString()}
};
                helper.Process(items);
            }
            else
                MessageBox.Show("Вы не выбрали запись.");
        }

        private void comboBox_cb1(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            int searchInt = cb1.SelectedIndex;
            if (searchInt == cb1.SelectedIndex)
            {
                x = x.Where(line => (line.Owner == cb1.SelectedIndex + 1)).ToList();
                buy_kvartir_tabl.ItemsSource = x;
            }
            else
            {
                buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            }
        }

        private void comboBox_cb2(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            int searchInt = cb2.SelectedIndex;
            if (searchInt == cb2.SelectedIndex)
            {
                x = x.Where(line => (line.Staff == cb2.SelectedIndex + 1)).ToList();
                buy_kvartir_tabl.ItemsSource = x;
            }
            else
            {
                buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            }
        }

        private void comboBox_cb3(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            int searchInt = cb3.SelectedIndex;
            if (searchInt == cb3.SelectedIndex)
            {
                x = x.Where(line => (line.Staff == cb3.SelectedIndex + 1)).ToList();
                buy_kvartir_tabl.ItemsSource = x;
            }
            else
            {
                buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
            }
        }
    }
}
