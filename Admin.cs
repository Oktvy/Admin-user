using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Admin : People
    {
        public string Section;
        public bool IsSuperAdmin;

        public Admin(string username, string password, string section, bool isSuperAdmin) : base(username, password)
        {
            Username = username;
            Password = password;
            Section = section;
            IsSuperAdmin = isSuperAdmin;
        
        }
    } 
}
