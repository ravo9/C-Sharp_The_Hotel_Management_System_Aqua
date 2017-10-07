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
    /// Interaction logic for RoomMenu.xaml
    /// </summary>
    public partial class RoomMenu : Window
    {
        public RoomMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddRoom newWin = new AddRoom();
            newWin.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            EditRoomData newWin = new EditRoomData(lbox1.SelectedIndex);
            newWin.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            // Variable storing index of selected room.
            int si1 = lbox1.SelectedIndex;

            MessageBoxResult message1 = MessageBox.Show("Do you want to delete this room's data permanently?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message1 == MessageBoxResult.Yes)
            {
                Room.removeRoom(si1);

                lbox1.Items.Clear();

                for (int i = 0; i < Room.getRoomAmount(); i++)
                {
                    lbox1.Items.Add((i + 1).ToString() + ".  " + Room.getChosenRoom(i).roomTypePub + "  (number " + Room.getChosenRoom(i).roomNumberPub.ToString() + ",  floor " + Room.getChosenRoom(i).floorNoPub.ToString() + ")  basic price:  " + Room.getChosenRoom(i).basicNightPricePub.ToString() + "$ per night        " + Room.getChosenRoom(i).additionalInfoPub);
                }

                // "Remove all" button deactivation.
                if (Room.getRoomAmount() == 0)
                    btn5.IsEnabled = false;

                MessageBox.Show("The room's data has been removed!");
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWin = new MainMenu();
            newWin.Show();
            Close();
        }

        private void btn4_Click_1(object sender, RoutedEventArgs e)
        {
            RoomTypesMenu newWin = new RoomTypesMenu();
            newWin.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message1 = MessageBox.Show("Do you want to delete all rooms data permanently?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message1 == MessageBoxResult.Yes)
            {
                Room.removeAllRooms();

                lbox1.Items.Clear();

                // "Remove all" button deactivation.
                btn5.IsEnabled = false;

                MessageBox.Show("All rooms data has been removed!");
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lbox1.Items.Clear();

            for (int i = 0; i < Room.getRoomAmount(); i++)
            {
                lbox1.Items.Add((i + 1).ToString() + ".  " + Room.getChosenRoom(i).roomTypePub + "  (number " + Room.getChosenRoom(i).roomNumberPub.ToString() + ",  floor " + Room.getChosenRoom(i).floorNoPub.ToString() + ")  basic price:  " + Room.getChosenRoom(i).basicNightPricePub.ToString() + "$ per night        " + Room.getChosenRoom(i).additionalInfoPub);
            }

            // "Remove all" button activation.
            if (Room.getRoomAmount() > 0)
                btn5.IsEnabled = true;
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

        private void lbox1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           
        }
    }
}
