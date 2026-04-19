using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class TeacherService
    {

        private readonly TeacherDao _teacherDao = new TeacherDao();

        public string CreateTeacher(Teacher teacher)
        {
            if (teacher == null) return "Teacher data is missing.";
            if (string.IsNullOrWhiteSpace(teacher.FirstName) || string.IsNullOrWhiteSpace(teacher.LastName))
                return "First and Last names are required.";

            // Age validation
            if (teacher.Age < 18) return "Teacher must be at least 18 years old.";

            return _teacherDao.AddTeacher(teacher)
                ? "Teacher added successfully."
                : "Failed to add teacher to the database.";
        }

        public string UpdateTeacherProfile(Teacher teacher)
        {
            if (teacher.TeacherId <= 0) return "Invalid Teacher selection.";
            if (string.IsNullOrWhiteSpace(teacher.FirstName) || string.IsNullOrWhiteSpace(teacher.LastName))
                return "Names cannot be empty during update.";

            return _teacherDao.UpdateTeacher(teacher)
                ? "Teacher record updated."
                : "Update failed.";
        }

        public string DeleteTeacherAccount(int id)
        {
            if (id <= 0) return "Select a valid teacher to remove.";

            // Note: In your SQL schema, 'course' table has a foreign key to 'teacher'.
            // If a teacher is assigned to a course, deletion might fail or set course.teacher_id to NULL.
            return _teacherDao.DeleteTeacher(id)
                ? "Teacher removed successfully."
                : "Delete failed. The teacher might be assigned to an existing course.";
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherDao.GetAllTeacher();
        }

        public Teacher GetTeacher(int id)
        {
            if (id <= 0) return null;
            return _teacherDao.GetTeacherById(id);
        }
    }
}
