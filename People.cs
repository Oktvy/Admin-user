using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class People
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    _username = "Username 6 herfden cox  olmalidir";
                }

            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                char[] charsToTrim1 = {'1', '2', '3', '4', '5',
                               '6', '7', '8', '9'};

                if (value == value.ToLower()  ) 
                {
                    _password = "Password Minimum 1 herf boyuk olmalidir ve en azi 1 reqem olmalidir";
                }
                else
                {
                    _password = value;

                }
              }


            }

        public People(string username, string password)
        {
            Username = username;
            Password = password;
        }public void Showdata()
        {
            Console.WriteLine(Password);
        }
      
    }
}
