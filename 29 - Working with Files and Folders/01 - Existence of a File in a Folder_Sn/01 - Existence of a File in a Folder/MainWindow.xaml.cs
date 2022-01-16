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

namespace _01___Existence_of_a_File_in_a_Folder
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

        private void checkFileExistsButton_Click(object sender, RoutedEventArgs e)
        {
            bool b = System.IO.File.Exists(this.pathTextBox.Text);

            if (b)
            {
                MessageBox.Show("The file exists");
            }
            else
            {
                MessageBox.Show("The file do not exists");
            }
        }

        private void appSourceButton_Click(object sender, RoutedEventArgs e)
        {
            this.pathTextBox.Text = Environment.CurrentDirectory;
        }
    }
}
