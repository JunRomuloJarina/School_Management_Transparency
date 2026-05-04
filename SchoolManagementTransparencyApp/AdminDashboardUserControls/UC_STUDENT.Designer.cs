namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    partial class UC_STUDENT
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.firstNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.genderCombo = new Guna.UI2.WinForms.Guna2TextBox();
            this.roleTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ageTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.dobPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSelectedStudentId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSelectedUserId = new Guna.UI2.WinForms.Guna2TextBox();
            this.middleNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.contactTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.clearAllBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDGV
            // 
            this.studentDGV.AllowUserToResizeColumns = false;
            this.studentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            this.studentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.studentDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDGV.DefaultCellStyle = dataGridViewCellStyle36;
            this.studentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDGV.Location = new System.Drawing.Point(43, 95);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.ReadOnly = true;
            this.studentDGV.RowHeadersVisible = false;
            this.studentDGV.RowHeadersWidth = 51;
            this.studentDGV.RowTemplate.Height = 24;
            this.studentDGV.Size = new System.Drawing.Size(1107, 552);
            this.studentDGV.TabIndex = 0;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.studentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.studentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.studentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.ThemeStyle.HeaderStyle.Height = 18;
            this.studentDGV.ThemeStyle.ReadOnly = true;
            this.studentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.studentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentDGV.ThemeStyle.RowsStyle.Height = 24;
            this.studentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(139, 828);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(226, 45);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "ADD";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(389, 828);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(226, 45);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(639, 828);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(226, 45);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxt.DefaultText = "";
            this.firstNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTxt.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxt.Location = new System.Drawing.Point(32, 689);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTxt.MaxLength = 20;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.firstNameTxt.PlaceholderText = "FIRST NAME";
            this.firstNameTxt.SelectedText = "";
            this.firstNameTxt.Size = new System.Drawing.Size(206, 43);
            this.firstNameTxt.TabIndex = 2;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTxt.DefaultText = "";
            this.lastNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTxt.ForeColor = System.Drawing.Color.Black;
            this.lastNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTxt.Location = new System.Drawing.Point(456, 689);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTxt.MaxLength = 20;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.lastNameTxt.PlaceholderText = "LAST NAME";
            this.lastNameTxt.SelectedText = "";
            this.lastNameTxt.Size = new System.Drawing.Size(229, 43);
            this.lastNameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.ForeColor = System.Drawing.Color.Black;
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Location = new System.Drawing.Point(691, 770);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.MaxLength = 20;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordTxt.PlaceholderText = "PASSWORD";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(229, 43);
            this.passwordTxt.TabIndex = 2;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.ForeColor = System.Drawing.Color.Black;
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Location = new System.Drawing.Point(456, 770);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxt.MaxLength = 20;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameTxt.PlaceholderText = "USERNAME";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(229, 43);
            this.usernameTxt.TabIndex = 2;
            // 
            // genderCombo
            // 
            this.genderCombo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.genderCombo.DefaultText = "";
            this.genderCombo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.genderCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.genderCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genderCombo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genderCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genderCombo.ForeColor = System.Drawing.Color.Black;
            this.genderCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCombo.Location = new System.Drawing.Point(861, 689);
            this.genderCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderCombo.MaxLength = 6;
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.genderCombo.PlaceholderText = "GENDER";
            this.genderCombo.SelectedText = "";
            this.genderCombo.Size = new System.Drawing.Size(146, 43);
            this.genderCombo.TabIndex = 2;
            // 
            // roleTxt
            // 
            this.roleTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleTxt.DefaultText = "";
            this.roleTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roleTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roleTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roleTxt.ForeColor = System.Drawing.Color.Black;
            this.roleTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTxt.Location = new System.Drawing.Point(926, 770);
            this.roleTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roleTxt.MaxLength = 7;
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.roleTxt.PlaceholderText = "ROLE";
            this.roleTxt.SelectedText = "";
            this.roleTxt.Size = new System.Drawing.Size(229, 43);
            this.roleTxt.TabIndex = 2;
            // 
            // ageTxt
            // 
            this.ageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTxt.DefaultText = "";
            this.ageTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ageTxt.ForeColor = System.Drawing.Color.Black;
            this.ageTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTxt.Location = new System.Drawing.Point(691, 689);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ageTxt.MaxLength = 3;
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ageTxt.PlaceholderText = "AGE";
            this.ageTxt.SelectedText = "";
            this.ageTxt.Size = new System.Drawing.Size(164, 43);
            this.ageTxt.TabIndex = 2;
            this.ageTxt.TextChanged += new System.EventHandler(this.ageTxt_TextChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.FillColor = System.Drawing.Color.White;
            this.dobPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(1013, 689);
            this.dobPicker.MaxDate = new System.DateTime(2100, 2, 3, 0, 0, 0, 0);
            this.dobPicker.MinDate = new System.DateTime(1900, 2, 5, 0, 0, 0, 0);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(143, 43);
            this.dobPicker.TabIndex = 3;
            this.dobPicker.Value = new System.DateTime(2026, 5, 4, 19, 36, 2, 989);
            // 
            // lblSelectedStudentId
            // 
            this.lblSelectedStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSelectedStudentId.DefaultText = "";
            this.lblSelectedStudentId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblSelectedStudentId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblSelectedStudentId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblSelectedStudentId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblSelectedStudentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSelectedStudentId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedStudentId.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedStudentId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSelectedStudentId.Location = new System.Drawing.Point(32, 827);
            this.lblSelectedStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSelectedStudentId.Name = "lblSelectedStudentId";
            this.lblSelectedStudentId.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedStudentId.PlaceholderText = "STUDENT ID";
            this.lblSelectedStudentId.SelectedText = "";
            this.lblSelectedStudentId.Size = new System.Drawing.Size(206, 43);
            this.lblSelectedStudentId.TabIndex = 2;
            this.lblSelectedStudentId.Visible = false;
            // 
            // lblSelectedUserId
            // 
            this.lblSelectedUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSelectedUserId.DefaultText = "";
            this.lblSelectedUserId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblSelectedUserId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblSelectedUserId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblSelectedUserId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblSelectedUserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSelectedUserId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedUserId.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedUserId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSelectedUserId.Location = new System.Drawing.Point(244, 829);
            this.lblSelectedUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSelectedUserId.Name = "lblSelectedUserId";
            this.lblSelectedUserId.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedUserId.PlaceholderText = "USER ID";
            this.lblSelectedUserId.SelectedText = "";
            this.lblSelectedUserId.Size = new System.Drawing.Size(206, 43);
            this.lblSelectedUserId.TabIndex = 2;
            this.lblSelectedUserId.Visible = false;
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middleNameTxt.DefaultText = "";
            this.middleNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.middleNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.middleNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middleNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middleNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.middleNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.middleNameTxt.ForeColor = System.Drawing.Color.Black;
            this.middleNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.middleNameTxt.Location = new System.Drawing.Point(244, 689);
            this.middleNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleNameTxt.MaxLength = 20;
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.middleNameTxt.PlaceholderText = "MIDDLE NAME";
            this.middleNameTxt.SelectedText = "";
            this.middleNameTxt.Size = new System.Drawing.Size(206, 43);
            this.middleNameTxt.TabIndex = 2;
            // 
            // addressTxt
            // 
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.DefaultText = "";
            this.addressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTxt.ForeColor = System.Drawing.Color.Black;
            this.addressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTxt.Location = new System.Drawing.Point(32, 770);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTxt.MaxLength = 255;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addressTxt.PlaceholderText = "ADDRESS";
            this.addressTxt.SelectedText = "";
            this.addressTxt.Size = new System.Drawing.Size(206, 43);
            this.addressTxt.TabIndex = 2;
            // 
            // contactTxt
            // 
            this.contactTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactTxt.DefaultText = "";
            this.contactTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactTxt.ForeColor = System.Drawing.Color.Black;
            this.contactTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTxt.Location = new System.Drawing.Point(244, 770);
            this.contactTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactTxt.MaxLength = 20;
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.contactTxt.PlaceholderText = "CONTACT";
            this.contactTxt.SelectedText = "";
            this.contactTxt.Size = new System.Drawing.Size(206, 43);
            this.contactTxt.TabIndex = 2;
            this.contactTxt.TextChanged += new System.EventHandler(this.contactTxt_TextChanged);
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtbox.DefaultText = "";
            this.searchTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTxtbox.ForeColor = System.Drawing.Color.Black;
            this.searchTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtbox.Location = new System.Drawing.Point(444, 34);
            this.searchTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTxtbox.PlaceholderText = "SEARCH BOX";
            this.searchTxtbox.SelectedText = "";
            this.searchTxtbox.Size = new System.Drawing.Size(385, 44);
            this.searchTxtbox.TabIndex = 4;
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(845, 34);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(148, 44);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(299, 746);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(298, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(502, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(739, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1027, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(883, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(104, 746);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(527, 746);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Username";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(772, 746);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(1018, 746);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Role";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(103, 665);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "First Name";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::School_Management_Transparency.Properties.Resources.ncbii_login_img;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1138, 98);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoRoundedCorners = true;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(32, 890);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1138, 10);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearAllBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearAllBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearAllBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearAllBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearAllBtn.ForeColor = System.Drawing.Color.White;
            this.clearAllBtn.Location = new System.Drawing.Point(896, 827);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(180, 46);
            this.clearAllBtn.TabIndex = 10;
            this.clearAllBtn.Text = "CLEAR ";
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.studentDGV;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.guna2PictureBox1;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // UC_STUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchTxtbox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.middleNameTxt);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.studentDGV);
            this.Controls.Add(this.lblSelectedUserId);
            this.Controls.Add(this.lblSelectedStudentId);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_STUDENT";
            this.Size = new System.Drawing.Size(1199, 918);
            this.Load += new System.EventHandler(this.UC_STUDENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView studentDGV;
        private Guna.UI2.WinForms.Guna2GradientButton addBtn;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox genderCombo;
        private Guna.UI2.WinForms.Guna2TextBox roleTxt;
        private Guna.UI2.WinForms.Guna2TextBox ageTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobPicker;
        private Guna.UI2.WinForms.Guna2TextBox lblSelectedStudentId;
        private Guna.UI2.WinForms.Guna2TextBox lblSelectedUserId;
        private Guna.UI2.WinForms.Guna2TextBox middleNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
        private Guna.UI2.WinForms.Guna2TextBox contactTxt;
        private Guna.UI2.WinForms.Guna2TextBox searchTxtbox;
        private Guna.UI2.WinForms.Guna2GradientButton clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton clearAllBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}
