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
    public partial class AdminPanel : Form
    {

        public static AdminPanel instance;
        public AdminPanel()
        {
            InitializeComponent();
            instance = this;

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pending Table



        }

        public void AddDataGridView(string name, string sn, string rp, string pass)
        {
            PendingTable.Rows.Add(name, sn, rp, pass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PendingLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApprovedTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Approved Table


        }

        public void AddDataGridView1(string name, string sn, string rp, string pass)
        {

            ApprovedTable.Rows.Add(name, sn, rp, pass);
        }

        internal void SetPendingData(string name, string sn, string rp, string password)
        {
            throw new NotImplementedException();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            //ApproveBtn


            
        }
    }
}
