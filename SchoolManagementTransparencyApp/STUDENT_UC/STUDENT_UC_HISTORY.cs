using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
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
    public partial class STUDENT_UC_HISTORY : UserControl
    {
        private readonly StudentController _studentController = new StudentController();
        private int activeStudentId = 0;
        public STUDENT_UC_HISTORY()
        {
            InitializeComponent();

            // Wire up the load handler explicitly to ensure it fires reliably
            this.Load += new System.EventHandler(this.STUDENT_UC_HISTORY_Load);
        }

        private void RefreshHistoryGrid()
        {
            if (activeStudentId > 0)
            {
                // Clear the current bindings first to avoid conflict anomalies
                historyDGV.DataSource = null;

                string keyword = "";

                // SAFELY look for your search control whether it's a Guna2TextBox or standard TextBox
                Control searchControl = this.Controls.Find("searchHistoryTxtbox", true).FirstOrDefault();
                if (searchControl != null)
                {
                    keyword = searchControl.Text.Trim();
                }

                _studentController.LoadPaymentHistoryGrid(historyDGV, activeStudentId, keyword);
            }
        }

        private void historyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STUDENT_UC_HISTORY_Load(object sender, EventArgs e)
        {
            // Fetch session identity context details from the Controller layer
            Student currentStudent = _studentController.GetCurrentStudentProfile();

            if (currentStudent != null)
            {
                activeStudentId = currentStudent.StudentId;
                RefreshHistoryGrid();
            }
        }

        private void searchHistoryTxtbox_TextChanged(object sender, EventArgs e)
        {
            RefreshHistoryGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchHistoryTxtbox.Clear();
        }
    }
}
