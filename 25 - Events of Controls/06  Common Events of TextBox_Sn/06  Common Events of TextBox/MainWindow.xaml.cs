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

namespace _06__Common_Events_of_TextBox
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

        private void firstTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Title = firstTextBox.Text;
        }

        private void firstTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.firstTextBox.Background = Brushes.Aquamarine;
        }

        private void firstTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.firstTextBox.Background = Brushes.DarkSlateGray;
        }
    }
}
