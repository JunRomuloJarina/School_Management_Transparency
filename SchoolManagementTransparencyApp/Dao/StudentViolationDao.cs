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

        public List<StudentViolation> GetAllStudentViolationsNormal()
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



        // 1. GET ALL: Hop from Violation -> Student -> Enrollment -> Course
        public DataTable GetAllStudentViolations()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                SELECT 
                    sv.student_violation_id AS 'Record ID',
                    s.student_id AS 'Student ID',
                    CONCAT(s.first_name, ' ', s.last_name) AS 'Student Name',
                    c.course_name AS 'Course',
                    vt.category AS 'Violation Category',
                    vt.violation_name AS 'Offense',
                    vt.fee AS 'Penalty Fee',
                    sv.date_issued AS 'Date',
                    sv.status AS 'Status'
                FROM student_violation sv
                INNER JOIN student s ON sv.student_id = s.student_id
                INNER JOIN enrollment e ON s.student_id = e.student_id -- The Bridge
                INNER JOIN course c ON e.course_id = c.course_id     -- The Destination
                INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                ORDER BY sv.date_issued DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Error loading violations: " + ex.Message); }
            return dt;
        }

        // 2. SEARCH BAR: Global search across Name, Course, or Offense
        public DataTable SearchStudentViolations(string searchTerm)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                SELECT 
                    sv.student_violation_id AS 'Record ID', s.student_id AS 'Student ID',
                    CONCAT(s.first_name, ' ', s.last_name) AS 'Student Name',
                    c.course_name AS 'Course', vt.category AS 'Violation Category',
                    vt.violation_name AS 'Offense', vt.fee AS 'Penalty Fee',
                    sv.date_issued AS 'Date', sv.status AS 'Status'
                FROM student_violation sv
                INNER JOIN student s ON sv.student_id = s.student_id
                INNER JOIN enrollment e ON s.student_id = e.student_id
                INNER JOIN course c ON e.course_id = c.course_id
                INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                WHERE s.first_name LIKE @s 
                   OR s.last_name LIKE @s 
                   OR vt.violation_name LIKE @s
                   OR c.course_name LIKE @s";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@s", "%" + searchTerm + "%");
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
            return dt;
        }

        // 3. FILTER BY COURSE: Filter based on the ComboBox selection
        public DataTable FilterViolationsByCourse(int courseId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                SELECT 
                    sv.student_violation_id AS 'Record ID', s.student_id AS 'Student ID',
                    CONCAT(s.first_name, ' ', s.last_name) AS 'Student Name',
                    c.course_name AS 'Course', vt.category AS 'Violation Category',
                    vt.violation_name AS 'Offense', vt.fee AS 'Penalty Fee',
                    sv.date_issued AS 'Date', sv.status AS 'Status'
                FROM student_violation sv
                INNER JOIN student s ON sv.student_id = s.student_id
                INNER JOIN enrollment e ON s.student_id = e.student_id
                INNER JOIN course c ON e.course_id = c.course_id
                INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                WHERE c.course_id = @cId";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@cId", courseId);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Filter Error: " + ex.Message); }
            return dt;
        }

        // 4. COMBOBOX SOURCE: Already works perfectly with your course table
        public DataTable GetCoursesForComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT course_id, course_name FROM course ORDER BY course_name ASC";
                new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection)).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Course Load Error: " + ex.Message); }
            return dt;
        }


    }
}
