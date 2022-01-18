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

namespace _04___Style_to_ContextMenu_and_Items
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

        private void exitApp_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I'm exit Button!");
            Application.Current.Shutdown();
        }

        private void cutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut Button!");
        }

        private void copyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy Button!");
        }

        private void pasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste Button!");
        }
    }
}
