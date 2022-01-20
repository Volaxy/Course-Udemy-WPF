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

namespace _05___Add_Image_to_ListView_by_Code
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

        private void addImageButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.ListViewItem listViewItem = new System.Windows.Controls.ListViewItem();
            StackPanel stackPanel = new StackPanel();

            Image image = new Image();
            Label label = new Label();

            string path = Environment.CurrentDirectory + "\\images\\about.png";
            image.Source = new BitmapImage(new Uri(path));
            image.Width = 30;
            image.Height = 30;

            label.Content = "About";

            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(image);
            stackPanel.Children.Add(label);

            listViewItem.Content = stackPanel;

            this.imagesListView.Items.Add(listViewItem);
        }

        private void deleteAllButton_Click(object sender, RoutedEventArgs e)
        {
            this.imagesListView.Items.Clear();
        }
    }
}
