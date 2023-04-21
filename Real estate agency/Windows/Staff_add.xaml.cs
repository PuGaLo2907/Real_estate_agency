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
    /// Логика взаимодействия для Staff_add.xaml
    /// </summary>
    public partial class Staff_add : Window
    {
        private Staff staff;
        public Staff_add(Staff selectedStaff)
        {
            InitializeComponent();
            positions_box.ItemsSource = MainWindow.Real_estate_agenc.Positions.ToList();
            this.staff = selectedStaff;
            DataContext = selectedStaff;
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(staff.LName))
            {
                errors += "Пожалуйста, введите Фамилию\n";
            }
            if (String.IsNullOrWhiteSpace(staff.FName))
            {
                errors += "Пожалуйста, введите Имя\n";
            }
            if (String.IsNullOrWhiteSpace(staff.OName))
            {
                errors += "Пожалуйста, введите Отчество\n";
            }
            if (staff.Passport_number == 0)
            {
                errors += "Пожалуйста, введите номер паспорта\n";
            }
            if (Date_picker_1.Text == "")
            {
                errors += "Пожалуйста, введите Дату рождения\n";
            }
            if (String.IsNullOrWhiteSpace(staff.Login) || staff.Login.Length > 8)
            {
                errors += "Пожалуйста, введите корректный Логин (Не больше  8 символов)\n";
            }
            if (String.IsNullOrWhiteSpace(staff.Password) || staff.Password.Length > 8)
            {
                errors += "Пожалуйста, введите корректный Пароль (Не больше 8 символов)\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (staff.ID == 0)
            {
                MainWindow.Real_estate_agenc.Staff.Add(staff);
            }
            staff.Date_of_birth = Convert.ToDateTime(Date_picker_1.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (staff.ID == 0)
            {
                positions_box.SelectedIndex = 0;
            }
        }
    }
}
