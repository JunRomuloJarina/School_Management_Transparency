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
using System.Xml.Linq;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class StudentDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddStudent(Student student)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO student (user_id, first_name, middle_name, last_name, gender, address, date_of_birth, contact_number) VALUES (@UserId, @FirstName, @MiddleName, @LastName, @Gender, @Address, @DateOfBirth, @ContactNumber)", dbConn.getconnection); command.Parameters.AddWithValue("@UserId", student.UserId);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);

                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student added successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE Student SET  first_name=@FirstName, middle_name=@MiddleName,last_name=@LastName, age=@Age, gender=@Gender, address=@Address, date_of_birth=@DOB, contact_number=@Contact WHERE student_id=@StudentId",dbConn.getconnection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                command.Parameters.AddWithValue("@Contact", student.ContactNumber);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }


        public bool DeleteStudent(int student_id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM students WHERE student_id = @student_id", dbConn.getconnection);
                command.Parameters.AddWithValue("@student_id", student_id);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student deleted successfully.");
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public Student GetStudentById(int studentId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Student WHERE student_id = @StudentId", dbConn.getconnection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        Student student = new Student
                        {
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = Convert.ToInt32(reader["age"]),
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["dob"]),
                            ContactNumber = reader["contact_number"].ToString()
                        };

                        dbConn.closeConnect();
                        MessageBox.Show("Student retrieved successfully.");
                        return student;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return null;
        }

        public List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Student", dbConn.getconnection);
                dbConn.openConnect();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = Convert.ToInt32(reader["age"]),
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
                            ContactNumber = reader["contact_number"].ToString()
                        };

                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return students;
        }


        public List<dynamic> GetAllViolations()
        {
            List<dynamic> list = new List<dynamic>();
            try
            {
                // Now using your actual schema to get the real Violation Name
                string query = @"
            SELECT s.first_name, s.last_name, vt.violation_name 
            FROM student_violation sv
            JOIN student s ON sv.student_id = s.student_id
            JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                dbConn.openConnect();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            StudentName = reader["first_name"].ToString() + " " + reader["last_name"].ToString(),
                            ViolationType = reader["violation_name"].ToString() // Real data instead of placeholder
                        });
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { dbConn.closeConnect(); }
            return list;
        }

        public DataTable GetStudentWithAccountDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                // Joining students with user_account based on user_id
                string query = @"
                    SELECT 
                        s.student_id AS 'Student ID', 
                        s.first_name AS 'First Name', 
                        s.last_name AS 'Last Name',
                        s.course AS 'Course',
                        ua.username AS 'Account Name',
                        ua.user_id AS 'User ID'
                    FROM student s
                    INNER JOIN user_account ua ON s.user_id = ua.user_id
                    ORDER BY s.student_id DESC";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { dbConn.closeConnect(); }
            return dt;
        }

    }
}
