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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int b = int.Parse(d2.Text);
            int a = int.Parse(d1.Text);
            if (a > 31 || b > 12) v.Text = "Некоректная дата";
            else if (b == 2 && a > 29) v.Text = "Некоректная дата";
            else if (b == 4 && a > 30) v.Text = "Некоректная дата";
            else if (b == 6 && a > 30) v.Text = "Некоректная дата";
            else if (b == 9 && a > 30) v.Text = "Некоректная дата";
            else if (b == 11 && a > 30) v.Text = "Некоректная дата";
            else
            switch (b)

            {
                case 1: v.Text = (a < 22) ? "Водалей":"Козерог"; break;
                case 2: v.Text = (a < 22) ? "Козерог" : "Рыбы"; break;
                case 3: v.Text = (a < 22) ? "Рыбы" : " Овен"; break;
                case 4: v.Text = (a < 22) ? " Овен" : "Телец"; break;
                case 5: v.Text = (a < 22) ? "Телец" : "Блезницы"; break;
                case 6: v.Text = (a < 22) ? "Блезницы" : "Рак"; break;
                case 7: v.Text = (a < 22) ? "Рак" : "Лев"; break;
                case 8: v.Text = (a < 22) ? "Лев" : "Дева"; break;
                case 9: v.Text = (a < 22) ? "Дева" : "Весы"; break;
                case 10: v.Text = (a < 22) ? "Весы" : "Скорпион"; break;
                case 11: v.Text = (a < 22) ? "Скорпион" : "Стрилец"; break;
                case 12: v.Text = (a < 22) ? "Стрилец" : "Козерог"; break;

            }
            
        }

    }
}
