using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class IncomeTransactionDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddIncomeTransaction(IncomeTransaction income_Transaction)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO income_transaction(fund_id, transaction_type_id, student_id, student_violation_id, amount, transaction_date, remarks) VALUES(@FundId, @TransactionTypeId, @StudentId, @StudentViolationId, @Amount, @TransactionDate, @Remarks)", dbConn.getconnection); command.Parameters.AddWithValue("@FundId", income_Transaction.FundId);
                command.Parameters.AddWithValue("@TransactionTypeId", income_Transaction.TransactionTypeId);
                command.Parameters.AddWithValue("@StudentId", income_Transaction.StudentId);
                command.Parameters.AddWithValue("@StudentViolationId", income_Transaction.StudentViolationId);
                command.Parameters.AddWithValue("@Amount", income_Transaction.Amount);
                command.Parameters.AddWithValue("@TransactionDate", income_Transaction.TransactionDate);
                command.Parameters.AddWithValue("@Remarks", income_Transaction.Remarks);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Income transaction added successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message    );
            }
            return false;
        }

        public bool DeleteIncomeTransaction(IncomeTransaction income_Transaction)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM income_transaction WHERE income_transaction_id = @IncomeTransactionId", dbConn.getconnection);
                command.Parameters.AddWithValue("@IncomeTransactionId", income_Transaction.IncomeTransactionId);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Income transaction deleted successfully.");
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public List<IncomeTransaction> GetAllIncomeTransactions()
        {
            List<IncomeTransaction> incomeTransactions = new List<IncomeTransaction>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM income_transaction", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IncomeTransaction incomeTransaction = new IncomeTransaction
                    {
                        IncomeTransactionId = reader.GetInt32("income_transaction_id"),
                        FundId = reader.GetInt32("fund_id"),
                        TransactionTypeId = reader.GetInt32("transaction_type_id"),
                        StudentId = reader.GetInt32("student_id"),
                        StudentViolationId = reader.GetInt32("student_violation_id"),
                        Amount = reader.GetDecimal("amount"),
                        TransactionDate = reader.GetDateTime("transaction_date"),
                        Remarks = reader.GetString("remarks")
                    };
                    incomeTransactions.Add(incomeTransaction);
                }
                dbConn.closeConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return incomeTransactions;
        }


        public decimal GetTotalIncomeByFund(int fundId)
        {
            decimal total = 0;
            try
            {
                string sql = "SELECT SUM(amount) FROM income_transaction WHERE fund_id = @FundId";
                MySqlCommand command = new MySqlCommand(sql, dbConn.getconnection);
                command.Parameters.AddWithValue("@FundId", fundId);
                dbConn.openConnect();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value) total = Convert.ToDecimal(result);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { dbConn.closeConnect(); }
            return total;
        }



    }
}
