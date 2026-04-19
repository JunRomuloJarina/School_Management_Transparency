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
    internal class EnrollmentController
    {

        private readonly EnrollmentService _enrollmentService = new EnrollmentService();
        private readonly StudentService _studentService = new StudentService();
        private readonly CourseService _courseService = new CourseService();

        // 1. Refresh the DataGridView with Enrollment Records
        public void LoadEnrollments(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _enrollmentService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Handle the Enroll Action
        public bool EnrollStudent(int studentId, int courseId)
        {
            Enrollment newEnrollment = new Enrollment(studentId, courseId);
            string result = _enrollmentService.ValidateAddEnrollment(newEnrollment);

            if (result == "Successfully enrolled student.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Enrollment Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        // 3. Handle the Remove Enrollment Action
        public bool RemoveEnrollment(int enrollmentId)
        {
            Enrollment enrollment = new Enrollment { EnrollmentId = enrollmentId };
            string result = _enrollmentService.ValidateDeleteEnrollment(enrollment);

            if (result == "Enrollment removed.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4. Helpers to fill UI ComboBoxes for selection
        public void LoadPickers(ComboBox cmbStudents, ComboBox cmbCourses)
        {
            // Load Students
            cmbStudents.DataSource = _studentService.GetStudents();
            cmbStudents.DisplayMember = "LastName"; // Or combine Names in your Model
            cmbStudents.ValueMember = "StudentId";

            // Load Courses
            cmbCourses.DataSource = _courseService.GetAllCourses();
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseId";
        }
    }
}
