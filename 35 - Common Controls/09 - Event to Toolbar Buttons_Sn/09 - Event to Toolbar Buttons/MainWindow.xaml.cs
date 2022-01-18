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

namespace _09___Event_to_Toolbar_Buttons
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

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm undo Button!");
        }

        private void copyButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy Button!");
        }

        private void cutButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut Button!");
        }

        private void pasteButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste Button!");
        }
    }
}
