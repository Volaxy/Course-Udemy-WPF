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

namespace _04___Move_a_File_with_Code
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

        private void moveFileButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to replace it?", "Alert", MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                System.IO.File.Move("D:\\WS\\Visual Studio 2021\\C# com Visual Studio\\Udemy\\WPF\\29 - Working with Files and Folders\\Images\\Koala.jpg", "C:\\Users\\gustavo.pereira\\Desktop\\Images\\tests\\koalatest.jpg");
            }
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.ShowDialog();

            this.pathTextBox.Text = openFileDialog.FileName;
        }
    }
}
