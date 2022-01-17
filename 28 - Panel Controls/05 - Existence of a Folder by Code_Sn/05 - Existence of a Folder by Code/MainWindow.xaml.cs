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

namespace _05___Existence_of_a_Folder_by_Code
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

        private void folderExistsButton_Click(object sender, RoutedEventArgs e)
        {
            bool r = System.IO.Directory.Exists("D:\\WS");

            if (r)
            {
                MessageBox.Show("This folder exists");
            }
            else
            {
                MessageBox.Show("This folder not exists");
            }
        }
    }
}
