using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Util
{
    internal class LoginInputValidator
    {

        public bool ValidateLoginInput(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || username.Length < 3 || password.Length < 4)
            {
                return false; // Invalid input
            }
            return true; // Valid input
        }
    }
}
