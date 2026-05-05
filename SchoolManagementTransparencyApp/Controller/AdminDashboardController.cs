using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Controller
{
    internal class AdminDashboardController
    {
        FinancialService _financialService = new FinancialService();

        public void UpdateDashboardKPIs(Label lblStudents, Label lblFunds, Label lblExpenses)
        {
            lblStudents.Text = _financialService.GetTotalStudents();

            decimal netFunds = decimal.Parse(_financialService.GetFormattedTotalFunds());
            lblFunds.Text = "₱ " + netFunds.ToString("N2");

            // Visual Cue: If balance is low or negative
            if (netFunds < 0)
            {
                lblFunds.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblFunds.ForeColor = System.Drawing.Color.YellowGreen; // or your default color
            }

            lblExpenses.Text = "₱ " + _financialService.GetFormattedTotalExpenses();
        }


        public void FilterGridToTopViolators(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;

            // 1. Extract names from the grid (populated by the Service/DAO)
            var rows = dgv.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow && row.Cells["StudentName"].Value != null)
                .Select(row => new {
                    Name = row.Cells["StudentName"].Value.ToString()
                }).ToList();

            if (!rows.Any()) return;

            // 2. Group by Name and Count occurrences
            // We sort by Count (Descending) so the biggest offender is at the top
            var leaderboard = rows.GroupBy(r => r.Name)
                                 .Select(g => new {
                                     StudentName = g.Key,
                                     TotalViolations = g.Count()
                                 })
                                 .OrderByDescending(c => c.TotalViolations)
                                 .ToList();

            // 3. Bind the entire sorted list to the Grid
            dgv.DataSource = null;
            dgv.DataSource = leaderboard;

            // 4. UI Cleanup: Make it look like a professional leaderboard
            if (dgv.Columns["StudentName"] != null) dgv.Columns["StudentName"].HeaderText = "Student Name";
            if (dgv.Columns["TotalViolations"] != null) dgv.Columns["TotalViolations"].HeaderText = "Violation Count";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public void LoadFundTransparencyGrid(DataGridView dgv)
        {
            // 1. Fetch the data from the DAO (or Service)
            var fundData = _financialService.GetFundLeaderboard();

            if (fundData == null || fundData.Count == 0) return;

            // 2. Bind to Grid
            dgv.DataSource = null;
            dgv.DataSource = fundData;

            // 3. Format the Balance column as Currency
            if (dgv.Columns["Balance"] != null)
            {
                dgv.Columns["Balance"].DefaultCellStyle.Format = "₱ #,##0.00";
                dgv.Columns["Balance"].HeaderText = "Available Balance";
            }

            if (dgv.Columns["Category"] != null) dgv.Columns["Category"].HeaderText = "Fund Category";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void UpdateUserRoleKPIs(Label lblAdmin, Label lblStudent, Label lblSbo)
        {
            var stats = _financialService.GetDashboardUserStats();

            lblAdmin.Text = stats["ADMIN"].ToString();
            lblStudent.Text = stats["STUDENT"].ToString();
            lblSbo.Text = stats["SBO"].ToString();
        }

        public void ExecuteUserSearch(DataGridView dgv, string term)
        {
            DataTable results = _financialService.GetUserSearchResults(term);

            dgv.DataSource = results;

            // Formatting for the grid
            if (dgv.Columns["user_id"] != null) dgv.Columns["user_id"].HeaderText = "ID";
            if (dgv.Columns["username"] != null) dgv.Columns["username"].HeaderText = "Username";
            if (dgv.Columns["password"] != null) dgv.Columns["password"].HeaderText = "Password";
            if (dgv.Columns["role"] != null) dgv.Columns["role"].HeaderText = "Access Role";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
