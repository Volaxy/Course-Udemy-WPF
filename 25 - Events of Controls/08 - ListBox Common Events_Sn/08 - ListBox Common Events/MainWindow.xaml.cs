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

namespace _08___ListBox_Common_Events
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

        private void mainComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.firstTextBox.Text = this.mainComboBox.SelectedIndex.ToString();

            ComboBoxItem comboBoxItem;

            comboBoxItem = (ComboBoxItem)this.mainComboBox.SelectedItem;

            this.secondTextBox.Text = comboBoxItem.Content.ToString();
        }

        private void namesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.firstTextBox.Text = this.namesListBox.SelectedIndex.ToString();

            ListBoxItem listBoxItem = (ListBoxItem)this.namesListBox.SelectedItem;

            this.secondTextBox.Text = listBoxItem.Content.ToString();
        }
    }
}
