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
    /// Логика взаимодействия для Obyav.xaml
    /// </summary>
    public partial class Obyav : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Obyav()
        {
            InitializeComponent();
            tip_obyav.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            Refresh();
            UpdateAd_type();
        }
        List<Ad_type> listAd_type;
        private void Refresh()
        {
            listAd_type = MainWindow.Real_estate_agenc.Ad_type.ToList();
            _maxPages = (int)Math.Ceiling(listAd_type.Count * 1.0 / _countClients);

            var listAgentPage = listAd_type.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            tip_obyav.ItemsSource = listAgentPage;
        }
        private void UpdateAd_type()
        {
            tip_obyav.ItemsSource = null;
            tip_obyav.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedAd_type = editButton.DataContext as Ad_type;
            Windows.add_type winNew = new Windows.add_type(selectedAd_type);
            winNew.ShowDialog();
            Refresh();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Ad_type newAd_type = new Ad_type();
            Windows.add_type winAd_type = new Windows.add_type(newAd_type);
            winAd_type.ShowDialog();
            UpdateAd_type();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = tip_obyav.SelectedItem as Ad_type;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Ad_type.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateAd_type();

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
            var x = MainWindow.Real_estate_agenc.Ad_type.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Title.ToLower().StartsWith(searchText.ToLower())).ToList();
                tip_obyav.ItemsSource = x;

            }
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Ad_type.ToList();
            tip_obyav.ItemsSource = x;
            textbox_serach.Clear();
            Refresh();
        }
    }
}
