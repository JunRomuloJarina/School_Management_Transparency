using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Income_Transaction
    {

        public int IncomeTransactionId { get; set; }
        public int FundId { get; set; }
        public int TransactionTypeId { get; set; }
        public int StudentId { get; set; }
        public int StudentViolationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Remarks { get; set; }

        // 1. Default Constructor
        public Income_Transaction()
        {
        }

        // 2. Parameterized Constructor
        public Income_Transaction(int incomeTransactionId, int fundId, int transactionTypeId, int studentId, int studentViolationId, decimal amount, DateTime transactionDate, string remarks)
        {
            IncomeTransactionId = incomeTransactionId;
            FundId = fundId;
            TransactionTypeId = transactionTypeId;
            StudentId = studentId;
            StudentViolationId = studentViolationId;
            Amount = amount;
            TransactionDate = transactionDate;
            Remarks = remarks;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"[ID: {IncomeTransactionId}] Date: {TransactionDate.ToShortDateString()} | Amount: {Amount:C} | Remarks: {Remarks}";
        }
    }
}
