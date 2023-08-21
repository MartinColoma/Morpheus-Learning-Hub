using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Activity1
{
    public partial class LHHomePage : Form
    {
        public static LHHomePage instance;

        public LHHomePage()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing.
                e.Cancel = true;
                // Hide the form instead of closing it.
                this.Hide();
            }
        }


        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void RTUSealXL_Click(object sender, EventArgs e)
        {

        }
    }
}
