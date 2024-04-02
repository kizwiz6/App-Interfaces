using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string password;
        private string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least eight characters in length.");
                }
            }
        }

        public bool Hidden { get; private set; }
        public char HeaderSymbol { get { return '='; } }

        public PasswordManager(string password, bool hidden)
        {
            this.Password = password;
            this.Hidden = hidden;
        }

        public void Display()
        {
            Console.WriteLine("Password:");
            Console.WriteLine(new string(HeaderSymbol, 10));
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resetting Passwords.\n");
            Console.ResetColor();
            Password = "";
            Hidden = false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
