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

        private void SNBox_TextChanged(object sender, EventArgs e)
        {
            //student number textbox
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void SignUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SignUP Label

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

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            //Password Textbox

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Login Button

            
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
        }

       

        private void RegiNameBox_TextChanged(object sender, EventArgs e)
        {
            //Name Textbox
        }

        private void RegiSNBox_TextChanged(object sender, EventArgs e)
        {
            //Student Number Textbox
        }

        private void RegiPassBox_TextChanged(object sender, EventArgs e)
        {
            //Password Box
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