using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            string age = numericUpDown1.Text;
            
            
            if(textBox1.Text == "" )
            {
                MessageBox.Show("error (enter above information)");
            }
            if (numericUpDown1.Value <= 18)
            {
                MessageBox.Show("Enter age greater than 18");
            }
            else
            {

                sb.Append(" Student Name : " + textBox1.Text + "\n");
                sb.Append(" Student Age : " + numericUpDown1.Value + "\n");
            }

            label4.Text = sb.ToString();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            textBox1.Clear();
            numericUpDown1.Value = 0;
            MessageBox.Show("clear " +sb. ToString());
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
