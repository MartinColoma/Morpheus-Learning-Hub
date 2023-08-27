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
            panel1 = new Panel();
            LearningHLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LHMenuColumn = new Panel();
            BillIcon = new PictureBox();
            BillLinkedLbl = new LinkLabel();
            StudentSuppIcon = new PictureBox();
            StudentSuppLinkLbl = new LinkLabel();
            GradeIcon = new PictureBox();
            GradeLinkLbl = new LinkLabel();
            StudentIcon = new PictureBox();
            ProfileLinkLbl = new LinkLabel();
            UserCalendar = new MonthCalendar();
            LHWelcome = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LHMenuColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).BeginInit();
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
            RTUSealIcon.Location = new Point(421, 14);
            RTUSealIcon.Name = "RTUSealIcon";
            RTUSealIcon.Size = new Size(64, 63);
            RTUSealIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            RTUSealIcon.TabIndex = 1;
            RTUSealIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 184, 74);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(LearningHLabel);
            panel1.Controls.Add(RTUSealIcon);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-14, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 120);
            panel1.TabIndex = 3;
            // 
            // LearningHLabel
            // 
            LearningHLabel.AutoSize = true;
            LearningHLabel.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LearningHLabel.ForeColor = Color.FromArgb(24, 79, 144);
            LearningHLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LearningHLabel.Location = new Point(491, 33);
            LearningHLabel.Name = "LearningHLabel";
            LearningHLabel.Size = new Size(390, 27);
            LearningHLabel.TabIndex = 2;
            LearningHLabel.Text = "Rizal Technological University";
            LearningHLabel.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 57);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Menu1;
            pictureBox1.Location = new Point(10, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LHMenuColumn
            // 
            LHMenuColumn.BackColor = Color.FromArgb(249, 184, 74);
            LHMenuColumn.Controls.Add(BillIcon);
            LHMenuColumn.Controls.Add(BillLinkedLbl);
            LHMenuColumn.Controls.Add(StudentSuppIcon);
            LHMenuColumn.Controls.Add(StudentSuppLinkLbl);
            LHMenuColumn.Controls.Add(GradeIcon);
            LHMenuColumn.Controls.Add(GradeLinkLbl);
            LHMenuColumn.Controls.Add(StudentIcon);
            LHMenuColumn.Controls.Add(ProfileLinkLbl);
            LHMenuColumn.Location = new Point(0, 98);
            LHMenuColumn.Name = "LHMenuColumn";
            LHMenuColumn.Size = new Size(194, 590);
            LHMenuColumn.TabIndex = 4;
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
            // UserCalendar
            // 
            UserCalendar.BackColor = SystemColors.Window;
            UserCalendar.Location = new Point(18, 141);
            UserCalendar.Name = "UserCalendar";
            UserCalendar.ShowWeekNumbers = true;
            UserCalendar.TabIndex = 2;
            UserCalendar.TodayDate = new DateTime(2023, 8, 27, 0, 0, 0, 0);
            UserCalendar.DateChanged += UserCalendar_DateChanged;
            // 
            // LHWelcome
            // 
            LHWelcome.BackColor = Color.FromArgb(24, 79, 144);
            LHWelcome.BorderStyle = BorderStyle.None;
            LHWelcome.Font = new Font("MS PGothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LHWelcome.ForeColor = Color.White;
            LHWelcome.Location = new Point(266, 401);
            LHWelcome.Multiline = true;
            LHWelcome.Name = "LHWelcome";
            LHWelcome.ReadOnly = true;
            LHWelcome.Size = new Size(733, 142);
            LHWelcome.TabIndex = 5;
            LHWelcome.Text = "The RTUista Learning Hub is the university’s Learning Management System (LMS) platform developed to create virtual classrooms and learning environment dedicated for online distance learning.";
            LHWelcome.TextAlign = HorizontalAlignment.Center;
            LHWelcome.TextChanged += LHWelcome_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 184, 74);
            panel3.Location = new Point(279, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(694, 237);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 184, 74);
            panel4.Location = new Point(1002, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 482);
            panel4.TabIndex = 7;
            // 
            // LHHomePage
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 79, 144);
            ClientSize = new Size(1264, 681);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(LHWelcome);
            Controls.Add(panel1);
            Controls.Add(RTUSealXL);
            Controls.Add(LHMenuColumn);
            Controls.Add(UserCalendar);
            Name = "LHHomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Learning Hub";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).EndInit();
            ((System.ComponentModel.ISupportInitialize)RTUSealIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LHMenuColumn.ResumeLayout(false);
            LHMenuColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentSuppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GradeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RTUSealXL;
        private PictureBox RTUSealIcon;
        private Panel panel1;
        private MonthCalendar UserCalendar;
        private Label LearningHLabel;
        private Panel panel2;
        private Panel LHMenuColumn;
        private PictureBox pictureBox1;
        private TextBox LHWelcome;
        private LinkLabel ProfileLinkLbl;
        private PictureBox StudentIcon;
        private Label label1;
        private PictureBox GradeIcon;
        private LinkLabel GradeLinkLbl;
        private PictureBox StudentSuppIcon;
        private LinkLabel StudentSuppLinkLbl;
        private PictureBox BillIcon;
        private LinkLabel BillLinkedLbl;
        private Panel panel3;
        private Panel panel4;
    }
}