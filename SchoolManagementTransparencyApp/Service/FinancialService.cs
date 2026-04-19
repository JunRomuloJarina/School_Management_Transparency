using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class FinancialService
    {
        private readonly IncomeTransactionDao _incomeDao = new IncomeTransactionDao();
        private readonly ExpenseTransactionDao _expenseDao = new ExpenseTransactionDao();

        // The core calculation that prevents corruption
        public decimal GetCurrentBalance(int fundId)
        {
            decimal income = _incomeDao.GetTotalIncomeByFund(fundId);
            decimal expense = _expenseDao.GetTotalExpensesByFund(fundId);
            return income - expense;
        }

        // Logic for safe spending
        public string ProcessExpense(ExpenseTransaction expense)
        {
            decimal availableBalance = GetCurrentBalance(expense.FundId);

            if (expense.Amount > availableBalance)
            {
                return $"Error: Insufficient funds. Available: {availableBalance:N2}, Requested: {expense.Amount:N2}";
            }

            if (_expenseDao.AddExpenseTransaction(expense))
            {
                return "Expense approved and recorded.";
            }

            return "Transaction failed at the database level.";
        }

        public List<FundBalanceReport> GetTransparencyReport()
        {
            FinancialDao financialDao = new FinancialDao();
            return financialDao.GetFundBalanceReport();
        }
    }
}
