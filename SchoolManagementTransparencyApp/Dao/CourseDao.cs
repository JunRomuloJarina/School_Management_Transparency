using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
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
                        TeacherId = reader.GetString("teacher_id")
                    };
                    courses.Add(course);
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
                MessageBox.Show(ex.Message);
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
                        TeacherId = reader.GetString("teacher_id")
                    };
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
            return course;
        }

    }
}
