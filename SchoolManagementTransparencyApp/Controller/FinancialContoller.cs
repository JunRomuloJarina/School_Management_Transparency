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
    internal class FinancialContoller
    {

        private readonly FinancialService _financialService = new FinancialService();

        // 1. Load the Transparency Report into a DataGridView
        public void DisplayTransparencyReport(DataGridView dgv)
        {
            try
            {
                List<FundBalanceReport> reports = _financialService.GetTransparencyReport();

                // Binding the list to the GridView
                dgv.DataSource = null;
                dgv.DataSource = reports;

                // Basic formatting for the columns
                if (dgv.Columns["FundName"] != null) dgv.Columns["FundName"].HeaderText = "Fund Category";
                if (dgv.Columns["TotalIncome"] != null) dgv.Columns["TotalIncome"].HeaderText = "Total Income";
                if (dgv.Columns["TotalExpenses"] != null) dgv.Columns["TotalExpenses"].HeaderText = "Total Expenses";
                if (dgv.Columns["CurrentBalance"] != null) dgv.Columns["CurrentBalance"].HeaderText = "Available Balance";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Get a quick balance for a specific fund (useful for labels)
        public string GetFormattedBalance(int fundId)
        {
            decimal balance = _financialService.GetCurrentBalance(fundId);
            return $"₱{balance:N2}";
        }

        // 3. Logic to handle the result of an expense request
        // Call this from your "Add Expense" Form
        public bool RequestExpense(ExpenseTransaction expense)
        {
            string result = _financialService.ProcessExpense(expense);

            if (result == "Expense approved and recorded.")
            {
                MessageBox.Show(result, "Transparency System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                // Shows "Error: Insufficient funds" or database errors
                MessageBox.Show(result, "Transaction Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
