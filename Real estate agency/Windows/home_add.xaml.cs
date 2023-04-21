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
    /// Логика взаимодействия для home_add.xaml
    /// </summary>
    public partial class home_add : Window
    {
        private Home home;
        public home_add(Home selectedHome)
        {
            InitializeComponent();
            tip_box.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            status_box.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            ob_box.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            this.home = selectedHome;
            DataContext = selectedHome;
        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(home.Addres))
            {
                errors += "Пожалуйста, введите Адрес\n";
            }
            if (home.Type <= 0)
            {
                errors += "Пожалуйста, введите тип квартиры\n";

            }
            if (home.Status <= 0)
            {
                errors += "Пожалуйста, введите состояние квартиры\n";

            }
            if (home.Cadastral_number <= 0)
            {
                errors += "Пожалуйста, введите кадастровый номер квартиры\n";

            }
            if (home.Owner <= 0)
            {
                errors += "Пожалуйста, введите владельца\n";

            }
            if (home.Floors_House <= 0)
            {
                errors += "Пожалуйста, введите кол-во этажей  дома\n";

            }
           
            if (home.Square_house <= 0)
            {
                errors += "Пожалуйста, введите площадь дома\n";

            }
            if (home.Plot_area < 0)
            {
                errors += "Пожалуйста, введите площадь участка\n";

            }
            if (home.Number_of_rooms <= 0)
            {
                errors += "Пожалуйста, введите кол-во комнат\n";

            }

            if (home.Price <= 0)
            {
                errors += "Пожалуйста, введите цену\n";

            }
            if (home.Ad_types <= 0)
            {
                errors += "Пожалуйста, введите цтип объявления\n";

            }
            if (home.ID == 0)
            {
                MainWindow.Real_estate_agenc.Home.Add(home);
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
                home.Image = textblock_1.Text;
                String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }
        }
    }
}
