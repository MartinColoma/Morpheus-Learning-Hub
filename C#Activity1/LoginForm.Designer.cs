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
            FPtoLPLinkedLbl = new LinkLabel();
            ConfirmNewPassPanel = new Panel();
            NewPassConfirmBox = new TextBox();
            PRMorpheusLogo1 = new PictureBox();
            RecoveryHLabel = new Label();
            RCRPPanel = new Panel();
            RPINBox = new TextBox();
            RCSNLabel = new Label();
            NewPassBoxPanel = new Panel();
            NewPassBox = new TextBox();
            RecoveryPINLabel = new Label();
            RCSNPanel = new Panel();
            RCSNBox = new TextBox();
            ConfirmNewPassLbl = new Label();
            NewPassLbl = new Label();
            CPChangeBtn = new Button();
            RegiPanel = new Panel();
            SNMaxChar = new Label();
            RegiMailLbl = new Label();
            RegiMailPanel = new Panel();
            RegiMailBox = new TextBox();
            RegiAgeLbl = new Label();
            GenderLbl = new Label();
            RegiGenderPanel = new Panel();
            RegiGenderComboBox = new ComboBox();
            RegiCourseLbl = new Label();
            RegiCoursePanel = new Panel();
            RegiCourseBox = new TextBox();
            RegiNamePanel = new Panel();
            RegiNameBox = new TextBox();
            RegiRPLabel = new Label();
            RegiSNLabel = new Label();
            CreateBtn = new Button();
            LoginLinkLabel = new LinkLabel();
            RegiPassLabel = new Label();
            RegiNameLabel = new Label();
            GSLabel = new Label();
            RegiPassPanel = new Panel();
            RegiShowPass = new CheckBox();
            RegiPassBox = new TextBox();
            RegiRPPanel = new Panel();
            RegiRPBox = new TextBox();
            RegiSNBoxPanel = new Panel();
            RegiSNBox = new TextBox();
            RegiAgePanel = new Panel();
            RegiAgeBox = new TextBox();
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
            ConfirmNewPassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PRMorpheusLogo1).BeginInit();
            RCRPPanel.SuspendLayout();
            NewPassBoxPanel.SuspendLayout();
            RCSNPanel.SuspendLayout();
            RegiPanel.SuspendLayout();
            RegiMailPanel.SuspendLayout();
            RegiGenderPanel.SuspendLayout();
            RegiCoursePanel.SuspendLayout();
            RegiNamePanel.SuspendLayout();
            RegiPassPanel.SuspendLayout();
            RegiRPPanel.SuspendLayout();
            RegiSNBoxPanel.SuspendLayout();
            RegiAgePanel.SuspendLayout();
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
            SignUpLinkLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            SignUpLinkLabel.LinkColor = Color.FromArgb(90, 115, 141);
            SignUpLinkLabel.Location = new Point(30, 506);
            SignUpLinkLabel.Name = "SignUpLinkLabel";
            SignUpLinkLabel.Size = new Size(324, 18);
            SignUpLinkLabel.TabIndex = 8;
            SignUpLinkLabel.TabStop = true;
            SignUpLinkLabel.Text = "Don't have an account yet? Create one here.";
            SignUpLinkLabel.LinkClicked += SignUpLabel_LinkClicked;
            // 
            // RecoveryPanel
            // 
            RecoveryPanel.BackColor = Color.FromArgb(250, 247, 247);
            RecoveryPanel.Controls.Add(FPtoLPLinkedLbl);
            RecoveryPanel.Controls.Add(ConfirmNewPassPanel);
            RecoveryPanel.Controls.Add(PRMorpheusLogo1);
            RecoveryPanel.Controls.Add(RecoveryHLabel);
            RecoveryPanel.Controls.Add(RCRPPanel);
            RecoveryPanel.Controls.Add(RCSNLabel);
            RecoveryPanel.Controls.Add(NewPassBoxPanel);
            RecoveryPanel.Controls.Add(RecoveryPINLabel);
            RecoveryPanel.Controls.Add(RCSNPanel);
            RecoveryPanel.Controls.Add(ConfirmNewPassLbl);
            RecoveryPanel.Controls.Add(NewPassLbl);
            RecoveryPanel.Controls.Add(CPChangeBtn);
            RecoveryPanel.Location = new Point(495, 0);
            RecoveryPanel.Name = "RecoveryPanel";
            RecoveryPanel.Size = new Size(384, 614);
            RecoveryPanel.TabIndex = 16;
            RecoveryPanel.Paint += RecoveryPanel_Paint;
            // 
            // FPtoLPLinkedLbl
            // 
            FPtoLPLinkedLbl.ActiveLinkColor = Color.FromArgb(249, 184, 74);
            FPtoLPLinkedLbl.AutoSize = true;
            FPtoLPLinkedLbl.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FPtoLPLinkedLbl.ForeColor = Color.FromArgb(90, 115, 141);
            FPtoLPLinkedLbl.LinkBehavior = LinkBehavior.HoverUnderline;
            FPtoLPLinkedLbl.LinkColor = Color.FromArgb(90, 115, 141);
            FPtoLPLinkedLbl.Location = new Point(61, 538);
            FPtoLPLinkedLbl.Name = "FPtoLPLinkedLbl";
            FPtoLPLinkedLbl.Size = new Size(280, 22);
            FPtoLPLinkedLbl.TabIndex = 8;
            FPtoLPLinkedLbl.TabStop = true;
            FPtoLPLinkedLbl.Text = "Got your Password? Login again.";
            FPtoLPLinkedLbl.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // ConfirmNewPassPanel
            // 
            ConfirmNewPassPanel.BorderStyle = BorderStyle.FixedSingle;
            ConfirmNewPassPanel.Controls.Add(NewPassConfirmBox);
            ConfirmNewPassPanel.Location = new Point(32, 426);
            ConfirmNewPassPanel.Name = "ConfirmNewPassPanel";
            ConfirmNewPassPanel.Size = new Size(324, 30);
            ConfirmNewPassPanel.TabIndex = 13;
            // 
            // NewPassConfirmBox
            // 
            NewPassConfirmBox.BackColor = Color.FromArgb(250, 247, 247);
            NewPassConfirmBox.BorderStyle = BorderStyle.None;
            NewPassConfirmBox.Cursor = Cursors.IBeam;
            NewPassConfirmBox.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NewPassConfirmBox.ForeColor = Color.FromArgb(90, 115, 141);
            NewPassConfirmBox.Location = new Point(2, 6);
            NewPassConfirmBox.Margin = new Padding(10);
            NewPassConfirmBox.Name = "NewPassConfirmBox";
            NewPassConfirmBox.PlaceholderText = "Enter Confirm New Password";
            NewPassConfirmBox.Size = new Size(311, 18);
            NewPassConfirmBox.TabIndex = 3;
            NewPassConfirmBox.KeyDown += NewPassConfirmBox_KeyDown;
            // 
            // PRMorpheusLogo1
            // 
            PRMorpheusLogo1.Image = Properties.Resources._4;
            PRMorpheusLogo1.Location = new Point(135, 27);
            PRMorpheusLogo1.Name = "PRMorpheusLogo1";
            PRMorpheusLogo1.Size = new Size(128, 128);
            PRMorpheusLogo1.SizeMode = PictureBoxSizeMode.AutoSize;
            PRMorpheusLogo1.TabIndex = 14;
            PRMorpheusLogo1.TabStop = false;
            // 
            // RecoveryHLabel
            // 
            RecoveryHLabel.AutoSize = true;
            RecoveryHLabel.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RecoveryHLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RecoveryHLabel.Location = new Point(15, 158);
            RecoveryHLabel.Name = "RecoveryHLabel";
            RecoveryHLabel.Size = new Size(299, 38);
            RecoveryHLabel.TabIndex = 1;
            RecoveryHLabel.Text = "| Change Password";
            RecoveryHLabel.TextAlign = ContentAlignment.MiddleCenter;
            RecoveryHLabel.Click += label5_Click;
            // 
            // RCRPPanel
            // 
            RCRPPanel.BorderStyle = BorderStyle.FixedSingle;
            RCRPPanel.Controls.Add(RPINBox);
            RCRPPanel.Location = new Point(32, 301);
            RCRPPanel.Name = "RCRPPanel";
            RCRPPanel.Size = new Size(324, 30);
            RCRPPanel.TabIndex = 13;
            // 
            // RPINBox
            // 
            RPINBox.BackColor = Color.FromArgb(250, 247, 247);
            RPINBox.BorderStyle = BorderStyle.None;
            RPINBox.Cursor = Cursors.IBeam;
            RPINBox.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPINBox.ForeColor = Color.FromArgb(90, 115, 141);
            RPINBox.Location = new Point(5, 6);
            RPINBox.Margin = new Padding(10);
            RPINBox.Name = "RPINBox";
            RPINBox.PlaceholderText = "Enter PIN";
            RPINBox.Size = new Size(311, 18);
            RPINBox.TabIndex = 3;
            RPINBox.TextChanged += textBox4_TextChanged;
            // 
            // RCSNLabel
            // 
            RCSNLabel.AutoSize = true;
            RCSNLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RCSNLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RCSNLabel.Location = new Point(29, 205);
            RCSNLabel.Name = "RCSNLabel";
            RCSNLabel.Size = new Size(160, 23);
            RCSNLabel.TabIndex = 10;
            RCSNLabel.Text = "Student Number:";
            // 
            // NewPassBoxPanel
            // 
            NewPassBoxPanel.BorderStyle = BorderStyle.FixedSingle;
            NewPassBoxPanel.Controls.Add(NewPassBox);
            NewPassBoxPanel.Location = new Point(33, 363);
            NewPassBoxPanel.Name = "NewPassBoxPanel";
            NewPassBoxPanel.Size = new Size(324, 30);
            NewPassBoxPanel.TabIndex = 12;
            // 
            // NewPassBox
            // 
            NewPassBox.BackColor = Color.FromArgb(250, 247, 247);
            NewPassBox.BorderStyle = BorderStyle.None;
            NewPassBox.Cursor = Cursors.IBeam;
            NewPassBox.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NewPassBox.ForeColor = Color.FromArgb(90, 115, 141);
            NewPassBox.Location = new Point(3, 5);
            NewPassBox.Margin = new Padding(10);
            NewPassBox.Name = "NewPassBox";
            NewPassBox.PlaceholderText = "Enter New Password";
            NewPassBox.Size = new Size(311, 18);
            NewPassBox.TabIndex = 11;
            // 
            // RecoveryPINLabel
            // 
            RecoveryPINLabel.AutoSize = true;
            RecoveryPINLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RecoveryPINLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RecoveryPINLabel.Location = new Point(29, 275);
            RecoveryPINLabel.Name = "RecoveryPINLabel";
            RecoveryPINLabel.Size = new Size(131, 23);
            RecoveryPINLabel.TabIndex = 2;
            RecoveryPINLabel.Text = "Recovery Pin:";
            RecoveryPINLabel.Click += label4_Click;
            // 
            // RCSNPanel
            // 
            RCSNPanel.BorderStyle = BorderStyle.FixedSingle;
            RCSNPanel.Controls.Add(RCSNBox);
            RCSNPanel.Location = new Point(32, 238);
            RCSNPanel.Name = "RCSNPanel";
            RCSNPanel.Size = new Size(324, 30);
            RCSNPanel.TabIndex = 12;
            // 
            // RCSNBox
            // 
            RCSNBox.BackColor = Color.FromArgb(250, 247, 247);
            RCSNBox.BorderStyle = BorderStyle.None;
            RCSNBox.Cursor = Cursors.IBeam;
            RCSNBox.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RCSNBox.ForeColor = Color.FromArgb(90, 115, 141);
            RCSNBox.Location = new Point(3, 5);
            RCSNBox.Margin = new Padding(10);
            RCSNBox.Name = "RCSNBox";
            RCSNBox.PlaceholderText = "Enter Student Number";
            RCSNBox.Size = new Size(311, 18);
            RCSNBox.TabIndex = 11;
            RCSNBox.TextChanged += RCSNBox_TextChanged;
            // 
            // ConfirmNewPassLbl
            // 
            ConfirmNewPassLbl.AutoSize = true;
            ConfirmNewPassLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmNewPassLbl.ForeColor = Color.FromArgb(90, 115, 141);
            ConfirmNewPassLbl.Location = new Point(29, 400);
            ConfirmNewPassLbl.Name = "ConfirmNewPassLbl";
            ConfirmNewPassLbl.Size = new Size(176, 23);
            ConfirmNewPassLbl.TabIndex = 2;
            ConfirmNewPassLbl.Text = "Confirm Password:";
            // 
            // NewPassLbl
            // 
            NewPassLbl.AutoSize = true;
            NewPassLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewPassLbl.ForeColor = Color.FromArgb(90, 115, 141);
            NewPassLbl.Location = new Point(29, 336);
            NewPassLbl.Name = "NewPassLbl";
            NewPassLbl.Size = new Size(146, 23);
            NewPassLbl.TabIndex = 10;
            NewPassLbl.Text = "New Password:";
            // 
            // CPChangeBtn
            // 
            CPChangeBtn.BackColor = Color.FromArgb(250, 247, 247);
            CPChangeBtn.Cursor = Cursors.Hand;
            CPChangeBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            CPChangeBtn.FlatAppearance.BorderSize = 2;
            CPChangeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            CPChangeBtn.FlatStyle = FlatStyle.Flat;
            CPChangeBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPChangeBtn.ForeColor = Color.FromArgb(90, 115, 141);
            CPChangeBtn.Location = new Point(252, 464);
            CPChangeBtn.Name = "CPChangeBtn";
            CPChangeBtn.Size = new Size(104, 40);
            CPChangeBtn.TabIndex = 9;
            CPChangeBtn.Text = "CHANGE";
            CPChangeBtn.UseVisualStyleBackColor = false;
            CPChangeBtn.Click += CPChangeBtn_Click;
            // 
            // RegiPanel
            // 
            RegiPanel.BackColor = Color.FromArgb(250, 247, 247);
            RegiPanel.Controls.Add(SNMaxChar);
            RegiPanel.Controls.Add(RegiMailLbl);
            RegiPanel.Controls.Add(RegiMailPanel);
            RegiPanel.Controls.Add(RegiAgeLbl);
            RegiPanel.Controls.Add(GenderLbl);
            RegiPanel.Controls.Add(RegiGenderPanel);
            RegiPanel.Controls.Add(RegiCourseLbl);
            RegiPanel.Controls.Add(RegiCoursePanel);
            RegiPanel.Controls.Add(RegiNamePanel);
            RegiPanel.Controls.Add(RegiRPLabel);
            RegiPanel.Controls.Add(RegiSNLabel);
            RegiPanel.Controls.Add(CreateBtn);
            RegiPanel.Controls.Add(LoginLinkLabel);
            RegiPanel.Controls.Add(RegiPassLabel);
            RegiPanel.Controls.Add(RegiNameLabel);
            RegiPanel.Controls.Add(GSLabel);
            RegiPanel.Controls.Add(RegiPassPanel);
            RegiPanel.Controls.Add(RegiRPPanel);
            RegiPanel.Controls.Add(RegiSNBoxPanel);
            RegiPanel.Controls.Add(RegiAgePanel);
            RegiPanel.Location = new Point(149, 125);
            RegiPanel.Name = "RegiPanel";
            RegiPanel.Size = new Size(580, 455);
            RegiPanel.TabIndex = 12;
            RegiPanel.Paint += RegiPanel_Paint;
            // 
            // SNMaxChar
            // 
            SNMaxChar.AutoSize = true;
            SNMaxChar.BackColor = Color.Transparent;
            SNMaxChar.Font = new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SNMaxChar.ForeColor = Color.FromArgb(90, 115, 141);
            SNMaxChar.Location = new Point(187, 202);
            SNMaxChar.Name = "SNMaxChar";
            SNMaxChar.Size = new Size(133, 13);
            SNMaxChar.TabIndex = 29;
            SNMaxChar.Text = "(input another 4 digits)";
            // 
            // RegiMailLbl
            // 
            RegiMailLbl.AutoSize = true;
            RegiMailLbl.BackColor = Color.Transparent;
            RegiMailLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiMailLbl.ForeColor = Color.FromArgb(90, 115, 141);
            RegiMailLbl.Location = new Point(323, 136);
            RegiMailLbl.Name = "RegiMailLbl";
            RegiMailLbl.Size = new Size(64, 23);
            RegiMailLbl.TabIndex = 27;
            RegiMailLbl.Text = "Email:";
            // 
            // RegiMailPanel
            // 
            RegiMailPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiMailPanel.Controls.Add(RegiMailBox);
            RegiMailPanel.Location = new Point(326, 162);
            RegiMailPanel.Name = "RegiMailPanel";
            RegiMailPanel.Size = new Size(219, 32);
            RegiMailPanel.TabIndex = 28;
            // 
            // RegiMailBox
            // 
            RegiMailBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiMailBox.BorderStyle = BorderStyle.None;
            RegiMailBox.Cursor = Cursors.IBeam;
            RegiMailBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiMailBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiMailBox.Location = new Point(5, 6);
            RegiMailBox.Margin = new Padding(10);
            RegiMailBox.Name = "RegiMailBox";
            RegiMailBox.PlaceholderText = "Enter Email Address";
            RegiMailBox.Size = new Size(201, 13);
            RegiMailBox.TabIndex = 13;
            // 
            // RegiAgeLbl
            // 
            RegiAgeLbl.AutoSize = true;
            RegiAgeLbl.BackColor = Color.Transparent;
            RegiAgeLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiAgeLbl.ForeColor = Color.FromArgb(90, 115, 141);
            RegiAgeLbl.Location = new Point(323, 71);
            RegiAgeLbl.Name = "RegiAgeLbl";
            RegiAgeLbl.Size = new Size(49, 23);
            RegiAgeLbl.TabIndex = 26;
            RegiAgeLbl.Text = "Age:";
            RegiAgeLbl.Click += label1_Click_2;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.BackColor = Color.Transparent;
            GenderLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLbl.ForeColor = Color.FromArgb(90, 115, 141);
            GenderLbl.Location = new Point(407, 71);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(80, 23);
            GenderLbl.TabIndex = 24;
            GenderLbl.Text = "Gender:";
            // 
            // RegiGenderPanel
            // 
            RegiGenderPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiGenderPanel.Controls.Add(RegiGenderComboBox);
            RegiGenderPanel.Location = new Point(407, 99);
            RegiGenderPanel.Name = "RegiGenderPanel";
            RegiGenderPanel.Size = new Size(140, 34);
            RegiGenderPanel.TabIndex = 23;
            // 
            // RegiGenderComboBox
            // 
            RegiGenderComboBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiGenderComboBox.FormattingEnabled = true;
            RegiGenderComboBox.Location = new Point(3, 6);
            RegiGenderComboBox.Name = "RegiGenderComboBox";
            RegiGenderComboBox.Size = new Size(132, 22);
            RegiGenderComboBox.TabIndex = 20;
            RegiGenderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // RegiCourseLbl
            // 
            RegiCourseLbl.AutoSize = true;
            RegiCourseLbl.BackColor = Color.Transparent;
            RegiCourseLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiCourseLbl.ForeColor = Color.FromArgb(90, 115, 141);
            RegiCourseLbl.Location = new Point(33, 136);
            RegiCourseLbl.Name = "RegiCourseLbl";
            RegiCourseLbl.Size = new Size(148, 23);
            RegiCourseLbl.TabIndex = 21;
            RegiCourseLbl.Text = "College Course:";
            // 
            // RegiCoursePanel
            // 
            RegiCoursePanel.BorderStyle = BorderStyle.FixedSingle;
            RegiCoursePanel.Controls.Add(RegiCourseBox);
            RegiCoursePanel.Location = new Point(38, 162);
            RegiCoursePanel.Name = "RegiCoursePanel";
            RegiCoursePanel.Size = new Size(282, 32);
            RegiCoursePanel.TabIndex = 22;
            // 
            // RegiCourseBox
            // 
            RegiCourseBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiCourseBox.BorderStyle = BorderStyle.None;
            RegiCourseBox.Cursor = Cursors.IBeam;
            RegiCourseBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiCourseBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiCourseBox.Location = new Point(5, 6);
            RegiCourseBox.Margin = new Padding(10);
            RegiCourseBox.Name = "RegiCourseBox";
            RegiCourseBox.PlaceholderText = "Enter College Course";
            RegiCourseBox.Size = new Size(265, 13);
            RegiCourseBox.TabIndex = 13;
            // 
            // RegiNamePanel
            // 
            RegiNamePanel.BorderStyle = BorderStyle.FixedSingle;
            RegiNamePanel.Controls.Add(RegiNameBox);
            RegiNamePanel.Location = new Point(38, 99);
            RegiNamePanel.Name = "RegiNamePanel";
            RegiNamePanel.Size = new Size(282, 34);
            RegiNamePanel.TabIndex = 17;
            // 
            // RegiNameBox
            // 
            RegiNameBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiNameBox.BorderStyle = BorderStyle.None;
            RegiNameBox.Cursor = Cursors.IBeam;
            RegiNameBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiNameBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiNameBox.Location = new Point(5, 8);
            RegiNameBox.Margin = new Padding(10);
            RegiNameBox.Name = "RegiNameBox";
            RegiNameBox.PlaceholderText = "Enter Name";
            RegiNameBox.Size = new Size(265, 13);
            RegiNameBox.TabIndex = 3;
            RegiNameBox.TextChanged += RegiNameBox_TextChanged;
            // 
            // RegiRPLabel
            // 
            RegiRPLabel.AutoSize = true;
            RegiRPLabel.BackColor = Color.Transparent;
            RegiRPLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiRPLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiRPLabel.Location = new Point(323, 196);
            RegiRPLabel.Name = "RegiRPLabel";
            RegiRPLabel.Size = new Size(126, 23);
            RegiRPLabel.TabIndex = 14;
            RegiRPLabel.Text = "Recovery Pin";
            RegiRPLabel.Click += RegiRPLabel_Click;
            // 
            // RegiSNLabel
            // 
            RegiSNLabel.AutoSize = true;
            RegiSNLabel.BackColor = Color.Transparent;
            RegiSNLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiSNLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiSNLabel.Location = new Point(33, 196);
            RegiSNLabel.Name = "RegiSNLabel";
            RegiSNLabel.Size = new Size(160, 23);
            RegiSNLabel.TabIndex = 12;
            RegiSNLabel.Text = "Student Number:";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(250, 247, 247);
            CreateBtn.Cursor = Cursors.Hand;
            CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            CreateBtn.FlatAppearance.BorderSize = 2;
            CreateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.FromArgb(90, 115, 141);
            CreateBtn.Location = new Point(254, 332);
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
            LoginLinkLabel.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLinkLabel.ForeColor = Color.White;
            LoginLinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            LoginLinkLabel.LinkColor = Color.FromArgb(90, 115, 141);
            LoginLinkLabel.Location = new Point(156, 381);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(320, 22);
            LoginLinkLabel.TabIndex = 8;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Already have an account? Login here.";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // RegiPassLabel
            // 
            RegiPassLabel.AutoSize = true;
            RegiPassLabel.BackColor = Color.Transparent;
            RegiPassLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiPassLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiPassLabel.Location = new Point(33, 258);
            RegiPassLabel.Name = "RegiPassLabel";
            RegiPassLabel.Size = new Size(102, 23);
            RegiPassLabel.TabIndex = 4;
            RegiPassLabel.Text = "Password:";
            // 
            // RegiNameLabel
            // 
            RegiNameLabel.AutoSize = true;
            RegiNameLabel.BackColor = Color.Transparent;
            RegiNameLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiNameLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiNameLabel.Location = new Point(33, 75);
            RegiNameLabel.Name = "RegiNameLabel";
            RegiNameLabel.Size = new Size(66, 23);
            RegiNameLabel.TabIndex = 2;
            RegiNameLabel.Text = "Name:";
            // 
            // GSLabel
            // 
            GSLabel.AutoSize = true;
            GSLabel.BackColor = Color.Transparent;
            GSLabel.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            GSLabel.ForeColor = Color.FromArgb(90, 115, 141);
            GSLabel.Location = new Point(198, 19);
            GSLabel.Name = "GSLabel";
            GSLabel.Size = new Size(189, 38);
            GSLabel.TabIndex = 1;
            GSLabel.Text = "Get Started";
            GSLabel.TextAlign = ContentAlignment.MiddleCenter;
            GSLabel.Click += GSLabel_Click;
            // 
            // RegiPassPanel
            // 
            RegiPassPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiPassPanel.Controls.Add(RegiShowPass);
            RegiPassPanel.Controls.Add(RegiPassBox);
            RegiPassPanel.Location = new Point(38, 286);
            RegiPassPanel.Name = "RegiPassPanel";
            RegiPassPanel.Size = new Size(507, 32);
            RegiPassPanel.TabIndex = 19;
            // 
            // RegiShowPass
            // 
            RegiShowPass.AutoSize = true;
            RegiShowPass.BackColor = Color.White;
            RegiShowPass.Cursor = Cursors.Hand;
            RegiShowPass.Font = new Font("STZhongsong", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            RegiShowPass.ForeColor = Color.White;
            RegiShowPass.Location = new Point(481, 8);
            RegiShowPass.Name = "RegiShowPass";
            RegiShowPass.Size = new Size(15, 14);
            RegiShowPass.TabIndex = 16;
            RegiShowPass.UseVisualStyleBackColor = false;
            RegiShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegiPassBox
            // 
            RegiPassBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiPassBox.BorderStyle = BorderStyle.None;
            RegiPassBox.Cursor = Cursors.IBeam;
            RegiPassBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiPassBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiPassBox.Location = new Point(5, 7);
            RegiPassBox.Margin = new Padding(10);
            RegiPassBox.Name = "RegiPassBox";
            RegiPassBox.PlaceholderText = "Enter Password";
            RegiPassBox.Size = new Size(471, 13);
            RegiPassBox.TabIndex = 5;
            RegiPassBox.UseSystemPasswordChar = true;
            RegiPassBox.TextChanged += RegiPassBox_TextChanged;
            RegiPassBox.KeyDown += RegiPassBox_KeyDown;
            // 
            // RegiRPPanel
            // 
            RegiRPPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiRPPanel.Controls.Add(RegiRPBox);
            RegiRPPanel.Location = new Point(326, 223);
            RegiRPPanel.Name = "RegiRPPanel";
            RegiRPPanel.Size = new Size(219, 32);
            RegiRPPanel.TabIndex = 19;
            // 
            // RegiRPBox
            // 
            RegiRPBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiRPBox.BorderStyle = BorderStyle.None;
            RegiRPBox.Cursor = Cursors.IBeam;
            RegiRPBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiRPBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiRPBox.Location = new Point(8, 7);
            RegiRPBox.Margin = new Padding(10);
            RegiRPBox.Name = "RegiRPBox";
            RegiRPBox.PlaceholderText = "Enter PIN";
            RegiRPBox.Size = new Size(162, 13);
            RegiRPBox.TabIndex = 15;
            RegiRPBox.TextChanged += RegiRPBox_TextChanged;
            // 
            // RegiSNBoxPanel
            // 
            RegiSNBoxPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiSNBoxPanel.Controls.Add(RegiSNBox);
            RegiSNBoxPanel.Location = new Point(38, 223);
            RegiSNBoxPanel.Name = "RegiSNBoxPanel";
            RegiSNBoxPanel.Size = new Size(282, 32);
            RegiSNBoxPanel.TabIndex = 18;
            // 
            // RegiSNBox
            // 
            RegiSNBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiSNBox.BorderStyle = BorderStyle.None;
            RegiSNBox.Cursor = Cursors.IBeam;
            RegiSNBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiSNBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiSNBox.Location = new Point(5, 6);
            RegiSNBox.Margin = new Padding(10);
            RegiSNBox.MaxLength = 9;
            RegiSNBox.Name = "RegiSNBox";
            RegiSNBox.PlaceholderText = "Enter Student Number";
            RegiSNBox.Size = new Size(269, 13);
            RegiSNBox.TabIndex = 13;
            RegiSNBox.TextChanged += RegiSNBox_TextChanged;
            RegiSNBox.KeyDown += RegiSNBox_KeyDown;
            // 
            // RegiAgePanel
            // 
            RegiAgePanel.BorderStyle = BorderStyle.FixedSingle;
            RegiAgePanel.Controls.Add(RegiAgeBox);
            RegiAgePanel.Location = new Point(324, 99);
            RegiAgePanel.Name = "RegiAgePanel";
            RegiAgePanel.Size = new Size(77, 34);
            RegiAgePanel.TabIndex = 25;
            // 
            // RegiAgeBox
            // 
            RegiAgeBox.BackColor = Color.FromArgb(250, 247, 247);
            RegiAgeBox.BorderStyle = BorderStyle.None;
            RegiAgeBox.Cursor = Cursors.IBeam;
            RegiAgeBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegiAgeBox.ForeColor = Color.FromArgb(24, 79, 144);
            RegiAgeBox.Location = new Point(6, 8);
            RegiAgeBox.Margin = new Padding(10);
            RegiAgeBox.Multiline = true;
            RegiAgeBox.Name = "RegiAgeBox";
            RegiAgeBox.PlaceholderText = "Enter Age ";
            RegiAgeBox.Size = new Size(63, 25);
            RegiAgeBox.TabIndex = 17;
            RegiAgeBox.TextChanged += RegiAgeBox_TextChanged;
            // 
            // WCPanel
            // 
            WCPanel.Controls.Add(WCMsgBox);
            WCPanel.Controls.Add(MorpheusWCIcon);
            WCPanel.Location = new Point(7, 110);
            WCPanel.Name = "WCPanel";
            WCPanel.Size = new Size(488, 504);
            WCPanel.TabIndex = 18;
            WCPanel.Paint += panel3_Paint;
            // 
            // WCMsgBox
            // 
            WCMsgBox.BackColor = Color.FromArgb(90, 115, 141);
            WCMsgBox.BorderStyle = BorderStyle.None;
            WCMsgBox.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            WCMsgBox.ForeColor = Color.FromArgb(250, 247, 247);
            WCMsgBox.Location = new Point(63, 265);
            WCMsgBox.Multiline = true;
            WCMsgBox.Name = "WCMsgBox";
            WCMsgBox.Size = new Size(378, 94);
            WCMsgBox.TabIndex = 20;
            WCMsgBox.Text = "You are just one step away from your DREAMS. Make it happen with the help of MORPHEUS.";
            WCMsgBox.TextChanged += textBox2_TextChanged;
            // 
            // MorpheusWCIcon
            // 
            MorpheusWCIcon.Image = Properties.Resources.Morpheus_Icons__2_;
            MorpheusWCIcon.Location = new Point(128, 8);
            MorpheusWCIcon.Name = "MorpheusWCIcon";
            MorpheusWCIcon.Size = new Size(250, 250);
            MorpheusWCIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusWCIcon.TabIndex = 19;
            MorpheusWCIcon.TabStop = false;
            MorpheusWCIcon.Click += MorpheusWCIcon_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(250, 247, 247);
            LoginPanel.Controls.Add(UNTextPanel);
            LoginPanel.Controls.Add(RMBRCheckbox);
            LoginPanel.Controls.Add(SignUpLinkLabel);
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
            SNBox.BackColor = Color.FromArgb(250, 247, 247);
            SNBox.BorderStyle = BorderStyle.None;
            SNBox.Cursor = Cursors.IBeam;
            SNBox.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SNBox.ForeColor = Color.FromArgb(90, 115, 141);
            SNBox.Location = new Point(6, 4);
            SNBox.Margin = new Padding(10);
            SNBox.MaxLength = 9;
            SNBox.Name = "SNBox";
            SNBox.PlaceholderText = "Enter Student Number";
            SNBox.Size = new Size(297, 19);
            SNBox.TabIndex = 3;
            SNBox.TextChanged += SNBox_TextChanged;
            // 
            // RMBRCheckbox
            // 
            RMBRCheckbox.AutoSize = true;
            RMBRCheckbox.BackColor = Color.Transparent;
            RMBRCheckbox.Cursor = Cursors.Hand;
            RMBRCheckbox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            RMBRCheckbox.ForeColor = Color.FromArgb(90, 115, 141);
            RMBRCheckbox.Location = new Point(44, 390);
            RMBRCheckbox.Name = "RMBRCheckbox";
            RMBRCheckbox.Size = new Size(108, 18);
            RMBRCheckbox.TabIndex = 12;
            RMBRCheckbox.Text = "Remember Me";
            RMBRCheckbox.UseVisualStyleBackColor = false;
            RMBRCheckbox.CheckedChanged += RMBRCheckbox_CheckedChanged_1;
            // 
            // ForgotLinkLabel
            // 
            ForgotLinkLabel.AutoSize = true;
            ForgotLinkLabel.BackColor = Color.Transparent;
            ForgotLinkLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            LoginBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            LnRPanel.Controls.Add(LoginPanel);
            LnRPanel.Controls.Add(WCPanel);
            LnRPanel.Controls.Add(MorpheusLbl);
            LnRPanel.Controls.Add(MorpheusLogo2);
            LnRPanel.Controls.Add(RecoveryPanel);
            LnRPanel.Controls.Add(RegiPanel);
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
            ConfirmNewPassPanel.ResumeLayout(false);
            ConfirmNewPassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PRMorpheusLogo1).EndInit();
            RCRPPanel.ResumeLayout(false);
            RCRPPanel.PerformLayout();
            NewPassBoxPanel.ResumeLayout(false);
            NewPassBoxPanel.PerformLayout();
            RCSNPanel.ResumeLayout(false);
            RCSNPanel.PerformLayout();
            RegiPanel.ResumeLayout(false);
            RegiPanel.PerformLayout();
            RegiMailPanel.ResumeLayout(false);
            RegiMailPanel.PerformLayout();
            RegiGenderPanel.ResumeLayout(false);
            RegiCoursePanel.ResumeLayout(false);
            RegiCoursePanel.PerformLayout();
            RegiNamePanel.ResumeLayout(false);
            RegiNamePanel.PerformLayout();
            RegiPassPanel.ResumeLayout(false);
            RegiPassPanel.PerformLayout();
            RegiRPPanel.ResumeLayout(false);
            RegiRPPanel.PerformLayout();
            RegiSNBoxPanel.ResumeLayout(false);
            RegiSNBoxPanel.PerformLayout();
            RegiAgePanel.ResumeLayout(false);
            RegiAgePanel.PerformLayout();
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
        private Panel RegiNamePanel;
        private Panel RegiPassPanel;
        private Panel RegiRPPanel;
        private ComboBox RegiGenderComboBox;
        private Label RegiCourseLbl;
        private Panel RegiCoursePanel;
        private TextBox RegiCourseBox;
        private Label GenderLbl;
        private Panel RegiGenderPanel;
        private Label RegiAgeLbl;
        private Panel RegiAgePanel;
        private Panel RegiSNBoxPanel;
        private TextBox RegiAgeBox;
        private Panel RCSNPanel;
        private Panel RCRPPanel;
        private PictureBox PRMorpheusLogo1;
        private Label RegiMailLbl;
        private Panel RegiMailPanel;
        private TextBox RegiMailBox;
        private Panel ConfirmNewPassPanel;
        private TextBox NewPassConfirmBox;
        private Panel NewPassBoxPanel;
        private TextBox NewPassBox;
        private Label NewPassLbl;
        private Button CPChangeBtn;
        private Label ConfirmNewPassLbl;
        private Label SNMaxChar;
    }
}