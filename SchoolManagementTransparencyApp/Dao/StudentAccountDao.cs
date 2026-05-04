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

        // 1. READ: Joining student and user_account tables
        public DataTable GetStudentManagementData()
        {
            DataTable dt = new DataTable();
            try
            {
                // Aligning with your specific schema columns
                string query = @"
                SELECT 
                    s.student_id, ua.user_id, s.first_name, s.middle_name, s.last_name, 
                    s.age, s.gender, s.address, s.date_of_birth, s.contact_number, 
                    ua.username, ua.password, ua.role
                FROM student s 
                INNER JOIN user_account ua ON s.user_id = ua.user_id";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Read Error: " + ex.Message); }
            return dt;
        }

        // 2. CREATE: Insert into user_account FIRST, then student
        public bool CreateStudentWithAccount(string fn, string mn, string ln, int age, string gen, string addr, DateTime dob, string con, string user, string pass, string role)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // Step A: Insert into user_account
                        string q1 = "INSERT INTO user_account (username, password, role) VALUES (@u, @p, @r)";
                        MySqlCommand cmd1 = new MySqlCommand(q1, dbConn.getconnection, trans);
                        cmd1.Parameters.AddWithValue("@u", user);
                        cmd1.Parameters.AddWithValue("@p", pass);
                        cmd1.Parameters.AddWithValue("@r", role);
                        cmd1.ExecuteNonQuery();

                        long newUserId = cmd1.LastInsertedId; // Capture the FK for the student table

                        // Step B: Insert into student
                        string q2 = @"INSERT INTO student (user_id, first_name, middle_name, last_name, age, gender, address, date_of_birth, contact_number) 
                                 VALUES (@uid, @fn, @mn, @ln, @age, @gen, @addr, @dob, @con)";
                        MySqlCommand cmd2 = new MySqlCommand(q2, dbConn.getconnection, trans);
                        cmd2.Parameters.AddWithValue("@uid", newUserId);
                        cmd2.Parameters.AddWithValue("@fn", fn);
                        cmd2.Parameters.AddWithValue("@mn", mn);
                        cmd2.Parameters.AddWithValue("@ln", ln);
                        cmd2.Parameters.AddWithValue("@age", age);
                        cmd2.Parameters.AddWithValue("@gen", gen);
                        cmd2.Parameters.AddWithValue("@addr", addr);
                        cmd2.Parameters.AddWithValue("@dob", dob);
                        cmd2.Parameters.AddWithValue("@con", con);
                        cmd2.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex) { trans.Rollback(); MessageBox.Show(ex.Message); return false; }
                }
            }
            finally { dbConn.closeConnect(); }
        }

        // 3. DELETE: Delete child (student) first, then parent (user_account)
        public bool DeleteStudentRecord(int studentId, int userId)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // Delete from student first to avoid FK violation
                        new MySqlCommand($"DELETE FROM student WHERE student_id={studentId}", dbConn.getconnection, trans).ExecuteNonQuery();
                        // Delete from user_account second
                        new MySqlCommand($"DELETE FROM user_account WHERE user_id={userId}", dbConn.getconnection, trans).ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception) { trans.Rollback(); return false; }
                }
            }
            finally { dbConn.closeConnect(); }
        }



        public bool UpdateStudentAndAccount(int studentId, int userId, string fname, string mname, string lname, int age, string gender, string address, DateTime dob, string contact, string username, string pass, string role)
        {
            try
            {
                dbConn.openConnect();
                using (MySqlTransaction trans = dbConn.getconnection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update the user_account table
                        string userQuery = "UPDATE user_account SET username=@u, password=@p, role=@r WHERE user_id=@uid";
                        MySqlCommand uCmd = new MySqlCommand(userQuery, dbConn.getconnection, trans);
                        uCmd.Parameters.AddWithValue("@u", username);
                        uCmd.Parameters.AddWithValue("@p", pass);
                        uCmd.Parameters.AddWithValue("@r", role);
                        uCmd.Parameters.AddWithValue("@uid", userId);
                        uCmd.ExecuteNonQuery();

                        // 2. Update the student table based on your schema
                        string studQuery = @"UPDATE student SET 
                                        first_name=@fn, middle_name=@mn, last_name=@ln, 
                                        age=@age, gender=@gen, address=@addr, 
                                        date_of_birth=@dob, contact_number=@con 
                                        WHERE student_id=@sid";

                        MySqlCommand sCmd = new MySqlCommand(studQuery, dbConn.getconnection, trans);
                        sCmd.Parameters.AddWithValue("@fn", fname);
                        sCmd.Parameters.AddWithValue("@mn", mname);
                        sCmd.Parameters.AddWithValue("@ln", lname);
                        sCmd.Parameters.AddWithValue("@age", age);
                        sCmd.Parameters.AddWithValue("@gen", gender);
                        sCmd.Parameters.AddWithValue("@addr", address);
                        sCmd.Parameters.AddWithValue("@dob", dob);
                        sCmd.Parameters.AddWithValue("@con", contact);
                        sCmd.Parameters.AddWithValue("@sid", studentId);
                        sCmd.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Update Failed: " + ex.Message);
                        return false;
                    }
                }
            }
            finally { dbConn.closeConnect(); }

        }




        public DataTable SearchStudentProfiles(string searchTerm)
        {
            DataTable dt = new DataTable();
            try
            {
                // Use LIKE with % to find partial matches in any column
                string query = @"
                SELECT 
                    s.student_id, ua.user_id, s.first_name, s.middle_name, s.last_name, 
                    s.age, s.gender, s.address, s.date_of_birth, s.contact_number, 
                    ua.username, ua.password, ua.role
                FROM student s 
                INNER JOIN user_account ua ON s.user_id = ua.user_id
                WHERE s.first_name LIKE @search 
                   OR s.last_name LIKE @search 
                   OR ua.username LIKE @search
                   OR ua.password LIKE @search
                   OR ua.role LIKE @search
                   OR s.contact_number LIKE @search";

                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
            return dt;
        }








    }
}
