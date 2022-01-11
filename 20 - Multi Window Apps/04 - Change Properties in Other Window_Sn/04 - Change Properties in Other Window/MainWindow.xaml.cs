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

namespace _04___Change_Properties_in_Other_Window
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

        private void changePropertiesButton_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow childWindow = new ChildWindow();

            childWindow.childLabel.Content = "I changed...";
            childWindow.childLabel.Foreground = Brushes.Gainsboro;
            childWindow.childLabel.Background = Brushes.MediumAquamarine;

            childWindow.saveButton.Content = "Saving...";

            childWindow.Show();
        }
    }
}
