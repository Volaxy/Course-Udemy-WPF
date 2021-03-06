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

namespace _04___Change_Stretch_with_Code
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
            Uri uri = new Uri("C:\\Users\\gustavo.pereira\\Desktop\\Images\\My_Images\\v.jpg");
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
    }
}
