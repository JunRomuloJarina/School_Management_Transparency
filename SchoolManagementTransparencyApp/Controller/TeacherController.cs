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
    internal class TeacherController
    {
        private readonly TeacherService _teacherService = new TeacherService();

        // 1. Refresh DataGridView with all teachers
        public void LoadTeacherGrid(DataGridView dgv)
        {
            try
            {
                // Unbind and Rebind to ensure the UI refreshes correctly
                dgv.DataSource = null;
                List<Teacher> teachers = _teacherService.GetAllTeachers();
                dgv.DataSource = teachers;

                // Optional: Column Formatting
                if (dgv.Columns["TeacherId"] != null) dgv.Columns["TeacherId"].HeaderText = "ID";
                if (dgv.Columns["FirstName"] != null) dgv.Columns["FirstName"].HeaderText = "First Name";
                if (dgv.Columns["LastName"] != null) dgv.Columns["LastName"].HeaderText = "Last Name";
                if (dgv.Columns["ContactNumber"] != null) dgv.Columns["ContactNumber"].HeaderText = "Contact No.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Add New Teacher
        public bool HandleAddTeacher(string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact)
        {
            Teacher newTeacher = new Teacher(fname, mname, lname, age, gender, address, dob, contact);
            string result = _teacherService.CreateTeacher(newTeacher);

            if (result == "Teacher added successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Update Existing Teacher
        public bool HandleUpdateTeacher(int id, string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact)
        {
            Teacher updatedTeacher = new Teacher(id, fname, mname, lname, age, gender, address, dob, contact);
            string result = _teacherService.UpdateTeacherProfile(updatedTeacher);

            if (result == "Teacher record updated.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4. Delete Teacher
        public bool HandleDeleteTeacher(int id)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string result = _teacherService.DeleteTeacherAccount(id);
                if (result == "Teacher removed successfully.")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(result, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

    }
}
