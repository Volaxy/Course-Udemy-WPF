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

            // Write the First Name
            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + this.idTextBox.Text + "_info_Fn.txt",
                this.firstNameTextBox.Text,
                Encoding.UTF8);
            // Write the Last Name
            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + this.idTextBox.Text + "_info_Ln.txt",
                this.lastNameTextBox.Text,
                Encoding.UTF8);

            MessageBox.Show("Done!", "Alert");
        }

        private void searchDataButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.searchIdTextBox.Text == "")
            {
                MessageBox.Show("The search Id is empty!", "Alert");
                return;
            }

            this.idTextBox.Text = this.searchIdTextBox.Text;

            this.firstNameTextBox.Text = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + this.searchIdTextBox.Text + "_info_Fn.txt", Encoding.UTF8);

            this.lastNameTextBox.Text = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + this.searchIdTextBox.Text + "_info_Ln.txt", Encoding.UTF8);
        }
    }
}
