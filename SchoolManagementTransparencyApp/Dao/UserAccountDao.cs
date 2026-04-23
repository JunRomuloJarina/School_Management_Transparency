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
    internal class UserAccountDao
    {
        DatabaseConnection dbConn = new DatabaseConnection();

        // 1. Add User Account
        public bool AddUserAccount(UserAccount user)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO User_Account (username, password, role) VALUES (@Username, @Password, @Role)",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);

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

        // 2. Update User Account
        public bool UpdateUserAccount(UserAccount user)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE User_Account SET username=@Username, password=@Password, role=@Role WHERE user_id=@UserId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@UserId", user.UserId);

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

        // 3. Delete User Account
        public bool DeleteUserAccount(int userId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM User_Account WHERE user_id=@UserId", dbConn.getconnection);
                command.Parameters.AddWithValue("@UserId", userId);

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

        // 4. Get All User Accounts
        public List<UserAccount> GetAllUserAccounts()
        {
            List<UserAccount> users = new List<UserAccount>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM User_Account", dbConn.getconnection);
                dbConn.openConnect();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserAccount user = new UserAccount
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString()
                        };
                        users.Add(user);
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
            return users;
        }

        // 5. Get User By ID (Search)
        public UserAccount GetUserById(int userId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM User_Account WHERE user_id=@UserId", dbConn.getconnection);
                command.Parameters.AddWithValue("@UserId", userId);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserAccount
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString()
                        };
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


        public bool Login(string username, string password)
        {
            try
            {
                // Using BINARY to ensure case-sensitive comparison for both username and password
                MySqlCommand command = new MySqlCommand(
                    "SELECT COUNT(*) FROM User_Account WHERE BINARY username = @Username AND BINARY password = @Password",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                dbConn.openConnect();

                // ExecuteScalar is used because we only need to retrieve a single value (the count)
                int userCount = Convert.ToInt32(command.ExecuteScalar());

                if (userCount == 1)
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

        public string GetRoleByUsername(string username)
        {
            try
            {
                // Using BINARY to ensure we find the exact case-sensitive username
                MySqlCommand command = new MySqlCommand(
                    "SELECT role FROM User_Account WHERE BINARY username = @Username",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Username", username);

                dbConn.openConnect();

                // ExecuteScalar is ideal here as we are fetching a single string value
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    dbConn.closeConnect();
                    return result.ToString();
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


        public int GetUserIdByUsername(string username)
        {
            try
            {
                // Using BINARY for case-sensitivity to match your Login logic
                MySqlCommand command = new MySqlCommand(
                    "SELECT user_id FROM User_Account WHERE BINARY username = @Username",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@Username", username);

                dbConn.openConnect();

                // ExecuteScalar is perfect here as we only need the ID (a single value)
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    dbConn.closeConnect();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving User ID: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }

            // Return 0 or -1 if the user is not found
            return 0;
        }




    }
}
