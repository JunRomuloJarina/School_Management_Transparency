using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class DashboardDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        // Get Total Number of Students
        public int GetTotalStudentsCount()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Student", dbConn.getconnection);
                dbConn.openConnect();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch { return 0; }
            finally { dbConn.closeConnect(); }
        }

        // Get Total Funds (Sum of all Income)
        public decimal GetTotalFundsAmount()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT SUM(amount) FROM Income_Transaction", dbConn.getconnection);
                dbConn.openConnect();
                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0.00m;
            }
            catch { return 0; }
            finally { dbConn.closeConnect(); }
        }

        // Get Total Expenses (If you have an Expense table)
        public decimal GetTotalExpensesAmount()
        {
            try
            {
                // Assuming you have an Expense_Transaction table
                MySqlCommand command = new MySqlCommand("SELECT SUM(amount) FROM Expense_Transaction", dbConn.getconnection);
                dbConn.openConnect();
                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0.00m;
            }
            catch { return 0; }
            finally { dbConn.closeConnect(); }
        }
    }
}
