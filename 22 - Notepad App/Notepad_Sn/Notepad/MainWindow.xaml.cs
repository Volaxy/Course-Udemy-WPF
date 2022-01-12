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

namespace Notepad
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

        // File MenuItem
        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Text = "";
            this.mainTextBox.Focus();
        }

        private void openMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            openFileDialog.ShowDialog();

            if(openFileDialog.FileName != "")
            {
                mainTextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);

                MessageBox.Show("Sucess to Load!");
            }
        }

        private void saveAsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();

            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.AddExtension = true;

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text, Encoding.UTF8);

                MessageBox.Show("Sucess to Save!");
            }
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Edit MenuItem
        private void undoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Undo();
        }

        private void redoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Redo();
        }

        private void cutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Paste();
        }

        private void selectAllMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.Focus();
            this.mainTextBox.SelectAll();
        }

        // Format MenuItem
        private void wordWrapMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(this.wordWrapMenuItem.IsChecked)
            {
                this.mainTextBox.TextWrapping = TextWrapping.Wrap;
                this.mainTextBox.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            }
            else
            {
                this.mainTextBox.TextWrapping = TextWrapping.NoWrap;
                this.mainTextBox.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            }
        }

        // View MenuItem
        private void zoomInMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(this.mainTextBox.FontSize + 4 < 64)
            {
                this.mainTextBox.FontSize = this.mainTextBox.FontSize + 4;
            }
        }

        private void zoomOutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(this.mainTextBox.FontSize - 4 > 8)
            {
                this.mainTextBox.FontSize = this.mainTextBox.FontSize - 4;
            }
        }

        private void defaultZoomMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.mainTextBox.FontSize = 16;
        }

        // Help MenuItem
        private void aboutUsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutUs aboutUs = new AboutUs();

            aboutUs.ShowDialog();
        }
    }
}
