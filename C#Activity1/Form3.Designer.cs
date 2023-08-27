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
            RTUSealXL = new PictureBox();
            RTUSealIcon = new PictureBox();
            LHHeaderPanel = new Panel();
            LearningHLabel = new Label();
            LHMenuStripPanel = new Panel();
            MenuLbl = new Label();
            MenuIcon = new PictureBox();
            LHMenuColumn = new Panel();
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
            BasicInfoLbl = new Label();
            LHSchedPanel = new Panel();
            label1 = new Label();
            LHEnrolledCoursePanel = new Panel();
            EnrolledLbl = new Label();
            LHWcPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).BeginInit();
            LHHeaderPanel.SuspendLayout();
            LHMenuStripPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuIcon).BeginInit();
            LHMenuColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).BeginInit();
            LHBasicInfoPanel.SuspendLayout();
            LHSchedPanel.SuspendLayout();
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
            LHWelcome.Font = new Font("MS PGothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LHWelcome.ForeColor = Color.White;
            LHWelcome.Location = new Point(47, 24);
            LHWelcome.Multiline = true;
            LHWelcome.Name = "LHWelcome";
            LHWelcome.ReadOnly = true;
            LHWelcome.Size = new Size(623, 153);
            LHWelcome.TabIndex = 5;
            LHWelcome.Text = "The RTUista Learning Hub is the university’s  dupe Learning Management System (LMS) platform developed to create virtual classrooms and learning environment dedicated for online distance learning.";
            LHWelcome.TextAlign = HorizontalAlignment.Center;
            LHWelcome.TextChanged += LHWelcome_TextChanged;
            // 
            // LHBasicInfoPanel
            // 
            LHBasicInfoPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHBasicInfoPanel.Controls.Add(BasicInfoLbl);
            LHBasicInfoPanel.Location = new Point(279, 141);
            LHBasicInfoPanel.Name = "LHBasicInfoPanel";
            LHBasicInfoPanel.Size = new Size(706, 289);
            LHBasicInfoPanel.TabIndex = 6;
            // 
            // BasicInfoLbl
            // 
            BasicInfoLbl.AutoSize = true;
            BasicInfoLbl.BorderStyle = BorderStyle.FixedSingle;
            BasicInfoLbl.FlatStyle = FlatStyle.Flat;
            BasicInfoLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BasicInfoLbl.ForeColor = Color.White;
            BasicInfoLbl.Location = new Point(15, 15);
            BasicInfoLbl.Name = "BasicInfoLbl";
            BasicInfoLbl.Size = new Size(174, 18);
            BasicInfoLbl.TabIndex = 1;
            BasicInfoLbl.Text = "Basic Student Information";
            // 
            // LHSchedPanel
            // 
            LHSchedPanel.BackColor = Color.FromArgb(249, 184, 74);
            LHSchedPanel.Controls.Add(label1);
            LHSchedPanel.Location = new Point(997, 315);
            LHSchedPanel.Name = "LHSchedPanel";
            LHSchedPanel.Size = new Size(249, 338);
            LHSchedPanel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 2;
            label1.Text = "Class Schedule";
            // 
            // LHEnrolledCoursePanel
            // 
            LHEnrolledCoursePanel.BackColor = Color.FromArgb(249, 184, 74);
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
            EnrolledLbl.ForeColor = Color.White;
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
            ((System.ComponentModel.ISupportInitialize)BillIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).EndInit();
            LHBasicInfoPanel.ResumeLayout(false);
            LHBasicInfoPanel.PerformLayout();
            LHSchedPanel.ResumeLayout(false);
            LHSchedPanel.PerformLayout();
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
        private Label label1;
    }
}