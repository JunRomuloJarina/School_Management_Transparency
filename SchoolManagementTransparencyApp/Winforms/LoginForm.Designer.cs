namespace School_Management_Transparency.SchoolManagementTransparencyApp.Winfroms
{
    partial class LoginForm
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.signupBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.signInBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.passwordTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2DragControl2.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1393, 873);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.linkLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.signupBtn);
            this.guna2ShadowPanel1.Controls.Add(this.signInBtn);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.cuiLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.passwordTxtbox);
            this.guna2ShadowPanel1.Controls.Add(this.usernameTxtbox);
            this.guna2ShadowPanel1.EdgeWidth = 10;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.ForeColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(368, 26);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 9;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.ShadowDepth = 200;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(638, 816);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Forgot your  password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(333, 550);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reset Password";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(49, 740);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(537, 10);
            this.guna2Separator2.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(49, 276);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(537, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // signupBtn
            // 
            this.signupBtn.Animated = true;
            this.signupBtn.AnimatedGIF = true;
            this.signupBtn.AutoRoundedCorners = true;
            this.signupBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupBtn.FillColor = System.Drawing.Color.White;
            this.signupBtn.FillColor2 = System.Drawing.Color.White;
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupBtn.Location = new System.Drawing.Point(141, 620);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.PressedColor = System.Drawing.Color.Lime;
            this.signupBtn.Size = new System.Drawing.Size(353, 45);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "Don\'t have account? Sign Up";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Animated = true;
            this.signInBtn.AutoRoundedCorners = true;
            this.signInBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.BorderThickness = 1;
            this.signInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.signInBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.IndicateFocus = true;
            this.signInBtn.Location = new System.Drawing.Point(141, 502);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.PressedColor = System.Drawing.Color.Lime;
            this.signInBtn.Size = new System.Drawing.Size(353, 45);
            this.signInBtn.TabIndex = 4;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "SCHOOL\\ MANAGEMENT\\ TRANSPARENCY";
            this.cuiLabel1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(49, 62);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(537, 249);
            this.cuiLabel1.TabIndex = 1;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Animated = true;
            this.passwordTxtbox.AutoRoundedCorners = true;
            this.passwordTxtbox.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtbox.DefaultText = "";
            this.passwordTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtbox.FillColor = System.Drawing.SystemColors.HighlightText;
            this.passwordTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxtbox.ForeColor = System.Drawing.Color.Black;
            this.passwordTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtbox.Location = new System.Drawing.Point(141, 442);
            this.passwordTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.PasswordChar = '*';
            this.passwordTxtbox.PlaceholderText = "";
            this.passwordTxtbox.SelectedText = "";
            this.passwordTxtbox.Size = new System.Drawing.Size(353, 40);
            this.passwordTxtbox.TabIndex = 1;
            this.passwordTxtbox.TextChanged += new System.EventHandler(this.passwordTxtbox_TextChanged);
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Animated = true;
            this.usernameTxtbox.AutoRoundedCorners = true;
            this.usernameTxtbox.BorderColor = System.Drawing.Color.DarkGray;
            this.usernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtbox.DefaultText = "";
            this.usernameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtbox.FillColor = System.Drawing.SystemColors.HighlightText;
            this.usernameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxtbox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxtbox.Location = new System.Drawing.Point(141, 364);
            this.usernameTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.PlaceholderText = "";
            this.usernameTxtbox.SelectedText = "";
            this.usernameTxtbox.Size = new System.Drawing.Size(353, 40);
            this.usernameTxtbox.TabIndex = 0;
            this.usernameTxtbox.TextChanged += new System.EventHandler(this.usernameTxtbox_TextChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 873);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton signInBtn;
        private Guna.UI2.WinForms.Guna2GradientButton signupBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}