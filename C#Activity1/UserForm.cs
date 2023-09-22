﻿using System;
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
    public partial class UserForm : Form
    {
        public static UserForm instance;

        public UserForm()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing.
                e.Cancel = true;
                // Hide the form instead of closing it.
                this.Hide();
                LoginForm.instance.Show();

            }
        }


        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void RTUSealXL_Click(object sender, EventArgs e)
        {

        }

        private void UserCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LHWelcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LHMenuColumn.Visible)
            {
                LHMenuColumn.Visible = false;
                LHMenuColumn.Location = new Point(-220, 98);
            }
            else
            {
                LHMenuColumn.Visible = true;
                LHMenuColumn.Location = new Point(0, 98);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (LHMenuColumn.Visible)
            {
                LHMenuColumn.Visible = false;
                LHMenuColumn.Location = new Point(-220, 98);
            }
            else
            {
                LHMenuColumn.Visible = true;
                LHMenuColumn.Location = new Point(0, 98);
            }
        }

        private void LHMenuColumn_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LHDeptLbl_Click(object sender, EventArgs e)
        {

        }

        private void LHNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoutLinkedLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
                LoginForm.instance.Show();

            }
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
                LoginForm.instance.Show();

            }

        }
    }
}