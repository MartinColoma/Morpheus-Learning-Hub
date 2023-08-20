using Microsoft.VisualBasic.Logging;
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

                String SN, Pass;
                SN = SNBox.Text;
                Pass = PassBox.Text;

                if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
                {
                    MessageBox.Show("Welcome back Admin.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    APanel.Show();
                    SNBox.Text = ""; // Clear the textbox
                    PassBox.Text = ""; // Clear the textbox
                }
                else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
                {
                    MessageBox.Show("Input your username or password", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool found = false;

                    // Iterate through rows in ApprovedTable DataGridView
                    foreach (DataGridViewRow row in AdminPanel.instance.ApprovedTable.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row if any
                        {
                            int asnColumnIndex = AdminPanel.instance.ApprovedTable.Columns["ASNColumn"].Index;
                            int apassColumnIndex = AdminPanel.instance.ApprovedTable.Columns["APassColumn"].Index;

                            string storedSN = row.Cells[asnColumnIndex].Value?.ToString();
                            string storedPass = row.Cells[apassColumnIndex].Value?.ToString();

                            if (storedSN == SNBox.Text && storedPass == PassBox.Text)
                            {
                                found = true;
                                break;
                            }
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show("Welcome back RTUista.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomePage.Show(); // Show the LHHomePage form
                        SNBox.Text = ""; // Clear the textbox
                        PassBox.Text = ""; // Clear the textbox
                    }
                    else
                    {
                        // Invalid credentials handling
                        MessageBox.Show("Invalid username or password", "Oooops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Disable the textboxes temporarily after three failed attempts
                        int failedAttempts = 0;
                        failedAttempts++;

                        if (failedAttempts >= 3)
                        {
                            SNBox.Enabled = false;
                            PassBox.Enabled = false;
                            MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                // Prevent further event handling for the Enter key

                e.SuppressKeyPress = true
        ;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Login Button

            

            String SN, Pass;
            SN = SNBox.Text;
            Pass = PassBox.Text;

            if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Welcome back Admin.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);

                APanel.Show();
                SNBox.Text = ""; // Clear the textbox
                PassBox.Text = ""; // Clear the textbox
            }
            else if (string.IsNullOrEmpty(SNBox.Text) || string.IsNullOrEmpty(PassBox.Text))
            {
                MessageBox.Show("Input your username or password", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool found = false;

                // Iterate through rows in ApprovedTable DataGridView
                foreach (DataGridViewRow row in AdminPanel.instance.ApprovedTable.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row if any
                    {
                        int asnColumnIndex = AdminPanel.instance.ApprovedTable.Columns["ASNColumn"].Index;
                        int apassColumnIndex = AdminPanel.instance.ApprovedTable.Columns["APassColumn"].Index;

                        string storedSN = row.Cells[asnColumnIndex].Value?.ToString();
                        string storedPass = row.Cells[apassColumnIndex].Value?.ToString();

                        if (storedSN == SNBox.Text && storedPass == PassBox.Text)
                        {
                            found = true;
                            break;
                        }
                    }
                }

                if (found)
                {
                    MessageBox.Show("Welcome back RTUista.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage.Show(); // Show the LHHomePage form
                    SNBox.Text = ""; // Clear the textbox
                    PassBox.Text = ""; // Clear the textbox
                }
                else
                {
                    // Invalid credentials handling
                    MessageBox.Show("Invalid username or password", "Oooops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Disable the textboxes temporarily after three failed attempts
                    int failedAttempts = 0;
                    failedAttempts++;

                    if (failedAttempts >= 3)
                    {
                        SNBox.Enabled = false;
                        PassBox.Enabled = false;
                        MessageBox.Show("You've exceeded the maximum number of attempts. Please contact an administrator.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



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
            //Login linked label
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //recovery pass textbox
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //Recovery Pass Submit Btn


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