﻿using System;
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
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        public List<string> existingSN = new List<string>();
        public new Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
        private string selectedUN;

        public AdminForm()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += new FormClosingEventHandler(AdminPanel_FormClosing);
            FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //RTULogin rtu = new RTULogin();

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing.
                e.Cancel = true;
                // Hide the form instead of closing it.
                this.Hide();
                LoginForm.instance.Show();

            }
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 270);
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

        public void AddDataGridView(string name, string sn, string rp, string pass, string age, string course, string gender)
        {
            PendingTable.Rows.Add(name, sn, rp, pass, age, course, gender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (ApprovedPanel.Visible)
            {
                ApprovedPanel.Visible = false;
                PendingPanel.Visible = true;
            }

            else
            {
                PendingPanel.Visible = false;
                ApprovedPanel.Visible = true;
            }
        }

        private void PendingLabel_Click(object sender, EventArgs e)
        {
            if (PendingPanel.Visible)
            {
                PendingPanel.Visible = false;
                ApprovedPanel.Visible = true;
            }

            else
            {
                ApprovedPanel.Visible = false;
                PendingPanel.Visible = true;
            }
        }

        private void ApprovedTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Approved Table


        }



        public void AddDataGridView1(string name, string sn, string rp, string pass, string age, string course, string gender)
        {

            ApprovedTable.Rows.Add(name, sn, rp, pass, age, course, gender);
        }

        internal void SetPendingData(string name, string sn, string rp, string password)
        {
            throw new NotImplementedException();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            //approved btn


            if (PendingTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to approve the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in PendingTable.SelectedRows)
                    {
                        string selectedUsername = selectedRow.Cells["PSNColumn"].Value.ToString();

                        if (LoginForm.instance.dictionary.ContainsKey(selectedUsername))
                        {
                            MessageBox.Show("This student already has an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        else
                        {
                            LoginForm.instance.AddUserToDictionary(selectedUsername, (string)selectedRow.Cells["PPassColumn"].Value);

                            DataGridViewRow newRow = new DataGridViewRow();

                            foreach (DataGridViewCell cell in selectedRow.Cells)
                            {
                                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
                            }

                            ApprovedTable.Rows.Add(newRow);
                            PendingTable.Rows.RemoveAt(selectedRow.Index);
                        }
                    }
                    if (PendingPanel.Visible)
                    {
                        PendingPanel.Visible = false;
                        ApprovedPanel.Visible = true;
                    }

                    else
                    {
                        ApprovedPanel.Visible = false;
                        PendingPanel.Visible = true;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult deleteResult = MessageBox.Show("Do you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow selectedRow in PendingTable.SelectedRows)
                        {
                            PendingTable.Rows.RemoveAt(selectedRow.Index);
                        }
                    }
                }
            }




        }

        private void ApprovedDictionary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string dictContents = string.Join(Environment.NewLine, LoginForm.instance.dictionary.Select(kv => $"{kv.Key}: {kv.Value}"));
            MessageBox.Show("Activated Users Dictionary Contents:" + Environment.NewLine + dictContents);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Call this method when a button is clicked to delete the selected row from ApprovedTable
            DeleteSelectedRowFromApprovedTable();
        }

        private void DeleteSelectedRowFromApprovedTable()
        {
            if (ApprovedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in ApprovedTable.SelectedRows)
                    {
                        string selectedUsername = selectedRow.Cells["ASNColumn"].Value.ToString();

                        // Remove the value from the dictionary
                        if (LoginForm.instance.dictionary.ContainsKey(selectedUsername))
                        {
                            LoginForm.instance.dictionary.Remove(selectedUsername);
                        }
                       
                        AddUserToDictionaryOne(selectedUsername, (string)selectedRow.Cells["APassColumn"].Value);
                        ApprovedTable.Rows.RemoveAt(selectedRow.Index);
                        UserForm.instance.Hide();
                    }
                }
            }
        }

        public void AddUserToDictionaryOne(string selectedUN, string values)
        {
            dictionaryOne.Add(selectedUN, values);
        }

        private void AdminLoginLinkedLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Visible)
            {
                LoginForm.instance.Show();

            }
        }

        private void PendingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApprovedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string dictContents = string.Join(Environment.NewLine, dictionaryOne.Select(kv => $"{kv.Key}: {kv.Value}"));
            MessageBox.Show("Delete Users Dictionary Contents:" + Environment.NewLine + dictContents);
        }
    }
}
