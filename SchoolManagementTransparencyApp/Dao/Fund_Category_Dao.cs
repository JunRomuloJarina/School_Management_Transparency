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
    internal class Fund_Category_Dao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddFundCategory(Fund_Category fund_Category)
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

        public bool DeleteFundCategory(Fund_Category fund_Category)
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

        public bool UpdateFundCategory(Fund_Category fund_Category)
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

        public List<Fund_Category> GetAllFundCategories()
        {
            List<Fund_Category> fundCategories = new List<Fund_Category>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM fund_category", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Fund_Category fund_Category = new Fund_Category
                    {
                        FundId = reader.GetInt32("id"),
                        FundName = reader.GetString("name")
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

    }
}
