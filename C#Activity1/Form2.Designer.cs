﻿namespace C_Activity1
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
            label1 = new Label();
            ApproveBtn = new Button();
            TablePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)PendingTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).BeginInit();
            TablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // PendingTable
            // 
            PendingTable.AllowUserToOrderColumns = true;
            PendingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingTable.Columns.AddRange(new DataGridViewColumn[] { PNameColumn, PSNColumn, PRPinColumn, PPassColumn });
            PendingTable.Location = new Point(38, 73);
            PendingTable.Name = "PendingTable";
            PendingTable.ReadOnly = true;
            PendingTable.RowTemplate.Height = 25;
            PendingTable.Size = new Size(442, 265);
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
            ApprovedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ApprovedTable.Columns.AddRange(new DataGridViewColumn[] { ANameColumn, ASNColumn, ARPInColumn, APassColumn });
            ApprovedTable.Location = new Point(523, 73);
            ApprovedTable.Name = "ApprovedTable";
            ApprovedTable.ReadOnly = true;
            ApprovedTable.RowTemplate.Height = 25;
            ApprovedTable.Size = new Size(441, 265);
            ApprovedTable.TabIndex = 1;
            ApprovedTable.CellContentClick += ApprovedTable_CellContentClick;
            // 
            // ANameColumn
            // 
            ANameColumn.HeaderText = "Name";
            ANameColumn.Name = "ANameColumn";
            ANameColumn.ReadOnly = true;
            // 
            // ASNColumn
            // 
            ASNColumn.HeaderText = "Student Number";
            ASNColumn.Name = "ASNColumn";
            ASNColumn.ReadOnly = true;
            // 
            // ARPInColumn
            // 
            ARPInColumn.HeaderText = "Recovery Pin";
            ARPInColumn.Name = "ARPInColumn";
            ARPInColumn.ReadOnly = true;
            // 
            // APassColumn
            // 
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
            PendingLabel.Location = new Point(149, 31);
            PendingLabel.Name = "PendingLabel";
            PendingLabel.Size = new Size(232, 27);
            PendingLabel.TabIndex = 2;
            PendingLabel.Text = "Pending Accounts";
            PendingLabel.TextAlign = ContentAlignment.MiddleCenter;
            PendingLabel.Click += PendingLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 79, 144);
            label1.Location = new Point(635, 31);
            label1.Name = "label1";
            label1.Size = new Size(255, 27);
            label1.TabIndex = 3;
            label1.Text = "Approved Accounts";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            ApproveBtn.Location = new Point(366, 344);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 31);
            ApproveBtn.TabIndex = 10;
            ApproveBtn.Text = "APPROVE";
            ApproveBtn.UseVisualStyleBackColor = false;
            // 
            // TablePanel
            // 
            TablePanel.Controls.Add(ApproveBtn);
            TablePanel.Controls.Add(label1);
            TablePanel.Controls.Add(PendingLabel);
            TablePanel.Controls.Add(ApprovedTable);
            TablePanel.Controls.Add(PendingTable);
            TablePanel.Location = new Point(31, 55);
            TablePanel.Name = "TablePanel";
            TablePanel.Size = new Size(1008, 412);
            TablePanel.TabIndex = 11;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 184, 74);
            ClientSize = new Size(1064, 511);
            Controls.Add(TablePanel);
            Name = "AdminPanel";
            ShowIcon = false;
            Text = "Admin Panel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)PendingTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ApprovedTable).EndInit();
            TablePanel.ResumeLayout(false);
            TablePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PendingTable;
        private DataGridView ApprovedTable;
        private Label PendingLabel;
        private Label label1;
        private DataGridViewTextBoxColumn PNameColumn;
        private DataGridViewTextBoxColumn PSNColumn;
        private DataGridViewTextBoxColumn PRPinColumn;
        private DataGridViewTextBoxColumn PPassColumn;
        private DataGridViewTextBoxColumn ANameColumn;
        private DataGridViewTextBoxColumn ASNColumn;
        private DataGridViewTextBoxColumn ARPInColumn;
        private DataGridViewTextBoxColumn APassColumn;
        private Button ApproveBtn;
        private Panel TablePanel;
    }
}