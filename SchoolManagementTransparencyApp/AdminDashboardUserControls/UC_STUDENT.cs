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
    public partial class UC_STUDENT : UserControl
    {
        public UC_STUDENT()
        {
            InitializeComponent();
        }
        private StudentAccountDao _dao = new StudentAccountDao();

        private void RefreshGrid()
        {
            studentDGV.DataSource = _dao.GetStudentManagementData();

            // Hide technical IDs and Passwords from the user grid
            if (studentDGV.Columns["user_id"] != null) studentDGV.Columns["user_id"].Visible = false;
            //if (studentDGV.Columns["password"] != null) studentDGV.Columns["password"].Visible = false;

            FormatGrid();
        }


        private void LoadCourses()
        {
            courseCombo.DataSource = _dao.GetAvailableCourses();
            courseCombo.DisplayMember = "course_name";
            courseCombo.ValueMember = "course_id";
            courseCombo.SelectedIndex = -1;
        }


        private void FormatGrid()
        {
            // Hide technical columns regardless of search or full load[cite: 1]
            if (studentDGV.Columns["user_id"] != null) studentDGV.Columns["user_id"].Visible = false;
            if (studentDGV.Columns["course_id"] != null) studentDGV.Columns["course_id"].Visible = false;
            //if (studentDGV.Columns["password"] != null) studentDGV.Columns["password"].Visible = false;
            studentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the user clicked a valid row (not the header)
                if (e.RowIndex >= 0)
                {
                    var row = studentDGV.Rows[e.RowIndex];

                    // 1. Populate Profile Fields
                    firstNameTxt.Text = row.Cells["first_name"].Value?.ToString();
                    middleNameTxt.Text = row.Cells["middle_name"].Value?.ToString();
                    lastNameTxt.Text = row.Cells["last_name"].Value?.ToString();
                    ageTxt.Text = row.Cells["age"].Value?.ToString();
                    genderCombo.Text = row.Cells["gender"].Value?.ToString();
                    addressTxt.Text = row.Cells["address"].Value?.ToString();
                    contactTxt.Text = row.Cells["contact_number"].Value?.ToString();

                    if (row.Cells["date_of_birth"].Value != DBNull.Value)
                        dobPicker.Value = Convert.ToDateTime(row.Cells["date_of_birth"].Value);

                    // 2. Populate Account Fields
                    usernameTxt.Text = row.Cells["username"].Value?.ToString();
                    passwordTxt.Text = row.Cells["password"].Value?.ToString();
                    roleTxt.Text = row.Cells["role"].Value?.ToString();

                    // 3. NEW: Populate Course Selection
                    // This works because we set 'ValueMember' to 'course_id' during Load
                    if (row.Cells["course_id"].Value != DBNull.Value)
                    {
                        courseCombo.SelectedValue = row.Cells["course_id"].Value;
                    }
                    else
                    {
                        courseCombo.SelectedIndex = -1; // Clear selection if no course assigned
                    }

                    // 4. Hidden Labels for Foreign Key logic (Updates/Deletes)
                    lblSelectedStudentId.Text = row.Cells["student_id"].Value?.ToString();
                    lblSelectedUserId.Text = row.Cells["user_id"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                // It's better to know what went wrong than to have an empty catch!
                Console.WriteLine("Selection Error: " + ex.Message);
            }
        }

        private void UC_STUDENT_Load(object sender, EventArgs e)
        {
            LoadCourses();
            RefreshGrid();

            genderCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            genderCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection genderList = new AutoCompleteStringCollection();
            genderList.AddRange(new string[] { "MALE", "FEMALE", "OTHERS" });
            genderCombo.AutoCompleteCustomSource = genderList;

            roleTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            roleTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection rolesList = new AutoCompleteStringCollection();
            rolesList.AddRange(new string[] { "ADMIN", "STUDENT", "SBO" });
            roleTxt.AutoCompleteCustomSource = rolesList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ageTxt.Text, out int age) || courseCombo.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields and select a Course.");
                return;
            }

            int selectedCourseId = Convert.ToInt32(courseCombo.SelectedValue);

            bool success = _dao.CreateStudentWithAccount(
                firstNameTxt.Text.Trim(), middleNameTxt.Text.Trim(), lastNameTxt.Text.Trim(),
                age, genderCombo.Text, addressTxt.Text.Trim(), dobPicker.Value, contactTxt.Text.Trim(),
                usernameTxt.Text.Trim(), passwordTxt.Text.Trim(), roleTxt.Text.Trim(),
                selectedCourseId 
            );

            if (success) { MessageBox.Show("Success!"); RefreshGrid(); ClearAll(); }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSelectedStudentId.Text) || courseCombo.SelectedValue == null) return;

            bool success = _dao.UpdateStudentAndAccount(
                int.Parse(lblSelectedStudentId.Text), int.Parse(lblSelectedUserId.Text),
                firstNameTxt.Text.Trim(), middleNameTxt.Text.Trim(), lastNameTxt.Text.Trim(),
                int.Parse(ageTxt.Text), genderCombo.Text, addressTxt.Text.Trim(),
                dobPicker.Value, contactTxt.Text.Trim(),
                usernameTxt.Text.Trim(), passwordTxt.Text.Trim(), roleTxt.Text,
                Convert.ToInt32(courseCombo.SelectedValue) // <--- Added
            );

            if (success) { MessageBox.Show("Updated!"); RefreshGrid(); }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSelectedStudentId.Text) || string.IsNullOrEmpty(lblSelectedUserId.Text))
            {
                MessageBox.Show("Please select a student from the list first.");
                return;
            }

            if (MessageBox.Show("Permanently delete this student, their enrollment, and login account?",
                                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int sId = int.Parse(lblSelectedStudentId.Text);
                int uId = int.Parse(lblSelectedUserId.Text);

                if (_dao.DeleteStudentRecord(sId, uId))
                {
                    MessageBox.Show("All records associated with this student have been removed.");
                    RefreshGrid();
                    ClearAll();
                }
            }
        }

        private void ClearAll()
        {
            firstNameTxt.Clear();
            middleNameTxt.Clear();
            lastNameTxt.Clear();
            ageTxt.Clear();
            addressTxt.Clear();
            contactTxt.Clear(); 
            usernameTxt.Clear();
            passwordTxt.Clear();
            genderCombo.Clear();
            roleTxt.Clear();
            courseCombo.SelectedIndex = -1;
            dobPicker.Value = DateTime.Now;

            lblSelectedStudentId.Text = "";
            lblSelectedUserId.Text = "";
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            // 1. Check if the text is empty to avoid unnecessary processing
            if (string.IsNullOrWhiteSpace(ageTxt.Text)) return;

            //2.Validate if the input is a valid number
            if (!int.TryParse(ageTxt.Text, out int age))
            {
                // 3. If the user types a letter, show a warning and clear the invalid char
                MessageBox.Show("Please enter numbers only for Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Optional: Remove the last character typed if it's invalid
                ageTxt.Text = string.Concat(ageTxt.Text.Where(char.IsDigit));
                ageTxt.SelectionStart = ageTxt.Text.Length; // Keep the cursor at the end
            }
            else
            {
                // 4. Optional: Logic for age limits (e.g., student must be between 3 and 100)
                if (age > 100)
                {
                    MessageBox.Show("Please enter a realistic age.");
                    ageTxt.Clear();
                }
            }
        }

        private void contactTxt_TextChanged(object sender, EventArgs e)
        {
            // 1. Exit if empty
            if (string.IsNullOrEmpty(contactTxt.Text)) return;

            // 2. Remove any non-digit characters (allows for pasting text safely)
            string cleanText = new string(contactTxt.Text.Where(char.IsDigit).ToArray());

            // 3. Enforce the VARCHAR(20) database limit
            if (cleanText.Length > 20)
            {
                cleanText = cleanText.Substring(0, 20);
            }

            // 4. Update the textbox if the text was changed by the cleaning process
            if (contactTxt.Text != cleanText)
            {
                contactTxt.Text = cleanText;
                // Keep the cursor at the end
                contactTxt.SelectionStart = contactTxt.Text.Length;
            }
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            string term = searchTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                RefreshGrid(); // If they clear the box, show everyone again
            }
            else
            {
                // Update the grid with filtered results
                DataTable results = _dao.SearchStudentProfiles(term);
                studentDGV.DataSource = results;

                // CRITICAL: Call your formatting method to hide IDs/Passwords again
                FormatGrid();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchTxtbox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectedStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
