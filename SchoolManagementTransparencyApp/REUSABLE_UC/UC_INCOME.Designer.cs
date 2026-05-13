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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // incomeDGV
            // 
            this.incomeDGV.AllowUserToAddRows = false;
            this.incomeDGV.AllowUserToDeleteRows = false;
            this.incomeDGV.AllowUserToResizeColumns = false;
            this.incomeDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.incomeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.incomeDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.incomeDGV.ColumnHeadersHeight = 30;
            this.incomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incomeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.incomeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.incomeDGV.Location = new System.Drawing.Point(47, 449);
            this.incomeDGV.Name = "incomeDGV";
            this.incomeDGV.ReadOnly = true;
            this.incomeDGV.RowHeadersVisible = false;
            this.incomeDGV.RowHeadersWidth = 51;
            this.incomeDGV.RowTemplate.Height = 24;
            this.incomeDGV.Size = new System.Drawing.Size(1158, 253);
            this.incomeDGV.TabIndex = 0;
            this.incomeDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.incomeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.incomeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.incomeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.incomeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.incomeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.incomeDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.incomeDGV.ThemeStyle.ReadOnly = true;
            this.incomeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.incomeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.incomeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.incomeDGV.ThemeStyle.RowsStyle.Height = 24;
            this.incomeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.incomeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.incomeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeDGV_CellContentClick);
            // 
            // comboCourseFilter
            // 
            this.comboCourseFilter.BackColor = System.Drawing.Color.Transparent;
            this.comboCourseFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourseFilter.FocusedColor = System.Drawing.Color.Red;
            this.comboCourseFilter.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.comboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCourseFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCourseFilter.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.comboCourseFilter.ItemHeight = 30;
            this.comboCourseFilter.Location = new System.Drawing.Point(770, 395);
            this.comboCourseFilter.Name = "comboCourseFilter";
            this.comboCourseFilter.Size = new System.Drawing.Size(435, 36);
            this.comboCourseFilter.TabIndex = 1;
            this.comboCourseFilter.SelectedIndexChanged += new System.EventHandler(this.comboCourseFilter_SelectedIndexChanged);
            // 
            // paidBtn
            // 
            this.paidBtn.Animated = true;
            this.paidBtn.AnimatedGIF = true;
            this.paidBtn.AutoRoundedCorners = true;
            this.paidBtn.BorderColor = System.Drawing.Color.Gray;
            this.paidBtn.BorderThickness = 1;
            this.paidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paidBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paidBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.paidBtn.FillColor2 = System.Drawing.Color.Red;
            this.paidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paidBtn.ForeColor = System.Drawing.Color.White;
            this.paidBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.paidBtn.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.paidBtn.Location = new System.Drawing.Point(55, 734);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(106, 37);
            this.paidBtn.TabIndex = 2;
            this.paidBtn.Text = "PAID";
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // unpaidBtn
            // 
            this.unpaidBtn.Animated = true;
            this.unpaidBtn.AnimatedGIF = true;
            this.unpaidBtn.AutoRoundedCorners = true;
            this.unpaidBtn.BorderColor = System.Drawing.Color.Gray;
            this.unpaidBtn.BorderThickness = 1;
            this.unpaidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unpaidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unpaidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unpaidBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unpaidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unpaidBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.unpaidBtn.FillColor2 = System.Drawing.Color.Red;
            this.unpaidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unpaidBtn.ForeColor = System.Drawing.Color.White;
            this.unpaidBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.unpaidBtn.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.unpaidBtn.Location = new System.Drawing.Point(167, 734);
            this.unpaidBtn.Name = "unpaidBtn";
            this.unpaidBtn.Size = new System.Drawing.Size(106, 37);
            this.unpaidBtn.TabIndex = 2;
            this.unpaidBtn.Text = "UNPAID";
            this.unpaidBtn.Click += new System.EventHandler(this.unpaidBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Animated = true;
            this.showAllBtn.AnimatedGIF = true;
            this.showAllBtn.AutoRoundedCorners = true;
            this.showAllBtn.BorderColor = System.Drawing.Color.Gray;
            this.showAllBtn.BorderThickness = 1;
            this.showAllBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAllBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAllBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAllBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.showAllBtn.FillColor2 = System.Drawing.Color.Red;
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showAllBtn.ForeColor = System.Drawing.Color.White;
            this.showAllBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.showAllBtn.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.showAllBtn.Location = new System.Drawing.Point(279, 734);
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
            this.btnSettlePayment.Animated = true;
            this.btnSettlePayment.AnimatedGIF = true;
            this.btnSettlePayment.AutoRoundedCorners = true;
            this.btnSettlePayment.BorderColor = System.Drawing.Color.Gray;
            this.btnSettlePayment.BorderThickness = 1;
            this.btnSettlePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettlePayment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettlePayment.FillColor2 = System.Drawing.Color.Red;
            this.btnSettlePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSettlePayment.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
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
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Red;
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
            this.clearSearch.Animated = true;
            this.clearSearch.AnimatedGIF = true;
            this.clearSearch.AutoRoundedCorners = true;
            this.clearSearch.BorderColor = System.Drawing.Color.Gray;
            this.clearSearch.BorderThickness = 1;
            this.clearSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.clearSearch.FillColor2 = System.Drawing.Color.Red;
            this.clearSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearSearch.ForeColor = System.Drawing.Color.White;
            this.clearSearch.HoverState.FillColor = System.Drawing.Color.Red;
            this.clearSearch.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
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
            this.comboFundSelect.FocusedColor = System.Drawing.Color.Red;
            this.comboFundSelect.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.comboFundSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFundSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFundSelect.HoverState.BorderColor = System.Drawing.Color.Maroon;
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
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
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
