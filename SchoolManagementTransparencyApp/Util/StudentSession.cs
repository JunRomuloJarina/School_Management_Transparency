using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Util
{
    internal class StudentSession
    {
        public static Student Session { get; set; }

        public static bool IsLoggedIn()
        {
            return Session != null;
        }

        public static void Logout()
        {
            Session = null;
        }
    }
}
