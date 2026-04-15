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
    internal class Teacher_Dao
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO teacher (first_name, middle_name, last_name, age, gender, address, date_of_birth, contact_number) " +
                    "VALUES (@FirstName, @MiddleName, @LastName, @Age, @Gender, @Address, @DOB, @ContactNumber)",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                command.Parameters.AddWithValue("@MiddleName", teacher.MiddleName);
                command.Parameters.AddWithValue("@LastName", teacher.LastName);
                command.Parameters.AddWithValue("@Age", teacher.Age);
                command.Parameters.AddWithValue("@Gender", teacher.Gender);
                command.Parameters.AddWithValue("@Address", teacher.Address);
                command.Parameters.AddWithValue("@DOB", teacher.DateOfBirth);
                command.Parameters.AddWithValue("@ContactNumber", teacher.ContactNumber);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request Add Teacher Failed: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool DeleteTeacher(int teacherId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM teacher WHERE teacher_id = @TeacherId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TeacherId", teacherId);

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

        public bool UpdateTeacher(Teacher teacher)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE Teacher SET first_name=@FirstName, middle_name=@MiddleName, " +
                    "last_name=@LastName, age=@Age, gender=@Gender, address=@Address, " +
                    "date_of_birth=@DOB, contact_number=@ContactNumber WHERE teacher_id=@TeacherId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                command.Parameters.AddWithValue("@MiddleName", teacher.MiddleName);
                command.Parameters.AddWithValue("@LastName", teacher.LastName);
                command.Parameters.AddWithValue("@Age", teacher.Age);
                command.Parameters.AddWithValue("@Gender", teacher.Gender);
                command.Parameters.AddWithValue("@Address", teacher.Address);
                command.Parameters.AddWithValue("@DOB", teacher.DateOfBirth);
                command.Parameters.AddWithValue("@ContactNumber", teacher.ContactNumber);
                command.Parameters.AddWithValue("@TeacherId", teacher.TeacherId);

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

        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> teachers = new List<Teacher>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM teacher", dbConn.getconnection);
                dbConn.openConnect();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher teacher = new Teacher
                        {
                            TeacherId = Convert.ToInt32(reader["teacher_id"]),
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = Convert.ToInt32(reader["age"]),
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
                            ContactNumber = reader["contact_number"].ToString()
                        };
                        teachers.Add(teacher);
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
            return teachers;
        }

        public Teacher GetTeacherById(int teacherId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM teacher WHERE teacher_id = @TeacherId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TeacherId", teacherId);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Teacher teacher = new Teacher
                        {
                            TeacherId = Convert.ToInt32(reader["teacher_id"]),
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = Convert.ToInt32(reader["age"]),
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["dob"]),
                            ContactNumber = reader["contact_number"].ToString()
                        };

                        return teacher;
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
