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
    /// Логика взаимодействия для Client_pages.xaml
    /// </summary>
    public partial class Client_pages : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Client_pages()
        {
            InitializeComponent();
            Client_tabl.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            UpdateClient();
            Refresh();
        }
        List<Client> listClient;
        private void Refresh()
        {
            listClient = MainWindow.Real_estate_agenc.Client.ToList();
            _maxPages = (int)Math.Ceiling(listClient.Count * 1.0 / _countClients);

            var listAgentPage = listClient.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            Client_tabl.ItemsSource = listAgentPage;
        }
        private void UpdateClient()
        {
            Client_tabl.ItemsSource = null;
            Client_tabl.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
        }
        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedClient = editButton.DataContext as Client;
            Windows.Client_add winNew = new Windows.Client_add(selectedClient);
            winNew.ShowDialog();
            Refresh();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client();
            Windows.Client_add winClient = new Windows.Client_add(newClient);
            winClient.ShowDialog();
            UpdateClient();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = Client_tabl.SelectedItem as Client;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Client.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateClient();

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
            var x = MainWindow.Real_estate_agenc.Client.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.LName.ToLower().StartsWith(searchText.ToLower())).ToList();
                Client_tabl.ItemsSource = x;

            }
        }

        private void textSearchClick1(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Client.ToList();
            string searchText = textbox_serach1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.FName.ToLower().StartsWith(searchText.ToLower())).ToList();
                Client_tabl.ItemsSource = x;

            }
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Client.ToList();
            Client_tabl.ItemsSource = x;
            textbox_serach.Clear();
            textbox_serach1.Clear();
            Refresh();
        }
    }
}
