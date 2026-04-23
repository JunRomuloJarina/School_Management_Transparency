using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class UserAccountService
    {

        private readonly UserAccountDao _userDao = new UserAccountDao();

        // Static property to keep track of the person currently using the app
        public static string LoggedInUsername { get; private set; }
        public static string LoggedInRole { get; private set; }

        public bool AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            bool isValid = _userDao.Login(username, password);

            if (isValid)
            {
                LoggedInUsername = username;
                LoggedInRole = _userDao.GetRoleByUsername(username);
                return true;
            }

            return false;
        }

        public string CreateAccount(UserAccount user)
        {
            if (user == null) return "User data is missing.";
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                return "Username and Password are required.";

            // Role validation based on your Enum in SQL
            if (string.IsNullOrWhiteSpace(user.Role)) user.Role = "STUDENT";

            return _userDao.AddUserAccount(user)
                ? "Account created successfully."
                : "Failed to create account. Username might already exist.";
        }

        public string UpdateAccount(UserAccount user)
        {
            if (user.UserId <= 0) return "Invalid user selection.";
            return _userDao.UpdateUserAccount(user) ? "Account updated." : "Update failed.";
        }

        public string DeleteAccount(int id)
        {
            if (id <= 0) return "Invalid user ID.";
            return _userDao.DeleteUserAccount(id) ? "Account removed." : "Delete failed.";
        }

        public List<UserAccount> GetAll() => _userDao.GetAllUserAccounts();

        public void Logout()
        {
            LoggedInUsername = null;
            LoggedInRole = null;
        }

        public int GetCurrentUserId()
        {
            if (string.IsNullOrEmpty(LoggedInUsername)) return 0;
            return _userDao.GetUserIdByUsername(LoggedInUsername);
        }

        public int GetIdFromUsername(string username)
        {
            // Basic validation: Don't query the DB if the string is empty
            if (string.IsNullOrWhiteSpace(username))
            {
                return 0;
            }

            // Call the DAO method you just created
            return _userDao.GetUserIdByUsername(username);
        }
    }
}
