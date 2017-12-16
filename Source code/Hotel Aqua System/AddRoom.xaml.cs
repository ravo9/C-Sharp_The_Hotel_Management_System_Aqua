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
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Window
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room r = new Room(Int32.Parse(tbox1.Text), cbox1.SelectedItem.ToString(), Int32.Parse(tbox2.Text), Convert.ToDouble(tbox3.Text), tbox4.Text);
                Close();
                MessageBox.Show("The new room has been added!");
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

        private void Window_Initialized(object sender, EventArgs e)
        {

        }
        
        private void Window_Activated(object sender, EventArgs e)
        {
            cbox1.Items.Clear();
            for (int i = 0; i < Room.getTypeAmount(); i++)
            {
                cbox1.Items.Add(Room.getChosenType(i));
            }
        }
    }
}
