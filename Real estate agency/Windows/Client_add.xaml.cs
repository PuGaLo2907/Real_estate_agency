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
    /// Логика взаимодействия для Client_add.xaml
    /// </summary>
    public partial class Client_add : Window
    {
        private Client client;
        public Client_add(Client selectedClient)
        {
            InitializeComponent();
            this.client = selectedClient;
            DataContext = selectedClient;
        }
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(client.LName))
            {
                errors += "Пожалуйста, введите Фамилию\n";
            }
            if (String.IsNullOrWhiteSpace(client.FName))
            {
                errors += "Пожалуйста, введите Имя\n";
            }
            if (String.IsNullOrWhiteSpace(client.OName))
            {
                errors += "Пожалуйста, введите Отчество\n";
            }
            if (client.Passport_number == 0)
            {
                errors += "Пожалуйста, введите номер паспорта\n";
            }
            if (Date_picker_1.SelectedDate == null)
            {
                errors += "Пожалуйста, введите Дату рождения\n";
            }
            if (textbox_snils.Text == "")
            {
                errors += "Пожалуйста, введите Снилс\n";
            }
            if (String.IsNullOrWhiteSpace(client.Registration))
            {
                errors += "Пожалуйста, введите место прописки\n";
            }
            if (client.INN < 0)
            {
                errors += "Пожалуйста, введите ИНН\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (client.ID == 0)
            {
                MainWindow.Real_estate_agenc.Client.Add(client);
            }
            client.Date_of_birth = Convert.ToDateTime(Date_picker_1.SelectedDate);
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }
    }
}
