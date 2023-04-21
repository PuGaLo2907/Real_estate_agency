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
    /// Логика взаимодействия для Buy_kvartir.xaml
    /// </summary>
    public partial class Buy_kvartir : Window
    {
        private int _currentPage = 1;
        private int _countClients = 8;
        private int _maxPages;
        public Buy_kvartir()
        {
            InitializeComponent();
            buy_kvartir_tabl.ItemsSource = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
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
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Buy_apartment.ToList();
            buy_kvartir_tabl.ItemsSource = x;
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
        
    }
}
