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
            System.IO.File.WriteAllText("D:\\WS\\Visual Studio 2021\\C# com Visual Studio\\Udemy\\WPF\\18 - Project - Customer Info\\01 - Design Info Window_Sn\\01 - Design Info Window\\" + this.idTextBox.Text + "_info.txt", this.firstNameTextBox.Text + " " + this.lastNameTextBox.Text, Encoding.UTF8);

            MessageBox.Show("Done!", "Alert");
        }
    }
}
