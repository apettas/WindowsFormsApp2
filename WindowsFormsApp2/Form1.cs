using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ("εδώ είμαι");
            double one =0;
            double two =0;
            double result;



            one = double.Parse(txt1.Text);
            
            two = double.Parse (txt2.Text);

            result = one + two;




            //txtresult.Text = Convert.ToString( result);
            txtresult.Text = result.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txtresult.Text = "";
           
        }
    }
}
