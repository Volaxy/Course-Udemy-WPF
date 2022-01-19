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

namespace _03___Add_Items_to_ListView_at_Once
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //this.mainListView.Items.Add("Edit");
            //this.mainListView.Items.Add("New");
            //this.mainListView.Items.Add("Delete");

            this.mainListView.Items.Add(this.nameTextBox.Text);
            this.countLabel.Content = this.mainListView.Items.Count.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.countLabel.Content = this.mainListView.Items.Count.ToString();
        }

        private void deleteAllButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainListView.Items.Clear();
        }

        private void deleteSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            //int index = this.mainListView.SelectedIndex;

            //this.mainListView.Items.RemoveAt(index);
            //******************************************
            object item = this.mainListView.SelectedItem;

            this.mainListView.Items.Remove(item);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();

            list.Add("Male");
            list.Add("Female");
            list.Add("Boy");
            list.Add("Girl");

            this.secondListView.ItemsSource = list;
        }
    }
}
