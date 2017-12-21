using System;
using System.IO;
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

namespace Hotel_Aqua_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Account reading.
            // File to object transformation.
            string name = "";
            DateTime date;

            /*if (File.Exists("account.txt"))
            {
                System.IO.StreamReader file = new System.IO.StreamReader("account.txt");
                name = file.ReadLine();
                if (name != "")
                {
                    date = DateTime.Parse(file.ReadLine());
                    Account a = new Account(name, date);
                }
                file.Close();
            }*/
            

            if (Account.getAccount() == null)
            {
                //btn2.IsEnabled = true;
            }
            else
            {
                lbox1.Items.Add(Account.getAccount().namePub);
                lbox1.Items.Add(Account.getAccount().lastUpdatePub);

                btn1.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWin = new MainMenu();
            newWin.Show();
            Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount newWin = new CreateAccount();
            newWin.Show();
            Close();
        }

        private void lbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
