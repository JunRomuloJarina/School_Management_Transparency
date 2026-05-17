//using MySql.Data.MySqlClient;
//using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
//using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;

//namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
//{
//    internal class StudentDao
//    {

//        DatabaseConnection dbConn = new DatabaseConnection();

//        public bool AddStudent(Student student)
//        {
//            try
//            {
//                MySqlCommand command = new MySqlCommand("INSERT INTO student (user_id, first_name, middle_name, last_name, gender, address, date_of_birth, contact_number) VALUES (@UserId, @FirstName, @MiddleName, @LastName, @Gender, @Address, @DateOfBirth, @ContactNumber)", dbConn.getconnection); command.Parameters.AddWithValue("@UserId", student.UserId);
//                command.Parameters.AddWithValue("@FirstName", student.FirstName);
//                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
//                command.Parameters.AddWithValue("@LastName", student.LastName);
//                command.Parameters.AddWithValue("@Gender", student.Gender);
//                command.Parameters.AddWithValue("@Address", student.Address);
//                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
//                command.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);

//                dbConn.openConnect();
//                if (command.ExecuteNonQuery() == 1)
//                {
//                    dbConn.closeConnect();
//                    MessageBox.Show("Student added successfully.");
//                    return true;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return false;
//        }

//        public bool UpdateStudent(Student student)
//        {
//            try
//            {
//                MySqlCommand command = new MySqlCommand("UPDATE Student SET  first_name=@FirstName, middle_name=@MiddleName,last_name=@LastName, age=@Age, gender=@Gender, address=@Address, date_of_birth=@DOB, contact_number=@Contact WHERE student_id=@StudentId",dbConn.getconnection);
//                command.Parameters.AddWithValue("@FirstName", student.FirstName);
//                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
//                command.Parameters.AddWithValue("@LastName", student.LastName);
//                command.Parameters.AddWithValue("@Age", student.Age);
//                command.Parameters.AddWithValue("@Gender", student.Gender);
//                command.Parameters.AddWithValue("@Address", student.Address);
//                command.Parameters.AddWithValue("@DOB", student.DateOfBirth);
//                command.Parameters.AddWithValue("@Contact", student.ContactNumber);
//                command.Parameters.AddWithValue("@StudentId", student.StudentId);

//                dbConn.openConnect();

//                if (command.ExecuteNonQuery() == 1)
//                {
//                    dbConn.closeConnect();
//                    return true;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return false;
//        }


//        public bool DeleteStudent(int student_id)
//        {
//            try
//            {
//                MySqlCommand command = new MySqlCommand("DELETE FROM students WHERE student_id = @student_id", dbConn.getconnection);
//                command.Parameters.AddWithValue("@student_id", student_id);
//                dbConn.openConnect();

//                if (command.ExecuteNonQuery() == 1)
//                {
//                    dbConn.closeConnect();
//                    MessageBox.Show("Student deleted successfully.");
//                    return true;
//                }
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return false;
//        }

//        public Student GetStudentById(int studentId)
//        {
//            try
//            {
//                MySqlCommand command = new MySqlCommand("SELECT * FROM Student WHERE student_id = @StudentId", dbConn.getconnection);
//                command.Parameters.AddWithValue("@StudentId", studentId);

//                dbConn.openConnect();
//                using (MySqlDataReader reader = command.ExecuteReader())
//                {
//                    if (reader.Read()) 
//                    {
//                        Student student = new Student
//                        {
//                            StudentId = Convert.ToInt32(reader["student_id"]),
//                            UserId = Convert.ToInt32(reader["user_id"]),
//                            FirstName = reader["first_name"].ToString(),
//                            MiddleName = reader["middle_name"].ToString(),
//                            LastName = reader["last_name"].ToString(),
//                            Age = Convert.ToInt32(reader["age"]),
//                            Gender = reader["gender"].ToString(),
//                            Address = reader["address"].ToString(),
//                            DateOfBirth = Convert.ToDateTime(reader["dob"]),
//                            ContactNumber = reader["contact_number"].ToString()
//                        };

//                        dbConn.closeConnect();
//                        MessageBox.Show("Student retrieved successfully.");
//                        return student;
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return null;
//        }

//        public List<Student> GetAllStudent()
//        {
//            List<Student> students = new List<Student>();
//            try
//            {
//                MySqlCommand command = new MySqlCommand("SELECT * FROM Student", dbConn.getconnection);
//                dbConn.openConnect();

