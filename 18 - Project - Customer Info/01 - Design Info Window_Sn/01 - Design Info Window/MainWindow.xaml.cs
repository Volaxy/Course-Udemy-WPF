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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01___Design_Info_Window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.idTextBox.Text == "")
            {
                MessageBox.Show("The Id is Empty", "Alert");
                return;
            }
            if (this.firstNameTextBox.Text == "")
            {
                MessageBox.Show("The First Name is Empty", "Alert");
                return;
            }
            if (this.lastNameTextBox.Text == "")
            {
                MessageBox.Show("The Last Name is Empty", "Alert");
                return;
            }

            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\data\\" +  this.idTextBox.Text + "_info.txt", 
                this.firstNameTextBox.Text + " " + this.lastNameTextBox.Text,
                Encoding.UTF8);

            MessageBox.Show("Done!", "Alert");
        }
    }
}
