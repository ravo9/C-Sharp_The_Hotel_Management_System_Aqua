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
    /// Interaction logic for EditOrder.xaml
    /// </summary>
    public partial class EditOrder : Window
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddOrder newWin = new AddOrder();
            newWin.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            EditOrderData newWin = new EditOrderData(lbox1.SelectedIndex);
            newWin.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            OrdersMenu newWin = new OrdersMenu();
            newWin.Show();
            Close();
        }

        private void lbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbox1.SelectedIndex >= 0)
            {
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
            }
            else
            {
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lbox1.Items.Clear();

            for (int i = 0; i < Client.getClientAmount(); i++)
            {
                lbox1.Items.Add((i + 1).ToString() + ".  " + Client.getChosenClient(i).firstNamePub + "  " + Client.getChosenClient(i).surnamePub + "  (" + Client.getChosenClient(i).genderPub + "; individual ID = " + Client.getChosenClient(i).idPub + ")  " + Client.getChosenClient(i).dateBirthPub.ToShortDateString() + "  " + Client.getChosenClient(i).addressPub + "  " + Client.getChosenClient(i).nationalityPub);
            }
        }
    }
}
