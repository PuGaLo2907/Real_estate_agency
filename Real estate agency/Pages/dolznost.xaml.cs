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
    /// Логика взаимодействия для dolznost.xaml
    /// </summary>
    public partial class dolznost : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public dolznost()
        {
            InitializeComponent();
            dolznost_tabl.ItemsSource = MainWindow.Real_estate_agenc.Positions.ToList();
            UpdatePositions();
            Refresh();
        }
        List<Positions> listPositions;
        private void Refresh()
        {
            listPositions = MainWindow.Real_estate_agenc.Positions.ToList();
            _maxPages = (int)Math.Ceiling(listPositions.Count * 1.0 / _countClients);

            var listAgentPage = listPositions.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            dolznost_tabl.ItemsSource = listAgentPage;
        }
        private void UpdatePositions()
        {
            dolznost_tabl.ItemsSource = null;
            dolznost_tabl.ItemsSource = MainWindow.Real_estate_agenc.Positions.ToList();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedPositions = editButton.DataContext as Positions;
            Windows.dolznost_add winNew = new Windows.dolznost_add(selectedPositions);
            winNew.ShowDialog();
            Refresh();
        }

        private void textSearchClick(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Positions.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Title.ToLower().StartsWith(searchText.ToLower())).ToList();
                dolznost_tabl.ItemsSource = x;

            }
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Positions newPositions = new Positions();
            Windows.dolznost_add winPositions = new Windows.dolznost_add(newPositions);
            winPositions.ShowDialog();
            UpdatePositions();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = dolznost_tabl.SelectedItem as Positions;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Positions.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdatePositions();

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

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Positions.ToList();
            dolznost_tabl.ItemsSource = x;
            textbox_serach.Clear();
            Refresh();
        }
    }
}
