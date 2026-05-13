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
    internal class StudentViolationContoller
    {

        private readonly StudentViolationService _violationService = new StudentViolationService();
        private readonly StudentService _studentService = new StudentService();

        // 1. Refresh DataGridView with all violations
        public void LoadViolationGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _violationService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Handle adding a new violation
        public bool AddViolation(int studentId, int typeId, DateTime date, string status = "UNPAID")
        {
            StudentViolation violation = new StudentViolation
            {
                StudentId = studentId,
                ViolationTypeId = typeId,
                DateIssued = date,
                Status = status
            };

            string result = _violationService.RecordViolation(violation);

            if (result == "Violation successfully recorded.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Update an existing violation (e.g., changing status to 'PAID')
        public bool EditViolation(int id, int studentId, int typeId, DateTime date, string status)
        {
            StudentViolation violation = new StudentViolation(id, studentId, typeId, date, status);
            string result = _violationService.UpdateViolation(violation);

            if (result == "Updated successfully.") return true;

            MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // 4. Delete a violation
        public bool RemoveViolation(int id)
        {
            string result = _violationService.DeleteViolation(id);
            if (result == "Violation deleted.") return true;

            MessageBox.Show(result, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // 5. Helper to load Students for selection
        public void LoadStudentPicker(ComboBox cmb)
        {
            cmb.DataSource = _studentService.GetStudents();
            cmb.DisplayMember = "LastName";
            cmb.ValueMember = "StudentId";
        }


    }
}
