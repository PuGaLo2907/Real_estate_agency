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
    /// Логика взаимодействия для arent_home.xaml
    /// </summary>
    public partial class arent_home : Page
    {
        private int _currentPage = 1;
        private int _countClients = 8;
        private int _maxPages;
        public arent_home()
        {
            InitializeComponent();
            rent_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Rent_apartment.ToList();
            cb1.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            cb2.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            Refresh();
            Updatearent_kvartir();
        }
        List<Rent_home> listRent_home;
        private void Refresh()
        {
            listRent_home = MainWindow.Real_estate_agenc.Rent_home.ToList();
            _maxPages = (int)Math.Ceiling(listRent_home.Count * 1.0 / _countClients);

            var listAgentPage = listRent_home.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            rent_kvartir_tabl.ItemsSource = listAgentPage;
        }
        private void Updatearent_kvartir()
        {
            rent_kvartir_tabl.ItemsSource = null;
            rent_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Rent_home.ToList();
        }
        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Rent_home.ToList();
            rent_kvartir_tabl.ItemsSource = x;
            cb1.Text = "";
            cb2.Text = "";
            Refresh();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedBuy_apartment = editButton.DataContext as Rent_home;
            Windows.Rent_home_add winNew = new Windows.Rent_home_add(selectedBuy_apartment);
            winNew.ShowDialog();
            Refresh();
        }

        private void Button_copy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Печать");
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Rent_home newBuy_apartment = new Rent_home();
            Windows.Rent_home_add winBuy_apartment = new Windows.Rent_home_add(newBuy_apartment);
            winBuy_apartment.ShowDialog();
            Updatearent_kvartir();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = rent_kvartir_tabl.SelectedItem as Rent_home;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Rent_home.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                Updatearent_kvartir();
            }
            else MessageBox.Show("Выберите запись для удаления!");
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

        private void comboBox_cb1(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Rent_home.ToList();
            int searchInt = cb1.SelectedIndex;
            if (searchInt == cb1.SelectedIndex)
            {
                x = x.Where(line => (line.Owner == cb1.SelectedIndex + 1)).ToList();
                rent_kvartir_tabl.ItemsSource = x;
            }
            else
            {
                rent_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            }
        }

        private void comboBox_cb2(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Rent_home.ToList();
            int searchInt = cb2.SelectedIndex;
            if (searchInt == cb2.SelectedIndex)
            {
                x = x.Where(line => (line.Staff == cb2.SelectedIndex + 1)).ToList();
                rent_kvartir_tabl.ItemsSource = x;
            }
            else
            {
                rent_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            }
        }
    }
}
