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
    /// Логика взаимодействия для payment_add.xaml
    /// </summary>
    public partial class payment_add : Window
    {
        private Payment_type payment_type;
        public payment_add(Payment_type selectedPayment_type)
        {
            InitializeComponent();
            this.payment_type = selectedPayment_type;
            DataContext = selectedPayment_type;
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(payment_type.Title))
            {
                errors += "Пожалуйста, введите название\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (payment_type.ID == 0)
            {
                MainWindow.Real_estate_agenc.Payment_type.Add(payment_type);
            }
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }
    }
}
