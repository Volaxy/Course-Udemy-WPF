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

namespace _15___Final_Project_with_StatusBar
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

        private void mainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.countLabel.Content = this.mainTextBox.Text.Length.ToString();
        }

        private void zoomComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.mainTextBox.FontSize = 10 + (this.zoomComboBox.SelectedIndex * 2);
        }
    }
}
