namespace School_Management_Transparency.SchoolManagementTransparencyApp.Winfroms
{
    partial class StudentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.contentContainerPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.studentFullnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.leftNavContainerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.homeBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mydebtBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.historyBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.leftNavContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // contentContainerPanel
            // 
            this.contentContainerPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.contentContainerPanel, "contentContainerPanel");
            this.contentContainerPanel.FillColor = System.Drawing.Color.White;
            this.contentContainerPanel.Name = "contentContainerPanel";
            this.contentContainerPanel.Radius = 9;
            this.contentContainerPanel.ShadowColor = System.Drawing.Color.Maroon;
            this.contentContainerPanel.ShadowShift = 10;
            this.contentContainerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentContainerPanel_Paint);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Separator3, "guna2Separator3");
            this.guna2Separator3.Name = "guna2Separator3";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Separator4, "guna2Separator4");
            this.guna2Separator4.Name = "guna2Separator4";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // studentFullnameLabel
            // 
            resources.ApplyResources(this.studentFullnameLabel, "studentFullnameLabel");
            this.studentFullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentFullnameLabel.ForeColor = System.Drawing.Color.White;
            this.studentFullnameLabel.Name = "studentFullnameLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::School_Management_Transparency.Properties.Resources.ncbii_log;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // leftNavContainerPanel
            // 
            this.leftNavContainerPanel.Controls.Add(this.logoutBtn);
            this.leftNavContainerPanel.Controls.Add(this.historyBtn);
            this.leftNavContainerPanel.Controls.Add(this.mydebtBtn);
            this.leftNavContainerPanel.Controls.Add(this.homeBtn);
            this.leftNavContainerPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.leftNavContainerPanel.Controls.Add(this.label2);
            this.leftNavContainerPanel.Controls.Add(this.studentFullnameLabel);
            this.leftNavContainerPanel.Controls.Add(this.guna2Separator2);
            this.leftNavContainerPanel.Controls.Add(this.guna2Separator4);
            this.leftNavContainerPanel.Controls.Add(this.guna2Separator3);
            this.leftNavContainerPanel.Controls.Add(this.guna2Separator1);
            resources.ApplyResources(this.leftNavContainerPanel, "leftNavContainerPanel");
            this.leftNavContainerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftNavContainerPanel.FillColor2 = System.Drawing.Color.Maroon;
            this.leftNavContainerPanel.Name = "leftNavContainerPanel";
            this.leftNavContainerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftNavContainerPanel_Paint);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.AnimatedGIF = true;
            this.homeBtn.AutoRoundedCorners = true;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderThickness = 1;
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.Red;
            this.homeBtn.FillColor2 = System.Drawing.Color.Black;
            resources.ApplyResources(this.homeBtn, "homeBtn");
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.homeBtn.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.homeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // mydebtBtn
            // 
            this.mydebtBtn.Animated = true;
            this.mydebtBtn.AnimatedGIF = true;
            this.mydebtBtn.AutoRoundedCorners = true;
            this.mydebtBtn.BackColor = System.Drawing.Color.Transparent;
            this.mydebtBtn.BorderThickness = 1;
            this.mydebtBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mydebtBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mydebtBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mydebtBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mydebtBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mydebtBtn.FillColor = System.Drawing.Color.Red;
            this.mydebtBtn.FillColor2 = System.Drawing.Color.Black;
            resources.ApplyResources(this.mydebtBtn, "mydebtBtn");
            this.mydebtBtn.ForeColor = System.Drawing.Color.White;
            this.mydebtBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.mydebtBtn.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.mydebtBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.mydebtBtn.Name = "mydebtBtn";
            this.mydebtBtn.Click += new System.EventHandler(this.mydebtBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Animated = true;
            this.historyBtn.AnimatedGIF = true;
            this.historyBtn.AutoRoundedCorners = true;
            this.historyBtn.BackColor = System.Drawing.Color.Transparent;
            this.historyBtn.BorderThickness = 1;
            this.historyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.historyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.historyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.historyBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.historyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.historyBtn.FillColor = System.Drawing.Color.Red;
            this.historyBtn.FillColor2 = System.Drawing.Color.Black;
            resources.ApplyResources(this.historyBtn, "historyBtn");
            this.historyBtn.ForeColor = System.Drawing.Color.White;
            this.historyBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.historyBtn.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.historyBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
            this.logoutBtn.AnimatedGIF = true;
            this.logoutBtn.AutoRoundedCorners = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderThickness = 1;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Red;
            this.logoutBtn.FillColor2 = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.logoutBtn, "logoutBtn");
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.logoutBtn.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentContainerPanel);
            this.Controls.Add(this.leftNavContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.leftNavContainerPanel.ResumeLayout(false);
            this.leftNavContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowPanel contentContainerPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel leftNavContainerPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentFullnameLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton homeBtn;
        private Guna.UI2.WinForms.Guna2GradientButton logoutBtn;
        private Guna.UI2.WinForms.Guna2GradientButton historyBtn;
        private Guna.UI2.WinForms.Guna2GradientButton mydebtBtn;
    }
}