using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    public partial class UC_FUND : UserControl
    {
        public UC_FUND()
        {
            InitializeComponent();
        }

        private readonly AdminController _adminController = new AdminController();

        // Define WinForms Printing Objects
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        // Setup separate printing objects for this specific report
        private PrintDocument violationPrintDocument = new PrintDocument();
        private PrintPreviewDialog violationPreviewDialog = new PrintPreviewDialog();

        FundCategoryDao _fundDao = new FundCategoryDao();
        int selectedFundId = -1;


        private void UC_FUND_Load(object sender, EventArgs e)
        {
            RefreshFundDashboard();
            // Wire up the print page drawing logic
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            violationPrintDocument.PrintPage += new PrintPageEventHandler(ViolationPrintDocument_PrintPage);
        }

        public void RefreshFundDashboard()
        {
            // 1. Update the Big Summary Label
            decimal totalBalance = _fundDao.GetTotalSchoolBalance();
            lblTotalSchoolBalance.Text = $"Total Available School Funds: ₱ {totalBalance:N2}";
            // 2. Load the Detailed Grid
            DataTable dt = _fundDao.GetFundSummaryTable();
            fundSummaryDGV.DataSource = dt;

            // 3. Format the Grid
            if (fundSummaryDGV.Columns["ID"] != null) fundSummaryDGV.Columns["ID"].Visible = false;
            fundSummaryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Format all money columns to Currency
            string[] moneyCols = { "Total Income", "Total Expenses", "Current Balance" };
            foreach (string col in moneyCols)
            {
                if (fundSummaryDGV.Columns[col] != null)
                {
                    fundSummaryDGV.Columns[col].DefaultCellStyle.Format = "N2";
                    fundSummaryDGV.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void btnAddFund_Click(object sender, EventArgs e)
        {
            string newFund = txtNewFundName.Text.Trim();
            if (string.IsNullOrEmpty(newFund)) return;

            if (_fundDao.AddNewFundCategory(newFund))
            {
                MessageBox.Show("New Fund Category Added!", "Success");
                txtNewFundName.Clear();
                RefreshFundDashboard();
            }
        }

        private void fundSummaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = fundSummaryDGV.Rows[e.RowIndex];
                selectedFundId = Convert.ToInt32(row.Cells["ID"].Value);
                txtNewFundName.Text = row.Cells["Fund Name"].Value.ToString();

                // Change button text to indicate we are in "Edit Mode"
                btnAddFund.Text = "Update Fund";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedFundId == -1) { MessageBox.Show("Please select a fund from the list first."); return; }

            string updatedName = txtNewFundName.Text.Trim();
            if (string.IsNullOrEmpty(updatedName)) return;

            if (_fundDao.UpdateFundCategory(selectedFundId, updatedName))
            {
                MessageBox.Show("Fund name updated successfully!");
                ResetFundForm();
                RefreshFundDashboard();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFundId == -1) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this fund? This action cannot be undone.",
                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (_fundDao.DeleteFundCategory(selectedFundId))
                {
                    MessageBox.Show("Fund deleted.");
                    ResetFundForm();
                    RefreshFundDashboard();
                }
            }
        }

        private void ResetFundForm()
        {
            selectedFundId = -1;
            txtNewFundName.Clear();
            btnAddFund.Text = "Create Fund";
        }

        private void txtNewFundName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalSchoolBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewFundName.Clear();
        }

       

        private void printReportBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 800;
            printPreviewDialog.Height = 1000;
            printPreviewDialog.ShowDialog(); // Opens a preview before actually sending to printer
        }

        // The Engine: This draws the text exactly how it will look on A4 Paper
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // 1. Setup Fonts and Formatting
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font subtitleFont = new Font("Arial", 14, FontStyle.Italic);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12, FontStyle.Regular);

            int yPos = 50; // Starting Y coordinate
            int xCenter = e.PageBounds.Width / 2;

            // 2. Draw Official Headers
            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;

            e.Graphics.DrawString("SCHOOL TRANSPARENCY SYSTEM", titleFont, Brushes.Black, xCenter, yPos, centerFormat);
            yPos += 30;
            e.Graphics.DrawString("Master Financial Transparency Report", subtitleFont, Brushes.DimGray, xCenter, yPos, centerFormat);
            yPos += 50;

            // 3. Draw Meta Data (Date & Admin Identity)
            e.Graphics.DrawLine(Pens.Black, 50, yPos, e.PageBounds.Width - 50, yPos); // Line separator
            yPos += 15;
            e.Graphics.DrawString($"Generated On: {DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt")}", regularFont, Brushes.Black, 50, yPos);
            yPos += 25;
            e.Graphics.DrawString($"Generated By: {UserSession.CurrentRole} - {UserSession.CurrentUsername}", regularFont, Brushes.Black, 50, yPos);
            yPos += 20;
            e.Graphics.DrawLine(Pens.Black, 50, yPos, e.PageBounds.Width - 50, yPos); // Line separator
            yPos += 50;

            // 4. Fetch the live data via Controller
            var metrics = _adminController.GetReportMetrics();

            // 5. Draw Financial Summaries
            e.Graphics.DrawString("--- FINANCIAL OVERVIEW ---", headerFont, Brushes.Black, xCenter, yPos, centerFormat);
            yPos += 40;

            e.Graphics.DrawString("Total Income Collected:", regularFont, Brushes.Black, 100, yPos);
            e.Graphics.DrawString(metrics.totalIncome.ToString("C2", new System.Globalization.CultureInfo("en-PH")), headerFont, Brushes.SeaGreen, 500, yPos);
            yPos += 30;

            e.Graphics.DrawString("Total Expenses Disbursed:", regularFont, Brushes.Black, 100, yPos);
            e.Graphics.DrawString(metrics.totalExpense.ToString("C2", new System.Globalization.CultureInfo("en-PH")), headerFont, Brushes.Crimson, 500, yPos);
            yPos += 40;

            // Highlight the final balance
            e.Graphics.DrawString("NET AVAILABLE BALANCE:", titleFont, Brushes.Black, 100, yPos);
            e.Graphics.DrawString(metrics.netBalance.ToString("C2", new System.Globalization.CultureInfo("en-PH")), titleFont, Brushes.SteelBlue, 500, yPos);
            yPos += 60;

            // 6. Draw Footer Statement
            e.Graphics.DrawString("This is a system-generated official document reflecting real-time database ledgers.", new Font("Arial", 9, FontStyle.Italic), Brushes.Gray, xCenter, e.PageBounds.Height - 50, centerFormat);
        }

        private void printViolatorsBtn_Click(object sender, EventArgs e)
        {
            violationPreviewDialog.Document = violationPrintDocument;
            violationPreviewDialog.Width = 800;
            violationPreviewDialog.Height = 1000;
            violationPreviewDialog.ShowDialog();
        }

        // The Engine: Draws a table of the top violators
        private void ViolationPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font subtitleFont = new Font("Arial", 12, FontStyle.Italic);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font rowFont = new Font("Arial", 11, FontStyle.Regular);

            int yPos = 50;
            int xCenter = e.PageBounds.Width / 2;
            int margin = 50;

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;

            // 1. Draw Headers
            e.Graphics.DrawString("SCHOOL TRANSPARENCY SYSTEM", titleFont, Brushes.Black, xCenter, yPos, centerFormat);
            yPos += 30;
            e.Graphics.DrawString("Disciplinary Action & Top Violators Report", subtitleFont, Brushes.Crimson, xCenter, yPos, centerFormat);
            yPos += 40;

            // 2. Draw Meta Data
            e.Graphics.DrawLine(Pens.Black, margin, yPos, e.PageBounds.Width - margin, yPos);
            yPos += 15;
            e.Graphics.DrawString($"Date: {DateTime.Now.ToString("MMMM dd, yyyy")}", rowFont, Brushes.Black, margin, yPos);
            yPos += 20;
            e.Graphics.DrawString($"Issuer: {UserSession.CurrentRole} - {UserSession.CurrentUsername}", rowFont, Brushes.Black, margin, yPos);
            yPos += 20;
            e.Graphics.DrawLine(Pens.Black, margin, yPos, e.PageBounds.Width - margin, yPos);
            yPos += 40;

            // 3. Setup Table Columns (X coordinates for spacing)
            int colRank = margin;
            int colName = margin + 50;
            int colCount = margin + 350;
            int colFines = margin + 550;

            // Draw Table Headers
            e.Graphics.DrawString("#", headerFont, Brushes.Black, colRank, yPos);
            e.Graphics.DrawString("STUDENT NAME", headerFont, Brushes.Black, colName, yPos);
            e.Graphics.DrawString("TOTAL VIOLATIONS", headerFont, Brushes.Black, colCount, yPos);
            e.Graphics.DrawString("TOTAL FINES", headerFont, Brushes.Black, colFines, yPos);
            yPos += 25;
            e.Graphics.DrawLine(Pens.Gray, margin, yPos, e.PageBounds.Width - margin, yPos);
            yPos += 15;

            // 4. Fetch Data and Draw Rows
            DataTable dt = _adminController.GetTopViolatorsReport();

            if (dt != null && dt.Rows.Count > 0)
            {
                int rank = 1;
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["StudentName"].ToString();
                    string count = row["ViolationCount"].ToString();
                    decimal fines = Convert.ToDecimal(row["TotalFines"]);

                    e.Graphics.DrawString(rank.ToString(), rowFont, Brushes.Black, colRank, yPos);
                    e.Graphics.DrawString(name, rowFont, Brushes.Black, colName, yPos);

                    // Highlight heavy violators in Red if they have more than 3 violations
                    Brush countBrush = Convert.ToInt32(count) > 3 ? Brushes.Crimson : Brushes.Black;
                    e.Graphics.DrawString(count, headerFont, countBrush, colCount, yPos);

                    e.Graphics.DrawString(fines.ToString("C2", new System.Globalization.CultureInfo("en-PH")), rowFont, Brushes.Black, colFines, yPos);

                    yPos += 30;
                    rank++;
                }
            }
            else
            {
                e.Graphics.DrawString("No violation records found.", subtitleFont, Brushes.Gray, xCenter, yPos + 20, centerFormat);
            }

            // 5. Draw Footer
            e.Graphics.DrawLine(Pens.Black, margin, e.PageBounds.Height - 60, e.PageBounds.Width - margin, e.PageBounds.Height - 60);
            e.Graphics.DrawString("End of Report", new Font("Arial", 9, FontStyle.Italic), Brushes.Gray, xCenter, e.PageBounds.Height - 40, centerFormat);
        }
    }
}
