using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            frmAdminDashboard_Load();
            this.Load += new EventHandler(AdminForm_Load);
        }

        AdminDashboardController _dashboardController = new AdminDashboardController();
        StudentController _studentController = new StudentController();


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControlContainer.Controls.Clear();
            userControlContainer.Controls.Add(userControl);
            userControlContainer.Show();
            userControl.BringToFront(); 
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            frmAdminDashboard_Load();
        }

        private void RefreshMostViolatedGrid()
        {
            // 1. First, load all violations normally
            _studentController.LoadViolationGrid(mostviolatedstudent_dgv);

            // 2. Immediately filter it to show ONLY the top offenders
            _dashboardController.FilterGridToTopViolators(mostviolatedstudent_dgv);
        }

        private void frmAdminDashboard_Load()
        {
            // One call to update all KPI labels
            _dashboardController.UpdateDashboardKPIs(totalStudent_label, totalFunds_label, allExpense_label);
            RefreshMostViolatedGrid();
            _dashboardController.LoadFundTransparencyGrid(fundTransparency_dgv);
            userControlContainer.Hide();

        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            // 1. Create the Pop-up with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out from the Admin Dashboard?",
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
            // If 'No' is clicked, the method ends and nothing happens (user stays on dashboard)

            //this.Hide();
            //new LoginForm().Show();
        }

        private void mostviolatedstudent_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard_Load();
        }

        private void fundTransparency_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kpi_container_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userAccountBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_USER_ACCOUNT());
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_STUDENT());
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

        private void userControlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
