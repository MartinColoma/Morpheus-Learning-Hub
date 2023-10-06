namespace C_Activity1
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PendingTable = new DataGridView();
            ApprovedTable = new DataGridView();
            PendingLabel = new Label();
            ApprovedLbl = new Label();
            ApproveBtn = new Button();
            ApprovedPanel = new Panel();
            ApprovedSearchPanel = new Panel();
            ApprovedSearchBtn = new FontAwesome.Sharp.IconButton();
            ApprovedSearchBox = new TextBox();
            PendingBtn = new Button();
            AdminLoginLinkedLbl = new LinkLabel();
            ApprovedRefreshBtn = new FontAwesome.Sharp.IconButton();
            MorpheusLogo2 = new PictureBox();
            ArchiveBtn = new Button();
            PendingPanel = new Panel();
            PendingSearchPanel = new Panel();
            PendingSearchBtn = new FontAwesome.Sharp.IconButton();
            PendingSearchBox = new TextBox();
            PendingRefreshBtn = new FontAwesome.Sharp.IconButton();
            MorpheusBlueLogo = new PictureBox();
            AccountTabs = new TabControl();
            InsertTab = new TabPage();
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
            RegiPassLabel = new Label();
            RegiNameLabel = new Label();
            GSLabel = new Label();
            RegiPassPanel = new Panel();
            RegiShowPass = new CheckBox();
            RegiPassBox = new TextBox();
            RegiRPPanel = new Panel();
            RegiRPBox = new TextBox();
            RegiSNBoxPanel = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            RegiSNBox = new TextBox();
            RegiAgePanel = new Panel();
            RegiAgeBox = new TextBox();
            PendingTab = new TabPage();
            ApprovedTab = new TabPage();
            ArchivedTab = new TabPage();
            ArchivedPanel = new Panel();
            ArchivedSearchPanel = new Panel();
            ArchivedSearchBtn = new FontAwesome.Sharp.IconButton();
            ArchivedSearchBox = new TextBox();
            linkLabel1 = new LinkLabel();
            ArchivedRefreshBtn = new FontAwesome.Sharp.IconButton();
            ArchivedLogo = new PictureBox();
            ReactivateBtn = new Button();
            ArchivedAccLbl = new Label();
            ArchivedTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PendingTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).BeginInit();
            ApprovedPanel.SuspendLayout();
            ApprovedSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).BeginInit();
            PendingPanel.SuspendLayout();
            PendingSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusBlueLogo).BeginInit();
            AccountTabs.SuspendLayout();
            InsertTab.SuspendLayout();
            RegiPanel.SuspendLayout();
            RegiMailPanel.SuspendLayout();
            RegiGenderPanel.SuspendLayout();
            RegiCoursePanel.SuspendLayout();
            RegiNamePanel.SuspendLayout();
            RegiPassPanel.SuspendLayout();
            RegiRPPanel.SuspendLayout();
            RegiSNBoxPanel.SuspendLayout();
            RegiAgePanel.SuspendLayout();
            PendingTab.SuspendLayout();
            ApprovedTab.SuspendLayout();
            ArchivedTab.SuspendLayout();
            ArchivedPanel.SuspendLayout();
            ArchivedSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ArchivedLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ArchivedTable).BeginInit();
            SuspendLayout();
            // 
            // PendingTable
            // 
            PendingTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PendingTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PendingTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            PendingTable.BorderStyle = BorderStyle.Fixed3D;
            PendingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingTable.Location = new Point(42, 152);
            PendingTable.Name = "PendingTable";
            PendingTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 247, 247);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PendingTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PendingTable.RowTemplate.Height = 25;
            PendingTable.Size = new Size(665, 220);
            PendingTable.TabIndex = 0;
            PendingTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ApprovedTable
            // 
            ApprovedTable.AllowUserToAddRows = false;
            ApprovedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApprovedTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            ApprovedTable.BorderStyle = BorderStyle.Fixed3D;
            ApprovedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ApprovedTable.Location = new Point(43, 157);
            ApprovedTable.Name = "ApprovedTable";
            ApprovedTable.ReadOnly = true;
            ApprovedTable.RowTemplate.Height = 25;
            ApprovedTable.Size = new Size(665, 220);
            ApprovedTable.TabIndex = 1;
            ApprovedTable.CellContentClick += ApprovedTable_CellContentClick;
            // 
            // PendingLabel
            // 
            PendingLabel.AutoSize = true;
            PendingLabel.BackColor = Color.Transparent;
            PendingLabel.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            PendingLabel.ForeColor = Color.FromArgb(250, 247, 247);
            PendingLabel.Location = new Point(219, 14);
            PendingLabel.Name = "PendingLabel";
            PendingLabel.Size = new Size(390, 52);
            PendingLabel.TabIndex = 2;
            PendingLabel.Text = "Pending Accounts";
            PendingLabel.TextAlign = ContentAlignment.MiddleCenter;
            PendingLabel.Click += PendingLabel_Click;
            // 
            // ApprovedLbl
            // 
            ApprovedLbl.AutoSize = true;
            ApprovedLbl.BackColor = Color.Transparent;
            ApprovedLbl.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApprovedLbl.ForeColor = Color.FromArgb(250, 247, 247);
            ApprovedLbl.Location = new Point(219, 18);
            ApprovedLbl.Name = "ApprovedLbl";
            ApprovedLbl.Size = new Size(420, 52);
            ApprovedLbl.TabIndex = 3;
            ApprovedLbl.Text = "Approved Accounts";
            ApprovedLbl.TextAlign = ContentAlignment.MiddleCenter;
            ApprovedLbl.Click += label1_Click;
            // 
            // ApproveBtn
            // 
            ApproveBtn.BackColor = Color.Transparent;
            ApproveBtn.Cursor = Cursors.Hand;
            ApproveBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            ApproveBtn.FlatAppearance.BorderSize = 2;
            ApproveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            ApproveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            ApproveBtn.FlatStyle = FlatStyle.Flat;
            ApproveBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ApproveBtn.ForeColor = Color.White;
            ApproveBtn.Location = new Point(592, 396);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 37);
            ApproveBtn.TabIndex = 10;
            ApproveBtn.Text = "APPROVE";
            ApproveBtn.UseVisualStyleBackColor = false;
            ApproveBtn.Click += ApproveBtn_Click;
            // 
            // ApprovedPanel
            // 
            ApprovedPanel.Controls.Add(ApprovedSearchPanel);
            ApprovedPanel.Controls.Add(PendingBtn);
            ApprovedPanel.Controls.Add(AdminLoginLinkedLbl);
            ApprovedPanel.Controls.Add(ApprovedRefreshBtn);
            ApprovedPanel.Controls.Add(MorpheusLogo2);
            ApprovedPanel.Controls.Add(ArchiveBtn);
            ApprovedPanel.Controls.Add(ApprovedLbl);
            ApprovedPanel.Controls.Add(ApprovedTable);
            ApprovedPanel.Location = new Point(20, 0);
            ApprovedPanel.Name = "ApprovedPanel";
            ApprovedPanel.Size = new Size(747, 476);
            ApprovedPanel.TabIndex = 11;
            ApprovedPanel.Paint += ApprovedPanel_Paint;
            // 
            // ApprovedSearchPanel
            // 
            ApprovedSearchPanel.BackColor = Color.FromArgb(250, 247, 247);
            ApprovedSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            ApprovedSearchPanel.Controls.Add(ApprovedSearchBtn);
            ApprovedSearchPanel.Controls.Add(ApprovedSearchBox);
            ApprovedSearchPanel.Location = new Point(43, 120);
            ApprovedSearchPanel.Name = "ApprovedSearchPanel";
            ApprovedSearchPanel.Size = new Size(396, 28);
            ApprovedSearchPanel.TabIndex = 23;
            // 
            // ApprovedSearchBtn
            // 
            ApprovedSearchBtn.BackColor = Color.Transparent;
            ApprovedSearchBtn.FlatAppearance.BorderSize = 0;
            ApprovedSearchBtn.FlatStyle = FlatStyle.Flat;
            ApprovedSearchBtn.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            ApprovedSearchBtn.IconColor = Color.FromArgb(90, 115, 141);
            ApprovedSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ApprovedSearchBtn.IconSize = 24;
            ApprovedSearchBtn.Location = new Point(336, -4);
            ApprovedSearchBtn.Name = "ApprovedSearchBtn";
            ApprovedSearchBtn.Size = new Size(75, 36);
            ApprovedSearchBtn.TabIndex = 1;
            ApprovedSearchBtn.UseVisualStyleBackColor = false;
            // 
            // ApprovedSearchBox
            // 
            ApprovedSearchBox.BackColor = Color.FromArgb(250, 247, 247);
            ApprovedSearchBox.BorderStyle = BorderStyle.None;
            ApprovedSearchBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ApprovedSearchBox.ForeColor = Color.FromArgb(90, 115, 141);
            ApprovedSearchBox.Location = new Point(3, 5);
            ApprovedSearchBox.Name = "ApprovedSearchBox";
            ApprovedSearchBox.PlaceholderText = "Search..";
            ApprovedSearchBox.Size = new Size(356, 17);
            ApprovedSearchBox.TabIndex = 0;
            ApprovedSearchBox.TextChanged += ApprovedSearchBox_TextChanged;
            // 
            // PendingBtn
            // 
            PendingBtn.BackColor = Color.Transparent;
            PendingBtn.Cursor = Cursors.Hand;
            PendingBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            PendingBtn.FlatAppearance.BorderSize = 2;
            PendingBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            PendingBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            PendingBtn.FlatStyle = FlatStyle.Flat;
            PendingBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PendingBtn.ForeColor = Color.White;
            PendingBtn.Location = new Point(474, 405);
            PendingBtn.Name = "PendingBtn";
            PendingBtn.Size = new Size(114, 36);
            PendingBtn.TabIndex = 22;
            PendingBtn.Text = "WAITLIST";
            PendingBtn.UseVisualStyleBackColor = false;
            PendingBtn.Click += PendingBtn_Click;
            // 
            // AdminLoginLinkedLbl
            // 
            AdminLoginLinkedLbl.ActiveLinkColor = Color.FromArgb(24, 79, 144);
            AdminLoginLinkedLbl.AutoSize = true;
            AdminLoginLinkedLbl.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AdminLoginLinkedLbl.LinkBehavior = LinkBehavior.HoverUnderline;
            AdminLoginLinkedLbl.LinkColor = Color.White;
            AdminLoginLinkedLbl.Location = new Point(40, 413);
            AdminLoginLinkedLbl.Name = "AdminLoginLinkedLbl";
            AdminLoginLinkedLbl.Size = new Size(125, 15);
            AdminLoginLinkedLbl.TabIndex = 14;
            AdminLoginLinkedLbl.TabStop = true;
            AdminLoginLinkedLbl.Text = "Open Login Page...";
            AdminLoginLinkedLbl.LinkClicked += AdminLoginLinkedLbl_LinkClicked;
            // 
            // ApprovedRefreshBtn
            // 
            ApprovedRefreshBtn.FlatAppearance.BorderSize = 0;
            ApprovedRefreshBtn.FlatStyle = FlatStyle.Flat;
            ApprovedRefreshBtn.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ApprovedRefreshBtn.ForeColor = Color.FromArgb(250, 247, 247);
            ApprovedRefreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            ApprovedRefreshBtn.IconColor = Color.FromArgb(250, 247, 247);
            ApprovedRefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ApprovedRefreshBtn.IconSize = 24;
            ApprovedRefreshBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ApprovedRefreshBtn.Location = new Point(678, 122);
            ApprovedRefreshBtn.Name = "ApprovedRefreshBtn";
            ApprovedRefreshBtn.Size = new Size(30, 31);
            ApprovedRefreshBtn.TabIndex = 21;
            ApprovedRefreshBtn.TextAlign = ContentAlignment.MiddleLeft;
            ApprovedRefreshBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ApprovedRefreshBtn.UseVisualStyleBackColor = true;
            ApprovedRefreshBtn.Click += ApprovedRefreshBtn_Click;
            // 
            // MorpheusLogo2
            // 
            MorpheusLogo2.Image = Properties.Resources._3;
            MorpheusLogo2.Location = new Point(97, -8);
            MorpheusLogo2.Name = "MorpheusLogo2";
            MorpheusLogo2.Size = new Size(128, 128);
            MorpheusLogo2.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusLogo2.TabIndex = 18;
            MorpheusLogo2.TabStop = false;
            // 
            // ArchiveBtn
            // 
            ArchiveBtn.BackColor = Color.Transparent;
            ArchiveBtn.Cursor = Cursors.Hand;
            ArchiveBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            ArchiveBtn.FlatAppearance.BorderSize = 2;
            ArchiveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            ArchiveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            ArchiveBtn.FlatStyle = FlatStyle.Flat;
            ArchiveBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ArchiveBtn.ForeColor = Color.White;
            ArchiveBtn.Location = new Point(594, 405);
            ArchiveBtn.Name = "ArchiveBtn";
            ArchiveBtn.Size = new Size(114, 36);
            ArchiveBtn.TabIndex = 12;
            ArchiveBtn.Text = "ARCHIVE";
            ArchiveBtn.UseVisualStyleBackColor = false;
            ArchiveBtn.Click += DeleteBtn_Click;
            // 
            // PendingPanel
            // 
            PendingPanel.Controls.Add(PendingSearchPanel);
            PendingPanel.Controls.Add(PendingRefreshBtn);
            PendingPanel.Controls.Add(ApproveBtn);
            PendingPanel.Controls.Add(PendingLabel);
            PendingPanel.Controls.Add(PendingTable);
            PendingPanel.Controls.Add(MorpheusBlueLogo);
            PendingPanel.Location = new Point(22, 7);
            PendingPanel.Name = "PendingPanel";
            PendingPanel.Size = new Size(744, 473);
            PendingPanel.TabIndex = 13;
            PendingPanel.Paint += PendingPanel_Paint;
            // 
            // PendingSearchPanel
            // 
            PendingSearchPanel.BackColor = Color.FromArgb(250, 247, 247);
            PendingSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            PendingSearchPanel.Controls.Add(PendingSearchBtn);
            PendingSearchPanel.Controls.Add(PendingSearchBox);
            PendingSearchPanel.Location = new Point(42, 115);
            PendingSearchPanel.Name = "PendingSearchPanel";
            PendingSearchPanel.Size = new Size(396, 28);
            PendingSearchPanel.TabIndex = 21;
            PendingSearchPanel.Paint += PendingSearchPanel_Paint;
            // 
            // PendingSearchBtn
            // 
            PendingSearchBtn.BackColor = Color.Transparent;
            PendingSearchBtn.FlatAppearance.BorderSize = 0;
            PendingSearchBtn.FlatStyle = FlatStyle.Flat;
            PendingSearchBtn.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            PendingSearchBtn.IconColor = Color.FromArgb(90, 115, 141);
            PendingSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PendingSearchBtn.IconSize = 24;
            PendingSearchBtn.Location = new Point(336, -4);
            PendingSearchBtn.Name = "PendingSearchBtn";
            PendingSearchBtn.Size = new Size(75, 36);
            PendingSearchBtn.TabIndex = 1;
            PendingSearchBtn.UseVisualStyleBackColor = false;
            PendingSearchBtn.Click += iconButton1_Click;
            // 
            // PendingSearchBox
            // 
            PendingSearchBox.BackColor = Color.FromArgb(250, 247, 247);
            PendingSearchBox.BorderStyle = BorderStyle.None;
            PendingSearchBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PendingSearchBox.ForeColor = Color.FromArgb(90, 115, 141);
            PendingSearchBox.Location = new Point(3, 5);
            PendingSearchBox.Name = "PendingSearchBox";
            PendingSearchBox.PlaceholderText = "Search..";
            PendingSearchBox.Size = new Size(356, 17);
            PendingSearchBox.TabIndex = 0;
            PendingSearchBox.TextChanged += PendingSearchBox_TextChanged;
            // 
            // PendingRefreshBtn
            // 
            PendingRefreshBtn.FlatAppearance.BorderSize = 0;
            PendingRefreshBtn.FlatStyle = FlatStyle.Flat;
            PendingRefreshBtn.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PendingRefreshBtn.ForeColor = Color.FromArgb(250, 247, 247);
            PendingRefreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            PendingRefreshBtn.IconColor = Color.FromArgb(250, 247, 247);
            PendingRefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PendingRefreshBtn.IconSize = 24;
            PendingRefreshBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PendingRefreshBtn.Location = new Point(676, 117);
            PendingRefreshBtn.Name = "PendingRefreshBtn";
            PendingRefreshBtn.Size = new Size(31, 31);
            PendingRefreshBtn.TabIndex = 20;
            PendingRefreshBtn.TextAlign = ContentAlignment.MiddleLeft;
            PendingRefreshBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            PendingRefreshBtn.UseVisualStyleBackColor = true;
            PendingRefreshBtn.Click += PendingRefreshBtn_Click;
            // 
            // MorpheusBlueLogo
            // 
            MorpheusBlueLogo.Image = Properties.Resources._3;
            MorpheusBlueLogo.Location = new Point(97, -8);
            MorpheusBlueLogo.Name = "MorpheusBlueLogo";
            MorpheusBlueLogo.Size = new Size(128, 128);
            MorpheusBlueLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            MorpheusBlueLogo.TabIndex = 19;
            MorpheusBlueLogo.TabStop = false;
            // 
            // AccountTabs
            // 
            AccountTabs.Controls.Add(InsertTab);
            AccountTabs.Controls.Add(PendingTab);
            AccountTabs.Controls.Add(ApprovedTab);
            AccountTabs.Controls.Add(ArchivedTab);
            AccountTabs.Cursor = Cursors.Hand;
            AccountTabs.Dock = DockStyle.Fill;
            AccountTabs.HotTrack = true;
            AccountTabs.Location = new Point(0, 0);
            AccountTabs.Name = "AccountTabs";
            AccountTabs.SelectedIndex = 0;
            AccountTabs.Size = new Size(804, 511);
            AccountTabs.TabIndex = 30;
            AccountTabs.SelectedIndexChanged += AccountTabs_SelectedIndexChanged;
            // 
            // InsertTab
            // 
            InsertTab.BackColor = Color.FromArgb(90, 115, 141);
            InsertTab.Controls.Add(RegiPanel);
            InsertTab.Location = new Point(4, 24);
            InsertTab.Name = "InsertTab";
            InsertTab.Padding = new Padding(3);
            InsertTab.Size = new Size(796, 483);
            InsertTab.TabIndex = 3;
            InsertTab.Text = "Insert Account";
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
            RegiPanel.Controls.Add(RegiPassLabel);
            RegiPanel.Controls.Add(RegiNameLabel);
            RegiPanel.Controls.Add(GSLabel);
            RegiPanel.Controls.Add(RegiPassPanel);
            RegiPanel.Controls.Add(RegiRPPanel);
            RegiPanel.Controls.Add(RegiSNBoxPanel);
            RegiPanel.Controls.Add(RegiAgePanel);
            RegiPanel.Location = new Point(108, 14);
            RegiPanel.Name = "RegiPanel";
            RegiPanel.Size = new Size(580, 455);
            RegiPanel.TabIndex = 13;
            // 
            // SNMaxChar
            // 
            SNMaxChar.AutoSize = true;
            SNMaxChar.BackColor = Color.Transparent;
            SNMaxChar.Font = new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SNMaxChar.ForeColor = Color.FromArgb(90, 115, 141);
            SNMaxChar.Location = new Point(187, 212);
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
            RegiMailLbl.Location = new Point(323, 146);
            RegiMailLbl.Name = "RegiMailLbl";
            RegiMailLbl.Size = new Size(64, 23);
            RegiMailLbl.TabIndex = 27;
            RegiMailLbl.Text = "Email:";
            // 
            // RegiMailPanel
            // 
            RegiMailPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiMailPanel.Controls.Add(RegiMailBox);
            RegiMailPanel.Location = new Point(326, 172);
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
            RegiAgeLbl.Location = new Point(323, 81);
            RegiAgeLbl.Name = "RegiAgeLbl";
            RegiAgeLbl.Size = new Size(49, 23);
            RegiAgeLbl.TabIndex = 26;
            RegiAgeLbl.Text = "Age:";
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.BackColor = Color.Transparent;
            GenderLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLbl.ForeColor = Color.FromArgb(90, 115, 141);
            GenderLbl.Location = new Point(407, 81);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(80, 23);
            GenderLbl.TabIndex = 24;
            GenderLbl.Text = "Gender:";
            // 
            // RegiGenderPanel
            // 
            RegiGenderPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiGenderPanel.Controls.Add(RegiGenderComboBox);
            RegiGenderPanel.Location = new Point(407, 109);
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
            RegiGenderComboBox.SelectedIndexChanged += RegiGenderComboBox_SelectedIndexChanged;
            // 
            // RegiCourseLbl
            // 
            RegiCourseLbl.AutoSize = true;
            RegiCourseLbl.BackColor = Color.Transparent;
            RegiCourseLbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiCourseLbl.ForeColor = Color.FromArgb(90, 115, 141);
            RegiCourseLbl.Location = new Point(33, 146);
            RegiCourseLbl.Name = "RegiCourseLbl";
            RegiCourseLbl.Size = new Size(148, 23);
            RegiCourseLbl.TabIndex = 21;
            RegiCourseLbl.Text = "College Course:";
            // 
            // RegiCoursePanel
            // 
            RegiCoursePanel.BorderStyle = BorderStyle.FixedSingle;
            RegiCoursePanel.Controls.Add(RegiCourseBox);
            RegiCoursePanel.Location = new Point(38, 172);
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
            RegiNamePanel.Location = new Point(38, 109);
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
            // 
            // RegiRPLabel
            // 
            RegiRPLabel.AutoSize = true;
            RegiRPLabel.BackColor = Color.Transparent;
            RegiRPLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiRPLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiRPLabel.Location = new Point(323, 206);
            RegiRPLabel.Name = "RegiRPLabel";
            RegiRPLabel.Size = new Size(126, 23);
            RegiRPLabel.TabIndex = 14;
            RegiRPLabel.Text = "Recovery Pin";
            // 
            // RegiSNLabel
            // 
            RegiSNLabel.AutoSize = true;
            RegiSNLabel.BackColor = Color.Transparent;
            RegiSNLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiSNLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiSNLabel.Location = new Point(33, 206);
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
            CreateBtn.Location = new Point(238, 334);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(104, 35);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // RegiPassLabel
            // 
            RegiPassLabel.AutoSize = true;
            RegiPassLabel.BackColor = Color.Transparent;
            RegiPassLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegiPassLabel.ForeColor = Color.FromArgb(90, 115, 141);
            RegiPassLabel.Location = new Point(33, 268);
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
            RegiNameLabel.Location = new Point(33, 85);
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
            GSLabel.Location = new Point(171, 19);
            GSLabel.Name = "GSLabel";
            GSLabel.Size = new Size(238, 38);
            GSLabel.TabIndex = 1;
            GSLabel.Text = "Insert Account";
            GSLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegiPassPanel
            // 
            RegiPassPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiPassPanel.Controls.Add(RegiShowPass);
            RegiPassPanel.Controls.Add(RegiPassBox);
            RegiPassPanel.Location = new Point(38, 296);
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
            RegiShowPass.CheckedChanged += RegiShowPass_CheckedChanged;
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
            RegiPassBox.KeyDown += RegiPassBox_KeyDown;
            // 
            // RegiRPPanel
            // 
            RegiRPPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiRPPanel.Controls.Add(RegiRPBox);
            RegiRPPanel.Location = new Point(326, 233);
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
            // 
            // RegiSNBoxPanel
            // 
            RegiSNBoxPanel.BorderStyle = BorderStyle.FixedSingle;
            RegiSNBoxPanel.Controls.Add(iconButton1);
            RegiSNBoxPanel.Controls.Add(RegiSNBox);
            RegiSNBoxPanel.Location = new Point(38, 233);
            RegiSNBoxPanel.Name = "RegiSNBoxPanel";
            RegiSNBoxPanel.Size = new Size(282, 32);
            RegiSNBoxPanel.TabIndex = 18;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(250, 247, 247);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton1.IconColor = Color.FromArgb(90, 115, 141);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(249, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 31);
            iconButton1.TabIndex = 30;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
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
            RegiSNBox.Size = new Size(248, 13);
            RegiSNBox.TabIndex = 13;
            RegiSNBox.KeyDown += RegiSNBox_KeyDown;
            // 
            // RegiAgePanel
            // 
            RegiAgePanel.BorderStyle = BorderStyle.FixedSingle;
            RegiAgePanel.Controls.Add(RegiAgeBox);
            RegiAgePanel.Location = new Point(324, 109);
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
            // 
            // PendingTab
            // 
            PendingTab.BackColor = Color.FromArgb(90, 115, 141);
            PendingTab.Controls.Add(PendingPanel);
            PendingTab.Location = new Point(4, 24);
            PendingTab.Name = "PendingTab";
            PendingTab.Padding = new Padding(3);
            PendingTab.Size = new Size(796, 483);
            PendingTab.TabIndex = 0;
            PendingTab.Text = "Pending Account";
            PendingTab.Click += PendingTab_Click;
            // 
            // ApprovedTab
            // 
            ApprovedTab.BackColor = Color.FromArgb(90, 115, 141);
            ApprovedTab.Controls.Add(ApprovedPanel);
            ApprovedTab.Location = new Point(4, 24);
            ApprovedTab.Name = "ApprovedTab";
            ApprovedTab.Padding = new Padding(3);
            ApprovedTab.Size = new Size(796, 483);
            ApprovedTab.TabIndex = 1;
            ApprovedTab.Text = "Approved Account";
            ApprovedTab.Click += ApprovedTab_Click;
            // 
            // ArchivedTab
            // 
            ArchivedTab.BackColor = Color.FromArgb(90, 115, 141);
            ArchivedTab.Controls.Add(ArchivedPanel);
            ArchivedTab.Location = new Point(4, 24);
            ArchivedTab.Name = "ArchivedTab";
            ArchivedTab.Padding = new Padding(3);
            ArchivedTab.Size = new Size(796, 483);
            ArchivedTab.TabIndex = 2;
            ArchivedTab.Text = "Archived Account";
            // 
            // ArchivedPanel
            // 
            ArchivedPanel.Controls.Add(ArchivedSearchPanel);
            ArchivedPanel.Controls.Add(linkLabel1);
            ArchivedPanel.Controls.Add(ArchivedRefreshBtn);
            ArchivedPanel.Controls.Add(ArchivedLogo);
            ArchivedPanel.Controls.Add(ReactivateBtn);
            ArchivedPanel.Controls.Add(ArchivedAccLbl);
            ArchivedPanel.Controls.Add(ArchivedTable);
            ArchivedPanel.Location = new Point(25, 3);
            ArchivedPanel.Name = "ArchivedPanel";
            ArchivedPanel.Size = new Size(747, 476);
            ArchivedPanel.TabIndex = 12;
            ArchivedPanel.Paint += panel1_Paint;
            // 
            // ArchivedSearchPanel
            // 
            ArchivedSearchPanel.BackColor = Color.FromArgb(250, 247, 247);
            ArchivedSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            ArchivedSearchPanel.Controls.Add(ArchivedSearchBtn);
            ArchivedSearchPanel.Controls.Add(ArchivedSearchBox);
            ArchivedSearchPanel.Location = new Point(39, 125);
            ArchivedSearchPanel.Name = "ArchivedSearchPanel";
            ArchivedSearchPanel.Size = new Size(396, 28);
            ArchivedSearchPanel.TabIndex = 22;
            // 
            // ArchivedSearchBtn
            // 
            ArchivedSearchBtn.BackColor = Color.Transparent;
            ArchivedSearchBtn.FlatAppearance.BorderSize = 0;
            ArchivedSearchBtn.FlatStyle = FlatStyle.Flat;
            ArchivedSearchBtn.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            ArchivedSearchBtn.IconColor = Color.FromArgb(90, 115, 141);
            ArchivedSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ArchivedSearchBtn.IconSize = 24;
            ArchivedSearchBtn.Location = new Point(336, -4);
            ArchivedSearchBtn.Name = "ArchivedSearchBtn";
            ArchivedSearchBtn.Size = new Size(75, 36);
            ArchivedSearchBtn.TabIndex = 1;
            ArchivedSearchBtn.UseVisualStyleBackColor = false;
            // 
            // ArchivedSearchBox
            // 
            ArchivedSearchBox.BackColor = Color.FromArgb(250, 247, 247);
            ArchivedSearchBox.BorderStyle = BorderStyle.None;
            ArchivedSearchBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ArchivedSearchBox.ForeColor = Color.FromArgb(90, 115, 141);
            ArchivedSearchBox.Location = new Point(3, 5);
            ArchivedSearchBox.Name = "ArchivedSearchBox";
            ArchivedSearchBox.PlaceholderText = "Search..";
            ArchivedSearchBox.Size = new Size(356, 17);
            ArchivedSearchBox.TabIndex = 0;
            ArchivedSearchBox.TextChanged += ArchivedSearchBox_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(24, 79, 144);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(40, 413);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open Login Page...";
            // 
            // ArchivedRefreshBtn
            // 
            ArchivedRefreshBtn.FlatAppearance.BorderSize = 0;
            ArchivedRefreshBtn.FlatStyle = FlatStyle.Flat;
            ArchivedRefreshBtn.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ArchivedRefreshBtn.ForeColor = Color.FromArgb(250, 247, 247);
            ArchivedRefreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            ArchivedRefreshBtn.IconColor = Color.FromArgb(250, 247, 247);
            ArchivedRefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ArchivedRefreshBtn.IconSize = 24;
            ArchivedRefreshBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ArchivedRefreshBtn.Location = new Point(672, 122);
            ArchivedRefreshBtn.Name = "ArchivedRefreshBtn";
            ArchivedRefreshBtn.Size = new Size(32, 31);
            ArchivedRefreshBtn.TabIndex = 21;
            ArchivedRefreshBtn.TextAlign = ContentAlignment.MiddleLeft;
            ArchivedRefreshBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ArchivedRefreshBtn.UseVisualStyleBackColor = true;
            // 
            // ArchivedLogo
            // 
            ArchivedLogo.Image = Properties.Resources._3;
            ArchivedLogo.Location = new Point(97, -8);
            ArchivedLogo.Name = "ArchivedLogo";
            ArchivedLogo.Size = new Size(128, 128);
            ArchivedLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            ArchivedLogo.TabIndex = 18;
            ArchivedLogo.TabStop = false;
            // 
            // ReactivateBtn
            // 
            ReactivateBtn.BackColor = Color.Transparent;
            ReactivateBtn.Cursor = Cursors.Hand;
            ReactivateBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            ReactivateBtn.FlatAppearance.BorderSize = 2;
            ReactivateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            ReactivateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            ReactivateBtn.FlatStyle = FlatStyle.Flat;
            ReactivateBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReactivateBtn.ForeColor = Color.White;
            ReactivateBtn.Location = new Point(559, 407);
            ReactivateBtn.Name = "ReactivateBtn";
            ReactivateBtn.Size = new Size(145, 36);
            ReactivateBtn.TabIndex = 12;
            ReactivateBtn.Text = "REACTIVATE";
            ReactivateBtn.UseVisualStyleBackColor = false;
            ReactivateBtn.Click += ReactivateBtn_Click;
            // 
            // ArchivedAccLbl
            // 
            ArchivedAccLbl.AutoSize = true;
            ArchivedAccLbl.BackColor = Color.Transparent;
            ArchivedAccLbl.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ArchivedAccLbl.ForeColor = Color.FromArgb(250, 247, 247);
            ArchivedAccLbl.Location = new Point(219, 18);
            ArchivedAccLbl.Name = "ArchivedAccLbl";
            ArchivedAccLbl.Size = new Size(406, 52);
            ArchivedAccLbl.TabIndex = 3;
            ArchivedAccLbl.Text = "Archived Accounts";
            ArchivedAccLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArchivedTable
            // 
            ArchivedTable.AllowUserToAddRows = false;
            ArchivedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArchivedTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            ArchivedTable.BorderStyle = BorderStyle.Fixed3D;
            ArchivedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArchivedTable.Location = new Point(39, 159);
            ArchivedTable.Name = "ArchivedTable";
            ArchivedTable.ReadOnly = true;
            ArchivedTable.RowTemplate.Height = 25;
            ArchivedTable.Size = new Size(665, 220);
            ArchivedTable.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 115, 141);
            ClientSize = new Size(804, 511);
            Controls.Add(AccountTabs);
            MaximumSize = new Size(820, 550);
            MinimumSize = new Size(820, 550);
            Name = "AdminForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Morpheus Admin Panel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)PendingTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).EndInit();
            ApprovedPanel.ResumeLayout(false);
            ApprovedPanel.PerformLayout();
            ApprovedSearchPanel.ResumeLayout(false);
            ApprovedSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).EndInit();
            PendingPanel.ResumeLayout(false);
            PendingPanel.PerformLayout();
            PendingSearchPanel.ResumeLayout(false);
            PendingSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusBlueLogo).EndInit();
            AccountTabs.ResumeLayout(false);
            InsertTab.ResumeLayout(false);
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
            PendingTab.ResumeLayout(false);
            ApprovedTab.ResumeLayout(false);
            ArchivedTab.ResumeLayout(false);
            ArchivedPanel.ResumeLayout(false);
            ArchivedPanel.PerformLayout();
            ArchivedSearchPanel.ResumeLayout(false);
            ArchivedSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ArchivedLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ArchivedTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label PendingLabel;
        private Label ApprovedLbl;
        private Button ApproveBtn;
        private Panel ApprovedPanel;
        public DataGridView PendingTable;
        public DataGridView ApprovedTable;
        private Button ArchiveBtn;
        private Panel PendingPanel;
        private LinkLabel AdminLoginLinkedLbl;
        private PictureBox MorpheusLogo2;
        private PictureBox MorpheusBlueLogo;
        private FontAwesome.Sharp.IconButton PendingRefreshBtn;
        private FontAwesome.Sharp.IconButton ApprovedRefreshBtn;
        private TabControl AccountTabs;
        private TabPage ApprovedTab;
        private TabPage PendingTab;
        private TabPage ArchivedTab;
        private Panel ArchivedPanel;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton ArchivedRefreshBtn;
        private PictureBox ArchivedLogo;
        private Button ReactivateBtn;
        private Label ArchivedAccLbl;
        public DataGridView ArchivedTable;
        private Button PendingBtn;
        private Panel PendingSearchPanel;
        private TextBox PendingSearchBox;
        private FontAwesome.Sharp.IconButton PendingSearchBtn;
        private Panel ApprovedSearchPanel;
        private FontAwesome.Sharp.IconButton ApprovedSearchBtn;
        private TextBox ApprovedSearchBox;
        private Panel ArchivedSearchPanel;
        private FontAwesome.Sharp.IconButton ArchivedSearchBtn;
        private TextBox ArchivedSearchBox;
        private TabPage InsertTab;
        private Panel RegiPanel;
        private Label SNMaxChar;
        private Label RegiMailLbl;
        private Panel RegiMailPanel;
        private TextBox RegiMailBox;
        private Label RegiAgeLbl;
        private Label GenderLbl;
        private Panel RegiGenderPanel;
        private ComboBox RegiGenderComboBox;
        private Label RegiCourseLbl;
        private Panel RegiCoursePanel;
        private TextBox RegiCourseBox;
        private Panel RegiNamePanel;
        private TextBox RegiNameBox;
        private Label RegiRPLabel;
        private Label RegiSNLabel;
        private Button CreateBtn;
        private Label RegiPassLabel;
        private Label RegiNameLabel;
        private Label GSLabel;
        private Panel RegiPassPanel;
        private CheckBox RegiShowPass;
        private TextBox RegiPassBox;
        private Panel RegiRPPanel;
        private TextBox RegiRPBox;
        private Panel RegiSNBoxPanel;
        private TextBox RegiSNBox;
        private Panel RegiAgePanel;
        private TextBox RegiAgeBox;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}