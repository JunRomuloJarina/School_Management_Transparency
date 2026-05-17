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
    internal class AdminDao
    {
        private readonly DatabaseConnection dbConn = new DatabaseConnection();

        public DataTable GetOverallFinancialSummary()
        {
            DataTable dt = new DataTable();
            try
            {
                // Calculates Total Income, Total Expenses, and the Net Remaining Balance
                string query = @"
                    SELECT 
                        (SELECT COALESCE(SUM(amount), 0) FROM income_transaction) AS 'TotalIncome',
                        (SELECT COALESCE(SUM(amount), 0) FROM expense_transaction) AS 'TotalExpense',
                        ((SELECT COALESCE(SUM(amount), 0) FROM income_transaction) - 
                         (SELECT COALESCE(SUM(amount), 0) FROM expense_transaction)) AS 'NetBalance'";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Summary Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }

        public DataTable GetTopViolatorsReport()
        {
            DataTable dt = new DataTable();
            try
            {
                // Groups violations by student, counts them, and sums up their total fines.
                // LIMIT 15 ensures the report fits nicely on a single printed page.
                string query = @"
            SELECT 
                CONCAT(s.first_name, ' ', s.last_name) AS 'StudentName',
                COUNT(sv.student_violation_id) AS 'ViolationCount',
                SUM(vt.fee) AS 'TotalFines'
            FROM student_violation sv
            INNER JOIN student s ON sv.student_id = s.student_id
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            GROUP BY s.student_id, s.first_name, s.last_name
            ORDER BY ViolationCount DESC, TotalFines DESC
            LIMIT 15";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Violators Report Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }
    }
}
