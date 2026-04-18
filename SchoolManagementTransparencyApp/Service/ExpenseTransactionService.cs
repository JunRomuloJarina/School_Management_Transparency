using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class ExpenseTransactionService
    {
        private readonly ExpenseTransactionDao _expenseDao = new ExpenseTransactionDao();
        private readonly IncomeTransactionDao _incomeDao = new IncomeTransactionDao();
        public string ValidateAndAddExpense(ExpenseTransaction expense)
        {
            if (expense == null) return "Transaction data is null.";
            if (expense.Amount <= 0) return "Amount must be greater than zero.";
            if (expense.FundId <= 0) return "Please select a valid fund category.";
            if (expense.StudentId <= 0) return "A student (payee/requester) must be assigned.";

            // Default date if none provided
            if (expense.TransactionDate == DateTime.MinValue)
                expense.TransactionDate = DateTime.Now;

            bool success = _expenseDao.AddExpenseTransaction(expense);
            return success ? "Expense recorded successfully." : "Failed to record expense.";
        }

        public string ValidateAndUpdateExpense(ExpenseTransaction expense)
        {
            if (expense.ExpenseTransactionId <= 0) return "Invalid Transaction ID.";
            if (expense.Amount <= 0) return "Amount cannot be zero or negative.";

            bool success = _expenseDao.UpdateExpenseTransaction(expense);
            return success ? "Transaction updated." : "Update failed.";
        }

        public string ValidateAndDeleteExpense(int id)
        {
            if (id <= 0) return "Invalid ID.";
            return _expenseDao.DeleteExpenseTransaction(id) ? "Deleted successfully." : "Delete failed.";
        }

        public List<ExpenseTransaction> GetAll() => _expenseDao.GetAllExpenseTransactions();

        public ExpenseTransaction GetById(int id) => _expenseDao.GetExpenseTransactionById(id);

        public decimal GetRemainingFundBalance(int fundId)
        {
            // Logic: Total Income for Fund - Total Expenses for Fund
            // This is the core of "Transparency"
            decimal totalIncome = _incomeDao.GetTotalIncomeByFund(fundId);
            decimal totalExpenses = _expenseDao.GetTotalExpensesByFund(fundId);
            return totalIncome - totalExpenses;
        }

        public string ProcessSafeExpense(ExpenseTransaction expense)
        {
            // 1. Basic Validation
            if (expense.Amount <= 0) return "Amount must be positive.";

            // 2. Calculate Real-Time Balance
            decimal totalIncome = _incomeDao.GetTotalIncomeByFund(expense.FundId);
            decimal totalExpenses = _expenseDao.GetTotalExpensesByFund(expense.FundId);
            decimal currentBalance = totalIncome - totalExpenses;

            // 3. Transparency Check: Can we afford this?
            if (expense.Amount > currentBalance)
            {
                return $"Denied: Insufficient Funds. Available: {currentBalance:N2}, Request: {expense.Amount:N2}";
            }

            // 4. If OK, Save to DB
            return _expenseDao.AddExpenseTransaction(expense)
                ? "Transaction Successful. Balance Updated."
                : "Database Error.";
        }
    }
}
