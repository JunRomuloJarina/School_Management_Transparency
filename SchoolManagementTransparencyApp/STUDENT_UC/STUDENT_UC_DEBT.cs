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
    public partial class STUDENT_UC_DEBT : UserControl
    {
        public STUDENT_UC_DEBT()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.STUDENT_UC_DEBT_Load);
        }

        private readonly StudentController _studentController = new StudentController();
        private int activeStudentId = 0;

        private void RefreshDebtGrid()
        {
            if (activeStudentId > 0)
            {
                studentDebtDGV.DataSource = null;
                _studentController.LoadDebtGrid(studentDebtDGV, activeStudentId, searchTxtbox.Text.Trim());
            }
        }

        private void STUDENT_UC_DEBT_Load(object sender, EventArgs e)
        {
            Student currentStudent = _studentController.GetCurrentStudentProfile();

            if (currentStudent != null)
            {
                activeStudentId = currentStudent.StudentId;
                RefreshDebtGrid();
            }
        }

        private void studentDebtDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            RefreshDebtGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTxtbox.Clear();
            RefreshDebtGrid();
        }
    }
}
