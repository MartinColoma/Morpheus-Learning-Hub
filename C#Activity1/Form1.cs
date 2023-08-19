using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace C_Activity1
{
    public partial class RTULogin : Form
    {
        public RTULogin()
        {
            InitializeComponent();
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
                RegiPanel.Visible = true;
                SNBox.Text = "";
                PassBox.Text = "";
            }

            else
            {
                RegiPanel.Visible = false;
                LoginPanel.Visible = true;
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Forgot Pass
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

        private void RMBRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Remember Me Checkbox
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

                // Check login credentials


                if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
                {
                    AdminPanel APanel = new AdminPanel();
                    Hide();
                    APanel.Show();
                }

                else

                {
                    MessageBox.Show("Glad you're back Admin.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                // Prevent further event handling for the Enter key

                e.SuppressKeyPress = true
        ;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Login Button

            if (SNBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Input your username or password", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Glad you're back Admin.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPanel APanel = new AdminPanel();
                Hide();
                APanel.Show();

            }
            else
            {

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
        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Login linked label
            if (RegiPanel.Visible)
            {
                RegiPanel.Visible = false;
                LoginPanel.Visible = true;
                RegiNameBox.Text = "";
                RegiSNBox.Text = "";
                RegiRPBox.Text = "";
                RecoveryPanel.Visible = false;
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //Recovery Pass Submit Btn


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //recovery pass textbox
        }

        
    }
}