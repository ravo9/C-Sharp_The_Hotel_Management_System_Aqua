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
    /// Interaction logic for EditRoomData.xaml
    /// </summary>
    public partial class EditRoomData : Window
    {
        // Selected room's number.
        int s;

        public EditRoomData(int i)
        {
            InitializeComponent();

            // Selected room's number assignment.
            s = i;

            tbox1.Text = Room.getChosenRoom(i).roomNumberPub.ToString();
            tbox2.Text = Room.getChosenRoom(i).floorNoPub.ToString();
            tbox3.Text = Room.getChosenRoom(i).basicNightPricePub.ToString();
            tbox4.Text = Room.getChosenRoom(i).additionalInfoPub;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            cbox1.Items.Clear();
            for (int i = 0; i < Room.getTypeAmount(); i++)
            {
                cbox1.Items.Add(Room.getChosenType(i));
            }

            try
            {
                cbox1.SelectedItem = Room.getChosenRoom(s).roomTypePub;
            }
            catch (Exception ex)
            {
                cbox1.SelectedItem = null;
            }
        }
        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room.getChosenRoom(s).roomNumberPub = Int32.Parse(tbox1.Text);
                Room.getChosenRoom(s).roomTypePub = cbox1.SelectedItem.ToString();
                Room.getChosenRoom(s).floorNoPub = Int32.Parse(tbox2.Text);
                Room.getChosenRoom(s).basicNightPricePub = Convert.ToDouble(tbox3.Text);
                Room.getChosenRoom(s).additionalInfoPub = tbox4.Text;
                Close();
                MessageBox.Show("The room's data has been updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in the correct data!", "Data error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            RoomTypesMenu newWin = new RoomTypesMenu();
            newWin.Show();
        }
    }
}
