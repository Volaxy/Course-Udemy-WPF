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

namespace _05___Load_the_Value_from_Resources
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
            object obj = this.TryFindResource("ButtonWidth");
            //this.Resources["ButtonWidth"];

            this.windowResourceLabel.Content = obj;
        }

        private void appResourceButton_Click(object sender, RoutedEventArgs e)
        {
            object obj = Application.Current.TryFindResource("ButtonBackground");

            this.appResourceLabel.Content = obj;
        }

        private void gridResourceButton_Click(object sender, RoutedEventArgs e)
        {
            object obj = this.mainGrid.TryFindResource("ButtonWidthTest");

            this.gridResourceLabel.Content = obj;
        }

    }
}
