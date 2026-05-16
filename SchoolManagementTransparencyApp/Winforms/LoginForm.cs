using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Winfroms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private StudentController studentController = new StudentController();
        private UserAccountController userAccountController = new UserAccountController();
        StudentAccountDao _dao = new StudentAccountDao();
        private IButtonControl signInBtn;

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Fetch and bind courses to your dropdown
            DataTable courses = _dao.GetAvailableCourses();
            courseCombo.DataSource = courses;
            courseCombo.DisplayMember = "course_name";
            courseCombo.ValueMember = "course_id";
            courseCombo.SelectedIndex = -1; // Start empty
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            CreateAccountContainerPanel.Visible = true;
            LoginContainerPanel.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            String username = usernameLoginTxtbox.Text;
            String password = passwordLoginTxtbox.Text;

            bool result = userAccountController.Login(username, password);

            if (result)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string role = userAccountController.GetLoggedInUserRole();

                if (role != null)
                {
                    if (role.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
                    {
                        new AdminForm().Show();
                        ClearLogin(); // Clear login fields after successful login
                    }
                    else if (role.Equals("SBO", StringComparison.OrdinalIgnoreCase))
                    {
                        new SboForm().Show();
                        ClearLogin();
                    }
                    else if (role.Equals("STUDENT", StringComparison.OrdinalIgnoreCase))
                    {
                        new StudentForm().Show();
                        ClearLogin();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role assigned to the user.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    this.Hide(); // Hide login form after successful login

                }
                else
                {
                    MessageBox.Show("Failed to retrieve user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void cuiLabel3_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccountContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clear()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            middleNameTextBox.Clear();
            addressTextBox.Clear();
            contactNumberTextBox.Clear();
            usernameCreateTxtBox.Clear();
            passwordCreateTxtBox.Clear() ;
        }
        
        private void ClearLogin()
        {
            usernameLoginTxtbox.Clear();
            passwordLoginTxtbox.Clear();    
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginContainerPanel.Visible = true;
            CreateAccountContainerPanel.Visible = false;
            Clear();
            
        }

        private void dateOfBirtchDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordLoginTxtbox.PasswordChar = showPassword.Checked ? '\0' : '●';
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //var isValidInput = new LoginInputValidator().ValidateLoginInput(usernameCreateTxtBox.Text, passwordCreateTxtBox.Text);
            //var isValidStudentInput = new StudentCreateInputValidator().ValidateStudentInput(firstNameTextBox.Text, lastNameTextBox.Text);

            //if (!isValidStudentInput)
            //{
            //    MessageBox.Show("Invalid student information. Please check the first name and last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (!isValidInput)
            //{
            //    MessageBox.Show("Invalid input. Please check your username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //int age = DateTime.Now.Year - dateOfBirtchDatePicker.Value.Year;

            //bool userAccountCreated = userAccountController.RegisterUser(
            //    usernameCreateTxtBox.Text,
            //    passwordCreateTxtBox.Text,
            //    "STUDENT" // Default role for new accounts
            //);

            ////get the userId of the newly created account to link with the student record
            //int getCurrentId = userAccountController.GetUserIdByUsername( usernameCreateTxtBox.Text );

            //if ( userAccountCreated ) {

            //    bool studentAccountCreated = studentController.AddNewStudent(
            //       firstNameTextBox.Text,
            //       middleNameTextBox.Text,
            //       lastNameTextBox.Text,
            //       age,
            //       genderComboBox.SelectedItem?.ToString() ?? "",
            //       addressTextBox.Text,
            //       dateOfBirtchDatePicker.Value,
            //       contactNumberTextBox.Text,
            //       getCurrentId // Placeholder for userId, should be linked to the created user account
            //    );

            //    //MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    if( studentAccountCreated )
            //    {
            //        new StudentForm().Show(); // Open the student dashboard
            //        this.Hide(); // Hide the login form after successful account creation
            //    }

            //}

            // 1. Validation
            var isValidInput = new LoginInputValidator().ValidateLoginInput(usernameCreateTxtBox.Text, passwordCreateTxtBox.Text);
            var isValidStudentInput = new StudentCreateInputValidator().ValidateStudentInput(firstNameTextBox.Text, lastNameTextBox.Text);

            if (!isValidStudentInput || !isValidInput)
            {
                MessageBox.Show("Please check your input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (courseCombo.SelectedValue == null)
            {
                MessageBox.Show("Please select a course to enroll in.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Data Preparation
            int age = DateTime.Now.Year - dateOfBirtchDatePicker.Value.Year;
            int selectedCourseId = Convert.ToInt32(courseCombo.SelectedValue);

            // 3. The Unified Transaction (User + Student + Enrollment)
            bool registrationSuccess = _dao.CreateStudentWithAccount(
                firstNameTextBox.Text.Trim(),
                middleNameTextBox.Text.Trim(),
                lastNameTextBox.Text.Trim(),
                age,
                genderComboBox.SelectedItem?.ToString() ?? "",
                addressTextBox.Text.Trim(),
                dateOfBirtchDatePicker.Value,
                contactNumberTextBox.Text.Trim(),
                usernameCreateTxtBox.Text.Trim(),
                passwordCreateTxtBox.Text.Trim(),
                "STUDENT",        // Default Role
                selectedCourseId  // New Enrollment link
            );

            // 4. Result Handling
            if (registrationSuccess)
            {
                MessageBox.Show("Registration Successful! Welcome to the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the dashboard
                new StudentForm().Show();
                this.Hide();
                Clear(); // Clear the form for next time (optional since we're hiding it)
            }
            // No 'else' needed here because the DAO already shows a MessageBox if it fails

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // 1. If empty, stop here
            if (string.IsNullOrEmpty(contactNumberTextBox.Text)) return;

            // 2. Filter out anything that isn't a digit
            string cleanText = new string(contactNumberTextBox.Text.Where(char.IsDigit).ToArray());

            // 3. Enforce the DB limit (your schema uses VARCHAR(20))
            if (cleanText.Length > 20)
            {
                cleanText = cleanText.Substring(0, 20);
            }

            // 4. Update the textbox ONLY if it's different (prevents infinite loops)
            if (contactNumberTextBox.Text != cleanText)
            {
                contactNumberTextBox.Text = cleanText;

                // Put the cursor at the end so it doesn't jump to the start
                contactNumberTextBox.SelectionStart = contactNumberTextBox.Text.Length;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
