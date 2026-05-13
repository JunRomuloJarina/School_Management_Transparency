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
    public partial class UC_FUND : UserControl
    {
        public UC_FUND()
        {
            InitializeComponent();
        }

        FundCategoryDao _fundDao = new FundCategoryDao();
        int selectedFundId = -1;


        private void UC_FUND_Load(object sender, EventArgs e)
        {
            RefreshFundDashboard();
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
    }
}
