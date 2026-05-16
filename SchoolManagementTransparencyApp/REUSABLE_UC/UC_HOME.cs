using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
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
            // We bypass the old logic and call the new Unpaid Leaderboard
            _dashboardController.LoadUnpaidLeaderboard(mostviolatedstudent_dgv);

            // UI Cleanup: Ensure it fills the panel nicely
            mostviolatedstudent_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Aesthetic: Remove row headers for a cleaner 'Dashboard' look
            mostviolatedstudent_dgv.RowHeadersVisible = false;
        }
        private void frmAdminDashboard_Load()
        {
            // One call to update all KPI labels
            _dashboardController.UpdateDashboardKPIs(totalStudent_label, totalFunds_label, allExpense_label);
            RefreshMostViolatedGrid();
            _dashboardController.LoadFundTransparencyGrid(fundTransparency_dgv);
            RefreshOutstandingBalanceKPI();
        }

        private void totalFunds_label_Click(object sender, EventArgs e)
        {

        }



        private void RefreshOutstandingBalanceKPI()
        {
            DashboardDao dao = new DashboardDao();
            decimal amountOwed = dao.GetTotalOutstandingBalance();

            // Update your specific label
            totalUnpaidMoneyLabel.Text = "₱" + amountOwed.ToString("N2");

            totalUnpaidMoneyLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
        }

        private void mostviolatedstudent_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
