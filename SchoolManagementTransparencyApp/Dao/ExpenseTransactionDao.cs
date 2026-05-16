using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class ExpenseTransactionDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddExpenseTransaction(ExpenseTransaction expense_Transaction)
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool UpdateExpenseTransaction(ExpenseTransaction expense_Transaction)
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
                Console.WriteLine(ex.Message    );
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public ExpenseTransaction GetExpenseTransactionById(int expenseTransactionId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM expense_transaction WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@Id", expenseTransactionId);

                dbConn.openConnect();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExpenseTransaction expense_Transaction = new ExpenseTransaction
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return null;
        }


        public List<ExpenseTransaction> GetAllExpenseTransactions()
        {
            List<ExpenseTransaction> expenseTransactions = new List<ExpenseTransaction>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM expense_transaction", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExpenseTransaction expense_Transaction = new ExpenseTransaction
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return expenseTransactions;
        }



        public decimal GetTotalExpensesByFund(int fundId)
        {
            decimal total = 0;
            try
            {
                // SQL: Sum all amounts for this specific fund
                string sql = "SELECT SUM(amount) FROM expense_transaction WHERE fund_id = @FundId";
                MySqlCommand command = new MySqlCommand(sql, dbConn.getconnection);
                command.Parameters.AddWithValue("@FundId", fundId);

                dbConn.openConnect();
                object result = command.ExecuteScalar(); // ExecuteScalar is faster for single values

                if (result != null && result != DBNull.Value)
                {
                    total = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { dbConn.closeConnect(); }
            return total;
        }


        // 1. Load Funds for the ComboBox
        public DataTable GetFundCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                // Matches your 'fund_category' table
                string query = "SELECT fund_id, fund_name FROM fund_category ORDER BY fund_name ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message    );
            }
            return dt;
        }

        //// 2. Record Expense Transaction
        //public bool AddExpenseTransaction(int fundId, decimal amount, string remarks, DateTime date)
        //{
        //    try
        //    {
        //        dbConn.openConnect();
        //        // Matches 'expense_transaction' columns
        //        // Note: transaction_type_id should correspond to 'Expense' in your transaction_type table
        //        string query = "INSERT INTO expense_transaction (fund_id, transaction_type_id, amount, transaction_date, remarks) " +
        //                       "VALUES (@fundId, @typeId, @amt, @date, @rem)";

        //        MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
        //        cmd.Parameters.AddWithValue("@fundId", fundId);
        //        cmd.Parameters.AddWithValue("@typeId", 2); // Assuming 2 is the ID for 'Expense'
        //        cmd.Parameters.AddWithValue("@amt", amount);
        //        cmd.Parameters.AddWithValue("@date", date);
        //        cmd.Parameters.AddWithValue("@rem", remarks);

        //        if (cmd.ExecuteNonQuery() == 1)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Database Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        dbConn.closeConnect();
        //    }
        //    return false;
        //}

        public DataTable GetFundBalancesTables()
        {
            DataTable dt = new DataTable();
            try
            {
                // Aliasing columns for professional look in the Grid
                string query = "SELECT fund_id AS 'ID', fund_name AS 'Fund Category', " +
                               "available_balance AS 'Available Money' FROM fund_category " +
                               "ORDER BY fund_name ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        // 1. Calculate Real-time Balance for each Fund
        // This joins income and expense tables to find the 'Available Money'
        public DataTable GetFundBalancesTable()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                    SELECT 
                        f.fund_id AS 'ID', 
                        f.fund_name AS 'Fund Category',
                        (IFNULL((SELECT SUM(amount) FROM income_transaction WHERE fund_id = f.fund_id), 0) - 
                         IFNULL((SELECT SUM(amount) FROM expense_transaction WHERE fund_id = f.fund_id), 0)) AS 'Available Money'
                    FROM fund_category f";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return dt;
        }

        // 2. Fetch Funds for the ComboBox
        public DataTable GetFundCategoriess()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT fund_id, fund_name FROM fund_category ORDER BY fund_name ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message ); }
            return dt;
        }

        // 3. Record the Spending
        public bool AddExpenseTransactions(int fundId, decimal amount, string remarks, DateTime date)
        {
            try
            {
                dbConn.openConnect();
                // transaction_type_id 2 is 'EXPENSE' based on your school_db_transaction_type.sql
                string query = "INSERT INTO expense_transaction (fund_id, transaction_type_id, amount, transaction_date, remarks, student_id) " +
                               "VALUES (@fid, 2, @amt, @date, @rem, NULL)";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@fid", fundId);
                cmd.Parameters.AddWithValue("@amt", amount);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@rem", remarks);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
            finally { dbConn.closeConnect(); }
        }

        // 4. Get Detailed Expense History for the second DataGridView
        public DataTable GetExpenseHistoryTable()
        {
            DataTable dt = new DataTable();
            try
            {
                // Joining tables to get Fund Name and Student Name
                string query = @"
            SELECT 
                e.expense_transaction_id AS 'ID',
                f.fund_name AS 'Fund Category',
                e.amount AS 'Amount Spent',
                e.transaction_date AS 'Date',
                e.remarks AS 'Description',
                IF(e.student_id IS NULL, 'General/School', CONCAT(s.last_name, ', ', s.first_name)) AS 'Recipient'
            FROM expense_transaction e
            INNER JOIN fund_category f ON e.fund_id = f.fund_id
            LEFT JOIN student s ON e.student_id = s.student_id
            ORDER BY e.transaction_date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        // Get the exact real-time balance for a specific fund ID
        public decimal GetSingleFundBalance(int fundId)
        {
            decimal balance = 0;
            try
            {
                dbConn.openConnect();

                // FIX: Added 'FROM fund_category f' so @fid is only bound ONCE. 
                // This stops the MySQL driver bug from wiping out the expense calculation!
                string query = @"
            SELECT 
                (IFNULL((SELECT SUM(amount) FROM income_transaction WHERE fund_id = f.fund_id), 0) - 
                 IFNULL((SELECT SUM(amount) FROM expense_transaction WHERE fund_id = f.fund_id), 0)) AS Balance
            FROM fund_category f
            WHERE f.fund_id = @fid";

                using (MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection))
                {
                    cmd.Parameters.AddWithValue("@fid", fundId);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        balance = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return balance;
        }

    }
}
