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
    internal class StudentAccountDao
    {
        private DatabaseConnection dbConn = new DatabaseConnection();

        // 1. READ: Now joins with Enrollment and Course to show the Course Name
        public DataTable GetStudentManagementData()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                s.student_id, ua.user_id, s.first_name, s.middle_name, s.last_name, 
                s.age, s.gender, s.address, s.date_of_birth, s.contact_number, 
                ua.username, ua.password, ua.role,
                c.course_id, c.course_name AS 'Course'
            FROM student s 
            INNER JOIN user_account ua ON s.user_id = ua.user_id
            LEFT JOIN enrollment e ON s.student_id = e.student_id
            LEFT JOIN course c ON e.course_id = c.course_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Read Error: " + ex.Message); }
            return dt;
        }

        // 2. NEW: Fetch Courses for the Dropdown
        public DataTable GetAvailableCourses()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT course_id, course_name FROM course ORDER BY course_name ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Error loading courses: " + ex.Message); }
            return dt;
        }

        // 3. CREATE: User -> Student -> Enrollment (Transaction)
        public bool CreateStudentWithAccount(string fn, string mn, string ln, int age, string gen, string addr, DateTime dob, string con, string user, string pass, string role, int courseId)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // Step A: User Account
                        string q1 = "INSERT INTO user_account (username, password, role) VALUES (@u, @p, @r)";
                        MySqlCommand cmd1 = new MySqlCommand(q1, dbConn.getconnection, trans);
                        cmd1.Parameters.AddWithValue("@u", user);
                        cmd1.Parameters.AddWithValue("@p", pass);
                        cmd1.Parameters.AddWithValue("@r", role);
                        cmd1.ExecuteNonQuery();
                        long newUserId = cmd1.LastInsertedId;

                        // Step B: Student
                        string q2 = @"INSERT INTO student (user_id, first_name, middle_name, last_name, age, gender, address, date_of_birth, contact_number) 
                                 VALUES (@uid, @fn, @mn, @ln, @age, @gen, @addr, @dob, @con)";
                        MySqlCommand cmd2 = new MySqlCommand(q2, dbConn.getconnection, trans);
                        cmd2.Parameters.AddWithValue("@uid", newUserId);
                        cmd2.Parameters.AddWithValue("@fn", fn); cmd2.Parameters.AddWithValue("@mn", mn); cmd2.Parameters.AddWithValue("@ln", ln);
                        cmd2.Parameters.AddWithValue("@age", age); cmd2.Parameters.AddWithValue("@gen", gen);
                        cmd2.Parameters.AddWithValue("@addr", addr); cmd2.Parameters.AddWithValue("@dob", dob); cmd2.Parameters.AddWithValue("@con", con);
                        cmd2.ExecuteNonQuery();
                        long newStudentId = cmd2.LastInsertedId;

                        // Step C: Enrollment (The Bridge)
                        string q3 = "INSERT INTO enrollment (student_id, course_id, enrollment_date) VALUES (@sid, @cid, NOW())";
                        MySqlCommand cmd3 = new MySqlCommand(q3, dbConn.getconnection, trans);
                        cmd3.Parameters.AddWithValue("@sid", newStudentId);
                        cmd3.Parameters.AddWithValue("@cid", courseId);
                        cmd3.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex) { trans.Rollback(); MessageBox.Show(ex.Message); return false; }
                }
            }
            finally { dbConn.closeConnect(); }
        }

        // 4. UPDATE: Including Enrollment Update
        public bool UpdateStudentAndAccount(int studentId, int userId, string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact, string username, string pass, string role, int courseId)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // Update User
                        string uQ = "UPDATE user_account SET username=@u, password=@p, role=@r WHERE user_id=@uid";
                        MySqlCommand uCmd = new MySqlCommand(uQ, dbConn.getconnection, trans);
                        uCmd.Parameters.AddWithValue("@u", username); uCmd.Parameters.AddWithValue("@p", pass); uCmd.Parameters.AddWithValue("@r", role); uCmd.Parameters.AddWithValue("@uid", userId);
                        uCmd.ExecuteNonQuery();

                        // Update Student
                        string sQ = "UPDATE student SET first_name=@fn, middle_name=@mn, last_name=@ln, age=@age, gender=@gen, address=@addr, date_of_birth=@dob, contact_number=@con WHERE student_id=@sid";
                        MySqlCommand sCmd = new MySqlCommand(sQ, dbConn.getconnection, trans);
                        sCmd.Parameters.AddWithValue("@fn", fname); sCmd.Parameters.AddWithValue("@mn", mname); sCmd.Parameters.AddWithValue("@ln", lname);
                        sCmd.Parameters.AddWithValue("@age", age); sCmd.Parameters.AddWithValue("@gen", gender);
                        sCmd.Parameters.AddWithValue("@addr", address); sCmd.Parameters.AddWithValue("@dob", dob); sCmd.Parameters.AddWithValue("@con", contact); sCmd.Parameters.AddWithValue("@sid", studentId);
                        sCmd.ExecuteNonQuery();

                        // Update Enrollment (Checks if record exists, if not inserts, if yes updates)
                        string eQ = "INSERT INTO enrollment (student_id, course_id, enrollment_date) VALUES (@sid, @cid, NOW()) ON DUPLICATE KEY UPDATE course_id=@cid";
                        MySqlCommand eCmd = new MySqlCommand(eQ, dbConn.getconnection, trans);
                        eCmd.Parameters.AddWithValue("@sid", studentId);
                        eCmd.Parameters.AddWithValue("@cid", courseId);
                        eCmd.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex) { trans.Rollback(); MessageBox.Show(ex.Message); return false; }
                }
            }
            finally { dbConn.closeConnect(); }
        }




        public DataTable SearchStudentProfiles(string searchTerm)
        {
            DataTable dt = new DataTable();
            try
            {
                // Join with enrollment and course so we can search by 'Course Name'
                string query = @"
                SELECT 
                    s.student_id, ua.user_id, s.first_name, s.middle_name, s.last_name, 
                    s.age, s.gender, s.address, s.date_of_birth, s.contact_number, 
                    ua.username, ua.password, ua.role,
                    c.course_name AS 'Course', c.course_id
                FROM student s 
                INNER JOIN user_account ua ON s.user_id = ua.user_id
                LEFT JOIN enrollment e ON s.student_id = e.student_id
                LEFT JOIN course c ON e.course_id = c.course_id
                WHERE s.first_name LIKE @search 
                   OR s.last_name LIKE @search 
                   OR ua.username LIKE @search
                   OR c.course_name LIKE @search  -- Now you can search by Course!
                   OR s.contact_number LIKE @search";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
            return dt;
        }





        public bool DeleteStudentRecord(int studentId, int userId)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // 1. Delete from enrollment first (The Bridge)
                        string q1 = "DELETE FROM enrollment WHERE student_id = @sid";
                        MySqlCommand cmd1 = new MySqlCommand(q1, dbConn.getconnection, trans);
                        cmd1.Parameters.AddWithValue("@sid", studentId);
                        cmd1.ExecuteNonQuery();

                        // 2. Delete from student (The Profile)
                        string q2 = "DELETE FROM student WHERE student_id = @sid";
                        MySqlCommand cmd2 = new MySqlCommand(q2, dbConn.getconnection, trans);
                        cmd2.Parameters.AddWithValue("@sid", studentId);
                        cmd2.ExecuteNonQuery();

                        // 3. Delete from user_account (The Login)
                        string q3 = "DELETE FROM user_account WHERE user_id = @uid";
                        MySqlCommand cmd3 = new MySqlCommand(q3, dbConn.getconnection, trans);
                        cmd3.Parameters.AddWithValue("@uid", userId);
                        cmd3.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Delete Failed: " + ex.Message);
                        return false;
                    }
                }
            }
            finally { dbConn.closeConnect(); }
        }

    }
}
