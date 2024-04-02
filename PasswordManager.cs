using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password { get; set; }

        public bool Hidden { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            this.Password = password;
            this.Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden == false)
            {
                Console.WriteLine($"The password is: {Password}");
            }
            else
            {
                Console.WriteLine("***");
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}
