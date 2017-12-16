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
    /// Interaction logic for EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        public EditClient()
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
            EditClientData newWin = new EditClientData(lbox1.SelectedIndex);
            newWin.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            // Variable storing index of selected customer.
            int si1 = lbox1.SelectedIndex;

            MessageBoxResult message1 = MessageBox.Show("Do you want to delete this cutomer's data permanently?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (message1 == MessageBoxResult.Yes)
            {
                Client.removeClient(si1);

                lbox1.Items.Clear();

                for (int i = 0; i < Client.getClientAmount(); i++)
                {
                    lbox1.Items.Add((i + 1).ToString() + ".  " + Client.getChosenClient(i).firstNamePub + "  " + Client.getChosenClient(i).surnamePub + "  (" + Client.getChosenClient(i).genderPub + "; individual ID = " + Client.getChosenClient(i).idPub + ")  " + Client.getChosenClient(i).dateBirthPub.ToShortDateString() + "  " + Client.getChosenClient(i).addressPub + "  " + Client.getChosenClient(i).nationalityPub);
                }

                MessageBox.Show("The customer's data has been removed!");
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ClientsMenu newWin = new ClientsMenu();
            newWin.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lbox1.Items.Clear();

            for (int i = 0; i < Client.getClientAmount(); i++)
            {
                lbox1.Items.Add((i + 1).ToString() + ".  " + Client.getChosenClient(i).firstNamePub + "  " + Client.getChosenClient(i).surnamePub + "  (" + Client.getChosenClient(i).genderPub + "; individual ID = " + Client.getChosenClient(i).idPub + ")  " + Client.getChosenClient(i).dateBirthPub.ToShortDateString() + "  " + Client.getChosenClient(i).addressPub + "  " + Client.getChosenClient(i).nationalityPub);
            }
        }

        private void lbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbox1.SelectedIndex >= 0)
            {
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
            }
            else
            {
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
            }
        }
    }
}
