namespace C_Activity1
{
    partial class AdminPanel
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
            PendingTable = new DataGridView();
            PNameColumn = new DataGridViewTextBoxColumn();
            PSNColumn = new DataGridViewTextBoxColumn();
            PRPinColumn = new DataGridViewTextBoxColumn();
            PPassColumn = new DataGridViewTextBoxColumn();
            ApprovedTable = new DataGridView();
            ANameColumn = new DataGridViewTextBoxColumn();
            ASNColumn = new DataGridViewTextBoxColumn();
            ARPInColumn = new DataGridViewTextBoxColumn();
            APassColumn = new DataGridViewTextBoxColumn();
            PendingLabel = new Label();
            ApprovedLbl = new Label();
            ApproveBtn = new Button();
            ApprovedPanel = new Panel();
            DeleteBtn = new Button();
            ApprovedDictionary = new LinkLabel();
            PendingPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)PendingTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).BeginInit();
            ApprovedPanel.SuspendLayout();
            PendingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PendingTable
            // 
            PendingTable.AllowUserToOrderColumns = true;
            PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PendingTable.BackgroundColor = Color.FromArgb(249, 184, 74);
            PendingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingTable.Columns.AddRange(new DataGridViewColumn[] { PNameColumn, PSNColumn, PRPinColumn, PPassColumn });
            PendingTable.Location = new Point(39, 71);
            PendingTable.Name = "PendingTable";
            PendingTable.ReadOnly = true;
            PendingTable.RowTemplate.Height = 25;
            PendingTable.Size = new Size(441, 265);
            PendingTable.TabIndex = 0;
            PendingTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PNameColumn
            // 
            PNameColumn.HeaderText = "Name";
            PNameColumn.Name = "PNameColumn";
            PNameColumn.ReadOnly = true;
            // 
            // PSNColumn
            // 
            PSNColumn.HeaderText = "Student Number";
            PSNColumn.Name = "PSNColumn";
            PSNColumn.ReadOnly = true;
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
            ApprovedTable.AllowUserToOrderColumns = true;
            ApprovedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApprovedTable.BackgroundColor = Color.FromArgb(249, 184, 74);
            ApprovedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ApprovedTable.Columns.AddRange(new DataGridViewColumn[] { ANameColumn, ASNColumn, ARPInColumn, APassColumn });
            ApprovedTable.Location = new Point(39, 73);
            ApprovedTable.Name = "ApprovedTable";
            ApprovedTable.ReadOnly = true;
            ApprovedTable.RowTemplate.Height = 25;
            ApprovedTable.Size = new Size(441, 265);
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
            // ASNColumn
            // 
            ASNColumn.FillWeight = 99.37547F;
            ASNColumn.HeaderText = "Student Number";
            ASNColumn.Name = "ASNColumn";
            ASNColumn.ReadOnly = true;
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
            PendingLabel.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PendingLabel.ForeColor = Color.FromArgb(24, 79, 144);
            PendingLabel.Location = new Point(163, 25);
            PendingLabel.Name = "PendingLabel";
            PendingLabel.Size = new Size(232, 27);
            PendingLabel.TabIndex = 2;
            PendingLabel.Text = "Pending Accounts";
            PendingLabel.TextAlign = ContentAlignment.MiddleCenter;
            PendingLabel.Click += PendingLabel_Click;
            // 
            // ApprovedLbl
            // 
            ApprovedLbl.AutoSize = true;
            ApprovedLbl.BackColor = Color.Transparent;
            ApprovedLbl.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ApprovedLbl.ForeColor = Color.FromArgb(24, 79, 144);
            ApprovedLbl.Location = new Point(138, 27);
            ApprovedLbl.Name = "ApprovedLbl";
            ApprovedLbl.Size = new Size(255, 27);
            ApprovedLbl.TabIndex = 3;
            ApprovedLbl.Text = "Approved Accounts";
            ApprovedLbl.TextAlign = ContentAlignment.MiddleCenter;
            ApprovedLbl.Click += label1_Click;
            // 
            // ApproveBtn
            // 
            ApproveBtn.BackColor = Color.FromArgb(249, 184, 74);
            ApproveBtn.Cursor = Cursors.Hand;
            ApproveBtn.FlatAppearance.BorderColor = Color.FromArgb(24, 79, 144);
            ApproveBtn.FlatAppearance.BorderSize = 2;
            ApproveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 79, 144);
            ApproveBtn.FlatStyle = FlatStyle.Flat;
            ApproveBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            ApproveBtn.ForeColor = Color.White;
            ApproveBtn.Location = new Point(366, 342);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 31);
            ApproveBtn.TabIndex = 10;
            ApproveBtn.Text = "APPROVE";
            ApproveBtn.UseVisualStyleBackColor = false;
            ApproveBtn.Click += ApproveBtn_Click;
            // 
            // ApprovedPanel
            // 
            ApprovedPanel.Controls.Add(DeleteBtn);
            ApprovedPanel.Controls.Add(ApprovedDictionary);
            ApprovedPanel.Controls.Add(ApprovedLbl);
            ApprovedPanel.Controls.Add(ApprovedTable);
            ApprovedPanel.Location = new Point(31, 55);
            ApprovedPanel.Name = "ApprovedPanel";
            ApprovedPanel.Size = new Size(521, 412);
            ApprovedPanel.TabIndex = 11;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(249, 184, 74);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderColor = Color.FromArgb(24, 79, 144);
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 79, 144);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(366, 344);
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
            ApprovedDictionary.LinkColor = Color.FromArgb(24, 79, 144);
            ApprovedDictionary.Location = new Point(39, 351);
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
            PendingPanel.Location = new Point(31, 55);
            PendingPanel.Name = "PendingPanel";
            PendingPanel.Size = new Size(518, 412);
            PendingPanel.TabIndex = 13;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 184, 74);
            ClientSize = new Size(582, 511);
            Controls.Add(PendingPanel);
            Controls.Add(ApprovedPanel);
            Name = "AdminPanel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTU Admin Panel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)PendingTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).EndInit();
            ApprovedPanel.ResumeLayout(false);
            ApprovedPanel.PerformLayout();
            PendingPanel.ResumeLayout(false);
            PendingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label PendingLabel;
        private Label ApprovedLbl;
        private DataGridViewTextBoxColumn PNameColumn;
        private DataGridViewTextBoxColumn PSNColumn;
        private DataGridViewTextBoxColumn PRPinColumn;
        private DataGridViewTextBoxColumn PPassColumn;
        private DataGridViewTextBoxColumn ANameColumn;
        private DataGridViewTextBoxColumn ASNColumn;
        private DataGridViewTextBoxColumn ARPInColumn;
        private DataGridViewTextBoxColumn APassColumn;
        private Button ApproveBtn;
        private Panel ApprovedPanel;
        public DataGridView PendingTable;
        public DataGridView ApprovedTable;
        private LinkLabel ApprovedDictionary;
        private Button DeleteBtn;
        private Panel PendingPanel;
    }
}