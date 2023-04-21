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
    /// Логика взаимодействия для Sostoyanie.xaml
    /// </summary>
    public partial class Sostoyanie : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Sostoyanie()
        {
            InitializeComponent();
            sostoyan_tabl.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
        }
        List<Property_condition> listProperty_condition;
        private void Refresh()
        {
            listProperty_condition = MainWindow.Real_estate_agenc.Property_condition.ToList();
            _maxPages = (int)Math.Ceiling(listProperty_condition.Count * 1.0 / _countClients);

            var listAgentPage = listProperty_condition.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            sostoyan_tabl.ItemsSource = listAgentPage;
        }
        private void UpdateProperty_condition()
        {
            sostoyan_tabl.ItemsSource = null;
            sostoyan_tabl.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedProperty_condition = editButton.DataContext as Property_condition;
            Windows.Sostayanie_add winNew = new Windows.Sostayanie_add(selectedProperty_condition);
            winNew.ShowDialog();
            Refresh();
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Property_condition.ToList();
            sostoyan_tabl.ItemsSource = x;
            textbox_serach.Clear();
            Refresh();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Property_condition newProperty_condition = new Property_condition();
            Windows.Sostayanie_add winProperty_condition = new Windows.Sostayanie_add(newProperty_condition);
            winProperty_condition.ShowDialog();
            UpdateProperty_condition();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = sostoyan_tabl.SelectedItem as Property_condition;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Property_condition.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateProperty_condition();

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
            var x = MainWindow.Real_estate_agenc.Property_condition.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Title.ToLower().StartsWith(searchText.ToLower())).ToList();
                sostoyan_tabl.ItemsSource = x;

            }
        }
    }
}
