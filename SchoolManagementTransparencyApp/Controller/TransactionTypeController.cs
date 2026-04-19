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
    internal class TransactionTypeController
    {

        private readonly TransactionTypeService _typeService = new TransactionTypeService();

        // 1. Refresh the DataGridView with all transaction types
        public void LoadTypeGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _typeService.GetAllTypes();

                // UI Formatting
                if (dgv.Columns["TransactionTypeId"] != null) dgv.Columns["TransactionTypeId"].HeaderText = "ID";
                if (dgv.Columns["TypeName"] != null) dgv.Columns["TypeName"].HeaderText = "Transaction Category";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Add New Transaction Type
        public bool AddNewType(string typeName)
        {
            TransactionType newType = new TransactionType { TypeName = typeName };
            string result = _typeService.CreateType(newType);

            if (result == "Transaction Type added successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Update Existing Type
        public bool EditType(int id, string typeName)
        {
            TransactionType typeToUpdate = new TransactionType(id, typeName);
            string result = _typeService.UpdateType(typeToUpdate);

            if (result == "Transaction Type updated.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4. Delete Type
        public bool DeleteType(int id)
        {
            string result = _typeService.RemoveType(id);
            if (result == "Transaction Type deleted.")
            {
                return true;
            }
            else
            {
                // Shows the error if the type is tied to existing transactions
                MessageBox.Show(result, "Deletion Restricted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        // 5. Helper for ComboBoxes in the Income/Expense forms
        public void LoadTypePicker(ComboBox cmb)
        {
            cmb.DataSource = _typeService.GetAllTypes();
            cmb.DisplayMember = "TypeName";
            cmb.ValueMember = "TransactionTypeId";
        }
    }
}
