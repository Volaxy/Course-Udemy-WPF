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

namespace _08___Open_Any_Folders_in_Code
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
            //System.Diagnostics.Process.Start("D:\\WS\\Visual Studio 2021\\C# com Visual Studio\\Udemy\\WPF\\16 - Practical Code\\08 - Open Any Folders in Code_Sn\\08 - Open Any Folders in Code\\bin\\Debug\\images");

            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.BaseDirectory + "\\images");
        }
    }
}
