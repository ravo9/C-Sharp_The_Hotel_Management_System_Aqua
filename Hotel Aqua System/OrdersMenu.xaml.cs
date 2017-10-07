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

namespace Hotel_Aqua_System
{
    /// <summary>
    /// Interaction logic for OrdersMenu.xaml
    /// </summary>
    public partial class OrdersMenu : Window
    {
        public OrdersMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddOrder newWin = new AddOrder();
            newWin.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWin = new MainMenu();
            newWin.Show();
            Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            EditOrder newWin = new EditOrder();
            newWin.Show();
            Close();
        }
    }
}
