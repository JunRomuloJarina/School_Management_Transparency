namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    partial class UC_FUND
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fundSummaryDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTotalSchoolBalance = new System.Windows.Forms.Label();
            this.btnAddFund = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewFundName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.fundSummaryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // fundSummaryDGV
            // 
            this.fundSummaryDGV.AllowUserToAddRows = false;
            this.fundSummaryDGV.AllowUserToDeleteRows = false;
            this.fundSummaryDGV.AllowUserToResizeColumns = false;
            this.fundSummaryDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.fundSummaryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fundSummaryDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fundSummaryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fundSummaryDGV.ColumnHeadersHeight = 30;
            this.fundSummaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fundSummaryDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.fundSummaryDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.fundSummaryDGV.Location = new System.Drawing.Point(104, 211);
            this.fundSummaryDGV.Name = "fundSummaryDGV";
            this.fundSummaryDGV.ReadOnly = true;
            this.fundSummaryDGV.RowHeadersVisible = false;
            this.fundSummaryDGV.RowHeadersWidth = 51;
            this.fundSummaryDGV.RowTemplate.Height = 24;
            this.fundSummaryDGV.Size = new System.Drawing.Size(1042, 454);
            this.fundSummaryDGV.TabIndex = 0;
            this.fundSummaryDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.fundSummaryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.fundSummaryDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.fundSummaryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.fundSummaryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.fundSummaryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.fundSummaryDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.fundSummaryDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.fundSummaryDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.fundSummaryDGV.ThemeStyle.ReadOnly = true;
            this.fundSummaryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.fundSummaryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fundSummaryDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundSummaryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.fundSummaryDGV.ThemeStyle.RowsStyle.Height = 24;
            this.fundSummaryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.fundSummaryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.fundSummaryDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fundSummaryDGV_CellContentClick);
            // 
            // lblTotalSchoolBalance
            // 
            this.lblTotalSchoolBalance.AutoSize = true;
            this.lblTotalSchoolBalance.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSchoolBalance.Location = new System.Drawing.Point(111, 109);
            this.lblTotalSchoolBalance.Name = "lblTotalSchoolBalance";
            this.lblTotalSchoolBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSchoolBalance.Size = new System.Drawing.Size(37, 33);
            this.lblTotalSchoolBalance.TabIndex = 1;
            this.lblTotalSchoolBalance.Text = "{}";
            this.lblTotalSchoolBalance.Click += new System.EventHandler(this.lblTotalSchoolBalance_Click);
            // 
            // btnAddFund
            // 
            this.btnAddFund.Animated = true;
            this.btnAddFund.AnimatedGIF = true;
            this.btnAddFund.AutoRoundedCorners = true;
            this.btnAddFund.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFund.BorderThickness = 1;
            this.btnAddFund.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFund.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFund.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFund.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFund.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFund.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFund.FillColor2 = System.Drawing.Color.Red;
            this.btnAddFund.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFund.ForeColor = System.Drawing.Color.White;
            this.btnAddFund.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnAddFund.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnAddFund.Location = new System.Drawing.Point(256, 780);
            this.btnAddFund.Name = "btnAddFund";
            this.btnAddFund.Size = new System.Drawing.Size(180, 45);
            this.btnAddFund.TabIndex = 2;
            this.btnAddFund.Text = "Create Fund";
            this.btnAddFund.Click += new System.EventHandler(this.btnAddFund_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "School Financial Overview";
            // 
            // txtNewFundName
            // 
            this.txtNewFundName.Animated = true;
            this.txtNewFundName.AutoRoundedCorners = true;
            this.txtNewFundName.BorderColor = System.Drawing.Color.Gray;
            this.txtNewFundName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewFundName.DefaultText = "";
            this.txtNewFundName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewFundName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewFundName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewFundName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewFundName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.txtNewFundName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewFundName.ForeColor = System.Drawing.Color.Black;
            this.txtNewFundName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.txtNewFundName.Location = new System.Drawing.Point(363, 716);
            this.txtNewFundName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewFundName.Name = "txtNewFundName";
            this.txtNewFundName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewFundName.PlaceholderText = "";
            this.txtNewFundName.SelectedText = "";
            this.txtNewFundName.Size = new System.Drawing.Size(548, 45);
            this.txtNewFundName.TabIndex = 3;
            this.txtNewFundName.TextChanged += new System.EventHandler(this.txtNewFundName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AnimatedGIF = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FillColor2 = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnUpdate.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(442, 780);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Name";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AnimatedGIF = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FillColor2 = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(628, 780);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove Fund";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fund Category Name";
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AnimatedGIF = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FillColor2 = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClear.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(814, 780);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear/Cancel";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UC_FUND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewFundName);
            this.Controls.Add(this.btnAddFund);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalSchoolBalance);
            this.Controls.Add(this.fundSummaryDGV);
            this.Name = "UC_FUND";
            this.Size = new System.Drawing.Size(1250, 918);
            this.Load += new System.EventHandler(this.UC_FUND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundSummaryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView fundSummaryDGV;
        private System.Windows.Forms.Label lblTotalSchoolBalance;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddFund;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNewFundName;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
    }
}
