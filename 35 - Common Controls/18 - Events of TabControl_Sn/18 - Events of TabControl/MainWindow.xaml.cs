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

namespace _18___Events_of_TabControl
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

        private void mainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Int32 si = this.mainTabControl.SelectedIndex;

            if (si == 0)
            {
                this.selectedTabItemLabel.Content = "Application";
            }
            if (si == 1)
            {
                this.selectedTabItemLabel.Content = "Settings";
            }
            if (si == 2)
            {
                this.selectedTabItemLabel.Content = "Display";
            }
            if (si == 3)
            {
                this.selectedTabItemLabel.Content = "About";
            }
        }
    }
}
