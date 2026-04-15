using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }

        // 1. Default Constructor
        public Teacher()
        {
        }

        // 2. Parameterized Constructor
        public Teacher(int teacherId, string firstName, string middleName, string lastName,
                       int age, string gender, string address, DateTime dateOfBirth,
                       string contactNumber)
        {
            TeacherId = teacherId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
        }

        public Teacher(string firstName, string middleName, string lastName,
                       int age, string gender, string address, DateTime dateOfBirth,
                       string contactNumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"[ID: {TeacherId}] {LastName}, {FirstName} {MiddleName} | Gender: {Gender} | Contact: {ContactNumber}";
        }
    }
}
