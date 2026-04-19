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
    internal class IncomeTransactionController
    {
        private readonly IncomeTransactionService _incomeService = new IncomeTransactionService();
        private readonly StudentService _studentService = new StudentService();
        private readonly FundCategoryService _fundService = new FundCategoryService();

        // 1. Refresh the DataGridView with all income records
        public void LoadIncomeGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _incomeService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Handle adding a new Income record
        public bool RecordIncome(int fundId, int transTypeId, int studentId, int violationId, decimal amount, string remarks)
        {
            IncomeTransaction income = new IncomeTransaction
            {
                FundId = fundId,
                TransactionTypeId = transTypeId, // e.g., 1 for 'INCOME'
                StudentId = studentId,
                StudentViolationId = violationId, // Can be 0 if not from a violation
                Amount = amount,
                Remarks = remarks,
                TransactionDate = DateTime.Now
            };

            string result = _incomeService.ValidateAndAddIncome(income);

            if (result == "Income recorded successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Delete an Income record
        public bool RemoveIncome(int id)
        {
            IncomeTransaction income = new IncomeTransaction { IncomeTransactionId = id };
            string result = _incomeService.ValidateAndDeleteIncome(income);

            if (result == "Transaction deleted.") return true;

            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // 4. Populate Form Pickers (Students and Funds)
        public void SetupPickers(ComboBox cmbStudents, ComboBox cmbFunds)
        {
            // Load Students
            cmbStudents.DataSource = _studentService.GetStudents();
            cmbStudents.DisplayMember = "LastName";
            cmbStudents.ValueMember = "StudentId";

            // Load Funds
            cmbFunds.DataSource = _fundService.GetList();
            cmbFunds.DisplayMember = "FundName";
            cmbFunds.ValueMember = "FundId";
        }
    }
}
