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
    /// Логика взаимодействия для Sostayanie_add.xaml
    /// </summary>
    public partial class Sostayanie_add : Window
    {
        private Property_condition property_condition;
        public Sostayanie_add(Property_condition selectedProperty_condition)
        {
            InitializeComponent();
            this.property_condition = selectedProperty_condition;
            DataContext = selectedProperty_condition;
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(property_condition.Title))
            {
                errors += "Пожалуйста, введите название\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (property_condition.ID == 0)
            {
                MainWindow.Real_estate_agenc.Property_condition.Add(property_condition);
            }
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
