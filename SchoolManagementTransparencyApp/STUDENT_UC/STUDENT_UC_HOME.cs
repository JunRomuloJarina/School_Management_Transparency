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

            // Wire up the load handler explicitly to ensure it runs automatically
            this.Load += new System.EventHandler(this.STUDENT_UC_HOME_Load);
            // 1. Tell the grid to allow custom height adjustments (Disable auto-sizing based on content)
            homeExpenseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // 2. Assign the explicit pixel height value
            homeExpenseDGV.ColumnHeadersHeight = 50;
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

        private void LoadTransparencyReport()
        {
            try
            {
                if (homeExpenseDGV != null)
                {
                    _studentController.LoadExpenseTransparencyGrid(homeExpenseDGV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UI Data Population Error: " + ex.Message, "Form Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadTransparencyReport();
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
