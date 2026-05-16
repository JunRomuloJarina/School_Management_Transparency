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

namespace School_Management_Transparency.SchoolManagementTransparencyApp.STUDENT_UC
{
    public partial class STUDENT_UC_HOME : UserControl
    {
        public STUDENT_UC_HOME()
        {
            InitializeComponent();
        }
        AdminDashboardController _dashboardController = new AdminDashboardController();
        StudentController _studentController = new StudentController();

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STUDENT_UC_HOME_Load(object sender, EventArgs e)
        {
            frmAdminDashboard_Load();
        }

        private void RefreshMostViolatedGrid()
        {
            // We bypass the old logic and call the new Unpaid Leaderboard
            _dashboardController.LoadUnpaidLeaderboard(fundTransparency_dgv);

            // UI Cleanup: Ensure it fills the panel nicely
            fundTransparency_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Aesthetic: Remove row headers for a cleaner 'Dashboard' look
            fundTransparency_dgv.RowHeadersVisible = false;
        }

        private void frmAdminDashboard_Load()
        {
            // One call to update all KPI labels
            _dashboardController.UpdateDashboardKPIs(totalStudent_label, totalFunds_label, allExpense_label);
            RefreshMostViolatedGrid();
            _dashboardController.LoadFundTransparencyGrid(fundTransparency_dgv);
            RefreshOutstandingBalanceKPI();
        }

        private void RefreshOutstandingBalanceKPI()
        {
            DashboardDao dao = new DashboardDao();
            decimal amountOwed = dao.GetTotalOutstandingBalance();

            // Update your specific label
            totalUnpaidMoneyLabel.Text = "₱" + amountOwed.ToString("N2");

            // Optional: Make the text red to indicate it is a "debt" or "uncollected" amount
            totalUnpaidMoneyLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
        }

    }
}
