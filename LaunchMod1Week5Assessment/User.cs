using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        // Attributes
        public string Name { get; private set; }
        public string Email { get; private set; }
        // Must make password public in order to test it, but setting to a 'private set' so that it can only be changed within this class.
        public string Password { get; private set; }
        public bool IsLoggedIn { get; set; }

        // Constructor
        // Must add password in order to test it
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = Password;
            IsLoggedIn = false;
        }

        // Method
        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        // Method
        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }

            if (Password != null)
            {
                var confirmation = "Password Created";
            }
        }
        // Method
        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
