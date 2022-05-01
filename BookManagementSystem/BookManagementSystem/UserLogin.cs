using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 zel = new Form2();
            string employeeuser, employeepassword;

            employeeuser = txtUsername.Text;
            employeepassword = txtPassword.Text;

           //txtPassword.Text = "";
            //txtPassword.PasswordChar = '*';

            if(employeeuser == "admin" && employeepassword == "1234")
            {
                MessageBox.Show("Loading Info...", "Program Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                zel.ShowDialog();
            }
            else if (employeeuser == "employee" && employeepassword == "7894")
            {
                MessageBox.Show("Loading Info...", "Program Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                zel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login! Try again...", "Program Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
