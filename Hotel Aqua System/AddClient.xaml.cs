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
    /// Interaction logic for AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public AddClient()
        {
            InitializeComponent();
            lbox1.Items.Add("Female");
            lbox1.Items.Add("Male");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client c = new Client(tbox1.Text, tbox2.Text, lbox1.SelectedItem.ToString(), dp1.SelectedDate.Value, tbox3.Text, tbox4.Text);
                Close();
                MessageBox.Show("The new customer has been added!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please fill in the correct data!", "Data error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
