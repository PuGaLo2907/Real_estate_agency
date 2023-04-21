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
    /// Логика взаимодействия для Tip_nedviz_add.xaml
    /// </summary>
    public partial class Tip_nedviz_add : Window
    {
        private Property_type property_type;
        public Tip_nedviz_add(Property_type selectedProperty_type)
        {
            InitializeComponent();
            this.property_type = selectedProperty_type;
            DataContext = selectedProperty_type;
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(property_type.Title))
            {
                errors += "Пожалуйста, введите название\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (property_type.ID == 0)
            {
                MainWindow.Real_estate_agenc.Property_type.Add(property_type);
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
