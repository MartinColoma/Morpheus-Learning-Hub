namespace C_Activity1
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            RTUSealIcon = new PictureBox();
            LHHeaderPanel = new Panel();
            LearningHLabel = new Label();
            LHMenuStripPanel = new Panel();
            MenuBtn = new Button();
            LHMenuColumn = new Panel();
            LogoutBtn = new Button();
            EducPlanBtn = new Button();
            StudSuppLinkBtn = new Button();
            GradeLinkBtn = new Button();
            ProfileLinkedBtn = new Button();
            LHUserCalendar = new MonthCalendar();
            LHWelcome = new TextBox();
            LHBasicInfoPanel = new Panel();
            LHSNBox = new TextBox();
            LHNameBox = new TextBox();
            LHSectLbl = new Label();
            LHCourseLbl = new Label();
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
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).BeginInit();
            LHHeaderPanel.SuspendLayout();
            LHMenuStripPanel.SuspendLayout();
            LHMenuColumn.SuspendLayout();
            LHBasicInfoPanel.SuspendLayout();
            LHSchedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LHSchedTable).BeginInit();
            LHEnrolledCoursePanel.SuspendLayout();
            LHWcPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RTUSealIcon
            // 
            RTUSealIcon.Image = Properties.Resources._5;
            RTUSealIcon.Location = new Point(421, 28);
            RTUSealIcon.Name = "RTUSealIcon";
            RTUSealIcon.Size = new Size(64, 64);
            RTUSealIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            RTUSealIcon.TabIndex = 1;
            RTUSealIcon.TabStop = false;
            // 
            // LHHeaderPanel
            // 
            LHHeaderPanel.BackColor = Color.FromArgb(250, 247, 247);
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
            LHMenuStripPanel.Controls.Add(MenuBtn);
            LHMenuStripPanel.Location = new Point(15, 63);
            LHMenuStripPanel.Name = "LHMenuStripPanel";
            LHMenuStripPanel.Size = new Size(1285, 57);
            LHMenuStripPanel.TabIndex = 5;
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.FromArgb(250, 247, 247);
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.FlatAppearance.BorderSize = 0;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MenuBtn.ForeColor = Color.FromArgb(90, 115, 141);
            MenuBtn.Image = Properties.Resources.Menu1;
            MenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MenuBtn.Location = new Point(3, 16);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(194, 38);
            MenuBtn.TabIndex = 15;
            MenuBtn.Text = "MENU";
            MenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            MenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuBtn.UseVisualStyleBackColor = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // LHMenuColumn
            // 
            LHMenuColumn.BackColor = Color.FromArgb(250, 247, 247);
            LHMenuColumn.BorderStyle = BorderStyle.FixedSingle;
            LHMenuColumn.Controls.Add(LogoutBtn);
            LHMenuColumn.Controls.Add(EducPlanBtn);
            LHMenuColumn.Controls.Add(StudSuppLinkBtn);
            LHMenuColumn.Controls.Add(GradeLinkBtn);
            LHMenuColumn.Controls.Add(ProfileLinkedBtn);
            LHMenuColumn.Location = new Point(-220, 115);
            LHMenuColumn.Name = "LHMenuColumn";
            LHMenuColumn.Size = new Size(212, 573);
            LHMenuColumn.TabIndex = 4;
            LHMenuColumn.Paint += LHMenuColumn_Paint;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(250, 247, 247);
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.FromArgb(90, 115, 141);
            LogoutBtn.Image = Properties.Resources.Logout;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleRight;
            LogoutBtn.Location = new Point(10, 531);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(194, 38);
            LogoutBtn.TabIndex = 14;
            LogoutBtn.Text = "LOGOUT";
            LogoutBtn.TextAlign = ContentAlignment.MiddleRight;
            LogoutBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += button1_Click_1;
            // 
            // EducPlanBtn
            // 
            EducPlanBtn.BackColor = Color.FromArgb(250, 247, 247);
            EducPlanBtn.Cursor = Cursors.Hand;
            EducPlanBtn.FlatAppearance.BorderSize = 0;
            EducPlanBtn.FlatStyle = FlatStyle.Flat;
            EducPlanBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EducPlanBtn.ForeColor = Color.FromArgb(90, 115, 141);
            EducPlanBtn.Image = Properties.Resources.Bills;
            EducPlanBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EducPlanBtn.Location = new Point(10, 153);
            EducPlanBtn.Name = "EducPlanBtn";
            EducPlanBtn.Size = new Size(194, 38);
            EducPlanBtn.TabIndex = 13;
            EducPlanBtn.Text = "EDUCATIONAL PLAN";
            EducPlanBtn.TextAlign = ContentAlignment.MiddleLeft;
            EducPlanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            EducPlanBtn.UseVisualStyleBackColor = false;
            // 
            // StudSuppLinkBtn
            // 
            StudSuppLinkBtn.BackColor = Color.FromArgb(250, 247, 247);
            StudSuppLinkBtn.Cursor = Cursors.Hand;
            StudSuppLinkBtn.FlatAppearance.BorderSize = 0;
            StudSuppLinkBtn.FlatStyle = FlatStyle.Flat;
            StudSuppLinkBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StudSuppLinkBtn.ForeColor = Color.FromArgb(90, 115, 141);
            StudSuppLinkBtn.Image = Properties.Resources.Bell;
            StudSuppLinkBtn.ImageAlign = ContentAlignment.MiddleLeft;
            StudSuppLinkBtn.Location = new Point(10, 109);
            StudSuppLinkBtn.Name = "StudSuppLinkBtn";
            StudSuppLinkBtn.Size = new Size(194, 38);
            StudSuppLinkBtn.TabIndex = 12;
            StudSuppLinkBtn.Text = "STUDENT SUPPORT";
            StudSuppLinkBtn.TextAlign = ContentAlignment.MiddleLeft;
            StudSuppLinkBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            StudSuppLinkBtn.UseVisualStyleBackColor = false;
            // 
            // GradeLinkBtn
            // 
            GradeLinkBtn.BackColor = Color.FromArgb(250, 247, 247);
            GradeLinkBtn.Cursor = Cursors.Hand;
            GradeLinkBtn.FlatAppearance.BorderSize = 0;
            GradeLinkBtn.FlatStyle = FlatStyle.Flat;
            GradeLinkBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GradeLinkBtn.ForeColor = Color.FromArgb(90, 115, 141);
            GradeLinkBtn.Image = Properties.Resources.Table;
            GradeLinkBtn.ImageAlign = ContentAlignment.MiddleLeft;
            GradeLinkBtn.Location = new Point(10, 67);
            GradeLinkBtn.Name = "GradeLinkBtn";
            GradeLinkBtn.Size = new Size(194, 38);
            GradeLinkBtn.TabIndex = 11;
            GradeLinkBtn.Text = "GRADES";
            GradeLinkBtn.TextAlign = ContentAlignment.MiddleLeft;
            GradeLinkBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            GradeLinkBtn.UseVisualStyleBackColor = false;
            GradeLinkBtn.Click += button1_Click;
            // 
            // ProfileLinkedBtn
            // 
            ProfileLinkedBtn.BackColor = Color.FromArgb(250, 247, 247);
            ProfileLinkedBtn.Cursor = Cursors.Hand;
            ProfileLinkedBtn.FlatAppearance.BorderSize = 0;
            ProfileLinkedBtn.FlatStyle = FlatStyle.Flat;
            ProfileLinkedBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProfileLinkedBtn.ForeColor = Color.FromArgb(90, 115, 141);
            ProfileLinkedBtn.Image = Properties.Resources.User;
            ProfileLinkedBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileLinkedBtn.Location = new Point(10, 23);
            ProfileLinkedBtn.Name = "ProfileLinkedBtn";
            ProfileLinkedBtn.Size = new Size(194, 38);
            ProfileLinkedBtn.TabIndex = 10;
            ProfileLinkedBtn.Text = "PROFILE";
            ProfileLinkedBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProfileLinkedBtn.UseVisualStyleBackColor = false;
            // 
            // LHUserCalendar
            // 
            LHUserCalendar.BackColor = SystemColors.Info;
            LHUserCalendar.Cursor = Cursors.Hand;
            LHUserCalendar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LHUserCalendar.Location = new Point(997, 139);
            LHUserCalendar.Name = "LHUserCalendar";
            LHUserCalendar.ShowToday = false;
            LHUserCalendar.TabIndex = 2;
            LHUserCalendar.TodayDate = new DateTime(2023, 9, 25, 0, 0, 0, 0);
            LHUserCalendar.DateChanged += UserCalendar_DateChanged;
            // 
            // LHWelcome
            // 
            LHWelcome.BackColor = Color.FromArgb(250, 247, 247);
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
            LHBasicInfoPanel.BackColor = Color.FromArgb(250, 247, 247);
            LHBasicInfoPanel.Controls.Add(LHSNBox);
            LHBasicInfoPanel.Controls.Add(LHNameBox);
            LHBasicInfoPanel.Controls.Add(LHSectLbl);
            LHBasicInfoPanel.Controls.Add(LHCourseLbl);
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
            LHSNBox.BackColor = Color.FromArgb(250, 247, 247);
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
            LHNameBox.BackColor = Color.FromArgb(250, 247, 247);
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
            // LHCourseLbl
            // 
            LHCourseLbl.AutoSize = true;
            LHCourseLbl.FlatStyle = FlatStyle.Flat;
            LHCourseLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LHCourseLbl.ForeColor = Color.Black;
            LHCourseLbl.Location = new Point(15, 131);
            LHCourseLbl.Name = "LHCourseLbl";
            LHCourseLbl.Size = new Size(111, 16);
            LHCourseLbl.TabIndex = 4;
            LHCourseLbl.Text = "College Course:";
            LHCourseLbl.Click += LHDeptLbl_Click;
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
            LHSchedPanel.BackColor = Color.FromArgb(250, 247, 247);
            LHSchedPanel.Controls.Add(LHSchedTable);
            LHSchedPanel.Controls.Add(ClassSchedLbl);
            LHSchedPanel.Location = new Point(997, 315);
            LHSchedPanel.Name = "LHSchedPanel";
            LHSchedPanel.Size = new Size(227, 338);
            LHSchedPanel.TabIndex = 7;
            // 
            // LHSchedTable
            // 
            LHSchedTable.AllowUserToDeleteRows = false;
            LHSchedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LHSchedTable.BackgroundColor = Color.FromArgb(250, 247, 247);
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
            LHSchedTable.Size = new Size(194, 275);
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
            LHEnrolledCoursePanel.BackColor = Color.FromArgb(250, 247, 247);
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
            LHWcPanel.BackColor = Color.FromArgb(250, 247, 247);
            LHWcPanel.Controls.Add(LHWelcome);
            LHWcPanel.Location = new Point(279, 450);
            LHWcPanel.Name = "LHWcPanel";
            LHWcPanel.Size = new Size(706, 203);
            LHWcPanel.TabIndex = 7;
            // 
            // UserForm
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 115, 141);
            ClientSize = new Size(1264, 681);
            Controls.Add(LHWcPanel);
            Controls.Add(LHSchedPanel);
            Controls.Add(LHBasicInfoPanel);
            Controls.Add(LHHeaderPanel);
            Controls.Add(LHMenuColumn);
            Controls.Add(LHUserCalendar);
            Controls.Add(LHEnrolledCoursePanel);
            Name = "UserForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Learning Hub";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).EndInit();
            LHHeaderPanel.ResumeLayout(false);
            LHHeaderPanel.PerformLayout();
            LHMenuStripPanel.ResumeLayout(false);
            LHMenuColumn.ResumeLayout(false);
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
        private PictureBox RTUSealIcon;
        private Panel LHHeaderPanel;
        private MonthCalendar LHUserCalendar;
        private Label LearningHLabel;
        private Panel LHMenuStripPanel;
        private Panel LHMenuColumn;
        private TextBox LHWelcome;
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
        private Label LHCourseLbl;
        private DataGridView LHSchedTable;
        private DataGridViewTextBoxColumn LHSub;
        private DataGridViewTextBoxColumn LHSect;
        private DataGridViewTextBoxColumn LHTime;
        private DataGridViewTextBoxColumn LHDay;
        private DataGridViewTextBoxColumn LHRoom;
        public TextBox LHNameBox;
        public TextBox LHSNBox;
        private Button ProfileLinkedBtn;
        private Button EducPlanBtn;
        private Button StudSuppLinkBtn;
        private Button GradeLinkBtn;
        private Button LogoutBtn;
        private Button MenuBtn;
    }
}