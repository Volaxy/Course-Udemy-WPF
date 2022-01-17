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

namespace _09___Get_File_Info_by_Code
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

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.ShowDialog();

            this.filePathTextBox.Text = openFileDialog.FileName;
        }

        private void fileInfoButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(this.filePathTextBox.Text);

            this.fileNameTextBox.Text = fileInfo.Name.ToString();
            this.fileFolderTextBox.Text = fileInfo.DirectoryName.ToString();
            this.fileDriveTextBox.Text = fileInfo.Directory.Root.Name.ToString();
            this.fileExtensionTextBox.Text = fileInfo.Extension.ToString();
            this.fileCreationTextBox.Text = fileInfo.CreationTime.ToString();
            this.fileLastAccessTextBox.Text = fileInfo.LastAccessTime.ToString();
            this.fileLastModifiedTextBox.Text = fileInfo.LastWriteTime.ToString();
            this.fileSizeTextBox.Text = (fileInfo.Length / 1024).ToString() + " KB";
        }
    }
}
