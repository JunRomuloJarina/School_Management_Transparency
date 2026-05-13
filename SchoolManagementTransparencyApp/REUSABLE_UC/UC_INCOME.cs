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
    public partial class UC_INCOME : UserControl
    {
        public UC_INCOME()
        {
            InitializeComponent();
        }

        private void UC_INCOME_Load(object sender, EventArgs e)
        {
            LoadCourseFilter();
            ShowAllIncome();
            RefreshKPIs();
            LoadFundSelection();
            UpdateFilteredKPIs();
        }

        StudentViolationDao _violationDao = new StudentViolationDao();
        int selectedRecordId = -1;

        private void LoadFundSelection()
        {
            DataTable dt = _violationDao.GetFundCategories();
            comboFundSelect.DataSource = dt;
            comboFundSelect.DisplayMember = "fund_name"; // Shows the Name to the Admin
            comboFundSelect.ValueMember = "fund_id";     // Keeps the ID in the background
        }
        private void HideIdColumns()
        {
            // We check if the column exists first to prevent the program from crashing
            if (incomeDGV.Columns.Contains("Record ID"))
                incomeDGV.Columns["Record ID"].Visible = false;

            if (incomeDGV.Columns.Contains("Student ID"))
                incomeDGV.Columns["Student ID"].Visible = false;

            // Professional touch: Auto-size the remaining columns to fill the space
            incomeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateFilteredKPIs()
        {
            try
            {
                decimal filteredPaid = 0;
                decimal filteredUnpaid = 0;

                foreach (DataGridViewRow row in incomeDGV.Rows)
                {
                    // Use the index or ensure the string matches your SQL 'AS' alias exactly
                    // Based on your DAO, "Amount Due" is column index 5 or 6 usually
                    if (row.Cells["Amount Due"].Value != null && row.Cells["Status"].Value != null)
                    {
                        decimal amount = Convert.ToDecimal(row.Cells["Amount Due"].Value);
                        string status = row.Cells["Status"].Value.ToString();

                        if (status == "PAID")
                            filteredPaid += amount;
                        else if (status == "UNPAID")
                            filteredUnpaid += amount;
                    }
                }

                lblTotalIncome.Text = "Income (Paid): ₱" + filteredPaid.ToString("N2");
                lblTotalUnpaidKPI.Text = "Total Unpaid: ₱" + filteredUnpaid.ToString("N2");

                // Red alert logic
                lblTotalUnpaidKPI.ForeColor = (filteredUnpaid > 1000) ? Color.Red : Color.Black;
            } catch { }
        }


        // Master method for KPIs - Replaces the old separate ones
        private void RefreshKPIs()
        {
            decimal totalPaid = 0;
            decimal totalUnpaid = 0;

            foreach (DataGridViewRow row in incomeDGV.Rows)
            {
                if (row.Cells["Amount Due"].Value != null)
                {
                    decimal fee = Convert.ToDecimal(row.Cells["Amount Due"].Value);
                    string status = row.Cells["Status"].Value.ToString();

                    if (status == "PAID") totalPaid += fee;
                    else if (status == "UNPAID") totalUnpaid += fee;
                }
            }

            lblTotalIncome.Text = "Income (Paid): ₱" + totalPaid.ToString("N2");
            lblTotalUnpaidKPI.Text = "Total Unpaid: ₱" + totalUnpaid.ToString("N2");
        }

        private void LoadCourseFilter()
        {
            DataTable dt = _violationDao.GetCoursesForComboBox();
            DataRow topRow = dt.NewRow();
            topRow["course_id"] = 0;
            topRow["course_name"] = "--- All Courses ---";
            dt.Rows.InsertAt(topRow, 0);

            comboCourseFilter.DataSource = dt;
            comboCourseFilter.DisplayMember = "course_name";
            comboCourseFilter.ValueMember = "course_id";
        }

        private void ShowAllIncome()
        {
            incomeDGV.DataSource = _violationDao.GetAllStudentViolations();
            lblTotalAmountHeader.Text = "General Summary: All Violations and Events";
            HideIdColumns();

            if (incomeDGV.Columns.Contains("Record ID")) incomeDGV.Columns["Record ID"].Visible = false;
            if (incomeDGV.Columns.Contains("Student ID")) incomeDGV.Columns["Student ID"].Visible = false;
        }

        private void incomeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = incomeDGV.Rows[e.RowIndex];

                try
                {
                    selectedRecordId = Convert.ToInt32(row.Cells["Record ID"].Value);
                    string student = row.Cells["Student Name"].Value?.ToString() ?? "N/A";
                    string description = row.Cells["Description"].Value?.ToString() ?? "";
                    decimal amount = Convert.ToDecimal(row.Cells["Amount Due"].Value);
                    string status = row.Cells["Status"].Value?.ToString() ?? "UNPAID";

                    // Update Labels immediately
                    lblSelectedStudent.Text = "Selected: " + student;
                    lblTotalAmountHeader.Text = $"DETAILS: {student} | {description} | ₱{amount:N2} ({status})";

                    // Only enable payment button for unpaid items
                    btnSettlePayment.Enabled = (status == "UNPAID");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selection Error: Check Column Names. " + ex.Message);
                }
            }
        }
        private decimal CalculateDataTableTotal(DataTable dt)
        {
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Amount Due"] != DBNull.Value)
                    total += Convert.ToDecimal(row["Amount Due"]);
            }
            return total;
        }

        private void paidBtn_Click(object sender, EventArgs e)
        {
            // Use V2 here
            DataTable dt = _violationDao.FilterViolationsByStatusV2("PAID");
            incomeDGV.DataSource = dt;
            lblTotalAmountHeader.Text = $"Viewing: Total Paid Collections (₱{CalculateDataTableTotal(dt):N2})";
            HideIdColumns();
        }

        private void unpaidBtn_Click(object sender, EventArgs e)
        {
            // Use V2 here
            DataTable dt = _violationDao.FilterViolationsByStatusV2("UNPAID");
            incomeDGV.DataSource = dt;
            lblTotalAmountHeader.Text = $"Viewing: Outstanding Debts (₱{CalculateDataTableTotal(dt):N2})";
            HideIdColumns();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            ShowAllIncome();
            RefreshKPIs();
        }

        private void comboCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboCourseFilter.SelectedValue == null || comboCourseFilter.SelectedIndex == -1) return;
                int selectedCourseId = Convert.ToInt32(comboCourseFilter.SelectedValue);

                if (selectedCourseId == 0)
                    ShowAllIncome();
                else
                    // Use V2 here
                    incomeDGV.DataSource = _violationDao.FilterViolationsByCourseV2(selectedCourseId);

                HideIdColumns();
                UpdateFilteredKPIs();
                lblTotalAmountHeader.Text = "Viewing Course: " + comboCourseFilter.Text;
            }
            catch { }
        }

        private void lblTotalIncome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if (selectedRecordId == -1 || incomeDGV.CurrentRow == null)
            {
                MessageBox.Show("Please select a student record.");
                return;
            }

            // Capture the Fund ID from the ComboBox
            if (comboFundSelect.SelectedValue == null)
            {
                MessageBox.Show("Please select a destination Fund.");
                return;
            }
            int selectedFundId = Convert.ToInt32(comboFundSelect.SelectedValue);
            string fundName = comboFundSelect.Text;

            DataGridViewRow row = incomeDGV.CurrentRow;
            int studentId = Convert.ToInt32(row.Cells["Student ID"].Value);
            decimal feeAmount = Convert.ToDecimal(row.Cells["Amount Due"].Value);
            string studentName = row.Cells["Student Name"].Value.ToString();
            string description = row.Cells["Description"].Value.ToString();

            string confirmMsg = $"Proceed with payment?\n\nStudent: {studentName}\nAmount: ₱{feeAmount:N2}\nFund: {fundName}";

            if (MessageBox.Show(confirmMsg, "Confirm Settlement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Send the 6th argument: selectedFundId
                if (_violationDao.SettleStudentDebtWithTransaction(selectedRecordId, studentId, feeAmount, studentName, description, selectedFundId))
                {
                    MessageBox.Show($"Payment successful! Money added to {fundName}.");
                    ShowAllIncome();
                    UpdateFilteredKPIs();
                }
            }
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Use V2 to ensure "Description" column exists
            DataTable dt = _violationDao.SearchStudentViolationsV2(txtSearch.Text);
            incomeDGV.DataSource = dt;
            HideIdColumns();
            UpdateFilteredKPIs();
        }
    }
}
