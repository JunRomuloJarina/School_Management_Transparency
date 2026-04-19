using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Controller
{
    internal class CourseController
    {
        private readonly CourseService _courseService = new CourseService();
        private readonly TeacherService _teacherService = new TeacherService();

        // 1. Method to refresh the DataGridView
        public void LoadCoursesIntoGrid(DataGridView dgv)
        {
            try
            {
                // We wrap the list in a BindingSource for better WinForms compatibility
                dgv.DataSource = null;
                dgv.DataSource = _courseService.GetAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Method to handle adding a course from the Form
        public bool AddCourse(string name, int teacherId)
        {
            Course newCourse = new Course
            {
                CourseName = name,
                TeacherId = teacherId
            };

            string result = _courseService.ValidateAddCourse(newCourse);

            if (result == "Added Successfully")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Method to handle updating a course
        public bool UpdateCourse(int id, string name, int teacherId)
        {
            Course courseToUpdate = new Course(id, name, teacherId);
            string result = _courseService.ValidateUpdateCourse(courseToUpdate);

            if (result == "Updated Successfully")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 4. Helper to load Teachers into a ComboBox for the Course Form
        public void LoadTeacherSelection(ComboBox cmb)
        {
            List<Teacher> teachers = _teacherService.GetAllTeachers();
            cmb.DataSource = teachers;
            cmb.DisplayMember = "LastName"; // Shows the teacher's name in the dropdown
            cmb.ValueMember = "TeacherId";  // Stores the ID behind the scenes
        }
    }
}
