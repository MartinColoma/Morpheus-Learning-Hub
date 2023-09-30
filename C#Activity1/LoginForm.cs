using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;



namespace C_Activity1
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public static string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlconn);

        AdminForm APanel = new AdminForm();
        UserForm HomePage = new UserForm();
        public new Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private const int LoginmaxAttempt = 3;
        int LoginfailedAttempts = 0;
        private const int CreatemaxAttempt = 3;
        int CreatefailedAttempts = 0;
        //private const int maxAttempt = 3;
        //int failedAttempts = 0;
        int timerInterval = 15000;
        bool disableButton = false;
        private string[] genders = { "Male", "Female", "Prefer Not to Say" };
        string ID;



        public LoginForm()
        {
            InitializeComponent();
            String SN, Pass;
            SN = SNBox.Text; Pass = PassBox.Text;
            instance = this;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            RegiGenderComboBox.Items.AddRange(genders);
            RegiGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            using (MySqlConnection connection = new MySqlConnection(mysqlconn))
            {
                try
                {
                    MessageBox.Show("Connection Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }

            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing.
                e.Cancel = true;

                DialogResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Dispose();

                }


            }
        }
        private void RTULogin_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //LoginPanel







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;
        }

        private void SignUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Reset RegiSNBox's First 4 values
            ID = RandomNumberGenerator.GenerateRandomNumber();
            string BtnSN = RegiSNBox.Text;
            RegiSNBox.Text = ID + "-" + BtnSN;

            //Login Panel to Register Panel Linked Label

            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                RecoveryPanel.Visible = false;
                WCPanel.Visible = false;
                RegiPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RegiPanel.Visible = false;
                RecoveryPanel.Visible = true;
                LoginPanel.Visible = true;
                WCPanel.Visible = true;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Login Panel to Forgot Panel Linked Label
            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                //WCPanel.Visible = false;
                RegiPanel.Visible = false;
                RecoveryPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RecoveryPanel.Visible = false;
                LoginPanel.Visible = true;
                //WCPanel.Visible = true;

            }

        }

        private void RMBRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Show PassCheckbox
            //if(ShowPassCheck.isChecked)
            PassBox.UseSystemPasswordChar = !ShowPassCheck.Checked;

        }
        private void SNBox_TextChanged(object sender, EventArgs e)
        {
            //Login student number textbox
        }

        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Login Password Textbox
            if (e.KeyCode == Keys.Enter)
            {
                if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
                {
                    MessageBox.Show("Welcome back Admin.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    APanel.Show();
                    ResetForm();
                }
                else if (SNBox.Text != "Admin" && PassBox.Text == "Admin123")
                {
                    HandleIncorrectInput("Incorrect Student Number.");
                }
                else if (SNBox.Text == "Admin" && PassBox.Text != "Admin123")
                {
                    HandleIncorrectInput("Incorrect Password.");
                }
                else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
                {
                    MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string studNum = SNBox.Text;
                    string enteredPassword = PassBox.Text;
                    string passchecker = HashHelper.HashString(enteredPassword);

                    MySqlConnection connection = null;

                    try
                    {
                        connection = new MySqlConnection(mysqlconn);
                        connection.Open();

                        // Query the database for the provided student number in mpendingdb
                        string queryPending = "SELECT PassHashed FROM mpendingdb WHERE StudNum = @StudNum";

                        using (MySqlCommand cmdPending = new MySqlCommand(queryPending, connection))
                        {
                            cmdPending.Parameters.AddWithValue("@StudNum", studNum);

                            using (MySqlDataReader readerPending = cmdPending.ExecuteReader())
                            {
                                if (readerPending.Read())
                                {
                                    string pendinghashedPasswordFromDB = readerPending["PassHashed"].ToString();

                                    // Implement your password hashing and comparison logic here
                                    bool passwordMatches = pendinghashedPasswordFromDB.Equals(passchecker);

                                    if (passwordMatches)
                                    {
                                        MessageBox.Show("Student account is pending for approval", "Ooooops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        HandleIncorrectInput("Incorrect Password.");
                                    }
                                    return; // Exit the method after handling the pending case
                                }
                            }
                        }

                        // Query the database for the provided student number in mapproveddb
                        string queryApproved = "SELECT PassHashed FROM mapproveddb WHERE StudNum = @StudNum";

                        using (MySqlCommand cmdApproved = new MySqlCommand(queryApproved, connection))
                        {
                            cmdApproved.Parameters.AddWithValue("@StudNum", studNum);

                            using (MySqlDataReader readerApproved = cmdApproved.ExecuteReader())
                            {
                                if (readerApproved.Read())
                                {
                                    string hashedPasswordFromDB = readerApproved["PassHashed"].ToString();

                                    // Implement your password hashing and comparison logic here
                                    bool passwordMatches = hashedPasswordFromDB.Equals(passchecker);

                                    if (passwordMatches)
                                    {
                                        MessageBox.Show("Welcome back, Dreamers.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        HomePage.Show(); // Show the LHHomePage form
                                        ResetHideForm();
                                    }
                                    else
                                    {
                                        HandleIncorrectInput("Incorrect Password.");
                                    }
                                }
                                else
                                {
                                    // The entered student number does not exist in the approved database
                                    MessageBox.Show("Account not found.", "Ooooops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection?.Close();
                    }
                }



                // Prevent further event handling for the Enter key

                e.SuppressKeyPress = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Login Button

            if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Welcome back Admin.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                APanel.Show();
                ResetForm();
            }
            else if (SNBox.Text != "Admin" && PassBox.Text == "Admin123")
            {
                HandleIncorrectInput("Incorrect Student Number.");
            }
            else if (SNBox.Text == "Admin" && PassBox.Text != "Admin123")
            {
                HandleIncorrectInput("Incorrect Password.");
            }
            else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
            {
                MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string studNum = SNBox.Text;
                string enteredPassword = PassBox.Text;
                string passchecker = HashHelper.HashString(enteredPassword);

                MySqlConnection connection = null;

                try
                {
                    connection = new MySqlConnection(mysqlconn);
                    connection.Open();

                    // Query the database for the provided student number in mpendingdb
                    string queryPending = "SELECT PassHashed FROM mpendingdb WHERE StudNum = @StudNum";

                    using (MySqlCommand cmdPending = new MySqlCommand(queryPending, connection))
                    {
                        cmdPending.Parameters.AddWithValue("@StudNum", studNum);

                        using (MySqlDataReader readerPending = cmdPending.ExecuteReader())
                        {
                            if (readerPending.Read())
                            {
                                string pendinghashedPasswordFromDB = readerPending["PassHashed"].ToString();

                                // Implement your password hashing and comparison logic here
                                bool passwordMatches = pendinghashedPasswordFromDB.Equals(passchecker);

                                if (passwordMatches)
                                {
                                    MessageBox.Show("Student account is pending for approval", "Ooooops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    HandleIncorrectInput("Incorrect Password.");
                                }
                                return; // Exit the method after handling the pending case
                            }
                        }
                    }

                    // Query the database for the provided student number in mapproveddb
                    string queryApproved = "SELECT PassHashed FROM mapproveddb WHERE StudNum = @StudNum";

                    using (MySqlCommand cmdApproved = new MySqlCommand(queryApproved, connection))
                    {
                        cmdApproved.Parameters.AddWithValue("@StudNum", studNum);

                        using (MySqlDataReader readerApproved = cmdApproved.ExecuteReader())
                        {
                            if (readerApproved.Read())
                            {
                                string hashedPasswordFromDB = readerApproved["PassHashed"].ToString();

                                // Implement your password hashing and comparison logic here
                                bool passwordMatches = hashedPasswordFromDB.Equals(passchecker);

                                if (passwordMatches)
                                {
                                    MessageBox.Show("Welcome back, Dreamers.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    HomePage.Show(); // Show the LHHomePage form
                                    ResetHideForm();
                                }
                                else
                                {
                                    HandleIncorrectInput("Incorrect Password.");
                                }
                            }
                            else
                            {
                                // The entered student number does not exist in the approved database
                                MessageBox.Show("Account not found.", "Ooooops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection?.Close();
                }
            }
        }






        //Previous login button parameters
        //bool found = false;
        //bool find = false;
        ////bool unknown = false;


        //int asnColumnIndex = AdminForm.instance.ApprovedTable.Columns["ASNColumn"].Index;
        //int apassColumnIndex = AdminForm.instance.ApprovedTable.Columns["APassColumn"].Index;
        //int anameColumnIndex = AdminForm.instance.ApprovedTable.Columns["ANameColumn"].Index;

        ////Pending Table Indexes
        //int psnColumnIndex = AdminForm.instance.PendingTable.Columns["PSNColumn"].Index;
        //int ppassColumnIndex = AdminForm.instance.PendingTable.Columns["PPassColumn"].Index;


        //// Iterate through rows in ApprovedTable DataGridView
        //foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
        //{
        //    if (!row.IsNewRow) // Skip the new row if any
        //    {

        //        string storedSN = row.Cells[asnColumnIndex].Value?.ToString();
        //        string storedPass = row.Cells[apassColumnIndex].Value?.ToString();


        //        if (storedSN == SNBox.Text && storedPass == PassBox.Text)
        //        {
        //            found = true;
        //            UserForm.instance.LHSNBox.Text = storedSN;
        //            UserForm.instance.LHNameBox.Text = row.Cells[anameColumnIndex].Value?.ToString();
        //            break;
        //        }
        //        else if (storedSN != SNBox.Text && storedPass == PassBox.Text)
        //        {
        //            HandleIncorrectInput("Incorrect Student Number.");

        //        }
        //        else if (storedSN == SNBox.Text && storedPass != PassBox.Text)
        //        {
        //            HandleIncorrectInput("Incorrect Password.");

        //        }


        //    }

        //}

        //foreach (DataGridViewRow rows in AdminForm.instance.PendingTable.Rows)
        //{
        //    if (!rows.IsNewRow) // Skip the new row if any
        //    {

        //        string notStoredSN = rows.Cells[psnColumnIndex].Value?.ToString();
        //        string notStoredPass = rows.Cells[ppassColumnIndex].Value?.ToString();

        //        if (notStoredSN == SNBox.Text && notStoredPass == PassBox.Text)
        //        {
        //            find = true;
        //            MessageBox.Show("Student Account is pending for approval.", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }


        //    }
        //}


        //if (found)
        //{
        //    MessageBox.Show("Welcome back RTUista.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    HomePage.Show(); // Show the LHHomePage form
        //    ResetHideForm();

        //}
        //else if (find)
        //{
        //    ResetForm();
        //}
        //else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
        //{
        //    //HandleIncorrectInput("Missing Student Number and Password.");
        //    MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}
        //else if (!find && !found)
        //{
        //    MessageBox.Show("Login Failed. Please try again.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}









        private void HandleIncorrectInput(string errorMessage)
        {
            LoginfailedAttempts++;

            int LoginremainingAttempts = LoginmaxAttempt - LoginfailedAttempts;


            if (LoginremainingAttempts > 0)
            {
                MessageBox.Show($"Attempts remaining: {LoginremainingAttempts} \n{errorMessage}", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!disableButton)
            {
                DisableLoginButton();
                int secondsRemaining = LoginBtnTimer.Interval / 1000; // Convert milliseconds to seconds

                MessageBox.Show($"You ran out of attempts. Please try again after {secondsRemaining} second.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBtnTimer_Tick(object sender, EventArgs e)
        {
            ResetForm();
            LoginBtnTimer.Stop();


            if (LoginfailedAttempts > 0 && disableButton)
            {
                // If the remaining attempts are still zero, extend the timer
                LoginBtnTimer.Interval += timerInterval;
                LoginBtnTimer.Start();
            }

            else if (disableButton)
            {
                EnableLoginButton();
            }
        }

        private void DisableLoginButton()
        {
            LoginBtn.Enabled = false;
            disableButton = true;
            LoginBtnTimer.Interval = timerInterval;
            LoginBtnTimer.Start();
        }

        private void EnableLoginButton()
        {
            LoginBtn.Enabled = true;
            disableButton = false;
        }

        private void ResetForm()
        {
            SNBox.Text = "";
            PassBox.Text = "";
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;
        }
        private void ResetHideForm()
        {
            SNBox.Text = "";
            PassBox.Text = "";
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;
            this.Hide();
        }



        private void RegiNameBox_TextChanged(object sender, EventArgs e)
        {
            //Register Name Textbox
        }

        private int minTextLength = 5; // Minimum required text length

        private void RegiSNBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                // If the current length is less than or equal to the minimum required length, prevent Backspace
                if (RegiSNBox.Text.Length <= minTextLength)
                {
                    e.SuppressKeyPress = true; // Prevent Backspace
                }
            }
        }



        private void RegiSNBox_TextChanged(object sender, EventArgs e)
        {
            //Register Student Number Textbox

        }
        private void RegiRPBox_TextChanged(object sender, EventArgs e)
        {
            //Register PIN TextBox


        }
        private void RegiPassBox_TextChanged(object sender, EventArgs e)
        {
            //Register Password Textbox


        }
        private void RegiPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Register Password Textbox
            if (e.KeyCode == Keys.Enter)
            {

                string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
                Btnname = RegiNameBox.Text;
                BtnSN = RegiSNBox.Text;
                BtnRP = RegiRPBox.Text;
                BtnPass = RegiPassBox.Text;
                BtnCourse = RegiCourseBox.Text;
                BtnAge = RegiAgeBox.Text;
                BtnGender = RegiGenderComboBox.Text;
                BtnMail = RegiMailBox.Text;


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
                else if (Btnname == "Admin" || BtnSN == "Admin" || BtnPass == "Admin123")
                {
                    HandleIncorrectCreateInput("This student already has an account.");
                    return;
                }

                // Check if the student number (BtnSN) already exists in ApprovedTable
                bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);

                if (isStudentInApprovedTable)
                {
                    HandleApprovedUserInput("This student already has an account.");
                    return; // Exit the method since there's an error
                }

                // Validate fields using regex patterns
                if (!nameRegex.IsMatch(Btnname))
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

                RegiNameBox.Text = "";
                RegiSNBox.Text = "";
                RegiRPBox.Text = "";
                RegiPassBox.Text = "";
                RegiCourseBox.Text = "";
                RegiAgeBox.Text = "";
                RegiGenderComboBox.SelectedIndex = -1;
                RegiMailBox.Text = "";

                e.SuppressKeyPress = true;
            }


        }



        private void CreateBtn_Click(object sender, EventArgs e) //8506-1231
        {
            // Create Button
            string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
            Btnname = RegiNameBox.Text;
            BtnSN = RegiSNBox.Text;
            BtnRP = RegiRPBox.Text;
            BtnPass = RegiPassBox.Text;
            BtnCourse = RegiCourseBox.Text;
            BtnAge = RegiAgeBox.Text;
            BtnGender = RegiGenderComboBox.Text;
            BtnMail = RegiMailBox.Text;


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
            else if (Btnname == "Admin" || BtnSN == "Admin" || BtnPass == "Admin123")
            {
                HandleIncorrectCreateInput("This student already has an account.");
                return;
            }

            // Check if the student number (BtnSN) already exists in ApprovedTable
            bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);

            if (isStudentInApprovedTable)
            {
                HandleApprovedUserInput("This student already has an account.");
                return; // Exit the method since there's an error
            }

            // Validate fields using regex patterns
            if (!nameRegex.IsMatch(Btnname))
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

            RegiNameBox.Text = "";
            RegiSNBox.Text = "";
            RegiRPBox.Text = "";
            RegiPassBox.Text = "";
            RegiCourseBox.Text = "";
            RegiAgeBox.Text = "";
            RegiGenderComboBox.SelectedIndex = -1;
            RegiMailBox.Text = "";

        }

        //// If everything is okay, proceed to add the record
        //if (!AdminForm.instance.existingSN.Contains(BtnSN))
        //{
        //    AdminForm.instance.existingSN.Add(BtnSN); // Add it to your existingSN list
        //    AdminForm.instance.AddDataGridView(Btnname, BtnAge, BtnGender, BtnCourse, BtnSN, BtnMail, BtnRP, BtnPass);
        //    MessageBox.Show("Account added for approval", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show("Student Number is pending for approval.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        private bool IsStudentNumberInApprovedTable(string studentNumber)
        {
            foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
            {
                if (row.Cells["ASNColumn"].Value != null && row.Cells["ASNColumn"].Value.ToString() == studentNumber)
                {
                    return true;
                }
            }
            return false;
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

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Register Panel to Login Panel Link Label
            if (RegiPanel.Visible)
            {
                RegiPanel.Visible = false;
                WCPanel.Visible = true;
                LoginPanel.Visible = true;
                RecoveryPanel.Visible = true;
                RegiNameBox.Text = "";
                RegiSNBox.Text = "";
                RegiRPBox.Text = "";
                RegiPassBox.Text = "";
                RegiCourseBox.Text = "";
                RegiAgeBox.Text = "";
                RegiGenderComboBox.SelectedIndex = -1;
                RegiMailBox.Text = "";
            }

            else
            {
                WCPanel.Visible = true;
                RegiPanel.Visible = true;
                LoginPanel.Visible = false; ;
                RecoveryPanel.Visible = false;

            }

        }

        private void RegiPanel_Paint(object sender, PaintEventArgs e)
        {
            //register panel


        }

        private void GSLabel_Click(object sender, EventArgs e)
        {
            CreatefailedAttempts = 0;
            CreateBtn.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //RecoverLabel


        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Recover Label
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Forgot Panel to Login Pass Panel linked label
            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                //WCPanel.Visible = false;
                RecoveryPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RecoveryPanel.Visible = false;
                LoginPanel.Visible = true;
                WCPanel.Visible = true;
            }

        }
        private void RCSNBox_TextChanged(object sender, EventArgs e)
        {
            //recovery student number textbox



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //recovery pin textbox
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            ////Recovery Pass Submit Btn

            bool credentialsFound = false;
            connection.Open();
            string query = $"SELECT UserID FROM mapproveddb WHERE StudNum = '{RCSNBox.Text}' AND RecoveryPin = '{RPINBox.Text}'";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            credentialsFound = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (credentialsFound)
            {
                //if (CPVerifyCreds.Visible)
                //{
                //    CPVerifyCreds.Visible = false;
                //    CPNewPass.Visible = true;

                //}

                //else
                //{
                //    CPVerifyCreds.Visible = true;
                //    CPNewPass.Visible = false;
                //}
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }

            connection.Close();
        }

        //bool LFPass = false;
        //string PassFound = "";

        //foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
        //{

        //    string psn = row.Cells["ASNColumn"].Value?.ToString();
        //    string ppin = row.Cells["ARPinColumn"].Value?.ToString();

        //    if (psn == RCSNBox.Text && ppin == RPINBox.Text)
        //    {
        //        LFPass = true;
        //        PassFound = row.Cells["APassColumn"].Value.ToString();
        //        break;
        //    }

        //}
        //if (LFPass)
        //{
        //    MessageBox.Show("Your Password is " + PassFound, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show("Incorrect Student Number and Recovery Pin.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}


        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddUserToDictionary(string selectedUsername, string value)
        {
            dictionary.Add(selectedUsername, value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegiPassBox.UseSystemPasswordChar = !RegiShowPass.Checked;

        }

        private void RMBRCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void RTUBg_Click(object sender, EventArgs e)
        {

        }

        private void RecoveryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MorpheusPB_Click(object sender, EventArgs e)
        {
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MorpheusWCIcon_Click(object sender, EventArgs e)
        {

        }

        private void RegiRPLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegiGenderComboBox.SelectedItem != null)
            {
                RegiGenderComboBox.Text = RegiGenderComboBox.SelectedItem.ToString();
            }
        }

        private void RegiAgeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void CPChangeBtn_Click(object sender, EventArgs e)
        {
            string studNum = RCSNBox.Text;
            string recPin = RPINBox.Text;
            string newPass = NewPassBox.Text;
            string newConfirm = NewPassConfirmBox.Text;

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(newConfirm) || string.IsNullOrEmpty(recPin) || string.IsNullOrEmpty(studNum))
            {
                MessageBox.Show("Missing text in required fields.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newPass != newConfirm)
            {
                MessageBox.Show("Password does not match.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ... Your existing code ...

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(mysqlconn))
                    {
                        connection.Open();

                        // Query the database for the provided student number and RecoveryPin
                        string query = "SELECT UserID FROM mapproveddb WHERE StudNum = @StudNum AND RecoveryPin = @RecoveryPin";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@StudNum", studNum);
                            cmd.Parameters.AddWithValue("@RecoveryPin", recPin);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string userID = reader["UserID"].ToString();

                                    // Close the first DataReader before executing another query
                                    reader.Close();

                                    // Update the password-related columns in the database
                                    string updatedHashedPassword = HashHelper.HashString(newPass);

                                    // Update the database
                                    string updateQuery = "UPDATE mapproveddb SET PassHashed = @NewHashedPassword WHERE UserID = @UserID";
                                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCmd.Parameters.AddWithValue("@NewHashedPassword", updatedHashedPassword);
                                        updateCmd.Parameters.AddWithValue("@UserID", userID);

                                        updateCmd.ExecuteNonQuery();

                                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        HomePage.Show(); // Show the LHHomePage form

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Student account not found or incorrect Recovery PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }




        public class HashHelper
        {
            public static string HashString(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    string hashedString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    return hashedString;
                }
            }
        }
        public class HashHelper_Salt
        {
            public static string HashString_Salt(string input_Salt)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes_Salt = Encoding.UTF8.GetBytes(input_Salt);
                    byte[] hashBytes_Salt = sha256.ComputeHash(inputBytes_Salt);
                    string hashedString_Salt = BitConverter.ToString(hashBytes_Salt).Replace("-", "").ToLower();
                    return hashedString_Salt;
                }
            }
        }
        public class HashHelper_SaltperUser
        {
            public static string HashString_SaltperUser(string input_SaltperUser)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes_SaltperUser = Encoding.UTF8.GetBytes(input_SaltperUser);
                    byte[] hashBytes_SaltperUser = sha256.ComputeHash(inputBytes_SaltperUser);
                    string hashedString_SaltperUser = BitConverter.ToString(hashBytes_SaltperUser).Replace("-", "").ToLower();
                    return hashedString_SaltperUser;
                }
            }
        }
        public class RandomNumberGenerator
        {
            private static Random random = new Random();

            public static string GenerateRandomNumber()
            {
                var digits = Enumerable.Range(0, 10).ToList();

                for (int i = 0; i < digits.Count; i++)
                {
                    int j = random.Next(i, digits.Count);
                    int temp = digits[i];
                    digits[i] = digits[j];
                    digits[j] = temp;
                }
                string randomNumber = string.Join("", digits.Take(4));

                return randomNumber;
            }
        }
    }
}

//public class RandomNumberGenerator
//{
//    private static Random random = new Random();

//    public static string GenerateRandomNumber()
//    {
//        var digits = Enumerable.Range(0, 10).ToList();

//        // Shuffle the digits to ensure randomness
//        for (int i = 0; i < digits.Count; i++)
//        {
//            int j = random.Next(i, digits.Count);
//            int temp = digits[i];
//            digits[i] = digits[j];
//            digits[j] = temp;
//        }

//        // Create the random number with the first 4 digits being "2022"
//        digits.InsertRange(0, new List<int> { 2, 0, 2, 2 });

//        // Take the first 8 digits (in case the list has more than 8 digits)
//        string randomNumber = string.Join("", digits.Take(8));

//        return randomNumber;
//    }
//}
