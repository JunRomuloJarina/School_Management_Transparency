using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            LoadViolationTypes();
            RefreshGrid();
            LoadViolationTypeCRUDGrid();
            isInitializing = false; // Finished loading
        }

        private StudentViolationDao _dao = new StudentViolationDao();
        private ViolationTypeDao _typeDao = new ViolationTypeDao();
        private bool isInitializing = true; // Prevents ComboBox from firing during load

        private void LoadCourseComboBoxForAddPanel()
        {
            // Use the same DAO method you already have
            DataTable courseTable = _dao.GetCoursesForComboBox();

            // Add the 'All Courses' option
            DataRow row = courseTable.NewRow();
            row["course_id"] = 0;
            row["course_name"] = "--- All Courses ---";
            courseTable.Rows.InsertAt(row, 0);

            comboCourseFilterAdd.DataSource = courseTable;
            comboCourseFilterAdd.DisplayMember = "course_name";
            comboCourseFilterAdd.ValueMember = "course_id";
        }

        private void LoadViolationTypes()
        {
            violationTypeCombo.DataSource = _dao.GetViolationTypes();
            violationTypeCombo.DisplayMember = "violation_name";
            violationTypeCombo.ValueMember = "violation_type_id";
        }

        private void LoadStudentLookupGrid()
        {
            // studentLookupDGV is the grid INSIDE your addviolateContainerPanel
            studentLookupDGV.DataSource = _dao.GetStudentLookupList();

            // Hide the ID column so it looks clean, but we can still access the value
            if (studentLookupDGV.Columns["student_id"] != null)
                studentLookupDGV.Columns["student_id"].Visible = false;

            studentLookupDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ApplyStudentLookupFilter()
        {
            //string term = txtSearchStudentAdd.Text.Trim();
            //int courseId = 0;

            //if (comboCourseFilterAdd.SelectedValue != null && int.TryParse(comboCourseFilterAdd.SelectedValue.ToString(), out int id))
            //{
            //    courseId = id;
            //}

            //// Update the lookup DGV
            //studentLookupDGV.DataSource = _dao.SearchStudentsForViolation(term, courseId);

            //if (studentLookupDGV.Columns["student_id"] != null)
            //    studentLookupDGV.Columns["student_id"].Visible = false;

            if (isInitializing) return;

            string term = txtSearchStudentAdd.Text.Trim();
            int courseId = 0;

            // Correctly extract the course ID
            if (comboCourseFilterAdd.SelectedValue != null)
            {
                if (int.TryParse(comboCourseFilterAdd.SelectedValue.ToString(), out int id))
                {
                    courseId = id;
                }
            }

            // Call DAO
            studentLookupDGV.DataSource = _dao.SearchStudentsForViolation(term, courseId);

            if (studentLookupDGV.Columns["student_id"] != null)
                studentLookupDGV.Columns["student_id"].Visible = false;
        }

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

        private void paidBtn_Click(object sender, EventArgs e)
        {
            // 1. Reset other filters visually
            isInitializing = true;
            studentviolatorSelectorCombo.SelectedIndex = 0;
            searchTxtbox.Clear();
            isInitializing = false;

            // 2. Fetch only PAID records
            studentviolationDGV.DataSource = _dao.FilterViolationsByStatus("PAID");
            FormatGridDisplay();
        }

        private void unpaidBtn_Click(object sender, EventArgs e)
        {
            // 1. Reset other filters visually
            isInitializing = true;
            studentviolatorSelectorCombo.SelectedIndex = 0;
            searchTxtbox.Clear();
            isInitializing = false;

            // 2. Fetch only UNPAID records
            studentviolationDGV.DataSource = _dao.FilterViolationsByStatus("UNPAID");
            FormatGridDisplay();
        }

        private void addstudentViolationBtn_Click(object sender, EventArgs e)
        {
            isInitializing = true; // Block events while setting up

            addviolateContainerPanel.Visible = true;
            addviolateContainerPanel.BringToFront();

            // 1. Fill the ComboBox for the Add Panel
            LoadCourseComboBoxForAddPanel();

            // 2. Load the Student Grid
            LoadStudentLookupGrid();

            isInitializing = false; // Re-enable events

            // 3. Initial filter (shows all)
            ApplyStudentLookupFilter();
        }

        private void addviolateContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            addviolateContainerPanel.Visible = false;
            addviolateContainerPanel.SendToBack();
        }

        private void studentLookupDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = studentLookupDGV.Rows[e.RowIndex];

                // Store the ID in a hidden label or a private variable
                lblSelectedStudentIdForViolation.Text = row.Cells["student_id"].Value.ToString();

                // Optional: Show the name in a label so the user knows who is selected
                lblTargetStudentName.Text = "Selected: " + row.Cells["Student Name"].Value.ToString();
            }
        }

        private void violationDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboCourseFilterAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reuse the same isInitializing logic to prevent errors during panel load
            if (isInitializing) return;
            ApplyStudentLookupFilter();
        }

        private void txtSearchStudentAdd_TextChanged(object sender, EventArgs e)
        {
            ApplyStudentLookupFilter();
        }

        private void searchClearBtn_Click(object sender, EventArgs e)
        {
            txtSearchStudentAdd.Clear();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void showContainerPanelForCrudViolationType_Click(object sender, EventArgs e)
        {

        }

        private void addViolatorStudent_Click(object sender, EventArgs e)
        {
            // 1. Validation
            if (string.IsNullOrEmpty(lblSelectedStudentIdForViolation.Text))
            {
                MessageBox.Show("Please select a student first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Map Data to Model
            int studentId = int.Parse(lblSelectedStudentIdForViolation.Text);
            int violationId = Convert.ToInt32(violationTypeCombo.SelectedValue);
            DateTime issuedDate = violationDatePicker.Value;

            // 3. Execute via DAO
            if (_dao.AddViolationRecord(studentId, violationId, issuedDate, "UNPAID"))
            {
                // --- THE "SUCCESS" EXPERIENCE ---

                // Refresh the main grid so the user sees the new entry immediately
                RefreshGrid();

                // Clear selection to prevent double-clicking the 'Add' button
                lblTargetStudentName.Text = "Select a Student...";
                lblSelectedStudentIdForViolation.Text = "";

                // Notify the user
                MessageBox.Show("Violation successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //// Optional: Hide the panel and go back to the main list
                //backBtn_Click(sender, e);
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            newViolationTypeContainer.Visible = false;
            showContainerPanelViolationType.Enabled = true;
            backBtn.Enabled = true;
        }

        private void showContainerPanelViolationType_Click(object sender, EventArgs e)
        {
            newViolationTypeContainer.Visible = true;
            showContainerPanelViolationType.Enabled = false;
            backBtn.Enabled = false;
        }

        private void LoadViolationTypeCRUDGrid()
        {
            // Fetches the DataTable for the Grid
            violationTypeDGV.DataSource = _typeDao.GetViolationTypesDataTable();

            violationTypeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Hide Technical ID
            if (violationTypeDGV.Columns["ID"] != null) violationTypeDGV.Columns["ID"].Visible = false;
        }


        private void addNewViolationTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(violationTypeNameTextBox.Text))
            {
                MessageBox.Show("Violation Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newType = new ViolationType
            {
                ViolationName = violationTypeNameTextBox.Text.Trim(),
                Fee = decimal.TryParse(violationTypeFeeTxtbox.Text, out decimal fee) ? fee : 0,
                Category = violationTypeCategoryTxtbox.Text.Trim(),
                Description = violationTypeDescriptionTxtbox.Text.Trim()
            };

            if (_typeDao.SaveNewViolationType(newType))
            {
                LoadViolationTypeCRUDGrid(); // Refresh the list
                LoadViolationTypes();        // Sync the ComboBox in the Add Panel
                clearViolationTypeBtn_Click(null, null); // Reset fields
            }
        }

        private void updateNewViolationTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(violationTypeIdTxtbox.Text))
            {
                MessageBox.Show("Please select a record from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updateType = new ViolationType
            {
                ViolationTypeId = int.Parse(violationTypeIdTxtbox.Text),
                ViolationName = violationTypeNameTextBox.Text.Trim(),
                Fee = decimal.Parse(violationTypeFeeTxtbox.Text),
                Category = violationTypeCategoryTxtbox.Text.Trim(),
                Description = violationTypeDescriptionTxtbox.Text.Trim()
            };

            if (_typeDao.UpdateViolationTypes(updateType))
            {
                LoadViolationTypeCRUDGrid();
                LoadViolationTypes();
            }
        }

        private void deleteNewViolationTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(violationTypeIdTxtbox.Text)) return;

            DialogResult result = MessageBox.Show("Delete this violation type? This may affect transparency reports.",
                                                 "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(violationTypeIdTxtbox.Text);
                if (_typeDao.DeleteViolationTypes(id))
                {
                    LoadViolationTypeCRUDGrid();
                    LoadViolationTypes();
                    clearViolationTypeBtn_Click(null, null);
                }
            }
        }


        private void violationTypeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // If empty or just spaces, turn background light red
            violationTypeNameTextBox.BackColor = string.IsNullOrWhiteSpace(violationTypeNameTextBox.Text)
                ? Color.MistyRose
                : Color.White;
        }


        private void violationTypeFeeTxtbox_TextChanged(object sender, EventArgs e)
        {
            // Use Regex to remove anything that isn't a digit or a decimal point
            string cleanString = Regex.Replace(violationTypeFeeTxtbox.Text, @"[^0-9.]", "");

            if (violationTypeFeeTxtbox.Text != cleanString)
            {
                // If the user typed a letter, we replace the text with the "clean" version
                violationTypeFeeTxtbox.Text = cleanString;

                // Move cursor to the end so it doesn't jump back to the start
                violationTypeFeeTxtbox.SelectionStart = violationTypeFeeTxtbox.Text.Length;
            }

            // Visual feedback: Red text if it's not a valid decimal
            bool isValidDecimal = decimal.TryParse(violationTypeFeeTxtbox.Text, out _);
            violationTypeFeeTxtbox.ForeColor = isValidDecimal ? Color.Black : Color.Red;
        }

        private void violationTypeCategoryTxtbox_TextChanged(object sender, EventArgs e)
        {
            violationTypeCategoryTxtbox.BackColor = string.IsNullOrWhiteSpace(violationTypeCategoryTxtbox.Text)
            ? Color.MistyRose
            : Color.White;
        }

        private void violationTypeDescriptionTxtbox_TextChanged(object sender, EventArgs e)
        {
            // If description is too long (e.g., > 255 chars), show a warning color
            if (violationTypeDescriptionTxtbox.Text.Length > 250)
            {
                violationTypeDescriptionTxtbox.ForeColor = Color.Red;
            }
            else
            {
                violationTypeDescriptionTxtbox.ForeColor = Color.Black;
            }
        }

        private void violationTypeIdTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void violationTypeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = violationTypeDGV.Rows[e.RowIndex];

                // Map Grid data back to TextBoxes
                violationTypeIdTxtbox.Text = row.Cells["ID"].Value.ToString();
                violationTypeNameTextBox.Text = row.Cells["Violation Name"].Value.ToString();
                violationTypeFeeTxtbox.Text = row.Cells["Penalty Fee"].Value.ToString();
                violationTypeCategoryTxtbox.Text = row.Cells["Category"].Value.ToString();
                violationTypeDescriptionTxtbox.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void clearViolationTypeBtn_Click(object sender, EventArgs e)
        {
            violationTypeIdTxtbox.Clear();
            violationTypeNameTextBox.Clear();
            violationTypeFeeTxtbox.Clear();
            violationTypeCategoryTxtbox.Clear();
            violationTypeDescriptionTxtbox.Clear();
        }

        private void newViolationTypeContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
