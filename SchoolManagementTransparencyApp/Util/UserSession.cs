using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Util
{
    internal class UserSession
    {
        // Globally stores the active User ID across all application forms
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }

        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
            CurrentRole = string.Empty;
        }
    }
}
