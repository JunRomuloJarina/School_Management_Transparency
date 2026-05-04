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


        private void FormatGrid()
        {
            // Hide technical columns regardless of search or full load[cite: 1]
            if (studentDGV.Columns["user_id"] != null) studentDGV.Columns["user_id"].Visible = false;
            //if (studentDGV.Columns["password"] != null) studentDGV.Columns["password"].Visible = false;
            studentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = studentDGV.Rows[e.RowIndex];

                    // Populate all profile fields from the student table
                    firstNameTxt.Text = row.Cells["first_name"].Value?.ToString();
                    middleNameTxt.Text = row.Cells["middle_name"].Value?.ToString();
                    lastNameTxt.Text = row.Cells["last_name"].Value?.ToString();
                    ageTxt.Text = row.Cells["age"].Value?.ToString();
                    genderCombo.Text = row.Cells["gender"].Value?.ToString();
                    addressTxt.Text = row.Cells["address"].Value?.ToString();
                    contactTxt.Text = row.Cells["contact_number"].Value?.ToString();
                    dobPicker.Value = Convert.ToDateTime(row.Cells["date_of_birth"].Value);

                    // Populate account fields from the user_account table
                    usernameTxt.Text = row.Cells["username"].Value?.ToString();
                    passwordTxt.Text = row.Cells["password"].Value?.ToString();
                    roleTxt.Text = row.Cells["role"].Value?.ToString();

                    // Hidden Labels for Foreign Key logic
                    lblSelectedStudentId.Text = row.Cells["student_id"].Value?.ToString();
                    lblSelectedUserId.Text = row.Cells["user_id"].Value?.ToString();
                }
            }
            catch(Exception ex) 
            { }
        }

        private void UC_STUDENT_Load(object sender, EventArgs e)
        {
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
            // 1. Safety check for the Age field
            if (!int.TryParse(ageTxt.Text, out int age))
            {
                MessageBox.Show("Please enter a valid number for Age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Proceed with the DAO call using the 'age' variable we just created
            bool success = _dao.CreateStudentWithAccount(
                firstNameTxt.Text.Trim(),
                middleNameTxt.Text.Trim(),
                lastNameTxt.Text.Trim(),
                age, // Using the parsed integer here
                genderCombo.Text,
                addressTxt.Text.Trim(),
                dobPicker.Value,
                contactTxt.Text.Trim(),
                usernameTxt.Text.Trim(),
                passwordTxt.Text.Trim(),
                roleTxt.Text.Trim()
            );

            if (success)
            {
                MessageBox.Show("Student Profile and Account Created!");
                RefreshGrid();
                ClearAll();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblSelectedStudentId.Text)) return;

                int sId = int.Parse(lblSelectedStudentId.Text);
                int uId = int.Parse(lblSelectedUserId.Text);

                bool success = _dao.UpdateStudentAndAccount(
                    sId, uId,
                    firstNameTxt.Text.Trim(), middleNameTxt.Text.Trim(), lastNameTxt.Text.Trim(),
                    int.Parse(ageTxt.Text), genderCombo.Text, addressTxt.Text.Trim(),
                    dobPicker.Value, contactTxt.Text.Trim(),
                    usernameTxt.Text.Trim(), passwordTxt.Text.Trim(), roleTxt.Text
                );

                if (success)
                {
                    MessageBox.Show("Record Updated!");
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSelectedStudentId.Text)) return;

            if (MessageBox.Show("Delete this student and their login account?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int sId = int.Parse(lblSelectedStudentId.Text);
                int uId = int.Parse(lblSelectedUserId.Text);

                if (_dao.DeleteStudentRecord(sId, uId))
                {
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
            dobPicker.Value = DateTime.Now;

            lblSelectedStudentId.Text = "";
            lblSelectedUserId.Text = "";
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            // 1. Check if the text is empty to avoid unnecessary processing
            if (string.IsNullOrWhiteSpace(ageTxt.Text)) return;

            // 2. Validate if the input is a valid number
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
                RefreshGrid(); // Show everything if the box is empty
            }
            else
            {
                // Call the search method and update the DataGridView
                studentDGV.DataSource = _dao.SearchStudentProfiles(term);
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
    }
}
