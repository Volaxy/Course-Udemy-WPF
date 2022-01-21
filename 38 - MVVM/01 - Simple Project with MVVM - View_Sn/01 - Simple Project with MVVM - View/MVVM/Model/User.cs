using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _01___Simple_Project_with_MVVM___View.MVVM.Model
{
    public class User
    {
        private Int32 id;
        private string name;

        public User(Int32 id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Int32 Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }
    }
}
