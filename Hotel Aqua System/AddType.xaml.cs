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
    /// Interaction logic for AddType.xaml
    /// </summary>
    public partial class AddType : Window
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tbox1.Text == "")
                MessageBox.Show("The name cannot be empty", "Name is empty!", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                Room.addNewType(tbox1.Text);
                Room.sortTypes();
                Close();
            }
        }
    }
}