//                using (MySqlDataReader reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Student student = new Student
//                        {
//                            StudentId = Convert.ToInt32(reader["student_id"]),
//                            UserId = Convert.ToInt32(reader["user_id"]),
//                            FirstName = reader["first_name"].ToString(),
//                            MiddleName = reader["middle_name"].ToString(),
//                            LastName = reader["last_name"].ToString(),
//                            Age = Convert.ToInt32(reader["age"]),
//                            Gender = reader["gender"].ToString(),
//                            Address = reader["address"].ToString(),
//                            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
//                            ContactNumber = reader["contact_number"].ToString()
//                        };

//                        students.Add(student);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return students;
//        }


//        public List<dynamic> GetAllViolations()
//        {
//            List<dynamic> list = new List<dynamic>();
//            try
//            {
//                // Now using your actual schema to get the real Violation Name
//                string query = @"
//            SELECT s.first_name, s.last_name, vt.violation_name 
//            FROM student_violation sv
//            JOIN student s ON sv.student_id = s.student_id
//            JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id";

//                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
//                dbConn.openConnect();

//                using (MySqlDataReader reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        list.Add(new
//                        {
//                            StudentName = reader["first_name"].ToString() + " " + reader["last_name"].ToString(),
//                            ViolationType = reader["violation_name"].ToString() // Real data instead of placeholder
//                        });
//                    }
//                }
//            }
//            catch (Exception ex) { Console.WriteLine(ex.Message); }
//            finally { dbConn.closeConnect(); }
//            return list;
//        }

//        public DataTable GetStudentWithAccountDetails()
//        {
//            DataTable dt = new DataTable();
//            try
//            {
//                // Joining students with user_account based on user_id
//                string query = @"
//                    SELECT 
//                        s.student_id AS 'Student ID', 
//                        s.first_name AS 'First Name', 
//                        s.last_name AS 'Last Name',
//                        s.course AS 'Course',
//                        ua.username AS 'Account Name',
//                        ua.user_id AS 'User ID'
//                    FROM student s
//                    INNER JOIN user_account ua ON s.user_id = ua.user_id
//                    ORDER BY s.student_id DESC";

//                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
//                dbConn.openConnect();
//                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
//                adapter.Fill(dt);
//            }
//            catch (Exception ex) { Console.WriteLine(ex.Message); }
//            finally { dbConn.closeConnect(); }
//            return dt;
//        }

//        public DataTable GetStudentDebts(int studentId, string searchKeyword = "")
//        {
//            DataTable dt = new DataTable();
//            try
//            {
//                string query = @"SELECT 
//                            debt_id AS 'Debt ID', 
//                            fee_name AS 'Fee Description', 
//                            amount AS 'Total Amount', 
//                            balance_amount AS 'Remaining Balance', 
//                            status AS 'Status', 
//                            date_issued AS 'Date Issued' 
//                         FROM student_debts 
//                         WHERE student_id = @StudentId";

//                // Append search criteria if textbox has inputs
//                if (!string.IsNullOrWhiteSpace(searchKeyword))
//                {
//                    query += " AND (fee_name LIKE @Search OR status LIKE @Search)";
//                }

//                query += " ORDER BY date_issued DESC";

//                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
//                command.Parameters.AddWithValue("@StudentId", studentId);

//                if (!string.IsNullOrWhiteSpace(searchKeyword))
//                {
//                    command.Parameters.AddWithValue("@Search", "%" + searchKeyword.Trim() + "%");
//                }

//                dbConn.openConnect();
//                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
//                adapter.Fill(dt);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                dbConn.closeConnect();
//            }
//            return dt;
//        }

