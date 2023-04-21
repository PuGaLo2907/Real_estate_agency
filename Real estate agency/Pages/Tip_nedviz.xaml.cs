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
    /// Логика взаимодействия для Tip_nedviz.xaml
    /// </summary>
    public partial class Tip_nedviz : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Tip_nedviz()
        {
            InitializeComponent();
            tip_nedviz.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            UpdateProperty_type();
            Refresh();
        }
        List<Property_type> listProperty_type;
        private void Refresh()
        {
            listProperty_type = MainWindow.Real_estate_agenc.Property_type.ToList();
            _maxPages = (int)Math.Ceiling(listProperty_type.Count * 1.0 / _countClients);

            var listAgentPage = listProperty_type.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            tip_nedviz.ItemsSource = listAgentPage;
        }
        private void UpdateProperty_type()
        {
            tip_nedviz.ItemsSource = null;
            tip_nedviz.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedProperty_type = editButton.DataContext as Property_type;
            Windows.Tip_nedviz_add winNew = new Windows.Tip_nedviz_add(selectedProperty_type);
            winNew.ShowDialog();
            Refresh();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Property_type newProperty_type = new Property_type();
            Windows.Tip_nedviz_add winProperty_type = new Windows.Tip_nedviz_add(newProperty_type);
            winProperty_type.ShowDialog();
            UpdateProperty_type();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = tip_nedviz.SelectedItem as Property_type;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Property_type.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateProperty_type();

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
            var x = MainWindow.Real_estate_agenc.Property_type.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Title.ToLower().StartsWith(searchText.ToLower())).ToList();
                tip_nedviz.ItemsSource = x;

            }
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Property_type.ToList();
            tip_nedviz.ItemsSource = x;
            textbox_serach.Clear();
            Refresh();
        }
    }
}
