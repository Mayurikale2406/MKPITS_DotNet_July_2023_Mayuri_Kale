using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root_quadratic_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            int result;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            result = b * b - 2 * a * c;
            label4.Text = "result : " + result;
            if(result!=0)
            {
                label4.Text="it is imaginary root";

            }
            else
            {
                label4.Text = "it is not imaginary root";
            }
        }
    }
}
