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

namespace School_Management_Transparency.SchoolManagementTransparencyApp.AdminDashboardUserControls
{
    public partial class UC_EXPENSE : UserControl
    {
        public UC_EXPENSE()
        {
            InitializeComponent();
        }

        ExpenseTransactionDao _expenseDao = new ExpenseTransactionDao();

        private void UC_EXPENSE_Load(object sender, EventArgs e) 
        {
            RefreshDashboard();
        }

        private void LoadHistoryGrid()
        {
            // Fetch detailed data from DAO
            DataTable dt = _expenseDao.GetExpenseHistoryTable();
            expenseHistoryDGV.DataSource = dt;

            // UI Formatting
            expenseHistoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide Technical ID
            if (expenseHistoryDGV.Columns["ID"] != null)
                expenseHistoryDGV.Columns["ID"].Visible = false;

            // Format Amount as Currency (₱)
            if (expenseHistoryDGV.Columns["Amount Spent"] != null)
            {
                expenseHistoryDGV.Columns["Amount Spent"].DefaultCellStyle.Format = "N2";
                expenseHistoryDGV.Columns["Amount Spent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Set Date format
            if (expenseHistoryDGV.Columns["Date"] != null)
            {
                expenseHistoryDGV.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }
        }

        // Central method to refresh all UI elements
        private void RefreshDashboard()
        {
            LoadFunds();         // Refresh ComboBox
            LoadBalanceGrid();   // Refresh Fund Balance DGV
            LoadHistoryGrid();   // Refresh Expense History DGV
        }

        private void ClearForm()
        {
            expenseAmountTxt.Clear();
            expenseRemarksTxt.Clear();
            expenseFundComboBox.SelectedIndex = -1;
            expenseDatePicker.Value = DateTime.Now;
        }
        private void LoadFunds()
        {
            DataTable funds = _expenseDao.GetFundCategories();

            // Setup ComboBox
            expenseFundComboBox.DataSource = funds;
            expenseFundComboBox.DisplayMember = "fund_name"; // What the user sees
            expenseFundComboBox.ValueMember = "fund_id";     // The ID sent to DB
            expenseFundComboBox.SelectedIndex = -1;          // Start empty
        }

        private void LoadBalanceGrid()
        {
            // Fetch calculated balances from DAO
            DataTable dt = _expenseDao.GetFundBalancesTable();
            fundBalanceDGV.DataSource = dt;

            // Formatting
            fundBalanceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (fundBalanceDGV.Columns["ID"] != null) fundBalanceDGV.Columns["ID"].Visible = false;

            if (fundBalanceDGV.Columns["Available Money"] != null)
            {
                fundBalanceDGV.Columns["Available Money"].DefaultCellStyle.Format = "N2";
                fundBalanceDGV.Columns["Available Money"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private void btnSpendMoney_Click(object sender, EventArgs e)
        {
            // 1. UI Validation
            if (expenseFundComboBox.SelectedIndex == -1) { MessageBox.Show("Select a fund."); return; }
            if (!decimal.TryParse(expenseAmountTxt.Text, out decimal amountToSpend) || amountToSpend <= 0)
            {
                MessageBox.Show("Enter a valid amount."); return;
            }

            // 2. Transparency Check: Verify if the fund has enough money
            int fundId = (int)expenseFundComboBox.SelectedValue;
            decimal currentBalance = 0;

            foreach (DataGridViewRow row in fundBalanceDGV.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == fundId)
                {
                    currentBalance = Convert.ToDecimal(row.Cells["Available Money"].Value);
                    break;
                }
            }

            if (amountToSpend > currentBalance)
            {
                MessageBox.Show($"Insufficient Funds!\nAvailable in {expenseFundComboBox.Text}: ₱{currentBalance:N2}",
                                "Transparency Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Process Transaction
            if (MessageBox.Show($"Spend ₱{amountToSpend:N2}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_expenseDao.AddExpenseTransactions(fundId, amountToSpend, expenseRemarksTxt.Text, expenseDatePicker.Value))
                {
                    MessageBox.Show("Expense recorded successfully!");
                    ClearForm();
                    RefreshDashboard(); // This will recalculate the balance in the DGV immediately
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
