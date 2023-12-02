using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            label3.Text = "Addition of two number : " + add;
            label4.Text = "Substraction of two number : " + sub;
            label5.Text = "Multiplication of two number : " + mul;

           
        }
    }
}
