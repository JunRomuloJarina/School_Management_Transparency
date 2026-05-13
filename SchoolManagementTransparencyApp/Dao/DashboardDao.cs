using MySql.Data.MySqlClient;
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

        public decimal GetGrandTotalUnpaidBalances()
        {
            decimal totalBalance = 0;
            try
            {
                dbConn.openConnect();

                // This query sums up every individual fee tied to an 'UNPAID' status
                // If 3 students each owe 50, this returns 150
                string query = @"
            SELECT COALESCE(SUM(vt.fee), 0) 
            FROM student_violation sv
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            WHERE sv.status = 'UNPAID'";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);

                // ExecuteScalar is perfect here because we only need one number
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    totalBalance = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                // Manual error feedback as per your coding style
                MessageBox.Show("Error calculating grand total: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return totalBalance;
        }

        public int GetTotalViolationCount()
        {
            int totalCount = 0;
            try
            {
                dbConn.openConnect();

                // Simple count of all records in the violation table
                string query = "SELECT COUNT(*) FROM student_violation";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                totalCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Consistent with your manual error feedback style
                MessageBox.Show("Error counting total violations: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return totalCount;
        }

        public decimal GetTotalPenaltyAmount()
        {
            decimal totalPenalty = 0;
            try
            {
                dbConn.openConnect();

                // This calculates the sum of all fees in the student_violation table
                string query = @"
            SELECT COALESCE(SUM(vt.fee), 0) 
            FROM student_violation sv
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    totalPenalty = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total penalty: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return totalPenalty;
        }


        // Method 1: Count how many unique students have at least one UNPAID violation
        public int GetCountOfStudentsWithUnpaidBalance()
        {
            int studentCount = 0;
            try
            {
                dbConn.openConnect();
                // DISTINCT ensures we count the student only once, even if they have 5 unpaid violations
                string query = "SELECT COUNT(DISTINCT student_id) FROM student_violation WHERE status = 'UNPAID'";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                studentCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { MessageBox.Show("Error counting debtors: " + ex.Message); }
            finally { dbConn.closeConnect(); }
            return studentCount;
        }

        // Method 2: Sum the total value of EVERY violation ever recorded (Grand Total Money)
        public decimal GetTotalPenaltyValueAllTime()
        {
            decimal totalValue = 0;
            try
            {
                dbConn.openConnect();
                // Sums every fee from the violation_type table linked to the violation records
                string query = @"
            SELECT COALESCE(SUM(vt.fee), 0) 
            FROM student_violation sv
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalValue = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error calculating total value: " + ex.Message); }
            finally { dbConn.closeConnect(); }
            return totalValue;
        }

        public decimal GetTotalOutstandingBalance()
        {
            decimal outstanding = 0;
            try
            {
                dbConn.openConnect();

                string query = @"
            SELECT COALESCE(SUM(vt.fee), 0) 
            FROM student_violation sv
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            WHERE sv.status = 'UNPAID'";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    outstanding = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating outstanding balance: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return outstanding;
        }

        public DataTable GetTopUnpaidStudents()
        {
            // We group by student to see who has the most 'UNPAID' counts
            string query = @"SELECT 
                        CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name', 
                        COUNT(sv.student_violation_id) AS 'Unpaid Records',
                        SUM(vt.fee) AS 'Total Debt'
                     FROM student s
                     JOIN student_violation sv ON s.student_id = sv.student_id
                     JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                     WHERE sv.status = 'UNPAID'
                     GROUP BY s.student_id
                     ORDER BY COUNT(sv.student_violation_id) DESC
                     LIMIT 5;"; // Just the top 5 for the home dashboard

            DataTable dt = new DataTable();
            try
            {
                dbConn.openConnect();
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbConn.getconnection);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Error: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }

    }
}
