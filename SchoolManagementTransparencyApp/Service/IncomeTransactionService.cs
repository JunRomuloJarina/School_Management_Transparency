using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class IncomeTransactionService
    {

        private readonly IncomeTransactionDao _incomeDao = new IncomeTransactionDao();

        public string ValidateAndAddIncome(IncomeTransaction income)
        {
            // 1. Basic Validation
            if (income == null) return "Transaction data is null.";
            if (income.Amount <= 0) return "Amount must be a positive number.";
            if (income.FundId <= 0) return "Please select a valid fund category.";
            if (income.StudentId <= 0) return "A student must be associated with this income.";

            // 2. Set default date if not provided
            if (income.TransactionDate == DateTime.MinValue)
                income.TransactionDate = DateTime.Now;

            // 3. Database Operation
            bool success = _incomeDao.AddIncomeTransaction(income);

            if (success)
            {
                // SPECIAL LOGIC: If this income is linked to a violation, 
                // you might want to call ViolationService here to mark it as 'PAID'.
                return "Income recorded successfully.";
            }

            return "Failed to record income transaction.";
        }

        public string ValidateAndDeleteIncome(IncomeTransaction income)
        {
            if (income == null || income.IncomeTransactionId <= 0)
                return "Invalid transaction selected for deletion.";

            return _incomeDao.DeleteIncomeTransaction(income)
                ? "Transaction deleted."
                : "Delete operation failed.";
        }

        public List<IncomeTransaction> GetAll() => _incomeDao.GetAllIncomeTransactions();

        public decimal GetFundTotal(int fundId) => _incomeDao.GetTotalIncomeByFund(fundId);
    }
}
