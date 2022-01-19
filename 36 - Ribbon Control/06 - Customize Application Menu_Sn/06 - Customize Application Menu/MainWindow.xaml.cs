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

namespace _06___Customize_Application_Menu
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

        private void cutRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut button!");
        }

        private void copyRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy button!");
        }

        private void pasteRibbonMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste button!");
        }

        private void pasteSpecialRibbonMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm special paste button!");
        }

        private void pasteSpecialRibbonMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Ribbon.RibbonMenuItem ribbonMenuItem;
            ribbonMenuItem = (System.Windows.Controls.Ribbon.RibbonMenuItem)sender;

            if (ribbonMenuItem.IsChecked)
            {
                System.Windows.MessageBox.Show("Paste button is checked!");
            }
        }

        private void exitRibbonMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
