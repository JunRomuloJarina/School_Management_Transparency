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
    internal class ExpenseTransactionController
    {

        private readonly ExpenseTransactionService _expenseService = new ExpenseTransactionService();
        private readonly StudentService _studentService = new StudentService();

        // 1. Refresh the DataGridView with all expenses
        public void LoadExpensesIntoGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _expenseService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 2. Add an Expense with a Real-Time Balance Check
        // This is the "Brain" of your transparency logic
        public bool RecordNewExpense(int fundId, int typeId, int studentId, decimal amount, string remarks)
        {
            ExpenseTransaction newExpense = new ExpenseTransaction
            {
                FundId = fundId,
                TransactionTypeId = typeId, // Usually 2 for 'EXPENSE'
                StudentId = studentId,
                Amount = amount,
                Remarks = remarks,
                TransactionDate = DateTime.Now
            };

            // We use ProcessSafeExpense to prevent overspending
            string result = _expenseService.ProcessSafeExpense(newExpense);

            if (result == "Transaction Successful. Balance Updated.")
            {
                return true;
            }
            else
            {
                // Shows "Denied: Insufficient Funds" or validation errors
                MessageBox.Show(result, "Financial Guard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 3. Helper to show current available cash for a specific fund
        public decimal GetAvailableBudget(int fundId)
        {
            return _expenseService.GetRemainingFundBalance(fundId);
        }

        // 4. Update an existing record
        public bool UpdateExpense(int id, int fundId, int typeId, int studentId, decimal amount, string remarks)
        {
            ExpenseTransaction expense = new ExpenseTransaction(fundId, typeId, studentId, amount, remarks);
            expense.ExpenseTransactionId = id;

            string result = _expenseService.ValidateAndUpdateExpense(expense);
            return result == "Transaction updated.";
        }

        // 5. Load Students into a ComboBox (The Payee/Requester)
        public void LoadStudentList(ComboBox cmb)
        {
            cmb.DataSource = _studentService.GetStudents();
            cmb.DisplayMember = "LastName";
            cmb.ValueMember = "StudentId";
        }
    }
}
