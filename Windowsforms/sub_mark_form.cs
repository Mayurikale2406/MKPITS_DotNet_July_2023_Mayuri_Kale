using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace submarkform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p, m, h;
            int total;
            float per;
            string grade=null;

             p = Convert.ToInt32(textBox1.Text);
             m = Convert.ToInt32(textBox2.Text);
             h = Convert.ToInt32(textBox3.Text);

            total = h + m + p;
            per = (total / 300.0f) * 100.0f;
            label4.Text = "total " + total;
            label5.Text = "percentage " + per;
            if(per>75)
                
            {
                grade = "distinction";
            }
            else if(per>=60 && per<75)
            {
                grade = "first class";
            }
            else if(per>=40 && per<60)
            {
                grade = "second class";
            }
            else
            {
                grade = "fail";
            }
            label6.Text = "grade " + grade;

        }
    }
}
