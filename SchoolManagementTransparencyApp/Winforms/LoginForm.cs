using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
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




        private void Login_Form_Load(object sender, EventArgs e)
        {

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
                        AdminForm adminDashboard = new AdminForm();
                        adminDashboard.Show();
                    }
                    else if (role.Equals("SBO", StringComparison.OrdinalIgnoreCase))
                    {
                        SboForm sboForm = new SboForm();
                        sboForm.Show();
                    }
                    else if (role.Equals("STUDENT", StringComparison.OrdinalIgnoreCase))
                    {
                        StudentForm studentForm = new StudentForm();
                        studentForm.Show();
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
            this.Close();
        }

        private void CreateAccountContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginContainerPanel.Visible = true;
            CreateAccountContainerPanel.Visible = false;
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
    }
}
