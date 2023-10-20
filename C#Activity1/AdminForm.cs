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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static C_Activity1.LoginForm;
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
        private DataTable mpendingdb = new DataTable(); // Declare your DataTable

        private string[] genders = { "Male", "Female", "Prefer Not to Say" };
        string ID;

        private const int CreatemaxAttempt = 3;
        int CreatefailedAttempts = 0;
        public AdminForm()
        {
            InitializeComponent();
            instance = this;
            //string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
            //conn = new MySqlConnection(mysqlconn);

            this.FormClosing += new FormClosingEventHandler(AdminPanel_FormClosing);
            FormBorderStyle = FormBorderStyle.FixedSingle;

            //Combo Boxes
            InsertRegiGenderComboBox.Items.AddRange(genders);
            InsertRegiGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateGenderComboBox.Items.AddRange(genders);
            UpdateGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Tab Header remover
            //AccountTabs.SizeMode = TabSizeMode.Fixed;
            //AccountTabs.TabPages.Clear();

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
            ID = RandomNumberGenerator.GenerateRandomNumber();
            string BtnSN = InsertRegiSNBox.Text;
            InsertRegiSNBox.Text = ID + "-" + BtnSN;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Assuming your source data grid is named "PendingTable"
            //DataGridViewRow selectedRow = PendingTable.CurrentRow;
            //ApprovedTable.Rows.Clear();

            //// Here, you can also insert the data into the database
            //InsertIntoApprovedDB(selectedRow);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Set the item size height to zero to hide the tab headers
            AccountTabs.ItemSize = new Size(0, 1);
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

        private void DBRefresher()
        {
            LoadPendingDB();
            LoadApprovedDB();
            LoadArchivedDB();
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

                DBRefresher();
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

                DBRefresher();
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
                DBRefresher();
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

                DBRefresher();
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

        private void PendingUpdateBtn_Click(object sender, EventArgs e)
        {
            //Pending Update Btn
            if (PendingTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to edit the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
                    foreach (DataGridViewRow selectedRow in PendingTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            RetrieveDataPendingDB(selectedRow);

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
                        AccountTabs.SelectedTab = UpdateTab;
                    }
                    else if (AccountTabs.SelectedTab == UpdateTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = PendingTab;
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

        private void ApprovedUpdateBtn_Click(object sender, EventArgs e)
        {
            if (ApprovedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to edit the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
                    foreach (DataGridViewRow selectedRow in ApprovedTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            RetrieveDataApprovedDB(selectedRow);

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
                        AccountTabs.SelectedTab = UpdateTab;
                    }
                    else if (AccountTabs.SelectedTab == UpdateTab)
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

        private void ArchivedUpdateBtn_Click(object sender, EventArgs e)
        {
            if (ArchivedTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to edit the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Iterate through selected rows in PendingTable
                    foreach (DataGridViewRow selectedRow in ArchivedTable.SelectedRows)
                    {
                        try
                        {
                            //// Insert data into the database
                            RetrieveDataArchivedDB(selectedRow);

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
                        AccountTabs.SelectedTab = UpdateTab;
                    }
                    else if (AccountTabs.SelectedTab == UpdateTab)
                    {
                        // Switch back to the PendingTab
                        AccountTabs.SelectedTab = ArchivedTab;
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

        private void RetrieveDataPendingDB(DataGridViewRow selectedRow)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                {
                    connection.Open();

                    // Get the student number from the selected row
                    string studentNumber = selectedRow.Cells["StudNum"].Value.ToString();

                    // Check if the student number exists in the database
                    string selectQuery = "SELECT * FROM mpendingdb WHERE StudNum = @StudNum";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
                    selectCmd.Parameters.AddWithValue("@StudNum", studentNumber);

                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve data from the database
                            string name = reader["Name"].ToString();
                            string sn = reader["StudNum"].ToString();
                            string rp = reader["RecoveryPin"].ToString();
                            string course = reader["Course"].ToString();
                            string age = reader["Age"].ToString();
                            string gender = reader["Gender"].ToString();
                            string email = reader["Email"].ToString();

                            // Populate the text boxes with the retrieved data
                            UpdateNameBox.Text = name;
                            UpdateSNBox.Text = sn;
                            UpdateRPBox.Text = rp;
                            UpdateCourseBox.Text = course;
                            UpdateAgeBox.Text = age;
                            UpdateGenderComboBox.Text = gender;
                            UpdateEmailBox.Text = email;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database exception (e.g., connection error or duplicate entry)
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RetrieveDataApprovedDB(DataGridViewRow selectedRow)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                {
                    connection.Open();

                    // Get the student number from the selected row
                    string studentNumber = selectedRow.Cells["StudNum"].Value.ToString();

                    // Check if the student number exists in the database
                    string selectQuery = "SELECT * FROM mapproveddb WHERE StudNum = @StudNum";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
                    selectCmd.Parameters.AddWithValue("@StudNum", studentNumber);

                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve data from the database
                            string name = reader["Name"].ToString();
                            string sn = reader["StudNum"].ToString();
                            string rp = reader["RecoveryPin"].ToString();
                            string course = reader["Course"].ToString();
                            string age = reader["Age"].ToString();
                            string gender = reader["Gender"].ToString();
                            string email = reader["Email"].ToString();

                            // Populate the text boxes with the retrieved data
                            UpdateNameBox.Text = name;
                            UpdateSNBox.Text = sn;
                            UpdateRPBox.Text = rp;
                            UpdateCourseBox.Text = course;
                            UpdateAgeBox.Text = age;
                            UpdateGenderComboBox.Text = gender;
                            UpdateEmailBox.Text = email;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database exception (e.g., connection error or duplicate entry)
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RetrieveDataArchivedDB(DataGridViewRow selectedRow)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                {
                    connection.Open();

                    // Get the student number from the selected row
                    string studentNumber = selectedRow.Cells["StudNum"].Value.ToString();

                    // Check if the student number exists in the database
                    string selectQuery = "SELECT * FROM marchiveddb WHERE StudNum = @StudNum";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
                    selectCmd.Parameters.AddWithValue("@StudNum", studentNumber);

                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve data from the database
                            string name = reader["Name"].ToString();
                            string sn = reader["StudNum"].ToString();
                            string rp = reader["RecoveryPin"].ToString();
                            string course = reader["Course"].ToString();
                            string age = reader["Age"].ToString();
                            string gender = reader["Gender"].ToString();
                            string email = reader["Email"].ToString();

                            // Populate the text boxes with the retrieved data
                            UpdateNameBox.Text = name;
                            UpdateSNBox.Text = sn;
                            UpdateRPBox.Text = rp;
                            UpdateCourseBox.Text = course;
                            UpdateAgeBox.Text = age;
                            UpdateGenderComboBox.Text = gender;
                            UpdateEmailBox.Text = email;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database exception (e.g., connection error or duplicate entry)
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
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
                DBRefresher();
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
                DBRefresher();
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
                DBRefresher();
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

        private void PendingSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = PendingSearchBox.Text;
            SearchPendingDB(searchText);
        }

        private void SearchPendingDB(string searchText)
        {
            connection.Open();
            // Modify your MySQL query to search in specific columns of the table
            string query = "SELECT * FROM mpendingdb WHERE " +
                           "Name LIKE @searchText OR " +
                           "Age LIKE @searchText OR " +
                           "Gender LIKE @searchText OR " +
                           "Course LIKE @searchText OR " +
                           "Email LIKE @searchText OR " +
                           "StudNum LIKE @searchText OR " +
                           "RecoveryPin LIKE @searchText OR " +
                           "UserID LIKE @searchText";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Adjust the parameter name and value accordingly

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataGridView (PendingTable) to the search results
                    PendingTable.DataSource = dataTable;
                }
            }
            connection.Close();
        }

        private void SearchApprovedDB(string searchText)
        {
            connection.Open();
            // Modify your MySQL query to search in specific columns of the table
            string query = "SELECT * FROM mapproveddb WHERE " +
                           "Name LIKE @searchText OR " +
                           "Age LIKE @searchText OR " +
                           "Gender LIKE @searchText OR " +
                           "Course LIKE @searchText OR " +
                           "Email LIKE @searchText OR " +
                           "StudNum LIKE @searchText OR " +
                           "RecoveryPin LIKE @searchText OR " +
                           "UserID LIKE @searchText";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Adjust the parameter name and value accordingly

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataGridView (PendingTable) to the search results
                    ApprovedTable.DataSource = dataTable;
                }
            }
            connection.Close();
        }

        private void SearchArchivedDB(string searchText)
        {
            connection.Open();
            // Modify your MySQL query to search in specific columns of the table
            string query = "SELECT * FROM marchiveddb WHERE " +
                           "Name LIKE @searchText OR " +
                           "Age LIKE @searchText OR " +
                           "Gender LIKE @searchText OR " +
                           "Course LIKE @searchText OR " +
                           "Email LIKE @searchText OR " +
                           "StudNum LIKE @searchText OR " +
                           "RecoveryPin LIKE @searchText OR " +
                           "UserID LIKE @searchText";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Adjust the parameter name and value accordingly

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataGridView (PendingTable) to the search results
                    ArchivedTable.DataSource = dataTable;
                }
            }
            connection.Close();
        }


        private void PendingSearchPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void ApprovedSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = ApprovedSearchBox.Text;
            SearchApprovedDB(searchText);
        }

        private void ArchivedSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = ArchivedSearchBox.Text;
            SearchArchivedDB(searchText);
        }

        private void RegiGenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InsertRegiGenderComboBox.SelectedItem != null)
            {
                InsertRegiGenderComboBox.Text = InsertRegiGenderComboBox.SelectedItem.ToString();
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
            Btnname = InsertRegiNameBox.Text;
            BtnSN = InsertRegiSNBox.Text;
            BtnRP = InsertRegiRPBox.Text;
            BtnPass = InsertRegiPassBox.Text;
            BtnCourse = InsertRegiCourseBox.Text;
            BtnAge = InsertRegiAgeBox.Text;
            BtnGender = InsertRegiGenderComboBox.Text;
            BtnMail = InsertRegiMailBox.Text;


            string hashedPassword = HashHelper.HashString(BtnPass);    // Password hashed
            string fixedSalt = HashHelper_Salt.HashString_Salt("Morpheus" + BtnPass + "01");    //Fixed Salt
            string perUserSalt = HashHelper_SaltperUser.HashString_SaltperUser(BtnPass + ID);    //Per User salt


            // Regex patterns
            Regex nameRegex = new Regex("^[A-Z][a-zA-Z]+(?: [a-zA-Z]+)*$");
            Regex courseRegex = new Regex("^[A-Za-z]+(?: [A-Za-z]+)*$");
            Regex passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");
            Regex gmailRegex = new Regex(@"^[A-Za-z0-9._%+-]*\d*@gmail\.com$");

            // Check if any of the input fields is empty
            if (string.IsNullOrEmpty(Btnname) || string.IsNullOrEmpty(BtnSN) || string.IsNullOrEmpty(BtnRP) ||
                string.IsNullOrEmpty(BtnPass) || string.IsNullOrEmpty(BtnAge) || string.IsNullOrEmpty(BtnCourse) ||
                string.IsNullOrEmpty(BtnGender) || string.IsNullOrEmpty(BtnMail))
            {
                MessageBox.Show("Missing text in required fields.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method since there's an error
            }
            else if (Btnname.Contains("Admin") || BtnSN.Contains("Admin") || BtnPass.Contains("Admin123"))
            {
                HandleIncorrectCreateInput("This student already has an account.");
                return;
            }

            // Check if the student number (BtnSN) already exists in ApprovedTable
            //bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);

            //if (isStudentInApprovedTable)
            //{
            //    HandleApprovedUserInput("This student already has an account.");
            //    return; // Exit the method since there's an error
            //}

            // Validate fields using regex patterns
            else if (!nameRegex.IsMatch(Btnname))
            {
                HandleIncorrectCreateInput("Name must start with a capital letter and only contain alphabetic values.");
                return;
            }
            else if (!courseRegex.IsMatch(BtnCourse))
            {
                HandleIncorrectCreateInput("Course must only contain alphabetic values.");
                return;
            }
            else if (!int.TryParse(BtnAge, out _))
            {
                HandleIncorrectCreateInput("Age must only contain numeric values.");
                return;
            }
            //else if (!int.TryParse(BtnSN, out _))
            //{
            //    HandleIncorrectCreateInput("Incorrect Student Number.");
            //    return;
            //}
            else if (!gmailRegex.IsMatch(BtnMail))
            {
                HandleIncorrectCreateInput("Invalid Gmail address format.");
                return;
            }
            else if (!passwordRegex.IsMatch(BtnPass))
            {
                HandleIncorrectCreateInput("Password must be at least 8 characters long and contain a combination of alphabetic characters, numeric digits, and special characters like (!, @, #, $, %, ^, &, *).");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                {
                    connection.Open();

                    // Insert data into the pendingdb table
                    string insertQuery = "INSERT INTO mpendingdb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                                        "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @RecoveryPin, @UserID, @Password, @FixedSalt, @PerUserSalt)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@Name", Btnname);
                    cmd.Parameters.AddWithValue("@StudNum", BtnSN);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@UserID", ID);
                    cmd.Parameters.AddWithValue("@FixedSalt", fixedSalt);
                    cmd.Parameters.AddWithValue("@PerUserSalt", perUserSalt);
                    cmd.Parameters.AddWithValue("@Course", BtnCourse);
                    cmd.Parameters.AddWithValue("@Age", BtnAge);
                    cmd.Parameters.AddWithValue("@Gender", BtnGender);
                    cmd.Parameters.AddWithValue("@Email", BtnMail);
                    cmd.Parameters.AddWithValue("@RecoveryPin", BtnRP);


                    cmd.ExecuteNonQuery();
                }
                DBRefresher();

                // Successful insertion
                MessageBox.Show("Account added for approval", "Hooray!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle database exception (e.g., connection error or duplicate entry)
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection
                connection.Close();
            }
            InsertTextboxClear();
        }

        private void InsertTextboxClear()
        {
            InsertRegiNameBox.Text = "";
            InsertRegiSNBox.Text = "";
            InsertRegiRPBox.Text = "";
            InsertRegiPassBox.Text = "";
            InsertRegiCourseBox.Text = "";
            InsertRegiAgeBox.Text = "";
            InsertRegiGenderComboBox.SelectedIndex = -1;
            InsertRegiMailBox.Text = "";
        }

        private void HandleIncorrectCreateInput(string errorMessage)
        {
            CreatefailedAttempts++;

            int CreateRemainingAttempts = CreatemaxAttempt - CreatefailedAttempts;

            if (CreateRemainingAttempts > 0)
            {
                MessageBox.Show($"Attempts remaining: {CreateRemainingAttempts} \n{errorMessage} ", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateBtn.Enabled = false;
                MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleApprovedUserInput(string errorMessage)
        {
            CreatefailedAttempts++;
            int CreateRemainingAttempts = CreatemaxAttempt - CreatefailedAttempts;


            if (CreateRemainingAttempts > 0)
            {
                MessageBox.Show($"Attempts remaining: {CreateRemainingAttempts} \n{errorMessage} Please try again. ", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateBtn.Enabled = false;
                MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegiPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
                Btnname = InsertRegiNameBox.Text;
                BtnSN = InsertRegiSNBox.Text;
                BtnRP = InsertRegiRPBox.Text;
                BtnPass = InsertRegiPassBox.Text;
                BtnCourse = InsertRegiCourseBox.Text;
                BtnAge = InsertRegiAgeBox.Text;
                BtnGender = InsertRegiGenderComboBox.Text;
                BtnMail = InsertRegiMailBox.Text;


                string hashedPassword = HashHelper.HashString(BtnPass);    // Password hashed
                string fixedSalt = HashHelper_Salt.HashString_Salt("Morpheus" + BtnPass + "01");    //Fixed Salt
                string perUserSalt = HashHelper_SaltperUser.HashString_SaltperUser(BtnPass + ID);    //Per User salt


                // Regex patterns
                Regex nameRegex = new Regex("^[A-Z][a-zA-Z]+(?: [a-zA-Z]+)*$");
                Regex courseRegex = new Regex("^[A-Za-z]+(?: [A-Za-z]+)*$");
                Regex passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");
                Regex gmailRegex = new Regex(@"^[A-Za-z0-9._%+-]*\d*@gmail\.com$");

                // Check if any of the input fields is empty
                if (string.IsNullOrEmpty(Btnname) || string.IsNullOrEmpty(BtnSN) || string.IsNullOrEmpty(BtnRP) ||
                    string.IsNullOrEmpty(BtnPass) || string.IsNullOrEmpty(BtnAge) || string.IsNullOrEmpty(BtnCourse) ||
                    string.IsNullOrEmpty(BtnGender) || string.IsNullOrEmpty(BtnMail))
                {
                    MessageBox.Show("Missing text in required fields.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method since there's an error
                }
                else if (Btnname.Contains("Admin") || BtnSN.Contains("Admin") || BtnPass.Contains("Admin123"))
                {
                    HandleIncorrectCreateInput("This student already has an account.");
                    return;
                }

                // Check if the student number (BtnSN) already exists in ApprovedTable
                //bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);

                //if (isStudentInApprovedTable)
                //{
                //    HandleApprovedUserInput("This student already has an account.");
                //    return; // Exit the method since there's an error
                //}

                // Validate fields using regex patterns
                else if (!nameRegex.IsMatch(Btnname))
                {
                    HandleIncorrectCreateInput("Name must start with a capital letter and only contain alphabetic values.");
                    return;
                }
                else if (!courseRegex.IsMatch(BtnCourse))
                {
                    HandleIncorrectCreateInput("Course must only contain alphabetic values.");
                    return;
                }
                else if (!int.TryParse(BtnAge, out _))
                {
                    HandleIncorrectCreateInput("Age must only contain numeric values.");
                    return;
                }
                //else if (!int.TryParse(BtnSN, out _))
                //{
                //    HandleIncorrectCreateInput("Incorrect Student Number.");
                //    return;
                //}
                else if (!gmailRegex.IsMatch(BtnMail))
                {
                    HandleIncorrectCreateInput("Invalid Gmail address format.");
                    return;
                }
                else if (!passwordRegex.IsMatch(BtnPass))
                {
                    HandleIncorrectCreateInput("Password must be at least 8 characters long and contain a combination of alphabetic characters, numeric digits, and special characters like (!, @, #, $, %, ^, &, *).");
                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                    {
                        connection.Open();

                        // Insert data into the pendingdb table
                        string insertQuery = "INSERT INTO mpendingdb (Name, Age, Gender, Course, Email, StudNum, RecoveryPin, UserID, PassHashed, PassFixNa, PassPerUserNa) " +
                                            "VALUES (@Name, @Age, @Gender, @Course, @Email, @StudNum, @RecoveryPin, @UserID, @Password, @FixedSalt, @PerUserSalt)";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                        cmd.Parameters.AddWithValue("@Name", Btnname);
                        cmd.Parameters.AddWithValue("@StudNum", BtnSN);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@UserID", ID);
                        cmd.Parameters.AddWithValue("@FixedSalt", fixedSalt);
                        cmd.Parameters.AddWithValue("@PerUserSalt", perUserSalt);
                        cmd.Parameters.AddWithValue("@Course", BtnCourse);
                        cmd.Parameters.AddWithValue("@Age", BtnAge);
                        cmd.Parameters.AddWithValue("@Gender", BtnGender);
                        cmd.Parameters.AddWithValue("@Email", BtnMail);
                        cmd.Parameters.AddWithValue("@RecoveryPin", BtnRP);


                        cmd.ExecuteNonQuery();
                    }
                    DBRefresher();
                    // Successful insertion
                    MessageBox.Show("Account added for approval", "Hooray!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle database exception (e.g., connection error or duplicate entry)
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Make sure to close the connection
                    connection.Close();
                }

                InsertTextboxClear();


                e.SuppressKeyPress = true;
            }
        }
        private int minTextLength = 5; // Minimum required text length

        private void RegiSNBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                // If the current length is less than or equal to the minimum required length, prevent Backspace
                if (InsertRegiSNBox.Text.Length <= minTextLength)
                {
                    e.SuppressKeyPress = true; // Prevent Backspace
                }
            }
        }



        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            studNumRefresher();
        }

        private void studNumRefresher()
        {
            InsertRegiSNBox.Text = "";
            ID = RandomNumberGenerator.GenerateRandomNumber();
            string BtnSN = InsertRegiSNBox.Text;
            InsertRegiSNBox.Text = ID + "-" + BtnSN;
        }

        private void RegiShowPass_CheckedChanged(object sender, EventArgs e)
        {
            InsertRegiPassBox.UseSystemPasswordChar = !RegiShowPass.Checked;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
            Btnname = UpdateNameBox.Text;
            BtnSN = UpdateSNBox.Text;
            BtnRP = UpdateRPBox.Text;
            BtnPass = UpdatePassBox.Text;
            BtnCourse = UpdateCourseBox.Text;
            BtnAge = UpdateAgeBox.Text;
            BtnGender = UpdateGenderComboBox.Text;
            BtnMail = UpdateEmailBox.Text;


            string hashedPassword = HashHelper.HashString(BtnPass);    // Password hashed
            string fixedSalt = HashHelper_Salt.HashString_Salt("Morpheus" + BtnPass + "01");    //Fixed Salt
            string perUserSalt = HashHelper_SaltperUser.HashString_SaltperUser(BtnPass + ID);    //Per User salt


            // Regex patterns
            Regex nameRegex = new Regex("^[A-Z][a-zA-Z]+(?: [a-zA-Z]+)*$");
            Regex courseRegex = new Regex("^[A-Za-z]+(?: [A-Za-z]+)*$");
            Regex passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");
            Regex gmailRegex = new Regex(@"^[A-Za-z0-9._%+-]*\d*@gmail\.com$");

            // Check if any of the input fields is empty
            if (string.IsNullOrEmpty(Btnname) || string.IsNullOrEmpty(BtnSN) || string.IsNullOrEmpty(BtnRP) ||
                string.IsNullOrEmpty(BtnPass) || string.IsNullOrEmpty(BtnAge) || string.IsNullOrEmpty(BtnCourse) ||
                string.IsNullOrEmpty(BtnGender) || string.IsNullOrEmpty(BtnMail))
            {
                MessageBox.Show("Missing text in required fields.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method since there's an error
            }
            else if (Btnname.Contains("Admin") || BtnSN.Contains("Admin") || BtnPass.Contains("Admin123"))
            {
                HandleIncorrectCreateInput("This student already has an account.");
                return;
            }

            // Check if the student number (BtnSN) already exists in ApprovedTable
            //bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);

            //if (isStudentInApprovedTable)
            //{
            //    HandleApprovedUserInput("This student already has an account.");
            //    return; // Exit the method since there's an error
            //}

            // Validate fields using regex patterns
            else if (!nameRegex.IsMatch(Btnname))
            {
                HandleIncorrectCreateInput("Name must start with a capital letter and only contain alphabetic values.");
                return;
            }
            else if (!courseRegex.IsMatch(BtnCourse))
            {
                HandleIncorrectCreateInput("Course must only contain alphabetic values.");
                return;
            }
            else if (!int.TryParse(BtnAge, out _))
            {
                HandleIncorrectCreateInput("Age must only contain numeric values.");
                return;
            }
            //else if (!int.TryParse(BtnSN, out _))
            //{
            //    HandleIncorrectCreateInput("Incorrect Student Number.");
            //    return;
            //}
            else if (!gmailRegex.IsMatch(BtnMail))
            {
                HandleIncorrectCreateInput("Invalid Gmail address format.");
                return;
            }
            else if (!passwordRegex.IsMatch(BtnPass))
            {
                HandleIncorrectCreateInput("Password must be at least 8 characters long and contain a combination of alphabetic characters, numeric digits, and special characters like (!, @, #, $, %, ^, &, *).");
                return;
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                    {
                        connection.Open();

                        bool pendingUpdate = false;
                        bool approvedUpdate = false;
                        bool archivedUpdate = false;

                        // Check if the student number (BtnSN) exists in the pendingdb table
                        string selectPendingQuery = "SELECT * FROM mpendingdb WHERE StudNum = @StudNum";
                        MySqlCommand selectPendingCmd = new MySqlCommand(selectPendingQuery, connection);
                        selectPendingCmd.Parameters.AddWithValue("@StudNum", BtnSN);

                        // Check if the student number (BtnSN) exists in the approveddb table
                        string selectApprovedQuery = "SELECT * FROM mapproveddb WHERE StudNum = @StudNum";
                        MySqlCommand selectApprovedCmd = new MySqlCommand(selectApprovedQuery, connection);
                        selectApprovedCmd.Parameters.AddWithValue("@StudNum", BtnSN);

                        // Check if the student number (BtnSN) exists in the archiveddb table
                        string selectArchivedQuery = "SELECT * FROM marchiveddb WHERE StudNum = @StudNum";
                        MySqlCommand selectArchivedCmd = new MySqlCommand(selectArchivedQuery, connection);
                        selectArchivedCmd.Parameters.AddWithValue("@StudNum", BtnSN);

                        using (MySqlDataReader pendingReader = selectPendingCmd.ExecuteReader())
                        {
                            if (pendingReader.Read())
                            {
                                // The student number exists in the pendingdb table, so set the pendingUpdate flag
                                pendingUpdate = true;
                            }
                        }

                        using (MySqlDataReader approvedReader = selectApprovedCmd.ExecuteReader())
                        {
                            if (approvedReader.Read())
                            {
                                // The student number exists in the approveddb table, so set the approvedUpdate flag
                                approvedUpdate = true;
                            }
                        }

                        using (MySqlDataReader archivedReader = selectArchivedCmd.ExecuteReader())
                        {
                            if (archivedReader.Read())
                            {
                                // The student number exists in the archiveddb table, so set the archivedUpdate flag
                                archivedUpdate = true;
                            }
                        }

                        if (pendingUpdate)
                        {
                            // The student number exists in the pendingdb table, so perform an update for pendingdb
                            string updateQuery = "UPDATE mpendingdb SET Name = @Name, Age = @Age, Gender = @Gender, Course = @Course, " +
                                "Email = @Email, RecoveryPin = @RecoveryPin, PassHashed = @Password, " +
                                "PassFixNa = @FixedSalt, PassPerUserNa = @PerUserSalt WHERE StudNum = @StudNum";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                            updateCmd.Parameters.AddWithValue("@Name", Btnname);
                            updateCmd.Parameters.AddWithValue("@StudNum", BtnSN);
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@FixedSalt", fixedSalt);
                            updateCmd.Parameters.AddWithValue("@PerUserSalt", perUserSalt);
                            updateCmd.Parameters.AddWithValue("@Course", BtnCourse);
                            updateCmd.Parameters.AddWithValue("@Age", BtnAge);
                            updateCmd.Parameters.AddWithValue("@Gender", BtnGender);
                            updateCmd.Parameters.AddWithValue("@Email", BtnMail);
                            updateCmd.Parameters.AddWithValue("@RecoveryPin", BtnRP);
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (approvedUpdate)
                        {
                            // The student number exists in the approveddb table, so perform an update for approveddb
                            string updateQuery = "UPDATE mapproveddb SET Name = @Name, Age = @Age, Gender = @Gender, Course = @Course, " +
                                "Email = @Email, RecoveryPin = @RecoveryPin, PassHashed = @Password, " +
                                "PassFixNa = @FixedSalt, PassPerUserNa = @PerUserSalt WHERE StudNum = @StudNum";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                            updateCmd.Parameters.AddWithValue("@Name", Btnname);
                            updateCmd.Parameters.AddWithValue("@StudNum", BtnSN);
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@FixedSalt", fixedSalt);
                            updateCmd.Parameters.AddWithValue("@PerUserSalt", perUserSalt);
                            updateCmd.Parameters.AddWithValue("@Course", BtnCourse);
                            updateCmd.Parameters.AddWithValue("@Age", BtnAge);
                            updateCmd.Parameters.AddWithValue("@Gender", BtnGender);
                            updateCmd.Parameters.AddWithValue("@Email", BtnMail);
                            updateCmd.Parameters.AddWithValue("@RecoveryPin", BtnRP);
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (archivedUpdate)
                        {
                            // The student number exists in the archiveddb table, so perform an update for archiveddb
                            string updateQuery = "UPDATE marchiveddb SET Name = @Name, Age = @Age, Gender = @Gender, Course = @Course, " +
                                "Email = @Email, RecoveryPin = @RecoveryPin, PassHashed = @Password, " +
                                "PassFixNa = @FixedSalt, PassPerUserNa = @PerUserSalt WHERE StudNum = @StudNum";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                            updateCmd.Parameters.AddWithValue("@Name", Btnname);
                            updateCmd.Parameters.AddWithValue("@StudNum", BtnSN);
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@FixedSalt", fixedSalt);
                            updateCmd.Parameters.AddWithValue("@PerUserSalt", perUserSalt);
                            updateCmd.Parameters.AddWithValue("@Course", BtnCourse);
                            updateCmd.Parameters.AddWithValue("@Age", BtnAge);
                            updateCmd.Parameters.AddWithValue("@Gender", BtnGender);
                            updateCmd.Parameters.AddWithValue("@Email", BtnMail);
                            updateCmd.Parameters.AddWithValue("@RecoveryPin", BtnRP);
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // The student number does not exist in any of the tables, show an error message
                            MessageBox.Show("Student not found in any of the database tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle database exception (e.g., connection error or duplicate entry)
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Make sure to close the connection
                    connection.Close();
                }

                DBRefresher();

                UpdateTextboxClear();


            }

        }

        private void UpdateTextboxClear()
        {
            UpdateNameBox.Text = "";
            UpdateSNBox.Text = "";
            UpdateRPBox.Text = "";
            UpdatePassBox.Text = "";
            UpdateCourseBox.Text = "";
            UpdateAgeBox.Text = "";
            UpdateGenderComboBox.SelectedIndex = -1;
            UpdateEmailBox.Text = "";
        }

        private void UpdateShowPass_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePassBox.UseSystemPasswordChar = !UpdateShowPass.Checked;

        }

        private void UpdateGenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateGenderComboBox.SelectedItem != null)
            {
                UpdateGenderComboBox.Text = UpdateGenderComboBox.SelectedItem.ToString();
            }
        }

        private void ApprovedTabLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountTabs.SelectedIndex = 1;
        }

        private void ArchivedTabLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountTabs.SelectedIndex = 2;

        }

        private void PendingLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountTabs.SelectedIndex = 0;
            //if (AccountTabs.SelectedTab == PendingTab)
            //{
            //    // Switch to the other tab (e.g., ApprovedTab)
            //    AccountTabs.SelectedTab = ApprovedTab;
            //    AccountTabs.SelectedTab = ArchivedTab;
            //    AccountTabs.SelectedTab = InsertTab;
            //    AccountTabs.SelectedTab = UpdateTab;

            //}
            //else if (AccountTabs.SelectedTab == ApprovedTab)
            //{
            //    // Switch back to the PendingTab
            //    AccountTabs.SelectedTab = PendingTab;
            //}

        }

        private void InsertTabLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountTabs.SelectedIndex = 3;

        }

        private void UpdateTabLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountTabs.SelectedIndex = 4
                ;

        }
    }
}