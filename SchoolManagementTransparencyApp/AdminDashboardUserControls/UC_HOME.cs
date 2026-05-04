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
    public partial class UC_HOME : UserControl
    {
        public UC_HOME()
        {
            InitializeComponent();
        }

        AdminDashboardController _dashboardController = new AdminDashboardController();
        StudentController _studentController = new StudentController();

        private void UC_HOME_Load(object sender, EventArgs e)
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

        }
    }
}
