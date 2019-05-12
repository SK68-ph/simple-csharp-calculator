using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring Variables
        double temp;
        bool add = false;
        bool sub = false;
        bool mul = false;
        bool div = false;
        bool pnt = false;



        private void btn0_Click(object sender, EventArgs e)
        {
            //concatenate the numbers pressed as string in textbox
            txtbox1.Text = txtbox1.Text + btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox1.Text + btn9.Text;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            
            try
            {
                div = true; //mark what the selected operation is selected
                temp = Convert.ToDouble(txtbox1.Text); //convert to double
                txtbox1.Text = "";
            }
            catch (System.FormatException ) // prints error if operation/inputs are null
            {
                txtbox1.Text = "ERROR";
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            try
            {
                mul = true;
                temp = Convert.ToDouble(txtbox1.Text);
                txtbox1.Text = "";
            }
            catch (System.FormatException)
            {
                txtbox1.Text = "ERROR";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try {
                add = true;
                temp = Convert.ToDouble(txtbox1.Text);
                txtbox1.Text = "";
            } catch (System.FormatException)
            {
                txtbox1.Text = "ERROR";
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                sub = true;
                temp = Convert.ToDouble(txtbox1.Text);
                txtbox1.Text = "";
            }
            catch (System.FormatException )
            {
                txtbox1.Text = "ERROR";
            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            pnt = true;
            txtbox1.Text = txtbox1.Text + btnpoint.Text;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
            {
                double temp2 = Convert.ToDouble(txtbox1.Text);
                txtbox1.Text = "";
                double result = 0;

                //test what the user's selected operation and calculate 
                if (div == true)
                {

                    result = temp / temp2;
                }
                else if (mul == true)
                {
                    result = temp * temp2;
                }

                else if (add == true)
                {
                    result = temp + temp2;
                }

                else if (sub == true)
                {
                    result = temp - temp2;
                }

                else if (pnt == true)
                {
                    result = (temp + temp2) / 2;
                }
                txtbox1.Text = result.ToString(); // convert to string
                disable(); // reset variables
            }
            catch (System.FormatException)
            {
                txtbox1.Text = "ERROR";
            }
        }
        public void disable()
        {
            add = false;
            sub = false;
            mul = false;
            div = false;
            pnt = false;

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            try
            {
                int lenght = txtbox1.Text.Length;
                txtbox1.Text = txtbox1.Text.Substring(0, lenght - 1);

            }
            catch (System.ArgumentOutOfRangeException a)
            {
                MessageBox.Show("Textbox Is Null" + "\n" + a.ToString().Substring(0 , 100)+ "...");
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            disable();
            temp = 0;
            
        }

        
    }
}
