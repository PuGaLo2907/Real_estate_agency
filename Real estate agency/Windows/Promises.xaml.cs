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
    /// Логика взаимодействия для Promises.xaml
    /// </summary>
    public partial class Promises : Window
    {
        private int _currentPage = 1;
        private int _countClients = 4;
        private int _maxPages;
        public Promises()
        {
            InitializeComponent();
            pomesh_panel.ItemsSource = MainWindow.Real_estate_agenc.Premises.ToList();
            cb.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            cb1.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            cb2.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            UpdateKvartir();
            Refresh();
        }
        List<Premises> listPremises;
        private void Refresh()
        {
            listPremises = MainWindow.Real_estate_agenc.Premises.ToList();
            _maxPages = (int)Math.Ceiling(listPremises.Count * 1.0 / _countClients);

            var listAgentPage = listPremises.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            pomesh_panel.ItemsSource = listAgentPage;
        }
        private void UpdateKvartir()
        {
            pomesh_panel.ItemsSource = null;
            pomesh_panel.ItemsSource = MainWindow.Real_estate_agenc.Premises.ToList();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = pomesh_panel.SelectedItem as Premises;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Premises.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateKvartir();
            }
            else MessageBox.Show("Выберите запись для удаления!");
            Refresh();
        }

        private void btn_redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedKvartira = editButton.DataContext as Premises;
            Windows.Promis_add winNew = new Windows.Promis_add(selectedKvartira);
            winNew.ShowDialog();
            Refresh();
        }

        private void textSearchClic1k(object sender, TextChangedEventArgs e)
        {

        }

        private void textSearchClick2(object sender, TextChangedEventArgs e)
        {

        }

        private void textSearchClick3(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            string searchText = textbox_serach1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Addres.ToLower().StartsWith(searchText.ToLower())).ToList();
                pomesh_panel.ItemsSource = x;

            }
        }

        private void textSearchClick4(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            string searchText = textbox_serac2.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.S.ToLower().StartsWith(searchText.ToLower())).ToList();
                pomesh_panel.ItemsSource = x;

            }
        }

        private void comboBox_cb2(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            int searchInt = cb2.SelectedIndex;
            if (searchInt == cb2.SelectedIndex)
            {
                x = x.Where(line => (line.Ad_types == cb2.SelectedIndex + 1)).ToList();
                pomesh_panel.ItemsSource = x;
            }
            else
            {
                pomesh_panel.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            }
        }

        private void comboBox_cb1(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            int searchInt = cb1.SelectedIndex;
            if (searchInt == cb1.SelectedIndex)
            {
                x = x.Where(line => (line.Status == cb1.SelectedIndex + 1)).ToList();
                pomesh_panel.ItemsSource = x;
            }
            else
            {
                pomesh_panel.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            }
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            cb.Text = "";
            cb1.Text = "";
            cb2.Text = "";

            textbox_serach.Text = "";
            textbox_serach1.Text = "";
            textbox_serac2.Text = "";
            textbox_serach4.Text = "";
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            pomesh_panel.ItemsSource = x;
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

        private void comboBox_cb(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Premises.ToList();
            int searchInt = cb.SelectedIndex;
            if (searchInt == cb.SelectedIndex)
            {
                x = x.Where(line => (line.Type == cb.SelectedIndex + 1)).ToList();
                pomesh_panel.ItemsSource = x;
            }
            else
            {
                pomesh_panel.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            }
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Premises newApartment = new Premises();
            Windows.Promis_add winApartment = new Windows.Promis_add(newApartment);
            winApartment.ShowDialog();
            UpdateKvartir();
            Refresh();
        }

        private void btn_arend(object sender, RoutedEventArgs e)
        {
            Rent_promises newBuy_apartment = new Rent_promises();
            Windows.Rent_premis_add winBuy_apartment = new Windows.Rent_premis_add(newBuy_apartment);
            winBuy_apartment.ShowDialog();
        }

        private void btn_prod(object sender, RoutedEventArgs e)
        {
            Buy_premises newBuy_apartment = new Buy_premises();
            Windows.Buy_premis_add winBuy_apartment = new Windows.Buy_premis_add(newBuy_apartment);
            winBuy_apartment.ShowDialog();
        }
    }
}
