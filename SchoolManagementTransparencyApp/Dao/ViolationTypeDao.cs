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
                    "DELETE FROM Violation_Type WHERE violation_type_id=@ViolationTypeId",
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
                            ViolationTypeId = Convert.ToInt32(reader["violation_type_id"]),
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
        [Obsolete("Use GetViolationTypesDataTable for DataGridView binding.")]
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

        // 1. GET ALL FOR GRID (The New Method for CRUD)
        public DataTable GetViolationTypesDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                // We use Aliases (AS) so the Grid Headers look professional automatically
                string query = "SELECT violation_type_id AS ID, violation_name AS 'Violation Name', " +
                               "fee AS 'Penalty Fee', category AS 'Category', description AS 'Description' " +
                               "FROM Violation_Type ORDER BY violation_name ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Table: " + ex.Message);
            }
            return dt;
        }

        // 2. SAVE (New Version with proper Feedback)
        public bool SaveNewViolationType(ViolationType violation)
        {
            try
            {
                dbConn.openConnect();
                string query = "INSERT INTO Violation_Type (violation_name, fee, category, description) " +
                               "VALUES (@Name, @Fee, @Category, @Description)";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                command.Parameters.AddWithValue("@Name", violation.ViolationName);
                command.Parameters.AddWithValue("@Fee", violation.Fee);
                command.Parameters.AddWithValue("@Category", violation.Category);
                command.Parameters.AddWithValue("@Description", violation.Description);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Violation Type added to the system successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { dbConn.closeConnect(); }
            return false;
        }

        // 3. UPDATE
        public bool UpdateViolationTypes(ViolationType violation)
        {
            try
            {
                dbConn.openConnect();
                string query = "UPDATE Violation_Type SET violation_name=@Name, fee=@Fee, " +
                               "category=@Category, description=@Description WHERE violation_type_id=@Id";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                command.Parameters.AddWithValue("@Name", violation.ViolationName);
                command.Parameters.AddWithValue("@Fee", violation.Fee);
                command.Parameters.AddWithValue("@Category", violation.Category);
                command.Parameters.AddWithValue("@Description", violation.Description);
                command.Parameters.AddWithValue("@Id", violation.ViolationTypeId);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { dbConn.closeConnect(); }
            return false;
        }

        // 4. DELETE
        public bool DeleteViolationTypes(int violationTypeId)
        {
            try
            {
                dbConn.openConnect();
                string query = "DELETE FROM Violation_Type WHERE violation_type_id=@Id";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                command.Parameters.AddWithValue("@Id", violationTypeId);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Violation type has been removed.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete: This type is likely being used by a student record.\n" + ex.Message);
            }
            finally { dbConn.closeConnect(); }
            return false;
        }


    }
}
