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

namespace _06___Code_to_Save_Value_in_Resource
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

        private void windowResourceButton_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonHeight"] = Double.Parse(windowResourceTextBox.Text);
        }

        private void appResourceButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["ButtonWidth"] = Double.Parse(appResourceTextBox.Text);
        }

        private void gridResourceButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainGrid.Resources["ButtonFontSize"] = Double.Parse(gridResourceTextBox.Text);
        }
    }
}
