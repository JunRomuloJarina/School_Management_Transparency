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
    internal class ViolationTypeController
    {

        private readonly ViolationTypeService _violationService = new ViolationTypeService();

        // 1. Refresh the DataGridView with all violation types
        public void LoadViolationTypeGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _violationService.GetList();

                // Professional formatting for the grid
                if (dgv.Columns["ViolationTypeId"] != null) dgv.Columns["ViolationTypeId"].HeaderText = "ID";
                if (dgv.Columns["ViolationName"] != null) dgv.Columns["ViolationName"].HeaderText = "Violation Name";
                if (dgv.Columns["Fee"] != null) dgv.Columns["Fee"].DefaultCellStyle.Format = "C2"; // Local currency format
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Handle Add Violation Type
        public bool AddViolationType(string name, decimal fee, string category, string description)
        {
            ViolationType violation = new ViolationType
            {
                ViolationName = name,
                Fee = fee,
                Category = category,
                Description = description
            };

            string result = _violationService.CreateViolationType(violation);

            if (result == "Violation Type added successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Handle Update Violation Type
        public bool EditViolationType(int id, string name, decimal fee, string category, string description)
        {
            ViolationType violation = new ViolationType(id, name, fee, category, description);
            string result = _violationService.UpdateViolationType(violation);

            if (result == "Update successful.") return true;

            MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // 4. Handle Delete Violation Type
        public bool RemoveViolationType(int id)
        {
            string result = _violationService.DeleteViolationType(id);
            if (result == "Violation Type removed.") return true;

            // This usually triggers if a student has an existing record with this violation
            MessageBox.Show(result, "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;
        }

        // 5. Populate ComboBoxes for other forms (like StudentViolation form)
        public void SetupViolationPicker(ComboBox cmb)
        {
            cmb.DataSource = _violationService.GetList();
            cmb.DisplayMember = "ViolationName";
            cmb.ValueMember = "ViolationTypeId";
        }
    }
}
