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
        private CourseDao courseDao = new CourseDao();

        public string ValidateAddCourse(Course course)
        {
            if (course == null) { return "Course cannot be null"; }
            else if (course.CourseName == null || course.CourseName.Equals("") || course.CourseName.Equals(String.Empty)) { return "Course name cannot be null or empty."; }
            else if (course.CourseName.Length <= 4) { return "Course name length's cannot below to 4 - 0"; }
            else if (course.CourseName.Length >= 50) { return "Course name length's cannot above to 50 - 0"; }
            else if (course.TeacherId == null || course.TeacherId.Equals("") || course.TeacherId.Equals(String.Empty)) { return "Teacher ID cannot be null or empty."; }
            else
            {
                if (courseDao.AddCourse(course))
                {
                    return "Added Successfully";
                }
            }
            return "Failed to add course.";
        }


        public string ValidateRemoveCourse(Course course)
        {
            if (course == null) { return "Course cannot be null"; }
            else if (course.CourseId <= 0) { return "Course ID must be greater than 0."; }
            else
            {
                if (courseDao.DeleteCourse(course))
                {
                    return "Removed Successfully";
                }
            }
            return "Failed to remove course.";
        }

        public List<Course> GetAllCourses()
        {
            return courseDao.GetAllCourses();
        }

        public Course GetCoursesByTeacherId(int teacherId)
        {
            return courseDao.GetCourseById(teacherId);
        }

        public string ValidateUpdateCourse(Course course)
        {
            if (course == null) { return "Course cannot be null"; }
            else if (course.CourseName == null || course.CourseName.Equals("") || course.CourseName.Equals(String.Empty)) { return "Course name cannot be null or empty."; }
            else if (course.CourseName.Length <= 4) { return "Course name length's cannot below to 4 - 0"; }
            else if (course.CourseName.Length >= 50) { return "Course name length's cannot above to 50 - 0"; }
            else if (course.TeacherId == null || course.TeacherId.Equals("") || course.TeacherId.Equals(String.Empty)) { return "Teacher ID cannot be null or empty."; }
            else
            {
                if (courseDao.UpdateCourse(course))
                {
                    return "Updated Successfully";
                }
            }
            return "Failed to update course.";

        }


    }
}
