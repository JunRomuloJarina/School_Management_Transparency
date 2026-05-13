namespace School_Management_Transparency.SchoolManagementTransparencyApp.AdminDashboardUserControls
{
    partial class UC_EXPENSE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fundBalanceDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.expenseFundComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSpendMoney = new Guna.UI2.WinForms.Guna2GradientButton();
            this.expenseAmountTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.expenseRemarksTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.expenseDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.clearBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expenseHistoryDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fundBalanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseHistoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // fundBalanceDGV
            // 
            this.fundBalanceDGV.AllowUserToAddRows = false;
            this.fundBalanceDGV.AllowUserToDeleteRows = false;
            this.fundBalanceDGV.AllowUserToResizeColumns = false;
            this.fundBalanceDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.fundBalanceDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fundBalanceDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fundBalanceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fundBalanceDGV.ColumnHeadersHeight = 30;
            this.fundBalanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fundBalanceDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.fundBalanceDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.fundBalanceDGV.Location = new System.Drawing.Point(40, 95);
            this.fundBalanceDGV.Name = "fundBalanceDGV";
            this.fundBalanceDGV.ReadOnly = true;
            this.fundBalanceDGV.RowHeadersVisible = false;
            this.fundBalanceDGV.RowHeadersWidth = 51;
            this.fundBalanceDGV.RowTemplate.Height = 24;
            this.fundBalanceDGV.Size = new System.Drawing.Size(444, 530);
            this.fundBalanceDGV.TabIndex = 0;
            this.fundBalanceDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.fundBalanceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.fundBalanceDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.fundBalanceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.fundBalanceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.fundBalanceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.fundBalanceDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.fundBalanceDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.fundBalanceDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.fundBalanceDGV.ThemeStyle.ReadOnly = true;
            this.fundBalanceDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.fundBalanceDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fundBalanceDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundBalanceDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.fundBalanceDGV.ThemeStyle.RowsStyle.Height = 24;
            this.fundBalanceDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.fundBalanceDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // expenseFundComboBox
            // 
            this.expenseFundComboBox.AutoRoundedCorners = true;
            this.expenseFundComboBox.BackColor = System.Drawing.Color.Transparent;
            this.expenseFundComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.expenseFundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseFundComboBox.FocusedColor = System.Drawing.Color.Maroon;
            this.expenseFundComboBox.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.expenseFundComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expenseFundComboBox.ForeColor = System.Drawing.Color.Black;
            this.expenseFundComboBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.expenseFundComboBox.ItemHeight = 30;
            this.expenseFundComboBox.Location = new System.Drawing.Point(804, 685);
            this.expenseFundComboBox.Name = "expenseFundComboBox";
            this.expenseFundComboBox.Size = new System.Drawing.Size(279, 36);
            this.expenseFundComboBox.TabIndex = 1;
            // 
            // btnSpendMoney
            // 
            this.btnSpendMoney.Animated = true;
            this.btnSpendMoney.AnimatedGIF = true;
            this.btnSpendMoney.AutoRoundedCorners = true;
            this.btnSpendMoney.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpendMoney.BorderThickness = 1;
            this.btnSpendMoney.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpendMoney.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpendMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpendMoney.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpendMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpendMoney.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSpendMoney.FillColor2 = System.Drawing.Color.Red;
            this.btnSpendMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSpendMoney.ForeColor = System.Drawing.Color.White;
            this.btnSpendMoney.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSpendMoney.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnSpendMoney.Location = new System.Drawing.Point(876, 753);
            this.btnSpendMoney.Name = "btnSpendMoney";
            this.btnSpendMoney.Size = new System.Drawing.Size(207, 45);
            this.btnSpendMoney.TabIndex = 2;
            this.btnSpendMoney.Text = "Confirm Transaction";
            this.btnSpendMoney.Click += new System.EventHandler(this.btnSpendMoney_Click);
            // 
            // expenseAmountTxt
            // 
            this.expenseAmountTxt.AutoRoundedCorners = true;
            this.expenseAmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseAmountTxt.DefaultText = "";
            this.expenseAmountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseAmountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseAmountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseAmountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseAmountTxt.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.expenseAmountTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expenseAmountTxt.ForeColor = System.Drawing.Color.Black;
            this.expenseAmountTxt.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.expenseAmountTxt.Location = new System.Drawing.Point(133, 685);
            this.expenseAmountTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseAmountTxt.Name = "expenseAmountTxt";
            this.expenseAmountTxt.PlaceholderText = "";
            this.expenseAmountTxt.SelectedText = "";
            this.expenseAmountTxt.Size = new System.Drawing.Size(229, 36);
            this.expenseAmountTxt.TabIndex = 3;
            // 
            // expenseRemarksTxt
            // 
            this.expenseRemarksTxt.AutoScroll = true;
            this.expenseRemarksTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseRemarksTxt.DefaultText = "";
            this.expenseRemarksTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseRemarksTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseRemarksTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseRemarksTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseRemarksTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseRemarksTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expenseRemarksTxt.ForeColor = System.Drawing.Color.Black;
            this.expenseRemarksTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseRemarksTxt.Location = new System.Drawing.Point(379, 685);
            this.expenseRemarksTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseRemarksTxt.Multiline = true;
            this.expenseRemarksTxt.Name = "expenseRemarksTxt";
            this.expenseRemarksTxt.PlaceholderText = "";
            this.expenseRemarksTxt.SelectedText = "";
            this.expenseRemarksTxt.Size = new System.Drawing.Size(229, 180);
            this.expenseRemarksTxt.TabIndex = 3;
            // 
            // expenseDatePicker
            // 
            this.expenseDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.expenseDatePicker.Checked = true;
            this.expenseDatePicker.FillColor = System.Drawing.Color.White;
            this.expenseDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expenseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expenseDatePicker.Location = new System.Drawing.Point(625, 685);
            this.expenseDatePicker.MaxDate = new System.DateTime(2100, 2, 3, 0, 0, 0, 0);
            this.expenseDatePicker.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.expenseDatePicker.Name = "expenseDatePicker";
            this.expenseDatePicker.Size = new System.Drawing.Size(150, 36);
            this.expenseDatePicker.TabIndex = 4;
            this.expenseDatePicker.UseTransparentBackground = true;
            this.expenseDatePicker.Value = new System.DateTime(2026, 5, 13, 21, 26, 54, 332);
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.AnimatedGIF = true;
            this.clearBtn.AutoRoundedCorners = true;
            this.clearBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.FillColor2 = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.clearBtn.HoverState.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.Location = new System.Drawing.Point(726, 753);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(134, 45);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Reset Fields";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount to Spend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Purpose / Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaction Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(833, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Fund Category";
            // 
            // expenseHistoryDGV
            // 
            this.expenseHistoryDGV.AllowUserToAddRows = false;
            this.expenseHistoryDGV.AllowUserToDeleteRows = false;
            this.expenseHistoryDGV.AllowUserToResizeColumns = false;
            this.expenseHistoryDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.expenseHistoryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.expenseHistoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseHistoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.expenseHistoryDGV.ColumnHeadersHeight = 30;
            this.expenseHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseHistoryDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.expenseHistoryDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.expenseHistoryDGV.Location = new System.Drawing.Point(512, 95);
            this.expenseHistoryDGV.Name = "expenseHistoryDGV";
            this.expenseHistoryDGV.ReadOnly = true;
            this.expenseHistoryDGV.RowHeadersVisible = false;
            this.expenseHistoryDGV.RowHeadersWidth = 51;
            this.expenseHistoryDGV.RowTemplate.Height = 24;
            this.expenseHistoryDGV.Size = new System.Drawing.Size(700, 530);
            this.expenseHistoryDGV.TabIndex = 9;
            this.expenseHistoryDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.expenseHistoryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.expenseHistoryDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.expenseHistoryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.expenseHistoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.expenseHistoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.expenseHistoryDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expenseHistoryDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.expenseHistoryDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.expenseHistoryDGV.ThemeStyle.ReadOnly = true;
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.Height = 24;
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.expenseHistoryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Current Fund Balances";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Recent Expense Logs";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // UC_EXPENSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expenseHistoryDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.expenseDatePicker);
            this.Controls.Add(this.expenseRemarksTxt);
            this.Controls.Add(this.expenseAmountTxt);
            this.Controls.Add(this.btnSpendMoney);
            this.Controls.Add(this.expenseFundComboBox);
            this.Controls.Add(this.fundBalanceDGV);
            this.Name = "UC_EXPENSE";
            this.Size = new System.Drawing.Size(1250, 918);
            this.Load += new System.EventHandler(this.UC_EXPENSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundBalanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseHistoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView fundBalanceDGV;
        private Guna.UI2.WinForms.Guna2ComboBox expenseFundComboBox;
        private Guna.UI2.WinForms.Guna2GradientButton btnSpendMoney;
        private Guna.UI2.WinForms.Guna2TextBox expenseAmountTxt;
        private Guna.UI2.WinForms.Guna2TextBox expenseRemarksTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker expenseDatePicker;
        private Guna.UI2.WinForms.Guna2GradientButton clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView expenseHistoryDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
