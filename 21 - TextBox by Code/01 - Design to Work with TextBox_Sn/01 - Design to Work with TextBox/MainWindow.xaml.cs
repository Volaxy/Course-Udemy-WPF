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

namespace _01___Design_to_Work_with_TextBox
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

        private void zoomInButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.mainTextBox.FontSize + 5 < 60)
            {
                this.mainTextBox.FontSize = this.mainTextBox.FontSize + 5;
            }
        }

        private void zoomOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.mainTextBox.FontSize - 4 > 8)
            {
                this.mainTextBox.FontSize = this.mainTextBox.FontSize - 5;
            }
        }

        private void selectAllButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Focus();
            this.mainTextBox.SelectAll();
        }

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Undo();
        }

        private void redoButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Redo();
        }
    }
}
