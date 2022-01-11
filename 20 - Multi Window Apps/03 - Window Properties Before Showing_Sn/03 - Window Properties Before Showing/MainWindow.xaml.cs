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

namespace _03___Window_Properties_Before_Showing
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow childWindow = new ChildWindow();

            childWindow.Title = "Hello! I'm Happy C# Code!";
            childWindow.Background = System.Windows.Media.Brushes.DarkBlue;
            childWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            childWindow.ResizeMode = ResizeMode.CanMinimize;
            childWindow.WindowState = WindowState.Normal;
            childWindow.Width = 350;
            childWindow.Height = 200;

            childWindow.Show();
        }
    }
}
