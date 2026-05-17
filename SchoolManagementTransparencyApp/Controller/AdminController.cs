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
    internal class AdminController
    {
        private readonly AdminService _adminService = new AdminService();

        public (decimal totalIncome, decimal totalExpense, decimal netBalance) GetReportMetrics()
        {
            try
            {
                DataTable dt = _adminService.GetFinancialReportData();
                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal income = Convert.ToDecimal(dt.Rows[0]["TotalIncome"]);
                    decimal expense = Convert.ToDecimal(dt.Rows[0]["TotalExpense"]);
                    decimal balance = Convert.ToDecimal(dt.Rows[0]["NetBalance"]);

                    return (income, expense, balance);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Report Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (0, 0, 0); // Default fallback
        }

        public DataTable GetTopViolatorsReport()
        {
            try
            {
                return _adminService.GetTopViolatorsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller Violators Report Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}
