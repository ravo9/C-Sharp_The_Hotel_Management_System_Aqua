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
    /// Interaction logic for RoomTypesMenu.xaml
    /// </summary>
    public partial class RoomTypesMenu : Window
    {
        public RoomTypesMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddType newWin = new AddType();
            newWin.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lbox1.Items.Clear();

            for (int i = 0; i < Room.getTypeAmount(); i++)
            {
                lbox1.Items.Add((i + 1).ToString() + ".  " + Room.getChosenType(i));
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            // Variable storing index of selected type.
            int si1 = lbox1.SelectedIndex;

            MessageBoxResult message1 = MessageBox.Show("Do you want to delete this type permanently?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message1 == MessageBoxResult.Yes)
            {
                Room.removeType(si1);
                Room.sortTypes();

                lbox1.Items.Clear();

                for (int i = 0; i < Room.getTypeAmount(); i++)
                {
                    lbox1.Items.Add((i + 1).ToString() + ".  " + Room.getChosenType(i));
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message1 = MessageBox.Show("Do you want to delete all room types permanently?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message1 == MessageBoxResult.Yes)
            {
                Room.removeAllTypes();

                lbox1.Items.Clear();

                for (int i = 0; i < Room.getTypeAmount(); i++)
                {
                    lbox1.Items.Add((i + 1).ToString() + ".  " + Room.getChosenType(i));
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void lbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbox1.SelectedIndex >= 0)
                btn2.IsEnabled = true;
            else
                btn2.IsEnabled = false;
        }
    }
}
