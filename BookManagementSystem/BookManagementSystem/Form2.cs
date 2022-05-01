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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random zel = new Random();
            int employeeid = zel.Next();
            lblemployee.Text = employeeid.ToString();

        }

        public class PayrollDetails
        {
            string firstname, lastname;
            double basicsalary_single, basicsalary_married, tax_single, tax_marrried, deductions_single, deductions_married, home_pay_single, home_pay_married, bi_monthly_single, bi_monthly_married;
            int sss_number, pagibig_number, philhealth_number, sss_married, pagibig_married, philhealth_married;
            int sss_single = 1500;
            int pagibig_single = 500;
            int philhealth_single = 350;



            public string Firstname
            {
                get
                {
                    return firstname;
                }
                set
                {
                    this.firstname = value;
                }
            }

            public string Lasttname
            {
                get
                {
                    return lastname;
                }
                set
                {
                    this.lastname = value;
                }
            }

            public int SSS
            {
                get
                {
                    return sss_number;
                }
                set
                {
                    this.sss_number = value;
                }
            }

            public int Pagibig
            {
                get
                {
                    return pagibig_number;
                }
                set
                {
                    this.pagibig_number = value;
                }
            }

            public int Philhealth
            {
                get
                {
                    return philhealth_number;
                }
                set
                {
                    this.philhealth_number = value;
                }
            }

            public double Basicsalary_single
            {
                get
                {
                    return basicsalary_single;
                }
                set
                {
                    this.basicsalary_single = value;
                }
            }

            public double Basicsalary_married
            {
                get
                {
                    return basicsalary_married;
                }
                set
                {
                    this.basicsalary_married = value;
                }
            }

            public int SSS_single
            {
                get
                {
                    return sss_single;
                }
                set
                {
                    this.sss_single = value;
                }
            }

            public int SSS_married
            {
                get
                {
                    return sss_married;
                }
                set
                {
                    this.sss_married = 1300;
                }
            }

            public int Pagibig_single
            {
                get
                {
                    return pagibig_single;
                }
                set
                {
                    this.pagibig_single = value;
                }
            }

            public int Pagibig_married
            {
                get
                {
                    return pagibig_married;
                }
                set
                {
                    this.pagibig_married = 430;
                }
            }

            public int Philhealth_single
            {
                get
                {
                    return philhealth_single;
                }
                set
                {
                    this.philhealth_single = value;
                }
            }

            public int Philhealth_married
            {
                get
                {
                    return philhealth_married;
                }
                set
                {
                    this.philhealth_married = 190;
                }
            }

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname, lastname, maritalstats;
                double basicsalary, sss, pagibig, philhealth, deductions, tax, homepay, monthlypay;

                firstname = txtbEmpFirNam.Text;
                lastname = txtbEmpLasNam.Text;
                basicsalary = Convert.ToDouble(txtbBasSal.Text);
                sss = Convert.ToDouble(txtsss.Text);
                pagibig = Convert.ToDouble(txtpagibig.Text);
                philhealth = Convert.ToDouble(txtphilhealth.Text);

                tax = (basicsalary * .12);
                deductions = (tax + sss + pagibig + philhealth);
                homepay = (basicsalary - deductions);
                monthlypay = (homepay / 2);

                this.Hide();
                Form3 jzel = new Form3();
                jzel.lblfname.Text = firstname;
                jzel.lbllast.Text = lastname;
                jzel.lbldeductions.Text = deductions.ToString();
                jzel.lblhome.Text = homepay.ToString();
                jzel.lblmonthly.Text = monthlypay.ToString();

                if (btnsingle.Checked == true)
                {
                    maritalstats = "Single";
                    jzel.lblmarital.Text = maritalstats;
                }
                else
                {
                    maritalstats = "Married";
                    jzel.lblmarital.Text = maritalstats;
                }



                this.Hide();
                jzel.ShowDialog();
            }
            catch(Exception er)
            {
                MessageBox.Show("There is an error with the program!", "Program Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblemployee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
