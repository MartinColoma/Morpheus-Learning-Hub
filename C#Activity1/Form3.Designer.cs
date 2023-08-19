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
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).BeginInit();
            SuspendLayout();
            // 
            // RTUSealXL
            // 
            RTUSealXL.Dock = DockStyle.Fill;
            RTUSealXL.Image = Properties.Resources.RTU_Facade1_720x720;
            RTUSealXL.Location = new Point(0, 0);
            RTUSealXL.Name = "RTUSealXL";
            RTUSealXL.Size = new Size(704, 681);
            RTUSealXL.SizeMode = PictureBoxSizeMode.CenterImage;
            RTUSealXL.TabIndex = 0;
            RTUSealXL.TabStop = false;
            // 
            // LHHomePage
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 184, 74);
            ClientSize = new Size(704, 681);
            Controls.Add(RTUSealXL);
            Name = "LHHomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learning Hub Home Page";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)RTUSealXL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RTUSealXL;
    }
}