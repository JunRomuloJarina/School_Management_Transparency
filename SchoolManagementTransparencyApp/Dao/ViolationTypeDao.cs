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
    internal class ViolationTypeDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        // 1. Add Violation Type
        public bool AddViolationType(ViolationType violation)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO Violation_Type (violation_name, fee, category, description) " +
                    "VALUES (@Name, @Fee, @Category, @Description)",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Name", violation.ViolationName);
                command.Parameters.AddWithValue("@Fee", violation.Fee);
                command.Parameters.AddWithValue("@Category", violation.Category);
                command.Parameters.AddWithValue("@Description", violation.Description);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
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

        // 2. Update Violation Type
        public bool UpdateViolationType(ViolationType violation)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE Violation_Type SET violation_name=@Name, fee=@Fee, " +
                    "category=@Category, description=@Description WHERE violation_type_id=@ViolationTypeId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Name", violation.ViolationName);
                command.Parameters.AddWithValue("@Fee", violation.Fee);
                command.Parameters.AddWithValue("@Category", violation.Category);
                command.Parameters.AddWithValue("@Description", violation.Description);
                command.Parameters.AddWithValue("@ViolationTypeId", violation.ViolationTypeId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
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

        // 3. Delete Violation Type
        public bool DeleteViolationType(int violationTypeId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM Violation_Type WHERE id=@ViolationTypeId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@ViolationTypeId", violationTypeId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
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

        // 4. Get All Violation Types
        public List<ViolationType> GetAllViolationTypes()
        {
            List<ViolationType> violations = new List<ViolationType>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Violation_Type", dbConn.getconnection);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViolationType violation = new ViolationType
                        {
                            ViolationTypeId = Convert.ToInt32(reader["id"]),
                            ViolationName = reader["violation_name"].ToString(),
                            Fee = Convert.ToDecimal(reader["fee"]),
                            Category = reader["category"].ToString(),
                            Description = reader["description"].ToString()
                        };
                        violations.Add(violation);
                    }
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
            return violations;
        }

        // 5. Get Violation Type By ID
        public ViolationType GetViolationTypeById(int violationTypeId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Violation_Type WHERE violation_type_id=@ViolationTypeId", dbConn.getconnection);
                command.Parameters.AddWithValue("@ViolationTypeId", violationTypeId);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ViolationType
                        {
                            ViolationTypeId = Convert.ToInt32(reader["violation_type_id"]),
                            ViolationName = reader["violation_name"].ToString(),
                            Fee = Convert.ToDecimal(reader["fee"]),
                            Category = reader["category"].ToString(),
                            Description = reader["description"].ToString()
                        };
                    }
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
    }
}
