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

        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void mostviolatedstudent_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard_Load();
        }
    }
}
