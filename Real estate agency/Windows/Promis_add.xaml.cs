using Microsoft.Win32;
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
    /// Логика взаимодействия для Promis_add.xaml
    /// </summary>
    public partial class Promis_add : Window
    {
        private Premises premises;
        public Promis_add(Premises selectedPremises)
        {
            InitializeComponent();
            tip_box.ItemsSource = MainWindow.Real_estate_agenc.Property_type.ToList();
            status_box.ItemsSource = MainWindow.Real_estate_agenc.Property_condition.ToList();
            ob_box.ItemsSource = MainWindow.Real_estate_agenc.Ad_type.ToList();
            owner_box.ItemsSource = MainWindow.Real_estate_agenc.Client.ToList();
            this.premises = selectedPremises;
            DataContext = selectedPremises;
        }
        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(premises.Addres))
            {
                errors += "Пожалуйста, введите Адрес\n";
            }
            if (premises.Type <= 0)
            {
                errors += "Пожалуйста, введите тип квартиры\n";

            }
            if (premises.Status <= 0)
            {
                errors += "Пожалуйста, введите состояние квартиры\n";

            }
            if (premises.Cadastral_number <= 0)
            {
                errors += "Пожалуйста, введите кадастровый номер квартиры\n";

            }
            if (premises.Owner <= 0)
            {
                errors += "Пожалуйста, введите владельца\n";

            }
            if (premises.Floor <= 0)
            {
                errors += "Пожалуйста, введите кол-во этажей в доме\n";

            }
            
            if (premises.Area <= 0)
            {
                errors += "Пожалуйста, введите площадь квартиры\n";

            }
            if (premises.Price <= 0)
            {
                errors += "Пожалуйста, введите цену\n";

            }
            if (premises.Ad_types <= 0)
            {
                errors += "Пожалуйста, введите тип объявления\n";

            }

            if (premises.ID == 0)
            {
                MainWindow.Real_estate_agenc.Premises.Add(premises);
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
                premises.Image = textblock_1.Text;
                String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }
        }
    }
}
