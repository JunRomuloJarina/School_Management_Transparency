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



        // UPDATE THIS METHOD IN StudentViolationDao
        public DataTable GetAllStudentViolations()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                    SELECT 
                        sv.student_violation_id AS 'Record ID',
                        s.student_id AS 'Student ID',
                        CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                        c.course_name AS 'Course',
                        vt.category AS 'Type', -- Added Category (Event or Violation)
                        vt.violation_name AS 'Description', -- Renamed 'Offense' to 'Description'
                        vt.fee AS 'Amount Due',
                        sv.date_issued AS 'Date',
                        sv.status AS 'Status'
                    FROM student_violation sv
                    INNER JOIN student s ON sv.student_id = s.student_id
                    INNER JOIN enrollment e ON s.student_id = e.student_id
                    INNER JOIN course c ON e.course_id = c.course_id
                    INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                    ORDER BY sv.date_issued DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Error loading records: " + ex.Message); }
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

        // 5. FILTER BY STATUS: Show only 'PAID' or 'UNPAID' records
        public DataTable FilterViolationsByStatus(string status)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                sv.student_violation_id AS 'Record ID',
                s.student_id AS 'Student ID',
                CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                c.course_name AS 'Course',
                vt.violation_name AS 'Offense',
                vt.fee AS 'Amount Due',
                sv.date_issued AS 'Date Logged',
                sv.status AS 'Status'
            FROM student_violation sv
            INNER JOIN student s ON sv.student_id = s.student_id
            INNER JOIN enrollment e ON s.student_id = e.student_id
            INNER JOIN course c ON e.course_id = c.course_id
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            WHERE sv.status = @status
            ORDER BY sv.date_issued DESC";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@status", status);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Filter Error: " + ex.Message); }
            return dt;
        }

        public bool AddViolationRecord(int studentId, int violationTypeId, DateTime date, string status)
        {
            try
            {
                dbConn.openConnect();
                string query = @"INSERT INTO student_violation (student_id, violation_type_id, date_issued, status) 
                         VALUES (@sid, @vid, @date, @status)";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@vid", violationTypeId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", status);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }


        public DataTable GetViolationTypes()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT violation_type_id, violation_name FROM violation_type ORDER BY violation_name";
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }
        public bool SettleStudentDebtWithTransaction(int vId, int sId, decimal amt, string name, string desc, int fundId)
        {
            MySqlTransaction tr = null;
            try
            {
                dbConn.openConnect();
                tr = dbConn.getconnection.BeginTransaction();

                // Update violation status
                string updateQuery = "UPDATE student_violation SET status = 'PAID' WHERE student_violation_id = @vId";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, dbConn.getconnection, tr);
                updateCmd.Parameters.AddWithValue("@vId", vId);
                updateCmd.ExecuteNonQuery();

                // Insert into income_transaction with the selected fundId
                string insertQuery = @"INSERT INTO income_transaction 
                               (fund_id, transaction_type_id, student_id, student_violation_id, amount, transaction_date, remarks) 
                               VALUES (@fId, 1, @sId, @vId, @amt, CURDATE(), @remarks)";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, dbConn.getconnection, tr);
                insertCmd.Parameters.AddWithValue("@fId", fundId);
                insertCmd.Parameters.AddWithValue("@sId", sId);
                insertCmd.Parameters.AddWithValue("@vId", vId);
                insertCmd.Parameters.AddWithValue("@amt", amt);
                insertCmd.Parameters.AddWithValue("@remarks", $"Payment for {desc} - Student: {name}");

                insertCmd.ExecuteNonQuery();
                tr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show("Transaction Failed: " + ex.Message);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }

        public DataTable GetStudentLookupList()
        {
            DataTable dt = new DataTable();
            try
            {
                // Simple join to show Name and Course for selection
                string query = @"
            SELECT 
                s.student_id, 
                CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                c.course_name AS 'Course'
            FROM student s
            LEFT JOIN enrollment e ON s.student_id = e.student_id
            LEFT JOIN course c ON e.course_id = c.course_id
            ORDER BY s.last_name ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Lookup Error: " + ex.Message); }
            return dt;
        }


        public DataTable SearchStudentsForViolation(string searchTerm, int courseId)
        {
            DataTable dt = new DataTable();
            try
            {
                // Base Query
                string query = @"
                    SELECT 
                        s.student_id, 
                        CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                        c.course_name AS 'Course'
                    FROM student s
                    LEFT JOIN enrollment e ON s.student_id = e.student_id
                    LEFT JOIN course c ON e.course_id = c.course_id
                    WHERE (s.first_name LIKE @s OR s.last_name LIKE @s OR c.course_name LIKE @s)";

                // Append course filter if one is selected (0 is 'All Courses')
                if (courseId > 0)
                {
                    query += " AND c.course_id = @cId";
                }

                query += " ORDER BY s.last_name ASC";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@s", "%" + searchTerm + "%");
                if (courseId > 0) cmd.Parameters.AddWithValue("@cId", courseId);

                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
            return dt;
        }

        public bool SettleStudentDebt(int recordId)
        {
            try
            {
                dbConn.openConnect();
                // Update the status from UNPAID to PAID
                string query = "UPDATE student_violation SET status = 'PAID' WHERE student_violation_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@id", recordId);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Error: " + ex.Message);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }

        public DataTable GetFundCategories()
        {
            string query = "SELECT fund_id, fund_name FROM fund_category ORDER BY fund_name ASC";
            DataTable dt = new DataTable();
            try
            {
                dbConn.openConnect();
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbConn.getconnection);
                da.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Error loading funds: " + ex.Message); }
            finally { dbConn.closeConnect(); }
            return dt;
        }

        public bool SettleStudentDebtWithTransaction(int violationId, int studentId, decimal amount, string studentName, string description)
        {
            MySqlTransaction tr = null;
            try
            {
                dbConn.openConnect();
                tr = dbConn.getconnection.BeginTransaction();

                // 1. Update status to PAID
                string updateQuery = "UPDATE student_violation SET status = 'PAID' WHERE student_violation_id = @vId";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, dbConn.getconnection, tr);
                updateCmd.Parameters.AddWithValue("@vId", violationId);
                updateCmd.ExecuteNonQuery();

                // 2. Insert into income_transaction based on your image schema
                string insertQuery = @"INSERT INTO income_transaction 
                               (fund_id, transaction_type_id, student_id, student_violation_id, amount, transaction_date, remarks) 
                               VALUES (@fId, @tTypeId, @sId, @vId, @amt, CURDATE(), @remarks)";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, dbConn.getconnection, tr);

                insertCmd.Parameters.AddWithValue("@fId", 1); // General Fund
                insertCmd.Parameters.AddWithValue("@tTypeId", 1); // Payment Type
                insertCmd.Parameters.AddWithValue("@sId", studentId);
                insertCmd.Parameters.AddWithValue("@vId", violationId);
                insertCmd.Parameters.AddWithValue("@amt", amount);
                insertCmd.Parameters.AddWithValue("@remarks", $"Payment for {description} - Student: {studentName}");

                insertCmd.ExecuteNonQuery();
                tr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show("Transaction Failed: " + ex.Message);
                return false;
            }
            finally { dbConn.closeConnect(); }
        }

        public DataTable SearchStudentViolationsV2(string searchTerm)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                sv.student_violation_id AS 'Record ID', 
                s.student_id AS 'Student ID',
                CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                c.course_name AS 'Course', 
                vt.category AS 'Type',
                vt.violation_name AS 'Description', 
                vt.fee AS 'Amount Due',
                sv.date_issued AS 'Date', 
                sv.status AS 'Status'
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

        public DataTable FilterViolationsByCourseV2(int courseId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                sv.student_violation_id AS 'Record ID', 
                s.student_id AS 'Student ID',
                CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                c.course_name AS 'Course', 
                vt.category AS 'Type',
                vt.violation_name AS 'Description', 
                vt.fee AS 'Amount Due',
                sv.date_issued AS 'Date', 
                sv.status AS 'Status'
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

        public DataTable FilterViolationsByStatusV2(string status)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                sv.student_violation_id AS 'Record ID',
                s.student_id AS 'Student ID',
                CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name',
                c.course_name AS 'Course',
                vt.category AS 'Type',
                vt.violation_name AS 'Description',
                vt.fee AS 'Amount Due',
                sv.date_issued AS 'Date',
                sv.status AS 'Status'
            FROM student_violation sv
            INNER JOIN student s ON sv.student_id = s.student_id
            INNER JOIN enrollment e ON s.student_id = e.student_id
            INNER JOIN course c ON e.course_id = c.course_id
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            WHERE sv.status = @status
            ORDER BY sv.date_issued DESC";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@status", status);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Filter Error: " + ex.Message); }
            return dt;
        }


    }
}
