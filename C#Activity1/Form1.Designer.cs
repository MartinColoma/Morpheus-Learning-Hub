namespace C_Activity1
{
    partial class RTULogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RTUBg = new PictureBox();
            LoginPanel = new Panel();
            RMBRCheckBox = new CheckBox();
            ForgotLinkLabel = new LinkLabel();
            LoginBtn = new Button();
            SignUpLinkLabel = new LinkLabel();
            PassBox = new TextBox();
            PassLabel = new Label();
            SNBox = new TextBox();
            SNLabel = new Label();
            RTULHLabel = new Label();
            RTUSealIcon = new PictureBox();
            RegiPanel = new Panel();
            RegiSNBox = new TextBox();
            RegiSNLabel = new Label();
            CreateBtn = new Button();
            LoginLinkLabel = new LinkLabel();
            RegiPassBox = new TextBox();
            RegiPassLabel = new Label();
            RegiNameBox = new TextBox();
            RegiNameLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)RTUBg).BeginInit();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).BeginInit();
            RegiPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RTUBg
            // 
            RTUBg.Image = Properties.Resources.rtu_grounds;
            RTUBg.Location = new Point(-2, -5);
            RTUBg.Name = "RTUBg";
            RTUBg.Size = new Size(828, 696);
            RTUBg.TabIndex = 0;
            RTUBg.TabStop = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(249, 184, 74);
            LoginPanel.Controls.Add(RMBRCheckBox);
            LoginPanel.Controls.Add(ForgotLinkLabel);
            LoginPanel.Controls.Add(LoginBtn);
            LoginPanel.Controls.Add(SignUpLinkLabel);
            LoginPanel.Controls.Add(PassBox);
            LoginPanel.Controls.Add(PassLabel);
            LoginPanel.Controls.Add(SNBox);
            LoginPanel.Controls.Add(SNLabel);
            LoginPanel.Controls.Add(RTULHLabel);
            LoginPanel.Controls.Add(RTUSealIcon);
            LoginPanel.Location = new Point(499, 84);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(362, 529);
            LoginPanel.TabIndex = 1;
            LoginPanel.Paint += panel1_Paint;
            // 
            // RMBRCheckBox
            // 
            RMBRCheckBox.AutoSize = true;
            RMBRCheckBox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RMBRCheckBox.ForeColor = Color.White;
            RMBRCheckBox.Location = new Point(24, 329);
            RMBRCheckBox.Name = "RMBRCheckBox";
            RMBRCheckBox.Size = new Size(117, 19);
            RMBRCheckBox.TabIndex = 11;
            RMBRCheckBox.Text = "Remember Me";
            RMBRCheckBox.UseVisualStyleBackColor = true;
            RMBRCheckBox.CheckedChanged += RMBRCheckBox_CheckedChanged;
            // 
            // ForgotLinkLabel
            // 
            ForgotLinkLabel.AutoSize = true;
            ForgotLinkLabel.BackColor = Color.Transparent;
            ForgotLinkLabel.Font = new Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForgotLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            ForgotLinkLabel.LinkColor = Color.White;
            ForgotLinkLabel.Location = new Point(14, 422);
            ForgotLinkLabel.Name = "ForgotLinkLabel";
            ForgotLinkLabel.Size = new Size(116, 14);
            ForgotLinkLabel.TabIndex = 10;
            ForgotLinkLabel.TabStop = true;
            ForgotLinkLabel.Text = "Forgot Password?|";
            ForgotLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(249, 184, 74);
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(24, 79, 144);
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 79, 144);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(240, 329);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(95, 31);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignUpLinkLabel
            // 
            SignUpLinkLabel.ActiveLinkColor = Color.RoyalBlue;
            SignUpLinkLabel.AutoSize = true;
            SignUpLinkLabel.Font = new Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            SignUpLinkLabel.LinkColor = Color.White;
            SignUpLinkLabel.Location = new Point(128, 422);
            SignUpLinkLabel.Name = "SignUpLinkLabel";
            SignUpLinkLabel.Size = new Size(231, 14);
            SignUpLinkLabel.TabIndex = 8;
            SignUpLinkLabel.TabStop = true;
            SignUpLinkLabel.Text = "New student? Create an account here.";
            SignUpLinkLabel.LinkClicked += SignUpLabel_LinkClicked;
            // 
            // PassBox
            // 
            PassBox.BackColor = Color.White;
            PassBox.Cursor = Cursors.IBeam;
            PassBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PassBox.ForeColor = Color.FromArgb(24, 79, 144);
            PassBox.Location = new Point(24, 286);
            PassBox.Margin = new Padding(10);
            PassBox.Multiline = true;
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '•';
            PassBox.Size = new Size(311, 30);
            PassBox.TabIndex = 5;
            PassBox.TextChanged += PassBox_TextChanged;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            PassLabel.ForeColor = Color.FromArgb(24, 79, 144);
            PassLabel.Location = new Point(14, 255);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(96, 19);
            PassLabel.TabIndex = 4;
            PassLabel.Text = "Password:";
            // 
            // SNBox
            // 
            SNBox.BackColor = Color.White;
            SNBox.Cursor = Cursors.IBeam;
            SNBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SNBox.ForeColor = Color.FromArgb(24, 79, 144);
            SNBox.Location = new Point(24, 198);
            SNBox.Margin = new Padding(10);
            SNBox.Multiline = true;
            SNBox.Name = "SNBox";
            SNBox.Size = new Size(311, 30);
            SNBox.TabIndex = 3;
            SNBox.TextChanged += SNBox_TextChanged;
            // 
            // SNLabel
            // 
            SNLabel.AutoSize = true;
            SNLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            SNLabel.ForeColor = Color.FromArgb(24, 79, 144);
            SNLabel.Location = new Point(14, 169);
            SNLabel.Name = "SNLabel";
            SNLabel.Size = new Size(160, 19);
            SNLabel.TabIndex = 2;
            SNLabel.Text = "Student Number:";
            SNLabel.Click += label1_Click_1;
            // 
            // RTULHLabel
            // 
            RTULHLabel.AutoSize = true;
            RTULHLabel.Font = new Font("STZhongsong", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            RTULHLabel.ForeColor = Color.FromArgb(24, 79, 144);
            RTULHLabel.Location = new Point(46, 113);
            RTULHLabel.Name = "RTULHLabel";
            RTULHLabel.Size = new Size(270, 24);
            RTULHLabel.TabIndex = 1;
            RTULHLabel.Text = "RTUISTA Learning Hub";
            RTULHLabel.Click += label1_Click;
            // 
            // RTUSealIcon
            // 
            RTUSealIcon.Image = Properties.Resources.RTU_Seal_64x64;
            RTUSealIcon.Location = new Point(157, 23);
            RTUSealIcon.Name = "RTUSealIcon";
            RTUSealIcon.Size = new Size(64, 64);
            RTUSealIcon.TabIndex = 0;
            RTUSealIcon.TabStop = false;
            RTUSealIcon.Click += pictureBox1_Click;
            // 
            // RegiPanel
            // 
            RegiPanel.BackColor = Color.FromArgb(24, 79, 144);
            RegiPanel.Controls.Add(RegiSNBox);
            RegiPanel.Controls.Add(RegiSNLabel);
            RegiPanel.Controls.Add(CreateBtn);
            RegiPanel.Controls.Add(LoginLinkLabel);
            RegiPanel.Controls.Add(RegiPassBox);
            RegiPanel.Controls.Add(RegiPassLabel);
            RegiPanel.Controls.Add(RegiNameBox);
            RegiPanel.Controls.Add(RegiNameLabel);
            RegiPanel.Controls.Add(label5);
            RegiPanel.Location = new Point(867, 84);
            RegiPanel.Name = "RegiPanel";
            RegiPanel.Size = new Size(362, 526);
            RegiPanel.TabIndex = 12;
            // 
            // RegiSNBox
            // 
            RegiSNBox.BackColor = Color.White;
            RegiSNBox.Cursor = Cursors.IBeam;
            RegiSNBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegiSNBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiSNBox.Location = new Point(21, 230);
            RegiSNBox.Margin = new Padding(10);
            RegiSNBox.Multiline = true;
            RegiSNBox.Name = "RegiSNBox";
            RegiSNBox.Size = new Size(311, 30);
            RegiSNBox.TabIndex = 13;
            RegiSNBox.TextChanged += RegiSNBox_TextChanged;
            // 
            // RegiSNLabel
            // 
            RegiSNLabel.AutoSize = true;
            RegiSNLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiSNLabel.ForeColor = Color.White;
            RegiSNLabel.Location = new Point(11, 201);
            RegiSNLabel.Name = "RegiSNLabel";
            RegiSNLabel.Size = new Size(160, 19);
            RegiSNLabel.TabIndex = 12;
            RegiSNLabel.Text = "Student Number:";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(24, 79, 144);
            CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(249, 184, 74);
            CreateBtn.FlatAppearance.BorderSize = 2;
            CreateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 184, 74);
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(228, 365);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(104, 31);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // LoginLinkLabel
            // 
            LoginLinkLabel.ActiveLinkColor = Color.FromArgb(249, 184, 74);
            LoginLinkLabel.AutoSize = true;
            LoginLinkLabel.ForeColor = Color.White;
            LoginLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            LoginLinkLabel.LinkColor = Color.White;
            LoginLinkLabel.Location = new Point(86, 467);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(204, 15);
            LoginLinkLabel.TabIndex = 8;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Already have an account? Login here.";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // RegiPassBox
            // 
            RegiPassBox.BackColor = Color.White;
            RegiPassBox.Cursor = Cursors.IBeam;
            RegiPassBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegiPassBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiPassBox.Location = new Point(21, 322);
            RegiPassBox.Margin = new Padding(10);
            RegiPassBox.Multiline = true;
            RegiPassBox.Name = "RegiPassBox";
            RegiPassBox.PasswordChar = '•';
            RegiPassBox.Size = new Size(311, 30);
            RegiPassBox.TabIndex = 5;
            RegiPassBox.TextChanged += RegiPassBox_TextChanged;
            // 
            // RegiPassLabel
            // 
            RegiPassLabel.AutoSize = true;
            RegiPassLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiPassLabel.ForeColor = Color.White;
            RegiPassLabel.Location = new Point(11, 291);
            RegiPassLabel.Name = "RegiPassLabel";
            RegiPassLabel.Size = new Size(96, 19);
            RegiPassLabel.TabIndex = 4;
            RegiPassLabel.Text = "Password:";
            // 
            // RegiNameBox
            // 
            RegiNameBox.BackColor = Color.White;
            RegiNameBox.Cursor = Cursors.IBeam;
            RegiNameBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegiNameBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiNameBox.Location = new Point(21, 139);
            RegiNameBox.Margin = new Padding(10);
            RegiNameBox.Multiline = true;
            RegiNameBox.Name = "RegiNameBox";
            RegiNameBox.Size = new Size(311, 30);
            RegiNameBox.TabIndex = 3;
            RegiNameBox.TextChanged += RegiNameBox_TextChanged;
            // 
            // RegiNameLabel
            // 
            RegiNameLabel.AutoSize = true;
            RegiNameLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiNameLabel.ForeColor = Color.White;
            RegiNameLabel.Location = new Point(11, 110);
            RegiNameLabel.Name = "RegiNameLabel";
            RegiNameLabel.Size = new Size(63, 19);
            RegiNameLabel.TabIndex = 2;
            RegiNameLabel.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("STZhongsong", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(110, 44);
            label5.Name = "label5";
            label5.Size = new Size(139, 24);
            label5.TabIndex = 1;
            label5.Text = "Get Started";
            // 
            // RTULogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 79, 144);
            ClientSize = new Size(1264, 681);
            Controls.Add(LoginPanel);
            Controls.Add(RTUBg);
            Controls.Add(RegiPanel);
            Name = "RTULogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Learning Hub Login";
            Load += RTULogin_Load;
            ((System.ComponentModel.ISupportInitialize)RTUBg).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).EndInit();
            RegiPanel.ResumeLayout(false);
            RegiPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RTUBg;
        private Panel LoginPanel;
        private PictureBox RTUSealIcon;
        private Label RTULHLabel;
        private Label SNLabel;
        private TextBox SNBox;
        private TextBox PassBox;
        private Label PassLabel;
        private Label PassWarningLabel;
        private Label SNWarningLabel;
        private LinkLabel SignUpLinkLabel;
        private Button LoginBtn;
        private LinkLabel ForgotLinkLabel;
        private CheckBox RMBRCheckBox;
        private Panel RegiPanel;
        private Button CreateBtn;
        private LinkLabel LoginLinkLabel;
        private Label RegiWarning3;
        private Label RegiWarning1;
        private TextBox RegiPassBox;
        private Label RegiPassLabel;
        private TextBox RegiNameBox;
        private Label RegiNameLabel;
        private Label label5;
        private Label RegiWarning2;
        private TextBox RegiSNBox;
        private Label RegiSNLabel;
    }
}