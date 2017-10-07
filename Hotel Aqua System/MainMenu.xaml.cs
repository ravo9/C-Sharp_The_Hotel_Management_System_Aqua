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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            OrdersMenu newWin = new OrdersMenu();
            newWin.Show();
            Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ClientsMenu newWin = new ClientsMenu();
            newWin.Show();
            Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            RoomMenu newWin = new RoomMenu();
            newWin.Show();
            Close();
        }
    }
}
