using School_Management_Transparency.SchoolManagementTransparencyApp.Controller;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.STUDENT_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Winfroms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private readonly StudentController _studentController = new StudentController();

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentContainerPanel.Controls.Clear();
            contentContainerPanel.Controls.Add(userControl);
            contentContainerPanel.Show();
            userControl.BringToFront();
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {
            // 1. Fetch and display the student's full name on load
            DisplayStudentProfile();

            // 2. Automatically load the Home screen User Control by default
            addUserControl(new STUDENT_UC_HOME());
        }

        private void DisplayStudentProfile()
        {
            try
            {
                // Fetch the current student's model data via your controller
                Student currentStudent = _studentController.GetCurrentStudentProfile();

                if (currentStudent != null)
                {
                    // Handle empty or missing middle names gracefully
                    string middle = string.IsNullOrWhiteSpace(currentStudent.MiddleName)
                        ? ""
                        : currentStudent.MiddleName + " ";

                    string fullName = $"{currentStudent.FirstName} {middle}{currentStudent.LastName}";

                    // CHANGE 'lblStudentName' to match your actual Form design control name
                    studentFullnameLabel.Text = fullName.ToUpper();
                }
                else
                {
                    studentFullnameLabel.Text = "Welcome, Student";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rendering profile header: " + ex.Message, "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leftNavContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new STUDENT_UC_HOME());
        }

        private void mydebtBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new STUDENT_UC_DEBT());
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new STUDENT_UC_HISTORY());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // 1. Create the Pop-up with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out from the Student Dashboard?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 2. Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Close or hide current dashboard
                this.Hide();

                // Wipe out the static variables safely
                Util.UserSession.ClearSession();

                // Redirect back to Login
                LoginForm login = new LoginForm();
                login.Show();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
