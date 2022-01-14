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

namespace _09___ProgressBar_Control
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

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void increaseButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainProgressBar.Value = this.mainProgressBar.Value + 5;
        }

        private void decreaseButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainProgressBar.Value = this.mainProgressBar.Value - 5;
        }
    }
}
