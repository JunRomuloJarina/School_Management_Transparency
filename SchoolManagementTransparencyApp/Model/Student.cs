using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Student
    {
        // Properties (Implicit Getters and Setters)
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }

        // 1. Default Constructor
        public Student()
        {
            // Initializes strings to empty to avoid null reference issues
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Gender = string.Empty;
            Address = string.Empty;
            ContactNumber = string.Empty;
            DateOfBirth = DateTime.Now;
        }

        // 2. Overridden ToString Method
        // This is great for debugging or displaying the name in a ComboBox
        public override string ToString()
        {
            return $"[ID: {StudentId}] {FirstName} {LastName} - {ContactNumber}";
        }

    }
}
