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
    internal class Expense_Transaction_Dao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddExpenseTransaction(Expense_Transaction expense_Transaction)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO expense_transaction(fund_id, transaction_type_id, student_id, amount, transaction_date, remarks) VALUES (@Fund, @TransactionTypeId, @StudentId, @Amount, @TransactionDate, @Remarks)", dbConn.getconnection);
                command.Parameters.AddWithValue("@Fund", expense_Transaction.FundId);
                command.Parameters.AddWithValue("@TransactionTypeId", expense_Transaction.TransactionTypeId);
                command.Parameters.AddWithValue("@StudentId", expense_Transaction.StudentId);
                command.Parameters.AddWithValue("@Amount", expense_Transaction.Amount);
                command.Parameters.AddWithValue("@TransactionDate", expense_Transaction.TransactionDate);
                command.Parameters.AddWithValue("@Remarks", expense_Transaction.Remarks);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Expense transaction added successfully.");
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool UpdateExpenseTransaction(Expense_Transaction expense_Transaction)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE expense_transaction SET fund_id = @Fund, transaction_type_id = @TransactionTypeId, student_id = @StudentId, amount = @Amount, transaction_date = @TransactionDate, remarks = @Remarks WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@Fund", expense_Transaction.FundId);
                command.Parameters.AddWithValue("@TransactionTypeId", expense_Transaction.TransactionTypeId);
                command.Parameters.AddWithValue("@StudentId", expense_Transaction.StudentId);
                command.Parameters.AddWithValue("@Amount", expense_Transaction.Amount);
                command.Parameters.AddWithValue("@TransactionDate", expense_Transaction.TransactionDate);
                command.Parameters.AddWithValue("@Remarks", expense_Transaction.Remarks);
                command.Parameters.AddWithValue("@Id", expense_Transaction.ExpenseTransactionId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Expense transaction updated successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool DeleteExpenseTransaction(int expenseTransactionId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM expense_transaction WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@Id", expenseTransactionId);
                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Expense transaction deleted successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public Expense_Transaction GetExpenseTransactionById(int expenseTransactionId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM expense_transaction WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@Id", expenseTransactionId);

                dbConn.openConnect();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Expense_Transaction expense_Transaction = new Expense_Transaction
                    {
                        ExpenseTransactionId = reader.GetInt32("expense_transaction_id"),
                        FundId = reader.GetInt32("fund_id"),
                        TransactionTypeId = reader.GetInt32("transaction_type_id"),
                        StudentId = reader.GetInt32("student_id"),
                        Amount = reader.GetDecimal("amount"),
                        TransactionDate = reader.GetDateTime("transaction_date"),
                        Remarks = reader.GetString("remarks")
                    };
                    dbConn.closeConnect();
                    MessageBox.Show($"Expense transaction found: {expense_Transaction.ExpenseTransactionId}");
                    return expense_Transaction;
                }
               
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return null;
        }


        public List<Expense_Transaction> GetAllExpenseTransactions()
        {
            List<Expense_Transaction> expenseTransactions = new List<Expense_Transaction>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM expense_transaction", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Expense_Transaction expense_Transaction = new Expense_Transaction
                    {
                        ExpenseTransactionId = reader.GetInt32("id"),
                        FundId = reader.GetInt32("fund_id"),
                        TransactionTypeId = reader.GetInt32("transaction_type_id"),
                        StudentId = reader.GetInt32("student_id"),
                        Amount = reader.GetDecimal("amount"),
                        TransactionDate = reader.GetDateTime("transaction_date"),
                        Remarks = reader.GetString("remarks")
                    };
                    expenseTransactions.Add(expense_Transaction);
                }
                dbConn.closeConnect();
                MessageBox.Show($"Total expense transactions found: {expenseTransactions.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return expenseTransactions;
        }






    }
}
