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
    internal class StudentViolationDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddStudentViolation(StudentViolation student_Violation)
        {
            try
            {
                // Use student_violation (singular) and correct column names
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO student_violation (student_id, violation_type_id, date_issued, status) " +
                    "VALUES (@StudentId, @ViolationId, @ViolationDate, @Status)",
                    dbConn.getconnection); 

                command.Parameters.AddWithValue("@StudentId", student_Violation.StudentId);
                command.Parameters.AddWithValue("@ViolationId", student_Violation.ViolationTypeId);
                command.Parameters.AddWithValue("@ViolationDate", student_Violation.DateIssued);
                command.Parameters.AddWithValue("@Status",student_Violation.Status);

                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student violation added successfully.");
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

        public bool DeleteStudentViolation(int studentViolationId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM student_violation WHERE id = @StudentViolationId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@StudentViolationId", studentViolationId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student violation deleted successfully.");
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


        public bool UpdateStudentViolation(StudentViolation student_Violation)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE Student_Violation SET student_id=@StudentId, violation_type_id=@ViolationTypeId, " +
                    "date_issued=@DateIssued, status=@Status WHERE id=@StudentViolationId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@StudentId", student_Violation.StudentId);
                command.Parameters.AddWithValue("@ViolationTypeId", student_Violation.ViolationTypeId);
                command.Parameters.AddWithValue("@DateIssued", student_Violation.DateIssued);
                command.Parameters.AddWithValue("@Status", student_Violation.Status);
                command.Parameters.AddWithValue("@StudentViolationId", student_Violation.StudentViolationId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student violation updated successfully.");
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

        public List<StudentViolation> GetAllStudentViolations()
        {
            List<StudentViolation> violations = new List<StudentViolation>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM student_violation", dbConn.getconnection);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentViolation violation = new StudentViolation
                        {
                            StudentViolationId = Convert.ToInt32(reader["student_violation_id"]),
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            ViolationTypeId = Convert.ToInt32(reader["violation_type_id"]),
                            DateIssued = Convert.ToDateTime(reader["date_issued"]),
                            Status = reader["status"].ToString()
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




    }
}
