using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


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
        private int minTextLength = 5; // Minimum required text length

        private Dictionary<string, string> accountData = new Dictionary<string, string>();


        //College Program List
        private List<string> collegePrograms = new List<string>
        {
            "Enter College Program",
            "Bachelor of Science in Mechanical Engineering",
            "Bachelor of Science in Architecture",
            "Bachelor of Science in Civil Engineering",
            "Bachelor of Science in Electrical Engineering",
            "Bachelor of Science in Electronics Engineering",
            "Bachelor of Science in Computer Engineering",
            "Bachelor of Science in Industrial Engineering",
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Instrumentation and Control Engineering",
            "Bachelor of Science in Mechatronics",
            "Bachelor of Science in Accountancy",
            "Bachelor of Science in Entrepreneurship",
            "Bachelor of Science in Office Administration",
            "Bachelor of Science in Business Administration major in Operations Management",
            "Bachelor of Science in Business Administration major in Marketing Management",
            "Bachelor of Science in Business Administration major in Financial Management",
            "Bachelor of Science in Business Administration major in Human Resource Management",
            "Bachelor of Secondary Education major in English",
            "Bachelor of Secondary Education major in Math",
            "Bachelor of Secondary Education major in Science",
            "Bachelor of Secondary Education major in Social Studies",
            "Bachelor of Secondary Education Major in Filipino",
            "Bachelor of Technical-Vocational Teacher Education major in Animation",
            "Bachelor of Technical-Vocational Teacher Education major in Computer Hardware Servicing",
            "Bachelor of Technical-Vocational Teacher Education major in Visual Graphic Design",
            "Bachelor or Technical-Vocational Teacher Education Major in Garments Fashion and Design",
            "Bachelor or Technical-Vocational Teacher Education Major in Electronics Technology",
            "Bachelor or Technical-Vocational Teacher Education Major in Welding and Fabrications Technology",
            "Bachelor of Science in Psychology",
            "Bachelor of Arts in Political Science",
            "Bachelor of Science in Statistics",
            "Bachelor of Science in Biology",
            "Bachelor of Science in Astronomy",
            "Bachelor of Science in Physical Education"
        };
        private List<string> suggestions = new List<string>();
        private bool placeholderShown = true; // Flag to track if the placeholder is currently displayed


        public LoginForm()
        {
            InitializeComponent();
            String SN, Pass;
            SN = SNComboBox.Text; Pass = PassBox.Text;
            instance = this;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            RegiGenderComboBox.Items.AddRange(genders);
            RegiGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;



            using (MySqlConnection connection = new MySqlConnection(mysqlconn))
            {
                try
                {
                    MessageBox.Show("Welcome to Morpheus. Do you wish to continue?", "Welcome Dreamers!", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

            studNumRefresher();

            CollegeProgramComboBox.Items.AddRange(collegePrograms.ToArray());

            CollegeProgramComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CollegeProgramComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CollegeProgramComboBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            CollegeProgramComboBox.AutoCompleteCustomSource.AddRange(collegePrograms.ToArray());

            CollegeProgramComboBox.KeyUp += CollegeProgramComboBox_KeyUp;
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

            studNumRefresher();

            //Login Panel to Register Panel Linked Label

            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                RecoveryPanel.Visible = false;
                WCPanel.Visible = false;
                RegiPanel.Visible = true;
                SNComboBox.Text = "";
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
                SNComboBox.Text = "";
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

                if (SNComboBox.Text == "Admin" && PassBox.Text == "Admin123")
                {
                    MessageBox.Show("Welcome back Admin.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    APanel.Show();
                    rememberAccount();
                    ResetHideForm();

                }
                else if (SNComboBox.Text != "Admin" && PassBox.Text == "Admin123")
                {
                    HandleIncorrectInput("Incorrect Student Number.");
                }
                else if (SNComboBox.Text == "Admin" && PassBox.Text != "Admin123")
                {
                    HandleIncorrectInput("Incorrect Password.");
                }
                else if (string.IsNullOrEmpty(SNComboBox.Text) || string.IsNullOrEmpty(PassBox.Text))
                {
                    MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string studNum = SNComboBox.Text;
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
                        string queryApproved = "SELECT Name, StudNum, Course, PassHashed FROM mapproveddb WHERE StudNum = @StudNum";

                        using (MySqlCommand cmdApproved = new MySqlCommand(queryApproved, connection))
                        {
                            cmdApproved.Parameters.AddWithValue("@StudNum", studNum);

                            using (MySqlDataReader readerApproved = cmdApproved.ExecuteReader())
                            {
                                if (readerApproved.Read())
                                {
                                    // Retrieve user information
                                    string name = readerApproved["Name"].ToString();
                                    string studentNumber = readerApproved["StudNum"].ToString();
                                    string course = readerApproved["Course"].ToString();

                                    // Retrieve the PassHashed column
                                    string hashedPasswordFromDB = readerApproved["PassHashed"].ToString();

                                    // Check if the entered password matches
                                    bool passwordMatches = hashedPasswordFromDB.Equals(passchecker);

                                    if (passwordMatches)
                                    {
                                        MessageBox.Show("Welcome back, Dreamers.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        HomePage.Show(); // Show the LHHomePage form

                                        // Populate the textboxes in HomePage form
                                        HomePage.LHNameBox.Text = name;
                                        HomePage.LHSNBox.Text = studentNumber;
                                        HomePage.LHCourseBox.Text = course;
                                        rememberAccount();
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

            if (SNComboBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Welcome back Admin.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                APanel.Show();
                rememberAccount();
                ResetHideForm();

            }
            else if (SNComboBox.Text != "Admin" && PassBox.Text == "Admin123")
            {
                HandleIncorrectInput("Incorrect Student Number.");
            }
            else if (SNComboBox.Text == "Admin" && PassBox.Text != "Admin123")
            {
                HandleIncorrectInput("Incorrect Password.");
            }
            else if (string.IsNullOrEmpty(SNComboBox.Text) || string.IsNullOrEmpty(PassBox.Text))
            {
                MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string studNum = SNComboBox.Text;
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
                    string queryApproved = "SELECT Name, StudNum, Course, PassHashed FROM mapproveddb WHERE StudNum = @StudNum";

                    using (MySqlCommand cmdApproved = new MySqlCommand(queryApproved, connection))
                    {
                        cmdApproved.Parameters.AddWithValue("@StudNum", studNum);

                        using (MySqlDataReader readerApproved = cmdApproved.ExecuteReader())
                        {
                            if (readerApproved.Read())
                            {
                                // Retrieve user information
                                string name = readerApproved["Name"].ToString();
                                string studentNumber = readerApproved["StudNum"].ToString();
                                string course = readerApproved["Course"].ToString();

                                // Retrieve the PassHashed column
                                string hashedPasswordFromDB = readerApproved["PassHashed"].ToString();

                                // Check if the entered password matches
                                bool passwordMatches = hashedPasswordFromDB.Equals(passchecker);

                                if (passwordMatches)
                                {
                                    MessageBox.Show("Welcome back, Dreamers.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    HomePage.Show(); // Show the LHHomePage form

                                    // Populate the textboxes in HomePage form
                                    HomePage.LHNameBox.Text = name;
                                    HomePage.LHSNBox.Text = studentNumber;
                                    HomePage.LHCourseBox.Text = course;
                                    rememberAccount();
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
            SNComboBox.Text = "";
            PassBox.Text = "";
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;

        }

        private void ResetHideForm()
        {
            SNComboBox.Text = "";
            PassBox.Text = "";
            LoginfailedAttempts = 0;
            LoginBtn.Enabled = true;
            this.Hide();

        }

        private void rememberAccount()
        {
            string newItem = SNComboBox.Text.Trim();
            string newPassword = PassBox.Text.Trim();

            bool itemExists = SNComboBox.Items.Contains(newItem);

            if (RMBRCheckbox.Checked == true && !itemExists)
            {
                // Store username and password in the dictionary
                accountData[newItem] = newPassword;

                // Add the username to the combo box
                SNComboBox.Items.Add(newItem);

                // Clear the textboxes
                SNComboBox.SelectedIndex = SNComboBox.Items.IndexOf(newItem);
                SNComboBox.Text = "";
                PassBox.Text = "";
            }
        }

        private void SNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a username is selected from the combo box,
            // fill the username and password textboxes
            string selectedItem = SNComboBox.SelectedItem as string;
            if (selectedItem != null && accountData.ContainsKey(selectedItem))
            {
                PassBox.Text = accountData[selectedItem];
            }
        }

        private void RegiNameBox_TextChanged(object sender, EventArgs e)
        {
            //Register Name Textbox
        }

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
                BtnCourse = CollegeProgramComboBox.Text;//RegiCourseBox.Text;
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
                studNumRefresher();
                RegiRPBox.Text = "";
                RegiPassBox.Text = "";
                RegiCourseBox.Text = "";
                RegiAgeBox.Text = "";
                RegiGenderComboBox.SelectedIndex = -1;
                RegiMailBox.Text = "";

                e.SuppressKeyPress = true;
            }


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Create Button
            string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender, BtnMail, BtnRole;
            Btnname = RegiNameBox.Text;
            BtnSN = RegiSNBox.Text;
            BtnRP = RegiRPBox.Text;
            BtnPass = RegiPassBox.Text;
            BtnCourse = CollegeProgramComboBox.Text;//RegiCourseBox.Text;
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
            studNumRefresher();
            RegiRPBox.Text = "";
            RegiPassBox.Text = "";
            RegiCourseBox.Text = "";
            RegiAgeBox.Text = "";
            RegiGenderComboBox.SelectedIndex = -1;
            RegiMailBox.Text = "";

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
                SNComboBox.Text = "";
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
            string newConfirm = ConfirmNewPassBox.Text;

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

                RCSNBox.Text = "";
                RPINBox.Text = "";
                NewPassBox.Text = "";
                ConfirmNewPassBox.Text = "";


            }
        }

        private void NewPassConfirmBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string studNum = RCSNBox.Text;
                string recPin = RPINBox.Text;
                string newPass = NewPassBox.Text;
                string newConfirm = ConfirmNewPassBox.Text;

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

                    RCSNBox.Text = "";
                    RPINBox.Text = "";
                    NewPassBox.Text = "";
                    ConfirmNewPassBox.Text = "";


                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            studNumRefresher();
        }

        private void studNumRefresher()
        {
            RegiSNBox.Text = "";
            ID = RandomNumberGenerator.GenerateRandomNumber();
            string BtnSN = RegiSNBox.Text;
            RegiSNBox.Text = ID + "-" + BtnSN;
        }

        private void NewPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            NewPassBox.UseSystemPasswordChar = !ShowPassCheck.Checked;

        }

        private void ConfirmNewPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConfirmNewPassBox.UseSystemPasswordChar = !ShowPassCheck.Checked;

        }

        private void SNComboBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CollegeProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CollegeProgramComboBox.SelectedIndex == 0) // Placeholder item selected
            {
                // Handle the selection of the placeholder item (e.g., display a message)
            }
        }

        private void CollegeProgramComboBox_TextChanged(object sender, EventArgs e)
        {
            //string userInput = CollegeProgramComboBox.Text;

            //if (!placeholderShown)
            //{
            //    // Filter the suggestions based on user input
            //    var filteredSuggestions = collegePrograms
            //        .Where(program => program.Contains(userInput, StringComparison.OrdinalIgnoreCase))
            //        .ToList();

            //    CollegeProgramComboBox.AutoCompleteCustomSource.Clear();
            //    CollegeProgramComboBox.AutoCompleteCustomSource.AddRange(filteredSuggestions.ToArray());

            //    if (string.IsNullOrWhiteSpace(userInput))
            //    {
            //        suggestions.Add("Enter College Program");
            //        placeholderShown = true;
            //        CollegeProgramComboBox.Text = "Enter College Program";
            //    }
            //}
        }
        private void CollegeProgramComboBox_GotFocus(object sender, EventArgs e)
        {
            if (placeholderShown)
            {
                CollegeProgramComboBox.Text = "";
                placeholderShown = false;
            }
        }

        private void CollegeProgramComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                string userInput = CollegeProgramComboBox.Text;
                var filteredSuggestions = collegePrograms
                    .Where(program => program.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                CollegeProgramComboBox.AutoCompleteCustomSource.Clear();
                CollegeProgramComboBox.AutoCompleteCustomSource.AddRange(filteredSuggestions.ToArray());
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
