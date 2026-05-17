using School_Management_Transparency.SchoolManagementTransparencyApp.AdminDashboardUserControls;
using School_Management_Transparency.SchoolManagementTransparencyApp.UserControls;
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
    public partial class SboForm : Form
    {
        public SboForm()
        {
            InitializeComponent();
            addUserControl(new UC_HOME());
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentContainerPanel.Controls.Clear();
            contentContainerPanel.Controls.Add(userControl);
            contentContainerPanel.Show();
            userControl.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_HOME());
        }

        private void studentViolationBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_STUDENT_VIOLATION());
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_INCOME());
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_EXPENSE());
        }

        private void fundBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_FUND());
        }

        private void contentContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            // 1. Create the Pop-up with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out from the SBO Dashboard?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 2. Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Close or hide current dashboard
                this.Hide();

                // Redirect back to Login
                LoginForm login = new LoginForm();
                login.Show();

            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }
    }
}
