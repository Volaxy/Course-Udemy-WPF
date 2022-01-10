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

namespace _07___Save_File_in_Custom_Folder
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

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText("C:\\tests\\info.txt", this.textTextBox.Text, Encoding.UTF8);
            MessageBox.Show("Done!", "Alert");
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            this.textTextBox.Text = System.IO.File.ReadAllText("C:\\tests\\info.txt", Encoding.UTF8);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textTextBox.Text = "";
            textTextBox.Focus();
        }

        private void saveAsButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();

            saveFileDialog.Title = "Save Text File";
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment
                .SpecialFolder.MyDocuments);
            saveFileDialog.AddExtension = true;

            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName == "")
            {
                return;
            }

            System.IO.File.WriteAllText(saveFileDialog.FileName, this.textTextBox.Text, Encoding.UTF8);

            MessageBox.Show(saveFileDialog.FileName);
        }
    }
}
