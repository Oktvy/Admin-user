using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class User : People
    {
        public User(string username, string password) : base(username, password)
        {
            Username = username;
            Password = password;
        }
    }
}
