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
    /// Логика взаимодействия для add_type.xaml
    /// </summary>
    public partial class add_type : Window
    {
        private Ad_type ad_type_;
        public add_type(Ad_type selectedAd_type)
        {
            InitializeComponent();
            this.ad_type_ = selectedAd_type;
            DataContext = selectedAd_type;
        }
        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(ad_type_.Title))
            {
                errors += "Пожалуйста, введите название\n";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Ошибка записи", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ad_type_.ID == 0)
            {
                MainWindow.Real_estate_agenc.Ad_type.Add(ad_type_);
            }
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }
    }
}
