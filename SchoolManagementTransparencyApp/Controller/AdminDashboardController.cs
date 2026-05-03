using School_Management_Transparency.SchoolManagementTransparencyApp.Service;
using System;
using System.Collections.Generic;
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
                lblFunds.ForeColor = System.Drawing.Color.Black; // or your default color
            }

            lblExpenses.Text = "₱ " + _financialService.GetFormattedTotalExpenses();
        }

        public void FilterGridToTopViolators(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;

            // 1. Read the grid data
            var rows = dgv.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow && row.Cells["StudentName"].Value != null)
                .Select(row => new {
                    Name = row.Cells["StudentName"].Value.ToString()
                }).ToList();

            if (!rows.Any()) return;

            // 2. Count the violations for each student
            var counts = rows.GroupBy(r => r.Name)
                             .Select(g => new {
                                 StudentName = g.Key,
                                 TotalViolations = g.Count()
                             })
                             .OrderByDescending(c => c.TotalViolations)
                             .ToList();

            // 3. Find the highest number of violations
            int maxViolations = counts.First().TotalViolations;

            // 4. Update the grid to show ONLY the top students and their score
            dgv.DataSource = null;
            dgv.DataSource = counts.Where(c => c.TotalViolations == maxViolations).ToList();

            // Auto-resize columns for a cleaner look
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
