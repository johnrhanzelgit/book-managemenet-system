using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //EmployeeID
            Random j = new Random();
            int employeeid = j.Next();
            lblid.Text = employeeid.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully entered the data. Have a nice day!");
        }

        private void lblid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldeductions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
