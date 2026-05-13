namespace School_Management_Transparency.SchoolManagementTransparencyApp.UserControls
{
    partial class UC_INCOME
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.incomeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboCourseFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.paidBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.unpaidBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.showAllBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalUnpaidKPI = new System.Windows.Forms.Label();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.btnSettlePayment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTotalAmountHeader = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.comboFundSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // incomeDGV
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.incomeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.incomeDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.incomeDGV.ColumnHeadersHeight = 18;
            this.incomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incomeDGV.DefaultCellStyle = dataGridViewCellStyle21;
            this.incomeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.incomeDGV.Location = new System.Drawing.Point(47, 449);
            this.incomeDGV.Name = "incomeDGV";
            this.incomeDGV.ReadOnly = true;
            this.incomeDGV.RowHeadersVisible = false;
            this.incomeDGV.RowHeadersWidth = 51;
            this.incomeDGV.RowTemplate.Height = 24;
            this.incomeDGV.Size = new System.Drawing.Size(1158, 253);
            this.incomeDGV.TabIndex = 0;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.incomeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.incomeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.incomeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.incomeDGV.ThemeStyle.HeaderStyle.Height = 18;
            this.incomeDGV.ThemeStyle.ReadOnly = true;
            this.incomeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.incomeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.incomeDGV.ThemeStyle.RowsStyle.Height = 24;
            this.incomeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.incomeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.incomeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeDGV_CellContentClick);
            // 
            // comboCourseFilter
            // 
            this.comboCourseFilter.BackColor = System.Drawing.Color.Transparent;
            this.comboCourseFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourseFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCourseFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCourseFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCourseFilter.ItemHeight = 30;
            this.comboCourseFilter.Location = new System.Drawing.Point(770, 395);
            this.comboCourseFilter.Name = "comboCourseFilter";
            this.comboCourseFilter.Size = new System.Drawing.Size(435, 36);
            this.comboCourseFilter.TabIndex = 1;
            this.comboCourseFilter.SelectedIndexChanged += new System.EventHandler(this.comboCourseFilter_SelectedIndexChanged);
            // 
            // paidBtn
            // 
            this.paidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paidBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paidBtn.ForeColor = System.Drawing.Color.White;
            this.paidBtn.Location = new System.Drawing.Point(55, 709);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(106, 37);
            this.paidBtn.TabIndex = 2;
            this.paidBtn.Text = "PAID";
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // unpaidBtn
            // 
            this.unpaidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unpaidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unpaidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unpaidBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unpaidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unpaidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unpaidBtn.ForeColor = System.Drawing.Color.White;
            this.unpaidBtn.Location = new System.Drawing.Point(167, 709);
            this.unpaidBtn.Name = "unpaidBtn";
            this.unpaidBtn.Size = new System.Drawing.Size(106, 37);
            this.unpaidBtn.TabIndex = 2;
            this.unpaidBtn.Text = "UNPAID";
            this.unpaidBtn.Click += new System.EventHandler(this.unpaidBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAllBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAllBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showAllBtn.ForeColor = System.Drawing.Color.White;
            this.showAllBtn.Location = new System.Drawing.Point(279, 709);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(258, 37);
            this.showAllBtn.TabIndex = 3;
            this.showAllBtn.Text = "SHOW ALL PAID | UNPAID";
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblTotalIncome);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(28, 138);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(766, 250);
            this.guna2ShadowPanel1.TabIndex = 4;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.lblTotalIncome.Location = new System.Drawing.Point(13, 95);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(47, 49);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "0";
            this.lblTotalIncome.Click += new System.EventHandler(this.lblTotalIncome_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lblTotalUnpaidKPI);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(800, 138);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(452, 250);
            this.guna2ShadowPanel2.TabIndex = 4;
            // 
            // lblTotalUnpaidKPI
            // 
            this.lblTotalUnpaidKPI.AutoSize = true;
            this.lblTotalUnpaidKPI.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnpaidKPI.Location = new System.Drawing.Point(3, 116);
            this.lblTotalUnpaidKPI.Name = "lblTotalUnpaidKPI";
            this.lblTotalUnpaidKPI.Size = new System.Drawing.Size(33, 35);
            this.lblTotalUnpaidKPI.TabIndex = 0;
            this.lblTotalUnpaidKPI.Text = "0";
            this.lblTotalUnpaidKPI.Click += new System.EventHandler(this.lblTotalIncome_Click);
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedStudent.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedStudent.Location = new System.Drawing.Point(64, 28);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(108, 26);
            this.lblSelectedStudent.TabIndex = 5;
            this.lblSelectedStudent.Text = "{NAME}";
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettlePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.Location = new System.Drawing.Point(1025, 752);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(180, 45);
            this.btnSettlePayment.TabIndex = 6;
            this.btnSettlePayment.Text = "Settle Payment";
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // lblTotalAmountHeader
            // 
            this.lblTotalAmountHeader.AutoSize = true;
            this.lblTotalAmountHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmountHeader.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountHeader.Location = new System.Drawing.Point(60, 82);
            this.lblTotalAmountHeader.Name = "lblTotalAmountHeader";
            this.lblTotalAmountHeader.Size = new System.Drawing.Size(118, 26);
            this.lblTotalAmountHeader.TabIndex = 5;
            this.lblTotalAmountHeader.Text = "{TOTAL}";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(69, 395);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "SEARCH BOX";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(229, 36);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // clearSearch
            // 
            this.clearSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearSearch.ForeColor = System.Drawing.Color.White;
            this.clearSearch.Location = new System.Drawing.Point(304, 395);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(123, 36);
            this.clearSearch.TabIndex = 8;
            this.clearSearch.Text = "CLEAR";
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // comboFundSelect
            // 
            this.comboFundSelect.BackColor = System.Drawing.Color.Transparent;
            this.comboFundSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFundSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFundSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboFundSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboFundSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFundSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFundSelect.ItemHeight = 30;
            this.comboFundSelect.Location = new System.Drawing.Point(680, 752);
            this.comboFundSelect.Name = "comboFundSelect";
            this.comboFundSelect.Size = new System.Drawing.Size(321, 36);
            this.comboFundSelect.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Destination Fund:";
            this.label1.Click += new System.EventHandler(this.lblTotalIncome_Click);
            // 
            // UC_INCOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFundSelect);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSettlePayment);
            this.Controls.Add(this.lblTotalAmountHeader);
            this.Controls.Add(this.lblSelectedStudent);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.unpaidBtn);
            this.Controls.Add(this.paidBtn);
            this.Controls.Add(this.comboCourseFilter);
            this.Controls.Add(this.incomeDGV);
            this.Name = "UC_INCOME";
            this.Size = new System.Drawing.Size(1292, 918);
            this.Load += new System.EventHandler(this.UC_INCOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView incomeDGV;
        private Guna.UI2.WinForms.Guna2ComboBox comboCourseFilter;
        private Guna.UI2.WinForms.Guna2GradientButton paidBtn;
        private Guna.UI2.WinForms.Guna2GradientButton unpaidBtn;
        private Guna.UI2.WinForms.Guna2GradientButton showAllBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalUnpaidKPI;
        private System.Windows.Forms.Label lblSelectedStudent;
        private Guna.UI2.WinForms.Guna2GradientButton btnSettlePayment;
        private System.Windows.Forms.Label lblTotalAmountHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton clearSearch;
        private Guna.UI2.WinForms.Guna2ComboBox comboFundSelect;
        private System.Windows.Forms.Label label1;
    }
}
