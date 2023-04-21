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
    /// Логика взаимодействия для Oplata.xaml
    /// </summary>
    public partial class Oplata : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Oplata()
        {
            InitializeComponent();
            oplata.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
            Refresh();
            UpdatePayment_type();

        }
        List<Payment_type> listPayment_type;
        private void Refresh()
        {
            listPayment_type = MainWindow.Real_estate_agenc.Payment_type.ToList();
            _maxPages = (int)Math.Ceiling(listPayment_type.Count * 1.0 / _countClients);

            var listAgentPage = listPayment_type.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            oplata.ItemsSource = listAgentPage;
        }
        private void UpdatePayment_type()
        {
            oplata.ItemsSource = null;
            oplata.ItemsSource = MainWindow.Real_estate_agenc.Payment_type.ToList();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedPayment_type = editButton.DataContext as Payment_type;
            Windows.payment_add winNew = new Windows.payment_add(selectedPayment_type);
            winNew.ShowDialog();
            Refresh();
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Client.ToList();
            oplata.ItemsSource = x;
            textbox_serach.Clear();
            Refresh();

        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Payment_type newPayment_type = new Payment_type();
            Windows.payment_add winPayment_type = new Windows.payment_add(newPayment_type);
            winPayment_type.ShowDialog();
            UpdatePayment_type();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = oplata.SelectedItem as Payment_type;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Payment_type.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdatePayment_type();

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

        private void textSearchClick(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Payment_type.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Title.ToLower().StartsWith(searchText.ToLower())).ToList();
                oplata.ItemsSource = x;

            }
        }
    }
}
