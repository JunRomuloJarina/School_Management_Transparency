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
    internal class StudentController
    {
        private readonly StudentService _studentService = new StudentService();

        // 1. Refresh DataGridView with Student List
        public void LoadStudentGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _studentService.GetStudents();

                // Optional: Hide internal IDs if preferred
                if (dgv.Columns["UserId"] != null) dgv.Columns["UserId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Add New Student
        public bool AddNewStudent(string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact, int userId)
        {
            Student student = new Student
            {
                FirstName = fname,
                MiddleName = mname,
                LastName = lname,
                Age = age,
                Gender = gender,
                Address = address,
                DateOfBirth = dob,
                ContactNumber = contact,
                UserId = userId // Linked to the system user account
            };

            string result = _studentService.SaveStudent(student);

            if (result == "Student registered successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Update Existing Student
        public bool UpdateExistingStudent(int studentId, string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact)
        {
            Student student = new Student
            {
                StudentId = studentId,
                FirstName = fname,
                MiddleName = mname,
                LastName = lname,
                Age = age,
                Gender = gender,
                Address = address,
                DateOfBirth = dob,
                ContactNumber = contact
            };

            string result = _studentService.UpdateStudentInfo(student);

            if (result == "Student record updated.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4. Delete Student
        public bool DeleteStudent(int id)
        {
            // Note: Service expects a Student object or ID based on your current code
            // I'm creating a temporary object with just the ID
            Student tempStudent = new Student { StudentId = id };
            string result = _studentService.RemoveStudent(tempStudent);

            if (result == "Student deleted.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to get the profile of the currently logged-in student
        public Student GetCurrentStudentProfile()
        {
            try
            {
                // 1. Get the current UserID from the Account Service
                UserAccountService userAccountService = new UserAccountService();
                int currentUserId = userAccountService.GetCurrentUserId();

                // 2. Fetch the student record linked to that UserID
                Student currentStudent = _studentService.GetStudentByUserId(currentUserId);

                if (currentStudent == null)
                {
                    MessageBox.Show("Profile not found. Please contact the administrator.");
                }

                return currentStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Error: " + ex.Message);
                return null;
            }
        }

        public void LoadViolationGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                // Fetch the data from service
                var data = _studentService.GetViolationLogs();

                if (data != null && data.Count > 0)
                {
                    dgv.DataSource = data;

                    // Optional: Make the columns look nice
                    if (dgv.Columns["StudentName"] != null) dgv.Columns["StudentName"].HeaderText = "Student Name";
                    if (dgv.Columns["ViolationType"] != null) dgv.Columns["ViolationType"].HeaderText = "Violation Committed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }
    }
}
