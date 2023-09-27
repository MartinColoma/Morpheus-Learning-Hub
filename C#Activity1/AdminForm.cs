using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private MySqlConnection conn;

        public List<string> existingSN = new List<string>();
        public new Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
        private string selectedUN;

        public AdminForm()
        {
            InitializeComponent();
            instance = this;
            string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
            conn = new MySqlConnection(mysqlconn);

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
                
                DialogResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm.instance.Show();

                }


            }
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 270);
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming your source data grid is named "PendingTable"
            DataGridViewRow selectedRow = PendingTable.CurrentRow;

            // Transfer data to the destination data grid
            ApprovedTable.Rows.Clear();
            // Clear previous data

            // Create a new row for the destination data grid and populate it with the values from the selected row
            DataGridViewRow newRow = new DataGridViewRow();

            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
            }

            // Add the new row to the "ApprovedTable"
            ApprovedTable.Rows.Add(newRow);

            // Here, you can also insert the data into the database
            InsertDataIntoDatabase(selectedRow);
        }

        // Function to insert data into the database
        private void InsertDataIntoDatabase(DataGridViewRow selectedRow)
        {
            try
            {
                string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
                using (conn)
                {
                    conn.Open();

                    // Assuming you have a table named "ApprovedData" in your database
                    string insertQuery = "INSERT INTO approveddb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin) VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @RecoveryPin)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Name", selectedRow.Cells["PNameColumn"].Value);
                        command.Parameters.AddWithValue("@Age", selectedRow.Cells["PAgeColumn"].Value);
                        command.Parameters.AddWithValue("@Gender", selectedRow.Cells["PGenderColumn"].Value);
                        command.Parameters.AddWithValue("@Course", selectedRow.Cells["PCourseColumn"].Value);
                        command.Parameters.AddWithValue("@Email", selectedRow.Cells["PMailColumn"].Value);
                        command.Parameters.AddWithValue("@StudNum", selectedRow.Cells["PSNColumn"].Value);
                        command.Parameters.AddWithValue("@RecoveryPin", selectedRow.Cells["PRPinColumn"].Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any database-related errors here
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        public void AddDataGridView(string name, string sn, string rp, string pass, string age, string course, string gender, string mail)
        {
            PendingTable.Rows.Add(name, sn, rp, pass, age, course, gender, mail);
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



        public void AddDataGridView1(string name, string sn, string rp, string pass, string age, string course, string gender, string mail)
        {

            ApprovedTable.Rows.Add(name, sn, rp, pass, age, course, gender, mail);
        }

        internal void SetPendingData(string name, string sn, string rp, string password)
        {
            throw new NotImplementedException();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected in PendingTable
            if (PendingTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to approve the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
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
                            // Insert data into the database
                            InsertDataIntoDatabase(selectedRow);

                            // Clone the selected row and add it to ApprovedTable
                            DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
                            foreach (DataGridViewCell cell in selectedRow.Cells)
                            {
                                newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                            }
                            ApprovedTable.Rows.Add(newRow);

                            // Remove the selected row from PendingTable
                            PendingTable.Rows.Remove(selectedRow);
                        }
                    }

                    // Toggle visibility of panels
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
