using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_Activity1
{
    public partial class RTULogin : Form
    {
        AdminPanel APanel = new AdminPanel();

        public RTULogin()
        {
            InitializeComponent();
            String SN, Pass;
            SN = SNBox.Text; Pass = PassBox.Text;
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
                RecoveryPanel.Visible= true;
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
                String SN, Pass;
                SN = SNBox.Text; Pass = PassBox.Text;

                if (SN == "Admin" && Pass == "Admin123")
                {
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

            if (SNBox.Text == "Admin" && PassBox.Text == "Admin123")
            {
                MessageBox.Show("Welcome back Admin.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPanel APanel = new AdminPanel();

                APanel.Show();
            }
            else if (SNBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SNBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Input your username or password", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            String Btnname,BtnSN, BtnRP, BtnPass;
            Btnname = RegiNameBox.Text; BtnSN = RegiSNBox.Text; BtnRP = RegiRPBox.Text; BtnPass = RegiPassBox.Text;
            if (Btnname != "" || BtnSN!="" || BtnRP!="" || BtnPass != "")
            {
                //if (!AdminPanel.instance.existingStudentNumber.Contain(name, sn, rp, pass))
                //{
                //    AdminPanel.instance.existingStudentNumber.Add();
                //    AdminPanel.instance.AddDataGridView(name, sn, rp, pass);
                //    Btnname = "";
                //    BtnSN = "";
                //    BtnRP = "";
                //    BtnPass = "";
                //    MessageBox.Show("Account added for approval", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //}
                //else
                //{

                //}
            }



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
    }
}