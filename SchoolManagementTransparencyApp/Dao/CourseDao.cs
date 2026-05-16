using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class CourseDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddCourse(Course course)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO courses (course_name, teacher_id) VALUES (@CourseName, @TeacherId)", dbConn.getconnection);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@TeacherId", course.TeacherId);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Course added successfully.");
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

        public bool DeleteCourse(Course course)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM courses WHERE course_id = @CourseId", dbConn.getconnection);
                command.Parameters.AddWithValue("@CourseId", course.CourseId);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Course deleted successfully.");
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

        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT course_id, course_name, teacher_id FROM courses", dbConn.getconnection);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course
                    {
                        CourseId = reader.GetInt32("course_id"),
                        CourseName = reader.GetString("course_name"),
                        TeacherId = reader.GetInt32("teacher_id")
                    };
                    courses.Add(course);
                }
                reader.Close();
                dbConn.closeConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return courses;
        }

        public bool UpdateCourse(Course course)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE courses SET course_name = @CourseName, teacher_id = @TeacherId WHERE course_id = @CourseId", dbConn.getconnection);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@TeacherId", course.TeacherId);
                command.Parameters.AddWithValue("@CourseId", course.CourseId);
                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Course updated successfully.");
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

        public Course GetCourseById(int courseId)
        {
            Course course = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT course_id, course_name, teacher_id FROM courses WHERE course_id = @CourseId", dbConn.getconnection);
                command.Parameters.AddWithValue("@CourseId", courseId);
                dbConn.openConnect();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    course = new Course
                    {
                        CourseId = reader.GetInt32("course_id"),
                        CourseName = reader.GetString("course_name"),
                        TeacherId = reader.GetInt32("teacher_id")
                    };
                }
                reader.Close();
                dbConn.closeConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return course;
        }


        // Unique name to avoid conflict with GetAllCourses
        public DataTable FetchCourseInstructorJoinData()
        {
            DataTable dt = new DataTable();
            try
            {
                // Joins Teacher table to show Names instead of IDs in the grid
                string query = @"SELECT c.course_id AS 'ID', 
                                        c.course_name AS 'Course Name', 
                                        CONCAT(t.first_name, ' ', t.last_name) AS 'Instructor'
                                 FROM Course c
                                 LEFT JOIN Teacher t ON c.teacher_id = t.teacher_id
                                 ORDER BY c.course_name ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return dt;
        }

        // Unique name to avoid conflict with GetTeachers
        public DataTable RetrieveTeacherLookupList()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT teacher_id, CONCAT(first_name, ' ', last_name) AS full_name FROM Teacher";
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, dbConn.getconnection));
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return dt;
        }


        // --- CRUD ACTION METHODS ---

        public bool InsertNewCourseRecord(string name, int instructorId)
        {
            try
            {
                dbConn.openConnect();
                string query = "INSERT INTO Course (course_name, teacher_id) VALUES (@cName, @tId)";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@cName", name);
                cmd.Parameters.AddWithValue("@tId", instructorId);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New Course successfully registered.", "Success");
                    return true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { dbConn.closeConnect(); }
            return false;
        }

        public bool ModifyExistingCourseRecord(int courseId, string newName, int newInstructorId)
        {
            try
            {
                dbConn.openConnect();
                string query = "UPDATE Course SET course_name = @newName, teacher_id = @newTId WHERE course_id = @cId";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@newTId", newInstructorId);
                cmd.Parameters.AddWithValue("@cId", courseId);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Course record updated successfully.", "Updated");
                    return true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message ); }
            finally { dbConn.closeConnect(); }
            return false;
        }

        public bool PermanentlyRemoveCourse(int targetId)
        {
            try
            {
                dbConn.openConnect();
                string query = "DELETE FROM Course WHERE course_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbConn.getconnection);
                cmd.Parameters.AddWithValue("@id", targetId);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Course has been removed from the system.", "Deleted");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: Check if students are still enrolled in this course.\n");
                Console.WriteLine(ex.Message    );
            }
            finally { dbConn.closeConnect(); }
            return false;
        }
    }
}
