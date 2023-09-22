namespace C_Activity1
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            LoginBtnTimer = new System.Windows.Forms.Timer(components);
            MorpheusLogo2 = new PictureBox();
            MorpheusLbl = new Label();
            SignUpLinkLabel = new LinkLabel();
            RecoveryPanel = new Panel();
            RCSNBox = new TextBox();
            RCSNLabel = new Label();
            SubmitBtn = new Button();
            FPtoLPLinkedLbl = new LinkLabel();
            RPINBox = new TextBox();
            RecoveryPINLabel = new Label();
            RecoveryHLabel = new Label();
            RegiPanel = new Panel();
            RegiShowPass = new CheckBox();
            RegiRPBox = new TextBox();
            RegiRPLabel = new Label();
            RegiSNBox = new TextBox();
            RegiSNLabel = new Label();
            CreateBtn = new Button();
            LoginLinkLabel = new LinkLabel();
            RegiPassBox = new TextBox();
            RegiPassLabel = new Label();
            RegiNameBox = new TextBox();
            RegiNameLabel = new Label();
            GSLabel = new Label();
            WCPanel = new Panel();
            WCMsgBox = new TextBox();
            MorpheusWCIcon = new PictureBox();
            LoginPanel = new Panel();
            UNTextPanel = new Panel();
            SNBox = new TextBox();
            RMBRCheckbox = new CheckBox();
            ForgotLinkLabel = new LinkLabel();
            LoginBtn = new Button();
            PassLabel = new Label();
            MorpheusLogo1 = new PictureBox();
            UNLabel = new Label();
            RTULHLabel = new Label();
            PassTextPanel = new Panel();
            PassBox = new TextBox();
            ShowPassCheck = new CheckBox();
            LnRPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).BeginInit();
            RecoveryPanel.SuspendLayout();
            RegiPanel.SuspendLayout();
            WCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusWCIcon).BeginInit();
            LoginPanel.SuspendLayout();
            UNTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo1).BeginInit();
            PassTextPanel.SuspendLayout();
            LnRPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBtnTimer
            // 
            LoginBtnTimer.Enabled = true;
            LoginBtnTimer.Interval = 15000;
            LoginBtnTimer.Tick += LoginBtnTimer_Tick;
            // 
            // MorpheusLogo2
            // 
            MorpheusLogo2.Image = Properties.Resources._3;
            MorpheusLogo2.Location = new Point(12, 12);
            MorpheusLogo2.Name = "MorpheusLogo2";
            MorpheusLogo2.Size = new Size(128, 128);
            MorpheusLogo2.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusLogo2.TabIndex = 17;
            MorpheusLogo2.TabStop = false;
            MorpheusLogo2.Click += MorpheusPB_Click;
            // 
            // MorpheusLbl
            // 
            MorpheusLbl.AutoSize = true;
            MorpheusLbl.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            MorpheusLbl.ForeColor = Color.FromArgb(250, 247, 247);
            MorpheusLbl.Location = new Point(125, 38);
            MorpheusLbl.Name = "MorpheusLbl";
            MorpheusLbl.Size = new Size(243, 56);
            MorpheusLbl.TabIndex = 14;
            MorpheusLbl.Text = "morpheus";
            MorpheusLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpLinkLabel
            // 
            SignUpLinkLabel.ActiveLinkColor = Color.RoyalBlue;
            SignUpLinkLabel.AutoSize = true;
            SignUpLinkLabel.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            SignUpLinkLabel.LinkColor = Color.FromArgb(250, 247, 247);
            SignUpLinkLabel.Location = new Point(99, 354);
            SignUpLinkLabel.Name = "SignUpLinkLabel";
            SignUpLinkLabel.Size = new Size(299, 15);
            SignUpLinkLabel.TabIndex = 8;
            SignUpLinkLabel.TabStop = true;
            SignUpLinkLabel.Text = "Don't have an account yet? Create one here.";
            SignUpLinkLabel.LinkClicked += SignUpLabel_LinkClicked;
            // 
            // RecoveryPanel
            // 
            RecoveryPanel.BackColor = Color.FromArgb(90, 115, 141);
            RecoveryPanel.Controls.Add(RCSNBox);
            RecoveryPanel.Controls.Add(RCSNLabel);
            RecoveryPanel.Controls.Add(SubmitBtn);
            RecoveryPanel.Controls.Add(FPtoLPLinkedLbl);
            RecoveryPanel.Controls.Add(RPINBox);
            RecoveryPanel.Controls.Add(RecoveryPINLabel);
            RecoveryPanel.Controls.Add(RecoveryHLabel);
            RecoveryPanel.Location = new Point(478, 54);
            RecoveryPanel.Name = "RecoveryPanel";
            RecoveryPanel.Size = new Size(362, 457);
            RecoveryPanel.TabIndex = 16;
            RecoveryPanel.Paint += RecoveryPanel_Paint;
            // 
            // RCSNBox
            // 
            RCSNBox.BackColor = Color.White;
            RCSNBox.Cursor = Cursors.IBeam;
            RCSNBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RCSNBox.ForeColor = Color.FromArgb(24, 79, 144);
            RCSNBox.Location = new Point(23, 189);
            RCSNBox.Margin = new Padding(10);
            RCSNBox.Multiline = true;
            RCSNBox.Name = "RCSNBox";
            RCSNBox.PlaceholderText = "Enter Student Number";
            RCSNBox.Size = new Size(311, 30);
            RCSNBox.TabIndex = 11;
            RCSNBox.TextChanged += RCSNBox_TextChanged;
            // 
            // RCSNLabel
            // 
            RCSNLabel.AutoSize = true;
            RCSNLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RCSNLabel.ForeColor = Color.White;
            RCSNLabel.Location = new Point(20, 160);
            RCSNLabel.Name = "RCSNLabel";
            RCSNLabel.Size = new Size(160, 19);
            RCSNLabel.TabIndex = 10;
            RCSNLabel.Text = "Student Number:";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(24, 79, 144);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderColor = Color.FromArgb(249, 184, 74);
            SubmitBtn.FlatAppearance.BorderSize = 2;
            SubmitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 184, 74);
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(230, 319);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(104, 31);
            SubmitBtn.TabIndex = 9;
            SubmitBtn.Text = "SUBMIT";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // FPtoLPLinkedLbl
            // 
            FPtoLPLinkedLbl.ActiveLinkColor = Color.FromArgb(249, 184, 74);
            FPtoLPLinkedLbl.AutoSize = true;
            FPtoLPLinkedLbl.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FPtoLPLinkedLbl.ForeColor = Color.White;
            FPtoLPLinkedLbl.LinkBehavior = LinkBehavior.HoverUnderline;
            FPtoLPLinkedLbl.LinkColor = Color.White;
            FPtoLPLinkedLbl.Location = new Point(73, 427);
            FPtoLPLinkedLbl.Name = "FPtoLPLinkedLbl";
            FPtoLPLinkedLbl.Size = new Size(214, 15);
            FPtoLPLinkedLbl.TabIndex = 8;
            FPtoLPLinkedLbl.TabStop = true;
            FPtoLPLinkedLbl.Text = "Got your Password? Login again.";
            FPtoLPLinkedLbl.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // RPINBox
            // 
            RPINBox.BackColor = Color.White;
            RPINBox.Cursor = Cursors.IBeam;
            RPINBox.Font = new Font("STZhongsong", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RPINBox.ForeColor = Color.FromArgb(24, 79, 144);
            RPINBox.Location = new Point(23, 276);
            RPINBox.Margin = new Padding(10);
            RPINBox.Multiline = true;
            RPINBox.Name = "RPINBox";
            RPINBox.PlaceholderText = "Enter PIN";
            RPINBox.Size = new Size(311, 30);
            RPINBox.TabIndex = 3;
            RPINBox.TextChanged += textBox4_TextChanged;
            // 
            // RecoveryPINLabel
            // 
            RecoveryPINLabel.AutoSize = true;
            RecoveryPINLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RecoveryPINLabel.ForeColor = Color.White;
            RecoveryPINLabel.Location = new Point(20, 246);
            RecoveryPINLabel.Name = "RecoveryPINLabel";
            RecoveryPINLabel.Size = new Size(127, 19);
            RecoveryPINLabel.TabIndex = 2;
            RecoveryPINLabel.Text = "Recovery Pin:";
            RecoveryPINLabel.Click += label4_Click;
            // 
            // RecoveryHLabel
            // 
            RecoveryHLabel.AutoSize = true;
            RecoveryHLabel.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            RecoveryHLabel.ForeColor = Color.White;
            RecoveryHLabel.Location = new Point(35, 61);
            RecoveryHLabel.Name = "RecoveryHLabel";
            RecoveryHLabel.Size = new Size(282, 31);
            RecoveryHLabel.TabIndex = 1;
            RecoveryHLabel.Text = "Password Recovery";
            RecoveryHLabel.TextAlign = ContentAlignment.MiddleCenter;
            RecoveryHLabel.Click += label5_Click;
            // 
            // RegiPanel
            // 
            RegiPanel.BackColor = Color.FromArgb(90, 115, 141);
            RegiPanel.Controls.Add(RegiShowPass);
            RegiPanel.Controls.Add(RegiRPBox);
            RegiPanel.Controls.Add(RegiRPLabel);
            RegiPanel.Controls.Add(RegiSNBox);
            RegiPanel.Controls.Add(RegiSNLabel);
            RegiPanel.Controls.Add(CreateBtn);
            RegiPanel.Controls.Add(LoginLinkLabel);
            RegiPanel.Controls.Add(RegiPassBox);
            RegiPanel.Controls.Add(RegiPassLabel);
            RegiPanel.Controls.Add(RegiNameBox);
            RegiPanel.Controls.Add(RegiNameLabel);
            RegiPanel.Controls.Add(GSLabel);
            RegiPanel.Location = new Point(199, 113);
            RegiPanel.Name = "RegiPanel";
            RegiPanel.Size = new Size(500, 480);
            RegiPanel.TabIndex = 12;
            RegiPanel.Paint += RegiPanel_Paint;
            // 
            // RegiShowPass
            // 
            RegiShowPass.AutoSize = true;
            RegiShowPass.BackColor = Color.White;
            RegiShowPass.Cursor = Cursors.Hand;
            RegiShowPass.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiShowPass.ForeColor = Color.White;
            RegiShowPass.Location = new Point(382, 319);
            RegiShowPass.Name = "RegiShowPass";
            RegiShowPass.Size = new Size(15, 14);
            RegiShowPass.TabIndex = 16;
            RegiShowPass.UseVisualStyleBackColor = false;
            RegiShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegiRPBox
            // 
            RegiRPBox.BackColor = Color.White;
            RegiRPBox.Cursor = Cursors.IBeam;
            RegiRPBox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiRPBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiRPBox.Location = new Point(86, 242);
            RegiRPBox.Margin = new Padding(10);
            RegiRPBox.Name = "RegiRPBox";
            RegiRPBox.PlaceholderText = "Enter PIN";
            RegiRPBox.Size = new Size(311, 25);
            RegiRPBox.TabIndex = 15;
            RegiRPBox.TextChanged += RegiRPBox_TextChanged;
            // 
            // RegiRPLabel
            // 
            RegiRPLabel.AutoSize = true;
            RegiRPLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiRPLabel.ForeColor = Color.White;
            RegiRPLabel.Location = new Point(76, 213);
            RegiRPLabel.Name = "RegiRPLabel";
            RegiRPLabel.Size = new Size(121, 19);
            RegiRPLabel.TabIndex = 14;
            RegiRPLabel.Text = "Recovery Pin";
            // 
            // RegiSNBox
            // 
            RegiSNBox.BackColor = Color.White;
            RegiSNBox.Cursor = Cursors.IBeam;
            RegiSNBox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiSNBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiSNBox.Location = new Point(86, 169);
            RegiSNBox.Margin = new Padding(10);
            RegiSNBox.Name = "RegiSNBox";
            RegiSNBox.PlaceholderText = "Enter Student Number";
            RegiSNBox.Size = new Size(311, 25);
            RegiSNBox.TabIndex = 13;
            RegiSNBox.TextChanged += RegiSNBox_TextChanged;
            // 
            // RegiSNLabel
            // 
            RegiSNLabel.AutoSize = true;
            RegiSNLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiSNLabel.ForeColor = Color.White;
            RegiSNLabel.Location = new Point(76, 140);
            RegiSNLabel.Name = "RegiSNLabel";
            RegiSNLabel.Size = new Size(160, 19);
            RegiSNLabel.TabIndex = 12;
            RegiSNLabel.Text = "Student Number:";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(24, 79, 144);
            CreateBtn.Cursor = Cursors.Hand;
            CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(249, 184, 74);
            CreateBtn.FlatAppearance.BorderSize = 2;
            CreateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 184, 74);
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(293, 367);
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
            LoginLinkLabel.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLinkLabel.ForeColor = Color.White;
            LoginLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            LoginLinkLabel.LinkColor = Color.White;
            LoginLinkLabel.Location = new Point(123, 429);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(248, 15);
            LoginLinkLabel.TabIndex = 8;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Already have an account? Login here.";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // RegiPassBox
            // 
            RegiPassBox.BackColor = Color.White;
            RegiPassBox.Cursor = Cursors.IBeam;
            RegiPassBox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiPassBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiPassBox.Location = new Point(86, 313);
            RegiPassBox.Margin = new Padding(10);
            RegiPassBox.Name = "RegiPassBox";
            RegiPassBox.PlaceholderText = "Enter Password";
            RegiPassBox.Size = new Size(311, 25);
            RegiPassBox.TabIndex = 5;
            RegiPassBox.UseSystemPasswordChar = true;
            RegiPassBox.TextChanged += RegiPassBox_TextChanged;
            RegiPassBox.KeyDown += RegiPassBox_KeyDown;
            // 
            // RegiPassLabel
            // 
            RegiPassLabel.AutoSize = true;
            RegiPassLabel.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            RegiPassLabel.ForeColor = Color.White;
            RegiPassLabel.Location = new Point(76, 282);
            RegiPassLabel.Name = "RegiPassLabel";
            RegiPassLabel.Size = new Size(96, 19);
            RegiPassLabel.TabIndex = 4;
            RegiPassLabel.Text = "Password:";
            // 
            // RegiNameBox
            // 
            RegiNameBox.BackColor = Color.White;
            RegiNameBox.Cursor = Cursors.IBeam;
            RegiNameBox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiNameBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiNameBox.Location = new Point(86, 103);
            RegiNameBox.Margin = new Padding(10);
            RegiNameBox.Name = "RegiNameBox";
            RegiNameBox.PlaceholderText = "Enter Name";
            RegiNameBox.Size = new Size(311, 25);
            RegiNameBox.TabIndex = 3;
            RegiNameBox.TextChanged += RegiNameBox_TextChanged;
            // 
            // RegiNameLabel
            // 
            RegiNameLabel.AutoSize = true;
            RegiNameLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiNameLabel.ForeColor = Color.White;
            RegiNameLabel.Location = new Point(76, 74);
            RegiNameLabel.Name = "RegiNameLabel";
            RegiNameLabel.Size = new Size(66, 23);
            RegiNameLabel.TabIndex = 2;
            RegiNameLabel.Text = "Name:";
            // 
            // GSLabel
            // 
            GSLabel.AutoSize = true;
            GSLabel.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            GSLabel.ForeColor = Color.White;
            GSLabel.Location = new Point(155, 20);
            GSLabel.Name = "GSLabel";
            GSLabel.Size = new Size(189, 38);
            GSLabel.TabIndex = 1;
            GSLabel.Text = "Get Started";
            GSLabel.TextAlign = ContentAlignment.MiddleCenter;
            GSLabel.Click += GSLabel_Click;
            // 
            // WCPanel
            // 
            WCPanel.Controls.Add(WCMsgBox);
            WCPanel.Controls.Add(MorpheusWCIcon);
            WCPanel.Controls.Add(SignUpLinkLabel);
            WCPanel.Location = new Point(7, 125);
            WCPanel.Name = "WCPanel";
            WCPanel.Size = new Size(498, 489);
            WCPanel.TabIndex = 18;
            WCPanel.Paint += panel3_Paint;
            // 
            // WCMsgBox
            // 
            WCMsgBox.BackColor = Color.FromArgb(90, 115, 141);
            WCMsgBox.BorderStyle = BorderStyle.None;
            WCMsgBox.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            WCMsgBox.ForeColor = Color.FromArgb(250, 247, 247);
            WCMsgBox.Location = new Point(50, 246);
            WCMsgBox.Multiline = true;
            WCMsgBox.Name = "WCMsgBox";
            WCMsgBox.Size = new Size(378, 94);
            WCMsgBox.TabIndex = 20;
            WCMsgBox.Text = "You are just one step away from your DREAMS. Make it through with the help of MORPHEUS.";
            WCMsgBox.TextChanged += textBox2_TextChanged;
            // 
            // MorpheusWCIcon
            // 
            MorpheusWCIcon.Image = Properties.Resources.Morpheus_Icons__2_;
            MorpheusWCIcon.Location = new Point(118, 8);
            MorpheusWCIcon.Name = "MorpheusWCIcon";
            MorpheusWCIcon.Size = new Size(250, 250);
            MorpheusWCIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusWCIcon.TabIndex = 19;
            MorpheusWCIcon.TabStop = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(250, 247, 247);
            LoginPanel.Controls.Add(UNTextPanel);
            LoginPanel.Controls.Add(RMBRCheckbox);
            LoginPanel.Controls.Add(ForgotLinkLabel);
            LoginPanel.Controls.Add(LoginBtn);
            LoginPanel.Controls.Add(PassLabel);
            LoginPanel.Controls.Add(MorpheusLogo1);
            LoginPanel.Controls.Add(UNLabel);
            LoginPanel.Controls.Add(RTULHLabel);
            LoginPanel.Controls.Add(PassTextPanel);
            LoginPanel.Location = new Point(492, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(391, 640);
            LoginPanel.TabIndex = 1;
            LoginPanel.Paint += panel1_Paint;
            // 
            // UNTextPanel
            // 
            UNTextPanel.BorderStyle = BorderStyle.FixedSingle;
            UNTextPanel.Controls.Add(SNBox);
            UNTextPanel.ForeColor = Color.Black;
            UNTextPanel.Location = new Point(37, 256);
            UNTextPanel.Name = "UNTextPanel";
            UNTextPanel.Size = new Size(315, 34);
            UNTextPanel.TabIndex = 13;
            // 
            // SNBox
            // 
            SNBox.BackColor = SystemColors.Window;
            SNBox.BorderStyle = BorderStyle.None;
            SNBox.Cursor = Cursors.IBeam;
            SNBox.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SNBox.ForeColor = Color.FromArgb(90, 115, 141);
            SNBox.Location = new Point(6, 4);
            SNBox.Margin = new Padding(10);
            SNBox.Name = "SNBox";
            SNBox.PlaceholderText = "Enter Student Number";
            SNBox.Size = new Size(310, 19);
            SNBox.TabIndex = 3;
            SNBox.TextChanged += SNBox_TextChanged;
            // 
            // RMBRCheckbox
            // 
            RMBRCheckbox.AutoSize = true;
            RMBRCheckbox.BackColor = Color.Transparent;
            RMBRCheckbox.Cursor = Cursors.Hand;
            RMBRCheckbox.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RMBRCheckbox.ForeColor = Color.FromArgb(90, 115, 141);
            RMBRCheckbox.Location = new Point(44, 390);
            RMBRCheckbox.Name = "RMBRCheckbox";
            RMBRCheckbox.Size = new Size(117, 19);
            RMBRCheckbox.TabIndex = 12;
            RMBRCheckbox.Text = "Remember Me";
            RMBRCheckbox.UseVisualStyleBackColor = false;
            RMBRCheckbox.CheckedChanged += RMBRCheckbox_CheckedChanged_1;
            // 
            // ForgotLinkLabel
            // 
            ForgotLinkLabel.AutoSize = true;
            ForgotLinkLabel.BackColor = Color.Transparent;
            ForgotLinkLabel.Font = new Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForgotLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            ForgotLinkLabel.LinkColor = Color.FromArgb(90, 115, 141);
            ForgotLinkLabel.Location = new Point(252, 395);
            ForgotLinkLabel.Name = "ForgotLinkLabel";
            ForgotLinkLabel.Size = new Size(109, 14);
            ForgotLinkLabel.TabIndex = 10;
            ForgotLinkLabel.TabStop = true;
            ForgotLinkLabel.Text = "Forgot Password?";
            ForgotLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(250, 247, 247);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.FromArgb(90, 115, 141);
            LoginBtn.Location = new Point(253, 428);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(100, 35);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginButton_Click;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassLabel.ForeColor = Color.FromArgb(90, 115, 141);
            PassLabel.Location = new Point(31, 327);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(102, 23);
            PassLabel.TabIndex = 4;
            PassLabel.Text = "Password:";
            // 
            // MorpheusLogo1
            // 
            MorpheusLogo1.Image = Properties.Resources._4;
            MorpheusLogo1.Location = new Point(135, 25);
            MorpheusLogo1.Name = "MorpheusLogo1";
            MorpheusLogo1.Size = new Size(128, 128);
            MorpheusLogo1.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusLogo1.TabIndex = 0;
            MorpheusLogo1.TabStop = false;
            MorpheusLogo1.Click += pictureBox1_Click;
            // 
            // UNLabel
            // 
            UNLabel.AutoSize = true;
            UNLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UNLabel.ForeColor = Color.FromArgb(90, 115, 141);
            UNLabel.Location = new Point(31, 228);
            UNLabel.Name = "UNLabel";
            UNLabel.Size = new Size(160, 23);
            UNLabel.TabIndex = 2;
            UNLabel.Text = "Student Number:";
            UNLabel.Click += label1_Click_1;
            // 
            // RTULHLabel
            // 
            RTULHLabel.AutoSize = true;
            RTULHLabel.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RTULHLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RTULHLabel.Location = new Point(21, 174);
            RTULHLabel.Name = "RTULHLabel";
            RTULHLabel.Size = new Size(151, 38);
            RTULHLabel.TabIndex = 1;
            RTULHLabel.Text = "| SIGN IN";
            RTULHLabel.TextAlign = ContentAlignment.MiddleCenter;
            RTULHLabel.Click += label1_Click;
            // 
            // PassTextPanel
            // 
            PassTextPanel.BorderStyle = BorderStyle.FixedSingle;
            PassTextPanel.Controls.Add(PassBox);
            PassTextPanel.Controls.Add(ShowPassCheck);
            PassTextPanel.ForeColor = Color.Black;
            PassTextPanel.Location = new Point(37, 354);
            PassTextPanel.Name = "PassTextPanel";
            PassTextPanel.Size = new Size(315, 34);
            PassTextPanel.TabIndex = 14;
            // 
            // PassBox
            // 
            PassBox.BackColor = Color.FromArgb(250, 247, 247);
            PassBox.BorderStyle = BorderStyle.None;
            PassBox.Cursor = Cursors.IBeam;
            PassBox.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PassBox.ForeColor = Color.FromArgb(90, 115, 141);
            PassBox.Location = new Point(8, 5);
            PassBox.Margin = new Padding(10);
            PassBox.Name = "PassBox";
            PassBox.PlaceholderText = "Enter Password";
            PassBox.Size = new Size(285, 19);
            PassBox.TabIndex = 5;
            PassBox.UseSystemPasswordChar = true;
            PassBox.TextChanged += PassBox_TextChanged;
            PassBox.KeyDown += PassBox_KeyDown;
            // 
            // ShowPassCheck
            // 
            ShowPassCheck.AutoSize = true;
            ShowPassCheck.BackColor = Color.White;
            ShowPassCheck.Cursor = Cursors.Hand;
            ShowPassCheck.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPassCheck.ForeColor = Color.White;
            ShowPassCheck.Location = new Point(295, 10);
            ShowPassCheck.Name = "ShowPassCheck";
            ShowPassCheck.Size = new Size(15, 14);
            ShowPassCheck.TabIndex = 11;
            ShowPassCheck.UseVisualStyleBackColor = false;
            ShowPassCheck.CheckedChanged += RMBRCheckBox_CheckedChanged;
            // 
            // LnRPanel
            // 
            LnRPanel.BackColor = Color.Transparent;
            LnRPanel.Controls.Add(RegiPanel);
            LnRPanel.Controls.Add(LoginPanel);
            LnRPanel.Controls.Add(WCPanel);
            LnRPanel.Controls.Add(MorpheusLbl);
            LnRPanel.Controls.Add(MorpheusLogo2);
            LnRPanel.Controls.Add(RecoveryPanel);
            LnRPanel.Location = new Point(-6, 0);
            LnRPanel.Name = "LnRPanel";
            LnRPanel.Size = new Size(879, 614);
            LnRPanel.TabIndex = 17;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 115, 141);
            ClientSize = new Size(869, 611);
            Controls.Add(LnRPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(885, 650);
            MinimumSize = new Size(885, 650);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Morpheus Learning Hub";
            Load += RTULogin_Load;
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).EndInit();
            RecoveryPanel.ResumeLayout(false);
            RecoveryPanel.PerformLayout();
            RegiPanel.ResumeLayout(false);
            RegiPanel.PerformLayout();
            WCPanel.ResumeLayout(false);
            WCPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusWCIcon).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            UNTextPanel.ResumeLayout(false);
            UNTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo1).EndInit();
            PassTextPanel.ResumeLayout(false);
            PassTextPanel.PerformLayout();
            LnRPanel.ResumeLayout(false);
            LnRPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer LoginBtnTimer;
        private PictureBox MorpheusLogo2;
        private Label MorpheusLbl;
        private LinkLabel SignUpLinkLabel;
        private Panel RecoveryPanel;
        private TextBox RCSNBox;
        private Label RCSNLabel;
        private Button SubmitBtn;
        private LinkLabel FPtoLPLinkedLbl;
        private TextBox RPINBox;
        private Label RecoveryPINLabel;
        private Label RecoveryHLabel;
        private Panel RegiPanel;
        private CheckBox RegiShowPass;
        private TextBox RegiRPBox;
        private Label RegiRPLabel;
        private TextBox RegiSNBox;
        private Label RegiSNLabel;
        private Button CreateBtn;
        private LinkLabel LoginLinkLabel;
        private TextBox RegiPassBox;
        private Label RegiPassLabel;
        private TextBox RegiNameBox;
        private Label RegiNameLabel;
        private Label GSLabel;
        private Panel LoginPanel;
        private CheckBox RMBRCheckbox;
        private CheckBox ShowPassCheck;
        private LinkLabel ForgotLinkLabel;
        private Button LoginBtn;
        private TextBox PassBox;
        private Label PassLabel;
        private TextBox SNBox;
        private Label UNLabel;
        private Label RTULHLabel;
        private Panel LnRPanel;
        private PictureBox MorpheusLogo1;
        private Panel UNTextPanel;
        private Panel PassTextPanel;
        private Panel WCPanel;
        private PictureBox MorpheusWCIcon;
        private TextBox WCMsgBox;
    }
}