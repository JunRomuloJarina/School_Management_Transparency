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
    public partial class UC_STUDENT_VIOLATION : UserControl
    {
        public UC_STUDENT_VIOLATION()
        {
            InitializeComponent();
            LoadCourseComboBox();
            RefreshGrid();
            isInitializing = false; // Finished loading
        }

        private StudentViolationDao _dao = new StudentViolationDao();
        private bool isInitializing = true; // Prevents ComboBox from firing during load

        //private void UC_STUDENT_VIOLATION_Load(object sender, EventArgs e)
        //{
           
        //}

        private void RefreshGrid()
        {
            studentviolationDGV.DataSource = _dao.GetAllStudentViolations();
            FormatGridDisplay();
        }

        // Helper to keep the grid looking consistent whether filtered or searched
        private void FormatGridDisplay()
        {
            studentviolationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Hide the technical ID columns to keep the transparency view clean
            if (studentviolationDGV.Columns["Record ID"] != null) studentviolationDGV.Columns["Record ID"].Visible = false;
            if (studentviolationDGV.Columns["Student ID"] != null) studentviolationDGV.Columns["Student ID"].Visible = false;
        }

        private void LoadCourseComboBox()
        {
            // Populate ComboBox using specific columns 'course_id' and 'course_name'[cite: 3]
            DataTable courseTable = _dao.GetCoursesForComboBox();

            // Add the 'All Courses' option to the top so users can reset the filter
            DataRow row = courseTable.NewRow();
            row["course_id"] = 0;
            row["course_name"] = "--- All Courses ---";
            courseTable.Rows.InsertAt(row, 0);

            studentviolatorSelectorCombo.DataSource = courseTable;
            studentviolatorSelectorCombo.DisplayMember = "course_name"; // What the user sees in dropdown
            studentviolatorSelectorCombo.ValueMember = "course_id";     // The actual ID used for database filtering
        }

        private void studentviolationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentviolatorSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // Ignore selections that happen while the form is still loading

            // Prevent conflicting filters by clearing the search box when a course is chosen
            searchTxtbox.Clear();

            FilterBySelectedCourse();
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            string term = searchTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                // If search is empty, go back to respecting the ComboBox filter state
                FilterBySelectedCourse();
            }
            else
            {
                // Reset ComboBox visually when performing a global search[cite: 1, 2]
                isInitializing = true;
                studentviolatorSelectorCombo.SelectedIndex = 0;
                isInitializing = false;

                studentviolationDGV.DataSource = _dao.SearchStudentViolations(term);
                FormatGridDisplay();
            }
        }

        private void FilterBySelectedCourse()
        {
            // Standardizing the check for SelectedValue helps avoid occasional cast errors[cite: 1]
            if (studentviolatorSelectorCombo.SelectedValue != null && int.TryParse(studentviolatorSelectorCombo.SelectedValue.ToString(), out int courseId))
            {
                if (courseId == 0) // "All Courses" reset
                {
                    RefreshGrid();
                }
                else // Filter strictly by chosen Course[cite: 3]
                {
                    studentviolationDGV.DataSource = _dao.FilterViolationsByCourse(courseId);
                    FormatGridDisplay();
                }
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTxtbox.Clear();
        }
    }
}
