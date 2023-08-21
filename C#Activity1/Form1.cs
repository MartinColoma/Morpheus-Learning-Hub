using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;
using System.Numerics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_Activity1
{
    public partial class RTULogin : Form
    {
        public static RTULogin instance;

        AdminPanel APanel = new AdminPanel();
        LHHomePage HomePage = new LHHomePage();
        public new Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private const int maxAttempt = 3;
        int failedAttempts = 0;

        public RTULogin()
        {
            InitializeComponent();
            String SN, Pass;
            SN = SNBox.Text; Pass = PassBox.Text;
            
            instance = this;
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
            failedAttempts = 0;
            LoginBtn.Enabled = true;
        }

        private void SignUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Sign UP Label

            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                RecoveryPanel.Visible = false;
                RegiPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RegiPanel.Visible = false;
                RecoveryPanel.Visible = true;
                LoginPanel.Visible = true;
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Forgot Pass
            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                RegiPanel.Visible = false;
                RecoveryPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RecoveryPanel.Visible = false;
                RecoveryPanel.Visible = true;
                LoginPanel.Visible = true;
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
                    MessageBox.Show("Welcome back Admin.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    APanel.Show();
                    ResetForm();
                }
                else
                {
                    bool foundInPending = false;
                    bool foundInApproved = false;

                    foreach (DataGridViewRow row in AdminPanel.instance.PendingTable.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string psn = row.Cells["PSNColumn"].Value?.ToString();
                            string ppass = row.Cells["PPassColumn"].Value?.ToString();

                            if (psn == SNBox.Text && ppass == PassBox.Text)
                            {
                                foundInPending = true;
                                break;
                            }
                        }
                    }

                    foreach (DataGridViewRow row in AdminPanel.instance.ApprovedTable.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string asn = row.Cells["ASNColumn"].Value?.ToString();
                            string apass = row.Cells["APassColumn"].Value?.ToString();

                            if (asn == SNBox.Text && apass == PassBox.Text)
                            {
                                foundInApproved = true;
                                HomePage.Show();
                                ResetForm();
                                break;
                            }
                            else if (asn == SNBox.Text)
                            {
                                HandleIncorrectInput("Incorrect Password.");
                            }
                        }
                    }

                    if (foundInPending)
                    {
                        MessageBox.Show("Student Account is pending for approval.", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!foundInApproved)
                    {
                        HandleIncorrectInput("Incorrect Student Number and Password.");
                    }
                }

                if (failedAttempts >= maxAttempt)
                {
                    LoginBtn.Enabled = false;
                }


                // Prevent further event handling for the Enter key

                e.SuppressKeyPress = true
        ;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //LoginButton

            if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Welcome back Admin.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                APanel.Show();
                ResetForm();
            }
            else
            {
                bool foundInPending = false;
                bool foundInApproved = false;

                foreach (DataGridViewRow row in AdminPanel.instance.PendingTable.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string psn = row.Cells["PSNColumn"].Value?.ToString();
                        string ppass = row.Cells["PPassColumn"].Value?.ToString();

                        if (psn == SNBox.Text && ppass == PassBox.Text)
                        {
                            foundInPending = true;
                            break;
                        }
                    }
                }

                foreach (DataGridViewRow row in AdminPanel.instance.ApprovedTable.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string asn = row.Cells["ASNColumn"].Value?.ToString();
                        string apass = row.Cells["APassColumn"].Value?.ToString();

                        if (asn == SNBox.Text && apass == PassBox.Text)
                        {
                            foundInApproved = true;
                            HomePage.Show();
                            ResetForm();
                            break;
                        }
                        else if (asn == SNBox.Text)
                        {
                            HandleIncorrectInput("Incorrect Password.");
                        }
                    }
                }

                if (foundInPending)
                {
                    MessageBox.Show("Student Account is pending for approval.", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!foundInApproved)
                {
                    HandleIncorrectInput("Incorrect Student Number and Password.");
                }
            }

            if (failedAttempts >= maxAttempt)
            {
                LoginBtn.Enabled = false;
            }
        }

        private void HandleIncorrectInput(string errorMessage)
        {
            failedAttempts++;
            int remainingAttempts = maxAttempt - failedAttempts;

            if (remainingAttempts > 0)
            {
                MessageBox.Show($"{errorMessage} Please check your input. Attempts remaining: {remainingAttempts}", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginBtn.Enabled = false;
                MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            SNBox.Text = "";
            PassBox.Text = "";
            failedAttempts = 0;
            LoginBtn.Enabled = true;
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            //Create Button
            String Btnname, BtnSN, BtnRP, BtnPass;
            Btnname = RegiNameBox.Text; BtnSN = RegiSNBox.Text; BtnRP = RegiRPBox.Text; BtnPass = RegiPassBox.Text;
            if (Btnname != "" || BtnSN != "" || BtnRP != "" || BtnPass != "")
            {
                if (!AdminPanel.instance.existingSN.Contains(BtnSN))
                {
                    AdminPanel.instance.existingSN.Contains(BtnSN);
                    AdminPanel.instance.AddDataGridView(Btnname, BtnSN, BtnRP, BtnPass);
                    Btnname = "";
                    BtnSN = "";
                    BtnRP = "";
                    BtnPass = "";
                    MessageBox.Show("Account added for approval", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Student Number already exists.", "Ooooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Register to Login Link Label
            if (RegiPanel.Visible)
            {
                RegiPanel.Visible = false;
                LoginPanel.Visible = true;
                RecoveryPanel.Visible = false;
                RegiNameBox.Text = "";
                RegiSNBox.Text = "";
                RegiRPBox.Text = "";
                RegiPassBox.Text = "";
            }

            else
            {
                LoginPanel.Visible = false;
                RegiPanel.Visible = true;
                RecoveryPanel.Visible = false;

            }


            
        }

        private void RegiPanel_Paint(object sender, PaintEventArgs e)
        {
            //register panel


        }

        private void GSLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //RecoverLabel
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Forgot Pass linked label
            if (LoginPanel.Visible)
            {
                LoginPanel.Visible = false;
                RecoveryPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RecoveryPanel.Visible = false;
                LoginPanel.Visible = true;
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

            foreach (DataGridViewRow row in AdminPanel.instance.ApprovedTable.Rows)
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


    }
}