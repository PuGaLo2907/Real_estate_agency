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
    /// Логика взаимодействия для Staff_pages.xaml
    /// </summary>
    public partial class Staff_pages : Page
    {
        private int _currentPage = 1;
        private int _countClients = 7;
        private int _maxPages;
        public Staff_pages()
        {
            InitializeComponent();
            Staff_tabl.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
            cb.ItemsSource = MainWindow.Real_estate_agenc.Positions.ToList();
            UpdateSaff();
            Refresh();
        }
        List<Staff> listStaff;
        private void Refresh()
        {
            listStaff = MainWindow.Real_estate_agenc.Staff.ToList();
            _maxPages = (int)Math.Ceiling(listStaff.Count * 1.0 / _countClients);

            var listAgentPage = listStaff.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            Staff_tabl.ItemsSource = listAgentPage;
        }
        private void UpdateSaff()
        {
            Staff_tabl.ItemsSource = null;
            Staff_tabl.ItemsSource = MainWindow.Real_estate_agenc.Staff.ToList();
        }
        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedStaff = editButton.DataContext as Staff;
            Windows.Staff_add winNew = new Windows.Staff_add(selectedStaff);
            winNew.ShowDialog();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = Staff_tabl.SelectedItem as Staff;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Staff.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateSaff();

            }
            else MessageBox.Show("Выберите запись для удаления!");
            Refresh();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Staff newStaff = new Staff();
            Windows.Staff_add winStaff = new Windows.Staff_add(newStaff);
            winStaff.ShowDialog();
            UpdateSaff();
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
            var x = MainWindow.Real_estate_agenc.Staff.ToList();
            string searchText = textbox_serach.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.LName.ToLower().StartsWith(searchText.ToLower())).ToList();
                Staff_tabl.ItemsSource = x;

            }
        }

        private void textSearchClick1(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Staff.ToList();
            string searchText = textbox_serach1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.FName.ToLower().StartsWith(searchText.ToLower())).ToList();
                Staff_tabl.ItemsSource = x;

            }
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Staff.ToList();
            Staff_tabl.ItemsSource = x;
            textbox_serach.Clear();
            textbox_serach1.Clear();
            cb.Text = "";
            Refresh();
        }

        private void comboBox_cb(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Staff.ToList();
            int searchInt = cb.SelectedIndex;
            if (searchInt == cb.SelectedIndex)
            {
                x = x.Where(line => (line.Positions_ == cb.SelectedIndex + 1)).ToList();
                Staff_tabl.ItemsSource = x;
            }
            else
            {
                Staff_tabl.ItemsSource = MainWindow.Real_estate_agenc.Positions.ToList();
            }
        }
    }
}
