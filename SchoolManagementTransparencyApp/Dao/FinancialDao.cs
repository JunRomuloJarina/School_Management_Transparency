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
    internal class FinancialDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        public List<FundBalanceReport> GetFundBalanceReport()
        {
            List<FundBalanceReport> reports = new List<FundBalanceReport>();
            // Using Subqueries ensures that the Sum of Income doesn't multiply by the number of Expenses
            string sql = @"
                SELECT 
                    f.fund_name,
                    COALESCE(inc.total_inc, 0) AS total_income,
                    COALESCE(exp.total_exp, 0) AS total_expense,
                    (COALESCE(inc.total_inc, 0) - COALESCE(exp.total_exp, 0)) AS balance
                FROM fund_category f
                LEFT JOIN (
                    SELECT fund_id, SUM(amount) as total_inc 
                    FROM income_transaction GROUP BY fund_id
                ) inc ON f.fund_id = inc.fund_id
                LEFT JOIN (
                    SELECT fund_id, SUM(amount) as total_exp 
                    FROM expense_transaction GROUP BY fund_id
                ) exp ON f.fund_id = exp.fund_id";

            try
            {
                dbConn.openConnect();
                MySqlCommand cmd = new MySqlCommand(sql, dbConn.getconnection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reports.Add(new FundBalanceReport
                        {
                            FundName = reader.GetString("fund_name"),
                            TotalIncome = reader.GetDecimal("total_income"),
                            TotalExpenses = reader.GetDecimal("total_expense"),
                            CurrentBalance = reader.GetDecimal("balance")
                        });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { dbConn.closeConnect(); }

            return reports;
        }
    }
}
