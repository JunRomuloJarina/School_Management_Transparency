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
    internal class EnrollmentDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddEnrollment(Enrollment enrollment)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO enrollments (student_id, course_id) VALUES (@StudentId, @CourseId)", dbConn.getconnection);
                command.Parameters.AddWithValue("@StudentId", enrollment.StudentId);
                command.Parameters.AddWithValue("@CourseId", enrollment.CourseId);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Enrollment added successfully.");
                    return true;
                }

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool DeleteEnrollment(Enrollment enrollment)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM enrollments WHERE enrollment_id = @EnrollmentId", dbConn.getconnection);
                command.Parameters.AddWithValue("@EnrollmentId", enrollment.EnrollmentId);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();

                    MessageBox.Show("Enrollment deleted successfully.");
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

        public List<Enrollment> GetAllEnrollments()
        {
            List<Enrollment> enrollments = new List<Enrollment>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT enrollment_id, student_id, course_id FROM enrollments", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Enrollment enrollment = new Enrollment
                    {
                        EnrollmentId = reader.GetInt32("enrollment_id"),
                        StudentId = reader.GetInt32("student_id"),
                        CourseId = reader.GetInt32("course_id")
                    };
                    enrollments.Add(enrollment);
                }
                reader.Close();
                dbConn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return enrollments;
        }






    }
}
