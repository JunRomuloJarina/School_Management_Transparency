using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class ExpenseTransaction
    {
        // Properties
        public int ExpenseTransactionId { get; set; }
        public int FundId { get; set; }
        public int TransactionTypeId { get; set; }
        public int StudentId { get; set; } 
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Remarks { get; set; }

        // 1. Default Constructor
        public ExpenseTransaction()
        {
            TransactionDate = DateTime.Now;
            Remarks = string.Empty;
        }

        // 2. Parameterized Constructor (Useful for manual entry or DB mapping)
        public ExpenseTransaction(int fundId, int transTypeId, int studentId, decimal amount, string remarks)
        {
            FundId = fundId;
            TransactionTypeId = transTypeId;
            StudentId = studentId;
            Amount = amount;
            Remarks = remarks;
            TransactionDate = DateTime.Now;
        }

        // 3. Overridden ToString Method
        public override string ToString()
        {
            // The :N2 format ensures the amount shows 2 decimal places
            return $"[{TransactionDate:MM/dd/yyyy}] ID: {ExpenseTransactionId} | Amount: {Amount:N2} | Note: {Remarks}";
        }
    }
}
