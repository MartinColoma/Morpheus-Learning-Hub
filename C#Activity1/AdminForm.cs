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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace C_Activity1
{
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        public static string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlconn);

        public List<string> existingSN = new List<string>();
        public new Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
        private string selectedUN;

        public AdminForm()
        {
            InitializeComponent();
            instance = this;
            //string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
            //conn = new MySqlConnection(mysqlconn);

            this.FormClosing += new FormClosingEventHandler(AdminPanel_FormClosing);
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {

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
            LoadPendingDB();
            LoadApprovedDB();
            LoadArchivedDB();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Assuming your source data grid is named "PendingTable"
            //DataGridViewRow selectedRow = PendingTable.CurrentRow;
            //ApprovedTable.Rows.Clear();

            //// Here, you can also insert the data into the database
            //InsertIntoApprovedDB(selectedRow);
        }

        public void LoadPendingDB()
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM `mpendingdb`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                //DataTable dataTable = new DataTable();
                System.Data.DataTable dataTable = new System.Data.DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                    PendingTable.DataSource = dataTable;
                    PendingTable.Columns[8].Visible = false; //hashedpass
                    PendingTable.Columns[9].Visible = false; //fixedsalt
                    PendingTable.Columns[10].Visible = false; //perusersalt
                    PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void LoadApprovedDB()
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM `mapproveddb`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                //DataTable dataTable = new DataTable();
                System.Data.DataTable dataTable = new System.Data.DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                    ApprovedTable.DataSource = dataTable;
                    ApprovedTable.Columns[8].Visible = false; //hashedpass
                    ApprovedTable.Columns[9].Visible = false; //fixedsalt
                    ApprovedTable.Columns[10].Visible = false; //perusersalt
                    ApprovedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void LoadArchivedDB()
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM `marchiveddb`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                //DataTable dataTable = new DataTable();
                System.Data.DataTable dataTable = new System.Data.DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                    ArchivedTable.DataSource = dataTable;
                    ArchivedTable.Columns[8].Visible = false; //hashedpass
                    ArchivedTable.Columns[9].Visible = false; //fixedsalt
                    ArchivedTable.Columns[10].Visible = false; //perusersalt
                    PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        // Function to insert data into the database
        private void InsertIntoApprovedDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(mysqlconn);
                connection.Open();

                // Assuming the order of columns in the DataGridView matches the order of columns in the database table
                using (MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO mapproveddb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                    "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @UserID, @RecoveryPin, @Password, @FixedSalt, @PerUserSalt)", connection))
                {
                    // Assuming you have a 'selectedRow' object containing the data to be inserted
                    insertCommand.Parameters.AddWithValue("@Name", selectedRow.Cells[0].Value); // Replace 0 with the index of the Name column
                    insertCommand.Parameters.AddWithValue("@Age", selectedRow.Cells[1].Value); // Replace 1 with the index of the Age column
                    insertCommand.Parameters.AddWithValue("@Gender", selectedRow.Cells[2].Value); // Replace 2 with the index of the Gender column
                    insertCommand.Parameters.AddWithValue("@Course", selectedRow.Cells[3].Value); // Replace 3 with the index of the Course column
                    insertCommand.Parameters.AddWithValue("@Email", selectedRow.Cells[4].Value); // Replace 4 with the index of the Email column
                    insertCommand.Parameters.AddWithValue("@StudNum", selectedRow.Cells[5].Value); // Replace 5 with the index of the StudNum column

                    // You need to provide values for the following parameters as well
                    insertCommand.Parameters.AddWithValue("@UserID", selectedRow.Cells[6].Value); // Replace 6 with the index of the UserID column
                    insertCommand.Parameters.AddWithValue("@RecoveryPin", selectedRow.Cells[7].Value); // Replace 7 with the index of the RecoveryPin column
                    insertCommand.Parameters.AddWithValue("@Password", selectedRow.Cells[8].Value); // Replace 8 with the index of the PassHashed column
                    insertCommand.Parameters.AddWithValue("@FixedSalt", selectedRow.Cells[9].Value); // Replace 9 with the index of the PassFixNa column
                    insertCommand.Parameters.AddWithValue("@PerUserSalt", selectedRow.Cells[10].Value); // Replace 10 with the index of the PassPerUserNa column

                    // Execute the insertion query
                    insertCommand.ExecuteNonQuery();


                }
                string deletequery = "DELETE FROM mpendingdb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account has been approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student account row match found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        private void InsertIntoArchivedDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(mysqlconn);
                connection.Open();

                // Assuming the order of columns in the DataGridView matches the order of columns in the database table
                using (MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO marchiveddb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                    "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @UserID, @RecoveryPin, @Password, @FixedSalt, @PerUserSalt)", connection))
                {
                    // Assuming you have a 'selectedRow' object containing the data to be inserted
                    insertCommand.Parameters.AddWithValue("@Name", selectedRow.Cells[0].Value); // Replace 0 with the index of the Name column
                    insertCommand.Parameters.AddWithValue("@Age", selectedRow.Cells[1].Value); // Replace 1 with the index of the Age column
                    insertCommand.Parameters.AddWithValue("@Gender", selectedRow.Cells[2].Value); // Replace 2 with the index of the Gender column
                    insertCommand.Parameters.AddWithValue("@Course", selectedRow.Cells[3].Value); // Replace 3 with the index of the Course column
                    insertCommand.Parameters.AddWithValue("@Email", selectedRow.Cells[4].Value); // Replace 4 with the index of the Email column
                    insertCommand.Parameters.AddWithValue("@StudNum", selectedRow.Cells[5].Value); // Replace 5 with the index of the StudNum column

                    // You need to provide values for the following parameters as well
                    insertCommand.Parameters.AddWithValue("@UserID", selectedRow.Cells[6].Value); // Replace 6 with the index of the UserID column
                    insertCommand.Parameters.AddWithValue("@RecoveryPin", selectedRow.Cells[7].Value); // Replace 7 with the index of the RecoveryPin column
                    insertCommand.Parameters.AddWithValue("@Password", selectedRow.Cells[8].Value); // Replace 8 with the index of the PassHashed column
                    insertCommand.Parameters.AddWithValue("@FixedSalt", selectedRow.Cells[9].Value); // Replace 9 with the index of the PassFixNa column
                    insertCommand.Parameters.AddWithValue("@PerUserSalt", selectedRow.Cells[10].Value); // Replace 10 with the index of the PassPerUserNa column

                    // Execute the insertion query
                    insertCommand.ExecuteNonQuery();


                }
                string deletequery = "DELETE FROM mapproveddb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account has been archived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student account row match found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        private void ReinsertIntoApprovedDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(mysqlconn);
                connection.Open();

                // Assuming the order of columns in the DataGridView matches the order of columns in the database table
                using (MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO mapproveddb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                    "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @UserID, @RecoveryPin, @Password, @FixedSalt, @PerUserSalt)", connection))
                {
                    // Assuming you have a 'selectedRow' object containing the data to be inserted
                    insertCommand.Parameters.AddWithValue("@Name", selectedRow.Cells[0].Value); // Replace 0 with the index of the Name column
                    insertCommand.Parameters.AddWithValue("@Age", selectedRow.Cells[1].Value); // Replace 1 with the index of the Age column
                    insertCommand.Parameters.AddWithValue("@Gender", selectedRow.Cells[2].Value); // Replace 2 with the index of the Gender column
                    insertCommand.Parameters.AddWithValue("@Course", selectedRow.Cells[3].Value); // Replace 3 with the index of the Course column
                    insertCommand.Parameters.AddWithValue("@Email", selectedRow.Cells[4].Value); // Replace 4 with the index of the Email column
                    insertCommand.Parameters.AddWithValue("@StudNum", selectedRow.Cells[5].Value); // Replace 5 with the index of the StudNum column

                    // You need to provide values for the following parameters as well
                    insertCommand.Parameters.AddWithValue("@UserID", selectedRow.Cells[6].Value); // Replace 6 with the index of the UserID column
                    insertCommand.Parameters.AddWithValue("@RecoveryPin", selectedRow.Cells[7].Value); // Replace 7 with the index of the RecoveryPin column
                    insertCommand.Parameters.AddWithValue("@Password", selectedRow.Cells[8].Value); // Replace 8 with the index of the PassHashed column
                    insertCommand.Parameters.AddWithValue("@FixedSalt", selectedRow.Cells[9].Value); // Replace 9 with the index of the PassFixNa column
                    insertCommand.Parameters.AddWithValue("@PerUserSalt", selectedRow.Cells[10].Value); // Replace 10 with the index of the PassPerUserNa column

                    // Execute the insertion query
                    insertCommand.ExecuteNonQuery();


                }
                string deletequery = "DELETE FROM marchiveddb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account has been reactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student account row match found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        private void ReinsertIntoPendingDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(mysqlconn);
                connection.Open();

                // Assuming the order of columns in the DataGridView matches the order of columns in the database table
                using (MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO mpendingdb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                    "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @UserID, @RecoveryPin, @Password, @FixedSalt, @PerUserSalt)", connection))
                {
                    // Assuming you have a 'selectedRow' object containing the data to be inserted
                    insertCommand.Parameters.AddWithValue("@Name", selectedRow.Cells[0].Value); // Replace 0 with the index of the Name column
                    insertCommand.Parameters.AddWithValue("@Age", selectedRow.Cells[1].Value); // Replace 1 with the index of the Age column
                    insertCommand.Parameters.AddWithValue("@Gender", selectedRow.Cells[2].Value); // Replace 2 with the index of the Gender column
                    insertCommand.Parameters.AddWithValue("@Course", selectedRow.Cells[3].Value); // Replace 3 with the index of the Course column
                    insertCommand.Parameters.AddWithValue("@Email", selectedRow.Cells[4].Value); // Replace 4 with the index of the Email column
                    insertCommand.Parameters.AddWithValue("@StudNum", selectedRow.Cells[5].Value); // Replace 5 with the index of the StudNum column

                    // You need to provide values for the following parameters as well
                    insertCommand.Parameters.AddWithValue("@UserID", selectedRow.Cells[6].Value); // Replace 6 with the index of the UserID column
                    insertCommand.Parameters.AddWithValue("@RecoveryPin", selectedRow.Cells[7].Value); // Replace 7 with the index of the RecoveryPin column
                    insertCommand.Parameters.AddWithValue("@Password", selectedRow.Cells[8].Value); // Replace 8 with the index of the PassHashed column
                    insertCommand.Parameters.AddWithValue("@FixedSalt", selectedRow.Cells[9].Value); // Replace 9 with the index of the PassFixNa column
                    insertCommand.Parameters.AddWithValue("@PerUserSalt", selectedRow.Cells[10].Value); // Replace 10 with the index of the PassPerUserNa column

                    // Execute the insertion query
                    insertCommand.ExecuteNonQuery();


                }
                string deletequery = "DELETE FROM mapproveddb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account has been waitlisted.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student account row match found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
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
                        try
                        {
                            //// Insert data into the database
                            InsertIntoApprovedDB(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            // Handle any database-related errors here
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }


                    if (AccountTabs.SelectedTab == PendingTab)
                    {
                        // Switch to the other tab (e.g., ApprovedTab)
                        AccountTabs.SelectedTab = ApprovedTab;
                    }
                    else if (AccountTabs.SelectedTab == ApprovedTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = PendingTab;
                    }




                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult deleteResult = MessageBox.Show("Do you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow selectedRow in PendingTable.SelectedRows)
                        {
                            DeleteInPendingdDB(selectedRow);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a table row first.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void DeleteInPendingdDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;

            try
            {
                connection.Open();
                string deletequery = "DELETE FROM mpendingdb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching rows found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }



            // You can add code here to update your UI or perform any other necessary actions
        }

        private void DeleteInApproveddDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;

            try
            {
                connection.Open();
                string deletequery = "DELETE FROM mapproveddb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching rows found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

        }


        private void DeleteInArchiveddDB(DataGridViewRow selectedRow)
        {
            string selectedUID = selectedRow.Cells["UserID"].Value as string;

            try
            {
                connection.Open();
                string deletequery = "DELETE FROM marchiveddb WHERE UserID = @UserID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deletequery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUID);
                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching rows found for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadPendingDB();
                LoadApprovedDB();
                LoadArchivedDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

        }




        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ApprovedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to archive the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable

                    foreach (DataGridViewRow selectedRow in ApprovedTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            //DeleteInApproveddDB(selectedRow);
                            InsertIntoArchivedDB(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            // Handle any database-related errors here
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    if (AccountTabs.SelectedTab == ApprovedTab)
                    {
                        // Switch to the other tab (e.g., ApprovedTab)
                        AccountTabs.SelectedTab = ArchivedTab;
                    }
                    else if (AccountTabs.SelectedTab == ArchivedTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = ApprovedTab;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Select a table row first.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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


        private void PendingRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadPendingDB();
        }

        private void ApprovedRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadApprovedDB();
        }

        private void ApprovedTab_Click(object sender, EventArgs e)
        {
            LoadPendingDB();
            LoadApprovedDB();
        }

        private void PendingTab_Click(object sender, EventArgs e)
        {
            LoadPendingDB();
            LoadApprovedDB();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReactivateBtn_Click(object sender, EventArgs e)
        {
            //Reactivate button

            if (ArchivedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to reactivate the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
                    foreach (DataGridViewRow selectedRow in ArchivedTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            ReinsertIntoApprovedDB(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            // Handle any database-related errors here
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }


                    if (AccountTabs.SelectedTab == ArchivedTab)
                    {
                        // Switch to the other tab (e.g., ApprovedTab)
                        AccountTabs.SelectedTab = ApprovedTab;
                    }
                    else if (AccountTabs.SelectedTab == ApprovedTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = ArchivedTab;
                    }




                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult deleteResult = MessageBox.Show("Do you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow selectedRow in ArchivedTable.SelectedRows)
                        {
                            DeleteInArchiveddDB(selectedRow);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a table row first.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }




        }

        private void AccountTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PendingBtn_Click(object sender, EventArgs e)
        {
            if (ApprovedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to waitlist the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
                    foreach (DataGridViewRow selectedRow in ApprovedTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            ReinsertIntoPendingDB(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            // Handle any database-related errors here
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }


                    if (AccountTabs.SelectedTab == ApprovedTab)
                    {
                        // Switch to the other tab (e.g., ApprovedTab)
                        AccountTabs.SelectedTab = PendingTab;
                    }
                    else if (AccountTabs.SelectedTab == PendingTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = ApprovedTab;
                    }




                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult deleteResult = MessageBox.Show("Do you want to archive the selected row? instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow selectedRow in ArchivedTable.SelectedRows)
                        {
                            DeleteInArchiveddDB(selectedRow);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a table row first.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
