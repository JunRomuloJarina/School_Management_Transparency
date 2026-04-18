using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class UserAccount
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // 1. Default Constructor
        public UserAccount()
        {
        }

        // 2. Parameterized Constructor
        public UserAccount(int userId, string username, string password, string role)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Role = role;
        }

        // 3. ToString Method
        public override string ToString()
        {
            // We omit the password in ToString for basic security hygiene
            return $"User ID: {UserId} | Username: {Username} | Role: {Role}";
        }

    }
}
