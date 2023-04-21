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
    /// Логика взаимодействия для dolznost_add.xaml
    /// </summary>
    public partial class dolznost_add : Window
    {
        private Positions positions;
        public dolznost_add(Positions selectedPositions)
        {
            InitializeComponent();
            this.positions = selectedPositions;
            DataContext = selectedPositions;

        }

        private void button_save_click(object sender, RoutedEventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(positions.Title))
            {
                errors += "Пожалуйста, введите Должность\n";
            }
            
            if (positions.ID == 0)
            {
                MainWindow.Real_estate_agenc.Positions.Add(positions);
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
