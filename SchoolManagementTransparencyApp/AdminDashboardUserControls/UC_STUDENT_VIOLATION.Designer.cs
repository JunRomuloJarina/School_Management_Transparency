namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    partial class UC_STUDENT_VIOLATION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.clearBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.searchTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addStudentViolationContainerPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.studentviolatorSelectorCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentviolationDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentviolationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Controls.Add(this.studentviolatorSelectorCombo);
            this.guna2ShadowPanel1.Controls.Add(this.clearBtn);
            this.guna2ShadowPanel1.Controls.Add(this.searchTxtbox);
            this.guna2ShadowPanel1.Controls.Add(this.addStudentViolationContainerPanel);
            this.guna2ShadowPanel1.Controls.Add(this.studentviolationDGV);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 0;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1330, 918);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
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
            this.clearBtn.Location = new System.Drawing.Point(232, 72);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 36);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.searchTxtbox.Location = new System.Drawing.Point(51, 72);
            this.searchTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.PlaceholderText = "SEARCH BOX";
            this.searchTxtbox.SelectedText = "";
            this.searchTxtbox.Size = new System.Drawing.Size(175, 36);
            this.searchTxtbox.TabIndex = 3;
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // addStudentViolationContainerPanel
            // 
            this.addStudentViolationContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.addStudentViolationContainerPanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.addStudentViolationContainerPanel.Location = new System.Drawing.Point(665, 46);
            this.addStudentViolationContainerPanel.Name = "addStudentViolationContainerPanel";
            this.addStudentViolationContainerPanel.Radius = 10;
            this.addStudentViolationContainerPanel.ShadowColor = System.Drawing.Color.Black;
            this.addStudentViolationContainerPanel.ShadowShift = 15;
            this.addStudentViolationContainerPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.addStudentViolationContainerPanel.Size = new System.Drawing.Size(616, 805);
            this.addStudentViolationContainerPanel.TabIndex = 2;
            // 
            // studentviolatorSelectorCombo
            // 
            this.studentviolatorSelectorCombo.BackColor = System.Drawing.Color.Transparent;
            this.studentviolatorSelectorCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentviolatorSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentviolatorSelectorCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentviolatorSelectorCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentviolatorSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentviolatorSelectorCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.studentviolatorSelectorCombo.ItemHeight = 30;
            this.studentviolatorSelectorCombo.Location = new System.Drawing.Point(329, 72);
            this.studentviolatorSelectorCombo.Name = "studentviolatorSelectorCombo";
            this.studentviolatorSelectorCombo.Size = new System.Drawing.Size(296, 36);
            this.studentviolatorSelectorCombo.TabIndex = 1;
            this.studentviolatorSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.studentviolatorSelectorCombo_SelectedIndexChanged);
            // 
            // studentviolationDGV
            // 
            this.studentviolationDGV.AllowUserToAddRows = false;
            this.studentviolationDGV.AllowUserToDeleteRows = false;
            this.studentviolationDGV.AllowUserToResizeColumns = false;
            this.studentviolationDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.studentviolationDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentviolationDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentviolationDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentviolationDGV.ColumnHeadersHeight = 30;
            this.studentviolationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentviolationDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentviolationDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentviolationDGV.Location = new System.Drawing.Point(36, 135);
            this.studentviolationDGV.Name = "studentviolationDGV";
            this.studentviolationDGV.ReadOnly = true;
            this.studentviolationDGV.RowHeadersVisible = false;
            this.studentviolationDGV.RowHeadersWidth = 51;
            this.studentviolationDGV.RowTemplate.Height = 24;
            this.studentviolationDGV.Size = new System.Drawing.Size(601, 514);
            this.studentviolationDGV.TabIndex = 0;
            this.studentviolationDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.studentviolationDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.studentviolationDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.studentviolationDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.studentviolationDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.studentviolationDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.studentviolationDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentviolationDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.studentviolationDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentviolationDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentviolationDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.studentviolationDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentviolationDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.studentviolationDGV.ThemeStyle.ReadOnly = true;
            this.studentviolationDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.studentviolationDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentviolationDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentviolationDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentviolationDGV.ThemeStyle.RowsStyle.Height = 24;
            this.studentviolationDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentviolationDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentviolationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentviolationDGV_CellContentClick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2ShadowPanel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // UC_STUDENT_VIOLATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UC_STUDENT_VIOLATION";
            this.Size = new System.Drawing.Size(1330, 918);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentviolationDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ShadowPanel addStudentViolationContainerPanel;
        private Guna.UI2.WinForms.Guna2ComboBox studentviolatorSelectorCombo;
        private Guna.UI2.WinForms.Guna2DataGridView studentviolationDGV;
        private Guna.UI2.WinForms.Guna2GradientButton clearBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchTxtbox;
    }
}
