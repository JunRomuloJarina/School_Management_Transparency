using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class CourseService
    {
        private readonly CourseDao _courseDao = new CourseDao();

        private string GetValidationError(Course course)
        {
            if (course == null) return "Course object is missing.";

            if (string.IsNullOrWhiteSpace(course.CourseName)) return "Course name is required.";

            if (course.CourseName.Length < 4 || course.CourseName.Length > 50)
                return "Course name must be between 4 and 50 characters.";

            if (course.TeacherId <= 0) return "Please select a valid teacher.";

            return string.Empty;
        }

        public string ValidateAddCourse(Course course)
        {
            string error = GetValidationError(course);
            if (!string.IsNullOrEmpty(error)) return error;

            return _courseDao.AddCourse(course) ? "Added Successfully" : "Database error: Could not add course.";
        }

        public string ValidateUpdateCourse(Course course)
        {
            if (course.CourseId <= 0) return "Invalid Course ID.";

            string error = GetValidationError(course);
            if (!string.IsNullOrEmpty(error)) return error;

            return _courseDao.UpdateCourse(course) ? "Updated Successfully" : "Database error: Could not update course.";
        }

        public List<Course> GetAllCourses() => _courseDao.GetAllCourses();
    }
}
