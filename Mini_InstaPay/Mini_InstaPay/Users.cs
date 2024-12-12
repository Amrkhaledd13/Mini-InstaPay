using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    public class Users
    {
        static Users users;

        public Dictionary<string, User> UsersWithPhone = new Dictionary<string, User>(); 
        public Dictionary<string, User> UsersWithEmail = new Dictionary<string, User>(); 
        private Users() { }

        static public Users getUsers()
        {
            if (users == null)
            {
                users = new Users();
            }
            return users;
        }

    }
}
