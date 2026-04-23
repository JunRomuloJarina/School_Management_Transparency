using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Controller
{
    internal class UserAccountController
    {

        private readonly UserAccountService _userService = new UserAccountService();

        // 1. Handle Login Logic
        public bool Login(string username, string password)
        {
            if (_userService.AuthenticateUser(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 2. Handle Logout
        public void Logout()
        {
            _userService.Logout();
        }

        // 3. Load all users into a management grid
        public void LoadUserGrid(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = _userService.GetAll();

                // Hide passwords for security in the UI
                if (dgv.Columns["Password"] != null) dgv.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
            }
        }

        // 4. Create a new account
        public bool RegisterUser(string username, string password, string role)
        {
            UserAccount newUser = new UserAccount
            {
                Username = username,
                Password = password,
                Role = role
            };

            string result = _userService.CreateAccount(newUser);

            if (result == "Account created successfully.")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Registration Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 5. Update existing account
        public bool EditAccount(int id, string username, string password, string role)
        {
            UserAccount user = new UserAccount(id, username, password, role);
            string result = _userService.UpdateAccount(user);

            if (result == "Account updated.") return true;

            MessageBox.Show(result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // 6. Delete an account
        public bool RemoveAccount(int id)
        {
            string result = _userService.DeleteAccount(id);
            if (result == "Account removed.") return true;

            MessageBox.Show(result, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public UserAccount GetUserById(int id)
        {
            return _userService.GetAll().FirstOrDefault(u => u.UserId == id);
        }


        public List<UserAccount> GetAllUsers()
        {
            return _userService.GetAll();
        }

        public string GetLoggedInUsername()
        {
            return UserAccountService.LoggedInUsername;
        }

        public string GetLoggedInUserRole()
        {
                return UserAccountService.LoggedInRole;
        }

        public int GetCurrentUserId()
        {
            return _userService.GetCurrentUserId();
        }

        public int GetUserIdByUsername(string username)
        {
            try
            {
                int id = _userService.GetIdFromUsername(username);

                if (id == 0)
                {
                    return 0;
                }

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Error: " + ex.Message);
                return 0;
            }
        }
    }
}
