using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Course
    {
        // Properties
        public int CourseId { get; set; }
        public string CourseName { get; set; } // Renamed to PascalCase for C# consistency
        public int TeacherId { get; set; }  // Renamed to PascalCase

        // Default Constructor
        public Course()
        {
            CourseName = string.Empty;
            TeacherId = 0;
        }

        // Parameterized Constructor (Useful for quickly creating objects from DB results)
        public Course(int id, string name, int teacherId)
        {
            CourseId = id;
            CourseName = name;
            TeacherId = teacherId;
        }

        // Overridden ToString Method
        // Ideal for populating ListBoxes or ComboBoxes in WinForms
        public override string ToString()
        {
            return $"{CourseName} (Teacher ID: {TeacherId})";
        }
    }
}