//    }
//}

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
    internal class StudentDao
    {
        private readonly DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddStudent(Student student)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO student (user_id, first_name, middle_name, last_name, age, gender, address, date_of_birth, contact_number) VALUES (@UserId, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Address, @DateOfBirth, @ContactNumber)", dbConn.getconnection);
                command.Parameters.AddWithValue("@UserId", student.UserId);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);

                dbConn.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Add Student Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MySqlCommand command = new MySqlCommand("UPDATE student SET first_name=@FirstName, middle_name=@MiddleName, last_name=@LastName, age=@Age, gender=@Gender, address=@Address, date_of_birth=@DOB, contact_number=@Contact WHERE student_id=@StudentId", dbConn.getconnection);
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
                MessageBox.Show("DAO Update Student Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM student WHERE student_id = @student_id", dbConn.getconnection);
                command.Parameters.AddWithValue("@student_id", student_id);
                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    dbConn.closeConnect();
                    MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Delete Student Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM student WHERE student_id = @StudentId", dbConn.getconnection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Student student = new Student
                        {
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : 0,
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = reader["age"] != DBNull.Value ? Convert.ToInt32(reader["age"]) : 0,
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
                            ContactNumber = reader["contact_number"].ToString()
                        };

                        dbConn.closeConnect();
                        return student;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO GetStudentById Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM student", dbConn.getconnection);
                dbConn.openConnect();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : 0,
                            FirstName = reader["first_name"].ToString(),
                            MiddleName = reader["middle_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = reader["age"] != DBNull.Value ? Convert.ToInt32(reader["age"]) : 0,
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
                MessageBox.Show("DAO GetAllStudents Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            ViolationType = reader["violation_name"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Violations Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return list;
        }

        public DataTable GetStudentWithAccountDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                    SELECT 
                        s.student_id AS 'Student ID', 
                        s.first_name AS 'First Name', 
                        s.last_name AS 'Last Name',
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
            catch (Exception ex)
            {
                MessageBox.Show("DAO Account Details Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }

        public DataTable GetStudentDebts(int studentId, string searchKeyword = "")
        {
            DataTable dt = new DataTable();
            try
            {
                // REWRITTEN QUERY: Uses actual schema components (student_violation, violation_type, income_transaction)
                // Outstanding balance calculates dynamically by subtracting aggregate paid income totals
                string query = @"
                    SELECT 
                        sv.student_violation_id AS 'Debt ID', 
                        vt.violation_name AS 'Fee Description', 
                        vt.fee AS 'Total Amount', 
                        CASE 
                            WHEN sv.status = 'PAID' THEN 0.00
                            ELSE (vt.fee - COALESCE((
                                SELECT SUM(it.amount) 
                                FROM income_transaction it 
                                WHERE it.student_violation_id = sv.student_violation_id
                            ), 0.00))
                        END AS 'Remaining Balance', 
                        sv.status AS 'Status', 
                        sv.date_issued AS 'Date Issued' 
                    FROM student_violation sv
                    INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
                    WHERE sv.student_id = @StudentId";

                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    query += " AND (vt.violation_name LIKE @Search OR sv.status LIKE @Search)";
                }

                query += " ORDER BY sv.date_issued DESC";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    command.Parameters.AddWithValue("@Search", "%" + searchKeyword.Trim() + "%");
                }

                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Schema Alignment Failure: " + ex.Message, "SQL Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }

        public DataTable GetStudentPaymentHistory(int studentId, string searchKeyword = "")
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT 
                it.income_transaction_id AS 'Receipt ID',
                vt.violation_name AS 'Payment For',
                fc.fund_name AS 'Fund Category',
                it.amount AS 'Amount Paid',
                it.transaction_date AS 'Date Paid',
                it.remarks AS 'Remarks'
            FROM income_transaction it
            INNER JOIN student_violation sv ON it.student_violation_id = sv.student_violation_id
            INNER JOIN violation_type vt ON sv.violation_type_id = vt.violation_type_id
            INNER JOIN fund_category fc ON it.fund_id = fc.fund_id
            WHERE it.student_id = @StudentId";

                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    query += " AND (vt.violation_name LIKE @Search OR fc.fund_name LIKE @Search OR it.remarks LIKE @Search)";
                }

                query += " ORDER BY it.transaction_date DESC, it.income_transaction_id DESC";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    command.Parameters.AddWithValue("@Search", "%" + searchKeyword.Trim() + "%");
                }

                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Payment History Error: " + ex.Message, "SQL Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }

        public DataTable GetExpenseTransparencyLog()
        {
            DataTable dt = new DataTable();
            try
            {
                // FIX: Changed INNER JOIN to LEFT JOIN for fund_category and student.
                // This forces all records from expense_transaction to load, even if student_id is empty or unlinked.
                string query = @"
                    SELECT 
                        et.expense_transaction_id AS 'Transaction ID',
                        et.remarks AS 'Expense Description',
                        et.amount AS 'Amount Spent',
                        COALESCE(fc.fund_name, 'General Fund') AS 'Fund Source',
                        CASE 
                            WHEN s.student_id IS NULL THEN 'System / Administrator'
                            ELSE CONCAT(s.first_name, ' ', s.last_name)
                        END AS 'Authorized By / Spent For',
                        et.transaction_date AS 'Date Spent'
                    FROM expense_transaction et
                    LEFT JOIN fund_category fc ON et.fund_id = fc.fund_id
                    LEFT JOIN student s ON et.student_id = s.student_id
                    ORDER BY et.transaction_date DESC, et.expense_transaction_id DESC";

                MySqlCommand command = new MySqlCommand(query, dbConn.getconnection);

                dbConn.openConnect();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAO Expense Log Error: " + ex.Message, "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return dt;
        }
    }
}