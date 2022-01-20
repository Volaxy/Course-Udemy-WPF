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

namespace _08___Class_to_Add_Data_inside_ListView
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
            string path = Environment.CurrentDirectory + "\\images\\me.jpg";

            User user = new User(1, "Gusavo", "Martins Pereira", "02/06/2000", new BitmapImage(new Uri(path)));

            this.mainListView.Items.Clear();
            this.mainListView.Items.Add(user);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();

            string path = Environment.CurrentDirectory + "\\images\\me.jpg";
            for(int i = 1; i <= 5; i++)
            {
                users.Add(new User(i, "Gusavo", "Martins Pereira", "02/06/2000", new BitmapImage(new Uri(path))));
            }

            this.mainListView.Items.Clear();
            this.mainListView.ItemsSource = users;
        }
    }

    public class User
    {
        private Int32 id;
        private string firstName;
        private string lastName;
        private string birthdate;
        private BitmapImage photo;

        public User(Int32 id, string firstName, string lastName, string birthdate, BitmapImage photo)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.photo = photo;
        }

        public Int32 Id { get { return id; } set { this.id = value; } }

        public string FirstName { get { return firstName; } set { this.firstName = value; } }

        public String LastName { get { return lastName; } set { this.lastName = value; } }

        public string Birthdate { get { return birthdate; } set { this.birthdate = value; }  }

        public BitmapImage Photo { get { return photo; } set { photo = value; } }
    }
}
