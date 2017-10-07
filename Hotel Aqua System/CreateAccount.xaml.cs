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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            /*Account a = new Account(name, date);

            System.IO.StreamWriter file = new System.IO.StreamWriter("account.txt");
            file.WriteLine(tbox1.Text);
            file.WriteLine(DateTime.Now.ToString());
            file.Close();*/

            MainWindow newWin = new MainWindow();
            newWin.Show();
            Close();
        }
    }
}
