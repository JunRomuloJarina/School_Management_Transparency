using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Util
{
    internal class StudentCreateInputValidator
    {

        public bool ValidateStudentInput(string firstname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname) || firstname.Length < 2)
                return false; // First name is required and should be at least 2 characters
            if (string.IsNullOrWhiteSpace(lastname) || lastname.Length < 2)
                return false; // Last name is required and should be at least 2 characters
            return true; // All inputs are valid
        }


        
    }
}
