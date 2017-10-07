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
    /// Interaction logic for ClientsMenu.xaml
    /// </summary>
    public partial class ClientsMenu : Window
    {
        public ClientsMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddClient newWin = new AddClient();
            newWin.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            EditClient newWin = new EditClient();
            newWin.Show();
            Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWin = new MainMenu();
            newWin.Show();
            Close();
        }
    }
}
