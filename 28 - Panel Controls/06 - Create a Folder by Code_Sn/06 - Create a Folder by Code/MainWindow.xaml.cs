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

namespace _06___Create_a_Folder_by_Code
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

        private void createFolderButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.DirectoryInfo r = System.IO.Directory.CreateDirectory("D:\\test");

            bool b = r.Exists;

            if (b)
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("false");
            }

            this.Title = r.FullName;
            this.Title = r.Name;
            this.Title = r.CreationTime.ToString();
        }
    }
}
