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

namespace _04___CheckBox_to_Show_and_Hide_Controls
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

        private void showHideCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(this.showHideCheckBox.IsChecked.Value)
            {
                this.mainButton.Visibility = Visibility.Visible;
            }
        }

        private void showHideCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!this.showHideCheckBox.IsChecked.Value)
            {
                this.mainButton.Visibility = Visibility.Hidden;
            }
        }

        private void enableAlertCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.enableAlertCheckBox.IsChecked.Value;
        }

        private void enableAlertCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.enableAlertCheckBox.IsChecked.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.mainButton.IsEnabled = this.enableAlertCheckBox.IsChecked.Value;
        }
    }
}
