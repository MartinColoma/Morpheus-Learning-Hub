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
            AdminLoginLinkedLbl = new LinkLabel();
            ApprovedRefreshBtn = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            MorpheusLogo2 = new PictureBox();
            DeleteBtn = new Button();
            ApprovedDictionary = new LinkLabel();
            PendingPanel = new Panel();
            PendingRefreshBtn = new FontAwesome.Sharp.IconButton();
            MorpheusBlueLogo = new PictureBox();
            PendingApprovedTabs = new TabControl();
            PendingTab = new TabPage();
            ApprovedTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)PendingTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).BeginInit();
            ApprovedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).BeginInit();
            PendingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusBlueLogo).BeginInit();
            PendingApprovedTabs.SuspendLayout();
            PendingTab.SuspendLayout();
            ApprovedTab.SuspendLayout();
            SuspendLayout();
            // 
            // PendingTable
            // 
            PendingTable.AllowUserToAddRows = false;
            PendingTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PendingTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PendingTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            PendingTable.BorderStyle = BorderStyle.Fixed3D;
            PendingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingTable.Location = new Point(39, 126);
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
            ApprovedTable.AllowUserToOrderColumns = true;
            ApprovedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApprovedTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            ApprovedTable.BorderStyle = BorderStyle.Fixed3D;
            ApprovedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ApprovedTable.Location = new Point(39, 126);
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
            ApproveBtn.Location = new Point(589, 370);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 31);
            ApproveBtn.TabIndex = 10;
            ApproveBtn.Text = "APPROVE";
            ApproveBtn.UseVisualStyleBackColor = false;
            ApproveBtn.Click += ApproveBtn_Click;
            // 
            // ApprovedPanel
            // 
            ApprovedPanel.Controls.Add(AdminLoginLinkedLbl);
            ApprovedPanel.Controls.Add(ApprovedRefreshBtn);
            ApprovedPanel.Controls.Add(linkLabel1);
            ApprovedPanel.Controls.Add(MorpheusLogo2);
            ApprovedPanel.Controls.Add(DeleteBtn);
            ApprovedPanel.Controls.Add(ApprovedDictionary);
            ApprovedPanel.Controls.Add(ApprovedLbl);
            ApprovedPanel.Controls.Add(ApprovedTable);
            ApprovedPanel.Location = new Point(26, 6);
            ApprovedPanel.Name = "ApprovedPanel";
            ApprovedPanel.Size = new Size(747, 476);
            ApprovedPanel.TabIndex = 11;
            ApprovedPanel.Paint += ApprovedPanel_Paint;
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
            ApprovedRefreshBtn.Location = new Point(607, 89);
            ApprovedRefreshBtn.Name = "ApprovedRefreshBtn";
            ApprovedRefreshBtn.Size = new Size(106, 31);
            ApprovedRefreshBtn.TabIndex = 21;
            ApprovedRefreshBtn.Text = "REFRESH";
            ApprovedRefreshBtn.TextAlign = ContentAlignment.MiddleLeft;
            ApprovedRefreshBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ApprovedRefreshBtn.UseVisualStyleBackColor = true;
            ApprovedRefreshBtn.Click += ApprovedRefreshBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(250, 247, 247);
            linkLabel1.Location = new Point(40, 389);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(247, 16);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dictionary of Deleted Accounts";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Transparent;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 52, 64);
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 247, 247);
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 177, 217);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(589, 397);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(114, 31);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ApprovedDictionary
            // 
            ApprovedDictionary.ActiveLinkColor = Color.Black;
            ApprovedDictionary.AutoSize = true;
            ApprovedDictionary.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ApprovedDictionary.LinkBehavior = LinkBehavior.HoverUnderline;
            ApprovedDictionary.LinkColor = Color.FromArgb(250, 247, 247);
            ApprovedDictionary.Location = new Point(39, 363);
            ApprovedDictionary.Name = "ApprovedDictionary";
            ApprovedDictionary.Size = new Size(261, 16);
            ApprovedDictionary.TabIndex = 11;
            ApprovedDictionary.TabStop = true;
            ApprovedDictionary.Text = "Dictionary of Approved Accounts";
            ApprovedDictionary.LinkClicked += ApprovedDictionary_LinkClicked;
            // 
            // PendingPanel
            // 
            PendingPanel.Controls.Add(PendingRefreshBtn);
            PendingPanel.Controls.Add(ApproveBtn);
            PendingPanel.Controls.Add(PendingLabel);
            PendingPanel.Controls.Add(PendingTable);
            PendingPanel.Controls.Add(MorpheusBlueLogo);
            PendingPanel.Location = new Point(36, 7);
            PendingPanel.Name = "PendingPanel";
            PendingPanel.Size = new Size(744, 473);
            PendingPanel.TabIndex = 13;
            PendingPanel.Paint += PendingPanel_Paint;
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
            PendingRefreshBtn.Location = new Point(608, 89);
            PendingRefreshBtn.Name = "PendingRefreshBtn";
            PendingRefreshBtn.Size = new Size(106, 31);
            PendingRefreshBtn.TabIndex = 20;
            PendingRefreshBtn.Text = "REFRESH";
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
            // PendingApprovedTabs
            // 
            PendingApprovedTabs.Controls.Add(PendingTab);
            PendingApprovedTabs.Controls.Add(ApprovedTab);
            PendingApprovedTabs.Cursor = Cursors.Hand;
            PendingApprovedTabs.Dock = DockStyle.Fill;
            PendingApprovedTabs.HotTrack = true;
            PendingApprovedTabs.Location = new Point(0, 0);
            PendingApprovedTabs.Name = "PendingApprovedTabs";
            PendingApprovedTabs.SelectedIndex = 0;
            PendingApprovedTabs.Size = new Size(805, 511);
            PendingApprovedTabs.TabIndex = 30;
            // 
            // PendingTab
            // 
            PendingTab.BackColor = Color.FromArgb(90, 115, 141);
            PendingTab.Controls.Add(PendingPanel);
            PendingTab.Location = new Point(4, 24);
            PendingTab.Name = "PendingTab";
            PendingTab.Padding = new Padding(3);
            PendingTab.Size = new Size(797, 483);
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
            ApprovedTab.Size = new Size(797, 483);
            ApprovedTab.TabIndex = 1;
            ApprovedTab.Text = "Approved Account";
            ApprovedTab.Click += ApprovedTab_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 115, 141);
            ClientSize = new Size(805, 511);
            Controls.Add(PendingApprovedTabs);
            Name = "AdminForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Admin Panel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)PendingTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).EndInit();
            ApprovedPanel.ResumeLayout(false);
            ApprovedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).EndInit();
            PendingPanel.ResumeLayout(false);
            PendingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusBlueLogo).EndInit();
            PendingApprovedTabs.ResumeLayout(false);
            PendingTab.ResumeLayout(false);
            ApprovedTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label PendingLabel;
        private Label ApprovedLbl;
        private Button ApproveBtn;
        private Panel ApprovedPanel;
        public DataGridView PendingTable;
        public DataGridView ApprovedTable;
        private LinkLabel ApprovedDictionary;
        private Button DeleteBtn;
        private Panel PendingPanel;
        private LinkLabel AdminLoginLinkedLbl;
        private PictureBox MorpheusLogo2;
        private PictureBox MorpheusBlueLogo;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton PendingRefreshBtn;
        private FontAwesome.Sharp.IconButton ApprovedRefreshBtn;
        private TabControl PendingApprovedTabs;
        private TabPage ApprovedTab;
        private TabPage PendingTab;
    }
}