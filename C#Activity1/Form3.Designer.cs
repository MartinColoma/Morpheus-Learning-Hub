namespace C_Activity1
{
    partial class LHHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LHHomePage));
            RTUSealXL = new PictureBox();
            RTUSealIcon = new PictureBox();
            LHHeaderPanel = new Panel();
            LearningHLabel = new Label();
            LHMenuStripPanel = new Panel();
            MenuLbl = new Label();
            MenuIcon = new PictureBox();
            LHMenuColumn = new Panel();
            LogoutLinkedLbl = new LinkLabel();
            LogoutIcon = new PictureBox();
            BillIcon = new PictureBox();
            BillLinkedLbl = new LinkLabel();
            StudentSuppIcon = new PictureBox();
            StudentSuppLinkLbl = new LinkLabel();
            GradeIcon = new PictureBox();
            GradeLinkLbl = new LinkLabel();
            StudentIcon = new PictureBox();
            ProfileLinkLbl = new LinkLabel();
            LHUserCalendar = new MonthCalendar();
            LHWelcome = new TextBox();
            LHBasicInfoPanel = new Panel();
            LHSNBox = new TextBox();
            LHNameBox = new TextBox();
            LHSectLbl = new Label();
            LHDeptLbl = new Label();
            LHSNLbl = new Label();
            LHNameLbl = new Label();
            BasicInfoLbl = new Label();
            LHSchedPanel = new Panel();
            LHSchedTable = new DataGridView();
            LHSub = new DataGridViewTextBoxColumn();
            LHSect = new DataGridViewTextBoxColumn();
            LHTime = new DataGridViewTextBoxColumn();
            LHDay = new DataGridViewTextBoxColumn();
            LHRoom = new DataGridViewTextBoxColumn();
            ClassSchedLbl = new Label();
            LHEnrolledCoursePanel = new Panel();
            EnrolledLbl = new Label();
            LHWcPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).BeginInit();
            LHHeaderPanel.SuspendLayout();
            LHMenuStripPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuIcon).BeginInit();
            LHMenuColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).BeginInit();
            LHBasicInfoPanel.SuspendLayout();
            LHSchedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LHSchedTable).BeginInit();
            LHEnrolledCoursePanel.SuspendLayout();
            LHWcPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RTUSealXL
            // 
            RTUSealXL.Image = Properties.Resources.RTU_Facade1_720x720;
            RTUSealXL.Location = new Point(1281, 0);
            RTUSealXL.Name = "RTUSealXL";
            RTUSealXL.Size = new Size(704, 681);
            RTUSealXL.SizeMode = PictureBoxSizeMode.CenterImage;
            RTUSealXL.TabIndex = 0;
            RTUSealXL.TabStop = false;
            RTUSealXL.Click += RTUSealXL_Click;
            // 
            // RTUSealIcon
            // 
            RTUSealIcon.Image = Properties.Resources.RTU_Seal_64x64;
            RTUSealIcon.Location = new Point(421, 28);
            RTUSealIcon.Name = "RTUSealIcon";
            RTUSealIcon.Size = new Size(64, 63);
            RTUSealIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            RTUSealIcon.TabIndex = 1;
            RTUSealIcon.TabStop = false;
            // 
            // LHHeaderPanel
            // 
            LHHeaderPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHHeaderPanel.BackgroundImageLayout = ImageLayout.None;
            LHHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            LHHeaderPanel.Controls.Add(LearningHLabel);
            LHHeaderPanel.Controls.Add(RTUSealIcon);
            LHHeaderPanel.Controls.Add(LHMenuStripPanel);
            LHHeaderPanel.Location = new Point(-14, -5);
            LHHeaderPanel.Name = "LHHeaderPanel";
            LHHeaderPanel.Size = new Size(1281, 120);
            LHHeaderPanel.TabIndex = 3;
            // 
            // LearningHLabel
            // 
            LearningHLabel.AutoSize = true;
            LearningHLabel.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LearningHLabel.ForeColor = Color.FromArgb(24, 79, 144);
            LearningHLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LearningHLabel.Location = new Point(491, 47);
            LearningHLabel.Name = "LearningHLabel";
            LearningHLabel.Size = new Size(390, 27);
            LearningHLabel.TabIndex = 2;
            LearningHLabel.Text = "Rizal Technological University";
            LearningHLabel.Click += label1_Click;
            // 
            // LHMenuStripPanel
            // 
            LHMenuStripPanel.BackColor = Color.Transparent;
            LHMenuStripPanel.Controls.Add(MenuLbl);
            LHMenuStripPanel.Controls.Add(MenuIcon);
            LHMenuStripPanel.Location = new Point(15, 63);
            LHMenuStripPanel.Name = "LHMenuStripPanel";
            LHMenuStripPanel.Size = new Size(1285, 57);
            LHMenuStripPanel.TabIndex = 5;
            // 
            // MenuLbl
            // 
            MenuLbl.AutoSize = true;
            MenuLbl.Cursor = Cursors.Hand;
            MenuLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MenuLbl.Location = new Point(37, 28);
            MenuLbl.Name = "MenuLbl";
            MenuLbl.Size = new Size(44, 16);
            MenuLbl.TabIndex = 1;
            MenuLbl.Text = "MENU";
            MenuLbl.Click += label1_Click_1;
            // 
            // MenuIcon
            // 
            MenuIcon.Cursor = Cursors.Hand;
            MenuIcon.Image = Properties.Resources.Menu1;
            MenuIcon.Location = new Point(10, 25);
            MenuIcon.Name = "MenuIcon";
            MenuIcon.Size = new Size(24, 24);
            MenuIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            MenuIcon.TabIndex = 0;
            MenuIcon.TabStop = false;
            MenuIcon.Click += pictureBox1_Click;
            // 
            // LHMenuColumn
            // 
            LHMenuColumn.BackColor = Color.FromArgb(249, 184, 74);
            LHMenuColumn.BorderStyle = BorderStyle.Fixed3D;
            LHMenuColumn.Controls.Add(LogoutLinkedLbl);
            LHMenuColumn.Controls.Add(LogoutIcon);
            LHMenuColumn.Controls.Add(BillIcon);
            LHMenuColumn.Controls.Add(BillLinkedLbl);
            LHMenuColumn.Controls.Add(StudentSuppIcon);
            LHMenuColumn.Controls.Add(StudentSuppLinkLbl);
            LHMenuColumn.Controls.Add(GradeIcon);
            LHMenuColumn.Controls.Add(GradeLinkLbl);
            LHMenuColumn.Controls.Add(StudentIcon);
            LHMenuColumn.Controls.Add(ProfileLinkLbl);
            LHMenuColumn.Location = new Point(-220, 98);
            LHMenuColumn.Name = "LHMenuColumn";
            LHMenuColumn.Size = new Size(212, 590);
            LHMenuColumn.TabIndex = 4;
            LHMenuColumn.Paint += LHMenuColumn_Paint;
            // 
            // LogoutLinkedLbl
            // 
            LogoutLinkedLbl.ActiveLinkColor = Color.RoyalBlue;
            LogoutLinkedLbl.AutoSize = true;
            LogoutLinkedLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            LogoutLinkedLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            LogoutLinkedLbl.LinkColor = Color.Black;
            LogoutLinkedLbl.Location = new Point(118, 548);
            LogoutLinkedLbl.Name = "LogoutLinkedLbl";
            LogoutLinkedLbl.Size = new Size(60, 16);
            LogoutLinkedLbl.TabIndex = 9;
            LogoutLinkedLbl.TabStop = true;
            LogoutLinkedLbl.Text = "LOGOUT";
            LogoutLinkedLbl.LinkClicked += LogoutLinkedLbl_LinkClicked;
            // 
            // LogoutIcon
            // 
            LogoutIcon.Image = Properties.Resources.Logout;
            LogoutIcon.Location = new Point(181, 545);
            LogoutIcon.Name = "LogoutIcon";
            LogoutIcon.Size = new Size(24, 24);
            LogoutIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            LogoutIcon.TabIndex = 8;
            LogoutIcon.TabStop = false;
            LogoutIcon.Click += LogoutIcon_Click;
            // 
            // BillIcon
            // 
            BillIcon.Image = Properties.Resources.Bills;
            BillIcon.Location = new Point(12, 168);
            BillIcon.Name = "BillIcon";
            BillIcon.Size = new Size(24, 24);
            BillIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            BillIcon.TabIndex = 7;
            BillIcon.TabStop = false;
            // 
            // BillLinkedLbl
            // 
            BillLinkedLbl.ActiveLinkColor = Color.RoyalBlue;
            BillLinkedLbl.AutoSize = true;
            BillLinkedLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BillLinkedLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            BillLinkedLbl.LinkColor = Color.Black;
            BillLinkedLbl.Location = new Point(39, 172);
            BillLinkedLbl.Name = "BillLinkedLbl";
            BillLinkedLbl.Size = new Size(139, 16);
            BillLinkedLbl.TabIndex = 6;
            BillLinkedLbl.TabStop = true;
            BillLinkedLbl.Text = "BILLS and PAYMENTS";
            // 
            // StudentSuppIcon
            // 
            StudentSuppIcon.Image = Properties.Resources.Bell;
            StudentSuppIcon.Location = new Point(13, 123);
            StudentSuppIcon.Name = "StudentSuppIcon";
            StudentSuppIcon.Size = new Size(24, 24);
            StudentSuppIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentSuppIcon.TabIndex = 5;
            StudentSuppIcon.TabStop = false;
            // 
            // StudentSuppLinkLbl
            // 
            StudentSuppLinkLbl.ActiveLinkColor = Color.RoyalBlue;
            StudentSuppLinkLbl.AutoSize = true;
            StudentSuppLinkLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StudentSuppLinkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            StudentSuppLinkLbl.LinkColor = Color.Black;
            StudentSuppLinkLbl.Location = new Point(40, 127);
            StudentSuppLinkLbl.Name = "StudentSuppLinkLbl";
            StudentSuppLinkLbl.Size = new Size(118, 16);
            StudentSuppLinkLbl.TabIndex = 4;
            StudentSuppLinkLbl.TabStop = true;
            StudentSuppLinkLbl.Text = "STUDENT SUPPORT";
            // 
            // GradeIcon
            // 
            GradeIcon.Image = Properties.Resources.Table;
            GradeIcon.Location = new Point(12, 79);
            GradeIcon.Name = "GradeIcon";
            GradeIcon.Size = new Size(24, 24);
            GradeIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            GradeIcon.TabIndex = 3;
            GradeIcon.TabStop = false;
            // 
            // GradeLinkLbl
            // 
            GradeLinkLbl.ActiveLinkColor = Color.RoyalBlue;
            GradeLinkLbl.AutoSize = true;
            GradeLinkLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GradeLinkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            GradeLinkLbl.LinkColor = Color.Black;
            GradeLinkLbl.Location = new Point(39, 83);
            GradeLinkLbl.Name = "GradeLinkLbl";
            GradeLinkLbl.Size = new Size(59, 16);
            GradeLinkLbl.TabIndex = 2;
            GradeLinkLbl.TabStop = true;
            GradeLinkLbl.Text = "GRADES";
            // 
            // StudentIcon
            // 
            StudentIcon.Image = Properties.Resources.User;
            StudentIcon.Location = new Point(12, 39);
            StudentIcon.Name = "StudentIcon";
            StudentIcon.Size = new Size(24, 24);
            StudentIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentIcon.TabIndex = 1;
            StudentIcon.TabStop = false;
            // 
            // ProfileLinkLbl
            // 
            ProfileLinkLbl.ActiveLinkColor = Color.RoyalBlue;
            ProfileLinkLbl.AutoSize = true;
            ProfileLinkLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProfileLinkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            ProfileLinkLbl.LinkColor = Color.Black;
            ProfileLinkLbl.Location = new Point(39, 43);
            ProfileLinkLbl.Name = "ProfileLinkLbl";
            ProfileLinkLbl.Size = new Size(56, 16);
            ProfileLinkLbl.TabIndex = 0;
            ProfileLinkLbl.TabStop = true;
            ProfileLinkLbl.Text = "PROFILE";
            ProfileLinkLbl.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LHUserCalendar
            // 
            LHUserCalendar.BackColor = SystemColors.Window;
            LHUserCalendar.Cursor = Cursors.Hand;
            LHUserCalendar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LHUserCalendar.Location = new Point(997, 141);
            LHUserCalendar.Name = "LHUserCalendar";
            LHUserCalendar.ShowWeekNumbers = true;
            LHUserCalendar.TabIndex = 2;
            LHUserCalendar.TodayDate = new DateTime(2023, 8, 27, 0, 0, 0, 0);
            LHUserCalendar.DateChanged += UserCalendar_DateChanged;
            // 
            // LHWelcome
            // 
            LHWelcome.BackColor = Color.FromArgb(249, 184, 74);
            LHWelcome.BorderStyle = BorderStyle.None;
            LHWelcome.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LHWelcome.ForeColor = Color.Black;
            LHWelcome.Location = new Point(15, 18);
            LHWelcome.Multiline = true;
            LHWelcome.Name = "LHWelcome";
            LHWelcome.ReadOnly = true;
            LHWelcome.Size = new Size(688, 165);
            LHWelcome.TabIndex = 5;
            LHWelcome.Text = resources.GetString("LHWelcome.Text");
            LHWelcome.TextAlign = HorizontalAlignment.Center;
            LHWelcome.TextChanged += LHWelcome_TextChanged;
            // 
            // LHBasicInfoPanel
            // 
            LHBasicInfoPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHBasicInfoPanel.Controls.Add(LHSNBox);
            LHBasicInfoPanel.Controls.Add(LHNameBox);
            LHBasicInfoPanel.Controls.Add(LHSectLbl);
            LHBasicInfoPanel.Controls.Add(LHDeptLbl);
            LHBasicInfoPanel.Controls.Add(LHSNLbl);
            LHBasicInfoPanel.Controls.Add(LHNameLbl);
            LHBasicInfoPanel.Controls.Add(BasicInfoLbl);
            LHBasicInfoPanel.Location = new Point(279, 141);
            LHBasicInfoPanel.Name = "LHBasicInfoPanel";
            LHBasicInfoPanel.Size = new Size(706, 289);
            LHBasicInfoPanel.TabIndex = 6;
            // 
            // LHSNBox
            // 
            LHSNBox.BackColor = Color.FromArgb(249, 184, 74);
            LHSNBox.BorderStyle = BorderStyle.None;
            LHSNBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LHSNBox.ForeColor = Color.Black;
            LHSNBox.Location = new Point(136, 74);
            LHSNBox.Name = "LHSNBox";
            LHSNBox.ReadOnly = true;
            LHSNBox.Size = new Size(305, 16);
            LHSNBox.TabIndex = 7;
            // 
            // LHNameBox
            // 
            LHNameBox.BackColor = Color.FromArgb(249, 184, 74);
            LHNameBox.BorderStyle = BorderStyle.None;
            LHNameBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LHNameBox.ForeColor = Color.Black;
            LHNameBox.Location = new Point(71, 44);
            LHNameBox.Name = "LHNameBox";
            LHNameBox.ReadOnly = true;
            LHNameBox.Size = new Size(305, 16);
            LHNameBox.TabIndex = 6;
            LHNameBox.TextChanged += LHNam_TextChanged;
            // 
            // LHSectLbl
            // 
            LHSectLbl.AutoSize = true;
            LHSectLbl.FlatStyle = FlatStyle.Flat;
            LHSectLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LHSectLbl.ForeColor = Color.Black;
            LHSectLbl.Location = new Point(15, 103);
            LHSectLbl.Name = "LHSectLbl";
            LHSectLbl.Size = new Size(58, 16);
            LHSectLbl.TabIndex = 5;
            LHSectLbl.Text = "Section:";
            LHSectLbl.Click += label1_Click_2;
            // 
            // LHDeptLbl
            // 
            LHDeptLbl.AutoSize = true;
            LHDeptLbl.FlatStyle = FlatStyle.Flat;
            LHDeptLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LHDeptLbl.ForeColor = Color.Black;
            LHDeptLbl.Location = new Point(15, 131);
            LHDeptLbl.Name = "LHDeptLbl";
            LHDeptLbl.Size = new Size(142, 16);
            LHDeptLbl.TabIndex = 4;
            LHDeptLbl.Text = "College Department:";
            LHDeptLbl.Click += LHDeptLbl_Click;
            // 
            // LHSNLbl
            // 
            LHSNLbl.AutoSize = true;
            LHSNLbl.FlatStyle = FlatStyle.Flat;
            LHSNLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LHSNLbl.ForeColor = Color.Black;
            LHSNLbl.Location = new Point(15, 74);
            LHSNLbl.Name = "LHSNLbl";
            LHSNLbl.Size = new Size(115, 16);
            LHSNLbl.TabIndex = 3;
            LHSNLbl.Text = "Student Number:";
            // 
            // LHNameLbl
            // 
            LHNameLbl.AutoSize = true;
            LHNameLbl.FlatStyle = FlatStyle.Flat;
            LHNameLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LHNameLbl.ForeColor = Color.Black;
            LHNameLbl.Location = new Point(15, 46);
            LHNameLbl.Name = "LHNameLbl";
            LHNameLbl.Size = new Size(50, 16);
            LHNameLbl.TabIndex = 2;
            LHNameLbl.Text = "Name:";
            LHNameLbl.Click += label2_Click;
            // 
            // BasicInfoLbl
            // 
            BasicInfoLbl.AutoSize = true;
            BasicInfoLbl.BorderStyle = BorderStyle.FixedSingle;
            BasicInfoLbl.FlatStyle = FlatStyle.Flat;
            BasicInfoLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BasicInfoLbl.ForeColor = Color.Black;
            BasicInfoLbl.Location = new Point(15, 15);
            BasicInfoLbl.Name = "BasicInfoLbl";
            BasicInfoLbl.Size = new Size(174, 18);
            BasicInfoLbl.TabIndex = 1;
            BasicInfoLbl.Text = "Basic Student Information";
            // 
            // LHSchedPanel
            // 
            LHSchedPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHSchedPanel.Controls.Add(LHSchedTable);
            LHSchedPanel.Controls.Add(ClassSchedLbl);
            LHSchedPanel.Location = new Point(997, 315);
            LHSchedPanel.Name = "LHSchedPanel";
            LHSchedPanel.Size = new Size(249, 338);
            LHSchedPanel.TabIndex = 7;
            // 
            // LHSchedTable
            // 
            LHSchedTable.AllowUserToDeleteRows = false;
            LHSchedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LHSchedTable.BackgroundColor = Color.FromArgb(249, 184, 74);
            LHSchedTable.BorderStyle = BorderStyle.None;
            LHSchedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LHSchedTable.Columns.AddRange(new DataGridViewColumn[] { LHSub, LHSect, LHTime, LHDay, LHRoom });
            LHSchedTable.GridColor = SystemColors.Highlight;
            LHSchedTable.Location = new Point(16, 43);
            LHSchedTable.Name = "LHSchedTable";
            LHSchedTable.ReadOnly = true;
            LHSchedTable.RowHeadersVisible = false;
            LHSchedTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            LHSchedTable.RowTemplate.Height = 25;
            LHSchedTable.Size = new Size(215, 275);
            LHSchedTable.TabIndex = 3;
            // 
            // LHSub
            // 
            LHSub.HeaderText = "Subject";
            LHSub.Name = "LHSub";
            LHSub.ReadOnly = true;
            // 
            // LHSect
            // 
            LHSect.HeaderText = "Section";
            LHSect.Name = "LHSect";
            LHSect.ReadOnly = true;
            // 
            // LHTime
            // 
            LHTime.HeaderText = "Time";
            LHTime.Name = "LHTime";
            LHTime.ReadOnly = true;
            // 
            // LHDay
            // 
            LHDay.HeaderText = "Day";
            LHDay.Name = "LHDay";
            LHDay.ReadOnly = true;
            // 
            // LHRoom
            // 
            LHRoom.HeaderText = "Room";
            LHRoom.Name = "LHRoom";
            LHRoom.ReadOnly = true;
            // 
            // ClassSchedLbl
            // 
            ClassSchedLbl.AutoSize = true;
            ClassSchedLbl.BorderStyle = BorderStyle.FixedSingle;
            ClassSchedLbl.FlatStyle = FlatStyle.Flat;
            ClassSchedLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClassSchedLbl.ForeColor = Color.Black;
            ClassSchedLbl.Location = new Point(12, 11);
            ClassSchedLbl.Name = "ClassSchedLbl";
            ClassSchedLbl.Size = new Size(108, 18);
            ClassSchedLbl.TabIndex = 2;
            ClassSchedLbl.Text = "Class Schedule";
            // 
            // LHEnrolledCoursePanel
            // 
            LHEnrolledCoursePanel.BackColor = Color.FromArgb(249, 184, 74);
            LHEnrolledCoursePanel.BorderStyle = BorderStyle.FixedSingle;
            LHEnrolledCoursePanel.Controls.Add(EnrolledLbl);
            LHEnrolledCoursePanel.Location = new Point(18, 141);
            LHEnrolledCoursePanel.Name = "LHEnrolledCoursePanel";
            LHEnrolledCoursePanel.Size = new Size(249, 512);
            LHEnrolledCoursePanel.TabIndex = 8;
            // 
            // EnrolledLbl
            // 
            EnrolledLbl.AutoSize = true;
            EnrolledLbl.BorderStyle = BorderStyle.FixedSingle;
            EnrolledLbl.FlatStyle = FlatStyle.Flat;
            EnrolledLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EnrolledLbl.ForeColor = Color.Black;
            EnrolledLbl.Location = new Point(13, 15);
            EnrolledLbl.Name = "EnrolledLbl";
            EnrolledLbl.Size = new Size(117, 18);
            EnrolledLbl.TabIndex = 0;
            EnrolledLbl.Text = "Enrolled Courses";
            // 
            // LHWcPanel
            // 
            LHWcPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHWcPanel.Controls.Add(LHWelcome);
            LHWcPanel.Location = new Point(279, 450);
            LHWcPanel.Name = "LHWcPanel";
            LHWcPanel.Size = new Size(706, 203);
            LHWcPanel.TabIndex = 7;
            // 
            // LHHomePage
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 79, 144);
            ClientSize = new Size(1264, 681);
            Controls.Add(LHWcPanel);
            Controls.Add(LHSchedPanel);
            Controls.Add(LHBasicInfoPanel);
            Controls.Add(LHHeaderPanel);
            Controls.Add(RTUSealXL);
            Controls.Add(LHMenuColumn);
            Controls.Add(LHUserCalendar);
            Controls.Add(LHEnrolledCoursePanel);
            Name = "LHHomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Learning Hub";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).EndInit();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).EndInit();
            LHHeaderPanel.ResumeLayout(false);
            LHHeaderPanel.PerformLayout();
            LHMenuStripPanel.ResumeLayout(false);
            LHMenuStripPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuIcon).EndInit();
            LHMenuColumn.ResumeLayout(false);
            LHMenuColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).EndInit();
            LHBasicInfoPanel.ResumeLayout(false);
            LHBasicInfoPanel.PerformLayout();
            LHSchedPanel.ResumeLayout(false);
            LHSchedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LHSchedTable).EndInit();
            LHEnrolledCoursePanel.ResumeLayout(false);
            LHEnrolledCoursePanel.PerformLayout();
            LHWcPanel.ResumeLayout(false);
            LHWcPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RTUSealXL;
        private PictureBox RTUSealIcon;
        private Panel LHHeaderPanel;
        private MonthCalendar LHUserCalendar;
        private Label LearningHLabel;
        private Panel LHMenuStripPanel;
        private Panel LHMenuColumn;
        private PictureBox MenuIcon;
        private TextBox LHWelcome;
        private LinkLabel ProfileLinkLbl;
        private PictureBox StudentIcon;
        private Label MenuLbl;
        private PictureBox GradeIcon;
        private LinkLabel GradeLinkLbl;
        private PictureBox StudentSuppIcon;
        private LinkLabel StudentSuppLinkLbl;
        private PictureBox BillIcon;
        private LinkLabel BillLinkedLbl;
        private Panel LHBasicInfoPanel;
        private Panel LHSchedPanel;
        private Panel LHEnrolledCoursePanel;
        private Panel LHWcPanel;
        private Label EnrolledLbl;
        private Label BasicInfoLbl;
        private Label ClassSchedLbl;
        private Label LHNameLbl;
        private Label LHSNLbl;
        private Label LHSectLbl;
        private Label LHDeptLbl;
        private DataGridView LHSchedTable;
        private DataGridViewTextBoxColumn LHSub;
        private DataGridViewTextBoxColumn LHSect;
        private DataGridViewTextBoxColumn LHTime;
        private DataGridViewTextBoxColumn LHDay;
        private DataGridViewTextBoxColumn LHRoom;
        private LinkLabel LogoutLinkedLbl;
        private PictureBox LogoutIcon;
        public TextBox LHNameBox;
        public TextBox LHSNBox;
    }
}