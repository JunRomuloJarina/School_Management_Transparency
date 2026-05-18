//using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
//using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
//using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace School_Management_Transparency.SchoolManagementTransparencyApp.Controller
//{
//    internal class StudentController
//    {
//        private readonly StudentService _studentService = new StudentService();

//        // 1. Refresh DataGridView with Student List
//        public void LoadStudentGrid(DataGridView dgv)
//        {
//            try
//            {
//                dgv.DataSource = null;
//                dgv.DataSource = _studentService.GetStudents();

//                // Optional: Hide internal IDs if preferred
//                if (dgv.Columns["UserId"] != null) dgv.Columns["UserId"].Visible = false;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Controller Error: " + ex.Message);
//            }
//        }

//        // 2. Add New Student
//        public bool AddNewStudent(string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact, int userId)
//        {
//            Student student = new Student
//            {
//                FirstName = fname,
//                MiddleName = mname,
//                LastName = lname,
//                Age = age,
//                Gender = gender,
//                Address = address,
//                DateOfBirth = dob,
//                ContactNumber = contact,
//                UserId = userId // Linked to the system user account
//            };

//            string result = _studentService.SaveStudent(student);

//            if (result == "Student registered successfully.")
//            {
//                return true;
//            }
//            else
//            {
//                MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }
//        }

//        // 3. Update Existing Student
//        public bool UpdateExistingStudent(int studentId, string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact)
//        {
//            Student student = new Student
//            {
//                StudentId = studentId,
//                FirstName = fname,
//                MiddleName = mname,
//                LastName = lname,
//                Age = age,
//                Gender = gender,
//                Address = address,
//                DateOfBirth = dob,
//                ContactNumber = contact
//            };

//            string result = _studentService.UpdateStudentInfo(student);

//            if (result == "Student record updated.")
//            {
//                return true;
//            }
//            else
//            {
//                MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//        }

//        // 4. Delete Student
//        public bool DeleteStudent(int id)
//        {
//            // Note: Service expects a Student object or ID based on your current code
//            // I'm creating a temporary object with just the ID
//            Student tempStudent = new Student { StudentId = id };
//            string result = _studentService.RemoveStudent(tempStudent);

//            if (result == "Student deleted.")
//            {
//                return true;
//            }
//            else
//            {
//                MessageBox.Show(result, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//        }

//        // Method to get the profile of the currently logged-in student
//        public Student GetCurrentStudentProfile()
//        {
//            try
//            {
//                // 1. Pull the globally preserved UserID directly from static memory
//                int currentUserId = Util.UserSession.CurrentUserId;

//                if (currentUserId <= 0)
//                {
//                    MessageBox.Show("Active session is invalid or has timed out.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return null;
//                }

//                // 2. Fetch the student record linked to that UserID via LINQ sequence mapping
//                Student currentStudent = _studentService.GetStudentByUserId(currentUserId);

//                if (currentStudent == null)
//                {
//                    MessageBox.Show($"Profile matching User ID [{currentUserId}] not found in database registry.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }

//                return currentStudent;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Profile Controller Error: " + ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return null;
//            }
//        }

//        public void LoadViolationGrid(DataGridView dgv)
//        {
//            try
//            {
//                dgv.DataSource = null;
//                // Fetch the data from service
//                var data = _studentService.GetViolationLogs();

//                if (data != null && data.Count > 0)
//                {
//                    dgv.DataSource = data;

//                    // Optional: Make the columns look nice
//                    if (dgv.Columns["StudentName"] != null) dgv.Columns["StudentName"].HeaderText = "Student Name";
//                    if (dgv.Columns["ViolationType"] != null) dgv.Columns["ViolationType"].HeaderText = "Violation Committed";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Controller Error: " + ex.Message);
//            }
//        }

//        public void LoadStudentManagementGrid(DataGridView dgv)
//        {
//            StudentDao dao = new StudentDao();
//            dgv.DataSource = dao.GetStudentWithAccountDetails();

//            // Hide the User ID from the grid (we only need it for the logic)
//            if (dgv.Columns["User ID"] != null) dgv.Columns["User ID"].Visible = false;

//            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//        }

//        public void LoadDebtGrid(DataGridView dgv, int studentId, string searchKeyword = "")
//        {
//            try
//            {
//                dgv.DataSource = null;
//                dgv.DataSource = _studentService.GetDebtRecords(studentId, searchKeyword);
//                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Controller Error loading debts: " + ex.Message);
//            }
//        }
//    }
//}


using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Controller
{
    internal class StudentController
    {
        private readonly StudentService _studentService = new StudentService();

        public void LoadStudentGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _studentService.GetStudents();

                if (dgv.Columns["UserId"] != null) dgv.Columns["UserId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

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
                UserId = userId
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

        public bool DeleteStudent(int id)
        {
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

        public Student GetCurrentStudentProfile()
        {
            try
            {
                int currentUserId = Util.UserSession.CurrentUserId;

                if (currentUserId <= 0)
                {
                    MessageBox.Show("Active session is invalid or has timed out.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                Student currentStudent = _studentService.GetStudentByUserId(currentUserId);

                if (currentStudent == null)
                {
                    MessageBox.Show($"Profile matching User ID [{currentUserId}] not found.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return currentStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Controller Error: " + ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void LoadViolationGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                var data = _studentService.GetViolationLogs();

                if (data != null && data.Count > 0)
                {
                    dgv.DataSource = data;
                    if (dgv.Columns["StudentName"] != null) dgv.Columns["StudentName"].HeaderText = "Student Name";
                    if (dgv.Columns["ViolationType"] != null) dgv.Columns["ViolationType"].HeaderText = "Violation Committed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        public void LoadStudentManagementGrid(DataGridView dgv)
        {
            StudentDao dao = new StudentDao();
            dgv.DataSource = dao.GetStudentWithAccountDetails();

            if (dgv.Columns["User ID"] != null) dgv.Columns["User ID"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadDebtGrid(DataGridView dgv, int studentId, string searchKeyword = "")
        {
            try
            {
                dgv.DataSource = null;
                DataTable dt = _studentService.GetDebtRecords(studentId, searchKeyword);

                if (dt != null)
                {
                    dgv.DataSource = dt;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error loading debts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPaymentHistoryGrid(DataGridView dgv, int studentId, string searchKeyword = "")
        {
            try
            {
                dgv.DataSource = null;
                DataTable dt = _studentService.GetPaymentHistoryRecords(studentId, searchKeyword);

                if (dt != null)
                {
                    dgv.DataSource = dt;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error loading payment history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadExpenseTransparencyGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                DataTable dt = _studentService.GetPublicExpenseTransparency();

                if (dt != null)
                {
                    dgv.DataSource = dt;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgv.Columns["Amount Spent"] != null)
                    {
                        dgv.Columns["Amount Spent"].DefaultCellStyle.Format = "C2";
                        dgv.Columns["Amount Spent"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Expense Binding Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}