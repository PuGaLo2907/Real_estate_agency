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
using System.IO;
using Microsoft.Win32;

namespace Real_estate_agency.Windows
{
    /// <summary>
    /// Логика взаимодействия для kvartira_add.xaml
    /// </summary>
    public partial class kvartira_add : Window
    {
        private Apartment apartment;
        public kvartira_add(Apartment selectedKvartira)
        {
            InitializeComponent();
            tip_box.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            status_box.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            ob_box.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            this.apartment = selectedKvartira;
            DataContext = selectedKvartira;
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(apartment.Addres))
            {
                errors += "Пожалуйста, введите Адрес\n";
            }
            if (apartment.Type <=0)
            {
                errors += "Пожалуйста, введите тип квартиры\n";

            }
            if(apartment.Status <= 0)
            {
                errors += "Пожалуйста, введите состояние квартиры\n";

            }
            if (apartment.Cadastral_number <= 0)
            {
                errors += "Пожалуйста, введите кадастровый номер квартиры\n";

            }
            if (apartment.Owner <= 0)
            {
                errors += "Пожалуйста, введите владельца\n";

            }
            if (apartment.Floors_House <= 0)
            {
                errors += "Пожалуйста, введите кол-во этажей в доме\n";

            }
            if (apartment.Apartment_floor <= 0)
            {
                errors += "Пожалуйста, введите этаж квартиры\n";

            }
            if (apartment.Number_of_rooms <= 0)
            {
                errors += "Пожалуйста, введите кол-во комнат\n";

            }
            if (apartment.Area <= 0)
            {
                errors += "Пожалуйста, введите площадь квартиры\n";

            }
            if (apartment.Price <= 0)
            {
                errors += "Пожалуйста, введите цену\n";

            }
            if (apartment.Ad_types <= 0)
            {
                errors += "Пожалуйста, введите цтип объявления\n";

            }

            if (apartment.ID == 0)
            {
                MainWindow.Real_estate_agenc.Apartment.Add(apartment);
            }
            MainWindow.Real_estate_agenc.SaveChanges();
            this.Close();
        }

        private void Button_back_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_s_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            myDialog.Filter = "Картинки(*.JPG;*.GIF;*.PNG) | *.JPG;*.GIF;*.PNG" + "|Все файлы (*.*)|*.*";

            if (myDialog.ShowDialog() == true)
            {
                textblock_1.Text = @"\image\" + myDialog.SafeFileName;
                apartment.Image = textblock_1.Text;
                String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }
        }
    }
}
