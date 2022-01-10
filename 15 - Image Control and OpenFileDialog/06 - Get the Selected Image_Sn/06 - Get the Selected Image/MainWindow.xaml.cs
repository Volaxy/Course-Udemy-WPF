using Microsoft.Win32;
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

namespace _06___Get_the_Selected_Image
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

        private void loadImageButton_Click(object sender, RoutedEventArgs e)
        {
            //Uri uri = new Uri("C:\\Users\\gustavo.pereira\\Desktop\\Images\\My_Images\\v.jpg");
            Uri uri = new Uri(filePathLabel.Content.ToString());
            this.imageControl.Source = new BitmapImage(uri);
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            this.imageControl.Stretch = Stretch.Fill;
        }

        private void zoomButton_Click(object sender, RoutedEventArgs e)
        {
            this.imageControl.Stretch = Stretch.Uniform;
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Image to Show";

            openFileDialog.ShowDialog();

            this.filePathLabel.Content = openFileDialog.FileName;
        }
    }
}
