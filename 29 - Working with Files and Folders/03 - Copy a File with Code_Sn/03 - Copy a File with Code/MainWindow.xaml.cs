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

namespace _03___Copy_a_File_with_Code
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

        private void copyFileButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.Copy("C:\\Users\\gugas\\Desktop\\Adv_WPF_sn\\Adv_WPF\\2nd_ctls\\Images\\file_32.png", "C:\\Users\\gugas\\Desktop");
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.ShowDialog();

            this.pathTextBox.Text = openFileDialog.FileName;
        }
    }
}
