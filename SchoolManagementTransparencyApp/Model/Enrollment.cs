using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Enrollment
    {
        // Properties
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; } // Changed to int to match your Course class
        public DateTime EnrollmentDate { get; set; }

        // Default Constructor
        public Enrollment()
        {
            // Default to current date/time when a new enrollment is created
            EnrollmentDate = DateTime.Now;
        }

        // Parameterized Constructor
        public Enrollment(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
            EnrollmentDate = DateTime.Now;
        }

        // Overridden ToString Method
        public override string ToString()
        {
            return $"Enrollment: Student {StudentId} in Course {CourseId} on {EnrollmentDate:yyyy-MM-dd}";
        }
    }
}
