using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    public partial class UC_USER_ACCOUNT : UserControl
    {
        public UC_USER_ACCOUNT()
        {
            InitializeComponent();
        }

        AdminDashboardController _dashboardController = new AdminDashboardController();
        private readonly UserAccountController _userController = new UserAccountController();

        private void RefreshDashboardData()
        {
            // Refresh the DataGridView
            _userController.LoadUserGrid(user_accountDGV);

            // Refresh the KPI labels at the top
            _dashboardController.UpdateUserRoleKPIs(adminCount_label, studentCount_label, sboCount_label);
        }

        private void ClearFields()
        {
            idTxtbox.Clear();
            usernameTxtbox.Clear();
            passwordTxtbox.Clear();
            roleTxtbox.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_USER_ACCOUNT_Load(object sender, EventArgs e)
        {
            _dashboardController.UpdateUserRoleKPIs(adminCount_label, studentCount_label, sboCount_label);
            // This uses your existing Controller method to fill the DGV
            _userController.LoadUserGrid(user_accountDGV);

            // Optional: Make the columns look professional
            //user_accountDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 1. Setup Auto-Suggest for the Role TextBox
            roleTxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            roleTxtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection roles = new AutoCompleteStringCollection();
            roles.Add("ADMIN");
            roles.Add("STUDENT");
            roles.Add("SBO");

            roleTxtbox.AutoCompleteCustomSource = roles;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string term = searchTextbox.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                _userController.LoadUserGrid(user_accountDGV); //
            }
            else
            {
                // Use the controller search that filters the List<UserAccount>
                _userController.SearchUsers(user_accountDGV, term);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {


            //string role = roleTxtbox.Text.Trim().ToUpper();
            //string[] validRoles = { "ADMIN", "STUDENT", "SBO" };

            //// Strict validation to prevent invalid database entries
            //if (!validRoles.Contains(role))
            //{
            //    MessageBox.Show("Invalid Role! Please use: ADMIN, STUDENT, or SBO.",
            //                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            // 1. Basic Validation
            if (string.IsNullOrWhiteSpace(usernameTxtbox.Text) ||
                string.IsNullOrWhiteSpace(passwordTxtbox.Text) ||
                string.IsNullOrWhiteSpace(roleTxtbox.Text))
            {
                MessageBox.Show("Please fill in all fields (Username, Password, and Role).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Call the Controller to register the user
            bool isSuccess = _userController.RegisterUser(
                usernameTxtbox.Text.Trim(),
                passwordTxtbox.Text.Trim(),
                roleTxtbox.Text.Trim()
            );

            if (isSuccess)
            {
                MessageBox.Show("New user account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Refresh UI
                RefreshDashboardData();
                ClearFields();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {


            // 1. Validation: Ensure an ID is selected
            if (string.IsNullOrEmpty(idTxtbox.Text))
            {
                MessageBox.Show("Please select a user from the list first.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Collect updated data
            int id = int.Parse(idTxtbox.Text);
            string username = usernameTxtbox.Text.Trim();
            string password = passwordTxtbox.Text.Trim(); // Logic in controller handles if this is empty
            string role = roleTxtbox.Text.Trim();

            // 3. Call your controller (which you already have defined)
            bool success = _userController.EditAccount(id, username, password, role);

            if (success)
            {
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Refresh the grid and KPIs
                _userController.LoadUserGrid(user_accountDGV);
                _dashboardController.UpdateUserRoleKPIs(adminCount_label, studentCount_label, sboCount_label);

                // 5. Clear fields
                idTxtbox.Clear();
                usernameTxtbox.Clear();
                passwordTxtbox.Clear();
                roleTxtbox.Clear();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 1. Ensure a user is selected (check the ID textbox)
            if (string.IsNullOrEmpty(idTxtbox.Text))
            {
                MessageBox.Show("Please select a user from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = int.Parse(idTxtbox.Text);
            string username = usernameTxtbox.Text;

            // 2. Confirmation Pop-up
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete the account for '{username}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                // 3. Call Controller to remove
                if (_userController.RemoveAccount(userId))
                {
                    MessageBox.Show("Account removed successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Refresh UI
                    RefreshDashboardData();
                    ClearFields();
                }
            }
        }

        private void idTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_accountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 1. Check if the clicked row index is valid (prevents crashing on header clicks)
                if (e.RowIndex >= 0)
                {
                    // 2. Get the selected row
                    DataGridViewRow row = user_accountDGV.Rows[e.RowIndex];

                    // 3. Map the cell values to your TextBoxes
                    // Ensure the names in quotes [""] match exactly with your Model properties 
                    // or the Database column names displayed in the grid.
                    idTxtbox.Text = row.Cells["UserId"].Value?.ToString();
                    usernameTxtbox.Text = row.Cells["Username"].Value?.ToString();
                    passwordTxtbox.Text = row.Cells["Password"].Value?.ToString();
                    roleTxtbox.Text = row.Cells["Role"].Value?.ToString();
                }


            } catch (Exception ex)
            {
            } 
        }
    }
}
