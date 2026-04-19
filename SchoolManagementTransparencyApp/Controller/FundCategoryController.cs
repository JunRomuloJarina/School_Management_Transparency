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
    internal class FundCategoryController
    {

        private readonly FundCategoryService _fundService = new FundCategoryService();

        // 1. Refresh the DataGridView with all fund categories
        public void LoadFundCategoriesIntoGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _fundService.GetList();

                // Formatting for the UI
                if (dgv.Columns["FundId"] != null) dgv.Columns["FundId"].HeaderText = "ID";
                if (dgv.Columns["FundName"] != null) dgv.Columns["FundName"].HeaderText = "Category Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Handle Add Action
        public bool CreateFundCategory(string fundName)
        {
            FundCategory newFund = new FundCategory { FundName = fundName };
            string result = _fundService.ValidateAndAdd(newFund);

            if (result == "Fund Category Added Successfully!")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Handle Update Action
        public bool EditFundCategory(int id, string fundName)
        {
            FundCategory fundToUpdate = new FundCategory(id, fundName);
            string result = _fundService.ValidateAndUpdate(fundToUpdate);

            if (result == "Fund Category Updated!")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 4. Handle Delete Action
        public bool RemoveFundCategory(int id)
        {
            FundCategory fundToDelete = new FundCategory { FundId = id };
            string result = _fundService.ValidateAndDelete(fundToDelete);

            if (result == "Fund Category Removed.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
