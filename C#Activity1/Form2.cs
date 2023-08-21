using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace C_Activity1
{
    public partial class AdminPanel : Form
    {
        public static AdminPanel instance;
        public List<string> existingSN = new List<string>();

        public AdminPanel()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing.
                e.Cancel = true;
                // Hide the form instead of closing it.
                this.Hide();
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pending Table


            // Assuming your source data grid is named "PendingTable"

            DataGridViewRow selectedRow = PendingTable.CurrentRow;


            // Transfer data to the destination data grid


            // Assuming your destination data grid is named "ApprovedTable"

            ApprovedTable.Rows.Clear();
            // Clear previous data



            // Create a new row for the destination data grid and populate it with the values from the selected row

            DataGridViewRow newRow = new DataGridViewRow();

            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
            }

            ApprovedTable.Rows.Add(newRow);

        }

        public void AddDataGridView(string name, string sn, string rp, string pass)
        {
            PendingTable.Rows.Add(name, sn, rp, pass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PendingLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApprovedTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Approved Table

          
        }

        

        public void AddDataGridView1(string name, string sn, string rp, string pass)
        {

            ApprovedTable.Rows.Add(name, sn, rp, pass);
        }

        internal void SetPendingData(string name, string sn, string rp, string password)
        {
            throw new NotImplementedException();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if (PendingTable.SelectedRows.Count > 0)
            {
                // Loop through selected rows
                foreach (DataGridViewRow selectedRow in PendingTable.SelectedRows)
                {
                    string selectedUsername = selectedRow.Cells["PSNColumn"].Value.ToString();

                    // Check for duplicate username in the dictionary
                    if (RTULogin.instance.dictionary.ContainsKey(selectedUsername))
                    {
                        MessageBox.Show("This student already had an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // Skip to the next selected row
                    }
                    else
                    {
                        // Add the user to the dictionary
                        RTULogin.instance.AddUserToDictionary(selectedUsername, (string)selectedRow.Cells["PPassColumn"].Value);

                        // Create a new row for the ApprovedTable
                        DataGridViewRow newRow = new DataGridViewRow();

                        // Loop through each cell in the selected row and add its value to the new row
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
                        }

                        // Add the new row to the ApprovedTable
                        ApprovedTable.Rows.Add(newRow);

                        // Remove the selected row from the PendingTable
                        PendingTable.Rows.RemoveAt(selectedRow.Index);
                    }
                }
            }





        }

        private void ApprovedDictionary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string dictContents = string.Join(Environment.NewLine, RTULogin.instance.dictionary.Select(kv => $"{kv.Key}: {kv.Value}"));
            MessageBox.Show("ActivatedUsers Dictionary Contents:" + Environment.NewLine + dictContents);
        }
    }
}
