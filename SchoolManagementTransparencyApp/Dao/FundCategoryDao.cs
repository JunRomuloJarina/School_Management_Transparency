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
    internal class FundCategoryDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddFundCategory(FundCategory fund_Category)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO fund_category (name) VALUES (@FundName)", dbConn.getconnection);
                command.Parameters.AddWithValue("@FundName", fund_Category.FundName);
                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Fund Category Added Successfully!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool DeleteFundCategory(FundCategory fund_Category)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM fund_category WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@Id", fund_Category.FundId);
                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Fund Category Deleted Successfully!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateFundCategory(FundCategory fund_Category)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE fund_category SET name = @FundName WHERE id = @Id", dbConn.getconnection);
                command.Parameters.AddWithValue("@FundName", fund_Category.FundName);
                command.Parameters.AddWithValue("@Id", fund_Category.FundId);
                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Fund Category Updated Successfully!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        public List<FundCategory> GetAllFundCategories()
        {
            List<FundCategory> fundCategories = new List<FundCategory>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM fund_category", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FundCategory fund_Category = new FundCategory
                    {
                        FundId = reader.GetInt32("fund_id"),
                        FundName = reader.GetString("fund_name")
                    };
                    fundCategories.Add(fund_Category);
                }
                dbConn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fundCategories;
        }

        // 1. Get Detailed Fund Analysis (Total In, Total Out, Balance)
        public DataTable GetFundSummaryTable()
        {
            DataTable dt = new DataTable();
            try
            {
                // This query joins the categories with calculated sums from income and expense tables
                string query = @"
                    SELECT 
                        f.fund_id AS 'ID',
                        f.fund_name AS 'Fund Name',
                        IFNULL((SELECT SUM(amount) FROM income_transaction WHERE fund_id = f.fund_id), 0) AS 'Total Income',
                        IFNULL((SELECT SUM(amount) FROM expense_transaction WHERE fund_id = f.fund_id), 0) AS 'Total Expenses',
                        (IFNULL((SELECT SUM(amount) FROM income_transaction WHERE fund_id = f.fund_id), 0) - 
                         IFNULL((SELECT SUM(amount) FROM expense_transaction WHERE fund_id = f.fund_id), 0)) AS 'Current Balance'
                    FROM fund_category f
                    ORDER BY f.fund_name ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Error loading fund summary: " + ex.Message); }
            return dt;
        }

        // 2. Add a new Fund Category (e.g., Graduation Fund)
        public bool AddNewFundCategory(string fundName)
        {
            try
            {
                dbConn.openConnect();
                string query = "INSERT INTO fund_category (fund_name) VALUES (@name)";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@name", fundName.ToUpper());
                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex) { MessageBox.Show("Error adding fund: " + ex.Message); return false; }
            finally { dbConn.closeConnect(); }
        }

        // 3. Get Total School Cash (Sum of all balances)
        public decimal GetTotalSchoolBalance()
        {
            decimal total = 0;
            try
            {
                dbConn.openConnect();
                string query = @"
                    SELECT 
                        (SELECT IFNULL(SUM(amount), 0) FROM income_transaction) - 
                        (SELECT IFNULL(SUM(amount), 0) FROM expense_transaction) AS Total";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                total = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception) { total = 0; }
            finally { dbConn.closeConnect(); }
            return total;
        }

        // 4. Update an existing Fund Name
        public bool UpdateFundCategory(int fundId, string newName)
        {
            try
            {
                dbConn.openConnect();
                string query = "UPDATE fund_category SET fund_name = @name WHERE fund_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@name", newName.ToUpper());
                cmd.Parameters.AddWithValue("@id", fundId);
                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }

        // 5. Delete a Fund Category
        public bool DeleteFundCategory(int fundId)
        {
            try
            {
                dbConn.openConnect();
                // Note: This will fail if there are existing transactions linked to this fund (Foreign Key protection)
                string query = "DELETE FROM fund_category WHERE fund_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@id", fundId);
                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete fund. It may have existing transaction records.\nError: " + ex.Message, "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }

    }
}
