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
    /// Логика взаимодействия для House.xaml
    /// </summary>
    public partial class House : Window
    {
        public int HouseType { get; set; }


        private int _currentPage = 1;
        private int _countClients = 4;
        private int _maxPages;
        private List<Home> aboba;
        public House()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            InitializeComponent();
            aboba = MainWindow.Real_estate_agenc.Home.ToList();
            dome_panel.ItemsSource = aboba;
            dome_panel.ItemsSource = MainWindow.Real_estate_agenc.Home.ToList();
            cb.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            cb1.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            cb2.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            cb4.ItemsSource = list.ToList();
            Refresh();
            UpdateHome();
        }

        List<Home> listHome;
        private void Refresh()
        {
            listHome = MainWindow.Real_estate_agenc.Home.ToList();
            _maxPages = (int)Math.Ceiling(listHome.Count * 1.0 / _countClients);

            var listAgentPage = listHome.Skip((_currentPage - 1) * _countClients).Take(_countClients).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "из " + _maxPages;

            dome_panel.ItemsSource = listAgentPage;
        }
        private void UpdateHome()
        {
            dome_panel.ItemsSource = null;
            dome_panel.ItemsSource = MainWindow.Real_estate_agenc.Home.ToList();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_redact(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedHome = editButton.DataContext as Home;
            Windows.home_add winNew = new Windows.home_add(selectedHome);
            winNew.ShowDialog();
            Refresh();
        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            var Button_Delet = dome_panel.SelectedItem as Home;
            if (Button_Delet != null)
            {
                MainWindow.Real_estate_agenc.Home.Remove(Button_Delet);
                MainWindow.Real_estate_agenc.SaveChanges();
                UpdateHome();
            }
            else MessageBox.Show("Выберите запись для удаления!");
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
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            string searchText = textbox_serach1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.Addres.ToLower().StartsWith(searchText.ToLower())).ToList();
                dome_panel.ItemsSource = x;

            }
        }

        private void textSearchClick4(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            string searchText = textbox_serac2.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                x = x.Where(p => p.S.ToLower().StartsWith(searchText.ToLower())).ToList();
                dome_panel.ItemsSource = x;

            }
        }

        private void comboBox_cb(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            int searchInt = cb.SelectedIndex;
            if (searchInt == cb.SelectedIndex)
            {
                x = x.Where(line => (line.Type == cb.SelectedIndex + 1)).ToList();
                dome_panel.ItemsSource = x;
            }
            else
            {
                dome_panel.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            }
        }

        private void comboBox_cb1(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            int searchInt = cb1.SelectedIndex;
            if (searchInt == cb1.SelectedIndex)
            {
                x = x.Where(line => (line.Status == cb1.SelectedIndex + 1)).ToList();
                dome_panel.ItemsSource = x;
            }
            else
            {
                dome_panel.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            }
        }

        private void comboBox_cb2(object sender, SelectionChangedEventArgs e)
        {
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            int searchInt = cb2.SelectedIndex;
            if (searchInt == cb2.SelectedIndex)
            {
                x = x.Where(line => (line.Ad_types == cb2.SelectedIndex + 1)).ToList();
                dome_panel.ItemsSource = x;
            }
            else
            {
                dome_panel.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            }
        }

        private void comboBox_cb4(object sender, SelectionChangedEventArgs e)
        {

            var x = MainWindow.Real_estate_agenc.Home.ToList();
            int searchInt = cb4.SelectedIndex;
            if (searchInt == cb4.SelectedIndex)
            {
                x = x.Where(line => (line.Number_of_rooms == cb4.SelectedIndex + 1)).ToList();
                dome_panel.ItemsSource = x;
            }
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Home newHome = new Home();
            Windows.home_add winHome = new Windows.home_add(newHome);
            winHome.ShowDialog();
            UpdateHome();
            Refresh();
        }

        private void revers_btn_click(object sender, RoutedEventArgs e)
        {
            cb.Text = "";
            cb1.Text = "";
            cb2.Text = "";
            cb4.Text = "";

            textbox_serach.Text = "";
            textbox_serach1.Text = "";
            textbox_serac2.Text = "";
            textbox_serach4.Text = "";
            var x = MainWindow.Real_estate_agenc.Home.ToList();
            dome_panel.ItemsSource = x;
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

        private void btn_prod(object sender, RoutedEventArgs e)
        {
            Buy_home newHome = new Buy_home();
            Windows.Buy_home_add winHome = new Windows.Buy_home_add(newHome);
            winHome.ShowDialog();
            UpdateHome();
            Refresh();
        }

        private void btn_arend(object sender, RoutedEventArgs e)
        {
            Rent_home newHome = new Rent_home();
            Windows.Rent_home_add winHome = new Windows.Rent_home_add(newHome);
            winHome.ShowDialog();
            UpdateHome();
            Refresh();
        }
    }
}
