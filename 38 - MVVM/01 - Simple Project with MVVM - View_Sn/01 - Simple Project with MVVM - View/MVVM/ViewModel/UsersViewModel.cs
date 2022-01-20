using _01___Simple_Project_with_MVVM.MVVM.View;
using _01___Simple_Project_with_MVVM___View.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Simple_Project_with_MVVM___View.MVVM.ViewModel
{
    public class UsersViewModel
    {
        private List<User> users = new List<User>();

        public UsersViewModel()
        {
            users.Add(new User(1, "Mike"));
            users.Add(new User(2, "Lee"));
            users.Add(new User(3, "Jonh"));
        }

        public List<User> Users { get { return users; } set { users = value; } }
    }
}
