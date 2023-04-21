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

namespace Real_estate_agency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Real_estate_agencyEntities5 Real_estate_agenc;
        public MainWindow()
        {
            InitializeComponent();
            Real_estate_agenc = new Real_estate_agencyEntities5();

        }
        private void Button_Registr_click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoc_Login.Text) || String.IsNullOrEmpty(PasswordBox_Password.Password))
            {
                MessageBox.Show("Введите логин или пароль");
                TextBoc_Login.BorderBrush = Brushes.Red;
                PasswordBox_Password.BorderBrush = Brushes.Red;
                return;
            }
            var user = MainWindow.Real_estate_agenc.Staff.AsNoTracking().FirstOrDefault(predicate => predicate.Login == TextBoc_Login.Text && predicate.Password == PasswordBox_Password.Password);
            if (user == null)
            {
                MessageBox.Show("Пользователь с такими данными не найден");
                TextBoc_Login.Clear();
                PasswordBox_Password.Clear();
                return;
            }
            else if (user.Positions_ == 1)
            {
                MessageBox.Show("Вы вошли как администратор");
                Windows.Menu w1 = new Windows.Menu();
                w1.Show();
                this.Close();
            }
            else if (user.Positions_ == 2)
            {
                MessageBox.Show("Вы вошли как сотрудник");
                Windows.Rieltor_menu w1 = new Windows.Rieltor_menu();
                w1.Show();
                this.Close();
            }

        }

        private void Chek(object sender, RoutedEventArgs e)
        {
            if (Check_kek.IsChecked.Value)
            {
                text_pas.Text = PasswordBox_Password.Password;
                text_pas.Visibility = Visibility.Visible;
                PasswordBox_Password.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordBox_Password.Password = text_pas.Text;
                text_pas.Visibility = Visibility.Hidden;
                PasswordBox_Password.Visibility = Visibility.Visible;
            }
        }

        private void Button_Otmena_click(object sender, RoutedEventArgs e)
        {
            PasswordBox_Password.Clear();
            TextBoc_Login.Clear();
            text_pas.Clear();
        }
    }
}
