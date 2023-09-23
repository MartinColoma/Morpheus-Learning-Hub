using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace C_Activity1
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        private MySqlConnection conn;


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



        public LoginForm()
        {
            InitializeComponent();
            String SN, Pass;
            SN = SNBox.Text; Pass = PassBox.Text;
            instance = this;
            FormBorderStyle = FormBorderStyle.FixedSingle;


            string mysqlconn = "server=localhost;user=root;database=learninghub;password=";
            conn = new MySqlConnection(mysqlconn);


            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RegiGenderComboBox.Items.AddRange(genders);
            RegiGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


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
                else
                {
                    bool found = false;
                    bool find = false;
                    //bool unknown = false;


                    int asnColumnIndex = AdminForm.instance.ApprovedTable.Columns["ASNColumn"].Index;
                    int apassColumnIndex = AdminForm.instance.ApprovedTable.Columns["APassColumn"].Index;
                    int anameColumnIndex = AdminForm.instance.ApprovedTable.Columns["ANameColumn"].Index;
                    int psnColumnIndex = AdminForm.instance.PendingTable.Columns["PSNColumn"].Index;
                    int ppassColumnIndex = AdminForm.instance.PendingTable.Columns["PPassColumn"].Index;


                    // Iterate through rows in ApprovedTable DataGridView
                    foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row if any
                        {

                            string storedSN = row.Cells[asnColumnIndex].Value?.ToString();
                            string storedPass = row.Cells[apassColumnIndex].Value?.ToString();


                            if (storedSN == SNBox.Text && storedPass == PassBox.Text)
                            {
                                found = true;
                                UserForm.instance.LHSNBox.Text = storedSN;
                                UserForm.instance.LHNameBox.Text = row.Cells[anameColumnIndex].Value?.ToString();
                                break;
                            }
                            else if (storedSN != SNBox.Text && storedPass == PassBox.Text)
                            {
                                HandleIncorrectInput("Incorrect Student Number.");

                            }
                            else if (storedSN == SNBox.Text && storedPass != PassBox.Text)
                            {
                                HandleIncorrectInput("Incorrect Password.");

                            }


                        }

                    }

                    foreach (DataGridViewRow rows in AdminForm.instance.PendingTable.Rows)
                    {
                        if (!rows.IsNewRow) // Skip the new row if any
                        {

                            string notStoredSN = rows.Cells[psnColumnIndex].Value?.ToString();
                            string notStoredPass = rows.Cells[ppassColumnIndex].Value?.ToString();

                            if (notStoredSN == SNBox.Text && notStoredPass == PassBox.Text)
                            {
                                find = true;
                                MessageBox.Show("Student Account is pending for approval.", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                        }
                    }


                    if (found)
                    {
                        MessageBox.Show("Welcome back RTUista.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomePage.Show(); // Show the LHHomePage form
                        ResetHideForm();

                    }
                    else if (find)
                    {
                        ResetForm();
                    }
                    else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
                    {
                        HandleIncorrectInput("Missing Student Number and Password.");
                    }
                    else if (!find && !found)
                    {
                        MessageBox.Show("Login Failed. Please try again.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



                // Prevent further event handling for the Enter key

                e.SuppressKeyPress = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Login BUtton

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
            else
            {
                bool found = false;
                bool find = false;
                //bool unknown = false;


                int asnColumnIndex = AdminForm.instance.ApprovedTable.Columns["ASNColumn"].Index;
                int apassColumnIndex = AdminForm.instance.ApprovedTable.Columns["APassColumn"].Index;
                int anameColumnIndex = AdminForm.instance.ApprovedTable.Columns["ANameColumn"].Index;

                //Pending Table Indexes
                int psnColumnIndex = AdminForm.instance.PendingTable.Columns["PSNColumn"].Index;
                int ppassColumnIndex = AdminForm.instance.PendingTable.Columns["PPassColumn"].Index;


                // Iterate through rows in ApprovedTable DataGridView
                foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row if any
                    {

                        string storedSN = row.Cells[asnColumnIndex].Value?.ToString();
                        string storedPass = row.Cells[apassColumnIndex].Value?.ToString();


                        if (storedSN == SNBox.Text && storedPass == PassBox.Text)
                        {
                            found = true;
                            UserForm.instance.LHSNBox.Text = storedSN;
                            UserForm.instance.LHNameBox.Text = row.Cells[anameColumnIndex].Value?.ToString();
                            break;
                        }
                        else if (storedSN != SNBox.Text && storedPass == PassBox.Text)
                        {
                            HandleIncorrectInput("Incorrect Student Number.");

                        }
                        else if (storedSN == SNBox.Text && storedPass != PassBox.Text)
                        {
                            HandleIncorrectInput("Incorrect Password.");

                        }


                    }

                }

                foreach (DataGridViewRow rows in AdminForm.instance.PendingTable.Rows)
                {
                    if (!rows.IsNewRow) // Skip the new row if any
                    {

                        string notStoredSN = rows.Cells[psnColumnIndex].Value?.ToString();
                        string notStoredPass = rows.Cells[ppassColumnIndex].Value?.ToString();

                        if (notStoredSN == SNBox.Text && notStoredPass == PassBox.Text)
                        {
                            find = true;
                            MessageBox.Show("Student Account is pending for approval.", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                    }
                }


                if (found)
                {
                    MessageBox.Show("Welcome back RTUista.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage.Show(); // Show the LHHomePage form
                    ResetHideForm();

                }
                else if (find)
                {
                    ResetForm();
                }
                else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
                {
                    //HandleIncorrectInput("Missing Student Number and Password.");
                    MessageBox.Show("Missing text on required Field.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!find && !found)
                {
                    MessageBox.Show("Login Failed. Please try again.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }



        //private void HandleIncorrectInput(string errorMessage)
        //{
        //    LoginfailedAttempts++;
        //    int LoginremainingAttempts = LoginmaxAttempt - LoginfailedAttempts;

        //    if (LoginremainingAttempts > 0)
        //    {
        //        MessageBox.Show($"Attempts remaining: {LoginremainingAttempts} \n{errorMessage} Check your input on required fields", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        LoginBtn.Enabled = false;
        //        LoginBtnTimer.Start();
        //        MessageBox.Show("You run out of attempts. Please try again after 15 seconds.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
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

                //string Btnname, BtnSN, BtnRP, BtnPass;
                //Btnname = RegiNameBox.Text; BtnSN = RegiSNBox.Text; BtnRP = RegiRPBox.Text; BtnPass = RegiPassBox.Text;

                //// Check if any of the input fields is empty
                //if (string.IsNullOrEmpty(Btnname) || string.IsNullOrEmpty(BtnSN) || string.IsNullOrEmpty(BtnRP) || string.IsNullOrEmpty(BtnPass))
                //{
                //    HandleIncorrectCreateInput("Missing text on required Field.");
                //    return; // Exit the method since there's an error
                //}
                //else if (Btnname == "Admin" || BtnSN == "Admin" || BtnPass == "Admin123")
                //{
                //    HandleIncorrectCreateInput("This student already has an account.");
                //    return;
                //}

                //Regex nameRegex = new Regex("^[A-Za-z ]+$");

                //if (!nameRegex.IsMatch(Btnname))
                //{
                //    HandleIncorrectCreateInput("Name must only contain alphabetic values.");
                //    return
                //    ;
                //}


                //// Check if the student number (BtnSN) already exists in ApprovedTable
                //bool isStudentInApprovedTable = IsStudentNumberInApprovedTable(BtnSN);
                //if (isStudentInApprovedTable)
                //{
                //    HandleApprovedUserInput("This student already has an account.");
                //    return; // Exit the method since there's an error
                //}

                //// Validate Student Number using Lambda
                //else if (!int.TryParse(BtnSN, out _))
                //{
                //    HandleIncorrectCreateInput("Incorrect Student Number.");
                //    return;
                //}
                //else if (IsPasswordTakenInTable(BtnPass, AdminForm.instance.ApprovedTable, "APassColumn"))
                //{
                //    HandleIncorrectCreateInput("Password is already taken.");
                //    return;
                //}
                //// Validate Password using Lambda
                ////Regex passwordRegex = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");
                //Regex passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");

                //if (!passwordRegex.IsMatch(BtnPass))
                //{
                //    HandleIncorrectCreateInput("Password must be at least 8 characters long and contain a combination of alphabetic characters, numeric digits, and special characters like (!, @, #, $, %, ^, &, *).");
                //    return;
                //}


                //// If everything is okay, proceed to add the record
                //if (!AdminForm.instance.existingSN.Contains(BtnSN))
                //{
                //    AdminForm.instance.existingSN.Add(BtnSN); // Add it to your existingSN list
                //    AdminForm.instance.AddDataGridView(Btnname, BtnSN, BtnRP, BtnPass);
                //    Btnname = "";
                //    BtnSN = "";
                //    BtnRP = "";
                //    BtnPass = "";
                //    MessageBox.Show("Account added for approval", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                //else
                //{
                //    MessageBox.Show("Student Number is pending for approval.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}



                //if (CreatefailedAttempts >= CreatemaxAttempt)
                //{
                //    CreateBtn.Enabled = false;
                //    MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                e.SuppressKeyPress = true;
            }


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Create Button
            string Btnname, BtnSN, BtnRP, BtnPass, BtnCourse, BtnAge, BtnGender;
            Btnname = RegiNameBox.Text;
            BtnSN = RegiSNBox.Text;
            BtnRP = RegiRPBox.Text;
            BtnPass = RegiPassBox.Text;
            BtnCourse = RegiCourseBox.Text;
            BtnAge = RegiAgeBox.Text;
            BtnGender = RegiGenderComboBox.Text;

            // Regex patterns
            Regex nameRegex = new Regex("^[A-Z][a-zA-Z]+(?: [a-zA-Z]+)*$");
            Regex courseRegex = new Regex("^[A-Za-z]+(?: [A-Za-z]+)*$");
            Regex passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]{8,}$");

            // Check if any of the input fields is empty
            if (string.IsNullOrEmpty(Btnname) || string.IsNullOrEmpty(BtnSN) || string.IsNullOrEmpty(BtnRP) ||
                string.IsNullOrEmpty(BtnPass) || string.IsNullOrEmpty(BtnAge) || string.IsNullOrEmpty(BtnCourse) ||
                string.IsNullOrEmpty(BtnGender))
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
            else if (!int.TryParse(BtnSN, out _))
            {
                HandleIncorrectCreateInput("Incorrect Student Number.");
                return;
            }
            else if (!passwordRegex.IsMatch(BtnPass))
            {
                HandleIncorrectCreateInput("Password must be at least 8 characters long and contain a combination of alphabetic characters, numeric digits, and special characters like (!, @, #, $, %, ^, &, *).");
                return;
            }

            // If everything is okay, proceed to add the record
            if (!AdminForm.instance.existingSN.Contains(BtnSN))
            {
                AdminForm.instance.existingSN.Add(BtnSN); // Add it to your existingSN list
                AdminForm.instance.AddDataGridView(Btnname, BtnAge, BtnGender, BtnCourse, BtnSN, BtnRP, BtnPass);
                MessageBox.Show("Account added for approval", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student Number is pending for approval.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        //private void CreateBtn_Click(object sender, EventArgs e)
        //{
        //    // ... (existing code)

        //    // Check if the provided password is already taken in ApprovedTable or PendingTable


        //    // ... (existing code)

        //    // If everything is okay, proceed to add the record
        //    // ... (existing code)
        //}

        private bool IsPasswordTakenInTable(string password, DataGridView dataGridView, string passwordColumnName)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[passwordColumnName].Value != null && row.Cells[passwordColumnName].Value.ToString() == password)
                {
                    return true;
                }
            }
            return false;
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
            bool LFPass = false;
            string PassFound = "";

            foreach (DataGridViewRow row in AdminForm.instance.ApprovedTable.Rows)
            {

                string psn = row.Cells["ASNColumn"].Value?.ToString();
                string ppin = row.Cells["ARPinColumn"].Value?.ToString();

                if (psn == RCSNBox.Text && ppin == RPINBox.Text)
                {
                    LFPass = true;
                    PassFound = row.Cells["APassColumn"].Value.ToString();
                    break;
                }

            }
            if (LFPass)
            {
                MessageBox.Show("Your Password is " + PassFound, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect Student Number and Recovery Pin.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



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
    }
}