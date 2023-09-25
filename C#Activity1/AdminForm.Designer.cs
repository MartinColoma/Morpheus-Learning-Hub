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
            PNameColumn = new DataGridViewTextBoxColumn();
            PAgeColumn = new DataGridViewTextBoxColumn();
            PGenderColumn = new DataGridViewTextBoxColumn();
            PCourseColumn = new DataGridViewTextBoxColumn();
            PSNColumn = new DataGridViewTextBoxColumn();
            PMailColumn = new DataGridViewTextBoxColumn();
            PRPinColumn = new DataGridViewTextBoxColumn();
            PPassColumn = new DataGridViewTextBoxColumn();
            ApprovedTable = new DataGridView();
            ANameColumn = new DataGridViewTextBoxColumn();
            AAgeColumn = new DataGridViewTextBoxColumn();
            AGenderColumn = new DataGridViewTextBoxColumn();
            ACourseColumn = new DataGridViewTextBoxColumn();
            ASNColumn = new DataGridViewTextBoxColumn();
            AMailColumn = new DataGridViewTextBoxColumn();
            ARPInColumn = new DataGridViewTextBoxColumn();
            APassColumn = new DataGridViewTextBoxColumn();
            PendingLabel = new Label();
            ApprovedLbl = new Label();
            ApproveBtn = new Button();
            ApprovedPanel = new Panel();
            linkLabel1 = new LinkLabel();
            MorpheusLogo2 = new PictureBox();
            DeleteBtn = new Button();
            ApprovedDictionary = new LinkLabel();
            PendingPanel = new Panel();
            MorpheusBlueLogo = new PictureBox();
            AdminLoginLinkedLbl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)PendingTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).BeginInit();
            ApprovedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusLogo2).BeginInit();
            PendingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MorpheusBlueLogo).BeginInit();
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
            PendingTable.Columns.AddRange(new DataGridViewColumn[] { PNameColumn, PAgeColumn, PGenderColumn, PCourseColumn, PSNColumn, PMailColumn, PRPinColumn, PPassColumn });
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
            PendingTable.Size = new Size(664, 265);
            PendingTable.TabIndex = 0;
            PendingTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PNameColumn
            // 
            PNameColumn.HeaderText = "Name";
            PNameColumn.Name = "PNameColumn";
            PNameColumn.ReadOnly = true;
            // 
            // PAgeColumn
            // 
            PAgeColumn.HeaderText = "Age";
            PAgeColumn.Name = "PAgeColumn";
            PAgeColumn.ReadOnly = true;
            // 
            // PGenderColumn
            // 
            PGenderColumn.HeaderText = "Gender";
            PGenderColumn.Name = "PGenderColumn";
            PGenderColumn.ReadOnly = true;
            PGenderColumn.Resizable = DataGridViewTriState.True;
            PGenderColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PCourseColumn
            // 
            PCourseColumn.HeaderText = "College Course";
            PCourseColumn.Name = "PCourseColumn";
            PCourseColumn.ReadOnly = true;
            PCourseColumn.Resizable = DataGridViewTriState.True;
            PCourseColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PSNColumn
            // 
            PSNColumn.HeaderText = "Student Number";
            PSNColumn.Name = "PSNColumn";
            PSNColumn.ReadOnly = true;
            // 
            // PMailColumn
            // 
            PMailColumn.HeaderText = "Email";
            PMailColumn.Name = "PMailColumn";
            PMailColumn.ReadOnly = true;
            // 
            // PRPinColumn
            // 
            PRPinColumn.HeaderText = "Recovery Pin";
            PRPinColumn.Name = "PRPinColumn";
            PRPinColumn.ReadOnly = true;
            // 
            // PPassColumn
            // 
            PPassColumn.HeaderText = "Password";
            PPassColumn.Name = "PPassColumn";
            PPassColumn.ReadOnly = true;
            // 
            // ApprovedTable
            // 
            ApprovedTable.AllowUserToAddRows = false;
            ApprovedTable.AllowUserToOrderColumns = true;
            ApprovedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApprovedTable.BackgroundColor = Color.FromArgb(90, 115, 141);
            ApprovedTable.BorderStyle = BorderStyle.Fixed3D;
            ApprovedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ApprovedTable.Columns.AddRange(new DataGridViewColumn[] { ANameColumn, AAgeColumn, AGenderColumn, ACourseColumn, ASNColumn, AMailColumn, ARPInColumn, APassColumn });
            ApprovedTable.Location = new Point(39, 126);
            ApprovedTable.Name = "ApprovedTable";
            ApprovedTable.ReadOnly = true;
            ApprovedTable.RowTemplate.Height = 25;
            ApprovedTable.Size = new Size(664, 265);
            ApprovedTable.TabIndex = 1;
            ApprovedTable.CellContentClick += ApprovedTable_CellContentClick;
            // 
            // ANameColumn
            // 
            ANameColumn.FillWeight = 100.582642F;
            ANameColumn.HeaderText = "Name";
            ANameColumn.Name = "ANameColumn";
            ANameColumn.ReadOnly = true;
            // 
            // AAgeColumn
            // 
            AAgeColumn.HeaderText = "Age";
            AAgeColumn.Name = "AAgeColumn";
            AAgeColumn.ReadOnly = true;
            // 
            // AGenderColumn
            // 
            AGenderColumn.HeaderText = "Gender";
            AGenderColumn.Name = "AGenderColumn";
            AGenderColumn.ReadOnly = true;
            AGenderColumn.Resizable = DataGridViewTriState.True;
            AGenderColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ACourseColumn
            // 
            ACourseColumn.HeaderText = "College Course";
            ACourseColumn.Name = "ACourseColumn";
            ACourseColumn.ReadOnly = true;
            // 
            // ASNColumn
            // 
            ASNColumn.FillWeight = 99.37547F;
            ASNColumn.HeaderText = "Student Number";
            ASNColumn.Name = "ASNColumn";
            ASNColumn.ReadOnly = true;
            // 
            // AMailColumn
            // 
            AMailColumn.HeaderText = "Email";
            AMailColumn.Name = "AMailColumn";
            AMailColumn.ReadOnly = true;
            // 
            // ARPInColumn
            // 
            ARPInColumn.FillWeight = 100.544395F;
            ARPInColumn.HeaderText = "Recovery Pin";
            ARPInColumn.Name = "ARPInColumn";
            ARPInColumn.ReadOnly = true;
            // 
            // APassColumn
            // 
            APassColumn.FillWeight = 99.49749F;
            APassColumn.HeaderText = "Password";
            APassColumn.Name = "APassColumn";
            APassColumn.ReadOnly = true;
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
            ApproveBtn.Location = new Point(589, 399);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 31);
            ApproveBtn.TabIndex = 10;
            ApproveBtn.Text = "APPROVE";
            ApproveBtn.UseVisualStyleBackColor = false;
            ApproveBtn.Click += ApproveBtn_Click;
            // 
            // ApprovedPanel
            // 
            ApprovedPanel.Controls.Add(linkLabel1);
            ApprovedPanel.Controls.Add(MorpheusLogo2);
            ApprovedPanel.Controls.Add(DeleteBtn);
            ApprovedPanel.Controls.Add(ApprovedDictionary);
            ApprovedPanel.Controls.Add(ApprovedLbl);
            ApprovedPanel.Controls.Add(ApprovedTable);
            ApprovedPanel.Location = new Point(30, 9);
            ApprovedPanel.Name = "ApprovedPanel";
            ApprovedPanel.Size = new Size(747, 476);
            ApprovedPanel.TabIndex = 11;
            ApprovedPanel.Paint += ApprovedPanel_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(250, 247, 247);
            linkLabel1.Location = new Point(40, 430);
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
            ApprovedDictionary.Location = new Point(39, 404);
            ApprovedDictionary.Name = "ApprovedDictionary";
            ApprovedDictionary.Size = new Size(261, 16);
            ApprovedDictionary.TabIndex = 11;
            ApprovedDictionary.TabStop = true;
            ApprovedDictionary.Text = "Dictionary of Approved Accounts";
            ApprovedDictionary.LinkClicked += ApprovedDictionary_LinkClicked;
            // 
            // PendingPanel
            // 
            PendingPanel.Controls.Add(ApproveBtn);
            PendingPanel.Controls.Add(PendingLabel);
            PendingPanel.Controls.Add(PendingTable);
            PendingPanel.Controls.Add(MorpheusBlueLogo);
            PendingPanel.Location = new Point(30, 12);
            PendingPanel.Name = "PendingPanel";
            PendingPanel.Size = new Size(744, 473);
            PendingPanel.TabIndex = 13;
            PendingPanel.Paint += PendingPanel_Paint;
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
            // AdminLoginLinkedLbl
            // 
            AdminLoginLinkedLbl.ActiveLinkColor = Color.FromArgb(24, 79, 144);
            AdminLoginLinkedLbl.AutoSize = true;
            AdminLoginLinkedLbl.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AdminLoginLinkedLbl.LinkBehavior = LinkBehavior.HoverUnderline;
            AdminLoginLinkedLbl.LinkColor = Color.White;
            AdminLoginLinkedLbl.Location = new Point(70, 470);
            AdminLoginLinkedLbl.Name = "AdminLoginLinkedLbl";
            AdminLoginLinkedLbl.Size = new Size(125, 15);
            AdminLoginLinkedLbl.TabIndex = 14;
            AdminLoginLinkedLbl.TabStop = true;
            AdminLoginLinkedLbl.Text = "Open Login Page...";
            AdminLoginLinkedLbl.LinkClicked += AdminLoginLinkedLbl_LinkClicked;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 115, 141);
            ClientSize = new Size(805, 511);
            Controls.Add(AdminLoginLinkedLbl);
            Controls.Add(PendingPanel);
            Controls.Add(ApprovedPanel);
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
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn PNameColumn;
        private DataGridViewTextBoxColumn PAgeColumn;
        private DataGridViewTextBoxColumn PGenderColumn;
        private DataGridViewTextBoxColumn PCourseColumn;
        private DataGridViewTextBoxColumn PSNColumn;
        private DataGridViewTextBoxColumn PMailColumn;
        private DataGridViewTextBoxColumn PRPinColumn;
        private DataGridViewTextBoxColumn PPassColumn;
        private DataGridViewTextBoxColumn ANameColumn;
        private DataGridViewTextBoxColumn AAgeColumn;
        private DataGridViewTextBoxColumn AGenderColumn;
        private DataGridViewTextBoxColumn ACourseColumn;
        private DataGridViewTextBoxColumn ASNColumn;
        private DataGridViewTextBoxColumn AMailColumn;
        private DataGridViewTextBoxColumn ARPInColumn;
        private DataGridViewTextBoxColumn APassColumn;
    }
}