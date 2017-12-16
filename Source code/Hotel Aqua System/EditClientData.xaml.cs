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
    /// Interaction logic for EditClientData.xaml
    /// </summary>
    public partial class EditClientData : Window
    {
        // Selected customer's number.
        int s;

        public EditClientData(int i)
        {
            InitializeComponent();

            // Selected customer's number assignment.
            s = i;

            lbox1.Items.Add("Female");
            lbox1.Items.Add("Male");

            tbox1.Text = Client.getChosenClient(i).firstNamePub;
            tbox2.Text = Client.getChosenClient(i).surnamePub;

            if (Client.getChosenClient(i).genderPub == "Female")
                lbox1.SelectedIndex = 0;
            else
                lbox1.SelectedIndex = 1;

            dp1.SelectedDate = Client.getChosenClient(i).dateBirthPub;

            tbox3.Text = Client.getChosenClient(i).addressPub;
            tbox4.Text = Client.getChosenClient(i).nationalityPub;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client.getChosenClient(s).firstNamePub = tbox1.Text;
                Client.getChosenClient(s).surnamePub = tbox2.Text;
                Client.getChosenClient(s).genderPub = lbox1.SelectedItem.ToString();
                Client.getChosenClient(s).addressPub = tbox3.Text;
                Client.getChosenClient(s).nationalityPub = tbox4.Text;
                Close();
                MessageBox.Show("The customer's data has been updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in the correct data!", "Data error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
