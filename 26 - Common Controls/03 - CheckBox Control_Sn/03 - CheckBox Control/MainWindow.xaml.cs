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

namespace _03___CheckBox_Control
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

        private void mainCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.mainCheckBox.IsChecked.Value;
        }

        private void mainCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.mainCheckBox.IsChecked.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.mainCheckBox.IsChecked.Value;
        }
    }
}
